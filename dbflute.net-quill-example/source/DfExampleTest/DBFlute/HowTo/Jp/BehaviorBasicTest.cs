using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using DfExample.DBFlute.ExBhv;
using Seasar.Framework.Container.Factory;
using Seasar.Framework.Container;
using DfExample.DBFlute.CBean;
using DfExample.DBFlute.ExEntity;
using DfExample.DBFlute.AllCommon.CBean;
using System.Data;
using DfExample.DBFlute.ExDao.PmBean;
using DfExample.DBFlute.ExEntity.Customize;
using MbUnit.Framework;
using DfExample.DBFlute.AllCommon;
using DfExample.DBFlute.AllCommon.Exp;
using Seasar.Quill.Attrs;
using Seasar.Quill.Unit;
using Seasar.Extension.Unit;

namespace DfExample.DBFlute.HowTo.Jp {

    /// <summary>
    /// Behaviorの初級編Example実装。
    /// 
    /// ターゲットは以下の通り：
    ///   o とりあえずDBFluteのDBアクセスのやり方について知りたい方
    ///   o DBFluteで開発するけど今まで全く使ったことのない方
    ///   
    /// コンテンツは以下の通り：
    ///  o 一件検索: selectEntity().
    ///  o チェック付き一件検索(): selectEntityWithDeletedCheck().
    ///  o リスト検索: selectList().
    ///  o カウント検索: selectCount().
    ///  o 一件登録: insert().
    ///  o 排他制御あり一件更新: update().
    ///  o 排他制御なし一件更新: updateNonstrict().
    ///  o 排他制御あり一件削除: delete().
    ///  o 排他制御なし一件削除: deleteNonstrict().
    ///  o 既に削除済みであれば素通りする排他制御なし一件削除: deleteNonstrictIgnoreDeleted().
    ///  o 外だしSQL(OutsideSql)の基本的な検索: outsideSql().SelectList().
    /// </summary>
    [MbUnit.Framework.TestFixture]
    public class BehaviorBasicTest : ContainerTestCase {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected MemberBhv _memberBhv;

        // ===============================================================================
        //                                                                   Entity Select
        //                                                                   =============
        /// <summary>
        /// 一件検索: selectEntity().
        /// 会員IDが'3'である会員を一件検索。
        /// </summary>
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void SelectEntity() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            cb.Query().SetMemberId_Equal(3);

            // ## Act ##
            Member member = _memberBhv.SelectEntity(cb);

            // ## Assert ##
            log(member.ToString());
            assertEquals(3, member.MemberId);

            // [SQL]
            // where MEMBER_ID = 3

            // [Description]
            // A. 存在しないIDを指定した場合はnullが戻る。
            // B. 結果が複数件の場合は例外発生。{EntityDuplicatedException}
        }

        /// <summary>
        /// チェック付き一件検索: selectEntityWithDeletedCheck().
        /// 会員IDが'99999'である会員を一件検索。存在しない場合は例外発生。
        /// </summary>
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void SelectEntityWithDeletedCheck() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            cb.Query().SetMemberId_Equal(99999);

            // ## Act & Assert ##
            try {
                _memberBhv.SelectEntityWithDeletedCheck(cb);
                fail();
            } catch (EntityAlreadyDeletedException e) {
                // OK
                log(e.Message);
            }

            // [SQL]
            // where MEMBER_ACCOUNT = 99999

            // 【Description】
            // A. 存在しないIDを指定した場合は例外発生。{EntityAlreadyDeletedException}
            // B. 結果が複数件の場合は例外発生。{EntityDuplicatedException}
        }

        // ===================================================================================
        //                                                                         List Select
        //                                                                         ===========
        /// <summary>
        /// リスト検索: selectList().
        /// 会員名称が'S'で始まる会員を会員IDの昇順でリスト検索。
        /// </summary>
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void SelectList() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            cb.Query().SetMemberName_PrefixSearch("S");
            cb.Query().AddOrderBy_MemberId_Asc();

            // ## Act ##
            ListResultBean<Member> memberList = _memberBhv.SelectList(cb);

            // ## Assert ##
            assertNotSame(0, memberList.Count);
            foreach (Member member in memberList) {
                log(member.ToString());
                assertTrue(member.MemberName.StartsWith("S"));
            }

            // [Description]
            // A. 検索結果が無い場合は空のList。(nullは戻らない)
            // B. ListResultBeanは、java.util.Listの実装クラス。

            // [SQL]
            // where MEMBER_ACCOUNT like 'S%'
            // order by MEMBER_ID asc
        }

        // ===================================================================================
        //                                                                        Count Select
        //                                                                        ============
        /// <summary>
        /// カウント検索: selectCount().
        /// 会員名称が'S'で始まる会員をカウント検索。
        /// </summary>
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void SelectCount() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            cb.Query().SetMemberName_PrefixSearch("S");

            // ## Act ##
            int count = _memberBhv.SelectCount(cb);

            // ## Assert ##
            assertNotSame(0, count);
            log("count = " + count);
        }

        // ===================================================================================
        //                                                                       Entity Update
        //                                                                       =============
        // -----------------------------------------------------
        //                                                Insert
        //                                                ------
        /// <summary>
        /// 一件登録: insert().
        /// 会員名称が'testName'で、会員アカウントが'testAccount'の正式会員を登録。
        /// </summary>
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void Insert() {
            // ## Arrange ##
            Member member = new Member();
            member.MemberName = "testName";
            member.MemberAccount = "testAccount";
            member.SetMemberStatusCode_Formalized();

            // ## Act ##
            _memberBhv.Insert(member);

            // ## Assert ##
            log(member.MemberId);// Insertしたときに採番されたIDを取得

            // 【Description】
            // A. 自動採番カラム「会員ID」は設定不要。
            // member.MemberId(memberId);
            // 
            // B. 共通カラムは設定不要。
            // member.RegisterDatetime(registerDatetime); 
            // member.UpdateUser(updateUser);
            //   ※事前にDBFluteの「共通カラム自動設定」機能の準備すること
            //   --> dbflute_exampledb/dfprop/commonColumnMap.Dfprop
            // 
            // C. バージョンNOは設定不要。(自動インクリメント)
            // member.VersionNo(versionNo); 
            // 
            // D. 会員ステータスは、タイプセーフに設定。
            // member.ClassifyMemberStatusCodeFormalized();
            //   ※事前にDBFluteの「区分値」機能の準備すること
            //   --> dbflute_exampledb/dfprop/classificationDefinitionMap.Dfprop
            //   --> dbflute_exampledb/dfprop/classificationDeploymentMap.Dfprop
        }

        // -----------------------------------------------------
        //                                                Update
        //                                                ------
        /// <summary>
        /// 排他制御ありの一件更新: update().
        /// 会員ID'3'の会員の名称を'testName'に更新
        /// </summary>
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void Update() {
            // ## Arrange ##
            MemberCB memberCB = new MemberCB();
            memberCB.Query().SetMemberId_Equal(3);
            Member beforeMember = _memberBhv.SelectEntityWithDeletedCheck(memberCB);
            long? versionNo = beforeMember.VersionNo;// 排他制御のためにVersionNoを取得

            Member member = new Member();
            member.MemberId = 3;// 更新したい会員の会員ID
            member.MemberName = "testName";
            member.VersionNo = versionNo;// 排他制御カラムの設定

            // ## Act ##
            _memberBhv.Update(member);

            // ## Assert ##
            Member afterMember = _memberBhv.SelectEntityWithDeletedCheck(memberCB);
            log("onDatabase = " + afterMember.ToString());
            log("onMemory   = " + member.ToString());
            assertEquals(versionNo + 1, member.VersionNo);
            assertEquals(afterMember.VersionNo, member.VersionNo);

            // 【Description】
            // A. Setterが呼び出された項目(と自動設定項目)だけ更新
            // update MEMBER  MEMBER_NAME = 'testName' where ...
            // 
            // B. 共通カラムは設定不要。
            // member.RegisterDatetime(registerDatetime); 
            // member.UpdateUser(updateUser);
            //   ※事前にDBFluteの「共通カラム自動設定」機能の準備すること
            //   --> dbflute_exampledb/dfprop/commonColumnMap.Dfprop
            // 
            // C. 排他制御カラム(VERSION_NOなど)が定義されていない場合は、排他制御なし更新になる。
            // D. すれ違いが発生した場合は例外発生。{EntityAlreadyUpdatedException}
            // E. 存在しないPK値を指定された場合はすれ違いが発生した場合と同じ。
            //    --> 排他制御の仕組み上、区別が付かないため
            // 
            // F. 更新後のEntityにはOnMemoryでインクリメントされたVersionNoが格納される。
        }

        /// <summary>
        /// 排他制御なし一件更新: updateNonstrict().
        /// 会員ID'3'の会員の名称を'testName'に更新
        /// </summary>
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void UpdateNonstrict() {
            // ## Arrange ##
            Member member = new Member();
            member.MemberId = 3;// 更新したい会員の会員ID
            member.MemberName = "testName";

            // ## Act ##
            _memberBhv.UpdateNonstrict(member);

            // ## Assert ##
            MemberCB memberCB = new MemberCB();
            memberCB.Query().SetMemberId_Equal(3);
            Member afterMember = _memberBhv.SelectEntityWithDeletedCheck(memberCB);
            log("onDatabase = " + afterMember.ToString());
            log("onMemory   = " + member.ToString());
            assertNull(member.VersionNo);
            assertNotNull(afterMember.VersionNo);

            // 【Description】
            // A. Setterが呼び出された項目(と自動設定項目)だけ更新
            // update MEMBER  MEMBER_NAME = 'testName' where ...
            // 
            // B. 共通カラムは設定不要。
            // member.RegisterDatetime(registerDatetime); 
            // member.UpdateUser(updateUser);
            //   ※事前にDBFluteの「共通カラム自動設定」機能の準備すること
            //   --> dbflute_exampledb/dfprop/commonColumnMap.Dfprop
            // 
            // C. バージョンNOは設定不要(OnQueryでインクリメント「VERSION_NO = VERSION + 1」)
            // member.VersionNo = versionNo; 
            // 
            // D. 存在しないPK値を指定された場合は例外発生。{EntityAlreadyDeletedException}
            // 
            // E. 更新後のEntityのVersionNoは更新前と全く同じ値がそのまま保持される。
        }

        // -----------------------------------------------------
        //                                                Delete
        //                                                ------
        /// <summary>
        /// 排他制御あり一件削除: delete().
        /// 会員ID'3'の会員を削除。
        /// </summary>
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void Delete() {
            //  ## Arrange ##
            deleteMemberReferrers();// テストのためにReferrerを全部消す

            MemberCB cb = new MemberCB();
            cb.Query().SetMemberId_Equal(3);
            Member beforeMember = _memberBhv.SelectEntityWithDeletedCheck(cb);
            long? versionNo = beforeMember.VersionNo;// 排他制御のためにVersionNoを取得

            Member member = new Member();
            member.MemberId = 3;// 削除したい会員の会員ID
            member.VersionNo = versionNo;// 排他制御カラムの設定

            //  ## Act ##
            _memberBhv.Delete(member);

            //  ## Assert ##
            try {
                _memberBhv.SelectEntityWithDeletedCheck(cb);
                fail();
            } catch (EntityAlreadyDeletedException e) {
                // OK
                log(e.Message);
            }

            // [Description]
            // A. PKとVersionNoのみ評価されるため、他のカラムはnullでもよい。
            // B. すれ違いが発生した場合は例外発生。{EntityAlreadyUpdatedException}
            // C. 存在しないPK値を指定された場合はすれ違いが発生した場合と同じ。
            //    --> 排他制御の仕組み上、区別が付かないため
        }

        /// <summary>
        /// 排他制御なし一件削除: deleteNonstrict(). 
        /// 会員ID'3'の会員を削除。
        /// </summary>
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void DeleteNonstrict() {
            // ## Arrange ##
            deleteMemberReferrers();// テストのためにReferrerを全部消す

            Member member = new Member();
            member.MemberId = 3;// 削除したい会員の会員ID

            // ## Act ##
            _memberBhv.DeleteNonstrict(member);

            // ## Assert ##
            try {
                MemberCB cb = new MemberCB();
                cb.Query().SetMemberId_Equal(3);
                _memberBhv.SelectEntityWithDeletedCheck(cb);
                fail();
            } catch (EntityAlreadyDeletedException e) {
                // OK
                log(e.Message);
            }

            // [Description]
            // A. PKのみ評価されるため、他のカラムはnullでもよい。
            // B. 存在しないPK値を指定された場合は例外発生。{EntityAlreadyDeletedException}
        }

        /// <summary>
        /// 既に削除済みであれば素通りする排他制御なし一件削除: deleteNonstrictIgnoreDeleted().
        /// 存在しない会員ID'99999'の会員を削除。
        /// </summary>
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void DeleteNonstrictIgnoreDeleted() {
            // ## Arrange ##
            Member member = new Member();
            member.MemberId = 99999;// 存在しない会員の会員ID(既に削除されたと仮定)

            // ## Act ##
            _memberBhv.DeleteNonstrictIgnoreDeleted(member);// 例外は発生しない

            // ## Assert ##
            try {
                MemberCB cb = new MemberCB();
                cb.Query().SetMemberId_Equal(99999);
                _memberBhv.SelectEntityWithDeletedCheck(cb);
                fail();
            } catch (EntityAlreadyDeletedException e) {
                // OK
                log(e.Message);
            }
        }

        // ===================================================================================
        //                                                                          OutsideSql
        //                                                                          ==========
        // -----------------------------------------------------
        //                                                  List
        //                                                  ----
        /// <summary>
        /// 外だしSQL(OutsideSql)の基本的な検索: outsideSql().selectList().
        /// 会員名称が'S'で始まる会員をリスト検索。
        /// <pre>
        /// 【手順】
        /// 1. exbhvパッケージにSQLファイルを作成する。
        ///
        /// 　　パッケージ：source配下のxxx.ExBhvパッケージ
        /// 　　ファイル名：[Behaviorクラス名]_[SQLを表現する任意の名称].sql
        ///   　　ex) xxx/ExBhv/MemberBhv_selectSimpleMember.sql
        /// 　　エンコーディング：UTF-8 (デフォルトの設定)
        ///     ビルドアクション：埋め込まれたリソース
        ///
        /// 2. SQLファイルにSQLを2Way-SQLで実装する。
        ///
        /// 　　＜意識すること＞
        /// 　　o 2WaySQLで実装すること
        /// 　　o 必要に応じてSql2Entityのコメントを追記すること
        ///
        /// 　　　ex) CustomizeEntity(戻り値)
        /// 　　　-- #Xxx#
        ///
        /// 　　　ex) ParameterBean(検索条件)
        /// 　　　-- !XxxPmb!
        /// 　　　-- !!String arg1!!
        ///
        /// 　　※戻り値EntityがDomainEntityで事足りるならば、CustomizeEntity(戻り値)を生成する必要はない。
        /// 　　※検索条件がない、もしくは、一つであるならば、ParameterBean(検索条件)を生成する必要はない。
        ///
        /// 3. Sql2Entityを実行する。
        ///
        /// 　　＜生成されるもの＞
        /// 　　A. CustomizeEntity(戻り値)のクラス ※任意
        /// 　　B. ParameterBean(検索条件)のクラス ※任意
        /// 　　C. BehaviorQueryPath(SQLのパス)の定義
        ///
        /// 4. BehaviorのoutsideSql()メソッドを利用してSQLを呼び出す。
        ///
        /// 　　＜指定するもの＞
        /// 　　第一引数(C)：SQLのパス
        /// 　　第二引数(B)：検索条件
        /// 　　Generic (A)：戻り値の型
        ///
        /// 　　※それぞれSql2Entityにて自動生成されたものを利用して指定する。
        /// 　　※検索条件が無い場合は、第二引数にはnullを指定する。
        /// 　　※検索条件が一つの場合は、第二引数には直接その値を指定する。
        /// 　　　→ パラメータコメントの変数名も「pmb.xxx」ではなく「xxx」でよい。
        ///
        /// 【特徴】
        /// o SQLファイル名とプログラム上での指定が食い違うことがない。
        /// 　- SQLファイル名を変更してSql2Entityを実行すると古いPath指定をコンパイルエラーで検知可能
        /// 　- SQLファイル名の[Behaviorクラス名]で存在しないクラスを指定した場合は、Sql2Entityで明示的な例外
        /// o SQLのSelect句定義と戻り値クラスの構造が食い違うことが無い。
        /// o Sql2EntityでSQLの文法的な実行チェックが行われる。
        /// o ParameterBeanでプロパティに空文字「""」が設定されてもそのプロパティの値はnullと同等に扱われる。
        /// </pre>
        /// </summary>
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void OutsideSql_SelectList_selectSimpleMember() {
            // ## Arrange ##
            // SQLのパス
            String path = MemberBhv.PATH_selectSimpleMember;

            // 検索条件
            SimpleMemberPmb pmb = new SimpleMemberPmb();
            pmb.SetMemberName_PrefixSearch("S");

            // ## Act ##
            // SQL実行！
            IList<SimpleMember> memberList =
                _memberBhv.OutsideSql().SelectList<SimpleMember>(path, pmb);

            // ## Assert ##
            assertNotSame(0, memberList.Count);
            log("{SimpleMember}");
            foreach (SimpleMember entity in memberList) {
                int? memberId = entity.MemberId;
                String memberName = entity.MemberName;
                String memberStatusName = entity.MemberStatusName;
                Log("    " + memberId + ", " + memberName + ", " + memberStatusName);
                assertNotNull(memberId);
                assertNotNull(memberName);
                assertNotNull(memberStatusName);
                assertTrue(memberName.StartsWith("S"));
            }
        }

        /// <summary>
        /// 外だしSQL(OutsideSql)の基本的な更新: outsideSql().execute().
        /// 会員名称が'S'で始まる会員を強制退会する。
        /// </summary>
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void OutsideSql_Execute_updateForcedWithdrawal() {
            // ## Arrange ##
            // SQLのパス
            String path = MemberBhv.PATH_updateForcedWithdrawal;

            // 更新条件
            String pmb = "S";

            // ## Act ##
            int updatedCount = _memberBhv.OutsideSql().Execute(path, pmb);
            
            // ## Assert ##
            log("updatedCount=" + updatedCount);
            assertNotSame(0, updatedCount);

            // [Description]
            // A. 手順は外だしSQLによる検索とほぼ同じである。
            //    --> 更新系には戻り値Entityという概念が存在しない。
            // 
            // B. insertでもupdateでもdeleteでも検索でないものは全てexecute()。
            //    --> その他truncateやmergeなど
            // 
            // C. 引数が一つの場合は、ParameterBeanは不要。
            //    --> 第二引数にベタっと値を指定して良い。
            //    --> パラメータコメントは/*pmb.xxx*/ではなく/*pmb*/とする。
            // 
            // D. 排他制御(VERSION_NOの+1含む)と共通カラムの自動設定は実行されない。
            //    --> 必要な場合は自前で処理する必要がある。
            // 
            // E. 主キー以外の条件での更新は必ず外だしSQLで実装する。
            //    --> 削除はConditionBeanによる削除(queryDelete)が可能である。
        }
    }
}

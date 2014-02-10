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

namespace DfExample.DBFlute.Various.Seminar.Jp {

    /// <summary>
    /// </summary>
    [MbUnit.Framework.TestFixture]
    public class BehaviorBasicExercise : ContainerTestCase {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected MemberBhv _memberBhv;

        // ===============================================================================
        //                                                                   Entity Select
        //                                                                   =============
        /// <summary>
        /// 演習Bhv-B1：会員IDが'4'である会員を一件検索。
        /// </summary>
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void Bhv_B1_SelectEntity_by_MemberId_4() {
            // ## Arrange ##

            // ## Act ##

            // ## Assert ##
            // ※コメントアウトを外して、このテストが通ることを確認
            // log(member.ToString());
            // assertEquals(4, member.MemberId);
        }

        /// <summary>
        /// 演習Bhv-B2：会員アカウントが'P'で始まる会員を誕生日の降順で検索。
        /// </summary>
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void Bhv_B2_SelectList_by_MemberAccount_startsWith_P_orderBy_MemberBirthday() {
            // ## Arrange ##

            // ## Act ##

            // ## Assert ##
            // ※コメントアウトを外して、このテストが通ることを確認
            // assertTrue(memberList.Count > 0);
            // foreach (Member member in memberList) {
            //     log(member.MemberAccount + ", " + member.MemberBirthday);
            //     assertTrue(member.MemberAccount.StartsWith("P"));
            // }
        }

        /// <summary>
        /// 演習Bhv-B3：会員を仮会員で登録し、正式会員で更新して、最後に削除。
        /// ※更新と削除は排他制御なしで実装すること
        /// </summary>
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void Bhv_B3_Insert_and_Update_and_Delete() {
            // ## Arrange ##
            // ※コメントアウトを外す
            // Member member = new Member();
            // member.MemberId = 3;
            // member.MemberName = "Billy Joel";
            // member.MemberAccount = "billy";
            // member.ClassifyMemberStatusCodeProvisional();

            // ## Act ##
            // ※ここにInsert/Update/Deleteの処理を記述

            // ## Assert ##
            // ※ログで一覧の処理ができているか確認
            // ※コメントアウトを外して、このテストが通ることを確認
            // MemberCB cb = new MemberCB();
            // cb.Query().SetMemberName_Equal("Billy Joel");
            // try {
            //     _memberBhv.SelectEntityWithDeletedCheck(cb);
            //     fail();
            // } catch (EntityAlreadyDeletedException e) {
            //     // OK
            //     log(e.Message);
            // }
        }

        /// <summary>
        /// 演習Bhv-B4：外だしSQLで会員のリスト検索。
        /// </summary>
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void Bhv_B4_OutsideSql_SelectList() {
            // /* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
            // 検索仕様：
            //   会員の一覧を検索。
            //   取得する項目：「会員ID・会員名称・会員セキュリティ情報.リマインダ質問」
            //   絞込み条件　：「会員名称の前方一致・会員アカウントの前方一致」
            //   並び順　　　：「会員名称の降順」
            //   ※絞込み条件は指定されらものだけが有効になるようにすること
            //   ※全ての絞込み条件が指定されなかったときは全件検索になること
            // 
            // SQLファイル仕様：
            //   o DBFlute/ExBhv配下に「MemberBhv_selectExerciseOutsideSqlBasic.sql」という名前で作成
            //   o ファイルエンコーディングは「UTF-8」
            //   ※Template配下にSQLファイルのテンプレートがあるのでそれを利用
            //   ※ビルドアクションを「埋め込まれたリソース」にすることを忘れずに
            // 
            // 自動生成仕様：
            //   o CustomizeEntityのクラス名は「ExerciseOutsideSqlBasic」
            //   o ParameterBeanのクラス名は「ExerciseOutsideSqlBasicPmb」
            // 
            // 時間が余った人は：
            //   o 取得する項目に「会員セキュリティ情報.リマインダ質問」を追加
            //   o 会員セキュリティを取得しないモードを追加(Pmbでbool値)
            // * * * * * * * * * */

            // ## Arrange ##
            // ※会員名称が'S'で始まる会員を検索

            // ## Act ##

            // ## Assert ##
            // ※コメントアウトを外して、このテストが通ることを確認
            // assertTrue(memberList.Count > 0);
            // foreach (ExerciseOutsideSqlBasicMember member in memberList) {
            //     log(member.MemberId + ", " + member.MemberName + ", " + member.ReminderQuestion);
            //     assertTrue(member.MemberName.StartsWith("S"));
            // }
        }
    }
}

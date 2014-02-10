using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using DfExample.DBFlute.AllCommon.CBean.COption;
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
    public class ConditionBeanMiddleExercise : ContainerTestCase {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected MemberBhv _memberBhv;

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        /// <summary>
        /// 演習CB-M1：1970年より前に生まれた正式会員をリスト検索
        /// </summary>
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void CB_M1_SelectList_query_LessThan() {
            // ## Arrange ##

            // ## Act ##

            // ## Assert ##
            // ※コメントアウトを外して、このテストが通ることを確認
            // assertTrue(memberList.Count > 0);
            // foreach (Member member in memberList) {
            //     log(member.MemberName + ", " + member.MemberBirthday
            //         + ", " + member.MemberStatusCode);
            //     assertNotNull(member.MemberBirthday);
            //     assertTrue(member.MemberBirthday.Value.Year < 1970);
            //     assertTrue(member.IsMemberStatusCodeFormalized);
            // }
        }

        /// <summary>
        /// 演習CB-M2：会員名称が'M'で始まる会員をリスト検索
        /// </summary>
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void CB_M2_SelectList_query_PrefixSearch() {
            // ## Arrange ##

            // ## Act ##

            // ## Assert ##
            // ※コメントアウトを外して、このテストが通ることを確認
            // assertTrue(memberList.Count > 0);
            // foreach (Member member in memberList) {
            //     log(member.MemberId + ", " + member.MemberName);
            //     assertTrue(member.MemberName.StartsWith("M"));
            // }
        }

        /// <summary>
        /// 演習CB-M3：会員アカウントが'Pixy', 'Mijato', 'Suker'の会員をリスト検索
        /// </summary>
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void CB_M3_SelectList_query_InScope() {
            // ## Arrange ##

            // ## Act ##

            // ## Assert ##
            // ※コメントアウトを外して、このテストが通ることを確認
            // assertTrue(memberList.Count > 0);
            // foreach (Member member in memberList) {
            //     log(member.MemberId + ", " + member.MemberAccount);
            //     assertTrue(member.MemberAccount.Equals("Pixy")
            //         || member.MemberAccount.Equals("Mijato")
            //         || member.MemberAccount.Equals("Suker"));
            // }
        }

        /// <summary>
        /// 演習CB-M4：会員名称に'vi'が含まれる会員をリスト検索
        /// ※スラッシュ'/'でエスケープすること
        /// </summary>
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void CB_M4_SelectList_query_LikeSearch() {
            // ## Arrange ##

            // ## Act ##

            // ## Assert ##
            // ※ログで曖昧検索がエスケープされていることを確認
            // ※コメントアウトを外して、このテストが通ることを確認
            // assertTrue(memberList.Count > 0);
            // foreach (Member member in memberList) {
            //     log(member.MemberId + ", " + member.MemberName);
            //     assertTrue(member.MemberName.Contains("vi"));
            // }
        }

        /// <summary>
        /// 演習CB-M5：2000円以上の購入をしたことのある会員をリスト検索
        /// </summary>
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void CB_M5_SelectList_query_ExistsSubQuery() {
            // ## Arrange ##

            // ## Act ##

            // ## Assert ##
            // ※ログで曖昧検索がエスケープされていることを確認
            // ※コメントアウトを外して、このテストが通ることを確認
            // assertTrue(memberList.Count > 0);
            // _memberBhv.LoadPurchaseList(memberList, delegate(PurchaseCB subCB) {
            //     subCB.Query().SetPurchasePrice_GreaterEqual(2000);
            // });
            // foreach (Member member in memberList) {
            //     log(member.MemberId + ", " + member.MemberName + ", " + member.PurchaseList.Count);
            //     assertTrue(member.PurchaseList.Count > 0);
            // }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
        /// <summary>
        /// 演習CB-M6：会員ステータスが仮会員もしくは会員名称が'S'で始まる会員をリスト検索
        /// ※会員ステータスを取得すること
        /// ※会員ステータスの表示順の昇順、会員名称の昇順で並べること
        /// </summary>
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void CB_M6_SelectList_Union() {
            // ## Arrange ##

            // ## Act ##

            // ## Assert ##
            // ※ログで曖昧検索がエスケープされていることを確認
            // ※コメントアウトを外して、このテストが通ることを確認
            // assertTrue(memberList.Count > 0);
            // foreach (Member member in memberList) {
            //     assertNotNull(member.MemberStatus);
            //     log(member.MemberId + ", " + member.MemberName
            //         + ", " + member.MemberStatus.MemberStatusName);
            //     assertTrue(member.IsMemberStatusCodeProvisional || member.MemberName.StartsWith("S"));
            // }
        }

        // ===============================================================================
        //                                                                          Paging
        //                                                                          ======
        /// <summary>
        /// 演習CB-M7：１ページ５件で２ページ目(６件目から１０件目)の会員を検索
        /// ※会員IDの昇順で並べること
        /// </summary>
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void CB_M7_SelectList_Paging() {
            // ## Arrange ##

            // ## Act ##

            // ## Assert ##
            // ※ログで曖昧検索がエスケープされていることを確認
            // ※コメントアウトを外して、このテストが通ることを確認
            // assertTrue(memberList.Count == 5);
            // foreach (Member member in memberList) {
            //     log(member.MemberId + ", " + member.MemberName);
            //     assertTrue(member.MemberId > 5);
            // }
        }

        // ===============================================================================
        //                                                                             All
        //                                                                             ===
        /// <summary>
        /// 演習CB-M99：複雑な条件の会員を検索
        /// </summary>
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void CB_M99_SelectList_Complex() {
            // 取得関連テーブル：
            //   会員ステータス・会員退会情報・退会理由
            // 
            // 絞込み条件：
            //   A. 会員ステータスが退会である、かつ、購入情報が存在する
            //        もしくは
            //   B. モバイルでログインしたことのない会員
            // 
            // ## Arrange ##

            // ## Act ##

            // ## Assert ##
            // ※ログで想定どおりのSQLであること確認
        }

    }
}

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
    public class ConditionBeanBasicExercise : ContainerTestCase {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected MemberBhv _memberBhv;

        // ===============================================================================
        //                                                                     SetupSelect
        //                                                                     ===========
        /// <summary>
        /// 演習CB-B1：会員ステータスと会員セキュリティ情報を取得する会員のリスト検索。
        /// </summary>
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void CB_B1_SelectList_with_MemberStatus_MemberSecurity() {
            // ## Arrange ##

            // ## Act ##

            // ## Assert ##
            // ※コメントアウトを外して、このテストが通ることを確認
            // assertTrue(memberList.Count > 0);
            // foreach (Member member in memberList) {
            //     log(member.ToString());
            //     assertNotNull(member.MemberStatus);
            //     assertNotNull(member.MemberSecurityAsOne);
            // }
        }

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        /// <summary>
        /// 演習CB-B2：会員アカウントが'Pixy'の会員を一件検索。
        /// </summary>
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void CB_B2_SelectEntity_query_MemberAccount_Equal_Pixy() {
            // ## Arrange ##

            // ## Act ##

            // ## Assert ##
            // ※コメントアウトを外して、このテストが通ることを確認
            // assertNotNull(member);
            // assertEquals("Pixy", member.MemberAccount);
        }

        /// <summary>
        /// 演習CB-B3：会員セキュリティ.ログインパスワードが'j'で始まる会員をリスト検索。
        /// ※会員セキュリティを取得すること
        /// </summary>
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void CB_B3_SelectList_query_MemberAccount_Equal_Pixy() {
            // ## Arrange ##

            // ## Act ##

            // ## Assert ##
            // ※コメントアウトを外して、このテストが通ることを確認
            // assertTrue(memberList.Count > 0);
            // foreach (Member member in memberList) {
            //     log(member.ToString());
            //     assertNotNull(member.MemberSecurityAsOne);
            //     log("pwd=" + member.MemberSecurityAsOne.LoginPassword);
            //     assertTrue(member.MemberSecurityAsOne.LoginPassword.StartsWith("j"));
            // }
        }

        /// <summary>
        /// 演習CB-B4：会員ステータス.表示順の昇順と正式会員日時の降順と会員IDの昇順のリスト検索。
        /// ※会員ステータスを取得すること
        /// </summary>
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void CB_B4_SelectList_orderBy_Various() {
            // ## Arrange ##

            // ## Act ##

            // ## Assert ##
            // ※コメントアウトを外して、このテストが通ることを確認
            //   (ログで順番を確認)
            // assertTrue(memberList.Count > 0);
            // foreach (Member member in memberList) {
            //     log(member.MemberStatus.MemberStatusName + "(" + member.MemberStatus.DisplayOrder + ")"
            //         + ", " + member.MemberFormalizedDatetime
            //         + ", " + member.MemberId);
            // }
        }
    }
}

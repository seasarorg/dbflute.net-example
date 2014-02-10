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
        /// ���KCB-B1�F����X�e�[�^�X�Ɖ���Z�L�����e�B�����擾�������̃��X�g�����B
        /// </summary>
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void CB_B1_SelectList_with_MemberStatus_MemberSecurity() {
            // ## Arrange ##

            // ## Act ##

            // ## Assert ##
            // ���R�����g�A�E�g���O���āA���̃e�X�g���ʂ邱�Ƃ��m�F
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
        /// ���KCB-B2�F����A�J�E���g��'Pixy'�̉�����ꌏ�����B
        /// </summary>
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void CB_B2_SelectEntity_query_MemberAccount_Equal_Pixy() {
            // ## Arrange ##

            // ## Act ##

            // ## Assert ##
            // ���R�����g�A�E�g���O���āA���̃e�X�g���ʂ邱�Ƃ��m�F
            // assertNotNull(member);
            // assertEquals("Pixy", member.MemberAccount);
        }

        /// <summary>
        /// ���KCB-B3�F����Z�L�����e�B.���O�C���p�X���[�h��'j'�Ŏn�܂��������X�g�����B
        /// ������Z�L�����e�B���擾���邱��
        /// </summary>
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void CB_B3_SelectList_query_MemberAccount_Equal_Pixy() {
            // ## Arrange ##

            // ## Act ##

            // ## Assert ##
            // ���R�����g�A�E�g���O���āA���̃e�X�g���ʂ邱�Ƃ��m�F
            // assertTrue(memberList.Count > 0);
            // foreach (Member member in memberList) {
            //     log(member.ToString());
            //     assertNotNull(member.MemberSecurityAsOne);
            //     log("pwd=" + member.MemberSecurityAsOne.LoginPassword);
            //     assertTrue(member.MemberSecurityAsOne.LoginPassword.StartsWith("j"));
            // }
        }

        /// <summary>
        /// ���KCB-B4�F����X�e�[�^�X.�\�����̏����Ɛ�����������̍~���Ɖ��ID�̏����̃��X�g�����B
        /// ������X�e�[�^�X���擾���邱��
        /// </summary>
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void CB_B4_SelectList_orderBy_Various() {
            // ## Arrange ##

            // ## Act ##

            // ## Assert ##
            // ���R�����g�A�E�g���O���āA���̃e�X�g���ʂ邱�Ƃ��m�F
            //   (���O�ŏ��Ԃ��m�F)
            // assertTrue(memberList.Count > 0);
            // foreach (Member member in memberList) {
            //     log(member.MemberStatus.MemberStatusName + "(" + member.MemberStatus.DisplayOrder + ")"
            //         + ", " + member.MemberFormalizedDatetime
            //         + ", " + member.MemberId);
            // }
        }
    }
}

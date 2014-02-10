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
        /// ���KCB-M1�F1970�N���O�ɐ��܂ꂽ������������X�g����
        /// </summary>
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void CB_M1_SelectList_query_LessThan() {
            // ## Arrange ##

            // ## Act ##

            // ## Assert ##
            // ���R�����g�A�E�g���O���āA���̃e�X�g���ʂ邱�Ƃ��m�F
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
        /// ���KCB-M2�F������̂�'M'�Ŏn�܂��������X�g����
        /// </summary>
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void CB_M2_SelectList_query_PrefixSearch() {
            // ## Arrange ##

            // ## Act ##

            // ## Assert ##
            // ���R�����g�A�E�g���O���āA���̃e�X�g���ʂ邱�Ƃ��m�F
            // assertTrue(memberList.Count > 0);
            // foreach (Member member in memberList) {
            //     log(member.MemberId + ", " + member.MemberName);
            //     assertTrue(member.MemberName.StartsWith("M"));
            // }
        }

        /// <summary>
        /// ���KCB-M3�F����A�J�E���g��'Pixy', 'Mijato', 'Suker'�̉�������X�g����
        /// </summary>
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void CB_M3_SelectList_query_InScope() {
            // ## Arrange ##

            // ## Act ##

            // ## Assert ##
            // ���R�����g�A�E�g���O���āA���̃e�X�g���ʂ邱�Ƃ��m�F
            // assertTrue(memberList.Count > 0);
            // foreach (Member member in memberList) {
            //     log(member.MemberId + ", " + member.MemberAccount);
            //     assertTrue(member.MemberAccount.Equals("Pixy")
            //         || member.MemberAccount.Equals("Mijato")
            //         || member.MemberAccount.Equals("Suker"));
            // }
        }

        /// <summary>
        /// ���KCB-M4�F������̂�'vi'���܂܂���������X�g����
        /// ���X���b�V��'/'�ŃG�X�P�[�v���邱��
        /// </summary>
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void CB_M4_SelectList_query_LikeSearch() {
            // ## Arrange ##

            // ## Act ##

            // ## Assert ##
            // �����O�ŞB���������G�X�P�[�v����Ă��邱�Ƃ��m�F
            // ���R�����g�A�E�g���O���āA���̃e�X�g���ʂ邱�Ƃ��m�F
            // assertTrue(memberList.Count > 0);
            // foreach (Member member in memberList) {
            //     log(member.MemberId + ", " + member.MemberName);
            //     assertTrue(member.MemberName.Contains("vi"));
            // }
        }

        /// <summary>
        /// ���KCB-M5�F2000�~�ȏ�̍w�����������Ƃ̂����������X�g����
        /// </summary>
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void CB_M5_SelectList_query_ExistsSubQuery() {
            // ## Arrange ##

            // ## Act ##

            // ## Assert ##
            // �����O�ŞB���������G�X�P�[�v����Ă��邱�Ƃ��m�F
            // ���R�����g�A�E�g���O���āA���̃e�X�g���ʂ邱�Ƃ��m�F
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
        /// ���KCB-M6�F����X�e�[�^�X��������������͉�����̂�'S'�Ŏn�܂��������X�g����
        /// ������X�e�[�^�X���擾���邱��
        /// ������X�e�[�^�X�̕\�����̏����A������̂̏����ŕ��ׂ邱��
        /// </summary>
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void CB_M6_SelectList_Union() {
            // ## Arrange ##

            // ## Act ##

            // ## Assert ##
            // �����O�ŞB���������G�X�P�[�v����Ă��邱�Ƃ��m�F
            // ���R�����g�A�E�g���O���āA���̃e�X�g���ʂ邱�Ƃ��m�F
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
        /// ���KCB-M7�F�P�y�[�W�T���łQ�y�[�W��(�U���ڂ���P�O����)�̉��������
        /// �����ID�̏����ŕ��ׂ邱��
        /// </summary>
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void CB_M7_SelectList_Paging() {
            // ## Arrange ##

            // ## Act ##

            // ## Assert ##
            // �����O�ŞB���������G�X�P�[�v����Ă��邱�Ƃ��m�F
            // ���R�����g�A�E�g���O���āA���̃e�X�g���ʂ邱�Ƃ��m�F
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
        /// ���KCB-M99�F���G�ȏ����̉��������
        /// </summary>
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void CB_M99_SelectList_Complex() {
            // �擾�֘A�e�[�u���F
            //   ����X�e�[�^�X�E����މ���E�މ�R
            // 
            // �i���ݏ����F
            //   A. ����X�e�[�^�X���މ�ł���A���A�w����񂪑��݂���
            //        ��������
            //   B. ���o�C���Ń��O�C���������Ƃ̂Ȃ����
            // 
            // ## Arrange ##

            // ## Act ##

            // ## Assert ##
            // �����O�őz��ǂ����SQL�ł��邱�Ɗm�F
        }

    }
}

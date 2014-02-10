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
        /// ���KBhv-B1�F���ID��'4'�ł��������ꌏ�����B
        /// </summary>
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void Bhv_B1_SelectEntity_by_MemberId_4() {
            // ## Arrange ##

            // ## Act ##

            // ## Assert ##
            // ���R�����g�A�E�g���O���āA���̃e�X�g���ʂ邱�Ƃ��m�F
            // log(member.ToString());
            // assertEquals(4, member.MemberId);
        }

        /// <summary>
        /// ���KBhv-B2�F����A�J�E���g��'P'�Ŏn�܂�����a�����̍~���Ō����B
        /// </summary>
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void Bhv_B2_SelectList_by_MemberAccount_startsWith_P_orderBy_MemberBirthday() {
            // ## Arrange ##

            // ## Act ##

            // ## Assert ##
            // ���R�����g�A�E�g���O���āA���̃e�X�g���ʂ邱�Ƃ��m�F
            // assertTrue(memberList.Count > 0);
            // foreach (Member member in memberList) {
            //     log(member.MemberAccount + ", " + member.MemberBirthday);
            //     assertTrue(member.MemberAccount.StartsWith("P"));
            // }
        }

        /// <summary>
        /// ���KBhv-B3�F�����������œo�^���A��������ōX�V���āA�Ō�ɍ폜�B
        /// ���X�V�ƍ폜�͔r������Ȃ��Ŏ������邱��
        /// </summary>
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void Bhv_B3_Insert_and_Update_and_Delete() {
            // ## Arrange ##
            // ���R�����g�A�E�g���O��
            // Member member = new Member();
            // member.MemberId = 3;
            // member.MemberName = "Billy Joel";
            // member.MemberAccount = "billy";
            // member.ClassifyMemberStatusCodeProvisional();

            // ## Act ##
            // ��������Insert/Update/Delete�̏������L�q

            // ## Assert ##
            // �����O�ňꗗ�̏������ł��Ă��邩�m�F
            // ���R�����g�A�E�g���O���āA���̃e�X�g���ʂ邱�Ƃ��m�F
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
        /// ���KBhv-B4�F�O����SQL�ŉ���̃��X�g�����B
        /// </summary>
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void Bhv_B4_OutsideSql_SelectList() {
            // /* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
            // �����d�l�F
            //   ����̈ꗗ�������B
            //   �擾���鍀�ځF�u���ID�E������́E����Z�L�����e�B���.���}�C���_����v
            //   �i���ݏ����@�F�u������̂̑O����v�E����A�J�E���g�̑O����v�v
            //   ���я��@�@�@�F�u������̂̍~���v
            //   ���i���ݏ����͎w�肳�����̂������L���ɂȂ�悤�ɂ��邱��
            //   ���S�Ă̍i���ݏ������w�肳��Ȃ������Ƃ��͑S�������ɂȂ邱��
            // 
            // SQL�t�@�C���d�l�F
            //   o DBFlute/ExBhv�z���ɁuMemberBhv_selectExerciseOutsideSqlBasic.sql�v�Ƃ������O�ō쐬
            //   o �t�@�C���G���R�[�f�B���O�́uUTF-8�v
            //   ��Template�z����SQL�t�@�C���̃e���v���[�g������̂ł���𗘗p
            //   ���r���h�A�N�V�������u���ߍ��܂ꂽ���\�[�X�v�ɂ��邱�Ƃ�Y�ꂸ��
            // 
            // ���������d�l�F
            //   o CustomizeEntity�̃N���X���́uExerciseOutsideSqlBasic�v
            //   o ParameterBean�̃N���X���́uExerciseOutsideSqlBasicPmb�v
            // 
            // ���Ԃ��]�����l�́F
            //   o �擾���鍀�ڂɁu����Z�L�����e�B���.���}�C���_����v��ǉ�
            //   o ����Z�L�����e�B���擾���Ȃ����[�h��ǉ�(Pmb��bool�l)
            // * * * * * * * * * */

            // ## Arrange ##
            // ��������̂�'S'�Ŏn�܂���������

            // ## Act ##

            // ## Assert ##
            // ���R�����g�A�E�g���O���āA���̃e�X�g���ʂ邱�Ƃ��m�F
            // assertTrue(memberList.Count > 0);
            // foreach (ExerciseOutsideSqlBasicMember member in memberList) {
            //     log(member.MemberId + ", " + member.MemberName + ", " + member.ReminderQuestion);
            //     assertTrue(member.MemberName.StartsWith("S"));
            // }
        }
    }
}

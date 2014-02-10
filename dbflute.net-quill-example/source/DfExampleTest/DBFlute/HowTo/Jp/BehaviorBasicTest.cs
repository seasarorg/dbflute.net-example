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
    /// Behavior�̏�����Example�����B
    /// 
    /// �^�[�Q�b�g�͈ȉ��̒ʂ�F
    ///   o �Ƃ肠����DBFlute��DB�A�N�Z�X�̂����ɂ��Ēm�肽����
    ///   o DBFlute�ŊJ�����邯�Ǎ��܂őS���g�������Ƃ̂Ȃ���
    ///   
    /// �R���e���c�͈ȉ��̒ʂ�F
    ///  o �ꌏ����: selectEntity().
    ///  o �`�F�b�N�t���ꌏ����(): selectEntityWithDeletedCheck().
    ///  o ���X�g����: selectList().
    ///  o �J�E���g����: selectCount().
    ///  o �ꌏ�o�^: insert().
    ///  o �r�����䂠��ꌏ�X�V: update().
    ///  o �r������Ȃ��ꌏ�X�V: updateNonstrict().
    ///  o �r�����䂠��ꌏ�폜: delete().
    ///  o �r������Ȃ��ꌏ�폜: deleteNonstrict().
    ///  o ���ɍ폜�ς݂ł���Αf�ʂ肷��r������Ȃ��ꌏ�폜: deleteNonstrictIgnoreDeleted().
    ///  o �O����SQL(OutsideSql)�̊�{�I�Ȍ���: outsideSql().SelectList().
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
        /// �ꌏ����: selectEntity().
        /// ���ID��'3'�ł��������ꌏ�����B
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
            // A. ���݂��Ȃ�ID���w�肵���ꍇ��null���߂�B
            // B. ���ʂ��������̏ꍇ�͗�O�����B{EntityDuplicatedException}
        }

        /// <summary>
        /// �`�F�b�N�t���ꌏ����: selectEntityWithDeletedCheck().
        /// ���ID��'99999'�ł��������ꌏ�����B���݂��Ȃ��ꍇ�͗�O�����B
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

            // �yDescription�z
            // A. ���݂��Ȃ�ID���w�肵���ꍇ�͗�O�����B{EntityAlreadyDeletedException}
            // B. ���ʂ��������̏ꍇ�͗�O�����B{EntityDuplicatedException}
        }

        // ===================================================================================
        //                                                                         List Select
        //                                                                         ===========
        /// <summary>
        /// ���X�g����: selectList().
        /// ������̂�'S'�Ŏn�܂��������ID�̏����Ń��X�g�����B
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
            // A. �������ʂ������ꍇ�͋��List�B(null�͖߂�Ȃ�)
            // B. ListResultBean�́Ajava.util.List�̎����N���X�B

            // [SQL]
            // where MEMBER_ACCOUNT like 'S%'
            // order by MEMBER_ID asc
        }

        // ===================================================================================
        //                                                                        Count Select
        //                                                                        ============
        /// <summary>
        /// �J�E���g����: selectCount().
        /// ������̂�'S'�Ŏn�܂������J�E���g�����B
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
        /// �ꌏ�o�^: insert().
        /// ������̂�'testName'�ŁA����A�J�E���g��'testAccount'�̐��������o�^�B
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
            log(member.MemberId);// Insert�����Ƃ��ɍ̔Ԃ��ꂽID���擾

            // �yDescription�z
            // A. �����̔ԃJ�����u���ID�v�͐ݒ�s�v�B
            // member.MemberId(memberId);
            // 
            // B. ���ʃJ�����͐ݒ�s�v�B
            // member.RegisterDatetime(registerDatetime); 
            // member.UpdateUser(updateUser);
            //   �����O��DBFlute�́u���ʃJ���������ݒ�v�@�\�̏������邱��
            //   --> dbflute_exampledb/dfprop/commonColumnMap.Dfprop
            // 
            // C. �o�[�W����NO�͐ݒ�s�v�B(�����C���N�������g)
            // member.VersionNo(versionNo); 
            // 
            // D. ����X�e�[�^�X�́A�^�C�v�Z�[�t�ɐݒ�B
            // member.ClassifyMemberStatusCodeFormalized();
            //   �����O��DBFlute�́u�敪�l�v�@�\�̏������邱��
            //   --> dbflute_exampledb/dfprop/classificationDefinitionMap.Dfprop
            //   --> dbflute_exampledb/dfprop/classificationDeploymentMap.Dfprop
        }

        // -----------------------------------------------------
        //                                                Update
        //                                                ------
        /// <summary>
        /// �r�����䂠��̈ꌏ�X�V: update().
        /// ���ID'3'�̉���̖��̂�'testName'�ɍX�V
        /// </summary>
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void Update() {
            // ## Arrange ##
            MemberCB memberCB = new MemberCB();
            memberCB.Query().SetMemberId_Equal(3);
            Member beforeMember = _memberBhv.SelectEntityWithDeletedCheck(memberCB);
            long? versionNo = beforeMember.VersionNo;// �r������̂��߂�VersionNo���擾

            Member member = new Member();
            member.MemberId = 3;// �X�V����������̉��ID
            member.MemberName = "testName";
            member.VersionNo = versionNo;// �r������J�����̐ݒ�

            // ## Act ##
            _memberBhv.Update(member);

            // ## Assert ##
            Member afterMember = _memberBhv.SelectEntityWithDeletedCheck(memberCB);
            log("onDatabase = " + afterMember.ToString());
            log("onMemory   = " + member.ToString());
            assertEquals(versionNo + 1, member.VersionNo);
            assertEquals(afterMember.VersionNo, member.VersionNo);

            // �yDescription�z
            // A. Setter���Ăяo���ꂽ����(�Ǝ����ݒ荀��)�����X�V
            // update MEMBER  MEMBER_NAME = 'testName' where ...
            // 
            // B. ���ʃJ�����͐ݒ�s�v�B
            // member.RegisterDatetime(registerDatetime); 
            // member.UpdateUser(updateUser);
            //   �����O��DBFlute�́u���ʃJ���������ݒ�v�@�\�̏������邱��
            //   --> dbflute_exampledb/dfprop/commonColumnMap.Dfprop
            // 
            // C. �r������J����(VERSION_NO�Ȃ�)����`����Ă��Ȃ��ꍇ�́A�r������Ȃ��X�V�ɂȂ�B
            // D. ����Ⴂ�����������ꍇ�͗�O�����B{EntityAlreadyUpdatedException}
            // E. ���݂��Ȃ�PK�l���w�肳�ꂽ�ꍇ�͂���Ⴂ�����������ꍇ�Ɠ����B
            //    --> �r������̎d�g�ݏ�A��ʂ��t���Ȃ�����
            // 
            // F. �X�V���Entity�ɂ�OnMemory�ŃC���N�������g���ꂽVersionNo���i�[�����B
        }

        /// <summary>
        /// �r������Ȃ��ꌏ�X�V: updateNonstrict().
        /// ���ID'3'�̉���̖��̂�'testName'�ɍX�V
        /// </summary>
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void UpdateNonstrict() {
            // ## Arrange ##
            Member member = new Member();
            member.MemberId = 3;// �X�V����������̉��ID
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

            // �yDescription�z
            // A. Setter���Ăяo���ꂽ����(�Ǝ����ݒ荀��)�����X�V
            // update MEMBER  MEMBER_NAME = 'testName' where ...
            // 
            // B. ���ʃJ�����͐ݒ�s�v�B
            // member.RegisterDatetime(registerDatetime); 
            // member.UpdateUser(updateUser);
            //   �����O��DBFlute�́u���ʃJ���������ݒ�v�@�\�̏������邱��
            //   --> dbflute_exampledb/dfprop/commonColumnMap.Dfprop
            // 
            // C. �o�[�W����NO�͐ݒ�s�v(OnQuery�ŃC���N�������g�uVERSION_NO = VERSION + 1�v)
            // member.VersionNo = versionNo; 
            // 
            // D. ���݂��Ȃ�PK�l���w�肳�ꂽ�ꍇ�͗�O�����B{EntityAlreadyDeletedException}
            // 
            // E. �X�V���Entity��VersionNo�͍X�V�O�ƑS�������l�����̂܂ܕێ������B
        }

        // -----------------------------------------------------
        //                                                Delete
        //                                                ------
        /// <summary>
        /// �r�����䂠��ꌏ�폜: delete().
        /// ���ID'3'�̉�����폜�B
        /// </summary>
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void Delete() {
            //  ## Arrange ##
            deleteMemberReferrers();// �e�X�g�̂��߂�Referrer��S������

            MemberCB cb = new MemberCB();
            cb.Query().SetMemberId_Equal(3);
            Member beforeMember = _memberBhv.SelectEntityWithDeletedCheck(cb);
            long? versionNo = beforeMember.VersionNo;// �r������̂��߂�VersionNo���擾

            Member member = new Member();
            member.MemberId = 3;// �폜����������̉��ID
            member.VersionNo = versionNo;// �r������J�����̐ݒ�

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
            // A. PK��VersionNo�̂ݕ]������邽�߁A���̃J������null�ł��悢�B
            // B. ����Ⴂ�����������ꍇ�͗�O�����B{EntityAlreadyUpdatedException}
            // C. ���݂��Ȃ�PK�l���w�肳�ꂽ�ꍇ�͂���Ⴂ�����������ꍇ�Ɠ����B
            //    --> �r������̎d�g�ݏ�A��ʂ��t���Ȃ�����
        }

        /// <summary>
        /// �r������Ȃ��ꌏ�폜: deleteNonstrict(). 
        /// ���ID'3'�̉�����폜�B
        /// </summary>
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void DeleteNonstrict() {
            // ## Arrange ##
            deleteMemberReferrers();// �e�X�g�̂��߂�Referrer��S������

            Member member = new Member();
            member.MemberId = 3;// �폜����������̉��ID

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
            // A. PK�̂ݕ]������邽�߁A���̃J������null�ł��悢�B
            // B. ���݂��Ȃ�PK�l���w�肳�ꂽ�ꍇ�͗�O�����B{EntityAlreadyDeletedException}
        }

        /// <summary>
        /// ���ɍ폜�ς݂ł���Αf�ʂ肷��r������Ȃ��ꌏ�폜: deleteNonstrictIgnoreDeleted().
        /// ���݂��Ȃ����ID'99999'�̉�����폜�B
        /// </summary>
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void DeleteNonstrictIgnoreDeleted() {
            // ## Arrange ##
            Member member = new Member();
            member.MemberId = 99999;// ���݂��Ȃ�����̉��ID(���ɍ폜���ꂽ�Ɖ���)

            // ## Act ##
            _memberBhv.DeleteNonstrictIgnoreDeleted(member);// ��O�͔������Ȃ�

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
        /// �O����SQL(OutsideSql)�̊�{�I�Ȍ���: outsideSql().selectList().
        /// ������̂�'S'�Ŏn�܂��������X�g�����B
        /// <pre>
        /// �y�菇�z
        /// 1. exbhv�p�b�P�[�W��SQL�t�@�C�����쐬����B
        ///
        /// �@�@�p�b�P�[�W�Fsource�z����xxx.ExBhv�p�b�P�[�W
        /// �@�@�t�@�C�����F[Behavior�N���X��]_[SQL��\������C�ӂ̖���].sql
        ///   �@�@ex) xxx/ExBhv/MemberBhv_selectSimpleMember.sql
        /// �@�@�G���R�[�f�B���O�FUTF-8 (�f�t�H���g�̐ݒ�)
        ///     �r���h�A�N�V�����F���ߍ��܂ꂽ���\�[�X
        ///
        /// 2. SQL�t�@�C����SQL��2Way-SQL�Ŏ�������B
        ///
        /// �@�@���ӎ����邱�Ɓ�
        /// �@�@o 2WaySQL�Ŏ������邱��
        /// �@�@o �K�v�ɉ�����Sql2Entity�̃R�����g��ǋL���邱��
        ///
        /// �@�@�@ex) CustomizeEntity(�߂�l)
        /// �@�@�@-- #Xxx#
        ///
        /// �@�@�@ex) ParameterBean(��������)
        /// �@�@�@-- !XxxPmb!
        /// �@�@�@-- !!String arg1!!
        ///
        /// �@�@���߂�lEntity��DomainEntity�Ŏ������Ȃ�΁ACustomizeEntity(�߂�l)�𐶐�����K�v�͂Ȃ��B
        /// �@�@�������������Ȃ��A�������́A��ł���Ȃ�΁AParameterBean(��������)�𐶐�����K�v�͂Ȃ��B
        ///
        /// 3. Sql2Entity�����s����B
        ///
        /// �@�@�������������́�
        /// �@�@A. CustomizeEntity(�߂�l)�̃N���X ���C��
        /// �@�@B. ParameterBean(��������)�̃N���X ���C��
        /// �@�@C. BehaviorQueryPath(SQL�̃p�X)�̒�`
        ///
        /// 4. Behavior��outsideSql()���\�b�h�𗘗p����SQL���Ăяo���B
        ///
        /// �@�@���w�肷����́�
        /// �@�@������(C)�FSQL�̃p�X
        /// �@�@������(B)�F��������
        /// �@�@Generic (A)�F�߂�l�̌^
        ///
        /// �@�@�����ꂼ��Sql2Entity�ɂĎ����������ꂽ���̂𗘗p���Ďw�肷��B
        /// �@�@�����������������ꍇ�́A�������ɂ�null���w�肷��B
        /// �@�@��������������̏ꍇ�́A�������ɂ͒��ڂ��̒l���w�肷��B
        /// �@�@�@�� �p�����[�^�R�����g�̕ϐ������upmb.xxx�v�ł͂Ȃ��uxxx�v�ł悢�B
        ///
        /// �y�����z
        /// o SQL�t�@�C�����ƃv���O������ł̎w�肪�H���Ⴄ���Ƃ��Ȃ��B
        /// �@- SQL�t�@�C������ύX����Sql2Entity�����s����ƌÂ�Path�w����R���p�C���G���[�Ō��m�\
        /// �@- SQL�t�@�C������[Behavior�N���X��]�ő��݂��Ȃ��N���X���w�肵���ꍇ�́ASql2Entity�Ŗ����I�ȗ�O
        /// o SQL��Select���`�Ɩ߂�l�N���X�̍\�����H���Ⴄ���Ƃ������B
        /// o Sql2Entity��SQL�̕��@�I�Ȏ��s�`�F�b�N���s����B
        /// o ParameterBean�Ńv���p�e�B�ɋ󕶎��u""�v���ݒ肳��Ă����̃v���p�e�B�̒l��null�Ɠ����Ɉ�����B
        /// </pre>
        /// </summary>
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void OutsideSql_SelectList_selectSimpleMember() {
            // ## Arrange ##
            // SQL�̃p�X
            String path = MemberBhv.PATH_selectSimpleMember;

            // ��������
            SimpleMemberPmb pmb = new SimpleMemberPmb();
            pmb.SetMemberName_PrefixSearch("S");

            // ## Act ##
            // SQL���s�I
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
        /// �O����SQL(OutsideSql)�̊�{�I�ȍX�V: outsideSql().execute().
        /// ������̂�'S'�Ŏn�܂����������މ��B
        /// </summary>
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void OutsideSql_Execute_updateForcedWithdrawal() {
            // ## Arrange ##
            // SQL�̃p�X
            String path = MemberBhv.PATH_updateForcedWithdrawal;

            // �X�V����
            String pmb = "S";

            // ## Act ##
            int updatedCount = _memberBhv.OutsideSql().Execute(path, pmb);
            
            // ## Assert ##
            log("updatedCount=" + updatedCount);
            assertNotSame(0, updatedCount);

            // [Description]
            // A. �菇�͊O����SQL�ɂ�錟���Ƃقړ����ł���B
            //    --> �X�V�n�ɂ͖߂�lEntity�Ƃ����T�O�����݂��Ȃ��B
            // 
            // B. insert�ł�update�ł�delete�ł������łȂ����̂͑S��execute()�B
            //    --> ���̑�truncate��merge�Ȃ�
            // 
            // C. ��������̏ꍇ�́AParameterBean�͕s�v�B
            //    --> �������Ƀx�^���ƒl���w�肵�ėǂ��B
            //    --> �p�����[�^�R�����g��/*pmb.xxx*/�ł͂Ȃ�/*pmb*/�Ƃ���B
            // 
            // D. �r������(VERSION_NO��+1�܂�)�Ƌ��ʃJ�����̎����ݒ�͎��s����Ȃ��B
            //    --> �K�v�ȏꍇ�͎��O�ŏ�������K�v������B
            // 
            // E. ��L�[�ȊO�̏����ł̍X�V�͕K���O����SQL�Ŏ�������B
            //    --> �폜��ConditionBean�ɂ��폜(queryDelete)���\�ł���B
        }
    }
}

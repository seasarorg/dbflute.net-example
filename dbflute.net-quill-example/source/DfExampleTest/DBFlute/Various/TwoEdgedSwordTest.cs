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

namespace DfExample.DBFlute.Various
{
    /// <summary>
    /// �u���n�̐n�v�@�\��Example�����B
    /// 
    /// �R���e���c�͈ȉ��̒ʂ�F
    ///   o BehaviorFilter-beforeInsert: behaviorFilterMap.dfprop, beforeInsertMap
    ///   o FileSystemOutsideSql: OutsideSql().
    /// 
    /// ���u���n�̐n�v�@�\�Ƃ́A�������ĂƂ��ɖ𗧂����Ӑ[�����p����K�v������@�\�ł���B
    /// </summary>
    [MbUnit.Framework.TestFixture]
    public class TwoEdgedSwordTest : ContainerTestCase {
        
        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected MemberBhv _memberBhv;
        protected MemberWithdrawalBhv _memberWithdrawalBhv;

        // ===============================================================================
        //                                                                 Behavior Filter
        //                                                                 ===============
        /// <summary>
        /// BehaviorFilter-beforeInsert: behaviorFilterMap.dfprop, beforeInsertMap
        /// ����މ��Behavior�ɉ���މ�����̎����o�^��Filter��������Insert����B
        /// 
        /// behaviorFilterMap.dfprop�Ŏw�肳�ꂽ�J���������S�Ẵe�[�u����Filter���|����B
        /// ����Example�ł͓K�؂ȃJ���������݂��Ȃ������̂����A��{�I�ɂ�
        /// �u�����e�[�u���ɂ܂�����J�����ŁA�������Ȃ���A���ʃJ�����ɓ��Ă͂Ȃ�Ȃ��J�����v
        /// ��ΏۂƂ���B
        /// 
        /// ���ʃJ�����̎����ݒ�Ƃ̈Ⴂ�́A���ɊȈՓI�ŒP���Ȏd�g�݂̋@�\�ł��邱�ƁB
        /// �����܂ł����Ƃ����Ƃ��̕⏕�@�\�ł���B
        /// ��肷�����Filter�����G�ɗ���Ō듮��𐶂݂��˂Ȃ��̂ŁA
        /// ���n�̐n�ł��邱�Ƃ𗝉����ė��p���邱�ƁB
        /// 
        /// �����ݒ�𓮓I�ɉ�������悤�ȃI�v�V�����͑��݂��Ȃ��B
        /// (���ʃJ�����̎����ݒ�͂����������I�v�V���������݂���)
        /// </summary>
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void BehaviorFilter_beforeInsert() {
            // ## Arrange ##
            MemberWithdrawal withdrawal = new MemberWithdrawal();
            withdrawal.MemberId = 8;

            // ## Act ##
            _memberWithdrawalBhv.Insert(withdrawal);

            // ## Assert ##
            MemberWithdrawalCB cb = new MemberWithdrawalCB();
            cb.Query().SetMemberId_Equal(withdrawal.MemberId);
            MemberWithdrawal actualWithdrawal = _memberWithdrawalBhv.SelectEntityWithDeletedCheck(cb);
            log("WithdrawalDatetime=" + actualWithdrawal.WithdrawalDatetime);
            assertNotNull(actualWithdrawal.WithdrawalDatetime);
            assertTrue(actualWithdrawal.WithdrawalDatetime.HasValue);
            assertEquals(_accessTimestamp.Value.Year, actualWithdrawal.WithdrawalDatetime.Value.Year);
            assertEquals(_accessTimestamp.Value.Month, actualWithdrawal.WithdrawalDatetime.Value.Month);
            assertEquals(_accessTimestamp.Value.Day, actualWithdrawal.WithdrawalDatetime.Value.Day);
            assertEquals(_accessTimestamp.Value.Hour, actualWithdrawal.WithdrawalDatetime.Value.Hour);
            assertEquals(_accessTimestamp.Value.Minute, actualWithdrawal.WithdrawalDatetime.Value.Minute);
            assertEquals(_accessTimestamp.Value.Second, actualWithdrawal.WithdrawalDatetime.Value.Second);
        }

        // ===============================================================================
        //                                                                      OutsideSql
        //                                                                      ==========
        /// <summary>
        /// FileSystemOutsideSql: OutsideSql().
        /// ���ߍ��܂ꂽ���\�[�X�łȂ�SQL�t�@�C�������s����B
        /// </summary>
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void OutsideSql_NotEmbedded() {
            // ## Arrange ##
            String path = MemberBhv.PATH_Various_NotEmbedded_selectNotEmbedded;
            SimpleMemberPmb pmb = new SimpleMemberPmb();
            pmb.SetMemberName_PrefixSearch("S");

            // ## Act ##
            IList<SimpleMember> memberList = _memberBhv.OutsideSql().SelectList<SimpleMember>(path, pmb);

            // ## Assert ##
            assertTrue(memberList.Count > 0);
        }
    }
}

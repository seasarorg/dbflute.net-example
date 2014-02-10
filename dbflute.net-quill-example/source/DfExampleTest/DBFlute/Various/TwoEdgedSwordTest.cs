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
    /// 「諸刃の刃」機能のExample実装。
    /// 
    /// コンテンツは以下の通り：
    ///   o BehaviorFilter-beforeInsert: behaviorFilterMap.dfprop, beforeInsertMap
    ///   o FileSystemOutsideSql: OutsideSql().
    /// 
    /// ※「諸刃の刃」機能とは、いざってときに役立つが注意深く利用する必要がある機能である。
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
        /// 会員退会のBehaviorに会員退会日時の自動登録のFilterをかけてInsertする。
        /// 
        /// behaviorFilterMap.dfpropで指定されたカラムを持つ全てのテーブルにFilterが掛かる。
        /// このExampleでは適切なカラムが存在しなかったのだが、基本的には
        /// 「複数テーブルにまたがるカラムで、しかしながら、共通カラムに当てはならないカラム」
        /// を対象とする。
        /// 
        /// 共通カラムの自動設定との違いは、非常に簡易的で単純な仕組みの機能であること。
        /// あくまでいざというときの補助機能である。
        /// やりすぎるとFilterが複雑に絡んで誤動作を生みかねないので、
        /// 諸刃の刃であることを理解して利用すること。
        /// 
        /// 自動設定を動的に解除するようなオプションは存在しない。
        /// (共通カラムの自動設定はそういったオプションが存在する)
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
        /// 埋め込まれたリソースでないSQLファイルを実行する。
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

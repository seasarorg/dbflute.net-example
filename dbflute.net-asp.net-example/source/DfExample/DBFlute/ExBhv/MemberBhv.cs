
using System;
using System.Collections.Generic;
using DfExample.DBFlute.AllCommon.Ado;
using DfExample.DBFlute.ExDao.Cursor;
using DfExample.DBFlute.ExDao.PmBean;

namespace DfExample.DBFlute.ExBhv {

    partial class MemberBhv {

        /// <summary>Log instance.</summary>
        protected static readonly log4net.ILog _log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public void MakeCsvPurchaseSummaryMember(PurchaseSummaryMemberPmb pmb) {
            PurchaseSummaryMemberCursorHandler handler = new PurchaseSummaryMemberCursorHandler(
                delegate(PurchaseSummaryMemberCursor cursor) {
                    while (cursor.Next()) {
                        long? memberId = cursor.MemberId;
                        String memberName = cursor.MemberName;
                        decimal? purchaseSummary = cursor.PurchaseSummary;
                        
                        _log.Debug("  " + memberId + " - " + memberName + " - " + purchaseSummary);

                    }// DataReader��Close��Framework���s���̂ŕK�v�Ȃ�
                    return null;// �����ŏ������������Ă�̂Ŗ߂�l�͕s�v
                });
            OutsideSql().CursorHandling().SelectCursor(PATH_selectPurchaseSummaryMember, pmb, handler);
        }
    }
}

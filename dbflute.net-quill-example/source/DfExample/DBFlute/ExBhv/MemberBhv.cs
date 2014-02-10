
using System;
using System.Collections.Generic;
using DfExample.DBFlute.AllCommon.Ado;
using DfExample.DBFlute.ExDao.Cursor;
using DfExample.DBFlute.ExDao.PmBean;

namespace DfExample.DBFlute.ExBhv {

    partial class MemberBhv {

        protected static readonly log4net.ILog _log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public void MakeCsvPurchaseSummaryMember(PurchaseSummaryMemberPmb pmb) {
            PurchaseSummaryMemberCursorHandler handler = new PurchaseSummaryMemberCursorHandler(
                delegate(PurchaseSummaryMemberCursor cursor) {
                    while (cursor.Next()) {
                        int? memberId = cursor.MemberId;
                        String memberName = cursor.MemberName;
                        DateTime? birthdate = cursor.Birthdate;
                        DateTime? formalizedDatetime = cursor.FormalizedDatetime;
                        decimal? purchaseSummary = cursor.PurchaseSummary;
                        
                        _log.Debug(memberId + ", " + memberName + ", "
                                 + birthdate + ", " + formalizedDatetime + ", " + purchaseSummary);

                    }
                    return null;
                });
            OutsideSql().CursorHandling().SelectCursor(PATH_selectPurchaseSummaryMember, pmb, handler);
        }
    }
}

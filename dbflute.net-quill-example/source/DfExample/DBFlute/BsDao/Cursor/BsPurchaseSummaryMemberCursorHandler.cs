
using System;
using System.Data;
using DfExample.DBFlute.AllCommon.Ado;

namespace DfExample.DBFlute.ExDao.Cursor {

    [System.Serializable]
    public partial class PurchaseSummaryMemberCursorHandler : DfExample.DBFlute.AllCommon.Ado.CursorHandler {

        protected CursorFetcher<PurchaseSummaryMemberCursor> _cursorFetcher;

        public PurchaseSummaryMemberCursorHandler(CursorFetcher<PurchaseSummaryMemberCursor> cursorFetcher) {
            _cursorFetcher = cursorFetcher;
        }

        public virtual Object Handle(IDataReader reader) {
            return FetchCursor(reader);
        }

        protected virtual Object FetchCursor(IDataReader reader) {
            return _cursorFetcher.Invoke(CreateTypeSafeCursor(reader));
        }

        protected virtual PurchaseSummaryMemberCursor CreateTypeSafeCursor(IDataReader reader) {
            PurchaseSummaryMemberCursor cursor = new PurchaseSummaryMemberCursor();
            cursor.Accept(reader);
            return cursor;
        }
    }
}

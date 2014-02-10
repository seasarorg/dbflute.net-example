
using System;
using System.Data;
using Seasar.Framework.Util;

namespace DfExample.DBFlute.ExDao.Cursor {

    public partial class PurchaseSummaryMemberCursor {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        // -------------------------------------------------
        //                                    Column DB Name
        //                                    --------------
        public static readonly String DB_NAME_MEMBER_ID = "MEMBER_ID";
        public static readonly String DB_NAME_MEMBER_NAME = "MEMBER_NAME";
        public static readonly String DB_NAME_BIRTHDATE = "BIRTHDATE";
        public static readonly String DB_NAME_FORMALIZED_DATETIME = "FORMALIZED_DATETIME";
        public static readonly String DB_NAME_PURCHASE_SUMMARY = "PURCHASE_SUMMARY";

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected IDataReader _reader;

        // ===============================================================================
        //                                                                         Prepare
        //                                                                         =======
        public virtual void Accept(IDataReader reader) {
            this._reader = reader;
        }

        // ===============================================================================
        //                                                                          Direct
        //                                                                          ======
        public virtual IDataReader Cursor {
            get { return _reader; }
        }

        // ===============================================================================
        //                                                                        Delegate
        //                                                                        ========
        public virtual bool Next() {
            return _reader.Read();
        }

        // ===============================================================================
        //                                                              Type Safe Accessor
        //                                                              ==================
        public int? MemberId {
            get { return (int?)ExtractValueAsNumber(typeof(int?), "MEMBER_ID"); }
        }

        public String MemberName {
            get { return ExtractValueAsString("MEMBER_NAME"); }
        }

        public DateTime? Birthdate {
            get { return ExtractValueAsDateTime(typeof(DateTime?), "BIRTHDATE"); }
        }

        public DateTime? FormalizedDatetime {
            get { return ExtractValueAsDateTime(typeof(DateTime?), "FORMALIZED_DATETIME"); }
        }

        public decimal? PurchaseSummary {
            get { return (decimal?)ExtractValueAsNumber(typeof(decimal?), "PURCHASE_SUMMARY"); }
        }

        // ===============================================================================
        //                                                                   Assist Helper
        //                                                                   =============
        protected virtual String ExtractValueAsString(String name) {
            Object objValue = ExtractValueAsObject(name);
            if (objValue == null || objValue.Equals(DBNull.Value)) { return null; }
            return (String)objValue;
        }

        protected virtual bool? ExtractValueAsBoolean(String name) {
            Object objValue = ExtractValueAsObject(name);
            if (objValue == null || objValue.Equals(DBNull.Value)) { return null; }
            return new bool?((bool)objValue);
        }

        protected virtual Object ExtractValueAsNumber(Type type, String name) {
            Object objValue = ExtractValueAsObject(name);
            if (objValue == null || objValue.Equals(DBNull.Value)) { return null; }
            decimal value = DecimalConversionUtil.ToDecimal(objValue);
            if (typeof(int?).Equals(type)) { return new int?((int)value); }
            if (typeof(long?).Equals(type)) { return new long?((long)value); }
            if (typeof(decimal?).Equals(type)) { return new decimal?(value); }
            return value;
        }

        protected virtual DateTime? ExtractValueAsDateTime(Type type, String name) {
            Object objValue = ExtractValueAsObject(name);
            if (objValue == null || objValue.Equals(DBNull.Value)) { return null; }
            return new DateTime?((DateTime)objValue);
        }

        protected virtual Object ExtractValueAsObject(String name) {
            return _reader[name];
        }
    }
}

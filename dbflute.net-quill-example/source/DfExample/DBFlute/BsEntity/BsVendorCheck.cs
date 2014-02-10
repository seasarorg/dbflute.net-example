

using System;
using System.Reflection;
using System.Collections.Generic;
using System.Text;

using DfExample.DBFlute.AllCommon;
using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.Dbm;
using DfExample.DBFlute.AllCommon.Helper;
using DfExample.DBFlute.ExEntity;
using DfExample.DBFlute.BsEntity.Dbm;


namespace DfExample.DBFlute.ExEntity {

    /// <summary>
    /// The entity of vendor_check as TABLE. (partial class for auto-generation)
    /// <![CDATA[
    /// [primary-key]
    ///     VENDOR_CHECK_ID
    /// 
    /// [column]
    ///     VENDOR_CHECK_ID, TYPE_OF_BOOLEAN, TYPE_OF_INTEGER, TYPE_OF_BIGINT, TYPE_OF_FLOAT, TYPE_OF_DOUBLE, TYPE_OF_DECIMAL_DECIMAL, TYPE_OF_DECIMAL_INTEGER, TYPE_OF_DECIMAL_BIGINT, TYPE_OF_NUMERIC_DECIMAL, TYPE_OF_NUMERIC_INTEGER, TYPE_OF_NUMERIC_BIGINT, TYPE_OF_TEXT, TYPE_OF_TINYTEXT, TYPE_OF_MEDIUMTEXT, TYPE_OF_LONGTEXT, TYPE_OF_DATE, TYPE_OF_DATETIME, TYPE_OF_TIMESTAMP, TYPE_OF_TIME, TYPE_OF_YEAR, TYPE_OF_BLOB, TYPE_OF_TINYBLOB, TYPE_OF_MEDIUMBLOB, TYPE_OF_LONGBLOB, TYPE_OF_BINARY, TYPE_OF_VARBINARY, TYPE_OF_ENUM, TYPE_OF_SET
    /// 
    /// [sequence]
    ///     
    /// 
    /// [identity]
    ///     
    /// 
    /// [version-no]
    ///     
    /// 
    /// [foreign-table]
    ///     
    /// 
    /// [referrer-table]
    ///     
    /// 
    /// [foreign-property]
    ///     
    /// 
    /// [referrer-property]
    ///     
    /// ]]>
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    [Seasar.Dao.Attrs.Table("vendor_check")]
    [System.Serializable]
    public partial class VendorCheck : Entity {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        #region Attribute
        /// <summary>VENDOR_CHECK_ID: {PK, NotNull, DECIMAL(16)}</summary>
        protected long? _vendorCheckId;

        /// <summary>TYPE_OF_BOOLEAN: {NotNull, BIT}</summary>
        protected bool? _typeOfBoolean;

        /// <summary>TYPE_OF_INTEGER: {INT(10)}</summary>
        protected int? _typeOfInteger;

        /// <summary>TYPE_OF_BIGINT: {BIGINT(19)}</summary>
        protected long? _typeOfBigint;

        /// <summary>TYPE_OF_FLOAT: {FLOAT(12)}</summary>
        protected decimal? _typeOfFloat;

        /// <summary>TYPE_OF_DOUBLE: {DOUBLE(22)}</summary>
        protected decimal? _typeOfDouble;

        /// <summary>TYPE_OF_DECIMAL_DECIMAL: {DECIMAL(5, 3)}</summary>
        protected decimal? _typeOfDecimalDecimal;

        /// <summary>TYPE_OF_DECIMAL_INTEGER: {DECIMAL(5)}</summary>
        protected int? _typeOfDecimalInteger;

        /// <summary>TYPE_OF_DECIMAL_BIGINT: {DECIMAL(12)}</summary>
        protected long? _typeOfDecimalBigint;

        /// <summary>TYPE_OF_NUMERIC_DECIMAL: {DECIMAL(5, 3)}</summary>
        protected decimal? _typeOfNumericDecimal;

        /// <summary>TYPE_OF_NUMERIC_INTEGER: {DECIMAL(5)}</summary>
        protected int? _typeOfNumericInteger;

        /// <summary>TYPE_OF_NUMERIC_BIGINT: {DECIMAL(12)}</summary>
        protected long? _typeOfNumericBigint;

        /// <summary>TYPE_OF_TEXT: {TEXT(65535)}</summary>
        protected String _typeOfText;

        /// <summary>TYPE_OF_TINYTEXT: {TINYTEXT(255)}</summary>
        protected String _typeOfTinytext;

        /// <summary>TYPE_OF_MEDIUMTEXT: {MEDIUMTEXT(16777215)}</summary>
        protected String _typeOfMediumtext;

        /// <summary>TYPE_OF_LONGTEXT: {LONGTEXT(2147483647)}</summary>
        protected String _typeOfLongtext;

        /// <summary>TYPE_OF_DATE: {DATE(10)}</summary>
        protected DateTime? _typeOfDate;

        /// <summary>TYPE_OF_DATETIME: {DATETIME(19)}</summary>
        protected DateTime? _typeOfDatetime;

        /// <summary>TYPE_OF_TIMESTAMP: {NotNull, TIMESTAMP(19), default=[CURRENT_TIMESTAMP]}</summary>
        protected DateTime? _typeOfTimestamp;

        /// <summary>TYPE_OF_TIME: {TIME(8)}</summary>
        protected DateTime? _typeOfTime;

        /// <summary>TYPE_OF_YEAR: {YEAR}</summary>
        protected DateTime? _typeOfYear;

        /// <summary>TYPE_OF_BLOB: {BLOB(65535)}</summary>
        protected byte[] _typeOfBlob;

        /// <summary>TYPE_OF_TINYBLOB: {TINYBLOB(255)}</summary>
        protected byte[] _typeOfTinyblob;

        /// <summary>TYPE_OF_MEDIUMBLOB: {MEDIUMBLOB(16777215)}</summary>
        protected byte[] _typeOfMediumblob;

        /// <summary>TYPE_OF_LONGBLOB: {LONGBLOB(2147483647)}</summary>
        protected byte[] _typeOfLongblob;

        /// <summary>TYPE_OF_BINARY: {BINARY(1)}</summary>
        protected byte[] _typeOfBinary;

        /// <summary>TYPE_OF_VARBINARY: {VARBINARY(1000)}</summary>
        protected byte[] _typeOfVarbinary;

        /// <summary>TYPE_OF_ENUM: {ENUM(6)}</summary>
        protected String _typeOfEnum;

        /// <summary>TYPE_OF_SET: {SET(15)}</summary>
        protected String _typeOfSet;

        protected EntityModifiedProperties __modifiedProperties = new EntityModifiedProperties();
        #endregion

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public String TableDbName { get { return "vendor_check"; } }
        public String TablePropertyName { get { return "VendorCheck"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public DBMeta DBMeta { get { return DBMetaInstanceHandler.FindDBMeta(TableDbName); } }

        // ===============================================================================
        //                                                                Foreign Property
        //                                                                ================
        #region Foreign Property
        #endregion

        // ===============================================================================
        //                                                               Referrer Property
        //                                                               =================
        #region Referrer Property
        #endregion

        // ===============================================================================
        //                                                                   Determination
        //                                                                   =============
        public virtual bool HasPrimaryKeyValue {
            get {
                if (_vendorCheckId == null) { return false; }
                return true;
            }
        }

        // ===============================================================================
        //                                                             Modified Properties
        //                                                             ===================
        public virtual IDictionary<String, Object> ModifiedPropertyNames {
            get { return __modifiedProperties.PropertyNames; }
        }

        public virtual void ClearModifiedPropertyNames() {
            __modifiedProperties.Clear();
        }

        // ===============================================================================
        //                                                                  Basic Override
        //                                                                  ==============
        #region Basic Override
        public override bool Equals(Object other) {
            if (other == null || !(other is VendorCheck)) { return false; }
            VendorCheck otherEntity = (VendorCheck)other;
            if (!xSV(this.VendorCheckId, otherEntity.VendorCheckId)) { return false; }
            return true;
        }
        protected bool xSV(Object value1, Object value2) { // isSameValue()
            if (value1 == null && value2 == null) { return true; }
            if (value1 == null || value2 == null) { return false; }
            return value1.Equals(value2);
        }

        public override int GetHashCode() {
            int result = 17;
            result = xCH(result, _vendorCheckId);
            return result;
        }
        protected int xCH(int result, Object value) { // calculateHashcode()
            if (value == null) { return result; }
            return (31*result) + (value is byte[] ? ((byte[])value).Length : value.GetHashCode());
        }

        public override String ToString() {
            return "VendorCheck:" + BuildColumnString() + BuildRelationString();
        }

        public virtual String ToStringWithRelation() {
            StringBuilder sb = new StringBuilder();
            sb.Append(ToString());
            return sb.ToString();
        }

        public virtual String BuildDisplayString(String name, bool column, bool relation) {
            StringBuilder sb = new StringBuilder();
            if (name != null) { sb.Append(name).Append(column || relation ? ":" : ""); }
            if (column) { sb.Append(BuildColumnString()); }
            if (relation) { sb.Append(BuildRelationString()); }
            return sb.ToString();
        }
        protected virtual String BuildColumnString() {
            String c = ", ";
            StringBuilder sb = new StringBuilder();
            sb.Append(c).Append(this.VendorCheckId);
            sb.Append(c).Append(this.TypeOfBoolean);
            sb.Append(c).Append(this.TypeOfInteger);
            sb.Append(c).Append(this.TypeOfBigint);
            sb.Append(c).Append(this.TypeOfFloat);
            sb.Append(c).Append(this.TypeOfDouble);
            sb.Append(c).Append(this.TypeOfDecimalDecimal);
            sb.Append(c).Append(this.TypeOfDecimalInteger);
            sb.Append(c).Append(this.TypeOfDecimalBigint);
            sb.Append(c).Append(this.TypeOfNumericDecimal);
            sb.Append(c).Append(this.TypeOfNumericInteger);
            sb.Append(c).Append(this.TypeOfNumericBigint);
            sb.Append(c).Append(this.TypeOfText);
            sb.Append(c).Append(this.TypeOfTinytext);
            sb.Append(c).Append(this.TypeOfMediumtext);
            sb.Append(c).Append(this.TypeOfLongtext);
            sb.Append(c).Append(this.TypeOfDate);
            sb.Append(c).Append(this.TypeOfDatetime);
            sb.Append(c).Append(this.TypeOfTimestamp);
            sb.Append(c).Append(this.TypeOfTime);
            sb.Append(c).Append(this.TypeOfYear);
            sb.Append(c).Append(xfBA(this.TypeOfBlob));
            sb.Append(c).Append(xfBA(this.TypeOfTinyblob));
            sb.Append(c).Append(xfBA(this.TypeOfMediumblob));
            sb.Append(c).Append(xfBA(this.TypeOfLongblob));
            sb.Append(c).Append(xfBA(this.TypeOfBinary));
            sb.Append(c).Append(xfBA(this.TypeOfVarbinary));
            sb.Append(c).Append(this.TypeOfEnum);
            sb.Append(c).Append(this.TypeOfSet);
            if (sb.Length > 0) { sb.Remove(0, c.Length); }
            sb.Insert(0, "{").Append("}");
            return sb.ToString();
        }
        protected String xfBA(byte[] byteArray) { // formatByteArray()
            return "byte[" + (byteArray != null ? byteArray.Length.ToString() : "null") + "]";
        }
        protected virtual String BuildRelationString() {
            return "";
        }
        #endregion

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        #region Accessor
        /// <summary>VENDOR_CHECK_ID: {PK, NotNull, DECIMAL(16)}</summary>
        [Seasar.Dao.Attrs.Column("VENDOR_CHECK_ID")]
        public long? VendorCheckId {
            get { return _vendorCheckId; }
            set {
                __modifiedProperties.AddPropertyName("VendorCheckId");
                _vendorCheckId = value;
            }
        }

        /// <summary>TYPE_OF_BOOLEAN: {NotNull, BIT}</summary>
        [Seasar.Dao.Attrs.Column("TYPE_OF_BOOLEAN")]
        public bool? TypeOfBoolean {
            get { return _typeOfBoolean; }
            set {
                __modifiedProperties.AddPropertyName("TypeOfBoolean");
                _typeOfBoolean = value;
            }
        }

        /// <summary>TYPE_OF_INTEGER: {INT(10)}</summary>
        [Seasar.Dao.Attrs.Column("TYPE_OF_INTEGER")]
        public int? TypeOfInteger {
            get { return _typeOfInteger; }
            set {
                __modifiedProperties.AddPropertyName("TypeOfInteger");
                _typeOfInteger = value;
            }
        }

        /// <summary>TYPE_OF_BIGINT: {BIGINT(19)}</summary>
        [Seasar.Dao.Attrs.Column("TYPE_OF_BIGINT")]
        public long? TypeOfBigint {
            get { return _typeOfBigint; }
            set {
                __modifiedProperties.AddPropertyName("TypeOfBigint");
                _typeOfBigint = value;
            }
        }

        /// <summary>TYPE_OF_FLOAT: {FLOAT(12)}</summary>
        [Seasar.Dao.Attrs.Column("TYPE_OF_FLOAT")]
        public decimal? TypeOfFloat {
            get { return _typeOfFloat; }
            set {
                __modifiedProperties.AddPropertyName("TypeOfFloat");
                _typeOfFloat = value;
            }
        }

        /// <summary>TYPE_OF_DOUBLE: {DOUBLE(22)}</summary>
        [Seasar.Dao.Attrs.Column("TYPE_OF_DOUBLE")]
        public decimal? TypeOfDouble {
            get { return _typeOfDouble; }
            set {
                __modifiedProperties.AddPropertyName("TypeOfDouble");
                _typeOfDouble = value;
            }
        }

        /// <summary>TYPE_OF_DECIMAL_DECIMAL: {DECIMAL(5, 3)}</summary>
        [Seasar.Dao.Attrs.Column("TYPE_OF_DECIMAL_DECIMAL")]
        public decimal? TypeOfDecimalDecimal {
            get { return _typeOfDecimalDecimal; }
            set {
                __modifiedProperties.AddPropertyName("TypeOfDecimalDecimal");
                _typeOfDecimalDecimal = value;
            }
        }

        /// <summary>TYPE_OF_DECIMAL_INTEGER: {DECIMAL(5)}</summary>
        [Seasar.Dao.Attrs.Column("TYPE_OF_DECIMAL_INTEGER")]
        public int? TypeOfDecimalInteger {
            get { return _typeOfDecimalInteger; }
            set {
                __modifiedProperties.AddPropertyName("TypeOfDecimalInteger");
                _typeOfDecimalInteger = value;
            }
        }

        /// <summary>TYPE_OF_DECIMAL_BIGINT: {DECIMAL(12)}</summary>
        [Seasar.Dao.Attrs.Column("TYPE_OF_DECIMAL_BIGINT")]
        public long? TypeOfDecimalBigint {
            get { return _typeOfDecimalBigint; }
            set {
                __modifiedProperties.AddPropertyName("TypeOfDecimalBigint");
                _typeOfDecimalBigint = value;
            }
        }

        /// <summary>TYPE_OF_NUMERIC_DECIMAL: {DECIMAL(5, 3)}</summary>
        [Seasar.Dao.Attrs.Column("TYPE_OF_NUMERIC_DECIMAL")]
        public decimal? TypeOfNumericDecimal {
            get { return _typeOfNumericDecimal; }
            set {
                __modifiedProperties.AddPropertyName("TypeOfNumericDecimal");
                _typeOfNumericDecimal = value;
            }
        }

        /// <summary>TYPE_OF_NUMERIC_INTEGER: {DECIMAL(5)}</summary>
        [Seasar.Dao.Attrs.Column("TYPE_OF_NUMERIC_INTEGER")]
        public int? TypeOfNumericInteger {
            get { return _typeOfNumericInteger; }
            set {
                __modifiedProperties.AddPropertyName("TypeOfNumericInteger");
                _typeOfNumericInteger = value;
            }
        }

        /// <summary>TYPE_OF_NUMERIC_BIGINT: {DECIMAL(12)}</summary>
        [Seasar.Dao.Attrs.Column("TYPE_OF_NUMERIC_BIGINT")]
        public long? TypeOfNumericBigint {
            get { return _typeOfNumericBigint; }
            set {
                __modifiedProperties.AddPropertyName("TypeOfNumericBigint");
                _typeOfNumericBigint = value;
            }
        }

        /// <summary>TYPE_OF_TEXT: {TEXT(65535)}</summary>
        [Seasar.Dao.Attrs.Column("TYPE_OF_TEXT")]
        public String TypeOfText {
            get { return _typeOfText; }
            set {
                __modifiedProperties.AddPropertyName("TypeOfText");
                _typeOfText = value;
            }
        }

        /// <summary>TYPE_OF_TINYTEXT: {TINYTEXT(255)}</summary>
        [Seasar.Dao.Attrs.Column("TYPE_OF_TINYTEXT")]
        public String TypeOfTinytext {
            get { return _typeOfTinytext; }
            set {
                __modifiedProperties.AddPropertyName("TypeOfTinytext");
                _typeOfTinytext = value;
            }
        }

        /// <summary>TYPE_OF_MEDIUMTEXT: {MEDIUMTEXT(16777215)}</summary>
        [Seasar.Dao.Attrs.Column("TYPE_OF_MEDIUMTEXT")]
        public String TypeOfMediumtext {
            get { return _typeOfMediumtext; }
            set {
                __modifiedProperties.AddPropertyName("TypeOfMediumtext");
                _typeOfMediumtext = value;
            }
        }

        /// <summary>TYPE_OF_LONGTEXT: {LONGTEXT(2147483647)}</summary>
        [Seasar.Dao.Attrs.Column("TYPE_OF_LONGTEXT")]
        public String TypeOfLongtext {
            get { return _typeOfLongtext; }
            set {
                __modifiedProperties.AddPropertyName("TypeOfLongtext");
                _typeOfLongtext = value;
            }
        }

        /// <summary>TYPE_OF_DATE: {DATE(10)}</summary>
        [Seasar.Dao.Attrs.Column("TYPE_OF_DATE")]
        public DateTime? TypeOfDate {
            get { return _typeOfDate; }
            set {
                __modifiedProperties.AddPropertyName("TypeOfDate");
                _typeOfDate = value;
            }
        }

        /// <summary>TYPE_OF_DATETIME: {DATETIME(19)}</summary>
        [Seasar.Dao.Attrs.Column("TYPE_OF_DATETIME")]
        public DateTime? TypeOfDatetime {
            get { return _typeOfDatetime; }
            set {
                __modifiedProperties.AddPropertyName("TypeOfDatetime");
                _typeOfDatetime = value;
            }
        }

        /// <summary>TYPE_OF_TIMESTAMP: {NotNull, TIMESTAMP(19), default=[CURRENT_TIMESTAMP]}</summary>
        [Seasar.Dao.Attrs.Column("TYPE_OF_TIMESTAMP")]
        public DateTime? TypeOfTimestamp {
            get { return _typeOfTimestamp; }
            set {
                __modifiedProperties.AddPropertyName("TypeOfTimestamp");
                _typeOfTimestamp = value;
            }
        }

        /// <summary>TYPE_OF_TIME: {TIME(8)}</summary>
        [Seasar.Dao.Attrs.Column("TYPE_OF_TIME")]
        public DateTime? TypeOfTime {
            get { return _typeOfTime; }
            set {
                __modifiedProperties.AddPropertyName("TypeOfTime");
                _typeOfTime = value;
            }
        }

        /// <summary>TYPE_OF_YEAR: {YEAR}</summary>
        [Seasar.Dao.Attrs.Column("TYPE_OF_YEAR")]
        public DateTime? TypeOfYear {
            get { return _typeOfYear; }
            set {
                __modifiedProperties.AddPropertyName("TypeOfYear");
                _typeOfYear = value;
            }
        }

        /// <summary>TYPE_OF_BLOB: {BLOB(65535)}</summary>
        [Seasar.Dao.Attrs.Column("TYPE_OF_BLOB")]
        public byte[] TypeOfBlob {
            get { return _typeOfBlob; }
            set {
                __modifiedProperties.AddPropertyName("TypeOfBlob");
                _typeOfBlob = value;
            }
        }

        /// <summary>TYPE_OF_TINYBLOB: {TINYBLOB(255)}</summary>
        [Seasar.Dao.Attrs.Column("TYPE_OF_TINYBLOB")]
        public byte[] TypeOfTinyblob {
            get { return _typeOfTinyblob; }
            set {
                __modifiedProperties.AddPropertyName("TypeOfTinyblob");
                _typeOfTinyblob = value;
            }
        }

        /// <summary>TYPE_OF_MEDIUMBLOB: {MEDIUMBLOB(16777215)}</summary>
        [Seasar.Dao.Attrs.Column("TYPE_OF_MEDIUMBLOB")]
        public byte[] TypeOfMediumblob {
            get { return _typeOfMediumblob; }
            set {
                __modifiedProperties.AddPropertyName("TypeOfMediumblob");
                _typeOfMediumblob = value;
            }
        }

        /// <summary>TYPE_OF_LONGBLOB: {LONGBLOB(2147483647)}</summary>
        [Seasar.Dao.Attrs.Column("TYPE_OF_LONGBLOB")]
        public byte[] TypeOfLongblob {
            get { return _typeOfLongblob; }
            set {
                __modifiedProperties.AddPropertyName("TypeOfLongblob");
                _typeOfLongblob = value;
            }
        }

        /// <summary>TYPE_OF_BINARY: {BINARY(1)}</summary>
        [Seasar.Dao.Attrs.Column("TYPE_OF_BINARY")]
        public byte[] TypeOfBinary {
            get { return _typeOfBinary; }
            set {
                __modifiedProperties.AddPropertyName("TypeOfBinary");
                _typeOfBinary = value;
            }
        }

        /// <summary>TYPE_OF_VARBINARY: {VARBINARY(1000)}</summary>
        [Seasar.Dao.Attrs.Column("TYPE_OF_VARBINARY")]
        public byte[] TypeOfVarbinary {
            get { return _typeOfVarbinary; }
            set {
                __modifiedProperties.AddPropertyName("TypeOfVarbinary");
                _typeOfVarbinary = value;
            }
        }

        /// <summary>TYPE_OF_ENUM: {ENUM(6)}</summary>
        [Seasar.Dao.Attrs.Column("TYPE_OF_ENUM")]
        public String TypeOfEnum {
            get { return _typeOfEnum; }
            set {
                __modifiedProperties.AddPropertyName("TypeOfEnum");
                _typeOfEnum = value;
            }
        }

        /// <summary>TYPE_OF_SET: {SET(15)}</summary>
        [Seasar.Dao.Attrs.Column("TYPE_OF_SET")]
        public String TypeOfSet {
            get { return _typeOfSet; }
            set {
                __modifiedProperties.AddPropertyName("TypeOfSet");
                _typeOfSet = value;
            }
        }

        #endregion
    }
}

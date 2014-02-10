

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
    /// The entity of VENDOR_CHECK as TABLE. (partial class for auto-generation)
    /// <![CDATA[
    /// [primary-key]
    ///     VENDOR_CHECK_ID
    /// 
    /// [column]
    ///     VENDOR_CHECK_ID, DECIMAL_DIGIT, INTEGER_NON_DIGIT, LARGE_CHARACTER, TYPE_OF_CHAR, TYPE_OF_NCHAR, TYPE_OF_VARCHAR2, TYPE_OF_VARCHAR2_MAX, TYPE_OF_NVARCHAR2, TYPE_OF_CLOB, TYPE_OF_NCLOB, TYPE_OF_DATE, TYPE_OF_TIMESTAMP, TYPE_OF_BLOB, TYPE_OF_RAW, TYPE_OF_BFILE
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
    [Seasar.Dao.Attrs.Table("VENDOR_CHECK")]
    [System.Serializable]
    public partial class VendorCheck : Entity {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        #region Attribute
        /// <summary>VENDOR_CHECK_ID: {PK, NotNull, NUMBER(16)}</summary>
        protected long? _vendorCheckId;

        /// <summary>DECIMAL_DIGIT: {NotNull, NUMBER(5, 3)}</summary>
        protected decimal? _decimalDigit;

        /// <summary>INTEGER_NON_DIGIT: {NotNull, NUMBER(5)}</summary>
        protected int? _integerNonDigit;

        /// <summary>LARGE_CHARACTER: {CLOB(4000)}</summary>
        protected String _largeCharacter;

        /// <summary>TYPE_OF_CHAR: {CHAR(3)}</summary>
        protected String _typeOfChar;

        /// <summary>TYPE_OF_NCHAR: {NCHAR(3)}</summary>
        protected String _typeOfNchar;

        /// <summary>TYPE_OF_VARCHAR2: {VARCHAR2(32)}</summary>
        protected String _typeOfVarchar2;

        /// <summary>TYPE_OF_VARCHAR2_MAX: {VARCHAR2(4000)}</summary>
        protected String _typeOfVarchar2Max;

        /// <summary>TYPE_OF_NVARCHAR2: {NVARCHAR2(32)}</summary>
        protected String _typeOfNvarchar2;

        /// <summary>TYPE_OF_CLOB: {CLOB(4000)}</summary>
        protected String _typeOfClob;

        /// <summary>TYPE_OF_NCLOB: {NCLOB(4000)}</summary>
        protected String _typeOfNclob;

        /// <summary>TYPE_OF_DATE: {DATE(7)}</summary>
        protected DateTime? _typeOfDate;

        /// <summary>TYPE_OF_TIMESTAMP: {TIMESTAMP(6)(11, 6)}</summary>
        protected DateTime? _typeOfTimestamp;

        /// <summary>TYPE_OF_BLOB: {BLOB(4000)}</summary>
        protected byte[] _typeOfBlob;

        /// <summary>TYPE_OF_RAW: {RAW(512)}</summary>
        protected byte[] _typeOfRaw;

        /// <summary>TYPE_OF_BFILE: {BFILE(530)}</summary>
        protected String _typeOfBfile;

        protected EntityModifiedProperties __modifiedProperties = new EntityModifiedProperties();
        #endregion

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public String TableDbName { get { return "VENDOR_CHECK"; } }
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
            sb.Append(c).Append(this.DecimalDigit);
            sb.Append(c).Append(this.IntegerNonDigit);
            sb.Append(c).Append(this.LargeCharacter);
            sb.Append(c).Append(this.TypeOfChar);
            sb.Append(c).Append(this.TypeOfNchar);
            sb.Append(c).Append(this.TypeOfVarchar2);
            sb.Append(c).Append(this.TypeOfVarchar2Max);
            sb.Append(c).Append(this.TypeOfNvarchar2);
            sb.Append(c).Append(this.TypeOfClob);
            sb.Append(c).Append(this.TypeOfNclob);
            sb.Append(c).Append(this.TypeOfDate);
            sb.Append(c).Append(this.TypeOfTimestamp);
            sb.Append(c).Append(xfBA(this.TypeOfBlob));
            sb.Append(c).Append(xfBA(this.TypeOfRaw));
            sb.Append(c).Append(this.TypeOfBfile);
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
        /// <summary>VENDOR_CHECK_ID: {PK, NotNull, NUMBER(16)}</summary>
        [Seasar.Dao.Attrs.Column("VENDOR_CHECK_ID")]
        public long? VendorCheckId {
            get { return _vendorCheckId; }
            set {
                __modifiedProperties.AddPropertyName("VendorCheckId");
                _vendorCheckId = value;
            }
        }

        /// <summary>DECIMAL_DIGIT: {NotNull, NUMBER(5, 3)}</summary>
        [Seasar.Dao.Attrs.Column("DECIMAL_DIGIT")]
        public decimal? DecimalDigit {
            get { return _decimalDigit; }
            set {
                __modifiedProperties.AddPropertyName("DecimalDigit");
                _decimalDigit = value;
            }
        }

        /// <summary>INTEGER_NON_DIGIT: {NotNull, NUMBER(5)}</summary>
        [Seasar.Dao.Attrs.Column("INTEGER_NON_DIGIT")]
        public int? IntegerNonDigit {
            get { return _integerNonDigit; }
            set {
                __modifiedProperties.AddPropertyName("IntegerNonDigit");
                _integerNonDigit = value;
            }
        }

        /// <summary>LARGE_CHARACTER: {CLOB(4000)}</summary>
        [Seasar.Dao.Attrs.Column("LARGE_CHARACTER")]
        public String LargeCharacter {
            get { return _largeCharacter; }
            set {
                __modifiedProperties.AddPropertyName("LargeCharacter");
                _largeCharacter = value;
            }
        }

        /// <summary>TYPE_OF_CHAR: {CHAR(3)}</summary>
        [Seasar.Dao.Attrs.Column("TYPE_OF_CHAR")]
        public String TypeOfChar {
            get { return _typeOfChar; }
            set {
                __modifiedProperties.AddPropertyName("TypeOfChar");
                _typeOfChar = value;
            }
        }

        /// <summary>TYPE_OF_NCHAR: {NCHAR(3)}</summary>
        [Seasar.Dao.Attrs.Column("TYPE_OF_NCHAR")]
        public String TypeOfNchar {
            get { return _typeOfNchar; }
            set {
                __modifiedProperties.AddPropertyName("TypeOfNchar");
                _typeOfNchar = value;
            }
        }

        /// <summary>TYPE_OF_VARCHAR2: {VARCHAR2(32)}</summary>
        [Seasar.Dao.Attrs.Column("TYPE_OF_VARCHAR2")]
        public String TypeOfVarchar2 {
            get { return _typeOfVarchar2; }
            set {
                __modifiedProperties.AddPropertyName("TypeOfVarchar2");
                _typeOfVarchar2 = value;
            }
        }

        /// <summary>TYPE_OF_VARCHAR2_MAX: {VARCHAR2(4000)}</summary>
        [Seasar.Dao.Attrs.Column("TYPE_OF_VARCHAR2_MAX")]
        public String TypeOfVarchar2Max {
            get { return _typeOfVarchar2Max; }
            set {
                __modifiedProperties.AddPropertyName("TypeOfVarchar2Max");
                _typeOfVarchar2Max = value;
            }
        }

        /// <summary>TYPE_OF_NVARCHAR2: {NVARCHAR2(32)}</summary>
        [Seasar.Dao.Attrs.Column("TYPE_OF_NVARCHAR2")]
        public String TypeOfNvarchar2 {
            get { return _typeOfNvarchar2; }
            set {
                __modifiedProperties.AddPropertyName("TypeOfNvarchar2");
                _typeOfNvarchar2 = value;
            }
        }

        /// <summary>TYPE_OF_CLOB: {CLOB(4000)}</summary>
        [Seasar.Dao.Attrs.Column("TYPE_OF_CLOB")]
        public String TypeOfClob {
            get { return _typeOfClob; }
            set {
                __modifiedProperties.AddPropertyName("TypeOfClob");
                _typeOfClob = value;
            }
        }

        /// <summary>TYPE_OF_NCLOB: {NCLOB(4000)}</summary>
        [Seasar.Dao.Attrs.Column("TYPE_OF_NCLOB")]
        public String TypeOfNclob {
            get { return _typeOfNclob; }
            set {
                __modifiedProperties.AddPropertyName("TypeOfNclob");
                _typeOfNclob = value;
            }
        }

        /// <summary>TYPE_OF_DATE: {DATE(7)}</summary>
        [Seasar.Dao.Attrs.Column("TYPE_OF_DATE")]
        public DateTime? TypeOfDate {
            get { return _typeOfDate; }
            set {
                __modifiedProperties.AddPropertyName("TypeOfDate");
                _typeOfDate = value;
            }
        }

        /// <summary>TYPE_OF_TIMESTAMP: {TIMESTAMP(6)(11, 6)}</summary>
        [Seasar.Dao.Attrs.Column("TYPE_OF_TIMESTAMP")]
        public DateTime? TypeOfTimestamp {
            get { return _typeOfTimestamp; }
            set {
                __modifiedProperties.AddPropertyName("TypeOfTimestamp");
                _typeOfTimestamp = value;
            }
        }

        /// <summary>TYPE_OF_BLOB: {BLOB(4000)}</summary>
        [Seasar.Dao.Attrs.Column("TYPE_OF_BLOB")]
        public byte[] TypeOfBlob {
            get { return _typeOfBlob; }
            set {
                __modifiedProperties.AddPropertyName("TypeOfBlob");
                _typeOfBlob = value;
            }
        }

        /// <summary>TYPE_OF_RAW: {RAW(512)}</summary>
        [Seasar.Dao.Attrs.Column("TYPE_OF_RAW")]
        public byte[] TypeOfRaw {
            get { return _typeOfRaw; }
            set {
                __modifiedProperties.AddPropertyName("TypeOfRaw");
                _typeOfRaw = value;
            }
        }

        /// <summary>TYPE_OF_BFILE: {BFILE(530)}</summary>
        [Seasar.Dao.Attrs.Column("TYPE_OF_BFILE")]
        public String TypeOfBfile {
            get { return _typeOfBfile; }
            set {
                __modifiedProperties.AddPropertyName("TypeOfBfile");
                _typeOfBfile = value;
            }
        }

        #endregion
    }
}

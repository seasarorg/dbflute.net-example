

using System;
using System.Reflection;
using System.Collections.Generic;
using System.Text;

using DfExample.DBFlute.AllCommon;
using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.Dbm;
using DfExample.DBFlute.AllCommon.Helper;
using DfExample.DBFlute.ExEntity.Customize;
using DfExample.DBFlute.BsEntity.Customize.Dbm;


namespace DfExample.DBFlute.ExEntity.Customize {

    /// <summary>
    /// The entity of SimpleVendorCheck. (partial class for auto-generation)
    /// <![CDATA[
    /// [primary-key]
    ///     
    /// 
    /// [column]
    ///     VENDOR_CHECK_ID, TYPE_OF_NUMERIC_DECIMAL, TYPE_OF_NUMERIC_INTEGER, TYPE_OF_NUMERIC_BIGINT, TYPE_OF_BOOLEAN, TYPE_OF_TEXT, TYPE_OF_BLOB
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
    [Seasar.Dao.Attrs.Table("SimpleVendorCheck")]
    [System.Serializable]
    public partial class SimpleVendorCheck : Entity {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        #region Attribute
        /// <summary>VENDOR_CHECK_ID: {DECIMAL(16), refers to vendor_check.VENDOR_CHECK_ID}</summary>
        protected long? _vendorCheckId;

        /// <summary>TYPE_OF_NUMERIC_DECIMAL: {DECIMAL(5, 3), refers to vendor_check.TYPE_OF_NUMERIC_DECIMAL}</summary>
        protected decimal? _typeOfNumericDecimal;

        /// <summary>TYPE_OF_NUMERIC_INTEGER: {DECIMAL(5), refers to vendor_check.TYPE_OF_NUMERIC_INTEGER}</summary>
        protected int? _typeOfNumericInteger;

        /// <summary>TYPE_OF_NUMERIC_BIGINT: {DECIMAL(12), refers to vendor_check.TYPE_OF_NUMERIC_BIGINT}</summary>
        protected long? _typeOfNumericBigint;

        /// <summary>TYPE_OF_BOOLEAN: {TINYINT(1), refers to vendor_check.TYPE_OF_BOOLEAN}</summary>
        protected bool? _typeOfBoolean;

        /// <summary>TYPE_OF_TEXT: {VARCHAR(21845), refers to vendor_check.TYPE_OF_TEXT}</summary>
        protected String _typeOfText;

        /// <summary>TYPE_OF_BLOB: {BLOB(65535), refers to vendor_check.TYPE_OF_BLOB}</summary>
        protected byte[] _typeOfBlob;

        protected EntityModifiedProperties __modifiedProperties = new EntityModifiedProperties();
        #endregion

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public String TableDbName { get { return "SimpleVendorCheck"; } }
        public String TablePropertyName { get { return "SimpleVendorCheck"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public DBMeta DBMeta { get { return SimpleVendorCheckDbm.GetInstance(); } }

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
                return false;
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
            if (other == null || !(other is SimpleVendorCheck)) { return false; }
            SimpleVendorCheck otherEntity = (SimpleVendorCheck)other;
            if (!xSV(this.VendorCheckId, otherEntity.VendorCheckId)) { return false; }
            if (!xSV(this.TypeOfNumericDecimal, otherEntity.TypeOfNumericDecimal)) { return false; }
            if (!xSV(this.TypeOfNumericInteger, otherEntity.TypeOfNumericInteger)) { return false; }
            if (!xSV(this.TypeOfNumericBigint, otherEntity.TypeOfNumericBigint)) { return false; }
            if (!xSV(this.TypeOfBoolean, otherEntity.TypeOfBoolean)) { return false; }
            if (!xSV(this.TypeOfText, otherEntity.TypeOfText)) { return false; }
            if (!xSV(this.TypeOfBlob, otherEntity.TypeOfBlob)) { return false; }
            return true;
        }
        protected bool xSV(Object value1, Object value2) { // isSameValue()
            if (value1 == null && value2 == null) { return true; }
            if (value1 == null || value2 == null) { return false; }
            if (value1 is byte[] && value2 is byte[]) { return xSVBA((byte[])value1, (byte[])value2); }
            return value1.Equals(value2);
        }
        protected bool xSVBA(byte[] byte1, byte[] byte2) { // isSameValueByteArray()
            if (byte1 == null && byte2 == null) { return true; }
            if (byte1 == null || byte2 == null) { return false; }
            if (byte1.Length != byte2.Length) { return false; }
            for (int i=0; i < byte1.Length; i++) {
                if (byte1[i] != byte2[i]) { return false; }
            }
            return true;
        }

        public override int GetHashCode() {
            int result = 17;
            result = xCH(result, _vendorCheckId);
            result = xCH(result, _typeOfNumericDecimal);
            result = xCH(result, _typeOfNumericInteger);
            result = xCH(result, _typeOfNumericBigint);
            result = xCH(result, _typeOfBoolean);
            result = xCH(result, _typeOfText);
            result = xCH(result, _typeOfBlob);
            return result;
        }
        protected int xCH(int result, Object value) { // calculateHashcode()
            if (value == null) { return result; }
            return (31*result) + (value is byte[] ? ((byte[])value).Length : value.GetHashCode());
        }

        public override String ToString() {
            return "SimpleVendorCheck:" + BuildColumnString() + BuildRelationString();
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
            sb.Append(c).Append(this.TypeOfNumericDecimal);
            sb.Append(c).Append(this.TypeOfNumericInteger);
            sb.Append(c).Append(this.TypeOfNumericBigint);
            sb.Append(c).Append(this.TypeOfBoolean);
            sb.Append(c).Append(this.TypeOfText);
            sb.Append(c).Append(xfBA(this.TypeOfBlob));
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
        /// <summary>VENDOR_CHECK_ID: {DECIMAL(16), refers to vendor_check.VENDOR_CHECK_ID}</summary>
        [Seasar.Dao.Attrs.Column("VENDOR_CHECK_ID")]
        public long? VendorCheckId {
            get { return _vendorCheckId; }
            set {
                __modifiedProperties.AddPropertyName("VendorCheckId");
                _vendorCheckId = value;
            }
        }

        /// <summary>TYPE_OF_NUMERIC_DECIMAL: {DECIMAL(5, 3), refers to vendor_check.TYPE_OF_NUMERIC_DECIMAL}</summary>
        [Seasar.Dao.Attrs.Column("TYPE_OF_NUMERIC_DECIMAL")]
        public decimal? TypeOfNumericDecimal {
            get { return _typeOfNumericDecimal; }
            set {
                __modifiedProperties.AddPropertyName("TypeOfNumericDecimal");
                _typeOfNumericDecimal = value;
            }
        }

        /// <summary>TYPE_OF_NUMERIC_INTEGER: {DECIMAL(5), refers to vendor_check.TYPE_OF_NUMERIC_INTEGER}</summary>
        [Seasar.Dao.Attrs.Column("TYPE_OF_NUMERIC_INTEGER")]
        public int? TypeOfNumericInteger {
            get { return _typeOfNumericInteger; }
            set {
                __modifiedProperties.AddPropertyName("TypeOfNumericInteger");
                _typeOfNumericInteger = value;
            }
        }

        /// <summary>TYPE_OF_NUMERIC_BIGINT: {DECIMAL(12), refers to vendor_check.TYPE_OF_NUMERIC_BIGINT}</summary>
        [Seasar.Dao.Attrs.Column("TYPE_OF_NUMERIC_BIGINT")]
        public long? TypeOfNumericBigint {
            get { return _typeOfNumericBigint; }
            set {
                __modifiedProperties.AddPropertyName("TypeOfNumericBigint");
                _typeOfNumericBigint = value;
            }
        }

        /// <summary>TYPE_OF_BOOLEAN: {TINYINT(1), refers to vendor_check.TYPE_OF_BOOLEAN}</summary>
        [Seasar.Dao.Attrs.Column("TYPE_OF_BOOLEAN")]
        public bool? TypeOfBoolean {
            get { return _typeOfBoolean; }
            set {
                __modifiedProperties.AddPropertyName("TypeOfBoolean");
                _typeOfBoolean = value;
            }
        }

        /// <summary>TYPE_OF_TEXT: {VARCHAR(21845), refers to vendor_check.TYPE_OF_TEXT}</summary>
        [Seasar.Dao.Attrs.Column("TYPE_OF_TEXT")]
        public String TypeOfText {
            get { return _typeOfText; }
            set {
                __modifiedProperties.AddPropertyName("TypeOfText");
                _typeOfText = value;
            }
        }

        /// <summary>TYPE_OF_BLOB: {BLOB(65535), refers to vendor_check.TYPE_OF_BLOB}</summary>
        [Seasar.Dao.Attrs.Column("TYPE_OF_BLOB")]
        public byte[] TypeOfBlob {
            get { return _typeOfBlob; }
            set {
                __modifiedProperties.AddPropertyName("TypeOfBlob");
                _typeOfBlob = value;
            }
        }

        #endregion
    }
}

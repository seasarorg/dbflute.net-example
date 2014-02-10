

using System;
using System.Reflection;
using System.Collections.Generic;
using System.Text;

using DfExample.DBFlute.MemberDb.AllCommon;
using DfExample.DBFlute.MemberDb.AllCommon.CBean;
using DfExample.DBFlute.MemberDb.AllCommon.Dbm;
using DfExample.DBFlute.MemberDb.AllCommon.Helper;
using DfExample.DBFlute.MemberDb.ExEntity;
using DfExample.DBFlute.MemberDb.BsEntity.Dbm;


namespace DfExample.DBFlute.MemberDb.ExEntity {

    /// <summary>
    /// The entity of vendor_check as TABLE. (partial class for auto-generation)
    /// <![CDATA[
    /// [primary-key]
    ///     VENDOR_CHECK_ID
    /// 
    /// [column]
    ///     VENDOR_CHECK_ID, DECIMAL_DIGIT, INTEGER_NON_DIGIT, TYPE_OF_BOOLEAN, TYPE_OF_TEXT
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
    public partial class MbVendorCheck : MbEntity {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        #region Attribute
        /// <summary>VENDOR_CHECK_ID: {PK, NotNull, DECIMAL(16)}</summary>
        protected long? _vendorCheckId;

        /// <summary>DECIMAL_DIGIT: {NotNull, DECIMAL(5, 3)}</summary>
        protected decimal? _decimalDigit;

        /// <summary>INTEGER_NON_DIGIT: {NotNull, DECIMAL(5)}</summary>
        protected int? _integerNonDigit;

        /// <summary>TYPE_OF_BOOLEAN: {NotNull, BIT}</summary>
        protected bool? _typeOfBoolean;

        /// <summary>TYPE_OF_TEXT: {TEXT(65535)}</summary>
        protected String _typeOfText;

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
        public MbDBMeta DBMeta { get { return MbDBMetaInstanceHandler.FindDBMeta(TableDbName); } }

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
            if (other == null || !(other is MbVendorCheck)) { return false; }
            MbVendorCheck otherEntity = (MbVendorCheck)other;
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
            return "MbVendorCheck:" + BuildColumnString() + BuildRelationString();
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
            sb.Append(c).Append(this.TypeOfBoolean);
            sb.Append(c).Append(this.TypeOfText);
            if (sb.Length > 0) { sb.Remove(0, c.Length); }
            sb.Insert(0, "{").Append("}");
            return sb.ToString();
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

        /// <summary>DECIMAL_DIGIT: {NotNull, DECIMAL(5, 3)}</summary>
        [Seasar.Dao.Attrs.Column("DECIMAL_DIGIT")]
        public decimal? DecimalDigit {
            get { return _decimalDigit; }
            set {
                __modifiedProperties.AddPropertyName("DecimalDigit");
                _decimalDigit = value;
            }
        }

        /// <summary>INTEGER_NON_DIGIT: {NotNull, DECIMAL(5)}</summary>
        [Seasar.Dao.Attrs.Column("INTEGER_NON_DIGIT")]
        public int? IntegerNonDigit {
            get { return _integerNonDigit; }
            set {
                __modifiedProperties.AddPropertyName("IntegerNonDigit");
                _integerNonDigit = value;
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

        /// <summary>TYPE_OF_TEXT: {TEXT(65535)}</summary>
        [Seasar.Dao.Attrs.Column("TYPE_OF_TEXT")]
        public String TypeOfText {
            get { return _typeOfText; }
            set {
                __modifiedProperties.AddPropertyName("TypeOfText");
                _typeOfText = value;
            }
        }

        #endregion
    }
}



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
    /// The entity of vendor_token as TABLE. (partial class for auto-generation)
    /// <![CDATA[
    /// [primary-key]
    ///     VENDOR_TOKEN_ID
    /// 
    /// [column]
    ///     VENDOR_TOKEN_ID, TOKEN_NUMBER, TOKEN_NAME
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
    [Seasar.Dao.Attrs.Table("vendor_token")]
    [System.Serializable]
    public partial class VendorToken : Entity {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        #region Attribute
        /// <summary>VENDOR_TOKEN_ID: {PK, NotNull, DECIMAL(16)}</summary>
        protected long? _vendorTokenId;

        /// <summary>TOKEN_NUMBER: {INT(10)}</summary>
        protected int? _tokenNumber;

        /// <summary>TOKEN_NAME: {VARCHAR(200)}</summary>
        protected String _tokenName;

        protected EntityModifiedProperties __modifiedProperties = new EntityModifiedProperties();
        #endregion

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public String TableDbName { get { return "vendor_token"; } }
        public String TablePropertyName { get { return "VendorToken"; } }

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
                if (_vendorTokenId == null) { return false; }
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
            if (other == null || !(other is VendorToken)) { return false; }
            VendorToken otherEntity = (VendorToken)other;
            if (!xSV(this.VendorTokenId, otherEntity.VendorTokenId)) { return false; }
            return true;
        }
        protected bool xSV(Object value1, Object value2) { // isSameValue()
            if (value1 == null && value2 == null) { return true; }
            if (value1 == null || value2 == null) { return false; }
            return value1.Equals(value2);
        }

        public override int GetHashCode() {
            int result = 17;
            result = xCH(result, _vendorTokenId);
            return result;
        }
        protected int xCH(int result, Object value) { // calculateHashcode()
            if (value == null) { return result; }
            return (31*result) + (value is byte[] ? ((byte[])value).Length : value.GetHashCode());
        }

        public override String ToString() {
            return "VendorToken:" + BuildColumnString() + BuildRelationString();
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
            sb.Append(c).Append(this.VendorTokenId);
            sb.Append(c).Append(this.TokenNumber);
            sb.Append(c).Append(this.TokenName);
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
        /// <summary>VENDOR_TOKEN_ID: {PK, NotNull, DECIMAL(16)}</summary>
        [Seasar.Dao.Attrs.Column("VENDOR_TOKEN_ID")]
        public long? VendorTokenId {
            get { return _vendorTokenId; }
            set {
                __modifiedProperties.AddPropertyName("VendorTokenId");
                _vendorTokenId = value;
            }
        }

        /// <summary>TOKEN_NUMBER: {INT(10)}</summary>
        [Seasar.Dao.Attrs.Column("TOKEN_NUMBER")]
        public int? TokenNumber {
            get { return _tokenNumber; }
            set {
                __modifiedProperties.AddPropertyName("TokenNumber");
                _tokenNumber = value;
            }
        }

        /// <summary>TOKEN_NAME: {VARCHAR(200)}</summary>
        [Seasar.Dao.Attrs.Column("TOKEN_NAME")]
        public String TokenName {
            get { return _tokenName; }
            set {
                __modifiedProperties.AddPropertyName("TokenName");
                _tokenName = value;
            }
        }

        #endregion
    }
}



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
    /// The entity of summary_product as VIEW. (partial class for auto-generation)
    /// <![CDATA[
    /// VIEW
    /// 
    /// [primary-key]
    ///     PRODUCT_ID
    /// 
    /// [column]
    ///     PRODUCT_ID, PRODUCT_NAME, PRODUCT_HANDLE_CODE, PRODUCT_STATUS_CODE, LATEST_PURCHASE_DATETIME
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
    [Seasar.Dao.Attrs.Table("summary_product")]
    [System.Serializable]
    public partial class SummaryProduct : Entity {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        #region Attribute
        /// <summary>PRODUCT_ID: {PK, NotNull, INT(10), default=[0]}</summary>
        protected int? _productId;

        /// <summary>PRODUCT_NAME: {NotNull, VARCHAR(50)}</summary>
        protected String _productName;

        /// <summary>PRODUCT_HANDLE_CODE: {UQ, NotNull, VARCHAR(100)}</summary>
        protected String _productHandleCode;

        /// <summary>PRODUCT_STATUS_CODE: {NotNull, CHAR(3)}</summary>
        protected String _productStatusCode;

        /// <summary>LATEST_PURCHASE_DATETIME: {DATETIME(19)}</summary>
        protected DateTime? _latestPurchaseDatetime;

        protected EntityModifiedProperties __modifiedProperties = new EntityModifiedProperties();
        #endregion

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public String TableDbName { get { return "summary_product"; } }
        public String TablePropertyName { get { return "SummaryProduct"; } }

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
                if (_productId == null) { return false; }
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
            if (other == null || !(other is SummaryProduct)) { return false; }
            SummaryProduct otherEntity = (SummaryProduct)other;
            if (!xSV(this.ProductId, otherEntity.ProductId)) { return false; }
            return true;
        }
        protected bool xSV(Object value1, Object value2) { // isSameValue()
            if (value1 == null && value2 == null) { return true; }
            if (value1 == null || value2 == null) { return false; }
            return value1.Equals(value2);
        }

        public override int GetHashCode() {
            int result = 17;
            result = xCH(result, _productId);
            return result;
        }
        protected int xCH(int result, Object value) { // calculateHashcode()
            if (value == null) { return result; }
            return (31*result) + (value is byte[] ? ((byte[])value).Length : value.GetHashCode());
        }

        public override String ToString() {
            return "SummaryProduct:" + BuildColumnString() + BuildRelationString();
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
            sb.Append(c).Append(this.ProductId);
            sb.Append(c).Append(this.ProductName);
            sb.Append(c).Append(this.ProductHandleCode);
            sb.Append(c).Append(this.ProductStatusCode);
            sb.Append(c).Append(this.LatestPurchaseDatetime);
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
        /// <summary>PRODUCT_ID: {PK, NotNull, INT(10), default=[0]}</summary>
        [Seasar.Dao.Attrs.Column("PRODUCT_ID")]
        public int? ProductId {
            get { return _productId; }
            set {
                __modifiedProperties.AddPropertyName("ProductId");
                _productId = value;
            }
        }

        /// <summary>PRODUCT_NAME: {NotNull, VARCHAR(50)}</summary>
        [Seasar.Dao.Attrs.Column("PRODUCT_NAME")]
        public String ProductName {
            get { return _productName; }
            set {
                __modifiedProperties.AddPropertyName("ProductName");
                _productName = value;
            }
        }

        /// <summary>PRODUCT_HANDLE_CODE: {UQ, NotNull, VARCHAR(100)}</summary>
        [Seasar.Dao.Attrs.Column("PRODUCT_HANDLE_CODE")]
        public String ProductHandleCode {
            get { return _productHandleCode; }
            set {
                __modifiedProperties.AddPropertyName("ProductHandleCode");
                _productHandleCode = value;
            }
        }

        /// <summary>PRODUCT_STATUS_CODE: {NotNull, CHAR(3)}</summary>
        [Seasar.Dao.Attrs.Column("PRODUCT_STATUS_CODE")]
        public String ProductStatusCode {
            get { return _productStatusCode; }
            set {
                __modifiedProperties.AddPropertyName("ProductStatusCode");
                _productStatusCode = value;
            }
        }

        /// <summary>LATEST_PURCHASE_DATETIME: {DATETIME(19)}</summary>
        [Seasar.Dao.Attrs.Column("LATEST_PURCHASE_DATETIME")]
        public DateTime? LatestPurchaseDatetime {
            get { return _latestPurchaseDatetime; }
            set {
                __modifiedProperties.AddPropertyName("LatestPurchaseDatetime");
                _latestPurchaseDatetime = value;
            }
        }

        #endregion
    }
}



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
    /// The entity of product as TABLE. (partial class for auto-generation)
    /// <![CDATA[
    /// [primary-key]
    ///     PRODUCT_ID
    /// 
    /// [column]
    ///     PRODUCT_ID, PRODUCT_NAME, PRODUCT_HANDLE_CODE, PRODUCT_STATUS_CODE, REGISTER_DATETIME, REGISTER_USER, REGISTER_PROCESS, UPDATE_DATETIME, UPDATE_USER, UPDATE_PROCESS, VERSION_NO
    /// 
    /// [sequence]
    ///     
    /// 
    /// [identity]
    ///     PRODUCT_ID
    /// 
    /// [version-no]
    ///     VERSION_NO
    /// 
    /// [foreign-table]
    ///     product_status
    /// 
    /// [referrer-table]
    ///     purchase
    /// 
    /// [foreign-property]
    ///     productStatus
    /// 
    /// [referrer-property]
    ///     purchaseList
    /// ]]>
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    [Seasar.Dao.Attrs.Table("product")]
    [Seasar.Dao.Attrs.VersionNoProperty("VersionNo")]
    [System.Serializable]
    public partial class MbProduct : MbEntityDefinedCommonColumn {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        #region Attribute
        /// <summary>PRODUCT_ID: {PK, ID, NotNull, INT(10)}</summary>
        protected int? _productId;

        /// <summary>PRODUCT_NAME: {IX, NotNull, VARCHAR(50)}</summary>
        protected String _productName;

        /// <summary>PRODUCT_HANDLE_CODE: {UQ, NotNull, VARCHAR(100)}</summary>
        protected String _productHandleCode;

        /// <summary>PRODUCT_STATUS_CODE: {IX, NotNull, CHAR(3), FK to product_status}</summary>
        protected String _productStatusCode;

        /// <summary>REGISTER_DATETIME: {NotNull, DATETIME(19)}</summary>
        protected DateTime? _registerDatetime;

        /// <summary>REGISTER_USER: {NotNull, VARCHAR(200)}</summary>
        protected String _registerUser;

        /// <summary>REGISTER_PROCESS: {NotNull, VARCHAR(200)}</summary>
        protected String _registerProcess;

        /// <summary>UPDATE_DATETIME: {NotNull, DATETIME(19)}</summary>
        protected DateTime? _updateDatetime;

        /// <summary>UPDATE_USER: {NotNull, VARCHAR(200)}</summary>
        protected String _updateUser;

        /// <summary>UPDATE_PROCESS: {NotNull, VARCHAR(200)}</summary>
        protected String _updateProcess;

        /// <summary>VERSION_NO: {NotNull, BIGINT(19)}</summary>
        protected long? _versionNo;

        protected EntityModifiedProperties __modifiedProperties = new EntityModifiedProperties();

        protected bool __canCommonColumnAutoSetup = true;
        #endregion

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public String TableDbName { get { return "product"; } }
        public String TablePropertyName { get { return "Product"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public MbDBMeta DBMeta { get { return MbDBMetaInstanceHandler.FindDBMeta(TableDbName); } }

        // ===============================================================================
        //                                                                Foreign Property
        //                                                                ================
        #region Foreign Property
        protected MbProductStatus _productStatus;

        /// <summary>product_status as 'ProductStatus'.</summary>
        [Seasar.Dao.Attrs.Relno(0), Seasar.Dao.Attrs.Relkeys("PRODUCT_STATUS_CODE:PRODUCT_STATUS_CODE")]
        public MbProductStatus ProductStatus {
            get { return _productStatus; }
            set { _productStatus = value; }
        }

        #endregion

        // ===============================================================================
        //                                                               Referrer Property
        //                                                               =================
        #region Referrer Property
        protected IList<MbPurchase> _purchaseList;

        /// <summary>purchase as 'PurchaseList'.</summary>
        public IList<MbPurchase> PurchaseList {
            get { if (_purchaseList == null) { _purchaseList = new List<MbPurchase>(); } return _purchaseList; }
            set { _purchaseList = value; }
        }

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
        //                                                          Common Column Handling
        //                                                          ======================
        public virtual void EnableCommonColumnAutoSetup() {
            __canCommonColumnAutoSetup = true;
        }

        public virtual void DisableCommonColumnAutoSetup() {
            __canCommonColumnAutoSetup = false;
        }

        public virtual bool CanCommonColumnAutoSetup() {// for Framework
            return __canCommonColumnAutoSetup;
        }

        // ===============================================================================
        //                                                                  Basic Override
        //                                                                  ==============
        #region Basic Override
        public override bool Equals(Object other) {
            if (other == null || !(other is MbProduct)) { return false; }
            MbProduct otherEntity = (MbProduct)other;
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
            return "MbProduct:" + BuildColumnString() + BuildRelationString();
        }

        public virtual String ToStringWithRelation() {
            StringBuilder sb = new StringBuilder();
            sb.Append(ToString());
            String l = "\n  ";
            if (_productStatus != null)
            { sb.Append(l).Append(xbRDS(_productStatus, "ProductStatus")); }
            if (_purchaseList != null) { foreach (MbEntity e in _purchaseList)
            { if (e != null) { sb.Append(l).Append(xbRDS(e, "PurchaseList")); } } }
            return sb.ToString();
        }
        protected String xbRDS(MbEntity e, String name) { // buildRelationDisplayString()
            return e.BuildDisplayString(name, true, true);
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
            sb.Append(c).Append(this.RegisterDatetime);
            sb.Append(c).Append(this.RegisterUser);
            sb.Append(c).Append(this.RegisterProcess);
            sb.Append(c).Append(this.UpdateDatetime);
            sb.Append(c).Append(this.UpdateUser);
            sb.Append(c).Append(this.UpdateProcess);
            sb.Append(c).Append(this.VersionNo);
            if (sb.Length > 0) { sb.Remove(0, c.Length); }
            sb.Insert(0, "{").Append("}");
            return sb.ToString();
        }
        protected virtual String BuildRelationString() {
            StringBuilder sb = new StringBuilder();
            String c = ",";
            if (_productStatus != null) { sb.Append(c).Append("ProductStatus"); }
            if (_purchaseList != null && _purchaseList.Count > 0)
            { sb.Append(c).Append("PurchaseList"); }
            if (sb.Length > 0) { sb.Remove(0, c.Length).Insert(0, "(").Append(")"); }
            return sb.ToString();
        }
        #endregion

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        #region Accessor
        /// <summary>PRODUCT_ID: {PK, ID, NotNull, INT(10)}</summary>
        [Seasar.Dao.Attrs.ID("identity")]
        [Seasar.Dao.Attrs.Column("PRODUCT_ID")]
        public int? ProductId {
            get { return _productId; }
            set {
                __modifiedProperties.AddPropertyName("ProductId");
                _productId = value;
            }
        }

        /// <summary>PRODUCT_NAME: {IX, NotNull, VARCHAR(50)}</summary>
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

        /// <summary>PRODUCT_STATUS_CODE: {IX, NotNull, CHAR(3), FK to product_status}</summary>
        [Seasar.Dao.Attrs.Column("PRODUCT_STATUS_CODE")]
        public String ProductStatusCode {
            get { return _productStatusCode; }
            set {
                __modifiedProperties.AddPropertyName("ProductStatusCode");
                _productStatusCode = value;
            }
        }

        /// <summary>REGISTER_DATETIME: {NotNull, DATETIME(19)}</summary>
        [Seasar.Dao.Attrs.Column("REGISTER_DATETIME")]
        public DateTime? RegisterDatetime {
            get { return _registerDatetime; }
            set {
                __modifiedProperties.AddPropertyName("RegisterDatetime");
                _registerDatetime = value;
            }
        }

        /// <summary>REGISTER_USER: {NotNull, VARCHAR(200)}</summary>
        [Seasar.Dao.Attrs.Column("REGISTER_USER")]
        public String RegisterUser {
            get { return _registerUser; }
            set {
                __modifiedProperties.AddPropertyName("RegisterUser");
                _registerUser = value;
            }
        }

        /// <summary>REGISTER_PROCESS: {NotNull, VARCHAR(200)}</summary>
        [Seasar.Dao.Attrs.Column("REGISTER_PROCESS")]
        public String RegisterProcess {
            get { return _registerProcess; }
            set {
                __modifiedProperties.AddPropertyName("RegisterProcess");
                _registerProcess = value;
            }
        }

        /// <summary>UPDATE_DATETIME: {NotNull, DATETIME(19)}</summary>
        [Seasar.Dao.Attrs.Column("UPDATE_DATETIME")]
        public DateTime? UpdateDatetime {
            get { return _updateDatetime; }
            set {
                __modifiedProperties.AddPropertyName("UpdateDatetime");
                _updateDatetime = value;
            }
        }

        /// <summary>UPDATE_USER: {NotNull, VARCHAR(200)}</summary>
        [Seasar.Dao.Attrs.Column("UPDATE_USER")]
        public String UpdateUser {
            get { return _updateUser; }
            set {
                __modifiedProperties.AddPropertyName("UpdateUser");
                _updateUser = value;
            }
        }

        /// <summary>UPDATE_PROCESS: {NotNull, VARCHAR(200)}</summary>
        [Seasar.Dao.Attrs.Column("UPDATE_PROCESS")]
        public String UpdateProcess {
            get { return _updateProcess; }
            set {
                __modifiedProperties.AddPropertyName("UpdateProcess");
                _updateProcess = value;
            }
        }

        /// <summary>VERSION_NO: {NotNull, BIGINT(19)}</summary>
        [Seasar.Dao.Attrs.Column("VERSION_NO")]
        public long? VersionNo {
            get { return _versionNo; }
            set {
                __modifiedProperties.AddPropertyName("VersionNo");
                _versionNo = value;
            }
        }

        #endregion
    }
}

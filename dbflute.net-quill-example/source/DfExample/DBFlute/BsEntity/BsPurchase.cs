

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
    /// The entity of (購入)purchase as TABLE. (partial class for auto-generation)
    /// <![CDATA[
    /// [primary-key]
    ///     PURCHASE_ID
    /// 
    /// [column]
    ///     PURCHASE_ID, MEMBER_ID, PRODUCT_ID, PURCHASE_DATETIME, PURCHASE_COUNT, PURCHASE_PRICE, PAYMENT_COMPLETE_FLG, REGISTER_DATETIME, REGISTER_USER, REGISTER_PROCESS, UPDATE_DATETIME, UPDATE_USER, UPDATE_PROCESS, VERSION_NO
    /// 
    /// [sequence]
    ///     
    /// 
    /// [identity]
    ///     PURCHASE_ID
    /// 
    /// [version-no]
    ///     VERSION_NO
    /// 
    /// [foreign-table]
    ///     member, product
    /// 
    /// [referrer-table]
    ///     
    /// 
    /// [foreign-property]
    ///     member, product
    /// 
    /// [referrer-property]
    ///     
    /// ]]>
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    [Seasar.Dao.Attrs.Table("purchase")]
    [Seasar.Dao.Attrs.VersionNoProperty("VersionNo")]
    [System.Serializable]
    public partial class Purchase : EntityDefinedCommonColumn {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        #region Attribute
        /// <summary>PURCHASE_ID: {PK, ID, NotNull, BIGINT(19)}</summary>
        protected long? _purchaseId;

        /// <summary>MEMBER_ID: {UQ+, IX+, NotNull, INT(10), FK to member}</summary>
        protected int? _memberId;

        /// <summary>PRODUCT_ID: {+UQ, IX+, NotNull, INT(10), FK to product}</summary>
        protected int? _productId;

        /// <summary>PURCHASE_DATETIME: {+UQ, IX+, NotNull, DATETIME(19)}</summary>
        protected DateTime? _purchaseDatetime;

        /// <summary>PURCHASE_COUNT: {NotNull, INT(10)}</summary>
        protected int? _purchaseCount;

        /// <summary>PURCHASE_PRICE: {IX, NotNull, INT(10)}</summary>
        protected int? _purchasePrice;

        /// <summary>PAYMENT_COMPLETE_FLG: {NotNull, INT(10), classification=Flg}</summary>
        protected int? _paymentCompleteFlg;

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
        public String TableDbName { get { return "purchase"; } }
        public String TablePropertyName { get { return "Purchase"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public DBMeta DBMeta { get { return DBMetaInstanceHandler.FindDBMeta(TableDbName); } }

        // ===============================================================================
        //                                                         Classification Property
        //                                                         =======================
        #region Classification Property
        public CDef.Flg PaymentCompleteFlgAsFlg { get {
            return CDef.Flg.CodeOf(_paymentCompleteFlg);
        } set {
            PaymentCompleteFlg = value != null ? int.Parse(value.Code) : (int?)null;
        }}

        #endregion

        // ===============================================================================
        //                                                          Classification Setting
        //                                                          ======================
        #region Classification Setting
        /// <summary>
        /// Set the value of paymentCompleteFlg as True.
        /// <![CDATA[
        /// はい: 有効を示す
        /// ]]>
        /// </summary>
        public void SetPaymentCompleteFlg_True() {
            PaymentCompleteFlgAsFlg = CDef.Flg.True;
        }

        /// <summary>
        /// Set the value of paymentCompleteFlg as False.
        /// <![CDATA[
        /// いいえ: 無効を示す
        /// ]]>
        /// </summary>
        public void SetPaymentCompleteFlg_False() {
            PaymentCompleteFlgAsFlg = CDef.Flg.False;
        }

        #endregion

        // ===============================================================================
        //                                                    Classification Determination
        //                                                    ============================
        #region Classification Determination
        /// <summary>
        /// Is the value of paymentCompleteFlg 'True'?
        /// <![CDATA[
        /// The difference of capital letters and small letters is NOT distinguished.
        /// If the value is null, this method returns false!
        /// はい: 有効を示す
        /// ]]>
        /// </summary>
        public bool IsPaymentCompleteFlgTrue {
            get {
                CDef.Flg cls = PaymentCompleteFlgAsFlg;
                return cls != null ? cls.Equals(CDef.Flg.True) : false;
            }
        }

        /// <summary>
        /// Is the value of paymentCompleteFlg 'False'?
        /// <![CDATA[
        /// The difference of capital letters and small letters is NOT distinguished.
        /// If the value is null, this method returns false!
        /// いいえ: 無効を示す
        /// ]]>
        /// </summary>
        public bool IsPaymentCompleteFlgFalse {
            get {
                CDef.Flg cls = PaymentCompleteFlgAsFlg;
                return cls != null ? cls.Equals(CDef.Flg.False) : false;
            }
        }

        #endregion

        // ===============================================================================
        //                                                       Classification Name/Alias
        //                                                       =========================
        #region Classification Name/Alias
        public String PaymentCompleteFlgName {
            get {
                CDef.Flg cls = PaymentCompleteFlgAsFlg;
                return cls != null ? cls.Name : null;
            }
        }
        public String PaymentCompleteFlgAlias {
            get {
                CDef.Flg cls = PaymentCompleteFlgAsFlg;
                return cls != null ? cls.Alias : null;
            }
        }

        #endregion

        // ===============================================================================
        //                                                                Foreign Property
        //                                                                ================
        #region Foreign Property
        protected Member _member;

        /// <summary>(会員)member as 'Member'.</summary>
        [Seasar.Dao.Attrs.Relno(0), Seasar.Dao.Attrs.Relkeys("MEMBER_ID:MEMBER_ID")]
        public Member Member {
            get { return _member; }
            set { _member = value; }
        }

        protected Product _product;

        /// <summary>product as 'Product'.</summary>
        [Seasar.Dao.Attrs.Relno(1), Seasar.Dao.Attrs.Relkeys("PRODUCT_ID:PRODUCT_ID")]
        public Product Product {
            get { return _product; }
            set { _product = value; }
        }

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
                if (_purchaseId == null) { return false; }
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
            if (other == null || !(other is Purchase)) { return false; }
            Purchase otherEntity = (Purchase)other;
            if (!xSV(this.PurchaseId, otherEntity.PurchaseId)) { return false; }
            return true;
        }
        protected bool xSV(Object value1, Object value2) { // isSameValue()
            if (value1 == null && value2 == null) { return true; }
            if (value1 == null || value2 == null) { return false; }
            return value1.Equals(value2);
        }

        public override int GetHashCode() {
            int result = 17;
            result = xCH(result, _purchaseId);
            return result;
        }
        protected int xCH(int result, Object value) { // calculateHashcode()
            if (value == null) { return result; }
            return (31*result) + (value is byte[] ? ((byte[])value).Length : value.GetHashCode());
        }

        public override String ToString() {
            return "Purchase:" + BuildColumnString() + BuildRelationString();
        }

        public virtual String ToStringWithRelation() {
            StringBuilder sb = new StringBuilder();
            sb.Append(ToString());
            String l = "\n  ";
            if (_member != null)
            { sb.Append(l).Append(xbRDS(_member, "Member")); }
            if (_product != null)
            { sb.Append(l).Append(xbRDS(_product, "Product")); }
            return sb.ToString();
        }
        protected String xbRDS(Entity e, String name) { // buildRelationDisplayString()
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
            sb.Append(c).Append(this.PurchaseId);
            sb.Append(c).Append(this.MemberId);
            sb.Append(c).Append(this.ProductId);
            sb.Append(c).Append(this.PurchaseDatetime);
            sb.Append(c).Append(this.PurchaseCount);
            sb.Append(c).Append(this.PurchasePrice);
            sb.Append(c).Append(this.PaymentCompleteFlg);
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
            if (_member != null) { sb.Append(c).Append("Member"); }
            if (_product != null) { sb.Append(c).Append("Product"); }
            if (sb.Length > 0) { sb.Remove(0, c.Length).Insert(0, "(").Append(")"); }
            return sb.ToString();
        }
        #endregion

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        #region Accessor
        /// <summary>PURCHASE_ID: {PK, ID, NotNull, BIGINT(19)}</summary>
        [Seasar.Dao.Attrs.ID("identity")]
        [Seasar.Dao.Attrs.Column("PURCHASE_ID")]
        public long? PurchaseId {
            get { return _purchaseId; }
            set {
                __modifiedProperties.AddPropertyName("PurchaseId");
                _purchaseId = value;
            }
        }

        /// <summary>MEMBER_ID: {UQ+, IX+, NotNull, INT(10), FK to member}</summary>
        [Seasar.Dao.Attrs.Column("MEMBER_ID")]
        public int? MemberId {
            get { return _memberId; }
            set {
                __modifiedProperties.AddPropertyName("MemberId");
                _memberId = value;
            }
        }

        /// <summary>PRODUCT_ID: {+UQ, IX+, NotNull, INT(10), FK to product}</summary>
        [Seasar.Dao.Attrs.Column("PRODUCT_ID")]
        public int? ProductId {
            get { return _productId; }
            set {
                __modifiedProperties.AddPropertyName("ProductId");
                _productId = value;
            }
        }

        /// <summary>PURCHASE_DATETIME: {+UQ, IX+, NotNull, DATETIME(19)}</summary>
        [Seasar.Dao.Attrs.Column("PURCHASE_DATETIME")]
        public DateTime? PurchaseDatetime {
            get { return _purchaseDatetime; }
            set {
                __modifiedProperties.AddPropertyName("PurchaseDatetime");
                _purchaseDatetime = value;
            }
        }

        /// <summary>PURCHASE_COUNT: {NotNull, INT(10)}</summary>
        [Seasar.Dao.Attrs.Column("PURCHASE_COUNT")]
        public int? PurchaseCount {
            get { return _purchaseCount; }
            set {
                __modifiedProperties.AddPropertyName("PurchaseCount");
                _purchaseCount = value;
            }
        }

        /// <summary>PURCHASE_PRICE: {IX, NotNull, INT(10)}</summary>
        [Seasar.Dao.Attrs.Column("PURCHASE_PRICE")]
        public int? PurchasePrice {
            get { return _purchasePrice; }
            set {
                __modifiedProperties.AddPropertyName("PurchasePrice");
                _purchasePrice = value;
            }
        }

        /// <summary>PAYMENT_COMPLETE_FLG: {NotNull, INT(10), classification=Flg}</summary>
        [Seasar.Dao.Attrs.Column("PAYMENT_COMPLETE_FLG")]
        public int? PaymentCompleteFlg {
            get { return _paymentCompleteFlg; }
            set {
                __modifiedProperties.AddPropertyName("PaymentCompleteFlg");
                _paymentCompleteFlg = value;
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

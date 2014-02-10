

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
    /// The entity of PurchaseMaxPriceMember. (partial class for auto-generation)
    /// <![CDATA[
    /// [primary-key]
    ///     
    /// 
    /// [column]
    ///     MEMBER_ID, MEMBER_NAME, PURCHASE_MAX_PRICE, MEMBER_STATUS_NAME, RN
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
    [Seasar.Dao.Attrs.Table("PurchaseMaxPriceMember")]
    [System.Serializable]
    public partial class PurchaseMaxPriceMember : Entity {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        #region Attribute
        /// <summary>MEMBER_ID: {NUMBER(16)}</summary>
        protected long? _memberId;

        /// <summary>MEMBER_NAME: {VARCHAR2(200)}</summary>
        protected String _memberName;

        /// <summary>PURCHASE_MAX_PRICE: {NUMBER(39)}</summary>
        protected decimal? _purchaseMaxPrice;

        /// <summary>MEMBER_STATUS_NAME: {VARCHAR2(50)}</summary>
        protected String _memberStatusName;

        /// <summary>RN: {NUMBER(39)}</summary>
        protected decimal? _rn;

        protected EntityModifiedProperties __modifiedProperties = new EntityModifiedProperties();
        #endregion

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public String TableDbName { get { return "PurchaseMaxPriceMember"; } }
        public String TablePropertyName { get { return "PurchaseMaxPriceMember"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public DBMeta DBMeta { get { return PurchaseMaxPriceMemberDbm.GetInstance(); } }

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
            if (other == null || !(other is PurchaseMaxPriceMember)) { return false; }
            PurchaseMaxPriceMember otherEntity = (PurchaseMaxPriceMember)other;
            if (!xSV(this.MemberId, otherEntity.MemberId)) { return false; }
            if (!xSV(this.MemberName, otherEntity.MemberName)) { return false; }
            if (!xSV(this.PurchaseMaxPrice, otherEntity.PurchaseMaxPrice)) { return false; }
            if (!xSV(this.MemberStatusName, otherEntity.MemberStatusName)) { return false; }
            if (!xSV(this.Rn, otherEntity.Rn)) { return false; }
            return true;
        }
        protected bool xSV(Object value1, Object value2) { // isSameValue()
            if (value1 == null && value2 == null) { return true; }
            if (value1 == null || value2 == null) { return false; }
            return value1.Equals(value2);
        }

        public override int GetHashCode() {
            int result = 17;
            result = xCH(result, _memberId);
            result = xCH(result, _memberName);
            result = xCH(result, _purchaseMaxPrice);
            result = xCH(result, _memberStatusName);
            result = xCH(result, _rn);
            return result;
        }
        protected int xCH(int result, Object value) { // calculateHashcode()
            if (value == null) { return result; }
            return (31*result) + (value is byte[] ? ((byte[])value).Length : value.GetHashCode());
        }

        public override String ToString() {
            return "PurchaseMaxPriceMember:" + BuildColumnString() + BuildRelationString();
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
            sb.Append(c).Append(this.MemberId);
            sb.Append(c).Append(this.MemberName);
            sb.Append(c).Append(this.PurchaseMaxPrice);
            sb.Append(c).Append(this.MemberStatusName);
            sb.Append(c).Append(this.Rn);
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
        /// <summary>MEMBER_ID: {NUMBER(16)}</summary>
        [Seasar.Dao.Attrs.Column("MEMBER_ID")]
        public long? MemberId {
            get { return _memberId; }
            set {
                __modifiedProperties.AddPropertyName("MemberId");
                _memberId = value;
            }
        }

        /// <summary>MEMBER_NAME: {VARCHAR2(200)}</summary>
        [Seasar.Dao.Attrs.Column("MEMBER_NAME")]
        public String MemberName {
            get { return _memberName; }
            set {
                __modifiedProperties.AddPropertyName("MemberName");
                _memberName = value;
            }
        }

        /// <summary>PURCHASE_MAX_PRICE: {NUMBER(39)}</summary>
        [Seasar.Dao.Attrs.Column("PURCHASE_MAX_PRICE")]
        public decimal? PurchaseMaxPrice {
            get { return _purchaseMaxPrice; }
            set {
                __modifiedProperties.AddPropertyName("PurchaseMaxPrice");
                _purchaseMaxPrice = value;
            }
        }

        /// <summary>MEMBER_STATUS_NAME: {VARCHAR2(50)}</summary>
        [Seasar.Dao.Attrs.Column("MEMBER_STATUS_NAME")]
        public String MemberStatusName {
            get { return _memberStatusName; }
            set {
                __modifiedProperties.AddPropertyName("MemberStatusName");
                _memberStatusName = value;
            }
        }

        /// <summary>RN: {NUMBER(39)}</summary>
        [Seasar.Dao.Attrs.Column("RN")]
        public decimal? Rn {
            get { return _rn; }
            set {
                __modifiedProperties.AddPropertyName("Rn");
                _rn = value;
            }
        }

        #endregion
    }
}

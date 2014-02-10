

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
    /// The entity of UnpaidSummaryMember. (partial class for auto-generation)
    /// <![CDATA[
    /// [primary-key]
    ///     UNPAID_MAN_ID
    /// 
    /// [column]
    ///     UNPAID_MAN_ID, UNPAID_MAN_NAME, UNPAID_PRICE_SUMMARY, STATUS_NAME
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
    [Seasar.Dao.Attrs.Table("UnpaidSummaryMember")]
    [System.Serializable]
    public partial class UnpaidSummaryMember : Entity {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        #region Attribute
        /// <summary>(会員ID)UNPAID_MAN_ID: {PK, INT(11), refers to member.MEMBER_ID}</summary>
        protected int? _unpaidManId;

        /// <summary>(会員名称)UNPAID_MAN_NAME: {VARCHAR(200), refers to member.MEMBER_NAME}</summary>
        protected String _unpaidManName;

        /// <summary>UNPAID_PRICE_SUMMARY: {DECIMAL(32)}</summary>
        protected decimal? _unpaidPriceSummary;

        /// <summary>STATUS_NAME: {VARCHAR(50), refers to member_status.MEMBER_STATUS_NAME}</summary>
        protected String _statusName;

        protected EntityModifiedProperties __modifiedProperties = new EntityModifiedProperties();
        #endregion

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public String TableDbName { get { return "UnpaidSummaryMember"; } }
        public String TablePropertyName { get { return "UnpaidSummaryMember"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public DBMeta DBMeta { get { return UnpaidSummaryMemberDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                Foreign Property
        //                                                                ================
        #region Foreign Property
        #endregion

        // ===============================================================================
        //                                                               Referrer Property
        //                                                               =================
        #region Referrer Property
        protected Member __innerDomain;

        protected Member innerDomain() {
            if (__innerDomain == null) {
                __innerDomain = new Member();
            }
            return __innerDomain;
        }

        public Member PrepareDomain() {
            innerDomain().MemberId = this.UnpaidManId;
            return innerDomain();
        }

        public IList<MemberAddress> MemberAddressList {
            get { return innerDomain().MemberAddressList; }
        }

        public IList<MemberLogin> MemberLoginList {
            get { return innerDomain().MemberLoginList; }
        }

        public IList<Purchase> PurchaseList {
            get { return innerDomain().PurchaseList; }
        }

        #endregion

        // ===============================================================================
        //                                                                   Determination
        //                                                                   =============
        public virtual bool HasPrimaryKeyValue {
            get {
                if (_unpaidManId == null) { return false; }
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
            if (other == null || !(other is UnpaidSummaryMember)) { return false; }
            UnpaidSummaryMember otherEntity = (UnpaidSummaryMember)other;
            if (!xSV(this.UnpaidManId, otherEntity.UnpaidManId)) { return false; }
            return true;
        }
        protected bool xSV(Object value1, Object value2) { // isSameValue()
            if (value1 == null && value2 == null) { return true; }
            if (value1 == null || value2 == null) { return false; }
            return value1.Equals(value2);
        }

        public override int GetHashCode() {
            int result = 17;
            result = xCH(result, _unpaidManId);
            return result;
        }
        protected int xCH(int result, Object value) { // calculateHashcode()
            if (value == null) { return result; }
            return (31*result) + (value is byte[] ? ((byte[])value).Length : value.GetHashCode());
        }

        public override String ToString() {
            return "UnpaidSummaryMember:" + BuildColumnString() + BuildRelationString();
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
            sb.Append(c).Append(this.UnpaidManId);
            sb.Append(c).Append(this.UnpaidManName);
            sb.Append(c).Append(this.UnpaidPriceSummary);
            sb.Append(c).Append(this.StatusName);
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
        /// <summary>(会員ID)UNPAID_MAN_ID: {PK, INT(11), refers to member.MEMBER_ID}</summary>
        /// <remarks>
        /// 連番
        /// </remarks>
        [Seasar.Dao.Attrs.Column("UNPAID_MAN_ID")]
        public int? UnpaidManId {
            get { return _unpaidManId; }
            set {
                __modifiedProperties.AddPropertyName("UnpaidManId");
                _unpaidManId = value;
            }
        }

        /// <summary>(会員名称)UNPAID_MAN_NAME: {VARCHAR(200), refers to member.MEMBER_NAME}</summary>
        /// <remarks>
        /// 会員の表示用の名称(姓名)
        /// </remarks>
        [Seasar.Dao.Attrs.Column("UNPAID_MAN_NAME")]
        public String UnpaidManName {
            get { return _unpaidManName; }
            set {
                __modifiedProperties.AddPropertyName("UnpaidManName");
                _unpaidManName = value;
            }
        }

        /// <summary>UNPAID_PRICE_SUMMARY: {DECIMAL(32)}</summary>
        [Seasar.Dao.Attrs.Column("UNPAID_PRICE_SUMMARY")]
        public decimal? UnpaidPriceSummary {
            get { return _unpaidPriceSummary; }
            set {
                __modifiedProperties.AddPropertyName("UnpaidPriceSummary");
                _unpaidPriceSummary = value;
            }
        }

        /// <summary>STATUS_NAME: {VARCHAR(50), refers to member_status.MEMBER_STATUS_NAME}</summary>
        [Seasar.Dao.Attrs.Column("STATUS_NAME")]
        public String StatusName {
            get { return _statusName; }
            set {
                __modifiedProperties.AddPropertyName("StatusName");
                _statusName = value;
            }
        }

        #endregion
    }
}

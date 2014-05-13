

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
    /// The entity of SUMMARY_MEMBER_PURCHASE as TABLE. (partial class for auto-generation)
    /// <![CDATA[
    /// snapshot table for snapshot DFNETEXDB.SUMMARY_MEMBER_PURCHASE
    /// 
    /// [primary-key]
    ///     
    /// 
    /// [column]
    ///     MEMBER_ID, ALLSUM_PURCHASE_PRICE, LATEST_PURCHASE_DATETIME
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
    [Seasar.Dao.Attrs.Table("SUMMARY_MEMBER_PURCHASE")]
    [System.Serializable]
    public partial class SummaryMemberPurchase : Entity {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        #region Attribute
        /// <summary>MEMBER_ID: {NotNull, NUMBER(16)}</summary>
        protected long? _memberId;

        /// <summary>ALLSUM_PURCHASE_PRICE: {NUMBER(22)}</summary>
        protected decimal? _allsumPurchasePrice;

        /// <summary>LATEST_PURCHASE_DATETIME: {DATE(7)}</summary>
        protected DateTime? _latestPurchaseDatetime;

        protected EntityModifiedProperties __modifiedProperties = new EntityModifiedProperties();
        #endregion

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public String TableDbName { get { return "SUMMARY_MEMBER_PURCHASE"; } }
        public String TablePropertyName { get { return "SummaryMemberPurchase"; } }

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
            if (other == null || !(other is SummaryMemberPurchase)) { return false; }
            SummaryMemberPurchase otherEntity = (SummaryMemberPurchase)other;
            if (!xSV(this.MemberId, otherEntity.MemberId)) { return false; }
            if (!xSV(this.AllsumPurchasePrice, otherEntity.AllsumPurchasePrice)) { return false; }
            if (!xSV(this.LatestPurchaseDatetime, otherEntity.LatestPurchaseDatetime)) { return false; }
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
            result = xCH(result, _allsumPurchasePrice);
            result = xCH(result, _latestPurchaseDatetime);
            return result;
        }
        protected int xCH(int result, Object value) { // calculateHashcode()
            if (value == null) { return result; }
            return (31*result) + (value is byte[] ? ((byte[])value).Length : value.GetHashCode());
        }

        public override String ToString() {
            return "SummaryMemberPurchase:" + BuildColumnString() + BuildRelationString();
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
            sb.Append(c).Append(this.AllsumPurchasePrice);
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
        /// <summary>MEMBER_ID: {NotNull, NUMBER(16)}</summary>
        [Seasar.Dao.Attrs.Column("MEMBER_ID")]
        public long? MemberId {
            get { return _memberId; }
            set {
                __modifiedProperties.AddPropertyName("MemberId");
                _memberId = value;
            }
        }

        /// <summary>ALLSUM_PURCHASE_PRICE: {NUMBER(22)}</summary>
        [Seasar.Dao.Attrs.Column("ALLSUM_PURCHASE_PRICE")]
        public decimal? AllsumPurchasePrice {
            get { return _allsumPurchasePrice; }
            set {
                __modifiedProperties.AddPropertyName("AllsumPurchasePrice");
                _allsumPurchasePrice = value;
            }
        }

        /// <summary>LATEST_PURCHASE_DATETIME: {DATE(7)}</summary>
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

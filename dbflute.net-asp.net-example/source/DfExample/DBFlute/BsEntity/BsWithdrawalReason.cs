

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
    /// The entity of WITHDRAWAL_REASON as TABLE. (partial class for auto-generation)
    /// <![CDATA[
    /// [primary-key]
    ///     WITHDRAWAL_REASON_CODE
    /// 
    /// [column]
    ///     WITHDRAWAL_REASON_CODE, WITHDRAWAL_REASON_TEXT, DISPLAY_ORDER
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
    ///     MEMBER_WITHDRAWAL, VD_SYNONYM_MEMBER_WITHDRAWAL
    /// 
    /// [foreign-property]
    ///     
    /// 
    /// [referrer-property]
    ///     memberWithdrawalList, vdSynonymMemberWithdrawalList
    /// ]]>
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    [Seasar.Dao.Attrs.Table("WITHDRAWAL_REASON")]
    [System.Serializable]
    public partial class WithdrawalReason : Entity {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        #region Attribute
        /// <summary>WITHDRAWAL_REASON_CODE: {PK, NotNull, CHAR(3)}</summary>
        protected String _withdrawalReasonCode;

        /// <summary>WITHDRAWAL_REASON_TEXT: {NotNull, CLOB(4000)}</summary>
        protected String _withdrawalReasonText;

        /// <summary>DISPLAY_ORDER: {UQ, NotNull, NUMBER(16)}</summary>
        protected long? _displayOrder;

        protected EntityModifiedProperties __modifiedProperties = new EntityModifiedProperties();
        #endregion

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public String TableDbName { get { return "WITHDRAWAL_REASON"; } }
        public String TablePropertyName { get { return "WithdrawalReason"; } }

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
        protected IList<MemberWithdrawal> _memberWithdrawalList;

        /// <summary>MEMBER_WITHDRAWAL as 'MemberWithdrawalList'.</summary>
        public IList<MemberWithdrawal> MemberWithdrawalList {
            get { if (_memberWithdrawalList == null) { _memberWithdrawalList = new List<MemberWithdrawal>(); } return _memberWithdrawalList; }
            set { _memberWithdrawalList = value; }
        }

        protected IList<VdSynonymMemberWithdrawal> _vdSynonymMemberWithdrawalList;

        /// <summary>VD_SYNONYM_MEMBER_WITHDRAWAL as 'VdSynonymMemberWithdrawalList'.</summary>
        public IList<VdSynonymMemberWithdrawal> VdSynonymMemberWithdrawalList {
            get { if (_vdSynonymMemberWithdrawalList == null) { _vdSynonymMemberWithdrawalList = new List<VdSynonymMemberWithdrawal>(); } return _vdSynonymMemberWithdrawalList; }
            set { _vdSynonymMemberWithdrawalList = value; }
        }

        #endregion

        // ===============================================================================
        //                                                                   Determination
        //                                                                   =============
        public virtual bool HasPrimaryKeyValue {
            get {
                if (_withdrawalReasonCode == null) { return false; }
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
            if (other == null || !(other is WithdrawalReason)) { return false; }
            WithdrawalReason otherEntity = (WithdrawalReason)other;
            if (!xSV(this.WithdrawalReasonCode, otherEntity.WithdrawalReasonCode)) { return false; }
            return true;
        }
        protected bool xSV(Object value1, Object value2) { // isSameValue()
            if (value1 == null && value2 == null) { return true; }
            if (value1 == null || value2 == null) { return false; }
            return value1.Equals(value2);
        }

        public override int GetHashCode() {
            int result = 17;
            result = xCH(result, _withdrawalReasonCode);
            return result;
        }
        protected int xCH(int result, Object value) { // calculateHashcode()
            if (value == null) { return result; }
            return (31*result) + (value is byte[] ? ((byte[])value).Length : value.GetHashCode());
        }

        public override String ToString() {
            return "WithdrawalReason:" + BuildColumnString() + BuildRelationString();
        }

        public virtual String ToStringWithRelation() {
            StringBuilder sb = new StringBuilder();
            sb.Append(ToString());
            String l = "\n  ";
            if (_memberWithdrawalList != null) { foreach (Entity e in _memberWithdrawalList)
            { if (e != null) { sb.Append(l).Append(xbRDS(e, "MemberWithdrawalList")); } } }
            if (_vdSynonymMemberWithdrawalList != null) { foreach (Entity e in _vdSynonymMemberWithdrawalList)
            { if (e != null) { sb.Append(l).Append(xbRDS(e, "VdSynonymMemberWithdrawalList")); } } }
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
            sb.Append(c).Append(this.WithdrawalReasonCode);
            sb.Append(c).Append(this.WithdrawalReasonText);
            sb.Append(c).Append(this.DisplayOrder);
            if (sb.Length > 0) { sb.Remove(0, c.Length); }
            sb.Insert(0, "{").Append("}");
            return sb.ToString();
        }
        protected virtual String BuildRelationString() {
            StringBuilder sb = new StringBuilder();
            String c = ",";
            if (_memberWithdrawalList != null && _memberWithdrawalList.Count > 0)
            { sb.Append(c).Append("MemberWithdrawalList"); }
            if (_vdSynonymMemberWithdrawalList != null && _vdSynonymMemberWithdrawalList.Count > 0)
            { sb.Append(c).Append("VdSynonymMemberWithdrawalList"); }
            if (sb.Length > 0) { sb.Remove(0, c.Length).Insert(0, "(").Append(")"); }
            return sb.ToString();
        }
        #endregion

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        #region Accessor
        /// <summary>WITHDRAWAL_REASON_CODE: {PK, NotNull, CHAR(3)}</summary>
        [Seasar.Dao.Attrs.Column("WITHDRAWAL_REASON_CODE")]
        public String WithdrawalReasonCode {
            get { return _withdrawalReasonCode; }
            set {
                __modifiedProperties.AddPropertyName("WithdrawalReasonCode");
                _withdrawalReasonCode = value;
            }
        }

        /// <summary>WITHDRAWAL_REASON_TEXT: {NotNull, CLOB(4000)}</summary>
        [Seasar.Dao.Attrs.Column("WITHDRAWAL_REASON_TEXT")]
        public String WithdrawalReasonText {
            get { return _withdrawalReasonText; }
            set {
                __modifiedProperties.AddPropertyName("WithdrawalReasonText");
                _withdrawalReasonText = value;
            }
        }

        /// <summary>DISPLAY_ORDER: {UQ, NotNull, NUMBER(16)}</summary>
        [Seasar.Dao.Attrs.Column("DISPLAY_ORDER")]
        public long? DisplayOrder {
            get { return _displayOrder; }
            set {
                __modifiedProperties.AddPropertyName("DisplayOrder");
                _displayOrder = value;
            }
        }

        #endregion
    }
}



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
    /// The entity of (会員退会情報)member_withdrawal as TABLE. (partial class for auto-generation)
    /// <![CDATA[
    /// [primary-key]
    ///     MEMBER_ID
    /// 
    /// [column]
    ///     MEMBER_ID, WITHDRAWAL_REASON_CODE, WITHDRAWAL_REASON_INPUT_TEXT, WITHDRAWAL_DATETIME, REGISTER_DATETIME, REGISTER_PROCESS, REGISTER_USER, UPDATE_DATETIME, UPDATE_PROCESS, UPDATE_USER, VERSION_NO
    /// 
    /// [sequence]
    ///     
    /// 
    /// [identity]
    ///     
    /// 
    /// [version-no]
    ///     VERSION_NO
    /// 
    /// [foreign-table]
    ///     member, withdrawal_reason
    /// 
    /// [referrer-table]
    ///     
    /// 
    /// [foreign-property]
    ///     member, withdrawalReason
    /// 
    /// [referrer-property]
    ///     
    /// ]]>
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    [Seasar.Dao.Attrs.Table("member_withdrawal")]
    [Seasar.Dao.Attrs.VersionNoProperty("VersionNo")]
    [System.Serializable]
    public partial class MemberWithdrawal : EntityDefinedCommonColumn {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        #region Attribute
        /// <summary>MEMBER_ID: {PK, IX, NotNull, INT(10), FK to member}</summary>
        protected int? _memberId;

        /// <summary>WITHDRAWAL_REASON_CODE: {IX, CHAR(3), FK to withdrawal_reason}</summary>
        protected String _withdrawalReasonCode;

        /// <summary>WITHDRAWAL_REASON_INPUT_TEXT: {TEXT(65535)}</summary>
        protected String _withdrawalReasonInputText;

        /// <summary>WITHDRAWAL_DATETIME: {NotNull, DATETIME(19)}</summary>
        protected DateTime? _withdrawalDatetime;

        /// <summary>REGISTER_DATETIME: {NotNull, DATETIME(19)}</summary>
        protected DateTime? _registerDatetime;

        /// <summary>REGISTER_PROCESS: {NotNull, VARCHAR(200)}</summary>
        protected String _registerProcess;

        /// <summary>REGISTER_USER: {NotNull, VARCHAR(200)}</summary>
        protected String _registerUser;

        /// <summary>UPDATE_DATETIME: {NotNull, DATETIME(19)}</summary>
        protected DateTime? _updateDatetime;

        /// <summary>UPDATE_PROCESS: {NotNull, VARCHAR(200)}</summary>
        protected String _updateProcess;

        /// <summary>UPDATE_USER: {NotNull, VARCHAR(200)}</summary>
        protected String _updateUser;

        /// <summary>VERSION_NO: {NotNull, BIGINT(19)}</summary>
        protected long? _versionNo;

        protected EntityModifiedProperties __modifiedProperties = new EntityModifiedProperties();

        protected bool __canCommonColumnAutoSetup = true;
        #endregion

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public String TableDbName { get { return "member_withdrawal"; } }
        public String TablePropertyName { get { return "MemberWithdrawal"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public DBMeta DBMeta { get { return DBMetaInstanceHandler.FindDBMeta(TableDbName); } }

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

        protected WithdrawalReason _withdrawalReason;

        /// <summary>withdrawal_reason as 'WithdrawalReason'.</summary>
        [Seasar.Dao.Attrs.Relno(1), Seasar.Dao.Attrs.Relkeys("WITHDRAWAL_REASON_CODE:WITHDRAWAL_REASON_CODE")]
        public WithdrawalReason WithdrawalReason {
            get { return _withdrawalReason; }
            set { _withdrawalReason = value; }
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
                if (_memberId == null) { return false; }
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
            if (other == null || !(other is MemberWithdrawal)) { return false; }
            MemberWithdrawal otherEntity = (MemberWithdrawal)other;
            if (!xSV(this.MemberId, otherEntity.MemberId)) { return false; }
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
            return result;
        }
        protected int xCH(int result, Object value) { // calculateHashcode()
            if (value == null) { return result; }
            return (31*result) + (value is byte[] ? ((byte[])value).Length : value.GetHashCode());
        }

        public override String ToString() {
            return "MemberWithdrawal:" + BuildColumnString() + BuildRelationString();
        }

        public virtual String ToStringWithRelation() {
            StringBuilder sb = new StringBuilder();
            sb.Append(ToString());
            String l = "\n  ";
            if (_member != null)
            { sb.Append(l).Append(xbRDS(_member, "Member")); }
            if (_withdrawalReason != null)
            { sb.Append(l).Append(xbRDS(_withdrawalReason, "WithdrawalReason")); }
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
            sb.Append(c).Append(this.MemberId);
            sb.Append(c).Append(this.WithdrawalReasonCode);
            sb.Append(c).Append(this.WithdrawalReasonInputText);
            sb.Append(c).Append(this.WithdrawalDatetime);
            sb.Append(c).Append(this.RegisterDatetime);
            sb.Append(c).Append(this.RegisterProcess);
            sb.Append(c).Append(this.RegisterUser);
            sb.Append(c).Append(this.UpdateDatetime);
            sb.Append(c).Append(this.UpdateProcess);
            sb.Append(c).Append(this.UpdateUser);
            sb.Append(c).Append(this.VersionNo);
            if (sb.Length > 0) { sb.Remove(0, c.Length); }
            sb.Insert(0, "{").Append("}");
            return sb.ToString();
        }
        protected virtual String BuildRelationString() {
            StringBuilder sb = new StringBuilder();
            String c = ",";
            if (_member != null) { sb.Append(c).Append("Member"); }
            if (_withdrawalReason != null) { sb.Append(c).Append("WithdrawalReason"); }
            if (sb.Length > 0) { sb.Remove(0, c.Length).Insert(0, "(").Append(")"); }
            return sb.ToString();
        }
        #endregion

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        #region Accessor
        /// <summary>MEMBER_ID: {PK, IX, NotNull, INT(10), FK to member}</summary>
        [Seasar.Dao.Attrs.Column("MEMBER_ID")]
        public int? MemberId {
            get { return _memberId; }
            set {
                __modifiedProperties.AddPropertyName("MemberId");
                _memberId = value;
            }
        }

        /// <summary>WITHDRAWAL_REASON_CODE: {IX, CHAR(3), FK to withdrawal_reason}</summary>
        [Seasar.Dao.Attrs.Column("WITHDRAWAL_REASON_CODE")]
        public String WithdrawalReasonCode {
            get { return _withdrawalReasonCode; }
            set {
                __modifiedProperties.AddPropertyName("WithdrawalReasonCode");
                _withdrawalReasonCode = value;
            }
        }

        /// <summary>WITHDRAWAL_REASON_INPUT_TEXT: {TEXT(65535)}</summary>
        [Seasar.Dao.Attrs.Column("WITHDRAWAL_REASON_INPUT_TEXT")]
        public String WithdrawalReasonInputText {
            get { return _withdrawalReasonInputText; }
            set {
                __modifiedProperties.AddPropertyName("WithdrawalReasonInputText");
                _withdrawalReasonInputText = value;
            }
        }

        /// <summary>WITHDRAWAL_DATETIME: {NotNull, DATETIME(19)}</summary>
        [Seasar.Dao.Attrs.Column("WITHDRAWAL_DATETIME")]
        public DateTime? WithdrawalDatetime {
            get { return _withdrawalDatetime; }
            set {
                __modifiedProperties.AddPropertyName("WithdrawalDatetime");
                _withdrawalDatetime = value;
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

        /// <summary>REGISTER_PROCESS: {NotNull, VARCHAR(200)}</summary>
        [Seasar.Dao.Attrs.Column("REGISTER_PROCESS")]
        public String RegisterProcess {
            get { return _registerProcess; }
            set {
                __modifiedProperties.AddPropertyName("RegisterProcess");
                _registerProcess = value;
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

        /// <summary>UPDATE_DATETIME: {NotNull, DATETIME(19)}</summary>
        [Seasar.Dao.Attrs.Column("UPDATE_DATETIME")]
        public DateTime? UpdateDatetime {
            get { return _updateDatetime; }
            set {
                __modifiedProperties.AddPropertyName("UpdateDatetime");
                _updateDatetime = value;
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

        /// <summary>UPDATE_USER: {NotNull, VARCHAR(200)}</summary>
        [Seasar.Dao.Attrs.Column("UPDATE_USER")]
        public String UpdateUser {
            get { return _updateUser; }
            set {
                __modifiedProperties.AddPropertyName("UpdateUser");
                _updateUser = value;
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

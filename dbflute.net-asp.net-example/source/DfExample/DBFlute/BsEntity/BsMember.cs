

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
    /// The entity of (会員)MEMBER as TABLE. (partial class for auto-generation)
    /// <![CDATA[
    /// 会員登録時にInsertされる。
    /// 物理削除されることはない
    /// 
    /// [primary-key]
    ///     MEMBER_ID
    /// 
    /// [column]
    ///     MEMBER_ID, MEMBER_NAME, MEMBER_ACCOUNT, MEMBER_STATUS_CODE, FORMALIZED_DATETIME, BIRTHDATE, REGISTER_DATETIME, REGISTER_USER, REGISTER_PROCESS, UPDATE_DATETIME, UPDATE_USER, UPDATE_PROCESS, VERSION_NO
    /// 
    /// [sequence]
    ///     SEQ_MEMBER
    /// 
    /// [identity]
    ///     
    /// 
    /// [version-no]
    ///     VERSION_NO
    /// 
    /// [foreign-table]
    ///     MEMBER_STATUS, MEMBER_LOGIN(AsLatest), MEMBER_SECURITY(AsOne), MEMBER_WITHDRAWAL(AsOne)
    /// 
    /// [referrer-table]
    ///     MEMBER_ADDRESS, MEMBER_LOGIN, PURCHASE, MEMBER_SECURITY, MEMBER_WITHDRAWAL
    /// 
    /// [foreign-property]
    ///     memberStatus, memberLoginAsLatest, memberSecurityAsOne, memberWithdrawalAsOne
    /// 
    /// [referrer-property]
    ///     memberAddressList, memberLoginList, purchaseList
    /// ]]>
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    [Seasar.Dao.Attrs.Table("MEMBER")]
    [Seasar.Dao.Attrs.VersionNoProperty("VersionNo")]
    [System.Serializable]
    public partial class Member : EntityDefinedCommonColumn {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        #region Attribute
        /// <summary>(会員ID)MEMBER_ID: {PK, NotNull, NUMBER(16), FK to MEMBER_LOGIN}</summary>
        protected long? _memberId;

        /// <summary>(会員名称)MEMBER_NAME: {IX, NotNull, VARCHAR2(200)}</summary>
        protected String _memberName;

        /// <summary>(会員アカウント)MEMBER_ACCOUNT: {UQ, NotNull, VARCHAR2(50)}</summary>
        protected String _memberAccount;

        /// <summary>(会員ステータスコード)MEMBER_STATUS_CODE: {NotNull, CHAR(3), FK to MEMBER_STATUS, classification=MemberStatus}</summary>
        protected String _memberStatusCode;

        /// <summary>(正式会員日時)FORMALIZED_DATETIME: {IX, TIMESTAMP(3)(11, 3)}</summary>
        protected DateTime? _formalizedDatetime;

        /// <summary>(生年月日)BIRTHDATE: {DATE(7)}</summary>
        protected DateTime? _birthdate;

        /// <summary>(登録日時)REGISTER_DATETIME: {NotNull, DATE(7)}</summary>
        protected DateTime? _registerDatetime;

        /// <summary>(登録ユーザ)REGISTER_USER: {NotNull, VARCHAR2(200)}</summary>
        protected String _registerUser;

        /// <summary>(登録プロセス)REGISTER_PROCESS: {NotNull, VARCHAR2(200)}</summary>
        protected String _registerProcess;

        /// <summary>(更新日時)UPDATE_DATETIME: {NotNull, DATE(7)}</summary>
        protected DateTime? _updateDatetime;

        /// <summary>(更新ユーザ)UPDATE_USER: {NotNull, VARCHAR2(200)}</summary>
        protected String _updateUser;

        /// <summary>(更新プロセス)UPDATE_PROCESS: {NotNull, VARCHAR2(200)}</summary>
        protected String _updateProcess;

        /// <summary>(バージョンNO)VERSION_NO: {NotNull, NUMBER(16)}</summary>
        protected long? _versionNo;

        protected EntityModifiedProperties __modifiedProperties = new EntityModifiedProperties();

        protected bool __canCommonColumnAutoSetup = true;
        #endregion

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public String TableDbName { get { return "MEMBER"; } }
        public String TablePropertyName { get { return "Member"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public DBMeta DBMeta { get { return DBMetaInstanceHandler.FindDBMeta(TableDbName); } }

        // ===============================================================================
        //                                                         Classification Property
        //                                                         =======================
        #region Classification Property
        public CDef.MemberStatus MemberStatusCodeAsMemberStatus { get {
            return CDef.MemberStatus.CodeOf(_memberStatusCode);
        } set {
            MemberStatusCode = value != null ? value.Code : null;
        }}

        #endregion

        // ===============================================================================
        //                                                          Classification Setting
        //                                                          ======================
        #region Classification Setting
        /// <summary>
        /// Set the value of memberStatusCode as Provisional.
        /// <![CDATA[
        /// Provisional: 仮会員を示す
        /// ]]>
        /// </summary>
        public void SetMemberStatusCode_Provisional() {
            MemberStatusCodeAsMemberStatus = CDef.MemberStatus.Provisional;
        }

        /// <summary>
        /// Set the value of memberStatusCode as Formalized.
        /// <![CDATA[
        /// Formalized: 正式会員を示す
        /// ]]>
        /// </summary>
        public void SetMemberStatusCode_Formalized() {
            MemberStatusCodeAsMemberStatus = CDef.MemberStatus.Formalized;
        }

        /// <summary>
        /// Set the value of memberStatusCode as Withdrawal.
        /// <![CDATA[
        /// Withdrawal: 退会会員を示す
        /// ]]>
        /// </summary>
        public void SetMemberStatusCode_Withdrawal() {
            MemberStatusCodeAsMemberStatus = CDef.MemberStatus.Withdrawal;
        }

        #endregion

        // ===============================================================================
        //                                                    Classification Determination
        //                                                    ============================
        #region Classification Determination
        /// <summary>
        /// Is the value of memberStatusCode 'Provisional'?
        /// <![CDATA[
        /// The difference of capital letters and small letters is NOT distinguished.
        /// If the value is null, this method returns false!
        /// Provisional: 仮会員を示す
        /// ]]>
        /// </summary>
        public bool IsMemberStatusCodeProvisional {
            get {
                CDef.MemberStatus cls = MemberStatusCodeAsMemberStatus;
                return cls != null ? cls.Equals(CDef.MemberStatus.Provisional) : false;
            }
        }

        /// <summary>
        /// Is the value of memberStatusCode 'Formalized'?
        /// <![CDATA[
        /// The difference of capital letters and small letters is NOT distinguished.
        /// If the value is null, this method returns false!
        /// Formalized: 正式会員を示す
        /// ]]>
        /// </summary>
        public bool IsMemberStatusCodeFormalized {
            get {
                CDef.MemberStatus cls = MemberStatusCodeAsMemberStatus;
                return cls != null ? cls.Equals(CDef.MemberStatus.Formalized) : false;
            }
        }

        /// <summary>
        /// Is the value of memberStatusCode 'Withdrawal'?
        /// <![CDATA[
        /// The difference of capital letters and small letters is NOT distinguished.
        /// If the value is null, this method returns false!
        /// Withdrawal: 退会会員を示す
        /// ]]>
        /// </summary>
        public bool IsMemberStatusCodeWithdrawal {
            get {
                CDef.MemberStatus cls = MemberStatusCodeAsMemberStatus;
                return cls != null ? cls.Equals(CDef.MemberStatus.Withdrawal) : false;
            }
        }

        #endregion

        // ===============================================================================
        //                                                       Classification Name/Alias
        //                                                       =========================
        #region Classification Name/Alias
        public String MemberStatusCodeName {
            get {
                CDef.MemberStatus cls = MemberStatusCodeAsMemberStatus;
                return cls != null ? cls.Name : null;
            }
        }
        #endregion

        // ===============================================================================
        //                                                                Foreign Property
        //                                                                ================
        #region Foreign Property
        protected MemberStatus _memberStatus;

        /// <summary>(会員ステータス)MEMBER_STATUS as 'MemberStatus'.</summary>
        [Seasar.Dao.Attrs.Relno(0), Seasar.Dao.Attrs.Relkeys("MEMBER_STATUS_CODE:MEMBER_STATUS_CODE")]
        public MemberStatus MemberStatus {
            get { return _memberStatus; }
            set { _memberStatus = value; }
        }

        protected MemberLogin _memberLoginAsLatest;

        /// <summary>(会員ログイン)MEMBER_LOGIN as 'MemberLoginAsLatest'.</summary>
        [Seasar.Dao.Attrs.Relno(1), Seasar.Dao.Attrs.Relkeys("MEMBER_ID:MEMBER_ID")]
        public MemberLogin MemberLoginAsLatest {
            get { return _memberLoginAsLatest; }
            set { _memberLoginAsLatest = value; }
        }

        protected MemberSecurity _memberSecurityAsOne;

        /// <summary>MEMBER_SECURITY as 'MemberSecurityAsOne'.</summary>
        [Seasar.Dao.Attrs.Relno(2), Seasar.Dao.Attrs.Relkeys("MEMBER_ID:MEMBER_ID")]
        public MemberSecurity MemberSecurityAsOne {
            get { return _memberSecurityAsOne; }
            set { _memberSecurityAsOne = value; }
        }

        protected MemberWithdrawal _memberWithdrawalAsOne;

        /// <summary>MEMBER_WITHDRAWAL as 'MemberWithdrawalAsOne'.</summary>
        [Seasar.Dao.Attrs.Relno(3), Seasar.Dao.Attrs.Relkeys("MEMBER_ID:MEMBER_ID")]
        public MemberWithdrawal MemberWithdrawalAsOne {
            get { return _memberWithdrawalAsOne; }
            set { _memberWithdrawalAsOne = value; }
        }

        #endregion

        // ===============================================================================
        //                                                               Referrer Property
        //                                                               =================
        #region Referrer Property
        protected IList<MemberAddress> _memberAddressList;

        /// <summary>MEMBER_ADDRESS as 'MemberAddressList'.</summary>
        public IList<MemberAddress> MemberAddressList {
            get { if (_memberAddressList == null) { _memberAddressList = new List<MemberAddress>(); } return _memberAddressList; }
            set { _memberAddressList = value; }
        }

        protected IList<MemberLogin> _memberLoginList;

        /// <summary>(会員ログイン)MEMBER_LOGIN as 'MemberLoginList'.</summary>
        public IList<MemberLogin> MemberLoginList {
            get { if (_memberLoginList == null) { _memberLoginList = new List<MemberLogin>(); } return _memberLoginList; }
            set { _memberLoginList = value; }
        }

        protected IList<Purchase> _purchaseList;

        /// <summary>(購入)PURCHASE as 'PurchaseList'.</summary>
        public IList<Purchase> PurchaseList {
            get { if (_purchaseList == null) { _purchaseList = new List<Purchase>(); } return _purchaseList; }
            set { _purchaseList = value; }
        }

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
            if (other == null || !(other is Member)) { return false; }
            Member otherEntity = (Member)other;
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
            return "Member:" + BuildColumnString() + BuildRelationString();
        }

        public virtual String ToStringWithRelation() {
            StringBuilder sb = new StringBuilder();
            sb.Append(ToString());
            String l = "\n  ";
            if (_memberStatus != null)
            { sb.Append(l).Append(xbRDS(_memberStatus, "MemberStatus")); }
            if (_memberLoginAsLatest != null)
            { sb.Append(l).Append(xbRDS(_memberLoginAsLatest, "MemberLoginAsLatest")); }
            if (_memberSecurityAsOne != null)
            { sb.Append(l).Append(xbRDS(_memberSecurityAsOne, "MemberSecurityAsOne")); }
            if (_memberWithdrawalAsOne != null)
            { sb.Append(l).Append(xbRDS(_memberWithdrawalAsOne, "MemberWithdrawalAsOne")); }
            if (_memberAddressList != null) { foreach (Entity e in _memberAddressList)
            { if (e != null) { sb.Append(l).Append(xbRDS(e, "MemberAddressList")); } } }
            if (_memberLoginList != null) { foreach (Entity e in _memberLoginList)
            { if (e != null) { sb.Append(l).Append(xbRDS(e, "MemberLoginList")); } } }
            if (_purchaseList != null) { foreach (Entity e in _purchaseList)
            { if (e != null) { sb.Append(l).Append(xbRDS(e, "PurchaseList")); } } }
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
            sb.Append(c).Append(this.MemberName);
            sb.Append(c).Append(this.MemberAccount);
            sb.Append(c).Append(this.MemberStatusCode);
            sb.Append(c).Append(this.FormalizedDatetime);
            sb.Append(c).Append(this.Birthdate);
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
            if (_memberStatus != null) { sb.Append(c).Append("MemberStatus"); }
            if (_memberLoginAsLatest != null) { sb.Append(c).Append("MemberLoginAsLatest"); }
            if (_memberSecurityAsOne != null) { sb.Append(c).Append("MemberSecurityAsOne"); }
            if (_memberWithdrawalAsOne != null) { sb.Append(c).Append("MemberWithdrawalAsOne"); }
            if (_memberAddressList != null && _memberAddressList.Count > 0)
            { sb.Append(c).Append("MemberAddressList"); }
            if (_memberLoginList != null && _memberLoginList.Count > 0)
            { sb.Append(c).Append("MemberLoginList"); }
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
        /// <summary>(会員ID)MEMBER_ID: {PK, NotNull, NUMBER(16), FK to MEMBER_LOGIN}</summary>
        /// <remarks>
        /// 連番
        /// </remarks>
        [Seasar.Dao.Attrs.Column("MEMBER_ID")]
        public long? MemberId {
            get { return _memberId; }
            set {
                __modifiedProperties.AddPropertyName("MemberId");
                _memberId = value;
            }
        }

        /// <summary>(会員名称)MEMBER_NAME: {IX, NotNull, VARCHAR2(200)}</summary>
        /// <remarks>
        /// 会員検索の条件となる。
        /// </remarks>
        [Seasar.Dao.Attrs.Column("MEMBER_NAME")]
        public String MemberName {
            get { return _memberName; }
            set {
                __modifiedProperties.AddPropertyName("MemberName");
                _memberName = value;
            }
        }

        /// <summary>(会員アカウント)MEMBER_ACCOUNT: {UQ, NotNull, VARCHAR2(50)}</summary>
        /// <remarks>
        /// ログインに利用。
        /// 完全にユニークである
        /// </remarks>
        [Seasar.Dao.Attrs.Column("MEMBER_ACCOUNT")]
        public String MemberAccount {
            get { return _memberAccount; }
            set {
                __modifiedProperties.AddPropertyName("MemberAccount");
                _memberAccount = value;
            }
        }

        /// <summary>(会員ステータスコード)MEMBER_STATUS_CODE: {NotNull, CHAR(3), FK to MEMBER_STATUS, classification=MemberStatus}</summary>
        [Seasar.Dao.Attrs.Column("MEMBER_STATUS_CODE")]
        public String MemberStatusCode {
            get { return _memberStatusCode; }
            set {
                __modifiedProperties.AddPropertyName("MemberStatusCode");
                _memberStatusCode = value;
            }
        }

        /// <summary>(正式会員日時)FORMALIZED_DATETIME: {IX, TIMESTAMP(3)(11, 3)}</summary>
        /// <remarks>
        /// 正式会員になったら値が格納される
        /// </remarks>
        [Seasar.Dao.Attrs.Column("FORMALIZED_DATETIME")]
        public DateTime? FormalizedDatetime {
            get { return _formalizedDatetime; }
            set {
                __modifiedProperties.AddPropertyName("FormalizedDatetime");
                _formalizedDatetime = value;
            }
        }

        /// <summary>(生年月日)BIRTHDATE: {DATE(7)}</summary>
        /// <remarks>
        /// わからない場合はnull
        /// </remarks>
        [Seasar.Dao.Attrs.Column("BIRTHDATE")]
        public DateTime? Birthdate {
            get { return _birthdate; }
            set {
                __modifiedProperties.AddPropertyName("Birthdate");
                _birthdate = value;
            }
        }

        /// <summary>(登録日時)REGISTER_DATETIME: {NotNull, DATE(7)}</summary>
        [Seasar.Dao.Attrs.Column("REGISTER_DATETIME")]
        public DateTime? RegisterDatetime {
            get { return _registerDatetime; }
            set {
                __modifiedProperties.AddPropertyName("RegisterDatetime");
                _registerDatetime = value;
            }
        }

        /// <summary>(登録ユーザ)REGISTER_USER: {NotNull, VARCHAR2(200)}</summary>
        [Seasar.Dao.Attrs.Column("REGISTER_USER")]
        public String RegisterUser {
            get { return _registerUser; }
            set {
                __modifiedProperties.AddPropertyName("RegisterUser");
                _registerUser = value;
            }
        }

        /// <summary>(登録プロセス)REGISTER_PROCESS: {NotNull, VARCHAR2(200)}</summary>
        [Seasar.Dao.Attrs.Column("REGISTER_PROCESS")]
        public String RegisterProcess {
            get { return _registerProcess; }
            set {
                __modifiedProperties.AddPropertyName("RegisterProcess");
                _registerProcess = value;
            }
        }

        /// <summary>(更新日時)UPDATE_DATETIME: {NotNull, DATE(7)}</summary>
        [Seasar.Dao.Attrs.Column("UPDATE_DATETIME")]
        public DateTime? UpdateDatetime {
            get { return _updateDatetime; }
            set {
                __modifiedProperties.AddPropertyName("UpdateDatetime");
                _updateDatetime = value;
            }
        }

        /// <summary>(更新ユーザ)UPDATE_USER: {NotNull, VARCHAR2(200)}</summary>
        [Seasar.Dao.Attrs.Column("UPDATE_USER")]
        public String UpdateUser {
            get { return _updateUser; }
            set {
                __modifiedProperties.AddPropertyName("UpdateUser");
                _updateUser = value;
            }
        }

        /// <summary>(更新プロセス)UPDATE_PROCESS: {NotNull, VARCHAR2(200)}</summary>
        [Seasar.Dao.Attrs.Column("UPDATE_PROCESS")]
        public String UpdateProcess {
            get { return _updateProcess; }
            set {
                __modifiedProperties.AddPropertyName("UpdateProcess");
                _updateProcess = value;
            }
        }

        /// <summary>(バージョンNO)VERSION_NO: {NotNull, NUMBER(16)}</summary>
        /// <remarks>
        /// 排他制御に利用される
        /// </remarks>
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

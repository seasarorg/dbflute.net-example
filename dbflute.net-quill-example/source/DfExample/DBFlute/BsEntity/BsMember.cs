

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
    /// The entity of (会員)member as TABLE. (partial class for auto-generation)
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
    ///     
    /// 
    /// [identity]
    ///     MEMBER_ID
    /// 
    /// [version-no]
    ///     VERSION_NO
    /// 
    /// [foreign-table]
    ///     member_status, MEMBER_LOGIN(AsLatest), MEMBER_ADDRESS(AsValid), member_security(AsOne), member_withdrawal(AsOne)
    /// 
    /// [referrer-table]
    ///     member_address, member_login, purchase, member_security, member_withdrawal
    /// 
    /// [foreign-property]
    ///     memberStatus, memberLoginAsLatest, memberAddressAsValid, memberLoginAsLocalForeignOverTest, memberLoginAsForeignForeignOverTest, memberLoginAsForeignForeignParameterOverTest, memberLoginAsForeignForeignVariousOverTest, memberLoginAsReferrerOverTest, memberLoginAsReferrerForeignOverTest, memberSecurityAsOne, memberWithdrawalAsOne
    /// 
    /// [referrer-property]
    ///     memberAddressList, memberLoginList, purchaseList
    /// ]]>
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    [Seasar.Dao.Attrs.Table("member")]
    [Seasar.Dao.Attrs.VersionNoProperty("VersionNo")]
    [System.Serializable]
    public partial class Member : EntityDefinedCommonColumn {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        #region Attribute
        /// <summary>(会員ID)MEMBER_ID: {PK, ID, NotNull, INT(10), FK to MEMBER_LOGIN}</summary>
        protected int? _memberId;

        /// <summary>(会員名称)MEMBER_NAME: {IX, NotNull, VARCHAR(200)}</summary>
        protected String _memberName;

        /// <summary>(会員アカウント)MEMBER_ACCOUNT: {UQ, NotNull, VARCHAR(50)}</summary>
        protected String _memberAccount;

        /// <summary>MEMBER_STATUS_CODE: {IX, NotNull, CHAR(3), FK to member_status, classification=MemberStatus}</summary>
        protected String _memberStatusCode;

        /// <summary>FORMALIZED_DATETIME: {IX, DATETIME(19)}</summary>
        protected DateTime? _formalizedDatetime;

        /// <summary>BIRTHDATE: {DATE(10)}</summary>
        protected DateTime? _birthdate;

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
        public String TableDbName { get { return "member"; } }
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
        /// 仮会員: 仮会員を示す
        /// ]]>
        /// </summary>
        public void SetMemberStatusCode_Provisional() {
            MemberStatusCodeAsMemberStatus = CDef.MemberStatus.Provisional;
        }

        /// <summary>
        /// Set the value of memberStatusCode as Formalized.
        /// <![CDATA[
        /// 正式会員: 正式会員を示す
        /// ]]>
        /// </summary>
        public void SetMemberStatusCode_Formalized() {
            MemberStatusCodeAsMemberStatus = CDef.MemberStatus.Formalized;
        }

        /// <summary>
        /// Set the value of memberStatusCode as Withdrawal.
        /// <![CDATA[
        /// 退会会員: 退会会員を示す
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
        /// 仮会員: 仮会員を示す
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
        /// 正式会員: 正式会員を示す
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
        /// 退会会員: 退会会員を示す
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
        public String MemberStatusCodeAlias {
            get {
                CDef.MemberStatus cls = MemberStatusCodeAsMemberStatus;
                return cls != null ? cls.Alias : null;
            }
        }

        #endregion

        // ===============================================================================
        //                                                                Foreign Property
        //                                                                ================
        #region Foreign Property
        protected MemberStatus _memberStatus;

        /// <summary>member_status as 'MemberStatus'.</summary>
        [Seasar.Dao.Attrs.Relno(0), Seasar.Dao.Attrs.Relkeys("MEMBER_STATUS_CODE:MEMBER_STATUS_CODE")]
        public MemberStatus MemberStatus {
            get { return _memberStatus; }
            set { _memberStatus = value; }
        }

        protected MemberLogin _memberLoginAsLatest;

        /// <summary>member_login as 'MemberLoginAsLatest'.</summary>
        [Seasar.Dao.Attrs.Relno(1), Seasar.Dao.Attrs.Relkeys("MEMBER_ID:MEMBER_ID")]
        public MemberLogin MemberLoginAsLatest {
            get { return _memberLoginAsLatest; }
            set { _memberLoginAsLatest = value; }
        }

        protected MemberAddress _memberAddressAsValid;

        /// <summary>member_address as 'MemberAddressAsValid'.</summary>
        [Seasar.Dao.Attrs.Relno(2), Seasar.Dao.Attrs.Relkeys("MEMBER_ID:MEMBER_ID")]
        public MemberAddress MemberAddressAsValid {
            get { return _memberAddressAsValid; }
            set { _memberAddressAsValid = value; }
        }

        protected MemberLogin _memberLoginAsLocalForeignOverTest;

        /// <summary>member_login as 'MemberLoginAsLocalForeignOverTest'.</summary>
        [Seasar.Dao.Attrs.Relno(3), Seasar.Dao.Attrs.Relkeys("MEMBER_ID:MEMBER_ID")]
        public MemberLogin MemberLoginAsLocalForeignOverTest {
            get { return _memberLoginAsLocalForeignOverTest; }
            set { _memberLoginAsLocalForeignOverTest = value; }
        }

        protected MemberLogin _memberLoginAsForeignForeignOverTest;

        /// <summary>member_login as 'MemberLoginAsForeignForeignOverTest'.</summary>
        [Seasar.Dao.Attrs.Relno(4), Seasar.Dao.Attrs.Relkeys("MEMBER_ID:MEMBER_ID")]
        public MemberLogin MemberLoginAsForeignForeignOverTest {
            get { return _memberLoginAsForeignForeignOverTest; }
            set { _memberLoginAsForeignForeignOverTest = value; }
        }

        protected MemberLogin _memberLoginAsForeignForeignParameterOverTest;

        /// <summary>member_login as 'MemberLoginAsForeignForeignParameterOverTest'.</summary>
        [Seasar.Dao.Attrs.Relno(5), Seasar.Dao.Attrs.Relkeys("MEMBER_ID:MEMBER_ID")]
        public MemberLogin MemberLoginAsForeignForeignParameterOverTest {
            get { return _memberLoginAsForeignForeignParameterOverTest; }
            set { _memberLoginAsForeignForeignParameterOverTest = value; }
        }

        protected MemberLogin _memberLoginAsForeignForeignVariousOverTest;

        /// <summary>member_login as 'MemberLoginAsForeignForeignVariousOverTest'.</summary>
        [Seasar.Dao.Attrs.Relno(6), Seasar.Dao.Attrs.Relkeys("MEMBER_ID:MEMBER_ID")]
        public MemberLogin MemberLoginAsForeignForeignVariousOverTest {
            get { return _memberLoginAsForeignForeignVariousOverTest; }
            set { _memberLoginAsForeignForeignVariousOverTest = value; }
        }

        protected MemberLogin _memberLoginAsReferrerOverTest;

        /// <summary>member_login as 'MemberLoginAsReferrerOverTest'.</summary>
        [Seasar.Dao.Attrs.Relno(7), Seasar.Dao.Attrs.Relkeys("MEMBER_ID:MEMBER_ID")]
        public MemberLogin MemberLoginAsReferrerOverTest {
            get { return _memberLoginAsReferrerOverTest; }
            set { _memberLoginAsReferrerOverTest = value; }
        }

        protected MemberLogin _memberLoginAsReferrerForeignOverTest;

        /// <summary>member_login as 'MemberLoginAsReferrerForeignOverTest'.</summary>
        [Seasar.Dao.Attrs.Relno(8), Seasar.Dao.Attrs.Relkeys("MEMBER_ID:MEMBER_ID")]
        public MemberLogin MemberLoginAsReferrerForeignOverTest {
            get { return _memberLoginAsReferrerForeignOverTest; }
            set { _memberLoginAsReferrerForeignOverTest = value; }
        }

        protected MemberSecurity _memberSecurityAsOne;

        /// <summary>member_security as 'MemberSecurityAsOne'.</summary>
        [Seasar.Dao.Attrs.Relno(9), Seasar.Dao.Attrs.Relkeys("MEMBER_ID:MEMBER_ID")]
        public MemberSecurity MemberSecurityAsOne {
            get { return _memberSecurityAsOne; }
            set { _memberSecurityAsOne = value; }
        }

        protected MemberWithdrawal _memberWithdrawalAsOne;

        /// <summary>(会員退会情報)member_withdrawal as 'MemberWithdrawalAsOne'.</summary>
        [Seasar.Dao.Attrs.Relno(10), Seasar.Dao.Attrs.Relkeys("MEMBER_ID:MEMBER_ID")]
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

        /// <summary>member_address as 'MemberAddressList'.</summary>
        public IList<MemberAddress> MemberAddressList {
            get { if (_memberAddressList == null) { _memberAddressList = new List<MemberAddress>(); } return _memberAddressList; }
            set { _memberAddressList = value; }
        }

        protected IList<MemberLogin> _memberLoginList;

        /// <summary>member_login as 'MemberLoginList'.</summary>
        public IList<MemberLogin> MemberLoginList {
            get { if (_memberLoginList == null) { _memberLoginList = new List<MemberLogin>(); } return _memberLoginList; }
            set { _memberLoginList = value; }
        }

        protected IList<Purchase> _purchaseList;

        /// <summary>(購入)purchase as 'PurchaseList'.</summary>
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
            if (_memberAddressAsValid != null)
            { sb.Append(l).Append(xbRDS(_memberAddressAsValid, "MemberAddressAsValid")); }
            if (_memberLoginAsLocalForeignOverTest != null)
            { sb.Append(l).Append(xbRDS(_memberLoginAsLocalForeignOverTest, "MemberLoginAsLocalForeignOverTest")); }
            if (_memberLoginAsForeignForeignOverTest != null)
            { sb.Append(l).Append(xbRDS(_memberLoginAsForeignForeignOverTest, "MemberLoginAsForeignForeignOverTest")); }
            if (_memberLoginAsForeignForeignParameterOverTest != null)
            { sb.Append(l).Append(xbRDS(_memberLoginAsForeignForeignParameterOverTest, "MemberLoginAsForeignForeignParameterOverTest")); }
            if (_memberLoginAsForeignForeignVariousOverTest != null)
            { sb.Append(l).Append(xbRDS(_memberLoginAsForeignForeignVariousOverTest, "MemberLoginAsForeignForeignVariousOverTest")); }
            if (_memberLoginAsReferrerOverTest != null)
            { sb.Append(l).Append(xbRDS(_memberLoginAsReferrerOverTest, "MemberLoginAsReferrerOverTest")); }
            if (_memberLoginAsReferrerForeignOverTest != null)
            { sb.Append(l).Append(xbRDS(_memberLoginAsReferrerForeignOverTest, "MemberLoginAsReferrerForeignOverTest")); }
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
            if (_memberAddressAsValid != null) { sb.Append(c).Append("MemberAddressAsValid"); }
            if (_memberLoginAsLocalForeignOverTest != null) { sb.Append(c).Append("MemberLoginAsLocalForeignOverTest"); }
            if (_memberLoginAsForeignForeignOverTest != null) { sb.Append(c).Append("MemberLoginAsForeignForeignOverTest"); }
            if (_memberLoginAsForeignForeignParameterOverTest != null) { sb.Append(c).Append("MemberLoginAsForeignForeignParameterOverTest"); }
            if (_memberLoginAsForeignForeignVariousOverTest != null) { sb.Append(c).Append("MemberLoginAsForeignForeignVariousOverTest"); }
            if (_memberLoginAsReferrerOverTest != null) { sb.Append(c).Append("MemberLoginAsReferrerOverTest"); }
            if (_memberLoginAsReferrerForeignOverTest != null) { sb.Append(c).Append("MemberLoginAsReferrerForeignOverTest"); }
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
        /// <summary>(会員ID)MEMBER_ID: {PK, ID, NotNull, INT(10), FK to MEMBER_LOGIN}</summary>
        /// <remarks>
        /// 連番
        /// </remarks>
        [Seasar.Dao.Attrs.ID("identity")]
        [Seasar.Dao.Attrs.Column("MEMBER_ID")]
        public int? MemberId {
            get { return _memberId; }
            set {
                __modifiedProperties.AddPropertyName("MemberId");
                _memberId = value;
            }
        }

        /// <summary>(会員名称)MEMBER_NAME: {IX, NotNull, VARCHAR(200)}</summary>
        /// <remarks>
        /// 会員の表示用の名称(姓名)
        /// </remarks>
        [Seasar.Dao.Attrs.Column("MEMBER_NAME")]
        public String MemberName {
            get { return _memberName; }
            set {
                __modifiedProperties.AddPropertyName("MemberName");
                _memberName = value;
            }
        }

        /// <summary>(会員アカウント)MEMBER_ACCOUNT: {UQ, NotNull, VARCHAR(50)}</summary>
        [Seasar.Dao.Attrs.Column("MEMBER_ACCOUNT")]
        public String MemberAccount {
            get { return _memberAccount; }
            set {
                __modifiedProperties.AddPropertyName("MemberAccount");
                _memberAccount = value;
            }
        }

        /// <summary>MEMBER_STATUS_CODE: {IX, NotNull, CHAR(3), FK to member_status, classification=MemberStatus}</summary>
        [Seasar.Dao.Attrs.Column("MEMBER_STATUS_CODE")]
        public String MemberStatusCode {
            get { return _memberStatusCode; }
            set {
                __modifiedProperties.AddPropertyName("MemberStatusCode");
                _memberStatusCode = value;
            }
        }

        /// <summary>FORMALIZED_DATETIME: {IX, DATETIME(19)}</summary>
        [Seasar.Dao.Attrs.Column("FORMALIZED_DATETIME")]
        public DateTime? FormalizedDatetime {
            get { return _formalizedDatetime; }
            set {
                __modifiedProperties.AddPropertyName("FormalizedDatetime");
                _formalizedDatetime = value;
            }
        }

        /// <summary>BIRTHDATE: {DATE(10)}</summary>
        [Seasar.Dao.Attrs.Column("BIRTHDATE")]
        public DateTime? Birthdate {
            get { return _birthdate; }
            set {
                __modifiedProperties.AddPropertyName("Birthdate");
                _birthdate = value;
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

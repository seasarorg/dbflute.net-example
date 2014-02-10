

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
    /// The entity of OptionMember. (partial class for auto-generation)
    /// <![CDATA[
    /// [primary-key]
    ///     
    /// 
    /// [column]
    ///     MEMBER_ID, MEMBER_NAME, BIRTHDATE, FORMALIZED_DATETIME, MEMBER_STATUS_CODE, MEMBER_STATUS_NAME, DUMMY_FLG, DUMMY_NOFLG
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
    [Seasar.Dao.Attrs.Table("OptionMember")]
    [System.Serializable]
    public partial class OptionMember : Entity {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        #region Attribute
        /// <summary>(会員ID)MEMBER_ID: {INT(11), refers to member.MEMBER_ID}</summary>
        protected int? _memberId;

        /// <summary>(会員名称)MEMBER_NAME: {VARCHAR(200), refers to member.MEMBER_NAME}</summary>
        protected String _memberName;

        /// <summary>BIRTHDATE: {DATE(10), refers to member.BIRTHDATE}</summary>
        protected DateTime? _birthdate;

        /// <summary>FORMALIZED_DATETIME: {DATETIME(19), refers to member.FORMALIZED_DATETIME}</summary>
        protected DateTime? _formalizedDatetime;

        /// <summary>MEMBER_STATUS_CODE: {CHAR(3), refers to member.MEMBER_STATUS_CODE, classification=MemberStatus}</summary>
        protected String _memberStatusCode;

        /// <summary>MEMBER_STATUS_NAME: {VARCHAR(50), refers to member_status.MEMBER_STATUS_NAME}</summary>
        protected String _memberStatusName;

        /// <summary>DUMMY_FLG: {BIGINT(1), classification=Flg}</summary>
        protected long? _dummyFlg;

        /// <summary>DUMMY_NOFLG: {BIGINT(1)}</summary>
        protected long? _dummyNoflg;

        protected EntityModifiedProperties __modifiedProperties = new EntityModifiedProperties();
        #endregion

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public String TableDbName { get { return "OptionMember"; } }
        public String TablePropertyName { get { return "OptionMember"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public DBMeta DBMeta { get { return OptionMemberDbm.GetInstance(); } }

        // ===============================================================================
        //                                                         Classification Property
        //                                                         =======================
        #region Classification Property
        public CDef.MemberStatus MemberStatusCodeAsMemberStatus { get {
            return CDef.MemberStatus.CodeOf(_memberStatusCode);
        } set {
            MemberStatusCode = value != null ? value.Code : null;
        }}

        public CDef.Flg DummyFlgAsFlg { get {
            return CDef.Flg.CodeOf(_dummyFlg);
        } set {
            DummyFlg = value != null ? long.Parse(value.Code) : (long?)null;
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

        /// <summary>
        /// Set the value of dummyFlg as True.
        /// <![CDATA[
        /// はい: 有効を示す
        /// ]]>
        /// </summary>
        public void SetDummyFlg_True() {
            DummyFlgAsFlg = CDef.Flg.True;
        }

        /// <summary>
        /// Set the value of dummyFlg as False.
        /// <![CDATA[
        /// いいえ: 無効を示す
        /// ]]>
        /// </summary>
        public void SetDummyFlg_False() {
            DummyFlgAsFlg = CDef.Flg.False;
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

        /// <summary>
        /// Is the value of dummyFlg 'True'?
        /// <![CDATA[
        /// The difference of capital letters and small letters is NOT distinguished.
        /// If the value is null, this method returns false!
        /// はい: 有効を示す
        /// ]]>
        /// </summary>
        public bool IsDummyFlgTrue {
            get {
                CDef.Flg cls = DummyFlgAsFlg;
                return cls != null ? cls.Equals(CDef.Flg.True) : false;
            }
        }

        /// <summary>
        /// Is the value of dummyFlg 'False'?
        /// <![CDATA[
        /// The difference of capital letters and small letters is NOT distinguished.
        /// If the value is null, this method returns false!
        /// いいえ: 無効を示す
        /// ]]>
        /// </summary>
        public bool IsDummyFlgFalse {
            get {
                CDef.Flg cls = DummyFlgAsFlg;
                return cls != null ? cls.Equals(CDef.Flg.False) : false;
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

        public String DummyFlgName {
            get {
                CDef.Flg cls = DummyFlgAsFlg;
                return cls != null ? cls.Name : null;
            }
        }
        public String DummyFlgAlias {
            get {
                CDef.Flg cls = DummyFlgAsFlg;
                return cls != null ? cls.Alias : null;
            }
        }

        #endregion

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
            if (other == null || !(other is OptionMember)) { return false; }
            OptionMember otherEntity = (OptionMember)other;
            if (!xSV(this.MemberId, otherEntity.MemberId)) { return false; }
            if (!xSV(this.MemberName, otherEntity.MemberName)) { return false; }
            if (!xSV(this.Birthdate, otherEntity.Birthdate)) { return false; }
            if (!xSV(this.FormalizedDatetime, otherEntity.FormalizedDatetime)) { return false; }
            if (!xSV(this.MemberStatusCode, otherEntity.MemberStatusCode)) { return false; }
            if (!xSV(this.MemberStatusName, otherEntity.MemberStatusName)) { return false; }
            if (!xSV(this.DummyFlg, otherEntity.DummyFlg)) { return false; }
            if (!xSV(this.DummyNoflg, otherEntity.DummyNoflg)) { return false; }
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
            result = xCH(result, _birthdate);
            result = xCH(result, _formalizedDatetime);
            result = xCH(result, _memberStatusCode);
            result = xCH(result, _memberStatusName);
            result = xCH(result, _dummyFlg);
            result = xCH(result, _dummyNoflg);
            return result;
        }
        protected int xCH(int result, Object value) { // calculateHashcode()
            if (value == null) { return result; }
            return (31*result) + (value is byte[] ? ((byte[])value).Length : value.GetHashCode());
        }

        public override String ToString() {
            return "OptionMember:" + BuildColumnString() + BuildRelationString();
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
            sb.Append(c).Append(this.Birthdate);
            sb.Append(c).Append(this.FormalizedDatetime);
            sb.Append(c).Append(this.MemberStatusCode);
            sb.Append(c).Append(this.MemberStatusName);
            sb.Append(c).Append(this.DummyFlg);
            sb.Append(c).Append(this.DummyNoflg);
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
        /// <summary>(会員ID)MEMBER_ID: {INT(11), refers to member.MEMBER_ID}</summary>
        /// <remarks>
        /// 連番
        /// </remarks>
        [Seasar.Dao.Attrs.Column("MEMBER_ID")]
        public int? MemberId {
            get { return _memberId; }
            set {
                __modifiedProperties.AddPropertyName("MemberId");
                _memberId = value;
            }
        }

        /// <summary>(会員名称)MEMBER_NAME: {VARCHAR(200), refers to member.MEMBER_NAME}</summary>
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

        /// <summary>BIRTHDATE: {DATE(10), refers to member.BIRTHDATE}</summary>
        [Seasar.Dao.Attrs.Column("BIRTHDATE")]
        public DateTime? Birthdate {
            get { return _birthdate; }
            set {
                __modifiedProperties.AddPropertyName("Birthdate");
                _birthdate = value;
            }
        }

        /// <summary>FORMALIZED_DATETIME: {DATETIME(19), refers to member.FORMALIZED_DATETIME}</summary>
        [Seasar.Dao.Attrs.Column("FORMALIZED_DATETIME")]
        public DateTime? FormalizedDatetime {
            get { return _formalizedDatetime; }
            set {
                __modifiedProperties.AddPropertyName("FormalizedDatetime");
                _formalizedDatetime = value;
            }
        }

        /// <summary>MEMBER_STATUS_CODE: {CHAR(3), refers to member.MEMBER_STATUS_CODE, classification=MemberStatus}</summary>
        [Seasar.Dao.Attrs.Column("MEMBER_STATUS_CODE")]
        public String MemberStatusCode {
            get { return _memberStatusCode; }
            set {
                __modifiedProperties.AddPropertyName("MemberStatusCode");
                _memberStatusCode = value;
            }
        }

        /// <summary>MEMBER_STATUS_NAME: {VARCHAR(50), refers to member_status.MEMBER_STATUS_NAME}</summary>
        [Seasar.Dao.Attrs.Column("MEMBER_STATUS_NAME")]
        public String MemberStatusName {
            get { return _memberStatusName; }
            set {
                __modifiedProperties.AddPropertyName("MemberStatusName");
                _memberStatusName = value;
            }
        }

        /// <summary>DUMMY_FLG: {BIGINT(1), classification=Flg}</summary>
        [Seasar.Dao.Attrs.Column("DUMMY_FLG")]
        public long? DummyFlg {
            get { return _dummyFlg; }
            set {
                __modifiedProperties.AddPropertyName("DummyFlg");
                _dummyFlg = value;
            }
        }

        /// <summary>DUMMY_NOFLG: {BIGINT(1)}</summary>
        [Seasar.Dao.Attrs.Column("DUMMY_NOFLG")]
        public long? DummyNoflg {
            get { return _dummyNoflg; }
            set {
                __modifiedProperties.AddPropertyName("DummyNoflg");
                _dummyNoflg = value;
            }
        }

        #endregion
    }
}

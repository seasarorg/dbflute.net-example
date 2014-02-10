

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
    /// The entity of member_login as TABLE. (partial class for auto-generation)
    /// <![CDATA[
    /// [primary-key]
    ///     MEMBER_LOGIN_ID
    /// 
    /// [column]
    ///     MEMBER_LOGIN_ID, MEMBER_ID, LOGIN_DATETIME, MOBILE_LOGIN_FLG, LOGIN_MEMBER_STATUS_CODE
    /// 
    /// [sequence]
    ///     
    /// 
    /// [identity]
    ///     MEMBER_LOGIN_ID
    /// 
    /// [version-no]
    ///     
    /// 
    /// [foreign-table]
    ///     member, member_status
    /// 
    /// [referrer-table]
    ///     
    /// 
    /// [foreign-property]
    ///     member, memberStatus
    /// 
    /// [referrer-property]
    ///     
    /// ]]>
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    [Seasar.Dao.Attrs.Table("member_login")]
    [System.Serializable]
    public partial class MemberLogin : Entity {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        #region Attribute
        /// <summary>MEMBER_LOGIN_ID: {PK, ID, NotNull, BIGINT(19)}</summary>
        protected long? _memberLoginId;

        /// <summary>MEMBER_ID: {UQ, IX, NotNull, INT(10), FK to member}</summary>
        protected int? _memberId;

        /// <summary>LOGIN_DATETIME: {UQ+, IX, NotNull, DATETIME(19)}</summary>
        protected DateTime? _loginDatetime;

        /// <summary>MOBILE_LOGIN_FLG: {NotNull, INT(10), classification=Flg}</summary>
        protected int? _mobileLoginFlg;

        /// <summary>LOGIN_MEMBER_STATUS_CODE: {IX, NotNull, CHAR(3), FK to member_status}</summary>
        protected String _loginMemberStatusCode;

        protected EntityModifiedProperties __modifiedProperties = new EntityModifiedProperties();
        #endregion

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public String TableDbName { get { return "member_login"; } }
        public String TablePropertyName { get { return "MemberLogin"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public DBMeta DBMeta { get { return DBMetaInstanceHandler.FindDBMeta(TableDbName); } }

        // ===============================================================================
        //                                                         Classification Property
        //                                                         =======================
        #region Classification Property
        public CDef.Flg MobileLoginFlgAsFlg { get {
            return CDef.Flg.CodeOf(_mobileLoginFlg);
        } set {
            MobileLoginFlg = value != null ? int.Parse(value.Code) : (int?)null;
        }}

        #endregion

        // ===============================================================================
        //                                                          Classification Setting
        //                                                          ======================
        #region Classification Setting
        /// <summary>
        /// Set the value of mobileLoginFlg as True.
        /// <![CDATA[
        /// はい: 有効を示す
        /// ]]>
        /// </summary>
        public void SetMobileLoginFlg_True() {
            MobileLoginFlgAsFlg = CDef.Flg.True;
        }

        /// <summary>
        /// Set the value of mobileLoginFlg as False.
        /// <![CDATA[
        /// いいえ: 無効を示す
        /// ]]>
        /// </summary>
        public void SetMobileLoginFlg_False() {
            MobileLoginFlgAsFlg = CDef.Flg.False;
        }

        #endregion

        // ===============================================================================
        //                                                    Classification Determination
        //                                                    ============================
        #region Classification Determination
        /// <summary>
        /// Is the value of mobileLoginFlg 'True'?
        /// <![CDATA[
        /// The difference of capital letters and small letters is NOT distinguished.
        /// If the value is null, this method returns false!
        /// はい: 有効を示す
        /// ]]>
        /// </summary>
        public bool IsMobileLoginFlgTrue {
            get {
                CDef.Flg cls = MobileLoginFlgAsFlg;
                return cls != null ? cls.Equals(CDef.Flg.True) : false;
            }
        }

        /// <summary>
        /// Is the value of mobileLoginFlg 'False'?
        /// <![CDATA[
        /// The difference of capital letters and small letters is NOT distinguished.
        /// If the value is null, this method returns false!
        /// いいえ: 無効を示す
        /// ]]>
        /// </summary>
        public bool IsMobileLoginFlgFalse {
            get {
                CDef.Flg cls = MobileLoginFlgAsFlg;
                return cls != null ? cls.Equals(CDef.Flg.False) : false;
            }
        }

        #endregion

        // ===============================================================================
        //                                                       Classification Name/Alias
        //                                                       =========================
        #region Classification Name/Alias
        public String MobileLoginFlgName {
            get {
                CDef.Flg cls = MobileLoginFlgAsFlg;
                return cls != null ? cls.Name : null;
            }
        }
        public String MobileLoginFlgAlias {
            get {
                CDef.Flg cls = MobileLoginFlgAsFlg;
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

        protected MemberStatus _memberStatus;

        /// <summary>member_status as 'MemberStatus'.</summary>
        [Seasar.Dao.Attrs.Relno(1), Seasar.Dao.Attrs.Relkeys("LOGIN_MEMBER_STATUS_CODE:MEMBER_STATUS_CODE")]
        public MemberStatus MemberStatus {
            get { return _memberStatus; }
            set { _memberStatus = value; }
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
                if (_memberLoginId == null) { return false; }
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
            if (other == null || !(other is MemberLogin)) { return false; }
            MemberLogin otherEntity = (MemberLogin)other;
            if (!xSV(this.MemberLoginId, otherEntity.MemberLoginId)) { return false; }
            return true;
        }
        protected bool xSV(Object value1, Object value2) { // isSameValue()
            if (value1 == null && value2 == null) { return true; }
            if (value1 == null || value2 == null) { return false; }
            return value1.Equals(value2);
        }

        public override int GetHashCode() {
            int result = 17;
            result = xCH(result, _memberLoginId);
            return result;
        }
        protected int xCH(int result, Object value) { // calculateHashcode()
            if (value == null) { return result; }
            return (31*result) + (value is byte[] ? ((byte[])value).Length : value.GetHashCode());
        }

        public override String ToString() {
            return "MemberLogin:" + BuildColumnString() + BuildRelationString();
        }

        public virtual String ToStringWithRelation() {
            StringBuilder sb = new StringBuilder();
            sb.Append(ToString());
            String l = "\n  ";
            if (_member != null)
            { sb.Append(l).Append(xbRDS(_member, "Member")); }
            if (_memberStatus != null)
            { sb.Append(l).Append(xbRDS(_memberStatus, "MemberStatus")); }
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
            sb.Append(c).Append(this.MemberLoginId);
            sb.Append(c).Append(this.MemberId);
            sb.Append(c).Append(this.LoginDatetime);
            sb.Append(c).Append(this.MobileLoginFlg);
            sb.Append(c).Append(this.LoginMemberStatusCode);
            if (sb.Length > 0) { sb.Remove(0, c.Length); }
            sb.Insert(0, "{").Append("}");
            return sb.ToString();
        }
        protected virtual String BuildRelationString() {
            StringBuilder sb = new StringBuilder();
            String c = ",";
            if (_member != null) { sb.Append(c).Append("Member"); }
            if (_memberStatus != null) { sb.Append(c).Append("MemberStatus"); }
            if (sb.Length > 0) { sb.Remove(0, c.Length).Insert(0, "(").Append(")"); }
            return sb.ToString();
        }
        #endregion

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        #region Accessor
        /// <summary>MEMBER_LOGIN_ID: {PK, ID, NotNull, BIGINT(19)}</summary>
        [Seasar.Dao.Attrs.ID("identity")]
        [Seasar.Dao.Attrs.Column("MEMBER_LOGIN_ID")]
        public long? MemberLoginId {
            get { return _memberLoginId; }
            set {
                __modifiedProperties.AddPropertyName("MemberLoginId");
                _memberLoginId = value;
            }
        }

        /// <summary>MEMBER_ID: {UQ, IX, NotNull, INT(10), FK to member}</summary>
        [Seasar.Dao.Attrs.Column("MEMBER_ID")]
        public int? MemberId {
            get { return _memberId; }
            set {
                __modifiedProperties.AddPropertyName("MemberId");
                _memberId = value;
            }
        }

        /// <summary>LOGIN_DATETIME: {UQ+, IX, NotNull, DATETIME(19)}</summary>
        [Seasar.Dao.Attrs.Column("LOGIN_DATETIME")]
        public DateTime? LoginDatetime {
            get { return _loginDatetime; }
            set {
                __modifiedProperties.AddPropertyName("LoginDatetime");
                _loginDatetime = value;
            }
        }

        /// <summary>MOBILE_LOGIN_FLG: {NotNull, INT(10), classification=Flg}</summary>
        [Seasar.Dao.Attrs.Column("MOBILE_LOGIN_FLG")]
        public int? MobileLoginFlg {
            get { return _mobileLoginFlg; }
            set {
                __modifiedProperties.AddPropertyName("MobileLoginFlg");
                _mobileLoginFlg = value;
            }
        }

        /// <summary>LOGIN_MEMBER_STATUS_CODE: {IX, NotNull, CHAR(3), FK to member_status}</summary>
        [Seasar.Dao.Attrs.Column("LOGIN_MEMBER_STATUS_CODE")]
        public String LoginMemberStatusCode {
            get { return _loginMemberStatusCode; }
            set {
                __modifiedProperties.AddPropertyName("LoginMemberStatusCode");
                _loginMemberStatusCode = value;
            }
        }

        #endregion
    }
}

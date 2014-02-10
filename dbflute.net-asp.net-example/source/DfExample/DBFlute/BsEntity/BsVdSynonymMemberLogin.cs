

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
    /// The entity of (会員ログイン)VD_SYNONYM_MEMBER_LOGIN as SYNONYM. (partial class for auto-generation)
    /// <![CDATA[
    /// ログインの度にInsertされる
    /// 
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
    ///     
    /// 
    /// [version-no]
    ///     
    /// 
    /// [foreign-table]
    ///     MEMBER_VENDOR_SYNONYM, MEMBER_STATUS, VD_SYNONYM_MEMBER, VENDOR_SYNONYM_MEMBER
    /// 
    /// [referrer-table]
    ///     
    /// 
    /// [foreign-property]
    ///     memberVendorSynonym, memberStatus, vdSynonymMember, vendorSynonymMember
    /// 
    /// [referrer-property]
    ///     
    /// ]]>
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    [Seasar.Dao.Attrs.Table("VD_SYNONYM_MEMBER_LOGIN")]
    [System.Serializable]
    public partial class VdSynonymMemberLogin : Entity {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        #region Attribute
        /// <summary>MEMBER_LOGIN_ID: {PK, NotNull, NUMBER(16)}</summary>
        protected long? _memberLoginId;

        /// <summary>MEMBER_ID: {UQ, NotNull, NUMBER(16), FK to MEMBER_VENDOR_SYNONYM}</summary>
        protected long? _memberId;

        /// <summary>LOGIN_DATETIME: {UQ+, IX, NotNull, DATE(7)}</summary>
        protected DateTime? _loginDatetime;

        /// <summary>MOBILE_LOGIN_FLG: {NotNull, NUMBER(1), classification=Flg}</summary>
        protected int? _mobileLoginFlg;

        /// <summary>LOGIN_MEMBER_STATUS_CODE: {NotNull, CHAR(3), FK to MEMBER_STATUS}</summary>
        protected String _loginMemberStatusCode;

        protected EntityModifiedProperties __modifiedProperties = new EntityModifiedProperties();
        #endregion

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public String TableDbName { get { return "VD_SYNONYM_MEMBER_LOGIN"; } }
        public String TablePropertyName { get { return "VdSynonymMemberLogin"; } }

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
        /// True: 有効を示す
        /// ]]>
        /// </summary>
        public void SetMobileLoginFlg_True() {
            MobileLoginFlgAsFlg = CDef.Flg.True;
        }

        /// <summary>
        /// Set the value of mobileLoginFlg as False.
        /// <![CDATA[
        /// False: 無効を示す
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
        /// True: 有効を示す
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
        /// False: 無効を示す
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
        #endregion

        // ===============================================================================
        //                                                                Foreign Property
        //                                                                ================
        #region Foreign Property
        protected MemberVendorSynonym _memberVendorSynonym;

        /// <summary>(会員)MEMBER_VENDOR_SYNONYM as 'MemberVendorSynonym'.</summary>
        [Seasar.Dao.Attrs.Relno(0), Seasar.Dao.Attrs.Relkeys("MEMBER_ID:MEMBER_ID")]
        public MemberVendorSynonym MemberVendorSynonym {
            get { return _memberVendorSynonym; }
            set { _memberVendorSynonym = value; }
        }

        protected MemberStatus _memberStatus;

        /// <summary>(会員ステータス)MEMBER_STATUS as 'MemberStatus'.</summary>
        [Seasar.Dao.Attrs.Relno(1), Seasar.Dao.Attrs.Relkeys("LOGIN_MEMBER_STATUS_CODE:MEMBER_STATUS_CODE")]
        public MemberStatus MemberStatus {
            get { return _memberStatus; }
            set { _memberStatus = value; }
        }

        protected VdSynonymMember _vdSynonymMember;

        /// <summary>(会員)VD_SYNONYM_MEMBER as 'VdSynonymMember'.</summary>
        [Seasar.Dao.Attrs.Relno(2), Seasar.Dao.Attrs.Relkeys("MEMBER_ID:MEMBER_ID")]
        public VdSynonymMember VdSynonymMember {
            get { return _vdSynonymMember; }
            set { _vdSynonymMember = value; }
        }

        protected VendorSynonymMember _vendorSynonymMember;

        /// <summary>(会員)VENDOR_SYNONYM_MEMBER as 'VendorSynonymMember'.</summary>
        [Seasar.Dao.Attrs.Relno(3), Seasar.Dao.Attrs.Relkeys("MEMBER_ID:MEMBER_ID")]
        public VendorSynonymMember VendorSynonymMember {
            get { return _vendorSynonymMember; }
            set { _vendorSynonymMember = value; }
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
            if (other == null || !(other is VdSynonymMemberLogin)) { return false; }
            VdSynonymMemberLogin otherEntity = (VdSynonymMemberLogin)other;
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
            return "VdSynonymMemberLogin:" + BuildColumnString() + BuildRelationString();
        }

        public virtual String ToStringWithRelation() {
            StringBuilder sb = new StringBuilder();
            sb.Append(ToString());
            String l = "\n  ";
            if (_memberVendorSynonym != null)
            { sb.Append(l).Append(xbRDS(_memberVendorSynonym, "MemberVendorSynonym")); }
            if (_memberStatus != null)
            { sb.Append(l).Append(xbRDS(_memberStatus, "MemberStatus")); }
            if (_vdSynonymMember != null)
            { sb.Append(l).Append(xbRDS(_vdSynonymMember, "VdSynonymMember")); }
            if (_vendorSynonymMember != null)
            { sb.Append(l).Append(xbRDS(_vendorSynonymMember, "VendorSynonymMember")); }
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
            if (_memberVendorSynonym != null) { sb.Append(c).Append("MemberVendorSynonym"); }
            if (_memberStatus != null) { sb.Append(c).Append("MemberStatus"); }
            if (_vdSynonymMember != null) { sb.Append(c).Append("VdSynonymMember"); }
            if (_vendorSynonymMember != null) { sb.Append(c).Append("VendorSynonymMember"); }
            if (sb.Length > 0) { sb.Remove(0, c.Length).Insert(0, "(").Append(")"); }
            return sb.ToString();
        }
        #endregion

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        #region Accessor
        /// <summary>MEMBER_LOGIN_ID: {PK, NotNull, NUMBER(16)}</summary>
        [Seasar.Dao.Attrs.Column("MEMBER_LOGIN_ID")]
        public long? MemberLoginId {
            get { return _memberLoginId; }
            set {
                __modifiedProperties.AddPropertyName("MemberLoginId");
                _memberLoginId = value;
            }
        }

        /// <summary>MEMBER_ID: {UQ, NotNull, NUMBER(16), FK to MEMBER_VENDOR_SYNONYM}</summary>
        [Seasar.Dao.Attrs.Column("MEMBER_ID")]
        public long? MemberId {
            get { return _memberId; }
            set {
                __modifiedProperties.AddPropertyName("MemberId");
                _memberId = value;
            }
        }

        /// <summary>LOGIN_DATETIME: {UQ+, IX, NotNull, DATE(7)}</summary>
        [Seasar.Dao.Attrs.Column("LOGIN_DATETIME")]
        public DateTime? LoginDatetime {
            get { return _loginDatetime; }
            set {
                __modifiedProperties.AddPropertyName("LoginDatetime");
                _loginDatetime = value;
            }
        }

        /// <summary>MOBILE_LOGIN_FLG: {NotNull, NUMBER(1), classification=Flg}</summary>
        [Seasar.Dao.Attrs.Column("MOBILE_LOGIN_FLG")]
        public int? MobileLoginFlg {
            get { return _mobileLoginFlg; }
            set {
                __modifiedProperties.AddPropertyName("MobileLoginFlg");
                _mobileLoginFlg = value;
            }
        }

        /// <summary>LOGIN_MEMBER_STATUS_CODE: {NotNull, CHAR(3), FK to MEMBER_STATUS}</summary>
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

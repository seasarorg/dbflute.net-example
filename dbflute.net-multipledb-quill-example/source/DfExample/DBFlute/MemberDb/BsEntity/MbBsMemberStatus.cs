

using System;
using System.Reflection;
using System.Collections.Generic;
using System.Text;

using DfExample.DBFlute.MemberDb.AllCommon;
using DfExample.DBFlute.MemberDb.AllCommon.CBean;
using DfExample.DBFlute.MemberDb.AllCommon.Dbm;
using DfExample.DBFlute.MemberDb.AllCommon.Helper;
using DfExample.DBFlute.MemberDb.ExEntity;
using DfExample.DBFlute.MemberDb.BsEntity.Dbm;


namespace DfExample.DBFlute.MemberDb.ExEntity {

    /// <summary>
    /// The entity of member_status as TABLE. (partial class for auto-generation)
    /// <![CDATA[
    /// [primary-key]
    ///     MEMBER_STATUS_CODE
    /// 
    /// [column]
    ///     MEMBER_STATUS_CODE, MEMBER_STATUS_NAME, DISPLAY_ORDER
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
    ///     member, member_login
    /// 
    /// [foreign-property]
    ///     
    /// 
    /// [referrer-property]
    ///     memberList, memberLoginList
    /// ]]>
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    [Seasar.Dao.Attrs.Table("member_status")]
    [System.Serializable]
    public partial class MbMemberStatus : MbEntity {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        #region Attribute
        /// <summary>MEMBER_STATUS_CODE: {PK, NotNull, CHAR(3), classification=MemberStatus}</summary>
        protected String _memberStatusCode;

        /// <summary>MEMBER_STATUS_NAME: {UQ, NotNull, VARCHAR(50)}</summary>
        protected String _memberStatusName;

        /// <summary>DISPLAY_ORDER: {UQ, NotNull, INT(10)}</summary>
        protected int? _displayOrder;

        protected EntityModifiedProperties __modifiedProperties = new EntityModifiedProperties();
        #endregion

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public String TableDbName { get { return "member_status"; } }
        public String TablePropertyName { get { return "MemberStatus"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public MbDBMeta DBMeta { get { return MbDBMetaInstanceHandler.FindDBMeta(TableDbName); } }

        // ===============================================================================
        //                                                         Classification Property
        //                                                         =======================
        #region Classification Property
        public MbCDef.MemberStatus MemberStatusCodeAsMemberStatus { get {
            return MbCDef.MemberStatus.CodeOf(_memberStatusCode);
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
            MemberStatusCodeAsMemberStatus = MbCDef.MemberStatus.Provisional;
        }

        /// <summary>
        /// Set the value of memberStatusCode as Formalized.
        /// <![CDATA[
        /// 正式会員: 正式会員を示す
        /// ]]>
        /// </summary>
        public void SetMemberStatusCode_Formalized() {
            MemberStatusCodeAsMemberStatus = MbCDef.MemberStatus.Formalized;
        }

        /// <summary>
        /// Set the value of memberStatusCode as Withdrawal.
        /// <![CDATA[
        /// 退会会員: 退会会員を示す
        /// ]]>
        /// </summary>
        public void SetMemberStatusCode_Withdrawal() {
            MemberStatusCodeAsMemberStatus = MbCDef.MemberStatus.Withdrawal;
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
                MbCDef.MemberStatus cls = MemberStatusCodeAsMemberStatus;
                return cls != null ? cls.Equals(MbCDef.MemberStatus.Provisional) : false;
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
                MbCDef.MemberStatus cls = MemberStatusCodeAsMemberStatus;
                return cls != null ? cls.Equals(MbCDef.MemberStatus.Formalized) : false;
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
                MbCDef.MemberStatus cls = MemberStatusCodeAsMemberStatus;
                return cls != null ? cls.Equals(MbCDef.MemberStatus.Withdrawal) : false;
            }
        }

        #endregion

        // ===============================================================================
        //                                                       Classification Name/Alias
        //                                                       =========================
        #region Classification Name/Alias
        public String MemberStatusCodeName {
            get {
                MbCDef.MemberStatus cls = MemberStatusCodeAsMemberStatus;
                return cls != null ? cls.Name : null;
            }
        }
        public String MemberStatusCodeAlias {
            get {
                MbCDef.MemberStatus cls = MemberStatusCodeAsMemberStatus;
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
        protected IList<MbMember> _memberList;

        /// <summary>member as 'MemberList'.</summary>
        public IList<MbMember> MemberList {
            get { if (_memberList == null) { _memberList = new List<MbMember>(); } return _memberList; }
            set { _memberList = value; }
        }

        protected IList<MbMemberLogin> _memberLoginList;

        /// <summary>member_login as 'MemberLoginList'.</summary>
        public IList<MbMemberLogin> MemberLoginList {
            get { if (_memberLoginList == null) { _memberLoginList = new List<MbMemberLogin>(); } return _memberLoginList; }
            set { _memberLoginList = value; }
        }

        #endregion

        // ===============================================================================
        //                                                                   Determination
        //                                                                   =============
        public virtual bool HasPrimaryKeyValue {
            get {
                if (_memberStatusCode == null) { return false; }
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
            if (other == null || !(other is MbMemberStatus)) { return false; }
            MbMemberStatus otherEntity = (MbMemberStatus)other;
            if (!xSV(this.MemberStatusCode, otherEntity.MemberStatusCode)) { return false; }
            return true;
        }
        protected bool xSV(Object value1, Object value2) { // isSameValue()
            if (value1 == null && value2 == null) { return true; }
            if (value1 == null || value2 == null) { return false; }
            return value1.Equals(value2);
        }

        public override int GetHashCode() {
            int result = 17;
            result = xCH(result, _memberStatusCode);
            return result;
        }
        protected int xCH(int result, Object value) { // calculateHashcode()
            if (value == null) { return result; }
            return (31*result) + (value is byte[] ? ((byte[])value).Length : value.GetHashCode());
        }

        public override String ToString() {
            return "MbMemberStatus:" + BuildColumnString() + BuildRelationString();
        }

        public virtual String ToStringWithRelation() {
            StringBuilder sb = new StringBuilder();
            sb.Append(ToString());
            String l = "\n  ";
            if (_memberList != null) { foreach (MbEntity e in _memberList)
            { if (e != null) { sb.Append(l).Append(xbRDS(e, "MemberList")); } } }
            if (_memberLoginList != null) { foreach (MbEntity e in _memberLoginList)
            { if (e != null) { sb.Append(l).Append(xbRDS(e, "MemberLoginList")); } } }
            return sb.ToString();
        }
        protected String xbRDS(MbEntity e, String name) { // buildRelationDisplayString()
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
            sb.Append(c).Append(this.MemberStatusCode);
            sb.Append(c).Append(this.MemberStatusName);
            sb.Append(c).Append(this.DisplayOrder);
            if (sb.Length > 0) { sb.Remove(0, c.Length); }
            sb.Insert(0, "{").Append("}");
            return sb.ToString();
        }
        protected virtual String BuildRelationString() {
            StringBuilder sb = new StringBuilder();
            String c = ",";
            if (_memberList != null && _memberList.Count > 0)
            { sb.Append(c).Append("MemberList"); }
            if (_memberLoginList != null && _memberLoginList.Count > 0)
            { sb.Append(c).Append("MemberLoginList"); }
            if (sb.Length > 0) { sb.Remove(0, c.Length).Insert(0, "(").Append(")"); }
            return sb.ToString();
        }
        #endregion

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        #region Accessor
        /// <summary>MEMBER_STATUS_CODE: {PK, NotNull, CHAR(3), classification=MemberStatus}</summary>
        [Seasar.Dao.Attrs.Column("MEMBER_STATUS_CODE")]
        public String MemberStatusCode {
            get { return _memberStatusCode; }
            set {
                __modifiedProperties.AddPropertyName("MemberStatusCode");
                _memberStatusCode = value;
            }
        }

        /// <summary>MEMBER_STATUS_NAME: {UQ, NotNull, VARCHAR(50)}</summary>
        [Seasar.Dao.Attrs.Column("MEMBER_STATUS_NAME")]
        public String MemberStatusName {
            get { return _memberStatusName; }
            set {
                __modifiedProperties.AddPropertyName("MemberStatusName");
                _memberStatusName = value;
            }
        }

        /// <summary>DISPLAY_ORDER: {UQ, NotNull, INT(10)}</summary>
        [Seasar.Dao.Attrs.Column("DISPLAY_ORDER")]
        public int? DisplayOrder {
            get { return _displayOrder; }
            set {
                __modifiedProperties.AddPropertyName("DisplayOrder");
                _displayOrder = value;
            }
        }

        #endregion
    }
}



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
    /// The entity of MEMBER_ADDRESS as TABLE. (partial class for auto-generation)
    /// <![CDATA[
    /// [primary-key]
    ///     MEMBER_ADDRESS_ID
    /// 
    /// [column]
    ///     MEMBER_ADDRESS_ID, MEMBER_ID, VALID_BEGIN_DATE, VALID_END_DATE, ADDRESS, REGISTER_DATETIME, REGISTER_PROCESS, REGISTER_USER, UPDATE_DATETIME, UPDATE_PROCESS, UPDATE_USER, VERSION_NO
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
    ///     MEMBER
    /// 
    /// [referrer-table]
    ///     
    /// 
    /// [foreign-property]
    ///     member
    /// 
    /// [referrer-property]
    ///     
    /// ]]>
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    [Seasar.Dao.Attrs.Table("MEMBER_ADDRESS")]
    [Seasar.Dao.Attrs.VersionNoProperty("VersionNo")]
    [System.Serializable]
    public partial class MemberAddress : EntityDefinedCommonColumn {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        #region Attribute
        /// <summary>MEMBER_ADDRESS_ID: {PK, NotNull, NUMBER(16)}</summary>
        protected long? _memberAddressId;

        /// <summary>MEMBER_ID: {UQ, NotNull, NUMBER(16), FK to MEMBER}</summary>
        protected long? _memberId;

        /// <summary>VALID_BEGIN_DATE: {UQ+, NotNull, DATE(7)}</summary>
        protected DateTime? _validBeginDate;

        /// <summary>VALID_END_DATE: {NotNull, DATE(7)}</summary>
        protected DateTime? _validEndDate;

        /// <summary>ADDRESS: {NotNull, VARCHAR2(200)}</summary>
        protected String _address;

        /// <summary>REGISTER_DATETIME: {NotNull, DATE(7)}</summary>
        protected DateTime? _registerDatetime;

        /// <summary>REGISTER_PROCESS: {NotNull, VARCHAR2(200)}</summary>
        protected String _registerProcess;

        /// <summary>REGISTER_USER: {NotNull, VARCHAR2(200)}</summary>
        protected String _registerUser;

        /// <summary>UPDATE_DATETIME: {NotNull, DATE(7)}</summary>
        protected DateTime? _updateDatetime;

        /// <summary>UPDATE_PROCESS: {NotNull, VARCHAR2(200)}</summary>
        protected String _updateProcess;

        /// <summary>UPDATE_USER: {NotNull, VARCHAR2(200)}</summary>
        protected String _updateUser;

        /// <summary>VERSION_NO: {NotNull, NUMBER(16)}</summary>
        protected long? _versionNo;

        protected EntityModifiedProperties __modifiedProperties = new EntityModifiedProperties();

        protected bool __canCommonColumnAutoSetup = true;
        #endregion

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public String TableDbName { get { return "MEMBER_ADDRESS"; } }
        public String TablePropertyName { get { return "MemberAddress"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public DBMeta DBMeta { get { return DBMetaInstanceHandler.FindDBMeta(TableDbName); } }

        // ===============================================================================
        //                                                                Foreign Property
        //                                                                ================
        #region Foreign Property
        protected Member _member;

        /// <summary>(会員)MEMBER as 'Member'.</summary>
        [Seasar.Dao.Attrs.Relno(0), Seasar.Dao.Attrs.Relkeys("MEMBER_ID:MEMBER_ID")]
        public Member Member {
            get { return _member; }
            set { _member = value; }
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
                if (_memberAddressId == null) { return false; }
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
            if (other == null || !(other is MemberAddress)) { return false; }
            MemberAddress otherEntity = (MemberAddress)other;
            if (!xSV(this.MemberAddressId, otherEntity.MemberAddressId)) { return false; }
            return true;
        }
        protected bool xSV(Object value1, Object value2) { // isSameValue()
            if (value1 == null && value2 == null) { return true; }
            if (value1 == null || value2 == null) { return false; }
            return value1.Equals(value2);
        }

        public override int GetHashCode() {
            int result = 17;
            result = xCH(result, _memberAddressId);
            return result;
        }
        protected int xCH(int result, Object value) { // calculateHashcode()
            if (value == null) { return result; }
            return (31*result) + (value is byte[] ? ((byte[])value).Length : value.GetHashCode());
        }

        public override String ToString() {
            return "MemberAddress:" + BuildColumnString() + BuildRelationString();
        }

        public virtual String ToStringWithRelation() {
            StringBuilder sb = new StringBuilder();
            sb.Append(ToString());
            String l = "\n  ";
            if (_member != null)
            { sb.Append(l).Append(xbRDS(_member, "Member")); }
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
            sb.Append(c).Append(this.MemberAddressId);
            sb.Append(c).Append(this.MemberId);
            sb.Append(c).Append(this.ValidBeginDate);
            sb.Append(c).Append(this.ValidEndDate);
            sb.Append(c).Append(this.Address);
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
            if (sb.Length > 0) { sb.Remove(0, c.Length).Insert(0, "(").Append(")"); }
            return sb.ToString();
        }
        #endregion

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        #region Accessor
        /// <summary>MEMBER_ADDRESS_ID: {PK, NotNull, NUMBER(16)}</summary>
        [Seasar.Dao.Attrs.Column("MEMBER_ADDRESS_ID")]
        public long? MemberAddressId {
            get { return _memberAddressId; }
            set {
                __modifiedProperties.AddPropertyName("MemberAddressId");
                _memberAddressId = value;
            }
        }

        /// <summary>MEMBER_ID: {UQ, NotNull, NUMBER(16), FK to MEMBER}</summary>
        [Seasar.Dao.Attrs.Column("MEMBER_ID")]
        public long? MemberId {
            get { return _memberId; }
            set {
                __modifiedProperties.AddPropertyName("MemberId");
                _memberId = value;
            }
        }

        /// <summary>VALID_BEGIN_DATE: {UQ+, NotNull, DATE(7)}</summary>
        [Seasar.Dao.Attrs.Column("VALID_BEGIN_DATE")]
        public DateTime? ValidBeginDate {
            get { return _validBeginDate; }
            set {
                __modifiedProperties.AddPropertyName("ValidBeginDate");
                _validBeginDate = value;
            }
        }

        /// <summary>VALID_END_DATE: {NotNull, DATE(7)}</summary>
        [Seasar.Dao.Attrs.Column("VALID_END_DATE")]
        public DateTime? ValidEndDate {
            get { return _validEndDate; }
            set {
                __modifiedProperties.AddPropertyName("ValidEndDate");
                _validEndDate = value;
            }
        }

        /// <summary>ADDRESS: {NotNull, VARCHAR2(200)}</summary>
        [Seasar.Dao.Attrs.Column("ADDRESS")]
        public String Address {
            get { return _address; }
            set {
                __modifiedProperties.AddPropertyName("Address");
                _address = value;
            }
        }

        /// <summary>REGISTER_DATETIME: {NotNull, DATE(7)}</summary>
        [Seasar.Dao.Attrs.Column("REGISTER_DATETIME")]
        public DateTime? RegisterDatetime {
            get { return _registerDatetime; }
            set {
                __modifiedProperties.AddPropertyName("RegisterDatetime");
                _registerDatetime = value;
            }
        }

        /// <summary>REGISTER_PROCESS: {NotNull, VARCHAR2(200)}</summary>
        [Seasar.Dao.Attrs.Column("REGISTER_PROCESS")]
        public String RegisterProcess {
            get { return _registerProcess; }
            set {
                __modifiedProperties.AddPropertyName("RegisterProcess");
                _registerProcess = value;
            }
        }

        /// <summary>REGISTER_USER: {NotNull, VARCHAR2(200)}</summary>
        [Seasar.Dao.Attrs.Column("REGISTER_USER")]
        public String RegisterUser {
            get { return _registerUser; }
            set {
                __modifiedProperties.AddPropertyName("RegisterUser");
                _registerUser = value;
            }
        }

        /// <summary>UPDATE_DATETIME: {NotNull, DATE(7)}</summary>
        [Seasar.Dao.Attrs.Column("UPDATE_DATETIME")]
        public DateTime? UpdateDatetime {
            get { return _updateDatetime; }
            set {
                __modifiedProperties.AddPropertyName("UpdateDatetime");
                _updateDatetime = value;
            }
        }

        /// <summary>UPDATE_PROCESS: {NotNull, VARCHAR2(200)}</summary>
        [Seasar.Dao.Attrs.Column("UPDATE_PROCESS")]
        public String UpdateProcess {
            get { return _updateProcess; }
            set {
                __modifiedProperties.AddPropertyName("UpdateProcess");
                _updateProcess = value;
            }
        }

        /// <summary>UPDATE_USER: {NotNull, VARCHAR2(200)}</summary>
        [Seasar.Dao.Attrs.Column("UPDATE_USER")]
        public String UpdateUser {
            get { return _updateUser; }
            set {
                __modifiedProperties.AddPropertyName("UpdateUser");
                _updateUser = value;
            }
        }

        /// <summary>VERSION_NO: {NotNull, NUMBER(16)}</summary>
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

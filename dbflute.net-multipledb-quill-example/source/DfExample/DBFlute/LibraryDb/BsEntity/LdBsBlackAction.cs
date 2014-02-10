

using System;
using System.Reflection;
using System.Collections.Generic;
using System.Text;

using DfExample.DBFlute.LibraryDb.AllCommon;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean;
using DfExample.DBFlute.LibraryDb.AllCommon.Dbm;
using DfExample.DBFlute.LibraryDb.AllCommon.Helper;
using DfExample.DBFlute.LibraryDb.ExEntity;
using DfExample.DBFlute.LibraryDb.BsEntity.Dbm;


namespace DfExample.DBFlute.LibraryDb.ExEntity {

    /// <summary>
    /// The entity of black_action as TABLE. (partial class for auto-generation)
    /// <![CDATA[
    /// [primary-key]
    ///     BLACK_ACTION_ID
    /// 
    /// [column]
    ///     BLACK_ACTION_ID, BLACK_LIST_ID, BLACK_ACTION_CODE, BLACK_LEVEL, ACTION_DATE, EVIDENCE_PHOTOGRAPH, R_USER, R_MODULE, R_TIMESTAMP, U_USER, U_MODULE, U_TIMESTAMP
    /// 
    /// [sequence]
    ///     
    /// 
    /// [identity]
    ///     BLACK_ACTION_ID
    /// 
    /// [version-no]
    ///     
    /// 
    /// [foreign-table]
    ///     black_list, black_action_lookup
    /// 
    /// [referrer-table]
    ///     
    /// 
    /// [foreign-property]
    ///     blackList, blackActionLookup
    /// 
    /// [referrer-property]
    ///     
    /// ]]>
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    [Seasar.Dao.Attrs.Table("black_action")]
    [Seasar.Dao.Attrs.TimestampProperty("UTimestamp")]
    [System.Serializable]
    public partial class LdBlackAction : LdEntityDefinedCommonColumn {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        #region Attribute
        /// <summary>BLACK_ACTION_ID: {PK, ID, NotNull, INT(10)}</summary>
        protected int? _blackActionId;

        /// <summary>BLACK_LIST_ID: {IX, NotNull, INT(10), FK to black_list}</summary>
        protected int? _blackListId;

        /// <summary>BLACK_ACTION_CODE: {IX, NotNull, CHAR(3), FK to black_action_lookup}</summary>
        protected String _blackActionCode;

        /// <summary>BLACK_LEVEL: {NotNull, INT(10)}</summary>
        protected int? _blackLevel;

        /// <summary>ACTION_DATE: {DATETIME(19)}</summary>
        protected DateTime? _actionDate;

        /// <summary>EVIDENCE_PHOTOGRAPH: {BLOB(65535)}</summary>
        protected byte[] _evidencePhotograph;

        /// <summary>R_USER: {NotNull, VARCHAR(100), default=[default-user]}</summary>
        protected String _rUser;

        /// <summary>R_MODULE: {NotNull, VARCHAR(100), default=[default-module]}</summary>
        protected String _rModule;

        /// <summary>R_TIMESTAMP: {NotNull, DATETIME(19)}</summary>
        protected DateTime? _rTimestamp;

        /// <summary>U_USER: {NotNull, VARCHAR(100), default=[default-user]}</summary>
        protected String _uUser;

        /// <summary>U_MODULE: {NotNull, VARCHAR(100), default=[default-module]}</summary>
        protected String _uModule;

        /// <summary>U_TIMESTAMP: {NotNull, DATETIME(19)}</summary>
        protected DateTime? _uTimestamp;

        protected EntityModifiedProperties __modifiedProperties = new EntityModifiedProperties();

        protected bool __canCommonColumnAutoSetup = true;
        #endregion

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public String TableDbName { get { return "black_action"; } }
        public String TablePropertyName { get { return "BlackAction"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public LdDBMeta DBMeta { get { return LdDBMetaInstanceHandler.FindDBMeta(TableDbName); } }

        // ===============================================================================
        //                                                                Foreign Property
        //                                                                ================
        #region Foreign Property
        protected LdBlackList _blackList;

        /// <summary>black_list as 'BlackList'.</summary>
        [Seasar.Dao.Attrs.Relno(0), Seasar.Dao.Attrs.Relkeys("BLACK_LIST_ID:BLACK_LIST_ID")]
        public LdBlackList BlackList {
            get { return _blackList; }
            set { _blackList = value; }
        }

        protected LdBlackActionLookup _blackActionLookup;

        /// <summary>black_action_lookup as 'BlackActionLookup'.</summary>
        [Seasar.Dao.Attrs.Relno(1), Seasar.Dao.Attrs.Relkeys("BLACK_ACTION_CODE:BLACK_ACTION_CODE")]
        public LdBlackActionLookup BlackActionLookup {
            get { return _blackActionLookup; }
            set { _blackActionLookup = value; }
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
                if (_blackActionId == null) { return false; }
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
            if (other == null || !(other is LdBlackAction)) { return false; }
            LdBlackAction otherEntity = (LdBlackAction)other;
            if (!xSV(this.BlackActionId, otherEntity.BlackActionId)) { return false; }
            return true;
        }
        protected bool xSV(Object value1, Object value2) { // isSameValue()
            if (value1 == null && value2 == null) { return true; }
            if (value1 == null || value2 == null) { return false; }
            return value1.Equals(value2);
        }

        public override int GetHashCode() {
            int result = 17;
            result = xCH(result, _blackActionId);
            return result;
        }
        protected int xCH(int result, Object value) { // calculateHashcode()
            if (value == null) { return result; }
            return (31*result) + (value is byte[] ? ((byte[])value).Length : value.GetHashCode());
        }

        public override String ToString() {
            return "LdBlackAction:" + BuildColumnString() + BuildRelationString();
        }

        public virtual String ToStringWithRelation() {
            StringBuilder sb = new StringBuilder();
            sb.Append(ToString());
            String l = "\n  ";
            if (_blackList != null)
            { sb.Append(l).Append(xbRDS(_blackList, "BlackList")); }
            if (_blackActionLookup != null)
            { sb.Append(l).Append(xbRDS(_blackActionLookup, "BlackActionLookup")); }
            return sb.ToString();
        }
        protected String xbRDS(LdEntity e, String name) { // buildRelationDisplayString()
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
            sb.Append(c).Append(this.BlackActionId);
            sb.Append(c).Append(this.BlackListId);
            sb.Append(c).Append(this.BlackActionCode);
            sb.Append(c).Append(this.BlackLevel);
            sb.Append(c).Append(this.ActionDate);
            sb.Append(c).Append(xfBA(this.EvidencePhotograph));
            sb.Append(c).Append(this.RUser);
            sb.Append(c).Append(this.RModule);
            sb.Append(c).Append(this.RTimestamp);
            sb.Append(c).Append(this.UUser);
            sb.Append(c).Append(this.UModule);
            sb.Append(c).Append(this.UTimestamp);
            if (sb.Length > 0) { sb.Remove(0, c.Length); }
            sb.Insert(0, "{").Append("}");
            return sb.ToString();
        }
        protected String xfBA(byte[] byteArray) { // formatByteArray()
            return "byte[" + (byteArray != null ? byteArray.Length.ToString() : "null") + "]";
        }
        protected virtual String BuildRelationString() {
            StringBuilder sb = new StringBuilder();
            String c = ",";
            if (_blackList != null) { sb.Append(c).Append("BlackList"); }
            if (_blackActionLookup != null) { sb.Append(c).Append("BlackActionLookup"); }
            if (sb.Length > 0) { sb.Remove(0, c.Length).Insert(0, "(").Append(")"); }
            return sb.ToString();
        }
        #endregion

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        #region Accessor
        /// <summary>BLACK_ACTION_ID: {PK, ID, NotNull, INT(10)}</summary>
        [Seasar.Dao.Attrs.ID("identity")]
        [Seasar.Dao.Attrs.Column("BLACK_ACTION_ID")]
        public int? BlackActionId {
            get { return _blackActionId; }
            set {
                __modifiedProperties.AddPropertyName("BlackActionId");
                _blackActionId = value;
            }
        }

        /// <summary>BLACK_LIST_ID: {IX, NotNull, INT(10), FK to black_list}</summary>
        [Seasar.Dao.Attrs.Column("BLACK_LIST_ID")]
        public int? BlackListId {
            get { return _blackListId; }
            set {
                __modifiedProperties.AddPropertyName("BlackListId");
                _blackListId = value;
            }
        }

        /// <summary>BLACK_ACTION_CODE: {IX, NotNull, CHAR(3), FK to black_action_lookup}</summary>
        [Seasar.Dao.Attrs.Column("BLACK_ACTION_CODE")]
        public String BlackActionCode {
            get { return _blackActionCode; }
            set {
                __modifiedProperties.AddPropertyName("BlackActionCode");
                _blackActionCode = value;
            }
        }

        /// <summary>BLACK_LEVEL: {NotNull, INT(10)}</summary>
        [Seasar.Dao.Attrs.Column("BLACK_LEVEL")]
        public int? BlackLevel {
            get { return _blackLevel; }
            set {
                __modifiedProperties.AddPropertyName("BlackLevel");
                _blackLevel = value;
            }
        }

        /// <summary>ACTION_DATE: {DATETIME(19)}</summary>
        [Seasar.Dao.Attrs.Column("ACTION_DATE")]
        public DateTime? ActionDate {
            get { return _actionDate; }
            set {
                __modifiedProperties.AddPropertyName("ActionDate");
                _actionDate = value;
            }
        }

        /// <summary>EVIDENCE_PHOTOGRAPH: {BLOB(65535)}</summary>
        [Seasar.Dao.Attrs.Column("EVIDENCE_PHOTOGRAPH")]
        public byte[] EvidencePhotograph {
            get { return _evidencePhotograph; }
            set {
                __modifiedProperties.AddPropertyName("EvidencePhotograph");
                _evidencePhotograph = value;
            }
        }

        /// <summary>R_USER: {NotNull, VARCHAR(100), default=[default-user]}</summary>
        [Seasar.Dao.Attrs.Column("R_USER")]
        public String RUser {
            get { return _rUser; }
            set {
                __modifiedProperties.AddPropertyName("RUser");
                _rUser = value;
            }
        }

        /// <summary>R_MODULE: {NotNull, VARCHAR(100), default=[default-module]}</summary>
        [Seasar.Dao.Attrs.Column("R_MODULE")]
        public String RModule {
            get { return _rModule; }
            set {
                __modifiedProperties.AddPropertyName("RModule");
                _rModule = value;
            }
        }

        /// <summary>R_TIMESTAMP: {NotNull, DATETIME(19)}</summary>
        [Seasar.Dao.Attrs.Column("R_TIMESTAMP")]
        public DateTime? RTimestamp {
            get { return _rTimestamp; }
            set {
                __modifiedProperties.AddPropertyName("RTimestamp");
                _rTimestamp = value;
            }
        }

        /// <summary>U_USER: {NotNull, VARCHAR(100), default=[default-user]}</summary>
        [Seasar.Dao.Attrs.Column("U_USER")]
        public String UUser {
            get { return _uUser; }
            set {
                __modifiedProperties.AddPropertyName("UUser");
                _uUser = value;
            }
        }

        /// <summary>U_MODULE: {NotNull, VARCHAR(100), default=[default-module]}</summary>
        [Seasar.Dao.Attrs.Column("U_MODULE")]
        public String UModule {
            get { return _uModule; }
            set {
                __modifiedProperties.AddPropertyName("UModule");
                _uModule = value;
            }
        }

        /// <summary>U_TIMESTAMP: {NotNull, DATETIME(19)}</summary>
        [Seasar.Dao.Attrs.Column("U_TIMESTAMP")]
        public DateTime? UTimestamp {
            get { return _uTimestamp; }
            set {
                __modifiedProperties.AddPropertyName("UTimestamp");
                _uTimestamp = value;
            }
        }

        #endregion
    }
}



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
    /// The entity of library as TABLE. (partial class for auto-generation)
    /// <![CDATA[
    /// [primary-key]
    ///     LIBRARY_ID
    /// 
    /// [column]
    ///     LIBRARY_ID, LIBRARY_NAME, LIBRARY_TYPE_CODE, R_USER, R_MODULE, R_TIMESTAMP, U_USER, U_MODULE, U_TIMESTAMP
    /// 
    /// [sequence]
    ///     
    /// 
    /// [identity]
    ///     LIBRARY_ID
    /// 
    /// [version-no]
    ///     
    /// 
    /// [foreign-table]
    ///     library_type_lookup
    /// 
    /// [referrer-table]
    ///     collection, library_user, next_library
    /// 
    /// [foreign-property]
    ///     libraryTypeLookup
    /// 
    /// [referrer-property]
    ///     collectionList, libraryUserList, nextLibraryByLibraryIdList, nextLibraryByNextLibraryIdList
    /// ]]>
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    [Seasar.Dao.Attrs.Table("library")]
    [Seasar.Dao.Attrs.TimestampProperty("UTimestamp")]
    [System.Serializable]
    public partial class LdLibrary : LdEntityDefinedCommonColumn {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        #region Attribute
        /// <summary>LIBRARY_ID: {PK, ID, NotNull, INT(10)}</summary>
        protected int? _libraryId;

        /// <summary>LIBRARY_NAME: {UQ, NotNull, VARCHAR(80)}</summary>
        protected String _libraryName;

        /// <summary>LIBRARY_TYPE_CODE: {IX, NotNull, CHAR(3), FK to library_type_lookup}</summary>
        protected String _libraryTypeCode;

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
        public String TableDbName { get { return "library"; } }
        public String TablePropertyName { get { return "Library"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public LdDBMeta DBMeta { get { return LdDBMetaInstanceHandler.FindDBMeta(TableDbName); } }

        // ===============================================================================
        //                                                                Foreign Property
        //                                                                ================
        #region Foreign Property
        protected LdLibraryTypeLookup _libraryTypeLookup;

        /// <summary>library_type_lookup as 'LibraryTypeLookup'.</summary>
        [Seasar.Dao.Attrs.Relno(0), Seasar.Dao.Attrs.Relkeys("LIBRARY_TYPE_CODE:LIBRARY_TYPE_CODE")]
        public LdLibraryTypeLookup LibraryTypeLookup {
            get { return _libraryTypeLookup; }
            set { _libraryTypeLookup = value; }
        }

        #endregion

        // ===============================================================================
        //                                                               Referrer Property
        //                                                               =================
        #region Referrer Property
        protected IList<LdCollection> _collectionList;

        /// <summary>collection as 'CollectionList'.</summary>
        public IList<LdCollection> CollectionList {
            get { if (_collectionList == null) { _collectionList = new List<LdCollection>(); } return _collectionList; }
            set { _collectionList = value; }
        }

        protected IList<LdLibraryUser> _libraryUserList;

        /// <summary>library_user as 'LibraryUserList'.</summary>
        public IList<LdLibraryUser> LibraryUserList {
            get { if (_libraryUserList == null) { _libraryUserList = new List<LdLibraryUser>(); } return _libraryUserList; }
            set { _libraryUserList = value; }
        }

        protected IList<LdNextLibrary> _nextLibraryByLibraryIdList;

        /// <summary>next_library as 'NextLibraryByLibraryIdList'.</summary>
        public IList<LdNextLibrary> NextLibraryByLibraryIdList {
            get { if (_nextLibraryByLibraryIdList == null) { _nextLibraryByLibraryIdList = new List<LdNextLibrary>(); } return _nextLibraryByLibraryIdList; }
            set { _nextLibraryByLibraryIdList = value; }
        }

        protected IList<LdNextLibrary> _nextLibraryByNextLibraryIdList;

        /// <summary>next_library as 'NextLibraryByNextLibraryIdList'.</summary>
        public IList<LdNextLibrary> NextLibraryByNextLibraryIdList {
            get { if (_nextLibraryByNextLibraryIdList == null) { _nextLibraryByNextLibraryIdList = new List<LdNextLibrary>(); } return _nextLibraryByNextLibraryIdList; }
            set { _nextLibraryByNextLibraryIdList = value; }
        }

        #endregion

        // ===============================================================================
        //                                                                   Determination
        //                                                                   =============
        public virtual bool HasPrimaryKeyValue {
            get {
                if (_libraryId == null) { return false; }
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
            if (other == null || !(other is LdLibrary)) { return false; }
            LdLibrary otherEntity = (LdLibrary)other;
            if (!xSV(this.LibraryId, otherEntity.LibraryId)) { return false; }
            return true;
        }
        protected bool xSV(Object value1, Object value2) { // isSameValue()
            if (value1 == null && value2 == null) { return true; }
            if (value1 == null || value2 == null) { return false; }
            return value1.Equals(value2);
        }

        public override int GetHashCode() {
            int result = 17;
            result = xCH(result, _libraryId);
            return result;
        }
        protected int xCH(int result, Object value) { // calculateHashcode()
            if (value == null) { return result; }
            return (31*result) + (value is byte[] ? ((byte[])value).Length : value.GetHashCode());
        }

        public override String ToString() {
            return "LdLibrary:" + BuildColumnString() + BuildRelationString();
        }

        public virtual String ToStringWithRelation() {
            StringBuilder sb = new StringBuilder();
            sb.Append(ToString());
            String l = "\n  ";
            if (_libraryTypeLookup != null)
            { sb.Append(l).Append(xbRDS(_libraryTypeLookup, "LibraryTypeLookup")); }
            if (_collectionList != null) { foreach (LdEntity e in _collectionList)
            { if (e != null) { sb.Append(l).Append(xbRDS(e, "CollectionList")); } } }
            if (_libraryUserList != null) { foreach (LdEntity e in _libraryUserList)
            { if (e != null) { sb.Append(l).Append(xbRDS(e, "LibraryUserList")); } } }
            if (_nextLibraryByLibraryIdList != null) { foreach (LdEntity e in _nextLibraryByLibraryIdList)
            { if (e != null) { sb.Append(l).Append(xbRDS(e, "NextLibraryByLibraryIdList")); } } }
            if (_nextLibraryByNextLibraryIdList != null) { foreach (LdEntity e in _nextLibraryByNextLibraryIdList)
            { if (e != null) { sb.Append(l).Append(xbRDS(e, "NextLibraryByNextLibraryIdList")); } } }
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
            sb.Append(c).Append(this.LibraryId);
            sb.Append(c).Append(this.LibraryName);
            sb.Append(c).Append(this.LibraryTypeCode);
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
        protected virtual String BuildRelationString() {
            StringBuilder sb = new StringBuilder();
            String c = ",";
            if (_libraryTypeLookup != null) { sb.Append(c).Append("LibraryTypeLookup"); }
            if (_collectionList != null && _collectionList.Count > 0)
            { sb.Append(c).Append("CollectionList"); }
            if (_libraryUserList != null && _libraryUserList.Count > 0)
            { sb.Append(c).Append("LibraryUserList"); }
            if (_nextLibraryByLibraryIdList != null && _nextLibraryByLibraryIdList.Count > 0)
            { sb.Append(c).Append("NextLibraryByLibraryIdList"); }
            if (_nextLibraryByNextLibraryIdList != null && _nextLibraryByNextLibraryIdList.Count > 0)
            { sb.Append(c).Append("NextLibraryByNextLibraryIdList"); }
            if (sb.Length > 0) { sb.Remove(0, c.Length).Insert(0, "(").Append(")"); }
            return sb.ToString();
        }
        #endregion

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        #region Accessor
        /// <summary>LIBRARY_ID: {PK, ID, NotNull, INT(10)}</summary>
        [Seasar.Dao.Attrs.ID("identity")]
        [Seasar.Dao.Attrs.Column("LIBRARY_ID")]
        public int? LibraryId {
            get { return _libraryId; }
            set {
                __modifiedProperties.AddPropertyName("LibraryId");
                _libraryId = value;
            }
        }

        /// <summary>LIBRARY_NAME: {UQ, NotNull, VARCHAR(80)}</summary>
        [Seasar.Dao.Attrs.Column("LIBRARY_NAME")]
        public String LibraryName {
            get { return _libraryName; }
            set {
                __modifiedProperties.AddPropertyName("LibraryName");
                _libraryName = value;
            }
        }

        /// <summary>LIBRARY_TYPE_CODE: {IX, NotNull, CHAR(3), FK to library_type_lookup}</summary>
        [Seasar.Dao.Attrs.Column("LIBRARY_TYPE_CODE")]
        public String LibraryTypeCode {
            get { return _libraryTypeCode; }
            set {
                __modifiedProperties.AddPropertyName("LibraryTypeCode");
                _libraryTypeCode = value;
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

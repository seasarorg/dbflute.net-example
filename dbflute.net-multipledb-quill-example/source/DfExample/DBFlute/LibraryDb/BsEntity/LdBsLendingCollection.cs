

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
    /// The entity of lending_collection as TABLE. (partial class for auto-generation)
    /// <![CDATA[
    /// [primary-key]
    ///     LIBRARY_ID, LB_USER_ID, LENDING_DATE, COLLECTION_ID
    /// 
    /// [column]
    ///     LIBRARY_ID, LB_USER_ID, LENDING_DATE, COLLECTION_ID, RETURN_LIMIT_DATE, R_USER, R_MODULE, R_TIMESTAMP, U_USER, U_MODULE, U_TIMESTAMP
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
    ///     collection, lending, LIBRARY_USER
    /// 
    /// [referrer-table]
    ///     
    /// 
    /// [foreign-property]
    ///     collection, lending, libraryUser
    /// 
    /// [referrer-property]
    ///     
    /// ]]>
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    [Seasar.Dao.Attrs.Table("lending_collection")]
    [Seasar.Dao.Attrs.TimestampProperty("UTimestamp")]
    [System.Serializable]
    public partial class LdLendingCollection : LdEntityDefinedCommonColumn {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        #region Attribute
        /// <summary>LIBRARY_ID: {PK, NotNull, INT(10), FK to lending}</summary>
        protected int? _libraryId;

        /// <summary>LB_USER_ID: {PK, NotNull, INT(10), FK to lending}</summary>
        protected int? _lbUserId;

        /// <summary>LENDING_DATE: {PK, NotNull, DATETIME(19), FK to lending}</summary>
        protected DateTime? _lendingDate;

        /// <summary>COLLECTION_ID: {PK, IX, NotNull, INT(10), FK to collection}</summary>
        protected int? _collectionId;

        /// <summary>RETURN_LIMIT_DATE: {NotNull, DATETIME(19)}</summary>
        protected DateTime? _returnLimitDate;

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
        public String TableDbName { get { return "lending_collection"; } }
        public String TablePropertyName { get { return "LendingCollection"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public LdDBMeta DBMeta { get { return LdDBMetaInstanceHandler.FindDBMeta(TableDbName); } }

        // ===============================================================================
        //                                                                Foreign Property
        //                                                                ================
        #region Foreign Property
        protected LdCollection _collection;

        /// <summary>collection as 'Collection'.</summary>
        [Seasar.Dao.Attrs.Relno(0), Seasar.Dao.Attrs.Relkeys("COLLECTION_ID:COLLECTION_ID")]
        public LdCollection Collection {
            get { return _collection; }
            set { _collection = value; }
        }

        protected LdLending _lending;

        /// <summary>lending as 'Lending'.</summary>
        [Seasar.Dao.Attrs.Relno(1), Seasar.Dao.Attrs.Relkeys("LIBRARY_ID:LIBRARY_ID, LB_USER_ID:LB_USER_ID, LENDING_DATE:LENDING_DATE")]
        public LdLending Lending {
            get { return _lending; }
            set { _lending = value; }
        }

        protected LdLibraryUser _libraryUser;

        /// <summary>library_user as 'LibraryUser'.</summary>
        [Seasar.Dao.Attrs.Relno(2), Seasar.Dao.Attrs.Relkeys("LIBRARY_ID:LIBRARY_ID, LB_USER_ID:LB_USER_ID")]
        public LdLibraryUser LibraryUser {
            get { return _libraryUser; }
            set { _libraryUser = value; }
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
                if (_libraryId == null) { return false; }
                if (_lbUserId == null) { return false; }
                if (_lendingDate == null) { return false; }
                if (_collectionId == null) { return false; }
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
            if (other == null || !(other is LdLendingCollection)) { return false; }
            LdLendingCollection otherEntity = (LdLendingCollection)other;
            if (!xSV(this.LibraryId, otherEntity.LibraryId)) { return false; }
            if (!xSV(this.LbUserId, otherEntity.LbUserId)) { return false; }
            if (!xSV(this.LendingDate, otherEntity.LendingDate)) { return false; }
            if (!xSV(this.CollectionId, otherEntity.CollectionId)) { return false; }
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
            result = xCH(result, _lbUserId);
            result = xCH(result, _lendingDate);
            result = xCH(result, _collectionId);
            return result;
        }
        protected int xCH(int result, Object value) { // calculateHashcode()
            if (value == null) { return result; }
            return (31*result) + (value is byte[] ? ((byte[])value).Length : value.GetHashCode());
        }

        public override String ToString() {
            return "LdLendingCollection:" + BuildColumnString() + BuildRelationString();
        }

        public virtual String ToStringWithRelation() {
            StringBuilder sb = new StringBuilder();
            sb.Append(ToString());
            String l = "\n  ";
            if (_collection != null)
            { sb.Append(l).Append(xbRDS(_collection, "Collection")); }
            if (_lending != null)
            { sb.Append(l).Append(xbRDS(_lending, "Lending")); }
            if (_libraryUser != null)
            { sb.Append(l).Append(xbRDS(_libraryUser, "LibraryUser")); }
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
            sb.Append(c).Append(this.LbUserId);
            sb.Append(c).Append(this.LendingDate);
            sb.Append(c).Append(this.CollectionId);
            sb.Append(c).Append(this.ReturnLimitDate);
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
            if (_collection != null) { sb.Append(c).Append("Collection"); }
            if (_lending != null) { sb.Append(c).Append("Lending"); }
            if (_libraryUser != null) { sb.Append(c).Append("LibraryUser"); }
            if (sb.Length > 0) { sb.Remove(0, c.Length).Insert(0, "(").Append(")"); }
            return sb.ToString();
        }
        #endregion

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        #region Accessor
        /// <summary>LIBRARY_ID: {PK, NotNull, INT(10), FK to lending}</summary>
        [Seasar.Dao.Attrs.Column("LIBRARY_ID")]
        public int? LibraryId {
            get { return _libraryId; }
            set {
                __modifiedProperties.AddPropertyName("LibraryId");
                _libraryId = value;
            }
        }

        /// <summary>LB_USER_ID: {PK, NotNull, INT(10), FK to lending}</summary>
        [Seasar.Dao.Attrs.Column("LB_USER_ID")]
        public int? LbUserId {
            get { return _lbUserId; }
            set {
                __modifiedProperties.AddPropertyName("LbUserId");
                _lbUserId = value;
            }
        }

        /// <summary>LENDING_DATE: {PK, NotNull, DATETIME(19), FK to lending}</summary>
        [Seasar.Dao.Attrs.Column("LENDING_DATE")]
        public DateTime? LendingDate {
            get { return _lendingDate; }
            set {
                __modifiedProperties.AddPropertyName("LendingDate");
                _lendingDate = value;
            }
        }

        /// <summary>COLLECTION_ID: {PK, IX, NotNull, INT(10), FK to collection}</summary>
        [Seasar.Dao.Attrs.Column("COLLECTION_ID")]
        public int? CollectionId {
            get { return _collectionId; }
            set {
                __modifiedProperties.AddPropertyName("CollectionId");
                _collectionId = value;
            }
        }

        /// <summary>RETURN_LIMIT_DATE: {NotNull, DATETIME(19)}</summary>
        [Seasar.Dao.Attrs.Column("RETURN_LIMIT_DATE")]
        public DateTime? ReturnLimitDate {
            get { return _returnLimitDate; }
            set {
                __modifiedProperties.AddPropertyName("ReturnLimitDate");
                _returnLimitDate = value;
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

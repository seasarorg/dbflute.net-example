

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
    /// The entity of collection_status as TABLE. (partial class for auto-generation)
    /// <![CDATA[
    /// [primary-key]
    ///     COLLECTION_ID
    /// 
    /// [column]
    ///     COLLECTION_ID, COLLECTION_STATUS_CODE, R_USER, R_MODULE, R_TIMESTAMP, U_USER, U_MODULE, U_TIMESTAMP
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
    ///     collection, collection_status_lookup
    /// 
    /// [referrer-table]
    ///     
    /// 
    /// [foreign-property]
    ///     collection, collectionStatusLookup
    /// 
    /// [referrer-property]
    ///     
    /// ]]>
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    [Seasar.Dao.Attrs.Table("collection_status")]
    [Seasar.Dao.Attrs.TimestampProperty("UTimestamp")]
    [System.Serializable]
    public partial class LdCollectionStatus : LdEntityDefinedCommonColumn {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        #region Attribute
        /// <summary>COLLECTION_ID: {PK, NotNull, INT(10), FK to collection}</summary>
        protected int? _collectionId;

        /// <summary>COLLECTION_STATUS_CODE: {IX, NotNull, CHAR(3), FK to collection_status_lookup, classification=CollectionStatus}</summary>
        protected String _collectionStatusCode;

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
        public String TableDbName { get { return "collection_status"; } }
        public String TablePropertyName { get { return "CollectionStatus"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public LdDBMeta DBMeta { get { return LdDBMetaInstanceHandler.FindDBMeta(TableDbName); } }

        // ===============================================================================
        //                                                         Classification Property
        //                                                         =======================
        #region Classification Property
        public LdCDef.CollectionStatus CollectionStatusCodeAsCollectionStatus { get {
            return LdCDef.CollectionStatus.CodeOf(_collectionStatusCode);
        } set {
            CollectionStatusCode = value != null ? value.Code : null;
        }}

        #endregion

        // ===============================================================================
        //                                                          Classification Setting
        //                                                          ======================
        #region Classification Setting
        /// <summary>
        /// Set the value of collectionStatusCode as NOR.
        /// <![CDATA[
        /// NOR: 通常状態を示す
        /// ]]>
        /// </summary>
        public void SetCollectionStatusCode_NOR() {
            CollectionStatusCodeAsCollectionStatus = LdCDef.CollectionStatus.NOR;
        }

        /// <summary>
        /// Set the value of collectionStatusCode as WAT.
        /// <![CDATA[
        /// WAT: 待ち状態を示す
        /// ]]>
        /// </summary>
        public void SetCollectionStatusCode_WAT() {
            CollectionStatusCodeAsCollectionStatus = LdCDef.CollectionStatus.WAT;
        }

        /// <summary>
        /// Set the value of collectionStatusCode as OUT.
        /// <![CDATA[
        /// OUT: 貸し出し中を示す
        /// ]]>
        /// </summary>
        public void SetCollectionStatusCode_OUT() {
            CollectionStatusCodeAsCollectionStatus = LdCDef.CollectionStatus.OUT;
        }

        #endregion

        // ===============================================================================
        //                                                    Classification Determination
        //                                                    ============================
        #region Classification Determination
        /// <summary>
        /// Is the value of collectionStatusCode 'NOR'?
        /// <![CDATA[
        /// The difference of capital letters and small letters is NOT distinguished.
        /// If the value is null, this method returns false!
        /// NOR: 通常状態を示す
        /// ]]>
        /// </summary>
        public bool IsCollectionStatusCodeNOR {
            get {
                LdCDef.CollectionStatus cls = CollectionStatusCodeAsCollectionStatus;
                return cls != null ? cls.Equals(LdCDef.CollectionStatus.NOR) : false;
            }
        }

        /// <summary>
        /// Is the value of collectionStatusCode 'WAT'?
        /// <![CDATA[
        /// The difference of capital letters and small letters is NOT distinguished.
        /// If the value is null, this method returns false!
        /// WAT: 待ち状態を示す
        /// ]]>
        /// </summary>
        public bool IsCollectionStatusCodeWAT {
            get {
                LdCDef.CollectionStatus cls = CollectionStatusCodeAsCollectionStatus;
                return cls != null ? cls.Equals(LdCDef.CollectionStatus.WAT) : false;
            }
        }

        /// <summary>
        /// Is the value of collectionStatusCode 'OUT'?
        /// <![CDATA[
        /// The difference of capital letters and small letters is NOT distinguished.
        /// If the value is null, this method returns false!
        /// OUT: 貸し出し中を示す
        /// ]]>
        /// </summary>
        public bool IsCollectionStatusCodeOUT {
            get {
                LdCDef.CollectionStatus cls = CollectionStatusCodeAsCollectionStatus;
                return cls != null ? cls.Equals(LdCDef.CollectionStatus.OUT) : false;
            }
        }

        #endregion

        // ===============================================================================
        //                                                       Classification Name/Alias
        //                                                       =========================
        #region Classification Name/Alias
        #endregion

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

        protected LdCollectionStatusLookup _collectionStatusLookup;

        /// <summary>collection_status_lookup as 'CollectionStatusLookup'.</summary>
        [Seasar.Dao.Attrs.Relno(1), Seasar.Dao.Attrs.Relkeys("COLLECTION_STATUS_CODE:COLLECTION_STATUS_CODE")]
        public LdCollectionStatusLookup CollectionStatusLookup {
            get { return _collectionStatusLookup; }
            set { _collectionStatusLookup = value; }
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
            if (other == null || !(other is LdCollectionStatus)) { return false; }
            LdCollectionStatus otherEntity = (LdCollectionStatus)other;
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
            result = xCH(result, _collectionId);
            return result;
        }
        protected int xCH(int result, Object value) { // calculateHashcode()
            if (value == null) { return result; }
            return (31*result) + (value is byte[] ? ((byte[])value).Length : value.GetHashCode());
        }

        public override String ToString() {
            return "LdCollectionStatus:" + BuildColumnString() + BuildRelationString();
        }

        public virtual String ToStringWithRelation() {
            StringBuilder sb = new StringBuilder();
            sb.Append(ToString());
            String l = "\n  ";
            if (_collection != null)
            { sb.Append(l).Append(xbRDS(_collection, "Collection")); }
            if (_collectionStatusLookup != null)
            { sb.Append(l).Append(xbRDS(_collectionStatusLookup, "CollectionStatusLookup")); }
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
            sb.Append(c).Append(this.CollectionId);
            sb.Append(c).Append(this.CollectionStatusCode);
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
            if (_collectionStatusLookup != null) { sb.Append(c).Append("CollectionStatusLookup"); }
            if (sb.Length > 0) { sb.Remove(0, c.Length).Insert(0, "(").Append(")"); }
            return sb.ToString();
        }
        #endregion

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        #region Accessor
        /// <summary>COLLECTION_ID: {PK, NotNull, INT(10), FK to collection}</summary>
        [Seasar.Dao.Attrs.Column("COLLECTION_ID")]
        public int? CollectionId {
            get { return _collectionId; }
            set {
                __modifiedProperties.AddPropertyName("CollectionId");
                _collectionId = value;
            }
        }

        /// <summary>COLLECTION_STATUS_CODE: {IX, NotNull, CHAR(3), FK to collection_status_lookup, classification=CollectionStatus}</summary>
        [Seasar.Dao.Attrs.Column("COLLECTION_STATUS_CODE")]
        public String CollectionStatusCode {
            get { return _collectionStatusCode; }
            set {
                __modifiedProperties.AddPropertyName("CollectionStatusCode");
                _collectionStatusCode = value;
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

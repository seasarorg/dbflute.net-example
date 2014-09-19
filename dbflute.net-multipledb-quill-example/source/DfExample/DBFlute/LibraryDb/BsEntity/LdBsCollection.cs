

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
    /// The entity of collection as TABLE. (partial class for auto-generation)
    /// <![CDATA[
    /// [primary-key]
    ///     COLLECTION_ID
    /// 
    /// [column]
    ///     COLLECTION_ID, LIBRARY_ID, BOOK_ID, ARRIVAL_DATE, R_USER, R_MODULE, R_TIMESTAMP, U_USER, U_MODULE, U_TIMESTAMP
    /// 
    /// [sequence]
    ///     
    /// 
    /// [identity]
    ///     COLLECTION_ID
    /// 
    /// [version-no]
    ///     
    /// 
    /// [foreign-table]
    ///     book, library, collection_status(AsOne)
    /// 
    /// [referrer-table]
    ///     lending_collection, collection_status
    /// 
    /// [foreign-property]
    ///     book, library, collectionStatusAsOne
    /// 
    /// [referrer-property]
    ///     lendingCollectionList
    /// ]]>
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    [Seasar.Dao.Attrs.Table("collection")]
    [Seasar.Dao.Attrs.TimestampProperty("UTimestamp")]
    [System.Serializable]
    public partial class LdCollection : LdEntityDefinedCommonColumn {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        #region Attribute
        /// <summary>COLLECTION_ID: {PK, ID, NotNull, INT(10)}</summary>
        protected int? _collectionId;

        /// <summary>LIBRARY_ID: {UQ+, NotNull, INT(10), FK to library}</summary>
        protected int? _libraryId;

        /// <summary>BOOK_ID: {+UQ, IX, NotNull, INT(10), FK to book}</summary>
        protected int? _bookId;

        /// <summary>ARRIVAL_DATE: {NotNull, DATETIME(19)}</summary>
        protected DateTime? _arrivalDate;

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
        public String TableDbName { get { return "collection"; } }
        public String TablePropertyName { get { return "Collection"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public LdDBMeta DBMeta { get { return LdDBMetaInstanceHandler.FindDBMeta(TableDbName); } }

        // ===============================================================================
        //                                                                Foreign Property
        //                                                                ================
        #region Foreign Property
        protected LdBook _book;

        /// <summary>book as 'Book'.</summary>
        [Seasar.Dao.Attrs.Relno(0), Seasar.Dao.Attrs.Relkeys("BOOK_ID:BOOK_ID")]
        public LdBook Book {
            get { return _book; }
            set { _book = value; }
        }

        protected LdLibrary _library;

        /// <summary>library as 'Library'.</summary>
        [Seasar.Dao.Attrs.Relno(1), Seasar.Dao.Attrs.Relkeys("LIBRARY_ID:LIBRARY_ID")]
        public LdLibrary Library {
            get { return _library; }
            set { _library = value; }
        }

        protected LdCollectionStatus _collectionStatusAsOne;

        /// <summary>collection_status as 'CollectionStatusAsOne'.</summary>
        [Seasar.Dao.Attrs.Relno(2), Seasar.Dao.Attrs.Relkeys("COLLECTION_ID:COLLECTION_ID")]
        public LdCollectionStatus CollectionStatusAsOne {
            get { return _collectionStatusAsOne; }
            set { _collectionStatusAsOne = value; }
        }

        #endregion

        // ===============================================================================
        //                                                               Referrer Property
        //                                                               =================
        #region Referrer Property
        protected IList<LdLendingCollection> _lendingCollectionList;

        /// <summary>lending_collection as 'LendingCollectionList'.</summary>
        public IList<LdLendingCollection> LendingCollectionList {
            get { if (_lendingCollectionList == null) { _lendingCollectionList = new List<LdLendingCollection>(); } return _lendingCollectionList; }
            set { _lendingCollectionList = value; }
        }

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
            if (other == null || !(other is LdCollection)) { return false; }
            LdCollection otherEntity = (LdCollection)other;
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
            return "LdCollection:" + BuildColumnString() + BuildRelationString();
        }

        public virtual String ToStringWithRelation() {
            StringBuilder sb = new StringBuilder();
            sb.Append(ToString());
            String l = "\n  ";
            if (_book != null)
            { sb.Append(l).Append(xbRDS(_book, "Book")); }
            if (_library != null)
            { sb.Append(l).Append(xbRDS(_library, "Library")); }
            if (_collectionStatusAsOne != null)
            { sb.Append(l).Append(xbRDS(_collectionStatusAsOne, "CollectionStatusAsOne")); }
            if (_lendingCollectionList != null) { foreach (LdEntity e in _lendingCollectionList)
            { if (e != null) { sb.Append(l).Append(xbRDS(e, "LendingCollectionList")); } } }
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
            sb.Append(c).Append(this.LibraryId);
            sb.Append(c).Append(this.BookId);
            sb.Append(c).Append(this.ArrivalDate);
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
            if (_book != null) { sb.Append(c).Append("Book"); }
            if (_library != null) { sb.Append(c).Append("Library"); }
            if (_collectionStatusAsOne != null) { sb.Append(c).Append("CollectionStatusAsOne"); }
            if (_lendingCollectionList != null && _lendingCollectionList.Count > 0)
            { sb.Append(c).Append("LendingCollectionList"); }
            if (sb.Length > 0) { sb.Remove(0, c.Length).Insert(0, "(").Append(")"); }
            return sb.ToString();
        }
        #endregion

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        #region Accessor
        /// <summary>COLLECTION_ID: {PK, ID, NotNull, INT(10)}</summary>
        [Seasar.Dao.Attrs.ID("identity")]
        [Seasar.Dao.Attrs.Column("COLLECTION_ID")]
        public int? CollectionId {
            get { return _collectionId; }
            set {
                __modifiedProperties.AddPropertyName("CollectionId");
                _collectionId = value;
            }
        }

        /// <summary>LIBRARY_ID: {UQ+, NotNull, INT(10), FK to library}</summary>
        [Seasar.Dao.Attrs.Column("LIBRARY_ID")]
        public int? LibraryId {
            get { return _libraryId; }
            set {
                __modifiedProperties.AddPropertyName("LibraryId");
                _libraryId = value;
            }
        }

        /// <summary>BOOK_ID: {+UQ, IX, NotNull, INT(10), FK to book}</summary>
        [Seasar.Dao.Attrs.Column("BOOK_ID")]
        public int? BookId {
            get { return _bookId; }
            set {
                __modifiedProperties.AddPropertyName("BookId");
                _bookId = value;
            }
        }

        /// <summary>ARRIVAL_DATE: {NotNull, DATETIME(19)}</summary>
        [Seasar.Dao.Attrs.Column("ARRIVAL_DATE")]
        public DateTime? ArrivalDate {
            get { return _arrivalDate; }
            set {
                __modifiedProperties.AddPropertyName("ArrivalDate");
                _arrivalDate = value;
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

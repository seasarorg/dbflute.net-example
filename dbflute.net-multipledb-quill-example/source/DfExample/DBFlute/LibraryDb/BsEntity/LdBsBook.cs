

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
    /// The entity of book as TABLE. (partial class for auto-generation)
    /// <![CDATA[
    /// [primary-key]
    ///     BOOK_ID
    /// 
    /// [column]
    ///     BOOK_ID, ISBN, BOOK_NAME, AUTHOR_ID, PUBLISHER_ID, GENRE_CODE, OPENING_PART, MAX_LENDING_DATE_COUNT, OUT_OF_USER_SELECT_YN, OUT_OF_USER_SELECT_REASON, R_USER, R_MODULE, R_TIMESTAMP, U_USER, U_MODULE, U_TIMESTAMP
    /// 
    /// [sequence]
    ///     
    /// 
    /// [identity]
    ///     BOOK_ID
    /// 
    /// [version-no]
    ///     
    /// 
    /// [foreign-table]
    ///     author, genre, publisher, COLLECTION_STATUS_LOOKUP(AsNonExist)
    /// 
    /// [referrer-table]
    ///     collection
    /// 
    /// [foreign-property]
    ///     author, genre, publisher, collectionStatusLookupAsNonExist
    /// 
    /// [referrer-property]
    ///     collectionList
    /// ]]>
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    [Seasar.Dao.Attrs.Table("book")]
    [Seasar.Dao.Attrs.TimestampProperty("UTimestamp")]
    [System.Serializable]
    public partial class LdBook : LdEntityDefinedCommonColumn {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        #region Attribute
        /// <summary>BOOK_ID: {PK, ID, NotNull, INT(10)}</summary>
        protected int? _bookId;

        /// <summary>ISBN: {UQ, NotNull, VARCHAR(20)}</summary>
        protected String _isbn;

        /// <summary>BOOK_NAME: {NotNull, VARCHAR(80)}</summary>
        protected String _bookName;

        /// <summary>AUTHOR_ID: {IX, NotNull, INT(10), FK to author}</summary>
        protected int? _authorId;

        /// <summary>PUBLISHER_ID: {IX, NotNull, INT(10), FK to publisher}</summary>
        protected int? _publisherId;

        /// <summary>GENRE_CODE: {IX, VARCHAR(24), FK to genre}</summary>
        protected String _genreCode;

        /// <summary>OPENING_PART: {TEXT(65535)}</summary>
        protected String _openingPart;

        /// <summary>MAX_LENDING_DATE_COUNT: {NotNull, INT(10)}</summary>
        protected int? _maxLendingDateCount;

        /// <summary>OUT_OF_USER_SELECT_YN: {NotNull, CHAR(1), classification=YesNo}</summary>
        protected String _outOfUserSelectYn;

        /// <summary>OUT_OF_USER_SELECT_REASON: {VARCHAR(200)}</summary>
        protected String _outOfUserSelectReason;

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
        public String TableDbName { get { return "book"; } }
        public String TablePropertyName { get { return "Book"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public LdDBMeta DBMeta { get { return LdDBMetaInstanceHandler.FindDBMeta(TableDbName); } }

        // ===============================================================================
        //                                                         Classification Property
        //                                                         =======================
        #region Classification Property
        public LdCDef.YesNo OutOfUserSelectYnAsYesNo { get {
            return LdCDef.YesNo.CodeOf(_outOfUserSelectYn);
        } set {
            OutOfUserSelectYn = value != null ? value.Code : null;
        }}

        #endregion

        // ===============================================================================
        //                                                          Classification Setting
        //                                                          ======================
        #region Classification Setting
        /// <summary>
        /// Set the value of outOfUserSelectYn as Yes.
        /// <![CDATA[
        /// はい
        /// ]]>
        /// </summary>
        public void SetOutOfUserSelectYn_Yes() {
            OutOfUserSelectYnAsYesNo = LdCDef.YesNo.Yes;
        }

        /// <summary>
        /// Set the value of outOfUserSelectYn as No.
        /// <![CDATA[
        /// いいえ
        /// ]]>
        /// </summary>
        public void SetOutOfUserSelectYn_No() {
            OutOfUserSelectYnAsYesNo = LdCDef.YesNo.No;
        }

        #endregion

        // ===============================================================================
        //                                                    Classification Determination
        //                                                    ============================
        #region Classification Determination
        /// <summary>
        /// Is the value of outOfUserSelectYn 'Yes'?
        /// <![CDATA[
        /// The difference of capital letters and small letters is NOT distinguished.
        /// If the value is null, this method returns false!
        /// はい
        /// ]]>
        /// </summary>
        public bool IsOutOfUserSelectYnYes {
            get {
                LdCDef.YesNo cls = OutOfUserSelectYnAsYesNo;
                return cls != null ? cls.Equals(LdCDef.YesNo.Yes) : false;
            }
        }

        /// <summary>
        /// Is the value of outOfUserSelectYn 'No'?
        /// <![CDATA[
        /// The difference of capital letters and small letters is NOT distinguished.
        /// If the value is null, this method returns false!
        /// いいえ
        /// ]]>
        /// </summary>
        public bool IsOutOfUserSelectYnNo {
            get {
                LdCDef.YesNo cls = OutOfUserSelectYnAsYesNo;
                return cls != null ? cls.Equals(LdCDef.YesNo.No) : false;
            }
        }

        #endregion

        // ===============================================================================
        //                                                       Classification Name/Alias
        //                                                       =========================
        #region Classification Name/Alias
        public String OutOfUserSelectYnName {
            get {
                LdCDef.YesNo cls = OutOfUserSelectYnAsYesNo;
                return cls != null ? cls.Name : null;
            }
        }
        public String OutOfUserSelectYnAlias {
            get {
                LdCDef.YesNo cls = OutOfUserSelectYnAsYesNo;
                return cls != null ? cls.Alias : null;
            }
        }

        #endregion

        // ===============================================================================
        //                                                                Foreign Property
        //                                                                ================
        #region Foreign Property
        protected LdAuthor _author;

        /// <summary>author as 'Author'.</summary>
        [Seasar.Dao.Attrs.Relno(0), Seasar.Dao.Attrs.Relkeys("AUTHOR_ID:AUTHOR_ID")]
        public LdAuthor Author {
            get { return _author; }
            set { _author = value; }
        }

        protected LdGenre _genre;

        /// <summary>genre as 'Genre'.</summary>
        [Seasar.Dao.Attrs.Relno(1), Seasar.Dao.Attrs.Relkeys("GENRE_CODE:GENRE_CODE")]
        public LdGenre Genre {
            get { return _genre; }
            set { _genre = value; }
        }

        protected LdPublisher _publisher;

        /// <summary>publisher as 'Publisher'.</summary>
        [Seasar.Dao.Attrs.Relno(2), Seasar.Dao.Attrs.Relkeys("PUBLISHER_ID:PUBLISHER_ID")]
        public LdPublisher Publisher {
            get { return _publisher; }
            set { _publisher = value; }
        }

        protected LdCollectionStatusLookup _collectionStatusLookupAsNonExist;

        /// <summary>collection_status_lookup as 'CollectionStatusLookupAsNonExist'.</summary>
        [Seasar.Dao.Attrs.Relno(3), Seasar.Dao.Attrs.Relkeys("GENRE_CODE:COLLECTION_STATUS_CODE")]
        public LdCollectionStatusLookup CollectionStatusLookupAsNonExist {
            get { return _collectionStatusLookupAsNonExist; }
            set { _collectionStatusLookupAsNonExist = value; }
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

        #endregion

        // ===============================================================================
        //                                                                   Determination
        //                                                                   =============
        public virtual bool HasPrimaryKeyValue {
            get {
                if (_bookId == null) { return false; }
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
            if (other == null || !(other is LdBook)) { return false; }
            LdBook otherEntity = (LdBook)other;
            if (!xSV(this.BookId, otherEntity.BookId)) { return false; }
            return true;
        }
        protected bool xSV(Object value1, Object value2) { // isSameValue()
            if (value1 == null && value2 == null) { return true; }
            if (value1 == null || value2 == null) { return false; }
            return value1.Equals(value2);
        }

        public override int GetHashCode() {
            int result = 17;
            result = xCH(result, _bookId);
            return result;
        }
        protected int xCH(int result, Object value) { // calculateHashcode()
            if (value == null) { return result; }
            return (31*result) + (value is byte[] ? ((byte[])value).Length : value.GetHashCode());
        }

        public override String ToString() {
            return "LdBook:" + BuildColumnString() + BuildRelationString();
        }

        public virtual String ToStringWithRelation() {
            StringBuilder sb = new StringBuilder();
            sb.Append(ToString());
            String l = "\n  ";
            if (_author != null)
            { sb.Append(l).Append(xbRDS(_author, "Author")); }
            if (_genre != null)
            { sb.Append(l).Append(xbRDS(_genre, "Genre")); }
            if (_publisher != null)
            { sb.Append(l).Append(xbRDS(_publisher, "Publisher")); }
            if (_collectionStatusLookupAsNonExist != null)
            { sb.Append(l).Append(xbRDS(_collectionStatusLookupAsNonExist, "CollectionStatusLookupAsNonExist")); }
            if (_collectionList != null) { foreach (LdEntity e in _collectionList)
            { if (e != null) { sb.Append(l).Append(xbRDS(e, "CollectionList")); } } }
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
            sb.Append(c).Append(this.BookId);
            sb.Append(c).Append(this.Isbn);
            sb.Append(c).Append(this.BookName);
            sb.Append(c).Append(this.AuthorId);
            sb.Append(c).Append(this.PublisherId);
            sb.Append(c).Append(this.GenreCode);
            sb.Append(c).Append(this.OpeningPart);
            sb.Append(c).Append(this.MaxLendingDateCount);
            sb.Append(c).Append(this.OutOfUserSelectYn);
            sb.Append(c).Append(this.OutOfUserSelectReason);
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
            if (_author != null) { sb.Append(c).Append("Author"); }
            if (_genre != null) { sb.Append(c).Append("Genre"); }
            if (_publisher != null) { sb.Append(c).Append("Publisher"); }
            if (_collectionStatusLookupAsNonExist != null) { sb.Append(c).Append("CollectionStatusLookupAsNonExist"); }
            if (_collectionList != null && _collectionList.Count > 0)
            { sb.Append(c).Append("CollectionList"); }
            if (sb.Length > 0) { sb.Remove(0, c.Length).Insert(0, "(").Append(")"); }
            return sb.ToString();
        }
        #endregion

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        #region Accessor
        /// <summary>BOOK_ID: {PK, ID, NotNull, INT(10)}</summary>
        [Seasar.Dao.Attrs.ID("identity")]
        [Seasar.Dao.Attrs.Column("BOOK_ID")]
        public int? BookId {
            get { return _bookId; }
            set {
                __modifiedProperties.AddPropertyName("BookId");
                _bookId = value;
            }
        }

        /// <summary>ISBN: {UQ, NotNull, VARCHAR(20)}</summary>
        [Seasar.Dao.Attrs.Column("ISBN")]
        public String Isbn {
            get { return _isbn; }
            set {
                __modifiedProperties.AddPropertyName("Isbn");
                _isbn = value;
            }
        }

        /// <summary>BOOK_NAME: {NotNull, VARCHAR(80)}</summary>
        [Seasar.Dao.Attrs.Column("BOOK_NAME")]
        public String BookName {
            get { return _bookName; }
            set {
                __modifiedProperties.AddPropertyName("BookName");
                _bookName = value;
            }
        }

        /// <summary>AUTHOR_ID: {IX, NotNull, INT(10), FK to author}</summary>
        [Seasar.Dao.Attrs.Column("AUTHOR_ID")]
        public int? AuthorId {
            get { return _authorId; }
            set {
                __modifiedProperties.AddPropertyName("AuthorId");
                _authorId = value;
            }
        }

        /// <summary>PUBLISHER_ID: {IX, NotNull, INT(10), FK to publisher}</summary>
        [Seasar.Dao.Attrs.Column("PUBLISHER_ID")]
        public int? PublisherId {
            get { return _publisherId; }
            set {
                __modifiedProperties.AddPropertyName("PublisherId");
                _publisherId = value;
            }
        }

        /// <summary>GENRE_CODE: {IX, VARCHAR(24), FK to genre}</summary>
        [Seasar.Dao.Attrs.Column("GENRE_CODE")]
        public String GenreCode {
            get { return _genreCode; }
            set {
                __modifiedProperties.AddPropertyName("GenreCode");
                _genreCode = value;
            }
        }

        /// <summary>OPENING_PART: {TEXT(65535)}</summary>
        [Seasar.Dao.Attrs.Column("OPENING_PART")]
        public String OpeningPart {
            get { return _openingPart; }
            set {
                __modifiedProperties.AddPropertyName("OpeningPart");
                _openingPart = value;
            }
        }

        /// <summary>MAX_LENDING_DATE_COUNT: {NotNull, INT(10)}</summary>
        [Seasar.Dao.Attrs.Column("MAX_LENDING_DATE_COUNT")]
        public int? MaxLendingDateCount {
            get { return _maxLendingDateCount; }
            set {
                __modifiedProperties.AddPropertyName("MaxLendingDateCount");
                _maxLendingDateCount = value;
            }
        }

        /// <summary>OUT_OF_USER_SELECT_YN: {NotNull, CHAR(1), classification=YesNo}</summary>
        [Seasar.Dao.Attrs.Column("OUT_OF_USER_SELECT_YN")]
        public String OutOfUserSelectYn {
            get { return _outOfUserSelectYn; }
            set {
                __modifiedProperties.AddPropertyName("OutOfUserSelectYn");
                _outOfUserSelectYn = value;
            }
        }

        /// <summary>OUT_OF_USER_SELECT_REASON: {VARCHAR(200)}</summary>
        [Seasar.Dao.Attrs.Column("OUT_OF_USER_SELECT_REASON")]
        public String OutOfUserSelectReason {
            get { return _outOfUserSelectReason; }
            set {
                __modifiedProperties.AddPropertyName("OutOfUserSelectReason");
                _outOfUserSelectReason = value;
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

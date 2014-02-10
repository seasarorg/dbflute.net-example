

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
    /// The entity of genre as TABLE. (partial class for auto-generation)
    /// <![CDATA[
    /// [primary-key]
    ///     GENRE_CODE
    /// 
    /// [column]
    ///     GENRE_CODE, GENRE_NAME, HIERARCHY_LEVEL, HIERARCHY_ORDER, PARENT_GENRE_CODE, R_USER, R_MODULE, R_TIMESTAMP, U_USER, U_MODULE, U_TIMESTAMP
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
    ///     genre
    /// 
    /// [referrer-table]
    ///     book, genre
    /// 
    /// [foreign-property]
    ///     genreSelf
    /// 
    /// [referrer-property]
    ///     bookList, genreSelfList
    /// ]]>
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    [Seasar.Dao.Attrs.Table("genre")]
    [Seasar.Dao.Attrs.TimestampProperty("UTimestamp")]
    [System.Serializable]
    public partial class LdGenre : LdEntityDefinedCommonColumn {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        #region Attribute
        /// <summary>GENRE_CODE: {PK, NotNull, VARCHAR(24)}</summary>
        protected String _genreCode;

        /// <summary>GENRE_NAME: {NotNull, VARCHAR(80)}</summary>
        protected String _genreName;

        /// <summary>HIERARCHY_LEVEL: {NotNull, DECIMAL(9)}</summary>
        protected decimal? _hierarchyLevel;

        /// <summary>HIERARCHY_ORDER: {NotNull, DECIMAL(10)}</summary>
        protected decimal? _hierarchyOrder;

        /// <summary>PARENT_GENRE_CODE: {IX, VARCHAR(24), FK to genre}</summary>
        protected String _parentGenreCode;

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
        public String TableDbName { get { return "genre"; } }
        public String TablePropertyName { get { return "Genre"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public LdDBMeta DBMeta { get { return LdDBMetaInstanceHandler.FindDBMeta(TableDbName); } }

        // ===============================================================================
        //                                                                Foreign Property
        //                                                                ================
        #region Foreign Property
        protected LdGenre _genreSelf;

        /// <summary>genre as 'GenreSelf'.</summary>
        [Seasar.Dao.Attrs.Relno(0), Seasar.Dao.Attrs.Relkeys("PARENT_GENRE_CODE:GENRE_CODE")]
        public LdGenre GenreSelf {
            get { return _genreSelf; }
            set { _genreSelf = value; }
        }

        #endregion

        // ===============================================================================
        //                                                               Referrer Property
        //                                                               =================
        #region Referrer Property
        protected IList<LdBook> _bookList;

        /// <summary>book as 'BookList'.</summary>
        public IList<LdBook> BookList {
            get { if (_bookList == null) { _bookList = new List<LdBook>(); } return _bookList; }
            set { _bookList = value; }
        }

        protected IList<LdGenre> _genreSelfList;

        /// <summary>genre as 'GenreSelfList'.</summary>
        public IList<LdGenre> GenreSelfList {
            get { if (_genreSelfList == null) { _genreSelfList = new List<LdGenre>(); } return _genreSelfList; }
            set { _genreSelfList = value; }
        }

        #endregion

        // ===============================================================================
        //                                                                   Determination
        //                                                                   =============
        public virtual bool HasPrimaryKeyValue {
            get {
                if (_genreCode == null) { return false; }
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
            if (other == null || !(other is LdGenre)) { return false; }
            LdGenre otherEntity = (LdGenre)other;
            if (!xSV(this.GenreCode, otherEntity.GenreCode)) { return false; }
            return true;
        }
        protected bool xSV(Object value1, Object value2) { // isSameValue()
            if (value1 == null && value2 == null) { return true; }
            if (value1 == null || value2 == null) { return false; }
            return value1.Equals(value2);
        }

        public override int GetHashCode() {
            int result = 17;
            result = xCH(result, _genreCode);
            return result;
        }
        protected int xCH(int result, Object value) { // calculateHashcode()
            if (value == null) { return result; }
            return (31*result) + (value is byte[] ? ((byte[])value).Length : value.GetHashCode());
        }

        public override String ToString() {
            return "LdGenre:" + BuildColumnString() + BuildRelationString();
        }

        public virtual String ToStringWithRelation() {
            StringBuilder sb = new StringBuilder();
            sb.Append(ToString());
            String l = "\n  ";
            if (_genreSelf != null)
            { sb.Append(l).Append(xbRDS(_genreSelf, "GenreSelf")); }
            if (_bookList != null) { foreach (LdEntity e in _bookList)
            { if (e != null) { sb.Append(l).Append(xbRDS(e, "BookList")); } } }
            if (_genreSelfList != null) { foreach (LdEntity e in _genreSelfList)
            { if (e != null) { sb.Append(l).Append(xbRDS(e, "GenreSelfList")); } } }
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
            sb.Append(c).Append(this.GenreCode);
            sb.Append(c).Append(this.GenreName);
            sb.Append(c).Append(this.HierarchyLevel);
            sb.Append(c).Append(this.HierarchyOrder);
            sb.Append(c).Append(this.ParentGenreCode);
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
            if (_genreSelf != null) { sb.Append(c).Append("GenreSelf"); }
            if (_bookList != null && _bookList.Count > 0)
            { sb.Append(c).Append("BookList"); }
            if (_genreSelfList != null && _genreSelfList.Count > 0)
            { sb.Append(c).Append("GenreSelfList"); }
            if (sb.Length > 0) { sb.Remove(0, c.Length).Insert(0, "(").Append(")"); }
            return sb.ToString();
        }
        #endregion

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        #region Accessor
        /// <summary>GENRE_CODE: {PK, NotNull, VARCHAR(24)}</summary>
        [Seasar.Dao.Attrs.Column("GENRE_CODE")]
        public String GenreCode {
            get { return _genreCode; }
            set {
                __modifiedProperties.AddPropertyName("GenreCode");
                _genreCode = value;
            }
        }

        /// <summary>GENRE_NAME: {NotNull, VARCHAR(80)}</summary>
        [Seasar.Dao.Attrs.Column("GENRE_NAME")]
        public String GenreName {
            get { return _genreName; }
            set {
                __modifiedProperties.AddPropertyName("GenreName");
                _genreName = value;
            }
        }

        /// <summary>HIERARCHY_LEVEL: {NotNull, DECIMAL(9)}</summary>
        [Seasar.Dao.Attrs.Column("HIERARCHY_LEVEL")]
        public decimal? HierarchyLevel {
            get { return _hierarchyLevel; }
            set {
                __modifiedProperties.AddPropertyName("HierarchyLevel");
                _hierarchyLevel = value;
            }
        }

        /// <summary>HIERARCHY_ORDER: {NotNull, DECIMAL(10)}</summary>
        [Seasar.Dao.Attrs.Column("HIERARCHY_ORDER")]
        public decimal? HierarchyOrder {
            get { return _hierarchyOrder; }
            set {
                __modifiedProperties.AddPropertyName("HierarchyOrder");
                _hierarchyOrder = value;
            }
        }

        /// <summary>PARENT_GENRE_CODE: {IX, VARCHAR(24), FK to genre}</summary>
        [Seasar.Dao.Attrs.Column("PARENT_GENRE_CODE")]
        public String ParentGenreCode {
            get { return _parentGenreCode; }
            set {
                __modifiedProperties.AddPropertyName("ParentGenreCode");
                _parentGenreCode = value;
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

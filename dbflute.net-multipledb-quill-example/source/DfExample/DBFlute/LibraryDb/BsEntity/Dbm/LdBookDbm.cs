
using System;
using System.Reflection;

using DfExample.DBFlute.LibraryDb.AllCommon;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean;
using DfExample.DBFlute.LibraryDb.AllCommon.Dbm;
using DfExample.DBFlute.LibraryDb.AllCommon.Dbm.Info;
using DfExample.DBFlute.LibraryDb.AllCommon.JavaLike;
using DfExample.DBFlute.LibraryDb.ExEntity;

using DfExample.DBFlute.LibraryDb.ExDao;
using DfExample.DBFlute.LibraryDb.CBean;

namespace DfExample.DBFlute.LibraryDb.BsEntity.Dbm {

    public class LdBookDbm : LdAbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(LdBook);

        private static readonly LdBookDbm _instance = new LdBookDbm();
        private LdBookDbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static LdBookDbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "book"; } }
        public override String TablePropertyName { get { return "Book"; } }
        public override String TableSqlName { get { return "book"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected LdColumnInfo _columnBookId;
        protected LdColumnInfo _columnIsbn;
        protected LdColumnInfo _columnBookName;
        protected LdColumnInfo _columnAuthorId;
        protected LdColumnInfo _columnPublisherId;
        protected LdColumnInfo _columnGenreCode;
        protected LdColumnInfo _columnOpeningPart;
        protected LdColumnInfo _columnMaxLendingDateCount;
        protected LdColumnInfo _columnOutOfUserSelectYn;
        protected LdColumnInfo _columnOutOfUserSelectReason;
        protected LdColumnInfo _columnRUser;
        protected LdColumnInfo _columnRModule;
        protected LdColumnInfo _columnRTimestamp;
        protected LdColumnInfo _columnUUser;
        protected LdColumnInfo _columnUModule;
        protected LdColumnInfo _columnUTimestamp;

        public LdColumnInfo ColumnBookId { get { return _columnBookId; } }
        public LdColumnInfo ColumnIsbn { get { return _columnIsbn; } }
        public LdColumnInfo ColumnBookName { get { return _columnBookName; } }
        public LdColumnInfo ColumnAuthorId { get { return _columnAuthorId; } }
        public LdColumnInfo ColumnPublisherId { get { return _columnPublisherId; } }
        public LdColumnInfo ColumnGenreCode { get { return _columnGenreCode; } }
        public LdColumnInfo ColumnOpeningPart { get { return _columnOpeningPart; } }
        public LdColumnInfo ColumnMaxLendingDateCount { get { return _columnMaxLendingDateCount; } }
        public LdColumnInfo ColumnOutOfUserSelectYn { get { return _columnOutOfUserSelectYn; } }
        public LdColumnInfo ColumnOutOfUserSelectReason { get { return _columnOutOfUserSelectReason; } }
        public LdColumnInfo ColumnRUser { get { return _columnRUser; } }
        public LdColumnInfo ColumnRModule { get { return _columnRModule; } }
        public LdColumnInfo ColumnRTimestamp { get { return _columnRTimestamp; } }
        public LdColumnInfo ColumnUUser { get { return _columnUUser; } }
        public LdColumnInfo ColumnUModule { get { return _columnUModule; } }
        public LdColumnInfo ColumnUTimestamp { get { return _columnUTimestamp; } }

        protected void InitializeColumnInfo() {
            _columnBookId = cci("BOOK_ID", "BOOK_ID", null, null, true, "BookId", typeof(int?), true, "INT", 10, 0, false, OptimisticLockType.NONE, null, null, "collectionList");
            _columnIsbn = cci("ISBN", "ISBN", null, null, true, "Isbn", typeof(String), false, "VARCHAR", 20, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnBookName = cci("BOOK_NAME", "BOOK_NAME", null, null, true, "BookName", typeof(String), false, "VARCHAR", 80, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnAuthorId = cci("AUTHOR_ID", "AUTHOR_ID", null, null, true, "AuthorId", typeof(int?), false, "INT", 10, 0, false, OptimisticLockType.NONE, null, "author", null);
            _columnPublisherId = cci("PUBLISHER_ID", "PUBLISHER_ID", null, null, true, "PublisherId", typeof(int?), false, "INT", 10, 0, false, OptimisticLockType.NONE, null, "publisher", null);
            _columnGenreCode = cci("GENRE_CODE", "GENRE_CODE", null, null, false, "GenreCode", typeof(String), false, "VARCHAR", 24, 0, false, OptimisticLockType.NONE, null, "genre,collectionStatusLookupAsNonExist", null);
            _columnOpeningPart = cci("OPENING_PART", "OPENING_PART", null, null, false, "OpeningPart", typeof(String), false, "TEXT", 65535, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnMaxLendingDateCount = cci("MAX_LENDING_DATE_COUNT", "MAX_LENDING_DATE_COUNT", null, null, true, "MaxLendingDateCount", typeof(int?), false, "INT", 10, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnOutOfUserSelectYn = cci("OUT_OF_USER_SELECT_YN", "OUT_OF_USER_SELECT_YN", null, null, true, "OutOfUserSelectYn", typeof(String), false, "CHAR", 1, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnOutOfUserSelectReason = cci("OUT_OF_USER_SELECT_REASON", "OUT_OF_USER_SELECT_REASON", null, null, false, "OutOfUserSelectReason", typeof(String), false, "VARCHAR", 200, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnRUser = cci("R_USER", "R_USER", null, null, true, "RUser", typeof(String), false, "VARCHAR", 100, 0, true, OptimisticLockType.NONE, null, null, null);
            _columnRModule = cci("R_MODULE", "R_MODULE", null, null, true, "RModule", typeof(String), false, "VARCHAR", 100, 0, true, OptimisticLockType.NONE, null, null, null);
            _columnRTimestamp = cci("R_TIMESTAMP", "R_TIMESTAMP", null, null, true, "RTimestamp", typeof(DateTime?), false, "DATETIME", 19, 0, true, OptimisticLockType.NONE, null, null, null);
            _columnUUser = cci("U_USER", "U_USER", null, null, true, "UUser", typeof(String), false, "VARCHAR", 100, 0, true, OptimisticLockType.NONE, null, null, null);
            _columnUModule = cci("U_MODULE", "U_MODULE", null, null, true, "UModule", typeof(String), false, "VARCHAR", 100, 0, true, OptimisticLockType.NONE, null, null, null);
            _columnUTimestamp = cci("U_TIMESTAMP", "U_TIMESTAMP", null, null, true, "UTimestamp", typeof(DateTime?), false, "DATETIME", 19, 0, true, OptimisticLockType.UPDATE_DATE, null, null, null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<LdColumnInfo>();
            _columnInfoList.add(ColumnBookId);
            _columnInfoList.add(ColumnIsbn);
            _columnInfoList.add(ColumnBookName);
            _columnInfoList.add(ColumnAuthorId);
            _columnInfoList.add(ColumnPublisherId);
            _columnInfoList.add(ColumnGenreCode);
            _columnInfoList.add(ColumnOpeningPart);
            _columnInfoList.add(ColumnMaxLendingDateCount);
            _columnInfoList.add(ColumnOutOfUserSelectYn);
            _columnInfoList.add(ColumnOutOfUserSelectReason);
            _columnInfoList.add(ColumnRUser);
            _columnInfoList.add(ColumnRModule);
            _columnInfoList.add(ColumnRTimestamp);
            _columnInfoList.add(ColumnUUser);
            _columnInfoList.add(ColumnUModule);
            _columnInfoList.add(ColumnUTimestamp);
        }

        // ===============================================================================
        //                                                                     Unique Info
        //                                                                     ===========
        public override LdUniqueInfo PrimaryUniqueInfo { get {
            return cpui(ColumnBookId);
        }}

        // -------------------------------------------------
        //                                   Primary Element
        //                                   ---------------
        public override bool HasPrimaryKey { get { return true; } }
        public override bool HasCompoundPrimaryKey { get { return false; } }

        // ===============================================================================
        //                                                                   Relation Info
        //                                                                   =============
        // -------------------------------------------------
        //                                   Foreign Element
        //                                   ---------------
        public LdForeignInfo ForeignAuthor { get {
            Map<LdColumnInfo, LdColumnInfo> map = new LinkedHashMap<LdColumnInfo, LdColumnInfo>();
            map.put(ColumnAuthorId, LdAuthorDbm.GetInstance().ColumnAuthorId);
            return cfi("Author", this, LdAuthorDbm.GetInstance(), map, 0, false, false);
        }}
        public LdForeignInfo ForeignGenre { get {
            Map<LdColumnInfo, LdColumnInfo> map = new LinkedHashMap<LdColumnInfo, LdColumnInfo>();
            map.put(ColumnGenreCode, LdGenreDbm.GetInstance().ColumnGenreCode);
            return cfi("Genre", this, LdGenreDbm.GetInstance(), map, 1, false, false);
        }}
        public LdForeignInfo ForeignPublisher { get {
            Map<LdColumnInfo, LdColumnInfo> map = new LinkedHashMap<LdColumnInfo, LdColumnInfo>();
            map.put(ColumnPublisherId, LdPublisherDbm.GetInstance().ColumnPublisherId);
            return cfi("Publisher", this, LdPublisherDbm.GetInstance(), map, 2, false, false);
        }}
        public LdForeignInfo ForeignCollectionStatusLookupAsNonExist { get {
            Map<LdColumnInfo, LdColumnInfo> map = new LinkedHashMap<LdColumnInfo, LdColumnInfo>();
            map.put(ColumnGenreCode, LdCollectionStatusLookupDbm.GetInstance().ColumnCollectionStatusCode);
            return cfi("CollectionStatusLookupAsNonExist", this, LdCollectionStatusLookupDbm.GetInstance(), map, 3, false, false);
        }}


        // -------------------------------------------------
        //                                  Referrer Element
        //                                  ----------------
        public LdReferrerInfo ReferrerCollectionList { get {
            Map<LdColumnInfo, LdColumnInfo> map = new LinkedHashMap<LdColumnInfo, LdColumnInfo>();
            map.put(ColumnBookId, LdCollectionDbm.GetInstance().ColumnBookId);
            return cri("CollectionList", this, LdCollectionDbm.GetInstance(), map, false);
        }}

        // ===============================================================================
        //                                                                    Various Info
        //                                                                    ============
        public override bool HasIdentity { get { return true; } }
        public override bool HasUpdateDate { get { return true; } }
        public override LdColumnInfo UpdateDateColumnInfo { get { return _columnUTimestamp; } }
        public override bool HasCommonColumn { get { return true; } }

        // ===============================================================================
        //                                                                 Name Definition
        //                                                                 ===============
        #region Name

        // -------------------------------------------------
        //                                             Table
        //                                             -----
        public static readonly String TABLE_DB_NAME = "book";
        public static readonly String TABLE_PROPERTY_NAME = "Book";

        // -------------------------------------------------
        //                                    Column DB-Name
        //                                    --------------
        public static readonly String DB_NAME_BOOK_ID = "BOOK_ID";
        public static readonly String DB_NAME_ISBN = "ISBN";
        public static readonly String DB_NAME_BOOK_NAME = "BOOK_NAME";
        public static readonly String DB_NAME_AUTHOR_ID = "AUTHOR_ID";
        public static readonly String DB_NAME_PUBLISHER_ID = "PUBLISHER_ID";
        public static readonly String DB_NAME_GENRE_CODE = "GENRE_CODE";
        public static readonly String DB_NAME_OPENING_PART = "OPENING_PART";
        public static readonly String DB_NAME_MAX_LENDING_DATE_COUNT = "MAX_LENDING_DATE_COUNT";
        public static readonly String DB_NAME_OUT_OF_USER_SELECT_YN = "OUT_OF_USER_SELECT_YN";
        public static readonly String DB_NAME_OUT_OF_USER_SELECT_REASON = "OUT_OF_USER_SELECT_REASON";
        public static readonly String DB_NAME_R_USER = "R_USER";
        public static readonly String DB_NAME_R_MODULE = "R_MODULE";
        public static readonly String DB_NAME_R_TIMESTAMP = "R_TIMESTAMP";
        public static readonly String DB_NAME_U_USER = "U_USER";
        public static readonly String DB_NAME_U_MODULE = "U_MODULE";
        public static readonly String DB_NAME_U_TIMESTAMP = "U_TIMESTAMP";

        // -------------------------------------------------
        //                              Column Property-Name
        //                              --------------------
        public static readonly String PROPERTY_NAME_BOOK_ID = "BookId";
        public static readonly String PROPERTY_NAME_ISBN = "Isbn";
        public static readonly String PROPERTY_NAME_BOOK_NAME = "BookName";
        public static readonly String PROPERTY_NAME_AUTHOR_ID = "AuthorId";
        public static readonly String PROPERTY_NAME_PUBLISHER_ID = "PublisherId";
        public static readonly String PROPERTY_NAME_GENRE_CODE = "GenreCode";
        public static readonly String PROPERTY_NAME_OPENING_PART = "OpeningPart";
        public static readonly String PROPERTY_NAME_MAX_LENDING_DATE_COUNT = "MaxLendingDateCount";
        public static readonly String PROPERTY_NAME_OUT_OF_USER_SELECT_YN = "OutOfUserSelectYn";
        public static readonly String PROPERTY_NAME_OUT_OF_USER_SELECT_REASON = "OutOfUserSelectReason";
        public static readonly String PROPERTY_NAME_R_USER = "RUser";
        public static readonly String PROPERTY_NAME_R_MODULE = "RModule";
        public static readonly String PROPERTY_NAME_R_TIMESTAMP = "RTimestamp";
        public static readonly String PROPERTY_NAME_U_USER = "UUser";
        public static readonly String PROPERTY_NAME_U_MODULE = "UModule";
        public static readonly String PROPERTY_NAME_U_TIMESTAMP = "UTimestamp";

        // -------------------------------------------------
        //                                      Foreign Name
        //                                      ------------
        public static readonly String FOREIGN_PROPERTY_NAME_Author = "Author";
        public static readonly String FOREIGN_PROPERTY_NAME_Genre = "Genre";
        public static readonly String FOREIGN_PROPERTY_NAME_Publisher = "Publisher";
        public static readonly String FOREIGN_PROPERTY_NAME_CollectionStatusLookupAsNonExist = "CollectionStatusLookupAsNonExist";
        // -------------------------------------------------
        //                                     Referrer Name
        //                                     -------------
        public static readonly String REFERRER_PROPERTY_NAME_CollectionList = "CollectionList";

        // -------------------------------------------------
        //                               DB-Property Mapping
        //                               -------------------
        protected static readonly Map<String, String> _dbNamePropertyNameKeyToLowerMap;
        protected static readonly Map<String, String> _propertyNameDbNameKeyToLowerMap;

        static LdBookDbm() {
            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_DB_NAME.ToLower(), TABLE_PROPERTY_NAME);
                map.put(DB_NAME_BOOK_ID.ToLower(), PROPERTY_NAME_BOOK_ID);
                map.put(DB_NAME_ISBN.ToLower(), PROPERTY_NAME_ISBN);
                map.put(DB_NAME_BOOK_NAME.ToLower(), PROPERTY_NAME_BOOK_NAME);
                map.put(DB_NAME_AUTHOR_ID.ToLower(), PROPERTY_NAME_AUTHOR_ID);
                map.put(DB_NAME_PUBLISHER_ID.ToLower(), PROPERTY_NAME_PUBLISHER_ID);
                map.put(DB_NAME_GENRE_CODE.ToLower(), PROPERTY_NAME_GENRE_CODE);
                map.put(DB_NAME_OPENING_PART.ToLower(), PROPERTY_NAME_OPENING_PART);
                map.put(DB_NAME_MAX_LENDING_DATE_COUNT.ToLower(), PROPERTY_NAME_MAX_LENDING_DATE_COUNT);
                map.put(DB_NAME_OUT_OF_USER_SELECT_YN.ToLower(), PROPERTY_NAME_OUT_OF_USER_SELECT_YN);
                map.put(DB_NAME_OUT_OF_USER_SELECT_REASON.ToLower(), PROPERTY_NAME_OUT_OF_USER_SELECT_REASON);
                map.put(DB_NAME_R_USER.ToLower(), PROPERTY_NAME_R_USER);
                map.put(DB_NAME_R_MODULE.ToLower(), PROPERTY_NAME_R_MODULE);
                map.put(DB_NAME_R_TIMESTAMP.ToLower(), PROPERTY_NAME_R_TIMESTAMP);
                map.put(DB_NAME_U_USER.ToLower(), PROPERTY_NAME_U_USER);
                map.put(DB_NAME_U_MODULE.ToLower(), PROPERTY_NAME_U_MODULE);
                map.put(DB_NAME_U_TIMESTAMP.ToLower(), PROPERTY_NAME_U_TIMESTAMP);
                _dbNamePropertyNameKeyToLowerMap = map;
            }

            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_PROPERTY_NAME.ToLower(), TABLE_DB_NAME);
                map.put(PROPERTY_NAME_BOOK_ID.ToLower(), DB_NAME_BOOK_ID);
                map.put(PROPERTY_NAME_ISBN.ToLower(), DB_NAME_ISBN);
                map.put(PROPERTY_NAME_BOOK_NAME.ToLower(), DB_NAME_BOOK_NAME);
                map.put(PROPERTY_NAME_AUTHOR_ID.ToLower(), DB_NAME_AUTHOR_ID);
                map.put(PROPERTY_NAME_PUBLISHER_ID.ToLower(), DB_NAME_PUBLISHER_ID);
                map.put(PROPERTY_NAME_GENRE_CODE.ToLower(), DB_NAME_GENRE_CODE);
                map.put(PROPERTY_NAME_OPENING_PART.ToLower(), DB_NAME_OPENING_PART);
                map.put(PROPERTY_NAME_MAX_LENDING_DATE_COUNT.ToLower(), DB_NAME_MAX_LENDING_DATE_COUNT);
                map.put(PROPERTY_NAME_OUT_OF_USER_SELECT_YN.ToLower(), DB_NAME_OUT_OF_USER_SELECT_YN);
                map.put(PROPERTY_NAME_OUT_OF_USER_SELECT_REASON.ToLower(), DB_NAME_OUT_OF_USER_SELECT_REASON);
                map.put(PROPERTY_NAME_R_USER.ToLower(), DB_NAME_R_USER);
                map.put(PROPERTY_NAME_R_MODULE.ToLower(), DB_NAME_R_MODULE);
                map.put(PROPERTY_NAME_R_TIMESTAMP.ToLower(), DB_NAME_R_TIMESTAMP);
                map.put(PROPERTY_NAME_U_USER.ToLower(), DB_NAME_U_USER);
                map.put(PROPERTY_NAME_U_MODULE.ToLower(), DB_NAME_U_MODULE);
                map.put(PROPERTY_NAME_U_TIMESTAMP.ToLower(), DB_NAME_U_TIMESTAMP);
                _propertyNameDbNameKeyToLowerMap = map;
            }
        }

        #endregion

        // ===============================================================================
        //                                                                        Name Map
        //                                                                        ========
        #region Name Map
        public override Map<String, String> DbNamePropertyNameKeyToLowerMap { get { return _dbNamePropertyNameKeyToLowerMap; } }
        public override Map<String, String> PropertyNameDbNameKeyToLowerMap { get { return _propertyNameDbNameKeyToLowerMap; } }
        #endregion

        // ===============================================================================
        //                                                                       Type Name
        //                                                                       =========
        public override String EntityTypeName { get { return "DfExample.DBFlute.LibraryDb.ExEntity.LdBook"; } }
        public override String DaoTypeName { get { return "DfExample.DBFlute.LibraryDb.ExDao.LdBookDao"; } }
        public override String ConditionBeanTypeName { get { return "DfExample.DBFlute.LibraryDb.CBean.LdBookCB"; } }
        public override String BehaviorTypeName { get { return "DfExample.DBFlute.LibraryDb.ExBhv.LdBookBhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override LdEntity NewEntity() { return NewMyEntity(); }
        public LdBook NewMyEntity() { return new LdBook(); }
        public override LdConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public LdBookCB NewMyConditionBean() { return new LdBookCB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<LdBook>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<LdBook>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("BOOK_ID", "BookId", new EntityPropertyBookIdSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("ISBN", "Isbn", new EntityPropertyIsbnSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("BOOK_NAME", "BookName", new EntityPropertyBookNameSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("AUTHOR_ID", "AuthorId", new EntityPropertyAuthorIdSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("PUBLISHER_ID", "PublisherId", new EntityPropertyPublisherIdSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("GENRE_CODE", "GenreCode", new EntityPropertyGenreCodeSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("OPENING_PART", "OpeningPart", new EntityPropertyOpeningPartSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("MAX_LENDING_DATE_COUNT", "MaxLendingDateCount", new EntityPropertyMaxLendingDateCountSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("OUT_OF_USER_SELECT_YN", "OutOfUserSelectYn", new EntityPropertyOutOfUserSelectYnSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("OUT_OF_USER_SELECT_REASON", "OutOfUserSelectReason", new EntityPropertyOutOfUserSelectReasonSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("R_USER", "RUser", new EntityPropertyRUserSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("R_MODULE", "RModule", new EntityPropertyRModuleSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("R_TIMESTAMP", "RTimestamp", new EntityPropertyRTimestampSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("U_USER", "UUser", new EntityPropertyUUserSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("U_MODULE", "UModule", new EntityPropertyUModuleSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("U_TIMESTAMP", "UTimestamp", new EntityPropertyUTimestampSetupper(), _entityPropertySetupperMap);
        }

        public override bool HasEntityPropertySetupper(String propertyName) {
            return _entityPropertySetupperMap.containsKey(propertyName);
        }

        public override void SetupEntityProperty(String propertyName, Object entity, Object value) {
            EntityPropertySetupper<LdBook> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((LdBook)entity, value);
        }

        public class EntityPropertyBookIdSetupper : EntityPropertySetupper<LdBook> {
            public void Setup(LdBook entity, Object value) { entity.BookId = (value != null) ? (int?)value : null; }
        }
        public class EntityPropertyIsbnSetupper : EntityPropertySetupper<LdBook> {
            public void Setup(LdBook entity, Object value) { entity.Isbn = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyBookNameSetupper : EntityPropertySetupper<LdBook> {
            public void Setup(LdBook entity, Object value) { entity.BookName = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyAuthorIdSetupper : EntityPropertySetupper<LdBook> {
            public void Setup(LdBook entity, Object value) { entity.AuthorId = (value != null) ? (int?)value : null; }
        }
        public class EntityPropertyPublisherIdSetupper : EntityPropertySetupper<LdBook> {
            public void Setup(LdBook entity, Object value) { entity.PublisherId = (value != null) ? (int?)value : null; }
        }
        public class EntityPropertyGenreCodeSetupper : EntityPropertySetupper<LdBook> {
            public void Setup(LdBook entity, Object value) { entity.GenreCode = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyOpeningPartSetupper : EntityPropertySetupper<LdBook> {
            public void Setup(LdBook entity, Object value) { entity.OpeningPart = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyMaxLendingDateCountSetupper : EntityPropertySetupper<LdBook> {
            public void Setup(LdBook entity, Object value) { entity.MaxLendingDateCount = (value != null) ? (int?)value : null; }
        }
        public class EntityPropertyOutOfUserSelectYnSetupper : EntityPropertySetupper<LdBook> {
            public void Setup(LdBook entity, Object value) { entity.OutOfUserSelectYn = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyOutOfUserSelectReasonSetupper : EntityPropertySetupper<LdBook> {
            public void Setup(LdBook entity, Object value) { entity.OutOfUserSelectReason = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyRUserSetupper : EntityPropertySetupper<LdBook> {
            public void Setup(LdBook entity, Object value) { entity.RUser = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyRModuleSetupper : EntityPropertySetupper<LdBook> {
            public void Setup(LdBook entity, Object value) { entity.RModule = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyRTimestampSetupper : EntityPropertySetupper<LdBook> {
            public void Setup(LdBook entity, Object value) { entity.RTimestamp = (value != null) ? (DateTime?)value : null; }
        }
        public class EntityPropertyUUserSetupper : EntityPropertySetupper<LdBook> {
            public void Setup(LdBook entity, Object value) { entity.UUser = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyUModuleSetupper : EntityPropertySetupper<LdBook> {
            public void Setup(LdBook entity, Object value) { entity.UModule = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyUTimestampSetupper : EntityPropertySetupper<LdBook> {
            public void Setup(LdBook entity, Object value) { entity.UTimestamp = (value != null) ? (DateTime?)value : null; }
        }
    }
}

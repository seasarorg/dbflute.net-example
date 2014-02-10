
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

    public class LdCollectionDbm : LdAbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(LdCollection);

        private static readonly LdCollectionDbm _instance = new LdCollectionDbm();
        private LdCollectionDbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static LdCollectionDbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "collection"; } }
        public override String TablePropertyName { get { return "Collection"; } }
        public override String TableSqlName { get { return "collection"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected LdColumnInfo _columnCollectionId;
        protected LdColumnInfo _columnLibraryId;
        protected LdColumnInfo _columnBookId;
        protected LdColumnInfo _columnArrivalDate;
        protected LdColumnInfo _columnRUser;
        protected LdColumnInfo _columnRModule;
        protected LdColumnInfo _columnRTimestamp;
        protected LdColumnInfo _columnUUser;
        protected LdColumnInfo _columnUModule;
        protected LdColumnInfo _columnUTimestamp;

        public LdColumnInfo ColumnCollectionId { get { return _columnCollectionId; } }
        public LdColumnInfo ColumnLibraryId { get { return _columnLibraryId; } }
        public LdColumnInfo ColumnBookId { get { return _columnBookId; } }
        public LdColumnInfo ColumnArrivalDate { get { return _columnArrivalDate; } }
        public LdColumnInfo ColumnRUser { get { return _columnRUser; } }
        public LdColumnInfo ColumnRModule { get { return _columnRModule; } }
        public LdColumnInfo ColumnRTimestamp { get { return _columnRTimestamp; } }
        public LdColumnInfo ColumnUUser { get { return _columnUUser; } }
        public LdColumnInfo ColumnUModule { get { return _columnUModule; } }
        public LdColumnInfo ColumnUTimestamp { get { return _columnUTimestamp; } }

        protected void InitializeColumnInfo() {
            _columnCollectionId = cci("COLLECTION_ID", "COLLECTION_ID", null, null, true, "CollectionId", typeof(int?), true, "INT", 10, 0, false, OptimisticLockType.NONE, null, null, "lendingCollectionList");
            _columnLibraryId = cci("LIBRARY_ID", "LIBRARY_ID", null, null, true, "LibraryId", typeof(int?), false, "INT", 10, 0, false, OptimisticLockType.NONE, null, "library", null);
            _columnBookId = cci("BOOK_ID", "BOOK_ID", null, null, true, "BookId", typeof(int?), false, "INT", 10, 0, false, OptimisticLockType.NONE, null, "book", null);
            _columnArrivalDate = cci("ARRIVAL_DATE", "ARRIVAL_DATE", null, null, true, "ArrivalDate", typeof(DateTime?), false, "DATETIME", 19, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnRUser = cci("R_USER", "R_USER", null, null, true, "RUser", typeof(String), false, "VARCHAR", 100, 0, true, OptimisticLockType.NONE, null, null, null);
            _columnRModule = cci("R_MODULE", "R_MODULE", null, null, true, "RModule", typeof(String), false, "VARCHAR", 100, 0, true, OptimisticLockType.NONE, null, null, null);
            _columnRTimestamp = cci("R_TIMESTAMP", "R_TIMESTAMP", null, null, true, "RTimestamp", typeof(DateTime?), false, "DATETIME", 19, 0, true, OptimisticLockType.NONE, null, null, null);
            _columnUUser = cci("U_USER", "U_USER", null, null, true, "UUser", typeof(String), false, "VARCHAR", 100, 0, true, OptimisticLockType.NONE, null, null, null);
            _columnUModule = cci("U_MODULE", "U_MODULE", null, null, true, "UModule", typeof(String), false, "VARCHAR", 100, 0, true, OptimisticLockType.NONE, null, null, null);
            _columnUTimestamp = cci("U_TIMESTAMP", "U_TIMESTAMP", null, null, true, "UTimestamp", typeof(DateTime?), false, "DATETIME", 19, 0, true, OptimisticLockType.UPDATE_DATE, null, null, null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<LdColumnInfo>();
            _columnInfoList.add(ColumnCollectionId);
            _columnInfoList.add(ColumnLibraryId);
            _columnInfoList.add(ColumnBookId);
            _columnInfoList.add(ColumnArrivalDate);
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
            return cpui(ColumnCollectionId);
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
        public LdForeignInfo ForeignBook { get {
            Map<LdColumnInfo, LdColumnInfo> map = new LinkedHashMap<LdColumnInfo, LdColumnInfo>();
            map.put(ColumnBookId, LdBookDbm.GetInstance().ColumnBookId);
            return cfi("Book", this, LdBookDbm.GetInstance(), map, 0, false, false);
        }}
        public LdForeignInfo ForeignLibrary { get {
            Map<LdColumnInfo, LdColumnInfo> map = new LinkedHashMap<LdColumnInfo, LdColumnInfo>();
            map.put(ColumnLibraryId, LdLibraryDbm.GetInstance().ColumnLibraryId);
            return cfi("Library", this, LdLibraryDbm.GetInstance(), map, 1, false, false);
        }}

        public LdForeignInfo ForeignCollectionStatusAsOne { get {
            Map<LdColumnInfo, LdColumnInfo> map = new LinkedHashMap<LdColumnInfo, LdColumnInfo>();
            map.put(ColumnCollectionId, LdCollectionStatusDbm.GetInstance().ColumnCollectionId);
            return cfi("CollectionStatusAsOne", this, LdCollectionStatusDbm.GetInstance(), map, 2, true, false);
        }}

        // -------------------------------------------------
        //                                  Referrer Element
        //                                  ----------------
        public LdReferrerInfo ReferrerLendingCollectionList { get {
            Map<LdColumnInfo, LdColumnInfo> map = new LinkedHashMap<LdColumnInfo, LdColumnInfo>();
            map.put(ColumnCollectionId, LdLendingCollectionDbm.GetInstance().ColumnCollectionId);
            return cri("LendingCollectionList", this, LdLendingCollectionDbm.GetInstance(), map, false);
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
        public static readonly String TABLE_DB_NAME = "collection";
        public static readonly String TABLE_PROPERTY_NAME = "Collection";

        // -------------------------------------------------
        //                                    Column DB-Name
        //                                    --------------
        public static readonly String DB_NAME_COLLECTION_ID = "COLLECTION_ID";
        public static readonly String DB_NAME_LIBRARY_ID = "LIBRARY_ID";
        public static readonly String DB_NAME_BOOK_ID = "BOOK_ID";
        public static readonly String DB_NAME_ARRIVAL_DATE = "ARRIVAL_DATE";
        public static readonly String DB_NAME_R_USER = "R_USER";
        public static readonly String DB_NAME_R_MODULE = "R_MODULE";
        public static readonly String DB_NAME_R_TIMESTAMP = "R_TIMESTAMP";
        public static readonly String DB_NAME_U_USER = "U_USER";
        public static readonly String DB_NAME_U_MODULE = "U_MODULE";
        public static readonly String DB_NAME_U_TIMESTAMP = "U_TIMESTAMP";

        // -------------------------------------------------
        //                              Column Property-Name
        //                              --------------------
        public static readonly String PROPERTY_NAME_COLLECTION_ID = "CollectionId";
        public static readonly String PROPERTY_NAME_LIBRARY_ID = "LibraryId";
        public static readonly String PROPERTY_NAME_BOOK_ID = "BookId";
        public static readonly String PROPERTY_NAME_ARRIVAL_DATE = "ArrivalDate";
        public static readonly String PROPERTY_NAME_R_USER = "RUser";
        public static readonly String PROPERTY_NAME_R_MODULE = "RModule";
        public static readonly String PROPERTY_NAME_R_TIMESTAMP = "RTimestamp";
        public static readonly String PROPERTY_NAME_U_USER = "UUser";
        public static readonly String PROPERTY_NAME_U_MODULE = "UModule";
        public static readonly String PROPERTY_NAME_U_TIMESTAMP = "UTimestamp";

        // -------------------------------------------------
        //                                      Foreign Name
        //                                      ------------
        public static readonly String FOREIGN_PROPERTY_NAME_Book = "Book";
        public static readonly String FOREIGN_PROPERTY_NAME_Library = "Library";
        public static readonly String FOREIGN_PROPERTY_NAME_CollectionStatusAsOne = "$foreignKeys.foreignPropertyNameInitCap";
        // -------------------------------------------------
        //                                     Referrer Name
        //                                     -------------
        public static readonly String REFERRER_PROPERTY_NAME_LendingCollectionList = "LendingCollectionList";

        // -------------------------------------------------
        //                               DB-Property Mapping
        //                               -------------------
        protected static readonly Map<String, String> _dbNamePropertyNameKeyToLowerMap;
        protected static readonly Map<String, String> _propertyNameDbNameKeyToLowerMap;

        static LdCollectionDbm() {
            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_DB_NAME.ToLower(), TABLE_PROPERTY_NAME);
                map.put(DB_NAME_COLLECTION_ID.ToLower(), PROPERTY_NAME_COLLECTION_ID);
                map.put(DB_NAME_LIBRARY_ID.ToLower(), PROPERTY_NAME_LIBRARY_ID);
                map.put(DB_NAME_BOOK_ID.ToLower(), PROPERTY_NAME_BOOK_ID);
                map.put(DB_NAME_ARRIVAL_DATE.ToLower(), PROPERTY_NAME_ARRIVAL_DATE);
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
                map.put(PROPERTY_NAME_COLLECTION_ID.ToLower(), DB_NAME_COLLECTION_ID);
                map.put(PROPERTY_NAME_LIBRARY_ID.ToLower(), DB_NAME_LIBRARY_ID);
                map.put(PROPERTY_NAME_BOOK_ID.ToLower(), DB_NAME_BOOK_ID);
                map.put(PROPERTY_NAME_ARRIVAL_DATE.ToLower(), DB_NAME_ARRIVAL_DATE);
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
        public override String EntityTypeName { get { return "DfExample.DBFlute.LibraryDb.ExEntity.LdCollection"; } }
        public override String DaoTypeName { get { return "DfExample.DBFlute.LibraryDb.ExDao.LdCollectionDao"; } }
        public override String ConditionBeanTypeName { get { return "DfExample.DBFlute.LibraryDb.CBean.LdCollectionCB"; } }
        public override String BehaviorTypeName { get { return "DfExample.DBFlute.LibraryDb.ExBhv.LdCollectionBhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override LdEntity NewEntity() { return NewMyEntity(); }
        public LdCollection NewMyEntity() { return new LdCollection(); }
        public override LdConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public LdCollectionCB NewMyConditionBean() { return new LdCollectionCB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<LdCollection>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<LdCollection>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("COLLECTION_ID", "CollectionId", new EntityPropertyCollectionIdSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("LIBRARY_ID", "LibraryId", new EntityPropertyLibraryIdSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("BOOK_ID", "BookId", new EntityPropertyBookIdSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("ARRIVAL_DATE", "ArrivalDate", new EntityPropertyArrivalDateSetupper(), _entityPropertySetupperMap);
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
            EntityPropertySetupper<LdCollection> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((LdCollection)entity, value);
        }

        public class EntityPropertyCollectionIdSetupper : EntityPropertySetupper<LdCollection> {
            public void Setup(LdCollection entity, Object value) { entity.CollectionId = (value != null) ? (int?)value : null; }
        }
        public class EntityPropertyLibraryIdSetupper : EntityPropertySetupper<LdCollection> {
            public void Setup(LdCollection entity, Object value) { entity.LibraryId = (value != null) ? (int?)value : null; }
        }
        public class EntityPropertyBookIdSetupper : EntityPropertySetupper<LdCollection> {
            public void Setup(LdCollection entity, Object value) { entity.BookId = (value != null) ? (int?)value : null; }
        }
        public class EntityPropertyArrivalDateSetupper : EntityPropertySetupper<LdCollection> {
            public void Setup(LdCollection entity, Object value) { entity.ArrivalDate = (value != null) ? (DateTime?)value : null; }
        }
        public class EntityPropertyRUserSetupper : EntityPropertySetupper<LdCollection> {
            public void Setup(LdCollection entity, Object value) { entity.RUser = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyRModuleSetupper : EntityPropertySetupper<LdCollection> {
            public void Setup(LdCollection entity, Object value) { entity.RModule = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyRTimestampSetupper : EntityPropertySetupper<LdCollection> {
            public void Setup(LdCollection entity, Object value) { entity.RTimestamp = (value != null) ? (DateTime?)value : null; }
        }
        public class EntityPropertyUUserSetupper : EntityPropertySetupper<LdCollection> {
            public void Setup(LdCollection entity, Object value) { entity.UUser = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyUModuleSetupper : EntityPropertySetupper<LdCollection> {
            public void Setup(LdCollection entity, Object value) { entity.UModule = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyUTimestampSetupper : EntityPropertySetupper<LdCollection> {
            public void Setup(LdCollection entity, Object value) { entity.UTimestamp = (value != null) ? (DateTime?)value : null; }
        }
    }
}

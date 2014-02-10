
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

    public class LdGenreDbm : LdAbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(LdGenre);

        private static readonly LdGenreDbm _instance = new LdGenreDbm();
        private LdGenreDbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static LdGenreDbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "genre"; } }
        public override String TablePropertyName { get { return "Genre"; } }
        public override String TableSqlName { get { return "genre"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected LdColumnInfo _columnGenreCode;
        protected LdColumnInfo _columnGenreName;
        protected LdColumnInfo _columnHierarchyLevel;
        protected LdColumnInfo _columnHierarchyOrder;
        protected LdColumnInfo _columnParentGenreCode;
        protected LdColumnInfo _columnRUser;
        protected LdColumnInfo _columnRModule;
        protected LdColumnInfo _columnRTimestamp;
        protected LdColumnInfo _columnUUser;
        protected LdColumnInfo _columnUModule;
        protected LdColumnInfo _columnUTimestamp;

        public LdColumnInfo ColumnGenreCode { get { return _columnGenreCode; } }
        public LdColumnInfo ColumnGenreName { get { return _columnGenreName; } }
        public LdColumnInfo ColumnHierarchyLevel { get { return _columnHierarchyLevel; } }
        public LdColumnInfo ColumnHierarchyOrder { get { return _columnHierarchyOrder; } }
        public LdColumnInfo ColumnParentGenreCode { get { return _columnParentGenreCode; } }
        public LdColumnInfo ColumnRUser { get { return _columnRUser; } }
        public LdColumnInfo ColumnRModule { get { return _columnRModule; } }
        public LdColumnInfo ColumnRTimestamp { get { return _columnRTimestamp; } }
        public LdColumnInfo ColumnUUser { get { return _columnUUser; } }
        public LdColumnInfo ColumnUModule { get { return _columnUModule; } }
        public LdColumnInfo ColumnUTimestamp { get { return _columnUTimestamp; } }

        protected void InitializeColumnInfo() {
            _columnGenreCode = cci("GENRE_CODE", "GENRE_CODE", null, null, true, "GenreCode", typeof(String), true, "VARCHAR", 24, 0, false, OptimisticLockType.NONE, null, null, "bookList,genreSelfList");
            _columnGenreName = cci("GENRE_NAME", "GENRE_NAME", null, null, true, "GenreName", typeof(String), false, "VARCHAR", 80, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnHierarchyLevel = cci("HIERARCHY_LEVEL", "HIERARCHY_LEVEL", null, null, true, "HierarchyLevel", typeof(decimal?), false, "DECIMAL", 9, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnHierarchyOrder = cci("HIERARCHY_ORDER", "HIERARCHY_ORDER", null, null, true, "HierarchyOrder", typeof(decimal?), false, "DECIMAL", 10, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnParentGenreCode = cci("PARENT_GENRE_CODE", "PARENT_GENRE_CODE", null, null, false, "ParentGenreCode", typeof(String), false, "VARCHAR", 24, 0, false, OptimisticLockType.NONE, null, "genreSelf", null);
            _columnRUser = cci("R_USER", "R_USER", null, null, true, "RUser", typeof(String), false, "VARCHAR", 100, 0, true, OptimisticLockType.NONE, null, null, null);
            _columnRModule = cci("R_MODULE", "R_MODULE", null, null, true, "RModule", typeof(String), false, "VARCHAR", 100, 0, true, OptimisticLockType.NONE, null, null, null);
            _columnRTimestamp = cci("R_TIMESTAMP", "R_TIMESTAMP", null, null, true, "RTimestamp", typeof(DateTime?), false, "DATETIME", 19, 0, true, OptimisticLockType.NONE, null, null, null);
            _columnUUser = cci("U_USER", "U_USER", null, null, true, "UUser", typeof(String), false, "VARCHAR", 100, 0, true, OptimisticLockType.NONE, null, null, null);
            _columnUModule = cci("U_MODULE", "U_MODULE", null, null, true, "UModule", typeof(String), false, "VARCHAR", 100, 0, true, OptimisticLockType.NONE, null, null, null);
            _columnUTimestamp = cci("U_TIMESTAMP", "U_TIMESTAMP", null, null, true, "UTimestamp", typeof(DateTime?), false, "DATETIME", 19, 0, true, OptimisticLockType.UPDATE_DATE, null, null, null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<LdColumnInfo>();
            _columnInfoList.add(ColumnGenreCode);
            _columnInfoList.add(ColumnGenreName);
            _columnInfoList.add(ColumnHierarchyLevel);
            _columnInfoList.add(ColumnHierarchyOrder);
            _columnInfoList.add(ColumnParentGenreCode);
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
            return cpui(ColumnGenreCode);
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
        public LdForeignInfo ForeignGenreSelf { get {
            Map<LdColumnInfo, LdColumnInfo> map = new LinkedHashMap<LdColumnInfo, LdColumnInfo>();
            map.put(ColumnParentGenreCode, LdGenreDbm.GetInstance().ColumnGenreCode);
            return cfi("GenreSelf", this, LdGenreDbm.GetInstance(), map, 0, false, false);
        }}


        // -------------------------------------------------
        //                                  Referrer Element
        //                                  ----------------
        public LdReferrerInfo ReferrerBookList { get {
            Map<LdColumnInfo, LdColumnInfo> map = new LinkedHashMap<LdColumnInfo, LdColumnInfo>();
            map.put(ColumnGenreCode, LdBookDbm.GetInstance().ColumnGenreCode);
            return cri("BookList", this, LdBookDbm.GetInstance(), map, false);
        }}
        public LdReferrerInfo ReferrerGenreSelfList { get {
            Map<LdColumnInfo, LdColumnInfo> map = new LinkedHashMap<LdColumnInfo, LdColumnInfo>();
            map.put(ColumnGenreCode, LdGenreDbm.GetInstance().ColumnParentGenreCode);
            return cri("GenreSelfList", this, LdGenreDbm.GetInstance(), map, false);
        }}

        // ===============================================================================
        //                                                                    Various Info
        //                                                                    ============
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
        public static readonly String TABLE_DB_NAME = "genre";
        public static readonly String TABLE_PROPERTY_NAME = "Genre";

        // -------------------------------------------------
        //                                    Column DB-Name
        //                                    --------------
        public static readonly String DB_NAME_GENRE_CODE = "GENRE_CODE";
        public static readonly String DB_NAME_GENRE_NAME = "GENRE_NAME";
        public static readonly String DB_NAME_HIERARCHY_LEVEL = "HIERARCHY_LEVEL";
        public static readonly String DB_NAME_HIERARCHY_ORDER = "HIERARCHY_ORDER";
        public static readonly String DB_NAME_PARENT_GENRE_CODE = "PARENT_GENRE_CODE";
        public static readonly String DB_NAME_R_USER = "R_USER";
        public static readonly String DB_NAME_R_MODULE = "R_MODULE";
        public static readonly String DB_NAME_R_TIMESTAMP = "R_TIMESTAMP";
        public static readonly String DB_NAME_U_USER = "U_USER";
        public static readonly String DB_NAME_U_MODULE = "U_MODULE";
        public static readonly String DB_NAME_U_TIMESTAMP = "U_TIMESTAMP";

        // -------------------------------------------------
        //                              Column Property-Name
        //                              --------------------
        public static readonly String PROPERTY_NAME_GENRE_CODE = "GenreCode";
        public static readonly String PROPERTY_NAME_GENRE_NAME = "GenreName";
        public static readonly String PROPERTY_NAME_HIERARCHY_LEVEL = "HierarchyLevel";
        public static readonly String PROPERTY_NAME_HIERARCHY_ORDER = "HierarchyOrder";
        public static readonly String PROPERTY_NAME_PARENT_GENRE_CODE = "ParentGenreCode";
        public static readonly String PROPERTY_NAME_R_USER = "RUser";
        public static readonly String PROPERTY_NAME_R_MODULE = "RModule";
        public static readonly String PROPERTY_NAME_R_TIMESTAMP = "RTimestamp";
        public static readonly String PROPERTY_NAME_U_USER = "UUser";
        public static readonly String PROPERTY_NAME_U_MODULE = "UModule";
        public static readonly String PROPERTY_NAME_U_TIMESTAMP = "UTimestamp";

        // -------------------------------------------------
        //                                      Foreign Name
        //                                      ------------
        public static readonly String FOREIGN_PROPERTY_NAME_GenreSelf = "GenreSelf";
        // -------------------------------------------------
        //                                     Referrer Name
        //                                     -------------
        public static readonly String REFERRER_PROPERTY_NAME_BookList = "BookList";
        public static readonly String REFERRER_PROPERTY_NAME_GenreSelfList = "GenreSelfList";

        // -------------------------------------------------
        //                               DB-Property Mapping
        //                               -------------------
        protected static readonly Map<String, String> _dbNamePropertyNameKeyToLowerMap;
        protected static readonly Map<String, String> _propertyNameDbNameKeyToLowerMap;

        static LdGenreDbm() {
            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_DB_NAME.ToLower(), TABLE_PROPERTY_NAME);
                map.put(DB_NAME_GENRE_CODE.ToLower(), PROPERTY_NAME_GENRE_CODE);
                map.put(DB_NAME_GENRE_NAME.ToLower(), PROPERTY_NAME_GENRE_NAME);
                map.put(DB_NAME_HIERARCHY_LEVEL.ToLower(), PROPERTY_NAME_HIERARCHY_LEVEL);
                map.put(DB_NAME_HIERARCHY_ORDER.ToLower(), PROPERTY_NAME_HIERARCHY_ORDER);
                map.put(DB_NAME_PARENT_GENRE_CODE.ToLower(), PROPERTY_NAME_PARENT_GENRE_CODE);
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
                map.put(PROPERTY_NAME_GENRE_CODE.ToLower(), DB_NAME_GENRE_CODE);
                map.put(PROPERTY_NAME_GENRE_NAME.ToLower(), DB_NAME_GENRE_NAME);
                map.put(PROPERTY_NAME_HIERARCHY_LEVEL.ToLower(), DB_NAME_HIERARCHY_LEVEL);
                map.put(PROPERTY_NAME_HIERARCHY_ORDER.ToLower(), DB_NAME_HIERARCHY_ORDER);
                map.put(PROPERTY_NAME_PARENT_GENRE_CODE.ToLower(), DB_NAME_PARENT_GENRE_CODE);
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
        public override String EntityTypeName { get { return "DfExample.DBFlute.LibraryDb.ExEntity.LdGenre"; } }
        public override String DaoTypeName { get { return "DfExample.DBFlute.LibraryDb.ExDao.LdGenreDao"; } }
        public override String ConditionBeanTypeName { get { return "DfExample.DBFlute.LibraryDb.CBean.LdGenreCB"; } }
        public override String BehaviorTypeName { get { return "DfExample.DBFlute.LibraryDb.ExBhv.LdGenreBhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override LdEntity NewEntity() { return NewMyEntity(); }
        public LdGenre NewMyEntity() { return new LdGenre(); }
        public override LdConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public LdGenreCB NewMyConditionBean() { return new LdGenreCB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<LdGenre>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<LdGenre>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("GENRE_CODE", "GenreCode", new EntityPropertyGenreCodeSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("GENRE_NAME", "GenreName", new EntityPropertyGenreNameSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("HIERARCHY_LEVEL", "HierarchyLevel", new EntityPropertyHierarchyLevelSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("HIERARCHY_ORDER", "HierarchyOrder", new EntityPropertyHierarchyOrderSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("PARENT_GENRE_CODE", "ParentGenreCode", new EntityPropertyParentGenreCodeSetupper(), _entityPropertySetupperMap);
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
            EntityPropertySetupper<LdGenre> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((LdGenre)entity, value);
        }

        public class EntityPropertyGenreCodeSetupper : EntityPropertySetupper<LdGenre> {
            public void Setup(LdGenre entity, Object value) { entity.GenreCode = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyGenreNameSetupper : EntityPropertySetupper<LdGenre> {
            public void Setup(LdGenre entity, Object value) { entity.GenreName = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyHierarchyLevelSetupper : EntityPropertySetupper<LdGenre> {
            public void Setup(LdGenre entity, Object value) { entity.HierarchyLevel = (value != null) ? (decimal?)value : null; }
        }
        public class EntityPropertyHierarchyOrderSetupper : EntityPropertySetupper<LdGenre> {
            public void Setup(LdGenre entity, Object value) { entity.HierarchyOrder = (value != null) ? (decimal?)value : null; }
        }
        public class EntityPropertyParentGenreCodeSetupper : EntityPropertySetupper<LdGenre> {
            public void Setup(LdGenre entity, Object value) { entity.ParentGenreCode = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyRUserSetupper : EntityPropertySetupper<LdGenre> {
            public void Setup(LdGenre entity, Object value) { entity.RUser = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyRModuleSetupper : EntityPropertySetupper<LdGenre> {
            public void Setup(LdGenre entity, Object value) { entity.RModule = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyRTimestampSetupper : EntityPropertySetupper<LdGenre> {
            public void Setup(LdGenre entity, Object value) { entity.RTimestamp = (value != null) ? (DateTime?)value : null; }
        }
        public class EntityPropertyUUserSetupper : EntityPropertySetupper<LdGenre> {
            public void Setup(LdGenre entity, Object value) { entity.UUser = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyUModuleSetupper : EntityPropertySetupper<LdGenre> {
            public void Setup(LdGenre entity, Object value) { entity.UModule = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyUTimestampSetupper : EntityPropertySetupper<LdGenre> {
            public void Setup(LdGenre entity, Object value) { entity.UTimestamp = (value != null) ? (DateTime?)value : null; }
        }
    }
}

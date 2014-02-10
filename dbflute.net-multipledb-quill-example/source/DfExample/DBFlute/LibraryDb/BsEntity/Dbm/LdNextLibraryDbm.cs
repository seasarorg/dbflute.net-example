
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

    public class LdNextLibraryDbm : LdAbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(LdNextLibrary);

        private static readonly LdNextLibraryDbm _instance = new LdNextLibraryDbm();
        private LdNextLibraryDbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static LdNextLibraryDbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "next_library"; } }
        public override String TablePropertyName { get { return "NextLibrary"; } }
        public override String TableSqlName { get { return "next_library"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected LdColumnInfo _columnLibraryId;
        protected LdColumnInfo _columnNextLibraryId;
        protected LdColumnInfo _columnDistanceKm;
        protected LdColumnInfo _columnRUser;
        protected LdColumnInfo _columnRModule;
        protected LdColumnInfo _columnRTimestamp;
        protected LdColumnInfo _columnUUser;
        protected LdColumnInfo _columnUModule;
        protected LdColumnInfo _columnUTimestamp;

        public LdColumnInfo ColumnLibraryId { get { return _columnLibraryId; } }
        public LdColumnInfo ColumnNextLibraryId { get { return _columnNextLibraryId; } }
        public LdColumnInfo ColumnDistanceKm { get { return _columnDistanceKm; } }
        public LdColumnInfo ColumnRUser { get { return _columnRUser; } }
        public LdColumnInfo ColumnRModule { get { return _columnRModule; } }
        public LdColumnInfo ColumnRTimestamp { get { return _columnRTimestamp; } }
        public LdColumnInfo ColumnUUser { get { return _columnUUser; } }
        public LdColumnInfo ColumnUModule { get { return _columnUModule; } }
        public LdColumnInfo ColumnUTimestamp { get { return _columnUTimestamp; } }

        protected void InitializeColumnInfo() {
            _columnLibraryId = cci("LIBRARY_ID", "LIBRARY_ID", null, null, true, "LibraryId", typeof(int?), true, "INT", 10, 0, false, OptimisticLockType.NONE, null, "libraryByLibraryId", null);
            _columnNextLibraryId = cci("NEXT_LIBRARY_ID", "NEXT_LIBRARY_ID", null, null, true, "NextLibraryId", typeof(int?), true, "INT", 10, 0, false, OptimisticLockType.NONE, null, "libraryByNextLibraryId", null);
            _columnDistanceKm = cci("DISTANCE_KM", "DISTANCE_KM", null, null, true, "DistanceKm", typeof(decimal?), false, "DECIMAL", 4, 2, false, OptimisticLockType.NONE, null, null, null);
            _columnRUser = cci("R_USER", "R_USER", null, null, true, "RUser", typeof(String), false, "VARCHAR", 100, 0, true, OptimisticLockType.NONE, null, null, null);
            _columnRModule = cci("R_MODULE", "R_MODULE", null, null, true, "RModule", typeof(String), false, "VARCHAR", 100, 0, true, OptimisticLockType.NONE, null, null, null);
            _columnRTimestamp = cci("R_TIMESTAMP", "R_TIMESTAMP", null, null, true, "RTimestamp", typeof(DateTime?), false, "DATETIME", 19, 0, true, OptimisticLockType.NONE, null, null, null);
            _columnUUser = cci("U_USER", "U_USER", null, null, true, "UUser", typeof(String), false, "VARCHAR", 100, 0, true, OptimisticLockType.NONE, null, null, null);
            _columnUModule = cci("U_MODULE", "U_MODULE", null, null, true, "UModule", typeof(String), false, "VARCHAR", 100, 0, true, OptimisticLockType.NONE, null, null, null);
            _columnUTimestamp = cci("U_TIMESTAMP", "U_TIMESTAMP", null, null, true, "UTimestamp", typeof(DateTime?), false, "DATETIME", 19, 0, true, OptimisticLockType.UPDATE_DATE, null, null, null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<LdColumnInfo>();
            _columnInfoList.add(ColumnLibraryId);
            _columnInfoList.add(ColumnNextLibraryId);
            _columnInfoList.add(ColumnDistanceKm);
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
            List<LdColumnInfo> ls = new ArrayList<LdColumnInfo>();
            ls.add(ColumnLibraryId);
            ls.add(ColumnNextLibraryId);
            return cpui(ls);
        }}

        // -------------------------------------------------
        //                                   Primary Element
        //                                   ---------------
        public override bool HasPrimaryKey { get { return true; } }
        public override bool HasCompoundPrimaryKey { get { return true; } }

        // ===============================================================================
        //                                                                   Relation Info
        //                                                                   =============
        // -------------------------------------------------
        //                                   Foreign Element
        //                                   ---------------
        public LdForeignInfo ForeignLibraryByLibraryId { get {
            Map<LdColumnInfo, LdColumnInfo> map = new LinkedHashMap<LdColumnInfo, LdColumnInfo>();
            map.put(ColumnLibraryId, LdLibraryDbm.GetInstance().ColumnLibraryId);
            return cfi("LibraryByLibraryId", this, LdLibraryDbm.GetInstance(), map, 0, false, false);
        }}
        public LdForeignInfo ForeignLibraryByNextLibraryId { get {
            Map<LdColumnInfo, LdColumnInfo> map = new LinkedHashMap<LdColumnInfo, LdColumnInfo>();
            map.put(ColumnNextLibraryId, LdLibraryDbm.GetInstance().ColumnLibraryId);
            return cfi("LibraryByNextLibraryId", this, LdLibraryDbm.GetInstance(), map, 1, false, false);
        }}


        // -------------------------------------------------
        //                                  Referrer Element
        //                                  ----------------

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
        public static readonly String TABLE_DB_NAME = "next_library";
        public static readonly String TABLE_PROPERTY_NAME = "NextLibrary";

        // -------------------------------------------------
        //                                    Column DB-Name
        //                                    --------------
        public static readonly String DB_NAME_LIBRARY_ID = "LIBRARY_ID";
        public static readonly String DB_NAME_NEXT_LIBRARY_ID = "NEXT_LIBRARY_ID";
        public static readonly String DB_NAME_DISTANCE_KM = "DISTANCE_KM";
        public static readonly String DB_NAME_R_USER = "R_USER";
        public static readonly String DB_NAME_R_MODULE = "R_MODULE";
        public static readonly String DB_NAME_R_TIMESTAMP = "R_TIMESTAMP";
        public static readonly String DB_NAME_U_USER = "U_USER";
        public static readonly String DB_NAME_U_MODULE = "U_MODULE";
        public static readonly String DB_NAME_U_TIMESTAMP = "U_TIMESTAMP";

        // -------------------------------------------------
        //                              Column Property-Name
        //                              --------------------
        public static readonly String PROPERTY_NAME_LIBRARY_ID = "LibraryId";
        public static readonly String PROPERTY_NAME_NEXT_LIBRARY_ID = "NextLibraryId";
        public static readonly String PROPERTY_NAME_DISTANCE_KM = "DistanceKm";
        public static readonly String PROPERTY_NAME_R_USER = "RUser";
        public static readonly String PROPERTY_NAME_R_MODULE = "RModule";
        public static readonly String PROPERTY_NAME_R_TIMESTAMP = "RTimestamp";
        public static readonly String PROPERTY_NAME_U_USER = "UUser";
        public static readonly String PROPERTY_NAME_U_MODULE = "UModule";
        public static readonly String PROPERTY_NAME_U_TIMESTAMP = "UTimestamp";

        // -------------------------------------------------
        //                                      Foreign Name
        //                                      ------------
        public static readonly String FOREIGN_PROPERTY_NAME_LibraryByLibraryId = "LibraryByLibraryId";
        public static readonly String FOREIGN_PROPERTY_NAME_LibraryByNextLibraryId = "LibraryByNextLibraryId";
        // -------------------------------------------------
        //                                     Referrer Name
        //                                     -------------

        // -------------------------------------------------
        //                               DB-Property Mapping
        //                               -------------------
        protected static readonly Map<String, String> _dbNamePropertyNameKeyToLowerMap;
        protected static readonly Map<String, String> _propertyNameDbNameKeyToLowerMap;

        static LdNextLibraryDbm() {
            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_DB_NAME.ToLower(), TABLE_PROPERTY_NAME);
                map.put(DB_NAME_LIBRARY_ID.ToLower(), PROPERTY_NAME_LIBRARY_ID);
                map.put(DB_NAME_NEXT_LIBRARY_ID.ToLower(), PROPERTY_NAME_NEXT_LIBRARY_ID);
                map.put(DB_NAME_DISTANCE_KM.ToLower(), PROPERTY_NAME_DISTANCE_KM);
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
                map.put(PROPERTY_NAME_LIBRARY_ID.ToLower(), DB_NAME_LIBRARY_ID);
                map.put(PROPERTY_NAME_NEXT_LIBRARY_ID.ToLower(), DB_NAME_NEXT_LIBRARY_ID);
                map.put(PROPERTY_NAME_DISTANCE_KM.ToLower(), DB_NAME_DISTANCE_KM);
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
        public override String EntityTypeName { get { return "DfExample.DBFlute.LibraryDb.ExEntity.LdNextLibrary"; } }
        public override String DaoTypeName { get { return "DfExample.DBFlute.LibraryDb.ExDao.LdNextLibraryDao"; } }
        public override String ConditionBeanTypeName { get { return "DfExample.DBFlute.LibraryDb.CBean.LdNextLibraryCB"; } }
        public override String BehaviorTypeName { get { return "DfExample.DBFlute.LibraryDb.ExBhv.LdNextLibraryBhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override LdEntity NewEntity() { return NewMyEntity(); }
        public LdNextLibrary NewMyEntity() { return new LdNextLibrary(); }
        public override LdConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public LdNextLibraryCB NewMyConditionBean() { return new LdNextLibraryCB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<LdNextLibrary>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<LdNextLibrary>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("LIBRARY_ID", "LibraryId", new EntityPropertyLibraryIdSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("NEXT_LIBRARY_ID", "NextLibraryId", new EntityPropertyNextLibraryIdSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("DISTANCE_KM", "DistanceKm", new EntityPropertyDistanceKmSetupper(), _entityPropertySetupperMap);
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
            EntityPropertySetupper<LdNextLibrary> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((LdNextLibrary)entity, value);
        }

        public class EntityPropertyLibraryIdSetupper : EntityPropertySetupper<LdNextLibrary> {
            public void Setup(LdNextLibrary entity, Object value) { entity.LibraryId = (value != null) ? (int?)value : null; }
        }
        public class EntityPropertyNextLibraryIdSetupper : EntityPropertySetupper<LdNextLibrary> {
            public void Setup(LdNextLibrary entity, Object value) { entity.NextLibraryId = (value != null) ? (int?)value : null; }
        }
        public class EntityPropertyDistanceKmSetupper : EntityPropertySetupper<LdNextLibrary> {
            public void Setup(LdNextLibrary entity, Object value) { entity.DistanceKm = (value != null) ? (decimal?)value : null; }
        }
        public class EntityPropertyRUserSetupper : EntityPropertySetupper<LdNextLibrary> {
            public void Setup(LdNextLibrary entity, Object value) { entity.RUser = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyRModuleSetupper : EntityPropertySetupper<LdNextLibrary> {
            public void Setup(LdNextLibrary entity, Object value) { entity.RModule = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyRTimestampSetupper : EntityPropertySetupper<LdNextLibrary> {
            public void Setup(LdNextLibrary entity, Object value) { entity.RTimestamp = (value != null) ? (DateTime?)value : null; }
        }
        public class EntityPropertyUUserSetupper : EntityPropertySetupper<LdNextLibrary> {
            public void Setup(LdNextLibrary entity, Object value) { entity.UUser = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyUModuleSetupper : EntityPropertySetupper<LdNextLibrary> {
            public void Setup(LdNextLibrary entity, Object value) { entity.UModule = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyUTimestampSetupper : EntityPropertySetupper<LdNextLibrary> {
            public void Setup(LdNextLibrary entity, Object value) { entity.UTimestamp = (value != null) ? (DateTime?)value : null; }
        }
    }
}

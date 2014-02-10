
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

    public class LdLibraryTypeLookupDbm : LdAbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(LdLibraryTypeLookup);

        private static readonly LdLibraryTypeLookupDbm _instance = new LdLibraryTypeLookupDbm();
        private LdLibraryTypeLookupDbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static LdLibraryTypeLookupDbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "library_type_lookup"; } }
        public override String TablePropertyName { get { return "LibraryTypeLookup"; } }
        public override String TableSqlName { get { return "library_type_lookup"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected LdColumnInfo _columnLibraryTypeCode;
        protected LdColumnInfo _columnLibraryTypeName;
        protected LdColumnInfo _columnRUser;
        protected LdColumnInfo _columnRModule;
        protected LdColumnInfo _columnRTimestamp;
        protected LdColumnInfo _columnUUser;
        protected LdColumnInfo _columnUModule;
        protected LdColumnInfo _columnUTimestamp;

        public LdColumnInfo ColumnLibraryTypeCode { get { return _columnLibraryTypeCode; } }
        public LdColumnInfo ColumnLibraryTypeName { get { return _columnLibraryTypeName; } }
        public LdColumnInfo ColumnRUser { get { return _columnRUser; } }
        public LdColumnInfo ColumnRModule { get { return _columnRModule; } }
        public LdColumnInfo ColumnRTimestamp { get { return _columnRTimestamp; } }
        public LdColumnInfo ColumnUUser { get { return _columnUUser; } }
        public LdColumnInfo ColumnUModule { get { return _columnUModule; } }
        public LdColumnInfo ColumnUTimestamp { get { return _columnUTimestamp; } }

        protected void InitializeColumnInfo() {
            _columnLibraryTypeCode = cci("LIBRARY_TYPE_CODE", "LIBRARY_TYPE_CODE", null, null, true, "LibraryTypeCode", typeof(String), true, "CHAR", 3, 0, false, OptimisticLockType.NONE, null, null, "libraryList");
            _columnLibraryTypeName = cci("LIBRARY_TYPE_NAME", "LIBRARY_TYPE_NAME", null, null, true, "LibraryTypeName", typeof(String), false, "VARCHAR", 80, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnRUser = cci("R_USER", "R_USER", null, null, true, "RUser", typeof(String), false, "VARCHAR", 100, 0, true, OptimisticLockType.NONE, null, null, null);
            _columnRModule = cci("R_MODULE", "R_MODULE", null, null, true, "RModule", typeof(String), false, "VARCHAR", 100, 0, true, OptimisticLockType.NONE, null, null, null);
            _columnRTimestamp = cci("R_TIMESTAMP", "R_TIMESTAMP", null, null, true, "RTimestamp", typeof(DateTime?), false, "DATETIME", 19, 0, true, OptimisticLockType.NONE, null, null, null);
            _columnUUser = cci("U_USER", "U_USER", null, null, true, "UUser", typeof(String), false, "VARCHAR", 100, 0, true, OptimisticLockType.NONE, null, null, null);
            _columnUModule = cci("U_MODULE", "U_MODULE", null, null, true, "UModule", typeof(String), false, "VARCHAR", 100, 0, true, OptimisticLockType.NONE, null, null, null);
            _columnUTimestamp = cci("U_TIMESTAMP", "U_TIMESTAMP", null, null, true, "UTimestamp", typeof(DateTime?), false, "DATETIME", 19, 0, true, OptimisticLockType.UPDATE_DATE, null, null, null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<LdColumnInfo>();
            _columnInfoList.add(ColumnLibraryTypeCode);
            _columnInfoList.add(ColumnLibraryTypeName);
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
            return cpui(ColumnLibraryTypeCode);
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


        // -------------------------------------------------
        //                                  Referrer Element
        //                                  ----------------
        public LdReferrerInfo ReferrerLibraryList { get {
            Map<LdColumnInfo, LdColumnInfo> map = new LinkedHashMap<LdColumnInfo, LdColumnInfo>();
            map.put(ColumnLibraryTypeCode, LdLibraryDbm.GetInstance().ColumnLibraryTypeCode);
            return cri("LibraryList", this, LdLibraryDbm.GetInstance(), map, false);
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
        public static readonly String TABLE_DB_NAME = "library_type_lookup";
        public static readonly String TABLE_PROPERTY_NAME = "LibraryTypeLookup";

        // -------------------------------------------------
        //                                    Column DB-Name
        //                                    --------------
        public static readonly String DB_NAME_LIBRARY_TYPE_CODE = "LIBRARY_TYPE_CODE";
        public static readonly String DB_NAME_LIBRARY_TYPE_NAME = "LIBRARY_TYPE_NAME";
        public static readonly String DB_NAME_R_USER = "R_USER";
        public static readonly String DB_NAME_R_MODULE = "R_MODULE";
        public static readonly String DB_NAME_R_TIMESTAMP = "R_TIMESTAMP";
        public static readonly String DB_NAME_U_USER = "U_USER";
        public static readonly String DB_NAME_U_MODULE = "U_MODULE";
        public static readonly String DB_NAME_U_TIMESTAMP = "U_TIMESTAMP";

        // -------------------------------------------------
        //                              Column Property-Name
        //                              --------------------
        public static readonly String PROPERTY_NAME_LIBRARY_TYPE_CODE = "LibraryTypeCode";
        public static readonly String PROPERTY_NAME_LIBRARY_TYPE_NAME = "LibraryTypeName";
        public static readonly String PROPERTY_NAME_R_USER = "RUser";
        public static readonly String PROPERTY_NAME_R_MODULE = "RModule";
        public static readonly String PROPERTY_NAME_R_TIMESTAMP = "RTimestamp";
        public static readonly String PROPERTY_NAME_U_USER = "UUser";
        public static readonly String PROPERTY_NAME_U_MODULE = "UModule";
        public static readonly String PROPERTY_NAME_U_TIMESTAMP = "UTimestamp";

        // -------------------------------------------------
        //                                      Foreign Name
        //                                      ------------
        // -------------------------------------------------
        //                                     Referrer Name
        //                                     -------------
        public static readonly String REFERRER_PROPERTY_NAME_LibraryList = "LibraryList";

        // -------------------------------------------------
        //                               DB-Property Mapping
        //                               -------------------
        protected static readonly Map<String, String> _dbNamePropertyNameKeyToLowerMap;
        protected static readonly Map<String, String> _propertyNameDbNameKeyToLowerMap;

        static LdLibraryTypeLookupDbm() {
            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_DB_NAME.ToLower(), TABLE_PROPERTY_NAME);
                map.put(DB_NAME_LIBRARY_TYPE_CODE.ToLower(), PROPERTY_NAME_LIBRARY_TYPE_CODE);
                map.put(DB_NAME_LIBRARY_TYPE_NAME.ToLower(), PROPERTY_NAME_LIBRARY_TYPE_NAME);
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
                map.put(PROPERTY_NAME_LIBRARY_TYPE_CODE.ToLower(), DB_NAME_LIBRARY_TYPE_CODE);
                map.put(PROPERTY_NAME_LIBRARY_TYPE_NAME.ToLower(), DB_NAME_LIBRARY_TYPE_NAME);
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
        public override String EntityTypeName { get { return "DfExample.DBFlute.LibraryDb.ExEntity.LdLibraryTypeLookup"; } }
        public override String DaoTypeName { get { return "DfExample.DBFlute.LibraryDb.ExDao.LdLibraryTypeLookupDao"; } }
        public override String ConditionBeanTypeName { get { return "DfExample.DBFlute.LibraryDb.CBean.LdLibraryTypeLookupCB"; } }
        public override String BehaviorTypeName { get { return "DfExample.DBFlute.LibraryDb.ExBhv.LdLibraryTypeLookupBhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override LdEntity NewEntity() { return NewMyEntity(); }
        public LdLibraryTypeLookup NewMyEntity() { return new LdLibraryTypeLookup(); }
        public override LdConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public LdLibraryTypeLookupCB NewMyConditionBean() { return new LdLibraryTypeLookupCB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<LdLibraryTypeLookup>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<LdLibraryTypeLookup>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("LIBRARY_TYPE_CODE", "LibraryTypeCode", new EntityPropertyLibraryTypeCodeSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("LIBRARY_TYPE_NAME", "LibraryTypeName", new EntityPropertyLibraryTypeNameSetupper(), _entityPropertySetupperMap);
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
            EntityPropertySetupper<LdLibraryTypeLookup> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((LdLibraryTypeLookup)entity, value);
        }

        public class EntityPropertyLibraryTypeCodeSetupper : EntityPropertySetupper<LdLibraryTypeLookup> {
            public void Setup(LdLibraryTypeLookup entity, Object value) { entity.LibraryTypeCode = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyLibraryTypeNameSetupper : EntityPropertySetupper<LdLibraryTypeLookup> {
            public void Setup(LdLibraryTypeLookup entity, Object value) { entity.LibraryTypeName = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyRUserSetupper : EntityPropertySetupper<LdLibraryTypeLookup> {
            public void Setup(LdLibraryTypeLookup entity, Object value) { entity.RUser = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyRModuleSetupper : EntityPropertySetupper<LdLibraryTypeLookup> {
            public void Setup(LdLibraryTypeLookup entity, Object value) { entity.RModule = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyRTimestampSetupper : EntityPropertySetupper<LdLibraryTypeLookup> {
            public void Setup(LdLibraryTypeLookup entity, Object value) { entity.RTimestamp = (value != null) ? (DateTime?)value : null; }
        }
        public class EntityPropertyUUserSetupper : EntityPropertySetupper<LdLibraryTypeLookup> {
            public void Setup(LdLibraryTypeLookup entity, Object value) { entity.UUser = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyUModuleSetupper : EntityPropertySetupper<LdLibraryTypeLookup> {
            public void Setup(LdLibraryTypeLookup entity, Object value) { entity.UModule = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyUTimestampSetupper : EntityPropertySetupper<LdLibraryTypeLookup> {
            public void Setup(LdLibraryTypeLookup entity, Object value) { entity.UTimestamp = (value != null) ? (DateTime?)value : null; }
        }
    }
}

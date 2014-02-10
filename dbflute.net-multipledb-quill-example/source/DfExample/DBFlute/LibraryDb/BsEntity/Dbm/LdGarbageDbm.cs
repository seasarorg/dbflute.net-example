
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

    public class LdGarbageDbm : LdAbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(LdGarbage);

        private static readonly LdGarbageDbm _instance = new LdGarbageDbm();
        private LdGarbageDbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static LdGarbageDbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "garbage"; } }
        public override String TablePropertyName { get { return "Garbage"; } }
        public override String TableSqlName { get { return "garbage"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected LdColumnInfo _columnGarbageMemo;
        protected LdColumnInfo _columnGarbageTime;
        protected LdColumnInfo _columnGarbageCount;
        protected LdColumnInfo _columnRUser;
        protected LdColumnInfo _columnRTimestamp;
        protected LdColumnInfo _columnUUser;
        protected LdColumnInfo _columnUTimestamp;

        public LdColumnInfo ColumnGarbageMemo { get { return _columnGarbageMemo; } }
        public LdColumnInfo ColumnGarbageTime { get { return _columnGarbageTime; } }
        public LdColumnInfo ColumnGarbageCount { get { return _columnGarbageCount; } }
        public LdColumnInfo ColumnRUser { get { return _columnRUser; } }
        public LdColumnInfo ColumnRTimestamp { get { return _columnRTimestamp; } }
        public LdColumnInfo ColumnUUser { get { return _columnUUser; } }
        public LdColumnInfo ColumnUTimestamp { get { return _columnUTimestamp; } }

        protected void InitializeColumnInfo() {
            _columnGarbageMemo = cci("GARBAGE_MEMO", "GARBAGE_MEMO", null, null, false, "GarbageMemo", typeof(String), false, "VARCHAR", 50, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnGarbageTime = cci("GARBAGE_TIME", "GARBAGE_TIME", null, null, false, "GarbageTime", typeof(DateTime?), false, "DATETIME", 19, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnGarbageCount = cci("GARBAGE_COUNT", "GARBAGE_COUNT", null, null, false, "GarbageCount", typeof(int?), false, "INT", 10, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnRUser = cci("R_USER", "R_USER", null, null, false, "RUser", typeof(String), false, "VARCHAR", 100, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnRTimestamp = cci("R_TIMESTAMP", "R_TIMESTAMP", null, null, false, "RTimestamp", typeof(DateTime?), false, "DATETIME", 19, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnUUser = cci("U_USER", "U_USER", null, null, false, "UUser", typeof(String), false, "VARCHAR", 100, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnUTimestamp = cci("U_TIMESTAMP", "U_TIMESTAMP", null, null, false, "UTimestamp", typeof(DateTime?), false, "DATETIME", 19, 0, false, OptimisticLockType.UPDATE_DATE, null, null, null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<LdColumnInfo>();
            _columnInfoList.add(ColumnGarbageMemo);
            _columnInfoList.add(ColumnGarbageTime);
            _columnInfoList.add(ColumnGarbageCount);
            _columnInfoList.add(ColumnRUser);
            _columnInfoList.add(ColumnRTimestamp);
            _columnInfoList.add(ColumnUUser);
            _columnInfoList.add(ColumnUTimestamp);
        }

        // ===============================================================================
        //                                                                     Unique Info
        //                                                                     ===========
        public override LdUniqueInfo PrimaryUniqueInfo { get {
            throw new NotSupportedException("The table does not have primary key: " + TableDbName);
        }}

        // -------------------------------------------------
        //                                   Primary Element
        //                                   ---------------
        public override bool HasPrimaryKey { get { return false; } }
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

        // ===============================================================================
        //                                                                    Various Info
        //                                                                    ============
        public override bool HasUpdateDate { get { return true; } }
        public override LdColumnInfo UpdateDateColumnInfo { get { return _columnUTimestamp; } }
        public override bool HasCommonColumn { get { return false; } }

        // ===============================================================================
        //                                                                 Name Definition
        //                                                                 ===============
        #region Name

        // -------------------------------------------------
        //                                             Table
        //                                             -----
        public static readonly String TABLE_DB_NAME = "garbage";
        public static readonly String TABLE_PROPERTY_NAME = "Garbage";

        // -------------------------------------------------
        //                                    Column DB-Name
        //                                    --------------
        public static readonly String DB_NAME_GARBAGE_MEMO = "GARBAGE_MEMO";
        public static readonly String DB_NAME_GARBAGE_TIME = "GARBAGE_TIME";
        public static readonly String DB_NAME_GARBAGE_COUNT = "GARBAGE_COUNT";
        public static readonly String DB_NAME_R_USER = "R_USER";
        public static readonly String DB_NAME_R_TIMESTAMP = "R_TIMESTAMP";
        public static readonly String DB_NAME_U_USER = "U_USER";
        public static readonly String DB_NAME_U_TIMESTAMP = "U_TIMESTAMP";

        // -------------------------------------------------
        //                              Column Property-Name
        //                              --------------------
        public static readonly String PROPERTY_NAME_GARBAGE_MEMO = "GarbageMemo";
        public static readonly String PROPERTY_NAME_GARBAGE_TIME = "GarbageTime";
        public static readonly String PROPERTY_NAME_GARBAGE_COUNT = "GarbageCount";
        public static readonly String PROPERTY_NAME_R_USER = "RUser";
        public static readonly String PROPERTY_NAME_R_TIMESTAMP = "RTimestamp";
        public static readonly String PROPERTY_NAME_U_USER = "UUser";
        public static readonly String PROPERTY_NAME_U_TIMESTAMP = "UTimestamp";

        // -------------------------------------------------
        //                                      Foreign Name
        //                                      ------------
        // -------------------------------------------------
        //                                     Referrer Name
        //                                     -------------

        // -------------------------------------------------
        //                               DB-Property Mapping
        //                               -------------------
        protected static readonly Map<String, String> _dbNamePropertyNameKeyToLowerMap;
        protected static readonly Map<String, String> _propertyNameDbNameKeyToLowerMap;

        static LdGarbageDbm() {
            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_DB_NAME.ToLower(), TABLE_PROPERTY_NAME);
                map.put(DB_NAME_GARBAGE_MEMO.ToLower(), PROPERTY_NAME_GARBAGE_MEMO);
                map.put(DB_NAME_GARBAGE_TIME.ToLower(), PROPERTY_NAME_GARBAGE_TIME);
                map.put(DB_NAME_GARBAGE_COUNT.ToLower(), PROPERTY_NAME_GARBAGE_COUNT);
                map.put(DB_NAME_R_USER.ToLower(), PROPERTY_NAME_R_USER);
                map.put(DB_NAME_R_TIMESTAMP.ToLower(), PROPERTY_NAME_R_TIMESTAMP);
                map.put(DB_NAME_U_USER.ToLower(), PROPERTY_NAME_U_USER);
                map.put(DB_NAME_U_TIMESTAMP.ToLower(), PROPERTY_NAME_U_TIMESTAMP);
                _dbNamePropertyNameKeyToLowerMap = map;
            }

            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_PROPERTY_NAME.ToLower(), TABLE_DB_NAME);
                map.put(PROPERTY_NAME_GARBAGE_MEMO.ToLower(), DB_NAME_GARBAGE_MEMO);
                map.put(PROPERTY_NAME_GARBAGE_TIME.ToLower(), DB_NAME_GARBAGE_TIME);
                map.put(PROPERTY_NAME_GARBAGE_COUNT.ToLower(), DB_NAME_GARBAGE_COUNT);
                map.put(PROPERTY_NAME_R_USER.ToLower(), DB_NAME_R_USER);
                map.put(PROPERTY_NAME_R_TIMESTAMP.ToLower(), DB_NAME_R_TIMESTAMP);
                map.put(PROPERTY_NAME_U_USER.ToLower(), DB_NAME_U_USER);
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
        public override String EntityTypeName { get { return "DfExample.DBFlute.LibraryDb.ExEntity.LdGarbage"; } }
        public override String DaoTypeName { get { return "DfExample.DBFlute.LibraryDb.ExDao.LdGarbageDao"; } }
        public override String ConditionBeanTypeName { get { return "DfExample.DBFlute.LibraryDb.CBean.LdGarbageCB"; } }
        public override String BehaviorTypeName { get { return "DfExample.DBFlute.LibraryDb.ExBhv.LdGarbageBhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override LdEntity NewEntity() { return NewMyEntity(); }
        public LdGarbage NewMyEntity() { return new LdGarbage(); }
        public override LdConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public LdGarbageCB NewMyConditionBean() { return new LdGarbageCB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<LdGarbage>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<LdGarbage>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("GARBAGE_MEMO", "GarbageMemo", new EntityPropertyGarbageMemoSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("GARBAGE_TIME", "GarbageTime", new EntityPropertyGarbageTimeSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("GARBAGE_COUNT", "GarbageCount", new EntityPropertyGarbageCountSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("R_USER", "RUser", new EntityPropertyRUserSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("R_TIMESTAMP", "RTimestamp", new EntityPropertyRTimestampSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("U_USER", "UUser", new EntityPropertyUUserSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("U_TIMESTAMP", "UTimestamp", new EntityPropertyUTimestampSetupper(), _entityPropertySetupperMap);
        }

        public override bool HasEntityPropertySetupper(String propertyName) {
            return _entityPropertySetupperMap.containsKey(propertyName);
        }

        public override void SetupEntityProperty(String propertyName, Object entity, Object value) {
            EntityPropertySetupper<LdGarbage> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((LdGarbage)entity, value);
        }

        public class EntityPropertyGarbageMemoSetupper : EntityPropertySetupper<LdGarbage> {
            public void Setup(LdGarbage entity, Object value) { entity.GarbageMemo = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyGarbageTimeSetupper : EntityPropertySetupper<LdGarbage> {
            public void Setup(LdGarbage entity, Object value) { entity.GarbageTime = (value != null) ? (DateTime?)value : null; }
        }
        public class EntityPropertyGarbageCountSetupper : EntityPropertySetupper<LdGarbage> {
            public void Setup(LdGarbage entity, Object value) { entity.GarbageCount = (value != null) ? (int?)value : null; }
        }
        public class EntityPropertyRUserSetupper : EntityPropertySetupper<LdGarbage> {
            public void Setup(LdGarbage entity, Object value) { entity.RUser = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyRTimestampSetupper : EntityPropertySetupper<LdGarbage> {
            public void Setup(LdGarbage entity, Object value) { entity.RTimestamp = (value != null) ? (DateTime?)value : null; }
        }
        public class EntityPropertyUUserSetupper : EntityPropertySetupper<LdGarbage> {
            public void Setup(LdGarbage entity, Object value) { entity.UUser = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyUTimestampSetupper : EntityPropertySetupper<LdGarbage> {
            public void Setup(LdGarbage entity, Object value) { entity.UTimestamp = (value != null) ? (DateTime?)value : null; }
        }
    }
}

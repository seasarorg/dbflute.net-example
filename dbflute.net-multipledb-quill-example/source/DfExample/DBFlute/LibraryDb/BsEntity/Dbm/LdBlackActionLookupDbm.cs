
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

    public class LdBlackActionLookupDbm : LdAbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(LdBlackActionLookup);

        private static readonly LdBlackActionLookupDbm _instance = new LdBlackActionLookupDbm();
        private LdBlackActionLookupDbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static LdBlackActionLookupDbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "black_action_lookup"; } }
        public override String TablePropertyName { get { return "BlackActionLookup"; } }
        public override String TableSqlName { get { return "black_action_lookup"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected LdColumnInfo _columnBlackActionCode;
        protected LdColumnInfo _columnBlackActionName;
        protected LdColumnInfo _columnRUser;
        protected LdColumnInfo _columnRModule;
        protected LdColumnInfo _columnRTimestamp;
        protected LdColumnInfo _columnUUser;
        protected LdColumnInfo _columnUModule;
        protected LdColumnInfo _columnUTimestamp;

        public LdColumnInfo ColumnBlackActionCode { get { return _columnBlackActionCode; } }
        public LdColumnInfo ColumnBlackActionName { get { return _columnBlackActionName; } }
        public LdColumnInfo ColumnRUser { get { return _columnRUser; } }
        public LdColumnInfo ColumnRModule { get { return _columnRModule; } }
        public LdColumnInfo ColumnRTimestamp { get { return _columnRTimestamp; } }
        public LdColumnInfo ColumnUUser { get { return _columnUUser; } }
        public LdColumnInfo ColumnUModule { get { return _columnUModule; } }
        public LdColumnInfo ColumnUTimestamp { get { return _columnUTimestamp; } }

        protected void InitializeColumnInfo() {
            _columnBlackActionCode = cci("BLACK_ACTION_CODE", "BLACK_ACTION_CODE", null, null, true, "BlackActionCode", typeof(String), true, "CHAR", 3, 0, false, OptimisticLockType.NONE, null, null, "blackActionList");
            _columnBlackActionName = cci("BLACK_ACTION_NAME", "BLACK_ACTION_NAME", null, null, true, "BlackActionName", typeof(String), false, "VARCHAR", 80, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnRUser = cci("R_USER", "R_USER", null, null, true, "RUser", typeof(String), false, "VARCHAR", 100, 0, true, OptimisticLockType.NONE, null, null, null);
            _columnRModule = cci("R_MODULE", "R_MODULE", null, null, true, "RModule", typeof(String), false, "VARCHAR", 100, 0, true, OptimisticLockType.NONE, null, null, null);
            _columnRTimestamp = cci("R_TIMESTAMP", "R_TIMESTAMP", null, null, true, "RTimestamp", typeof(DateTime?), false, "DATETIME", 19, 0, true, OptimisticLockType.NONE, null, null, null);
            _columnUUser = cci("U_USER", "U_USER", null, null, true, "UUser", typeof(String), false, "VARCHAR", 100, 0, true, OptimisticLockType.NONE, null, null, null);
            _columnUModule = cci("U_MODULE", "U_MODULE", null, null, true, "UModule", typeof(String), false, "VARCHAR", 100, 0, true, OptimisticLockType.NONE, null, null, null);
            _columnUTimestamp = cci("U_TIMESTAMP", "U_TIMESTAMP", null, null, true, "UTimestamp", typeof(DateTime?), false, "DATETIME", 19, 0, true, OptimisticLockType.UPDATE_DATE, null, null, null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<LdColumnInfo>();
            _columnInfoList.add(ColumnBlackActionCode);
            _columnInfoList.add(ColumnBlackActionName);
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
            return cpui(ColumnBlackActionCode);
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
        public LdReferrerInfo ReferrerBlackActionList { get {
            Map<LdColumnInfo, LdColumnInfo> map = new LinkedHashMap<LdColumnInfo, LdColumnInfo>();
            map.put(ColumnBlackActionCode, LdBlackActionDbm.GetInstance().ColumnBlackActionCode);
            return cri("BlackActionList", this, LdBlackActionDbm.GetInstance(), map, false);
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
        public static readonly String TABLE_DB_NAME = "black_action_lookup";
        public static readonly String TABLE_PROPERTY_NAME = "BlackActionLookup";

        // -------------------------------------------------
        //                                    Column DB-Name
        //                                    --------------
        public static readonly String DB_NAME_BLACK_ACTION_CODE = "BLACK_ACTION_CODE";
        public static readonly String DB_NAME_BLACK_ACTION_NAME = "BLACK_ACTION_NAME";
        public static readonly String DB_NAME_R_USER = "R_USER";
        public static readonly String DB_NAME_R_MODULE = "R_MODULE";
        public static readonly String DB_NAME_R_TIMESTAMP = "R_TIMESTAMP";
        public static readonly String DB_NAME_U_USER = "U_USER";
        public static readonly String DB_NAME_U_MODULE = "U_MODULE";
        public static readonly String DB_NAME_U_TIMESTAMP = "U_TIMESTAMP";

        // -------------------------------------------------
        //                              Column Property-Name
        //                              --------------------
        public static readonly String PROPERTY_NAME_BLACK_ACTION_CODE = "BlackActionCode";
        public static readonly String PROPERTY_NAME_BLACK_ACTION_NAME = "BlackActionName";
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
        public static readonly String REFERRER_PROPERTY_NAME_BlackActionList = "BlackActionList";

        // -------------------------------------------------
        //                               DB-Property Mapping
        //                               -------------------
        protected static readonly Map<String, String> _dbNamePropertyNameKeyToLowerMap;
        protected static readonly Map<String, String> _propertyNameDbNameKeyToLowerMap;

        static LdBlackActionLookupDbm() {
            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_DB_NAME.ToLower(), TABLE_PROPERTY_NAME);
                map.put(DB_NAME_BLACK_ACTION_CODE.ToLower(), PROPERTY_NAME_BLACK_ACTION_CODE);
                map.put(DB_NAME_BLACK_ACTION_NAME.ToLower(), PROPERTY_NAME_BLACK_ACTION_NAME);
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
                map.put(PROPERTY_NAME_BLACK_ACTION_CODE.ToLower(), DB_NAME_BLACK_ACTION_CODE);
                map.put(PROPERTY_NAME_BLACK_ACTION_NAME.ToLower(), DB_NAME_BLACK_ACTION_NAME);
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
        public override String EntityTypeName { get { return "DfExample.DBFlute.LibraryDb.ExEntity.LdBlackActionLookup"; } }
        public override String DaoTypeName { get { return "DfExample.DBFlute.LibraryDb.ExDao.LdBlackActionLookupDao"; } }
        public override String ConditionBeanTypeName { get { return "DfExample.DBFlute.LibraryDb.CBean.LdBlackActionLookupCB"; } }
        public override String BehaviorTypeName { get { return "DfExample.DBFlute.LibraryDb.ExBhv.LdBlackActionLookupBhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override LdEntity NewEntity() { return NewMyEntity(); }
        public LdBlackActionLookup NewMyEntity() { return new LdBlackActionLookup(); }
        public override LdConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public LdBlackActionLookupCB NewMyConditionBean() { return new LdBlackActionLookupCB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<LdBlackActionLookup>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<LdBlackActionLookup>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("BLACK_ACTION_CODE", "BlackActionCode", new EntityPropertyBlackActionCodeSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("BLACK_ACTION_NAME", "BlackActionName", new EntityPropertyBlackActionNameSetupper(), _entityPropertySetupperMap);
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
            EntityPropertySetupper<LdBlackActionLookup> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((LdBlackActionLookup)entity, value);
        }

        public class EntityPropertyBlackActionCodeSetupper : EntityPropertySetupper<LdBlackActionLookup> {
            public void Setup(LdBlackActionLookup entity, Object value) { entity.BlackActionCode = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyBlackActionNameSetupper : EntityPropertySetupper<LdBlackActionLookup> {
            public void Setup(LdBlackActionLookup entity, Object value) { entity.BlackActionName = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyRUserSetupper : EntityPropertySetupper<LdBlackActionLookup> {
            public void Setup(LdBlackActionLookup entity, Object value) { entity.RUser = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyRModuleSetupper : EntityPropertySetupper<LdBlackActionLookup> {
            public void Setup(LdBlackActionLookup entity, Object value) { entity.RModule = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyRTimestampSetupper : EntityPropertySetupper<LdBlackActionLookup> {
            public void Setup(LdBlackActionLookup entity, Object value) { entity.RTimestamp = (value != null) ? (DateTime?)value : null; }
        }
        public class EntityPropertyUUserSetupper : EntityPropertySetupper<LdBlackActionLookup> {
            public void Setup(LdBlackActionLookup entity, Object value) { entity.UUser = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyUModuleSetupper : EntityPropertySetupper<LdBlackActionLookup> {
            public void Setup(LdBlackActionLookup entity, Object value) { entity.UModule = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyUTimestampSetupper : EntityPropertySetupper<LdBlackActionLookup> {
            public void Setup(LdBlackActionLookup entity, Object value) { entity.UTimestamp = (value != null) ? (DateTime?)value : null; }
        }
    }
}

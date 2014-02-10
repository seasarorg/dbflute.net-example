
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

    public class LdBlackActionDbm : LdAbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(LdBlackAction);

        private static readonly LdBlackActionDbm _instance = new LdBlackActionDbm();
        private LdBlackActionDbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static LdBlackActionDbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "black_action"; } }
        public override String TablePropertyName { get { return "BlackAction"; } }
        public override String TableSqlName { get { return "black_action"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected LdColumnInfo _columnBlackActionId;
        protected LdColumnInfo _columnBlackListId;
        protected LdColumnInfo _columnBlackActionCode;
        protected LdColumnInfo _columnBlackLevel;
        protected LdColumnInfo _columnActionDate;
        protected LdColumnInfo _columnEvidencePhotograph;
        protected LdColumnInfo _columnRUser;
        protected LdColumnInfo _columnRModule;
        protected LdColumnInfo _columnRTimestamp;
        protected LdColumnInfo _columnUUser;
        protected LdColumnInfo _columnUModule;
        protected LdColumnInfo _columnUTimestamp;

        public LdColumnInfo ColumnBlackActionId { get { return _columnBlackActionId; } }
        public LdColumnInfo ColumnBlackListId { get { return _columnBlackListId; } }
        public LdColumnInfo ColumnBlackActionCode { get { return _columnBlackActionCode; } }
        public LdColumnInfo ColumnBlackLevel { get { return _columnBlackLevel; } }
        public LdColumnInfo ColumnActionDate { get { return _columnActionDate; } }
        public LdColumnInfo ColumnEvidencePhotograph { get { return _columnEvidencePhotograph; } }
        public LdColumnInfo ColumnRUser { get { return _columnRUser; } }
        public LdColumnInfo ColumnRModule { get { return _columnRModule; } }
        public LdColumnInfo ColumnRTimestamp { get { return _columnRTimestamp; } }
        public LdColumnInfo ColumnUUser { get { return _columnUUser; } }
        public LdColumnInfo ColumnUModule { get { return _columnUModule; } }
        public LdColumnInfo ColumnUTimestamp { get { return _columnUTimestamp; } }

        protected void InitializeColumnInfo() {
            _columnBlackActionId = cci("BLACK_ACTION_ID", "BLACK_ACTION_ID", null, null, true, "BlackActionId", typeof(int?), true, "INT", 10, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnBlackListId = cci("BLACK_LIST_ID", "BLACK_LIST_ID", null, null, true, "BlackListId", typeof(int?), false, "INT", 10, 0, false, OptimisticLockType.NONE, null, "blackList", null);
            _columnBlackActionCode = cci("BLACK_ACTION_CODE", "BLACK_ACTION_CODE", null, null, true, "BlackActionCode", typeof(String), false, "CHAR", 3, 0, false, OptimisticLockType.NONE, null, "blackActionLookup", null);
            _columnBlackLevel = cci("BLACK_LEVEL", "BLACK_LEVEL", null, null, true, "BlackLevel", typeof(int?), false, "INT", 10, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnActionDate = cci("ACTION_DATE", "ACTION_DATE", null, null, false, "ActionDate", typeof(DateTime?), false, "DATETIME", 19, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnEvidencePhotograph = cci("EVIDENCE_PHOTOGRAPH", "EVIDENCE_PHOTOGRAPH", null, null, false, "EvidencePhotograph", typeof(byte[]), false, "BLOB", 65535, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnRUser = cci("R_USER", "R_USER", null, null, true, "RUser", typeof(String), false, "VARCHAR", 100, 0, true, OptimisticLockType.NONE, null, null, null);
            _columnRModule = cci("R_MODULE", "R_MODULE", null, null, true, "RModule", typeof(String), false, "VARCHAR", 100, 0, true, OptimisticLockType.NONE, null, null, null);
            _columnRTimestamp = cci("R_TIMESTAMP", "R_TIMESTAMP", null, null, true, "RTimestamp", typeof(DateTime?), false, "DATETIME", 19, 0, true, OptimisticLockType.NONE, null, null, null);
            _columnUUser = cci("U_USER", "U_USER", null, null, true, "UUser", typeof(String), false, "VARCHAR", 100, 0, true, OptimisticLockType.NONE, null, null, null);
            _columnUModule = cci("U_MODULE", "U_MODULE", null, null, true, "UModule", typeof(String), false, "VARCHAR", 100, 0, true, OptimisticLockType.NONE, null, null, null);
            _columnUTimestamp = cci("U_TIMESTAMP", "U_TIMESTAMP", null, null, true, "UTimestamp", typeof(DateTime?), false, "DATETIME", 19, 0, true, OptimisticLockType.UPDATE_DATE, null, null, null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<LdColumnInfo>();
            _columnInfoList.add(ColumnBlackActionId);
            _columnInfoList.add(ColumnBlackListId);
            _columnInfoList.add(ColumnBlackActionCode);
            _columnInfoList.add(ColumnBlackLevel);
            _columnInfoList.add(ColumnActionDate);
            _columnInfoList.add(ColumnEvidencePhotograph);
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
            return cpui(ColumnBlackActionId);
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
        public LdForeignInfo ForeignBlackList { get {
            Map<LdColumnInfo, LdColumnInfo> map = new LinkedHashMap<LdColumnInfo, LdColumnInfo>();
            map.put(ColumnBlackListId, LdBlackListDbm.GetInstance().ColumnBlackListId);
            return cfi("BlackList", this, LdBlackListDbm.GetInstance(), map, 0, false, false);
        }}
        public LdForeignInfo ForeignBlackActionLookup { get {
            Map<LdColumnInfo, LdColumnInfo> map = new LinkedHashMap<LdColumnInfo, LdColumnInfo>();
            map.put(ColumnBlackActionCode, LdBlackActionLookupDbm.GetInstance().ColumnBlackActionCode);
            return cfi("BlackActionLookup", this, LdBlackActionLookupDbm.GetInstance(), map, 1, false, false);
        }}


        // -------------------------------------------------
        //                                  Referrer Element
        //                                  ----------------

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
        public static readonly String TABLE_DB_NAME = "black_action";
        public static readonly String TABLE_PROPERTY_NAME = "BlackAction";

        // -------------------------------------------------
        //                                    Column DB-Name
        //                                    --------------
        public static readonly String DB_NAME_BLACK_ACTION_ID = "BLACK_ACTION_ID";
        public static readonly String DB_NAME_BLACK_LIST_ID = "BLACK_LIST_ID";
        public static readonly String DB_NAME_BLACK_ACTION_CODE = "BLACK_ACTION_CODE";
        public static readonly String DB_NAME_BLACK_LEVEL = "BLACK_LEVEL";
        public static readonly String DB_NAME_ACTION_DATE = "ACTION_DATE";
        public static readonly String DB_NAME_EVIDENCE_PHOTOGRAPH = "EVIDENCE_PHOTOGRAPH";
        public static readonly String DB_NAME_R_USER = "R_USER";
        public static readonly String DB_NAME_R_MODULE = "R_MODULE";
        public static readonly String DB_NAME_R_TIMESTAMP = "R_TIMESTAMP";
        public static readonly String DB_NAME_U_USER = "U_USER";
        public static readonly String DB_NAME_U_MODULE = "U_MODULE";
        public static readonly String DB_NAME_U_TIMESTAMP = "U_TIMESTAMP";

        // -------------------------------------------------
        //                              Column Property-Name
        //                              --------------------
        public static readonly String PROPERTY_NAME_BLACK_ACTION_ID = "BlackActionId";
        public static readonly String PROPERTY_NAME_BLACK_LIST_ID = "BlackListId";
        public static readonly String PROPERTY_NAME_BLACK_ACTION_CODE = "BlackActionCode";
        public static readonly String PROPERTY_NAME_BLACK_LEVEL = "BlackLevel";
        public static readonly String PROPERTY_NAME_ACTION_DATE = "ActionDate";
        public static readonly String PROPERTY_NAME_EVIDENCE_PHOTOGRAPH = "EvidencePhotograph";
        public static readonly String PROPERTY_NAME_R_USER = "RUser";
        public static readonly String PROPERTY_NAME_R_MODULE = "RModule";
        public static readonly String PROPERTY_NAME_R_TIMESTAMP = "RTimestamp";
        public static readonly String PROPERTY_NAME_U_USER = "UUser";
        public static readonly String PROPERTY_NAME_U_MODULE = "UModule";
        public static readonly String PROPERTY_NAME_U_TIMESTAMP = "UTimestamp";

        // -------------------------------------------------
        //                                      Foreign Name
        //                                      ------------
        public static readonly String FOREIGN_PROPERTY_NAME_BlackList = "BlackList";
        public static readonly String FOREIGN_PROPERTY_NAME_BlackActionLookup = "BlackActionLookup";
        // -------------------------------------------------
        //                                     Referrer Name
        //                                     -------------

        // -------------------------------------------------
        //                               DB-Property Mapping
        //                               -------------------
        protected static readonly Map<String, String> _dbNamePropertyNameKeyToLowerMap;
        protected static readonly Map<String, String> _propertyNameDbNameKeyToLowerMap;

        static LdBlackActionDbm() {
            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_DB_NAME.ToLower(), TABLE_PROPERTY_NAME);
                map.put(DB_NAME_BLACK_ACTION_ID.ToLower(), PROPERTY_NAME_BLACK_ACTION_ID);
                map.put(DB_NAME_BLACK_LIST_ID.ToLower(), PROPERTY_NAME_BLACK_LIST_ID);
                map.put(DB_NAME_BLACK_ACTION_CODE.ToLower(), PROPERTY_NAME_BLACK_ACTION_CODE);
                map.put(DB_NAME_BLACK_LEVEL.ToLower(), PROPERTY_NAME_BLACK_LEVEL);
                map.put(DB_NAME_ACTION_DATE.ToLower(), PROPERTY_NAME_ACTION_DATE);
                map.put(DB_NAME_EVIDENCE_PHOTOGRAPH.ToLower(), PROPERTY_NAME_EVIDENCE_PHOTOGRAPH);
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
                map.put(PROPERTY_NAME_BLACK_ACTION_ID.ToLower(), DB_NAME_BLACK_ACTION_ID);
                map.put(PROPERTY_NAME_BLACK_LIST_ID.ToLower(), DB_NAME_BLACK_LIST_ID);
                map.put(PROPERTY_NAME_BLACK_ACTION_CODE.ToLower(), DB_NAME_BLACK_ACTION_CODE);
                map.put(PROPERTY_NAME_BLACK_LEVEL.ToLower(), DB_NAME_BLACK_LEVEL);
                map.put(PROPERTY_NAME_ACTION_DATE.ToLower(), DB_NAME_ACTION_DATE);
                map.put(PROPERTY_NAME_EVIDENCE_PHOTOGRAPH.ToLower(), DB_NAME_EVIDENCE_PHOTOGRAPH);
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
        public override String EntityTypeName { get { return "DfExample.DBFlute.LibraryDb.ExEntity.LdBlackAction"; } }
        public override String DaoTypeName { get { return "DfExample.DBFlute.LibraryDb.ExDao.LdBlackActionDao"; } }
        public override String ConditionBeanTypeName { get { return "DfExample.DBFlute.LibraryDb.CBean.LdBlackActionCB"; } }
        public override String BehaviorTypeName { get { return "DfExample.DBFlute.LibraryDb.ExBhv.LdBlackActionBhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override LdEntity NewEntity() { return NewMyEntity(); }
        public LdBlackAction NewMyEntity() { return new LdBlackAction(); }
        public override LdConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public LdBlackActionCB NewMyConditionBean() { return new LdBlackActionCB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<LdBlackAction>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<LdBlackAction>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("BLACK_ACTION_ID", "BlackActionId", new EntityPropertyBlackActionIdSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("BLACK_LIST_ID", "BlackListId", new EntityPropertyBlackListIdSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("BLACK_ACTION_CODE", "BlackActionCode", new EntityPropertyBlackActionCodeSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("BLACK_LEVEL", "BlackLevel", new EntityPropertyBlackLevelSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("ACTION_DATE", "ActionDate", new EntityPropertyActionDateSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("EVIDENCE_PHOTOGRAPH", "EvidencePhotograph", new EntityPropertyEvidencePhotographSetupper(), _entityPropertySetupperMap);
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
            EntityPropertySetupper<LdBlackAction> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((LdBlackAction)entity, value);
        }

        public class EntityPropertyBlackActionIdSetupper : EntityPropertySetupper<LdBlackAction> {
            public void Setup(LdBlackAction entity, Object value) { entity.BlackActionId = (value != null) ? (int?)value : null; }
        }
        public class EntityPropertyBlackListIdSetupper : EntityPropertySetupper<LdBlackAction> {
            public void Setup(LdBlackAction entity, Object value) { entity.BlackListId = (value != null) ? (int?)value : null; }
        }
        public class EntityPropertyBlackActionCodeSetupper : EntityPropertySetupper<LdBlackAction> {
            public void Setup(LdBlackAction entity, Object value) { entity.BlackActionCode = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyBlackLevelSetupper : EntityPropertySetupper<LdBlackAction> {
            public void Setup(LdBlackAction entity, Object value) { entity.BlackLevel = (value != null) ? (int?)value : null; }
        }
        public class EntityPropertyActionDateSetupper : EntityPropertySetupper<LdBlackAction> {
            public void Setup(LdBlackAction entity, Object value) { entity.ActionDate = (value != null) ? (DateTime?)value : null; }
        }
        public class EntityPropertyEvidencePhotographSetupper : EntityPropertySetupper<LdBlackAction> {
            public void Setup(LdBlackAction entity, Object value) { entity.EvidencePhotograph = (value != null) ? (byte[])value : null; }
        }
        public class EntityPropertyRUserSetupper : EntityPropertySetupper<LdBlackAction> {
            public void Setup(LdBlackAction entity, Object value) { entity.RUser = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyRModuleSetupper : EntityPropertySetupper<LdBlackAction> {
            public void Setup(LdBlackAction entity, Object value) { entity.RModule = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyRTimestampSetupper : EntityPropertySetupper<LdBlackAction> {
            public void Setup(LdBlackAction entity, Object value) { entity.RTimestamp = (value != null) ? (DateTime?)value : null; }
        }
        public class EntityPropertyUUserSetupper : EntityPropertySetupper<LdBlackAction> {
            public void Setup(LdBlackAction entity, Object value) { entity.UUser = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyUModuleSetupper : EntityPropertySetupper<LdBlackAction> {
            public void Setup(LdBlackAction entity, Object value) { entity.UModule = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyUTimestampSetupper : EntityPropertySetupper<LdBlackAction> {
            public void Setup(LdBlackAction entity, Object value) { entity.UTimestamp = (value != null) ? (DateTime?)value : null; }
        }
    }
}


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

    public class LdLbUserDbm : LdAbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(LdLbUser);

        private static readonly LdLbUserDbm _instance = new LdLbUserDbm();
        private LdLbUserDbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static LdLbUserDbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "lb_user"; } }
        public override String TablePropertyName { get { return "LbUser"; } }
        public override String TableSqlName { get { return "lb_user"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected LdColumnInfo _columnLbUserId;
        protected LdColumnInfo _columnLbUserName;
        protected LdColumnInfo _columnUserPassword;
        protected LdColumnInfo _columnRUser;
        protected LdColumnInfo _columnRModule;
        protected LdColumnInfo _columnRTimestamp;
        protected LdColumnInfo _columnUUser;
        protected LdColumnInfo _columnUModule;
        protected LdColumnInfo _columnUTimestamp;

        public LdColumnInfo ColumnLbUserId { get { return _columnLbUserId; } }
        public LdColumnInfo ColumnLbUserName { get { return _columnLbUserName; } }
        public LdColumnInfo ColumnUserPassword { get { return _columnUserPassword; } }
        public LdColumnInfo ColumnRUser { get { return _columnRUser; } }
        public LdColumnInfo ColumnRModule { get { return _columnRModule; } }
        public LdColumnInfo ColumnRTimestamp { get { return _columnRTimestamp; } }
        public LdColumnInfo ColumnUUser { get { return _columnUUser; } }
        public LdColumnInfo ColumnUModule { get { return _columnUModule; } }
        public LdColumnInfo ColumnUTimestamp { get { return _columnUTimestamp; } }

        protected void InitializeColumnInfo() {
            _columnLbUserId = cci("LB_USER_ID", "LB_USER_ID", null, null, true, "LbUserId", typeof(int?), true, "INT", 10, 0, false, OptimisticLockType.NONE, null, null, "libraryUserList");
            _columnLbUserName = cci("LB_USER_NAME", "LB_USER_NAME", null, null, true, "LbUserName", typeof(String), false, "VARCHAR", 80, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnUserPassword = cci("USER_PASSWORD", "USER_PASSWORD", null, null, true, "UserPassword", typeof(String), false, "VARCHAR", 50, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnRUser = cci("R_USER", "R_USER", null, null, true, "RUser", typeof(String), false, "VARCHAR", 100, 0, true, OptimisticLockType.NONE, null, null, null);
            _columnRModule = cci("R_MODULE", "R_MODULE", null, null, true, "RModule", typeof(String), false, "VARCHAR", 100, 0, true, OptimisticLockType.NONE, null, null, null);
            _columnRTimestamp = cci("R_TIMESTAMP", "R_TIMESTAMP", null, null, true, "RTimestamp", typeof(DateTime?), false, "DATETIME", 19, 0, true, OptimisticLockType.NONE, null, null, null);
            _columnUUser = cci("U_USER", "U_USER", null, null, true, "UUser", typeof(String), false, "VARCHAR", 100, 0, true, OptimisticLockType.NONE, null, null, null);
            _columnUModule = cci("U_MODULE", "U_MODULE", null, null, true, "UModule", typeof(String), false, "VARCHAR", 100, 0, true, OptimisticLockType.NONE, null, null, null);
            _columnUTimestamp = cci("U_TIMESTAMP", "U_TIMESTAMP", null, null, true, "UTimestamp", typeof(DateTime?), false, "DATETIME", 19, 0, true, OptimisticLockType.UPDATE_DATE, null, null, null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<LdColumnInfo>();
            _columnInfoList.add(ColumnLbUserId);
            _columnInfoList.add(ColumnLbUserName);
            _columnInfoList.add(ColumnUserPassword);
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
            return cpui(ColumnLbUserId);
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

        public LdForeignInfo ForeignBlackListAsOne { get {
            Map<LdColumnInfo, LdColumnInfo> map = new LinkedHashMap<LdColumnInfo, LdColumnInfo>();
            map.put(ColumnLbUserId, LdBlackListDbm.GetInstance().ColumnLbUserId);
            return cfi("BlackListAsOne", this, LdBlackListDbm.GetInstance(), map, 0, true, false);
        }}

        // -------------------------------------------------
        //                                  Referrer Element
        //                                  ----------------
        public LdReferrerInfo ReferrerLibraryUserList { get {
            Map<LdColumnInfo, LdColumnInfo> map = new LinkedHashMap<LdColumnInfo, LdColumnInfo>();
            map.put(ColumnLbUserId, LdLibraryUserDbm.GetInstance().ColumnLbUserId);
            return cri("LibraryUserList", this, LdLibraryUserDbm.GetInstance(), map, false);
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
        public static readonly String TABLE_DB_NAME = "lb_user";
        public static readonly String TABLE_PROPERTY_NAME = "LbUser";

        // -------------------------------------------------
        //                                    Column DB-Name
        //                                    --------------
        public static readonly String DB_NAME_LB_USER_ID = "LB_USER_ID";
        public static readonly String DB_NAME_LB_USER_NAME = "LB_USER_NAME";
        public static readonly String DB_NAME_USER_PASSWORD = "USER_PASSWORD";
        public static readonly String DB_NAME_R_USER = "R_USER";
        public static readonly String DB_NAME_R_MODULE = "R_MODULE";
        public static readonly String DB_NAME_R_TIMESTAMP = "R_TIMESTAMP";
        public static readonly String DB_NAME_U_USER = "U_USER";
        public static readonly String DB_NAME_U_MODULE = "U_MODULE";
        public static readonly String DB_NAME_U_TIMESTAMP = "U_TIMESTAMP";

        // -------------------------------------------------
        //                              Column Property-Name
        //                              --------------------
        public static readonly String PROPERTY_NAME_LB_USER_ID = "LbUserId";
        public static readonly String PROPERTY_NAME_LB_USER_NAME = "LbUserName";
        public static readonly String PROPERTY_NAME_USER_PASSWORD = "UserPassword";
        public static readonly String PROPERTY_NAME_R_USER = "RUser";
        public static readonly String PROPERTY_NAME_R_MODULE = "RModule";
        public static readonly String PROPERTY_NAME_R_TIMESTAMP = "RTimestamp";
        public static readonly String PROPERTY_NAME_U_USER = "UUser";
        public static readonly String PROPERTY_NAME_U_MODULE = "UModule";
        public static readonly String PROPERTY_NAME_U_TIMESTAMP = "UTimestamp";

        // -------------------------------------------------
        //                                      Foreign Name
        //                                      ------------
        public static readonly String FOREIGN_PROPERTY_NAME_BlackListAsOne = "$foreignKeys.foreignPropertyNameInitCap";
        // -------------------------------------------------
        //                                     Referrer Name
        //                                     -------------
        public static readonly String REFERRER_PROPERTY_NAME_LibraryUserList = "LibraryUserList";

        // -------------------------------------------------
        //                               DB-Property Mapping
        //                               -------------------
        protected static readonly Map<String, String> _dbNamePropertyNameKeyToLowerMap;
        protected static readonly Map<String, String> _propertyNameDbNameKeyToLowerMap;

        static LdLbUserDbm() {
            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_DB_NAME.ToLower(), TABLE_PROPERTY_NAME);
                map.put(DB_NAME_LB_USER_ID.ToLower(), PROPERTY_NAME_LB_USER_ID);
                map.put(DB_NAME_LB_USER_NAME.ToLower(), PROPERTY_NAME_LB_USER_NAME);
                map.put(DB_NAME_USER_PASSWORD.ToLower(), PROPERTY_NAME_USER_PASSWORD);
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
                map.put(PROPERTY_NAME_LB_USER_ID.ToLower(), DB_NAME_LB_USER_ID);
                map.put(PROPERTY_NAME_LB_USER_NAME.ToLower(), DB_NAME_LB_USER_NAME);
                map.put(PROPERTY_NAME_USER_PASSWORD.ToLower(), DB_NAME_USER_PASSWORD);
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
        public override String EntityTypeName { get { return "DfExample.DBFlute.LibraryDb.ExEntity.LdLbUser"; } }
        public override String DaoTypeName { get { return "DfExample.DBFlute.LibraryDb.ExDao.LdLbUserDao"; } }
        public override String ConditionBeanTypeName { get { return "DfExample.DBFlute.LibraryDb.CBean.LdLbUserCB"; } }
        public override String BehaviorTypeName { get { return "DfExample.DBFlute.LibraryDb.ExBhv.LdLbUserBhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override LdEntity NewEntity() { return NewMyEntity(); }
        public LdLbUser NewMyEntity() { return new LdLbUser(); }
        public override LdConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public LdLbUserCB NewMyConditionBean() { return new LdLbUserCB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<LdLbUser>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<LdLbUser>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("LB_USER_ID", "LbUserId", new EntityPropertyLbUserIdSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("LB_USER_NAME", "LbUserName", new EntityPropertyLbUserNameSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("USER_PASSWORD", "UserPassword", new EntityPropertyUserPasswordSetupper(), _entityPropertySetupperMap);
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
            EntityPropertySetupper<LdLbUser> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((LdLbUser)entity, value);
        }

        public class EntityPropertyLbUserIdSetupper : EntityPropertySetupper<LdLbUser> {
            public void Setup(LdLbUser entity, Object value) { entity.LbUserId = (value != null) ? (int?)value : null; }
        }
        public class EntityPropertyLbUserNameSetupper : EntityPropertySetupper<LdLbUser> {
            public void Setup(LdLbUser entity, Object value) { entity.LbUserName = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyUserPasswordSetupper : EntityPropertySetupper<LdLbUser> {
            public void Setup(LdLbUser entity, Object value) { entity.UserPassword = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyRUserSetupper : EntityPropertySetupper<LdLbUser> {
            public void Setup(LdLbUser entity, Object value) { entity.RUser = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyRModuleSetupper : EntityPropertySetupper<LdLbUser> {
            public void Setup(LdLbUser entity, Object value) { entity.RModule = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyRTimestampSetupper : EntityPropertySetupper<LdLbUser> {
            public void Setup(LdLbUser entity, Object value) { entity.RTimestamp = (value != null) ? (DateTime?)value : null; }
        }
        public class EntityPropertyUUserSetupper : EntityPropertySetupper<LdLbUser> {
            public void Setup(LdLbUser entity, Object value) { entity.UUser = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyUModuleSetupper : EntityPropertySetupper<LdLbUser> {
            public void Setup(LdLbUser entity, Object value) { entity.UModule = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyUTimestampSetupper : EntityPropertySetupper<LdLbUser> {
            public void Setup(LdLbUser entity, Object value) { entity.UTimestamp = (value != null) ? (DateTime?)value : null; }
        }
    }
}

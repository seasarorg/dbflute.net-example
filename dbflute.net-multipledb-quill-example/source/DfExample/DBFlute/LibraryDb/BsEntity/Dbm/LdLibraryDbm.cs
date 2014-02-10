
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

    public class LdLibraryDbm : LdAbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(LdLibrary);

        private static readonly LdLibraryDbm _instance = new LdLibraryDbm();
        private LdLibraryDbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static LdLibraryDbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "library"; } }
        public override String TablePropertyName { get { return "Library"; } }
        public override String TableSqlName { get { return "library"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected LdColumnInfo _columnLibraryId;
        protected LdColumnInfo _columnLibraryName;
        protected LdColumnInfo _columnLibraryTypeCode;
        protected LdColumnInfo _columnRUser;
        protected LdColumnInfo _columnRModule;
        protected LdColumnInfo _columnRTimestamp;
        protected LdColumnInfo _columnUUser;
        protected LdColumnInfo _columnUModule;
        protected LdColumnInfo _columnUTimestamp;

        public LdColumnInfo ColumnLibraryId { get { return _columnLibraryId; } }
        public LdColumnInfo ColumnLibraryName { get { return _columnLibraryName; } }
        public LdColumnInfo ColumnLibraryTypeCode { get { return _columnLibraryTypeCode; } }
        public LdColumnInfo ColumnRUser { get { return _columnRUser; } }
        public LdColumnInfo ColumnRModule { get { return _columnRModule; } }
        public LdColumnInfo ColumnRTimestamp { get { return _columnRTimestamp; } }
        public LdColumnInfo ColumnUUser { get { return _columnUUser; } }
        public LdColumnInfo ColumnUModule { get { return _columnUModule; } }
        public LdColumnInfo ColumnUTimestamp { get { return _columnUTimestamp; } }

        protected void InitializeColumnInfo() {
            _columnLibraryId = cci("LIBRARY_ID", "LIBRARY_ID", null, null, true, "LibraryId", typeof(int?), true, "INT", 10, 0, false, OptimisticLockType.NONE, null, null, "collectionList,libraryUserList,nextLibraryByLibraryIdList,nextLibraryByNextLibraryIdList");
            _columnLibraryName = cci("LIBRARY_NAME", "LIBRARY_NAME", null, null, true, "LibraryName", typeof(String), false, "VARCHAR", 80, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnLibraryTypeCode = cci("LIBRARY_TYPE_CODE", "LIBRARY_TYPE_CODE", null, null, true, "LibraryTypeCode", typeof(String), false, "CHAR", 3, 0, false, OptimisticLockType.NONE, null, "libraryTypeLookup", null);
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
            _columnInfoList.add(ColumnLibraryName);
            _columnInfoList.add(ColumnLibraryTypeCode);
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
            return cpui(ColumnLibraryId);
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
        public LdForeignInfo ForeignLibraryTypeLookup { get {
            Map<LdColumnInfo, LdColumnInfo> map = new LinkedHashMap<LdColumnInfo, LdColumnInfo>();
            map.put(ColumnLibraryTypeCode, LdLibraryTypeLookupDbm.GetInstance().ColumnLibraryTypeCode);
            return cfi("LibraryTypeLookup", this, LdLibraryTypeLookupDbm.GetInstance(), map, 0, false, false);
        }}


        // -------------------------------------------------
        //                                  Referrer Element
        //                                  ----------------
        public LdReferrerInfo ReferrerCollectionList { get {
            Map<LdColumnInfo, LdColumnInfo> map = new LinkedHashMap<LdColumnInfo, LdColumnInfo>();
            map.put(ColumnLibraryId, LdCollectionDbm.GetInstance().ColumnLibraryId);
            return cri("CollectionList", this, LdCollectionDbm.GetInstance(), map, false);
        }}
        public LdReferrerInfo ReferrerLibraryUserList { get {
            Map<LdColumnInfo, LdColumnInfo> map = new LinkedHashMap<LdColumnInfo, LdColumnInfo>();
            map.put(ColumnLibraryId, LdLibraryUserDbm.GetInstance().ColumnLibraryId);
            return cri("LibraryUserList", this, LdLibraryUserDbm.GetInstance(), map, false);
        }}
        public LdReferrerInfo ReferrerNextLibraryByLibraryIdList { get {
            Map<LdColumnInfo, LdColumnInfo> map = new LinkedHashMap<LdColumnInfo, LdColumnInfo>();
            map.put(ColumnLibraryId, LdNextLibraryDbm.GetInstance().ColumnLibraryId);
            return cri("NextLibraryByLibraryIdList", this, LdNextLibraryDbm.GetInstance(), map, false);
        }}
        public LdReferrerInfo ReferrerNextLibraryByNextLibraryIdList { get {
            Map<LdColumnInfo, LdColumnInfo> map = new LinkedHashMap<LdColumnInfo, LdColumnInfo>();
            map.put(ColumnLibraryId, LdNextLibraryDbm.GetInstance().ColumnNextLibraryId);
            return cri("NextLibraryByNextLibraryIdList", this, LdNextLibraryDbm.GetInstance(), map, false);
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
        public static readonly String TABLE_DB_NAME = "library";
        public static readonly String TABLE_PROPERTY_NAME = "Library";

        // -------------------------------------------------
        //                                    Column DB-Name
        //                                    --------------
        public static readonly String DB_NAME_LIBRARY_ID = "LIBRARY_ID";
        public static readonly String DB_NAME_LIBRARY_NAME = "LIBRARY_NAME";
        public static readonly String DB_NAME_LIBRARY_TYPE_CODE = "LIBRARY_TYPE_CODE";
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
        public static readonly String PROPERTY_NAME_LIBRARY_NAME = "LibraryName";
        public static readonly String PROPERTY_NAME_LIBRARY_TYPE_CODE = "LibraryTypeCode";
        public static readonly String PROPERTY_NAME_R_USER = "RUser";
        public static readonly String PROPERTY_NAME_R_MODULE = "RModule";
        public static readonly String PROPERTY_NAME_R_TIMESTAMP = "RTimestamp";
        public static readonly String PROPERTY_NAME_U_USER = "UUser";
        public static readonly String PROPERTY_NAME_U_MODULE = "UModule";
        public static readonly String PROPERTY_NAME_U_TIMESTAMP = "UTimestamp";

        // -------------------------------------------------
        //                                      Foreign Name
        //                                      ------------
        public static readonly String FOREIGN_PROPERTY_NAME_LibraryTypeLookup = "LibraryTypeLookup";
        // -------------------------------------------------
        //                                     Referrer Name
        //                                     -------------
        public static readonly String REFERRER_PROPERTY_NAME_CollectionList = "CollectionList";
        public static readonly String REFERRER_PROPERTY_NAME_LibraryUserList = "LibraryUserList";
        public static readonly String REFERRER_PROPERTY_NAME_NextLibraryByLibraryIdList = "NextLibraryByLibraryIdList";
        public static readonly String REFERRER_PROPERTY_NAME_NextLibraryByNextLibraryIdList = "NextLibraryByNextLibraryIdList";

        // -------------------------------------------------
        //                               DB-Property Mapping
        //                               -------------------
        protected static readonly Map<String, String> _dbNamePropertyNameKeyToLowerMap;
        protected static readonly Map<String, String> _propertyNameDbNameKeyToLowerMap;

        static LdLibraryDbm() {
            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_DB_NAME.ToLower(), TABLE_PROPERTY_NAME);
                map.put(DB_NAME_LIBRARY_ID.ToLower(), PROPERTY_NAME_LIBRARY_ID);
                map.put(DB_NAME_LIBRARY_NAME.ToLower(), PROPERTY_NAME_LIBRARY_NAME);
                map.put(DB_NAME_LIBRARY_TYPE_CODE.ToLower(), PROPERTY_NAME_LIBRARY_TYPE_CODE);
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
                map.put(PROPERTY_NAME_LIBRARY_NAME.ToLower(), DB_NAME_LIBRARY_NAME);
                map.put(PROPERTY_NAME_LIBRARY_TYPE_CODE.ToLower(), DB_NAME_LIBRARY_TYPE_CODE);
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
        public override String EntityTypeName { get { return "DfExample.DBFlute.LibraryDb.ExEntity.LdLibrary"; } }
        public override String DaoTypeName { get { return "DfExample.DBFlute.LibraryDb.ExDao.LdLibraryDao"; } }
        public override String ConditionBeanTypeName { get { return "DfExample.DBFlute.LibraryDb.CBean.LdLibraryCB"; } }
        public override String BehaviorTypeName { get { return "DfExample.DBFlute.LibraryDb.ExBhv.LdLibraryBhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override LdEntity NewEntity() { return NewMyEntity(); }
        public LdLibrary NewMyEntity() { return new LdLibrary(); }
        public override LdConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public LdLibraryCB NewMyConditionBean() { return new LdLibraryCB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<LdLibrary>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<LdLibrary>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("LIBRARY_ID", "LibraryId", new EntityPropertyLibraryIdSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("LIBRARY_NAME", "LibraryName", new EntityPropertyLibraryNameSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("LIBRARY_TYPE_CODE", "LibraryTypeCode", new EntityPropertyLibraryTypeCodeSetupper(), _entityPropertySetupperMap);
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
            EntityPropertySetupper<LdLibrary> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((LdLibrary)entity, value);
        }

        public class EntityPropertyLibraryIdSetupper : EntityPropertySetupper<LdLibrary> {
            public void Setup(LdLibrary entity, Object value) { entity.LibraryId = (value != null) ? (int?)value : null; }
        }
        public class EntityPropertyLibraryNameSetupper : EntityPropertySetupper<LdLibrary> {
            public void Setup(LdLibrary entity, Object value) { entity.LibraryName = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyLibraryTypeCodeSetupper : EntityPropertySetupper<LdLibrary> {
            public void Setup(LdLibrary entity, Object value) { entity.LibraryTypeCode = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyRUserSetupper : EntityPropertySetupper<LdLibrary> {
            public void Setup(LdLibrary entity, Object value) { entity.RUser = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyRModuleSetupper : EntityPropertySetupper<LdLibrary> {
            public void Setup(LdLibrary entity, Object value) { entity.RModule = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyRTimestampSetupper : EntityPropertySetupper<LdLibrary> {
            public void Setup(LdLibrary entity, Object value) { entity.RTimestamp = (value != null) ? (DateTime?)value : null; }
        }
        public class EntityPropertyUUserSetupper : EntityPropertySetupper<LdLibrary> {
            public void Setup(LdLibrary entity, Object value) { entity.UUser = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyUModuleSetupper : EntityPropertySetupper<LdLibrary> {
            public void Setup(LdLibrary entity, Object value) { entity.UModule = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyUTimestampSetupper : EntityPropertySetupper<LdLibrary> {
            public void Setup(LdLibrary entity, Object value) { entity.UTimestamp = (value != null) ? (DateTime?)value : null; }
        }
    }
}

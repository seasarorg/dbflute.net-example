
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

    public class LdMyselfDbm : LdAbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(LdMyself);

        private static readonly LdMyselfDbm _instance = new LdMyselfDbm();
        private LdMyselfDbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static LdMyselfDbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "myself"; } }
        public override String TablePropertyName { get { return "Myself"; } }
        public override String TableSqlName { get { return "myself"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected LdColumnInfo _columnMyselfId;
        protected LdColumnInfo _columnMyselfName;

        public LdColumnInfo ColumnMyselfId { get { return _columnMyselfId; } }
        public LdColumnInfo ColumnMyselfName { get { return _columnMyselfName; } }

        protected void InitializeColumnInfo() {
            _columnMyselfId = cci("MYSELF_ID", "MYSELF_ID", null, null, true, "MyselfId", typeof(int?), true, "INT", 10, 0, false, OptimisticLockType.NONE, null, null, "myselfCheckList");
            _columnMyselfName = cci("MYSELF_NAME", "MYSELF_NAME", null, null, true, "MyselfName", typeof(String), false, "VARCHAR", 80, 0, false, OptimisticLockType.NONE, null, null, null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<LdColumnInfo>();
            _columnInfoList.add(ColumnMyselfId);
            _columnInfoList.add(ColumnMyselfName);
        }

        // ===============================================================================
        //                                                                     Unique Info
        //                                                                     ===========
        public override LdUniqueInfo PrimaryUniqueInfo { get {
            return cpui(ColumnMyselfId);
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
        public LdReferrerInfo ReferrerMyselfCheckList { get {
            Map<LdColumnInfo, LdColumnInfo> map = new LinkedHashMap<LdColumnInfo, LdColumnInfo>();
            map.put(ColumnMyselfId, LdMyselfCheckDbm.GetInstance().ColumnMyselfId);
            return cri("MyselfCheckList", this, LdMyselfCheckDbm.GetInstance(), map, false);
        }}

        // ===============================================================================
        //                                                                    Various Info
        //                                                                    ============
        public override bool HasCommonColumn { get { return false; } }

        // ===============================================================================
        //                                                                 Name Definition
        //                                                                 ===============
        #region Name

        // -------------------------------------------------
        //                                             Table
        //                                             -----
        public static readonly String TABLE_DB_NAME = "myself";
        public static readonly String TABLE_PROPERTY_NAME = "Myself";

        // -------------------------------------------------
        //                                    Column DB-Name
        //                                    --------------
        public static readonly String DB_NAME_MYSELF_ID = "MYSELF_ID";
        public static readonly String DB_NAME_MYSELF_NAME = "MYSELF_NAME";

        // -------------------------------------------------
        //                              Column Property-Name
        //                              --------------------
        public static readonly String PROPERTY_NAME_MYSELF_ID = "MyselfId";
        public static readonly String PROPERTY_NAME_MYSELF_NAME = "MyselfName";

        // -------------------------------------------------
        //                                      Foreign Name
        //                                      ------------
        // -------------------------------------------------
        //                                     Referrer Name
        //                                     -------------
        public static readonly String REFERRER_PROPERTY_NAME_MyselfCheckList = "MyselfCheckList";

        // -------------------------------------------------
        //                               DB-Property Mapping
        //                               -------------------
        protected static readonly Map<String, String> _dbNamePropertyNameKeyToLowerMap;
        protected static readonly Map<String, String> _propertyNameDbNameKeyToLowerMap;

        static LdMyselfDbm() {
            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_DB_NAME.ToLower(), TABLE_PROPERTY_NAME);
                map.put(DB_NAME_MYSELF_ID.ToLower(), PROPERTY_NAME_MYSELF_ID);
                map.put(DB_NAME_MYSELF_NAME.ToLower(), PROPERTY_NAME_MYSELF_NAME);
                _dbNamePropertyNameKeyToLowerMap = map;
            }

            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_PROPERTY_NAME.ToLower(), TABLE_DB_NAME);
                map.put(PROPERTY_NAME_MYSELF_ID.ToLower(), DB_NAME_MYSELF_ID);
                map.put(PROPERTY_NAME_MYSELF_NAME.ToLower(), DB_NAME_MYSELF_NAME);
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
        public override String EntityTypeName { get { return "DfExample.DBFlute.LibraryDb.ExEntity.LdMyself"; } }
        public override String DaoTypeName { get { return "DfExample.DBFlute.LibraryDb.ExDao.LdMyselfDao"; } }
        public override String ConditionBeanTypeName { get { return "DfExample.DBFlute.LibraryDb.CBean.LdMyselfCB"; } }
        public override String BehaviorTypeName { get { return "DfExample.DBFlute.LibraryDb.ExBhv.LdMyselfBhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override LdEntity NewEntity() { return NewMyEntity(); }
        public LdMyself NewMyEntity() { return new LdMyself(); }
        public override LdConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public LdMyselfCB NewMyConditionBean() { return new LdMyselfCB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<LdMyself>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<LdMyself>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("MYSELF_ID", "MyselfId", new EntityPropertyMyselfIdSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("MYSELF_NAME", "MyselfName", new EntityPropertyMyselfNameSetupper(), _entityPropertySetupperMap);
        }

        public override bool HasEntityPropertySetupper(String propertyName) {
            return _entityPropertySetupperMap.containsKey(propertyName);
        }

        public override void SetupEntityProperty(String propertyName, Object entity, Object value) {
            EntityPropertySetupper<LdMyself> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((LdMyself)entity, value);
        }

        public class EntityPropertyMyselfIdSetupper : EntityPropertySetupper<LdMyself> {
            public void Setup(LdMyself entity, Object value) { entity.MyselfId = (value != null) ? (int?)value : null; }
        }
        public class EntityPropertyMyselfNameSetupper : EntityPropertySetupper<LdMyself> {
            public void Setup(LdMyself entity, Object value) { entity.MyselfName = (value != null) ? (String)value : null; }
        }
    }
}

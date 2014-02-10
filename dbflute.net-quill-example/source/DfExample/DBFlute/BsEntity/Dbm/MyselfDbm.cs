
using System;
using System.Reflection;

using DfExample.DBFlute.AllCommon;
using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.Dbm;
using DfExample.DBFlute.AllCommon.Dbm.Info;
using DfExample.DBFlute.AllCommon.JavaLike;
using DfExample.DBFlute.ExEntity;

using DfExample.DBFlute.ExDao;
using DfExample.DBFlute.CBean;

namespace DfExample.DBFlute.BsEntity.Dbm {

    public class MyselfDbm : AbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(Myself);

        private static readonly MyselfDbm _instance = new MyselfDbm();
        private MyselfDbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static MyselfDbm GetInstance() {
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
        protected ColumnInfo _columnMyselfId;
        protected ColumnInfo _columnMyselfName;

        public ColumnInfo ColumnMyselfId { get { return _columnMyselfId; } }
        public ColumnInfo ColumnMyselfName { get { return _columnMyselfName; } }

        protected void InitializeColumnInfo() {
            _columnMyselfId = cci("MYSELF_ID", "MYSELF_ID", null, null, true, "MyselfId", typeof(int?), true, "INT", 10, 0, false, OptimisticLockType.NONE, null, null, "myselfCheckList");
            _columnMyselfName = cci("MYSELF_NAME", "MYSELF_NAME", null, null, true, "MyselfName", typeof(String), false, "VARCHAR", 80, 0, false, OptimisticLockType.NONE, null, null, null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<ColumnInfo>();
            _columnInfoList.add(ColumnMyselfId);
            _columnInfoList.add(ColumnMyselfName);
        }

        // ===============================================================================
        //                                                                     Unique Info
        //                                                                     ===========
        public override UniqueInfo PrimaryUniqueInfo { get {
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
        public ReferrerInfo ReferrerMyselfCheckList { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(ColumnMyselfId, MyselfCheckDbm.GetInstance().ColumnMyselfId);
            return cri("MyselfCheckList", this, MyselfCheckDbm.GetInstance(), map, false);
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

        static MyselfDbm() {
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
        public override String EntityTypeName { get { return "DfExample.DBFlute.ExEntity.Myself"; } }
        public override String DaoTypeName { get { return "DfExample.DBFlute.ExDao.MyselfDao"; } }
        public override String ConditionBeanTypeName { get { return "DfExample.DBFlute.CBean.MyselfCB"; } }
        public override String BehaviorTypeName { get { return "DfExample.DBFlute.ExBhv.MyselfBhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override Entity NewEntity() { return NewMyEntity(); }
        public Myself NewMyEntity() { return new Myself(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public MyselfCB NewMyConditionBean() { return new MyselfCB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<Myself>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<Myself>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("MYSELF_ID", "MyselfId", new EntityPropertyMyselfIdSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("MYSELF_NAME", "MyselfName", new EntityPropertyMyselfNameSetupper(), _entityPropertySetupperMap);
        }

        public override bool HasEntityPropertySetupper(String propertyName) {
            return _entityPropertySetupperMap.containsKey(propertyName);
        }

        public override void SetupEntityProperty(String propertyName, Object entity, Object value) {
            EntityPropertySetupper<Myself> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((Myself)entity, value);
        }

        public class EntityPropertyMyselfIdSetupper : EntityPropertySetupper<Myself> {
            public void Setup(Myself entity, Object value) { entity.MyselfId = (value != null) ? (int?)value : null; }
        }
        public class EntityPropertyMyselfNameSetupper : EntityPropertySetupper<Myself> {
            public void Setup(Myself entity, Object value) { entity.MyselfName = (value != null) ? (String)value : null; }
        }
    }
}

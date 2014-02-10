
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

    public class WhiteMyselfDbm : AbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(WhiteMyself);

        private static readonly WhiteMyselfDbm _instance = new WhiteMyselfDbm();
        private WhiteMyselfDbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static WhiteMyselfDbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "white_myself"; } }
        public override String TablePropertyName { get { return "WhiteMyself"; } }
        public override String TableSqlName { get { return "white_myself"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected ColumnInfo _columnMyselfId;
        protected ColumnInfo _columnMyselfName;

        public ColumnInfo ColumnMyselfId { get { return _columnMyselfId; } }
        public ColumnInfo ColumnMyselfName { get { return _columnMyselfName; } }

        protected void InitializeColumnInfo() {
            _columnMyselfId = cci("MYSELF_ID", "MYSELF_ID", null, null, true, "MyselfId", typeof(int?), true, "INT", 10, 0, false, OptimisticLockType.NONE, null, null, "whiteMyselfCheckList");
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
        public ReferrerInfo ReferrerWhiteMyselfCheckList { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(ColumnMyselfId, WhiteMyselfCheckDbm.GetInstance().ColumnMyselfId);
            return cri("WhiteMyselfCheckList", this, WhiteMyselfCheckDbm.GetInstance(), map, false);
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
        public static readonly String TABLE_DB_NAME = "white_myself";
        public static readonly String TABLE_PROPERTY_NAME = "WhiteMyself";

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
        public static readonly String REFERRER_PROPERTY_NAME_WhiteMyselfCheckList = "WhiteMyselfCheckList";

        // -------------------------------------------------
        //                               DB-Property Mapping
        //                               -------------------
        protected static readonly Map<String, String> _dbNamePropertyNameKeyToLowerMap;
        protected static readonly Map<String, String> _propertyNameDbNameKeyToLowerMap;

        static WhiteMyselfDbm() {
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
        public override String EntityTypeName { get { return "DfExample.DBFlute.ExEntity.WhiteMyself"; } }
        public override String DaoTypeName { get { return "DfExample.DBFlute.ExDao.WhiteMyselfDao"; } }
        public override String ConditionBeanTypeName { get { return "DfExample.DBFlute.CBean.WhiteMyselfCB"; } }
        public override String BehaviorTypeName { get { return "DfExample.DBFlute.ExBhv.WhiteMyselfBhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override Entity NewEntity() { return NewMyEntity(); }
        public WhiteMyself NewMyEntity() { return new WhiteMyself(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public WhiteMyselfCB NewMyConditionBean() { return new WhiteMyselfCB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<WhiteMyself>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<WhiteMyself>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("MYSELF_ID", "MyselfId", new EntityPropertyMyselfIdSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("MYSELF_NAME", "MyselfName", new EntityPropertyMyselfNameSetupper(), _entityPropertySetupperMap);
        }

        public override bool HasEntityPropertySetupper(String propertyName) {
            return _entityPropertySetupperMap.containsKey(propertyName);
        }

        public override void SetupEntityProperty(String propertyName, Object entity, Object value) {
            EntityPropertySetupper<WhiteMyself> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((WhiteMyself)entity, value);
        }

        public class EntityPropertyMyselfIdSetupper : EntityPropertySetupper<WhiteMyself> {
            public void Setup(WhiteMyself entity, Object value) { entity.MyselfId = (value != null) ? (int?)value : null; }
        }
        public class EntityPropertyMyselfNameSetupper : EntityPropertySetupper<WhiteMyself> {
            public void Setup(WhiteMyself entity, Object value) { entity.MyselfName = (value != null) ? (String)value : null; }
        }
    }
}


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

    public class WhiteColumnExceptDbm : AbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(WhiteColumnExcept);

        private static readonly WhiteColumnExceptDbm _instance = new WhiteColumnExceptDbm();
        private WhiteColumnExceptDbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static WhiteColumnExceptDbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "white_column_except"; } }
        public override String TablePropertyName { get { return "WhiteColumnExcept"; } }
        public override String TableSqlName { get { return "white_column_except"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected ColumnInfo _columnExceptColumnId;
        protected ColumnInfo _columnColumnExceptTest;

        public ColumnInfo ColumnExceptColumnId { get { return _columnExceptColumnId; } }
        public ColumnInfo ColumnColumnExceptTest { get { return _columnColumnExceptTest; } }

        protected void InitializeColumnInfo() {
            _columnExceptColumnId = cci("EXCEPT_COLUMN_ID", "EXCEPT_COLUMN_ID", null, null, true, "ExceptColumnId", typeof(long?), true, "DECIMAL", 16, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnColumnExceptTest = cci("COLUMN_EXCEPT_TEST", "COLUMN_EXCEPT_TEST", null, null, false, "ColumnExceptTest", typeof(int?), false, "INT", 10, 0, false, OptimisticLockType.NONE, null, null, null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<ColumnInfo>();
            _columnInfoList.add(ColumnExceptColumnId);
            _columnInfoList.add(ColumnColumnExceptTest);
        }

        // ===============================================================================
        //                                                                     Unique Info
        //                                                                     ===========
        public override UniqueInfo PrimaryUniqueInfo { get {
            return cpui(ColumnExceptColumnId);
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
        public static readonly String TABLE_DB_NAME = "white_column_except";
        public static readonly String TABLE_PROPERTY_NAME = "WhiteColumnExcept";

        // -------------------------------------------------
        //                                    Column DB-Name
        //                                    --------------
        public static readonly String DB_NAME_EXCEPT_COLUMN_ID = "EXCEPT_COLUMN_ID";
        public static readonly String DB_NAME_COLUMN_EXCEPT_TEST = "COLUMN_EXCEPT_TEST";

        // -------------------------------------------------
        //                              Column Property-Name
        //                              --------------------
        public static readonly String PROPERTY_NAME_EXCEPT_COLUMN_ID = "ExceptColumnId";
        public static readonly String PROPERTY_NAME_COLUMN_EXCEPT_TEST = "ColumnExceptTest";

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

        static WhiteColumnExceptDbm() {
            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_DB_NAME.ToLower(), TABLE_PROPERTY_NAME);
                map.put(DB_NAME_EXCEPT_COLUMN_ID.ToLower(), PROPERTY_NAME_EXCEPT_COLUMN_ID);
                map.put(DB_NAME_COLUMN_EXCEPT_TEST.ToLower(), PROPERTY_NAME_COLUMN_EXCEPT_TEST);
                _dbNamePropertyNameKeyToLowerMap = map;
            }

            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_PROPERTY_NAME.ToLower(), TABLE_DB_NAME);
                map.put(PROPERTY_NAME_EXCEPT_COLUMN_ID.ToLower(), DB_NAME_EXCEPT_COLUMN_ID);
                map.put(PROPERTY_NAME_COLUMN_EXCEPT_TEST.ToLower(), DB_NAME_COLUMN_EXCEPT_TEST);
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
        public override String EntityTypeName { get { return "DfExample.DBFlute.ExEntity.WhiteColumnExcept"; } }
        public override String DaoTypeName { get { return "DfExample.DBFlute.ExDao.WhiteColumnExceptDao"; } }
        public override String ConditionBeanTypeName { get { return "DfExample.DBFlute.CBean.WhiteColumnExceptCB"; } }
        public override String BehaviorTypeName { get { return "DfExample.DBFlute.ExBhv.WhiteColumnExceptBhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override Entity NewEntity() { return NewMyEntity(); }
        public WhiteColumnExcept NewMyEntity() { return new WhiteColumnExcept(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public WhiteColumnExceptCB NewMyConditionBean() { return new WhiteColumnExceptCB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<WhiteColumnExcept>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<WhiteColumnExcept>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("EXCEPT_COLUMN_ID", "ExceptColumnId", new EntityPropertyExceptColumnIdSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("COLUMN_EXCEPT_TEST", "ColumnExceptTest", new EntityPropertyColumnExceptTestSetupper(), _entityPropertySetupperMap);
        }

        public override bool HasEntityPropertySetupper(String propertyName) {
            return _entityPropertySetupperMap.containsKey(propertyName);
        }

        public override void SetupEntityProperty(String propertyName, Object entity, Object value) {
            EntityPropertySetupper<WhiteColumnExcept> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((WhiteColumnExcept)entity, value);
        }

        public class EntityPropertyExceptColumnIdSetupper : EntityPropertySetupper<WhiteColumnExcept> {
            public void Setup(WhiteColumnExcept entity, Object value) { entity.ExceptColumnId = (value != null) ? (long?)value : null; }
        }
        public class EntityPropertyColumnExceptTestSetupper : EntityPropertySetupper<WhiteColumnExcept> {
            public void Setup(WhiteColumnExcept entity, Object value) { entity.ColumnExceptTest = (value != null) ? (int?)value : null; }
        }
    }
}

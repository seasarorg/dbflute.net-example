
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

    public class MyselfCheckDbm : AbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(MyselfCheck);

        private static readonly MyselfCheckDbm _instance = new MyselfCheckDbm();
        private MyselfCheckDbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static MyselfCheckDbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "myself_check"; } }
        public override String TablePropertyName { get { return "MyselfCheck"; } }
        public override String TableSqlName { get { return "myself_check"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected ColumnInfo _columnMyselfCheckId;
        protected ColumnInfo _columnMyselfCheckName;
        protected ColumnInfo _columnMyselfId;

        public ColumnInfo ColumnMyselfCheckId { get { return _columnMyselfCheckId; } }
        public ColumnInfo ColumnMyselfCheckName { get { return _columnMyselfCheckName; } }
        public ColumnInfo ColumnMyselfId { get { return _columnMyselfId; } }

        protected void InitializeColumnInfo() {
            _columnMyselfCheckId = cci("MYSELF_CHECK_ID", "MYSELF_CHECK_ID", null, null, true, "MyselfCheckId", typeof(int?), true, "INT", 10, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnMyselfCheckName = cci("MYSELF_CHECK_NAME", "MYSELF_CHECK_NAME", null, null, true, "MyselfCheckName", typeof(String), false, "VARCHAR", 80, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnMyselfId = cci("MYSELF_ID", "MYSELF_ID", null, null, false, "MyselfId", typeof(int?), false, "INT", 10, 0, false, OptimisticLockType.NONE, null, "myself", null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<ColumnInfo>();
            _columnInfoList.add(ColumnMyselfCheckId);
            _columnInfoList.add(ColumnMyselfCheckName);
            _columnInfoList.add(ColumnMyselfId);
        }

        // ===============================================================================
        //                                                                     Unique Info
        //                                                                     ===========
        public override UniqueInfo PrimaryUniqueInfo { get {
            return cpui(ColumnMyselfCheckId);
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
        public ForeignInfo ForeignMyself { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(ColumnMyselfId, MyselfDbm.GetInstance().ColumnMyselfId);
            return cfi("Myself", this, MyselfDbm.GetInstance(), map, 0, false, false);
        }}


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
        public static readonly String TABLE_DB_NAME = "myself_check";
        public static readonly String TABLE_PROPERTY_NAME = "MyselfCheck";

        // -------------------------------------------------
        //                                    Column DB-Name
        //                                    --------------
        public static readonly String DB_NAME_MYSELF_CHECK_ID = "MYSELF_CHECK_ID";
        public static readonly String DB_NAME_MYSELF_CHECK_NAME = "MYSELF_CHECK_NAME";
        public static readonly String DB_NAME_MYSELF_ID = "MYSELF_ID";

        // -------------------------------------------------
        //                              Column Property-Name
        //                              --------------------
        public static readonly String PROPERTY_NAME_MYSELF_CHECK_ID = "MyselfCheckId";
        public static readonly String PROPERTY_NAME_MYSELF_CHECK_NAME = "MyselfCheckName";
        public static readonly String PROPERTY_NAME_MYSELF_ID = "MyselfId";

        // -------------------------------------------------
        //                                      Foreign Name
        //                                      ------------
        public static readonly String FOREIGN_PROPERTY_NAME_Myself = "Myself";
        // -------------------------------------------------
        //                                     Referrer Name
        //                                     -------------

        // -------------------------------------------------
        //                               DB-Property Mapping
        //                               -------------------
        protected static readonly Map<String, String> _dbNamePropertyNameKeyToLowerMap;
        protected static readonly Map<String, String> _propertyNameDbNameKeyToLowerMap;

        static MyselfCheckDbm() {
            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_DB_NAME.ToLower(), TABLE_PROPERTY_NAME);
                map.put(DB_NAME_MYSELF_CHECK_ID.ToLower(), PROPERTY_NAME_MYSELF_CHECK_ID);
                map.put(DB_NAME_MYSELF_CHECK_NAME.ToLower(), PROPERTY_NAME_MYSELF_CHECK_NAME);
                map.put(DB_NAME_MYSELF_ID.ToLower(), PROPERTY_NAME_MYSELF_ID);
                _dbNamePropertyNameKeyToLowerMap = map;
            }

            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_PROPERTY_NAME.ToLower(), TABLE_DB_NAME);
                map.put(PROPERTY_NAME_MYSELF_CHECK_ID.ToLower(), DB_NAME_MYSELF_CHECK_ID);
                map.put(PROPERTY_NAME_MYSELF_CHECK_NAME.ToLower(), DB_NAME_MYSELF_CHECK_NAME);
                map.put(PROPERTY_NAME_MYSELF_ID.ToLower(), DB_NAME_MYSELF_ID);
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
        public override String EntityTypeName { get { return "DfExample.DBFlute.ExEntity.MyselfCheck"; } }
        public override String DaoTypeName { get { return "DfExample.DBFlute.ExDao.MyselfCheckDao"; } }
        public override String ConditionBeanTypeName { get { return "DfExample.DBFlute.CBean.MyselfCheckCB"; } }
        public override String BehaviorTypeName { get { return "DfExample.DBFlute.ExBhv.MyselfCheckBhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override Entity NewEntity() { return NewMyEntity(); }
        public MyselfCheck NewMyEntity() { return new MyselfCheck(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public MyselfCheckCB NewMyConditionBean() { return new MyselfCheckCB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<MyselfCheck>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<MyselfCheck>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("MYSELF_CHECK_ID", "MyselfCheckId", new EntityPropertyMyselfCheckIdSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("MYSELF_CHECK_NAME", "MyselfCheckName", new EntityPropertyMyselfCheckNameSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("MYSELF_ID", "MyselfId", new EntityPropertyMyselfIdSetupper(), _entityPropertySetupperMap);
        }

        public override bool HasEntityPropertySetupper(String propertyName) {
            return _entityPropertySetupperMap.containsKey(propertyName);
        }

        public override void SetupEntityProperty(String propertyName, Object entity, Object value) {
            EntityPropertySetupper<MyselfCheck> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((MyselfCheck)entity, value);
        }

        public class EntityPropertyMyselfCheckIdSetupper : EntityPropertySetupper<MyselfCheck> {
            public void Setup(MyselfCheck entity, Object value) { entity.MyselfCheckId = (value != null) ? (int?)value : null; }
        }
        public class EntityPropertyMyselfCheckNameSetupper : EntityPropertySetupper<MyselfCheck> {
            public void Setup(MyselfCheck entity, Object value) { entity.MyselfCheckName = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyMyselfIdSetupper : EntityPropertySetupper<MyselfCheck> {
            public void Setup(MyselfCheck entity, Object value) { entity.MyselfId = (value != null) ? (int?)value : null; }
        }
    }
}

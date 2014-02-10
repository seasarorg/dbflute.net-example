
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

    public class WhiteCompoundPkRefNestDbm : AbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(WhiteCompoundPkRefNest);

        private static readonly WhiteCompoundPkRefNestDbm _instance = new WhiteCompoundPkRefNestDbm();
        private WhiteCompoundPkRefNestDbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static WhiteCompoundPkRefNestDbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "white_compound_pk_ref_nest"; } }
        public override String TablePropertyName { get { return "WhiteCompoundPkRefNest"; } }
        public override String TableSqlName { get { return "white_compound_pk_ref_nest"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected ColumnInfo _columnCompoundPkRefNestId;
        protected ColumnInfo _columnFooMultipleId;
        protected ColumnInfo _columnBarMultipleId;
        protected ColumnInfo _columnQuxMultipleId;

        public ColumnInfo ColumnCompoundPkRefNestId { get { return _columnCompoundPkRefNestId; } }
        public ColumnInfo ColumnFooMultipleId { get { return _columnFooMultipleId; } }
        public ColumnInfo ColumnBarMultipleId { get { return _columnBarMultipleId; } }
        public ColumnInfo ColumnQuxMultipleId { get { return _columnQuxMultipleId; } }

        protected void InitializeColumnInfo() {
            _columnCompoundPkRefNestId = cci("COMPOUND_PK_REF_NEST_ID", "COMPOUND_PK_REF_NEST_ID", null, null, true, "CompoundPkRefNestId", typeof(int?), true, "INT", 10, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnFooMultipleId = cci("FOO_MULTIPLE_ID", "FOO_MULTIPLE_ID", null, null, true, "FooMultipleId", typeof(int?), false, "INT", 10, 0, false, OptimisticLockType.NONE, null, "whiteCompoundPkRefByFooMultipleId", null);
            _columnBarMultipleId = cci("BAR_MULTIPLE_ID", "BAR_MULTIPLE_ID", null, null, true, "BarMultipleId", typeof(int?), false, "INT", 10, 0, false, OptimisticLockType.NONE, null, "whiteCompoundPkRefByQuxMultipleId,whiteCompoundPkRefByFooMultipleId", null);
            _columnQuxMultipleId = cci("QUX_MULTIPLE_ID", "QUX_MULTIPLE_ID", null, null, true, "QuxMultipleId", typeof(int?), false, "INT", 10, 0, false, OptimisticLockType.NONE, null, "whiteCompoundPkRefByQuxMultipleId", null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<ColumnInfo>();
            _columnInfoList.add(ColumnCompoundPkRefNestId);
            _columnInfoList.add(ColumnFooMultipleId);
            _columnInfoList.add(ColumnBarMultipleId);
            _columnInfoList.add(ColumnQuxMultipleId);
        }

        // ===============================================================================
        //                                                                     Unique Info
        //                                                                     ===========
        public override UniqueInfo PrimaryUniqueInfo { get {
            return cpui(ColumnCompoundPkRefNestId);
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
        public ForeignInfo ForeignWhiteCompoundPkRefByQuxMultipleId { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(ColumnBarMultipleId, WhiteCompoundPkRefDbm.GetInstance().ColumnMultipleFirstId);
            map.put(ColumnQuxMultipleId, WhiteCompoundPkRefDbm.GetInstance().ColumnMultipleSecondId);
            return cfi("WhiteCompoundPkRefByQuxMultipleId", this, WhiteCompoundPkRefDbm.GetInstance(), map, 0, false, false);
        }}
        public ForeignInfo ForeignWhiteCompoundPkRefByFooMultipleId { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(ColumnFooMultipleId, WhiteCompoundPkRefDbm.GetInstance().ColumnMultipleFirstId);
            map.put(ColumnBarMultipleId, WhiteCompoundPkRefDbm.GetInstance().ColumnMultipleSecondId);
            return cfi("WhiteCompoundPkRefByFooMultipleId", this, WhiteCompoundPkRefDbm.GetInstance(), map, 1, false, false);
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
        public static readonly String TABLE_DB_NAME = "white_compound_pk_ref_nest";
        public static readonly String TABLE_PROPERTY_NAME = "WhiteCompoundPkRefNest";

        // -------------------------------------------------
        //                                    Column DB-Name
        //                                    --------------
        public static readonly String DB_NAME_COMPOUND_PK_REF_NEST_ID = "COMPOUND_PK_REF_NEST_ID";
        public static readonly String DB_NAME_FOO_MULTIPLE_ID = "FOO_MULTIPLE_ID";
        public static readonly String DB_NAME_BAR_MULTIPLE_ID = "BAR_MULTIPLE_ID";
        public static readonly String DB_NAME_QUX_MULTIPLE_ID = "QUX_MULTIPLE_ID";

        // -------------------------------------------------
        //                              Column Property-Name
        //                              --------------------
        public static readonly String PROPERTY_NAME_COMPOUND_PK_REF_NEST_ID = "CompoundPkRefNestId";
        public static readonly String PROPERTY_NAME_FOO_MULTIPLE_ID = "FooMultipleId";
        public static readonly String PROPERTY_NAME_BAR_MULTIPLE_ID = "BarMultipleId";
        public static readonly String PROPERTY_NAME_QUX_MULTIPLE_ID = "QuxMultipleId";

        // -------------------------------------------------
        //                                      Foreign Name
        //                                      ------------
        public static readonly String FOREIGN_PROPERTY_NAME_WhiteCompoundPkRefByQuxMultipleId = "WhiteCompoundPkRefByQuxMultipleId";
        public static readonly String FOREIGN_PROPERTY_NAME_WhiteCompoundPkRefByFooMultipleId = "WhiteCompoundPkRefByFooMultipleId";
        // -------------------------------------------------
        //                                     Referrer Name
        //                                     -------------

        // -------------------------------------------------
        //                               DB-Property Mapping
        //                               -------------------
        protected static readonly Map<String, String> _dbNamePropertyNameKeyToLowerMap;
        protected static readonly Map<String, String> _propertyNameDbNameKeyToLowerMap;

        static WhiteCompoundPkRefNestDbm() {
            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_DB_NAME.ToLower(), TABLE_PROPERTY_NAME);
                map.put(DB_NAME_COMPOUND_PK_REF_NEST_ID.ToLower(), PROPERTY_NAME_COMPOUND_PK_REF_NEST_ID);
                map.put(DB_NAME_FOO_MULTIPLE_ID.ToLower(), PROPERTY_NAME_FOO_MULTIPLE_ID);
                map.put(DB_NAME_BAR_MULTIPLE_ID.ToLower(), PROPERTY_NAME_BAR_MULTIPLE_ID);
                map.put(DB_NAME_QUX_MULTIPLE_ID.ToLower(), PROPERTY_NAME_QUX_MULTIPLE_ID);
                _dbNamePropertyNameKeyToLowerMap = map;
            }

            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_PROPERTY_NAME.ToLower(), TABLE_DB_NAME);
                map.put(PROPERTY_NAME_COMPOUND_PK_REF_NEST_ID.ToLower(), DB_NAME_COMPOUND_PK_REF_NEST_ID);
                map.put(PROPERTY_NAME_FOO_MULTIPLE_ID.ToLower(), DB_NAME_FOO_MULTIPLE_ID);
                map.put(PROPERTY_NAME_BAR_MULTIPLE_ID.ToLower(), DB_NAME_BAR_MULTIPLE_ID);
                map.put(PROPERTY_NAME_QUX_MULTIPLE_ID.ToLower(), DB_NAME_QUX_MULTIPLE_ID);
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
        public override String EntityTypeName { get { return "DfExample.DBFlute.ExEntity.WhiteCompoundPkRefNest"; } }
        public override String DaoTypeName { get { return "DfExample.DBFlute.ExDao.WhiteCompoundPkRefNestDao"; } }
        public override String ConditionBeanTypeName { get { return "DfExample.DBFlute.CBean.WhiteCompoundPkRefNestCB"; } }
        public override String BehaviorTypeName { get { return "DfExample.DBFlute.ExBhv.WhiteCompoundPkRefNestBhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override Entity NewEntity() { return NewMyEntity(); }
        public WhiteCompoundPkRefNest NewMyEntity() { return new WhiteCompoundPkRefNest(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public WhiteCompoundPkRefNestCB NewMyConditionBean() { return new WhiteCompoundPkRefNestCB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<WhiteCompoundPkRefNest>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<WhiteCompoundPkRefNest>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("COMPOUND_PK_REF_NEST_ID", "CompoundPkRefNestId", new EntityPropertyCompoundPkRefNestIdSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("FOO_MULTIPLE_ID", "FooMultipleId", new EntityPropertyFooMultipleIdSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("BAR_MULTIPLE_ID", "BarMultipleId", new EntityPropertyBarMultipleIdSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("QUX_MULTIPLE_ID", "QuxMultipleId", new EntityPropertyQuxMultipleIdSetupper(), _entityPropertySetupperMap);
        }

        public override bool HasEntityPropertySetupper(String propertyName) {
            return _entityPropertySetupperMap.containsKey(propertyName);
        }

        public override void SetupEntityProperty(String propertyName, Object entity, Object value) {
            EntityPropertySetupper<WhiteCompoundPkRefNest> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((WhiteCompoundPkRefNest)entity, value);
        }

        public class EntityPropertyCompoundPkRefNestIdSetupper : EntityPropertySetupper<WhiteCompoundPkRefNest> {
            public void Setup(WhiteCompoundPkRefNest entity, Object value) { entity.CompoundPkRefNestId = (value != null) ? (int?)value : null; }
        }
        public class EntityPropertyFooMultipleIdSetupper : EntityPropertySetupper<WhiteCompoundPkRefNest> {
            public void Setup(WhiteCompoundPkRefNest entity, Object value) { entity.FooMultipleId = (value != null) ? (int?)value : null; }
        }
        public class EntityPropertyBarMultipleIdSetupper : EntityPropertySetupper<WhiteCompoundPkRefNest> {
            public void Setup(WhiteCompoundPkRefNest entity, Object value) { entity.BarMultipleId = (value != null) ? (int?)value : null; }
        }
        public class EntityPropertyQuxMultipleIdSetupper : EntityPropertySetupper<WhiteCompoundPkRefNest> {
            public void Setup(WhiteCompoundPkRefNest entity, Object value) { entity.QuxMultipleId = (value != null) ? (int?)value : null; }
        }
    }
}

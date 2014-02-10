
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

    public class WhiteAllInOneClsRefDbm : AbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(WhiteAllInOneClsRef);

        private static readonly WhiteAllInOneClsRefDbm _instance = new WhiteAllInOneClsRefDbm();
        private WhiteAllInOneClsRefDbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static WhiteAllInOneClsRefDbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "white_all_in_one_cls_ref"; } }
        public override String TablePropertyName { get { return "WhiteAllInOneClsRef"; } }
        public override String TableSqlName { get { return "white_all_in_one_cls_ref"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected ColumnInfo _columnClsRefId;
        protected ColumnInfo _columnFooCode;
        protected ColumnInfo _columnBarCode;
        protected ColumnInfo _columnQuxCode;

        public ColumnInfo ColumnClsRefId { get { return _columnClsRefId; } }
        public ColumnInfo ColumnFooCode { get { return _columnFooCode; } }
        public ColumnInfo ColumnBarCode { get { return _columnBarCode; } }
        public ColumnInfo ColumnQuxCode { get { return _columnQuxCode; } }

        protected void InitializeColumnInfo() {
            _columnClsRefId = cci("CLS_REF_ID", "CLS_REF_ID", null, null, true, "ClsRefId", typeof(int?), true, "INT", 10, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnFooCode = cci("FOO_CODE", "FOO_CODE", null, null, true, "FooCode", typeof(String), false, "CHAR", 3, 0, false, OptimisticLockType.NONE, null, "whiteAllInOneClsAsFoo", null);
            _columnBarCode = cci("BAR_CODE", "BAR_CODE", null, null, true, "BarCode", typeof(String), false, "CHAR", 3, 0, false, OptimisticLockType.NONE, null, "whiteAllInOneClsAsBar", null);
            _columnQuxCode = cci("QUX_CODE", "QUX_CODE", null, null, true, "QuxCode", typeof(String), false, "CHAR", 3, 0, false, OptimisticLockType.NONE, null, null, null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<ColumnInfo>();
            _columnInfoList.add(ColumnClsRefId);
            _columnInfoList.add(ColumnFooCode);
            _columnInfoList.add(ColumnBarCode);
            _columnInfoList.add(ColumnQuxCode);
        }

        // ===============================================================================
        //                                                                     Unique Info
        //                                                                     ===========
        public override UniqueInfo PrimaryUniqueInfo { get {
            return cpui(ColumnClsRefId);
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
        public ForeignInfo ForeignWhiteAllInOneClsAsFoo { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(ColumnFooCode, WhiteAllInOneClsDbm.GetInstance().ColumnClsElementCode);
            return cfi("WhiteAllInOneClsAsFoo", this, WhiteAllInOneClsDbm.GetInstance(), map, 0, false, false);
        }}
        public ForeignInfo ForeignWhiteAllInOneClsAsBar { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(ColumnBarCode, WhiteAllInOneClsDbm.GetInstance().ColumnClsElementCode);
            return cfi("WhiteAllInOneClsAsBar", this, WhiteAllInOneClsDbm.GetInstance(), map, 1, false, false);
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
        public static readonly String TABLE_DB_NAME = "white_all_in_one_cls_ref";
        public static readonly String TABLE_PROPERTY_NAME = "WhiteAllInOneClsRef";

        // -------------------------------------------------
        //                                    Column DB-Name
        //                                    --------------
        public static readonly String DB_NAME_CLS_REF_ID = "CLS_REF_ID";
        public static readonly String DB_NAME_FOO_CODE = "FOO_CODE";
        public static readonly String DB_NAME_BAR_CODE = "BAR_CODE";
        public static readonly String DB_NAME_QUX_CODE = "QUX_CODE";

        // -------------------------------------------------
        //                              Column Property-Name
        //                              --------------------
        public static readonly String PROPERTY_NAME_CLS_REF_ID = "ClsRefId";
        public static readonly String PROPERTY_NAME_FOO_CODE = "FooCode";
        public static readonly String PROPERTY_NAME_BAR_CODE = "BarCode";
        public static readonly String PROPERTY_NAME_QUX_CODE = "QuxCode";

        // -------------------------------------------------
        //                                      Foreign Name
        //                                      ------------
        public static readonly String FOREIGN_PROPERTY_NAME_WhiteAllInOneClsAsFoo = "WhiteAllInOneClsAsFoo";
        public static readonly String FOREIGN_PROPERTY_NAME_WhiteAllInOneClsAsBar = "WhiteAllInOneClsAsBar";
        // -------------------------------------------------
        //                                     Referrer Name
        //                                     -------------

        // -------------------------------------------------
        //                               DB-Property Mapping
        //                               -------------------
        protected static readonly Map<String, String> _dbNamePropertyNameKeyToLowerMap;
        protected static readonly Map<String, String> _propertyNameDbNameKeyToLowerMap;

        static WhiteAllInOneClsRefDbm() {
            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_DB_NAME.ToLower(), TABLE_PROPERTY_NAME);
                map.put(DB_NAME_CLS_REF_ID.ToLower(), PROPERTY_NAME_CLS_REF_ID);
                map.put(DB_NAME_FOO_CODE.ToLower(), PROPERTY_NAME_FOO_CODE);
                map.put(DB_NAME_BAR_CODE.ToLower(), PROPERTY_NAME_BAR_CODE);
                map.put(DB_NAME_QUX_CODE.ToLower(), PROPERTY_NAME_QUX_CODE);
                _dbNamePropertyNameKeyToLowerMap = map;
            }

            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_PROPERTY_NAME.ToLower(), TABLE_DB_NAME);
                map.put(PROPERTY_NAME_CLS_REF_ID.ToLower(), DB_NAME_CLS_REF_ID);
                map.put(PROPERTY_NAME_FOO_CODE.ToLower(), DB_NAME_FOO_CODE);
                map.put(PROPERTY_NAME_BAR_CODE.ToLower(), DB_NAME_BAR_CODE);
                map.put(PROPERTY_NAME_QUX_CODE.ToLower(), DB_NAME_QUX_CODE);
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
        public override String EntityTypeName { get { return "DfExample.DBFlute.ExEntity.WhiteAllInOneClsRef"; } }
        public override String DaoTypeName { get { return "DfExample.DBFlute.ExDao.WhiteAllInOneClsRefDao"; } }
        public override String ConditionBeanTypeName { get { return "DfExample.DBFlute.CBean.WhiteAllInOneClsRefCB"; } }
        public override String BehaviorTypeName { get { return "DfExample.DBFlute.ExBhv.WhiteAllInOneClsRefBhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override Entity NewEntity() { return NewMyEntity(); }
        public WhiteAllInOneClsRef NewMyEntity() { return new WhiteAllInOneClsRef(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public WhiteAllInOneClsRefCB NewMyConditionBean() { return new WhiteAllInOneClsRefCB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<WhiteAllInOneClsRef>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<WhiteAllInOneClsRef>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("CLS_REF_ID", "ClsRefId", new EntityPropertyClsRefIdSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("FOO_CODE", "FooCode", new EntityPropertyFooCodeSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("BAR_CODE", "BarCode", new EntityPropertyBarCodeSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("QUX_CODE", "QuxCode", new EntityPropertyQuxCodeSetupper(), _entityPropertySetupperMap);
        }

        public override bool HasEntityPropertySetupper(String propertyName) {
            return _entityPropertySetupperMap.containsKey(propertyName);
        }

        public override void SetupEntityProperty(String propertyName, Object entity, Object value) {
            EntityPropertySetupper<WhiteAllInOneClsRef> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((WhiteAllInOneClsRef)entity, value);
        }

        public class EntityPropertyClsRefIdSetupper : EntityPropertySetupper<WhiteAllInOneClsRef> {
            public void Setup(WhiteAllInOneClsRef entity, Object value) { entity.ClsRefId = (value != null) ? (int?)value : null; }
        }
        public class EntityPropertyFooCodeSetupper : EntityPropertySetupper<WhiteAllInOneClsRef> {
            public void Setup(WhiteAllInOneClsRef entity, Object value) { entity.FooCode = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyBarCodeSetupper : EntityPropertySetupper<WhiteAllInOneClsRef> {
            public void Setup(WhiteAllInOneClsRef entity, Object value) { entity.BarCode = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyQuxCodeSetupper : EntityPropertySetupper<WhiteAllInOneClsRef> {
            public void Setup(WhiteAllInOneClsRef entity, Object value) { entity.QuxCode = (value != null) ? (String)value : null; }
        }
    }
}

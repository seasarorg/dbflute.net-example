
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

    public class VdSynonymProductStatusDbm : AbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(VdSynonymProductStatus);

        private static readonly VdSynonymProductStatusDbm _instance = new VdSynonymProductStatusDbm();
        private VdSynonymProductStatusDbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static VdSynonymProductStatusDbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "VD_SYNONYM_PRODUCT_STATUS"; } }
        public override String TablePropertyName { get { return "VdSynonymProductStatus"; } }
        public override String TableSqlName { get { return "VD_SYNONYM_PRODUCT_STATUS"; } }
        public override String TableComment { get { return "商品ステータス"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected ColumnInfo _columnProductStatusCode;
        protected ColumnInfo _columnProductStatusName;

        public ColumnInfo ColumnProductStatusCode { get { return _columnProductStatusCode; } }
        public ColumnInfo ColumnProductStatusName { get { return _columnProductStatusName; } }

        protected void InitializeColumnInfo() {
            _columnProductStatusCode = cci("PRODUCT_STATUS_CODE", "PRODUCT_STATUS_CODE", null, null, true, "ProductStatusCode", typeof(String), true, "CHAR", 3, 0, false, OptimisticLockType.NONE, null, null, "vdSynonymProductList");
            _columnProductStatusName = cci("PRODUCT_STATUS_NAME", "PRODUCT_STATUS_NAME", null, null, true, "ProductStatusName", typeof(String), false, "VARCHAR2", 50, 0, false, OptimisticLockType.NONE, null, null, null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<ColumnInfo>();
            _columnInfoList.add(ColumnProductStatusCode);
            _columnInfoList.add(ColumnProductStatusName);
        }

        // ===============================================================================
        //                                                                     Unique Info
        //                                                                     ===========
        public override UniqueInfo PrimaryUniqueInfo { get {
            return cpui(ColumnProductStatusCode);
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
        public ReferrerInfo ReferrerVdSynonymProductList { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(ColumnProductStatusCode, VdSynonymProductDbm.GetInstance().ColumnProductStatusCode);
            return cri("VdSynonymProductList", this, VdSynonymProductDbm.GetInstance(), map, false);
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
        public static readonly String TABLE_DB_NAME = "VD_SYNONYM_PRODUCT_STATUS";
        public static readonly String TABLE_PROPERTY_NAME = "VdSynonymProductStatus";

        // -------------------------------------------------
        //                                    Column DB-Name
        //                                    --------------
        public static readonly String DB_NAME_PRODUCT_STATUS_CODE = "PRODUCT_STATUS_CODE";
        public static readonly String DB_NAME_PRODUCT_STATUS_NAME = "PRODUCT_STATUS_NAME";

        // -------------------------------------------------
        //                              Column Property-Name
        //                              --------------------
        public static readonly String PROPERTY_NAME_PRODUCT_STATUS_CODE = "ProductStatusCode";
        public static readonly String PROPERTY_NAME_PRODUCT_STATUS_NAME = "ProductStatusName";

        // -------------------------------------------------
        //                                      Foreign Name
        //                                      ------------
        // -------------------------------------------------
        //                                     Referrer Name
        //                                     -------------
        public static readonly String REFERRER_PROPERTY_NAME_VdSynonymProductList = "VdSynonymProductList";

        // -------------------------------------------------
        //                               DB-Property Mapping
        //                               -------------------
        protected static readonly Map<String, String> _dbNamePropertyNameKeyToLowerMap;
        protected static readonly Map<String, String> _propertyNameDbNameKeyToLowerMap;

        static VdSynonymProductStatusDbm() {
            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_DB_NAME.ToLower(), TABLE_PROPERTY_NAME);
                map.put(DB_NAME_PRODUCT_STATUS_CODE.ToLower(), PROPERTY_NAME_PRODUCT_STATUS_CODE);
                map.put(DB_NAME_PRODUCT_STATUS_NAME.ToLower(), PROPERTY_NAME_PRODUCT_STATUS_NAME);
                _dbNamePropertyNameKeyToLowerMap = map;
            }

            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_PROPERTY_NAME.ToLower(), TABLE_DB_NAME);
                map.put(PROPERTY_NAME_PRODUCT_STATUS_CODE.ToLower(), DB_NAME_PRODUCT_STATUS_CODE);
                map.put(PROPERTY_NAME_PRODUCT_STATUS_NAME.ToLower(), DB_NAME_PRODUCT_STATUS_NAME);
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
        public override String EntityTypeName { get { return "DfExample.DBFlute.ExEntity.VdSynonymProductStatus"; } }
        public override String DaoTypeName { get { return "DfExample.DBFlute.ExDao.VdSynonymProductStatusDao"; } }
        public override String ConditionBeanTypeName { get { return "DfExample.DBFlute.CBean.VdSynonymProductStatusCB"; } }
        public override String BehaviorTypeName { get { return "DfExample.DBFlute.ExBhv.VdSynonymProductStatusBhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override Entity NewEntity() { return NewMyEntity(); }
        public VdSynonymProductStatus NewMyEntity() { return new VdSynonymProductStatus(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public VdSynonymProductStatusCB NewMyConditionBean() { return new VdSynonymProductStatusCB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<VdSynonymProductStatus>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<VdSynonymProductStatus>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("PRODUCT_STATUS_CODE", "ProductStatusCode", new EntityPropertyProductStatusCodeSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("PRODUCT_STATUS_NAME", "ProductStatusName", new EntityPropertyProductStatusNameSetupper(), _entityPropertySetupperMap);
        }

        public override bool HasEntityPropertySetupper(String propertyName) {
            return _entityPropertySetupperMap.containsKey(propertyName);
        }

        public override void SetupEntityProperty(String propertyName, Object entity, Object value) {
            EntityPropertySetupper<VdSynonymProductStatus> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((VdSynonymProductStatus)entity, value);
        }

        public class EntityPropertyProductStatusCodeSetupper : EntityPropertySetupper<VdSynonymProductStatus> {
            public void Setup(VdSynonymProductStatus entity, Object value) { entity.ProductStatusCode = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyProductStatusNameSetupper : EntityPropertySetupper<VdSynonymProductStatus> {
            public void Setup(VdSynonymProductStatus entity, Object value) { entity.ProductStatusName = (value != null) ? (String)value : null; }
        }
    }
}

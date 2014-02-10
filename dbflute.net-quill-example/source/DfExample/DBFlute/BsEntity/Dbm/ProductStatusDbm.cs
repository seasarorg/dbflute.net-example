
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

    public class ProductStatusDbm : AbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(ProductStatus);

        private static readonly ProductStatusDbm _instance = new ProductStatusDbm();
        private ProductStatusDbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static ProductStatusDbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "product_status"; } }
        public override String TablePropertyName { get { return "ProductStatus"; } }
        public override String TableSqlName { get { return "product_status"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected ColumnInfo _columnProductStatusCode;
        protected ColumnInfo _columnProductStatusName;

        public ColumnInfo ColumnProductStatusCode { get { return _columnProductStatusCode; } }
        public ColumnInfo ColumnProductStatusName { get { return _columnProductStatusName; } }

        protected void InitializeColumnInfo() {
            _columnProductStatusCode = cci("PRODUCT_STATUS_CODE", "PRODUCT_STATUS_CODE", null, null, true, "ProductStatusCode", typeof(String), true, "CHAR", 3, 0, false, OptimisticLockType.NONE, null, null, "productList");
            _columnProductStatusName = cci("PRODUCT_STATUS_NAME", "PRODUCT_STATUS_NAME", null, null, true, "ProductStatusName", typeof(String), false, "VARCHAR", 50, 0, false, OptimisticLockType.NONE, null, null, null);
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
        public ReferrerInfo ReferrerProductList { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(ColumnProductStatusCode, ProductDbm.GetInstance().ColumnProductStatusCode);
            return cri("ProductList", this, ProductDbm.GetInstance(), map, false);
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
        public static readonly String TABLE_DB_NAME = "product_status";
        public static readonly String TABLE_PROPERTY_NAME = "ProductStatus";

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
        public static readonly String REFERRER_PROPERTY_NAME_ProductList = "ProductList";

        // -------------------------------------------------
        //                               DB-Property Mapping
        //                               -------------------
        protected static readonly Map<String, String> _dbNamePropertyNameKeyToLowerMap;
        protected static readonly Map<String, String> _propertyNameDbNameKeyToLowerMap;

        static ProductStatusDbm() {
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
        public override String EntityTypeName { get { return "DfExample.DBFlute.ExEntity.ProductStatus"; } }
        public override String DaoTypeName { get { return "DfExample.DBFlute.ExDao.ProductStatusDao"; } }
        public override String ConditionBeanTypeName { get { return "DfExample.DBFlute.CBean.ProductStatusCB"; } }
        public override String BehaviorTypeName { get { return "DfExample.DBFlute.ExBhv.ProductStatusBhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override Entity NewEntity() { return NewMyEntity(); }
        public ProductStatus NewMyEntity() { return new ProductStatus(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public ProductStatusCB NewMyConditionBean() { return new ProductStatusCB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<ProductStatus>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<ProductStatus>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("PRODUCT_STATUS_CODE", "ProductStatusCode", new EntityPropertyProductStatusCodeSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("PRODUCT_STATUS_NAME", "ProductStatusName", new EntityPropertyProductStatusNameSetupper(), _entityPropertySetupperMap);
        }

        public override bool HasEntityPropertySetupper(String propertyName) {
            return _entityPropertySetupperMap.containsKey(propertyName);
        }

        public override void SetupEntityProperty(String propertyName, Object entity, Object value) {
            EntityPropertySetupper<ProductStatus> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((ProductStatus)entity, value);
        }

        public class EntityPropertyProductStatusCodeSetupper : EntityPropertySetupper<ProductStatus> {
            public void Setup(ProductStatus entity, Object value) { entity.ProductStatusCode = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyProductStatusNameSetupper : EntityPropertySetupper<ProductStatus> {
            public void Setup(ProductStatus entity, Object value) { entity.ProductStatusName = (value != null) ? (String)value : null; }
        }
    }
}

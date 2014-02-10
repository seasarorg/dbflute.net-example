
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

    public class SummaryProductDbm : AbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(SummaryProduct);

        private static readonly SummaryProductDbm _instance = new SummaryProductDbm();
        private SummaryProductDbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static SummaryProductDbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "summary_product"; } }
        public override String TablePropertyName { get { return "SummaryProduct"; } }
        public override String TableSqlName { get { return "summary_product"; } }
        public override String TableComment { get { return "VIEW"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected ColumnInfo _columnProductId;
        protected ColumnInfo _columnProductName;
        protected ColumnInfo _columnProductHandleCode;
        protected ColumnInfo _columnProductStatusCode;
        protected ColumnInfo _columnLatestPurchaseDatetime;

        public ColumnInfo ColumnProductId { get { return _columnProductId; } }
        public ColumnInfo ColumnProductName { get { return _columnProductName; } }
        public ColumnInfo ColumnProductHandleCode { get { return _columnProductHandleCode; } }
        public ColumnInfo ColumnProductStatusCode { get { return _columnProductStatusCode; } }
        public ColumnInfo ColumnLatestPurchaseDatetime { get { return _columnLatestPurchaseDatetime; } }

        protected void InitializeColumnInfo() {
            _columnProductId = cci("PRODUCT_ID", "PRODUCT_ID", null, null, true, "ProductId", typeof(int?), true, "INT", 10, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnProductName = cci("PRODUCT_NAME", "PRODUCT_NAME", null, null, true, "ProductName", typeof(String), false, "VARCHAR", 50, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnProductHandleCode = cci("PRODUCT_HANDLE_CODE", "PRODUCT_HANDLE_CODE", null, null, true, "ProductHandleCode", typeof(String), false, "VARCHAR", 100, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnProductStatusCode = cci("PRODUCT_STATUS_CODE", "PRODUCT_STATUS_CODE", null, null, true, "ProductStatusCode", typeof(String), false, "CHAR", 3, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnLatestPurchaseDatetime = cci("LATEST_PURCHASE_DATETIME", "LATEST_PURCHASE_DATETIME", null, null, false, "LatestPurchaseDatetime", typeof(DateTime?), false, "DATETIME", 19, 0, false, OptimisticLockType.NONE, null, null, null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<ColumnInfo>();
            _columnInfoList.add(ColumnProductId);
            _columnInfoList.add(ColumnProductName);
            _columnInfoList.add(ColumnProductHandleCode);
            _columnInfoList.add(ColumnProductStatusCode);
            _columnInfoList.add(ColumnLatestPurchaseDatetime);
        }

        // ===============================================================================
        //                                                                     Unique Info
        //                                                                     ===========
        public override UniqueInfo PrimaryUniqueInfo { get {
            return cpui(ColumnProductId);
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
        public static readonly String TABLE_DB_NAME = "summary_product";
        public static readonly String TABLE_PROPERTY_NAME = "SummaryProduct";

        // -------------------------------------------------
        //                                    Column DB-Name
        //                                    --------------
        public static readonly String DB_NAME_PRODUCT_ID = "PRODUCT_ID";
        public static readonly String DB_NAME_PRODUCT_NAME = "PRODUCT_NAME";
        public static readonly String DB_NAME_PRODUCT_HANDLE_CODE = "PRODUCT_HANDLE_CODE";
        public static readonly String DB_NAME_PRODUCT_STATUS_CODE = "PRODUCT_STATUS_CODE";
        public static readonly String DB_NAME_LATEST_PURCHASE_DATETIME = "LATEST_PURCHASE_DATETIME";

        // -------------------------------------------------
        //                              Column Property-Name
        //                              --------------------
        public static readonly String PROPERTY_NAME_PRODUCT_ID = "ProductId";
        public static readonly String PROPERTY_NAME_PRODUCT_NAME = "ProductName";
        public static readonly String PROPERTY_NAME_PRODUCT_HANDLE_CODE = "ProductHandleCode";
        public static readonly String PROPERTY_NAME_PRODUCT_STATUS_CODE = "ProductStatusCode";
        public static readonly String PROPERTY_NAME_LATEST_PURCHASE_DATETIME = "LatestPurchaseDatetime";

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

        static SummaryProductDbm() {
            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_DB_NAME.ToLower(), TABLE_PROPERTY_NAME);
                map.put(DB_NAME_PRODUCT_ID.ToLower(), PROPERTY_NAME_PRODUCT_ID);
                map.put(DB_NAME_PRODUCT_NAME.ToLower(), PROPERTY_NAME_PRODUCT_NAME);
                map.put(DB_NAME_PRODUCT_HANDLE_CODE.ToLower(), PROPERTY_NAME_PRODUCT_HANDLE_CODE);
                map.put(DB_NAME_PRODUCT_STATUS_CODE.ToLower(), PROPERTY_NAME_PRODUCT_STATUS_CODE);
                map.put(DB_NAME_LATEST_PURCHASE_DATETIME.ToLower(), PROPERTY_NAME_LATEST_PURCHASE_DATETIME);
                _dbNamePropertyNameKeyToLowerMap = map;
            }

            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_PROPERTY_NAME.ToLower(), TABLE_DB_NAME);
                map.put(PROPERTY_NAME_PRODUCT_ID.ToLower(), DB_NAME_PRODUCT_ID);
                map.put(PROPERTY_NAME_PRODUCT_NAME.ToLower(), DB_NAME_PRODUCT_NAME);
                map.put(PROPERTY_NAME_PRODUCT_HANDLE_CODE.ToLower(), DB_NAME_PRODUCT_HANDLE_CODE);
                map.put(PROPERTY_NAME_PRODUCT_STATUS_CODE.ToLower(), DB_NAME_PRODUCT_STATUS_CODE);
                map.put(PROPERTY_NAME_LATEST_PURCHASE_DATETIME.ToLower(), DB_NAME_LATEST_PURCHASE_DATETIME);
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
        public override String EntityTypeName { get { return "DfExample.DBFlute.ExEntity.SummaryProduct"; } }
        public override String DaoTypeName { get { return "DfExample.DBFlute.ExDao.SummaryProductDao"; } }
        public override String ConditionBeanTypeName { get { return "DfExample.DBFlute.CBean.SummaryProductCB"; } }
        public override String BehaviorTypeName { get { return "DfExample.DBFlute.ExBhv.SummaryProductBhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override Entity NewEntity() { return NewMyEntity(); }
        public SummaryProduct NewMyEntity() { return new SummaryProduct(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public SummaryProductCB NewMyConditionBean() { return new SummaryProductCB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<SummaryProduct>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<SummaryProduct>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("PRODUCT_ID", "ProductId", new EntityPropertyProductIdSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("PRODUCT_NAME", "ProductName", new EntityPropertyProductNameSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("PRODUCT_HANDLE_CODE", "ProductHandleCode", new EntityPropertyProductHandleCodeSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("PRODUCT_STATUS_CODE", "ProductStatusCode", new EntityPropertyProductStatusCodeSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("LATEST_PURCHASE_DATETIME", "LatestPurchaseDatetime", new EntityPropertyLatestPurchaseDatetimeSetupper(), _entityPropertySetupperMap);
        }

        public override bool HasEntityPropertySetupper(String propertyName) {
            return _entityPropertySetupperMap.containsKey(propertyName);
        }

        public override void SetupEntityProperty(String propertyName, Object entity, Object value) {
            EntityPropertySetupper<SummaryProduct> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((SummaryProduct)entity, value);
        }

        public class EntityPropertyProductIdSetupper : EntityPropertySetupper<SummaryProduct> {
            public void Setup(SummaryProduct entity, Object value) { entity.ProductId = (value != null) ? (int?)value : null; }
        }
        public class EntityPropertyProductNameSetupper : EntityPropertySetupper<SummaryProduct> {
            public void Setup(SummaryProduct entity, Object value) { entity.ProductName = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyProductHandleCodeSetupper : EntityPropertySetupper<SummaryProduct> {
            public void Setup(SummaryProduct entity, Object value) { entity.ProductHandleCode = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyProductStatusCodeSetupper : EntityPropertySetupper<SummaryProduct> {
            public void Setup(SummaryProduct entity, Object value) { entity.ProductStatusCode = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyLatestPurchaseDatetimeSetupper : EntityPropertySetupper<SummaryProduct> {
            public void Setup(SummaryProduct entity, Object value) { entity.LatestPurchaseDatetime = (value != null) ? (DateTime?)value : null; }
        }
    }
}


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

    public class ProductDbm : AbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(Product);

        private static readonly ProductDbm _instance = new ProductDbm();
        private ProductDbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static ProductDbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "PRODUCT"; } }
        public override String TablePropertyName { get { return "Product"; } }
        public override String TableSqlName { get { return "PRODUCT"; } }
        public override String TableAlias { get { return "商品"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected ColumnInfo _columnProductId;
        protected ColumnInfo _columnProductName;
        protected ColumnInfo _columnProductHandleCode;
        protected ColumnInfo _columnProductStatusCode;
        protected ColumnInfo _columnRegisterDatetime;
        protected ColumnInfo _columnRegisterUser;
        protected ColumnInfo _columnRegisterProcess;
        protected ColumnInfo _columnUpdateDatetime;
        protected ColumnInfo _columnUpdateUser;
        protected ColumnInfo _columnUpdateProcess;
        protected ColumnInfo _columnVersionNo;

        public ColumnInfo ColumnProductId { get { return _columnProductId; } }
        public ColumnInfo ColumnProductName { get { return _columnProductName; } }
        public ColumnInfo ColumnProductHandleCode { get { return _columnProductHandleCode; } }
        public ColumnInfo ColumnProductStatusCode { get { return _columnProductStatusCode; } }
        public ColumnInfo ColumnRegisterDatetime { get { return _columnRegisterDatetime; } }
        public ColumnInfo ColumnRegisterUser { get { return _columnRegisterUser; } }
        public ColumnInfo ColumnRegisterProcess { get { return _columnRegisterProcess; } }
        public ColumnInfo ColumnUpdateDatetime { get { return _columnUpdateDatetime; } }
        public ColumnInfo ColumnUpdateUser { get { return _columnUpdateUser; } }
        public ColumnInfo ColumnUpdateProcess { get { return _columnUpdateProcess; } }
        public ColumnInfo ColumnVersionNo { get { return _columnVersionNo; } }

        protected void InitializeColumnInfo() {
            _columnProductId = cci("PRODUCT_ID", "PRODUCT_ID", null, null, true, "ProductId", typeof(long?), true, "NUMBER", 16, 0, false, OptimisticLockType.NONE, null, null, "purchaseList");
            _columnProductName = cci("PRODUCT_NAME", "PRODUCT_NAME", null, null, true, "ProductName", typeof(String), false, "VARCHAR2", 50, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnProductHandleCode = cci("PRODUCT_HANDLE_CODE", "PRODUCT_HANDLE_CODE", null, null, true, "ProductHandleCode", typeof(String), false, "VARCHAR2", 100, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnProductStatusCode = cci("PRODUCT_STATUS_CODE", "PRODUCT_STATUS_CODE", null, null, true, "ProductStatusCode", typeof(String), false, "CHAR", 3, 0, false, OptimisticLockType.NONE, null, "productStatus", null);
            _columnRegisterDatetime = cci("REGISTER_DATETIME", "REGISTER_DATETIME", null, null, true, "RegisterDatetime", typeof(DateTime?), false, "DATE", 7, 0, true, OptimisticLockType.NONE, null, null, null);
            _columnRegisterUser = cci("REGISTER_USER", "REGISTER_USER", null, null, true, "RegisterUser", typeof(String), false, "VARCHAR2", 200, 0, true, OptimisticLockType.NONE, null, null, null);
            _columnRegisterProcess = cci("REGISTER_PROCESS", "REGISTER_PROCESS", null, null, true, "RegisterProcess", typeof(String), false, "VARCHAR2", 200, 0, true, OptimisticLockType.NONE, null, null, null);
            _columnUpdateDatetime = cci("UPDATE_DATETIME", "UPDATE_DATETIME", null, null, true, "UpdateDatetime", typeof(DateTime?), false, "DATE", 7, 0, true, OptimisticLockType.NONE, null, null, null);
            _columnUpdateUser = cci("UPDATE_USER", "UPDATE_USER", null, null, true, "UpdateUser", typeof(String), false, "VARCHAR2", 200, 0, true, OptimisticLockType.NONE, null, null, null);
            _columnUpdateProcess = cci("UPDATE_PROCESS", "UPDATE_PROCESS", null, null, true, "UpdateProcess", typeof(String), false, "VARCHAR2", 200, 0, true, OptimisticLockType.NONE, null, null, null);
            _columnVersionNo = cci("VERSION_NO", "VERSION_NO", null, null, true, "VersionNo", typeof(long?), false, "NUMBER", 16, 0, false, OptimisticLockType.VERSION_NO, null, null, null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<ColumnInfo>();
            _columnInfoList.add(ColumnProductId);
            _columnInfoList.add(ColumnProductName);
            _columnInfoList.add(ColumnProductHandleCode);
            _columnInfoList.add(ColumnProductStatusCode);
            _columnInfoList.add(ColumnRegisterDatetime);
            _columnInfoList.add(ColumnRegisterUser);
            _columnInfoList.add(ColumnRegisterProcess);
            _columnInfoList.add(ColumnUpdateDatetime);
            _columnInfoList.add(ColumnUpdateUser);
            _columnInfoList.add(ColumnUpdateProcess);
            _columnInfoList.add(ColumnVersionNo);
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
        public ForeignInfo ForeignProductStatus { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(ColumnProductStatusCode, ProductStatusDbm.GetInstance().ColumnProductStatusCode);
            return cfi("ProductStatus", this, ProductStatusDbm.GetInstance(), map, 0, false, false);
        }}


        // -------------------------------------------------
        //                                  Referrer Element
        //                                  ----------------
        public ReferrerInfo ReferrerPurchaseList { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(ColumnProductId, PurchaseDbm.GetInstance().ColumnProductId);
            return cri("PurchaseList", this, PurchaseDbm.GetInstance(), map, false);
        }}

        // ===============================================================================
        //                                                                    Various Info
        //                                                                    ============
        public override bool HasSequence { get { return true; } }
        public override String SequenceName { get { return "SEQ_PRODUCT"; } }
        public override String SequenceNextValSql { get { return "select SEQ_PRODUCT.nextval from dual"; } }
        public override int? SequenceIncrementSize { get { return 1; } }
        public override int? SequenceCacheSize { get { return null; } }
        public override bool HasVersionNo { get { return true; } }
        public override ColumnInfo VersionNoColumnInfo { get { return _columnVersionNo; } }
        public override bool HasCommonColumn { get { return true; } }

        // ===============================================================================
        //                                                                 Name Definition
        //                                                                 ===============
        #region Name

        // -------------------------------------------------
        //                                             Table
        //                                             -----
        public static readonly String TABLE_DB_NAME = "PRODUCT";
        public static readonly String TABLE_PROPERTY_NAME = "Product";

        // -------------------------------------------------
        //                                    Column DB-Name
        //                                    --------------
        public static readonly String DB_NAME_PRODUCT_ID = "PRODUCT_ID";
        public static readonly String DB_NAME_PRODUCT_NAME = "PRODUCT_NAME";
        public static readonly String DB_NAME_PRODUCT_HANDLE_CODE = "PRODUCT_HANDLE_CODE";
        public static readonly String DB_NAME_PRODUCT_STATUS_CODE = "PRODUCT_STATUS_CODE";
        public static readonly String DB_NAME_REGISTER_DATETIME = "REGISTER_DATETIME";
        public static readonly String DB_NAME_REGISTER_USER = "REGISTER_USER";
        public static readonly String DB_NAME_REGISTER_PROCESS = "REGISTER_PROCESS";
        public static readonly String DB_NAME_UPDATE_DATETIME = "UPDATE_DATETIME";
        public static readonly String DB_NAME_UPDATE_USER = "UPDATE_USER";
        public static readonly String DB_NAME_UPDATE_PROCESS = "UPDATE_PROCESS";
        public static readonly String DB_NAME_VERSION_NO = "VERSION_NO";

        // -------------------------------------------------
        //                              Column Property-Name
        //                              --------------------
        public static readonly String PROPERTY_NAME_PRODUCT_ID = "ProductId";
        public static readonly String PROPERTY_NAME_PRODUCT_NAME = "ProductName";
        public static readonly String PROPERTY_NAME_PRODUCT_HANDLE_CODE = "ProductHandleCode";
        public static readonly String PROPERTY_NAME_PRODUCT_STATUS_CODE = "ProductStatusCode";
        public static readonly String PROPERTY_NAME_REGISTER_DATETIME = "RegisterDatetime";
        public static readonly String PROPERTY_NAME_REGISTER_USER = "RegisterUser";
        public static readonly String PROPERTY_NAME_REGISTER_PROCESS = "RegisterProcess";
        public static readonly String PROPERTY_NAME_UPDATE_DATETIME = "UpdateDatetime";
        public static readonly String PROPERTY_NAME_UPDATE_USER = "UpdateUser";
        public static readonly String PROPERTY_NAME_UPDATE_PROCESS = "UpdateProcess";
        public static readonly String PROPERTY_NAME_VERSION_NO = "VersionNo";

        // -------------------------------------------------
        //                                      Foreign Name
        //                                      ------------
        public static readonly String FOREIGN_PROPERTY_NAME_ProductStatus = "ProductStatus";
        // -------------------------------------------------
        //                                     Referrer Name
        //                                     -------------
        public static readonly String REFERRER_PROPERTY_NAME_PurchaseList = "PurchaseList";

        // -------------------------------------------------
        //                               DB-Property Mapping
        //                               -------------------
        protected static readonly Map<String, String> _dbNamePropertyNameKeyToLowerMap;
        protected static readonly Map<String, String> _propertyNameDbNameKeyToLowerMap;

        static ProductDbm() {
            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_DB_NAME.ToLower(), TABLE_PROPERTY_NAME);
                map.put(DB_NAME_PRODUCT_ID.ToLower(), PROPERTY_NAME_PRODUCT_ID);
                map.put(DB_NAME_PRODUCT_NAME.ToLower(), PROPERTY_NAME_PRODUCT_NAME);
                map.put(DB_NAME_PRODUCT_HANDLE_CODE.ToLower(), PROPERTY_NAME_PRODUCT_HANDLE_CODE);
                map.put(DB_NAME_PRODUCT_STATUS_CODE.ToLower(), PROPERTY_NAME_PRODUCT_STATUS_CODE);
                map.put(DB_NAME_REGISTER_DATETIME.ToLower(), PROPERTY_NAME_REGISTER_DATETIME);
                map.put(DB_NAME_REGISTER_USER.ToLower(), PROPERTY_NAME_REGISTER_USER);
                map.put(DB_NAME_REGISTER_PROCESS.ToLower(), PROPERTY_NAME_REGISTER_PROCESS);
                map.put(DB_NAME_UPDATE_DATETIME.ToLower(), PROPERTY_NAME_UPDATE_DATETIME);
                map.put(DB_NAME_UPDATE_USER.ToLower(), PROPERTY_NAME_UPDATE_USER);
                map.put(DB_NAME_UPDATE_PROCESS.ToLower(), PROPERTY_NAME_UPDATE_PROCESS);
                map.put(DB_NAME_VERSION_NO.ToLower(), PROPERTY_NAME_VERSION_NO);
                _dbNamePropertyNameKeyToLowerMap = map;
            }

            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_PROPERTY_NAME.ToLower(), TABLE_DB_NAME);
                map.put(PROPERTY_NAME_PRODUCT_ID.ToLower(), DB_NAME_PRODUCT_ID);
                map.put(PROPERTY_NAME_PRODUCT_NAME.ToLower(), DB_NAME_PRODUCT_NAME);
                map.put(PROPERTY_NAME_PRODUCT_HANDLE_CODE.ToLower(), DB_NAME_PRODUCT_HANDLE_CODE);
                map.put(PROPERTY_NAME_PRODUCT_STATUS_CODE.ToLower(), DB_NAME_PRODUCT_STATUS_CODE);
                map.put(PROPERTY_NAME_REGISTER_DATETIME.ToLower(), DB_NAME_REGISTER_DATETIME);
                map.put(PROPERTY_NAME_REGISTER_USER.ToLower(), DB_NAME_REGISTER_USER);
                map.put(PROPERTY_NAME_REGISTER_PROCESS.ToLower(), DB_NAME_REGISTER_PROCESS);
                map.put(PROPERTY_NAME_UPDATE_DATETIME.ToLower(), DB_NAME_UPDATE_DATETIME);
                map.put(PROPERTY_NAME_UPDATE_USER.ToLower(), DB_NAME_UPDATE_USER);
                map.put(PROPERTY_NAME_UPDATE_PROCESS.ToLower(), DB_NAME_UPDATE_PROCESS);
                map.put(PROPERTY_NAME_VERSION_NO.ToLower(), DB_NAME_VERSION_NO);
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
        public override String EntityTypeName { get { return "DfExample.DBFlute.ExEntity.Product"; } }
        public override String DaoTypeName { get { return "DfExample.DBFlute.ExDao.ProductDao"; } }
        public override String ConditionBeanTypeName { get { return "DfExample.DBFlute.CBean.ProductCB"; } }
        public override String BehaviorTypeName { get { return "DfExample.DBFlute.ExBhv.ProductBhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override Entity NewEntity() { return NewMyEntity(); }
        public Product NewMyEntity() { return new Product(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public ProductCB NewMyConditionBean() { return new ProductCB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<Product>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<Product>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("PRODUCT_ID", "ProductId", new EntityPropertyProductIdSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("PRODUCT_NAME", "ProductName", new EntityPropertyProductNameSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("PRODUCT_HANDLE_CODE", "ProductHandleCode", new EntityPropertyProductHandleCodeSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("PRODUCT_STATUS_CODE", "ProductStatusCode", new EntityPropertyProductStatusCodeSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("REGISTER_DATETIME", "RegisterDatetime", new EntityPropertyRegisterDatetimeSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("REGISTER_USER", "RegisterUser", new EntityPropertyRegisterUserSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("REGISTER_PROCESS", "RegisterProcess", new EntityPropertyRegisterProcessSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("UPDATE_DATETIME", "UpdateDatetime", new EntityPropertyUpdateDatetimeSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("UPDATE_USER", "UpdateUser", new EntityPropertyUpdateUserSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("UPDATE_PROCESS", "UpdateProcess", new EntityPropertyUpdateProcessSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("VERSION_NO", "VersionNo", new EntityPropertyVersionNoSetupper(), _entityPropertySetupperMap);
        }

        public override bool HasEntityPropertySetupper(String propertyName) {
            return _entityPropertySetupperMap.containsKey(propertyName);
        }

        public override void SetupEntityProperty(String propertyName, Object entity, Object value) {
            EntityPropertySetupper<Product> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((Product)entity, value);
        }

        public class EntityPropertyProductIdSetupper : EntityPropertySetupper<Product> {
            public void Setup(Product entity, Object value) { entity.ProductId = (value != null) ? (long?)value : null; }
        }
        public class EntityPropertyProductNameSetupper : EntityPropertySetupper<Product> {
            public void Setup(Product entity, Object value) { entity.ProductName = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyProductHandleCodeSetupper : EntityPropertySetupper<Product> {
            public void Setup(Product entity, Object value) { entity.ProductHandleCode = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyProductStatusCodeSetupper : EntityPropertySetupper<Product> {
            public void Setup(Product entity, Object value) { entity.ProductStatusCode = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyRegisterDatetimeSetupper : EntityPropertySetupper<Product> {
            public void Setup(Product entity, Object value) { entity.RegisterDatetime = (value != null) ? (DateTime?)value : null; }
        }
        public class EntityPropertyRegisterUserSetupper : EntityPropertySetupper<Product> {
            public void Setup(Product entity, Object value) { entity.RegisterUser = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyRegisterProcessSetupper : EntityPropertySetupper<Product> {
            public void Setup(Product entity, Object value) { entity.RegisterProcess = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyUpdateDatetimeSetupper : EntityPropertySetupper<Product> {
            public void Setup(Product entity, Object value) { entity.UpdateDatetime = (value != null) ? (DateTime?)value : null; }
        }
        public class EntityPropertyUpdateUserSetupper : EntityPropertySetupper<Product> {
            public void Setup(Product entity, Object value) { entity.UpdateUser = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyUpdateProcessSetupper : EntityPropertySetupper<Product> {
            public void Setup(Product entity, Object value) { entity.UpdateProcess = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyVersionNoSetupper : EntityPropertySetupper<Product> {
            public void Setup(Product entity, Object value) { entity.VersionNo = (value != null) ? (long?)value : null; }
        }
    }
}

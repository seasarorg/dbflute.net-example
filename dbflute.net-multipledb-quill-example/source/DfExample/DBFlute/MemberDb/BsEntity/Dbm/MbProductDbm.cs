
using System;
using System.Reflection;

using DfExample.DBFlute.MemberDb.AllCommon;
using DfExample.DBFlute.MemberDb.AllCommon.CBean;
using DfExample.DBFlute.MemberDb.AllCommon.Dbm;
using DfExample.DBFlute.MemberDb.AllCommon.Dbm.Info;
using DfExample.DBFlute.MemberDb.AllCommon.JavaLike;
using DfExample.DBFlute.MemberDb.ExEntity;

using DfExample.DBFlute.MemberDb.ExDao;
using DfExample.DBFlute.MemberDb.CBean;

namespace DfExample.DBFlute.MemberDb.BsEntity.Dbm {

    public class MbProductDbm : MbAbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(MbProduct);

        private static readonly MbProductDbm _instance = new MbProductDbm();
        private MbProductDbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static MbProductDbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "product"; } }
        public override String TablePropertyName { get { return "Product"; } }
        public override String TableSqlName { get { return "product"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected MbColumnInfo _columnProductId;
        protected MbColumnInfo _columnProductName;
        protected MbColumnInfo _columnProductHandleCode;
        protected MbColumnInfo _columnProductStatusCode;
        protected MbColumnInfo _columnRegisterDatetime;
        protected MbColumnInfo _columnRegisterUser;
        protected MbColumnInfo _columnRegisterProcess;
        protected MbColumnInfo _columnUpdateDatetime;
        protected MbColumnInfo _columnUpdateUser;
        protected MbColumnInfo _columnUpdateProcess;
        protected MbColumnInfo _columnVersionNo;

        public MbColumnInfo ColumnProductId { get { return _columnProductId; } }
        public MbColumnInfo ColumnProductName { get { return _columnProductName; } }
        public MbColumnInfo ColumnProductHandleCode { get { return _columnProductHandleCode; } }
        public MbColumnInfo ColumnProductStatusCode { get { return _columnProductStatusCode; } }
        public MbColumnInfo ColumnRegisterDatetime { get { return _columnRegisterDatetime; } }
        public MbColumnInfo ColumnRegisterUser { get { return _columnRegisterUser; } }
        public MbColumnInfo ColumnRegisterProcess { get { return _columnRegisterProcess; } }
        public MbColumnInfo ColumnUpdateDatetime { get { return _columnUpdateDatetime; } }
        public MbColumnInfo ColumnUpdateUser { get { return _columnUpdateUser; } }
        public MbColumnInfo ColumnUpdateProcess { get { return _columnUpdateProcess; } }
        public MbColumnInfo ColumnVersionNo { get { return _columnVersionNo; } }

        protected void InitializeColumnInfo() {
            _columnProductId = cci("PRODUCT_ID", "PRODUCT_ID", null, null, true, "ProductId", typeof(int?), true, "INT", 10, 0, false, OptimisticLockType.NONE, null, null, "purchaseList");
            _columnProductName = cci("PRODUCT_NAME", "PRODUCT_NAME", null, null, true, "ProductName", typeof(String), false, "VARCHAR", 50, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnProductHandleCode = cci("PRODUCT_HANDLE_CODE", "PRODUCT_HANDLE_CODE", null, null, true, "ProductHandleCode", typeof(String), false, "VARCHAR", 100, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnProductStatusCode = cci("PRODUCT_STATUS_CODE", "PRODUCT_STATUS_CODE", null, null, true, "ProductStatusCode", typeof(String), false, "CHAR", 3, 0, false, OptimisticLockType.NONE, null, "productStatus", null);
            _columnRegisterDatetime = cci("REGISTER_DATETIME", "REGISTER_DATETIME", null, null, true, "RegisterDatetime", typeof(DateTime?), false, "DATETIME", 19, 0, true, OptimisticLockType.NONE, null, null, null);
            _columnRegisterUser = cci("REGISTER_USER", "REGISTER_USER", null, null, true, "RegisterUser", typeof(String), false, "VARCHAR", 200, 0, true, OptimisticLockType.NONE, null, null, null);
            _columnRegisterProcess = cci("REGISTER_PROCESS", "REGISTER_PROCESS", null, null, true, "RegisterProcess", typeof(String), false, "VARCHAR", 200, 0, true, OptimisticLockType.NONE, null, null, null);
            _columnUpdateDatetime = cci("UPDATE_DATETIME", "UPDATE_DATETIME", null, null, true, "UpdateDatetime", typeof(DateTime?), false, "DATETIME", 19, 0, true, OptimisticLockType.NONE, null, null, null);
            _columnUpdateUser = cci("UPDATE_USER", "UPDATE_USER", null, null, true, "UpdateUser", typeof(String), false, "VARCHAR", 200, 0, true, OptimisticLockType.NONE, null, null, null);
            _columnUpdateProcess = cci("UPDATE_PROCESS", "UPDATE_PROCESS", null, null, true, "UpdateProcess", typeof(String), false, "VARCHAR", 200, 0, true, OptimisticLockType.NONE, null, null, null);
            _columnVersionNo = cci("VERSION_NO", "VERSION_NO", null, null, true, "VersionNo", typeof(long?), false, "BIGINT", 19, 0, false, OptimisticLockType.VERSION_NO, null, null, null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<MbColumnInfo>();
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
        public override MbUniqueInfo PrimaryUniqueInfo { get {
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
        public MbForeignInfo ForeignProductStatus { get {
            Map<MbColumnInfo, MbColumnInfo> map = new LinkedHashMap<MbColumnInfo, MbColumnInfo>();
            map.put(ColumnProductStatusCode, MbProductStatusDbm.GetInstance().ColumnProductStatusCode);
            return cfi("ProductStatus", this, MbProductStatusDbm.GetInstance(), map, 0, false, false);
        }}


        // -------------------------------------------------
        //                                  Referrer Element
        //                                  ----------------
        public MbReferrerInfo ReferrerPurchaseList { get {
            Map<MbColumnInfo, MbColumnInfo> map = new LinkedHashMap<MbColumnInfo, MbColumnInfo>();
            map.put(ColumnProductId, MbPurchaseDbm.GetInstance().ColumnProductId);
            return cri("PurchaseList", this, MbPurchaseDbm.GetInstance(), map, false);
        }}

        // ===============================================================================
        //                                                                    Various Info
        //                                                                    ============
        public override bool HasIdentity { get { return true; } }
        public override bool HasVersionNo { get { return true; } }
        public override MbColumnInfo VersionNoColumnInfo { get { return _columnVersionNo; } }
        public override bool HasCommonColumn { get { return true; } }

        // ===============================================================================
        //                                                                 Name Definition
        //                                                                 ===============
        #region Name

        // -------------------------------------------------
        //                                             Table
        //                                             -----
        public static readonly String TABLE_DB_NAME = "product";
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

        static MbProductDbm() {
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
        public override String EntityTypeName { get { return "DfExample.DBFlute.MemberDb.ExEntity.MbProduct"; } }
        public override String DaoTypeName { get { return "DfExample.DBFlute.MemberDb.ExDao.MbProductDao"; } }
        public override String ConditionBeanTypeName { get { return "DfExample.DBFlute.MemberDb.CBean.MbProductCB"; } }
        public override String BehaviorTypeName { get { return "DfExample.DBFlute.MemberDb.ExBhv.MbProductBhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override MbEntity NewEntity() { return NewMyEntity(); }
        public MbProduct NewMyEntity() { return new MbProduct(); }
        public override MbConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public MbProductCB NewMyConditionBean() { return new MbProductCB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<MbProduct>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<MbProduct>>();

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
            EntityPropertySetupper<MbProduct> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((MbProduct)entity, value);
        }

        public class EntityPropertyProductIdSetupper : EntityPropertySetupper<MbProduct> {
            public void Setup(MbProduct entity, Object value) { entity.ProductId = (value != null) ? (int?)value : null; }
        }
        public class EntityPropertyProductNameSetupper : EntityPropertySetupper<MbProduct> {
            public void Setup(MbProduct entity, Object value) { entity.ProductName = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyProductHandleCodeSetupper : EntityPropertySetupper<MbProduct> {
            public void Setup(MbProduct entity, Object value) { entity.ProductHandleCode = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyProductStatusCodeSetupper : EntityPropertySetupper<MbProduct> {
            public void Setup(MbProduct entity, Object value) { entity.ProductStatusCode = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyRegisterDatetimeSetupper : EntityPropertySetupper<MbProduct> {
            public void Setup(MbProduct entity, Object value) { entity.RegisterDatetime = (value != null) ? (DateTime?)value : null; }
        }
        public class EntityPropertyRegisterUserSetupper : EntityPropertySetupper<MbProduct> {
            public void Setup(MbProduct entity, Object value) { entity.RegisterUser = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyRegisterProcessSetupper : EntityPropertySetupper<MbProduct> {
            public void Setup(MbProduct entity, Object value) { entity.RegisterProcess = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyUpdateDatetimeSetupper : EntityPropertySetupper<MbProduct> {
            public void Setup(MbProduct entity, Object value) { entity.UpdateDatetime = (value != null) ? (DateTime?)value : null; }
        }
        public class EntityPropertyUpdateUserSetupper : EntityPropertySetupper<MbProduct> {
            public void Setup(MbProduct entity, Object value) { entity.UpdateUser = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyUpdateProcessSetupper : EntityPropertySetupper<MbProduct> {
            public void Setup(MbProduct entity, Object value) { entity.UpdateProcess = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyVersionNoSetupper : EntityPropertySetupper<MbProduct> {
            public void Setup(MbProduct entity, Object value) { entity.VersionNo = (value != null) ? (long?)value : null; }
        }
    }
}

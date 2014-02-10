
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

    public class MbPurchaseDbm : MbAbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(MbPurchase);

        private static readonly MbPurchaseDbm _instance = new MbPurchaseDbm();
        private MbPurchaseDbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static MbPurchaseDbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "purchase"; } }
        public override String TablePropertyName { get { return "Purchase"; } }
        public override String TableSqlName { get { return "purchase"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected MbColumnInfo _columnPurchaseId;
        protected MbColumnInfo _columnMemberId;
        protected MbColumnInfo _columnProductId;
        protected MbColumnInfo _columnPurchaseDatetime;
        protected MbColumnInfo _columnPurchaseCount;
        protected MbColumnInfo _columnPurchasePrice;
        protected MbColumnInfo _columnPaymentCompleteFlg;
        protected MbColumnInfo _columnRegisterDatetime;
        protected MbColumnInfo _columnRegisterUser;
        protected MbColumnInfo _columnRegisterProcess;
        protected MbColumnInfo _columnUpdateDatetime;
        protected MbColumnInfo _columnUpdateUser;
        protected MbColumnInfo _columnUpdateProcess;
        protected MbColumnInfo _columnVersionNo;

        public MbColumnInfo ColumnPurchaseId { get { return _columnPurchaseId; } }
        public MbColumnInfo ColumnMemberId { get { return _columnMemberId; } }
        public MbColumnInfo ColumnProductId { get { return _columnProductId; } }
        public MbColumnInfo ColumnPurchaseDatetime { get { return _columnPurchaseDatetime; } }
        public MbColumnInfo ColumnPurchaseCount { get { return _columnPurchaseCount; } }
        public MbColumnInfo ColumnPurchasePrice { get { return _columnPurchasePrice; } }
        public MbColumnInfo ColumnPaymentCompleteFlg { get { return _columnPaymentCompleteFlg; } }
        public MbColumnInfo ColumnRegisterDatetime { get { return _columnRegisterDatetime; } }
        public MbColumnInfo ColumnRegisterUser { get { return _columnRegisterUser; } }
        public MbColumnInfo ColumnRegisterProcess { get { return _columnRegisterProcess; } }
        public MbColumnInfo ColumnUpdateDatetime { get { return _columnUpdateDatetime; } }
        public MbColumnInfo ColumnUpdateUser { get { return _columnUpdateUser; } }
        public MbColumnInfo ColumnUpdateProcess { get { return _columnUpdateProcess; } }
        public MbColumnInfo ColumnVersionNo { get { return _columnVersionNo; } }

        protected void InitializeColumnInfo() {
            _columnPurchaseId = cci("PURCHASE_ID", "PURCHASE_ID", null, null, true, "PurchaseId", typeof(long?), true, "BIGINT", 19, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnMemberId = cci("MEMBER_ID", "MEMBER_ID", null, null, true, "MemberId", typeof(int?), false, "INT", 10, 0, false, OptimisticLockType.NONE, null, "member", null);
            _columnProductId = cci("PRODUCT_ID", "PRODUCT_ID", null, null, true, "ProductId", typeof(int?), false, "INT", 10, 0, false, OptimisticLockType.NONE, null, "product", null);
            _columnPurchaseDatetime = cci("PURCHASE_DATETIME", "PURCHASE_DATETIME", null, null, true, "PurchaseDatetime", typeof(DateTime?), false, "DATETIME", 19, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnPurchaseCount = cci("PURCHASE_COUNT", "PURCHASE_COUNT", null, null, true, "PurchaseCount", typeof(int?), false, "INT", 10, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnPurchasePrice = cci("PURCHASE_PRICE", "PURCHASE_PRICE", null, null, true, "PurchasePrice", typeof(int?), false, "INT", 10, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnPaymentCompleteFlg = cci("PAYMENT_COMPLETE_FLG", "PAYMENT_COMPLETE_FLG", null, null, true, "PaymentCompleteFlg", typeof(int?), false, "INT", 10, 0, false, OptimisticLockType.NONE, null, null, null);
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
            _columnInfoList.add(ColumnPurchaseId);
            _columnInfoList.add(ColumnMemberId);
            _columnInfoList.add(ColumnProductId);
            _columnInfoList.add(ColumnPurchaseDatetime);
            _columnInfoList.add(ColumnPurchaseCount);
            _columnInfoList.add(ColumnPurchasePrice);
            _columnInfoList.add(ColumnPaymentCompleteFlg);
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
            return cpui(ColumnPurchaseId);
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
        public MbForeignInfo ForeignMember { get {
            Map<MbColumnInfo, MbColumnInfo> map = new LinkedHashMap<MbColumnInfo, MbColumnInfo>();
            map.put(ColumnMemberId, MbMemberDbm.GetInstance().ColumnMemberId);
            return cfi("Member", this, MbMemberDbm.GetInstance(), map, 0, false, false);
        }}
        public MbForeignInfo ForeignProduct { get {
            Map<MbColumnInfo, MbColumnInfo> map = new LinkedHashMap<MbColumnInfo, MbColumnInfo>();
            map.put(ColumnProductId, MbProductDbm.GetInstance().ColumnProductId);
            return cfi("Product", this, MbProductDbm.GetInstance(), map, 1, false, false);
        }}


        // -------------------------------------------------
        //                                  Referrer Element
        //                                  ----------------

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
        public static readonly String TABLE_DB_NAME = "purchase";
        public static readonly String TABLE_PROPERTY_NAME = "Purchase";

        // -------------------------------------------------
        //                                    Column DB-Name
        //                                    --------------
        public static readonly String DB_NAME_PURCHASE_ID = "PURCHASE_ID";
        public static readonly String DB_NAME_MEMBER_ID = "MEMBER_ID";
        public static readonly String DB_NAME_PRODUCT_ID = "PRODUCT_ID";
        public static readonly String DB_NAME_PURCHASE_DATETIME = "PURCHASE_DATETIME";
        public static readonly String DB_NAME_PURCHASE_COUNT = "PURCHASE_COUNT";
        public static readonly String DB_NAME_PURCHASE_PRICE = "PURCHASE_PRICE";
        public static readonly String DB_NAME_PAYMENT_COMPLETE_FLG = "PAYMENT_COMPLETE_FLG";
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
        public static readonly String PROPERTY_NAME_PURCHASE_ID = "PurchaseId";
        public static readonly String PROPERTY_NAME_MEMBER_ID = "MemberId";
        public static readonly String PROPERTY_NAME_PRODUCT_ID = "ProductId";
        public static readonly String PROPERTY_NAME_PURCHASE_DATETIME = "PurchaseDatetime";
        public static readonly String PROPERTY_NAME_PURCHASE_COUNT = "PurchaseCount";
        public static readonly String PROPERTY_NAME_PURCHASE_PRICE = "PurchasePrice";
        public static readonly String PROPERTY_NAME_PAYMENT_COMPLETE_FLG = "PaymentCompleteFlg";
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
        public static readonly String FOREIGN_PROPERTY_NAME_Member = "Member";
        public static readonly String FOREIGN_PROPERTY_NAME_Product = "Product";
        // -------------------------------------------------
        //                                     Referrer Name
        //                                     -------------

        // -------------------------------------------------
        //                               DB-Property Mapping
        //                               -------------------
        protected static readonly Map<String, String> _dbNamePropertyNameKeyToLowerMap;
        protected static readonly Map<String, String> _propertyNameDbNameKeyToLowerMap;

        static MbPurchaseDbm() {
            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_DB_NAME.ToLower(), TABLE_PROPERTY_NAME);
                map.put(DB_NAME_PURCHASE_ID.ToLower(), PROPERTY_NAME_PURCHASE_ID);
                map.put(DB_NAME_MEMBER_ID.ToLower(), PROPERTY_NAME_MEMBER_ID);
                map.put(DB_NAME_PRODUCT_ID.ToLower(), PROPERTY_NAME_PRODUCT_ID);
                map.put(DB_NAME_PURCHASE_DATETIME.ToLower(), PROPERTY_NAME_PURCHASE_DATETIME);
                map.put(DB_NAME_PURCHASE_COUNT.ToLower(), PROPERTY_NAME_PURCHASE_COUNT);
                map.put(DB_NAME_PURCHASE_PRICE.ToLower(), PROPERTY_NAME_PURCHASE_PRICE);
                map.put(DB_NAME_PAYMENT_COMPLETE_FLG.ToLower(), PROPERTY_NAME_PAYMENT_COMPLETE_FLG);
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
                map.put(PROPERTY_NAME_PURCHASE_ID.ToLower(), DB_NAME_PURCHASE_ID);
                map.put(PROPERTY_NAME_MEMBER_ID.ToLower(), DB_NAME_MEMBER_ID);
                map.put(PROPERTY_NAME_PRODUCT_ID.ToLower(), DB_NAME_PRODUCT_ID);
                map.put(PROPERTY_NAME_PURCHASE_DATETIME.ToLower(), DB_NAME_PURCHASE_DATETIME);
                map.put(PROPERTY_NAME_PURCHASE_COUNT.ToLower(), DB_NAME_PURCHASE_COUNT);
                map.put(PROPERTY_NAME_PURCHASE_PRICE.ToLower(), DB_NAME_PURCHASE_PRICE);
                map.put(PROPERTY_NAME_PAYMENT_COMPLETE_FLG.ToLower(), DB_NAME_PAYMENT_COMPLETE_FLG);
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
        public override String EntityTypeName { get { return "DfExample.DBFlute.MemberDb.ExEntity.MbPurchase"; } }
        public override String DaoTypeName { get { return "DfExample.DBFlute.MemberDb.ExDao.MbPurchaseDao"; } }
        public override String ConditionBeanTypeName { get { return "DfExample.DBFlute.MemberDb.CBean.MbPurchaseCB"; } }
        public override String BehaviorTypeName { get { return "DfExample.DBFlute.MemberDb.ExBhv.MbPurchaseBhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override MbEntity NewEntity() { return NewMyEntity(); }
        public MbPurchase NewMyEntity() { return new MbPurchase(); }
        public override MbConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public MbPurchaseCB NewMyConditionBean() { return new MbPurchaseCB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<MbPurchase>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<MbPurchase>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("PURCHASE_ID", "PurchaseId", new EntityPropertyPurchaseIdSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("MEMBER_ID", "MemberId", new EntityPropertyMemberIdSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("PRODUCT_ID", "ProductId", new EntityPropertyProductIdSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("PURCHASE_DATETIME", "PurchaseDatetime", new EntityPropertyPurchaseDatetimeSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("PURCHASE_COUNT", "PurchaseCount", new EntityPropertyPurchaseCountSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("PURCHASE_PRICE", "PurchasePrice", new EntityPropertyPurchasePriceSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("PAYMENT_COMPLETE_FLG", "PaymentCompleteFlg", new EntityPropertyPaymentCompleteFlgSetupper(), _entityPropertySetupperMap);
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
            EntityPropertySetupper<MbPurchase> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((MbPurchase)entity, value);
        }

        public class EntityPropertyPurchaseIdSetupper : EntityPropertySetupper<MbPurchase> {
            public void Setup(MbPurchase entity, Object value) { entity.PurchaseId = (value != null) ? (long?)value : null; }
        }
        public class EntityPropertyMemberIdSetupper : EntityPropertySetupper<MbPurchase> {
            public void Setup(MbPurchase entity, Object value) { entity.MemberId = (value != null) ? (int?)value : null; }
        }
        public class EntityPropertyProductIdSetupper : EntityPropertySetupper<MbPurchase> {
            public void Setup(MbPurchase entity, Object value) { entity.ProductId = (value != null) ? (int?)value : null; }
        }
        public class EntityPropertyPurchaseDatetimeSetupper : EntityPropertySetupper<MbPurchase> {
            public void Setup(MbPurchase entity, Object value) { entity.PurchaseDatetime = (value != null) ? (DateTime?)value : null; }
        }
        public class EntityPropertyPurchaseCountSetupper : EntityPropertySetupper<MbPurchase> {
            public void Setup(MbPurchase entity, Object value) { entity.PurchaseCount = (value != null) ? (int?)value : null; }
        }
        public class EntityPropertyPurchasePriceSetupper : EntityPropertySetupper<MbPurchase> {
            public void Setup(MbPurchase entity, Object value) { entity.PurchasePrice = (value != null) ? (int?)value : null; }
        }
        public class EntityPropertyPaymentCompleteFlgSetupper : EntityPropertySetupper<MbPurchase> {
            public void Setup(MbPurchase entity, Object value) { entity.PaymentCompleteFlg = (value != null) ? (int?)value : null; }
        }
        public class EntityPropertyRegisterDatetimeSetupper : EntityPropertySetupper<MbPurchase> {
            public void Setup(MbPurchase entity, Object value) { entity.RegisterDatetime = (value != null) ? (DateTime?)value : null; }
        }
        public class EntityPropertyRegisterUserSetupper : EntityPropertySetupper<MbPurchase> {
            public void Setup(MbPurchase entity, Object value) { entity.RegisterUser = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyRegisterProcessSetupper : EntityPropertySetupper<MbPurchase> {
            public void Setup(MbPurchase entity, Object value) { entity.RegisterProcess = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyUpdateDatetimeSetupper : EntityPropertySetupper<MbPurchase> {
            public void Setup(MbPurchase entity, Object value) { entity.UpdateDatetime = (value != null) ? (DateTime?)value : null; }
        }
        public class EntityPropertyUpdateUserSetupper : EntityPropertySetupper<MbPurchase> {
            public void Setup(MbPurchase entity, Object value) { entity.UpdateUser = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyUpdateProcessSetupper : EntityPropertySetupper<MbPurchase> {
            public void Setup(MbPurchase entity, Object value) { entity.UpdateProcess = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyVersionNoSetupper : EntityPropertySetupper<MbPurchase> {
            public void Setup(MbPurchase entity, Object value) { entity.VersionNo = (value != null) ? (long?)value : null; }
        }
    }
}

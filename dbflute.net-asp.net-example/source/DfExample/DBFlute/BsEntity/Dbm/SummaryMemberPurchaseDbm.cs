
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

    public class SummaryMemberPurchaseDbm : AbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(SummaryMemberPurchase);

        private static readonly SummaryMemberPurchaseDbm _instance = new SummaryMemberPurchaseDbm();
        private SummaryMemberPurchaseDbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static SummaryMemberPurchaseDbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "SUMMARY_MEMBER_PURCHASE"; } }
        public override String TablePropertyName { get { return "SummaryMemberPurchase"; } }
        public override String TableSqlName { get { return "SUMMARY_MEMBER_PURCHASE"; } }
        public override String TableComment { get { return "snapshot table for snapshot DFNETEXDB.SUMMARY_MEMBER_PURCHASE"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected ColumnInfo _columnMemberId;
        protected ColumnInfo _columnAllsumPurchasePrice;
        protected ColumnInfo _columnLatestPurchaseDatetime;

        public ColumnInfo ColumnMemberId { get { return _columnMemberId; } }
        public ColumnInfo ColumnAllsumPurchasePrice { get { return _columnAllsumPurchasePrice; } }
        public ColumnInfo ColumnLatestPurchaseDatetime { get { return _columnLatestPurchaseDatetime; } }

        protected void InitializeColumnInfo() {
            _columnMemberId = cci("MEMBER_ID", "MEMBER_ID", null, null, true, "MemberId", typeof(long?), false, "NUMBER", 16, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnAllsumPurchasePrice = cci("ALLSUM_PURCHASE_PRICE", "ALLSUM_PURCHASE_PRICE", null, null, false, "AllsumPurchasePrice", typeof(decimal?), false, "NUMBER", 22, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnLatestPurchaseDatetime = cci("LATEST_PURCHASE_DATETIME", "LATEST_PURCHASE_DATETIME", null, null, false, "LatestPurchaseDatetime", typeof(DateTime?), false, "DATE", 7, 0, false, OptimisticLockType.NONE, null, null, null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<ColumnInfo>();
            _columnInfoList.add(ColumnMemberId);
            _columnInfoList.add(ColumnAllsumPurchasePrice);
            _columnInfoList.add(ColumnLatestPurchaseDatetime);
        }

        // ===============================================================================
        //                                                                     Unique Info
        //                                                                     ===========
        public override UniqueInfo PrimaryUniqueInfo { get {
            throw new NotSupportedException("The table does not have primary key: " + TableDbName);
        }}

        // -------------------------------------------------
        //                                   Primary Element
        //                                   ---------------
        public override bool HasPrimaryKey { get { return false; } }
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
        public static readonly String TABLE_DB_NAME = "SUMMARY_MEMBER_PURCHASE";
        public static readonly String TABLE_PROPERTY_NAME = "SummaryMemberPurchase";

        // -------------------------------------------------
        //                                    Column DB-Name
        //                                    --------------
        public static readonly String DB_NAME_MEMBER_ID = "MEMBER_ID";
        public static readonly String DB_NAME_ALLSUM_PURCHASE_PRICE = "ALLSUM_PURCHASE_PRICE";
        public static readonly String DB_NAME_LATEST_PURCHASE_DATETIME = "LATEST_PURCHASE_DATETIME";

        // -------------------------------------------------
        //                              Column Property-Name
        //                              --------------------
        public static readonly String PROPERTY_NAME_MEMBER_ID = "MemberId";
        public static readonly String PROPERTY_NAME_ALLSUM_PURCHASE_PRICE = "AllsumPurchasePrice";
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

        static SummaryMemberPurchaseDbm() {
            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_DB_NAME.ToLower(), TABLE_PROPERTY_NAME);
                map.put(DB_NAME_MEMBER_ID.ToLower(), PROPERTY_NAME_MEMBER_ID);
                map.put(DB_NAME_ALLSUM_PURCHASE_PRICE.ToLower(), PROPERTY_NAME_ALLSUM_PURCHASE_PRICE);
                map.put(DB_NAME_LATEST_PURCHASE_DATETIME.ToLower(), PROPERTY_NAME_LATEST_PURCHASE_DATETIME);
                _dbNamePropertyNameKeyToLowerMap = map;
            }

            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_PROPERTY_NAME.ToLower(), TABLE_DB_NAME);
                map.put(PROPERTY_NAME_MEMBER_ID.ToLower(), DB_NAME_MEMBER_ID);
                map.put(PROPERTY_NAME_ALLSUM_PURCHASE_PRICE.ToLower(), DB_NAME_ALLSUM_PURCHASE_PRICE);
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
        public override String EntityTypeName { get { return "DfExample.DBFlute.ExEntity.SummaryMemberPurchase"; } }
        public override String DaoTypeName { get { return "DfExample.DBFlute.ExDao.SummaryMemberPurchaseDao"; } }
        public override String ConditionBeanTypeName { get { return "DfExample.DBFlute.CBean.SummaryMemberPurchaseCB"; } }
        public override String BehaviorTypeName { get { return "DfExample.DBFlute.ExBhv.SummaryMemberPurchaseBhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override Entity NewEntity() { return NewMyEntity(); }
        public SummaryMemberPurchase NewMyEntity() { return new SummaryMemberPurchase(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public SummaryMemberPurchaseCB NewMyConditionBean() { return new SummaryMemberPurchaseCB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<SummaryMemberPurchase>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<SummaryMemberPurchase>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("MEMBER_ID", "MemberId", new EntityPropertyMemberIdSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("ALLSUM_PURCHASE_PRICE", "AllsumPurchasePrice", new EntityPropertyAllsumPurchasePriceSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("LATEST_PURCHASE_DATETIME", "LatestPurchaseDatetime", new EntityPropertyLatestPurchaseDatetimeSetupper(), _entityPropertySetupperMap);
        }

        public override bool HasEntityPropertySetupper(String propertyName) {
            return _entityPropertySetupperMap.containsKey(propertyName);
        }

        public override void SetupEntityProperty(String propertyName, Object entity, Object value) {
            EntityPropertySetupper<SummaryMemberPurchase> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((SummaryMemberPurchase)entity, value);
        }

        public class EntityPropertyMemberIdSetupper : EntityPropertySetupper<SummaryMemberPurchase> {
            public void Setup(SummaryMemberPurchase entity, Object value) { entity.MemberId = (value != null) ? (long?)value : null; }
        }
        public class EntityPropertyAllsumPurchasePriceSetupper : EntityPropertySetupper<SummaryMemberPurchase> {
            public void Setup(SummaryMemberPurchase entity, Object value) { entity.AllsumPurchasePrice = (value != null) ? (decimal?)value : null; }
        }
        public class EntityPropertyLatestPurchaseDatetimeSetupper : EntityPropertySetupper<SummaryMemberPurchase> {
            public void Setup(SummaryMemberPurchase entity, Object value) { entity.LatestPurchaseDatetime = (value != null) ? (DateTime?)value : null; }
        }
    }
}

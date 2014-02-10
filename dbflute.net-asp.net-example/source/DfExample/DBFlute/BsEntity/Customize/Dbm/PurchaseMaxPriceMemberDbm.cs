
using System;
using System.Reflection;

using DfExample.DBFlute.AllCommon;
using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.Dbm;
using DfExample.DBFlute.AllCommon.Dbm.Info;
using DfExample.DBFlute.AllCommon.JavaLike;
using DfExample.DBFlute.ExEntity.Customize;
namespace DfExample.DBFlute.BsEntity.Customize.Dbm {

    public class PurchaseMaxPriceMemberDbm : AbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(PurchaseMaxPriceMember);

        private static readonly PurchaseMaxPriceMemberDbm _instance = new PurchaseMaxPriceMemberDbm();
        private PurchaseMaxPriceMemberDbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static PurchaseMaxPriceMemberDbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "PurchaseMaxPriceMember"; } }
        public override String TablePropertyName { get { return "PurchaseMaxPriceMember"; } }
        public override String TableSqlName { get { return "PurchaseMaxPriceMember"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected ColumnInfo _columnMemberId;
        protected ColumnInfo _columnMemberName;
        protected ColumnInfo _columnPurchaseMaxPrice;
        protected ColumnInfo _columnMemberStatusName;
        protected ColumnInfo _columnRn;

        public ColumnInfo ColumnMemberId { get { return _columnMemberId; } }
        public ColumnInfo ColumnMemberName { get { return _columnMemberName; } }
        public ColumnInfo ColumnPurchaseMaxPrice { get { return _columnPurchaseMaxPrice; } }
        public ColumnInfo ColumnMemberStatusName { get { return _columnMemberStatusName; } }
        public ColumnInfo ColumnRn { get { return _columnRn; } }

        protected void InitializeColumnInfo() {
            _columnMemberId = cci("MEMBER_ID", "MEMBER_ID", null, null, false, "MemberId", typeof(long?), false, "NUMBER", 16, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnMemberName = cci("MEMBER_NAME", "MEMBER_NAME", null, null, false, "MemberName", typeof(String), false, "VARCHAR2", 200, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnPurchaseMaxPrice = cci("PURCHASE_MAX_PRICE", "PURCHASE_MAX_PRICE", null, null, false, "PurchaseMaxPrice", typeof(decimal?), false, "NUMBER", 39, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnMemberStatusName = cci("MEMBER_STATUS_NAME", "MEMBER_STATUS_NAME", null, null, false, "MemberStatusName", typeof(String), false, "VARCHAR2", 50, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnRn = cci("RN", "RN", null, null, false, "Rn", typeof(decimal?), false, "NUMBER", 39, 0, false, OptimisticLockType.NONE, null, null, null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<ColumnInfo>();
            _columnInfoList.add(ColumnMemberId);
            _columnInfoList.add(ColumnMemberName);
            _columnInfoList.add(ColumnPurchaseMaxPrice);
            _columnInfoList.add(ColumnMemberStatusName);
            _columnInfoList.add(ColumnRn);
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
        public static readonly String TABLE_DB_NAME = "PurchaseMaxPriceMember";
        public static readonly String TABLE_PROPERTY_NAME = "PurchaseMaxPriceMember";

        // -------------------------------------------------
        //                                    Column DB-Name
        //                                    --------------
        public static readonly String DB_NAME_MEMBER_ID = "MEMBER_ID";
        public static readonly String DB_NAME_MEMBER_NAME = "MEMBER_NAME";
        public static readonly String DB_NAME_PURCHASE_MAX_PRICE = "PURCHASE_MAX_PRICE";
        public static readonly String DB_NAME_MEMBER_STATUS_NAME = "MEMBER_STATUS_NAME";
        public static readonly String DB_NAME_RN = "RN";

        // -------------------------------------------------
        //                              Column Property-Name
        //                              --------------------
        public static readonly String PROPERTY_NAME_MEMBER_ID = "MemberId";
        public static readonly String PROPERTY_NAME_MEMBER_NAME = "MemberName";
        public static readonly String PROPERTY_NAME_PURCHASE_MAX_PRICE = "PurchaseMaxPrice";
        public static readonly String PROPERTY_NAME_MEMBER_STATUS_NAME = "MemberStatusName";
        public static readonly String PROPERTY_NAME_RN = "Rn";

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

        static PurchaseMaxPriceMemberDbm() {
            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_DB_NAME.ToLower(), TABLE_PROPERTY_NAME);
                map.put(DB_NAME_MEMBER_ID.ToLower(), PROPERTY_NAME_MEMBER_ID);
                map.put(DB_NAME_MEMBER_NAME.ToLower(), PROPERTY_NAME_MEMBER_NAME);
                map.put(DB_NAME_PURCHASE_MAX_PRICE.ToLower(), PROPERTY_NAME_PURCHASE_MAX_PRICE);
                map.put(DB_NAME_MEMBER_STATUS_NAME.ToLower(), PROPERTY_NAME_MEMBER_STATUS_NAME);
                map.put(DB_NAME_RN.ToLower(), PROPERTY_NAME_RN);
                _dbNamePropertyNameKeyToLowerMap = map;
            }

            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_PROPERTY_NAME.ToLower(), TABLE_DB_NAME);
                map.put(PROPERTY_NAME_MEMBER_ID.ToLower(), DB_NAME_MEMBER_ID);
                map.put(PROPERTY_NAME_MEMBER_NAME.ToLower(), DB_NAME_MEMBER_NAME);
                map.put(PROPERTY_NAME_PURCHASE_MAX_PRICE.ToLower(), DB_NAME_PURCHASE_MAX_PRICE);
                map.put(PROPERTY_NAME_MEMBER_STATUS_NAME.ToLower(), DB_NAME_MEMBER_STATUS_NAME);
                map.put(PROPERTY_NAME_RN.ToLower(), DB_NAME_RN);
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
        public override String EntityTypeName { get { return "DfExample.DBFlute.ExEntity.Customize.PurchaseMaxPriceMember"; } }
        public override String DaoTypeName { get { return null; } }
        public override String ConditionBeanTypeName { get { return null; } }
        public override String BehaviorTypeName { get { return null; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override Entity NewEntity() { return NewMyEntity(); }
        public PurchaseMaxPriceMember NewMyEntity() { return new PurchaseMaxPriceMember(); }
        public override ConditionBean NewConditionBean() {
            String msg = "The entity does not have condition-bean. So this method is invalid.";
            throw new SystemException(msg + " dbmeta=" + ToString());
        }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<PurchaseMaxPriceMember>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<PurchaseMaxPriceMember>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("MEMBER_ID", "MemberId", new EntityPropertyMemberIdSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("MEMBER_NAME", "MemberName", new EntityPropertyMemberNameSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("PURCHASE_MAX_PRICE", "PurchaseMaxPrice", new EntityPropertyPurchaseMaxPriceSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("MEMBER_STATUS_NAME", "MemberStatusName", new EntityPropertyMemberStatusNameSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("RN", "Rn", new EntityPropertyRnSetupper(), _entityPropertySetupperMap);
        }

        public override bool HasEntityPropertySetupper(String propertyName) {
            return _entityPropertySetupperMap.containsKey(propertyName);
        }

        public override void SetupEntityProperty(String propertyName, Object entity, Object value) {
            EntityPropertySetupper<PurchaseMaxPriceMember> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((PurchaseMaxPriceMember)entity, value);
        }

        public class EntityPropertyMemberIdSetupper : EntityPropertySetupper<PurchaseMaxPriceMember> {
            public void Setup(PurchaseMaxPriceMember entity, Object value) { entity.MemberId = (value != null) ? (long?)value : null; }
        }
        public class EntityPropertyMemberNameSetupper : EntityPropertySetupper<PurchaseMaxPriceMember> {
            public void Setup(PurchaseMaxPriceMember entity, Object value) { entity.MemberName = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyPurchaseMaxPriceSetupper : EntityPropertySetupper<PurchaseMaxPriceMember> {
            public void Setup(PurchaseMaxPriceMember entity, Object value) { entity.PurchaseMaxPrice = (value != null) ? (decimal?)value : null; }
        }
        public class EntityPropertyMemberStatusNameSetupper : EntityPropertySetupper<PurchaseMaxPriceMember> {
            public void Setup(PurchaseMaxPriceMember entity, Object value) { entity.MemberStatusName = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyRnSetupper : EntityPropertySetupper<PurchaseMaxPriceMember> {
            public void Setup(PurchaseMaxPriceMember entity, Object value) { entity.Rn = (value != null) ? (decimal?)value : null; }
        }
    }
}

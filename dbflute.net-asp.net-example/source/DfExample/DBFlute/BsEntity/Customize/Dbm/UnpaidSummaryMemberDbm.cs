
using System;
using System.Reflection;

using DfExample.DBFlute.AllCommon;
using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.Dbm;
using DfExample.DBFlute.AllCommon.Dbm.Info;
using DfExample.DBFlute.AllCommon.JavaLike;
using DfExample.DBFlute.ExEntity.Customize;
namespace DfExample.DBFlute.BsEntity.Customize.Dbm {

    public class UnpaidSummaryMemberDbm : AbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(UnpaidSummaryMember);

        private static readonly UnpaidSummaryMemberDbm _instance = new UnpaidSummaryMemberDbm();
        private UnpaidSummaryMemberDbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static UnpaidSummaryMemberDbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "UnpaidSummaryMember"; } }
        public override String TablePropertyName { get { return "UnpaidSummaryMember"; } }
        public override String TableSqlName { get { return "UnpaidSummaryMember"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected ColumnInfo _columnMemberId;
        protected ColumnInfo _columnMemberName;
        protected ColumnInfo _columnUnpaidPriceSummary;
        protected ColumnInfo _columnMemberStatusName;

        public ColumnInfo ColumnMemberId { get { return _columnMemberId; } }
        public ColumnInfo ColumnMemberName { get { return _columnMemberName; } }
        public ColumnInfo ColumnUnpaidPriceSummary { get { return _columnUnpaidPriceSummary; } }
        public ColumnInfo ColumnMemberStatusName { get { return _columnMemberStatusName; } }

        protected void InitializeColumnInfo() {
            _columnMemberId = cci("MEMBER_ID", "MEMBER_ID", null, null, false, "MemberId", typeof(long?), false, "NUMBER", 16, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnMemberName = cci("MEMBER_NAME", "MEMBER_NAME", null, null, false, "MemberName", typeof(String), false, "VARCHAR2", 200, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnUnpaidPriceSummary = cci("UNPAID_PRICE_SUMMARY", "UNPAID_PRICE_SUMMARY", null, null, false, "UnpaidPriceSummary", typeof(decimal?), false, "NUMBER", 22, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnMemberStatusName = cci("MEMBER_STATUS_NAME", "MEMBER_STATUS_NAME", null, null, false, "MemberStatusName", typeof(String), false, "VARCHAR2", 50, 0, false, OptimisticLockType.NONE, null, null, null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<ColumnInfo>();
            _columnInfoList.add(ColumnMemberId);
            _columnInfoList.add(ColumnMemberName);
            _columnInfoList.add(ColumnUnpaidPriceSummary);
            _columnInfoList.add(ColumnMemberStatusName);
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
        public static readonly String TABLE_DB_NAME = "UnpaidSummaryMember";
        public static readonly String TABLE_PROPERTY_NAME = "UnpaidSummaryMember";

        // -------------------------------------------------
        //                                    Column DB-Name
        //                                    --------------
        public static readonly String DB_NAME_MEMBER_ID = "MEMBER_ID";
        public static readonly String DB_NAME_MEMBER_NAME = "MEMBER_NAME";
        public static readonly String DB_NAME_UNPAID_PRICE_SUMMARY = "UNPAID_PRICE_SUMMARY";
        public static readonly String DB_NAME_MEMBER_STATUS_NAME = "MEMBER_STATUS_NAME";

        // -------------------------------------------------
        //                              Column Property-Name
        //                              --------------------
        public static readonly String PROPERTY_NAME_MEMBER_ID = "MemberId";
        public static readonly String PROPERTY_NAME_MEMBER_NAME = "MemberName";
        public static readonly String PROPERTY_NAME_UNPAID_PRICE_SUMMARY = "UnpaidPriceSummary";
        public static readonly String PROPERTY_NAME_MEMBER_STATUS_NAME = "MemberStatusName";

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

        static UnpaidSummaryMemberDbm() {
            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_DB_NAME.ToLower(), TABLE_PROPERTY_NAME);
                map.put(DB_NAME_MEMBER_ID.ToLower(), PROPERTY_NAME_MEMBER_ID);
                map.put(DB_NAME_MEMBER_NAME.ToLower(), PROPERTY_NAME_MEMBER_NAME);
                map.put(DB_NAME_UNPAID_PRICE_SUMMARY.ToLower(), PROPERTY_NAME_UNPAID_PRICE_SUMMARY);
                map.put(DB_NAME_MEMBER_STATUS_NAME.ToLower(), PROPERTY_NAME_MEMBER_STATUS_NAME);
                _dbNamePropertyNameKeyToLowerMap = map;
            }

            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_PROPERTY_NAME.ToLower(), TABLE_DB_NAME);
                map.put(PROPERTY_NAME_MEMBER_ID.ToLower(), DB_NAME_MEMBER_ID);
                map.put(PROPERTY_NAME_MEMBER_NAME.ToLower(), DB_NAME_MEMBER_NAME);
                map.put(PROPERTY_NAME_UNPAID_PRICE_SUMMARY.ToLower(), DB_NAME_UNPAID_PRICE_SUMMARY);
                map.put(PROPERTY_NAME_MEMBER_STATUS_NAME.ToLower(), DB_NAME_MEMBER_STATUS_NAME);
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
        public override String EntityTypeName { get { return "DfExample.DBFlute.ExEntity.Customize.UnpaidSummaryMember"; } }
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
        public UnpaidSummaryMember NewMyEntity() { return new UnpaidSummaryMember(); }
        public override ConditionBean NewConditionBean() {
            String msg = "The entity does not have condition-bean. So this method is invalid.";
            throw new SystemException(msg + " dbmeta=" + ToString());
        }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<UnpaidSummaryMember>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<UnpaidSummaryMember>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("MEMBER_ID", "MemberId", new EntityPropertyMemberIdSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("MEMBER_NAME", "MemberName", new EntityPropertyMemberNameSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("UNPAID_PRICE_SUMMARY", "UnpaidPriceSummary", new EntityPropertyUnpaidPriceSummarySetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("MEMBER_STATUS_NAME", "MemberStatusName", new EntityPropertyMemberStatusNameSetupper(), _entityPropertySetupperMap);
        }

        public override bool HasEntityPropertySetupper(String propertyName) {
            return _entityPropertySetupperMap.containsKey(propertyName);
        }

        public override void SetupEntityProperty(String propertyName, Object entity, Object value) {
            EntityPropertySetupper<UnpaidSummaryMember> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((UnpaidSummaryMember)entity, value);
        }

        public class EntityPropertyMemberIdSetupper : EntityPropertySetupper<UnpaidSummaryMember> {
            public void Setup(UnpaidSummaryMember entity, Object value) { entity.MemberId = (value != null) ? (long?)value : null; }
        }
        public class EntityPropertyMemberNameSetupper : EntityPropertySetupper<UnpaidSummaryMember> {
            public void Setup(UnpaidSummaryMember entity, Object value) { entity.MemberName = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyUnpaidPriceSummarySetupper : EntityPropertySetupper<UnpaidSummaryMember> {
            public void Setup(UnpaidSummaryMember entity, Object value) { entity.UnpaidPriceSummary = (value != null) ? (decimal?)value : null; }
        }
        public class EntityPropertyMemberStatusNameSetupper : EntityPropertySetupper<UnpaidSummaryMember> {
            public void Setup(UnpaidSummaryMember entity, Object value) { entity.MemberStatusName = (value != null) ? (String)value : null; }
        }
    }
}

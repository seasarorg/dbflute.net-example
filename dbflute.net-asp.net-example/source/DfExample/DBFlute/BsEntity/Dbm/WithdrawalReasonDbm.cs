
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

    public class WithdrawalReasonDbm : AbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(WithdrawalReason);

        private static readonly WithdrawalReasonDbm _instance = new WithdrawalReasonDbm();
        private WithdrawalReasonDbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static WithdrawalReasonDbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "WITHDRAWAL_REASON"; } }
        public override String TablePropertyName { get { return "WithdrawalReason"; } }
        public override String TableSqlName { get { return "WITHDRAWAL_REASON"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected ColumnInfo _columnWithdrawalReasonCode;
        protected ColumnInfo _columnWithdrawalReasonText;
        protected ColumnInfo _columnDisplayOrder;

        public ColumnInfo ColumnWithdrawalReasonCode { get { return _columnWithdrawalReasonCode; } }
        public ColumnInfo ColumnWithdrawalReasonText { get { return _columnWithdrawalReasonText; } }
        public ColumnInfo ColumnDisplayOrder { get { return _columnDisplayOrder; } }

        protected void InitializeColumnInfo() {
            _columnWithdrawalReasonCode = cci("WITHDRAWAL_REASON_CODE", "WITHDRAWAL_REASON_CODE", null, null, true, "WithdrawalReasonCode", typeof(String), true, "CHAR", 3, 0, false, OptimisticLockType.NONE, null, null, "memberWithdrawalList,vdSynonymMemberWithdrawalList");
            _columnWithdrawalReasonText = cci("WITHDRAWAL_REASON_TEXT", "WITHDRAWAL_REASON_TEXT", null, null, true, "WithdrawalReasonText", typeof(String), false, "CLOB", 4000, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnDisplayOrder = cci("DISPLAY_ORDER", "DISPLAY_ORDER", null, null, true, "DisplayOrder", typeof(long?), false, "NUMBER", 16, 0, false, OptimisticLockType.NONE, null, null, null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<ColumnInfo>();
            _columnInfoList.add(ColumnWithdrawalReasonCode);
            _columnInfoList.add(ColumnWithdrawalReasonText);
            _columnInfoList.add(ColumnDisplayOrder);
        }

        // ===============================================================================
        //                                                                     Unique Info
        //                                                                     ===========
        public override UniqueInfo PrimaryUniqueInfo { get {
            return cpui(ColumnWithdrawalReasonCode);
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
        public ReferrerInfo ReferrerMemberWithdrawalList { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(ColumnWithdrawalReasonCode, MemberWithdrawalDbm.GetInstance().ColumnWithdrawalReasonCode);
            return cri("MemberWithdrawalList", this, MemberWithdrawalDbm.GetInstance(), map, false);
        }}
        public ReferrerInfo ReferrerVdSynonymMemberWithdrawalList { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(ColumnWithdrawalReasonCode, VdSynonymMemberWithdrawalDbm.GetInstance().ColumnWithdrawalReasonCode);
            return cri("VdSynonymMemberWithdrawalList", this, VdSynonymMemberWithdrawalDbm.GetInstance(), map, false);
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
        public static readonly String TABLE_DB_NAME = "WITHDRAWAL_REASON";
        public static readonly String TABLE_PROPERTY_NAME = "WithdrawalReason";

        // -------------------------------------------------
        //                                    Column DB-Name
        //                                    --------------
        public static readonly String DB_NAME_WITHDRAWAL_REASON_CODE = "WITHDRAWAL_REASON_CODE";
        public static readonly String DB_NAME_WITHDRAWAL_REASON_TEXT = "WITHDRAWAL_REASON_TEXT";
        public static readonly String DB_NAME_DISPLAY_ORDER = "DISPLAY_ORDER";

        // -------------------------------------------------
        //                              Column Property-Name
        //                              --------------------
        public static readonly String PROPERTY_NAME_WITHDRAWAL_REASON_CODE = "WithdrawalReasonCode";
        public static readonly String PROPERTY_NAME_WITHDRAWAL_REASON_TEXT = "WithdrawalReasonText";
        public static readonly String PROPERTY_NAME_DISPLAY_ORDER = "DisplayOrder";

        // -------------------------------------------------
        //                                      Foreign Name
        //                                      ------------
        // -------------------------------------------------
        //                                     Referrer Name
        //                                     -------------
        public static readonly String REFERRER_PROPERTY_NAME_MemberWithdrawalList = "MemberWithdrawalList";
        public static readonly String REFERRER_PROPERTY_NAME_VdSynonymMemberWithdrawalList = "VdSynonymMemberWithdrawalList";

        // -------------------------------------------------
        //                               DB-Property Mapping
        //                               -------------------
        protected static readonly Map<String, String> _dbNamePropertyNameKeyToLowerMap;
        protected static readonly Map<String, String> _propertyNameDbNameKeyToLowerMap;

        static WithdrawalReasonDbm() {
            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_DB_NAME.ToLower(), TABLE_PROPERTY_NAME);
                map.put(DB_NAME_WITHDRAWAL_REASON_CODE.ToLower(), PROPERTY_NAME_WITHDRAWAL_REASON_CODE);
                map.put(DB_NAME_WITHDRAWAL_REASON_TEXT.ToLower(), PROPERTY_NAME_WITHDRAWAL_REASON_TEXT);
                map.put(DB_NAME_DISPLAY_ORDER.ToLower(), PROPERTY_NAME_DISPLAY_ORDER);
                _dbNamePropertyNameKeyToLowerMap = map;
            }

            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_PROPERTY_NAME.ToLower(), TABLE_DB_NAME);
                map.put(PROPERTY_NAME_WITHDRAWAL_REASON_CODE.ToLower(), DB_NAME_WITHDRAWAL_REASON_CODE);
                map.put(PROPERTY_NAME_WITHDRAWAL_REASON_TEXT.ToLower(), DB_NAME_WITHDRAWAL_REASON_TEXT);
                map.put(PROPERTY_NAME_DISPLAY_ORDER.ToLower(), DB_NAME_DISPLAY_ORDER);
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
        public override String EntityTypeName { get { return "DfExample.DBFlute.ExEntity.WithdrawalReason"; } }
        public override String DaoTypeName { get { return "DfExample.DBFlute.ExDao.WithdrawalReasonDao"; } }
        public override String ConditionBeanTypeName { get { return "DfExample.DBFlute.CBean.WithdrawalReasonCB"; } }
        public override String BehaviorTypeName { get { return "DfExample.DBFlute.ExBhv.WithdrawalReasonBhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override Entity NewEntity() { return NewMyEntity(); }
        public WithdrawalReason NewMyEntity() { return new WithdrawalReason(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public WithdrawalReasonCB NewMyConditionBean() { return new WithdrawalReasonCB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<WithdrawalReason>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<WithdrawalReason>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("WITHDRAWAL_REASON_CODE", "WithdrawalReasonCode", new EntityPropertyWithdrawalReasonCodeSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("WITHDRAWAL_REASON_TEXT", "WithdrawalReasonText", new EntityPropertyWithdrawalReasonTextSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("DISPLAY_ORDER", "DisplayOrder", new EntityPropertyDisplayOrderSetupper(), _entityPropertySetupperMap);
        }

        public override bool HasEntityPropertySetupper(String propertyName) {
            return _entityPropertySetupperMap.containsKey(propertyName);
        }

        public override void SetupEntityProperty(String propertyName, Object entity, Object value) {
            EntityPropertySetupper<WithdrawalReason> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((WithdrawalReason)entity, value);
        }

        public class EntityPropertyWithdrawalReasonCodeSetupper : EntityPropertySetupper<WithdrawalReason> {
            public void Setup(WithdrawalReason entity, Object value) { entity.WithdrawalReasonCode = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyWithdrawalReasonTextSetupper : EntityPropertySetupper<WithdrawalReason> {
            public void Setup(WithdrawalReason entity, Object value) { entity.WithdrawalReasonText = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyDisplayOrderSetupper : EntityPropertySetupper<WithdrawalReason> {
            public void Setup(WithdrawalReason entity, Object value) { entity.DisplayOrder = (value != null) ? (long?)value : null; }
        }
    }
}

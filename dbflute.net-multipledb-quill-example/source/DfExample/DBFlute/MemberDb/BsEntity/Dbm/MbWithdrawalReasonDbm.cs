
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

    public class MbWithdrawalReasonDbm : MbAbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(MbWithdrawalReason);

        private static readonly MbWithdrawalReasonDbm _instance = new MbWithdrawalReasonDbm();
        private MbWithdrawalReasonDbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static MbWithdrawalReasonDbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "withdrawal_reason"; } }
        public override String TablePropertyName { get { return "WithdrawalReason"; } }
        public override String TableSqlName { get { return "withdrawal_reason"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected MbColumnInfo _columnWithdrawalReasonCode;
        protected MbColumnInfo _columnWithdrawalReasonText;
        protected MbColumnInfo _columnDisplayOrder;

        public MbColumnInfo ColumnWithdrawalReasonCode { get { return _columnWithdrawalReasonCode; } }
        public MbColumnInfo ColumnWithdrawalReasonText { get { return _columnWithdrawalReasonText; } }
        public MbColumnInfo ColumnDisplayOrder { get { return _columnDisplayOrder; } }

        protected void InitializeColumnInfo() {
            _columnWithdrawalReasonCode = cci("WITHDRAWAL_REASON_CODE", "WITHDRAWAL_REASON_CODE", null, null, true, "WithdrawalReasonCode", typeof(String), true, "CHAR", 3, 0, false, OptimisticLockType.NONE, null, null, "memberWithdrawalList");
            _columnWithdrawalReasonText = cci("WITHDRAWAL_REASON_TEXT", "WITHDRAWAL_REASON_TEXT", null, null, true, "WithdrawalReasonText", typeof(String), false, "TEXT", 65535, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnDisplayOrder = cci("DISPLAY_ORDER", "DISPLAY_ORDER", null, null, true, "DisplayOrder", typeof(int?), false, "INT", 10, 0, false, OptimisticLockType.NONE, null, null, null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<MbColumnInfo>();
            _columnInfoList.add(ColumnWithdrawalReasonCode);
            _columnInfoList.add(ColumnWithdrawalReasonText);
            _columnInfoList.add(ColumnDisplayOrder);
        }

        // ===============================================================================
        //                                                                     Unique Info
        //                                                                     ===========
        public override MbUniqueInfo PrimaryUniqueInfo { get {
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
        public MbReferrerInfo ReferrerMemberWithdrawalList { get {
            Map<MbColumnInfo, MbColumnInfo> map = new LinkedHashMap<MbColumnInfo, MbColumnInfo>();
            map.put(ColumnWithdrawalReasonCode, MbMemberWithdrawalDbm.GetInstance().ColumnWithdrawalReasonCode);
            return cri("MemberWithdrawalList", this, MbMemberWithdrawalDbm.GetInstance(), map, false);
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
        public static readonly String TABLE_DB_NAME = "withdrawal_reason";
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

        // -------------------------------------------------
        //                               DB-Property Mapping
        //                               -------------------
        protected static readonly Map<String, String> _dbNamePropertyNameKeyToLowerMap;
        protected static readonly Map<String, String> _propertyNameDbNameKeyToLowerMap;

        static MbWithdrawalReasonDbm() {
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
        public override String EntityTypeName { get { return "DfExample.DBFlute.MemberDb.ExEntity.MbWithdrawalReason"; } }
        public override String DaoTypeName { get { return "DfExample.DBFlute.MemberDb.ExDao.MbWithdrawalReasonDao"; } }
        public override String ConditionBeanTypeName { get { return "DfExample.DBFlute.MemberDb.CBean.MbWithdrawalReasonCB"; } }
        public override String BehaviorTypeName { get { return "DfExample.DBFlute.MemberDb.ExBhv.MbWithdrawalReasonBhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override MbEntity NewEntity() { return NewMyEntity(); }
        public MbWithdrawalReason NewMyEntity() { return new MbWithdrawalReason(); }
        public override MbConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public MbWithdrawalReasonCB NewMyConditionBean() { return new MbWithdrawalReasonCB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<MbWithdrawalReason>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<MbWithdrawalReason>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("WITHDRAWAL_REASON_CODE", "WithdrawalReasonCode", new EntityPropertyWithdrawalReasonCodeSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("WITHDRAWAL_REASON_TEXT", "WithdrawalReasonText", new EntityPropertyWithdrawalReasonTextSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("DISPLAY_ORDER", "DisplayOrder", new EntityPropertyDisplayOrderSetupper(), _entityPropertySetupperMap);
        }

        public override bool HasEntityPropertySetupper(String propertyName) {
            return _entityPropertySetupperMap.containsKey(propertyName);
        }

        public override void SetupEntityProperty(String propertyName, Object entity, Object value) {
            EntityPropertySetupper<MbWithdrawalReason> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((MbWithdrawalReason)entity, value);
        }

        public class EntityPropertyWithdrawalReasonCodeSetupper : EntityPropertySetupper<MbWithdrawalReason> {
            public void Setup(MbWithdrawalReason entity, Object value) { entity.WithdrawalReasonCode = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyWithdrawalReasonTextSetupper : EntityPropertySetupper<MbWithdrawalReason> {
            public void Setup(MbWithdrawalReason entity, Object value) { entity.WithdrawalReasonText = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyDisplayOrderSetupper : EntityPropertySetupper<MbWithdrawalReason> {
            public void Setup(MbWithdrawalReason entity, Object value) { entity.DisplayOrder = (value != null) ? (int?)value : null; }
        }
    }
}

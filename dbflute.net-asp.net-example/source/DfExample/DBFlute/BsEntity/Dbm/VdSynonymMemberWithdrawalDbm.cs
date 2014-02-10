
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

    public class VdSynonymMemberWithdrawalDbm : AbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(VdSynonymMemberWithdrawal);

        private static readonly VdSynonymMemberWithdrawalDbm _instance = new VdSynonymMemberWithdrawalDbm();
        private VdSynonymMemberWithdrawalDbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static VdSynonymMemberWithdrawalDbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "VD_SYNONYM_MEMBER_WITHDRAWAL"; } }
        public override String TablePropertyName { get { return "VdSynonymMemberWithdrawal"; } }
        public override String TableSqlName { get { return "VD_SYNONYM_MEMBER_WITHDRAWAL"; } }
        public override String TableComment { get { return "退会するとInsertされる"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected ColumnInfo _columnMemberId;
        protected ColumnInfo _columnWithdrawalReasonCode;
        protected ColumnInfo _columnWithdrawalReasonInputText;
        protected ColumnInfo _columnWithdrawalDatetime;
        protected ColumnInfo _columnRegisterDatetime;
        protected ColumnInfo _columnRegisterProcess;
        protected ColumnInfo _columnRegisterUser;
        protected ColumnInfo _columnUpdateDatetime;
        protected ColumnInfo _columnUpdateProcess;
        protected ColumnInfo _columnUpdateUser;
        protected ColumnInfo _columnVersionNo;

        public ColumnInfo ColumnMemberId { get { return _columnMemberId; } }
        public ColumnInfo ColumnWithdrawalReasonCode { get { return _columnWithdrawalReasonCode; } }
        public ColumnInfo ColumnWithdrawalReasonInputText { get { return _columnWithdrawalReasonInputText; } }
        public ColumnInfo ColumnWithdrawalDatetime { get { return _columnWithdrawalDatetime; } }
        public ColumnInfo ColumnRegisterDatetime { get { return _columnRegisterDatetime; } }
        public ColumnInfo ColumnRegisterProcess { get { return _columnRegisterProcess; } }
        public ColumnInfo ColumnRegisterUser { get { return _columnRegisterUser; } }
        public ColumnInfo ColumnUpdateDatetime { get { return _columnUpdateDatetime; } }
        public ColumnInfo ColumnUpdateProcess { get { return _columnUpdateProcess; } }
        public ColumnInfo ColumnUpdateUser { get { return _columnUpdateUser; } }
        public ColumnInfo ColumnVersionNo { get { return _columnVersionNo; } }

        protected void InitializeColumnInfo() {
            _columnMemberId = cci("MEMBER_ID", "MEMBER_ID", null, null, true, "MemberId", typeof(long?), true, "NUMBER", 16, 0, false, OptimisticLockType.NONE, null, "memberVendorSynonym,vdSynonymMember,vendorSynonymMember", null);
            _columnWithdrawalReasonCode = cci("WITHDRAWAL_REASON_CODE", "WITHDRAWAL_REASON_CODE", null, null, false, "WithdrawalReasonCode", typeof(String), false, "CHAR", 3, 0, false, OptimisticLockType.NONE, null, "withdrawalReason", null);
            _columnWithdrawalReasonInputText = cci("WITHDRAWAL_REASON_INPUT_TEXT", "WITHDRAWAL_REASON_INPUT_TEXT", null, null, false, "WithdrawalReasonInputText", typeof(String), false, "CLOB", 4000, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnWithdrawalDatetime = cci("WITHDRAWAL_DATETIME", "WITHDRAWAL_DATETIME", null, null, true, "WithdrawalDatetime", typeof(DateTime?), false, "DATE", 7, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnRegisterDatetime = cci("REGISTER_DATETIME", "REGISTER_DATETIME", null, null, true, "RegisterDatetime", typeof(DateTime?), false, "DATE", 7, 0, true, OptimisticLockType.NONE, null, null, null);
            _columnRegisterProcess = cci("REGISTER_PROCESS", "REGISTER_PROCESS", null, null, true, "RegisterProcess", typeof(String), false, "VARCHAR2", 200, 0, true, OptimisticLockType.NONE, null, null, null);
            _columnRegisterUser = cci("REGISTER_USER", "REGISTER_USER", null, null, true, "RegisterUser", typeof(String), false, "VARCHAR2", 200, 0, true, OptimisticLockType.NONE, null, null, null);
            _columnUpdateDatetime = cci("UPDATE_DATETIME", "UPDATE_DATETIME", null, null, true, "UpdateDatetime", typeof(DateTime?), false, "DATE", 7, 0, true, OptimisticLockType.NONE, null, null, null);
            _columnUpdateProcess = cci("UPDATE_PROCESS", "UPDATE_PROCESS", null, null, true, "UpdateProcess", typeof(String), false, "VARCHAR2", 200, 0, true, OptimisticLockType.NONE, null, null, null);
            _columnUpdateUser = cci("UPDATE_USER", "UPDATE_USER", null, null, true, "UpdateUser", typeof(String), false, "VARCHAR2", 200, 0, true, OptimisticLockType.NONE, null, null, null);
            _columnVersionNo = cci("VERSION_NO", "VERSION_NO", null, null, true, "VersionNo", typeof(long?), false, "NUMBER", 16, 0, false, OptimisticLockType.VERSION_NO, null, null, null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<ColumnInfo>();
            _columnInfoList.add(ColumnMemberId);
            _columnInfoList.add(ColumnWithdrawalReasonCode);
            _columnInfoList.add(ColumnWithdrawalReasonInputText);
            _columnInfoList.add(ColumnWithdrawalDatetime);
            _columnInfoList.add(ColumnRegisterDatetime);
            _columnInfoList.add(ColumnRegisterProcess);
            _columnInfoList.add(ColumnRegisterUser);
            _columnInfoList.add(ColumnUpdateDatetime);
            _columnInfoList.add(ColumnUpdateProcess);
            _columnInfoList.add(ColumnUpdateUser);
            _columnInfoList.add(ColumnVersionNo);
        }

        // ===============================================================================
        //                                                                     Unique Info
        //                                                                     ===========
        public override UniqueInfo PrimaryUniqueInfo { get {
            return cpui(ColumnMemberId);
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
        public ForeignInfo ForeignMemberVendorSynonym { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(ColumnMemberId, MemberVendorSynonymDbm.GetInstance().ColumnMemberId);
            return cfi("MemberVendorSynonym", this, MemberVendorSynonymDbm.GetInstance(), map, 0, true, false);
        }}
        public ForeignInfo ForeignWithdrawalReason { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(ColumnWithdrawalReasonCode, WithdrawalReasonDbm.GetInstance().ColumnWithdrawalReasonCode);
            return cfi("WithdrawalReason", this, WithdrawalReasonDbm.GetInstance(), map, 1, false, false);
        }}
        public ForeignInfo ForeignVdSynonymMember { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(ColumnMemberId, VdSynonymMemberDbm.GetInstance().ColumnMemberId);
            return cfi("VdSynonymMember", this, VdSynonymMemberDbm.GetInstance(), map, 2, true, false);
        }}
        public ForeignInfo ForeignVendorSynonymMember { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(ColumnMemberId, VendorSynonymMemberDbm.GetInstance().ColumnMemberId);
            return cfi("VendorSynonymMember", this, VendorSynonymMemberDbm.GetInstance(), map, 3, true, false);
        }}


        // -------------------------------------------------
        //                                  Referrer Element
        //                                  ----------------

        // ===============================================================================
        //                                                                    Various Info
        //                                                                    ============
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
        public static readonly String TABLE_DB_NAME = "VD_SYNONYM_MEMBER_WITHDRAWAL";
        public static readonly String TABLE_PROPERTY_NAME = "VdSynonymMemberWithdrawal";

        // -------------------------------------------------
        //                                    Column DB-Name
        //                                    --------------
        public static readonly String DB_NAME_MEMBER_ID = "MEMBER_ID";
        public static readonly String DB_NAME_WITHDRAWAL_REASON_CODE = "WITHDRAWAL_REASON_CODE";
        public static readonly String DB_NAME_WITHDRAWAL_REASON_INPUT_TEXT = "WITHDRAWAL_REASON_INPUT_TEXT";
        public static readonly String DB_NAME_WITHDRAWAL_DATETIME = "WITHDRAWAL_DATETIME";
        public static readonly String DB_NAME_REGISTER_DATETIME = "REGISTER_DATETIME";
        public static readonly String DB_NAME_REGISTER_PROCESS = "REGISTER_PROCESS";
        public static readonly String DB_NAME_REGISTER_USER = "REGISTER_USER";
        public static readonly String DB_NAME_UPDATE_DATETIME = "UPDATE_DATETIME";
        public static readonly String DB_NAME_UPDATE_PROCESS = "UPDATE_PROCESS";
        public static readonly String DB_NAME_UPDATE_USER = "UPDATE_USER";
        public static readonly String DB_NAME_VERSION_NO = "VERSION_NO";

        // -------------------------------------------------
        //                              Column Property-Name
        //                              --------------------
        public static readonly String PROPERTY_NAME_MEMBER_ID = "MemberId";
        public static readonly String PROPERTY_NAME_WITHDRAWAL_REASON_CODE = "WithdrawalReasonCode";
        public static readonly String PROPERTY_NAME_WITHDRAWAL_REASON_INPUT_TEXT = "WithdrawalReasonInputText";
        public static readonly String PROPERTY_NAME_WITHDRAWAL_DATETIME = "WithdrawalDatetime";
        public static readonly String PROPERTY_NAME_REGISTER_DATETIME = "RegisterDatetime";
        public static readonly String PROPERTY_NAME_REGISTER_PROCESS = "RegisterProcess";
        public static readonly String PROPERTY_NAME_REGISTER_USER = "RegisterUser";
        public static readonly String PROPERTY_NAME_UPDATE_DATETIME = "UpdateDatetime";
        public static readonly String PROPERTY_NAME_UPDATE_PROCESS = "UpdateProcess";
        public static readonly String PROPERTY_NAME_UPDATE_USER = "UpdateUser";
        public static readonly String PROPERTY_NAME_VERSION_NO = "VersionNo";

        // -------------------------------------------------
        //                                      Foreign Name
        //                                      ------------
        public static readonly String FOREIGN_PROPERTY_NAME_MemberVendorSynonym = "MemberVendorSynonym";
        public static readonly String FOREIGN_PROPERTY_NAME_WithdrawalReason = "WithdrawalReason";
        public static readonly String FOREIGN_PROPERTY_NAME_VdSynonymMember = "VdSynonymMember";
        public static readonly String FOREIGN_PROPERTY_NAME_VendorSynonymMember = "VendorSynonymMember";
        // -------------------------------------------------
        //                                     Referrer Name
        //                                     -------------

        // -------------------------------------------------
        //                               DB-Property Mapping
        //                               -------------------
        protected static readonly Map<String, String> _dbNamePropertyNameKeyToLowerMap;
        protected static readonly Map<String, String> _propertyNameDbNameKeyToLowerMap;

        static VdSynonymMemberWithdrawalDbm() {
            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_DB_NAME.ToLower(), TABLE_PROPERTY_NAME);
                map.put(DB_NAME_MEMBER_ID.ToLower(), PROPERTY_NAME_MEMBER_ID);
                map.put(DB_NAME_WITHDRAWAL_REASON_CODE.ToLower(), PROPERTY_NAME_WITHDRAWAL_REASON_CODE);
                map.put(DB_NAME_WITHDRAWAL_REASON_INPUT_TEXT.ToLower(), PROPERTY_NAME_WITHDRAWAL_REASON_INPUT_TEXT);
                map.put(DB_NAME_WITHDRAWAL_DATETIME.ToLower(), PROPERTY_NAME_WITHDRAWAL_DATETIME);
                map.put(DB_NAME_REGISTER_DATETIME.ToLower(), PROPERTY_NAME_REGISTER_DATETIME);
                map.put(DB_NAME_REGISTER_PROCESS.ToLower(), PROPERTY_NAME_REGISTER_PROCESS);
                map.put(DB_NAME_REGISTER_USER.ToLower(), PROPERTY_NAME_REGISTER_USER);
                map.put(DB_NAME_UPDATE_DATETIME.ToLower(), PROPERTY_NAME_UPDATE_DATETIME);
                map.put(DB_NAME_UPDATE_PROCESS.ToLower(), PROPERTY_NAME_UPDATE_PROCESS);
                map.put(DB_NAME_UPDATE_USER.ToLower(), PROPERTY_NAME_UPDATE_USER);
                map.put(DB_NAME_VERSION_NO.ToLower(), PROPERTY_NAME_VERSION_NO);
                _dbNamePropertyNameKeyToLowerMap = map;
            }

            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_PROPERTY_NAME.ToLower(), TABLE_DB_NAME);
                map.put(PROPERTY_NAME_MEMBER_ID.ToLower(), DB_NAME_MEMBER_ID);
                map.put(PROPERTY_NAME_WITHDRAWAL_REASON_CODE.ToLower(), DB_NAME_WITHDRAWAL_REASON_CODE);
                map.put(PROPERTY_NAME_WITHDRAWAL_REASON_INPUT_TEXT.ToLower(), DB_NAME_WITHDRAWAL_REASON_INPUT_TEXT);
                map.put(PROPERTY_NAME_WITHDRAWAL_DATETIME.ToLower(), DB_NAME_WITHDRAWAL_DATETIME);
                map.put(PROPERTY_NAME_REGISTER_DATETIME.ToLower(), DB_NAME_REGISTER_DATETIME);
                map.put(PROPERTY_NAME_REGISTER_PROCESS.ToLower(), DB_NAME_REGISTER_PROCESS);
                map.put(PROPERTY_NAME_REGISTER_USER.ToLower(), DB_NAME_REGISTER_USER);
                map.put(PROPERTY_NAME_UPDATE_DATETIME.ToLower(), DB_NAME_UPDATE_DATETIME);
                map.put(PROPERTY_NAME_UPDATE_PROCESS.ToLower(), DB_NAME_UPDATE_PROCESS);
                map.put(PROPERTY_NAME_UPDATE_USER.ToLower(), DB_NAME_UPDATE_USER);
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
        public override String EntityTypeName { get { return "DfExample.DBFlute.ExEntity.VdSynonymMemberWithdrawal"; } }
        public override String DaoTypeName { get { return "DfExample.DBFlute.ExDao.VdSynonymMemberWithdrawalDao"; } }
        public override String ConditionBeanTypeName { get { return "DfExample.DBFlute.CBean.VdSynonymMemberWithdrawalCB"; } }
        public override String BehaviorTypeName { get { return "DfExample.DBFlute.ExBhv.VdSynonymMemberWithdrawalBhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override Entity NewEntity() { return NewMyEntity(); }
        public VdSynonymMemberWithdrawal NewMyEntity() { return new VdSynonymMemberWithdrawal(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public VdSynonymMemberWithdrawalCB NewMyConditionBean() { return new VdSynonymMemberWithdrawalCB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<VdSynonymMemberWithdrawal>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<VdSynonymMemberWithdrawal>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("MEMBER_ID", "MemberId", new EntityPropertyMemberIdSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("WITHDRAWAL_REASON_CODE", "WithdrawalReasonCode", new EntityPropertyWithdrawalReasonCodeSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("WITHDRAWAL_REASON_INPUT_TEXT", "WithdrawalReasonInputText", new EntityPropertyWithdrawalReasonInputTextSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("WITHDRAWAL_DATETIME", "WithdrawalDatetime", new EntityPropertyWithdrawalDatetimeSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("REGISTER_DATETIME", "RegisterDatetime", new EntityPropertyRegisterDatetimeSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("REGISTER_PROCESS", "RegisterProcess", new EntityPropertyRegisterProcessSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("REGISTER_USER", "RegisterUser", new EntityPropertyRegisterUserSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("UPDATE_DATETIME", "UpdateDatetime", new EntityPropertyUpdateDatetimeSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("UPDATE_PROCESS", "UpdateProcess", new EntityPropertyUpdateProcessSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("UPDATE_USER", "UpdateUser", new EntityPropertyUpdateUserSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("VERSION_NO", "VersionNo", new EntityPropertyVersionNoSetupper(), _entityPropertySetupperMap);
        }

        public override bool HasEntityPropertySetupper(String propertyName) {
            return _entityPropertySetupperMap.containsKey(propertyName);
        }

        public override void SetupEntityProperty(String propertyName, Object entity, Object value) {
            EntityPropertySetupper<VdSynonymMemberWithdrawal> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((VdSynonymMemberWithdrawal)entity, value);
        }

        public class EntityPropertyMemberIdSetupper : EntityPropertySetupper<VdSynonymMemberWithdrawal> {
            public void Setup(VdSynonymMemberWithdrawal entity, Object value) { entity.MemberId = (value != null) ? (long?)value : null; }
        }
        public class EntityPropertyWithdrawalReasonCodeSetupper : EntityPropertySetupper<VdSynonymMemberWithdrawal> {
            public void Setup(VdSynonymMemberWithdrawal entity, Object value) { entity.WithdrawalReasonCode = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyWithdrawalReasonInputTextSetupper : EntityPropertySetupper<VdSynonymMemberWithdrawal> {
            public void Setup(VdSynonymMemberWithdrawal entity, Object value) { entity.WithdrawalReasonInputText = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyWithdrawalDatetimeSetupper : EntityPropertySetupper<VdSynonymMemberWithdrawal> {
            public void Setup(VdSynonymMemberWithdrawal entity, Object value) { entity.WithdrawalDatetime = (value != null) ? (DateTime?)value : null; }
        }
        public class EntityPropertyRegisterDatetimeSetupper : EntityPropertySetupper<VdSynonymMemberWithdrawal> {
            public void Setup(VdSynonymMemberWithdrawal entity, Object value) { entity.RegisterDatetime = (value != null) ? (DateTime?)value : null; }
        }
        public class EntityPropertyRegisterProcessSetupper : EntityPropertySetupper<VdSynonymMemberWithdrawal> {
            public void Setup(VdSynonymMemberWithdrawal entity, Object value) { entity.RegisterProcess = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyRegisterUserSetupper : EntityPropertySetupper<VdSynonymMemberWithdrawal> {
            public void Setup(VdSynonymMemberWithdrawal entity, Object value) { entity.RegisterUser = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyUpdateDatetimeSetupper : EntityPropertySetupper<VdSynonymMemberWithdrawal> {
            public void Setup(VdSynonymMemberWithdrawal entity, Object value) { entity.UpdateDatetime = (value != null) ? (DateTime?)value : null; }
        }
        public class EntityPropertyUpdateProcessSetupper : EntityPropertySetupper<VdSynonymMemberWithdrawal> {
            public void Setup(VdSynonymMemberWithdrawal entity, Object value) { entity.UpdateProcess = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyUpdateUserSetupper : EntityPropertySetupper<VdSynonymMemberWithdrawal> {
            public void Setup(VdSynonymMemberWithdrawal entity, Object value) { entity.UpdateUser = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyVersionNoSetupper : EntityPropertySetupper<VdSynonymMemberWithdrawal> {
            public void Setup(VdSynonymMemberWithdrawal entity, Object value) { entity.VersionNo = (value != null) ? (long?)value : null; }
        }
    }
}

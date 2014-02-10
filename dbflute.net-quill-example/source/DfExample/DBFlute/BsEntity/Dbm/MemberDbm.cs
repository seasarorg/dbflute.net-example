
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

    public class MemberDbm : AbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(Member);

        private static readonly MemberDbm _instance = new MemberDbm();
        private MemberDbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static MemberDbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "member"; } }
        public override String TablePropertyName { get { return "Member"; } }
        public override String TableSqlName { get { return "member"; } }
        public override String TableAlias { get { return "会員"; } }
        public override String TableComment { get { return "会員登録時にInsertされる。\n物理削除されることはない"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected ColumnInfo _columnMemberId;
        protected ColumnInfo _columnMemberName;
        protected ColumnInfo _columnMemberAccount;
        protected ColumnInfo _columnMemberStatusCode;
        protected ColumnInfo _columnFormalizedDatetime;
        protected ColumnInfo _columnBirthdate;
        protected ColumnInfo _columnRegisterDatetime;
        protected ColumnInfo _columnRegisterUser;
        protected ColumnInfo _columnRegisterProcess;
        protected ColumnInfo _columnUpdateDatetime;
        protected ColumnInfo _columnUpdateUser;
        protected ColumnInfo _columnUpdateProcess;
        protected ColumnInfo _columnVersionNo;

        public ColumnInfo ColumnMemberId { get { return _columnMemberId; } }
        public ColumnInfo ColumnMemberName { get { return _columnMemberName; } }
        public ColumnInfo ColumnMemberAccount { get { return _columnMemberAccount; } }
        public ColumnInfo ColumnMemberStatusCode { get { return _columnMemberStatusCode; } }
        public ColumnInfo ColumnFormalizedDatetime { get { return _columnFormalizedDatetime; } }
        public ColumnInfo ColumnBirthdate { get { return _columnBirthdate; } }
        public ColumnInfo ColumnRegisterDatetime { get { return _columnRegisterDatetime; } }
        public ColumnInfo ColumnRegisterUser { get { return _columnRegisterUser; } }
        public ColumnInfo ColumnRegisterProcess { get { return _columnRegisterProcess; } }
        public ColumnInfo ColumnUpdateDatetime { get { return _columnUpdateDatetime; } }
        public ColumnInfo ColumnUpdateUser { get { return _columnUpdateUser; } }
        public ColumnInfo ColumnUpdateProcess { get { return _columnUpdateProcess; } }
        public ColumnInfo ColumnVersionNo { get { return _columnVersionNo; } }

        protected void InitializeColumnInfo() {
            _columnMemberId = cci("MEMBER_ID", "MEMBER_ID", null, "会員ID", true, "MemberId", typeof(int?), true, "INT", 10, 0, false, OptimisticLockType.NONE, "連番", "memberLoginAsLatest,memberAddressAsValid,memberLoginAsLocalForeignOverTest,memberLoginAsForeignForeignOverTest,memberLoginAsForeignForeignParameterOverTest,memberLoginAsForeignForeignVariousOverTest,memberLoginAsReferrerOverTest,memberLoginAsReferrerForeignOverTest,memberSecurityAsOne,memberWithdrawalAsOne", "memberAddressList,memberLoginList,purchaseList");
            _columnMemberName = cci("MEMBER_NAME", "MEMBER_NAME", null, "会員名称", true, "MemberName", typeof(String), false, "VARCHAR", 200, 0, false, OptimisticLockType.NONE, "会員の表示用の名称(姓名)", null, null);
            _columnMemberAccount = cci("MEMBER_ACCOUNT", "MEMBER_ACCOUNT", null, "会員アカウント", true, "MemberAccount", typeof(String), false, "VARCHAR", 50, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnMemberStatusCode = cci("MEMBER_STATUS_CODE", "MEMBER_STATUS_CODE", null, null, true, "MemberStatusCode", typeof(String), false, "CHAR", 3, 0, false, OptimisticLockType.NONE, null, "memberStatus", null);
            _columnFormalizedDatetime = cci("FORMALIZED_DATETIME", "FORMALIZED_DATETIME", null, null, false, "FormalizedDatetime", typeof(DateTime?), false, "DATETIME", 19, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnBirthdate = cci("BIRTHDATE", "BIRTHDATE", null, null, false, "Birthdate", typeof(DateTime?), false, "DATE", 10, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnRegisterDatetime = cci("REGISTER_DATETIME", "REGISTER_DATETIME", null, null, true, "RegisterDatetime", typeof(DateTime?), false, "DATETIME", 19, 0, true, OptimisticLockType.NONE, null, null, null);
            _columnRegisterUser = cci("REGISTER_USER", "REGISTER_USER", null, null, true, "RegisterUser", typeof(String), false, "VARCHAR", 200, 0, true, OptimisticLockType.NONE, null, null, null);
            _columnRegisterProcess = cci("REGISTER_PROCESS", "REGISTER_PROCESS", null, null, true, "RegisterProcess", typeof(String), false, "VARCHAR", 200, 0, true, OptimisticLockType.NONE, null, null, null);
            _columnUpdateDatetime = cci("UPDATE_DATETIME", "UPDATE_DATETIME", null, null, true, "UpdateDatetime", typeof(DateTime?), false, "DATETIME", 19, 0, true, OptimisticLockType.NONE, null, null, null);
            _columnUpdateUser = cci("UPDATE_USER", "UPDATE_USER", null, null, true, "UpdateUser", typeof(String), false, "VARCHAR", 200, 0, true, OptimisticLockType.NONE, null, null, null);
            _columnUpdateProcess = cci("UPDATE_PROCESS", "UPDATE_PROCESS", null, null, true, "UpdateProcess", typeof(String), false, "VARCHAR", 200, 0, true, OptimisticLockType.NONE, null, null, null);
            _columnVersionNo = cci("VERSION_NO", "VERSION_NO", null, null, true, "VersionNo", typeof(long?), false, "BIGINT", 19, 0, false, OptimisticLockType.VERSION_NO, null, null, null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<ColumnInfo>();
            _columnInfoList.add(ColumnMemberId);
            _columnInfoList.add(ColumnMemberName);
            _columnInfoList.add(ColumnMemberAccount);
            _columnInfoList.add(ColumnMemberStatusCode);
            _columnInfoList.add(ColumnFormalizedDatetime);
            _columnInfoList.add(ColumnBirthdate);
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
        public ForeignInfo ForeignMemberStatus { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(ColumnMemberStatusCode, MemberStatusDbm.GetInstance().ColumnMemberStatusCode);
            return cfi("MemberStatus", this, MemberStatusDbm.GetInstance(), map, 0, false, false);
        }}
        public ForeignInfo ForeignMemberLoginAsLatest { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(ColumnMemberId, MemberLoginDbm.GetInstance().ColumnMemberId);
            return cfi("MemberLoginAsLatest", this, MemberLoginDbm.GetInstance(), map, 1, true, true);
        }}
        public ForeignInfo ForeignMemberAddressAsValid { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(ColumnMemberId, MemberAddressDbm.GetInstance().ColumnMemberId);
            return cfi("MemberAddressAsValid", this, MemberAddressDbm.GetInstance(), map, 2, true, true);
        }}
        public ForeignInfo ForeignMemberLoginAsLocalForeignOverTest { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(ColumnMemberId, MemberLoginDbm.GetInstance().ColumnMemberId);
            return cfi("MemberLoginAsLocalForeignOverTest", this, MemberLoginDbm.GetInstance(), map, 3, true, true);
        }}
        public ForeignInfo ForeignMemberLoginAsForeignForeignOverTest { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(ColumnMemberId, MemberLoginDbm.GetInstance().ColumnMemberId);
            return cfi("MemberLoginAsForeignForeignOverTest", this, MemberLoginDbm.GetInstance(), map, 4, true, true);
        }}
        public ForeignInfo ForeignMemberLoginAsForeignForeignParameterOverTest { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(ColumnMemberId, MemberLoginDbm.GetInstance().ColumnMemberId);
            return cfi("MemberLoginAsForeignForeignParameterOverTest", this, MemberLoginDbm.GetInstance(), map, 5, true, true);
        }}
        public ForeignInfo ForeignMemberLoginAsForeignForeignVariousOverTest { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(ColumnMemberId, MemberLoginDbm.GetInstance().ColumnMemberId);
            return cfi("MemberLoginAsForeignForeignVariousOverTest", this, MemberLoginDbm.GetInstance(), map, 6, true, true);
        }}
        public ForeignInfo ForeignMemberLoginAsReferrerOverTest { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(ColumnMemberId, MemberLoginDbm.GetInstance().ColumnMemberId);
            return cfi("MemberLoginAsReferrerOverTest", this, MemberLoginDbm.GetInstance(), map, 7, true, true);
        }}
        public ForeignInfo ForeignMemberLoginAsReferrerForeignOverTest { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(ColumnMemberId, MemberLoginDbm.GetInstance().ColumnMemberId);
            return cfi("MemberLoginAsReferrerForeignOverTest", this, MemberLoginDbm.GetInstance(), map, 8, true, true);
        }}

        public ForeignInfo ForeignMemberSecurityAsOne { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(ColumnMemberId, MemberSecurityDbm.GetInstance().ColumnMemberId);
            return cfi("MemberSecurityAsOne", this, MemberSecurityDbm.GetInstance(), map, 9, true, false);
        }}
        public ForeignInfo ForeignMemberWithdrawalAsOne { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(ColumnMemberId, MemberWithdrawalDbm.GetInstance().ColumnMemberId);
            return cfi("MemberWithdrawalAsOne", this, MemberWithdrawalDbm.GetInstance(), map, 10, true, false);
        }}

        // -------------------------------------------------
        //                                  Referrer Element
        //                                  ----------------
        public ReferrerInfo ReferrerMemberAddressList { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(ColumnMemberId, MemberAddressDbm.GetInstance().ColumnMemberId);
            return cri("MemberAddressList", this, MemberAddressDbm.GetInstance(), map, false);
        }}
        public ReferrerInfo ReferrerMemberLoginList { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(ColumnMemberId, MemberLoginDbm.GetInstance().ColumnMemberId);
            return cri("MemberLoginList", this, MemberLoginDbm.GetInstance(), map, false);
        }}
        public ReferrerInfo ReferrerPurchaseList { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(ColumnMemberId, PurchaseDbm.GetInstance().ColumnMemberId);
            return cri("PurchaseList", this, PurchaseDbm.GetInstance(), map, false);
        }}

        // ===============================================================================
        //                                                                    Various Info
        //                                                                    ============
        public override bool HasIdentity { get { return true; } }
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
        public static readonly String TABLE_DB_NAME = "member";
        public static readonly String TABLE_PROPERTY_NAME = "Member";

        // -------------------------------------------------
        //                                    Column DB-Name
        //                                    --------------
        public static readonly String DB_NAME_MEMBER_ID = "MEMBER_ID";
        public static readonly String DB_NAME_MEMBER_NAME = "MEMBER_NAME";
        public static readonly String DB_NAME_MEMBER_ACCOUNT = "MEMBER_ACCOUNT";
        public static readonly String DB_NAME_MEMBER_STATUS_CODE = "MEMBER_STATUS_CODE";
        public static readonly String DB_NAME_FORMALIZED_DATETIME = "FORMALIZED_DATETIME";
        public static readonly String DB_NAME_BIRTHDATE = "BIRTHDATE";
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
        public static readonly String PROPERTY_NAME_MEMBER_ID = "MemberId";
        public static readonly String PROPERTY_NAME_MEMBER_NAME = "MemberName";
        public static readonly String PROPERTY_NAME_MEMBER_ACCOUNT = "MemberAccount";
        public static readonly String PROPERTY_NAME_MEMBER_STATUS_CODE = "MemberStatusCode";
        public static readonly String PROPERTY_NAME_FORMALIZED_DATETIME = "FormalizedDatetime";
        public static readonly String PROPERTY_NAME_BIRTHDATE = "Birthdate";
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
        public static readonly String FOREIGN_PROPERTY_NAME_MemberStatus = "MemberStatus";
        public static readonly String FOREIGN_PROPERTY_NAME_MemberLoginAsLatest = "MemberLoginAsLatest";
        public static readonly String FOREIGN_PROPERTY_NAME_MemberAddressAsValid = "MemberAddressAsValid";
        public static readonly String FOREIGN_PROPERTY_NAME_MemberLoginAsLocalForeignOverTest = "MemberLoginAsLocalForeignOverTest";
        public static readonly String FOREIGN_PROPERTY_NAME_MemberLoginAsForeignForeignOverTest = "MemberLoginAsForeignForeignOverTest";
        public static readonly String FOREIGN_PROPERTY_NAME_MemberLoginAsForeignForeignParameterOverTest = "MemberLoginAsForeignForeignParameterOverTest";
        public static readonly String FOREIGN_PROPERTY_NAME_MemberLoginAsForeignForeignVariousOverTest = "MemberLoginAsForeignForeignVariousOverTest";
        public static readonly String FOREIGN_PROPERTY_NAME_MemberLoginAsReferrerOverTest = "MemberLoginAsReferrerOverTest";
        public static readonly String FOREIGN_PROPERTY_NAME_MemberLoginAsReferrerForeignOverTest = "MemberLoginAsReferrerForeignOverTest";
        public static readonly String FOREIGN_PROPERTY_NAME_MemberSecurityAsOne = "$foreignKeys.foreignPropertyNameInitCap";
        public static readonly String FOREIGN_PROPERTY_NAME_MemberWithdrawalAsOne = "$foreignKeys.foreignPropertyNameInitCap";
        // -------------------------------------------------
        //                                     Referrer Name
        //                                     -------------
        public static readonly String REFERRER_PROPERTY_NAME_MemberAddressList = "MemberAddressList";
        public static readonly String REFERRER_PROPERTY_NAME_MemberLoginList = "MemberLoginList";
        public static readonly String REFERRER_PROPERTY_NAME_PurchaseList = "PurchaseList";

        // -------------------------------------------------
        //                               DB-Property Mapping
        //                               -------------------
        protected static readonly Map<String, String> _dbNamePropertyNameKeyToLowerMap;
        protected static readonly Map<String, String> _propertyNameDbNameKeyToLowerMap;

        static MemberDbm() {
            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_DB_NAME.ToLower(), TABLE_PROPERTY_NAME);
                map.put(DB_NAME_MEMBER_ID.ToLower(), PROPERTY_NAME_MEMBER_ID);
                map.put(DB_NAME_MEMBER_NAME.ToLower(), PROPERTY_NAME_MEMBER_NAME);
                map.put(DB_NAME_MEMBER_ACCOUNT.ToLower(), PROPERTY_NAME_MEMBER_ACCOUNT);
                map.put(DB_NAME_MEMBER_STATUS_CODE.ToLower(), PROPERTY_NAME_MEMBER_STATUS_CODE);
                map.put(DB_NAME_FORMALIZED_DATETIME.ToLower(), PROPERTY_NAME_FORMALIZED_DATETIME);
                map.put(DB_NAME_BIRTHDATE.ToLower(), PROPERTY_NAME_BIRTHDATE);
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
                map.put(PROPERTY_NAME_MEMBER_ID.ToLower(), DB_NAME_MEMBER_ID);
                map.put(PROPERTY_NAME_MEMBER_NAME.ToLower(), DB_NAME_MEMBER_NAME);
                map.put(PROPERTY_NAME_MEMBER_ACCOUNT.ToLower(), DB_NAME_MEMBER_ACCOUNT);
                map.put(PROPERTY_NAME_MEMBER_STATUS_CODE.ToLower(), DB_NAME_MEMBER_STATUS_CODE);
                map.put(PROPERTY_NAME_FORMALIZED_DATETIME.ToLower(), DB_NAME_FORMALIZED_DATETIME);
                map.put(PROPERTY_NAME_BIRTHDATE.ToLower(), DB_NAME_BIRTHDATE);
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
        public override String EntityTypeName { get { return "DfExample.DBFlute.ExEntity.Member"; } }
        public override String DaoTypeName { get { return "DfExample.DBFlute.ExDao.MemberDao"; } }
        public override String ConditionBeanTypeName { get { return "DfExample.DBFlute.CBean.MemberCB"; } }
        public override String BehaviorTypeName { get { return "DfExample.DBFlute.ExBhv.MemberBhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override Entity NewEntity() { return NewMyEntity(); }
        public Member NewMyEntity() { return new Member(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public MemberCB NewMyConditionBean() { return new MemberCB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<Member>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<Member>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("MEMBER_ID", "MemberId", new EntityPropertyMemberIdSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("MEMBER_NAME", "MemberName", new EntityPropertyMemberNameSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("MEMBER_ACCOUNT", "MemberAccount", new EntityPropertyMemberAccountSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("MEMBER_STATUS_CODE", "MemberStatusCode", new EntityPropertyMemberStatusCodeSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("FORMALIZED_DATETIME", "FormalizedDatetime", new EntityPropertyFormalizedDatetimeSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("BIRTHDATE", "Birthdate", new EntityPropertyBirthdateSetupper(), _entityPropertySetupperMap);
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
            EntityPropertySetupper<Member> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((Member)entity, value);
        }

        public class EntityPropertyMemberIdSetupper : EntityPropertySetupper<Member> {
            public void Setup(Member entity, Object value) { entity.MemberId = (value != null) ? (int?)value : null; }
        }
        public class EntityPropertyMemberNameSetupper : EntityPropertySetupper<Member> {
            public void Setup(Member entity, Object value) { entity.MemberName = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyMemberAccountSetupper : EntityPropertySetupper<Member> {
            public void Setup(Member entity, Object value) { entity.MemberAccount = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyMemberStatusCodeSetupper : EntityPropertySetupper<Member> {
            public void Setup(Member entity, Object value) { entity.MemberStatusCode = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyFormalizedDatetimeSetupper : EntityPropertySetupper<Member> {
            public void Setup(Member entity, Object value) { entity.FormalizedDatetime = (value != null) ? (DateTime?)value : null; }
        }
        public class EntityPropertyBirthdateSetupper : EntityPropertySetupper<Member> {
            public void Setup(Member entity, Object value) { entity.Birthdate = (value != null) ? (DateTime?)value : null; }
        }
        public class EntityPropertyRegisterDatetimeSetupper : EntityPropertySetupper<Member> {
            public void Setup(Member entity, Object value) { entity.RegisterDatetime = (value != null) ? (DateTime?)value : null; }
        }
        public class EntityPropertyRegisterUserSetupper : EntityPropertySetupper<Member> {
            public void Setup(Member entity, Object value) { entity.RegisterUser = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyRegisterProcessSetupper : EntityPropertySetupper<Member> {
            public void Setup(Member entity, Object value) { entity.RegisterProcess = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyUpdateDatetimeSetupper : EntityPropertySetupper<Member> {
            public void Setup(Member entity, Object value) { entity.UpdateDatetime = (value != null) ? (DateTime?)value : null; }
        }
        public class EntityPropertyUpdateUserSetupper : EntityPropertySetupper<Member> {
            public void Setup(Member entity, Object value) { entity.UpdateUser = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyUpdateProcessSetupper : EntityPropertySetupper<Member> {
            public void Setup(Member entity, Object value) { entity.UpdateProcess = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyVersionNoSetupper : EntityPropertySetupper<Member> {
            public void Setup(Member entity, Object value) { entity.VersionNo = (value != null) ? (long?)value : null; }
        }
    }
}

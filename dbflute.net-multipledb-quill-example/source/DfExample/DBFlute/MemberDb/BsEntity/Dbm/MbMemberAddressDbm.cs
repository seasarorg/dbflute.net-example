
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

    public class MbMemberAddressDbm : MbAbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(MbMemberAddress);

        private static readonly MbMemberAddressDbm _instance = new MbMemberAddressDbm();
        private MbMemberAddressDbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static MbMemberAddressDbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "member_address"; } }
        public override String TablePropertyName { get { return "MemberAddress"; } }
        public override String TableSqlName { get { return "member_address"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected MbColumnInfo _columnMemberAddressId;
        protected MbColumnInfo _columnMemberId;
        protected MbColumnInfo _columnValidBeginDate;
        protected MbColumnInfo _columnValidEndDate;
        protected MbColumnInfo _columnAddress;
        protected MbColumnInfo _columnRegisterDatetime;
        protected MbColumnInfo _columnRegisterProcess;
        protected MbColumnInfo _columnRegisterUser;
        protected MbColumnInfo _columnUpdateDatetime;
        protected MbColumnInfo _columnUpdateProcess;
        protected MbColumnInfo _columnUpdateUser;
        protected MbColumnInfo _columnVersionNo;

        public MbColumnInfo ColumnMemberAddressId { get { return _columnMemberAddressId; } }
        public MbColumnInfo ColumnMemberId { get { return _columnMemberId; } }
        public MbColumnInfo ColumnValidBeginDate { get { return _columnValidBeginDate; } }
        public MbColumnInfo ColumnValidEndDate { get { return _columnValidEndDate; } }
        public MbColumnInfo ColumnAddress { get { return _columnAddress; } }
        public MbColumnInfo ColumnRegisterDatetime { get { return _columnRegisterDatetime; } }
        public MbColumnInfo ColumnRegisterProcess { get { return _columnRegisterProcess; } }
        public MbColumnInfo ColumnRegisterUser { get { return _columnRegisterUser; } }
        public MbColumnInfo ColumnUpdateDatetime { get { return _columnUpdateDatetime; } }
        public MbColumnInfo ColumnUpdateProcess { get { return _columnUpdateProcess; } }
        public MbColumnInfo ColumnUpdateUser { get { return _columnUpdateUser; } }
        public MbColumnInfo ColumnVersionNo { get { return _columnVersionNo; } }

        protected void InitializeColumnInfo() {
            _columnMemberAddressId = cci("MEMBER_ADDRESS_ID", "MEMBER_ADDRESS_ID", null, null, true, "MemberAddressId", typeof(int?), true, "INT", 10, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnMemberId = cci("MEMBER_ID", "MEMBER_ID", null, null, true, "MemberId", typeof(int?), false, "INT", 10, 0, false, OptimisticLockType.NONE, null, "member", null);
            _columnValidBeginDate = cci("VALID_BEGIN_DATE", "VALID_BEGIN_DATE", null, null, true, "ValidBeginDate", typeof(DateTime?), false, "DATE", 10, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnValidEndDate = cci("VALID_END_DATE", "VALID_END_DATE", null, null, true, "ValidEndDate", typeof(DateTime?), false, "DATE", 10, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnAddress = cci("ADDRESS", "ADDRESS", null, null, true, "Address", typeof(String), false, "VARCHAR", 200, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnRegisterDatetime = cci("REGISTER_DATETIME", "REGISTER_DATETIME", null, null, true, "RegisterDatetime", typeof(DateTime?), false, "DATETIME", 19, 0, true, OptimisticLockType.NONE, null, null, null);
            _columnRegisterProcess = cci("REGISTER_PROCESS", "REGISTER_PROCESS", null, null, true, "RegisterProcess", typeof(String), false, "VARCHAR", 200, 0, true, OptimisticLockType.NONE, null, null, null);
            _columnRegisterUser = cci("REGISTER_USER", "REGISTER_USER", null, null, true, "RegisterUser", typeof(String), false, "VARCHAR", 200, 0, true, OptimisticLockType.NONE, null, null, null);
            _columnUpdateDatetime = cci("UPDATE_DATETIME", "UPDATE_DATETIME", null, null, true, "UpdateDatetime", typeof(DateTime?), false, "DATETIME", 19, 0, true, OptimisticLockType.NONE, null, null, null);
            _columnUpdateProcess = cci("UPDATE_PROCESS", "UPDATE_PROCESS", null, null, true, "UpdateProcess", typeof(String), false, "VARCHAR", 200, 0, true, OptimisticLockType.NONE, null, null, null);
            _columnUpdateUser = cci("UPDATE_USER", "UPDATE_USER", null, null, true, "UpdateUser", typeof(String), false, "VARCHAR", 200, 0, true, OptimisticLockType.NONE, null, null, null);
            _columnVersionNo = cci("VERSION_NO", "VERSION_NO", null, null, true, "VersionNo", typeof(long?), false, "BIGINT", 19, 0, false, OptimisticLockType.VERSION_NO, null, null, null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<MbColumnInfo>();
            _columnInfoList.add(ColumnMemberAddressId);
            _columnInfoList.add(ColumnMemberId);
            _columnInfoList.add(ColumnValidBeginDate);
            _columnInfoList.add(ColumnValidEndDate);
            _columnInfoList.add(ColumnAddress);
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
        public override MbUniqueInfo PrimaryUniqueInfo { get {
            return cpui(ColumnMemberAddressId);
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
        public static readonly String TABLE_DB_NAME = "member_address";
        public static readonly String TABLE_PROPERTY_NAME = "MemberAddress";

        // -------------------------------------------------
        //                                    Column DB-Name
        //                                    --------------
        public static readonly String DB_NAME_MEMBER_ADDRESS_ID = "MEMBER_ADDRESS_ID";
        public static readonly String DB_NAME_MEMBER_ID = "MEMBER_ID";
        public static readonly String DB_NAME_VALID_BEGIN_DATE = "VALID_BEGIN_DATE";
        public static readonly String DB_NAME_VALID_END_DATE = "VALID_END_DATE";
        public static readonly String DB_NAME_ADDRESS = "ADDRESS";
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
        public static readonly String PROPERTY_NAME_MEMBER_ADDRESS_ID = "MemberAddressId";
        public static readonly String PROPERTY_NAME_MEMBER_ID = "MemberId";
        public static readonly String PROPERTY_NAME_VALID_BEGIN_DATE = "ValidBeginDate";
        public static readonly String PROPERTY_NAME_VALID_END_DATE = "ValidEndDate";
        public static readonly String PROPERTY_NAME_ADDRESS = "Address";
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
        public static readonly String FOREIGN_PROPERTY_NAME_Member = "Member";
        // -------------------------------------------------
        //                                     Referrer Name
        //                                     -------------

        // -------------------------------------------------
        //                               DB-Property Mapping
        //                               -------------------
        protected static readonly Map<String, String> _dbNamePropertyNameKeyToLowerMap;
        protected static readonly Map<String, String> _propertyNameDbNameKeyToLowerMap;

        static MbMemberAddressDbm() {
            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_DB_NAME.ToLower(), TABLE_PROPERTY_NAME);
                map.put(DB_NAME_MEMBER_ADDRESS_ID.ToLower(), PROPERTY_NAME_MEMBER_ADDRESS_ID);
                map.put(DB_NAME_MEMBER_ID.ToLower(), PROPERTY_NAME_MEMBER_ID);
                map.put(DB_NAME_VALID_BEGIN_DATE.ToLower(), PROPERTY_NAME_VALID_BEGIN_DATE);
                map.put(DB_NAME_VALID_END_DATE.ToLower(), PROPERTY_NAME_VALID_END_DATE);
                map.put(DB_NAME_ADDRESS.ToLower(), PROPERTY_NAME_ADDRESS);
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
                map.put(PROPERTY_NAME_MEMBER_ADDRESS_ID.ToLower(), DB_NAME_MEMBER_ADDRESS_ID);
                map.put(PROPERTY_NAME_MEMBER_ID.ToLower(), DB_NAME_MEMBER_ID);
                map.put(PROPERTY_NAME_VALID_BEGIN_DATE.ToLower(), DB_NAME_VALID_BEGIN_DATE);
                map.put(PROPERTY_NAME_VALID_END_DATE.ToLower(), DB_NAME_VALID_END_DATE);
                map.put(PROPERTY_NAME_ADDRESS.ToLower(), DB_NAME_ADDRESS);
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
        public override String EntityTypeName { get { return "DfExample.DBFlute.MemberDb.ExEntity.MbMemberAddress"; } }
        public override String DaoTypeName { get { return "DfExample.DBFlute.MemberDb.ExDao.MbMemberAddressDao"; } }
        public override String ConditionBeanTypeName { get { return "DfExample.DBFlute.MemberDb.CBean.MbMemberAddressCB"; } }
        public override String BehaviorTypeName { get { return "DfExample.DBFlute.MemberDb.ExBhv.MbMemberAddressBhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override MbEntity NewEntity() { return NewMyEntity(); }
        public MbMemberAddress NewMyEntity() { return new MbMemberAddress(); }
        public override MbConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public MbMemberAddressCB NewMyConditionBean() { return new MbMemberAddressCB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<MbMemberAddress>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<MbMemberAddress>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("MEMBER_ADDRESS_ID", "MemberAddressId", new EntityPropertyMemberAddressIdSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("MEMBER_ID", "MemberId", new EntityPropertyMemberIdSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("VALID_BEGIN_DATE", "ValidBeginDate", new EntityPropertyValidBeginDateSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("VALID_END_DATE", "ValidEndDate", new EntityPropertyValidEndDateSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("ADDRESS", "Address", new EntityPropertyAddressSetupper(), _entityPropertySetupperMap);
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
            EntityPropertySetupper<MbMemberAddress> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((MbMemberAddress)entity, value);
        }

        public class EntityPropertyMemberAddressIdSetupper : EntityPropertySetupper<MbMemberAddress> {
            public void Setup(MbMemberAddress entity, Object value) { entity.MemberAddressId = (value != null) ? (int?)value : null; }
        }
        public class EntityPropertyMemberIdSetupper : EntityPropertySetupper<MbMemberAddress> {
            public void Setup(MbMemberAddress entity, Object value) { entity.MemberId = (value != null) ? (int?)value : null; }
        }
        public class EntityPropertyValidBeginDateSetupper : EntityPropertySetupper<MbMemberAddress> {
            public void Setup(MbMemberAddress entity, Object value) { entity.ValidBeginDate = (value != null) ? (DateTime?)value : null; }
        }
        public class EntityPropertyValidEndDateSetupper : EntityPropertySetupper<MbMemberAddress> {
            public void Setup(MbMemberAddress entity, Object value) { entity.ValidEndDate = (value != null) ? (DateTime?)value : null; }
        }
        public class EntityPropertyAddressSetupper : EntityPropertySetupper<MbMemberAddress> {
            public void Setup(MbMemberAddress entity, Object value) { entity.Address = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyRegisterDatetimeSetupper : EntityPropertySetupper<MbMemberAddress> {
            public void Setup(MbMemberAddress entity, Object value) { entity.RegisterDatetime = (value != null) ? (DateTime?)value : null; }
        }
        public class EntityPropertyRegisterProcessSetupper : EntityPropertySetupper<MbMemberAddress> {
            public void Setup(MbMemberAddress entity, Object value) { entity.RegisterProcess = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyRegisterUserSetupper : EntityPropertySetupper<MbMemberAddress> {
            public void Setup(MbMemberAddress entity, Object value) { entity.RegisterUser = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyUpdateDatetimeSetupper : EntityPropertySetupper<MbMemberAddress> {
            public void Setup(MbMemberAddress entity, Object value) { entity.UpdateDatetime = (value != null) ? (DateTime?)value : null; }
        }
        public class EntityPropertyUpdateProcessSetupper : EntityPropertySetupper<MbMemberAddress> {
            public void Setup(MbMemberAddress entity, Object value) { entity.UpdateProcess = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyUpdateUserSetupper : EntityPropertySetupper<MbMemberAddress> {
            public void Setup(MbMemberAddress entity, Object value) { entity.UpdateUser = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyVersionNoSetupper : EntityPropertySetupper<MbMemberAddress> {
            public void Setup(MbMemberAddress entity, Object value) { entity.VersionNo = (value != null) ? (long?)value : null; }
        }
    }
}


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

    public class MemberLoginDbm : AbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(MemberLogin);

        private static readonly MemberLoginDbm _instance = new MemberLoginDbm();
        private MemberLoginDbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static MemberLoginDbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "member_login"; } }
        public override String TablePropertyName { get { return "MemberLogin"; } }
        public override String TableSqlName { get { return "member_login"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected ColumnInfo _columnMemberLoginId;
        protected ColumnInfo _columnMemberId;
        protected ColumnInfo _columnLoginDatetime;
        protected ColumnInfo _columnMobileLoginFlg;
        protected ColumnInfo _columnLoginMemberStatusCode;

        public ColumnInfo ColumnMemberLoginId { get { return _columnMemberLoginId; } }
        public ColumnInfo ColumnMemberId { get { return _columnMemberId; } }
        public ColumnInfo ColumnLoginDatetime { get { return _columnLoginDatetime; } }
        public ColumnInfo ColumnMobileLoginFlg { get { return _columnMobileLoginFlg; } }
        public ColumnInfo ColumnLoginMemberStatusCode { get { return _columnLoginMemberStatusCode; } }

        protected void InitializeColumnInfo() {
            _columnMemberLoginId = cci("MEMBER_LOGIN_ID", "MEMBER_LOGIN_ID", null, null, true, "MemberLoginId", typeof(long?), true, "BIGINT", 19, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnMemberId = cci("MEMBER_ID", "MEMBER_ID", null, null, true, "MemberId", typeof(int?), false, "INT", 10, 0, false, OptimisticLockType.NONE, null, "member", null);
            _columnLoginDatetime = cci("LOGIN_DATETIME", "LOGIN_DATETIME", null, null, true, "LoginDatetime", typeof(DateTime?), false, "DATETIME", 19, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnMobileLoginFlg = cci("MOBILE_LOGIN_FLG", "MOBILE_LOGIN_FLG", null, null, true, "MobileLoginFlg", typeof(int?), false, "INT", 10, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnLoginMemberStatusCode = cci("LOGIN_MEMBER_STATUS_CODE", "LOGIN_MEMBER_STATUS_CODE", null, null, true, "LoginMemberStatusCode", typeof(String), false, "CHAR", 3, 0, false, OptimisticLockType.NONE, null, "memberStatus", null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<ColumnInfo>();
            _columnInfoList.add(ColumnMemberLoginId);
            _columnInfoList.add(ColumnMemberId);
            _columnInfoList.add(ColumnLoginDatetime);
            _columnInfoList.add(ColumnMobileLoginFlg);
            _columnInfoList.add(ColumnLoginMemberStatusCode);
        }

        // ===============================================================================
        //                                                                     Unique Info
        //                                                                     ===========
        public override UniqueInfo PrimaryUniqueInfo { get {
            return cpui(ColumnMemberLoginId);
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
        public ForeignInfo ForeignMember { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(ColumnMemberId, MemberDbm.GetInstance().ColumnMemberId);
            return cfi("Member", this, MemberDbm.GetInstance(), map, 0, false, false);
        }}
        public ForeignInfo ForeignMemberStatus { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(ColumnLoginMemberStatusCode, MemberStatusDbm.GetInstance().ColumnMemberStatusCode);
            return cfi("MemberStatus", this, MemberStatusDbm.GetInstance(), map, 1, false, false);
        }}


        // -------------------------------------------------
        //                                  Referrer Element
        //                                  ----------------

        // ===============================================================================
        //                                                                    Various Info
        //                                                                    ============
        public override bool HasIdentity { get { return true; } }
        public override bool HasCommonColumn { get { return false; } }

        // ===============================================================================
        //                                                                 Name Definition
        //                                                                 ===============
        #region Name

        // -------------------------------------------------
        //                                             Table
        //                                             -----
        public static readonly String TABLE_DB_NAME = "member_login";
        public static readonly String TABLE_PROPERTY_NAME = "MemberLogin";

        // -------------------------------------------------
        //                                    Column DB-Name
        //                                    --------------
        public static readonly String DB_NAME_MEMBER_LOGIN_ID = "MEMBER_LOGIN_ID";
        public static readonly String DB_NAME_MEMBER_ID = "MEMBER_ID";
        public static readonly String DB_NAME_LOGIN_DATETIME = "LOGIN_DATETIME";
        public static readonly String DB_NAME_MOBILE_LOGIN_FLG = "MOBILE_LOGIN_FLG";
        public static readonly String DB_NAME_LOGIN_MEMBER_STATUS_CODE = "LOGIN_MEMBER_STATUS_CODE";

        // -------------------------------------------------
        //                              Column Property-Name
        //                              --------------------
        public static readonly String PROPERTY_NAME_MEMBER_LOGIN_ID = "MemberLoginId";
        public static readonly String PROPERTY_NAME_MEMBER_ID = "MemberId";
        public static readonly String PROPERTY_NAME_LOGIN_DATETIME = "LoginDatetime";
        public static readonly String PROPERTY_NAME_MOBILE_LOGIN_FLG = "MobileLoginFlg";
        public static readonly String PROPERTY_NAME_LOGIN_MEMBER_STATUS_CODE = "LoginMemberStatusCode";

        // -------------------------------------------------
        //                                      Foreign Name
        //                                      ------------
        public static readonly String FOREIGN_PROPERTY_NAME_Member = "Member";
        public static readonly String FOREIGN_PROPERTY_NAME_MemberStatus = "MemberStatus";
        // -------------------------------------------------
        //                                     Referrer Name
        //                                     -------------

        // -------------------------------------------------
        //                               DB-Property Mapping
        //                               -------------------
        protected static readonly Map<String, String> _dbNamePropertyNameKeyToLowerMap;
        protected static readonly Map<String, String> _propertyNameDbNameKeyToLowerMap;

        static MemberLoginDbm() {
            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_DB_NAME.ToLower(), TABLE_PROPERTY_NAME);
                map.put(DB_NAME_MEMBER_LOGIN_ID.ToLower(), PROPERTY_NAME_MEMBER_LOGIN_ID);
                map.put(DB_NAME_MEMBER_ID.ToLower(), PROPERTY_NAME_MEMBER_ID);
                map.put(DB_NAME_LOGIN_DATETIME.ToLower(), PROPERTY_NAME_LOGIN_DATETIME);
                map.put(DB_NAME_MOBILE_LOGIN_FLG.ToLower(), PROPERTY_NAME_MOBILE_LOGIN_FLG);
                map.put(DB_NAME_LOGIN_MEMBER_STATUS_CODE.ToLower(), PROPERTY_NAME_LOGIN_MEMBER_STATUS_CODE);
                _dbNamePropertyNameKeyToLowerMap = map;
            }

            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_PROPERTY_NAME.ToLower(), TABLE_DB_NAME);
                map.put(PROPERTY_NAME_MEMBER_LOGIN_ID.ToLower(), DB_NAME_MEMBER_LOGIN_ID);
                map.put(PROPERTY_NAME_MEMBER_ID.ToLower(), DB_NAME_MEMBER_ID);
                map.put(PROPERTY_NAME_LOGIN_DATETIME.ToLower(), DB_NAME_LOGIN_DATETIME);
                map.put(PROPERTY_NAME_MOBILE_LOGIN_FLG.ToLower(), DB_NAME_MOBILE_LOGIN_FLG);
                map.put(PROPERTY_NAME_LOGIN_MEMBER_STATUS_CODE.ToLower(), DB_NAME_LOGIN_MEMBER_STATUS_CODE);
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
        public override String EntityTypeName { get { return "DfExample.DBFlute.ExEntity.MemberLogin"; } }
        public override String DaoTypeName { get { return "DfExample.DBFlute.ExDao.MemberLoginDao"; } }
        public override String ConditionBeanTypeName { get { return "DfExample.DBFlute.CBean.MemberLoginCB"; } }
        public override String BehaviorTypeName { get { return "DfExample.DBFlute.ExBhv.MemberLoginBhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override Entity NewEntity() { return NewMyEntity(); }
        public MemberLogin NewMyEntity() { return new MemberLogin(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public MemberLoginCB NewMyConditionBean() { return new MemberLoginCB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<MemberLogin>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<MemberLogin>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("MEMBER_LOGIN_ID", "MemberLoginId", new EntityPropertyMemberLoginIdSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("MEMBER_ID", "MemberId", new EntityPropertyMemberIdSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("LOGIN_DATETIME", "LoginDatetime", new EntityPropertyLoginDatetimeSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("MOBILE_LOGIN_FLG", "MobileLoginFlg", new EntityPropertyMobileLoginFlgSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("LOGIN_MEMBER_STATUS_CODE", "LoginMemberStatusCode", new EntityPropertyLoginMemberStatusCodeSetupper(), _entityPropertySetupperMap);
        }

        public override bool HasEntityPropertySetupper(String propertyName) {
            return _entityPropertySetupperMap.containsKey(propertyName);
        }

        public override void SetupEntityProperty(String propertyName, Object entity, Object value) {
            EntityPropertySetupper<MemberLogin> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((MemberLogin)entity, value);
        }

        public class EntityPropertyMemberLoginIdSetupper : EntityPropertySetupper<MemberLogin> {
            public void Setup(MemberLogin entity, Object value) { entity.MemberLoginId = (value != null) ? (long?)value : null; }
        }
        public class EntityPropertyMemberIdSetupper : EntityPropertySetupper<MemberLogin> {
            public void Setup(MemberLogin entity, Object value) { entity.MemberId = (value != null) ? (int?)value : null; }
        }
        public class EntityPropertyLoginDatetimeSetupper : EntityPropertySetupper<MemberLogin> {
            public void Setup(MemberLogin entity, Object value) { entity.LoginDatetime = (value != null) ? (DateTime?)value : null; }
        }
        public class EntityPropertyMobileLoginFlgSetupper : EntityPropertySetupper<MemberLogin> {
            public void Setup(MemberLogin entity, Object value) { entity.MobileLoginFlg = (value != null) ? (int?)value : null; }
        }
        public class EntityPropertyLoginMemberStatusCodeSetupper : EntityPropertySetupper<MemberLogin> {
            public void Setup(MemberLogin entity, Object value) { entity.LoginMemberStatusCode = (value != null) ? (String)value : null; }
        }
    }
}

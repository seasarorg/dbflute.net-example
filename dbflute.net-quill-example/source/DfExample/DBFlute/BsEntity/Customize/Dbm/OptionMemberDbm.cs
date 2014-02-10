
using System;
using System.Reflection;

using DfExample.DBFlute.AllCommon;
using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.Dbm;
using DfExample.DBFlute.AllCommon.Dbm.Info;
using DfExample.DBFlute.AllCommon.JavaLike;
using DfExample.DBFlute.ExEntity.Customize;
namespace DfExample.DBFlute.BsEntity.Customize.Dbm {

    public class OptionMemberDbm : AbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(OptionMember);

        private static readonly OptionMemberDbm _instance = new OptionMemberDbm();
        private OptionMemberDbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static OptionMemberDbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "OptionMember"; } }
        public override String TablePropertyName { get { return "OptionMember"; } }
        public override String TableSqlName { get { return "OptionMember"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected ColumnInfo _columnMemberId;
        protected ColumnInfo _columnMemberName;
        protected ColumnInfo _columnBirthdate;
        protected ColumnInfo _columnFormalizedDatetime;
        protected ColumnInfo _columnMemberStatusCode;
        protected ColumnInfo _columnMemberStatusName;
        protected ColumnInfo _columnDummyFlg;
        protected ColumnInfo _columnDummyNoflg;

        public ColumnInfo ColumnMemberId { get { return _columnMemberId; } }
        public ColumnInfo ColumnMemberName { get { return _columnMemberName; } }
        public ColumnInfo ColumnBirthdate { get { return _columnBirthdate; } }
        public ColumnInfo ColumnFormalizedDatetime { get { return _columnFormalizedDatetime; } }
        public ColumnInfo ColumnMemberStatusCode { get { return _columnMemberStatusCode; } }
        public ColumnInfo ColumnMemberStatusName { get { return _columnMemberStatusName; } }
        public ColumnInfo ColumnDummyFlg { get { return _columnDummyFlg; } }
        public ColumnInfo ColumnDummyNoflg { get { return _columnDummyNoflg; } }

        protected void InitializeColumnInfo() {
            _columnMemberId = cci("MEMBER_ID", "MEMBER_ID", null, "会員ID", false, "MemberId", typeof(int?), false, "INT", 11, 0, false, OptimisticLockType.NONE, "連番", null, null);
            _columnMemberName = cci("MEMBER_NAME", "MEMBER_NAME", null, "会員名称", false, "MemberName", typeof(String), false, "VARCHAR", 200, 0, false, OptimisticLockType.NONE, "会員の表示用の名称(姓名)", null, null);
            _columnBirthdate = cci("BIRTHDATE", "BIRTHDATE", null, null, false, "Birthdate", typeof(DateTime?), false, "DATE", 10, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnFormalizedDatetime = cci("FORMALIZED_DATETIME", "FORMALIZED_DATETIME", null, null, false, "FormalizedDatetime", typeof(DateTime?), false, "DATETIME", 19, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnMemberStatusCode = cci("MEMBER_STATUS_CODE", "MEMBER_STATUS_CODE", null, null, false, "MemberStatusCode", typeof(String), false, "CHAR", 3, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnMemberStatusName = cci("MEMBER_STATUS_NAME", "MEMBER_STATUS_NAME", null, null, false, "MemberStatusName", typeof(String), false, "VARCHAR", 50, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnDummyFlg = cci("DUMMY_FLG", "DUMMY_FLG", null, null, false, "DummyFlg", typeof(long?), false, "BIGINT", 1, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnDummyNoflg = cci("DUMMY_NOFLG", "DUMMY_NOFLG", null, null, false, "DummyNoflg", typeof(long?), false, "BIGINT", 1, 0, false, OptimisticLockType.NONE, null, null, null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<ColumnInfo>();
            _columnInfoList.add(ColumnMemberId);
            _columnInfoList.add(ColumnMemberName);
            _columnInfoList.add(ColumnBirthdate);
            _columnInfoList.add(ColumnFormalizedDatetime);
            _columnInfoList.add(ColumnMemberStatusCode);
            _columnInfoList.add(ColumnMemberStatusName);
            _columnInfoList.add(ColumnDummyFlg);
            _columnInfoList.add(ColumnDummyNoflg);
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
        public static readonly String TABLE_DB_NAME = "OptionMember";
        public static readonly String TABLE_PROPERTY_NAME = "OptionMember";

        // -------------------------------------------------
        //                                    Column DB-Name
        //                                    --------------
        public static readonly String DB_NAME_MEMBER_ID = "MEMBER_ID";
        public static readonly String DB_NAME_MEMBER_NAME = "MEMBER_NAME";
        public static readonly String DB_NAME_BIRTHDATE = "BIRTHDATE";
        public static readonly String DB_NAME_FORMALIZED_DATETIME = "FORMALIZED_DATETIME";
        public static readonly String DB_NAME_MEMBER_STATUS_CODE = "MEMBER_STATUS_CODE";
        public static readonly String DB_NAME_MEMBER_STATUS_NAME = "MEMBER_STATUS_NAME";
        public static readonly String DB_NAME_DUMMY_FLG = "DUMMY_FLG";
        public static readonly String DB_NAME_DUMMY_NOFLG = "DUMMY_NOFLG";

        // -------------------------------------------------
        //                              Column Property-Name
        //                              --------------------
        public static readonly String PROPERTY_NAME_MEMBER_ID = "MemberId";
        public static readonly String PROPERTY_NAME_MEMBER_NAME = "MemberName";
        public static readonly String PROPERTY_NAME_BIRTHDATE = "Birthdate";
        public static readonly String PROPERTY_NAME_FORMALIZED_DATETIME = "FormalizedDatetime";
        public static readonly String PROPERTY_NAME_MEMBER_STATUS_CODE = "MemberStatusCode";
        public static readonly String PROPERTY_NAME_MEMBER_STATUS_NAME = "MemberStatusName";
        public static readonly String PROPERTY_NAME_DUMMY_FLG = "DummyFlg";
        public static readonly String PROPERTY_NAME_DUMMY_NOFLG = "DummyNoflg";

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

        static OptionMemberDbm() {
            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_DB_NAME.ToLower(), TABLE_PROPERTY_NAME);
                map.put(DB_NAME_MEMBER_ID.ToLower(), PROPERTY_NAME_MEMBER_ID);
                map.put(DB_NAME_MEMBER_NAME.ToLower(), PROPERTY_NAME_MEMBER_NAME);
                map.put(DB_NAME_BIRTHDATE.ToLower(), PROPERTY_NAME_BIRTHDATE);
                map.put(DB_NAME_FORMALIZED_DATETIME.ToLower(), PROPERTY_NAME_FORMALIZED_DATETIME);
                map.put(DB_NAME_MEMBER_STATUS_CODE.ToLower(), PROPERTY_NAME_MEMBER_STATUS_CODE);
                map.put(DB_NAME_MEMBER_STATUS_NAME.ToLower(), PROPERTY_NAME_MEMBER_STATUS_NAME);
                map.put(DB_NAME_DUMMY_FLG.ToLower(), PROPERTY_NAME_DUMMY_FLG);
                map.put(DB_NAME_DUMMY_NOFLG.ToLower(), PROPERTY_NAME_DUMMY_NOFLG);
                _dbNamePropertyNameKeyToLowerMap = map;
            }

            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_PROPERTY_NAME.ToLower(), TABLE_DB_NAME);
                map.put(PROPERTY_NAME_MEMBER_ID.ToLower(), DB_NAME_MEMBER_ID);
                map.put(PROPERTY_NAME_MEMBER_NAME.ToLower(), DB_NAME_MEMBER_NAME);
                map.put(PROPERTY_NAME_BIRTHDATE.ToLower(), DB_NAME_BIRTHDATE);
                map.put(PROPERTY_NAME_FORMALIZED_DATETIME.ToLower(), DB_NAME_FORMALIZED_DATETIME);
                map.put(PROPERTY_NAME_MEMBER_STATUS_CODE.ToLower(), DB_NAME_MEMBER_STATUS_CODE);
                map.put(PROPERTY_NAME_MEMBER_STATUS_NAME.ToLower(), DB_NAME_MEMBER_STATUS_NAME);
                map.put(PROPERTY_NAME_DUMMY_FLG.ToLower(), DB_NAME_DUMMY_FLG);
                map.put(PROPERTY_NAME_DUMMY_NOFLG.ToLower(), DB_NAME_DUMMY_NOFLG);
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
        public override String EntityTypeName { get { return "DfExample.DBFlute.ExEntity.Customize.OptionMember"; } }
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
        public OptionMember NewMyEntity() { return new OptionMember(); }
        public override ConditionBean NewConditionBean() {
            String msg = "The entity does not have condition-bean. So this method is invalid.";
            throw new SystemException(msg + " dbmeta=" + ToString());
        }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<OptionMember>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<OptionMember>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("MEMBER_ID", "MemberId", new EntityPropertyMemberIdSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("MEMBER_NAME", "MemberName", new EntityPropertyMemberNameSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("BIRTHDATE", "Birthdate", new EntityPropertyBirthdateSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("FORMALIZED_DATETIME", "FormalizedDatetime", new EntityPropertyFormalizedDatetimeSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("MEMBER_STATUS_CODE", "MemberStatusCode", new EntityPropertyMemberStatusCodeSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("MEMBER_STATUS_NAME", "MemberStatusName", new EntityPropertyMemberStatusNameSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("DUMMY_FLG", "DummyFlg", new EntityPropertyDummyFlgSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("DUMMY_NOFLG", "DummyNoflg", new EntityPropertyDummyNoflgSetupper(), _entityPropertySetupperMap);
        }

        public override bool HasEntityPropertySetupper(String propertyName) {
            return _entityPropertySetupperMap.containsKey(propertyName);
        }

        public override void SetupEntityProperty(String propertyName, Object entity, Object value) {
            EntityPropertySetupper<OptionMember> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((OptionMember)entity, value);
        }

        public class EntityPropertyMemberIdSetupper : EntityPropertySetupper<OptionMember> {
            public void Setup(OptionMember entity, Object value) { entity.MemberId = (value != null) ? (int?)value : null; }
        }
        public class EntityPropertyMemberNameSetupper : EntityPropertySetupper<OptionMember> {
            public void Setup(OptionMember entity, Object value) { entity.MemberName = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyBirthdateSetupper : EntityPropertySetupper<OptionMember> {
            public void Setup(OptionMember entity, Object value) { entity.Birthdate = (value != null) ? (DateTime?)value : null; }
        }
        public class EntityPropertyFormalizedDatetimeSetupper : EntityPropertySetupper<OptionMember> {
            public void Setup(OptionMember entity, Object value) { entity.FormalizedDatetime = (value != null) ? (DateTime?)value : null; }
        }
        public class EntityPropertyMemberStatusCodeSetupper : EntityPropertySetupper<OptionMember> {
            public void Setup(OptionMember entity, Object value) { entity.MemberStatusCode = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyMemberStatusNameSetupper : EntityPropertySetupper<OptionMember> {
            public void Setup(OptionMember entity, Object value) { entity.MemberStatusName = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyDummyFlgSetupper : EntityPropertySetupper<OptionMember> {
            public void Setup(OptionMember entity, Object value) { entity.DummyFlg = (value != null) ? (long?)value : null; }
        }
        public class EntityPropertyDummyNoflgSetupper : EntityPropertySetupper<OptionMember> {
            public void Setup(OptionMember entity, Object value) { entity.DummyNoflg = (value != null) ? (long?)value : null; }
        }
    }
}

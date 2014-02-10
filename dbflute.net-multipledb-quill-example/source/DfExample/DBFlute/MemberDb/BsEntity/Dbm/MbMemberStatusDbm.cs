
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

    public class MbMemberStatusDbm : MbAbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(MbMemberStatus);

        private static readonly MbMemberStatusDbm _instance = new MbMemberStatusDbm();
        private MbMemberStatusDbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static MbMemberStatusDbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "member_status"; } }
        public override String TablePropertyName { get { return "MemberStatus"; } }
        public override String TableSqlName { get { return "member_status"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected MbColumnInfo _columnMemberStatusCode;
        protected MbColumnInfo _columnMemberStatusName;
        protected MbColumnInfo _columnDisplayOrder;

        public MbColumnInfo ColumnMemberStatusCode { get { return _columnMemberStatusCode; } }
        public MbColumnInfo ColumnMemberStatusName { get { return _columnMemberStatusName; } }
        public MbColumnInfo ColumnDisplayOrder { get { return _columnDisplayOrder; } }

        protected void InitializeColumnInfo() {
            _columnMemberStatusCode = cci("MEMBER_STATUS_CODE", "MEMBER_STATUS_CODE", null, null, true, "MemberStatusCode", typeof(String), true, "CHAR", 3, 0, false, OptimisticLockType.NONE, null, null, "memberList,memberLoginList");
            _columnMemberStatusName = cci("MEMBER_STATUS_NAME", "MEMBER_STATUS_NAME", null, null, true, "MemberStatusName", typeof(String), false, "VARCHAR", 50, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnDisplayOrder = cci("DISPLAY_ORDER", "DISPLAY_ORDER", null, null, true, "DisplayOrder", typeof(int?), false, "INT", 10, 0, false, OptimisticLockType.NONE, null, null, null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<MbColumnInfo>();
            _columnInfoList.add(ColumnMemberStatusCode);
            _columnInfoList.add(ColumnMemberStatusName);
            _columnInfoList.add(ColumnDisplayOrder);
        }

        // ===============================================================================
        //                                                                     Unique Info
        //                                                                     ===========
        public override MbUniqueInfo PrimaryUniqueInfo { get {
            return cpui(ColumnMemberStatusCode);
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
        public MbReferrerInfo ReferrerMemberList { get {
            Map<MbColumnInfo, MbColumnInfo> map = new LinkedHashMap<MbColumnInfo, MbColumnInfo>();
            map.put(ColumnMemberStatusCode, MbMemberDbm.GetInstance().ColumnMemberStatusCode);
            return cri("MemberList", this, MbMemberDbm.GetInstance(), map, false);
        }}
        public MbReferrerInfo ReferrerMemberLoginList { get {
            Map<MbColumnInfo, MbColumnInfo> map = new LinkedHashMap<MbColumnInfo, MbColumnInfo>();
            map.put(ColumnMemberStatusCode, MbMemberLoginDbm.GetInstance().ColumnLoginMemberStatusCode);
            return cri("MemberLoginList", this, MbMemberLoginDbm.GetInstance(), map, false);
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
        public static readonly String TABLE_DB_NAME = "member_status";
        public static readonly String TABLE_PROPERTY_NAME = "MemberStatus";

        // -------------------------------------------------
        //                                    Column DB-Name
        //                                    --------------
        public static readonly String DB_NAME_MEMBER_STATUS_CODE = "MEMBER_STATUS_CODE";
        public static readonly String DB_NAME_MEMBER_STATUS_NAME = "MEMBER_STATUS_NAME";
        public static readonly String DB_NAME_DISPLAY_ORDER = "DISPLAY_ORDER";

        // -------------------------------------------------
        //                              Column Property-Name
        //                              --------------------
        public static readonly String PROPERTY_NAME_MEMBER_STATUS_CODE = "MemberStatusCode";
        public static readonly String PROPERTY_NAME_MEMBER_STATUS_NAME = "MemberStatusName";
        public static readonly String PROPERTY_NAME_DISPLAY_ORDER = "DisplayOrder";

        // -------------------------------------------------
        //                                      Foreign Name
        //                                      ------------
        // -------------------------------------------------
        //                                     Referrer Name
        //                                     -------------
        public static readonly String REFERRER_PROPERTY_NAME_MemberList = "MemberList";
        public static readonly String REFERRER_PROPERTY_NAME_MemberLoginList = "MemberLoginList";

        // -------------------------------------------------
        //                               DB-Property Mapping
        //                               -------------------
        protected static readonly Map<String, String> _dbNamePropertyNameKeyToLowerMap;
        protected static readonly Map<String, String> _propertyNameDbNameKeyToLowerMap;

        static MbMemberStatusDbm() {
            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_DB_NAME.ToLower(), TABLE_PROPERTY_NAME);
                map.put(DB_NAME_MEMBER_STATUS_CODE.ToLower(), PROPERTY_NAME_MEMBER_STATUS_CODE);
                map.put(DB_NAME_MEMBER_STATUS_NAME.ToLower(), PROPERTY_NAME_MEMBER_STATUS_NAME);
                map.put(DB_NAME_DISPLAY_ORDER.ToLower(), PROPERTY_NAME_DISPLAY_ORDER);
                _dbNamePropertyNameKeyToLowerMap = map;
            }

            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_PROPERTY_NAME.ToLower(), TABLE_DB_NAME);
                map.put(PROPERTY_NAME_MEMBER_STATUS_CODE.ToLower(), DB_NAME_MEMBER_STATUS_CODE);
                map.put(PROPERTY_NAME_MEMBER_STATUS_NAME.ToLower(), DB_NAME_MEMBER_STATUS_NAME);
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
        public override String EntityTypeName { get { return "DfExample.DBFlute.MemberDb.ExEntity.MbMemberStatus"; } }
        public override String DaoTypeName { get { return "DfExample.DBFlute.MemberDb.ExDao.MbMemberStatusDao"; } }
        public override String ConditionBeanTypeName { get { return "DfExample.DBFlute.MemberDb.CBean.MbMemberStatusCB"; } }
        public override String BehaviorTypeName { get { return "DfExample.DBFlute.MemberDb.ExBhv.MbMemberStatusBhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override MbEntity NewEntity() { return NewMyEntity(); }
        public MbMemberStatus NewMyEntity() { return new MbMemberStatus(); }
        public override MbConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public MbMemberStatusCB NewMyConditionBean() { return new MbMemberStatusCB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<MbMemberStatus>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<MbMemberStatus>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("MEMBER_STATUS_CODE", "MemberStatusCode", new EntityPropertyMemberStatusCodeSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("MEMBER_STATUS_NAME", "MemberStatusName", new EntityPropertyMemberStatusNameSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("DISPLAY_ORDER", "DisplayOrder", new EntityPropertyDisplayOrderSetupper(), _entityPropertySetupperMap);
        }

        public override bool HasEntityPropertySetupper(String propertyName) {
            return _entityPropertySetupperMap.containsKey(propertyName);
        }

        public override void SetupEntityProperty(String propertyName, Object entity, Object value) {
            EntityPropertySetupper<MbMemberStatus> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((MbMemberStatus)entity, value);
        }

        public class EntityPropertyMemberStatusCodeSetupper : EntityPropertySetupper<MbMemberStatus> {
            public void Setup(MbMemberStatus entity, Object value) { entity.MemberStatusCode = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyMemberStatusNameSetupper : EntityPropertySetupper<MbMemberStatus> {
            public void Setup(MbMemberStatus entity, Object value) { entity.MemberStatusName = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyDisplayOrderSetupper : EntityPropertySetupper<MbMemberStatus> {
            public void Setup(MbMemberStatus entity, Object value) { entity.DisplayOrder = (value != null) ? (int?)value : null; }
        }
    }
}

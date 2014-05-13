
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

    public class MemberStatusDbm : AbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(MemberStatus);

        private static readonly MemberStatusDbm _instance = new MemberStatusDbm();
        private MemberStatusDbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static MemberStatusDbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "MEMBER_STATUS"; } }
        public override String TablePropertyName { get { return "MemberStatus"; } }
        public override String TableSqlName { get { return "MEMBER_STATUS"; } }
        public override String TableAlias { get { return "会員ステータス"; } }
        public override String TableComment { get { return "固定の区分値"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected ColumnInfo _columnMemberStatusCode;
        protected ColumnInfo _columnMemberStatusName;
        protected ColumnInfo _columnDisplayOrder;

        public ColumnInfo ColumnMemberStatusCode { get { return _columnMemberStatusCode; } }
        public ColumnInfo ColumnMemberStatusName { get { return _columnMemberStatusName; } }
        public ColumnInfo ColumnDisplayOrder { get { return _columnDisplayOrder; } }

        protected void InitializeColumnInfo() {
            _columnMemberStatusCode = cci("MEMBER_STATUS_CODE", "MEMBER_STATUS_CODE", null, null, true, "MemberStatusCode", typeof(String), true, "CHAR", 3, 0, false, OptimisticLockType.NONE, null, null, "memberList,memberLoginList,memberVendorSynonymList,vdSynonymMemberList,vdSynonymMemberLoginList,vendorSynonymMemberList");
            _columnMemberStatusName = cci("MEMBER_STATUS_NAME", "MEMBER_STATUS_NAME", null, null, true, "MemberStatusName", typeof(String), false, "VARCHAR2", 50, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnDisplayOrder = cci("DISPLAY_ORDER", "DISPLAY_ORDER", null, null, true, "DisplayOrder", typeof(long?), false, "NUMBER", 16, 0, false, OptimisticLockType.NONE, null, null, null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<ColumnInfo>();
            _columnInfoList.add(ColumnMemberStatusCode);
            _columnInfoList.add(ColumnMemberStatusName);
            _columnInfoList.add(ColumnDisplayOrder);
        }

        // ===============================================================================
        //                                                                     Unique Info
        //                                                                     ===========
        public override UniqueInfo PrimaryUniqueInfo { get {
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
        public ReferrerInfo ReferrerMemberList { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(ColumnMemberStatusCode, MemberDbm.GetInstance().ColumnMemberStatusCode);
            return cri("MemberList", this, MemberDbm.GetInstance(), map, false);
        }}
        public ReferrerInfo ReferrerMemberLoginList { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(ColumnMemberStatusCode, MemberLoginDbm.GetInstance().ColumnLoginMemberStatusCode);
            return cri("MemberLoginList", this, MemberLoginDbm.GetInstance(), map, false);
        }}
        public ReferrerInfo ReferrerMemberVendorSynonymList { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(ColumnMemberStatusCode, MemberVendorSynonymDbm.GetInstance().ColumnMemberStatusCode);
            return cri("MemberVendorSynonymList", this, MemberVendorSynonymDbm.GetInstance(), map, false);
        }}
        public ReferrerInfo ReferrerVdSynonymMemberList { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(ColumnMemberStatusCode, VdSynonymMemberDbm.GetInstance().ColumnMemberStatusCode);
            return cri("VdSynonymMemberList", this, VdSynonymMemberDbm.GetInstance(), map, false);
        }}
        public ReferrerInfo ReferrerVdSynonymMemberLoginList { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(ColumnMemberStatusCode, VdSynonymMemberLoginDbm.GetInstance().ColumnLoginMemberStatusCode);
            return cri("VdSynonymMemberLoginList", this, VdSynonymMemberLoginDbm.GetInstance(), map, false);
        }}
        public ReferrerInfo ReferrerVendorSynonymMemberList { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(ColumnMemberStatusCode, VendorSynonymMemberDbm.GetInstance().ColumnMemberStatusCode);
            return cri("VendorSynonymMemberList", this, VendorSynonymMemberDbm.GetInstance(), map, false);
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
        public static readonly String TABLE_DB_NAME = "MEMBER_STATUS";
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
        public static readonly String REFERRER_PROPERTY_NAME_MemberVendorSynonymList = "MemberVendorSynonymList";
        public static readonly String REFERRER_PROPERTY_NAME_VdSynonymMemberList = "VdSynonymMemberList";
        public static readonly String REFERRER_PROPERTY_NAME_VdSynonymMemberLoginList = "VdSynonymMemberLoginList";
        public static readonly String REFERRER_PROPERTY_NAME_VendorSynonymMemberList = "VendorSynonymMemberList";

        // -------------------------------------------------
        //                               DB-Property Mapping
        //                               -------------------
        protected static readonly Map<String, String> _dbNamePropertyNameKeyToLowerMap;
        protected static readonly Map<String, String> _propertyNameDbNameKeyToLowerMap;

        static MemberStatusDbm() {
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
        public override String EntityTypeName { get { return "DfExample.DBFlute.ExEntity.MemberStatus"; } }
        public override String DaoTypeName { get { return "DfExample.DBFlute.ExDao.MemberStatusDao"; } }
        public override String ConditionBeanTypeName { get { return "DfExample.DBFlute.CBean.MemberStatusCB"; } }
        public override String BehaviorTypeName { get { return "DfExample.DBFlute.ExBhv.MemberStatusBhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override Entity NewEntity() { return NewMyEntity(); }
        public MemberStatus NewMyEntity() { return new MemberStatus(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public MemberStatusCB NewMyConditionBean() { return new MemberStatusCB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<MemberStatus>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<MemberStatus>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("MEMBER_STATUS_CODE", "MemberStatusCode", new EntityPropertyMemberStatusCodeSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("MEMBER_STATUS_NAME", "MemberStatusName", new EntityPropertyMemberStatusNameSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("DISPLAY_ORDER", "DisplayOrder", new EntityPropertyDisplayOrderSetupper(), _entityPropertySetupperMap);
        }

        public override bool HasEntityPropertySetupper(String propertyName) {
            return _entityPropertySetupperMap.containsKey(propertyName);
        }

        public override void SetupEntityProperty(String propertyName, Object entity, Object value) {
            EntityPropertySetupper<MemberStatus> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((MemberStatus)entity, value);
        }

        public class EntityPropertyMemberStatusCodeSetupper : EntityPropertySetupper<MemberStatus> {
            public void Setup(MemberStatus entity, Object value) { entity.MemberStatusCode = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyMemberStatusNameSetupper : EntityPropertySetupper<MemberStatus> {
            public void Setup(MemberStatus entity, Object value) { entity.MemberStatusName = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyDisplayOrderSetupper : EntityPropertySetupper<MemberStatus> {
            public void Setup(MemberStatus entity, Object value) { entity.DisplayOrder = (value != null) ? (long?)value : null; }
        }
    }
}

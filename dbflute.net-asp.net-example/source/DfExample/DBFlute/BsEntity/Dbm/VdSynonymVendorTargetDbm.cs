
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

    public class VdSynonymVendorTargetDbm : AbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(VdSynonymVendorTarget);

        private static readonly VdSynonymVendorTargetDbm _instance = new VdSynonymVendorTargetDbm();
        private VdSynonymVendorTargetDbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static VdSynonymVendorTargetDbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "VD_SYNONYM_VENDOR_TARGET"; } }
        public override String TablePropertyName { get { return "VdSynonymVendorTarget"; } }
        public override String TableSqlName { get { return "VD_SYNONYM_VENDOR_TARGET"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected ColumnInfo _columnVendorTargetId;
        protected ColumnInfo _columnVandorTargetName;

        public ColumnInfo ColumnVendorTargetId { get { return _columnVendorTargetId; } }
        public ColumnInfo ColumnVandorTargetName { get { return _columnVandorTargetName; } }

        protected void InitializeColumnInfo() {
            _columnVendorTargetId = cci("VENDOR_TARGET_ID", "VENDOR_TARGET_ID", null, null, true, "VendorTargetId", typeof(long?), true, "NUMBER", 16, 0, false, OptimisticLockType.NONE, null, null, "vdSynonymVendorRefTargetList");
            _columnVandorTargetName = cci("VANDOR_TARGET_NAME", "VANDOR_TARGET_NAME", null, null, false, "VandorTargetName", typeof(String), false, "VARCHAR2", 256, 0, false, OptimisticLockType.NONE, null, null, null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<ColumnInfo>();
            _columnInfoList.add(ColumnVendorTargetId);
            _columnInfoList.add(ColumnVandorTargetName);
        }

        // ===============================================================================
        //                                                                     Unique Info
        //                                                                     ===========
        public override UniqueInfo PrimaryUniqueInfo { get {
            return cpui(ColumnVendorTargetId);
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
        public ReferrerInfo ReferrerVdSynonymVendorRefTargetList { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(ColumnVendorTargetId, VdSynonymVendorRefTargetDbm.GetInstance().ColumnVendorTargetId);
            return cri("VdSynonymVendorRefTargetList", this, VdSynonymVendorRefTargetDbm.GetInstance(), map, false);
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
        public static readonly String TABLE_DB_NAME = "VD_SYNONYM_VENDOR_TARGET";
        public static readonly String TABLE_PROPERTY_NAME = "VdSynonymVendorTarget";

        // -------------------------------------------------
        //                                    Column DB-Name
        //                                    --------------
        public static readonly String DB_NAME_VENDOR_TARGET_ID = "VENDOR_TARGET_ID";
        public static readonly String DB_NAME_VANDOR_TARGET_NAME = "VANDOR_TARGET_NAME";

        // -------------------------------------------------
        //                              Column Property-Name
        //                              --------------------
        public static readonly String PROPERTY_NAME_VENDOR_TARGET_ID = "VendorTargetId";
        public static readonly String PROPERTY_NAME_VANDOR_TARGET_NAME = "VandorTargetName";

        // -------------------------------------------------
        //                                      Foreign Name
        //                                      ------------
        // -------------------------------------------------
        //                                     Referrer Name
        //                                     -------------
        public static readonly String REFERRER_PROPERTY_NAME_VdSynonymVendorRefTargetList = "VdSynonymVendorRefTargetList";

        // -------------------------------------------------
        //                               DB-Property Mapping
        //                               -------------------
        protected static readonly Map<String, String> _dbNamePropertyNameKeyToLowerMap;
        protected static readonly Map<String, String> _propertyNameDbNameKeyToLowerMap;

        static VdSynonymVendorTargetDbm() {
            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_DB_NAME.ToLower(), TABLE_PROPERTY_NAME);
                map.put(DB_NAME_VENDOR_TARGET_ID.ToLower(), PROPERTY_NAME_VENDOR_TARGET_ID);
                map.put(DB_NAME_VANDOR_TARGET_NAME.ToLower(), PROPERTY_NAME_VANDOR_TARGET_NAME);
                _dbNamePropertyNameKeyToLowerMap = map;
            }

            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_PROPERTY_NAME.ToLower(), TABLE_DB_NAME);
                map.put(PROPERTY_NAME_VENDOR_TARGET_ID.ToLower(), DB_NAME_VENDOR_TARGET_ID);
                map.put(PROPERTY_NAME_VANDOR_TARGET_NAME.ToLower(), DB_NAME_VANDOR_TARGET_NAME);
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
        public override String EntityTypeName { get { return "DfExample.DBFlute.ExEntity.VdSynonymVendorTarget"; } }
        public override String DaoTypeName { get { return "DfExample.DBFlute.ExDao.VdSynonymVendorTargetDao"; } }
        public override String ConditionBeanTypeName { get { return "DfExample.DBFlute.CBean.VdSynonymVendorTargetCB"; } }
        public override String BehaviorTypeName { get { return "DfExample.DBFlute.ExBhv.VdSynonymVendorTargetBhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override Entity NewEntity() { return NewMyEntity(); }
        public VdSynonymVendorTarget NewMyEntity() { return new VdSynonymVendorTarget(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public VdSynonymVendorTargetCB NewMyConditionBean() { return new VdSynonymVendorTargetCB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<VdSynonymVendorTarget>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<VdSynonymVendorTarget>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("VENDOR_TARGET_ID", "VendorTargetId", new EntityPropertyVendorTargetIdSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("VANDOR_TARGET_NAME", "VandorTargetName", new EntityPropertyVandorTargetNameSetupper(), _entityPropertySetupperMap);
        }

        public override bool HasEntityPropertySetupper(String propertyName) {
            return _entityPropertySetupperMap.containsKey(propertyName);
        }

        public override void SetupEntityProperty(String propertyName, Object entity, Object value) {
            EntityPropertySetupper<VdSynonymVendorTarget> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((VdSynonymVendorTarget)entity, value);
        }

        public class EntityPropertyVendorTargetIdSetupper : EntityPropertySetupper<VdSynonymVendorTarget> {
            public void Setup(VdSynonymVendorTarget entity, Object value) { entity.VendorTargetId = (value != null) ? (long?)value : null; }
        }
        public class EntityPropertyVandorTargetNameSetupper : EntityPropertySetupper<VdSynonymVendorTarget> {
            public void Setup(VdSynonymVendorTarget entity, Object value) { entity.VandorTargetName = (value != null) ? (String)value : null; }
        }
    }
}

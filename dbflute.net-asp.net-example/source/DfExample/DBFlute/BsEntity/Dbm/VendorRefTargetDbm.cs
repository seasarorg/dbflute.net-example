
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

    public class VendorRefTargetDbm : AbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(VendorRefTarget);

        private static readonly VendorRefTargetDbm _instance = new VendorRefTargetDbm();
        private VendorRefTargetDbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static VendorRefTargetDbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "VENDOR_REF_TARGET"; } }
        public override String TablePropertyName { get { return "VendorRefTarget"; } }
        public override String TableSqlName { get { return "VENDOR_REF_TARGET"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected ColumnInfo _columnVendorRefTargetId;
        protected ColumnInfo _columnVendorTargetId;

        public ColumnInfo ColumnVendorRefTargetId { get { return _columnVendorRefTargetId; } }
        public ColumnInfo ColumnVendorTargetId { get { return _columnVendorTargetId; } }

        protected void InitializeColumnInfo() {
            _columnVendorRefTargetId = cci("VENDOR_REF_TARGET_ID", "VENDOR_REF_TARGET_ID", null, null, true, "VendorRefTargetId", typeof(long?), true, "NUMBER", 16, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnVendorTargetId = cci("VENDOR_TARGET_ID", "VENDOR_TARGET_ID", null, null, true, "VendorTargetId", typeof(long?), false, "NUMBER", 16, 0, false, OptimisticLockType.NONE, null, "vendorTarget", null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<ColumnInfo>();
            _columnInfoList.add(ColumnVendorRefTargetId);
            _columnInfoList.add(ColumnVendorTargetId);
        }

        // ===============================================================================
        //                                                                     Unique Info
        //                                                                     ===========
        public override UniqueInfo PrimaryUniqueInfo { get {
            return cpui(ColumnVendorRefTargetId);
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
        public ForeignInfo ForeignVendorTarget { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(ColumnVendorTargetId, VendorTargetDbm.GetInstance().ColumnVendorTargetId);
            return cfi("VendorTarget", this, VendorTargetDbm.GetInstance(), map, 0, false, false);
        }}


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
        public static readonly String TABLE_DB_NAME = "VENDOR_REF_TARGET";
        public static readonly String TABLE_PROPERTY_NAME = "VendorRefTarget";

        // -------------------------------------------------
        //                                    Column DB-Name
        //                                    --------------
        public static readonly String DB_NAME_VENDOR_REF_TARGET_ID = "VENDOR_REF_TARGET_ID";
        public static readonly String DB_NAME_VENDOR_TARGET_ID = "VENDOR_TARGET_ID";

        // -------------------------------------------------
        //                              Column Property-Name
        //                              --------------------
        public static readonly String PROPERTY_NAME_VENDOR_REF_TARGET_ID = "VendorRefTargetId";
        public static readonly String PROPERTY_NAME_VENDOR_TARGET_ID = "VendorTargetId";

        // -------------------------------------------------
        //                                      Foreign Name
        //                                      ------------
        public static readonly String FOREIGN_PROPERTY_NAME_VendorTarget = "VendorTarget";
        // -------------------------------------------------
        //                                     Referrer Name
        //                                     -------------

        // -------------------------------------------------
        //                               DB-Property Mapping
        //                               -------------------
        protected static readonly Map<String, String> _dbNamePropertyNameKeyToLowerMap;
        protected static readonly Map<String, String> _propertyNameDbNameKeyToLowerMap;

        static VendorRefTargetDbm() {
            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_DB_NAME.ToLower(), TABLE_PROPERTY_NAME);
                map.put(DB_NAME_VENDOR_REF_TARGET_ID.ToLower(), PROPERTY_NAME_VENDOR_REF_TARGET_ID);
                map.put(DB_NAME_VENDOR_TARGET_ID.ToLower(), PROPERTY_NAME_VENDOR_TARGET_ID);
                _dbNamePropertyNameKeyToLowerMap = map;
            }

            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_PROPERTY_NAME.ToLower(), TABLE_DB_NAME);
                map.put(PROPERTY_NAME_VENDOR_REF_TARGET_ID.ToLower(), DB_NAME_VENDOR_REF_TARGET_ID);
                map.put(PROPERTY_NAME_VENDOR_TARGET_ID.ToLower(), DB_NAME_VENDOR_TARGET_ID);
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
        public override String EntityTypeName { get { return "DfExample.DBFlute.ExEntity.VendorRefTarget"; } }
        public override String DaoTypeName { get { return "DfExample.DBFlute.ExDao.VendorRefTargetDao"; } }
        public override String ConditionBeanTypeName { get { return "DfExample.DBFlute.CBean.VendorRefTargetCB"; } }
        public override String BehaviorTypeName { get { return "DfExample.DBFlute.ExBhv.VendorRefTargetBhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override Entity NewEntity() { return NewMyEntity(); }
        public VendorRefTarget NewMyEntity() { return new VendorRefTarget(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public VendorRefTargetCB NewMyConditionBean() { return new VendorRefTargetCB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<VendorRefTarget>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<VendorRefTarget>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("VENDOR_REF_TARGET_ID", "VendorRefTargetId", new EntityPropertyVendorRefTargetIdSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("VENDOR_TARGET_ID", "VendorTargetId", new EntityPropertyVendorTargetIdSetupper(), _entityPropertySetupperMap);
        }

        public override bool HasEntityPropertySetupper(String propertyName) {
            return _entityPropertySetupperMap.containsKey(propertyName);
        }

        public override void SetupEntityProperty(String propertyName, Object entity, Object value) {
            EntityPropertySetupper<VendorRefTarget> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((VendorRefTarget)entity, value);
        }

        public class EntityPropertyVendorRefTargetIdSetupper : EntityPropertySetupper<VendorRefTarget> {
            public void Setup(VendorRefTarget entity, Object value) { entity.VendorRefTargetId = (value != null) ? (long?)value : null; }
        }
        public class EntityPropertyVendorTargetIdSetupper : EntityPropertySetupper<VendorRefTarget> {
            public void Setup(VendorRefTarget entity, Object value) { entity.VendorTargetId = (value != null) ? (long?)value : null; }
        }
    }
}

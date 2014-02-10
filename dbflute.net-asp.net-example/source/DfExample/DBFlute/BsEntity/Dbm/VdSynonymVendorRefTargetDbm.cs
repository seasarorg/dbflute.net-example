
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

    public class VdSynonymVendorRefTargetDbm : AbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(VdSynonymVendorRefTarget);

        private static readonly VdSynonymVendorRefTargetDbm _instance = new VdSynonymVendorRefTargetDbm();
        private VdSynonymVendorRefTargetDbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static VdSynonymVendorRefTargetDbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "VD_SYNONYM_VENDOR_REF_TARGET"; } }
        public override String TablePropertyName { get { return "VdSynonymVendorRefTarget"; } }
        public override String TableSqlName { get { return "VD_SYNONYM_VENDOR_REF_TARGET"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected ColumnInfo _columnVendorRefTargetId;
        protected ColumnInfo _columnVendorTargetId;

        public ColumnInfo ColumnVendorRefTargetId { get { return _columnVendorRefTargetId; } }
        public ColumnInfo ColumnVendorTargetId { get { return _columnVendorTargetId; } }

        protected void InitializeColumnInfo() {
            _columnVendorRefTargetId = cci("VENDOR_REF_TARGET_ID", "VENDOR_REF_TARGET_ID", null, null, true, "VendorRefTargetId", typeof(long?), true, "NUMBER", 16, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnVendorTargetId = cci("VENDOR_TARGET_ID", "VENDOR_TARGET_ID", null, null, true, "VendorTargetId", typeof(long?), false, "NUMBER", 16, 0, false, OptimisticLockType.NONE, null, "vdSynonymVendorTarget", null);
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
        public ForeignInfo ForeignVdSynonymVendorTarget { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(ColumnVendorTargetId, VdSynonymVendorTargetDbm.GetInstance().ColumnVendorTargetId);
            return cfi("VdSynonymVendorTarget", this, VdSynonymVendorTargetDbm.GetInstance(), map, 0, false, false);
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
        public static readonly String TABLE_DB_NAME = "VD_SYNONYM_VENDOR_REF_TARGET";
        public static readonly String TABLE_PROPERTY_NAME = "VdSynonymVendorRefTarget";

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
        public static readonly String FOREIGN_PROPERTY_NAME_VdSynonymVendorTarget = "VdSynonymVendorTarget";
        // -------------------------------------------------
        //                                     Referrer Name
        //                                     -------------

        // -------------------------------------------------
        //                               DB-Property Mapping
        //                               -------------------
        protected static readonly Map<String, String> _dbNamePropertyNameKeyToLowerMap;
        protected static readonly Map<String, String> _propertyNameDbNameKeyToLowerMap;

        static VdSynonymVendorRefTargetDbm() {
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
        public override String EntityTypeName { get { return "DfExample.DBFlute.ExEntity.VdSynonymVendorRefTarget"; } }
        public override String DaoTypeName { get { return "DfExample.DBFlute.ExDao.VdSynonymVendorRefTargetDao"; } }
        public override String ConditionBeanTypeName { get { return "DfExample.DBFlute.CBean.VdSynonymVendorRefTargetCB"; } }
        public override String BehaviorTypeName { get { return "DfExample.DBFlute.ExBhv.VdSynonymVendorRefTargetBhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override Entity NewEntity() { return NewMyEntity(); }
        public VdSynonymVendorRefTarget NewMyEntity() { return new VdSynonymVendorRefTarget(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public VdSynonymVendorRefTargetCB NewMyConditionBean() { return new VdSynonymVendorRefTargetCB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<VdSynonymVendorRefTarget>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<VdSynonymVendorRefTarget>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("VENDOR_REF_TARGET_ID", "VendorRefTargetId", new EntityPropertyVendorRefTargetIdSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("VENDOR_TARGET_ID", "VendorTargetId", new EntityPropertyVendorTargetIdSetupper(), _entityPropertySetupperMap);
        }

        public override bool HasEntityPropertySetupper(String propertyName) {
            return _entityPropertySetupperMap.containsKey(propertyName);
        }

        public override void SetupEntityProperty(String propertyName, Object entity, Object value) {
            EntityPropertySetupper<VdSynonymVendorRefTarget> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((VdSynonymVendorRefTarget)entity, value);
        }

        public class EntityPropertyVendorRefTargetIdSetupper : EntityPropertySetupper<VdSynonymVendorRefTarget> {
            public void Setup(VdSynonymVendorRefTarget entity, Object value) { entity.VendorRefTargetId = (value != null) ? (long?)value : null; }
        }
        public class EntityPropertyVendorTargetIdSetupper : EntityPropertySetupper<VdSynonymVendorRefTarget> {
            public void Setup(VdSynonymVendorRefTarget entity, Object value) { entity.VendorTargetId = (value != null) ? (long?)value : null; }
        }
    }
}

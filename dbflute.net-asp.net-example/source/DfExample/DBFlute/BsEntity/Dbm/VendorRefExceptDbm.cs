
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

    public class VendorRefExceptDbm : AbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(VendorRefExcept);

        private static readonly VendorRefExceptDbm _instance = new VendorRefExceptDbm();
        private VendorRefExceptDbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static VendorRefExceptDbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "VENDOR_REF_EXCEPT"; } }
        public override String TablePropertyName { get { return "VendorRefExcept"; } }
        public override String TableSqlName { get { return "VENDOR_REF_EXCEPT"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected ColumnInfo _columnVendorRefExceptId;
        protected ColumnInfo _columnVendorExceptId;

        public ColumnInfo ColumnVendorRefExceptId { get { return _columnVendorRefExceptId; } }
        public ColumnInfo ColumnVendorExceptId { get { return _columnVendorExceptId; } }

        protected void InitializeColumnInfo() {
            _columnVendorRefExceptId = cci("VENDOR_REF_EXCEPT_ID", "VENDOR_REF_EXCEPT_ID", null, null, true, "VendorRefExceptId", typeof(long?), true, "NUMBER", 16, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnVendorExceptId = cci("VENDOR_EXCEPT_ID", "VENDOR_EXCEPT_ID", null, null, true, "VendorExceptId", typeof(long?), false, "NUMBER", 16, 0, false, OptimisticLockType.NONE, null, "vendorExcept", null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<ColumnInfo>();
            _columnInfoList.add(ColumnVendorRefExceptId);
            _columnInfoList.add(ColumnVendorExceptId);
        }

        // ===============================================================================
        //                                                                     Unique Info
        //                                                                     ===========
        public override UniqueInfo PrimaryUniqueInfo { get {
            return cpui(ColumnVendorRefExceptId);
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
        public ForeignInfo ForeignVendorExcept { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(ColumnVendorExceptId, VendorExceptDbm.GetInstance().ColumnVendorExceptId);
            return cfi("VendorExcept", this, VendorExceptDbm.GetInstance(), map, 0, false, false);
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
        public static readonly String TABLE_DB_NAME = "VENDOR_REF_EXCEPT";
        public static readonly String TABLE_PROPERTY_NAME = "VendorRefExcept";

        // -------------------------------------------------
        //                                    Column DB-Name
        //                                    --------------
        public static readonly String DB_NAME_VENDOR_REF_EXCEPT_ID = "VENDOR_REF_EXCEPT_ID";
        public static readonly String DB_NAME_VENDOR_EXCEPT_ID = "VENDOR_EXCEPT_ID";

        // -------------------------------------------------
        //                              Column Property-Name
        //                              --------------------
        public static readonly String PROPERTY_NAME_VENDOR_REF_EXCEPT_ID = "VendorRefExceptId";
        public static readonly String PROPERTY_NAME_VENDOR_EXCEPT_ID = "VendorExceptId";

        // -------------------------------------------------
        //                                      Foreign Name
        //                                      ------------
        public static readonly String FOREIGN_PROPERTY_NAME_VendorExcept = "VendorExcept";
        // -------------------------------------------------
        //                                     Referrer Name
        //                                     -------------

        // -------------------------------------------------
        //                               DB-Property Mapping
        //                               -------------------
        protected static readonly Map<String, String> _dbNamePropertyNameKeyToLowerMap;
        protected static readonly Map<String, String> _propertyNameDbNameKeyToLowerMap;

        static VendorRefExceptDbm() {
            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_DB_NAME.ToLower(), TABLE_PROPERTY_NAME);
                map.put(DB_NAME_VENDOR_REF_EXCEPT_ID.ToLower(), PROPERTY_NAME_VENDOR_REF_EXCEPT_ID);
                map.put(DB_NAME_VENDOR_EXCEPT_ID.ToLower(), PROPERTY_NAME_VENDOR_EXCEPT_ID);
                _dbNamePropertyNameKeyToLowerMap = map;
            }

            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_PROPERTY_NAME.ToLower(), TABLE_DB_NAME);
                map.put(PROPERTY_NAME_VENDOR_REF_EXCEPT_ID.ToLower(), DB_NAME_VENDOR_REF_EXCEPT_ID);
                map.put(PROPERTY_NAME_VENDOR_EXCEPT_ID.ToLower(), DB_NAME_VENDOR_EXCEPT_ID);
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
        public override String EntityTypeName { get { return "DfExample.DBFlute.ExEntity.VendorRefExcept"; } }
        public override String DaoTypeName { get { return "DfExample.DBFlute.ExDao.VendorRefExceptDao"; } }
        public override String ConditionBeanTypeName { get { return "DfExample.DBFlute.CBean.VendorRefExceptCB"; } }
        public override String BehaviorTypeName { get { return "DfExample.DBFlute.ExBhv.VendorRefExceptBhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override Entity NewEntity() { return NewMyEntity(); }
        public VendorRefExcept NewMyEntity() { return new VendorRefExcept(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public VendorRefExceptCB NewMyConditionBean() { return new VendorRefExceptCB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<VendorRefExcept>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<VendorRefExcept>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("VENDOR_REF_EXCEPT_ID", "VendorRefExceptId", new EntityPropertyVendorRefExceptIdSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("VENDOR_EXCEPT_ID", "VendorExceptId", new EntityPropertyVendorExceptIdSetupper(), _entityPropertySetupperMap);
        }

        public override bool HasEntityPropertySetupper(String propertyName) {
            return _entityPropertySetupperMap.containsKey(propertyName);
        }

        public override void SetupEntityProperty(String propertyName, Object entity, Object value) {
            EntityPropertySetupper<VendorRefExcept> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((VendorRefExcept)entity, value);
        }

        public class EntityPropertyVendorRefExceptIdSetupper : EntityPropertySetupper<VendorRefExcept> {
            public void Setup(VendorRefExcept entity, Object value) { entity.VendorRefExceptId = (value != null) ? (long?)value : null; }
        }
        public class EntityPropertyVendorExceptIdSetupper : EntityPropertySetupper<VendorRefExcept> {
            public void Setup(VendorRefExcept entity, Object value) { entity.VendorExceptId = (value != null) ? (long?)value : null; }
        }
    }
}


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

    public class VdSynonymVendorExceptDbm : AbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(VdSynonymVendorExcept);

        private static readonly VdSynonymVendorExceptDbm _instance = new VdSynonymVendorExceptDbm();
        private VdSynonymVendorExceptDbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static VdSynonymVendorExceptDbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "VD_SYNONYM_VENDOR_EXCEPT"; } }
        public override String TablePropertyName { get { return "VdSynonymVendorExcept"; } }
        public override String TableSqlName { get { return "VD_SYNONYM_VENDOR_EXCEPT"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected ColumnInfo _columnVendorExceptId;
        protected ColumnInfo _columnVandorExceptName;

        public ColumnInfo ColumnVendorExceptId { get { return _columnVendorExceptId; } }
        public ColumnInfo ColumnVandorExceptName { get { return _columnVandorExceptName; } }

        protected void InitializeColumnInfo() {
            _columnVendorExceptId = cci("VENDOR_EXCEPT_ID", "VENDOR_EXCEPT_ID", null, null, true, "VendorExceptId", typeof(long?), true, "NUMBER", 16, 0, false, OptimisticLockType.NONE, null, null, "vdSynonymVendorRefExceptList");
            _columnVandorExceptName = cci("VANDOR_EXCEPT_NAME", "VANDOR_EXCEPT_NAME", null, null, false, "VandorExceptName", typeof(String), false, "VARCHAR2", 256, 0, false, OptimisticLockType.NONE, null, null, null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<ColumnInfo>();
            _columnInfoList.add(ColumnVendorExceptId);
            _columnInfoList.add(ColumnVandorExceptName);
        }

        // ===============================================================================
        //                                                                     Unique Info
        //                                                                     ===========
        public override UniqueInfo PrimaryUniqueInfo { get {
            return cpui(ColumnVendorExceptId);
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
        public ReferrerInfo ReferrerVdSynonymVendorRefExceptList { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(ColumnVendorExceptId, VdSynonymVendorRefExceptDbm.GetInstance().ColumnVendorExceptId);
            return cri("VdSynonymVendorRefExceptList", this, VdSynonymVendorRefExceptDbm.GetInstance(), map, false);
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
        public static readonly String TABLE_DB_NAME = "VD_SYNONYM_VENDOR_EXCEPT";
        public static readonly String TABLE_PROPERTY_NAME = "VdSynonymVendorExcept";

        // -------------------------------------------------
        //                                    Column DB-Name
        //                                    --------------
        public static readonly String DB_NAME_VENDOR_EXCEPT_ID = "VENDOR_EXCEPT_ID";
        public static readonly String DB_NAME_VANDOR_EXCEPT_NAME = "VANDOR_EXCEPT_NAME";

        // -------------------------------------------------
        //                              Column Property-Name
        //                              --------------------
        public static readonly String PROPERTY_NAME_VENDOR_EXCEPT_ID = "VendorExceptId";
        public static readonly String PROPERTY_NAME_VANDOR_EXCEPT_NAME = "VandorExceptName";

        // -------------------------------------------------
        //                                      Foreign Name
        //                                      ------------
        // -------------------------------------------------
        //                                     Referrer Name
        //                                     -------------
        public static readonly String REFERRER_PROPERTY_NAME_VdSynonymVendorRefExceptList = "VdSynonymVendorRefExceptList";

        // -------------------------------------------------
        //                               DB-Property Mapping
        //                               -------------------
        protected static readonly Map<String, String> _dbNamePropertyNameKeyToLowerMap;
        protected static readonly Map<String, String> _propertyNameDbNameKeyToLowerMap;

        static VdSynonymVendorExceptDbm() {
            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_DB_NAME.ToLower(), TABLE_PROPERTY_NAME);
                map.put(DB_NAME_VENDOR_EXCEPT_ID.ToLower(), PROPERTY_NAME_VENDOR_EXCEPT_ID);
                map.put(DB_NAME_VANDOR_EXCEPT_NAME.ToLower(), PROPERTY_NAME_VANDOR_EXCEPT_NAME);
                _dbNamePropertyNameKeyToLowerMap = map;
            }

            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_PROPERTY_NAME.ToLower(), TABLE_DB_NAME);
                map.put(PROPERTY_NAME_VENDOR_EXCEPT_ID.ToLower(), DB_NAME_VENDOR_EXCEPT_ID);
                map.put(PROPERTY_NAME_VANDOR_EXCEPT_NAME.ToLower(), DB_NAME_VANDOR_EXCEPT_NAME);
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
        public override String EntityTypeName { get { return "DfExample.DBFlute.ExEntity.VdSynonymVendorExcept"; } }
        public override String DaoTypeName { get { return "DfExample.DBFlute.ExDao.VdSynonymVendorExceptDao"; } }
        public override String ConditionBeanTypeName { get { return "DfExample.DBFlute.CBean.VdSynonymVendorExceptCB"; } }
        public override String BehaviorTypeName { get { return "DfExample.DBFlute.ExBhv.VdSynonymVendorExceptBhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override Entity NewEntity() { return NewMyEntity(); }
        public VdSynonymVendorExcept NewMyEntity() { return new VdSynonymVendorExcept(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public VdSynonymVendorExceptCB NewMyConditionBean() { return new VdSynonymVendorExceptCB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<VdSynonymVendorExcept>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<VdSynonymVendorExcept>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("VENDOR_EXCEPT_ID", "VendorExceptId", new EntityPropertyVendorExceptIdSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("VANDOR_EXCEPT_NAME", "VandorExceptName", new EntityPropertyVandorExceptNameSetupper(), _entityPropertySetupperMap);
        }

        public override bool HasEntityPropertySetupper(String propertyName) {
            return _entityPropertySetupperMap.containsKey(propertyName);
        }

        public override void SetupEntityProperty(String propertyName, Object entity, Object value) {
            EntityPropertySetupper<VdSynonymVendorExcept> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((VdSynonymVendorExcept)entity, value);
        }

        public class EntityPropertyVendorExceptIdSetupper : EntityPropertySetupper<VdSynonymVendorExcept> {
            public void Setup(VdSynonymVendorExcept entity, Object value) { entity.VendorExceptId = (value != null) ? (long?)value : null; }
        }
        public class EntityPropertyVandorExceptNameSetupper : EntityPropertySetupper<VdSynonymVendorExcept> {
            public void Setup(VdSynonymVendorExcept entity, Object value) { entity.VandorExceptName = (value != null) ? (String)value : null; }
        }
    }
}

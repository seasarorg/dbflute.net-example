
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

    public class VendorLargeName901234567890Dbm : AbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(VendorLargeName901234567890);

        private static readonly VendorLargeName901234567890Dbm _instance = new VendorLargeName901234567890Dbm();
        private VendorLargeName901234567890Dbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static VendorLargeName901234567890Dbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "VENDOR_LARGE_NAME_901234567890"; } }
        public override String TablePropertyName { get { return "VendorLargeName901234567890"; } }
        public override String TableSqlName { get { return "VENDOR_LARGE_NAME_901234567890"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected ColumnInfo _columnVendorLargeName901234567Id;
        protected ColumnInfo _columnVendorLargeName9012345Name;

        public ColumnInfo ColumnVendorLargeName901234567Id { get { return _columnVendorLargeName901234567Id; } }
        public ColumnInfo ColumnVendorLargeName9012345Name { get { return _columnVendorLargeName9012345Name; } }

        protected void InitializeColumnInfo() {
            _columnVendorLargeName901234567Id = cci("VENDOR_LARGE_NAME_901234567_ID", "VENDOR_LARGE_NAME_901234567_ID", null, null, true, "VendorLargeName901234567Id", typeof(long?), true, "NUMBER", 16, 0, false, OptimisticLockType.NONE, null, null, "vendorLargeName90123456RefList");
            _columnVendorLargeName9012345Name = cci("VENDOR_LARGE_NAME_9012345_NAME", "VENDOR_LARGE_NAME_9012345_NAME", null, null, true, "VendorLargeName9012345Name", typeof(String), false, "VARCHAR2", 32, 0, false, OptimisticLockType.NONE, null, null, null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<ColumnInfo>();
            _columnInfoList.add(ColumnVendorLargeName901234567Id);
            _columnInfoList.add(ColumnVendorLargeName9012345Name);
        }

        // ===============================================================================
        //                                                                     Unique Info
        //                                                                     ===========
        public override UniqueInfo PrimaryUniqueInfo { get {
            return cpui(ColumnVendorLargeName901234567Id);
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
        public ReferrerInfo ReferrerVendorLargeName90123456RefList { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(ColumnVendorLargeName901234567Id, VendorLargeName90123456RefDbm.GetInstance().ColumnVendorLargeName901234567Id);
            return cri("VendorLargeName90123456RefList", this, VendorLargeName90123456RefDbm.GetInstance(), map, false);
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
        public static readonly String TABLE_DB_NAME = "VENDOR_LARGE_NAME_901234567890";
        public static readonly String TABLE_PROPERTY_NAME = "VendorLargeName901234567890";

        // -------------------------------------------------
        //                                    Column DB-Name
        //                                    --------------
        public static readonly String DB_NAME_VENDOR_LARGE_NAME_901234567_ID = "VENDOR_LARGE_NAME_901234567_ID";
        public static readonly String DB_NAME_VENDOR_LARGE_NAME_9012345_NAME = "VENDOR_LARGE_NAME_9012345_NAME";

        // -------------------------------------------------
        //                              Column Property-Name
        //                              --------------------
        public static readonly String PROPERTY_NAME_VENDOR_LARGE_NAME_901234567_ID = "VendorLargeName901234567Id";
        public static readonly String PROPERTY_NAME_VENDOR_LARGE_NAME_9012345_NAME = "VendorLargeName9012345Name";

        // -------------------------------------------------
        //                                      Foreign Name
        //                                      ------------
        // -------------------------------------------------
        //                                     Referrer Name
        //                                     -------------
        public static readonly String REFERRER_PROPERTY_NAME_VendorLargeName90123456RefList = "VendorLargeName90123456RefList";

        // -------------------------------------------------
        //                               DB-Property Mapping
        //                               -------------------
        protected static readonly Map<String, String> _dbNamePropertyNameKeyToLowerMap;
        protected static readonly Map<String, String> _propertyNameDbNameKeyToLowerMap;

        static VendorLargeName901234567890Dbm() {
            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_DB_NAME.ToLower(), TABLE_PROPERTY_NAME);
                map.put(DB_NAME_VENDOR_LARGE_NAME_901234567_ID.ToLower(), PROPERTY_NAME_VENDOR_LARGE_NAME_901234567_ID);
                map.put(DB_NAME_VENDOR_LARGE_NAME_9012345_NAME.ToLower(), PROPERTY_NAME_VENDOR_LARGE_NAME_9012345_NAME);
                _dbNamePropertyNameKeyToLowerMap = map;
            }

            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_PROPERTY_NAME.ToLower(), TABLE_DB_NAME);
                map.put(PROPERTY_NAME_VENDOR_LARGE_NAME_901234567_ID.ToLower(), DB_NAME_VENDOR_LARGE_NAME_901234567_ID);
                map.put(PROPERTY_NAME_VENDOR_LARGE_NAME_9012345_NAME.ToLower(), DB_NAME_VENDOR_LARGE_NAME_9012345_NAME);
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
        public override String EntityTypeName { get { return "DfExample.DBFlute.ExEntity.VendorLargeName901234567890"; } }
        public override String DaoTypeName { get { return "DfExample.DBFlute.ExDao.VendorLargeName901234567890Dao"; } }
        public override String ConditionBeanTypeName { get { return "DfExample.DBFlute.CBean.VendorLargeName901234567890CB"; } }
        public override String BehaviorTypeName { get { return "DfExample.DBFlute.ExBhv.VendorLargeName901234567890Bhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override Entity NewEntity() { return NewMyEntity(); }
        public VendorLargeName901234567890 NewMyEntity() { return new VendorLargeName901234567890(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public VendorLargeName901234567890CB NewMyConditionBean() { return new VendorLargeName901234567890CB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<VendorLargeName901234567890>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<VendorLargeName901234567890>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("VENDOR_LARGE_NAME_901234567_ID", "VendorLargeName901234567Id", new EntityPropertyVendorLargeName901234567IdSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("VENDOR_LARGE_NAME_9012345_NAME", "VendorLargeName9012345Name", new EntityPropertyVendorLargeName9012345NameSetupper(), _entityPropertySetupperMap);
        }

        public override bool HasEntityPropertySetupper(String propertyName) {
            return _entityPropertySetupperMap.containsKey(propertyName);
        }

        public override void SetupEntityProperty(String propertyName, Object entity, Object value) {
            EntityPropertySetupper<VendorLargeName901234567890> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((VendorLargeName901234567890)entity, value);
        }

        public class EntityPropertyVendorLargeName901234567IdSetupper : EntityPropertySetupper<VendorLargeName901234567890> {
            public void Setup(VendorLargeName901234567890 entity, Object value) { entity.VendorLargeName901234567Id = (value != null) ? (long?)value : null; }
        }
        public class EntityPropertyVendorLargeName9012345NameSetupper : EntityPropertySetupper<VendorLargeName901234567890> {
            public void Setup(VendorLargeName901234567890 entity, Object value) { entity.VendorLargeName9012345Name = (value != null) ? (String)value : null; }
        }
    }
}


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

    public class VendorLargeName90123456RefDbm : AbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(VendorLargeName90123456Ref);

        private static readonly VendorLargeName90123456RefDbm _instance = new VendorLargeName90123456RefDbm();
        private VendorLargeName90123456RefDbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static VendorLargeName90123456RefDbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "VENDOR_LARGE_NAME_90123456_REF"; } }
        public override String TablePropertyName { get { return "VendorLargeName90123456Ref"; } }
        public override String TableSqlName { get { return "VENDOR_LARGE_NAME_90123456_REF"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected ColumnInfo _columnVendorLargeName90123RefId;
        protected ColumnInfo _columnVendorLargeName901RefName;
        protected ColumnInfo _columnVendorLargeName901234567Id;

        public ColumnInfo ColumnVendorLargeName90123RefId { get { return _columnVendorLargeName90123RefId; } }
        public ColumnInfo ColumnVendorLargeName901RefName { get { return _columnVendorLargeName901RefName; } }
        public ColumnInfo ColumnVendorLargeName901234567Id { get { return _columnVendorLargeName901234567Id; } }

        protected void InitializeColumnInfo() {
            _columnVendorLargeName90123RefId = cci("VENDOR_LARGE_NAME_90123_REF_ID", "VENDOR_LARGE_NAME_90123_REF_ID", null, null, true, "VendorLargeName90123RefId", typeof(long?), true, "NUMBER", 16, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnVendorLargeName901RefName = cci("VENDOR_LARGE_NAME_901_REF_NAME", "VENDOR_LARGE_NAME_901_REF_NAME", null, null, true, "VendorLargeName901RefName", typeof(String), false, "VARCHAR2", 32, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnVendorLargeName901234567Id = cci("VENDOR_LARGE_NAME_901234567_ID", "VENDOR_LARGE_NAME_901234567_ID", null, null, false, "VendorLargeName901234567Id", typeof(long?), false, "NUMBER", 16, 0, false, OptimisticLockType.NONE, null, "vendorLargeName901234567890", null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<ColumnInfo>();
            _columnInfoList.add(ColumnVendorLargeName90123RefId);
            _columnInfoList.add(ColumnVendorLargeName901RefName);
            _columnInfoList.add(ColumnVendorLargeName901234567Id);
        }

        // ===============================================================================
        //                                                                     Unique Info
        //                                                                     ===========
        public override UniqueInfo PrimaryUniqueInfo { get {
            return cpui(ColumnVendorLargeName90123RefId);
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
        public ForeignInfo ForeignVendorLargeName901234567890 { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(ColumnVendorLargeName901234567Id, VendorLargeName901234567890Dbm.GetInstance().ColumnVendorLargeName901234567Id);
            return cfi("VendorLargeName901234567890", this, VendorLargeName901234567890Dbm.GetInstance(), map, 0, false, false);
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
        public static readonly String TABLE_DB_NAME = "VENDOR_LARGE_NAME_90123456_REF";
        public static readonly String TABLE_PROPERTY_NAME = "VendorLargeName90123456Ref";

        // -------------------------------------------------
        //                                    Column DB-Name
        //                                    --------------
        public static readonly String DB_NAME_VENDOR_LARGE_NAME_90123_REF_ID = "VENDOR_LARGE_NAME_90123_REF_ID";
        public static readonly String DB_NAME_VENDOR_LARGE_NAME_901_REF_NAME = "VENDOR_LARGE_NAME_901_REF_NAME";
        public static readonly String DB_NAME_VENDOR_LARGE_NAME_901234567_ID = "VENDOR_LARGE_NAME_901234567_ID";

        // -------------------------------------------------
        //                              Column Property-Name
        //                              --------------------
        public static readonly String PROPERTY_NAME_VENDOR_LARGE_NAME_90123_REF_ID = "VendorLargeName90123RefId";
        public static readonly String PROPERTY_NAME_VENDOR_LARGE_NAME_901_REF_NAME = "VendorLargeName901RefName";
        public static readonly String PROPERTY_NAME_VENDOR_LARGE_NAME_901234567_ID = "VendorLargeName901234567Id";

        // -------------------------------------------------
        //                                      Foreign Name
        //                                      ------------
        public static readonly String FOREIGN_PROPERTY_NAME_VendorLargeName901234567890 = "VendorLargeName901234567890";
        // -------------------------------------------------
        //                                     Referrer Name
        //                                     -------------

        // -------------------------------------------------
        //                               DB-Property Mapping
        //                               -------------------
        protected static readonly Map<String, String> _dbNamePropertyNameKeyToLowerMap;
        protected static readonly Map<String, String> _propertyNameDbNameKeyToLowerMap;

        static VendorLargeName90123456RefDbm() {
            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_DB_NAME.ToLower(), TABLE_PROPERTY_NAME);
                map.put(DB_NAME_VENDOR_LARGE_NAME_90123_REF_ID.ToLower(), PROPERTY_NAME_VENDOR_LARGE_NAME_90123_REF_ID);
                map.put(DB_NAME_VENDOR_LARGE_NAME_901_REF_NAME.ToLower(), PROPERTY_NAME_VENDOR_LARGE_NAME_901_REF_NAME);
                map.put(DB_NAME_VENDOR_LARGE_NAME_901234567_ID.ToLower(), PROPERTY_NAME_VENDOR_LARGE_NAME_901234567_ID);
                _dbNamePropertyNameKeyToLowerMap = map;
            }

            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_PROPERTY_NAME.ToLower(), TABLE_DB_NAME);
                map.put(PROPERTY_NAME_VENDOR_LARGE_NAME_90123_REF_ID.ToLower(), DB_NAME_VENDOR_LARGE_NAME_90123_REF_ID);
                map.put(PROPERTY_NAME_VENDOR_LARGE_NAME_901_REF_NAME.ToLower(), DB_NAME_VENDOR_LARGE_NAME_901_REF_NAME);
                map.put(PROPERTY_NAME_VENDOR_LARGE_NAME_901234567_ID.ToLower(), DB_NAME_VENDOR_LARGE_NAME_901234567_ID);
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
        public override String EntityTypeName { get { return "DfExample.DBFlute.ExEntity.VendorLargeName90123456Ref"; } }
        public override String DaoTypeName { get { return "DfExample.DBFlute.ExDao.VendorLargeName90123456RefDao"; } }
        public override String ConditionBeanTypeName { get { return "DfExample.DBFlute.CBean.VendorLargeName90123456RefCB"; } }
        public override String BehaviorTypeName { get { return "DfExample.DBFlute.ExBhv.VendorLargeName90123456RefBhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override Entity NewEntity() { return NewMyEntity(); }
        public VendorLargeName90123456Ref NewMyEntity() { return new VendorLargeName90123456Ref(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public VendorLargeName90123456RefCB NewMyConditionBean() { return new VendorLargeName90123456RefCB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<VendorLargeName90123456Ref>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<VendorLargeName90123456Ref>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("VENDOR_LARGE_NAME_90123_REF_ID", "VendorLargeName90123RefId", new EntityPropertyVendorLargeName90123RefIdSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("VENDOR_LARGE_NAME_901_REF_NAME", "VendorLargeName901RefName", new EntityPropertyVendorLargeName901RefNameSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("VENDOR_LARGE_NAME_901234567_ID", "VendorLargeName901234567Id", new EntityPropertyVendorLargeName901234567IdSetupper(), _entityPropertySetupperMap);
        }

        public override bool HasEntityPropertySetupper(String propertyName) {
            return _entityPropertySetupperMap.containsKey(propertyName);
        }

        public override void SetupEntityProperty(String propertyName, Object entity, Object value) {
            EntityPropertySetupper<VendorLargeName90123456Ref> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((VendorLargeName90123456Ref)entity, value);
        }

        public class EntityPropertyVendorLargeName90123RefIdSetupper : EntityPropertySetupper<VendorLargeName90123456Ref> {
            public void Setup(VendorLargeName90123456Ref entity, Object value) { entity.VendorLargeName90123RefId = (value != null) ? (long?)value : null; }
        }
        public class EntityPropertyVendorLargeName901RefNameSetupper : EntityPropertySetupper<VendorLargeName90123456Ref> {
            public void Setup(VendorLargeName90123456Ref entity, Object value) { entity.VendorLargeName901RefName = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyVendorLargeName901234567IdSetupper : EntityPropertySetupper<VendorLargeName90123456Ref> {
            public void Setup(VendorLargeName90123456Ref entity, Object value) { entity.VendorLargeName901234567Id = (value != null) ? (long?)value : null; }
        }
    }
}


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

    public class VendorSelfReferenceDbm : AbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(VendorSelfReference);

        private static readonly VendorSelfReferenceDbm _instance = new VendorSelfReferenceDbm();
        private VendorSelfReferenceDbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static VendorSelfReferenceDbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "vendor_self_reference"; } }
        public override String TablePropertyName { get { return "VendorSelfReference"; } }
        public override String TableSqlName { get { return "vendor_self_reference"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected ColumnInfo _columnSelfReferenceId;
        protected ColumnInfo _columnSelfReferenceName;
        protected ColumnInfo _columnParentId;

        public ColumnInfo ColumnSelfReferenceId { get { return _columnSelfReferenceId; } }
        public ColumnInfo ColumnSelfReferenceName { get { return _columnSelfReferenceName; } }
        public ColumnInfo ColumnParentId { get { return _columnParentId; } }

        protected void InitializeColumnInfo() {
            _columnSelfReferenceId = cci("SELF_REFERENCE_ID", "SELF_REFERENCE_ID", null, null, true, "SelfReferenceId", typeof(long?), true, "DECIMAL", 16, 0, false, OptimisticLockType.NONE, null, null, "vendorSelfReferenceSelfList");
            _columnSelfReferenceName = cci("SELF_REFERENCE_NAME", "SELF_REFERENCE_NAME", null, null, true, "SelfReferenceName", typeof(String), false, "VARCHAR", 200, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnParentId = cci("PARENT_ID", "PARENT_ID", null, null, false, "ParentId", typeof(long?), false, "DECIMAL", 16, 0, false, OptimisticLockType.NONE, null, "vendorSelfReferenceSelf", null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<ColumnInfo>();
            _columnInfoList.add(ColumnSelfReferenceId);
            _columnInfoList.add(ColumnSelfReferenceName);
            _columnInfoList.add(ColumnParentId);
        }

        // ===============================================================================
        //                                                                     Unique Info
        //                                                                     ===========
        public override UniqueInfo PrimaryUniqueInfo { get {
            return cpui(ColumnSelfReferenceId);
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
        public ForeignInfo ForeignVendorSelfReferenceSelf { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(ColumnParentId, VendorSelfReferenceDbm.GetInstance().ColumnSelfReferenceId);
            return cfi("VendorSelfReferenceSelf", this, VendorSelfReferenceDbm.GetInstance(), map, 0, false, false);
        }}


        // -------------------------------------------------
        //                                  Referrer Element
        //                                  ----------------
        public ReferrerInfo ReferrerVendorSelfReferenceSelfList { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(ColumnSelfReferenceId, VendorSelfReferenceDbm.GetInstance().ColumnParentId);
            return cri("VendorSelfReferenceSelfList", this, VendorSelfReferenceDbm.GetInstance(), map, false);
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
        public static readonly String TABLE_DB_NAME = "vendor_self_reference";
        public static readonly String TABLE_PROPERTY_NAME = "VendorSelfReference";

        // -------------------------------------------------
        //                                    Column DB-Name
        //                                    --------------
        public static readonly String DB_NAME_SELF_REFERENCE_ID = "SELF_REFERENCE_ID";
        public static readonly String DB_NAME_SELF_REFERENCE_NAME = "SELF_REFERENCE_NAME";
        public static readonly String DB_NAME_PARENT_ID = "PARENT_ID";

        // -------------------------------------------------
        //                              Column Property-Name
        //                              --------------------
        public static readonly String PROPERTY_NAME_SELF_REFERENCE_ID = "SelfReferenceId";
        public static readonly String PROPERTY_NAME_SELF_REFERENCE_NAME = "SelfReferenceName";
        public static readonly String PROPERTY_NAME_PARENT_ID = "ParentId";

        // -------------------------------------------------
        //                                      Foreign Name
        //                                      ------------
        public static readonly String FOREIGN_PROPERTY_NAME_VendorSelfReferenceSelf = "VendorSelfReferenceSelf";
        // -------------------------------------------------
        //                                     Referrer Name
        //                                     -------------
        public static readonly String REFERRER_PROPERTY_NAME_VendorSelfReferenceSelfList = "VendorSelfReferenceSelfList";

        // -------------------------------------------------
        //                               DB-Property Mapping
        //                               -------------------
        protected static readonly Map<String, String> _dbNamePropertyNameKeyToLowerMap;
        protected static readonly Map<String, String> _propertyNameDbNameKeyToLowerMap;

        static VendorSelfReferenceDbm() {
            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_DB_NAME.ToLower(), TABLE_PROPERTY_NAME);
                map.put(DB_NAME_SELF_REFERENCE_ID.ToLower(), PROPERTY_NAME_SELF_REFERENCE_ID);
                map.put(DB_NAME_SELF_REFERENCE_NAME.ToLower(), PROPERTY_NAME_SELF_REFERENCE_NAME);
                map.put(DB_NAME_PARENT_ID.ToLower(), PROPERTY_NAME_PARENT_ID);
                _dbNamePropertyNameKeyToLowerMap = map;
            }

            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_PROPERTY_NAME.ToLower(), TABLE_DB_NAME);
                map.put(PROPERTY_NAME_SELF_REFERENCE_ID.ToLower(), DB_NAME_SELF_REFERENCE_ID);
                map.put(PROPERTY_NAME_SELF_REFERENCE_NAME.ToLower(), DB_NAME_SELF_REFERENCE_NAME);
                map.put(PROPERTY_NAME_PARENT_ID.ToLower(), DB_NAME_PARENT_ID);
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
        public override String EntityTypeName { get { return "DfExample.DBFlute.ExEntity.VendorSelfReference"; } }
        public override String DaoTypeName { get { return "DfExample.DBFlute.ExDao.VendorSelfReferenceDao"; } }
        public override String ConditionBeanTypeName { get { return "DfExample.DBFlute.CBean.VendorSelfReferenceCB"; } }
        public override String BehaviorTypeName { get { return "DfExample.DBFlute.ExBhv.VendorSelfReferenceBhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override Entity NewEntity() { return NewMyEntity(); }
        public VendorSelfReference NewMyEntity() { return new VendorSelfReference(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public VendorSelfReferenceCB NewMyConditionBean() { return new VendorSelfReferenceCB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<VendorSelfReference>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<VendorSelfReference>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("SELF_REFERENCE_ID", "SelfReferenceId", new EntityPropertySelfReferenceIdSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("SELF_REFERENCE_NAME", "SelfReferenceName", new EntityPropertySelfReferenceNameSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("PARENT_ID", "ParentId", new EntityPropertyParentIdSetupper(), _entityPropertySetupperMap);
        }

        public override bool HasEntityPropertySetupper(String propertyName) {
            return _entityPropertySetupperMap.containsKey(propertyName);
        }

        public override void SetupEntityProperty(String propertyName, Object entity, Object value) {
            EntityPropertySetupper<VendorSelfReference> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((VendorSelfReference)entity, value);
        }

        public class EntityPropertySelfReferenceIdSetupper : EntityPropertySetupper<VendorSelfReference> {
            public void Setup(VendorSelfReference entity, Object value) { entity.SelfReferenceId = (value != null) ? (long?)value : null; }
        }
        public class EntityPropertySelfReferenceNameSetupper : EntityPropertySetupper<VendorSelfReference> {
            public void Setup(VendorSelfReference entity, Object value) { entity.SelfReferenceName = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyParentIdSetupper : EntityPropertySetupper<VendorSelfReference> {
            public void Setup(VendorSelfReference entity, Object value) { entity.ParentId = (value != null) ? (long?)value : null; }
        }
    }
}

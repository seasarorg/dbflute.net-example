
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

    public class MbVendorSelfReferenceDbm : MbAbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(MbVendorSelfReference);

        private static readonly MbVendorSelfReferenceDbm _instance = new MbVendorSelfReferenceDbm();
        private MbVendorSelfReferenceDbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static MbVendorSelfReferenceDbm GetInstance() {
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
        protected MbColumnInfo _columnSelfReferenceId;
        protected MbColumnInfo _columnSelfReferenceName;
        protected MbColumnInfo _columnParentId;

        public MbColumnInfo ColumnSelfReferenceId { get { return _columnSelfReferenceId; } }
        public MbColumnInfo ColumnSelfReferenceName { get { return _columnSelfReferenceName; } }
        public MbColumnInfo ColumnParentId { get { return _columnParentId; } }

        protected void InitializeColumnInfo() {
            _columnSelfReferenceId = cci("SELF_REFERENCE_ID", "SELF_REFERENCE_ID", null, null, true, "SelfReferenceId", typeof(long?), true, "DECIMAL", 16, 0, false, OptimisticLockType.NONE, null, null, "vendorSelfReferenceSelfList");
            _columnSelfReferenceName = cci("SELF_REFERENCE_NAME", "SELF_REFERENCE_NAME", null, null, true, "SelfReferenceName", typeof(String), false, "VARCHAR", 200, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnParentId = cci("PARENT_ID", "PARENT_ID", null, null, false, "ParentId", typeof(long?), false, "DECIMAL", 16, 0, false, OptimisticLockType.NONE, null, "vendorSelfReferenceSelf", null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<MbColumnInfo>();
            _columnInfoList.add(ColumnSelfReferenceId);
            _columnInfoList.add(ColumnSelfReferenceName);
            _columnInfoList.add(ColumnParentId);
        }

        // ===============================================================================
        //                                                                     Unique Info
        //                                                                     ===========
        public override MbUniqueInfo PrimaryUniqueInfo { get {
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
        public MbForeignInfo ForeignVendorSelfReferenceSelf { get {
            Map<MbColumnInfo, MbColumnInfo> map = new LinkedHashMap<MbColumnInfo, MbColumnInfo>();
            map.put(ColumnParentId, MbVendorSelfReferenceDbm.GetInstance().ColumnSelfReferenceId);
            return cfi("VendorSelfReferenceSelf", this, MbVendorSelfReferenceDbm.GetInstance(), map, 0, false, false);
        }}


        // -------------------------------------------------
        //                                  Referrer Element
        //                                  ----------------
        public MbReferrerInfo ReferrerVendorSelfReferenceSelfList { get {
            Map<MbColumnInfo, MbColumnInfo> map = new LinkedHashMap<MbColumnInfo, MbColumnInfo>();
            map.put(ColumnSelfReferenceId, MbVendorSelfReferenceDbm.GetInstance().ColumnParentId);
            return cri("VendorSelfReferenceSelfList", this, MbVendorSelfReferenceDbm.GetInstance(), map, false);
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

        static MbVendorSelfReferenceDbm() {
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
        public override String EntityTypeName { get { return "DfExample.DBFlute.MemberDb.ExEntity.MbVendorSelfReference"; } }
        public override String DaoTypeName { get { return "DfExample.DBFlute.MemberDb.ExDao.MbVendorSelfReferenceDao"; } }
        public override String ConditionBeanTypeName { get { return "DfExample.DBFlute.MemberDb.CBean.MbVendorSelfReferenceCB"; } }
        public override String BehaviorTypeName { get { return "DfExample.DBFlute.MemberDb.ExBhv.MbVendorSelfReferenceBhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override MbEntity NewEntity() { return NewMyEntity(); }
        public MbVendorSelfReference NewMyEntity() { return new MbVendorSelfReference(); }
        public override MbConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public MbVendorSelfReferenceCB NewMyConditionBean() { return new MbVendorSelfReferenceCB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<MbVendorSelfReference>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<MbVendorSelfReference>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("SELF_REFERENCE_ID", "SelfReferenceId", new EntityPropertySelfReferenceIdSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("SELF_REFERENCE_NAME", "SelfReferenceName", new EntityPropertySelfReferenceNameSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("PARENT_ID", "ParentId", new EntityPropertyParentIdSetupper(), _entityPropertySetupperMap);
        }

        public override bool HasEntityPropertySetupper(String propertyName) {
            return _entityPropertySetupperMap.containsKey(propertyName);
        }

        public override void SetupEntityProperty(String propertyName, Object entity, Object value) {
            EntityPropertySetupper<MbVendorSelfReference> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((MbVendorSelfReference)entity, value);
        }

        public class EntityPropertySelfReferenceIdSetupper : EntityPropertySetupper<MbVendorSelfReference> {
            public void Setup(MbVendorSelfReference entity, Object value) { entity.SelfReferenceId = (value != null) ? (long?)value : null; }
        }
        public class EntityPropertySelfReferenceNameSetupper : EntityPropertySetupper<MbVendorSelfReference> {
            public void Setup(MbVendorSelfReference entity, Object value) { entity.SelfReferenceName = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyParentIdSetupper : EntityPropertySetupper<MbVendorSelfReference> {
            public void Setup(MbVendorSelfReference entity, Object value) { entity.ParentId = (value != null) ? (long?)value : null; }
        }
    }
}

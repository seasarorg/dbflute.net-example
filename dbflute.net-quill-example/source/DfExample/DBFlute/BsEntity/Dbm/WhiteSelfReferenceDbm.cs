
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

    public class WhiteSelfReferenceDbm : AbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(WhiteSelfReference);

        private static readonly WhiteSelfReferenceDbm _instance = new WhiteSelfReferenceDbm();
        private WhiteSelfReferenceDbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static WhiteSelfReferenceDbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "white_self_reference"; } }
        public override String TablePropertyName { get { return "WhiteSelfReference"; } }
        public override String TableSqlName { get { return "white_self_reference"; } }

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
            _columnSelfReferenceId = cci("SELF_REFERENCE_ID", "SELF_REFERENCE_ID", null, null, true, "SelfReferenceId", typeof(long?), true, "DECIMAL", 16, 0, false, OptimisticLockType.NONE, null, null, "whiteSelfReferenceSelfList");
            _columnSelfReferenceName = cci("SELF_REFERENCE_NAME", "SELF_REFERENCE_NAME", null, null, true, "SelfReferenceName", typeof(String), false, "VARCHAR", 200, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnParentId = cci("PARENT_ID", "PARENT_ID", null, null, false, "ParentId", typeof(long?), false, "DECIMAL", 16, 0, false, OptimisticLockType.NONE, null, "whiteSelfReferenceSelf", null);
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
        public ForeignInfo ForeignWhiteSelfReferenceSelf { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(ColumnParentId, WhiteSelfReferenceDbm.GetInstance().ColumnSelfReferenceId);
            return cfi("WhiteSelfReferenceSelf", this, WhiteSelfReferenceDbm.GetInstance(), map, 0, false, false);
        }}


        // -------------------------------------------------
        //                                  Referrer Element
        //                                  ----------------
        public ReferrerInfo ReferrerWhiteSelfReferenceSelfList { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(ColumnSelfReferenceId, WhiteSelfReferenceDbm.GetInstance().ColumnParentId);
            return cri("WhiteSelfReferenceSelfList", this, WhiteSelfReferenceDbm.GetInstance(), map, false);
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
        public static readonly String TABLE_DB_NAME = "white_self_reference";
        public static readonly String TABLE_PROPERTY_NAME = "WhiteSelfReference";

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
        public static readonly String FOREIGN_PROPERTY_NAME_WhiteSelfReferenceSelf = "WhiteSelfReferenceSelf";
        // -------------------------------------------------
        //                                     Referrer Name
        //                                     -------------
        public static readonly String REFERRER_PROPERTY_NAME_WhiteSelfReferenceSelfList = "WhiteSelfReferenceSelfList";

        // -------------------------------------------------
        //                               DB-Property Mapping
        //                               -------------------
        protected static readonly Map<String, String> _dbNamePropertyNameKeyToLowerMap;
        protected static readonly Map<String, String> _propertyNameDbNameKeyToLowerMap;

        static WhiteSelfReferenceDbm() {
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
        public override String EntityTypeName { get { return "DfExample.DBFlute.ExEntity.WhiteSelfReference"; } }
        public override String DaoTypeName { get { return "DfExample.DBFlute.ExDao.WhiteSelfReferenceDao"; } }
        public override String ConditionBeanTypeName { get { return "DfExample.DBFlute.CBean.WhiteSelfReferenceCB"; } }
        public override String BehaviorTypeName { get { return "DfExample.DBFlute.ExBhv.WhiteSelfReferenceBhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override Entity NewEntity() { return NewMyEntity(); }
        public WhiteSelfReference NewMyEntity() { return new WhiteSelfReference(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public WhiteSelfReferenceCB NewMyConditionBean() { return new WhiteSelfReferenceCB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<WhiteSelfReference>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<WhiteSelfReference>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("SELF_REFERENCE_ID", "SelfReferenceId", new EntityPropertySelfReferenceIdSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("SELF_REFERENCE_NAME", "SelfReferenceName", new EntityPropertySelfReferenceNameSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("PARENT_ID", "ParentId", new EntityPropertyParentIdSetupper(), _entityPropertySetupperMap);
        }

        public override bool HasEntityPropertySetupper(String propertyName) {
            return _entityPropertySetupperMap.containsKey(propertyName);
        }

        public override void SetupEntityProperty(String propertyName, Object entity, Object value) {
            EntityPropertySetupper<WhiteSelfReference> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((WhiteSelfReference)entity, value);
        }

        public class EntityPropertySelfReferenceIdSetupper : EntityPropertySetupper<WhiteSelfReference> {
            public void Setup(WhiteSelfReference entity, Object value) { entity.SelfReferenceId = (value != null) ? (long?)value : null; }
        }
        public class EntityPropertySelfReferenceNameSetupper : EntityPropertySetupper<WhiteSelfReference> {
            public void Setup(WhiteSelfReference entity, Object value) { entity.SelfReferenceName = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyParentIdSetupper : EntityPropertySetupper<WhiteSelfReference> {
            public void Setup(WhiteSelfReference entity, Object value) { entity.ParentId = (value != null) ? (long?)value : null; }
        }
    }
}

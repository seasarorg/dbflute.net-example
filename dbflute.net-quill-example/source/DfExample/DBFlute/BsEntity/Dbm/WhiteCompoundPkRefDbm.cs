
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

    public class WhiteCompoundPkRefDbm : AbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(WhiteCompoundPkRef);

        private static readonly WhiteCompoundPkRefDbm _instance = new WhiteCompoundPkRefDbm();
        private WhiteCompoundPkRefDbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static WhiteCompoundPkRefDbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "white_compound_pk_ref"; } }
        public override String TablePropertyName { get { return "WhiteCompoundPkRef"; } }
        public override String TableSqlName { get { return "white_compound_pk_ref"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected ColumnInfo _columnMultipleFirstId;
        protected ColumnInfo _columnMultipleSecondId;
        protected ColumnInfo _columnRefFirstId;
        protected ColumnInfo _columnRefSecondId;

        public ColumnInfo ColumnMultipleFirstId { get { return _columnMultipleFirstId; } }
        public ColumnInfo ColumnMultipleSecondId { get { return _columnMultipleSecondId; } }
        public ColumnInfo ColumnRefFirstId { get { return _columnRefFirstId; } }
        public ColumnInfo ColumnRefSecondId { get { return _columnRefSecondId; } }

        protected void InitializeColumnInfo() {
            _columnMultipleFirstId = cci("MULTIPLE_FIRST_ID", "MULTIPLE_FIRST_ID", null, null, true, "MultipleFirstId", typeof(int?), true, "INT", 10, 0, false, OptimisticLockType.NONE, null, null, "whiteCompoundPkRefNestByQuxMultipleIdList,whiteCompoundPkRefNestByFooMultipleIdList");
            _columnMultipleSecondId = cci("MULTIPLE_SECOND_ID", "MULTIPLE_SECOND_ID", null, null, true, "MultipleSecondId", typeof(int?), true, "INT", 10, 0, false, OptimisticLockType.NONE, null, null, "whiteCompoundPkRefNestByQuxMultipleIdList,whiteCompoundPkRefNestByFooMultipleIdList");
            _columnRefFirstId = cci("REF_FIRST_ID", "REF_FIRST_ID", null, null, true, "RefFirstId", typeof(int?), false, "INT", 10, 0, false, OptimisticLockType.NONE, null, "whiteCompoundPk", null);
            _columnRefSecondId = cci("REF_SECOND_ID", "REF_SECOND_ID", null, null, true, "RefSecondId", typeof(int?), false, "INT", 10, 0, false, OptimisticLockType.NONE, null, "whiteCompoundPk", null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<ColumnInfo>();
            _columnInfoList.add(ColumnMultipleFirstId);
            _columnInfoList.add(ColumnMultipleSecondId);
            _columnInfoList.add(ColumnRefFirstId);
            _columnInfoList.add(ColumnRefSecondId);
        }

        // ===============================================================================
        //                                                                     Unique Info
        //                                                                     ===========
        public override UniqueInfo PrimaryUniqueInfo { get {
            List<ColumnInfo> ls = new ArrayList<ColumnInfo>();
            ls.add(ColumnMultipleFirstId);
            ls.add(ColumnMultipleSecondId);
            return cpui(ls);
        }}

        // -------------------------------------------------
        //                                   Primary Element
        //                                   ---------------
        public override bool HasPrimaryKey { get { return true; } }
        public override bool HasCompoundPrimaryKey { get { return true; } }

        // ===============================================================================
        //                                                                   Relation Info
        //                                                                   =============
        // -------------------------------------------------
        //                                   Foreign Element
        //                                   ---------------
        public ForeignInfo ForeignWhiteCompoundPk { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(ColumnRefFirstId, WhiteCompoundPkDbm.GetInstance().ColumnPkFirstId);
            map.put(ColumnRefSecondId, WhiteCompoundPkDbm.GetInstance().ColumnPkSecondId);
            return cfi("WhiteCompoundPk", this, WhiteCompoundPkDbm.GetInstance(), map, 0, false, false);
        }}


        // -------------------------------------------------
        //                                  Referrer Element
        //                                  ----------------
        public ReferrerInfo ReferrerWhiteCompoundPkRefNestByQuxMultipleIdList { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(ColumnMultipleFirstId, WhiteCompoundPkRefNestDbm.GetInstance().ColumnBarMultipleId);
            map.put(ColumnMultipleSecondId, WhiteCompoundPkRefNestDbm.GetInstance().ColumnQuxMultipleId);
            return cri("WhiteCompoundPkRefNestByQuxMultipleIdList", this, WhiteCompoundPkRefNestDbm.GetInstance(), map, false);
        }}
        public ReferrerInfo ReferrerWhiteCompoundPkRefNestByFooMultipleIdList { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(ColumnMultipleFirstId, WhiteCompoundPkRefNestDbm.GetInstance().ColumnFooMultipleId);
            map.put(ColumnMultipleSecondId, WhiteCompoundPkRefNestDbm.GetInstance().ColumnBarMultipleId);
            return cri("WhiteCompoundPkRefNestByFooMultipleIdList", this, WhiteCompoundPkRefNestDbm.GetInstance(), map, false);
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
        public static readonly String TABLE_DB_NAME = "white_compound_pk_ref";
        public static readonly String TABLE_PROPERTY_NAME = "WhiteCompoundPkRef";

        // -------------------------------------------------
        //                                    Column DB-Name
        //                                    --------------
        public static readonly String DB_NAME_MULTIPLE_FIRST_ID = "MULTIPLE_FIRST_ID";
        public static readonly String DB_NAME_MULTIPLE_SECOND_ID = "MULTIPLE_SECOND_ID";
        public static readonly String DB_NAME_REF_FIRST_ID = "REF_FIRST_ID";
        public static readonly String DB_NAME_REF_SECOND_ID = "REF_SECOND_ID";

        // -------------------------------------------------
        //                              Column Property-Name
        //                              --------------------
        public static readonly String PROPERTY_NAME_MULTIPLE_FIRST_ID = "MultipleFirstId";
        public static readonly String PROPERTY_NAME_MULTIPLE_SECOND_ID = "MultipleSecondId";
        public static readonly String PROPERTY_NAME_REF_FIRST_ID = "RefFirstId";
        public static readonly String PROPERTY_NAME_REF_SECOND_ID = "RefSecondId";

        // -------------------------------------------------
        //                                      Foreign Name
        //                                      ------------
        public static readonly String FOREIGN_PROPERTY_NAME_WhiteCompoundPk = "WhiteCompoundPk";
        // -------------------------------------------------
        //                                     Referrer Name
        //                                     -------------
        public static readonly String REFERRER_PROPERTY_NAME_WhiteCompoundPkRefNestByQuxMultipleIdList = "WhiteCompoundPkRefNestByQuxMultipleIdList";
        public static readonly String REFERRER_PROPERTY_NAME_WhiteCompoundPkRefNestByFooMultipleIdList = "WhiteCompoundPkRefNestByFooMultipleIdList";

        // -------------------------------------------------
        //                               DB-Property Mapping
        //                               -------------------
        protected static readonly Map<String, String> _dbNamePropertyNameKeyToLowerMap;
        protected static readonly Map<String, String> _propertyNameDbNameKeyToLowerMap;

        static WhiteCompoundPkRefDbm() {
            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_DB_NAME.ToLower(), TABLE_PROPERTY_NAME);
                map.put(DB_NAME_MULTIPLE_FIRST_ID.ToLower(), PROPERTY_NAME_MULTIPLE_FIRST_ID);
                map.put(DB_NAME_MULTIPLE_SECOND_ID.ToLower(), PROPERTY_NAME_MULTIPLE_SECOND_ID);
                map.put(DB_NAME_REF_FIRST_ID.ToLower(), PROPERTY_NAME_REF_FIRST_ID);
                map.put(DB_NAME_REF_SECOND_ID.ToLower(), PROPERTY_NAME_REF_SECOND_ID);
                _dbNamePropertyNameKeyToLowerMap = map;
            }

            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_PROPERTY_NAME.ToLower(), TABLE_DB_NAME);
                map.put(PROPERTY_NAME_MULTIPLE_FIRST_ID.ToLower(), DB_NAME_MULTIPLE_FIRST_ID);
                map.put(PROPERTY_NAME_MULTIPLE_SECOND_ID.ToLower(), DB_NAME_MULTIPLE_SECOND_ID);
                map.put(PROPERTY_NAME_REF_FIRST_ID.ToLower(), DB_NAME_REF_FIRST_ID);
                map.put(PROPERTY_NAME_REF_SECOND_ID.ToLower(), DB_NAME_REF_SECOND_ID);
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
        public override String EntityTypeName { get { return "DfExample.DBFlute.ExEntity.WhiteCompoundPkRef"; } }
        public override String DaoTypeName { get { return "DfExample.DBFlute.ExDao.WhiteCompoundPkRefDao"; } }
        public override String ConditionBeanTypeName { get { return "DfExample.DBFlute.CBean.WhiteCompoundPkRefCB"; } }
        public override String BehaviorTypeName { get { return "DfExample.DBFlute.ExBhv.WhiteCompoundPkRefBhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override Entity NewEntity() { return NewMyEntity(); }
        public WhiteCompoundPkRef NewMyEntity() { return new WhiteCompoundPkRef(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public WhiteCompoundPkRefCB NewMyConditionBean() { return new WhiteCompoundPkRefCB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<WhiteCompoundPkRef>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<WhiteCompoundPkRef>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("MULTIPLE_FIRST_ID", "MultipleFirstId", new EntityPropertyMultipleFirstIdSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("MULTIPLE_SECOND_ID", "MultipleSecondId", new EntityPropertyMultipleSecondIdSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("REF_FIRST_ID", "RefFirstId", new EntityPropertyRefFirstIdSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("REF_SECOND_ID", "RefSecondId", new EntityPropertyRefSecondIdSetupper(), _entityPropertySetupperMap);
        }

        public override bool HasEntityPropertySetupper(String propertyName) {
            return _entityPropertySetupperMap.containsKey(propertyName);
        }

        public override void SetupEntityProperty(String propertyName, Object entity, Object value) {
            EntityPropertySetupper<WhiteCompoundPkRef> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((WhiteCompoundPkRef)entity, value);
        }

        public class EntityPropertyMultipleFirstIdSetupper : EntityPropertySetupper<WhiteCompoundPkRef> {
            public void Setup(WhiteCompoundPkRef entity, Object value) { entity.MultipleFirstId = (value != null) ? (int?)value : null; }
        }
        public class EntityPropertyMultipleSecondIdSetupper : EntityPropertySetupper<WhiteCompoundPkRef> {
            public void Setup(WhiteCompoundPkRef entity, Object value) { entity.MultipleSecondId = (value != null) ? (int?)value : null; }
        }
        public class EntityPropertyRefFirstIdSetupper : EntityPropertySetupper<WhiteCompoundPkRef> {
            public void Setup(WhiteCompoundPkRef entity, Object value) { entity.RefFirstId = (value != null) ? (int?)value : null; }
        }
        public class EntityPropertyRefSecondIdSetupper : EntityPropertySetupper<WhiteCompoundPkRef> {
            public void Setup(WhiteCompoundPkRef entity, Object value) { entity.RefSecondId = (value != null) ? (int?)value : null; }
        }
    }
}

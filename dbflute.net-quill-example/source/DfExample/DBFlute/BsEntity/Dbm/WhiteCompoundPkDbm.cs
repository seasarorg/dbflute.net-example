
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

    public class WhiteCompoundPkDbm : AbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(WhiteCompoundPk);

        private static readonly WhiteCompoundPkDbm _instance = new WhiteCompoundPkDbm();
        private WhiteCompoundPkDbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static WhiteCompoundPkDbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "white_compound_pk"; } }
        public override String TablePropertyName { get { return "WhiteCompoundPk"; } }
        public override String TableSqlName { get { return "white_compound_pk"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected ColumnInfo _columnPkFirstId;
        protected ColumnInfo _columnPkSecondId;
        protected ColumnInfo _columnPkName;

        public ColumnInfo ColumnPkFirstId { get { return _columnPkFirstId; } }
        public ColumnInfo ColumnPkSecondId { get { return _columnPkSecondId; } }
        public ColumnInfo ColumnPkName { get { return _columnPkName; } }

        protected void InitializeColumnInfo() {
            _columnPkFirstId = cci("PK_FIRST_ID", "PK_FIRST_ID", null, null, true, "PkFirstId", typeof(int?), true, "INT", 10, 0, false, OptimisticLockType.NONE, null, null, "whiteCompoundPkRefList");
            _columnPkSecondId = cci("PK_SECOND_ID", "PK_SECOND_ID", null, null, true, "PkSecondId", typeof(int?), true, "INT", 10, 0, false, OptimisticLockType.NONE, null, null, "whiteCompoundPkRefList");
            _columnPkName = cci("PK_NAME", "PK_NAME", null, null, true, "PkName", typeof(String), false, "VARCHAR", 200, 0, false, OptimisticLockType.NONE, null, null, null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<ColumnInfo>();
            _columnInfoList.add(ColumnPkFirstId);
            _columnInfoList.add(ColumnPkSecondId);
            _columnInfoList.add(ColumnPkName);
        }

        // ===============================================================================
        //                                                                     Unique Info
        //                                                                     ===========
        public override UniqueInfo PrimaryUniqueInfo { get {
            List<ColumnInfo> ls = new ArrayList<ColumnInfo>();
            ls.add(ColumnPkFirstId);
            ls.add(ColumnPkSecondId);
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


        // -------------------------------------------------
        //                                  Referrer Element
        //                                  ----------------
        public ReferrerInfo ReferrerWhiteCompoundPkRefList { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(ColumnPkFirstId, WhiteCompoundPkRefDbm.GetInstance().ColumnRefFirstId);
            map.put(ColumnPkSecondId, WhiteCompoundPkRefDbm.GetInstance().ColumnRefSecondId);
            return cri("WhiteCompoundPkRefList", this, WhiteCompoundPkRefDbm.GetInstance(), map, false);
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
        public static readonly String TABLE_DB_NAME = "white_compound_pk";
        public static readonly String TABLE_PROPERTY_NAME = "WhiteCompoundPk";

        // -------------------------------------------------
        //                                    Column DB-Name
        //                                    --------------
        public static readonly String DB_NAME_PK_FIRST_ID = "PK_FIRST_ID";
        public static readonly String DB_NAME_PK_SECOND_ID = "PK_SECOND_ID";
        public static readonly String DB_NAME_PK_NAME = "PK_NAME";

        // -------------------------------------------------
        //                              Column Property-Name
        //                              --------------------
        public static readonly String PROPERTY_NAME_PK_FIRST_ID = "PkFirstId";
        public static readonly String PROPERTY_NAME_PK_SECOND_ID = "PkSecondId";
        public static readonly String PROPERTY_NAME_PK_NAME = "PkName";

        // -------------------------------------------------
        //                                      Foreign Name
        //                                      ------------
        // -------------------------------------------------
        //                                     Referrer Name
        //                                     -------------
        public static readonly String REFERRER_PROPERTY_NAME_WhiteCompoundPkRefList = "WhiteCompoundPkRefList";

        // -------------------------------------------------
        //                               DB-Property Mapping
        //                               -------------------
        protected static readonly Map<String, String> _dbNamePropertyNameKeyToLowerMap;
        protected static readonly Map<String, String> _propertyNameDbNameKeyToLowerMap;

        static WhiteCompoundPkDbm() {
            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_DB_NAME.ToLower(), TABLE_PROPERTY_NAME);
                map.put(DB_NAME_PK_FIRST_ID.ToLower(), PROPERTY_NAME_PK_FIRST_ID);
                map.put(DB_NAME_PK_SECOND_ID.ToLower(), PROPERTY_NAME_PK_SECOND_ID);
                map.put(DB_NAME_PK_NAME.ToLower(), PROPERTY_NAME_PK_NAME);
                _dbNamePropertyNameKeyToLowerMap = map;
            }

            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_PROPERTY_NAME.ToLower(), TABLE_DB_NAME);
                map.put(PROPERTY_NAME_PK_FIRST_ID.ToLower(), DB_NAME_PK_FIRST_ID);
                map.put(PROPERTY_NAME_PK_SECOND_ID.ToLower(), DB_NAME_PK_SECOND_ID);
                map.put(PROPERTY_NAME_PK_NAME.ToLower(), DB_NAME_PK_NAME);
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
        public override String EntityTypeName { get { return "DfExample.DBFlute.ExEntity.WhiteCompoundPk"; } }
        public override String DaoTypeName { get { return "DfExample.DBFlute.ExDao.WhiteCompoundPkDao"; } }
        public override String ConditionBeanTypeName { get { return "DfExample.DBFlute.CBean.WhiteCompoundPkCB"; } }
        public override String BehaviorTypeName { get { return "DfExample.DBFlute.ExBhv.WhiteCompoundPkBhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override Entity NewEntity() { return NewMyEntity(); }
        public WhiteCompoundPk NewMyEntity() { return new WhiteCompoundPk(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public WhiteCompoundPkCB NewMyConditionBean() { return new WhiteCompoundPkCB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<WhiteCompoundPk>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<WhiteCompoundPk>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("PK_FIRST_ID", "PkFirstId", new EntityPropertyPkFirstIdSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("PK_SECOND_ID", "PkSecondId", new EntityPropertyPkSecondIdSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("PK_NAME", "PkName", new EntityPropertyPkNameSetupper(), _entityPropertySetupperMap);
        }

        public override bool HasEntityPropertySetupper(String propertyName) {
            return _entityPropertySetupperMap.containsKey(propertyName);
        }

        public override void SetupEntityProperty(String propertyName, Object entity, Object value) {
            EntityPropertySetupper<WhiteCompoundPk> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((WhiteCompoundPk)entity, value);
        }

        public class EntityPropertyPkFirstIdSetupper : EntityPropertySetupper<WhiteCompoundPk> {
            public void Setup(WhiteCompoundPk entity, Object value) { entity.PkFirstId = (value != null) ? (int?)value : null; }
        }
        public class EntityPropertyPkSecondIdSetupper : EntityPropertySetupper<WhiteCompoundPk> {
            public void Setup(WhiteCompoundPk entity, Object value) { entity.PkSecondId = (value != null) ? (int?)value : null; }
        }
        public class EntityPropertyPkNameSetupper : EntityPropertySetupper<WhiteCompoundPk> {
            public void Setup(WhiteCompoundPk entity, Object value) { entity.PkName = (value != null) ? (String)value : null; }
        }
    }
}

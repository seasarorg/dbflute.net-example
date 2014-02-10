
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

    public class WhiteQuotedDbm : AbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(WhiteQuoted);

        private static readonly WhiteQuotedDbm _instance = new WhiteQuotedDbm();
        private WhiteQuotedDbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static WhiteQuotedDbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "white_quoted"; } }
        public override String TablePropertyName { get { return "WhiteQuoted"; } }
        public override String TableSqlName { get { return "`white_quoted`"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected ColumnInfo _columnSelect;
        protected ColumnInfo _columnFrom;

        public ColumnInfo ColumnSelect { get { return _columnSelect; } }
        public ColumnInfo ColumnFrom { get { return _columnFrom; } }

        protected void InitializeColumnInfo() {
            _columnSelect = cci("SELECT", "`SELECT`", null, null, true, "Select", typeof(int?), true, "INT", 10, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnFrom = cci("FROM", "`FROM`", null, null, false, "From", typeof(String), false, "VARCHAR", 200, 0, false, OptimisticLockType.NONE, null, null, null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<ColumnInfo>();
            _columnInfoList.add(ColumnSelect);
            _columnInfoList.add(ColumnFrom);
        }

        // ===============================================================================
        //                                                                     Unique Info
        //                                                                     ===========
        public override UniqueInfo PrimaryUniqueInfo { get {
            return cpui(ColumnSelect);
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
        public static readonly String TABLE_DB_NAME = "white_quoted";
        public static readonly String TABLE_PROPERTY_NAME = "WhiteQuoted";

        // -------------------------------------------------
        //                                    Column DB-Name
        //                                    --------------
        public static readonly String DB_NAME_SELECT = "SELECT";
        public static readonly String DB_NAME_FROM = "FROM";

        // -------------------------------------------------
        //                              Column Property-Name
        //                              --------------------
        public static readonly String PROPERTY_NAME_SELECT = "Select";
        public static readonly String PROPERTY_NAME_FROM = "From";

        // -------------------------------------------------
        //                                      Foreign Name
        //                                      ------------
        // -------------------------------------------------
        //                                     Referrer Name
        //                                     -------------

        // -------------------------------------------------
        //                               DB-Property Mapping
        //                               -------------------
        protected static readonly Map<String, String> _dbNamePropertyNameKeyToLowerMap;
        protected static readonly Map<String, String> _propertyNameDbNameKeyToLowerMap;

        static WhiteQuotedDbm() {
            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_DB_NAME.ToLower(), TABLE_PROPERTY_NAME);
                map.put(DB_NAME_SELECT.ToLower(), PROPERTY_NAME_SELECT);
                map.put(DB_NAME_FROM.ToLower(), PROPERTY_NAME_FROM);
                _dbNamePropertyNameKeyToLowerMap = map;
            }

            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_PROPERTY_NAME.ToLower(), TABLE_DB_NAME);
                map.put(PROPERTY_NAME_SELECT.ToLower(), DB_NAME_SELECT);
                map.put(PROPERTY_NAME_FROM.ToLower(), DB_NAME_FROM);
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
        public override String EntityTypeName { get { return "DfExample.DBFlute.ExEntity.WhiteQuoted"; } }
        public override String DaoTypeName { get { return "DfExample.DBFlute.ExDao.WhiteQuotedDao"; } }
        public override String ConditionBeanTypeName { get { return "DfExample.DBFlute.CBean.WhiteQuotedCB"; } }
        public override String BehaviorTypeName { get { return "DfExample.DBFlute.ExBhv.WhiteQuotedBhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override Entity NewEntity() { return NewMyEntity(); }
        public WhiteQuoted NewMyEntity() { return new WhiteQuoted(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public WhiteQuotedCB NewMyConditionBean() { return new WhiteQuotedCB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<WhiteQuoted>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<WhiteQuoted>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("SELECT", "Select", new EntityPropertySelectSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("FROM", "From", new EntityPropertyFromSetupper(), _entityPropertySetupperMap);
        }

        public override bool HasEntityPropertySetupper(String propertyName) {
            return _entityPropertySetupperMap.containsKey(propertyName);
        }

        public override void SetupEntityProperty(String propertyName, Object entity, Object value) {
            EntityPropertySetupper<WhiteQuoted> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((WhiteQuoted)entity, value);
        }

        public class EntityPropertySelectSetupper : EntityPropertySetupper<WhiteQuoted> {
            public void Setup(WhiteQuoted entity, Object value) { entity.Select = (value != null) ? (int?)value : null; }
        }
        public class EntityPropertyFromSetupper : EntityPropertySetupper<WhiteQuoted> {
            public void Setup(WhiteQuoted entity, Object value) { entity.From = (value != null) ? (String)value : null; }
        }
    }
}

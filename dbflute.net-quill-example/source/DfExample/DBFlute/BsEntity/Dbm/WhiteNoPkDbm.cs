
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

    public class WhiteNoPkDbm : AbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(WhiteNoPk);

        private static readonly WhiteNoPkDbm _instance = new WhiteNoPkDbm();
        private WhiteNoPkDbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static WhiteNoPkDbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "white_no_pk"; } }
        public override String TablePropertyName { get { return "WhiteNoPk"; } }
        public override String TableSqlName { get { return "white_no_pk"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected ColumnInfo _columnNoPkId;
        protected ColumnInfo _columnNoPkName;
        protected ColumnInfo _columnNoPkInteger;

        public ColumnInfo ColumnNoPkId { get { return _columnNoPkId; } }
        public ColumnInfo ColumnNoPkName { get { return _columnNoPkName; } }
        public ColumnInfo ColumnNoPkInteger { get { return _columnNoPkInteger; } }

        protected void InitializeColumnInfo() {
            _columnNoPkId = cci("NO_PK_ID", "NO_PK_ID", null, null, true, "NoPkId", typeof(long?), false, "DECIMAL", 16, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnNoPkName = cci("NO_PK_NAME", "NO_PK_NAME", null, null, false, "NoPkName", typeof(String), false, "VARCHAR", 32, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnNoPkInteger = cci("NO_PK_INTEGER", "NO_PK_INTEGER", null, null, false, "NoPkInteger", typeof(int?), false, "INT", 10, 0, false, OptimisticLockType.NONE, null, null, null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<ColumnInfo>();
            _columnInfoList.add(ColumnNoPkId);
            _columnInfoList.add(ColumnNoPkName);
            _columnInfoList.add(ColumnNoPkInteger);
        }

        // ===============================================================================
        //                                                                     Unique Info
        //                                                                     ===========
        public override UniqueInfo PrimaryUniqueInfo { get {
            throw new NotSupportedException("The table does not have primary key: " + TableDbName);
        }}

        // -------------------------------------------------
        //                                   Primary Element
        //                                   ---------------
        public override bool HasPrimaryKey { get { return false; } }
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
        public static readonly String TABLE_DB_NAME = "white_no_pk";
        public static readonly String TABLE_PROPERTY_NAME = "WhiteNoPk";

        // -------------------------------------------------
        //                                    Column DB-Name
        //                                    --------------
        public static readonly String DB_NAME_NO_PK_ID = "NO_PK_ID";
        public static readonly String DB_NAME_NO_PK_NAME = "NO_PK_NAME";
        public static readonly String DB_NAME_NO_PK_INTEGER = "NO_PK_INTEGER";

        // -------------------------------------------------
        //                              Column Property-Name
        //                              --------------------
        public static readonly String PROPERTY_NAME_NO_PK_ID = "NoPkId";
        public static readonly String PROPERTY_NAME_NO_PK_NAME = "NoPkName";
        public static readonly String PROPERTY_NAME_NO_PK_INTEGER = "NoPkInteger";

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

        static WhiteNoPkDbm() {
            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_DB_NAME.ToLower(), TABLE_PROPERTY_NAME);
                map.put(DB_NAME_NO_PK_ID.ToLower(), PROPERTY_NAME_NO_PK_ID);
                map.put(DB_NAME_NO_PK_NAME.ToLower(), PROPERTY_NAME_NO_PK_NAME);
                map.put(DB_NAME_NO_PK_INTEGER.ToLower(), PROPERTY_NAME_NO_PK_INTEGER);
                _dbNamePropertyNameKeyToLowerMap = map;
            }

            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_PROPERTY_NAME.ToLower(), TABLE_DB_NAME);
                map.put(PROPERTY_NAME_NO_PK_ID.ToLower(), DB_NAME_NO_PK_ID);
                map.put(PROPERTY_NAME_NO_PK_NAME.ToLower(), DB_NAME_NO_PK_NAME);
                map.put(PROPERTY_NAME_NO_PK_INTEGER.ToLower(), DB_NAME_NO_PK_INTEGER);
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
        public override String EntityTypeName { get { return "DfExample.DBFlute.ExEntity.WhiteNoPk"; } }
        public override String DaoTypeName { get { return "DfExample.DBFlute.ExDao.WhiteNoPkDao"; } }
        public override String ConditionBeanTypeName { get { return "DfExample.DBFlute.CBean.WhiteNoPkCB"; } }
        public override String BehaviorTypeName { get { return "DfExample.DBFlute.ExBhv.WhiteNoPkBhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override Entity NewEntity() { return NewMyEntity(); }
        public WhiteNoPk NewMyEntity() { return new WhiteNoPk(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public WhiteNoPkCB NewMyConditionBean() { return new WhiteNoPkCB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<WhiteNoPk>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<WhiteNoPk>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("NO_PK_ID", "NoPkId", new EntityPropertyNoPkIdSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("NO_PK_NAME", "NoPkName", new EntityPropertyNoPkNameSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("NO_PK_INTEGER", "NoPkInteger", new EntityPropertyNoPkIntegerSetupper(), _entityPropertySetupperMap);
        }

        public override bool HasEntityPropertySetupper(String propertyName) {
            return _entityPropertySetupperMap.containsKey(propertyName);
        }

        public override void SetupEntityProperty(String propertyName, Object entity, Object value) {
            EntityPropertySetupper<WhiteNoPk> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((WhiteNoPk)entity, value);
        }

        public class EntityPropertyNoPkIdSetupper : EntityPropertySetupper<WhiteNoPk> {
            public void Setup(WhiteNoPk entity, Object value) { entity.NoPkId = (value != null) ? (long?)value : null; }
        }
        public class EntityPropertyNoPkNameSetupper : EntityPropertySetupper<WhiteNoPk> {
            public void Setup(WhiteNoPk entity, Object value) { entity.NoPkName = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyNoPkIntegerSetupper : EntityPropertySetupper<WhiteNoPk> {
            public void Setup(WhiteNoPk entity, Object value) { entity.NoPkInteger = (value != null) ? (int?)value : null; }
        }
    }
}

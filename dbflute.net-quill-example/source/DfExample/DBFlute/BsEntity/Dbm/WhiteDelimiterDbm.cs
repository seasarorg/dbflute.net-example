
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

    public class WhiteDelimiterDbm : AbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(WhiteDelimiter);

        private static readonly WhiteDelimiterDbm _instance = new WhiteDelimiterDbm();
        private WhiteDelimiterDbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static WhiteDelimiterDbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "white_delimiter"; } }
        public override String TablePropertyName { get { return "WhiteDelimiter"; } }
        public override String TableSqlName { get { return "white_delimiter"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected ColumnInfo _columnDelimiterId;
        protected ColumnInfo _columnNumberNullable;
        protected ColumnInfo _columnStringConverted;
        protected ColumnInfo _columnStringNonConverted;
        protected ColumnInfo _columnDateDefault;

        public ColumnInfo ColumnDelimiterId { get { return _columnDelimiterId; } }
        public ColumnInfo ColumnNumberNullable { get { return _columnNumberNullable; } }
        public ColumnInfo ColumnStringConverted { get { return _columnStringConverted; } }
        public ColumnInfo ColumnStringNonConverted { get { return _columnStringNonConverted; } }
        public ColumnInfo ColumnDateDefault { get { return _columnDateDefault; } }

        protected void InitializeColumnInfo() {
            _columnDelimiterId = cci("DELIMITER_ID", "DELIMITER_ID", null, null, true, "DelimiterId", typeof(long?), true, "DECIMAL", 16, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnNumberNullable = cci("NUMBER_NULLABLE", "NUMBER_NULLABLE", null, null, false, "NumberNullable", typeof(int?), false, "INT", 10, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnStringConverted = cci("STRING_CONVERTED", "STRING_CONVERTED", null, null, true, "StringConverted", typeof(String), false, "VARCHAR", 200, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnStringNonConverted = cci("STRING_NON_CONVERTED", "STRING_NON_CONVERTED", null, null, false, "StringNonConverted", typeof(String), false, "VARCHAR", 200, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnDateDefault = cci("DATE_DEFAULT", "DATE_DEFAULT", null, null, true, "DateDefault", typeof(DateTime?), false, "DATE", 10, 0, false, OptimisticLockType.NONE, null, null, null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<ColumnInfo>();
            _columnInfoList.add(ColumnDelimiterId);
            _columnInfoList.add(ColumnNumberNullable);
            _columnInfoList.add(ColumnStringConverted);
            _columnInfoList.add(ColumnStringNonConverted);
            _columnInfoList.add(ColumnDateDefault);
        }

        // ===============================================================================
        //                                                                     Unique Info
        //                                                                     ===========
        public override UniqueInfo PrimaryUniqueInfo { get {
            return cpui(ColumnDelimiterId);
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
        public static readonly String TABLE_DB_NAME = "white_delimiter";
        public static readonly String TABLE_PROPERTY_NAME = "WhiteDelimiter";

        // -------------------------------------------------
        //                                    Column DB-Name
        //                                    --------------
        public static readonly String DB_NAME_DELIMITER_ID = "DELIMITER_ID";
        public static readonly String DB_NAME_NUMBER_NULLABLE = "NUMBER_NULLABLE";
        public static readonly String DB_NAME_STRING_CONVERTED = "STRING_CONVERTED";
        public static readonly String DB_NAME_STRING_NON_CONVERTED = "STRING_NON_CONVERTED";
        public static readonly String DB_NAME_DATE_DEFAULT = "DATE_DEFAULT";

        // -------------------------------------------------
        //                              Column Property-Name
        //                              --------------------
        public static readonly String PROPERTY_NAME_DELIMITER_ID = "DelimiterId";
        public static readonly String PROPERTY_NAME_NUMBER_NULLABLE = "NumberNullable";
        public static readonly String PROPERTY_NAME_STRING_CONVERTED = "StringConverted";
        public static readonly String PROPERTY_NAME_STRING_NON_CONVERTED = "StringNonConverted";
        public static readonly String PROPERTY_NAME_DATE_DEFAULT = "DateDefault";

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

        static WhiteDelimiterDbm() {
            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_DB_NAME.ToLower(), TABLE_PROPERTY_NAME);
                map.put(DB_NAME_DELIMITER_ID.ToLower(), PROPERTY_NAME_DELIMITER_ID);
                map.put(DB_NAME_NUMBER_NULLABLE.ToLower(), PROPERTY_NAME_NUMBER_NULLABLE);
                map.put(DB_NAME_STRING_CONVERTED.ToLower(), PROPERTY_NAME_STRING_CONVERTED);
                map.put(DB_NAME_STRING_NON_CONVERTED.ToLower(), PROPERTY_NAME_STRING_NON_CONVERTED);
                map.put(DB_NAME_DATE_DEFAULT.ToLower(), PROPERTY_NAME_DATE_DEFAULT);
                _dbNamePropertyNameKeyToLowerMap = map;
            }

            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_PROPERTY_NAME.ToLower(), TABLE_DB_NAME);
                map.put(PROPERTY_NAME_DELIMITER_ID.ToLower(), DB_NAME_DELIMITER_ID);
                map.put(PROPERTY_NAME_NUMBER_NULLABLE.ToLower(), DB_NAME_NUMBER_NULLABLE);
                map.put(PROPERTY_NAME_STRING_CONVERTED.ToLower(), DB_NAME_STRING_CONVERTED);
                map.put(PROPERTY_NAME_STRING_NON_CONVERTED.ToLower(), DB_NAME_STRING_NON_CONVERTED);
                map.put(PROPERTY_NAME_DATE_DEFAULT.ToLower(), DB_NAME_DATE_DEFAULT);
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
        public override String EntityTypeName { get { return "DfExample.DBFlute.ExEntity.WhiteDelimiter"; } }
        public override String DaoTypeName { get { return "DfExample.DBFlute.ExDao.WhiteDelimiterDao"; } }
        public override String ConditionBeanTypeName { get { return "DfExample.DBFlute.CBean.WhiteDelimiterCB"; } }
        public override String BehaviorTypeName { get { return "DfExample.DBFlute.ExBhv.WhiteDelimiterBhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override Entity NewEntity() { return NewMyEntity(); }
        public WhiteDelimiter NewMyEntity() { return new WhiteDelimiter(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public WhiteDelimiterCB NewMyConditionBean() { return new WhiteDelimiterCB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<WhiteDelimiter>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<WhiteDelimiter>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("DELIMITER_ID", "DelimiterId", new EntityPropertyDelimiterIdSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("NUMBER_NULLABLE", "NumberNullable", new EntityPropertyNumberNullableSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("STRING_CONVERTED", "StringConverted", new EntityPropertyStringConvertedSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("STRING_NON_CONVERTED", "StringNonConverted", new EntityPropertyStringNonConvertedSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("DATE_DEFAULT", "DateDefault", new EntityPropertyDateDefaultSetupper(), _entityPropertySetupperMap);
        }

        public override bool HasEntityPropertySetupper(String propertyName) {
            return _entityPropertySetupperMap.containsKey(propertyName);
        }

        public override void SetupEntityProperty(String propertyName, Object entity, Object value) {
            EntityPropertySetupper<WhiteDelimiter> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((WhiteDelimiter)entity, value);
        }

        public class EntityPropertyDelimiterIdSetupper : EntityPropertySetupper<WhiteDelimiter> {
            public void Setup(WhiteDelimiter entity, Object value) { entity.DelimiterId = (value != null) ? (long?)value : null; }
        }
        public class EntityPropertyNumberNullableSetupper : EntityPropertySetupper<WhiteDelimiter> {
            public void Setup(WhiteDelimiter entity, Object value) { entity.NumberNullable = (value != null) ? (int?)value : null; }
        }
        public class EntityPropertyStringConvertedSetupper : EntityPropertySetupper<WhiteDelimiter> {
            public void Setup(WhiteDelimiter entity, Object value) { entity.StringConverted = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyStringNonConvertedSetupper : EntityPropertySetupper<WhiteDelimiter> {
            public void Setup(WhiteDelimiter entity, Object value) { entity.StringNonConverted = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyDateDefaultSetupper : EntityPropertySetupper<WhiteDelimiter> {
            public void Setup(WhiteDelimiter entity, Object value) { entity.DateDefault = (value != null) ? (DateTime?)value : null; }
        }
    }
}

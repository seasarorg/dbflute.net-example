
using System;
using System.Reflection;

using DfExample.DBFlute.AllCommon;
using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.Dbm;
using DfExample.DBFlute.AllCommon.Dbm.Info;
using DfExample.DBFlute.AllCommon.JavaLike;
using DfExample.DBFlute.ExEntity.Customize;
namespace DfExample.DBFlute.BsEntity.Customize.Dbm {

    public class SimpleVendorCheckDbm : AbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(SimpleVendorCheck);

        private static readonly SimpleVendorCheckDbm _instance = new SimpleVendorCheckDbm();
        private SimpleVendorCheckDbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static SimpleVendorCheckDbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "SimpleVendorCheck"; } }
        public override String TablePropertyName { get { return "SimpleVendorCheck"; } }
        public override String TableSqlName { get { return "SimpleVendorCheck"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected ColumnInfo _columnVendorCheckId;
        protected ColumnInfo _columnTypeOfNumericDecimal;
        protected ColumnInfo _columnTypeOfNumericInteger;
        protected ColumnInfo _columnTypeOfNumericBigint;
        protected ColumnInfo _columnTypeOfBoolean;
        protected ColumnInfo _columnTypeOfText;
        protected ColumnInfo _columnTypeOfBlob;

        public ColumnInfo ColumnVendorCheckId { get { return _columnVendorCheckId; } }
        public ColumnInfo ColumnTypeOfNumericDecimal { get { return _columnTypeOfNumericDecimal; } }
        public ColumnInfo ColumnTypeOfNumericInteger { get { return _columnTypeOfNumericInteger; } }
        public ColumnInfo ColumnTypeOfNumericBigint { get { return _columnTypeOfNumericBigint; } }
        public ColumnInfo ColumnTypeOfBoolean { get { return _columnTypeOfBoolean; } }
        public ColumnInfo ColumnTypeOfText { get { return _columnTypeOfText; } }
        public ColumnInfo ColumnTypeOfBlob { get { return _columnTypeOfBlob; } }

        protected void InitializeColumnInfo() {
            _columnVendorCheckId = cci("VENDOR_CHECK_ID", "VENDOR_CHECK_ID", null, null, false, "VendorCheckId", typeof(long?), false, "DECIMAL", 16, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnTypeOfNumericDecimal = cci("TYPE_OF_NUMERIC_DECIMAL", "TYPE_OF_NUMERIC_DECIMAL", null, null, false, "TypeOfNumericDecimal", typeof(decimal?), false, "DECIMAL", 5, 3, false, OptimisticLockType.NONE, null, null, null);
            _columnTypeOfNumericInteger = cci("TYPE_OF_NUMERIC_INTEGER", "TYPE_OF_NUMERIC_INTEGER", null, null, false, "TypeOfNumericInteger", typeof(int?), false, "DECIMAL", 5, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnTypeOfNumericBigint = cci("TYPE_OF_NUMERIC_BIGINT", "TYPE_OF_NUMERIC_BIGINT", null, null, false, "TypeOfNumericBigint", typeof(long?), false, "DECIMAL", 12, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnTypeOfBoolean = cci("TYPE_OF_BOOLEAN", "TYPE_OF_BOOLEAN", null, null, false, "TypeOfBoolean", typeof(bool?), false, "TINYINT", 1, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnTypeOfText = cci("TYPE_OF_TEXT", "TYPE_OF_TEXT", null, null, false, "TypeOfText", typeof(String), false, "VARCHAR", 21845, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnTypeOfBlob = cci("TYPE_OF_BLOB", "TYPE_OF_BLOB", null, null, false, "TypeOfBlob", typeof(byte[]), false, "BLOB", 65535, 0, false, OptimisticLockType.NONE, null, null, null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<ColumnInfo>();
            _columnInfoList.add(ColumnVendorCheckId);
            _columnInfoList.add(ColumnTypeOfNumericDecimal);
            _columnInfoList.add(ColumnTypeOfNumericInteger);
            _columnInfoList.add(ColumnTypeOfNumericBigint);
            _columnInfoList.add(ColumnTypeOfBoolean);
            _columnInfoList.add(ColumnTypeOfText);
            _columnInfoList.add(ColumnTypeOfBlob);
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
        public static readonly String TABLE_DB_NAME = "SimpleVendorCheck";
        public static readonly String TABLE_PROPERTY_NAME = "SimpleVendorCheck";

        // -------------------------------------------------
        //                                    Column DB-Name
        //                                    --------------
        public static readonly String DB_NAME_VENDOR_CHECK_ID = "VENDOR_CHECK_ID";
        public static readonly String DB_NAME_TYPE_OF_NUMERIC_DECIMAL = "TYPE_OF_NUMERIC_DECIMAL";
        public static readonly String DB_NAME_TYPE_OF_NUMERIC_INTEGER = "TYPE_OF_NUMERIC_INTEGER";
        public static readonly String DB_NAME_TYPE_OF_NUMERIC_BIGINT = "TYPE_OF_NUMERIC_BIGINT";
        public static readonly String DB_NAME_TYPE_OF_BOOLEAN = "TYPE_OF_BOOLEAN";
        public static readonly String DB_NAME_TYPE_OF_TEXT = "TYPE_OF_TEXT";
        public static readonly String DB_NAME_TYPE_OF_BLOB = "TYPE_OF_BLOB";

        // -------------------------------------------------
        //                              Column Property-Name
        //                              --------------------
        public static readonly String PROPERTY_NAME_VENDOR_CHECK_ID = "VendorCheckId";
        public static readonly String PROPERTY_NAME_TYPE_OF_NUMERIC_DECIMAL = "TypeOfNumericDecimal";
        public static readonly String PROPERTY_NAME_TYPE_OF_NUMERIC_INTEGER = "TypeOfNumericInteger";
        public static readonly String PROPERTY_NAME_TYPE_OF_NUMERIC_BIGINT = "TypeOfNumericBigint";
        public static readonly String PROPERTY_NAME_TYPE_OF_BOOLEAN = "TypeOfBoolean";
        public static readonly String PROPERTY_NAME_TYPE_OF_TEXT = "TypeOfText";
        public static readonly String PROPERTY_NAME_TYPE_OF_BLOB = "TypeOfBlob";

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

        static SimpleVendorCheckDbm() {
            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_DB_NAME.ToLower(), TABLE_PROPERTY_NAME);
                map.put(DB_NAME_VENDOR_CHECK_ID.ToLower(), PROPERTY_NAME_VENDOR_CHECK_ID);
                map.put(DB_NAME_TYPE_OF_NUMERIC_DECIMAL.ToLower(), PROPERTY_NAME_TYPE_OF_NUMERIC_DECIMAL);
                map.put(DB_NAME_TYPE_OF_NUMERIC_INTEGER.ToLower(), PROPERTY_NAME_TYPE_OF_NUMERIC_INTEGER);
                map.put(DB_NAME_TYPE_OF_NUMERIC_BIGINT.ToLower(), PROPERTY_NAME_TYPE_OF_NUMERIC_BIGINT);
                map.put(DB_NAME_TYPE_OF_BOOLEAN.ToLower(), PROPERTY_NAME_TYPE_OF_BOOLEAN);
                map.put(DB_NAME_TYPE_OF_TEXT.ToLower(), PROPERTY_NAME_TYPE_OF_TEXT);
                map.put(DB_NAME_TYPE_OF_BLOB.ToLower(), PROPERTY_NAME_TYPE_OF_BLOB);
                _dbNamePropertyNameKeyToLowerMap = map;
            }

            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_PROPERTY_NAME.ToLower(), TABLE_DB_NAME);
                map.put(PROPERTY_NAME_VENDOR_CHECK_ID.ToLower(), DB_NAME_VENDOR_CHECK_ID);
                map.put(PROPERTY_NAME_TYPE_OF_NUMERIC_DECIMAL.ToLower(), DB_NAME_TYPE_OF_NUMERIC_DECIMAL);
                map.put(PROPERTY_NAME_TYPE_OF_NUMERIC_INTEGER.ToLower(), DB_NAME_TYPE_OF_NUMERIC_INTEGER);
                map.put(PROPERTY_NAME_TYPE_OF_NUMERIC_BIGINT.ToLower(), DB_NAME_TYPE_OF_NUMERIC_BIGINT);
                map.put(PROPERTY_NAME_TYPE_OF_BOOLEAN.ToLower(), DB_NAME_TYPE_OF_BOOLEAN);
                map.put(PROPERTY_NAME_TYPE_OF_TEXT.ToLower(), DB_NAME_TYPE_OF_TEXT);
                map.put(PROPERTY_NAME_TYPE_OF_BLOB.ToLower(), DB_NAME_TYPE_OF_BLOB);
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
        public override String EntityTypeName { get { return "DfExample.DBFlute.ExEntity.Customize.SimpleVendorCheck"; } }
        public override String DaoTypeName { get { return null; } }
        public override String ConditionBeanTypeName { get { return null; } }
        public override String BehaviorTypeName { get { return null; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override Entity NewEntity() { return NewMyEntity(); }
        public SimpleVendorCheck NewMyEntity() { return new SimpleVendorCheck(); }
        public override ConditionBean NewConditionBean() {
            String msg = "The entity does not have condition-bean. So this method is invalid.";
            throw new SystemException(msg + " dbmeta=" + ToString());
        }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<SimpleVendorCheck>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<SimpleVendorCheck>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("VENDOR_CHECK_ID", "VendorCheckId", new EntityPropertyVendorCheckIdSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("TYPE_OF_NUMERIC_DECIMAL", "TypeOfNumericDecimal", new EntityPropertyTypeOfNumericDecimalSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("TYPE_OF_NUMERIC_INTEGER", "TypeOfNumericInteger", new EntityPropertyTypeOfNumericIntegerSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("TYPE_OF_NUMERIC_BIGINT", "TypeOfNumericBigint", new EntityPropertyTypeOfNumericBigintSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("TYPE_OF_BOOLEAN", "TypeOfBoolean", new EntityPropertyTypeOfBooleanSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("TYPE_OF_TEXT", "TypeOfText", new EntityPropertyTypeOfTextSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("TYPE_OF_BLOB", "TypeOfBlob", new EntityPropertyTypeOfBlobSetupper(), _entityPropertySetupperMap);
        }

        public override bool HasEntityPropertySetupper(String propertyName) {
            return _entityPropertySetupperMap.containsKey(propertyName);
        }

        public override void SetupEntityProperty(String propertyName, Object entity, Object value) {
            EntityPropertySetupper<SimpleVendorCheck> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((SimpleVendorCheck)entity, value);
        }

        public class EntityPropertyVendorCheckIdSetupper : EntityPropertySetupper<SimpleVendorCheck> {
            public void Setup(SimpleVendorCheck entity, Object value) { entity.VendorCheckId = (value != null) ? (long?)value : null; }
        }
        public class EntityPropertyTypeOfNumericDecimalSetupper : EntityPropertySetupper<SimpleVendorCheck> {
            public void Setup(SimpleVendorCheck entity, Object value) { entity.TypeOfNumericDecimal = (value != null) ? (decimal?)value : null; }
        }
        public class EntityPropertyTypeOfNumericIntegerSetupper : EntityPropertySetupper<SimpleVendorCheck> {
            public void Setup(SimpleVendorCheck entity, Object value) { entity.TypeOfNumericInteger = (value != null) ? (int?)value : null; }
        }
        public class EntityPropertyTypeOfNumericBigintSetupper : EntityPropertySetupper<SimpleVendorCheck> {
            public void Setup(SimpleVendorCheck entity, Object value) { entity.TypeOfNumericBigint = (value != null) ? (long?)value : null; }
        }
        public class EntityPropertyTypeOfBooleanSetupper : EntityPropertySetupper<SimpleVendorCheck> {
            public void Setup(SimpleVendorCheck entity, Object value) { entity.TypeOfBoolean = (value != null) ? (bool?)value : null; }
        }
        public class EntityPropertyTypeOfTextSetupper : EntityPropertySetupper<SimpleVendorCheck> {
            public void Setup(SimpleVendorCheck entity, Object value) { entity.TypeOfText = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyTypeOfBlobSetupper : EntityPropertySetupper<SimpleVendorCheck> {
            public void Setup(SimpleVendorCheck entity, Object value) { entity.TypeOfBlob = (value != null) ? (byte[])value : null; }
        }
    }
}

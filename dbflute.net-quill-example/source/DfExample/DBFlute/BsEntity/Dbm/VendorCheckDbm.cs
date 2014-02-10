
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

    public class VendorCheckDbm : AbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(VendorCheck);

        private static readonly VendorCheckDbm _instance = new VendorCheckDbm();
        private VendorCheckDbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static VendorCheckDbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "vendor_check"; } }
        public override String TablePropertyName { get { return "VendorCheck"; } }
        public override String TableSqlName { get { return "vendor_check"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected ColumnInfo _columnVendorCheckId;
        protected ColumnInfo _columnTypeOfBoolean;
        protected ColumnInfo _columnTypeOfInteger;
        protected ColumnInfo _columnTypeOfBigint;
        protected ColumnInfo _columnTypeOfFloat;
        protected ColumnInfo _columnTypeOfDouble;
        protected ColumnInfo _columnTypeOfDecimalDecimal;
        protected ColumnInfo _columnTypeOfDecimalInteger;
        protected ColumnInfo _columnTypeOfDecimalBigint;
        protected ColumnInfo _columnTypeOfNumericDecimal;
        protected ColumnInfo _columnTypeOfNumericInteger;
        protected ColumnInfo _columnTypeOfNumericBigint;
        protected ColumnInfo _columnTypeOfText;
        protected ColumnInfo _columnTypeOfTinytext;
        protected ColumnInfo _columnTypeOfMediumtext;
        protected ColumnInfo _columnTypeOfLongtext;
        protected ColumnInfo _columnTypeOfDate;
        protected ColumnInfo _columnTypeOfDatetime;
        protected ColumnInfo _columnTypeOfTimestamp;
        protected ColumnInfo _columnTypeOfTime;
        protected ColumnInfo _columnTypeOfYear;
        protected ColumnInfo _columnTypeOfBlob;
        protected ColumnInfo _columnTypeOfTinyblob;
        protected ColumnInfo _columnTypeOfMediumblob;
        protected ColumnInfo _columnTypeOfLongblob;
        protected ColumnInfo _columnTypeOfBinary;
        protected ColumnInfo _columnTypeOfVarbinary;
        protected ColumnInfo _columnTypeOfEnum;
        protected ColumnInfo _columnTypeOfSet;

        public ColumnInfo ColumnVendorCheckId { get { return _columnVendorCheckId; } }
        public ColumnInfo ColumnTypeOfBoolean { get { return _columnTypeOfBoolean; } }
        public ColumnInfo ColumnTypeOfInteger { get { return _columnTypeOfInteger; } }
        public ColumnInfo ColumnTypeOfBigint { get { return _columnTypeOfBigint; } }
        public ColumnInfo ColumnTypeOfFloat { get { return _columnTypeOfFloat; } }
        public ColumnInfo ColumnTypeOfDouble { get { return _columnTypeOfDouble; } }
        public ColumnInfo ColumnTypeOfDecimalDecimal { get { return _columnTypeOfDecimalDecimal; } }
        public ColumnInfo ColumnTypeOfDecimalInteger { get { return _columnTypeOfDecimalInteger; } }
        public ColumnInfo ColumnTypeOfDecimalBigint { get { return _columnTypeOfDecimalBigint; } }
        public ColumnInfo ColumnTypeOfNumericDecimal { get { return _columnTypeOfNumericDecimal; } }
        public ColumnInfo ColumnTypeOfNumericInteger { get { return _columnTypeOfNumericInteger; } }
        public ColumnInfo ColumnTypeOfNumericBigint { get { return _columnTypeOfNumericBigint; } }
        public ColumnInfo ColumnTypeOfText { get { return _columnTypeOfText; } }
        public ColumnInfo ColumnTypeOfTinytext { get { return _columnTypeOfTinytext; } }
        public ColumnInfo ColumnTypeOfMediumtext { get { return _columnTypeOfMediumtext; } }
        public ColumnInfo ColumnTypeOfLongtext { get { return _columnTypeOfLongtext; } }
        public ColumnInfo ColumnTypeOfDate { get { return _columnTypeOfDate; } }
        public ColumnInfo ColumnTypeOfDatetime { get { return _columnTypeOfDatetime; } }
        public ColumnInfo ColumnTypeOfTimestamp { get { return _columnTypeOfTimestamp; } }
        public ColumnInfo ColumnTypeOfTime { get { return _columnTypeOfTime; } }
        public ColumnInfo ColumnTypeOfYear { get { return _columnTypeOfYear; } }
        public ColumnInfo ColumnTypeOfBlob { get { return _columnTypeOfBlob; } }
        public ColumnInfo ColumnTypeOfTinyblob { get { return _columnTypeOfTinyblob; } }
        public ColumnInfo ColumnTypeOfMediumblob { get { return _columnTypeOfMediumblob; } }
        public ColumnInfo ColumnTypeOfLongblob { get { return _columnTypeOfLongblob; } }
        public ColumnInfo ColumnTypeOfBinary { get { return _columnTypeOfBinary; } }
        public ColumnInfo ColumnTypeOfVarbinary { get { return _columnTypeOfVarbinary; } }
        public ColumnInfo ColumnTypeOfEnum { get { return _columnTypeOfEnum; } }
        public ColumnInfo ColumnTypeOfSet { get { return _columnTypeOfSet; } }

        protected void InitializeColumnInfo() {
            _columnVendorCheckId = cci("VENDOR_CHECK_ID", "VENDOR_CHECK_ID", null, null, true, "VendorCheckId", typeof(long?), true, "DECIMAL", 16, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnTypeOfBoolean = cci("TYPE_OF_BOOLEAN", "TYPE_OF_BOOLEAN", null, null, true, "TypeOfBoolean", typeof(bool?), false, "BIT", null, null, false, OptimisticLockType.NONE, null, null, null);
            _columnTypeOfInteger = cci("TYPE_OF_INTEGER", "TYPE_OF_INTEGER", null, null, false, "TypeOfInteger", typeof(int?), false, "INT", 10, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnTypeOfBigint = cci("TYPE_OF_BIGINT", "TYPE_OF_BIGINT", null, null, false, "TypeOfBigint", typeof(long?), false, "BIGINT", 19, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnTypeOfFloat = cci("TYPE_OF_FLOAT", "TYPE_OF_FLOAT", null, null, false, "TypeOfFloat", typeof(decimal?), false, "FLOAT", 12, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnTypeOfDouble = cci("TYPE_OF_DOUBLE", "TYPE_OF_DOUBLE", null, null, false, "TypeOfDouble", typeof(decimal?), false, "DOUBLE", 22, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnTypeOfDecimalDecimal = cci("TYPE_OF_DECIMAL_DECIMAL", "TYPE_OF_DECIMAL_DECIMAL", null, null, false, "TypeOfDecimalDecimal", typeof(decimal?), false, "DECIMAL", 5, 3, false, OptimisticLockType.NONE, null, null, null);
            _columnTypeOfDecimalInteger = cci("TYPE_OF_DECIMAL_INTEGER", "TYPE_OF_DECIMAL_INTEGER", null, null, false, "TypeOfDecimalInteger", typeof(int?), false, "DECIMAL", 5, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnTypeOfDecimalBigint = cci("TYPE_OF_DECIMAL_BIGINT", "TYPE_OF_DECIMAL_BIGINT", null, null, false, "TypeOfDecimalBigint", typeof(long?), false, "DECIMAL", 12, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnTypeOfNumericDecimal = cci("TYPE_OF_NUMERIC_DECIMAL", "TYPE_OF_NUMERIC_DECIMAL", null, null, false, "TypeOfNumericDecimal", typeof(decimal?), false, "DECIMAL", 5, 3, false, OptimisticLockType.NONE, null, null, null);
            _columnTypeOfNumericInteger = cci("TYPE_OF_NUMERIC_INTEGER", "TYPE_OF_NUMERIC_INTEGER", null, null, false, "TypeOfNumericInteger", typeof(int?), false, "DECIMAL", 5, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnTypeOfNumericBigint = cci("TYPE_OF_NUMERIC_BIGINT", "TYPE_OF_NUMERIC_BIGINT", null, null, false, "TypeOfNumericBigint", typeof(long?), false, "DECIMAL", 12, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnTypeOfText = cci("TYPE_OF_TEXT", "TYPE_OF_TEXT", null, null, false, "TypeOfText", typeof(String), false, "TEXT", 65535, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnTypeOfTinytext = cci("TYPE_OF_TINYTEXT", "TYPE_OF_TINYTEXT", null, null, false, "TypeOfTinytext", typeof(String), false, "TINYTEXT", 255, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnTypeOfMediumtext = cci("TYPE_OF_MEDIUMTEXT", "TYPE_OF_MEDIUMTEXT", null, null, false, "TypeOfMediumtext", typeof(String), false, "MEDIUMTEXT", 16777215, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnTypeOfLongtext = cci("TYPE_OF_LONGTEXT", "TYPE_OF_LONGTEXT", null, null, false, "TypeOfLongtext", typeof(String), false, "LONGTEXT", 2147483647, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnTypeOfDate = cci("TYPE_OF_DATE", "TYPE_OF_DATE", null, null, false, "TypeOfDate", typeof(DateTime?), false, "DATE", 10, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnTypeOfDatetime = cci("TYPE_OF_DATETIME", "TYPE_OF_DATETIME", null, null, false, "TypeOfDatetime", typeof(DateTime?), false, "DATETIME", 19, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnTypeOfTimestamp = cci("TYPE_OF_TIMESTAMP", "TYPE_OF_TIMESTAMP", null, null, true, "TypeOfTimestamp", typeof(DateTime?), false, "TIMESTAMP", 19, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnTypeOfTime = cci("TYPE_OF_TIME", "TYPE_OF_TIME", null, null, false, "TypeOfTime", typeof(DateTime?), false, "TIME", 8, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnTypeOfYear = cci("TYPE_OF_YEAR", "TYPE_OF_YEAR", null, null, false, "TypeOfYear", typeof(DateTime?), false, "YEAR", null, null, false, OptimisticLockType.NONE, null, null, null);
            _columnTypeOfBlob = cci("TYPE_OF_BLOB", "TYPE_OF_BLOB", null, null, false, "TypeOfBlob", typeof(byte[]), false, "BLOB", 65535, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnTypeOfTinyblob = cci("TYPE_OF_TINYBLOB", "TYPE_OF_TINYBLOB", null, null, false, "TypeOfTinyblob", typeof(byte[]), false, "TINYBLOB", 255, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnTypeOfMediumblob = cci("TYPE_OF_MEDIUMBLOB", "TYPE_OF_MEDIUMBLOB", null, null, false, "TypeOfMediumblob", typeof(byte[]), false, "MEDIUMBLOB", 16777215, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnTypeOfLongblob = cci("TYPE_OF_LONGBLOB", "TYPE_OF_LONGBLOB", null, null, false, "TypeOfLongblob", typeof(byte[]), false, "LONGBLOB", 2147483647, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnTypeOfBinary = cci("TYPE_OF_BINARY", "TYPE_OF_BINARY", null, null, false, "TypeOfBinary", typeof(byte[]), false, "BINARY", 1, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnTypeOfVarbinary = cci("TYPE_OF_VARBINARY", "TYPE_OF_VARBINARY", null, null, false, "TypeOfVarbinary", typeof(byte[]), false, "VARBINARY", 1000, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnTypeOfEnum = cci("TYPE_OF_ENUM", "TYPE_OF_ENUM", null, null, false, "TypeOfEnum", typeof(String), false, "ENUM", 6, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnTypeOfSet = cci("TYPE_OF_SET", "TYPE_OF_SET", null, null, false, "TypeOfSet", typeof(String), false, "SET", 15, 0, false, OptimisticLockType.NONE, null, null, null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<ColumnInfo>();
            _columnInfoList.add(ColumnVendorCheckId);
            _columnInfoList.add(ColumnTypeOfBoolean);
            _columnInfoList.add(ColumnTypeOfInteger);
            _columnInfoList.add(ColumnTypeOfBigint);
            _columnInfoList.add(ColumnTypeOfFloat);
            _columnInfoList.add(ColumnTypeOfDouble);
            _columnInfoList.add(ColumnTypeOfDecimalDecimal);
            _columnInfoList.add(ColumnTypeOfDecimalInteger);
            _columnInfoList.add(ColumnTypeOfDecimalBigint);
            _columnInfoList.add(ColumnTypeOfNumericDecimal);
            _columnInfoList.add(ColumnTypeOfNumericInteger);
            _columnInfoList.add(ColumnTypeOfNumericBigint);
            _columnInfoList.add(ColumnTypeOfText);
            _columnInfoList.add(ColumnTypeOfTinytext);
            _columnInfoList.add(ColumnTypeOfMediumtext);
            _columnInfoList.add(ColumnTypeOfLongtext);
            _columnInfoList.add(ColumnTypeOfDate);
            _columnInfoList.add(ColumnTypeOfDatetime);
            _columnInfoList.add(ColumnTypeOfTimestamp);
            _columnInfoList.add(ColumnTypeOfTime);
            _columnInfoList.add(ColumnTypeOfYear);
            _columnInfoList.add(ColumnTypeOfBlob);
            _columnInfoList.add(ColumnTypeOfTinyblob);
            _columnInfoList.add(ColumnTypeOfMediumblob);
            _columnInfoList.add(ColumnTypeOfLongblob);
            _columnInfoList.add(ColumnTypeOfBinary);
            _columnInfoList.add(ColumnTypeOfVarbinary);
            _columnInfoList.add(ColumnTypeOfEnum);
            _columnInfoList.add(ColumnTypeOfSet);
        }

        // ===============================================================================
        //                                                                     Unique Info
        //                                                                     ===========
        public override UniqueInfo PrimaryUniqueInfo { get {
            return cpui(ColumnVendorCheckId);
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
        public static readonly String TABLE_DB_NAME = "vendor_check";
        public static readonly String TABLE_PROPERTY_NAME = "VendorCheck";

        // -------------------------------------------------
        //                                    Column DB-Name
        //                                    --------------
        public static readonly String DB_NAME_VENDOR_CHECK_ID = "VENDOR_CHECK_ID";
        public static readonly String DB_NAME_TYPE_OF_BOOLEAN = "TYPE_OF_BOOLEAN";
        public static readonly String DB_NAME_TYPE_OF_INTEGER = "TYPE_OF_INTEGER";
        public static readonly String DB_NAME_TYPE_OF_BIGINT = "TYPE_OF_BIGINT";
        public static readonly String DB_NAME_TYPE_OF_FLOAT = "TYPE_OF_FLOAT";
        public static readonly String DB_NAME_TYPE_OF_DOUBLE = "TYPE_OF_DOUBLE";
        public static readonly String DB_NAME_TYPE_OF_DECIMAL_DECIMAL = "TYPE_OF_DECIMAL_DECIMAL";
        public static readonly String DB_NAME_TYPE_OF_DECIMAL_INTEGER = "TYPE_OF_DECIMAL_INTEGER";
        public static readonly String DB_NAME_TYPE_OF_DECIMAL_BIGINT = "TYPE_OF_DECIMAL_BIGINT";
        public static readonly String DB_NAME_TYPE_OF_NUMERIC_DECIMAL = "TYPE_OF_NUMERIC_DECIMAL";
        public static readonly String DB_NAME_TYPE_OF_NUMERIC_INTEGER = "TYPE_OF_NUMERIC_INTEGER";
        public static readonly String DB_NAME_TYPE_OF_NUMERIC_BIGINT = "TYPE_OF_NUMERIC_BIGINT";
        public static readonly String DB_NAME_TYPE_OF_TEXT = "TYPE_OF_TEXT";
        public static readonly String DB_NAME_TYPE_OF_TINYTEXT = "TYPE_OF_TINYTEXT";
        public static readonly String DB_NAME_TYPE_OF_MEDIUMTEXT = "TYPE_OF_MEDIUMTEXT";
        public static readonly String DB_NAME_TYPE_OF_LONGTEXT = "TYPE_OF_LONGTEXT";
        public static readonly String DB_NAME_TYPE_OF_DATE = "TYPE_OF_DATE";
        public static readonly String DB_NAME_TYPE_OF_DATETIME = "TYPE_OF_DATETIME";
        public static readonly String DB_NAME_TYPE_OF_TIMESTAMP = "TYPE_OF_TIMESTAMP";
        public static readonly String DB_NAME_TYPE_OF_TIME = "TYPE_OF_TIME";
        public static readonly String DB_NAME_TYPE_OF_YEAR = "TYPE_OF_YEAR";
        public static readonly String DB_NAME_TYPE_OF_BLOB = "TYPE_OF_BLOB";
        public static readonly String DB_NAME_TYPE_OF_TINYBLOB = "TYPE_OF_TINYBLOB";
        public static readonly String DB_NAME_TYPE_OF_MEDIUMBLOB = "TYPE_OF_MEDIUMBLOB";
        public static readonly String DB_NAME_TYPE_OF_LONGBLOB = "TYPE_OF_LONGBLOB";
        public static readonly String DB_NAME_TYPE_OF_BINARY = "TYPE_OF_BINARY";
        public static readonly String DB_NAME_TYPE_OF_VARBINARY = "TYPE_OF_VARBINARY";
        public static readonly String DB_NAME_TYPE_OF_ENUM = "TYPE_OF_ENUM";
        public static readonly String DB_NAME_TYPE_OF_SET = "TYPE_OF_SET";

        // -------------------------------------------------
        //                              Column Property-Name
        //                              --------------------
        public static readonly String PROPERTY_NAME_VENDOR_CHECK_ID = "VendorCheckId";
        public static readonly String PROPERTY_NAME_TYPE_OF_BOOLEAN = "TypeOfBoolean";
        public static readonly String PROPERTY_NAME_TYPE_OF_INTEGER = "TypeOfInteger";
        public static readonly String PROPERTY_NAME_TYPE_OF_BIGINT = "TypeOfBigint";
        public static readonly String PROPERTY_NAME_TYPE_OF_FLOAT = "TypeOfFloat";
        public static readonly String PROPERTY_NAME_TYPE_OF_DOUBLE = "TypeOfDouble";
        public static readonly String PROPERTY_NAME_TYPE_OF_DECIMAL_DECIMAL = "TypeOfDecimalDecimal";
        public static readonly String PROPERTY_NAME_TYPE_OF_DECIMAL_INTEGER = "TypeOfDecimalInteger";
        public static readonly String PROPERTY_NAME_TYPE_OF_DECIMAL_BIGINT = "TypeOfDecimalBigint";
        public static readonly String PROPERTY_NAME_TYPE_OF_NUMERIC_DECIMAL = "TypeOfNumericDecimal";
        public static readonly String PROPERTY_NAME_TYPE_OF_NUMERIC_INTEGER = "TypeOfNumericInteger";
        public static readonly String PROPERTY_NAME_TYPE_OF_NUMERIC_BIGINT = "TypeOfNumericBigint";
        public static readonly String PROPERTY_NAME_TYPE_OF_TEXT = "TypeOfText";
        public static readonly String PROPERTY_NAME_TYPE_OF_TINYTEXT = "TypeOfTinytext";
        public static readonly String PROPERTY_NAME_TYPE_OF_MEDIUMTEXT = "TypeOfMediumtext";
        public static readonly String PROPERTY_NAME_TYPE_OF_LONGTEXT = "TypeOfLongtext";
        public static readonly String PROPERTY_NAME_TYPE_OF_DATE = "TypeOfDate";
        public static readonly String PROPERTY_NAME_TYPE_OF_DATETIME = "TypeOfDatetime";
        public static readonly String PROPERTY_NAME_TYPE_OF_TIMESTAMP = "TypeOfTimestamp";
        public static readonly String PROPERTY_NAME_TYPE_OF_TIME = "TypeOfTime";
        public static readonly String PROPERTY_NAME_TYPE_OF_YEAR = "TypeOfYear";
        public static readonly String PROPERTY_NAME_TYPE_OF_BLOB = "TypeOfBlob";
        public static readonly String PROPERTY_NAME_TYPE_OF_TINYBLOB = "TypeOfTinyblob";
        public static readonly String PROPERTY_NAME_TYPE_OF_MEDIUMBLOB = "TypeOfMediumblob";
        public static readonly String PROPERTY_NAME_TYPE_OF_LONGBLOB = "TypeOfLongblob";
        public static readonly String PROPERTY_NAME_TYPE_OF_BINARY = "TypeOfBinary";
        public static readonly String PROPERTY_NAME_TYPE_OF_VARBINARY = "TypeOfVarbinary";
        public static readonly String PROPERTY_NAME_TYPE_OF_ENUM = "TypeOfEnum";
        public static readonly String PROPERTY_NAME_TYPE_OF_SET = "TypeOfSet";

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

        static VendorCheckDbm() {
            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_DB_NAME.ToLower(), TABLE_PROPERTY_NAME);
                map.put(DB_NAME_VENDOR_CHECK_ID.ToLower(), PROPERTY_NAME_VENDOR_CHECK_ID);
                map.put(DB_NAME_TYPE_OF_BOOLEAN.ToLower(), PROPERTY_NAME_TYPE_OF_BOOLEAN);
                map.put(DB_NAME_TYPE_OF_INTEGER.ToLower(), PROPERTY_NAME_TYPE_OF_INTEGER);
                map.put(DB_NAME_TYPE_OF_BIGINT.ToLower(), PROPERTY_NAME_TYPE_OF_BIGINT);
                map.put(DB_NAME_TYPE_OF_FLOAT.ToLower(), PROPERTY_NAME_TYPE_OF_FLOAT);
                map.put(DB_NAME_TYPE_OF_DOUBLE.ToLower(), PROPERTY_NAME_TYPE_OF_DOUBLE);
                map.put(DB_NAME_TYPE_OF_DECIMAL_DECIMAL.ToLower(), PROPERTY_NAME_TYPE_OF_DECIMAL_DECIMAL);
                map.put(DB_NAME_TYPE_OF_DECIMAL_INTEGER.ToLower(), PROPERTY_NAME_TYPE_OF_DECIMAL_INTEGER);
                map.put(DB_NAME_TYPE_OF_DECIMAL_BIGINT.ToLower(), PROPERTY_NAME_TYPE_OF_DECIMAL_BIGINT);
                map.put(DB_NAME_TYPE_OF_NUMERIC_DECIMAL.ToLower(), PROPERTY_NAME_TYPE_OF_NUMERIC_DECIMAL);
                map.put(DB_NAME_TYPE_OF_NUMERIC_INTEGER.ToLower(), PROPERTY_NAME_TYPE_OF_NUMERIC_INTEGER);
                map.put(DB_NAME_TYPE_OF_NUMERIC_BIGINT.ToLower(), PROPERTY_NAME_TYPE_OF_NUMERIC_BIGINT);
                map.put(DB_NAME_TYPE_OF_TEXT.ToLower(), PROPERTY_NAME_TYPE_OF_TEXT);
                map.put(DB_NAME_TYPE_OF_TINYTEXT.ToLower(), PROPERTY_NAME_TYPE_OF_TINYTEXT);
                map.put(DB_NAME_TYPE_OF_MEDIUMTEXT.ToLower(), PROPERTY_NAME_TYPE_OF_MEDIUMTEXT);
                map.put(DB_NAME_TYPE_OF_LONGTEXT.ToLower(), PROPERTY_NAME_TYPE_OF_LONGTEXT);
                map.put(DB_NAME_TYPE_OF_DATE.ToLower(), PROPERTY_NAME_TYPE_OF_DATE);
                map.put(DB_NAME_TYPE_OF_DATETIME.ToLower(), PROPERTY_NAME_TYPE_OF_DATETIME);
                map.put(DB_NAME_TYPE_OF_TIMESTAMP.ToLower(), PROPERTY_NAME_TYPE_OF_TIMESTAMP);
                map.put(DB_NAME_TYPE_OF_TIME.ToLower(), PROPERTY_NAME_TYPE_OF_TIME);
                map.put(DB_NAME_TYPE_OF_YEAR.ToLower(), PROPERTY_NAME_TYPE_OF_YEAR);
                map.put(DB_NAME_TYPE_OF_BLOB.ToLower(), PROPERTY_NAME_TYPE_OF_BLOB);
                map.put(DB_NAME_TYPE_OF_TINYBLOB.ToLower(), PROPERTY_NAME_TYPE_OF_TINYBLOB);
                map.put(DB_NAME_TYPE_OF_MEDIUMBLOB.ToLower(), PROPERTY_NAME_TYPE_OF_MEDIUMBLOB);
                map.put(DB_NAME_TYPE_OF_LONGBLOB.ToLower(), PROPERTY_NAME_TYPE_OF_LONGBLOB);
                map.put(DB_NAME_TYPE_OF_BINARY.ToLower(), PROPERTY_NAME_TYPE_OF_BINARY);
                map.put(DB_NAME_TYPE_OF_VARBINARY.ToLower(), PROPERTY_NAME_TYPE_OF_VARBINARY);
                map.put(DB_NAME_TYPE_OF_ENUM.ToLower(), PROPERTY_NAME_TYPE_OF_ENUM);
                map.put(DB_NAME_TYPE_OF_SET.ToLower(), PROPERTY_NAME_TYPE_OF_SET);
                _dbNamePropertyNameKeyToLowerMap = map;
            }

            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_PROPERTY_NAME.ToLower(), TABLE_DB_NAME);
                map.put(PROPERTY_NAME_VENDOR_CHECK_ID.ToLower(), DB_NAME_VENDOR_CHECK_ID);
                map.put(PROPERTY_NAME_TYPE_OF_BOOLEAN.ToLower(), DB_NAME_TYPE_OF_BOOLEAN);
                map.put(PROPERTY_NAME_TYPE_OF_INTEGER.ToLower(), DB_NAME_TYPE_OF_INTEGER);
                map.put(PROPERTY_NAME_TYPE_OF_BIGINT.ToLower(), DB_NAME_TYPE_OF_BIGINT);
                map.put(PROPERTY_NAME_TYPE_OF_FLOAT.ToLower(), DB_NAME_TYPE_OF_FLOAT);
                map.put(PROPERTY_NAME_TYPE_OF_DOUBLE.ToLower(), DB_NAME_TYPE_OF_DOUBLE);
                map.put(PROPERTY_NAME_TYPE_OF_DECIMAL_DECIMAL.ToLower(), DB_NAME_TYPE_OF_DECIMAL_DECIMAL);
                map.put(PROPERTY_NAME_TYPE_OF_DECIMAL_INTEGER.ToLower(), DB_NAME_TYPE_OF_DECIMAL_INTEGER);
                map.put(PROPERTY_NAME_TYPE_OF_DECIMAL_BIGINT.ToLower(), DB_NAME_TYPE_OF_DECIMAL_BIGINT);
                map.put(PROPERTY_NAME_TYPE_OF_NUMERIC_DECIMAL.ToLower(), DB_NAME_TYPE_OF_NUMERIC_DECIMAL);
                map.put(PROPERTY_NAME_TYPE_OF_NUMERIC_INTEGER.ToLower(), DB_NAME_TYPE_OF_NUMERIC_INTEGER);
                map.put(PROPERTY_NAME_TYPE_OF_NUMERIC_BIGINT.ToLower(), DB_NAME_TYPE_OF_NUMERIC_BIGINT);
                map.put(PROPERTY_NAME_TYPE_OF_TEXT.ToLower(), DB_NAME_TYPE_OF_TEXT);
                map.put(PROPERTY_NAME_TYPE_OF_TINYTEXT.ToLower(), DB_NAME_TYPE_OF_TINYTEXT);
                map.put(PROPERTY_NAME_TYPE_OF_MEDIUMTEXT.ToLower(), DB_NAME_TYPE_OF_MEDIUMTEXT);
                map.put(PROPERTY_NAME_TYPE_OF_LONGTEXT.ToLower(), DB_NAME_TYPE_OF_LONGTEXT);
                map.put(PROPERTY_NAME_TYPE_OF_DATE.ToLower(), DB_NAME_TYPE_OF_DATE);
                map.put(PROPERTY_NAME_TYPE_OF_DATETIME.ToLower(), DB_NAME_TYPE_OF_DATETIME);
                map.put(PROPERTY_NAME_TYPE_OF_TIMESTAMP.ToLower(), DB_NAME_TYPE_OF_TIMESTAMP);
                map.put(PROPERTY_NAME_TYPE_OF_TIME.ToLower(), DB_NAME_TYPE_OF_TIME);
                map.put(PROPERTY_NAME_TYPE_OF_YEAR.ToLower(), DB_NAME_TYPE_OF_YEAR);
                map.put(PROPERTY_NAME_TYPE_OF_BLOB.ToLower(), DB_NAME_TYPE_OF_BLOB);
                map.put(PROPERTY_NAME_TYPE_OF_TINYBLOB.ToLower(), DB_NAME_TYPE_OF_TINYBLOB);
                map.put(PROPERTY_NAME_TYPE_OF_MEDIUMBLOB.ToLower(), DB_NAME_TYPE_OF_MEDIUMBLOB);
                map.put(PROPERTY_NAME_TYPE_OF_LONGBLOB.ToLower(), DB_NAME_TYPE_OF_LONGBLOB);
                map.put(PROPERTY_NAME_TYPE_OF_BINARY.ToLower(), DB_NAME_TYPE_OF_BINARY);
                map.put(PROPERTY_NAME_TYPE_OF_VARBINARY.ToLower(), DB_NAME_TYPE_OF_VARBINARY);
                map.put(PROPERTY_NAME_TYPE_OF_ENUM.ToLower(), DB_NAME_TYPE_OF_ENUM);
                map.put(PROPERTY_NAME_TYPE_OF_SET.ToLower(), DB_NAME_TYPE_OF_SET);
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
        public override String EntityTypeName { get { return "DfExample.DBFlute.ExEntity.VendorCheck"; } }
        public override String DaoTypeName { get { return "DfExample.DBFlute.ExDao.VendorCheckDao"; } }
        public override String ConditionBeanTypeName { get { return "DfExample.DBFlute.CBean.VendorCheckCB"; } }
        public override String BehaviorTypeName { get { return "DfExample.DBFlute.ExBhv.VendorCheckBhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override Entity NewEntity() { return NewMyEntity(); }
        public VendorCheck NewMyEntity() { return new VendorCheck(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public VendorCheckCB NewMyConditionBean() { return new VendorCheckCB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<VendorCheck>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<VendorCheck>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("VENDOR_CHECK_ID", "VendorCheckId", new EntityPropertyVendorCheckIdSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("TYPE_OF_BOOLEAN", "TypeOfBoolean", new EntityPropertyTypeOfBooleanSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("TYPE_OF_INTEGER", "TypeOfInteger", new EntityPropertyTypeOfIntegerSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("TYPE_OF_BIGINT", "TypeOfBigint", new EntityPropertyTypeOfBigintSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("TYPE_OF_FLOAT", "TypeOfFloat", new EntityPropertyTypeOfFloatSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("TYPE_OF_DOUBLE", "TypeOfDouble", new EntityPropertyTypeOfDoubleSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("TYPE_OF_DECIMAL_DECIMAL", "TypeOfDecimalDecimal", new EntityPropertyTypeOfDecimalDecimalSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("TYPE_OF_DECIMAL_INTEGER", "TypeOfDecimalInteger", new EntityPropertyTypeOfDecimalIntegerSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("TYPE_OF_DECIMAL_BIGINT", "TypeOfDecimalBigint", new EntityPropertyTypeOfDecimalBigintSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("TYPE_OF_NUMERIC_DECIMAL", "TypeOfNumericDecimal", new EntityPropertyTypeOfNumericDecimalSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("TYPE_OF_NUMERIC_INTEGER", "TypeOfNumericInteger", new EntityPropertyTypeOfNumericIntegerSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("TYPE_OF_NUMERIC_BIGINT", "TypeOfNumericBigint", new EntityPropertyTypeOfNumericBigintSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("TYPE_OF_TEXT", "TypeOfText", new EntityPropertyTypeOfTextSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("TYPE_OF_TINYTEXT", "TypeOfTinytext", new EntityPropertyTypeOfTinytextSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("TYPE_OF_MEDIUMTEXT", "TypeOfMediumtext", new EntityPropertyTypeOfMediumtextSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("TYPE_OF_LONGTEXT", "TypeOfLongtext", new EntityPropertyTypeOfLongtextSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("TYPE_OF_DATE", "TypeOfDate", new EntityPropertyTypeOfDateSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("TYPE_OF_DATETIME", "TypeOfDatetime", new EntityPropertyTypeOfDatetimeSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("TYPE_OF_TIMESTAMP", "TypeOfTimestamp", new EntityPropertyTypeOfTimestampSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("TYPE_OF_TIME", "TypeOfTime", new EntityPropertyTypeOfTimeSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("TYPE_OF_YEAR", "TypeOfYear", new EntityPropertyTypeOfYearSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("TYPE_OF_BLOB", "TypeOfBlob", new EntityPropertyTypeOfBlobSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("TYPE_OF_TINYBLOB", "TypeOfTinyblob", new EntityPropertyTypeOfTinyblobSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("TYPE_OF_MEDIUMBLOB", "TypeOfMediumblob", new EntityPropertyTypeOfMediumblobSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("TYPE_OF_LONGBLOB", "TypeOfLongblob", new EntityPropertyTypeOfLongblobSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("TYPE_OF_BINARY", "TypeOfBinary", new EntityPropertyTypeOfBinarySetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("TYPE_OF_VARBINARY", "TypeOfVarbinary", new EntityPropertyTypeOfVarbinarySetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("TYPE_OF_ENUM", "TypeOfEnum", new EntityPropertyTypeOfEnumSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("TYPE_OF_SET", "TypeOfSet", new EntityPropertyTypeOfSetSetupper(), _entityPropertySetupperMap);
        }

        public override bool HasEntityPropertySetupper(String propertyName) {
            return _entityPropertySetupperMap.containsKey(propertyName);
        }

        public override void SetupEntityProperty(String propertyName, Object entity, Object value) {
            EntityPropertySetupper<VendorCheck> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((VendorCheck)entity, value);
        }

        public class EntityPropertyVendorCheckIdSetupper : EntityPropertySetupper<VendorCheck> {
            public void Setup(VendorCheck entity, Object value) { entity.VendorCheckId = (value != null) ? (long?)value : null; }
        }
        public class EntityPropertyTypeOfBooleanSetupper : EntityPropertySetupper<VendorCheck> {
            public void Setup(VendorCheck entity, Object value) { entity.TypeOfBoolean = (value != null) ? (bool?)value : null; }
        }
        public class EntityPropertyTypeOfIntegerSetupper : EntityPropertySetupper<VendorCheck> {
            public void Setup(VendorCheck entity, Object value) { entity.TypeOfInteger = (value != null) ? (int?)value : null; }
        }
        public class EntityPropertyTypeOfBigintSetupper : EntityPropertySetupper<VendorCheck> {
            public void Setup(VendorCheck entity, Object value) { entity.TypeOfBigint = (value != null) ? (long?)value : null; }
        }
        public class EntityPropertyTypeOfFloatSetupper : EntityPropertySetupper<VendorCheck> {
            public void Setup(VendorCheck entity, Object value) { entity.TypeOfFloat = (value != null) ? (decimal?)value : null; }
        }
        public class EntityPropertyTypeOfDoubleSetupper : EntityPropertySetupper<VendorCheck> {
            public void Setup(VendorCheck entity, Object value) { entity.TypeOfDouble = (value != null) ? (decimal?)value : null; }
        }
        public class EntityPropertyTypeOfDecimalDecimalSetupper : EntityPropertySetupper<VendorCheck> {
            public void Setup(VendorCheck entity, Object value) { entity.TypeOfDecimalDecimal = (value != null) ? (decimal?)value : null; }
        }
        public class EntityPropertyTypeOfDecimalIntegerSetupper : EntityPropertySetupper<VendorCheck> {
            public void Setup(VendorCheck entity, Object value) { entity.TypeOfDecimalInteger = (value != null) ? (int?)value : null; }
        }
        public class EntityPropertyTypeOfDecimalBigintSetupper : EntityPropertySetupper<VendorCheck> {
            public void Setup(VendorCheck entity, Object value) { entity.TypeOfDecimalBigint = (value != null) ? (long?)value : null; }
        }
        public class EntityPropertyTypeOfNumericDecimalSetupper : EntityPropertySetupper<VendorCheck> {
            public void Setup(VendorCheck entity, Object value) { entity.TypeOfNumericDecimal = (value != null) ? (decimal?)value : null; }
        }
        public class EntityPropertyTypeOfNumericIntegerSetupper : EntityPropertySetupper<VendorCheck> {
            public void Setup(VendorCheck entity, Object value) { entity.TypeOfNumericInteger = (value != null) ? (int?)value : null; }
        }
        public class EntityPropertyTypeOfNumericBigintSetupper : EntityPropertySetupper<VendorCheck> {
            public void Setup(VendorCheck entity, Object value) { entity.TypeOfNumericBigint = (value != null) ? (long?)value : null; }
        }
        public class EntityPropertyTypeOfTextSetupper : EntityPropertySetupper<VendorCheck> {
            public void Setup(VendorCheck entity, Object value) { entity.TypeOfText = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyTypeOfTinytextSetupper : EntityPropertySetupper<VendorCheck> {
            public void Setup(VendorCheck entity, Object value) { entity.TypeOfTinytext = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyTypeOfMediumtextSetupper : EntityPropertySetupper<VendorCheck> {
            public void Setup(VendorCheck entity, Object value) { entity.TypeOfMediumtext = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyTypeOfLongtextSetupper : EntityPropertySetupper<VendorCheck> {
            public void Setup(VendorCheck entity, Object value) { entity.TypeOfLongtext = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyTypeOfDateSetupper : EntityPropertySetupper<VendorCheck> {
            public void Setup(VendorCheck entity, Object value) { entity.TypeOfDate = (value != null) ? (DateTime?)value : null; }
        }
        public class EntityPropertyTypeOfDatetimeSetupper : EntityPropertySetupper<VendorCheck> {
            public void Setup(VendorCheck entity, Object value) { entity.TypeOfDatetime = (value != null) ? (DateTime?)value : null; }
        }
        public class EntityPropertyTypeOfTimestampSetupper : EntityPropertySetupper<VendorCheck> {
            public void Setup(VendorCheck entity, Object value) { entity.TypeOfTimestamp = (value != null) ? (DateTime?)value : null; }
        }
        public class EntityPropertyTypeOfTimeSetupper : EntityPropertySetupper<VendorCheck> {
            public void Setup(VendorCheck entity, Object value) { entity.TypeOfTime = (value != null) ? (DateTime?)value : null; }
        }
        public class EntityPropertyTypeOfYearSetupper : EntityPropertySetupper<VendorCheck> {
            public void Setup(VendorCheck entity, Object value) { entity.TypeOfYear = (value != null) ? (DateTime?)value : null; }
        }
        public class EntityPropertyTypeOfBlobSetupper : EntityPropertySetupper<VendorCheck> {
            public void Setup(VendorCheck entity, Object value) { entity.TypeOfBlob = (value != null) ? (byte[])value : null; }
        }
        public class EntityPropertyTypeOfTinyblobSetupper : EntityPropertySetupper<VendorCheck> {
            public void Setup(VendorCheck entity, Object value) { entity.TypeOfTinyblob = (value != null) ? (byte[])value : null; }
        }
        public class EntityPropertyTypeOfMediumblobSetupper : EntityPropertySetupper<VendorCheck> {
            public void Setup(VendorCheck entity, Object value) { entity.TypeOfMediumblob = (value != null) ? (byte[])value : null; }
        }
        public class EntityPropertyTypeOfLongblobSetupper : EntityPropertySetupper<VendorCheck> {
            public void Setup(VendorCheck entity, Object value) { entity.TypeOfLongblob = (value != null) ? (byte[])value : null; }
        }
        public class EntityPropertyTypeOfBinarySetupper : EntityPropertySetupper<VendorCheck> {
            public void Setup(VendorCheck entity, Object value) { entity.TypeOfBinary = (value != null) ? (byte[])value : null; }
        }
        public class EntityPropertyTypeOfVarbinarySetupper : EntityPropertySetupper<VendorCheck> {
            public void Setup(VendorCheck entity, Object value) { entity.TypeOfVarbinary = (value != null) ? (byte[])value : null; }
        }
        public class EntityPropertyTypeOfEnumSetupper : EntityPropertySetupper<VendorCheck> {
            public void Setup(VendorCheck entity, Object value) { entity.TypeOfEnum = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyTypeOfSetSetupper : EntityPropertySetupper<VendorCheck> {
            public void Setup(VendorCheck entity, Object value) { entity.TypeOfSet = (value != null) ? (String)value : null; }
        }
    }
}

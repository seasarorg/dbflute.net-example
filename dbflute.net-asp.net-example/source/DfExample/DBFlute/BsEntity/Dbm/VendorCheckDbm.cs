
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
        public override String TableDbName { get { return "VENDOR_CHECK"; } }
        public override String TablePropertyName { get { return "VendorCheck"; } }
        public override String TableSqlName { get { return "VENDOR_CHECK"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected ColumnInfo _columnVendorCheckId;
        protected ColumnInfo _columnDecimalDigit;
        protected ColumnInfo _columnIntegerNonDigit;
        protected ColumnInfo _columnLargeCharacter;
        protected ColumnInfo _columnTypeOfChar;
        protected ColumnInfo _columnTypeOfNchar;
        protected ColumnInfo _columnTypeOfVarchar2;
        protected ColumnInfo _columnTypeOfVarchar2Max;
        protected ColumnInfo _columnTypeOfNvarchar2;
        protected ColumnInfo _columnTypeOfClob;
        protected ColumnInfo _columnTypeOfNclob;
        protected ColumnInfo _columnTypeOfDate;
        protected ColumnInfo _columnTypeOfTimestamp;
        protected ColumnInfo _columnTypeOfBlob;
        protected ColumnInfo _columnTypeOfRaw;
        protected ColumnInfo _columnTypeOfBfile;

        public ColumnInfo ColumnVendorCheckId { get { return _columnVendorCheckId; } }
        public ColumnInfo ColumnDecimalDigit { get { return _columnDecimalDigit; } }
        public ColumnInfo ColumnIntegerNonDigit { get { return _columnIntegerNonDigit; } }
        public ColumnInfo ColumnLargeCharacter { get { return _columnLargeCharacter; } }
        public ColumnInfo ColumnTypeOfChar { get { return _columnTypeOfChar; } }
        public ColumnInfo ColumnTypeOfNchar { get { return _columnTypeOfNchar; } }
        public ColumnInfo ColumnTypeOfVarchar2 { get { return _columnTypeOfVarchar2; } }
        public ColumnInfo ColumnTypeOfVarchar2Max { get { return _columnTypeOfVarchar2Max; } }
        public ColumnInfo ColumnTypeOfNvarchar2 { get { return _columnTypeOfNvarchar2; } }
        public ColumnInfo ColumnTypeOfClob { get { return _columnTypeOfClob; } }
        public ColumnInfo ColumnTypeOfNclob { get { return _columnTypeOfNclob; } }
        public ColumnInfo ColumnTypeOfDate { get { return _columnTypeOfDate; } }
        public ColumnInfo ColumnTypeOfTimestamp { get { return _columnTypeOfTimestamp; } }
        public ColumnInfo ColumnTypeOfBlob { get { return _columnTypeOfBlob; } }
        public ColumnInfo ColumnTypeOfRaw { get { return _columnTypeOfRaw; } }
        public ColumnInfo ColumnTypeOfBfile { get { return _columnTypeOfBfile; } }

        protected void InitializeColumnInfo() {
            _columnVendorCheckId = cci("VENDOR_CHECK_ID", "VENDOR_CHECK_ID", null, null, true, "VendorCheckId", typeof(long?), true, "NUMBER", 16, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnDecimalDigit = cci("DECIMAL_DIGIT", "DECIMAL_DIGIT", null, null, true, "DecimalDigit", typeof(decimal?), false, "NUMBER", 5, 3, false, OptimisticLockType.NONE, null, null, null);
            _columnIntegerNonDigit = cci("INTEGER_NON_DIGIT", "INTEGER_NON_DIGIT", null, null, true, "IntegerNonDigit", typeof(int?), false, "NUMBER", 5, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnLargeCharacter = cci("LARGE_CHARACTER", "LARGE_CHARACTER", null, null, false, "LargeCharacter", typeof(String), false, "CLOB", 4000, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnTypeOfChar = cci("TYPE_OF_CHAR", "TYPE_OF_CHAR", null, null, false, "TypeOfChar", typeof(String), false, "CHAR", 3, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnTypeOfNchar = cci("TYPE_OF_NCHAR", "TYPE_OF_NCHAR", null, null, false, "TypeOfNchar", typeof(String), false, "NCHAR", 3, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnTypeOfVarchar2 = cci("TYPE_OF_VARCHAR2", "TYPE_OF_VARCHAR2", null, null, false, "TypeOfVarchar2", typeof(String), false, "VARCHAR2", 32, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnTypeOfVarchar2Max = cci("TYPE_OF_VARCHAR2_MAX", "TYPE_OF_VARCHAR2_MAX", null, null, false, "TypeOfVarchar2Max", typeof(String), false, "VARCHAR2", 4000, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnTypeOfNvarchar2 = cci("TYPE_OF_NVARCHAR2", "TYPE_OF_NVARCHAR2", null, null, false, "TypeOfNvarchar2", typeof(String), false, "NVARCHAR2", 32, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnTypeOfClob = cci("TYPE_OF_CLOB", "TYPE_OF_CLOB", null, null, false, "TypeOfClob", typeof(String), false, "CLOB", 4000, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnTypeOfNclob = cci("TYPE_OF_NCLOB", "TYPE_OF_NCLOB", null, null, false, "TypeOfNclob", typeof(String), false, "NCLOB", 4000, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnTypeOfDate = cci("TYPE_OF_DATE", "TYPE_OF_DATE", null, null, false, "TypeOfDate", typeof(DateTime?), false, "DATE", 7, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnTypeOfTimestamp = cci("TYPE_OF_TIMESTAMP", "TYPE_OF_TIMESTAMP", null, null, false, "TypeOfTimestamp", typeof(DateTime?), false, "TIMESTAMP(6)", 11, 6, false, OptimisticLockType.NONE, null, null, null);
            _columnTypeOfBlob = cci("TYPE_OF_BLOB", "TYPE_OF_BLOB", null, null, false, "TypeOfBlob", typeof(byte[]), false, "BLOB", 4000, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnTypeOfRaw = cci("TYPE_OF_RAW", "TYPE_OF_RAW", null, null, false, "TypeOfRaw", typeof(byte[]), false, "RAW", 512, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnTypeOfBfile = cci("TYPE_OF_BFILE", "TYPE_OF_BFILE", null, null, false, "TypeOfBfile", typeof(String), false, "BFILE", 530, 0, false, OptimisticLockType.NONE, null, null, null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<ColumnInfo>();
            _columnInfoList.add(ColumnVendorCheckId);
            _columnInfoList.add(ColumnDecimalDigit);
            _columnInfoList.add(ColumnIntegerNonDigit);
            _columnInfoList.add(ColumnLargeCharacter);
            _columnInfoList.add(ColumnTypeOfChar);
            _columnInfoList.add(ColumnTypeOfNchar);
            _columnInfoList.add(ColumnTypeOfVarchar2);
            _columnInfoList.add(ColumnTypeOfVarchar2Max);
            _columnInfoList.add(ColumnTypeOfNvarchar2);
            _columnInfoList.add(ColumnTypeOfClob);
            _columnInfoList.add(ColumnTypeOfNclob);
            _columnInfoList.add(ColumnTypeOfDate);
            _columnInfoList.add(ColumnTypeOfTimestamp);
            _columnInfoList.add(ColumnTypeOfBlob);
            _columnInfoList.add(ColumnTypeOfRaw);
            _columnInfoList.add(ColumnTypeOfBfile);
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
        public static readonly String TABLE_DB_NAME = "VENDOR_CHECK";
        public static readonly String TABLE_PROPERTY_NAME = "VendorCheck";

        // -------------------------------------------------
        //                                    Column DB-Name
        //                                    --------------
        public static readonly String DB_NAME_VENDOR_CHECK_ID = "VENDOR_CHECK_ID";
        public static readonly String DB_NAME_DECIMAL_DIGIT = "DECIMAL_DIGIT";
        public static readonly String DB_NAME_INTEGER_NON_DIGIT = "INTEGER_NON_DIGIT";
        public static readonly String DB_NAME_LARGE_CHARACTER = "LARGE_CHARACTER";
        public static readonly String DB_NAME_TYPE_OF_CHAR = "TYPE_OF_CHAR";
        public static readonly String DB_NAME_TYPE_OF_NCHAR = "TYPE_OF_NCHAR";
        public static readonly String DB_NAME_TYPE_OF_VARCHAR2 = "TYPE_OF_VARCHAR2";
        public static readonly String DB_NAME_TYPE_OF_VARCHAR2_MAX = "TYPE_OF_VARCHAR2_MAX";
        public static readonly String DB_NAME_TYPE_OF_NVARCHAR2 = "TYPE_OF_NVARCHAR2";
        public static readonly String DB_NAME_TYPE_OF_CLOB = "TYPE_OF_CLOB";
        public static readonly String DB_NAME_TYPE_OF_NCLOB = "TYPE_OF_NCLOB";
        public static readonly String DB_NAME_TYPE_OF_DATE = "TYPE_OF_DATE";
        public static readonly String DB_NAME_TYPE_OF_TIMESTAMP = "TYPE_OF_TIMESTAMP";
        public static readonly String DB_NAME_TYPE_OF_BLOB = "TYPE_OF_BLOB";
        public static readonly String DB_NAME_TYPE_OF_RAW = "TYPE_OF_RAW";
        public static readonly String DB_NAME_TYPE_OF_BFILE = "TYPE_OF_BFILE";

        // -------------------------------------------------
        //                              Column Property-Name
        //                              --------------------
        public static readonly String PROPERTY_NAME_VENDOR_CHECK_ID = "VendorCheckId";
        public static readonly String PROPERTY_NAME_DECIMAL_DIGIT = "DecimalDigit";
        public static readonly String PROPERTY_NAME_INTEGER_NON_DIGIT = "IntegerNonDigit";
        public static readonly String PROPERTY_NAME_LARGE_CHARACTER = "LargeCharacter";
        public static readonly String PROPERTY_NAME_TYPE_OF_CHAR = "TypeOfChar";
        public static readonly String PROPERTY_NAME_TYPE_OF_NCHAR = "TypeOfNchar";
        public static readonly String PROPERTY_NAME_TYPE_OF_VARCHAR2 = "TypeOfVarchar2";
        public static readonly String PROPERTY_NAME_TYPE_OF_VARCHAR2_MAX = "TypeOfVarchar2Max";
        public static readonly String PROPERTY_NAME_TYPE_OF_NVARCHAR2 = "TypeOfNvarchar2";
        public static readonly String PROPERTY_NAME_TYPE_OF_CLOB = "TypeOfClob";
        public static readonly String PROPERTY_NAME_TYPE_OF_NCLOB = "TypeOfNclob";
        public static readonly String PROPERTY_NAME_TYPE_OF_DATE = "TypeOfDate";
        public static readonly String PROPERTY_NAME_TYPE_OF_TIMESTAMP = "TypeOfTimestamp";
        public static readonly String PROPERTY_NAME_TYPE_OF_BLOB = "TypeOfBlob";
        public static readonly String PROPERTY_NAME_TYPE_OF_RAW = "TypeOfRaw";
        public static readonly String PROPERTY_NAME_TYPE_OF_BFILE = "TypeOfBfile";

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
                map.put(DB_NAME_DECIMAL_DIGIT.ToLower(), PROPERTY_NAME_DECIMAL_DIGIT);
                map.put(DB_NAME_INTEGER_NON_DIGIT.ToLower(), PROPERTY_NAME_INTEGER_NON_DIGIT);
                map.put(DB_NAME_LARGE_CHARACTER.ToLower(), PROPERTY_NAME_LARGE_CHARACTER);
                map.put(DB_NAME_TYPE_OF_CHAR.ToLower(), PROPERTY_NAME_TYPE_OF_CHAR);
                map.put(DB_NAME_TYPE_OF_NCHAR.ToLower(), PROPERTY_NAME_TYPE_OF_NCHAR);
                map.put(DB_NAME_TYPE_OF_VARCHAR2.ToLower(), PROPERTY_NAME_TYPE_OF_VARCHAR2);
                map.put(DB_NAME_TYPE_OF_VARCHAR2_MAX.ToLower(), PROPERTY_NAME_TYPE_OF_VARCHAR2_MAX);
                map.put(DB_NAME_TYPE_OF_NVARCHAR2.ToLower(), PROPERTY_NAME_TYPE_OF_NVARCHAR2);
                map.put(DB_NAME_TYPE_OF_CLOB.ToLower(), PROPERTY_NAME_TYPE_OF_CLOB);
                map.put(DB_NAME_TYPE_OF_NCLOB.ToLower(), PROPERTY_NAME_TYPE_OF_NCLOB);
                map.put(DB_NAME_TYPE_OF_DATE.ToLower(), PROPERTY_NAME_TYPE_OF_DATE);
                map.put(DB_NAME_TYPE_OF_TIMESTAMP.ToLower(), PROPERTY_NAME_TYPE_OF_TIMESTAMP);
                map.put(DB_NAME_TYPE_OF_BLOB.ToLower(), PROPERTY_NAME_TYPE_OF_BLOB);
                map.put(DB_NAME_TYPE_OF_RAW.ToLower(), PROPERTY_NAME_TYPE_OF_RAW);
                map.put(DB_NAME_TYPE_OF_BFILE.ToLower(), PROPERTY_NAME_TYPE_OF_BFILE);
                _dbNamePropertyNameKeyToLowerMap = map;
            }

            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_PROPERTY_NAME.ToLower(), TABLE_DB_NAME);
                map.put(PROPERTY_NAME_VENDOR_CHECK_ID.ToLower(), DB_NAME_VENDOR_CHECK_ID);
                map.put(PROPERTY_NAME_DECIMAL_DIGIT.ToLower(), DB_NAME_DECIMAL_DIGIT);
                map.put(PROPERTY_NAME_INTEGER_NON_DIGIT.ToLower(), DB_NAME_INTEGER_NON_DIGIT);
                map.put(PROPERTY_NAME_LARGE_CHARACTER.ToLower(), DB_NAME_LARGE_CHARACTER);
                map.put(PROPERTY_NAME_TYPE_OF_CHAR.ToLower(), DB_NAME_TYPE_OF_CHAR);
                map.put(PROPERTY_NAME_TYPE_OF_NCHAR.ToLower(), DB_NAME_TYPE_OF_NCHAR);
                map.put(PROPERTY_NAME_TYPE_OF_VARCHAR2.ToLower(), DB_NAME_TYPE_OF_VARCHAR2);
                map.put(PROPERTY_NAME_TYPE_OF_VARCHAR2_MAX.ToLower(), DB_NAME_TYPE_OF_VARCHAR2_MAX);
                map.put(PROPERTY_NAME_TYPE_OF_NVARCHAR2.ToLower(), DB_NAME_TYPE_OF_NVARCHAR2);
                map.put(PROPERTY_NAME_TYPE_OF_CLOB.ToLower(), DB_NAME_TYPE_OF_CLOB);
                map.put(PROPERTY_NAME_TYPE_OF_NCLOB.ToLower(), DB_NAME_TYPE_OF_NCLOB);
                map.put(PROPERTY_NAME_TYPE_OF_DATE.ToLower(), DB_NAME_TYPE_OF_DATE);
                map.put(PROPERTY_NAME_TYPE_OF_TIMESTAMP.ToLower(), DB_NAME_TYPE_OF_TIMESTAMP);
                map.put(PROPERTY_NAME_TYPE_OF_BLOB.ToLower(), DB_NAME_TYPE_OF_BLOB);
                map.put(PROPERTY_NAME_TYPE_OF_RAW.ToLower(), DB_NAME_TYPE_OF_RAW);
                map.put(PROPERTY_NAME_TYPE_OF_BFILE.ToLower(), DB_NAME_TYPE_OF_BFILE);
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
            RegisterEntityPropertySetupper("DECIMAL_DIGIT", "DecimalDigit", new EntityPropertyDecimalDigitSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("INTEGER_NON_DIGIT", "IntegerNonDigit", new EntityPropertyIntegerNonDigitSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("LARGE_CHARACTER", "LargeCharacter", new EntityPropertyLargeCharacterSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("TYPE_OF_CHAR", "TypeOfChar", new EntityPropertyTypeOfCharSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("TYPE_OF_NCHAR", "TypeOfNchar", new EntityPropertyTypeOfNcharSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("TYPE_OF_VARCHAR2", "TypeOfVarchar2", new EntityPropertyTypeOfVarchar2Setupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("TYPE_OF_VARCHAR2_MAX", "TypeOfVarchar2Max", new EntityPropertyTypeOfVarchar2MaxSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("TYPE_OF_NVARCHAR2", "TypeOfNvarchar2", new EntityPropertyTypeOfNvarchar2Setupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("TYPE_OF_CLOB", "TypeOfClob", new EntityPropertyTypeOfClobSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("TYPE_OF_NCLOB", "TypeOfNclob", new EntityPropertyTypeOfNclobSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("TYPE_OF_DATE", "TypeOfDate", new EntityPropertyTypeOfDateSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("TYPE_OF_TIMESTAMP", "TypeOfTimestamp", new EntityPropertyTypeOfTimestampSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("TYPE_OF_BLOB", "TypeOfBlob", new EntityPropertyTypeOfBlobSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("TYPE_OF_RAW", "TypeOfRaw", new EntityPropertyTypeOfRawSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("TYPE_OF_BFILE", "TypeOfBfile", new EntityPropertyTypeOfBfileSetupper(), _entityPropertySetupperMap);
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
        public class EntityPropertyDecimalDigitSetupper : EntityPropertySetupper<VendorCheck> {
            public void Setup(VendorCheck entity, Object value) { entity.DecimalDigit = (value != null) ? (decimal?)value : null; }
        }
        public class EntityPropertyIntegerNonDigitSetupper : EntityPropertySetupper<VendorCheck> {
            public void Setup(VendorCheck entity, Object value) { entity.IntegerNonDigit = (value != null) ? (int?)value : null; }
        }
        public class EntityPropertyLargeCharacterSetupper : EntityPropertySetupper<VendorCheck> {
            public void Setup(VendorCheck entity, Object value) { entity.LargeCharacter = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyTypeOfCharSetupper : EntityPropertySetupper<VendorCheck> {
            public void Setup(VendorCheck entity, Object value) { entity.TypeOfChar = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyTypeOfNcharSetupper : EntityPropertySetupper<VendorCheck> {
            public void Setup(VendorCheck entity, Object value) { entity.TypeOfNchar = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyTypeOfVarchar2Setupper : EntityPropertySetupper<VendorCheck> {
            public void Setup(VendorCheck entity, Object value) { entity.TypeOfVarchar2 = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyTypeOfVarchar2MaxSetupper : EntityPropertySetupper<VendorCheck> {
            public void Setup(VendorCheck entity, Object value) { entity.TypeOfVarchar2Max = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyTypeOfNvarchar2Setupper : EntityPropertySetupper<VendorCheck> {
            public void Setup(VendorCheck entity, Object value) { entity.TypeOfNvarchar2 = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyTypeOfClobSetupper : EntityPropertySetupper<VendorCheck> {
            public void Setup(VendorCheck entity, Object value) { entity.TypeOfClob = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyTypeOfNclobSetupper : EntityPropertySetupper<VendorCheck> {
            public void Setup(VendorCheck entity, Object value) { entity.TypeOfNclob = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyTypeOfDateSetupper : EntityPropertySetupper<VendorCheck> {
            public void Setup(VendorCheck entity, Object value) { entity.TypeOfDate = (value != null) ? (DateTime?)value : null; }
        }
        public class EntityPropertyTypeOfTimestampSetupper : EntityPropertySetupper<VendorCheck> {
            public void Setup(VendorCheck entity, Object value) { entity.TypeOfTimestamp = (value != null) ? (DateTime?)value : null; }
        }
        public class EntityPropertyTypeOfBlobSetupper : EntityPropertySetupper<VendorCheck> {
            public void Setup(VendorCheck entity, Object value) { entity.TypeOfBlob = (value != null) ? (byte[])value : null; }
        }
        public class EntityPropertyTypeOfRawSetupper : EntityPropertySetupper<VendorCheck> {
            public void Setup(VendorCheck entity, Object value) { entity.TypeOfRaw = (value != null) ? (byte[])value : null; }
        }
        public class EntityPropertyTypeOfBfileSetupper : EntityPropertySetupper<VendorCheck> {
            public void Setup(VendorCheck entity, Object value) { entity.TypeOfBfile = (value != null) ? (String)value : null; }
        }
    }
}

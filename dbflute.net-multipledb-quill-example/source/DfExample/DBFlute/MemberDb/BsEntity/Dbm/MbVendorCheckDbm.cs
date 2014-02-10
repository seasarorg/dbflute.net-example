
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

    public class MbVendorCheckDbm : MbAbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(MbVendorCheck);

        private static readonly MbVendorCheckDbm _instance = new MbVendorCheckDbm();
        private MbVendorCheckDbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static MbVendorCheckDbm GetInstance() {
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
        protected MbColumnInfo _columnVendorCheckId;
        protected MbColumnInfo _columnDecimalDigit;
        protected MbColumnInfo _columnIntegerNonDigit;
        protected MbColumnInfo _columnTypeOfBoolean;
        protected MbColumnInfo _columnTypeOfText;

        public MbColumnInfo ColumnVendorCheckId { get { return _columnVendorCheckId; } }
        public MbColumnInfo ColumnDecimalDigit { get { return _columnDecimalDigit; } }
        public MbColumnInfo ColumnIntegerNonDigit { get { return _columnIntegerNonDigit; } }
        public MbColumnInfo ColumnTypeOfBoolean { get { return _columnTypeOfBoolean; } }
        public MbColumnInfo ColumnTypeOfText { get { return _columnTypeOfText; } }

        protected void InitializeColumnInfo() {
            _columnVendorCheckId = cci("VENDOR_CHECK_ID", "VENDOR_CHECK_ID", null, null, true, "VendorCheckId", typeof(long?), true, "DECIMAL", 16, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnDecimalDigit = cci("DECIMAL_DIGIT", "DECIMAL_DIGIT", null, null, true, "DecimalDigit", typeof(decimal?), false, "DECIMAL", 5, 3, false, OptimisticLockType.NONE, null, null, null);
            _columnIntegerNonDigit = cci("INTEGER_NON_DIGIT", "INTEGER_NON_DIGIT", null, null, true, "IntegerNonDigit", typeof(int?), false, "DECIMAL", 5, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnTypeOfBoolean = cci("TYPE_OF_BOOLEAN", "TYPE_OF_BOOLEAN", null, null, true, "TypeOfBoolean", typeof(bool?), false, "BIT", null, null, false, OptimisticLockType.NONE, null, null, null);
            _columnTypeOfText = cci("TYPE_OF_TEXT", "TYPE_OF_TEXT", null, null, false, "TypeOfText", typeof(String), false, "TEXT", 65535, 0, false, OptimisticLockType.NONE, null, null, null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<MbColumnInfo>();
            _columnInfoList.add(ColumnVendorCheckId);
            _columnInfoList.add(ColumnDecimalDigit);
            _columnInfoList.add(ColumnIntegerNonDigit);
            _columnInfoList.add(ColumnTypeOfBoolean);
            _columnInfoList.add(ColumnTypeOfText);
        }

        // ===============================================================================
        //                                                                     Unique Info
        //                                                                     ===========
        public override MbUniqueInfo PrimaryUniqueInfo { get {
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
        public static readonly String DB_NAME_DECIMAL_DIGIT = "DECIMAL_DIGIT";
        public static readonly String DB_NAME_INTEGER_NON_DIGIT = "INTEGER_NON_DIGIT";
        public static readonly String DB_NAME_TYPE_OF_BOOLEAN = "TYPE_OF_BOOLEAN";
        public static readonly String DB_NAME_TYPE_OF_TEXT = "TYPE_OF_TEXT";

        // -------------------------------------------------
        //                              Column Property-Name
        //                              --------------------
        public static readonly String PROPERTY_NAME_VENDOR_CHECK_ID = "VendorCheckId";
        public static readonly String PROPERTY_NAME_DECIMAL_DIGIT = "DecimalDigit";
        public static readonly String PROPERTY_NAME_INTEGER_NON_DIGIT = "IntegerNonDigit";
        public static readonly String PROPERTY_NAME_TYPE_OF_BOOLEAN = "TypeOfBoolean";
        public static readonly String PROPERTY_NAME_TYPE_OF_TEXT = "TypeOfText";

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

        static MbVendorCheckDbm() {
            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_DB_NAME.ToLower(), TABLE_PROPERTY_NAME);
                map.put(DB_NAME_VENDOR_CHECK_ID.ToLower(), PROPERTY_NAME_VENDOR_CHECK_ID);
                map.put(DB_NAME_DECIMAL_DIGIT.ToLower(), PROPERTY_NAME_DECIMAL_DIGIT);
                map.put(DB_NAME_INTEGER_NON_DIGIT.ToLower(), PROPERTY_NAME_INTEGER_NON_DIGIT);
                map.put(DB_NAME_TYPE_OF_BOOLEAN.ToLower(), PROPERTY_NAME_TYPE_OF_BOOLEAN);
                map.put(DB_NAME_TYPE_OF_TEXT.ToLower(), PROPERTY_NAME_TYPE_OF_TEXT);
                _dbNamePropertyNameKeyToLowerMap = map;
            }

            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_PROPERTY_NAME.ToLower(), TABLE_DB_NAME);
                map.put(PROPERTY_NAME_VENDOR_CHECK_ID.ToLower(), DB_NAME_VENDOR_CHECK_ID);
                map.put(PROPERTY_NAME_DECIMAL_DIGIT.ToLower(), DB_NAME_DECIMAL_DIGIT);
                map.put(PROPERTY_NAME_INTEGER_NON_DIGIT.ToLower(), DB_NAME_INTEGER_NON_DIGIT);
                map.put(PROPERTY_NAME_TYPE_OF_BOOLEAN.ToLower(), DB_NAME_TYPE_OF_BOOLEAN);
                map.put(PROPERTY_NAME_TYPE_OF_TEXT.ToLower(), DB_NAME_TYPE_OF_TEXT);
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
        public override String EntityTypeName { get { return "DfExample.DBFlute.MemberDb.ExEntity.MbVendorCheck"; } }
        public override String DaoTypeName { get { return "DfExample.DBFlute.MemberDb.ExDao.MbVendorCheckDao"; } }
        public override String ConditionBeanTypeName { get { return "DfExample.DBFlute.MemberDb.CBean.MbVendorCheckCB"; } }
        public override String BehaviorTypeName { get { return "DfExample.DBFlute.MemberDb.ExBhv.MbVendorCheckBhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override MbEntity NewEntity() { return NewMyEntity(); }
        public MbVendorCheck NewMyEntity() { return new MbVendorCheck(); }
        public override MbConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public MbVendorCheckCB NewMyConditionBean() { return new MbVendorCheckCB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<MbVendorCheck>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<MbVendorCheck>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("VENDOR_CHECK_ID", "VendorCheckId", new EntityPropertyVendorCheckIdSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("DECIMAL_DIGIT", "DecimalDigit", new EntityPropertyDecimalDigitSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("INTEGER_NON_DIGIT", "IntegerNonDigit", new EntityPropertyIntegerNonDigitSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("TYPE_OF_BOOLEAN", "TypeOfBoolean", new EntityPropertyTypeOfBooleanSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("TYPE_OF_TEXT", "TypeOfText", new EntityPropertyTypeOfTextSetupper(), _entityPropertySetupperMap);
        }

        public override bool HasEntityPropertySetupper(String propertyName) {
            return _entityPropertySetupperMap.containsKey(propertyName);
        }

        public override void SetupEntityProperty(String propertyName, Object entity, Object value) {
            EntityPropertySetupper<MbVendorCheck> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((MbVendorCheck)entity, value);
        }

        public class EntityPropertyVendorCheckIdSetupper : EntityPropertySetupper<MbVendorCheck> {
            public void Setup(MbVendorCheck entity, Object value) { entity.VendorCheckId = (value != null) ? (long?)value : null; }
        }
        public class EntityPropertyDecimalDigitSetupper : EntityPropertySetupper<MbVendorCheck> {
            public void Setup(MbVendorCheck entity, Object value) { entity.DecimalDigit = (value != null) ? (decimal?)value : null; }
        }
        public class EntityPropertyIntegerNonDigitSetupper : EntityPropertySetupper<MbVendorCheck> {
            public void Setup(MbVendorCheck entity, Object value) { entity.IntegerNonDigit = (value != null) ? (int?)value : null; }
        }
        public class EntityPropertyTypeOfBooleanSetupper : EntityPropertySetupper<MbVendorCheck> {
            public void Setup(MbVendorCheck entity, Object value) { entity.TypeOfBoolean = (value != null) ? (bool?)value : null; }
        }
        public class EntityPropertyTypeOfTextSetupper : EntityPropertySetupper<MbVendorCheck> {
            public void Setup(MbVendorCheck entity, Object value) { entity.TypeOfText = (value != null) ? (String)value : null; }
        }
    }
}

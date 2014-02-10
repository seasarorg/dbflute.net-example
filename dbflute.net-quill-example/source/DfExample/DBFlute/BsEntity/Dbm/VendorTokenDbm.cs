
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

    public class VendorTokenDbm : AbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(VendorToken);

        private static readonly VendorTokenDbm _instance = new VendorTokenDbm();
        private VendorTokenDbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static VendorTokenDbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "vendor_token"; } }
        public override String TablePropertyName { get { return "VendorToken"; } }
        public override String TableSqlName { get { return "vendor_token"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected ColumnInfo _columnVendorTokenId;
        protected ColumnInfo _columnTokenNumber;
        protected ColumnInfo _columnTokenName;

        public ColumnInfo ColumnVendorTokenId { get { return _columnVendorTokenId; } }
        public ColumnInfo ColumnTokenNumber { get { return _columnTokenNumber; } }
        public ColumnInfo ColumnTokenName { get { return _columnTokenName; } }

        protected void InitializeColumnInfo() {
            _columnVendorTokenId = cci("VENDOR_TOKEN_ID", "VENDOR_TOKEN_ID", null, null, true, "VendorTokenId", typeof(long?), true, "DECIMAL", 16, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnTokenNumber = cci("TOKEN_NUMBER", "TOKEN_NUMBER", null, null, false, "TokenNumber", typeof(int?), false, "INT", 10, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnTokenName = cci("TOKEN_NAME", "TOKEN_NAME", null, null, false, "TokenName", typeof(String), false, "VARCHAR", 200, 0, false, OptimisticLockType.NONE, null, null, null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<ColumnInfo>();
            _columnInfoList.add(ColumnVendorTokenId);
            _columnInfoList.add(ColumnTokenNumber);
            _columnInfoList.add(ColumnTokenName);
        }

        // ===============================================================================
        //                                                                     Unique Info
        //                                                                     ===========
        public override UniqueInfo PrimaryUniqueInfo { get {
            return cpui(ColumnVendorTokenId);
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
        public static readonly String TABLE_DB_NAME = "vendor_token";
        public static readonly String TABLE_PROPERTY_NAME = "VendorToken";

        // -------------------------------------------------
        //                                    Column DB-Name
        //                                    --------------
        public static readonly String DB_NAME_VENDOR_TOKEN_ID = "VENDOR_TOKEN_ID";
        public static readonly String DB_NAME_TOKEN_NUMBER = "TOKEN_NUMBER";
        public static readonly String DB_NAME_TOKEN_NAME = "TOKEN_NAME";

        // -------------------------------------------------
        //                              Column Property-Name
        //                              --------------------
        public static readonly String PROPERTY_NAME_VENDOR_TOKEN_ID = "VendorTokenId";
        public static readonly String PROPERTY_NAME_TOKEN_NUMBER = "TokenNumber";
        public static readonly String PROPERTY_NAME_TOKEN_NAME = "TokenName";

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

        static VendorTokenDbm() {
            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_DB_NAME.ToLower(), TABLE_PROPERTY_NAME);
                map.put(DB_NAME_VENDOR_TOKEN_ID.ToLower(), PROPERTY_NAME_VENDOR_TOKEN_ID);
                map.put(DB_NAME_TOKEN_NUMBER.ToLower(), PROPERTY_NAME_TOKEN_NUMBER);
                map.put(DB_NAME_TOKEN_NAME.ToLower(), PROPERTY_NAME_TOKEN_NAME);
                _dbNamePropertyNameKeyToLowerMap = map;
            }

            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_PROPERTY_NAME.ToLower(), TABLE_DB_NAME);
                map.put(PROPERTY_NAME_VENDOR_TOKEN_ID.ToLower(), DB_NAME_VENDOR_TOKEN_ID);
                map.put(PROPERTY_NAME_TOKEN_NUMBER.ToLower(), DB_NAME_TOKEN_NUMBER);
                map.put(PROPERTY_NAME_TOKEN_NAME.ToLower(), DB_NAME_TOKEN_NAME);
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
        public override String EntityTypeName { get { return "DfExample.DBFlute.ExEntity.VendorToken"; } }
        public override String DaoTypeName { get { return "DfExample.DBFlute.ExDao.VendorTokenDao"; } }
        public override String ConditionBeanTypeName { get { return "DfExample.DBFlute.CBean.VendorTokenCB"; } }
        public override String BehaviorTypeName { get { return "DfExample.DBFlute.ExBhv.VendorTokenBhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override Entity NewEntity() { return NewMyEntity(); }
        public VendorToken NewMyEntity() { return new VendorToken(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public VendorTokenCB NewMyConditionBean() { return new VendorTokenCB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<VendorToken>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<VendorToken>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("VENDOR_TOKEN_ID", "VendorTokenId", new EntityPropertyVendorTokenIdSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("TOKEN_NUMBER", "TokenNumber", new EntityPropertyTokenNumberSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("TOKEN_NAME", "TokenName", new EntityPropertyTokenNameSetupper(), _entityPropertySetupperMap);
        }

        public override bool HasEntityPropertySetupper(String propertyName) {
            return _entityPropertySetupperMap.containsKey(propertyName);
        }

        public override void SetupEntityProperty(String propertyName, Object entity, Object value) {
            EntityPropertySetupper<VendorToken> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((VendorToken)entity, value);
        }

        public class EntityPropertyVendorTokenIdSetupper : EntityPropertySetupper<VendorToken> {
            public void Setup(VendorToken entity, Object value) { entity.VendorTokenId = (value != null) ? (long?)value : null; }
        }
        public class EntityPropertyTokenNumberSetupper : EntityPropertySetupper<VendorToken> {
            public void Setup(VendorToken entity, Object value) { entity.TokenNumber = (value != null) ? (int?)value : null; }
        }
        public class EntityPropertyTokenNameSetupper : EntityPropertySetupper<VendorToken> {
            public void Setup(VendorToken entity, Object value) { entity.TokenName = (value != null) ? (String)value : null; }
        }
    }
}

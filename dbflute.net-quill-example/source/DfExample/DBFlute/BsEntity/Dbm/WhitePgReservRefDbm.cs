
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

    public class WhitePgReservRefDbm : AbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(WhitePgReservRef);

        private static readonly WhitePgReservRefDbm _instance = new WhitePgReservRefDbm();
        private WhitePgReservRefDbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static WhitePgReservRefDbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "white_pg_reserv_ref"; } }
        public override String TablePropertyName { get { return "WhitePgReservRef"; } }
        public override String TableSqlName { get { return "white_pg_reserv_ref"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected ColumnInfo _columnRefId;
        protected ColumnInfo _columnClassSynonym;

        public ColumnInfo ColumnRefId { get { return _columnRefId; } }
        public ColumnInfo ColumnClassSynonym { get { return _columnClassSynonym; } }

        protected void InitializeColumnInfo() {
            _columnRefId = cci("REF_ID", "REF_ID", null, null, true, "RefId", typeof(int?), true, "INT", 10, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnClassSynonym = cci("CLASS", "CLASS", "CLASS_SYNONYM", null, false, "ClassSynonym", typeof(int?), false, "INT", 10, 0, false, OptimisticLockType.NONE, "(using DBFlute synonym)", "whitePgReserv", null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<ColumnInfo>();
            _columnInfoList.add(ColumnRefId);
            _columnInfoList.add(ColumnClassSynonym);
        }

        // ===============================================================================
        //                                                                     Unique Info
        //                                                                     ===========
        public override UniqueInfo PrimaryUniqueInfo { get {
            return cpui(ColumnRefId);
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
        public ForeignInfo ForeignWhitePgReserv { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(ColumnClassSynonym, WhitePgReservDbm.GetInstance().ColumnClassSynonym);
            return cfi("WhitePgReserv", this, WhitePgReservDbm.GetInstance(), map, 0, false, false);
        }}


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
        public static readonly String TABLE_DB_NAME = "white_pg_reserv_ref";
        public static readonly String TABLE_PROPERTY_NAME = "WhitePgReservRef";

        // -------------------------------------------------
        //                                    Column DB-Name
        //                                    --------------
        public static readonly String DB_NAME_REF_ID = "REF_ID";
        public static readonly String DB_NAME_CLASS = "CLASS";

        // -------------------------------------------------
        //                              Column Property-Name
        //                              --------------------
        public static readonly String PROPERTY_NAME_REF_ID = "RefId";
        public static readonly String PROPERTY_NAME_CLASS = "ClassSynonym";

        // -------------------------------------------------
        //                                      Foreign Name
        //                                      ------------
        public static readonly String FOREIGN_PROPERTY_NAME_WhitePgReserv = "WhitePgReserv";
        // -------------------------------------------------
        //                                     Referrer Name
        //                                     -------------

        // -------------------------------------------------
        //                               DB-Property Mapping
        //                               -------------------
        protected static readonly Map<String, String> _dbNamePropertyNameKeyToLowerMap;
        protected static readonly Map<String, String> _propertyNameDbNameKeyToLowerMap;

        static WhitePgReservRefDbm() {
            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_DB_NAME.ToLower(), TABLE_PROPERTY_NAME);
                map.put(DB_NAME_REF_ID.ToLower(), PROPERTY_NAME_REF_ID);
                map.put(DB_NAME_CLASS.ToLower(), PROPERTY_NAME_CLASS);
                _dbNamePropertyNameKeyToLowerMap = map;
            }

            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_PROPERTY_NAME.ToLower(), TABLE_DB_NAME);
                map.put(PROPERTY_NAME_REF_ID.ToLower(), DB_NAME_REF_ID);
                map.put(PROPERTY_NAME_CLASS.ToLower(), DB_NAME_CLASS);
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
        public override String EntityTypeName { get { return "DfExample.DBFlute.ExEntity.WhitePgReservRef"; } }
        public override String DaoTypeName { get { return "DfExample.DBFlute.ExDao.WhitePgReservRefDao"; } }
        public override String ConditionBeanTypeName { get { return "DfExample.DBFlute.CBean.WhitePgReservRefCB"; } }
        public override String BehaviorTypeName { get { return "DfExample.DBFlute.ExBhv.WhitePgReservRefBhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override Entity NewEntity() { return NewMyEntity(); }
        public WhitePgReservRef NewMyEntity() { return new WhitePgReservRef(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public WhitePgReservRefCB NewMyConditionBean() { return new WhitePgReservRefCB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<WhitePgReservRef>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<WhitePgReservRef>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("REF_ID", "RefId", new EntityPropertyRefIdSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("CLASS", "ClassSynonym", new EntityPropertyClassSynonymSetupper(), _entityPropertySetupperMap);
        }

        public override bool HasEntityPropertySetupper(String propertyName) {
            return _entityPropertySetupperMap.containsKey(propertyName);
        }

        public override void SetupEntityProperty(String propertyName, Object entity, Object value) {
            EntityPropertySetupper<WhitePgReservRef> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((WhitePgReservRef)entity, value);
        }

        public class EntityPropertyRefIdSetupper : EntityPropertySetupper<WhitePgReservRef> {
            public void Setup(WhitePgReservRef entity, Object value) { entity.RefId = (value != null) ? (int?)value : null; }
        }
        public class EntityPropertyClassSynonymSetupper : EntityPropertySetupper<WhitePgReservRef> {
            public void Setup(WhitePgReservRef entity, Object value) { entity.ClassSynonym = (value != null) ? (int?)value : null; }
        }
    }
}

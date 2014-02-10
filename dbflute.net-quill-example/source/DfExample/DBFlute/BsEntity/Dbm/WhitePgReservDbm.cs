
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

    public class WhitePgReservDbm : AbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(WhitePgReserv);

        private static readonly WhitePgReservDbm _instance = new WhitePgReservDbm();
        private WhitePgReservDbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static WhitePgReservDbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "white_pg_reserv"; } }
        public override String TablePropertyName { get { return "WhitePgReserv"; } }
        public override String TableSqlName { get { return "white_pg_reserv"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected ColumnInfo _columnClassSynonym;
        protected ColumnInfo _columnCase;
        protected ColumnInfo _columnPackage;
        protected ColumnInfo _columnDefault;
        protected ColumnInfo _columnNew;
        protected ColumnInfo _columnNative;
        protected ColumnInfo _columnVoid;
        protected ColumnInfo _columnPublic;
        protected ColumnInfo _columnProtected;
        protected ColumnInfo _columnPrivate;
        protected ColumnInfo _columnInterface;
        protected ColumnInfo _columnAbstract;
        protected ColumnInfo _columnFinal;
        protected ColumnInfo _columnFinally;
        protected ColumnInfo _columnReturn;
        protected ColumnInfo _columnDouble;
        protected ColumnInfo _columnFloat;
        protected ColumnInfo _columnShort;
        protected ColumnInfo _columnType;
        protected ColumnInfo _columnReservName;

        public ColumnInfo ColumnClassSynonym { get { return _columnClassSynonym; } }
        public ColumnInfo ColumnCase { get { return _columnCase; } }
        public ColumnInfo ColumnPackage { get { return _columnPackage; } }
        public ColumnInfo ColumnDefault { get { return _columnDefault; } }
        public ColumnInfo ColumnNew { get { return _columnNew; } }
        public ColumnInfo ColumnNative { get { return _columnNative; } }
        public ColumnInfo ColumnVoid { get { return _columnVoid; } }
        public ColumnInfo ColumnPublic { get { return _columnPublic; } }
        public ColumnInfo ColumnProtected { get { return _columnProtected; } }
        public ColumnInfo ColumnPrivate { get { return _columnPrivate; } }
        public ColumnInfo ColumnInterface { get { return _columnInterface; } }
        public ColumnInfo ColumnAbstract { get { return _columnAbstract; } }
        public ColumnInfo ColumnFinal { get { return _columnFinal; } }
        public ColumnInfo ColumnFinally { get { return _columnFinally; } }
        public ColumnInfo ColumnReturn { get { return _columnReturn; } }
        public ColumnInfo ColumnDouble { get { return _columnDouble; } }
        public ColumnInfo ColumnFloat { get { return _columnFloat; } }
        public ColumnInfo ColumnShort { get { return _columnShort; } }
        public ColumnInfo ColumnType { get { return _columnType; } }
        public ColumnInfo ColumnReservName { get { return _columnReservName; } }

        protected void InitializeColumnInfo() {
            _columnClassSynonym = cci("CLASS", "CLASS", "CLASS_SYNONYM", null, true, "ClassSynonym", typeof(int?), true, "INT", 10, 0, false, OptimisticLockType.NONE, "(using DBFlute synonym)", null, "whitePgReservRefList");
            _columnCase = cci("CASE", "`CASE`", null, null, false, "Case", typeof(int?), false, "INT", 10, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnPackage = cci("PACKAGE", "PACKAGE", null, null, false, "Package", typeof(int?), false, "INT", 10, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnDefault = cci("DEFAULT", "`DEFAULT`", null, null, false, "Default", typeof(int?), false, "INT", 10, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnNew = cci("NEW", "NEW", null, null, false, "New", typeof(int?), false, "INT", 10, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnNative = cci("NATIVE", "NATIVE", null, null, false, "Native", typeof(int?), false, "INT", 10, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnVoid = cci("VOID", "VOID", null, null, false, "Void", typeof(int?), false, "INT", 10, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnPublic = cci("PUBLIC", "PUBLIC", null, null, false, "Public", typeof(int?), false, "INT", 10, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnProtected = cci("PROTECTED", "PROTECTED", null, null, false, "Protected", typeof(int?), false, "INT", 10, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnPrivate = cci("PRIVATE", "PRIVATE", null, null, false, "Private", typeof(int?), false, "INT", 10, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnInterface = cci("INTERFACE", "INTERFACE", null, null, false, "Interface", typeof(int?), false, "INT", 10, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnAbstract = cci("ABSTRACT", "ABSTRACT", null, null, false, "Abstract", typeof(int?), false, "INT", 10, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnFinal = cci("FINAL", "FINAL", null, null, false, "Final", typeof(int?), false, "INT", 10, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnFinally = cci("FINALLY", "FINALLY", null, null, false, "Finally", typeof(int?), false, "INT", 10, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnReturn = cci("RETURN", "`RETURN`", null, null, false, "Return", typeof(int?), false, "INT", 10, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnDouble = cci("DOUBLE", "`DOUBLE`", null, null, false, "Double", typeof(int?), false, "INT", 10, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnFloat = cci("FLOAT", "`FLOAT`", null, null, false, "Float", typeof(int?), false, "INT", 10, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnShort = cci("SHORT", "SHORT", null, null, false, "Short", typeof(int?), false, "INT", 10, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnType = cci("TYPE", "TYPE", null, null, false, "Type", typeof(String), false, "CHAR", 3, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnReservName = cci("RESERV_NAME", "RESERV_NAME", null, null, true, "ReservName", typeof(String), false, "VARCHAR", 32, 0, false, OptimisticLockType.NONE, null, null, null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<ColumnInfo>();
            _columnInfoList.add(ColumnClassSynonym);
            _columnInfoList.add(ColumnCase);
            _columnInfoList.add(ColumnPackage);
            _columnInfoList.add(ColumnDefault);
            _columnInfoList.add(ColumnNew);
            _columnInfoList.add(ColumnNative);
            _columnInfoList.add(ColumnVoid);
            _columnInfoList.add(ColumnPublic);
            _columnInfoList.add(ColumnProtected);
            _columnInfoList.add(ColumnPrivate);
            _columnInfoList.add(ColumnInterface);
            _columnInfoList.add(ColumnAbstract);
            _columnInfoList.add(ColumnFinal);
            _columnInfoList.add(ColumnFinally);
            _columnInfoList.add(ColumnReturn);
            _columnInfoList.add(ColumnDouble);
            _columnInfoList.add(ColumnFloat);
            _columnInfoList.add(ColumnShort);
            _columnInfoList.add(ColumnType);
            _columnInfoList.add(ColumnReservName);
        }

        // ===============================================================================
        //                                                                     Unique Info
        //                                                                     ===========
        public override UniqueInfo PrimaryUniqueInfo { get {
            return cpui(ColumnClassSynonym);
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
        public ReferrerInfo ReferrerWhitePgReservRefList { get {
            Map<ColumnInfo, ColumnInfo> map = new LinkedHashMap<ColumnInfo, ColumnInfo>();
            map.put(ColumnClassSynonym, WhitePgReservRefDbm.GetInstance().ColumnClassSynonym);
            return cri("WhitePgReservRefList", this, WhitePgReservRefDbm.GetInstance(), map, false);
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
        public static readonly String TABLE_DB_NAME = "white_pg_reserv";
        public static readonly String TABLE_PROPERTY_NAME = "WhitePgReserv";

        // -------------------------------------------------
        //                                    Column DB-Name
        //                                    --------------
        public static readonly String DB_NAME_CLASS = "CLASS";
        public static readonly String DB_NAME_CASE = "CASE";
        public static readonly String DB_NAME_PACKAGE = "PACKAGE";
        public static readonly String DB_NAME_DEFAULT = "DEFAULT";
        public static readonly String DB_NAME_NEW = "NEW";
        public static readonly String DB_NAME_NATIVE = "NATIVE";
        public static readonly String DB_NAME_VOID = "VOID";
        public static readonly String DB_NAME_PUBLIC = "PUBLIC";
        public static readonly String DB_NAME_PROTECTED = "PROTECTED";
        public static readonly String DB_NAME_PRIVATE = "PRIVATE";
        public static readonly String DB_NAME_INTERFACE = "INTERFACE";
        public static readonly String DB_NAME_ABSTRACT = "ABSTRACT";
        public static readonly String DB_NAME_FINAL = "FINAL";
        public static readonly String DB_NAME_FINALLY = "FINALLY";
        public static readonly String DB_NAME_RETURN = "RETURN";
        public static readonly String DB_NAME_DOUBLE = "DOUBLE";
        public static readonly String DB_NAME_FLOAT = "FLOAT";
        public static readonly String DB_NAME_SHORT = "SHORT";
        public static readonly String DB_NAME_TYPE = "TYPE";
        public static readonly String DB_NAME_RESERV_NAME = "RESERV_NAME";

        // -------------------------------------------------
        //                              Column Property-Name
        //                              --------------------
        public static readonly String PROPERTY_NAME_CLASS = "ClassSynonym";
        public static readonly String PROPERTY_NAME_CASE = "Case";
        public static readonly String PROPERTY_NAME_PACKAGE = "Package";
        public static readonly String PROPERTY_NAME_DEFAULT = "Default";
        public static readonly String PROPERTY_NAME_NEW = "New";
        public static readonly String PROPERTY_NAME_NATIVE = "Native";
        public static readonly String PROPERTY_NAME_VOID = "Void";
        public static readonly String PROPERTY_NAME_PUBLIC = "Public";
        public static readonly String PROPERTY_NAME_PROTECTED = "Protected";
        public static readonly String PROPERTY_NAME_PRIVATE = "Private";
        public static readonly String PROPERTY_NAME_INTERFACE = "Interface";
        public static readonly String PROPERTY_NAME_ABSTRACT = "Abstract";
        public static readonly String PROPERTY_NAME_FINAL = "Final";
        public static readonly String PROPERTY_NAME_FINALLY = "Finally";
        public static readonly String PROPERTY_NAME_RETURN = "Return";
        public static readonly String PROPERTY_NAME_DOUBLE = "Double";
        public static readonly String PROPERTY_NAME_FLOAT = "Float";
        public static readonly String PROPERTY_NAME_SHORT = "Short";
        public static readonly String PROPERTY_NAME_TYPE = "Type";
        public static readonly String PROPERTY_NAME_RESERV_NAME = "ReservName";

        // -------------------------------------------------
        //                                      Foreign Name
        //                                      ------------
        // -------------------------------------------------
        //                                     Referrer Name
        //                                     -------------
        public static readonly String REFERRER_PROPERTY_NAME_WhitePgReservRefList = "WhitePgReservRefList";

        // -------------------------------------------------
        //                               DB-Property Mapping
        //                               -------------------
        protected static readonly Map<String, String> _dbNamePropertyNameKeyToLowerMap;
        protected static readonly Map<String, String> _propertyNameDbNameKeyToLowerMap;

        static WhitePgReservDbm() {
            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_DB_NAME.ToLower(), TABLE_PROPERTY_NAME);
                map.put(DB_NAME_CLASS.ToLower(), PROPERTY_NAME_CLASS);
                map.put(DB_NAME_CASE.ToLower(), PROPERTY_NAME_CASE);
                map.put(DB_NAME_PACKAGE.ToLower(), PROPERTY_NAME_PACKAGE);
                map.put(DB_NAME_DEFAULT.ToLower(), PROPERTY_NAME_DEFAULT);
                map.put(DB_NAME_NEW.ToLower(), PROPERTY_NAME_NEW);
                map.put(DB_NAME_NATIVE.ToLower(), PROPERTY_NAME_NATIVE);
                map.put(DB_NAME_VOID.ToLower(), PROPERTY_NAME_VOID);
                map.put(DB_NAME_PUBLIC.ToLower(), PROPERTY_NAME_PUBLIC);
                map.put(DB_NAME_PROTECTED.ToLower(), PROPERTY_NAME_PROTECTED);
                map.put(DB_NAME_PRIVATE.ToLower(), PROPERTY_NAME_PRIVATE);
                map.put(DB_NAME_INTERFACE.ToLower(), PROPERTY_NAME_INTERFACE);
                map.put(DB_NAME_ABSTRACT.ToLower(), PROPERTY_NAME_ABSTRACT);
                map.put(DB_NAME_FINAL.ToLower(), PROPERTY_NAME_FINAL);
                map.put(DB_NAME_FINALLY.ToLower(), PROPERTY_NAME_FINALLY);
                map.put(DB_NAME_RETURN.ToLower(), PROPERTY_NAME_RETURN);
                map.put(DB_NAME_DOUBLE.ToLower(), PROPERTY_NAME_DOUBLE);
                map.put(DB_NAME_FLOAT.ToLower(), PROPERTY_NAME_FLOAT);
                map.put(DB_NAME_SHORT.ToLower(), PROPERTY_NAME_SHORT);
                map.put(DB_NAME_TYPE.ToLower(), PROPERTY_NAME_TYPE);
                map.put(DB_NAME_RESERV_NAME.ToLower(), PROPERTY_NAME_RESERV_NAME);
                _dbNamePropertyNameKeyToLowerMap = map;
            }

            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_PROPERTY_NAME.ToLower(), TABLE_DB_NAME);
                map.put(PROPERTY_NAME_CLASS.ToLower(), DB_NAME_CLASS);
                map.put(PROPERTY_NAME_CASE.ToLower(), DB_NAME_CASE);
                map.put(PROPERTY_NAME_PACKAGE.ToLower(), DB_NAME_PACKAGE);
                map.put(PROPERTY_NAME_DEFAULT.ToLower(), DB_NAME_DEFAULT);
                map.put(PROPERTY_NAME_NEW.ToLower(), DB_NAME_NEW);
                map.put(PROPERTY_NAME_NATIVE.ToLower(), DB_NAME_NATIVE);
                map.put(PROPERTY_NAME_VOID.ToLower(), DB_NAME_VOID);
                map.put(PROPERTY_NAME_PUBLIC.ToLower(), DB_NAME_PUBLIC);
                map.put(PROPERTY_NAME_PROTECTED.ToLower(), DB_NAME_PROTECTED);
                map.put(PROPERTY_NAME_PRIVATE.ToLower(), DB_NAME_PRIVATE);
                map.put(PROPERTY_NAME_INTERFACE.ToLower(), DB_NAME_INTERFACE);
                map.put(PROPERTY_NAME_ABSTRACT.ToLower(), DB_NAME_ABSTRACT);
                map.put(PROPERTY_NAME_FINAL.ToLower(), DB_NAME_FINAL);
                map.put(PROPERTY_NAME_FINALLY.ToLower(), DB_NAME_FINALLY);
                map.put(PROPERTY_NAME_RETURN.ToLower(), DB_NAME_RETURN);
                map.put(PROPERTY_NAME_DOUBLE.ToLower(), DB_NAME_DOUBLE);
                map.put(PROPERTY_NAME_FLOAT.ToLower(), DB_NAME_FLOAT);
                map.put(PROPERTY_NAME_SHORT.ToLower(), DB_NAME_SHORT);
                map.put(PROPERTY_NAME_TYPE.ToLower(), DB_NAME_TYPE);
                map.put(PROPERTY_NAME_RESERV_NAME.ToLower(), DB_NAME_RESERV_NAME);
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
        public override String EntityTypeName { get { return "DfExample.DBFlute.ExEntity.WhitePgReserv"; } }
        public override String DaoTypeName { get { return "DfExample.DBFlute.ExDao.WhitePgReservDao"; } }
        public override String ConditionBeanTypeName { get { return "DfExample.DBFlute.CBean.WhitePgReservCB"; } }
        public override String BehaviorTypeName { get { return "DfExample.DBFlute.ExBhv.WhitePgReservBhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override Entity NewEntity() { return NewMyEntity(); }
        public WhitePgReserv NewMyEntity() { return new WhitePgReserv(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public WhitePgReservCB NewMyConditionBean() { return new WhitePgReservCB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<WhitePgReserv>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<WhitePgReserv>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("CLASS", "ClassSynonym", new EntityPropertyClassSynonymSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("CASE", "Case", new EntityPropertyCaseSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("PACKAGE", "Package", new EntityPropertyPackageSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("DEFAULT", "Default", new EntityPropertyDefaultSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("NEW", "New", new EntityPropertyNewSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("NATIVE", "Native", new EntityPropertyNativeSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("VOID", "Void", new EntityPropertyVoidSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("PUBLIC", "Public", new EntityPropertyPublicSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("PROTECTED", "Protected", new EntityPropertyProtectedSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("PRIVATE", "Private", new EntityPropertyPrivateSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("INTERFACE", "Interface", new EntityPropertyInterfaceSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("ABSTRACT", "Abstract", new EntityPropertyAbstractSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("FINAL", "Final", new EntityPropertyFinalSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("FINALLY", "Finally", new EntityPropertyFinallySetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("RETURN", "Return", new EntityPropertyReturnSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("DOUBLE", "Double", new EntityPropertyDoubleSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("FLOAT", "Float", new EntityPropertyFloatSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("SHORT", "Short", new EntityPropertyShortSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("TYPE", "Type", new EntityPropertyTypeSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("RESERV_NAME", "ReservName", new EntityPropertyReservNameSetupper(), _entityPropertySetupperMap);
        }

        public override bool HasEntityPropertySetupper(String propertyName) {
            return _entityPropertySetupperMap.containsKey(propertyName);
        }

        public override void SetupEntityProperty(String propertyName, Object entity, Object value) {
            EntityPropertySetupper<WhitePgReserv> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((WhitePgReserv)entity, value);
        }

        public class EntityPropertyClassSynonymSetupper : EntityPropertySetupper<WhitePgReserv> {
            public void Setup(WhitePgReserv entity, Object value) { entity.ClassSynonym = (value != null) ? (int?)value : null; }
        }
        public class EntityPropertyCaseSetupper : EntityPropertySetupper<WhitePgReserv> {
            public void Setup(WhitePgReserv entity, Object value) { entity.Case = (value != null) ? (int?)value : null; }
        }
        public class EntityPropertyPackageSetupper : EntityPropertySetupper<WhitePgReserv> {
            public void Setup(WhitePgReserv entity, Object value) { entity.Package = (value != null) ? (int?)value : null; }
        }
        public class EntityPropertyDefaultSetupper : EntityPropertySetupper<WhitePgReserv> {
            public void Setup(WhitePgReserv entity, Object value) { entity.Default = (value != null) ? (int?)value : null; }
        }
        public class EntityPropertyNewSetupper : EntityPropertySetupper<WhitePgReserv> {
            public void Setup(WhitePgReserv entity, Object value) { entity.New = (value != null) ? (int?)value : null; }
        }
        public class EntityPropertyNativeSetupper : EntityPropertySetupper<WhitePgReserv> {
            public void Setup(WhitePgReserv entity, Object value) { entity.Native = (value != null) ? (int?)value : null; }
        }
        public class EntityPropertyVoidSetupper : EntityPropertySetupper<WhitePgReserv> {
            public void Setup(WhitePgReserv entity, Object value) { entity.Void = (value != null) ? (int?)value : null; }
        }
        public class EntityPropertyPublicSetupper : EntityPropertySetupper<WhitePgReserv> {
            public void Setup(WhitePgReserv entity, Object value) { entity.Public = (value != null) ? (int?)value : null; }
        }
        public class EntityPropertyProtectedSetupper : EntityPropertySetupper<WhitePgReserv> {
            public void Setup(WhitePgReserv entity, Object value) { entity.Protected = (value != null) ? (int?)value : null; }
        }
        public class EntityPropertyPrivateSetupper : EntityPropertySetupper<WhitePgReserv> {
            public void Setup(WhitePgReserv entity, Object value) { entity.Private = (value != null) ? (int?)value : null; }
        }
        public class EntityPropertyInterfaceSetupper : EntityPropertySetupper<WhitePgReserv> {
            public void Setup(WhitePgReserv entity, Object value) { entity.Interface = (value != null) ? (int?)value : null; }
        }
        public class EntityPropertyAbstractSetupper : EntityPropertySetupper<WhitePgReserv> {
            public void Setup(WhitePgReserv entity, Object value) { entity.Abstract = (value != null) ? (int?)value : null; }
        }
        public class EntityPropertyFinalSetupper : EntityPropertySetupper<WhitePgReserv> {
            public void Setup(WhitePgReserv entity, Object value) { entity.Final = (value != null) ? (int?)value : null; }
        }
        public class EntityPropertyFinallySetupper : EntityPropertySetupper<WhitePgReserv> {
            public void Setup(WhitePgReserv entity, Object value) { entity.Finally = (value != null) ? (int?)value : null; }
        }
        public class EntityPropertyReturnSetupper : EntityPropertySetupper<WhitePgReserv> {
            public void Setup(WhitePgReserv entity, Object value) { entity.Return = (value != null) ? (int?)value : null; }
        }
        public class EntityPropertyDoubleSetupper : EntityPropertySetupper<WhitePgReserv> {
            public void Setup(WhitePgReserv entity, Object value) { entity.Double = (value != null) ? (int?)value : null; }
        }
        public class EntityPropertyFloatSetupper : EntityPropertySetupper<WhitePgReserv> {
            public void Setup(WhitePgReserv entity, Object value) { entity.Float = (value != null) ? (int?)value : null; }
        }
        public class EntityPropertyShortSetupper : EntityPropertySetupper<WhitePgReserv> {
            public void Setup(WhitePgReserv entity, Object value) { entity.Short = (value != null) ? (int?)value : null; }
        }
        public class EntityPropertyTypeSetupper : EntityPropertySetupper<WhitePgReserv> {
            public void Setup(WhitePgReserv entity, Object value) { entity.Type = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyReservNameSetupper : EntityPropertySetupper<WhitePgReserv> {
            public void Setup(WhitePgReserv entity, Object value) { entity.ReservName = (value != null) ? (String)value : null; }
        }
    }
}

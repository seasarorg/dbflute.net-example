
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

    public class WhiteAllInOneClsDbm : AbstractDBMeta {

        public static readonly Type ENTITY_TYPE = typeof(WhiteAllInOneCls);

        private static readonly WhiteAllInOneClsDbm _instance = new WhiteAllInOneClsDbm();
        private WhiteAllInOneClsDbm() {
            InitializeColumnInfo();
            InitializeColumnInfoList();
            InitializeEntityPropertySetupper();
        }
        public static WhiteAllInOneClsDbm GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public override String TableDbName { get { return "white_all_in_one_cls"; } }
        public override String TablePropertyName { get { return "WhiteAllInOneCls"; } }
        public override String TableSqlName { get { return "white_all_in_one_cls"; } }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        protected ColumnInfo _columnClsCategoryCode;
        protected ColumnInfo _columnClsElementCode;
        protected ColumnInfo _columnAttributeExp;

        public ColumnInfo ColumnClsCategoryCode { get { return _columnClsCategoryCode; } }
        public ColumnInfo ColumnClsElementCode { get { return _columnClsElementCode; } }
        public ColumnInfo ColumnAttributeExp { get { return _columnAttributeExp; } }

        protected void InitializeColumnInfo() {
            _columnClsCategoryCode = cci("CLS_CATEGORY_CODE", "CLS_CATEGORY_CODE", null, null, true, "ClsCategoryCode", typeof(String), true, "CHAR", 3, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnClsElementCode = cci("CLS_ELEMENT_CODE", "CLS_ELEMENT_CODE", null, null, true, "ClsElementCode", typeof(String), true, "CHAR", 3, 0, false, OptimisticLockType.NONE, null, null, null);
            _columnAttributeExp = cci("ATTRIBUTE_EXP", "ATTRIBUTE_EXP", null, null, true, "AttributeExp", typeof(String), false, "TEXT", 65535, 0, false, OptimisticLockType.NONE, null, null, null);
        }

        protected void InitializeColumnInfoList() {
            _columnInfoList = new ArrayList<ColumnInfo>();
            _columnInfoList.add(ColumnClsCategoryCode);
            _columnInfoList.add(ColumnClsElementCode);
            _columnInfoList.add(ColumnAttributeExp);
        }

        // ===============================================================================
        //                                                                     Unique Info
        //                                                                     ===========
        public override UniqueInfo PrimaryUniqueInfo { get {
            List<ColumnInfo> ls = new ArrayList<ColumnInfo>();
            ls.add(ColumnClsCategoryCode);
            ls.add(ColumnClsElementCode);
            return cpui(ls);
        }}

        // -------------------------------------------------
        //                                   Primary Element
        //                                   ---------------
        public override bool HasPrimaryKey { get { return true; } }
        public override bool HasCompoundPrimaryKey { get { return true; } }

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
        public static readonly String TABLE_DB_NAME = "white_all_in_one_cls";
        public static readonly String TABLE_PROPERTY_NAME = "WhiteAllInOneCls";

        // -------------------------------------------------
        //                                    Column DB-Name
        //                                    --------------
        public static readonly String DB_NAME_CLS_CATEGORY_CODE = "CLS_CATEGORY_CODE";
        public static readonly String DB_NAME_CLS_ELEMENT_CODE = "CLS_ELEMENT_CODE";
        public static readonly String DB_NAME_ATTRIBUTE_EXP = "ATTRIBUTE_EXP";

        // -------------------------------------------------
        //                              Column Property-Name
        //                              --------------------
        public static readonly String PROPERTY_NAME_CLS_CATEGORY_CODE = "ClsCategoryCode";
        public static readonly String PROPERTY_NAME_CLS_ELEMENT_CODE = "ClsElementCode";
        public static readonly String PROPERTY_NAME_ATTRIBUTE_EXP = "AttributeExp";

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

        static WhiteAllInOneClsDbm() {
            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_DB_NAME.ToLower(), TABLE_PROPERTY_NAME);
                map.put(DB_NAME_CLS_CATEGORY_CODE.ToLower(), PROPERTY_NAME_CLS_CATEGORY_CODE);
                map.put(DB_NAME_CLS_ELEMENT_CODE.ToLower(), PROPERTY_NAME_CLS_ELEMENT_CODE);
                map.put(DB_NAME_ATTRIBUTE_EXP.ToLower(), PROPERTY_NAME_ATTRIBUTE_EXP);
                _dbNamePropertyNameKeyToLowerMap = map;
            }

            {
                Map<String, String> map = new LinkedHashMap<String, String>();
                map.put(TABLE_PROPERTY_NAME.ToLower(), TABLE_DB_NAME);
                map.put(PROPERTY_NAME_CLS_CATEGORY_CODE.ToLower(), DB_NAME_CLS_CATEGORY_CODE);
                map.put(PROPERTY_NAME_CLS_ELEMENT_CODE.ToLower(), DB_NAME_CLS_ELEMENT_CODE);
                map.put(PROPERTY_NAME_ATTRIBUTE_EXP.ToLower(), DB_NAME_ATTRIBUTE_EXP);
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
        public override String EntityTypeName { get { return "DfExample.DBFlute.ExEntity.WhiteAllInOneCls"; } }
        public override String DaoTypeName { get { return "DfExample.DBFlute.ExDao.WhiteAllInOneClsDao"; } }
        public override String ConditionBeanTypeName { get { return "DfExample.DBFlute.CBean.WhiteAllInOneClsCB"; } }
        public override String BehaviorTypeName { get { return "DfExample.DBFlute.ExBhv.WhiteAllInOneClsBhv"; } }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public override Type EntityType { get { return ENTITY_TYPE; } }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public override Entity NewEntity() { return NewMyEntity(); }
        public WhiteAllInOneCls NewMyEntity() { return new WhiteAllInOneCls(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public WhiteAllInOneClsCB NewMyConditionBean() { return new WhiteAllInOneClsCB(); }

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        protected Map<String, EntityPropertySetupper<WhiteAllInOneCls>> _entityPropertySetupperMap = new LinkedHashMap<String, EntityPropertySetupper<WhiteAllInOneCls>>();

        protected void InitializeEntityPropertySetupper() {
            RegisterEntityPropertySetupper("CLS_CATEGORY_CODE", "ClsCategoryCode", new EntityPropertyClsCategoryCodeSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("CLS_ELEMENT_CODE", "ClsElementCode", new EntityPropertyClsElementCodeSetupper(), _entityPropertySetupperMap);
            RegisterEntityPropertySetupper("ATTRIBUTE_EXP", "AttributeExp", new EntityPropertyAttributeExpSetupper(), _entityPropertySetupperMap);
        }

        public override bool HasEntityPropertySetupper(String propertyName) {
            return _entityPropertySetupperMap.containsKey(propertyName);
        }

        public override void SetupEntityProperty(String propertyName, Object entity, Object value) {
            EntityPropertySetupper<WhiteAllInOneCls> callback = _entityPropertySetupperMap.get(propertyName);
            callback.Setup((WhiteAllInOneCls)entity, value);
        }

        public class EntityPropertyClsCategoryCodeSetupper : EntityPropertySetupper<WhiteAllInOneCls> {
            public void Setup(WhiteAllInOneCls entity, Object value) { entity.ClsCategoryCode = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyClsElementCodeSetupper : EntityPropertySetupper<WhiteAllInOneCls> {
            public void Setup(WhiteAllInOneCls entity, Object value) { entity.ClsElementCode = (value != null) ? (String)value : null; }
        }
        public class EntityPropertyAttributeExpSetupper : EntityPropertySetupper<WhiteAllInOneCls> {
            public void Setup(WhiteAllInOneCls entity, Object value) { entity.AttributeExp = (value != null) ? (String)value : null; }
        }
    }
}

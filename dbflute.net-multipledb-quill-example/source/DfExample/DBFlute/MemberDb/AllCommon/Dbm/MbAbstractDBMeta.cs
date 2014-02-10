

using System;
using System.Reflection;

using DfExample.DBFlute.MemberDb.AllCommon;
using DfExample.DBFlute.MemberDb.AllCommon.CBean;
using DfExample.DBFlute.MemberDb.AllCommon.Dbm.Info;
using DfExample.DBFlute.MemberDb.AllCommon.JavaLike;
using DfExample.DBFlute.MemberDb.AllCommon.Util;

namespace DfExample.DBFlute.MemberDb.AllCommon.Dbm {

    public abstract class MbAbstractDBMeta : MbDBMeta {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected List<MbColumnInfo> _columnInfoList;

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        public abstract String TableDbName { get; }
        public abstract String TablePropertyName { get; }
        public abstract String TableSqlName { get; }
        public virtual String TableAlias { get { return null; } } // as default
        public virtual String TableComment { get { return null; } } // as default

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        public bool HasColumn(String columnFlexibleName) {
            if (!HasFlexibleName(columnFlexibleName)) {
                return false;
            }
            String propertyName = FindPropertyName(columnFlexibleName);
            return HasProperty("Column" + InitCap(propertyName));
        }

        public MbColumnInfo FindColumnInfo(String columnFlexibleName) {
            AssertStringNotNullAndNotTrimmedEmpty("columnFlexibleName", columnFlexibleName);
            if (!HasColumn(columnFlexibleName)) {
                String msg = "Not found column by columnFlexibleName: " + columnFlexibleName;
                msg = msg + " tableName=" + TableDbName;
                throw new SystemException(msg);
            }
            String propertyName = "Column" + InitCap(FindPropertyName(columnFlexibleName));
            PropertyInfo propertyInfo = GetType().GetProperty(propertyName);
            return (MbColumnInfo)propertyInfo.GetValue(this, null);
        }

        // createColumnInfo()
        protected MbColumnInfo cci(String columnDbName, String columnSqlName
                , String columnSynonym, String columnAlias, bool notNull
                , String propertyName, Type propertyType, bool primary, String columnDbType
                , int? columnSize, int? columnDecimalDigits, bool commonColumn
                , OptimisticLockType optimisticLockType, String columnComment
                , String foreignListExp, String referrerListExp) {
            char delimiter = ',';
            List<String> foreignPropList = null;
            if (foreignListExp != null && foreignListExp.Trim().Length > 0) {
                foreignPropList = new ArrayList<String>();
                String[] foreignPropArray = foreignListExp.Split(delimiter);
                foreach (String foreignProp in foreignPropArray) {
                    foreignPropList.add(foreignProp.Trim());
                }
            }
            List<String> referrerPropList = null;
            if (referrerListExp != null && referrerListExp.Trim().Length > 0) {
                referrerPropList = new ArrayList<String>();
                String[] referrerPropArray = referrerListExp.Split(delimiter);
                foreach (String referrerProp in referrerPropArray) {
                    referrerPropList.add(referrerProp.Trim());
                }
            }
            return new MbColumnInfo(this, columnDbName, columnSqlName
                    , columnSynonym, columnAlias, notNull, propertyName
                    , propertyType, primary, columnDbType, columnSize, columnDecimalDigits, commonColumn
                    , optimisticLockType, columnComment, foreignPropList, referrerPropList);
        }

        public List<MbColumnInfo> ColumnInfoList { get { return _columnInfoList; } }

        // ===============================================================================
        //                                                                     Unique Info
        //                                                                     ===========
        public abstract MbUniqueInfo PrimaryUniqueInfo { get; }
        public abstract bool HasPrimaryKey { get; }
        public abstract bool HasCompoundPrimaryKey { get; }

        protected MbUniqueInfo cpui(MbColumnInfo uniqueColumnInfo) { // createPrimaryUniqueInfo()
            List<MbColumnInfo> uniqueColumnInfoList = new ArrayList<MbColumnInfo>();
            uniqueColumnInfoList.add(uniqueColumnInfo);
            return cpui(uniqueColumnInfoList);
        }
    
        protected MbUniqueInfo cpui(List<MbColumnInfo> uniqueColumnInfoList) { // createPrimaryUniqueInfo()
            MbUniqueInfo uniqueInfo = new MbUniqueInfo(this, uniqueColumnInfoList, true);
            return uniqueInfo;
        }
    
        // ===============================================================================
        //                                                                   Relation Info
        //                                                                   =============
        public MbRelationInfo FindRelationInfo(String relationPropertyName) {
            AssertStringNotNullAndNotTrimmedEmpty("relationPropertyName", relationPropertyName);
            return HasForeign(relationPropertyName) ? (MbRelationInfo)FindForeignInfo(relationPropertyName) : (MbRelationInfo)FindReferrerInfo(relationPropertyName);
        }

        // -------------------------------------------------
        //                                   Foreign Element
        //                                   ---------------
        public bool HasForeign(String foreignPropertyName) {
            AssertStringNotNullAndNotTrimmedEmpty("foreignPropertyName", foreignPropertyName);
            String propertyName = BuildRelationInfoGetterMethodNameInitCap("Foreign", foreignPropertyName);
            return HasProperty(propertyName);
        }

        public MbDBMeta FindForeignDBMeta(String foreignPropertyName) {
            return FindForeignInfo(foreignPropertyName).ForeignDBMeta;
        }

        public DfExample.DBFlute.MemberDb.AllCommon.Dbm.Info.MbForeignInfo FindForeignInfo(String foreignPropertyName) {
            AssertStringNotNullAndNotTrimmedEmpty("foreignPropertyName", foreignPropertyName);
            String propertyName = BuildRelationInfoGetterMethodNameInitCap("Foreign", foreignPropertyName);
            PropertyInfo propertyInfo = GetType().GetProperty(propertyName);
            if (propertyInfo == null) {
                String msg = "The property '" + propertyName + "' was Not Found on " + GetType().Name;
                throw new SystemException(msg);
            }
            return (MbForeignInfo)propertyInfo.GetValue(this, null);
        }

        protected MbForeignInfo cfi(String propName
                                , MbDBMeta localDbm, MbDBMeta foreignDbm
                                , Map<MbColumnInfo, MbColumnInfo> localForeignColumnInfoMap
                                , int relNo, bool oneToOne, bool bizOneToOne) { // createForeignInfo()
            return new MbForeignInfo(propName, localDbm, foreignDbm, localForeignColumnInfoMap, relNo, oneToOne, bizOneToOne);
        }

        public List<MbForeignInfo> ForeignInfoList { get {
            PropertyInfo[] props = GetType().GetProperties();
            List<MbForeignInfo> foreignInfoList = new ArrayList<MbForeignInfo>();
            String prefix = "Foreign";
            foreach (PropertyInfo prop in props) {
                if (prop.Name.StartsWith(prefix) && prop.PropertyType.Equals(typeof(MbForeignInfo))) {
                    foreignInfoList.add((MbForeignInfo)prop.GetValue(this, null));
                }
            }
            return foreignInfoList;
        }}

        // -------------------------------------------------
        //                                  Referrer Element
        //                                  ----------------
        public bool HasReferrer(String referrerPropertyName) {
            AssertStringNotNullAndNotTrimmedEmpty("referrerPropertyName", referrerPropertyName);
            String propertyName = BuildRelationInfoGetterMethodNameInitCap("Referrer", referrerPropertyName);
            return HasProperty(propertyName);
        }

        public MbDBMeta FindReferrerDBMeta(String referrerPropertyName) {
            AssertStringNotNullAndNotTrimmedEmpty("referrerPropertyName", referrerPropertyName);
            return FindReferrerInfo(referrerPropertyName).ReferrerDBMeta;
        }

        public MbReferrerInfo FindReferrerInfo(String referrerPropertyName) {
            AssertStringNotNullAndNotTrimmedEmpty("referrerPropertyName", referrerPropertyName);
            String propertyName = BuildRelationInfoGetterMethodNameInitCap("Referrer", referrerPropertyName);
            PropertyInfo propertyInfo = GetType().GetProperty(propertyName);
            if (propertyInfo == null) {
                String msg = "The property '" + propertyName + "' was Not Found on " + GetType().Name;
                throw new SystemException(msg);
            }
            return (MbReferrerInfo)propertyInfo.GetValue(this, null);
        }

        protected MbReferrerInfo cri(String propName
                                 , MbDBMeta localDbm, MbDBMeta referrerDbm
                                 , Map<MbColumnInfo, MbColumnInfo> localReferrerColumnInfoMap
                                 , bool oneToOne) { // createReferrerInfo()
            return new MbReferrerInfo(propName, localDbm, referrerDbm, localReferrerColumnInfoMap, oneToOne);
        }

        public List<MbReferrerInfo> ReferrerInfoList { get {
            PropertyInfo[] props = GetType().GetProperties();
            List<MbReferrerInfo> foreignInfoList = new ArrayList<MbReferrerInfo>();
            String prefix = "Referrer";
            foreach (PropertyInfo prop in props) {
                if (prop.Name.StartsWith(prefix) && prop.PropertyType.Equals(typeof(MbReferrerInfo))) {
                    foreignInfoList.add((MbReferrerInfo)prop.GetValue(this, null));
                }
            }
            return foreignInfoList;
        }}

        // -------------------------------------------------
        //                                      Common Logic
        //                                      ------------
        protected static String BuildRelationInfoGetterMethodNameInitCap(String targetName, String relationPropertyName) {
            return targetName + relationPropertyName.Substring(0, 1).ToUpper() + relationPropertyName.Substring(1);
        }

        // ===============================================================================
        //                                                                    Various Info
        //                                                                    ============
        public virtual bool HasIdentity { get { return false; } }
        public virtual bool HasSequence { get { return false; } }
        public virtual String SequenceName { get { return null; } }
        public virtual String SequenceNextValSql { get { return null; } }
        public virtual int? SequenceIncrementSize { get { return null; } }
        public virtual int? SequenceCacheSize { get { return null; } }
        public virtual bool HasVersionNo { get { return false; } }
        public virtual MbColumnInfo VersionNoColumnInfo { get { return null; } }
        public virtual bool HasUpdateDate { get { return false; } }
        public virtual MbColumnInfo UpdateDateColumnInfo { get { return null; } }
        public abstract bool HasCommonColumn { get; }

        // ===============================================================================
        //                                                                   Name Handling
        //                                                                   =============
        public bool HasFlexibleName(String flexibleName) {
            String key = RemoveQuoteIfExists(flexibleName.ToLower());
            if (DbNamePropertyNameKeyToLowerMap.containsKey(key)) {
                return true;
            }
            if (PropertyNameDbNameKeyToLowerMap.containsKey(key)) {
                return true;
            }
            return false;
        }

        public String FindDbName(String flexibleName) {
            String key = RemoveQuoteIfExists(flexibleName.ToLower());
            if (PropertyNameDbNameKeyToLowerMap.containsKey(key)) {
                return PropertyNameDbNameKeyToLowerMap.get(key);
            }
            if (DbNamePropertyNameKeyToLowerMap.containsKey(key)) {
                String dbNameKeyToLower = DbNamePropertyNameKeyToLowerMap.get(key).ToLower();
                if (PropertyNameDbNameKeyToLowerMap.containsKey(dbNameKeyToLower)) {
                    return PropertyNameDbNameKeyToLowerMap.get(dbNameKeyToLower);
                }
            }
            String msg = "Not found object by the flexible name: flexibleName=" + flexibleName;
            throw new SystemException(msg);
        }

        public String FindPropertyName(String flexibleName) {
            String key = RemoveQuoteIfExists(flexibleName.ToLower());
            if (DbNamePropertyNameKeyToLowerMap.containsKey(key)) {
                return DbNamePropertyNameKeyToLowerMap.get(key);
            }
            if (PropertyNameDbNameKeyToLowerMap.containsKey(key)) {
                String dbNameToLower = PropertyNameDbNameKeyToLowerMap.get(key).ToLower();
                if (DbNamePropertyNameKeyToLowerMap.containsKey(dbNameToLower)) {
                    return DbNamePropertyNameKeyToLowerMap.get(dbNameToLower);
                }
            }
            String msg = "Not found object by the flexible name: flexibleName=" + flexibleName;
            throw new SystemException(msg);
        }

        protected static String RemoveQuoteIfExists(String name) {
            if (name.StartsWith("\"") && name.EndsWith("\"")) {
                name = name.Substring(1);
                name = name.Substring(0, name.Length - 1);
            } else if (name.StartsWith("[") && name.EndsWith("]")) {
                name = name.Substring(1);
                name = name.Substring(0, name.Length - 1);
            }
            return name;
        }

        // ===============================================================================
        //                                                                        Name Map
        //                                                                        ========
        public abstract Map<String, String> DbNamePropertyNameKeyToLowerMap { get; }
        public abstract Map<String, String> PropertyNameDbNameKeyToLowerMap { get; }

        // ===============================================================================
        //                                                                       Type Name
        //                                                                       =========
        public abstract String EntityTypeName { get; }
        public abstract String DaoTypeName { get; }
        public abstract String ConditionBeanTypeName { get; }
        public abstract String BehaviorTypeName { get; }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        public abstract Type EntityType { get; }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        public abstract MbEntity NewEntity();
        public abstract MbConditionBean NewConditionBean();

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
        public abstract bool HasEntityPropertySetupper(String propertyName);
        public abstract void SetupEntityProperty(String propertyName, Object entity, Object value);

        protected void RegisterEntityPropertySetupper<ENTITY>(
                                                      String columnName
                                                    , String propertyName
                                                    , EntityPropertySetupper<ENTITY> setupper
                                                    , Map<String, EntityPropertySetupper<ENTITY>> _entityPropertySetupperMap
                                                    ) where ENTITY : MbEntity {
            _entityPropertySetupperMap.put(columnName, setupper);
            _entityPropertySetupperMap.put(propertyName, setupper);
            _entityPropertySetupperMap.put(columnName.ToLower(), setupper);
            _entityPropertySetupperMap.put(propertyName.ToLower(), setupper);
        }
        
        // ===============================================================================
        //                                                                   Assist Helper
        //                                                                   =============
//        protected abstract void checkDowncast(MbEntity entity);
// 
//        protected String helpGettingColumnStringValue(Object value) {
//            if (value instanceof java.sql.Timestamp) {
//                return (value != null ? helpFormatingTimestamp((java.sql.Timestamp)value) : "");
//            } else if (value instanceof java.util.Date) {
//                return (value != null ? helpFormatingDate((java.util.Date)value) : "");
//            } else {
//                return (value != null ? value.toString() : "");
//            }
//        }

//        protected String helpFormatingDate(java.util.Date date) {
//            return MapStringUtil.formatDate(date);
//        }

//        protected String helpFormatingTimestamp(java.sql.Timestamp timestamp) {
//            return MapStringUtil.formatTimestamp(timestamp);
//        }

        // ===============================================================================
        //                                                                  General Helper
        //                                                                  ==============
        // -------------------------------------------------
        //                               Reflection Handling
        //                               -------------------
        protected bool HasProperty(String propertyName) {
            AssertStringNotNullAndNotTrimmedEmpty("propertyName", propertyName);
            PropertyInfo propertyInfo = this.GetType().GetProperty(propertyName);
            return propertyInfo != null;
        }

        // -------------------------------------------------
        //                                   String Handling
        //                                   ---------------
        protected static String InitCap(String str) {
            return MbSimpleStringUtil.InitCap(str);
        }

        // -------------------------------------------------
        //                                     Assert Object
        //                                     -------------
        protected static void AssertObjectNotNull(String variableName, Object value) {
            MbSimpleAssertUtil.AssertObjectNotNull(variableName, value);
        }

        // -------------------------------------------------
        //                                     Assert String
        //                                     -------------
        protected static void AssertStringNotNullAndNotTrimmedEmpty(String variableName, String value) {
            MbSimpleAssertUtil.AssertStringNotNullAndNotTrimmedEmpty(variableName, value);
        }
    }
}

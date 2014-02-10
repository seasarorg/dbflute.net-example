
using System;
using System.Reflection;

using DfExample.DBFlute.LibraryDb.AllCommon.Dbm;
using DfExample.DBFlute.LibraryDb.AllCommon.JavaLike;
using DfExample.DBFlute.LibraryDb.AllCommon.Util;

namespace DfExample.DBFlute.LibraryDb.AllCommon.Dbm.Info {

    public class LdReferrerInfo : LdRelationInfo {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected String referrerPropertyName;
        protected LdDBMeta localDBMeta;
        protected LdDBMeta referrerDBMeta;
        protected Map<LdColumnInfo, LdColumnInfo> localReferrerColumnInfoMap;
        protected Map<LdColumnInfo, LdColumnInfo> referrerLocalColumnInfoMap;
        protected bool oneToOne;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public LdReferrerInfo(String referrerPropertyName, LdDBMeta localDBMeta, LdDBMeta referrerDBMeta
                          , Map<LdColumnInfo, LdColumnInfo> localReferrerColumnInfoMap
                          , bool oneToOne) {
            AssertObjectNotNull("referrerPropertyName", referrerPropertyName);
            AssertObjectNotNull("localDBMeta", localDBMeta);
            AssertObjectNotNull("referrerDBMeta", referrerDBMeta);
            AssertObjectNotNull("localReferrerColumnInfoMap", localReferrerColumnInfoMap);
            this.referrerPropertyName = referrerPropertyName;
            this.localDBMeta = localDBMeta;
            this.referrerDBMeta = referrerDBMeta;
            this.localReferrerColumnInfoMap = localReferrerColumnInfoMap;
            Set<LdColumnInfo> keySet = localReferrerColumnInfoMap.keySet();
            referrerLocalColumnInfoMap = new LinkedHashMap<LdColumnInfo, LdColumnInfo>();
            foreach (LdColumnInfo key in localReferrerColumnInfoMap.keySet()) {
                LdColumnInfo value = localReferrerColumnInfoMap.get(key);
                referrerLocalColumnInfoMap.put(value, key);
            }
            this.oneToOne = oneToOne;
        }

        // ===============================================================================
        //                                                                          Finder
        //                                                                          ======
        public LdColumnInfo FindLocalByReferrer(String referrerColumnDbName) {
            LdColumnInfo keyColumnInfo = referrerDBMeta.FindColumnInfo(referrerColumnDbName);
            LdColumnInfo resultColumnInfo = (LdColumnInfo)referrerLocalColumnInfoMap.get(keyColumnInfo);
            if (resultColumnInfo == null) {
                String msg = "Not found by referrerColumnDbName in referrerLocalColumnInfoMap:";
                msg = msg + " referrerColumnDbName=" + referrerColumnDbName + " referrerLocalColumnInfoMap=" + referrerLocalColumnInfoMap;
                throw new ArgumentException(msg);
            }
            return resultColumnInfo;
        }

        public LdColumnInfo FindReferrerByLocal(String localColumnDbName) {
            LdColumnInfo keyColumnInfo = localDBMeta.FindColumnInfo(localColumnDbName);
            LdColumnInfo resultColumnInfo = (LdColumnInfo)localReferrerColumnInfoMap.get(keyColumnInfo);
            if (resultColumnInfo == null) {
                String msg = "Not found by localColumnDbName in localReferrerColumnInfoMap:";
                msg = msg + " localColumnDbName=" + localColumnDbName + " localReferrerColumnInfoMap=" + localReferrerColumnInfoMap;
                throw new ArgumentException(msg);
            }
            return resultColumnInfo;
        }

        public PropertyInfo FindAccessor() {
            return FindProperty(localDBMeta.EntityType, BuildInitCapPropertyName(), new Type[] { typeof(System.Collections.Generic.IList<>) });
        }

        // ===============================================================================
        //                                                                         Builder
        //                                                                         =======
        public String BuildInitCapPropertyName() {
            return InitCap(this.referrerPropertyName);
        }
        
        // ===============================================================================
        //                                                                  General Helper
        //                                                                  ==============
        protected static String InitCap(String str) {
            return LdSimpleStringUtil.InitCap(str);
        }

        protected static PropertyInfo FindProperty(Type clazz, String propertyName, Type[] argTypes) {
            return clazz.GetProperty(propertyName, argTypes);
        }
        
        protected void AssertObjectNotNull(String variableName, Object value) {
            if (variableName == null) {
                String msg = "The value should not be null: variableName=" + variableName + " value=" + value;
                throw new ArgumentException(msg);
            }
            if (value == null) {
                String msg = "The value should not be null: variableName=" + variableName;
                throw new ArgumentException(msg);
            }
        }

        // ===============================================================================
        //                                                                       Implement
        //                                                                       =========
        public String RelationPropertyName {
            get { return ReferrerPropertyName; }
        }

        public LdDBMeta TargetDBMeta {
            get { return ReferrerDBMeta; }
        }

        public Map<LdColumnInfo, LdColumnInfo> LocalTargetColumnInfoMap {
            get { return LocalReferrerColumnInfoMap; }
        }

        public bool IsReferrer {
            get { return true; }
        }

        // ===============================================================================
        //                                                                  Basic Override
        //                                                                  ==============
        public override String ToString() {
            return localDBMeta.TableDbName + "." + referrerPropertyName + "->" + referrerDBMeta.TableDbName;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public String ReferrerPropertyName {
            get { return referrerPropertyName; }
        }

        public LdDBMeta LocalDBMeta {
            get { return localDBMeta; }
        }

        public LdDBMeta ReferrerDBMeta {
            get { return referrerDBMeta; }
        }

        public Map<LdColumnInfo, LdColumnInfo> LocalReferrerColumnInfoMap {
            get { return localReferrerColumnInfoMap; }
        }

        public Map<LdColumnInfo, LdColumnInfo> ReferrerLocalColumnInfoMap {
            get { return referrerLocalColumnInfoMap; }
        }

        public bool IsOneToOne {
            get { return oneToOne; }
        }
    }
}

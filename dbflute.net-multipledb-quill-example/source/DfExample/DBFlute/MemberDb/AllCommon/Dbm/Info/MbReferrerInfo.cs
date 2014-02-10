
using System;
using System.Reflection;

using DfExample.DBFlute.MemberDb.AllCommon.Dbm;
using DfExample.DBFlute.MemberDb.AllCommon.JavaLike;
using DfExample.DBFlute.MemberDb.AllCommon.Util;

namespace DfExample.DBFlute.MemberDb.AllCommon.Dbm.Info {

    public class MbReferrerInfo : MbRelationInfo {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected String referrerPropertyName;
        protected MbDBMeta localDBMeta;
        protected MbDBMeta referrerDBMeta;
        protected Map<MbColumnInfo, MbColumnInfo> localReferrerColumnInfoMap;
        protected Map<MbColumnInfo, MbColumnInfo> referrerLocalColumnInfoMap;
        protected bool oneToOne;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public MbReferrerInfo(String referrerPropertyName, MbDBMeta localDBMeta, MbDBMeta referrerDBMeta
                          , Map<MbColumnInfo, MbColumnInfo> localReferrerColumnInfoMap
                          , bool oneToOne) {
            AssertObjectNotNull("referrerPropertyName", referrerPropertyName);
            AssertObjectNotNull("localDBMeta", localDBMeta);
            AssertObjectNotNull("referrerDBMeta", referrerDBMeta);
            AssertObjectNotNull("localReferrerColumnInfoMap", localReferrerColumnInfoMap);
            this.referrerPropertyName = referrerPropertyName;
            this.localDBMeta = localDBMeta;
            this.referrerDBMeta = referrerDBMeta;
            this.localReferrerColumnInfoMap = localReferrerColumnInfoMap;
            Set<MbColumnInfo> keySet = localReferrerColumnInfoMap.keySet();
            referrerLocalColumnInfoMap = new LinkedHashMap<MbColumnInfo, MbColumnInfo>();
            foreach (MbColumnInfo key in localReferrerColumnInfoMap.keySet()) {
                MbColumnInfo value = localReferrerColumnInfoMap.get(key);
                referrerLocalColumnInfoMap.put(value, key);
            }
            this.oneToOne = oneToOne;
        }

        // ===============================================================================
        //                                                                          Finder
        //                                                                          ======
        public MbColumnInfo FindLocalByReferrer(String referrerColumnDbName) {
            MbColumnInfo keyColumnInfo = referrerDBMeta.FindColumnInfo(referrerColumnDbName);
            MbColumnInfo resultColumnInfo = (MbColumnInfo)referrerLocalColumnInfoMap.get(keyColumnInfo);
            if (resultColumnInfo == null) {
                String msg = "Not found by referrerColumnDbName in referrerLocalColumnInfoMap:";
                msg = msg + " referrerColumnDbName=" + referrerColumnDbName + " referrerLocalColumnInfoMap=" + referrerLocalColumnInfoMap;
                throw new ArgumentException(msg);
            }
            return resultColumnInfo;
        }

        public MbColumnInfo FindReferrerByLocal(String localColumnDbName) {
            MbColumnInfo keyColumnInfo = localDBMeta.FindColumnInfo(localColumnDbName);
            MbColumnInfo resultColumnInfo = (MbColumnInfo)localReferrerColumnInfoMap.get(keyColumnInfo);
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
            return MbSimpleStringUtil.InitCap(str);
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

        public MbDBMeta TargetDBMeta {
            get { return ReferrerDBMeta; }
        }

        public Map<MbColumnInfo, MbColumnInfo> LocalTargetColumnInfoMap {
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

        public MbDBMeta LocalDBMeta {
            get { return localDBMeta; }
        }

        public MbDBMeta ReferrerDBMeta {
            get { return referrerDBMeta; }
        }

        public Map<MbColumnInfo, MbColumnInfo> LocalReferrerColumnInfoMap {
            get { return localReferrerColumnInfoMap; }
        }

        public Map<MbColumnInfo, MbColumnInfo> ReferrerLocalColumnInfoMap {
            get { return referrerLocalColumnInfoMap; }
        }

        public bool IsOneToOne {
            get { return oneToOne; }
        }
    }
}


using System;
using System.Reflection;

using DfExample.DBFlute.MemberDb.AllCommon.Dbm;
using DfExample.DBFlute.MemberDb.AllCommon.JavaLike;
using DfExample.DBFlute.MemberDb.AllCommon.Util;

namespace DfExample.DBFlute.MemberDb.AllCommon.Dbm.Info {

    public class MbForeignInfo : MbRelationInfo {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected String _foreignPropertyName;
        protected MbDBMeta _localDBMeta;
        protected MbDBMeta _foreignDBMeta;
        protected Map<MbColumnInfo, MbColumnInfo> _localForeignColumnInfoMap;
        protected Map<MbColumnInfo, MbColumnInfo> _foreignLocalColumnInfoMap;
        protected int _relationNo;
        protected bool _oneToOne;
        protected bool _bizOneToOne;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public MbForeignInfo(String foreignPropertyName, MbDBMeta localDBMeta, MbDBMeta foreignDBMeta
                         , Map<MbColumnInfo, MbColumnInfo> localForeignColumnInfoMap
                         , int relationNo, bool oneToOne, bool bizOneToOne) {
            AssertObjectNotNull("foreignPropertyName", foreignPropertyName);
            AssertObjectNotNull("localDBMeta", localDBMeta);
            AssertObjectNotNull("foreignDBMeta", foreignDBMeta);
            AssertObjectNotNull("localForeignColumnInfoMap", localForeignColumnInfoMap);
            _foreignPropertyName = foreignPropertyName;
            _localDBMeta = localDBMeta;
            _foreignDBMeta = foreignDBMeta;
            _localForeignColumnInfoMap = localForeignColumnInfoMap;
            Set<MbColumnInfo> keySet = localForeignColumnInfoMap.keySet();
            _foreignLocalColumnInfoMap = new LinkedHashMap<MbColumnInfo, MbColumnInfo>();
            foreach (MbColumnInfo key in localForeignColumnInfoMap.keySet()) {
                MbColumnInfo value = localForeignColumnInfoMap.get(key);
                _foreignLocalColumnInfoMap.put(value, key);
            }
            _relationNo = relationNo;
            _oneToOne = oneToOne;
            _bizOneToOne = bizOneToOne;
        }
        
        // ===============================================================================
        //                                                                          Finder
        //                                                                          ======
        public MbColumnInfo FindLocalByForeign(String foreignColumnDbName) {
            MbColumnInfo keyColumnInfo = _foreignDBMeta.FindColumnInfo(foreignColumnDbName);
            MbColumnInfo resultColumnInfo = _foreignLocalColumnInfoMap.get(keyColumnInfo);
            if (resultColumnInfo == null) {
                String msg = "Not found by foreignColumnDbName in _foreignLocalColumnInfoMap:";
                msg = msg + " foreignColumnDbName=" + foreignColumnDbName + " foreignLocalColumnInfoMap=" + _foreignLocalColumnInfoMap;
                throw new ArgumentException(msg);
            }
            return resultColumnInfo;
        }

        public PropertyInfo FindAccessor() {
            return FindProperty(_localDBMeta.EntityType, BuildInitCapPropertyName(), new Type[] { typeof(System.Collections.Generic.IList<>) });
        }

        // ===============================================================================
        //                                                                         Builder
        //                                                                         =======
        public String BuildInitCapPropertyName() {
            return InitCap(_foreignPropertyName);
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
            get { return ForeignPropertyName; }
        }

        public MbDBMeta TargetDBMeta {
            get { return ForeignDBMeta; }
        }

        public Map<MbColumnInfo, MbColumnInfo> LocalTargetColumnInfoMap {
            get { return LocalForeignColumnInfoMap; }
        }

        public bool IsReferrer {
            get { return false; }
        }

        // ===============================================================================
        //                                                                  Basic Override
        //                                                                  ==============
        public override int GetHashCode() {
            return _foreignPropertyName.GetHashCode() + _localDBMeta.GetHashCode() + _foreignDBMeta.GetHashCode();
        }

        public override bool Equals(Object obj) {
            if (obj == null || !(obj is MbForeignInfo)) {
                return false;
            }
            MbForeignInfo target = (MbForeignInfo) obj;
            if (!this._foreignPropertyName.Equals(target.ForeignPropertyName)) {
                return false;
            }
            if (!this._localDBMeta.Equals(target.LocalDBMeta)) {
                return false;
            }
            if (!this._foreignDBMeta.Equals(target.ForeignDBMeta)) {
                return false;
            }
            return true;
        }

        public override String ToString() {
            return _localDBMeta.TableDbName + "." + _foreignPropertyName + "->" + _foreignDBMeta.TableDbName;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public String ForeignPropertyName {
            get { return _foreignPropertyName; }
        }

        public MbDBMeta LocalDBMeta {
            get { return _localDBMeta; }
        }

        public MbDBMeta ForeignDBMeta {
            get { return _foreignDBMeta; }
        }

        public Map<MbColumnInfo, MbColumnInfo> LocalForeignColumnInfoMap {
            get { return _localForeignColumnInfoMap; }
        }

        public Map<MbColumnInfo, MbColumnInfo> ForeignLocalColumnInfoMap {
            get { return _foreignLocalColumnInfoMap; }
        }

        public int RelationNo {
            get { return _relationNo; }
        }

        public bool IsOneToOne {
            get { return _oneToOne; }
        }

        public bool IsBizOneToOne {
            get { return _bizOneToOne; }
        }
    }
}

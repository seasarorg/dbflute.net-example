

using System;
using System.Reflection;
using System.Collections.Generic;
using System.Text;

using DfExample.DBFlute.LibraryDb.AllCommon;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean;
using DfExample.DBFlute.LibraryDb.AllCommon.Dbm;
using DfExample.DBFlute.LibraryDb.AllCommon.Helper;
using DfExample.DBFlute.LibraryDb.ExEntity;
using DfExample.DBFlute.LibraryDb.BsEntity.Dbm;


namespace DfExample.DBFlute.LibraryDb.ExEntity {

    /// <summary>
    /// The entity of garbage as TABLE. (partial class for auto-generation)
    /// <![CDATA[
    /// [primary-key]
    ///     
    /// 
    /// [column]
    ///     GARBAGE_MEMO, GARBAGE_TIME, GARBAGE_COUNT, R_USER, R_TIMESTAMP, U_USER, U_TIMESTAMP
    /// 
    /// [sequence]
    ///     
    /// 
    /// [identity]
    ///     
    /// 
    /// [version-no]
    ///     
    /// 
    /// [foreign-table]
    ///     
    /// 
    /// [referrer-table]
    ///     
    /// 
    /// [foreign-property]
    ///     
    /// 
    /// [referrer-property]
    ///     
    /// ]]>
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    [Seasar.Dao.Attrs.Table("garbage")]
    [Seasar.Dao.Attrs.TimestampProperty("UTimestamp")]
    [System.Serializable]
    public partial class LdGarbage : LdEntity {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        #region Attribute
        /// <summary>GARBAGE_MEMO: {VARCHAR(50)}</summary>
        protected String _garbageMemo;

        /// <summary>GARBAGE_TIME: {DATETIME(19)}</summary>
        protected DateTime? _garbageTime;

        /// <summary>GARBAGE_COUNT: {INT(10)}</summary>
        protected int? _garbageCount;

        /// <summary>R_USER: {VARCHAR(100)}</summary>
        protected String _rUser;

        /// <summary>R_TIMESTAMP: {DATETIME(19)}</summary>
        protected DateTime? _rTimestamp;

        /// <summary>U_USER: {VARCHAR(100)}</summary>
        protected String _uUser;

        /// <summary>U_TIMESTAMP: {DATETIME(19)}</summary>
        protected DateTime? _uTimestamp;

        protected EntityModifiedProperties __modifiedProperties = new EntityModifiedProperties();
        #endregion

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public String TableDbName { get { return "garbage"; } }
        public String TablePropertyName { get { return "Garbage"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public LdDBMeta DBMeta { get { return LdDBMetaInstanceHandler.FindDBMeta(TableDbName); } }

        // ===============================================================================
        //                                                                Foreign Property
        //                                                                ================
        #region Foreign Property
        #endregion

        // ===============================================================================
        //                                                               Referrer Property
        //                                                               =================
        #region Referrer Property
        #endregion

        // ===============================================================================
        //                                                                   Determination
        //                                                                   =============
        public virtual bool HasPrimaryKeyValue {
            get {
                return false;
            }
        }

        // ===============================================================================
        //                                                             Modified Properties
        //                                                             ===================
        public virtual IDictionary<String, Object> ModifiedPropertyNames {
            get { return __modifiedProperties.PropertyNames; }
        }

        public virtual void ClearModifiedPropertyNames() {
            __modifiedProperties.Clear();
        }

        // ===============================================================================
        //                                                                  Basic Override
        //                                                                  ==============
        #region Basic Override
        public override bool Equals(Object other) {
            if (other == null || !(other is LdGarbage)) { return false; }
            LdGarbage otherEntity = (LdGarbage)other;
            if (!xSV(this.GarbageMemo, otherEntity.GarbageMemo)) { return false; }
            if (!xSV(this.GarbageTime, otherEntity.GarbageTime)) { return false; }
            if (!xSV(this.GarbageCount, otherEntity.GarbageCount)) { return false; }
            if (!xSV(this.RUser, otherEntity.RUser)) { return false; }
            if (!xSV(this.RTimestamp, otherEntity.RTimestamp)) { return false; }
            if (!xSV(this.UUser, otherEntity.UUser)) { return false; }
            if (!xSV(this.UTimestamp, otherEntity.UTimestamp)) { return false; }
            return true;
        }
        protected bool xSV(Object value1, Object value2) { // isSameValue()
            if (value1 == null && value2 == null) { return true; }
            if (value1 == null || value2 == null) { return false; }
            return value1.Equals(value2);
        }

        public override int GetHashCode() {
            int result = 17;
            result = xCH(result, _garbageMemo);
            result = xCH(result, _garbageTime);
            result = xCH(result, _garbageCount);
            result = xCH(result, _rUser);
            result = xCH(result, _rTimestamp);
            result = xCH(result, _uUser);
            result = xCH(result, _uTimestamp);
            return result;
        }
        protected int xCH(int result, Object value) { // calculateHashcode()
            if (value == null) { return result; }
            return (31*result) + (value is byte[] ? ((byte[])value).Length : value.GetHashCode());
        }

        public override String ToString() {
            return "LdGarbage:" + BuildColumnString() + BuildRelationString();
        }

        public virtual String ToStringWithRelation() {
            StringBuilder sb = new StringBuilder();
            sb.Append(ToString());
            return sb.ToString();
        }

        public virtual String BuildDisplayString(String name, bool column, bool relation) {
            StringBuilder sb = new StringBuilder();
            if (name != null) { sb.Append(name).Append(column || relation ? ":" : ""); }
            if (column) { sb.Append(BuildColumnString()); }
            if (relation) { sb.Append(BuildRelationString()); }
            return sb.ToString();
        }
        protected virtual String BuildColumnString() {
            String c = ", ";
            StringBuilder sb = new StringBuilder();
            sb.Append(c).Append(this.GarbageMemo);
            sb.Append(c).Append(this.GarbageTime);
            sb.Append(c).Append(this.GarbageCount);
            sb.Append(c).Append(this.RUser);
            sb.Append(c).Append(this.RTimestamp);
            sb.Append(c).Append(this.UUser);
            sb.Append(c).Append(this.UTimestamp);
            if (sb.Length > 0) { sb.Remove(0, c.Length); }
            sb.Insert(0, "{").Append("}");
            return sb.ToString();
        }
        protected virtual String BuildRelationString() {
            return "";
        }
        #endregion

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        #region Accessor
        /// <summary>GARBAGE_MEMO: {VARCHAR(50)}</summary>
        [Seasar.Dao.Attrs.Column("GARBAGE_MEMO")]
        public String GarbageMemo {
            get { return _garbageMemo; }
            set {
                __modifiedProperties.AddPropertyName("GarbageMemo");
                _garbageMemo = value;
            }
        }

        /// <summary>GARBAGE_TIME: {DATETIME(19)}</summary>
        [Seasar.Dao.Attrs.Column("GARBAGE_TIME")]
        public DateTime? GarbageTime {
            get { return _garbageTime; }
            set {
                __modifiedProperties.AddPropertyName("GarbageTime");
                _garbageTime = value;
            }
        }

        /// <summary>GARBAGE_COUNT: {INT(10)}</summary>
        [Seasar.Dao.Attrs.Column("GARBAGE_COUNT")]
        public int? GarbageCount {
            get { return _garbageCount; }
            set {
                __modifiedProperties.AddPropertyName("GarbageCount");
                _garbageCount = value;
            }
        }

        /// <summary>R_USER: {VARCHAR(100)}</summary>
        [Seasar.Dao.Attrs.Column("R_USER")]
        public String RUser {
            get { return _rUser; }
            set {
                __modifiedProperties.AddPropertyName("RUser");
                _rUser = value;
            }
        }

        /// <summary>R_TIMESTAMP: {DATETIME(19)}</summary>
        [Seasar.Dao.Attrs.Column("R_TIMESTAMP")]
        public DateTime? RTimestamp {
            get { return _rTimestamp; }
            set {
                __modifiedProperties.AddPropertyName("RTimestamp");
                _rTimestamp = value;
            }
        }

        /// <summary>U_USER: {VARCHAR(100)}</summary>
        [Seasar.Dao.Attrs.Column("U_USER")]
        public String UUser {
            get { return _uUser; }
            set {
                __modifiedProperties.AddPropertyName("UUser");
                _uUser = value;
            }
        }

        /// <summary>U_TIMESTAMP: {DATETIME(19)}</summary>
        [Seasar.Dao.Attrs.Column("U_TIMESTAMP")]
        public DateTime? UTimestamp {
            get { return _uTimestamp; }
            set {
                __modifiedProperties.AddPropertyName("UTimestamp");
                _uTimestamp = value;
            }
        }

        #endregion
    }
}



using System;
using System.Reflection;
using System.Collections.Generic;
using System.Text;

using DfExample.DBFlute.AllCommon;
using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.Dbm;
using DfExample.DBFlute.AllCommon.Helper;
using DfExample.DBFlute.ExEntity;
using DfExample.DBFlute.BsEntity.Dbm;


namespace DfExample.DBFlute.ExEntity {

    /// <summary>
    /// The entity of myself_check as TABLE. (partial class for auto-generation)
    /// <![CDATA[
    /// [primary-key]
    ///     MYSELF_CHECK_ID
    /// 
    /// [column]
    ///     MYSELF_CHECK_ID, MYSELF_CHECK_NAME, MYSELF_ID
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
    ///     myself
    /// 
    /// [referrer-table]
    ///     
    /// 
    /// [foreign-property]
    ///     myself
    /// 
    /// [referrer-property]
    ///     
    /// ]]>
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    [Seasar.Dao.Attrs.Table("myself_check")]
    [System.Serializable]
    public partial class MyselfCheck : Entity {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        #region Attribute
        /// <summary>MYSELF_CHECK_ID: {PK, NotNull, INT(10)}</summary>
        protected int? _myselfCheckId;

        /// <summary>MYSELF_CHECK_NAME: {NotNull, VARCHAR(80)}</summary>
        protected String _myselfCheckName;

        /// <summary>MYSELF_ID: {IX, INT(10), FK to myself}</summary>
        protected int? _myselfId;

        protected EntityModifiedProperties __modifiedProperties = new EntityModifiedProperties();
        #endregion

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public String TableDbName { get { return "myself_check"; } }
        public String TablePropertyName { get { return "MyselfCheck"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public DBMeta DBMeta { get { return DBMetaInstanceHandler.FindDBMeta(TableDbName); } }

        // ===============================================================================
        //                                                                Foreign Property
        //                                                                ================
        #region Foreign Property
        protected Myself _myself;

        /// <summary>myself as 'Myself'.</summary>
        [Seasar.Dao.Attrs.Relno(0), Seasar.Dao.Attrs.Relkeys("MYSELF_ID:MYSELF_ID")]
        public Myself Myself {
            get { return _myself; }
            set { _myself = value; }
        }

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
                if (_myselfCheckId == null) { return false; }
                return true;
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
            if (other == null || !(other is MyselfCheck)) { return false; }
            MyselfCheck otherEntity = (MyselfCheck)other;
            if (!xSV(this.MyselfCheckId, otherEntity.MyselfCheckId)) { return false; }
            return true;
        }
        protected bool xSV(Object value1, Object value2) { // isSameValue()
            if (value1 == null && value2 == null) { return true; }
            if (value1 == null || value2 == null) { return false; }
            return value1.Equals(value2);
        }

        public override int GetHashCode() {
            int result = 17;
            result = xCH(result, _myselfCheckId);
            return result;
        }
        protected int xCH(int result, Object value) { // calculateHashcode()
            if (value == null) { return result; }
            return (31*result) + (value is byte[] ? ((byte[])value).Length : value.GetHashCode());
        }

        public override String ToString() {
            return "MyselfCheck:" + BuildColumnString() + BuildRelationString();
        }

        public virtual String ToStringWithRelation() {
            StringBuilder sb = new StringBuilder();
            sb.Append(ToString());
            String l = "\n  ";
            if (_myself != null)
            { sb.Append(l).Append(xbRDS(_myself, "Myself")); }
            return sb.ToString();
        }
        protected String xbRDS(Entity e, String name) { // buildRelationDisplayString()
            return e.BuildDisplayString(name, true, true);
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
            sb.Append(c).Append(this.MyselfCheckId);
            sb.Append(c).Append(this.MyselfCheckName);
            sb.Append(c).Append(this.MyselfId);
            if (sb.Length > 0) { sb.Remove(0, c.Length); }
            sb.Insert(0, "{").Append("}");
            return sb.ToString();
        }
        protected virtual String BuildRelationString() {
            StringBuilder sb = new StringBuilder();
            String c = ",";
            if (_myself != null) { sb.Append(c).Append("Myself"); }
            if (sb.Length > 0) { sb.Remove(0, c.Length).Insert(0, "(").Append(")"); }
            return sb.ToString();
        }
        #endregion

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        #region Accessor
        /// <summary>MYSELF_CHECK_ID: {PK, NotNull, INT(10)}</summary>
        [Seasar.Dao.Attrs.Column("MYSELF_CHECK_ID")]
        public int? MyselfCheckId {
            get { return _myselfCheckId; }
            set {
                __modifiedProperties.AddPropertyName("MyselfCheckId");
                _myselfCheckId = value;
            }
        }

        /// <summary>MYSELF_CHECK_NAME: {NotNull, VARCHAR(80)}</summary>
        [Seasar.Dao.Attrs.Column("MYSELF_CHECK_NAME")]
        public String MyselfCheckName {
            get { return _myselfCheckName; }
            set {
                __modifiedProperties.AddPropertyName("MyselfCheckName");
                _myselfCheckName = value;
            }
        }

        /// <summary>MYSELF_ID: {IX, INT(10), FK to myself}</summary>
        [Seasar.Dao.Attrs.Column("MYSELF_ID")]
        public int? MyselfId {
            get { return _myselfId; }
            set {
                __modifiedProperties.AddPropertyName("MyselfId");
                _myselfId = value;
            }
        }

        #endregion
    }
}



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
    /// The entity of myself as TABLE. (partial class for auto-generation)
    /// <![CDATA[
    /// [primary-key]
    ///     MYSELF_ID
    /// 
    /// [column]
    ///     MYSELF_ID, MYSELF_NAME
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
    ///     myself_check
    /// 
    /// [foreign-property]
    ///     
    /// 
    /// [referrer-property]
    ///     myselfCheckList
    /// ]]>
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    [Seasar.Dao.Attrs.Table("myself")]
    [System.Serializable]
    public partial class Myself : Entity {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        #region Attribute
        /// <summary>MYSELF_ID: {PK, NotNull, INT(10)}</summary>
        protected int? _myselfId;

        /// <summary>MYSELF_NAME: {NotNull, VARCHAR(80)}</summary>
        protected String _myselfName;

        protected EntityModifiedProperties __modifiedProperties = new EntityModifiedProperties();
        #endregion

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public String TableDbName { get { return "myself"; } }
        public String TablePropertyName { get { return "Myself"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public DBMeta DBMeta { get { return DBMetaInstanceHandler.FindDBMeta(TableDbName); } }

        // ===============================================================================
        //                                                                Foreign Property
        //                                                                ================
        #region Foreign Property
        #endregion

        // ===============================================================================
        //                                                               Referrer Property
        //                                                               =================
        #region Referrer Property
        protected IList<MyselfCheck> _myselfCheckList;

        /// <summary>myself_check as 'MyselfCheckList'.</summary>
        public IList<MyselfCheck> MyselfCheckList {
            get { if (_myselfCheckList == null) { _myselfCheckList = new List<MyselfCheck>(); } return _myselfCheckList; }
            set { _myselfCheckList = value; }
        }

        #endregion

        // ===============================================================================
        //                                                                   Determination
        //                                                                   =============
        public virtual bool HasPrimaryKeyValue {
            get {
                if (_myselfId == null) { return false; }
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
            if (other == null || !(other is Myself)) { return false; }
            Myself otherEntity = (Myself)other;
            if (!xSV(this.MyselfId, otherEntity.MyselfId)) { return false; }
            return true;
        }
        protected bool xSV(Object value1, Object value2) { // isSameValue()
            if (value1 == null && value2 == null) { return true; }
            if (value1 == null || value2 == null) { return false; }
            return value1.Equals(value2);
        }

        public override int GetHashCode() {
            int result = 17;
            result = xCH(result, _myselfId);
            return result;
        }
        protected int xCH(int result, Object value) { // calculateHashcode()
            if (value == null) { return result; }
            return (31*result) + (value is byte[] ? ((byte[])value).Length : value.GetHashCode());
        }

        public override String ToString() {
            return "Myself:" + BuildColumnString() + BuildRelationString();
        }

        public virtual String ToStringWithRelation() {
            StringBuilder sb = new StringBuilder();
            sb.Append(ToString());
            String l = "\n  ";
            if (_myselfCheckList != null) { foreach (Entity e in _myselfCheckList)
            { if (e != null) { sb.Append(l).Append(xbRDS(e, "MyselfCheckList")); } } }
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
            sb.Append(c).Append(this.MyselfId);
            sb.Append(c).Append(this.MyselfName);
            if (sb.Length > 0) { sb.Remove(0, c.Length); }
            sb.Insert(0, "{").Append("}");
            return sb.ToString();
        }
        protected virtual String BuildRelationString() {
            StringBuilder sb = new StringBuilder();
            String c = ",";
            if (_myselfCheckList != null && _myselfCheckList.Count > 0)
            { sb.Append(c).Append("MyselfCheckList"); }
            if (sb.Length > 0) { sb.Remove(0, c.Length).Insert(0, "(").Append(")"); }
            return sb.ToString();
        }
        #endregion

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        #region Accessor
        /// <summary>MYSELF_ID: {PK, NotNull, INT(10)}</summary>
        [Seasar.Dao.Attrs.Column("MYSELF_ID")]
        public int? MyselfId {
            get { return _myselfId; }
            set {
                __modifiedProperties.AddPropertyName("MyselfId");
                _myselfId = value;
            }
        }

        /// <summary>MYSELF_NAME: {NotNull, VARCHAR(80)}</summary>
        [Seasar.Dao.Attrs.Column("MYSELF_NAME")]
        public String MyselfName {
            get { return _myselfName; }
            set {
                __modifiedProperties.AddPropertyName("MyselfName");
                _myselfName = value;
            }
        }

        #endregion
    }
}

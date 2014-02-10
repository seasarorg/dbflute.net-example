

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
    /// The entity of white_pg_reserv_ref as TABLE. (partial class for auto-generation)
    /// <![CDATA[
    /// [primary-key]
    ///     REF_ID
    /// 
    /// [column]
    ///     REF_ID, CLASS
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
    ///     white_pg_reserv
    /// 
    /// [referrer-table]
    ///     
    /// 
    /// [foreign-property]
    ///     whitePgReserv
    /// 
    /// [referrer-property]
    ///     
    /// ]]>
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    [Seasar.Dao.Attrs.Table("white_pg_reserv_ref")]
    [System.Serializable]
    public partial class WhitePgReservRef : Entity {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        #region Attribute
        /// <summary>REF_ID: {PK, NotNull, INT(10)}</summary>
        protected int? _refId;

        /// <summary>CLASS: {IX, INT(10), FK to white_pg_reserv}</summary>
        protected int? _classSynonym;

        protected EntityModifiedProperties __modifiedProperties = new EntityModifiedProperties();
        #endregion

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public String TableDbName { get { return "white_pg_reserv_ref"; } }
        public String TablePropertyName { get { return "WhitePgReservRef"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public DBMeta DBMeta { get { return DBMetaInstanceHandler.FindDBMeta(TableDbName); } }

        // ===============================================================================
        //                                                                Foreign Property
        //                                                                ================
        #region Foreign Property
        protected WhitePgReserv _whitePgReserv;

        /// <summary>white_pg_reserv as 'WhitePgReserv'.</summary>
        [Seasar.Dao.Attrs.Relno(0), Seasar.Dao.Attrs.Relkeys("CLASS:CLASS")]
        public WhitePgReserv WhitePgReserv {
            get { return _whitePgReserv; }
            set { _whitePgReserv = value; }
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
                if (_refId == null) { return false; }
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
            if (other == null || !(other is WhitePgReservRef)) { return false; }
            WhitePgReservRef otherEntity = (WhitePgReservRef)other;
            if (!xSV(this.RefId, otherEntity.RefId)) { return false; }
            return true;
        }
        protected bool xSV(Object value1, Object value2) { // isSameValue()
            if (value1 == null && value2 == null) { return true; }
            if (value1 == null || value2 == null) { return false; }
            return value1.Equals(value2);
        }

        public override int GetHashCode() {
            int result = 17;
            result = xCH(result, _refId);
            return result;
        }
        protected int xCH(int result, Object value) { // calculateHashcode()
            if (value == null) { return result; }
            return (31*result) + (value is byte[] ? ((byte[])value).Length : value.GetHashCode());
        }

        public override String ToString() {
            return "WhitePgReservRef:" + BuildColumnString() + BuildRelationString();
        }

        public virtual String ToStringWithRelation() {
            StringBuilder sb = new StringBuilder();
            sb.Append(ToString());
            String l = "\n  ";
            if (_whitePgReserv != null)
            { sb.Append(l).Append(xbRDS(_whitePgReserv, "WhitePgReserv")); }
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
            sb.Append(c).Append(this.RefId);
            sb.Append(c).Append(this.ClassSynonym);
            if (sb.Length > 0) { sb.Remove(0, c.Length); }
            sb.Insert(0, "{").Append("}");
            return sb.ToString();
        }
        protected virtual String BuildRelationString() {
            StringBuilder sb = new StringBuilder();
            String c = ",";
            if (_whitePgReserv != null) { sb.Append(c).Append("WhitePgReserv"); }
            if (sb.Length > 0) { sb.Remove(0, c.Length).Insert(0, "(").Append(")"); }
            return sb.ToString();
        }
        #endregion

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        #region Accessor
        /// <summary>REF_ID: {PK, NotNull, INT(10)}</summary>
        [Seasar.Dao.Attrs.Column("REF_ID")]
        public int? RefId {
            get { return _refId; }
            set {
                __modifiedProperties.AddPropertyName("RefId");
                _refId = value;
            }
        }

        /// <summary>CLASS: {IX, INT(10), FK to white_pg_reserv}</summary>
        /// <remarks>
        /// (using DBFlute synonym)
        /// </remarks>
        [Seasar.Dao.Attrs.Column("CLASS")]
        public int? ClassSynonym {
            get { return _classSynonym; }
            set {
                __modifiedProperties.AddPropertyName("ClassSynonym");
                _classSynonym = value;
            }
        }

        #endregion
    }
}

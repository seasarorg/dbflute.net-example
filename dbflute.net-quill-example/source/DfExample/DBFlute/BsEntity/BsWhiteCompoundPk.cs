

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
    /// The entity of white_compound_pk as TABLE. (partial class for auto-generation)
    /// <![CDATA[
    /// [primary-key]
    ///     PK_FIRST_ID, PK_SECOND_ID
    /// 
    /// [column]
    ///     PK_FIRST_ID, PK_SECOND_ID, PK_NAME
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
    ///     white_compound_pk_ref
    /// 
    /// [foreign-property]
    ///     
    /// 
    /// [referrer-property]
    ///     whiteCompoundPkRefList
    /// ]]>
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    [Seasar.Dao.Attrs.Table("white_compound_pk")]
    [System.Serializable]
    public partial class WhiteCompoundPk : Entity {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        #region Attribute
        /// <summary>PK_FIRST_ID: {PK, NotNull, INT(10)}</summary>
        protected int? _pkFirstId;

        /// <summary>PK_SECOND_ID: {PK, NotNull, INT(10)}</summary>
        protected int? _pkSecondId;

        /// <summary>PK_NAME: {NotNull, VARCHAR(200)}</summary>
        protected String _pkName;

        protected EntityModifiedProperties __modifiedProperties = new EntityModifiedProperties();
        #endregion

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public String TableDbName { get { return "white_compound_pk"; } }
        public String TablePropertyName { get { return "WhiteCompoundPk"; } }

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
        protected IList<WhiteCompoundPkRef> _whiteCompoundPkRefList;

        /// <summary>white_compound_pk_ref as 'WhiteCompoundPkRefList'.</summary>
        public IList<WhiteCompoundPkRef> WhiteCompoundPkRefList {
            get { if (_whiteCompoundPkRefList == null) { _whiteCompoundPkRefList = new List<WhiteCompoundPkRef>(); } return _whiteCompoundPkRefList; }
            set { _whiteCompoundPkRefList = value; }
        }

        #endregion

        // ===============================================================================
        //                                                                   Determination
        //                                                                   =============
        public virtual bool HasPrimaryKeyValue {
            get {
                if (_pkFirstId == null) { return false; }
                if (_pkSecondId == null) { return false; }
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
            if (other == null || !(other is WhiteCompoundPk)) { return false; }
            WhiteCompoundPk otherEntity = (WhiteCompoundPk)other;
            if (!xSV(this.PkFirstId, otherEntity.PkFirstId)) { return false; }
            if (!xSV(this.PkSecondId, otherEntity.PkSecondId)) { return false; }
            return true;
        }
        protected bool xSV(Object value1, Object value2) { // isSameValue()
            if (value1 == null && value2 == null) { return true; }
            if (value1 == null || value2 == null) { return false; }
            return value1.Equals(value2);
        }

        public override int GetHashCode() {
            int result = 17;
            result = xCH(result, _pkFirstId);
            result = xCH(result, _pkSecondId);
            return result;
        }
        protected int xCH(int result, Object value) { // calculateHashcode()
            if (value == null) { return result; }
            return (31*result) + (value is byte[] ? ((byte[])value).Length : value.GetHashCode());
        }

        public override String ToString() {
            return "WhiteCompoundPk:" + BuildColumnString() + BuildRelationString();
        }

        public virtual String ToStringWithRelation() {
            StringBuilder sb = new StringBuilder();
            sb.Append(ToString());
            String l = "\n  ";
            if (_whiteCompoundPkRefList != null) { foreach (Entity e in _whiteCompoundPkRefList)
            { if (e != null) { sb.Append(l).Append(xbRDS(e, "WhiteCompoundPkRefList")); } } }
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
            sb.Append(c).Append(this.PkFirstId);
            sb.Append(c).Append(this.PkSecondId);
            sb.Append(c).Append(this.PkName);
            if (sb.Length > 0) { sb.Remove(0, c.Length); }
            sb.Insert(0, "{").Append("}");
            return sb.ToString();
        }
        protected virtual String BuildRelationString() {
            StringBuilder sb = new StringBuilder();
            String c = ",";
            if (_whiteCompoundPkRefList != null && _whiteCompoundPkRefList.Count > 0)
            { sb.Append(c).Append("WhiteCompoundPkRefList"); }
            if (sb.Length > 0) { sb.Remove(0, c.Length).Insert(0, "(").Append(")"); }
            return sb.ToString();
        }
        #endregion

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        #region Accessor
        /// <summary>PK_FIRST_ID: {PK, NotNull, INT(10)}</summary>
        [Seasar.Dao.Attrs.Column("PK_FIRST_ID")]
        public int? PkFirstId {
            get { return _pkFirstId; }
            set {
                __modifiedProperties.AddPropertyName("PkFirstId");
                _pkFirstId = value;
            }
        }

        /// <summary>PK_SECOND_ID: {PK, NotNull, INT(10)}</summary>
        [Seasar.Dao.Attrs.Column("PK_SECOND_ID")]
        public int? PkSecondId {
            get { return _pkSecondId; }
            set {
                __modifiedProperties.AddPropertyName("PkSecondId");
                _pkSecondId = value;
            }
        }

        /// <summary>PK_NAME: {NotNull, VARCHAR(200)}</summary>
        [Seasar.Dao.Attrs.Column("PK_NAME")]
        public String PkName {
            get { return _pkName; }
            set {
                __modifiedProperties.AddPropertyName("PkName");
                _pkName = value;
            }
        }

        #endregion
    }
}

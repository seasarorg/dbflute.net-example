

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
    /// The entity of white_compound_pk_ref as TABLE. (partial class for auto-generation)
    /// <![CDATA[
    /// [primary-key]
    ///     MULTIPLE_FIRST_ID, MULTIPLE_SECOND_ID
    /// 
    /// [column]
    ///     MULTIPLE_FIRST_ID, MULTIPLE_SECOND_ID, REF_FIRST_ID, REF_SECOND_ID
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
    ///     white_compound_pk
    /// 
    /// [referrer-table]
    ///     white_compound_pk_ref_nest
    /// 
    /// [foreign-property]
    ///     whiteCompoundPk
    /// 
    /// [referrer-property]
    ///     whiteCompoundPkRefNestByQuxMultipleIdList, whiteCompoundPkRefNestByFooMultipleIdList
    /// ]]>
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    [Seasar.Dao.Attrs.Table("white_compound_pk_ref")]
    [System.Serializable]
    public partial class WhiteCompoundPkRef : Entity {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        #region Attribute
        /// <summary>MULTIPLE_FIRST_ID: {PK, NotNull, INT(10)}</summary>
        protected int? _multipleFirstId;

        /// <summary>MULTIPLE_SECOND_ID: {PK, NotNull, INT(10)}</summary>
        protected int? _multipleSecondId;

        /// <summary>REF_FIRST_ID: {IX+, NotNull, INT(10), FK to white_compound_pk}</summary>
        protected int? _refFirstId;

        /// <summary>REF_SECOND_ID: {NotNull, INT(10), FK to white_compound_pk}</summary>
        protected int? _refSecondId;

        protected EntityModifiedProperties __modifiedProperties = new EntityModifiedProperties();
        #endregion

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public String TableDbName { get { return "white_compound_pk_ref"; } }
        public String TablePropertyName { get { return "WhiteCompoundPkRef"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public DBMeta DBMeta { get { return DBMetaInstanceHandler.FindDBMeta(TableDbName); } }

        // ===============================================================================
        //                                                                Foreign Property
        //                                                                ================
        #region Foreign Property
        protected WhiteCompoundPk _whiteCompoundPk;

        /// <summary>white_compound_pk as 'WhiteCompoundPk'.</summary>
        [Seasar.Dao.Attrs.Relno(0), Seasar.Dao.Attrs.Relkeys("REF_FIRST_ID:PK_FIRST_ID, REF_SECOND_ID:PK_SECOND_ID")]
        public WhiteCompoundPk WhiteCompoundPk {
            get { return _whiteCompoundPk; }
            set { _whiteCompoundPk = value; }
        }

        #endregion

        // ===============================================================================
        //                                                               Referrer Property
        //                                                               =================
        #region Referrer Property
        protected IList<WhiteCompoundPkRefNest> _whiteCompoundPkRefNestByQuxMultipleIdList;

        /// <summary>white_compound_pk_ref_nest as 'WhiteCompoundPkRefNestByQuxMultipleIdList'.</summary>
        public IList<WhiteCompoundPkRefNest> WhiteCompoundPkRefNestByQuxMultipleIdList {
            get { if (_whiteCompoundPkRefNestByQuxMultipleIdList == null) { _whiteCompoundPkRefNestByQuxMultipleIdList = new List<WhiteCompoundPkRefNest>(); } return _whiteCompoundPkRefNestByQuxMultipleIdList; }
            set { _whiteCompoundPkRefNestByQuxMultipleIdList = value; }
        }

        protected IList<WhiteCompoundPkRefNest> _whiteCompoundPkRefNestByFooMultipleIdList;

        /// <summary>white_compound_pk_ref_nest as 'WhiteCompoundPkRefNestByFooMultipleIdList'.</summary>
        public IList<WhiteCompoundPkRefNest> WhiteCompoundPkRefNestByFooMultipleIdList {
            get { if (_whiteCompoundPkRefNestByFooMultipleIdList == null) { _whiteCompoundPkRefNestByFooMultipleIdList = new List<WhiteCompoundPkRefNest>(); } return _whiteCompoundPkRefNestByFooMultipleIdList; }
            set { _whiteCompoundPkRefNestByFooMultipleIdList = value; }
        }

        #endregion

        // ===============================================================================
        //                                                                   Determination
        //                                                                   =============
        public virtual bool HasPrimaryKeyValue {
            get {
                if (_multipleFirstId == null) { return false; }
                if (_multipleSecondId == null) { return false; }
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
            if (other == null || !(other is WhiteCompoundPkRef)) { return false; }
            WhiteCompoundPkRef otherEntity = (WhiteCompoundPkRef)other;
            if (!xSV(this.MultipleFirstId, otherEntity.MultipleFirstId)) { return false; }
            if (!xSV(this.MultipleSecondId, otherEntity.MultipleSecondId)) { return false; }
            return true;
        }
        protected bool xSV(Object value1, Object value2) { // isSameValue()
            if (value1 == null && value2 == null) { return true; }
            if (value1 == null || value2 == null) { return false; }
            return value1.Equals(value2);
        }

        public override int GetHashCode() {
            int result = 17;
            result = xCH(result, _multipleFirstId);
            result = xCH(result, _multipleSecondId);
            return result;
        }
        protected int xCH(int result, Object value) { // calculateHashcode()
            if (value == null) { return result; }
            return (31*result) + (value is byte[] ? ((byte[])value).Length : value.GetHashCode());
        }

        public override String ToString() {
            return "WhiteCompoundPkRef:" + BuildColumnString() + BuildRelationString();
        }

        public virtual String ToStringWithRelation() {
            StringBuilder sb = new StringBuilder();
            sb.Append(ToString());
            String l = "\n  ";
            if (_whiteCompoundPk != null)
            { sb.Append(l).Append(xbRDS(_whiteCompoundPk, "WhiteCompoundPk")); }
            if (_whiteCompoundPkRefNestByQuxMultipleIdList != null) { foreach (Entity e in _whiteCompoundPkRefNestByQuxMultipleIdList)
            { if (e != null) { sb.Append(l).Append(xbRDS(e, "WhiteCompoundPkRefNestByQuxMultipleIdList")); } } }
            if (_whiteCompoundPkRefNestByFooMultipleIdList != null) { foreach (Entity e in _whiteCompoundPkRefNestByFooMultipleIdList)
            { if (e != null) { sb.Append(l).Append(xbRDS(e, "WhiteCompoundPkRefNestByFooMultipleIdList")); } } }
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
            sb.Append(c).Append(this.MultipleFirstId);
            sb.Append(c).Append(this.MultipleSecondId);
            sb.Append(c).Append(this.RefFirstId);
            sb.Append(c).Append(this.RefSecondId);
            if (sb.Length > 0) { sb.Remove(0, c.Length); }
            sb.Insert(0, "{").Append("}");
            return sb.ToString();
        }
        protected virtual String BuildRelationString() {
            StringBuilder sb = new StringBuilder();
            String c = ",";
            if (_whiteCompoundPk != null) { sb.Append(c).Append("WhiteCompoundPk"); }
            if (_whiteCompoundPkRefNestByQuxMultipleIdList != null && _whiteCompoundPkRefNestByQuxMultipleIdList.Count > 0)
            { sb.Append(c).Append("WhiteCompoundPkRefNestByQuxMultipleIdList"); }
            if (_whiteCompoundPkRefNestByFooMultipleIdList != null && _whiteCompoundPkRefNestByFooMultipleIdList.Count > 0)
            { sb.Append(c).Append("WhiteCompoundPkRefNestByFooMultipleIdList"); }
            if (sb.Length > 0) { sb.Remove(0, c.Length).Insert(0, "(").Append(")"); }
            return sb.ToString();
        }
        #endregion

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        #region Accessor
        /// <summary>MULTIPLE_FIRST_ID: {PK, NotNull, INT(10)}</summary>
        [Seasar.Dao.Attrs.Column("MULTIPLE_FIRST_ID")]
        public int? MultipleFirstId {
            get { return _multipleFirstId; }
            set {
                __modifiedProperties.AddPropertyName("MultipleFirstId");
                _multipleFirstId = value;
            }
        }

        /// <summary>MULTIPLE_SECOND_ID: {PK, NotNull, INT(10)}</summary>
        [Seasar.Dao.Attrs.Column("MULTIPLE_SECOND_ID")]
        public int? MultipleSecondId {
            get { return _multipleSecondId; }
            set {
                __modifiedProperties.AddPropertyName("MultipleSecondId");
                _multipleSecondId = value;
            }
        }

        /// <summary>REF_FIRST_ID: {IX+, NotNull, INT(10), FK to white_compound_pk}</summary>
        [Seasar.Dao.Attrs.Column("REF_FIRST_ID")]
        public int? RefFirstId {
            get { return _refFirstId; }
            set {
                __modifiedProperties.AddPropertyName("RefFirstId");
                _refFirstId = value;
            }
        }

        /// <summary>REF_SECOND_ID: {NotNull, INT(10), FK to white_compound_pk}</summary>
        [Seasar.Dao.Attrs.Column("REF_SECOND_ID")]
        public int? RefSecondId {
            get { return _refSecondId; }
            set {
                __modifiedProperties.AddPropertyName("RefSecondId");
                _refSecondId = value;
            }
        }

        #endregion
    }
}



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
    /// The entity of white_compound_pk_ref_nest as TABLE. (partial class for auto-generation)
    /// <![CDATA[
    /// [primary-key]
    ///     COMPOUND_PK_REF_NEST_ID
    /// 
    /// [column]
    ///     COMPOUND_PK_REF_NEST_ID, FOO_MULTIPLE_ID, BAR_MULTIPLE_ID, QUX_MULTIPLE_ID
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
    ///     white_compound_pk_ref
    /// 
    /// [referrer-table]
    ///     
    /// 
    /// [foreign-property]
    ///     whiteCompoundPkRefByQuxMultipleId, whiteCompoundPkRefByFooMultipleId
    /// 
    /// [referrer-property]
    ///     
    /// ]]>
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    [Seasar.Dao.Attrs.Table("white_compound_pk_ref_nest")]
    [System.Serializable]
    public partial class WhiteCompoundPkRefNest : Entity {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        #region Attribute
        /// <summary>COMPOUND_PK_REF_NEST_ID: {PK, NotNull, INT(10)}</summary>
        protected int? _compoundPkRefNestId;

        /// <summary>FOO_MULTIPLE_ID: {IX+, NotNull, INT(10), FK to white_compound_pk_ref}</summary>
        protected int? _fooMultipleId;

        /// <summary>BAR_MULTIPLE_ID: {IX+, NotNull, INT(10), FK to white_compound_pk_ref}</summary>
        protected int? _barMultipleId;

        /// <summary>QUX_MULTIPLE_ID: {NotNull, INT(10), FK to white_compound_pk_ref}</summary>
        protected int? _quxMultipleId;

        protected EntityModifiedProperties __modifiedProperties = new EntityModifiedProperties();
        #endregion

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public String TableDbName { get { return "white_compound_pk_ref_nest"; } }
        public String TablePropertyName { get { return "WhiteCompoundPkRefNest"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public DBMeta DBMeta { get { return DBMetaInstanceHandler.FindDBMeta(TableDbName); } }

        // ===============================================================================
        //                                                                Foreign Property
        //                                                                ================
        #region Foreign Property
        protected WhiteCompoundPkRef _whiteCompoundPkRefByQuxMultipleId;

        /// <summary>white_compound_pk_ref as 'WhiteCompoundPkRefByQuxMultipleId'.</summary>
        [Seasar.Dao.Attrs.Relno(0), Seasar.Dao.Attrs.Relkeys("BAR_MULTIPLE_ID:MULTIPLE_FIRST_ID, QUX_MULTIPLE_ID:MULTIPLE_SECOND_ID")]
        public WhiteCompoundPkRef WhiteCompoundPkRefByQuxMultipleId {
            get { return _whiteCompoundPkRefByQuxMultipleId; }
            set { _whiteCompoundPkRefByQuxMultipleId = value; }
        }

        protected WhiteCompoundPkRef _whiteCompoundPkRefByFooMultipleId;

        /// <summary>white_compound_pk_ref as 'WhiteCompoundPkRefByFooMultipleId'.</summary>
        [Seasar.Dao.Attrs.Relno(1), Seasar.Dao.Attrs.Relkeys("FOO_MULTIPLE_ID:MULTIPLE_FIRST_ID, BAR_MULTIPLE_ID:MULTIPLE_SECOND_ID")]
        public WhiteCompoundPkRef WhiteCompoundPkRefByFooMultipleId {
            get { return _whiteCompoundPkRefByFooMultipleId; }
            set { _whiteCompoundPkRefByFooMultipleId = value; }
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
                if (_compoundPkRefNestId == null) { return false; }
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
            if (other == null || !(other is WhiteCompoundPkRefNest)) { return false; }
            WhiteCompoundPkRefNest otherEntity = (WhiteCompoundPkRefNest)other;
            if (!xSV(this.CompoundPkRefNestId, otherEntity.CompoundPkRefNestId)) { return false; }
            return true;
        }
        protected bool xSV(Object value1, Object value2) { // isSameValue()
            if (value1 == null && value2 == null) { return true; }
            if (value1 == null || value2 == null) { return false; }
            return value1.Equals(value2);
        }

        public override int GetHashCode() {
            int result = 17;
            result = xCH(result, _compoundPkRefNestId);
            return result;
        }
        protected int xCH(int result, Object value) { // calculateHashcode()
            if (value == null) { return result; }
            return (31*result) + (value is byte[] ? ((byte[])value).Length : value.GetHashCode());
        }

        public override String ToString() {
            return "WhiteCompoundPkRefNest:" + BuildColumnString() + BuildRelationString();
        }

        public virtual String ToStringWithRelation() {
            StringBuilder sb = new StringBuilder();
            sb.Append(ToString());
            String l = "\n  ";
            if (_whiteCompoundPkRefByQuxMultipleId != null)
            { sb.Append(l).Append(xbRDS(_whiteCompoundPkRefByQuxMultipleId, "WhiteCompoundPkRefByQuxMultipleId")); }
            if (_whiteCompoundPkRefByFooMultipleId != null)
            { sb.Append(l).Append(xbRDS(_whiteCompoundPkRefByFooMultipleId, "WhiteCompoundPkRefByFooMultipleId")); }
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
            sb.Append(c).Append(this.CompoundPkRefNestId);
            sb.Append(c).Append(this.FooMultipleId);
            sb.Append(c).Append(this.BarMultipleId);
            sb.Append(c).Append(this.QuxMultipleId);
            if (sb.Length > 0) { sb.Remove(0, c.Length); }
            sb.Insert(0, "{").Append("}");
            return sb.ToString();
        }
        protected virtual String BuildRelationString() {
            StringBuilder sb = new StringBuilder();
            String c = ",";
            if (_whiteCompoundPkRefByQuxMultipleId != null) { sb.Append(c).Append("WhiteCompoundPkRefByQuxMultipleId"); }
            if (_whiteCompoundPkRefByFooMultipleId != null) { sb.Append(c).Append("WhiteCompoundPkRefByFooMultipleId"); }
            if (sb.Length > 0) { sb.Remove(0, c.Length).Insert(0, "(").Append(")"); }
            return sb.ToString();
        }
        #endregion

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        #region Accessor
        /// <summary>COMPOUND_PK_REF_NEST_ID: {PK, NotNull, INT(10)}</summary>
        [Seasar.Dao.Attrs.Column("COMPOUND_PK_REF_NEST_ID")]
        public int? CompoundPkRefNestId {
            get { return _compoundPkRefNestId; }
            set {
                __modifiedProperties.AddPropertyName("CompoundPkRefNestId");
                _compoundPkRefNestId = value;
            }
        }

        /// <summary>FOO_MULTIPLE_ID: {IX+, NotNull, INT(10), FK to white_compound_pk_ref}</summary>
        [Seasar.Dao.Attrs.Column("FOO_MULTIPLE_ID")]
        public int? FooMultipleId {
            get { return _fooMultipleId; }
            set {
                __modifiedProperties.AddPropertyName("FooMultipleId");
                _fooMultipleId = value;
            }
        }

        /// <summary>BAR_MULTIPLE_ID: {IX+, NotNull, INT(10), FK to white_compound_pk_ref}</summary>
        [Seasar.Dao.Attrs.Column("BAR_MULTIPLE_ID")]
        public int? BarMultipleId {
            get { return _barMultipleId; }
            set {
                __modifiedProperties.AddPropertyName("BarMultipleId");
                _barMultipleId = value;
            }
        }

        /// <summary>QUX_MULTIPLE_ID: {NotNull, INT(10), FK to white_compound_pk_ref}</summary>
        [Seasar.Dao.Attrs.Column("QUX_MULTIPLE_ID")]
        public int? QuxMultipleId {
            get { return _quxMultipleId; }
            set {
                __modifiedProperties.AddPropertyName("QuxMultipleId");
                _quxMultipleId = value;
            }
        }

        #endregion
    }
}



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
    /// The entity of white_self_reference as TABLE. (partial class for auto-generation)
    /// <![CDATA[
    /// [primary-key]
    ///     SELF_REFERENCE_ID
    /// 
    /// [column]
    ///     SELF_REFERENCE_ID, SELF_REFERENCE_NAME, PARENT_ID
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
    ///     white_self_reference
    /// 
    /// [referrer-table]
    ///     white_self_reference
    /// 
    /// [foreign-property]
    ///     whiteSelfReferenceSelf
    /// 
    /// [referrer-property]
    ///     whiteSelfReferenceSelfList
    /// ]]>
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    [Seasar.Dao.Attrs.Table("white_self_reference")]
    [System.Serializable]
    public partial class WhiteSelfReference : Entity {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        #region Attribute
        /// <summary>SELF_REFERENCE_ID: {PK, NotNull, DECIMAL(16)}</summary>
        protected long? _selfReferenceId;

        /// <summary>SELF_REFERENCE_NAME: {NotNull, VARCHAR(200)}</summary>
        protected String _selfReferenceName;

        /// <summary>PARENT_ID: {IX, DECIMAL(16), FK to white_self_reference}</summary>
        protected long? _parentId;

        protected EntityModifiedProperties __modifiedProperties = new EntityModifiedProperties();
        #endregion

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public String TableDbName { get { return "white_self_reference"; } }
        public String TablePropertyName { get { return "WhiteSelfReference"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public DBMeta DBMeta { get { return DBMetaInstanceHandler.FindDBMeta(TableDbName); } }

        // ===============================================================================
        //                                                                Foreign Property
        //                                                                ================
        #region Foreign Property
        protected WhiteSelfReference _whiteSelfReferenceSelf;

        /// <summary>white_self_reference as 'WhiteSelfReferenceSelf'.</summary>
        [Seasar.Dao.Attrs.Relno(0), Seasar.Dao.Attrs.Relkeys("PARENT_ID:SELF_REFERENCE_ID")]
        public WhiteSelfReference WhiteSelfReferenceSelf {
            get { return _whiteSelfReferenceSelf; }
            set { _whiteSelfReferenceSelf = value; }
        }

        #endregion

        // ===============================================================================
        //                                                               Referrer Property
        //                                                               =================
        #region Referrer Property
        protected IList<WhiteSelfReference> _whiteSelfReferenceSelfList;

        /// <summary>white_self_reference as 'WhiteSelfReferenceSelfList'.</summary>
        public IList<WhiteSelfReference> WhiteSelfReferenceSelfList {
            get { if (_whiteSelfReferenceSelfList == null) { _whiteSelfReferenceSelfList = new List<WhiteSelfReference>(); } return _whiteSelfReferenceSelfList; }
            set { _whiteSelfReferenceSelfList = value; }
        }

        #endregion

        // ===============================================================================
        //                                                                   Determination
        //                                                                   =============
        public virtual bool HasPrimaryKeyValue {
            get {
                if (_selfReferenceId == null) { return false; }
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
            if (other == null || !(other is WhiteSelfReference)) { return false; }
            WhiteSelfReference otherEntity = (WhiteSelfReference)other;
            if (!xSV(this.SelfReferenceId, otherEntity.SelfReferenceId)) { return false; }
            return true;
        }
        protected bool xSV(Object value1, Object value2) { // isSameValue()
            if (value1 == null && value2 == null) { return true; }
            if (value1 == null || value2 == null) { return false; }
            return value1.Equals(value2);
        }

        public override int GetHashCode() {
            int result = 17;
            result = xCH(result, _selfReferenceId);
            return result;
        }
        protected int xCH(int result, Object value) { // calculateHashcode()
            if (value == null) { return result; }
            return (31*result) + (value is byte[] ? ((byte[])value).Length : value.GetHashCode());
        }

        public override String ToString() {
            return "WhiteSelfReference:" + BuildColumnString() + BuildRelationString();
        }

        public virtual String ToStringWithRelation() {
            StringBuilder sb = new StringBuilder();
            sb.Append(ToString());
            String l = "\n  ";
            if (_whiteSelfReferenceSelf != null)
            { sb.Append(l).Append(xbRDS(_whiteSelfReferenceSelf, "WhiteSelfReferenceSelf")); }
            if (_whiteSelfReferenceSelfList != null) { foreach (Entity e in _whiteSelfReferenceSelfList)
            { if (e != null) { sb.Append(l).Append(xbRDS(e, "WhiteSelfReferenceSelfList")); } } }
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
            sb.Append(c).Append(this.SelfReferenceId);
            sb.Append(c).Append(this.SelfReferenceName);
            sb.Append(c).Append(this.ParentId);
            if (sb.Length > 0) { sb.Remove(0, c.Length); }
            sb.Insert(0, "{").Append("}");
            return sb.ToString();
        }
        protected virtual String BuildRelationString() {
            StringBuilder sb = new StringBuilder();
            String c = ",";
            if (_whiteSelfReferenceSelf != null) { sb.Append(c).Append("WhiteSelfReferenceSelf"); }
            if (_whiteSelfReferenceSelfList != null && _whiteSelfReferenceSelfList.Count > 0)
            { sb.Append(c).Append("WhiteSelfReferenceSelfList"); }
            if (sb.Length > 0) { sb.Remove(0, c.Length).Insert(0, "(").Append(")"); }
            return sb.ToString();
        }
        #endregion

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        #region Accessor
        /// <summary>SELF_REFERENCE_ID: {PK, NotNull, DECIMAL(16)}</summary>
        [Seasar.Dao.Attrs.Column("SELF_REFERENCE_ID")]
        public long? SelfReferenceId {
            get { return _selfReferenceId; }
            set {
                __modifiedProperties.AddPropertyName("SelfReferenceId");
                _selfReferenceId = value;
            }
        }

        /// <summary>SELF_REFERENCE_NAME: {NotNull, VARCHAR(200)}</summary>
        [Seasar.Dao.Attrs.Column("SELF_REFERENCE_NAME")]
        public String SelfReferenceName {
            get { return _selfReferenceName; }
            set {
                __modifiedProperties.AddPropertyName("SelfReferenceName");
                _selfReferenceName = value;
            }
        }

        /// <summary>PARENT_ID: {IX, DECIMAL(16), FK to white_self_reference}</summary>
        [Seasar.Dao.Attrs.Column("PARENT_ID")]
        public long? ParentId {
            get { return _parentId; }
            set {
                __modifiedProperties.AddPropertyName("ParentId");
                _parentId = value;
            }
        }

        #endregion
    }
}

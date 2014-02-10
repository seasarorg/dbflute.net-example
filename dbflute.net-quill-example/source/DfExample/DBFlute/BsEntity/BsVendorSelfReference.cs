

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
    /// The entity of vendor_self_reference as TABLE. (partial class for auto-generation)
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
    ///     vendor_self_reference
    /// 
    /// [referrer-table]
    ///     vendor_self_reference
    /// 
    /// [foreign-property]
    ///     vendorSelfReferenceSelf
    /// 
    /// [referrer-property]
    ///     vendorSelfReferenceSelfList
    /// ]]>
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    [Seasar.Dao.Attrs.Table("vendor_self_reference")]
    [System.Serializable]
    public partial class VendorSelfReference : Entity {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        #region Attribute
        /// <summary>SELF_REFERENCE_ID: {PK, NotNull, DECIMAL(16)}</summary>
        protected long? _selfReferenceId;

        /// <summary>SELF_REFERENCE_NAME: {NotNull, VARCHAR(200)}</summary>
        protected String _selfReferenceName;

        /// <summary>PARENT_ID: {IX, DECIMAL(16), FK to vendor_self_reference}</summary>
        protected long? _parentId;

        protected EntityModifiedProperties __modifiedProperties = new EntityModifiedProperties();
        #endregion

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public String TableDbName { get { return "vendor_self_reference"; } }
        public String TablePropertyName { get { return "VendorSelfReference"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public DBMeta DBMeta { get { return DBMetaInstanceHandler.FindDBMeta(TableDbName); } }

        // ===============================================================================
        //                                                                Foreign Property
        //                                                                ================
        #region Foreign Property
        protected VendorSelfReference _vendorSelfReferenceSelf;

        /// <summary>vendor_self_reference as 'VendorSelfReferenceSelf'.</summary>
        [Seasar.Dao.Attrs.Relno(0), Seasar.Dao.Attrs.Relkeys("PARENT_ID:SELF_REFERENCE_ID")]
        public VendorSelfReference VendorSelfReferenceSelf {
            get { return _vendorSelfReferenceSelf; }
            set { _vendorSelfReferenceSelf = value; }
        }

        #endregion

        // ===============================================================================
        //                                                               Referrer Property
        //                                                               =================
        #region Referrer Property
        protected IList<VendorSelfReference> _vendorSelfReferenceSelfList;

        /// <summary>vendor_self_reference as 'VendorSelfReferenceSelfList'.</summary>
        public IList<VendorSelfReference> VendorSelfReferenceSelfList {
            get { if (_vendorSelfReferenceSelfList == null) { _vendorSelfReferenceSelfList = new List<VendorSelfReference>(); } return _vendorSelfReferenceSelfList; }
            set { _vendorSelfReferenceSelfList = value; }
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
            if (other == null || !(other is VendorSelfReference)) { return false; }
            VendorSelfReference otherEntity = (VendorSelfReference)other;
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
            return "VendorSelfReference:" + BuildColumnString() + BuildRelationString();
        }

        public virtual String ToStringWithRelation() {
            StringBuilder sb = new StringBuilder();
            sb.Append(ToString());
            String l = "\n  ";
            if (_vendorSelfReferenceSelf != null)
            { sb.Append(l).Append(xbRDS(_vendorSelfReferenceSelf, "VendorSelfReferenceSelf")); }
            if (_vendorSelfReferenceSelfList != null) { foreach (Entity e in _vendorSelfReferenceSelfList)
            { if (e != null) { sb.Append(l).Append(xbRDS(e, "VendorSelfReferenceSelfList")); } } }
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
            if (_vendorSelfReferenceSelf != null) { sb.Append(c).Append("VendorSelfReferenceSelf"); }
            if (_vendorSelfReferenceSelfList != null && _vendorSelfReferenceSelfList.Count > 0)
            { sb.Append(c).Append("VendorSelfReferenceSelfList"); }
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

        /// <summary>PARENT_ID: {IX, DECIMAL(16), FK to vendor_self_reference}</summary>
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

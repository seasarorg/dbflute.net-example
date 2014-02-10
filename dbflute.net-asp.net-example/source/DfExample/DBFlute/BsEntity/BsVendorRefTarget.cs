

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
    /// The entity of VENDOR_REF_TARGET as TABLE. (partial class for auto-generation)
    /// <![CDATA[
    /// [primary-key]
    ///     VENDOR_REF_TARGET_ID
    /// 
    /// [column]
    ///     VENDOR_REF_TARGET_ID, VENDOR_TARGET_ID
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
    ///     VENDOR_TARGET
    /// 
    /// [referrer-table]
    ///     
    /// 
    /// [foreign-property]
    ///     vendorTarget
    /// 
    /// [referrer-property]
    ///     
    /// ]]>
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    [Seasar.Dao.Attrs.Table("VENDOR_REF_TARGET")]
    [System.Serializable]
    public partial class VendorRefTarget : Entity {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        #region Attribute
        /// <summary>VENDOR_REF_TARGET_ID: {PK, NotNull, NUMBER(16)}</summary>
        protected long? _vendorRefTargetId;

        /// <summary>VENDOR_TARGET_ID: {NotNull, NUMBER(16), FK to VENDOR_TARGET}</summary>
        protected long? _vendorTargetId;

        protected EntityModifiedProperties __modifiedProperties = new EntityModifiedProperties();
        #endregion

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public String TableDbName { get { return "VENDOR_REF_TARGET"; } }
        public String TablePropertyName { get { return "VendorRefTarget"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public DBMeta DBMeta { get { return DBMetaInstanceHandler.FindDBMeta(TableDbName); } }

        // ===============================================================================
        //                                                                Foreign Property
        //                                                                ================
        #region Foreign Property
        protected VendorTarget _vendorTarget;

        /// <summary>VENDOR_TARGET as 'VendorTarget'.</summary>
        [Seasar.Dao.Attrs.Relno(0), Seasar.Dao.Attrs.Relkeys("VENDOR_TARGET_ID:VENDOR_TARGET_ID")]
        public VendorTarget VendorTarget {
            get { return _vendorTarget; }
            set { _vendorTarget = value; }
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
                if (_vendorRefTargetId == null) { return false; }
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
            if (other == null || !(other is VendorRefTarget)) { return false; }
            VendorRefTarget otherEntity = (VendorRefTarget)other;
            if (!xSV(this.VendorRefTargetId, otherEntity.VendorRefTargetId)) { return false; }
            return true;
        }
        protected bool xSV(Object value1, Object value2) { // isSameValue()
            if (value1 == null && value2 == null) { return true; }
            if (value1 == null || value2 == null) { return false; }
            return value1.Equals(value2);
        }

        public override int GetHashCode() {
            int result = 17;
            result = xCH(result, _vendorRefTargetId);
            return result;
        }
        protected int xCH(int result, Object value) { // calculateHashcode()
            if (value == null) { return result; }
            return (31*result) + (value is byte[] ? ((byte[])value).Length : value.GetHashCode());
        }

        public override String ToString() {
            return "VendorRefTarget:" + BuildColumnString() + BuildRelationString();
        }

        public virtual String ToStringWithRelation() {
            StringBuilder sb = new StringBuilder();
            sb.Append(ToString());
            String l = "\n  ";
            if (_vendorTarget != null)
            { sb.Append(l).Append(xbRDS(_vendorTarget, "VendorTarget")); }
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
            sb.Append(c).Append(this.VendorRefTargetId);
            sb.Append(c).Append(this.VendorTargetId);
            if (sb.Length > 0) { sb.Remove(0, c.Length); }
            sb.Insert(0, "{").Append("}");
            return sb.ToString();
        }
        protected virtual String BuildRelationString() {
            StringBuilder sb = new StringBuilder();
            String c = ",";
            if (_vendorTarget != null) { sb.Append(c).Append("VendorTarget"); }
            if (sb.Length > 0) { sb.Remove(0, c.Length).Insert(0, "(").Append(")"); }
            return sb.ToString();
        }
        #endregion

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        #region Accessor
        /// <summary>VENDOR_REF_TARGET_ID: {PK, NotNull, NUMBER(16)}</summary>
        [Seasar.Dao.Attrs.Column("VENDOR_REF_TARGET_ID")]
        public long? VendorRefTargetId {
            get { return _vendorRefTargetId; }
            set {
                __modifiedProperties.AddPropertyName("VendorRefTargetId");
                _vendorRefTargetId = value;
            }
        }

        /// <summary>VENDOR_TARGET_ID: {NotNull, NUMBER(16), FK to VENDOR_TARGET}</summary>
        [Seasar.Dao.Attrs.Column("VENDOR_TARGET_ID")]
        public long? VendorTargetId {
            get { return _vendorTargetId; }
            set {
                __modifiedProperties.AddPropertyName("VendorTargetId");
                _vendorTargetId = value;
            }
        }

        #endregion
    }
}



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
    /// The entity of VD_SYNONYM_VENDOR_REF_EXCEPT as SYNONYM. (partial class for auto-generation)
    /// <![CDATA[
    /// [primary-key]
    ///     VENDOR_REF_EXCEPT_ID
    /// 
    /// [column]
    ///     VENDOR_REF_EXCEPT_ID, VENDOR_EXCEPT_ID
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
    ///     VD_SYNONYM_VENDOR_EXCEPT
    /// 
    /// [referrer-table]
    ///     
    /// 
    /// [foreign-property]
    ///     vdSynonymVendorExcept
    /// 
    /// [referrer-property]
    ///     
    /// ]]>
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    [Seasar.Dao.Attrs.Table("VD_SYNONYM_VENDOR_REF_EXCEPT")]
    [System.Serializable]
    public partial class VdSynonymVendorRefExcept : Entity {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        #region Attribute
        /// <summary>VENDOR_REF_EXCEPT_ID: {PK, NotNull, NUMBER(16)}</summary>
        protected long? _vendorRefExceptId;

        /// <summary>VENDOR_EXCEPT_ID: {NotNull, NUMBER(16), FK to VD_SYNONYM_VENDOR_EXCEPT}</summary>
        protected long? _vendorExceptId;

        protected EntityModifiedProperties __modifiedProperties = new EntityModifiedProperties();
        #endregion

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public String TableDbName { get { return "VD_SYNONYM_VENDOR_REF_EXCEPT"; } }
        public String TablePropertyName { get { return "VdSynonymVendorRefExcept"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public DBMeta DBMeta { get { return DBMetaInstanceHandler.FindDBMeta(TableDbName); } }

        // ===============================================================================
        //                                                                Foreign Property
        //                                                                ================
        #region Foreign Property
        protected VdSynonymVendorExcept _vdSynonymVendorExcept;

        /// <summary>VD_SYNONYM_VENDOR_EXCEPT as 'VdSynonymVendorExcept'.</summary>
        [Seasar.Dao.Attrs.Relno(0), Seasar.Dao.Attrs.Relkeys("VENDOR_EXCEPT_ID:VENDOR_EXCEPT_ID")]
        public VdSynonymVendorExcept VdSynonymVendorExcept {
            get { return _vdSynonymVendorExcept; }
            set { _vdSynonymVendorExcept = value; }
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
                if (_vendorRefExceptId == null) { return false; }
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
            if (other == null || !(other is VdSynonymVendorRefExcept)) { return false; }
            VdSynonymVendorRefExcept otherEntity = (VdSynonymVendorRefExcept)other;
            if (!xSV(this.VendorRefExceptId, otherEntity.VendorRefExceptId)) { return false; }
            return true;
        }
        protected bool xSV(Object value1, Object value2) { // isSameValue()
            if (value1 == null && value2 == null) { return true; }
            if (value1 == null || value2 == null) { return false; }
            return value1.Equals(value2);
        }

        public override int GetHashCode() {
            int result = 17;
            result = xCH(result, _vendorRefExceptId);
            return result;
        }
        protected int xCH(int result, Object value) { // calculateHashcode()
            if (value == null) { return result; }
            return (31*result) + (value is byte[] ? ((byte[])value).Length : value.GetHashCode());
        }

        public override String ToString() {
            return "VdSynonymVendorRefExcept:" + BuildColumnString() + BuildRelationString();
        }

        public virtual String ToStringWithRelation() {
            StringBuilder sb = new StringBuilder();
            sb.Append(ToString());
            String l = "\n  ";
            if (_vdSynonymVendorExcept != null)
            { sb.Append(l).Append(xbRDS(_vdSynonymVendorExcept, "VdSynonymVendorExcept")); }
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
            sb.Append(c).Append(this.VendorRefExceptId);
            sb.Append(c).Append(this.VendorExceptId);
            if (sb.Length > 0) { sb.Remove(0, c.Length); }
            sb.Insert(0, "{").Append("}");
            return sb.ToString();
        }
        protected virtual String BuildRelationString() {
            StringBuilder sb = new StringBuilder();
            String c = ",";
            if (_vdSynonymVendorExcept != null) { sb.Append(c).Append("VdSynonymVendorExcept"); }
            if (sb.Length > 0) { sb.Remove(0, c.Length).Insert(0, "(").Append(")"); }
            return sb.ToString();
        }
        #endregion

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        #region Accessor
        /// <summary>VENDOR_REF_EXCEPT_ID: {PK, NotNull, NUMBER(16)}</summary>
        [Seasar.Dao.Attrs.Column("VENDOR_REF_EXCEPT_ID")]
        public long? VendorRefExceptId {
            get { return _vendorRefExceptId; }
            set {
                __modifiedProperties.AddPropertyName("VendorRefExceptId");
                _vendorRefExceptId = value;
            }
        }

        /// <summary>VENDOR_EXCEPT_ID: {NotNull, NUMBER(16), FK to VD_SYNONYM_VENDOR_EXCEPT}</summary>
        [Seasar.Dao.Attrs.Column("VENDOR_EXCEPT_ID")]
        public long? VendorExceptId {
            get { return _vendorExceptId; }
            set {
                __modifiedProperties.AddPropertyName("VendorExceptId");
                _vendorExceptId = value;
            }
        }

        #endregion
    }
}

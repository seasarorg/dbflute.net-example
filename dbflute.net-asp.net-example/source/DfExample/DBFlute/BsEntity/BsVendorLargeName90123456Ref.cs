

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
    /// The entity of VENDOR_LARGE_NAME_90123456_REF as TABLE. (partial class for auto-generation)
    /// <![CDATA[
    /// [primary-key]
    ///     VENDOR_LARGE_NAME_90123_REF_ID
    /// 
    /// [column]
    ///     VENDOR_LARGE_NAME_90123_REF_ID, VENDOR_LARGE_NAME_901_REF_NAME, VENDOR_LARGE_NAME_901234567_ID
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
    ///     VENDOR_LARGE_NAME_901234567890
    /// 
    /// [referrer-table]
    ///     
    /// 
    /// [foreign-property]
    ///     vendorLargeName901234567890
    /// 
    /// [referrer-property]
    ///     
    /// ]]>
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    [Seasar.Dao.Attrs.Table("VENDOR_LARGE_NAME_90123456_REF")]
    [System.Serializable]
    public partial class VendorLargeName90123456Ref : Entity {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        #region Attribute
        /// <summary>VENDOR_LARGE_NAME_90123_REF_ID: {PK, NotNull, NUMBER(16)}</summary>
        protected long? _vendorLargeName90123RefId;

        /// <summary>VENDOR_LARGE_NAME_901_REF_NAME: {NotNull, VARCHAR2(32)}</summary>
        protected String _vendorLargeName901RefName;

        /// <summary>VENDOR_LARGE_NAME_901234567_ID: {NUMBER(16), FK to VENDOR_LARGE_NAME_901234567890}</summary>
        protected long? _vendorLargeName901234567Id;

        protected EntityModifiedProperties __modifiedProperties = new EntityModifiedProperties();
        #endregion

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public String TableDbName { get { return "VENDOR_LARGE_NAME_90123456_REF"; } }
        public String TablePropertyName { get { return "VendorLargeName90123456Ref"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public DBMeta DBMeta { get { return DBMetaInstanceHandler.FindDBMeta(TableDbName); } }

        // ===============================================================================
        //                                                                Foreign Property
        //                                                                ================
        #region Foreign Property
        protected VendorLargeName901234567890 _vendorLargeName901234567890;

        /// <summary>VENDOR_LARGE_NAME_901234567890 as 'VendorLargeName901234567890'.</summary>
        [Seasar.Dao.Attrs.Relno(0), Seasar.Dao.Attrs.Relkeys("VENDOR_LARGE_NAME_901234567_ID:VENDOR_LARGE_NAME_901234567_ID")]
        public VendorLargeName901234567890 VendorLargeName901234567890 {
            get { return _vendorLargeName901234567890; }
            set { _vendorLargeName901234567890 = value; }
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
                if (_vendorLargeName90123RefId == null) { return false; }
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
            if (other == null || !(other is VendorLargeName90123456Ref)) { return false; }
            VendorLargeName90123456Ref otherEntity = (VendorLargeName90123456Ref)other;
            if (!xSV(this.VendorLargeName90123RefId, otherEntity.VendorLargeName90123RefId)) { return false; }
            return true;
        }
        protected bool xSV(Object value1, Object value2) { // isSameValue()
            if (value1 == null && value2 == null) { return true; }
            if (value1 == null || value2 == null) { return false; }
            return value1.Equals(value2);
        }

        public override int GetHashCode() {
            int result = 17;
            result = xCH(result, _vendorLargeName90123RefId);
            return result;
        }
        protected int xCH(int result, Object value) { // calculateHashcode()
            if (value == null) { return result; }
            return (31*result) + (value is byte[] ? ((byte[])value).Length : value.GetHashCode());
        }

        public override String ToString() {
            return "VendorLargeName90123456Ref:" + BuildColumnString() + BuildRelationString();
        }

        public virtual String ToStringWithRelation() {
            StringBuilder sb = new StringBuilder();
            sb.Append(ToString());
            String l = "\n  ";
            if (_vendorLargeName901234567890 != null)
            { sb.Append(l).Append(xbRDS(_vendorLargeName901234567890, "VendorLargeName901234567890")); }
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
            sb.Append(c).Append(this.VendorLargeName90123RefId);
            sb.Append(c).Append(this.VendorLargeName901RefName);
            sb.Append(c).Append(this.VendorLargeName901234567Id);
            if (sb.Length > 0) { sb.Remove(0, c.Length); }
            sb.Insert(0, "{").Append("}");
            return sb.ToString();
        }
        protected virtual String BuildRelationString() {
            StringBuilder sb = new StringBuilder();
            String c = ",";
            if (_vendorLargeName901234567890 != null) { sb.Append(c).Append("VendorLargeName901234567890"); }
            if (sb.Length > 0) { sb.Remove(0, c.Length).Insert(0, "(").Append(")"); }
            return sb.ToString();
        }
        #endregion

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        #region Accessor
        /// <summary>VENDOR_LARGE_NAME_90123_REF_ID: {PK, NotNull, NUMBER(16)}</summary>
        [Seasar.Dao.Attrs.Column("VENDOR_LARGE_NAME_90123_REF_ID")]
        public long? VendorLargeName90123RefId {
            get { return _vendorLargeName90123RefId; }
            set {
                __modifiedProperties.AddPropertyName("VendorLargeName90123RefId");
                _vendorLargeName90123RefId = value;
            }
        }

        /// <summary>VENDOR_LARGE_NAME_901_REF_NAME: {NotNull, VARCHAR2(32)}</summary>
        [Seasar.Dao.Attrs.Column("VENDOR_LARGE_NAME_901_REF_NAME")]
        public String VendorLargeName901RefName {
            get { return _vendorLargeName901RefName; }
            set {
                __modifiedProperties.AddPropertyName("VendorLargeName901RefName");
                _vendorLargeName901RefName = value;
            }
        }

        /// <summary>VENDOR_LARGE_NAME_901234567_ID: {NUMBER(16), FK to VENDOR_LARGE_NAME_901234567890}</summary>
        [Seasar.Dao.Attrs.Column("VENDOR_LARGE_NAME_901234567_ID")]
        public long? VendorLargeName901234567Id {
            get { return _vendorLargeName901234567Id; }
            set {
                __modifiedProperties.AddPropertyName("VendorLargeName901234567Id");
                _vendorLargeName901234567Id = value;
            }
        }

        #endregion
    }
}

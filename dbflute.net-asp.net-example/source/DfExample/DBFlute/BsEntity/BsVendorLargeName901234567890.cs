

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
    /// The entity of VENDOR_LARGE_NAME_901234567890 as TABLE. (partial class for auto-generation)
    /// <![CDATA[
    /// [primary-key]
    ///     VENDOR_LARGE_NAME_901234567_ID
    /// 
    /// [column]
    ///     VENDOR_LARGE_NAME_901234567_ID, VENDOR_LARGE_NAME_9012345_NAME
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
    ///     VENDOR_LARGE_NAME_90123456_REF
    /// 
    /// [foreign-property]
    ///     
    /// 
    /// [referrer-property]
    ///     vendorLargeName90123456RefList
    /// ]]>
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    [Seasar.Dao.Attrs.Table("VENDOR_LARGE_NAME_901234567890")]
    [System.Serializable]
    public partial class VendorLargeName901234567890 : Entity {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        #region Attribute
        /// <summary>VENDOR_LARGE_NAME_901234567_ID: {PK, NotNull, NUMBER(16)}</summary>
        protected long? _vendorLargeName901234567Id;

        /// <summary>VENDOR_LARGE_NAME_9012345_NAME: {NotNull, VARCHAR2(32)}</summary>
        protected String _vendorLargeName9012345Name;

        protected EntityModifiedProperties __modifiedProperties = new EntityModifiedProperties();
        #endregion

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public String TableDbName { get { return "VENDOR_LARGE_NAME_901234567890"; } }
        public String TablePropertyName { get { return "VendorLargeName901234567890"; } }

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
        protected IList<VendorLargeName90123456Ref> _vendorLargeName90123456RefList;

        /// <summary>VENDOR_LARGE_NAME_90123456_REF as 'VendorLargeName90123456RefList'.</summary>
        public IList<VendorLargeName90123456Ref> VendorLargeName90123456RefList {
            get { if (_vendorLargeName90123456RefList == null) { _vendorLargeName90123456RefList = new List<VendorLargeName90123456Ref>(); } return _vendorLargeName90123456RefList; }
            set { _vendorLargeName90123456RefList = value; }
        }

        #endregion

        // ===============================================================================
        //                                                                   Determination
        //                                                                   =============
        public virtual bool HasPrimaryKeyValue {
            get {
                if (_vendorLargeName901234567Id == null) { return false; }
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
            if (other == null || !(other is VendorLargeName901234567890)) { return false; }
            VendorLargeName901234567890 otherEntity = (VendorLargeName901234567890)other;
            if (!xSV(this.VendorLargeName901234567Id, otherEntity.VendorLargeName901234567Id)) { return false; }
            return true;
        }
        protected bool xSV(Object value1, Object value2) { // isSameValue()
            if (value1 == null && value2 == null) { return true; }
            if (value1 == null || value2 == null) { return false; }
            return value1.Equals(value2);
        }

        public override int GetHashCode() {
            int result = 17;
            result = xCH(result, _vendorLargeName901234567Id);
            return result;
        }
        protected int xCH(int result, Object value) { // calculateHashcode()
            if (value == null) { return result; }
            return (31*result) + (value is byte[] ? ((byte[])value).Length : value.GetHashCode());
        }

        public override String ToString() {
            return "VendorLargeName901234567890:" + BuildColumnString() + BuildRelationString();
        }

        public virtual String ToStringWithRelation() {
            StringBuilder sb = new StringBuilder();
            sb.Append(ToString());
            String l = "\n  ";
            if (_vendorLargeName90123456RefList != null) { foreach (Entity e in _vendorLargeName90123456RefList)
            { if (e != null) { sb.Append(l).Append(xbRDS(e, "VendorLargeName90123456RefList")); } } }
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
            sb.Append(c).Append(this.VendorLargeName901234567Id);
            sb.Append(c).Append(this.VendorLargeName9012345Name);
            if (sb.Length > 0) { sb.Remove(0, c.Length); }
            sb.Insert(0, "{").Append("}");
            return sb.ToString();
        }
        protected virtual String BuildRelationString() {
            StringBuilder sb = new StringBuilder();
            String c = ",";
            if (_vendorLargeName90123456RefList != null && _vendorLargeName90123456RefList.Count > 0)
            { sb.Append(c).Append("VendorLargeName90123456RefList"); }
            if (sb.Length > 0) { sb.Remove(0, c.Length).Insert(0, "(").Append(")"); }
            return sb.ToString();
        }
        #endregion

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        #region Accessor
        /// <summary>VENDOR_LARGE_NAME_901234567_ID: {PK, NotNull, NUMBER(16)}</summary>
        [Seasar.Dao.Attrs.Column("VENDOR_LARGE_NAME_901234567_ID")]
        public long? VendorLargeName901234567Id {
            get { return _vendorLargeName901234567Id; }
            set {
                __modifiedProperties.AddPropertyName("VendorLargeName901234567Id");
                _vendorLargeName901234567Id = value;
            }
        }

        /// <summary>VENDOR_LARGE_NAME_9012345_NAME: {NotNull, VARCHAR2(32)}</summary>
        [Seasar.Dao.Attrs.Column("VENDOR_LARGE_NAME_9012345_NAME")]
        public String VendorLargeName9012345Name {
            get { return _vendorLargeName9012345Name; }
            set {
                __modifiedProperties.AddPropertyName("VendorLargeName9012345Name");
                _vendorLargeName9012345Name = value;
            }
        }

        #endregion
    }
}



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
    /// The entity of VD_SYNONYM_VENDOR_EXCEPT as SYNONYM. (partial class for auto-generation)
    /// <![CDATA[
    /// [primary-key]
    ///     VENDOR_EXCEPT_ID
    /// 
    /// [column]
    ///     VENDOR_EXCEPT_ID, VANDOR_EXCEPT_NAME
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
    ///     VD_SYNONYM_VENDOR_REF_EXCEPT
    /// 
    /// [foreign-property]
    ///     
    /// 
    /// [referrer-property]
    ///     vdSynonymVendorRefExceptList
    /// ]]>
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    [Seasar.Dao.Attrs.Table("VD_SYNONYM_VENDOR_EXCEPT")]
    [System.Serializable]
    public partial class VdSynonymVendorExcept : Entity {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        #region Attribute
        /// <summary>VENDOR_EXCEPT_ID: {PK, NotNull, NUMBER(16)}</summary>
        protected long? _vendorExceptId;

        /// <summary>VANDOR_EXCEPT_NAME: {VARCHAR2(256)}</summary>
        protected String _vandorExceptName;

        protected EntityModifiedProperties __modifiedProperties = new EntityModifiedProperties();
        #endregion

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public String TableDbName { get { return "VD_SYNONYM_VENDOR_EXCEPT"; } }
        public String TablePropertyName { get { return "VdSynonymVendorExcept"; } }

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
        protected IList<VdSynonymVendorRefExcept> _vdSynonymVendorRefExceptList;

        /// <summary>VD_SYNONYM_VENDOR_REF_EXCEPT as 'VdSynonymVendorRefExceptList'.</summary>
        public IList<VdSynonymVendorRefExcept> VdSynonymVendorRefExceptList {
            get { if (_vdSynonymVendorRefExceptList == null) { _vdSynonymVendorRefExceptList = new List<VdSynonymVendorRefExcept>(); } return _vdSynonymVendorRefExceptList; }
            set { _vdSynonymVendorRefExceptList = value; }
        }

        #endregion

        // ===============================================================================
        //                                                                   Determination
        //                                                                   =============
        public virtual bool HasPrimaryKeyValue {
            get {
                if (_vendorExceptId == null) { return false; }
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
            if (other == null || !(other is VdSynonymVendorExcept)) { return false; }
            VdSynonymVendorExcept otherEntity = (VdSynonymVendorExcept)other;
            if (!xSV(this.VendorExceptId, otherEntity.VendorExceptId)) { return false; }
            return true;
        }
        protected bool xSV(Object value1, Object value2) { // isSameValue()
            if (value1 == null && value2 == null) { return true; }
            if (value1 == null || value2 == null) { return false; }
            return value1.Equals(value2);
        }

        public override int GetHashCode() {
            int result = 17;
            result = xCH(result, _vendorExceptId);
            return result;
        }
        protected int xCH(int result, Object value) { // calculateHashcode()
            if (value == null) { return result; }
            return (31*result) + (value is byte[] ? ((byte[])value).Length : value.GetHashCode());
        }

        public override String ToString() {
            return "VdSynonymVendorExcept:" + BuildColumnString() + BuildRelationString();
        }

        public virtual String ToStringWithRelation() {
            StringBuilder sb = new StringBuilder();
            sb.Append(ToString());
            String l = "\n  ";
            if (_vdSynonymVendorRefExceptList != null) { foreach (Entity e in _vdSynonymVendorRefExceptList)
            { if (e != null) { sb.Append(l).Append(xbRDS(e, "VdSynonymVendorRefExceptList")); } } }
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
            sb.Append(c).Append(this.VendorExceptId);
            sb.Append(c).Append(this.VandorExceptName);
            if (sb.Length > 0) { sb.Remove(0, c.Length); }
            sb.Insert(0, "{").Append("}");
            return sb.ToString();
        }
        protected virtual String BuildRelationString() {
            StringBuilder sb = new StringBuilder();
            String c = ",";
            if (_vdSynonymVendorRefExceptList != null && _vdSynonymVendorRefExceptList.Count > 0)
            { sb.Append(c).Append("VdSynonymVendorRefExceptList"); }
            if (sb.Length > 0) { sb.Remove(0, c.Length).Insert(0, "(").Append(")"); }
            return sb.ToString();
        }
        #endregion

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        #region Accessor
        /// <summary>VENDOR_EXCEPT_ID: {PK, NotNull, NUMBER(16)}</summary>
        [Seasar.Dao.Attrs.Column("VENDOR_EXCEPT_ID")]
        public long? VendorExceptId {
            get { return _vendorExceptId; }
            set {
                __modifiedProperties.AddPropertyName("VendorExceptId");
                _vendorExceptId = value;
            }
        }

        /// <summary>VANDOR_EXCEPT_NAME: {VARCHAR2(256)}</summary>
        [Seasar.Dao.Attrs.Column("VANDOR_EXCEPT_NAME")]
        public String VandorExceptName {
            get { return _vandorExceptName; }
            set {
                __modifiedProperties.AddPropertyName("VandorExceptName");
                _vandorExceptName = value;
            }
        }

        #endregion
    }
}

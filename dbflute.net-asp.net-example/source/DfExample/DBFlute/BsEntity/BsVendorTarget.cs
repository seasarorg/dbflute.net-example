

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
    /// The entity of VENDOR_TARGET as TABLE. (partial class for auto-generation)
    /// <![CDATA[
    /// [primary-key]
    ///     VENDOR_TARGET_ID
    /// 
    /// [column]
    ///     VENDOR_TARGET_ID, VANDOR_TARGET_NAME
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
    ///     VENDOR_REF_TARGET
    /// 
    /// [foreign-property]
    ///     
    /// 
    /// [referrer-property]
    ///     vendorRefTargetList
    /// ]]>
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    [Seasar.Dao.Attrs.Table("VENDOR_TARGET")]
    [System.Serializable]
    public partial class VendorTarget : Entity {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        #region Attribute
        /// <summary>VENDOR_TARGET_ID: {PK, NotNull, NUMBER(16)}</summary>
        protected long? _vendorTargetId;

        /// <summary>VANDOR_TARGET_NAME: {VARCHAR2(256)}</summary>
        protected String _vandorTargetName;

        protected EntityModifiedProperties __modifiedProperties = new EntityModifiedProperties();
        #endregion

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public String TableDbName { get { return "VENDOR_TARGET"; } }
        public String TablePropertyName { get { return "VendorTarget"; } }

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
        protected IList<VendorRefTarget> _vendorRefTargetList;

        /// <summary>VENDOR_REF_TARGET as 'VendorRefTargetList'.</summary>
        public IList<VendorRefTarget> VendorRefTargetList {
            get { if (_vendorRefTargetList == null) { _vendorRefTargetList = new List<VendorRefTarget>(); } return _vendorRefTargetList; }
            set { _vendorRefTargetList = value; }
        }

        #endregion

        // ===============================================================================
        //                                                                   Determination
        //                                                                   =============
        public virtual bool HasPrimaryKeyValue {
            get {
                if (_vendorTargetId == null) { return false; }
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
            if (other == null || !(other is VendorTarget)) { return false; }
            VendorTarget otherEntity = (VendorTarget)other;
            if (!xSV(this.VendorTargetId, otherEntity.VendorTargetId)) { return false; }
            return true;
        }
        protected bool xSV(Object value1, Object value2) { // isSameValue()
            if (value1 == null && value2 == null) { return true; }
            if (value1 == null || value2 == null) { return false; }
            return value1.Equals(value2);
        }

        public override int GetHashCode() {
            int result = 17;
            result = xCH(result, _vendorTargetId);
            return result;
        }
        protected int xCH(int result, Object value) { // calculateHashcode()
            if (value == null) { return result; }
            return (31*result) + (value is byte[] ? ((byte[])value).Length : value.GetHashCode());
        }

        public override String ToString() {
            return "VendorTarget:" + BuildColumnString() + BuildRelationString();
        }

        public virtual String ToStringWithRelation() {
            StringBuilder sb = new StringBuilder();
            sb.Append(ToString());
            String l = "\n  ";
            if (_vendorRefTargetList != null) { foreach (Entity e in _vendorRefTargetList)
            { if (e != null) { sb.Append(l).Append(xbRDS(e, "VendorRefTargetList")); } } }
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
            sb.Append(c).Append(this.VendorTargetId);
            sb.Append(c).Append(this.VandorTargetName);
            if (sb.Length > 0) { sb.Remove(0, c.Length); }
            sb.Insert(0, "{").Append("}");
            return sb.ToString();
        }
        protected virtual String BuildRelationString() {
            StringBuilder sb = new StringBuilder();
            String c = ",";
            if (_vendorRefTargetList != null && _vendorRefTargetList.Count > 0)
            { sb.Append(c).Append("VendorRefTargetList"); }
            if (sb.Length > 0) { sb.Remove(0, c.Length).Insert(0, "(").Append(")"); }
            return sb.ToString();
        }
        #endregion

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        #region Accessor
        /// <summary>VENDOR_TARGET_ID: {PK, NotNull, NUMBER(16)}</summary>
        [Seasar.Dao.Attrs.Column("VENDOR_TARGET_ID")]
        public long? VendorTargetId {
            get { return _vendorTargetId; }
            set {
                __modifiedProperties.AddPropertyName("VendorTargetId");
                _vendorTargetId = value;
            }
        }

        /// <summary>VANDOR_TARGET_NAME: {VARCHAR2(256)}</summary>
        [Seasar.Dao.Attrs.Column("VANDOR_TARGET_NAME")]
        public String VandorTargetName {
            get { return _vandorTargetName; }
            set {
                __modifiedProperties.AddPropertyName("VandorTargetName");
                _vandorTargetName = value;
            }
        }

        #endregion
    }
}

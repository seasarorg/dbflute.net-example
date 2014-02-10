

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
    /// The entity of white_all_in_one_cls_ref as TABLE. (partial class for auto-generation)
    /// <![CDATA[
    /// [primary-key]
    ///     CLS_REF_ID
    /// 
    /// [column]
    ///     CLS_REF_ID, FOO_CODE, BAR_CODE, QUX_CODE
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
    ///     WHITE_ALL_IN_ONE_CLS(AsFoo)
    /// 
    /// [referrer-table]
    ///     
    /// 
    /// [foreign-property]
    ///     whiteAllInOneClsAsFoo, whiteAllInOneClsAsBar
    /// 
    /// [referrer-property]
    ///     
    /// ]]>
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    [Seasar.Dao.Attrs.Table("white_all_in_one_cls_ref")]
    [System.Serializable]
    public partial class WhiteAllInOneClsRef : Entity {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        #region Attribute
        /// <summary>CLS_REF_ID: {PK, NotNull, INT(10)}</summary>
        protected int? _clsRefId;

        /// <summary>FOO_CODE: {NotNull, CHAR(3), FK to WHITE_ALL_IN_ONE_CLS}</summary>
        protected String _fooCode;

        /// <summary>BAR_CODE: {NotNull, CHAR(3), FK to WHITE_ALL_IN_ONE_CLS}</summary>
        protected String _barCode;

        /// <summary>QUX_CODE: {NotNull, CHAR(3)}</summary>
        protected String _quxCode;

        protected EntityModifiedProperties __modifiedProperties = new EntityModifiedProperties();
        #endregion

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public String TableDbName { get { return "white_all_in_one_cls_ref"; } }
        public String TablePropertyName { get { return "WhiteAllInOneClsRef"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public DBMeta DBMeta { get { return DBMetaInstanceHandler.FindDBMeta(TableDbName); } }

        // ===============================================================================
        //                                                                Foreign Property
        //                                                                ================
        #region Foreign Property
        protected WhiteAllInOneCls _whiteAllInOneClsAsFoo;

        /// <summary>white_all_in_one_cls as 'WhiteAllInOneClsAsFoo'.</summary>
        [Seasar.Dao.Attrs.Relno(0), Seasar.Dao.Attrs.Relkeys("FOO_CODE:CLS_ELEMENT_CODE")]
        public WhiteAllInOneCls WhiteAllInOneClsAsFoo {
            get { return _whiteAllInOneClsAsFoo; }
            set { _whiteAllInOneClsAsFoo = value; }
        }

        protected WhiteAllInOneCls _whiteAllInOneClsAsBar;

        /// <summary>white_all_in_one_cls as 'WhiteAllInOneClsAsBar'.</summary>
        [Seasar.Dao.Attrs.Relno(1), Seasar.Dao.Attrs.Relkeys("BAR_CODE:CLS_ELEMENT_CODE")]
        public WhiteAllInOneCls WhiteAllInOneClsAsBar {
            get { return _whiteAllInOneClsAsBar; }
            set { _whiteAllInOneClsAsBar = value; }
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
                if (_clsRefId == null) { return false; }
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
            if (other == null || !(other is WhiteAllInOneClsRef)) { return false; }
            WhiteAllInOneClsRef otherEntity = (WhiteAllInOneClsRef)other;
            if (!xSV(this.ClsRefId, otherEntity.ClsRefId)) { return false; }
            return true;
        }
        protected bool xSV(Object value1, Object value2) { // isSameValue()
            if (value1 == null && value2 == null) { return true; }
            if (value1 == null || value2 == null) { return false; }
            return value1.Equals(value2);
        }

        public override int GetHashCode() {
            int result = 17;
            result = xCH(result, _clsRefId);
            return result;
        }
        protected int xCH(int result, Object value) { // calculateHashcode()
            if (value == null) { return result; }
            return (31*result) + (value is byte[] ? ((byte[])value).Length : value.GetHashCode());
        }

        public override String ToString() {
            return "WhiteAllInOneClsRef:" + BuildColumnString() + BuildRelationString();
        }

        public virtual String ToStringWithRelation() {
            StringBuilder sb = new StringBuilder();
            sb.Append(ToString());
            String l = "\n  ";
            if (_whiteAllInOneClsAsFoo != null)
            { sb.Append(l).Append(xbRDS(_whiteAllInOneClsAsFoo, "WhiteAllInOneClsAsFoo")); }
            if (_whiteAllInOneClsAsBar != null)
            { sb.Append(l).Append(xbRDS(_whiteAllInOneClsAsBar, "WhiteAllInOneClsAsBar")); }
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
            sb.Append(c).Append(this.ClsRefId);
            sb.Append(c).Append(this.FooCode);
            sb.Append(c).Append(this.BarCode);
            sb.Append(c).Append(this.QuxCode);
            if (sb.Length > 0) { sb.Remove(0, c.Length); }
            sb.Insert(0, "{").Append("}");
            return sb.ToString();
        }
        protected virtual String BuildRelationString() {
            StringBuilder sb = new StringBuilder();
            String c = ",";
            if (_whiteAllInOneClsAsFoo != null) { sb.Append(c).Append("WhiteAllInOneClsAsFoo"); }
            if (_whiteAllInOneClsAsBar != null) { sb.Append(c).Append("WhiteAllInOneClsAsBar"); }
            if (sb.Length > 0) { sb.Remove(0, c.Length).Insert(0, "(").Append(")"); }
            return sb.ToString();
        }
        #endregion

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        #region Accessor
        /// <summary>CLS_REF_ID: {PK, NotNull, INT(10)}</summary>
        [Seasar.Dao.Attrs.Column("CLS_REF_ID")]
        public int? ClsRefId {
            get { return _clsRefId; }
            set {
                __modifiedProperties.AddPropertyName("ClsRefId");
                _clsRefId = value;
            }
        }

        /// <summary>FOO_CODE: {NotNull, CHAR(3), FK to WHITE_ALL_IN_ONE_CLS}</summary>
        [Seasar.Dao.Attrs.Column("FOO_CODE")]
        public String FooCode {
            get { return _fooCode; }
            set {
                __modifiedProperties.AddPropertyName("FooCode");
                _fooCode = value;
            }
        }

        /// <summary>BAR_CODE: {NotNull, CHAR(3), FK to WHITE_ALL_IN_ONE_CLS}</summary>
        [Seasar.Dao.Attrs.Column("BAR_CODE")]
        public String BarCode {
            get { return _barCode; }
            set {
                __modifiedProperties.AddPropertyName("BarCode");
                _barCode = value;
            }
        }

        /// <summary>QUX_CODE: {NotNull, CHAR(3)}</summary>
        [Seasar.Dao.Attrs.Column("QUX_CODE")]
        public String QuxCode {
            get { return _quxCode; }
            set {
                __modifiedProperties.AddPropertyName("QuxCode");
                _quxCode = value;
            }
        }

        #endregion
    }
}

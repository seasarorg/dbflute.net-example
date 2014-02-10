

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
    /// The entity of white_all_in_one_cls as TABLE. (partial class for auto-generation)
    /// <![CDATA[
    /// [primary-key]
    ///     CLS_CATEGORY_CODE, CLS_ELEMENT_CODE
    /// 
    /// [column]
    ///     CLS_CATEGORY_CODE, CLS_ELEMENT_CODE, ATTRIBUTE_EXP
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
    ///     
    /// 
    /// [foreign-property]
    ///     
    /// 
    /// [referrer-property]
    ///     
    /// ]]>
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    [Seasar.Dao.Attrs.Table("white_all_in_one_cls")]
    [System.Serializable]
    public partial class WhiteAllInOneCls : Entity {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        #region Attribute
        /// <summary>CLS_CATEGORY_CODE: {PK, NotNull, CHAR(3)}</summary>
        protected String _clsCategoryCode;

        /// <summary>CLS_ELEMENT_CODE: {PK, NotNull, CHAR(3)}</summary>
        protected String _clsElementCode;

        /// <summary>ATTRIBUTE_EXP: {NotNull, TEXT(65535)}</summary>
        protected String _attributeExp;

        protected EntityModifiedProperties __modifiedProperties = new EntityModifiedProperties();
        #endregion

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public String TableDbName { get { return "white_all_in_one_cls"; } }
        public String TablePropertyName { get { return "WhiteAllInOneCls"; } }

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
        #endregion

        // ===============================================================================
        //                                                                   Determination
        //                                                                   =============
        public virtual bool HasPrimaryKeyValue {
            get {
                if (_clsCategoryCode == null) { return false; }
                if (_clsElementCode == null) { return false; }
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
            if (other == null || !(other is WhiteAllInOneCls)) { return false; }
            WhiteAllInOneCls otherEntity = (WhiteAllInOneCls)other;
            if (!xSV(this.ClsCategoryCode, otherEntity.ClsCategoryCode)) { return false; }
            if (!xSV(this.ClsElementCode, otherEntity.ClsElementCode)) { return false; }
            return true;
        }
        protected bool xSV(Object value1, Object value2) { // isSameValue()
            if (value1 == null && value2 == null) { return true; }
            if (value1 == null || value2 == null) { return false; }
            return value1.Equals(value2);
        }

        public override int GetHashCode() {
            int result = 17;
            result = xCH(result, _clsCategoryCode);
            result = xCH(result, _clsElementCode);
            return result;
        }
        protected int xCH(int result, Object value) { // calculateHashcode()
            if (value == null) { return result; }
            return (31*result) + (value is byte[] ? ((byte[])value).Length : value.GetHashCode());
        }

        public override String ToString() {
            return "WhiteAllInOneCls:" + BuildColumnString() + BuildRelationString();
        }

        public virtual String ToStringWithRelation() {
            StringBuilder sb = new StringBuilder();
            sb.Append(ToString());
            return sb.ToString();
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
            sb.Append(c).Append(this.ClsCategoryCode);
            sb.Append(c).Append(this.ClsElementCode);
            sb.Append(c).Append(this.AttributeExp);
            if (sb.Length > 0) { sb.Remove(0, c.Length); }
            sb.Insert(0, "{").Append("}");
            return sb.ToString();
        }
        protected virtual String BuildRelationString() {
            return "";
        }
        #endregion

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        #region Accessor
        /// <summary>CLS_CATEGORY_CODE: {PK, NotNull, CHAR(3)}</summary>
        [Seasar.Dao.Attrs.Column("CLS_CATEGORY_CODE")]
        public String ClsCategoryCode {
            get { return _clsCategoryCode; }
            set {
                __modifiedProperties.AddPropertyName("ClsCategoryCode");
                _clsCategoryCode = value;
            }
        }

        /// <summary>CLS_ELEMENT_CODE: {PK, NotNull, CHAR(3)}</summary>
        [Seasar.Dao.Attrs.Column("CLS_ELEMENT_CODE")]
        public String ClsElementCode {
            get { return _clsElementCode; }
            set {
                __modifiedProperties.AddPropertyName("ClsElementCode");
                _clsElementCode = value;
            }
        }

        /// <summary>ATTRIBUTE_EXP: {NotNull, TEXT(65535)}</summary>
        [Seasar.Dao.Attrs.Column("ATTRIBUTE_EXP")]
        public String AttributeExp {
            get { return _attributeExp; }
            set {
                __modifiedProperties.AddPropertyName("AttributeExp");
                _attributeExp = value;
            }
        }

        #endregion
    }
}

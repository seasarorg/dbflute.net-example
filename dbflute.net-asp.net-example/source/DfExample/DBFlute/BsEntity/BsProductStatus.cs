

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
    /// The entity of PRODUCT_STATUS as TABLE. (partial class for auto-generation)
    /// <![CDATA[
    /// 商品ステータス
    /// 
    /// [primary-key]
    ///     PRODUCT_STATUS_CODE
    /// 
    /// [column]
    ///     PRODUCT_STATUS_CODE, PRODUCT_STATUS_NAME
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
    ///     PRODUCT
    /// 
    /// [foreign-property]
    ///     
    /// 
    /// [referrer-property]
    ///     productList
    /// ]]>
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    [Seasar.Dao.Attrs.Table("PRODUCT_STATUS")]
    [System.Serializable]
    public partial class ProductStatus : Entity {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        #region Attribute
        /// <summary>PRODUCT_STATUS_CODE: {PK, NotNull, CHAR(3)}</summary>
        protected String _productStatusCode;

        /// <summary>PRODUCT_STATUS_NAME: {UQ, NotNull, VARCHAR2(50)}</summary>
        protected String _productStatusName;

        protected EntityModifiedProperties __modifiedProperties = new EntityModifiedProperties();
        #endregion

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public String TableDbName { get { return "PRODUCT_STATUS"; } }
        public String TablePropertyName { get { return "ProductStatus"; } }

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
        protected IList<Product> _productList;

        /// <summary>(商品)PRODUCT as 'ProductList'.</summary>
        public IList<Product> ProductList {
            get { if (_productList == null) { _productList = new List<Product>(); } return _productList; }
            set { _productList = value; }
        }

        #endregion

        // ===============================================================================
        //                                                                   Determination
        //                                                                   =============
        public virtual bool HasPrimaryKeyValue {
            get {
                if (_productStatusCode == null) { return false; }
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
            if (other == null || !(other is ProductStatus)) { return false; }
            ProductStatus otherEntity = (ProductStatus)other;
            if (!xSV(this.ProductStatusCode, otherEntity.ProductStatusCode)) { return false; }
            return true;
        }
        protected bool xSV(Object value1, Object value2) { // isSameValue()
            if (value1 == null && value2 == null) { return true; }
            if (value1 == null || value2 == null) { return false; }
            return value1.Equals(value2);
        }

        public override int GetHashCode() {
            int result = 17;
            result = xCH(result, _productStatusCode);
            return result;
        }
        protected int xCH(int result, Object value) { // calculateHashcode()
            if (value == null) { return result; }
            return (31*result) + (value is byte[] ? ((byte[])value).Length : value.GetHashCode());
        }

        public override String ToString() {
            return "ProductStatus:" + BuildColumnString() + BuildRelationString();
        }

        public virtual String ToStringWithRelation() {
            StringBuilder sb = new StringBuilder();
            sb.Append(ToString());
            String l = "\n  ";
            if (_productList != null) { foreach (Entity e in _productList)
            { if (e != null) { sb.Append(l).Append(xbRDS(e, "ProductList")); } } }
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
            sb.Append(c).Append(this.ProductStatusCode);
            sb.Append(c).Append(this.ProductStatusName);
            if (sb.Length > 0) { sb.Remove(0, c.Length); }
            sb.Insert(0, "{").Append("}");
            return sb.ToString();
        }
        protected virtual String BuildRelationString() {
            StringBuilder sb = new StringBuilder();
            String c = ",";
            if (_productList != null && _productList.Count > 0)
            { sb.Append(c).Append("ProductList"); }
            if (sb.Length > 0) { sb.Remove(0, c.Length).Insert(0, "(").Append(")"); }
            return sb.ToString();
        }
        #endregion

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        #region Accessor
        /// <summary>PRODUCT_STATUS_CODE: {PK, NotNull, CHAR(3)}</summary>
        [Seasar.Dao.Attrs.Column("PRODUCT_STATUS_CODE")]
        public String ProductStatusCode {
            get { return _productStatusCode; }
            set {
                __modifiedProperties.AddPropertyName("ProductStatusCode");
                _productStatusCode = value;
            }
        }

        /// <summary>PRODUCT_STATUS_NAME: {UQ, NotNull, VARCHAR2(50)}</summary>
        [Seasar.Dao.Attrs.Column("PRODUCT_STATUS_NAME")]
        public String ProductStatusName {
            get { return _productStatusName; }
            set {
                __modifiedProperties.AddPropertyName("ProductStatusName");
                _productStatusName = value;
            }
        }

        #endregion
    }
}

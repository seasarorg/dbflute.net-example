

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
    /// The entity of white_delimiter as TABLE. (partial class for auto-generation)
    /// <![CDATA[
    /// [primary-key]
    ///     DELIMITER_ID
    /// 
    /// [column]
    ///     DELIMITER_ID, NUMBER_NULLABLE, STRING_CONVERTED, STRING_NON_CONVERTED, DATE_DEFAULT
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
    [Seasar.Dao.Attrs.Table("white_delimiter")]
    [System.Serializable]
    public partial class WhiteDelimiter : Entity {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        #region Attribute
        /// <summary>DELIMITER_ID: {PK, NotNull, DECIMAL(16)}</summary>
        protected long? _delimiterId;

        /// <summary>NUMBER_NULLABLE: {INT(10)}</summary>
        protected int? _numberNullable;

        /// <summary>STRING_CONVERTED: {NotNull, VARCHAR(200)}</summary>
        protected String _stringConverted;

        /// <summary>STRING_NON_CONVERTED: {VARCHAR(200)}</summary>
        protected String _stringNonConverted;

        /// <summary>DATE_DEFAULT: {NotNull, DATE(10)}</summary>
        protected DateTime? _dateDefault;

        protected EntityModifiedProperties __modifiedProperties = new EntityModifiedProperties();
        #endregion

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public String TableDbName { get { return "white_delimiter"; } }
        public String TablePropertyName { get { return "WhiteDelimiter"; } }

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
                if (_delimiterId == null) { return false; }
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
            if (other == null || !(other is WhiteDelimiter)) { return false; }
            WhiteDelimiter otherEntity = (WhiteDelimiter)other;
            if (!xSV(this.DelimiterId, otherEntity.DelimiterId)) { return false; }
            return true;
        }
        protected bool xSV(Object value1, Object value2) { // isSameValue()
            if (value1 == null && value2 == null) { return true; }
            if (value1 == null || value2 == null) { return false; }
            return value1.Equals(value2);
        }

        public override int GetHashCode() {
            int result = 17;
            result = xCH(result, _delimiterId);
            return result;
        }
        protected int xCH(int result, Object value) { // calculateHashcode()
            if (value == null) { return result; }
            return (31*result) + (value is byte[] ? ((byte[])value).Length : value.GetHashCode());
        }

        public override String ToString() {
            return "WhiteDelimiter:" + BuildColumnString() + BuildRelationString();
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
            sb.Append(c).Append(this.DelimiterId);
            sb.Append(c).Append(this.NumberNullable);
            sb.Append(c).Append(this.StringConverted);
            sb.Append(c).Append(this.StringNonConverted);
            sb.Append(c).Append(this.DateDefault);
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
        /// <summary>DELIMITER_ID: {PK, NotNull, DECIMAL(16)}</summary>
        [Seasar.Dao.Attrs.Column("DELIMITER_ID")]
        public long? DelimiterId {
            get { return _delimiterId; }
            set {
                __modifiedProperties.AddPropertyName("DelimiterId");
                _delimiterId = value;
            }
        }

        /// <summary>NUMBER_NULLABLE: {INT(10)}</summary>
        [Seasar.Dao.Attrs.Column("NUMBER_NULLABLE")]
        public int? NumberNullable {
            get { return _numberNullable; }
            set {
                __modifiedProperties.AddPropertyName("NumberNullable");
                _numberNullable = value;
            }
        }

        /// <summary>STRING_CONVERTED: {NotNull, VARCHAR(200)}</summary>
        [Seasar.Dao.Attrs.Column("STRING_CONVERTED")]
        public String StringConverted {
            get { return _stringConverted; }
            set {
                __modifiedProperties.AddPropertyName("StringConverted");
                _stringConverted = value;
            }
        }

        /// <summary>STRING_NON_CONVERTED: {VARCHAR(200)}</summary>
        [Seasar.Dao.Attrs.Column("STRING_NON_CONVERTED")]
        public String StringNonConverted {
            get { return _stringNonConverted; }
            set {
                __modifiedProperties.AddPropertyName("StringNonConverted");
                _stringNonConverted = value;
            }
        }

        /// <summary>DATE_DEFAULT: {NotNull, DATE(10)}</summary>
        [Seasar.Dao.Attrs.Column("DATE_DEFAULT")]
        public DateTime? DateDefault {
            get { return _dateDefault; }
            set {
                __modifiedProperties.AddPropertyName("DateDefault");
                _dateDefault = value;
            }
        }

        #endregion
    }
}

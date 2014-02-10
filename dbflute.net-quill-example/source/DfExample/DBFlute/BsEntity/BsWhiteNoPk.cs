

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
    /// The entity of white_no_pk as TABLE. (partial class for auto-generation)
    /// <![CDATA[
    /// [primary-key]
    ///     
    /// 
    /// [column]
    ///     NO_PK_ID, NO_PK_NAME, NO_PK_INTEGER
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
    [Seasar.Dao.Attrs.Table("white_no_pk")]
    [System.Serializable]
    public partial class WhiteNoPk : Entity {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        #region Attribute
        /// <summary>NO_PK_ID: {NotNull, DECIMAL(16)}</summary>
        protected long? _noPkId;

        /// <summary>NO_PK_NAME: {VARCHAR(32)}</summary>
        protected String _noPkName;

        /// <summary>NO_PK_INTEGER: {INT(10)}</summary>
        protected int? _noPkInteger;

        protected EntityModifiedProperties __modifiedProperties = new EntityModifiedProperties();
        #endregion

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public String TableDbName { get { return "white_no_pk"; } }
        public String TablePropertyName { get { return "WhiteNoPk"; } }

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
                return false;
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
            if (other == null || !(other is WhiteNoPk)) { return false; }
            WhiteNoPk otherEntity = (WhiteNoPk)other;
            if (!xSV(this.NoPkId, otherEntity.NoPkId)) { return false; }
            if (!xSV(this.NoPkName, otherEntity.NoPkName)) { return false; }
            if (!xSV(this.NoPkInteger, otherEntity.NoPkInteger)) { return false; }
            return true;
        }
        protected bool xSV(Object value1, Object value2) { // isSameValue()
            if (value1 == null && value2 == null) { return true; }
            if (value1 == null || value2 == null) { return false; }
            return value1.Equals(value2);
        }

        public override int GetHashCode() {
            int result = 17;
            result = xCH(result, _noPkId);
            result = xCH(result, _noPkName);
            result = xCH(result, _noPkInteger);
            return result;
        }
        protected int xCH(int result, Object value) { // calculateHashcode()
            if (value == null) { return result; }
            return (31*result) + (value is byte[] ? ((byte[])value).Length : value.GetHashCode());
        }

        public override String ToString() {
            return "WhiteNoPk:" + BuildColumnString() + BuildRelationString();
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
            sb.Append(c).Append(this.NoPkId);
            sb.Append(c).Append(this.NoPkName);
            sb.Append(c).Append(this.NoPkInteger);
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
        /// <summary>NO_PK_ID: {NotNull, DECIMAL(16)}</summary>
        [Seasar.Dao.Attrs.Column("NO_PK_ID")]
        public long? NoPkId {
            get { return _noPkId; }
            set {
                __modifiedProperties.AddPropertyName("NoPkId");
                _noPkId = value;
            }
        }

        /// <summary>NO_PK_NAME: {VARCHAR(32)}</summary>
        [Seasar.Dao.Attrs.Column("NO_PK_NAME")]
        public String NoPkName {
            get { return _noPkName; }
            set {
                __modifiedProperties.AddPropertyName("NoPkName");
                _noPkName = value;
            }
        }

        /// <summary>NO_PK_INTEGER: {INT(10)}</summary>
        [Seasar.Dao.Attrs.Column("NO_PK_INTEGER")]
        public int? NoPkInteger {
            get { return _noPkInteger; }
            set {
                __modifiedProperties.AddPropertyName("NoPkInteger");
                _noPkInteger = value;
            }
        }

        #endregion
    }
}

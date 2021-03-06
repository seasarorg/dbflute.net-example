

using System;
using System.Reflection;
using System.Collections.Generic;
using System.Text;

using DfExample.DBFlute.AllCommon;
using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.Dbm;
using DfExample.DBFlute.AllCommon.Helper;
using DfExample.DBFlute.ExEntity.Customize;
using DfExample.DBFlute.BsEntity.Customize.Dbm;


namespace DfExample.DBFlute.ExEntity.Customize {

    /// <summary>
    /// The entity of NotEmbedded. (partial class for auto-generation)
    /// <![CDATA[
    /// [primary-key]
    ///     
    /// 
    /// [column]
    ///     MEMBER_ID, MEMBER_NAME, MEMBER_STATUS_NAME
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
    [Seasar.Dao.Attrs.Table("NotEmbedded")]
    [System.Serializable]
    public partial class NotEmbedded : Entity {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        #region Attribute
        /// <summary>(会員ID)MEMBER_ID: {INT(11), refers to member.MEMBER_ID}</summary>
        protected int? _memberId;

        /// <summary>(会員名称)MEMBER_NAME: {VARCHAR(200), refers to member.MEMBER_NAME}</summary>
        protected String _memberName;

        /// <summary>MEMBER_STATUS_NAME: {VARCHAR(50), refers to member_status.MEMBER_STATUS_NAME}</summary>
        protected String _memberStatusName;

        protected EntityModifiedProperties __modifiedProperties = new EntityModifiedProperties();
        #endregion

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public String TableDbName { get { return "NotEmbedded"; } }
        public String TablePropertyName { get { return "NotEmbedded"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public DBMeta DBMeta { get { return NotEmbeddedDbm.GetInstance(); } }

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
            if (other == null || !(other is NotEmbedded)) { return false; }
            NotEmbedded otherEntity = (NotEmbedded)other;
            if (!xSV(this.MemberId, otherEntity.MemberId)) { return false; }
            if (!xSV(this.MemberName, otherEntity.MemberName)) { return false; }
            if (!xSV(this.MemberStatusName, otherEntity.MemberStatusName)) { return false; }
            return true;
        }
        protected bool xSV(Object value1, Object value2) { // isSameValue()
            if (value1 == null && value2 == null) { return true; }
            if (value1 == null || value2 == null) { return false; }
            return value1.Equals(value2);
        }

        public override int GetHashCode() {
            int result = 17;
            result = xCH(result, _memberId);
            result = xCH(result, _memberName);
            result = xCH(result, _memberStatusName);
            return result;
        }
        protected int xCH(int result, Object value) { // calculateHashcode()
            if (value == null) { return result; }
            return (31*result) + (value is byte[] ? ((byte[])value).Length : value.GetHashCode());
        }

        public override String ToString() {
            return "NotEmbedded:" + BuildColumnString() + BuildRelationString();
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
            sb.Append(c).Append(this.MemberId);
            sb.Append(c).Append(this.MemberName);
            sb.Append(c).Append(this.MemberStatusName);
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
        /// <summary>(会員ID)MEMBER_ID: {INT(11), refers to member.MEMBER_ID}</summary>
        /// <remarks>
        /// 連番
        /// </remarks>
        [Seasar.Dao.Attrs.Column("MEMBER_ID")]
        public int? MemberId {
            get { return _memberId; }
            set {
                __modifiedProperties.AddPropertyName("MemberId");
                _memberId = value;
            }
        }

        /// <summary>(会員名称)MEMBER_NAME: {VARCHAR(200), refers to member.MEMBER_NAME}</summary>
        /// <remarks>
        /// 会員の表示用の名称(姓名)
        /// </remarks>
        [Seasar.Dao.Attrs.Column("MEMBER_NAME")]
        public String MemberName {
            get { return _memberName; }
            set {
                __modifiedProperties.AddPropertyName("MemberName");
                _memberName = value;
            }
        }

        /// <summary>MEMBER_STATUS_NAME: {VARCHAR(50), refers to member_status.MEMBER_STATUS_NAME}</summary>
        [Seasar.Dao.Attrs.Column("MEMBER_STATUS_NAME")]
        public String MemberStatusName {
            get { return _memberStatusName; }
            set {
                __modifiedProperties.AddPropertyName("MemberStatusName");
                _memberStatusName = value;
            }
        }

        #endregion
    }
}

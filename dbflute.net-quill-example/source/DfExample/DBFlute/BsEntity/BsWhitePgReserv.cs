

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
    /// The entity of white_pg_reserv as TABLE. (partial class for auto-generation)
    /// <![CDATA[
    /// [primary-key]
    ///     CLASS
    /// 
    /// [column]
    ///     CLASS, CASE, PACKAGE, DEFAULT, NEW, NATIVE, VOID, PUBLIC, PROTECTED, PRIVATE, INTERFACE, ABSTRACT, FINAL, FINALLY, RETURN, DOUBLE, FLOAT, SHORT, TYPE, RESERV_NAME
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
    ///     white_pg_reserv_ref
    /// 
    /// [foreign-property]
    ///     
    /// 
    /// [referrer-property]
    ///     whitePgReservRefList
    /// ]]>
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    [Seasar.Dao.Attrs.Table("white_pg_reserv")]
    [System.Serializable]
    public partial class WhitePgReserv : Entity {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        #region Attribute
        /// <summary>CLASS: {PK, NotNull, INT(10)}</summary>
        protected int? _classSynonym;

        /// <summary>CASE: {INT(10)}</summary>
        protected int? _case;

        /// <summary>PACKAGE: {INT(10)}</summary>
        protected int? _package;

        /// <summary>DEFAULT: {INT(10)}</summary>
        protected int? _default;

        /// <summary>NEW: {INT(10)}</summary>
        protected int? _new;

        /// <summary>NATIVE: {INT(10)}</summary>
        protected int? _native;

        /// <summary>VOID: {INT(10)}</summary>
        protected int? _void;

        /// <summary>PUBLIC: {INT(10)}</summary>
        protected int? _public;

        /// <summary>PROTECTED: {INT(10)}</summary>
        protected int? _protected;

        /// <summary>PRIVATE: {INT(10)}</summary>
        protected int? _private;

        /// <summary>INTERFACE: {INT(10)}</summary>
        protected int? _interface;

        /// <summary>ABSTRACT: {INT(10)}</summary>
        protected int? _abstract;

        /// <summary>FINAL: {INT(10)}</summary>
        protected int? _final;

        /// <summary>FINALLY: {INT(10)}</summary>
        protected int? _finally;

        /// <summary>RETURN: {INT(10)}</summary>
        protected int? _return;

        /// <summary>DOUBLE: {INT(10)}</summary>
        protected int? _double;

        /// <summary>FLOAT: {INT(10)}</summary>
        protected int? _float;

        /// <summary>SHORT: {INT(10)}</summary>
        protected int? _short;

        /// <summary>TYPE: {CHAR(3)}</summary>
        protected String _type;

        /// <summary>RESERV_NAME: {NotNull, VARCHAR(32)}</summary>
        protected String _reservName;

        protected EntityModifiedProperties __modifiedProperties = new EntityModifiedProperties();
        #endregion

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public String TableDbName { get { return "white_pg_reserv"; } }
        public String TablePropertyName { get { return "WhitePgReserv"; } }

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
        protected IList<WhitePgReservRef> _whitePgReservRefList;

        /// <summary>white_pg_reserv_ref as 'WhitePgReservRefList'.</summary>
        public IList<WhitePgReservRef> WhitePgReservRefList {
            get { if (_whitePgReservRefList == null) { _whitePgReservRefList = new List<WhitePgReservRef>(); } return _whitePgReservRefList; }
            set { _whitePgReservRefList = value; }
        }

        #endregion

        // ===============================================================================
        //                                                                   Determination
        //                                                                   =============
        public virtual bool HasPrimaryKeyValue {
            get {
                if (_classSynonym == null) { return false; }
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
            if (other == null || !(other is WhitePgReserv)) { return false; }
            WhitePgReserv otherEntity = (WhitePgReserv)other;
            if (!xSV(this.ClassSynonym, otherEntity.ClassSynonym)) { return false; }
            return true;
        }
        protected bool xSV(Object value1, Object value2) { // isSameValue()
            if (value1 == null && value2 == null) { return true; }
            if (value1 == null || value2 == null) { return false; }
            return value1.Equals(value2);
        }

        public override int GetHashCode() {
            int result = 17;
            result = xCH(result, _classSynonym);
            return result;
        }
        protected int xCH(int result, Object value) { // calculateHashcode()
            if (value == null) { return result; }
            return (31*result) + (value is byte[] ? ((byte[])value).Length : value.GetHashCode());
        }

        public override String ToString() {
            return "WhitePgReserv:" + BuildColumnString() + BuildRelationString();
        }

        public virtual String ToStringWithRelation() {
            StringBuilder sb = new StringBuilder();
            sb.Append(ToString());
            String l = "\n  ";
            if (_whitePgReservRefList != null) { foreach (Entity e in _whitePgReservRefList)
            { if (e != null) { sb.Append(l).Append(xbRDS(e, "WhitePgReservRefList")); } } }
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
            sb.Append(c).Append(this.ClassSynonym);
            sb.Append(c).Append(this.Case);
            sb.Append(c).Append(this.Package);
            sb.Append(c).Append(this.Default);
            sb.Append(c).Append(this.New);
            sb.Append(c).Append(this.Native);
            sb.Append(c).Append(this.Void);
            sb.Append(c).Append(this.Public);
            sb.Append(c).Append(this.Protected);
            sb.Append(c).Append(this.Private);
            sb.Append(c).Append(this.Interface);
            sb.Append(c).Append(this.Abstract);
            sb.Append(c).Append(this.Final);
            sb.Append(c).Append(this.Finally);
            sb.Append(c).Append(this.Return);
            sb.Append(c).Append(this.Double);
            sb.Append(c).Append(this.Float);
            sb.Append(c).Append(this.Short);
            sb.Append(c).Append(this.Type);
            sb.Append(c).Append(this.ReservName);
            if (sb.Length > 0) { sb.Remove(0, c.Length); }
            sb.Insert(0, "{").Append("}");
            return sb.ToString();
        }
        protected virtual String BuildRelationString() {
            StringBuilder sb = new StringBuilder();
            String c = ",";
            if (_whitePgReservRefList != null && _whitePgReservRefList.Count > 0)
            { sb.Append(c).Append("WhitePgReservRefList"); }
            if (sb.Length > 0) { sb.Remove(0, c.Length).Insert(0, "(").Append(")"); }
            return sb.ToString();
        }
        #endregion

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        #region Accessor
        /// <summary>CLASS: {PK, NotNull, INT(10)}</summary>
        /// <remarks>
        /// (using DBFlute synonym)
        /// </remarks>
        [Seasar.Dao.Attrs.Column("CLASS")]
        public int? ClassSynonym {
            get { return _classSynonym; }
            set {
                __modifiedProperties.AddPropertyName("ClassSynonym");
                _classSynonym = value;
            }
        }

        /// <summary>CASE: {INT(10)}</summary>
        [Seasar.Dao.Attrs.Column("`CASE`")]
        public int? Case {
            get { return _case; }
            set {
                __modifiedProperties.AddPropertyName("Case");
                _case = value;
            }
        }

        /// <summary>PACKAGE: {INT(10)}</summary>
        [Seasar.Dao.Attrs.Column("PACKAGE")]
        public int? Package {
            get { return _package; }
            set {
                __modifiedProperties.AddPropertyName("Package");
                _package = value;
            }
        }

        /// <summary>DEFAULT: {INT(10)}</summary>
        [Seasar.Dao.Attrs.Column("`DEFAULT`")]
        public int? Default {
            get { return _default; }
            set {
                __modifiedProperties.AddPropertyName("Default");
                _default = value;
            }
        }

        /// <summary>NEW: {INT(10)}</summary>
        [Seasar.Dao.Attrs.Column("NEW")]
        public int? New {
            get { return _new; }
            set {
                __modifiedProperties.AddPropertyName("New");
                _new = value;
            }
        }

        /// <summary>NATIVE: {INT(10)}</summary>
        [Seasar.Dao.Attrs.Column("NATIVE")]
        public int? Native {
            get { return _native; }
            set {
                __modifiedProperties.AddPropertyName("Native");
                _native = value;
            }
        }

        /// <summary>VOID: {INT(10)}</summary>
        [Seasar.Dao.Attrs.Column("VOID")]
        public int? Void {
            get { return _void; }
            set {
                __modifiedProperties.AddPropertyName("Void");
                _void = value;
            }
        }

        /// <summary>PUBLIC: {INT(10)}</summary>
        [Seasar.Dao.Attrs.Column("PUBLIC")]
        public int? Public {
            get { return _public; }
            set {
                __modifiedProperties.AddPropertyName("Public");
                _public = value;
            }
        }

        /// <summary>PROTECTED: {INT(10)}</summary>
        [Seasar.Dao.Attrs.Column("PROTECTED")]
        public int? Protected {
            get { return _protected; }
            set {
                __modifiedProperties.AddPropertyName("Protected");
                _protected = value;
            }
        }

        /// <summary>PRIVATE: {INT(10)}</summary>
        [Seasar.Dao.Attrs.Column("PRIVATE")]
        public int? Private {
            get { return _private; }
            set {
                __modifiedProperties.AddPropertyName("Private");
                _private = value;
            }
        }

        /// <summary>INTERFACE: {INT(10)}</summary>
        [Seasar.Dao.Attrs.Column("INTERFACE")]
        public int? Interface {
            get { return _interface; }
            set {
                __modifiedProperties.AddPropertyName("Interface");
                _interface = value;
            }
        }

        /// <summary>ABSTRACT: {INT(10)}</summary>
        [Seasar.Dao.Attrs.Column("ABSTRACT")]
        public int? Abstract {
            get { return _abstract; }
            set {
                __modifiedProperties.AddPropertyName("Abstract");
                _abstract = value;
            }
        }

        /// <summary>FINAL: {INT(10)}</summary>
        [Seasar.Dao.Attrs.Column("FINAL")]
        public int? Final {
            get { return _final; }
            set {
                __modifiedProperties.AddPropertyName("Final");
                _final = value;
            }
        }

        /// <summary>FINALLY: {INT(10)}</summary>
        [Seasar.Dao.Attrs.Column("FINALLY")]
        public int? Finally {
            get { return _finally; }
            set {
                __modifiedProperties.AddPropertyName("Finally");
                _finally = value;
            }
        }

        /// <summary>RETURN: {INT(10)}</summary>
        [Seasar.Dao.Attrs.Column("`RETURN`")]
        public int? Return {
            get { return _return; }
            set {
                __modifiedProperties.AddPropertyName("Return");
                _return = value;
            }
        }

        /// <summary>DOUBLE: {INT(10)}</summary>
        [Seasar.Dao.Attrs.Column("`DOUBLE`")]
        public int? Double {
            get { return _double; }
            set {
                __modifiedProperties.AddPropertyName("Double");
                _double = value;
            }
        }

        /// <summary>FLOAT: {INT(10)}</summary>
        [Seasar.Dao.Attrs.Column("`FLOAT`")]
        public int? Float {
            get { return _float; }
            set {
                __modifiedProperties.AddPropertyName("Float");
                _float = value;
            }
        }

        /// <summary>SHORT: {INT(10)}</summary>
        [Seasar.Dao.Attrs.Column("SHORT")]
        public int? Short {
            get { return _short; }
            set {
                __modifiedProperties.AddPropertyName("Short");
                _short = value;
            }
        }

        /// <summary>TYPE: {CHAR(3)}</summary>
        [Seasar.Dao.Attrs.Column("TYPE")]
        public String Type {
            get { return _type; }
            set {
                __modifiedProperties.AddPropertyName("Type");
                _type = value;
            }
        }

        /// <summary>RESERV_NAME: {NotNull, VARCHAR(32)}</summary>
        [Seasar.Dao.Attrs.Column("RESERV_NAME")]
        public String ReservName {
            get { return _reservName; }
            set {
                __modifiedProperties.AddPropertyName("ReservName");
                _reservName = value;
            }
        }

        #endregion
    }
}

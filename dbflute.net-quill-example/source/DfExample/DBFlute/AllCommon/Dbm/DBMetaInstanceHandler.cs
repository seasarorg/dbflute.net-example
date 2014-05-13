
using System;
using System.Reflection;

using DfExample.DBFlute.AllCommon.JavaLike;
using DfExample.DBFlute.AllCommon.Util;

namespace DfExample.DBFlute.AllCommon.Dbm {

    public interface DBMetaProvider {
        DBMeta provideDBMeta(String tableFlexibleName);
        DBMeta provideDBMetaChecked(String tableFlexibleName);
    }

    public class DBMetaInstanceHandler : DBMetaProvider {

        // ===============================================================================
        //                                                                    Resource Map
        //                                                                    ============
        protected static readonly Map<String, DBMeta> _tableDbNameInstanceMap = new HashMap<String, DBMeta>();
        protected static readonly Map<String, String> _tableDbNameClassNameMap;
        protected static readonly Map<String, String> _tableDbNamePropertyNameKeyToLowerMap;
        protected static readonly Map<String, String> _tablePropertyNameDbNameKeyToLowerMap;

        static DBMetaInstanceHandler() {
            {
                Map<String, String> tmpMap = new HashMap<String, String>();
                tmpMap.put("member", "DfExample.DBFlute.BsEntity.Dbm.MemberDbm");
                tmpMap.put("member_address", "DfExample.DBFlute.BsEntity.Dbm.MemberAddressDbm");
                tmpMap.put("member_login", "DfExample.DBFlute.BsEntity.Dbm.MemberLoginDbm");
                tmpMap.put("member_security", "DfExample.DBFlute.BsEntity.Dbm.MemberSecurityDbm");
                tmpMap.put("member_status", "DfExample.DBFlute.BsEntity.Dbm.MemberStatusDbm");
                tmpMap.put("member_withdrawal", "DfExample.DBFlute.BsEntity.Dbm.MemberWithdrawalDbm");
                tmpMap.put("myself", "DfExample.DBFlute.BsEntity.Dbm.MyselfDbm");
                tmpMap.put("myself_check", "DfExample.DBFlute.BsEntity.Dbm.MyselfCheckDbm");
                tmpMap.put("product", "DfExample.DBFlute.BsEntity.Dbm.ProductDbm");
                tmpMap.put("product_status", "DfExample.DBFlute.BsEntity.Dbm.ProductStatusDbm");
                tmpMap.put("purchase", "DfExample.DBFlute.BsEntity.Dbm.PurchaseDbm");
                tmpMap.put("summary_product", "DfExample.DBFlute.BsEntity.Dbm.SummaryProductDbm");
                tmpMap.put("vendor_check", "DfExample.DBFlute.BsEntity.Dbm.VendorCheckDbm");
                tmpMap.put("vendor_self_reference", "DfExample.DBFlute.BsEntity.Dbm.VendorSelfReferenceDbm");
                tmpMap.put("vendor_token", "DfExample.DBFlute.BsEntity.Dbm.VendorTokenDbm");
                tmpMap.put("white_all_in_one_cls", "DfExample.DBFlute.BsEntity.Dbm.WhiteAllInOneClsDbm");
                tmpMap.put("white_all_in_one_cls_ref", "DfExample.DBFlute.BsEntity.Dbm.WhiteAllInOneClsRefDbm");
                tmpMap.put("white_column_except", "DfExample.DBFlute.BsEntity.Dbm.WhiteColumnExceptDbm");
                tmpMap.put("white_compound_pk", "DfExample.DBFlute.BsEntity.Dbm.WhiteCompoundPkDbm");
                tmpMap.put("white_compound_pk_ref", "DfExample.DBFlute.BsEntity.Dbm.WhiteCompoundPkRefDbm");
                tmpMap.put("white_compound_pk_ref_nest", "DfExample.DBFlute.BsEntity.Dbm.WhiteCompoundPkRefNestDbm");
                tmpMap.put("white_delimiter", "DfExample.DBFlute.BsEntity.Dbm.WhiteDelimiterDbm");
                tmpMap.put("white_myself", "DfExample.DBFlute.BsEntity.Dbm.WhiteMyselfDbm");
                tmpMap.put("white_myself_check", "DfExample.DBFlute.BsEntity.Dbm.WhiteMyselfCheckDbm");
                tmpMap.put("white_no_pk", "DfExample.DBFlute.BsEntity.Dbm.WhiteNoPkDbm");
                tmpMap.put("white_pg_reserv", "DfExample.DBFlute.BsEntity.Dbm.WhitePgReservDbm");
                tmpMap.put("white_pg_reserv_ref", "DfExample.DBFlute.BsEntity.Dbm.WhitePgReservRefDbm");
                tmpMap.put("white_quoted", "DfExample.DBFlute.BsEntity.Dbm.WhiteQuotedDbm");
                tmpMap.put("white_self_reference", "DfExample.DBFlute.BsEntity.Dbm.WhiteSelfReferenceDbm");
                tmpMap.put("withdrawal_reason", "DfExample.DBFlute.BsEntity.Dbm.WithdrawalReasonDbm");
                _tableDbNameClassNameMap = tmpMap;//java.util.Collections.unmodifiableMap(tmpMap);
            }

            {
                Map<String, String> tmpMap = new HashMap<String, String>();
                tmpMap.put("member".ToLower(), "member");
                tmpMap.put("member_address".ToLower(), "memberAddress");
                tmpMap.put("member_login".ToLower(), "memberLogin");
                tmpMap.put("member_security".ToLower(), "memberSecurity");
                tmpMap.put("member_status".ToLower(), "memberStatus");
                tmpMap.put("member_withdrawal".ToLower(), "memberWithdrawal");
                tmpMap.put("myself".ToLower(), "myself");
                tmpMap.put("myself_check".ToLower(), "myselfCheck");
                tmpMap.put("product".ToLower(), "product");
                tmpMap.put("product_status".ToLower(), "productStatus");
                tmpMap.put("purchase".ToLower(), "purchase");
                tmpMap.put("summary_product".ToLower(), "summaryProduct");
                tmpMap.put("vendor_check".ToLower(), "vendorCheck");
                tmpMap.put("vendor_self_reference".ToLower(), "vendorSelfReference");
                tmpMap.put("vendor_token".ToLower(), "vendorToken");
                tmpMap.put("white_all_in_one_cls".ToLower(), "whiteAllInOneCls");
                tmpMap.put("white_all_in_one_cls_ref".ToLower(), "whiteAllInOneClsRef");
                tmpMap.put("white_column_except".ToLower(), "whiteColumnExcept");
                tmpMap.put("white_compound_pk".ToLower(), "whiteCompoundPk");
                tmpMap.put("white_compound_pk_ref".ToLower(), "whiteCompoundPkRef");
                tmpMap.put("white_compound_pk_ref_nest".ToLower(), "whiteCompoundPkRefNest");
                tmpMap.put("white_delimiter".ToLower(), "whiteDelimiter");
                tmpMap.put("white_myself".ToLower(), "whiteMyself");
                tmpMap.put("white_myself_check".ToLower(), "whiteMyselfCheck");
                tmpMap.put("white_no_pk".ToLower(), "whiteNoPk");
                tmpMap.put("white_pg_reserv".ToLower(), "whitePgReserv");
                tmpMap.put("white_pg_reserv_ref".ToLower(), "whitePgReservRef");
                tmpMap.put("white_quoted".ToLower(), "whiteQuoted");
                tmpMap.put("white_self_reference".ToLower(), "whiteSelfReference");
                tmpMap.put("withdrawal_reason".ToLower(), "withdrawalReason");
                _tableDbNamePropertyNameKeyToLowerMap = tmpMap;//java.util.Collections.unmodifiableMap(tmpMap);
            }

            {
                Map<String, String> tmpMap = new HashMap<String, String>();
                tmpMap.put("Member".ToLower(), "member");
                tmpMap.put("MemberAddress".ToLower(), "member_address");
                tmpMap.put("MemberLogin".ToLower(), "member_login");
                tmpMap.put("MemberSecurity".ToLower(), "member_security");
                tmpMap.put("MemberStatus".ToLower(), "member_status");
                tmpMap.put("MemberWithdrawal".ToLower(), "member_withdrawal");
                tmpMap.put("Myself".ToLower(), "myself");
                tmpMap.put("MyselfCheck".ToLower(), "myself_check");
                tmpMap.put("Product".ToLower(), "product");
                tmpMap.put("ProductStatus".ToLower(), "product_status");
                tmpMap.put("Purchase".ToLower(), "purchase");
                tmpMap.put("SummaryProduct".ToLower(), "summary_product");
                tmpMap.put("VendorCheck".ToLower(), "vendor_check");
                tmpMap.put("VendorSelfReference".ToLower(), "vendor_self_reference");
                tmpMap.put("VendorToken".ToLower(), "vendor_token");
                tmpMap.put("WhiteAllInOneCls".ToLower(), "white_all_in_one_cls");
                tmpMap.put("WhiteAllInOneClsRef".ToLower(), "white_all_in_one_cls_ref");
                tmpMap.put("WhiteColumnExcept".ToLower(), "white_column_except");
                tmpMap.put("WhiteCompoundPk".ToLower(), "white_compound_pk");
                tmpMap.put("WhiteCompoundPkRef".ToLower(), "white_compound_pk_ref");
                tmpMap.put("WhiteCompoundPkRefNest".ToLower(), "white_compound_pk_ref_nest");
                tmpMap.put("WhiteDelimiter".ToLower(), "white_delimiter");
                tmpMap.put("WhiteMyself".ToLower(), "white_myself");
                tmpMap.put("WhiteMyselfCheck".ToLower(), "white_myself_check");
                tmpMap.put("WhiteNoPk".ToLower(), "white_no_pk");
                tmpMap.put("WhitePgReserv".ToLower(), "white_pg_reserv");
                tmpMap.put("WhitePgReservRef".ToLower(), "white_pg_reserv_ref");
                tmpMap.put("WhiteQuoted".ToLower(), "white_quoted");
                tmpMap.put("WhiteSelfReference".ToLower(), "white_self_reference");
                tmpMap.put("WithdrawalReason".ToLower(), "withdrawal_reason");
                _tablePropertyNameDbNameKeyToLowerMap = tmpMap;//java.util.Collections.unmodifiableMap(tmpMap);
            }
        }

        protected static DBMeta GetDBMeta(String className) {
			Type clazz = ForName(className, AppDomain.CurrentDomain.GetAssemblies());
            if (clazz == null) {
                String msg = "The className was not found: " + className + " assemblys=";
                msg = msg + Seasar.Framework.Util.ToStringUtil.ToString(AppDomain.CurrentDomain.GetAssemblies());
                throw new SystemException(msg);
            }
            System.Reflection.MethodInfo method = clazz.GetMethod("GetInstance");
            return (DBMeta)method.Invoke(null, null);
        }

        protected static Type ForName(string className, Assembly[] assemblys) {
            Type type = Type.GetType(className);
            if(type != null) return type;
            foreach(Assembly assembly in assemblys) {
                type = assembly.GetType(className);
                if(type != null) return type;
            }
            return type;
        }

        // Returns the unmodifiable map that contains all instances of DB meta. (NotNull & NotEmpty)
        public static Map<String, DBMeta> GetUnmodifiableDBMetaMap() {
            InitializeDBMetaMap();
            lock (_tableDbNameInstanceMap) {
                Map<String, DBMeta> copiedMap = new HashMap<String, DBMeta>();
                foreach (String tableDbName in _tableDbNameInstanceMap.keySet()) {
                    copiedMap.put(tableDbName, _tableDbNameInstanceMap.get(tableDbName));
                }
                return copiedMap;
            }
        }

        protected static void InitializeDBMetaMap() {
            if (IsInitialized) {
                return;
            }
            lock (_tableDbNameInstanceMap) {
                Set<String> tableDbNameSet = _tableDbNameClassNameMap.keySet();
                foreach (String tableDbName in tableDbNameSet) {
                    FindDBMeta(tableDbName); // Initialize!
                }
                if (!IsInitialized) {
                    String msg = "Failed to initialize tableDbNameInstanceMap:";
                    msg = msg + " tableDbNameInstanceMap=" + _tableDbNameInstanceMap;
                    throw new IllegalStateException(msg);
                }
            }
        }

        protected static bool IsInitialized { get {
            return _tableDbNameInstanceMap.size() == _tableDbNameClassNameMap.size();
        }}

        // ===============================================================================
        //                                                              Provider Singleton
        //                                                              ==================
        protected static readonly DBMetaProvider _provider = new DBMetaInstanceHandler();

        public static DBMetaProvider getProvider() {
            return _provider;
        }

        public DBMeta provideDBMeta(String tableFlexibleName) {
            return ByTableFlexibleName(tableFlexibleName);
        }

        public DBMeta provideDBMetaChecked(String tableFlexibleName) {
            return FindDBMeta(tableFlexibleName);
        }

        // ===============================================================================
        //                                                                     Find DBMeta
        //                                                                     ===========
        public static DBMeta FindDBMeta(String tableFlexibleName) { // accept quoted name and schema prefix
            DBMeta dbmeta = ByTableFlexibleName(tableFlexibleName);
            if (dbmeta == null) {
                String msg = "The DB meta was not found by the table flexible name: " + tableFlexibleName;
                msg = msg + " key=" + tableFlexibleName + " instanceMap=" + _tableDbNameInstanceMap;
                throw new DBMetaNotFoundException(msg);
            }
            return dbmeta;
        }

        // ===============================================================================
        //                                                                   By Table Name
        //                                                                   =============
        protected static DBMeta ByTableFlexibleName(String tableFlexibleName) {
            AssertStringNotNullAndNotTrimmedEmpty("tableFlexibleName", tableFlexibleName);
            tableFlexibleName = RemoveSchemaIfExists(tableFlexibleName);
            tableFlexibleName = RemoveQuoteIfExists(tableFlexibleName);
            if (_tableDbNameInstanceMap.containsKey(tableFlexibleName)) {
                return ByTableDbName(tableFlexibleName);
            }
            String toLowerKey = tableFlexibleName.ToLower();
            if (_tableDbNamePropertyNameKeyToLowerMap.containsKey(toLowerKey)) {
                String propertyName = (String)_tableDbNamePropertyNameKeyToLowerMap.get(toLowerKey);
                String dbName = (String)_tablePropertyNameDbNameKeyToLowerMap.get(propertyName.ToLower());
                return ByTableDbName(dbName);
            }
            if (_tablePropertyNameDbNameKeyToLowerMap.containsKey(toLowerKey)) {
                String dbName = (String)_tablePropertyNameDbNameKeyToLowerMap.get(toLowerKey);
                return ByTableDbName(dbName);
            }
            return null;
        }

        protected static String RemoveSchemaIfExists(String name) {
            int dotLastIndex = name.LastIndexOf(".");
            if (dotLastIndex >= 0) {
                name = name.Substring(dotLastIndex + 1);
            }
            return name;
        }

        protected static String RemoveQuoteIfExists(String name) {
            if (name.StartsWith("\"") && name.EndsWith("\"")) {
                name = name.Substring(1);
                name = name.Substring(0, name.Length - 1);
            } else if (name.StartsWith("[") && name.EndsWith("]")) {
                name = name.Substring(1);
                name = name.Substring(0, name.Length - 1);
            }
            return name;
        }

        protected static DBMeta ByTableDbName(String tableDbName) {
            AssertStringNotNullAndNotTrimmedEmpty("tableDbName", tableDbName);
            return GetCachedDBMeta(tableDbName);
        }

        // ===============================================================================
        //                                                                   Cached DBMeta
        //                                                                   =============
        protected static DBMeta GetCachedDBMeta(String tableDbName) { // lazy-load (thank you koyak!)
            DBMeta dbmeta = _tableDbNameInstanceMap.get(tableDbName);
            if (dbmeta != null) {
                return dbmeta;
            }
            lock (_tableDbNameInstanceMap) {
                dbmeta = _tableDbNameInstanceMap.get(tableDbName);
                if (dbmeta != null) {
                    return dbmeta;
                }
                String entityName = _tableDbNameClassNameMap.get(tableDbName);
                _tableDbNameInstanceMap.put(tableDbName, GetDBMeta(entityName));
                return _tableDbNameInstanceMap.get(tableDbName);
            }
        }

        // ===============================================================================
        //                                                                  General Helper
        //                                                                  ==============
        // -------------------------------------------------
        //                                     Assert Object
        //                                     -------------
        protected static void AssertObjectNotNull(String variableName, Object value) {
		    SimpleAssertUtil.AssertObjectNotNull(variableName, value);
        }

        // -------------------------------------------------
        //                                     Assert String
        //                                     -------------
        protected static void AssertStringNotNullAndNotTrimmedEmpty(String variableName, String value) {
            SimpleAssertUtil.AssertStringNotNullAndNotTrimmedEmpty(variableName, value);
        }
    }

    public class DBMetaNotFoundException : SystemException {

        public DBMetaNotFoundException(String msg)
        : base(msg) {}
    }
}

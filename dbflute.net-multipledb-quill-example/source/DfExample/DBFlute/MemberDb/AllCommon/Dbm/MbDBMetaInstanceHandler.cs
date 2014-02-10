
using System;
using System.Reflection;

using DfExample.DBFlute.MemberDb.AllCommon.JavaLike;
using DfExample.DBFlute.MemberDb.AllCommon.Util;

namespace DfExample.DBFlute.MemberDb.AllCommon.Dbm {

    public interface DBMetaProvider {
        MbDBMeta provideDBMeta(String tableFlexibleName);
        MbDBMeta provideDBMetaChecked(String tableFlexibleName);
    }

    public class MbDBMetaInstanceHandler : DBMetaProvider {

        // ===============================================================================
        //                                                                    Resource Map
        //                                                                    ============
        protected static readonly Map<String, MbDBMeta> _tableDbNameInstanceMap = new HashMap<String, MbDBMeta>();
        protected static readonly Map<String, String> _tableDbNameClassNameMap;
        protected static readonly Map<String, String> _tableDbNamePropertyNameKeyToLowerMap;
        protected static readonly Map<String, String> _tablePropertyNameDbNameKeyToLowerMap;

        static MbDBMetaInstanceHandler() {
            {
                Map<String, String> tmpMap = new HashMap<String, String>();
                tmpMap.put("member", "DfExample.DBFlute.MemberDb.BsEntity.Dbm.MbMemberDbm");
                tmpMap.put("member_address", "DfExample.DBFlute.MemberDb.BsEntity.Dbm.MbMemberAddressDbm");
                tmpMap.put("member_login", "DfExample.DBFlute.MemberDb.BsEntity.Dbm.MbMemberLoginDbm");
                tmpMap.put("member_security", "DfExample.DBFlute.MemberDb.BsEntity.Dbm.MbMemberSecurityDbm");
                tmpMap.put("member_status", "DfExample.DBFlute.MemberDb.BsEntity.Dbm.MbMemberStatusDbm");
                tmpMap.put("member_withdrawal", "DfExample.DBFlute.MemberDb.BsEntity.Dbm.MbMemberWithdrawalDbm");
                tmpMap.put("product", "DfExample.DBFlute.MemberDb.BsEntity.Dbm.MbProductDbm");
                tmpMap.put("product_status", "DfExample.DBFlute.MemberDb.BsEntity.Dbm.MbProductStatusDbm");
                tmpMap.put("purchase", "DfExample.DBFlute.MemberDb.BsEntity.Dbm.MbPurchaseDbm");
                tmpMap.put("vendor_check", "DfExample.DBFlute.MemberDb.BsEntity.Dbm.MbVendorCheckDbm");
                tmpMap.put("vendor_self_reference", "DfExample.DBFlute.MemberDb.BsEntity.Dbm.MbVendorSelfReferenceDbm");
                tmpMap.put("withdrawal_reason", "DfExample.DBFlute.MemberDb.BsEntity.Dbm.MbWithdrawalReasonDbm");
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
                tmpMap.put("product".ToLower(), "product");
                tmpMap.put("product_status".ToLower(), "productStatus");
                tmpMap.put("purchase".ToLower(), "purchase");
                tmpMap.put("vendor_check".ToLower(), "vendorCheck");
                tmpMap.put("vendor_self_reference".ToLower(), "vendorSelfReference");
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
                tmpMap.put("Product".ToLower(), "product");
                tmpMap.put("ProductStatus".ToLower(), "product_status");
                tmpMap.put("Purchase".ToLower(), "purchase");
                tmpMap.put("VendorCheck".ToLower(), "vendor_check");
                tmpMap.put("VendorSelfReference".ToLower(), "vendor_self_reference");
                tmpMap.put("WithdrawalReason".ToLower(), "withdrawal_reason");
                _tablePropertyNameDbNameKeyToLowerMap = tmpMap;//java.util.Collections.unmodifiableMap(tmpMap);
            }
        }

        protected static MbDBMeta GetDBMeta(String className) {
			Type clazz = ForName(className, AppDomain.CurrentDomain.GetAssemblies());
            if (clazz == null) {
                String msg = "The className was not found: " + className + " assemblys=";
                msg = msg + Seasar.Framework.Util.ToStringUtil.ToString(AppDomain.CurrentDomain.GetAssemblies());
                throw new SystemException(msg);
            }
            System.Reflection.MethodInfo method = clazz.GetMethod("GetInstance");
            return (MbDBMeta)method.Invoke(null, null);
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
        public static Map<String, MbDBMeta> GetUnmodifiableDBMetaMap() {
            InitializeDBMetaMap();
            lock (_tableDbNameInstanceMap) {
                Map<String, MbDBMeta> copiedMap = new HashMap<String, MbDBMeta>();
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
        protected static readonly DBMetaProvider _provider = new MbDBMetaInstanceHandler();

        public static DBMetaProvider getProvider() {
            return _provider;
        }

        public MbDBMeta provideDBMeta(String tableFlexibleName) {
            return ByTableFlexibleName(tableFlexibleName);
        }

        public MbDBMeta provideDBMetaChecked(String tableFlexibleName) {
            return FindDBMeta(tableFlexibleName);
        }

        // ===============================================================================
        //                                                                     Find DBMeta
        //                                                                     ===========
        public static MbDBMeta FindDBMeta(String tableFlexibleName) { // accept quoted name and schema prefix
            MbDBMeta dbmeta = ByTableFlexibleName(tableFlexibleName);
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
        protected static MbDBMeta ByTableFlexibleName(String tableFlexibleName) {
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

        protected static MbDBMeta ByTableDbName(String tableDbName) {
            AssertStringNotNullAndNotTrimmedEmpty("tableDbName", tableDbName);
            return GetCachedDBMeta(tableDbName);
        }

        // ===============================================================================
        //                                                                   Cached DBMeta
        //                                                                   =============
        protected static MbDBMeta GetCachedDBMeta(String tableDbName) { // lazy-load (thank you koyak!)
            MbDBMeta dbmeta = _tableDbNameInstanceMap.get(tableDbName);
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
		    MbSimpleAssertUtil.AssertObjectNotNull(variableName, value);
        }

        // -------------------------------------------------
        //                                     Assert String
        //                                     -------------
        protected static void AssertStringNotNullAndNotTrimmedEmpty(String variableName, String value) {
            MbSimpleAssertUtil.AssertStringNotNullAndNotTrimmedEmpty(variableName, value);
        }
    }

    public class DBMetaNotFoundException : SystemException {

        public DBMetaNotFoundException(String msg)
        : base(msg) {}
    }
}

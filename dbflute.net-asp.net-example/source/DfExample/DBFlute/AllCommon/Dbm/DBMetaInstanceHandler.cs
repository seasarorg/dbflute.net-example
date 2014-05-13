
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
                tmpMap.put("MEMBER", "DfExample.DBFlute.BsEntity.Dbm.MemberDbm");
                tmpMap.put("MEMBER_ADDRESS", "DfExample.DBFlute.BsEntity.Dbm.MemberAddressDbm");
                tmpMap.put("MEMBER_LOGIN", "DfExample.DBFlute.BsEntity.Dbm.MemberLoginDbm");
                tmpMap.put("MEMBER_SECURITY", "DfExample.DBFlute.BsEntity.Dbm.MemberSecurityDbm");
                tmpMap.put("MEMBER_STATUS", "DfExample.DBFlute.BsEntity.Dbm.MemberStatusDbm");
                tmpMap.put("MEMBER_VENDOR_SYNONYM", "DfExample.DBFlute.BsEntity.Dbm.MemberVendorSynonymDbm");
                tmpMap.put("MEMBER_WITHDRAWAL", "DfExample.DBFlute.BsEntity.Dbm.MemberWithdrawalDbm");
                tmpMap.put("PRODUCT", "DfExample.DBFlute.BsEntity.Dbm.ProductDbm");
                tmpMap.put("PRODUCT_STATUS", "DfExample.DBFlute.BsEntity.Dbm.ProductStatusDbm");
                tmpMap.put("PURCHASE", "DfExample.DBFlute.BsEntity.Dbm.PurchaseDbm");
                tmpMap.put("SUMMARY_MEMBER_PURCHASE", "DfExample.DBFlute.BsEntity.Dbm.SummaryMemberPurchaseDbm");
                tmpMap.put("SUMMARY_PRODUCT", "DfExample.DBFlute.BsEntity.Dbm.SummaryProductDbm");
                tmpMap.put("VD_SYNONYM_MEMBER", "DfExample.DBFlute.BsEntity.Dbm.VdSynonymMemberDbm");
                tmpMap.put("VD_SYNONYM_MEMBER_LOGIN", "DfExample.DBFlute.BsEntity.Dbm.VdSynonymMemberLoginDbm");
                tmpMap.put("VD_SYNONYM_MEMBER_WITHDRAWAL", "DfExample.DBFlute.BsEntity.Dbm.VdSynonymMemberWithdrawalDbm");
                tmpMap.put("VD_SYNONYM_PRODUCT", "DfExample.DBFlute.BsEntity.Dbm.VdSynonymProductDbm");
                tmpMap.put("VD_SYNONYM_PRODUCT_STATUS", "DfExample.DBFlute.BsEntity.Dbm.VdSynonymProductStatusDbm");
                tmpMap.put("VD_SYNONYM_VENDOR_EXCEPT", "DfExample.DBFlute.BsEntity.Dbm.VdSynonymVendorExceptDbm");
                tmpMap.put("VD_SYNONYM_VENDOR_REF_EXCEPT", "DfExample.DBFlute.BsEntity.Dbm.VdSynonymVendorRefExceptDbm");
                tmpMap.put("VD_SYNONYM_VENDOR_REF_TARGET", "DfExample.DBFlute.BsEntity.Dbm.VdSynonymVendorRefTargetDbm");
                tmpMap.put("VD_SYNONYM_VENDOR_TARGET", "DfExample.DBFlute.BsEntity.Dbm.VdSynonymVendorTargetDbm");
                tmpMap.put("VENDOR_CHECK", "DfExample.DBFlute.BsEntity.Dbm.VendorCheckDbm");
                tmpMap.put("VENDOR_EXCEPT", "DfExample.DBFlute.BsEntity.Dbm.VendorExceptDbm");
                tmpMap.put("VENDOR_LARGE_NAME_901234567890", "DfExample.DBFlute.BsEntity.Dbm.VendorLargeName901234567890Dbm");
                tmpMap.put("VENDOR_LARGE_NAME_90123456_REF", "DfExample.DBFlute.BsEntity.Dbm.VendorLargeName90123456RefDbm");
                tmpMap.put("VENDOR_REF_EXCEPT", "DfExample.DBFlute.BsEntity.Dbm.VendorRefExceptDbm");
                tmpMap.put("VENDOR_REF_TARGET", "DfExample.DBFlute.BsEntity.Dbm.VendorRefTargetDbm");
                tmpMap.put("VENDOR_SYNONYM_MEMBER", "DfExample.DBFlute.BsEntity.Dbm.VendorSynonymMemberDbm");
                tmpMap.put("VENDOR_TARGET", "DfExample.DBFlute.BsEntity.Dbm.VendorTargetDbm");
                tmpMap.put("WITHDRAWAL_REASON", "DfExample.DBFlute.BsEntity.Dbm.WithdrawalReasonDbm");
                _tableDbNameClassNameMap = tmpMap;//java.util.Collections.unmodifiableMap(tmpMap);
            }

            {
                Map<String, String> tmpMap = new HashMap<String, String>();
                tmpMap.put("MEMBER".ToLower(), "member");
                tmpMap.put("MEMBER_ADDRESS".ToLower(), "memberAddress");
                tmpMap.put("MEMBER_LOGIN".ToLower(), "memberLogin");
                tmpMap.put("MEMBER_SECURITY".ToLower(), "memberSecurity");
                tmpMap.put("MEMBER_STATUS".ToLower(), "memberStatus");
                tmpMap.put("MEMBER_VENDOR_SYNONYM".ToLower(), "memberVendorSynonym");
                tmpMap.put("MEMBER_WITHDRAWAL".ToLower(), "memberWithdrawal");
                tmpMap.put("PRODUCT".ToLower(), "product");
                tmpMap.put("PRODUCT_STATUS".ToLower(), "productStatus");
                tmpMap.put("PURCHASE".ToLower(), "purchase");
                tmpMap.put("SUMMARY_MEMBER_PURCHASE".ToLower(), "summaryMemberPurchase");
                tmpMap.put("SUMMARY_PRODUCT".ToLower(), "summaryProduct");
                tmpMap.put("VD_SYNONYM_MEMBER".ToLower(), "vdSynonymMember");
                tmpMap.put("VD_SYNONYM_MEMBER_LOGIN".ToLower(), "vdSynonymMemberLogin");
                tmpMap.put("VD_SYNONYM_MEMBER_WITHDRAWAL".ToLower(), "vdSynonymMemberWithdrawal");
                tmpMap.put("VD_SYNONYM_PRODUCT".ToLower(), "vdSynonymProduct");
                tmpMap.put("VD_SYNONYM_PRODUCT_STATUS".ToLower(), "vdSynonymProductStatus");
                tmpMap.put("VD_SYNONYM_VENDOR_EXCEPT".ToLower(), "vdSynonymVendorExcept");
                tmpMap.put("VD_SYNONYM_VENDOR_REF_EXCEPT".ToLower(), "vdSynonymVendorRefExcept");
                tmpMap.put("VD_SYNONYM_VENDOR_REF_TARGET".ToLower(), "vdSynonymVendorRefTarget");
                tmpMap.put("VD_SYNONYM_VENDOR_TARGET".ToLower(), "vdSynonymVendorTarget");
                tmpMap.put("VENDOR_CHECK".ToLower(), "vendorCheck");
                tmpMap.put("VENDOR_EXCEPT".ToLower(), "vendorExcept");
                tmpMap.put("VENDOR_LARGE_NAME_901234567890".ToLower(), "vendorLargeName901234567890");
                tmpMap.put("VENDOR_LARGE_NAME_90123456_REF".ToLower(), "vendorLargeName90123456Ref");
                tmpMap.put("VENDOR_REF_EXCEPT".ToLower(), "vendorRefExcept");
                tmpMap.put("VENDOR_REF_TARGET".ToLower(), "vendorRefTarget");
                tmpMap.put("VENDOR_SYNONYM_MEMBER".ToLower(), "vendorSynonymMember");
                tmpMap.put("VENDOR_TARGET".ToLower(), "vendorTarget");
                tmpMap.put("WITHDRAWAL_REASON".ToLower(), "withdrawalReason");
                _tableDbNamePropertyNameKeyToLowerMap = tmpMap;//java.util.Collections.unmodifiableMap(tmpMap);
            }

            {
                Map<String, String> tmpMap = new HashMap<String, String>();
                tmpMap.put("Member".ToLower(), "MEMBER");
                tmpMap.put("MemberAddress".ToLower(), "MEMBER_ADDRESS");
                tmpMap.put("MemberLogin".ToLower(), "MEMBER_LOGIN");
                tmpMap.put("MemberSecurity".ToLower(), "MEMBER_SECURITY");
                tmpMap.put("MemberStatus".ToLower(), "MEMBER_STATUS");
                tmpMap.put("MemberVendorSynonym".ToLower(), "MEMBER_VENDOR_SYNONYM");
                tmpMap.put("MemberWithdrawal".ToLower(), "MEMBER_WITHDRAWAL");
                tmpMap.put("Product".ToLower(), "PRODUCT");
                tmpMap.put("ProductStatus".ToLower(), "PRODUCT_STATUS");
                tmpMap.put("Purchase".ToLower(), "PURCHASE");
                tmpMap.put("SummaryMemberPurchase".ToLower(), "SUMMARY_MEMBER_PURCHASE");
                tmpMap.put("SummaryProduct".ToLower(), "SUMMARY_PRODUCT");
                tmpMap.put("VdSynonymMember".ToLower(), "VD_SYNONYM_MEMBER");
                tmpMap.put("VdSynonymMemberLogin".ToLower(), "VD_SYNONYM_MEMBER_LOGIN");
                tmpMap.put("VdSynonymMemberWithdrawal".ToLower(), "VD_SYNONYM_MEMBER_WITHDRAWAL");
                tmpMap.put("VdSynonymProduct".ToLower(), "VD_SYNONYM_PRODUCT");
                tmpMap.put("VdSynonymProductStatus".ToLower(), "VD_SYNONYM_PRODUCT_STATUS");
                tmpMap.put("VdSynonymVendorExcept".ToLower(), "VD_SYNONYM_VENDOR_EXCEPT");
                tmpMap.put("VdSynonymVendorRefExcept".ToLower(), "VD_SYNONYM_VENDOR_REF_EXCEPT");
                tmpMap.put("VdSynonymVendorRefTarget".ToLower(), "VD_SYNONYM_VENDOR_REF_TARGET");
                tmpMap.put("VdSynonymVendorTarget".ToLower(), "VD_SYNONYM_VENDOR_TARGET");
                tmpMap.put("VendorCheck".ToLower(), "VENDOR_CHECK");
                tmpMap.put("VendorExcept".ToLower(), "VENDOR_EXCEPT");
                tmpMap.put("VendorLargeName901234567890".ToLower(), "VENDOR_LARGE_NAME_901234567890");
                tmpMap.put("VendorLargeName90123456Ref".ToLower(), "VENDOR_LARGE_NAME_90123456_REF");
                tmpMap.put("VendorRefExcept".ToLower(), "VENDOR_REF_EXCEPT");
                tmpMap.put("VendorRefTarget".ToLower(), "VENDOR_REF_TARGET");
                tmpMap.put("VendorSynonymMember".ToLower(), "VENDOR_SYNONYM_MEMBER");
                tmpMap.put("VendorTarget".ToLower(), "VENDOR_TARGET");
                tmpMap.put("WithdrawalReason".ToLower(), "WITHDRAWAL_REASON");
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

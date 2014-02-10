
using System;
using System.Reflection;

using DfExample.DBFlute.LibraryDb.AllCommon.JavaLike;
using DfExample.DBFlute.LibraryDb.AllCommon.Util;

namespace DfExample.DBFlute.LibraryDb.AllCommon.Dbm {

    public interface DBMetaProvider {
        LdDBMeta provideDBMeta(String tableFlexibleName);
        LdDBMeta provideDBMetaChecked(String tableFlexibleName);
    }

    public class LdDBMetaInstanceHandler : DBMetaProvider {

        // ===============================================================================
        //                                                                    Resource Map
        //                                                                    ============
        protected static readonly Map<String, LdDBMeta> _tableDbNameInstanceMap = new HashMap<String, LdDBMeta>();
        protected static readonly Map<String, String> _tableDbNameClassNameMap;
        protected static readonly Map<String, String> _tableDbNamePropertyNameKeyToLowerMap;
        protected static readonly Map<String, String> _tablePropertyNameDbNameKeyToLowerMap;

        static LdDBMetaInstanceHandler() {
            {
                Map<String, String> tmpMap = new HashMap<String, String>();
                tmpMap.put("author", "DfExample.DBFlute.LibraryDb.BsEntity.Dbm.LdAuthorDbm");
                tmpMap.put("black_action", "DfExample.DBFlute.LibraryDb.BsEntity.Dbm.LdBlackActionDbm");
                tmpMap.put("black_action_lookup", "DfExample.DBFlute.LibraryDb.BsEntity.Dbm.LdBlackActionLookupDbm");
                tmpMap.put("black_list", "DfExample.DBFlute.LibraryDb.BsEntity.Dbm.LdBlackListDbm");
                tmpMap.put("book", "DfExample.DBFlute.LibraryDb.BsEntity.Dbm.LdBookDbm");
                tmpMap.put("collection", "DfExample.DBFlute.LibraryDb.BsEntity.Dbm.LdCollectionDbm");
                tmpMap.put("collection_status", "DfExample.DBFlute.LibraryDb.BsEntity.Dbm.LdCollectionStatusDbm");
                tmpMap.put("collection_status_lookup", "DfExample.DBFlute.LibraryDb.BsEntity.Dbm.LdCollectionStatusLookupDbm");
                tmpMap.put("garbage", "DfExample.DBFlute.LibraryDb.BsEntity.Dbm.LdGarbageDbm");
                tmpMap.put("garbage_plus", "DfExample.DBFlute.LibraryDb.BsEntity.Dbm.LdGarbagePlusDbm");
                tmpMap.put("genre", "DfExample.DBFlute.LibraryDb.BsEntity.Dbm.LdGenreDbm");
                tmpMap.put("lb_user", "DfExample.DBFlute.LibraryDb.BsEntity.Dbm.LdLbUserDbm");
                tmpMap.put("lending", "DfExample.DBFlute.LibraryDb.BsEntity.Dbm.LdLendingDbm");
                tmpMap.put("lending_collection", "DfExample.DBFlute.LibraryDb.BsEntity.Dbm.LdLendingCollectionDbm");
                tmpMap.put("library", "DfExample.DBFlute.LibraryDb.BsEntity.Dbm.LdLibraryDbm");
                tmpMap.put("library_type_lookup", "DfExample.DBFlute.LibraryDb.BsEntity.Dbm.LdLibraryTypeLookupDbm");
                tmpMap.put("library_user", "DfExample.DBFlute.LibraryDb.BsEntity.Dbm.LdLibraryUserDbm");
                tmpMap.put("myself", "DfExample.DBFlute.LibraryDb.BsEntity.Dbm.LdMyselfDbm");
                tmpMap.put("myself_check", "DfExample.DBFlute.LibraryDb.BsEntity.Dbm.LdMyselfCheckDbm");
                tmpMap.put("next_library", "DfExample.DBFlute.LibraryDb.BsEntity.Dbm.LdNextLibraryDbm");
                tmpMap.put("publisher", "DfExample.DBFlute.LibraryDb.BsEntity.Dbm.LdPublisherDbm");
                _tableDbNameClassNameMap = tmpMap;//java.util.Collections.unmodifiableMap(tmpMap);
            }

            {
                Map<String, String> tmpMap = new HashMap<String, String>();
                tmpMap.put("author".ToLower(), "author");
                tmpMap.put("black_action".ToLower(), "blackAction");
                tmpMap.put("black_action_lookup".ToLower(), "blackActionLookup");
                tmpMap.put("black_list".ToLower(), "blackList");
                tmpMap.put("book".ToLower(), "book");
                tmpMap.put("collection".ToLower(), "collection");
                tmpMap.put("collection_status".ToLower(), "collectionStatus");
                tmpMap.put("collection_status_lookup".ToLower(), "collectionStatusLookup");
                tmpMap.put("garbage".ToLower(), "garbage");
                tmpMap.put("garbage_plus".ToLower(), "garbagePlus");
                tmpMap.put("genre".ToLower(), "genre");
                tmpMap.put("lb_user".ToLower(), "lbUser");
                tmpMap.put("lending".ToLower(), "lending");
                tmpMap.put("lending_collection".ToLower(), "lendingCollection");
                tmpMap.put("library".ToLower(), "library");
                tmpMap.put("library_type_lookup".ToLower(), "libraryTypeLookup");
                tmpMap.put("library_user".ToLower(), "libraryUser");
                tmpMap.put("myself".ToLower(), "myself");
                tmpMap.put("myself_check".ToLower(), "myselfCheck");
                tmpMap.put("next_library".ToLower(), "nextLibrary");
                tmpMap.put("publisher".ToLower(), "publisher");
                _tableDbNamePropertyNameKeyToLowerMap = tmpMap;//java.util.Collections.unmodifiableMap(tmpMap);
            }

            {
                Map<String, String> tmpMap = new HashMap<String, String>();
                tmpMap.put("Author".ToLower(), "author");
                tmpMap.put("BlackAction".ToLower(), "black_action");
                tmpMap.put("BlackActionLookup".ToLower(), "black_action_lookup");
                tmpMap.put("BlackList".ToLower(), "black_list");
                tmpMap.put("Book".ToLower(), "book");
                tmpMap.put("Collection".ToLower(), "collection");
                tmpMap.put("CollectionStatus".ToLower(), "collection_status");
                tmpMap.put("CollectionStatusLookup".ToLower(), "collection_status_lookup");
                tmpMap.put("Garbage".ToLower(), "garbage");
                tmpMap.put("GarbagePlus".ToLower(), "garbage_plus");
                tmpMap.put("Genre".ToLower(), "genre");
                tmpMap.put("LbUser".ToLower(), "lb_user");
                tmpMap.put("Lending".ToLower(), "lending");
                tmpMap.put("LendingCollection".ToLower(), "lending_collection");
                tmpMap.put("Library".ToLower(), "library");
                tmpMap.put("LibraryTypeLookup".ToLower(), "library_type_lookup");
                tmpMap.put("LibraryUser".ToLower(), "library_user");
                tmpMap.put("Myself".ToLower(), "myself");
                tmpMap.put("MyselfCheck".ToLower(), "myself_check");
                tmpMap.put("NextLibrary".ToLower(), "next_library");
                tmpMap.put("Publisher".ToLower(), "publisher");
                _tablePropertyNameDbNameKeyToLowerMap = tmpMap;//java.util.Collections.unmodifiableMap(tmpMap);
            }
        }

        protected static LdDBMeta GetDBMeta(String className) {
			Type clazz = ForName(className, AppDomain.CurrentDomain.GetAssemblies());
            if (clazz == null) {
                String msg = "The className was not found: " + className + " assemblys=";
                msg = msg + Seasar.Framework.Util.ToStringUtil.ToString(AppDomain.CurrentDomain.GetAssemblies());
                throw new SystemException(msg);
            }
            System.Reflection.MethodInfo method = clazz.GetMethod("GetInstance");
            return (LdDBMeta)method.Invoke(null, null);
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
        public static Map<String, LdDBMeta> GetUnmodifiableDBMetaMap() {
            InitializeDBMetaMap();
            lock (_tableDbNameInstanceMap) {
                Map<String, LdDBMeta> copiedMap = new HashMap<String, LdDBMeta>();
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
        protected static readonly DBMetaProvider _provider = new LdDBMetaInstanceHandler();

        public static DBMetaProvider getProvider() {
            return _provider;
        }

        public LdDBMeta provideDBMeta(String tableFlexibleName) {
            return ByTableFlexibleName(tableFlexibleName);
        }

        public LdDBMeta provideDBMetaChecked(String tableFlexibleName) {
            return FindDBMeta(tableFlexibleName);
        }

        // ===============================================================================
        //                                                                     Find DBMeta
        //                                                                     ===========
        public static LdDBMeta FindDBMeta(String tableFlexibleName) { // accept quoted name and schema prefix
            LdDBMeta dbmeta = ByTableFlexibleName(tableFlexibleName);
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
        protected static LdDBMeta ByTableFlexibleName(String tableFlexibleName) {
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

        protected static LdDBMeta ByTableDbName(String tableDbName) {
            AssertStringNotNullAndNotTrimmedEmpty("tableDbName", tableDbName);
            return GetCachedDBMeta(tableDbName);
        }

        // ===============================================================================
        //                                                                   Cached DBMeta
        //                                                                   =============
        protected static LdDBMeta GetCachedDBMeta(String tableDbName) { // lazy-load (thank you koyak!)
            LdDBMeta dbmeta = _tableDbNameInstanceMap.get(tableDbName);
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
		    LdSimpleAssertUtil.AssertObjectNotNull(variableName, value);
        }

        // -------------------------------------------------
        //                                     Assert String
        //                                     -------------
        protected static void AssertStringNotNullAndNotTrimmedEmpty(String variableName, String value) {
            LdSimpleAssertUtil.AssertStringNotNullAndNotTrimmedEmpty(variableName, value);
        }
    }

    public class DBMetaNotFoundException : SystemException {

        public DBMetaNotFoundException(String msg)
        : base(msg) {}
    }
}

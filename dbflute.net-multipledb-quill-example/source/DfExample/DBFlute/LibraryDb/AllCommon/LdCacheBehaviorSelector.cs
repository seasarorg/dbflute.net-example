
using System;
using System.Reflection;

using Seasar.Quill;

using DfExample.DBFlute.LibraryDb.AllCommon;
using DfExample.DBFlute.LibraryDb.AllCommon.Bhv;
using DfExample.DBFlute.LibraryDb.AllCommon.Dbm;
using DfExample.DBFlute.LibraryDb.AllCommon.JavaLike;
using DfExample.DBFlute.LibraryDb.AllCommon.Util;

namespace DfExample.DBFlute.LibraryDb.AllCommon {

    public class LdCacheBehaviorSelector : LdBehaviorSelector {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        private static readonly log4net.ILog _log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected LdDaoSelector _daoSelector;

        // ===============================================================================
        //                                                                      Initialize
        //                                                                      ==========
        public void InitializeConditionBeanMetaData() {
            Map<String, LdDBMeta> dbmetaMap = LdDBMetaInstanceHandler.GetUnmodifiableDBMetaMap();
            Collection<LdDBMeta> dbmetas = dbmetaMap.values();
            DateTime? before = null;
            if (_log.IsInfoEnabled) {
                before = DateTime.Now;
                _log.Info("/= = = = = = = = = = = = = = = = = InitializeConditionBeanMetaData()");
            }
            foreach (LdDBMeta dbmeta in dbmetas) {
                LdDaoReadable dao = DaoSelector.ByName(dbmeta.TableDbName);
                MethodInfo method = dao.GetType().GetMethod("InitializeDaoMetaData");
                if (method == null) {
                    continue;
                }
                method.Invoke(dao, new Object[] {"SelectList"});
            }
            if (_log.IsInfoEnabled) {
                DateTime after = DateTime.Now;
                _log.Info("Initialized Count: " + dbmetas.size());
                _log.Info("= = = = = = = = = =/ [" + LdTraceViewUtil.ConvertToPerformanceView(before.Value, after) + "]");
            }
        }
    
        // ===============================================================================
        //                                                                  Implementation
        //                                                                  ==============
        public virtual BEHAVIOR Select<BEHAVIOR>() where BEHAVIOR : LdBehaviorReadable {
            Type behaviorType = typeof(BEHAVIOR);
            QuillComponent component = QuillInjector.GetInstance().Container.GetComponent(behaviorType);
            BEHAVIOR bhv = (BEHAVIOR)component.GetComponentObject(behaviorType);
            if (bhv.IsInitialized) {
                return bhv;
            }
            QuillInjector.GetInstance().Inject(bhv);
            return bhv;
        }

        public virtual LdBehaviorReadable ByName(String tableFlexibleName) {
            AssertStringNotNullAndNotTrimmedEmpty("tableFlexibleName", tableFlexibleName);
            LdDBMeta dbmeta = LdDBMetaInstanceHandler.FindDBMeta(tableFlexibleName);
            return InternalSelect<LdBehaviorReadable>(GetBehaviorType(dbmeta));
        }

        protected virtual BEHAVIOR InternalSelect<BEHAVIOR>(Type behaviorType) where BEHAVIOR : LdBehaviorReadable {
            QuillComponent component = QuillInjector.GetInstance().Container.GetComponent(behaviorType);
            BEHAVIOR bhv = (BEHAVIOR)component.GetComponentObject(behaviorType);
            if (bhv.IsInitialized) {
                return bhv;
            }
            QuillInjector.GetInstance().Inject(bhv);
            return bhv;
        }

        // ===============================================================================
        //                                                                   Assist Helper
        //                                                                   =============
        protected static Type GetBehaviorType(LdDBMeta dbmeta) {
            String behaviorTypeName = dbmeta.BehaviorTypeName;
            if (behaviorTypeName == null) {
                String msg = "The dbmeta.BehaviorTypeName should not return null: dbmeta=" + dbmeta;
                throw new SystemException(msg);
            }
            return ForName(behaviorTypeName, AppDomain.CurrentDomain.GetAssemblies());
        }

        protected static Type ForName(string className, System.Collections.IList assemblys) {
            Type type = Type.GetType(className);
            if(type != null) return type;
            foreach(String assemblyName in assemblys) {
                System.Reflection.Assembly assembly = System.Reflection.Assembly.Load(assemblyName);
                if (assembly == null) {
                    String msg = "The assemblyName was not found: " + assemblyName + " assemblys=";
                    msg = msg + Seasar.Framework.Util.ToStringUtil.ToString(assemblys);
                    throw new SystemException(msg);
                }
                type = assembly.GetType(className);
                if(type != null) return type;
            }
            return type;
        }

        // ===============================================================================
        //                                                                          Helper
        //                                                                          ======
        // -------------------------------------------------
        //                                     Assert Object
        //                                     -------------
        protected static void AssertObjectNotNull(String variableName, Object value) {
            if (variableName == null) {
                String msg = "The value should not be null: variableName=" + variableName + " value=" + value;
                throw new SystemException(msg);
            }
            if (value == null) {
                String msg = "The value should not be null: variableName=" + variableName;
                throw new SystemException(msg);
            }
        }

        // -------------------------------------------------
        //                                     Assert String
        //                                     -------------
        protected static void AssertStringNotNullAndNotTrimmedEmpty(String variableName, String value) {
            AssertObjectNotNull("variableName", variableName);
            AssertObjectNotNull(variableName, value);
            if (value.Trim().Length ==0) {
                String msg = "The value should not be empty: variableName=" + variableName + " value=" + value;
                throw new SystemException(msg);
            }
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public LdDaoSelector DaoSelector {
            get { return _daoSelector; }
            set { _daoSelector = value; }
        }
    }
}

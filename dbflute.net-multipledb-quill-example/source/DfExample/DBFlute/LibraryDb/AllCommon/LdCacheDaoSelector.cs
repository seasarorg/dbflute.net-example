
using System;

using Seasar.Quill;

using DfExample.DBFlute.LibraryDb.AllCommon.Dbm;

namespace DfExample.DBFlute.LibraryDb.AllCommon {

    public class LdCacheDaoSelector : LdDaoSelector {

        // ===============================================================================
        //                                                                  Implementation
        //                                                                  ==============
        public virtual DAO Select<DAO>() where DAO : LdDaoReadable {
            Type daoType = typeof(DAO);
            QuillComponent component = QuillInjector.GetInstance().Container.GetComponent(daoType);
            DAO dao = (DAO)component.GetComponentObject(daoType);
            return dao;
        }

        public virtual LdDaoReadable ByName(String tableFlexibleName) {
            AssertStringNotNullAndNotTrimmedEmpty("tableFlexibleName", tableFlexibleName);
            LdDBMeta dbmeta = LdDBMetaInstanceHandler.FindDBMeta(tableFlexibleName);
            return InternalSelect<LdDaoReadable>(GetDaoType(dbmeta));
        }

        protected virtual DAO InternalSelect<DAO>(Type daoType) where DAO : LdDaoReadable {
            QuillComponent component = QuillInjector.GetInstance().Container.GetComponent(daoType);
            DAO dao = (DAO)component.GetComponentObject(daoType);
            return dao;
        }

        // ===============================================================================
        //                                                                   Assist Helper
        //                                                                   =============
        protected static Type GetDaoType(LdDBMeta dbmeta) {
            String daoTypeName = dbmeta.DaoTypeName;
            if (daoTypeName == null) {
                String msg = "The dbmeta.DaoTypeName should not return null: dbmeta=" + dbmeta;
                throw new SystemException(msg);
            }
            return ForName(daoTypeName, AppDomain.CurrentDomain.GetAssemblies());
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
    }
}

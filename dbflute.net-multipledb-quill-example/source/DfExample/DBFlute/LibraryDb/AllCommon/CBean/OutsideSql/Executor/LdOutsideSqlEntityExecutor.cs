
using System;
using System.Collections.Generic;

using DfExample.DBFlute.LibraryDb.AllCommon.CBean;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean.OutsideSql;
using DfExample.DBFlute.LibraryDb.AllCommon.Ado;
using DfExample.DBFlute.LibraryDb.AllCommon.Util;

namespace DfExample.DBFlute.LibraryDb.AllCommon.CBean.OutsideSql.Executor {

    public class LdOutsideSqlEntityExecutor<PARAMETER_BEAN> {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected LdOutsideSqlDao _outsideSqlDao;

        protected LdOutsideSqlOption _outsideSqlOption;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public LdOutsideSqlEntityExecutor(LdOutsideSqlDao outsideSqlDao, LdOutsideSqlOption outsideSqlOption) {
            this._outsideSqlDao = outsideSqlDao;
            this._outsideSqlOption = outsideSqlOption;
        }

        // ===============================================================================
        //                                                                          Select
        //                                                                          ======
        public ENTITY SelectEntity<ENTITY>(String path, PARAMETER_BEAN pmb) {
            IList<ENTITY> ls = ToGenericList<ENTITY>(_outsideSqlDao.SelectList(path, pmb, _outsideSqlOption, typeof(ENTITY)));
            if (ls.Count == 0) {
                return default(ENTITY);
            }
            if (ls.Count > 1) {
                ThrowEntityDuplicatedException(ls.Count + "", BuildSearch4LogString<ENTITY>(path, pmb), null);
            }
            return ls[0];
        }

        public ENTITY SelectEntityWithDeletedCheck<ENTITY>(String path, PARAMETER_BEAN pmb) {
            IList<ENTITY> ls = ToGenericList<ENTITY>(_outsideSqlDao.SelectList(path, pmb, _outsideSqlOption, typeof(ENTITY)));
            if (ls == null || ls.Count == 0) {
                ThrowEntityAlreadyDeletedException(BuildSearch4LogString<ENTITY>(path, pmb));
            }
            if (ls.Count > 1) {
                ThrowEntityDuplicatedException(ls.Count + "", BuildSearch4LogString<ENTITY>(path, pmb), null);
            }
            return ls[0];
        }

        protected IList<ENTITY> ToGenericList<ENTITY>(System.Collections.IList plainList) {
            return LdDfCollectionUtil.ToGenericList<ENTITY>(plainList);
        }

        protected String BuildSearch4LogString<ENTITY>(String path, PARAMETER_BEAN pmb) {
            Type entityType = typeof(ENTITY);
            String tmp = "Table  = " + _outsideSqlOption.TableDbName + GetLineSeparator();
            tmp = tmp + "Path   = " + path + GetLineSeparator();
            tmp = tmp + "Pmb    = " + (pmb != null ? pmb.GetType().ToString() : "null") + ":" + pmb + GetLineSeparator();
            tmp = tmp + "Entity = " + (entityType != null ? entityType.ToString() : "null") + GetLineSeparator();
            tmp = tmp + "Option = " + _outsideSqlOption;
            return tmp;
        }

        // -------------------------------------------------
        //                                            Helper
        //                                            ------
        protected void ThrowEntityAlreadyDeletedException(Object searchKey4Log) {
            LdConditionBeanContext.ThrowEntityAlreadyDeletedException(searchKey4Log);
        }

        protected void ThrowEntityDuplicatedException(String resultCountString, Object searchKey4Log, Exception cause) {
            LdConditionBeanContext.ThrowEntityDuplicatedException(resultCountString, searchKey4Log, cause);
        }

        // ===============================================================================
        //                                                                          Option
        //                                                                          ======
        public LdOutsideSqlEntityExecutor<PARAMETER_BEAN> Configure(LdStatementConfig statementConfig) {
            _outsideSqlOption.StatementConfig = statementConfig;
            return this;
        }

        public LdOutsideSqlEntityExecutor<PARAMETER_BEAN> DynamicBinding() {
            _outsideSqlOption.DynamicBinding();
            return this;
        }
	
    	// ===============================================================================
        //                                                                  General Helper
        //                                                                  ==============
        protected static String GetLineSeparator() {
            return LdSimpleSystemUtil.GetLineSeparator();
        }
    }
}

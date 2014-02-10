
using System;
using System.Collections.Generic;

using DfExample.DBFlute.LibraryDb.AllCommon.CBean;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean.OutsideSql;
using DfExample.DBFlute.LibraryDb.AllCommon.Ado;
using DfExample.DBFlute.LibraryDb.AllCommon.Util;

namespace DfExample.DBFlute.LibraryDb.AllCommon.CBean.OutsideSql.Executor {

    public class LdOutsideSqlBasicExecutor {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected LdOutsideSqlDao _outsideSqlDao;
        protected String _tableDbName;
        protected bool _dynamicBinding;
        protected LdStatementConfig _statementConfig;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public LdOutsideSqlBasicExecutor(LdOutsideSqlDao outsideSqlDao, String tableDbName) {
            _outsideSqlDao = outsideSqlDao;
            _tableDbName = tableDbName;
        }

        // ===============================================================================
        //                                                                          Select
        //                                                                          ======
        public LdListResultBean<ENTITY> SelectList<ENTITY>(String path, Object pmb) {
            IList<ENTITY> resultList = ToGenericList<ENTITY>(_outsideSqlDao.SelectList(path, pmb, CreateOutsideSqlOption(), typeof(ENTITY)));
            return new LdResultBeanBuilder<ENTITY>(_tableDbName).BuildListResultBean(resultList);
            
        }

        protected IList<ENTITY> ToGenericList<ENTITY>(System.Collections.IList plainList) {
            return LdDfCollectionUtil.ToGenericList<ENTITY>(plainList);
        }

        // ===============================================================================
        //                                                                         Execute
        //                                                                         =======
        public int Execute(String path, Object pmb) {
            return _outsideSqlDao.Execute(path, pmb, CreateOutsideSqlOption());
        }

        // Implements at the future!
        //    public int BatchExecute(String path, Object pmb) {
        //        throw new UnsupportedOperationException("Sorry! The method of batchExecute() has not been implemented yet.");
        //        // return _outsideSqlDao.batchExecute(path, pmb, CreateOutsideSqlOption());
        //    }

        // [DBFlute-0.8.0]
        // ===============================================================================
        //                                                                  Procedure Call
        //                                                                  ==============
        public void Call(LdProcedurePmb pmb) {
            if (pmb == null) { throw new ArgumentNullException("The argument of call() 'pmb' should not be null!"); }
            _outsideSqlDao.Call(pmb.ProcedureName, pmb, CreateOutsideSqlOption());
        }

        // ===============================================================================
        //                                                                          Option
        //                                                                          ======
        public LdOutsideSqlCursorExecutor<Object> CursorHandling() {
            return new LdOutsideSqlCursorExecutor<Object>(_outsideSqlDao, CreateOutsideSqlOption());
        }

        public LdOutsideSqlEntityExecutor<Object> EntityHandling() {
            return new LdOutsideSqlEntityExecutor<Object>(_outsideSqlDao, CreateOutsideSqlOption());
        }

        public LdOutsideSqlPagingExecutor AutoPaging() {
            LdOutsideSqlOption option = CreateOutsideSqlOption();
            option.AutoPaging();
            return new LdOutsideSqlPagingExecutor(_outsideSqlDao, option, _tableDbName);
        }

        public LdOutsideSqlPagingExecutor ManualPaging() {
            LdOutsideSqlOption option = CreateOutsideSqlOption();
            option.ManualPaging();
            return new LdOutsideSqlPagingExecutor(_outsideSqlDao, option, _tableDbName);
        }

        public LdOutsideSqlBasicExecutor DynamicBinding() {
            _dynamicBinding = true;
            return this;
        }

        public LdOutsideSqlBasicExecutor Configure(LdStatementConfig statementConfig) {
            _statementConfig = statementConfig;
            return this;
        }

        // -------------------------------------------------
        //                                            Helper
        //                                            ------
        protected LdOutsideSqlOption CreateOutsideSqlOption() {
            LdOutsideSqlOption option = new LdOutsideSqlOption();
            option.StatementConfig = _statementConfig;
            if (_dynamicBinding) {
                option.DynamicBinding();
            }
			option.TableDbName = _tableDbName;
            return option;
        }
    }
}

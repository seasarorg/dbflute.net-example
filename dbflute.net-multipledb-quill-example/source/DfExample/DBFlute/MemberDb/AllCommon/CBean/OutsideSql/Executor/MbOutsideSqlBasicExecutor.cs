
using System;
using System.Collections.Generic;

using DfExample.DBFlute.MemberDb.AllCommon.CBean;
using DfExample.DBFlute.MemberDb.AllCommon.CBean.OutsideSql;
using DfExample.DBFlute.MemberDb.AllCommon.Ado;
using DfExample.DBFlute.MemberDb.AllCommon.Util;

namespace DfExample.DBFlute.MemberDb.AllCommon.CBean.OutsideSql.Executor {

    public class MbOutsideSqlBasicExecutor {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected MbOutsideSqlDao _outsideSqlDao;
        protected String _tableDbName;
        protected bool _dynamicBinding;
        protected MbStatementConfig _statementConfig;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public MbOutsideSqlBasicExecutor(MbOutsideSqlDao outsideSqlDao, String tableDbName) {
            _outsideSqlDao = outsideSqlDao;
            _tableDbName = tableDbName;
        }

        // ===============================================================================
        //                                                                          Select
        //                                                                          ======
        public MbListResultBean<ENTITY> SelectList<ENTITY>(String path, Object pmb) {
            IList<ENTITY> resultList = ToGenericList<ENTITY>(_outsideSqlDao.SelectList(path, pmb, CreateOutsideSqlOption(), typeof(ENTITY)));
            return new MbResultBeanBuilder<ENTITY>(_tableDbName).BuildListResultBean(resultList);
            
        }

        protected IList<ENTITY> ToGenericList<ENTITY>(System.Collections.IList plainList) {
            return MbDfCollectionUtil.ToGenericList<ENTITY>(plainList);
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
        public void Call(MbProcedurePmb pmb) {
            if (pmb == null) { throw new ArgumentNullException("The argument of call() 'pmb' should not be null!"); }
            _outsideSqlDao.Call(pmb.ProcedureName, pmb, CreateOutsideSqlOption());
        }

        // ===============================================================================
        //                                                                          Option
        //                                                                          ======
        public MbOutsideSqlCursorExecutor<Object> CursorHandling() {
            return new MbOutsideSqlCursorExecutor<Object>(_outsideSqlDao, CreateOutsideSqlOption());
        }

        public MbOutsideSqlEntityExecutor<Object> EntityHandling() {
            return new MbOutsideSqlEntityExecutor<Object>(_outsideSqlDao, CreateOutsideSqlOption());
        }

        public MbOutsideSqlPagingExecutor AutoPaging() {
            MbOutsideSqlOption option = CreateOutsideSqlOption();
            option.AutoPaging();
            return new MbOutsideSqlPagingExecutor(_outsideSqlDao, option, _tableDbName);
        }

        public MbOutsideSqlPagingExecutor ManualPaging() {
            MbOutsideSqlOption option = CreateOutsideSqlOption();
            option.ManualPaging();
            return new MbOutsideSqlPagingExecutor(_outsideSqlDao, option, _tableDbName);
        }

        public MbOutsideSqlBasicExecutor DynamicBinding() {
            _dynamicBinding = true;
            return this;
        }

        public MbOutsideSqlBasicExecutor Configure(MbStatementConfig statementConfig) {
            _statementConfig = statementConfig;
            return this;
        }

        // -------------------------------------------------
        //                                            Helper
        //                                            ------
        protected MbOutsideSqlOption CreateOutsideSqlOption() {
            MbOutsideSqlOption option = new MbOutsideSqlOption();
            option.StatementConfig = _statementConfig;
            if (_dynamicBinding) {
                option.DynamicBinding();
            }
			option.TableDbName = _tableDbName;
            return option;
        }
    }
}

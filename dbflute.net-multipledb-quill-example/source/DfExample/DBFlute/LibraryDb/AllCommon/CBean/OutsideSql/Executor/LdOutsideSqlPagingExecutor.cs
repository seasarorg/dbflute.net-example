
using System;
using System.Collections.Generic;

using DfExample.DBFlute.LibraryDb.AllCommon.CBean;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean.OutsideSql;
using DfExample.DBFlute.LibraryDb.AllCommon.Exp;
using DfExample.DBFlute.LibraryDb.AllCommon.Ado;
using DfExample.DBFlute.LibraryDb.AllCommon.Util;

namespace DfExample.DBFlute.LibraryDb.AllCommon.CBean.OutsideSql.Executor {

    public class LdOutsideSqlPagingExecutor {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected LdOutsideSqlDao _outsideSqlDao;
        protected LdOutsideSqlOption _outsideSqlOption;
        protected String _tableDbName;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public LdOutsideSqlPagingExecutor(LdOutsideSqlDao outsideSqlDao, LdOutsideSqlOption outsideSqlOption, String tableDbName) {
            this._outsideSqlDao = outsideSqlDao;
            this._outsideSqlOption = outsideSqlOption;
            this._tableDbName = tableDbName;
        }

        // ===============================================================================
        //                                                                          Select
        //                                                                          ======
        public LdListResultBean<ENTITY> SelectList<ENTITY>(String path, LdPagingBean pmb) {
            IList<ENTITY> resultList = ToGenericList<ENTITY>(_outsideSqlDao.SelectList(path, pmb, _outsideSqlOption, typeof(ENTITY)));
            return new LdResultBeanBuilder<ENTITY>(_tableDbName).BuildListResultBean(resultList);
        }

        protected IList<ENTITY> ToGenericList<ENTITY>(System.Collections.IList plainList) {
            return LdDfCollectionUtil.ToGenericList<ENTITY>(plainList);
        }

        public LdPagingResultBean<ENTITY> SelectPage<ENTITY>(String path, LdPagingBean pmb) {
            LdOutsideSqlOption countOption = _outsideSqlOption.CopyOptionWithoutPaging();
            LdOutsideSqlEntityExecutor<LdPagingBean> countExecutor
                    = new LdOutsideSqlEntityExecutor<LdPagingBean>(_outsideSqlDao, countOption);
            DefaultPagingHandler<ENTITY> handler
                    = new DefaultPagingHandler<ENTITY>(path, pmb, typeof(ENTITY), countExecutor, this, _tableDbName);
            LdPagingInvoker<ENTITY> invoker = new LdPagingInvoker<ENTITY>(_tableDbName);
            if (pmb.IsCountLater) {
                invoker.CountLater();
            }
            return invoker.InvokePaging(handler);
        }

        protected class DefaultPagingHandler<ENTITY> : LdPagingHandler<ENTITY> {
            protected String _path;
            protected LdPagingBean _pmb;
            protected Type _entityType;
            protected LdOutsideSqlEntityExecutor<LdPagingBean> _countExecutor;
            protected LdOutsideSqlPagingExecutor _pagingExecutor;
            protected String _tableDbName;

            public DefaultPagingHandler(String path, LdPagingBean pmb, Type entityType
                    , LdOutsideSqlEntityExecutor<LdPagingBean> countExecutor
                    , LdOutsideSqlPagingExecutor pagingExecutor, String tableDbName) {
                this._path = path;
                this._pmb = pmb;
                this._entityType = entityType;
                this._countExecutor = countExecutor;
                this._pagingExecutor = pagingExecutor;
                this._tableDbName = tableDbName;
            }

            public LdPagingBean PagingBean {
                get { return _pmb; }
            }

            public int Count() {
                _pmb.XSetPaging(false);
                try {
                    return _countExecutor.SelectEntityWithDeletedCheck<int>(_path, _pmb);
                } catch (LdEntityDuplicatedException e) { // means switching the select clause failed
                    throwPagingCountSelectNotCountException(_path, _pmb, _entityType, e);
                    return -1; // unreachable
                }
            }

            public IList<ENTITY> Paging() {
                _pmb.XSetPaging(true);
                return _pagingExecutor.SelectList<ENTITY>(_path, _pmb);
            }

            protected void throwPagingCountSelectNotCountException(String path, LdPagingBean pmb,
                    Type entityType, LdEntityDuplicatedException e) {
                String msg = "Look! Read the message below." + ln();
                msg = msg + "/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *" + ln();
                msg = msg + "The count select for paging could not get a count." + ln();
                msg = msg + ln();
                msg = msg + "[Advice]" + ln();
                msg = msg + "A select clause of OutsideSql paging should be switchable like this:" + ln();
                msg = msg + "For example:" + ln();
                msg = msg + "  /*IF pmb.IsPaging*/" + ln();
                msg = msg + "  select member.MEMBER_ID" + ln();
                msg = msg + "       , member.MEMBER_NAME" + ln();
                msg = msg + "       , ..." + ln();
                msg = msg + "  -- ELSE select count(*)" + ln();
                msg = msg + "  /*END*/" + ln();
                msg = msg + "    from ..." + ln();
                msg = msg + "   where ..." + ln();
                msg = msg + ln();
                msg = msg + "This specificaton is for both ManualPaging and AutoPaging." + ln();
                msg = msg + "(AutoPaging is only allowed to omit a paging condition)" + ln();
                msg = msg + ln();
                msg = msg + "[Table]" + ln() + _tableDbName + ln();
                msg = msg + ln();
                msg = msg + "[OutsideSql]" + ln() + path + ln();
                msg = msg + ln();
                msg = msg + "[ParameterBean]" + ln() + pmb + ln();
                msg = msg + ln();
                msg = msg + "[Entity Type]" + ln() + entityType + ln();
                msg = msg + "* * * * * * * * * */";
                throw new SystemException(msg, e);
            }
        }

        // ===============================================================================
        //                                                                          Option
        //                                                                          ======
        public LdOutsideSqlPagingExecutor Configure(LdStatementConfig statementConfig) {
            _outsideSqlOption.StatementConfig = statementConfig;
            return this;
        }

        public LdOutsideSqlPagingExecutor DynamicBinding() {
            _outsideSqlOption.DynamicBinding();
            return this;
        }

    	// ===============================================================================
        //                                                                  General Helper
        //                                                                  ==============
        protected static String ln() {
            return LdSimpleSystemUtil.GetLineSeparator();
        }
    }
}

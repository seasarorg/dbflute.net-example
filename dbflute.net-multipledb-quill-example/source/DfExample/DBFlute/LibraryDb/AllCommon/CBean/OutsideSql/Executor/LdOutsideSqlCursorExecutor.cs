
using System;

using DfExample.DBFlute.LibraryDb.AllCommon.CBean.OutsideSql;
using DfExample.DBFlute.LibraryDb.AllCommon.Ado;

namespace DfExample.DBFlute.LibraryDb.AllCommon.CBean.OutsideSql.Executor {

    public class LdOutsideSqlCursorExecutor<PARAMETER_BEAN> {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected LdOutsideSqlDao _outsideSqlDao;

        protected LdOutsideSqlOption _outsideSqlOption;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public LdOutsideSqlCursorExecutor(LdOutsideSqlDao outsideSqlDao, LdOutsideSqlOption outsideSqlOption) {
            this._outsideSqlDao = outsideSqlDao;
            this._outsideSqlOption = outsideSqlOption;
        }

        // ===============================================================================
        //                                                                          Select
        //                                                                          ======
        public Object SelectCursor(String path, PARAMETER_BEAN pmb, LdCursorHandler handler) {
            return _outsideSqlDao.SelectCursor(path, pmb, _outsideSqlOption, handler);
        }

        // ===============================================================================
        //                                                                          Option
        //                                                                          ======
        public LdOutsideSqlCursorExecutor<PARAMETER_BEAN> Configure(LdStatementConfig statementConfig) {
            _outsideSqlOption.StatementConfig = statementConfig;
            return this;
        }

        public LdOutsideSqlCursorExecutor<PARAMETER_BEAN> DynamicBinding() {
            _outsideSqlOption.DynamicBinding();
            return this;
        }
    }
}

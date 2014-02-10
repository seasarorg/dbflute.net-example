
using System;

using DfExample.DBFlute.MemberDb.AllCommon.CBean.OutsideSql;
using DfExample.DBFlute.MemberDb.AllCommon.Ado;

namespace DfExample.DBFlute.MemberDb.AllCommon.CBean.OutsideSql.Executor {

    public class MbOutsideSqlCursorExecutor<PARAMETER_BEAN> {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected MbOutsideSqlDao _outsideSqlDao;

        protected MbOutsideSqlOption _outsideSqlOption;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public MbOutsideSqlCursorExecutor(MbOutsideSqlDao outsideSqlDao, MbOutsideSqlOption outsideSqlOption) {
            this._outsideSqlDao = outsideSqlDao;
            this._outsideSqlOption = outsideSqlOption;
        }

        // ===============================================================================
        //                                                                          Select
        //                                                                          ======
        public Object SelectCursor(String path, PARAMETER_BEAN pmb, MbCursorHandler handler) {
            return _outsideSqlDao.SelectCursor(path, pmb, _outsideSqlOption, handler);
        }

        // ===============================================================================
        //                                                                          Option
        //                                                                          ======
        public MbOutsideSqlCursorExecutor<PARAMETER_BEAN> Configure(MbStatementConfig statementConfig) {
            _outsideSqlOption.StatementConfig = statementConfig;
            return this;
        }

        public MbOutsideSqlCursorExecutor<PARAMETER_BEAN> DynamicBinding() {
            _outsideSqlOption.DynamicBinding();
            return this;
        }
    }
}

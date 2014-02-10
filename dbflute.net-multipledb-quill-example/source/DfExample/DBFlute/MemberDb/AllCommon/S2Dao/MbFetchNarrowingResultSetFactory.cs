
using System;
using System.Data;
using System.Data.Common;
using System.Reflection;
using System.Text;

using Seasar.Framework.Exceptions;
using Seasar.Framework.Util;
using Seasar.Extension.ADO;

using DfExample.DBFlute.MemberDb.AllCommon.CBean;
using DfExample.DBFlute.MemberDb.AllCommon.CBean.OutsideSql;
using DfExample.DBFlute.MemberDb.AllCommon.S2Dao.Internal.SqlHandler;

namespace DfExample.DBFlute.MemberDb.AllCommon.S2Dao {

    public class MbFetchNarrowingResultSetFactory : IDataReaderFactory {

        public MbFetchNarrowingResultSetFactory() {
        }

        public IDataReader CreateDataReader(IDataSource dataSource, IDbCommand cmd) {
            IDataReader dataReader = ExecuteReader(dataSource, cmd);
            if (!IsUseFetchNarrowingResultSetWrapper()) {
                return dataReader;
            }
            MbFetchNarrowingBean fnbean = MbFetchNarrowingBeanContext.GetFetchNarrowingBeanOnThread();
            MbFetchNarrowingResultSetWrapper wrapper = null;
            if (MbOutsideSqlContext.IsExistOutsideSqlContextOnThread()) {
                MbOutsideSqlContext outsideSqlContext = MbOutsideSqlContext.GetOutsideSqlContextOnThread();
                wrapper = new MbFetchNarrowingResultSetWrapper(dataReader, fnbean
                              , outsideSqlContext.IsOffsetByCursorForcedly
                              , outsideSqlContext.IsLimitByCursorForcedly);
            } else {
                wrapper = new MbFetchNarrowingResultSetWrapper(dataReader, fnbean, false, false);
            }
            return wrapper;
        }

        protected bool IsUseFetchNarrowingResultSetWrapper() {
            MbFetchNarrowingBean fnbean = MbFetchNarrowingBeanContext.GetFetchNarrowingBeanOnThread();

            // for safety result
            if (fnbean != null && fnbean.SafetyMaxResultSize > 0) {
                return true;
            }

            // for unsupported paging (ConditionBean)
            if (fnbean != null && fnbean.IsFetchNarrowingEffective) {
                // for unsupported paging (Database)
                if (fnbean.IsFetchNarrowingSkipStartIndexEffective || fnbean.IsFetchNarrowingLoopCountEffective) {
                    return true;
                }

                // for auto paging (OutsideSql)
                if (MbOutsideSqlContext.IsExistOutsideSqlContextOnThread()) {
                    MbOutsideSqlContext outsideSqlContext = MbOutsideSqlContext.GetOutsideSqlContextOnThread();
                    if (outsideSqlContext.IsOffsetByCursorForcedly || outsideSqlContext.IsLimitByCursorForcedly) {
                        return true;
                    }
                }
            }
            return false;
        }

        protected IDataReader ExecuteReader(IDataSource dataSource, IDbCommand cmd) {
            return CommandUtil.ExecuteReader(dataSource, cmd);
        }
    }
}

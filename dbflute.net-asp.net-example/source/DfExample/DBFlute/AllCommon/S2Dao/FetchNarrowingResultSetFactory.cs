
using System;
using System.Data;
using System.Data.Common;
using System.Reflection;
using System.Text;

using Seasar.Framework.Exceptions;
using Seasar.Framework.Util;
using Seasar.Extension.ADO;

using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.CBean.OutsideSql;
using DfExample.DBFlute.AllCommon.S2Dao.Internal.SqlHandler;

namespace DfExample.DBFlute.AllCommon.S2Dao {

    public class FetchNarrowingResultSetFactory : IDataReaderFactory {

        public FetchNarrowingResultSetFactory() {
        }

        public IDataReader CreateDataReader(IDataSource dataSource, IDbCommand cmd) {
            IDataReader dataReader = ExecuteReader(dataSource, cmd);
            if (!IsUseFetchNarrowingResultSetWrapper()) {
                return dataReader;
            }
            FetchNarrowingBean fnbean = FetchNarrowingBeanContext.GetFetchNarrowingBeanOnThread();
            FetchNarrowingResultSetWrapper wrapper = null;
            if (OutsideSqlContext.IsExistOutsideSqlContextOnThread()) {
                OutsideSqlContext outsideSqlContext = OutsideSqlContext.GetOutsideSqlContextOnThread();
                wrapper = new FetchNarrowingResultSetWrapper(dataReader, fnbean
                              , outsideSqlContext.IsOffsetByCursorForcedly
                              , outsideSqlContext.IsLimitByCursorForcedly);
            } else {
                wrapper = new FetchNarrowingResultSetWrapper(dataReader, fnbean, false, false);
            }
            return wrapper;
        }

        protected bool IsUseFetchNarrowingResultSetWrapper() {
            FetchNarrowingBean fnbean = FetchNarrowingBeanContext.GetFetchNarrowingBeanOnThread();

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
                if (OutsideSqlContext.IsExistOutsideSqlContextOnThread()) {
                    OutsideSqlContext outsideSqlContext = OutsideSqlContext.GetOutsideSqlContextOnThread();
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

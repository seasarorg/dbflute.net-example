
using System;
using System.Data;
using System.Data.Common;
using System.Reflection;
using System.Text;

using Seasar.Framework.Exceptions;
using Seasar.Framework.Util;
using Seasar.Extension.ADO;

using DfExample.DBFlute.LibraryDb.AllCommon.CBean;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean.OutsideSql;
using DfExample.DBFlute.LibraryDb.AllCommon.S2Dao.Internal.SqlHandler;

namespace DfExample.DBFlute.LibraryDb.AllCommon.S2Dao {

    public class LdFetchNarrowingResultSetFactory : IDataReaderFactory {

        public LdFetchNarrowingResultSetFactory() {
        }

        public IDataReader CreateDataReader(IDataSource dataSource, IDbCommand cmd) {
            IDataReader dataReader = ExecuteReader(dataSource, cmd);
            if (!IsUseFetchNarrowingResultSetWrapper()) {
                return dataReader;
            }
            LdFetchNarrowingBean fnbean = LdFetchNarrowingBeanContext.GetFetchNarrowingBeanOnThread();
            LdFetchNarrowingResultSetWrapper wrapper = null;
            if (LdOutsideSqlContext.IsExistOutsideSqlContextOnThread()) {
                LdOutsideSqlContext outsideSqlContext = LdOutsideSqlContext.GetOutsideSqlContextOnThread();
                wrapper = new LdFetchNarrowingResultSetWrapper(dataReader, fnbean
                              , outsideSqlContext.IsOffsetByCursorForcedly
                              , outsideSqlContext.IsLimitByCursorForcedly);
            } else {
                wrapper = new LdFetchNarrowingResultSetWrapper(dataReader, fnbean, false, false);
            }
            return wrapper;
        }

        protected bool IsUseFetchNarrowingResultSetWrapper() {
            LdFetchNarrowingBean fnbean = LdFetchNarrowingBeanContext.GetFetchNarrowingBeanOnThread();

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
                if (LdOutsideSqlContext.IsExistOutsideSqlContextOnThread()) {
                    LdOutsideSqlContext outsideSqlContext = LdOutsideSqlContext.GetOutsideSqlContextOnThread();
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

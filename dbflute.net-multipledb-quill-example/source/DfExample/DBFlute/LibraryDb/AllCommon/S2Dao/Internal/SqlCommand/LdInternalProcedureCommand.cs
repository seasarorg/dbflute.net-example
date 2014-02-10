
using System;

using Seasar.Extension.ADO;
using Seasar.Dao;

using DfExample.DBFlute.LibraryDb.AllCommon.JavaLike;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean.OutsideSql;
using DfExample.DBFlute.LibraryDb.AllCommon.S2Dao;
using DfExample.DBFlute.LibraryDb.AllCommon.S2Dao.Internal.SqlHandler;

namespace DfExample.DBFlute.LibraryDb.AllCommon.S2Dao.Internal.SqlCommand {

public class LdInternalProcedureCommand : ISqlCommand {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected IDataSource _dataSource;
        protected IDataReaderHandler _dataReaderHandler;
        protected ICommandFactory _commandFactory;
        protected IDataReaderFactory _dataReaderFactory;
        protected InternalProcedureMetaData _procedureMetaData;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public LdInternalProcedureCommand(IDataSource dataSource, IDataReaderHandler dataReaderHandler,
                ICommandFactory commandFactory, IDataReaderFactory dataReaderFactory,
                InternalProcedureMetaData procedureMetaData) {
            this._dataSource = dataSource;
            this._dataReaderHandler = dataReaderHandler;
            this._commandFactory = commandFactory;
            this._dataReaderFactory = dataReaderFactory;
            this._procedureMetaData = procedureMetaData;
        }

	    // ===============================================================================
        //                                                                         Execute
        //                                                                         =======
        public Object Execute(Object[] args) {
            LdInternalProcedureHandler handler = NewArgumentDtoProcedureHandler();
            LdOutsideSqlContext outsideSqlContext = LdOutsideSqlContext.GetOutsideSqlContextOnThread();
            Object pmb = outsideSqlContext.ParameterBean;
            // The logging message SQL of procedure is unnecessary.
            // handler.LoggingMessageSqlArgs = ...;
            return handler.Execute(new Object[]{pmb});
        }
        protected LdInternalProcedureHandler NewArgumentDtoProcedureHandler() {
            return new LdInternalProcedureHandler(_dataSource, CreateSql(_procedureMetaData), _dataReaderHandler,
                    _commandFactory, _dataReaderFactory, _procedureMetaData);
        }
        protected String CreateSql(InternalProcedureMetaData procedureMetaData) {
            // StringBuilder sb = new StringBuilder();
            // sb.append("{");
            // int size = procedureMetaData.ParameterTypeSize;
            // if (procedureMetaData.HasReturnParameterType) {
            //     sb.append("? = ");
            //     size--;
            // }
            // sb.append("call ").append(procedureMetaData.ProcedureName).append("(");
            // for (int i = 0; i < size; i++) {
            //     sb.append("?, ");
            // }
            // if (size > 0) {
            //     sb = new StringBuilder().append(sb.toString().Substring(0, sb.length() - 2));
            // }
            // sb.append(")}");
            // return sb.toString();

            // The procedure name is SQL at CSharp!
            return procedureMetaData.ProcedureName;
        }
    }
}

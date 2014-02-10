
using System;
using System.Text;
using Seasar.Extension.ADO;
using Seasar.Dao;
using Seasar.Dao.Impl;

using DfExample.DBFlute.LibraryDb.AllCommon.S2Dao.Internal.SqlHandler;

namespace DfExample.DBFlute.LibraryDb.AllCommon.S2Dao.Internal.SqlCommand {

    public class LdInternalUpdateDynamicCommand : AbstractDynamicCommand {

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public LdInternalUpdateDynamicCommand(IDataSource dataSource, ICommandFactory commandFactory)
            : base(dataSource, commandFactory) {
        }

        // ===============================================================================
        //                                                                         Execute
        //                                                                         =======
        public override object Execute(object[] args) {
            ICommandContext ctx = Apply(args);
            LdInternalBasicUpdateHandler handler = new LdInternalBasicUpdateHandler(DataSource, ctx.Sql, CommandFactory);
            Object[] bindVariables = ctx.BindVariables;
            handler.LoggingMessageSqlArgs = bindVariables;
            return handler.Execute(bindVariables, ctx.BindVariableTypes);
        }
	}
}


using System;
using System.Text;
using Seasar.Extension.ADO;
using Seasar.Dao;
using Seasar.Dao.Impl;

using DfExample.DBFlute.MemberDb.AllCommon.S2Dao.Internal.SqlHandler;

namespace DfExample.DBFlute.MemberDb.AllCommon.S2Dao.Internal.SqlCommand {

    public class MbInternalUpdateDynamicCommand : AbstractDynamicCommand {

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public MbInternalUpdateDynamicCommand(IDataSource dataSource, ICommandFactory commandFactory)
            : base(dataSource, commandFactory) {
        }

        // ===============================================================================
        //                                                                         Execute
        //                                                                         =======
        public override object Execute(object[] args) {
            ICommandContext ctx = Apply(args);
            MbInternalBasicUpdateHandler handler = new MbInternalBasicUpdateHandler(DataSource, ctx.Sql, CommandFactory);
            Object[] bindVariables = ctx.BindVariables;
            handler.LoggingMessageSqlArgs = bindVariables;
            return handler.Execute(bindVariables, ctx.BindVariableTypes);
        }
	}
}

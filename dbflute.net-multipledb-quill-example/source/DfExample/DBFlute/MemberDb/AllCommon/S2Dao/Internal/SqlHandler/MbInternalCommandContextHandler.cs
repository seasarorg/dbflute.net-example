
using System;
using System.Data;

using Seasar.Dao;
using Seasar.Extension.ADO;
using Seasar.Extension.ADO.Impl;
using Seasar.Framework.Util;

using DfExample.DBFlute.MemberDb.AllCommon;
using DfExample.DBFlute.MemberDb.AllCommon.Util;

namespace DfExample.DBFlute.MemberDb.AllCommon.S2Dao.Internal.SqlHandler {

    public class MbInternalCommandContextHandler : MbInternalBasicHandler {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected ICommandContext commandContext;
    
        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public MbInternalCommandContextHandler(IDataSource dataSource, ICommandFactory commandFactory, ICommandContext commandContext)
            : base(dataSource, commandContext.Sql, commandFactory) {
            this.commandContext = commandContext;
        }

        // ===============================================================================
        //                                                                         Execute
        //                                                                         =======
        public int Execute(Object[] args) {
            IDbConnection conn = Connection;
            try {
                return Execute(conn, commandContext);
            } finally {
                Close(conn);
            }
        }

        protected int Execute(IDbConnection conn, ICommandContext context) {
            LogSql(context.BindVariables, GetArgTypes(context.BindVariables));
            IDbCommand cmd = Command(conn);
            try {
                BindArgs(cmd, context.BindVariables, context.BindVariableTypes);
                return ExecuteUpdate(cmd);
            } finally {
                Close(cmd);
            }
        }
    }
}

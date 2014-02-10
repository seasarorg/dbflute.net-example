
using System;
using Seasar.Extension.ADO;
using Seasar.Dao;

using DfExample.DBFlute.LibraryDb.AllCommon.S2Dao.Internal.SqlParser;
using DfExample.DBFlute.LibraryDb.AllCommon.S2Dao.Internal.SqlHandler;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean;
using DfExample.DBFlute.LibraryDb.AllCommon.JavaLike;
using DfExample.DBFlute.LibraryDb.AllCommon.Util;

namespace DfExample.DBFlute.LibraryDb.AllCommon.S2Dao.Internal.SqlCommand {

public class LdInternalDeleteQueryAutoDynamicCommand : ISqlCommand {

    // ===================================================================================
    //                                                                           Attribute
    //                                                                           =========
    protected IDataSource dataSource;
    protected ICommandFactory commandFactory;

    // ===================================================================================
    //                                                                         Constructor
    //                                                                         ===========
    public LdInternalDeleteQueryAutoDynamicCommand(IDataSource dataSource, ICommandFactory commandFactory) {
        this.dataSource = dataSource;
        this.commandFactory = commandFactory;
    }

    // ===================================================================================
    //                                                                             Execute
    //                                                                             =======
    public Object Execute(Object[] args) {
        LdConditionBean cb = extractConditionBeanWithCheck(args);
        String[] argNames = new String[]{"pmb"};
        Type[] argTypes = new Type[]{cb.GetType()};
        String twoWaySql = buildQueryDeleteTwoWaySql(cb);
        ICommandContext context = createCommandContext(twoWaySql, argNames, argTypes, args);
        LdInternalCommandContextHandler handler = createCommandContextHandler(context);
        handler.LoggingMessageSqlArgs = context.BindVariables;
        int rows = handler.Execute(args);
        return rows;
    }
    
    protected LdConditionBean extractConditionBeanWithCheck(Object[] args) {
        if (args == null || args.Length == 0) {
            String msg = "The arguments should have one argument! But:";
            msg = msg + " args=" + (args != null ? "" + args.Length : "null");
            throw new IllegalArgumentException(msg);
        }
        Object fisrtArg = args[0];
        if (!(fisrtArg is LdConditionBean)) {
            String msg = "The type of argument should be " + typeof(LdConditionBean) + "! But:";
            msg = msg + " type=" + fisrtArg.GetType();
            throw new IllegalArgumentException(msg);
        }
        return (LdConditionBean) fisrtArg;
    }
    
    protected LdInternalCommandContextHandler createCommandContextHandler(ICommandContext context) {
        return new LdInternalCommandContextHandler(dataSource, commandFactory, context);
    }

    protected String buildQueryDeleteTwoWaySql(LdConditionBean cb) {
        return cb.SqlClause.getClauseQueryDelete();
    }
    
    protected ICommandContext createCommandContext(String twoWaySql, String[] argNames, Type[] argTypes, Object[] args) {
        ICommandContext context;
        {
            LdInternalSqlParser parser = new LdInternalSqlParser(twoWaySql, true);
            INode node = parser.Parse();
            LdInternalCommandContextCreator creator = new LdInternalCommandContextCreator(argNames, argTypes);
            context = creator.CreateCommandContext(args);
            node.Accept(context);
        }
        return context;
    }
	
    // ===================================================================================
    //                                                                      General Helper
    //                                                                      ==============
    protected String getLineSeparator() {
        return LdSimpleSystemUtil.GetLineSeparator();
    }
}

}

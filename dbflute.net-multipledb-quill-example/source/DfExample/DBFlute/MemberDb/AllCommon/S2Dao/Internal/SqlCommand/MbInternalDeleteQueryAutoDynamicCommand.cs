
using System;
using Seasar.Extension.ADO;
using Seasar.Dao;

using DfExample.DBFlute.MemberDb.AllCommon.S2Dao.Internal.SqlParser;
using DfExample.DBFlute.MemberDb.AllCommon.S2Dao.Internal.SqlHandler;
using DfExample.DBFlute.MemberDb.AllCommon.CBean;
using DfExample.DBFlute.MemberDb.AllCommon.JavaLike;
using DfExample.DBFlute.MemberDb.AllCommon.Util;

namespace DfExample.DBFlute.MemberDb.AllCommon.S2Dao.Internal.SqlCommand {

public class MbInternalDeleteQueryAutoDynamicCommand : ISqlCommand {

    // ===================================================================================
    //                                                                           Attribute
    //                                                                           =========
    protected IDataSource dataSource;
    protected ICommandFactory commandFactory;

    // ===================================================================================
    //                                                                         Constructor
    //                                                                         ===========
    public MbInternalDeleteQueryAutoDynamicCommand(IDataSource dataSource, ICommandFactory commandFactory) {
        this.dataSource = dataSource;
        this.commandFactory = commandFactory;
    }

    // ===================================================================================
    //                                                                             Execute
    //                                                                             =======
    public Object Execute(Object[] args) {
        MbConditionBean cb = extractConditionBeanWithCheck(args);
        String[] argNames = new String[]{"pmb"};
        Type[] argTypes = new Type[]{cb.GetType()};
        String twoWaySql = buildQueryDeleteTwoWaySql(cb);
        ICommandContext context = createCommandContext(twoWaySql, argNames, argTypes, args);
        MbInternalCommandContextHandler handler = createCommandContextHandler(context);
        handler.LoggingMessageSqlArgs = context.BindVariables;
        int rows = handler.Execute(args);
        return rows;
    }
    
    protected MbConditionBean extractConditionBeanWithCheck(Object[] args) {
        if (args == null || args.Length == 0) {
            String msg = "The arguments should have one argument! But:";
            msg = msg + " args=" + (args != null ? "" + args.Length : "null");
            throw new IllegalArgumentException(msg);
        }
        Object fisrtArg = args[0];
        if (!(fisrtArg is MbConditionBean)) {
            String msg = "The type of argument should be " + typeof(MbConditionBean) + "! But:";
            msg = msg + " type=" + fisrtArg.GetType();
            throw new IllegalArgumentException(msg);
        }
        return (MbConditionBean) fisrtArg;
    }
    
    protected MbInternalCommandContextHandler createCommandContextHandler(ICommandContext context) {
        return new MbInternalCommandContextHandler(dataSource, commandFactory, context);
    }

    protected String buildQueryDeleteTwoWaySql(MbConditionBean cb) {
        return cb.SqlClause.getClauseQueryDelete();
    }
    
    protected ICommandContext createCommandContext(String twoWaySql, String[] argNames, Type[] argTypes, Object[] args) {
        ICommandContext context;
        {
            MbInternalSqlParser parser = new MbInternalSqlParser(twoWaySql, true);
            INode node = parser.Parse();
            MbInternalCommandContextCreator creator = new MbInternalCommandContextCreator(argNames, argTypes);
            context = creator.CreateCommandContext(args);
            node.Accept(context);
        }
        return context;
    }
	
    // ===================================================================================
    //                                                                      General Helper
    //                                                                      ==============
    protected String getLineSeparator() {
        return MbSimpleSystemUtil.GetLineSeparator();
    }
}

}

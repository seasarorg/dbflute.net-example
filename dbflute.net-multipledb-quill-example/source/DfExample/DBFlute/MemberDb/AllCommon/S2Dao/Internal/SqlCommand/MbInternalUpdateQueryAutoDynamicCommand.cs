
using System;
using System.Reflection;

using Seasar.Extension.ADO;
using Seasar.Dao;

using DfExample.DBFlute.MemberDb.AllCommon.S2Dao.Internal.SqlParser;
using DfExample.DBFlute.MemberDb.AllCommon.S2Dao.Internal.SqlHandler;
using DfExample.DBFlute.MemberDb.AllCommon.CBean;
using DfExample.DBFlute.MemberDb.AllCommon.Dbm;
using DfExample.DBFlute.MemberDb.AllCommon.Dbm.Info;
using DfExample.DBFlute.MemberDb.AllCommon.JavaLike;
using DfExample.DBFlute.MemberDb.AllCommon.Util;

namespace DfExample.DBFlute.MemberDb.AllCommon.S2Dao.Internal.SqlCommand {

public class MbInternalUpdateQueryAutoDynamicCommand : ISqlCommand {

    // ===================================================================================
    //                                                                           Attribute
    //                                                                           =========
    protected IDataSource dataSource;
    protected ICommandFactory commandFactory;

    // ===================================================================================
    //                                                                         Constructor
    //                                                                         ===========
    public MbInternalUpdateQueryAutoDynamicCommand(IDataSource dataSource, ICommandFactory commandFactory) {
        this.dataSource = dataSource;
        this.commandFactory = commandFactory;
    }

    // ===================================================================================
    //                                                                             Execute
    //                                                                             =======
    public Object Execute(Object[] args) {
        MbConditionBean cb = extractConditionBeanWithCheck(args);
        MbEntity entity = extractEntityWithCheck(args);
        String[] argNames = new String[]{"pmb", "entity"};
        Type[] argTypes = new Type[]{cb.GetType(), entity.GetType()};
        String twoWaySql = buildQueryUpdateTwoWaySql(cb, entity);
        if (twoWaySql == null) {
            return 0;// No execute!
        }
        ICommandContext context = createCommandContext(twoWaySql, argNames, argTypes, args);
        MbInternalCommandContextHandler handler = createCommandContextHandler(context);
        handler.LoggingMessageSqlArgs = context.BindVariables;
        return handler.Execute(args);
    }
    
    protected MbConditionBean extractConditionBeanWithCheck(Object[] args) {
        assertArgument(args);
        Object fisrtArg = args[0];
        if (!(fisrtArg is MbConditionBean)) {
            String msg = "The type of first argument should be " + typeof(MbConditionBean) + "! But:";
            msg = msg + " type=" + fisrtArg.GetType();
            throw new IllegalArgumentException(msg);
        }
        return (MbConditionBean) fisrtArg;
    }
    
    protected MbEntity extractEntityWithCheck(Object[] args) {
        assertArgument(args);
        Object secondArg = args[1];
        if (!(secondArg is MbEntity)) {
            String msg = "The type of second argument should be " + typeof(MbEntity) + "! But:";
            msg = msg + " type=" + secondArg.GetType();
            throw new IllegalArgumentException(msg);
        }
        return (MbEntity) secondArg;
    }
	
    protected void assertArgument(Object[] args) {
        if (args == null || args.Length <= 1) {
            String msg = "The arguments should have two argument! But:";
            msg = msg + " args=" + (args != null ? "" + args.Length : "null");
            throw new IllegalArgumentException(msg);
        }
    }
    
    protected MbInternalCommandContextHandler createCommandContextHandler(ICommandContext context) {
        return new MbInternalCommandContextHandler(dataSource, commandFactory, context);
    }

    /**
     * @param cb Condition-bean. (NotNull)
     * @param entity Entity. (NotNull)
     * @return The two-way SQL of query update. (NullAllowed: If the set of modified properties is empty, return null.)
     */
    protected String buildQueryUpdateTwoWaySql(MbConditionBean cb, MbEntity entity) {
        Map<String, String> columnParameterMap = new LinkedHashMap<String, String>();
        MbDBMeta dbmeta = MbDBMetaInstanceHandler.FindDBMeta(entity.TableDbName);
        System.Collections.Generic.IDictionary<String, Object> modifiedPropertyNames = entity.ModifiedPropertyNames;
        if (modifiedPropertyNames.Count == 0) {
            return null;
        }
        String currentPropertyName = null;
        foreach (String propertyName in modifiedPropertyNames.Keys) {
            currentPropertyName = propertyName;
            MbColumnInfo columnInfo = dbmeta.FindColumnInfo(propertyName);
            String columnName = columnInfo.ColumnDbName;
            PropertyInfo getter = columnInfo.FindProperty();
            Object value = getter.GetValue(entity, null);
            if (value != null) {
                columnParameterMap.put(columnName, "/*entity." + propertyName + "*/null");
            } else {
                columnParameterMap.put(columnName, "null");
            }
        }
        if (dbmeta.HasVersionNo) {
            MbColumnInfo columnInfo = dbmeta.VersionNoColumnInfo;
            String columnName = columnInfo.ColumnDbName;
            columnParameterMap.put(columnName, columnName + " + 1");
        }
        if (dbmeta.HasUpdateDate) {
            MbColumnInfo columnInfo = dbmeta.UpdateDateColumnInfo;
            PropertyInfo setter = columnInfo.FindProperty();
            setter.SetValue(entity, DateTime.Now, null);
            String columnName = columnInfo.ColumnDbName;
            columnParameterMap.put(columnName, "/*entity." + columnInfo.PropertyName + "*/null");
        }
        return cb.SqlClause.getClauseQueryUpdate(columnParameterMap);
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

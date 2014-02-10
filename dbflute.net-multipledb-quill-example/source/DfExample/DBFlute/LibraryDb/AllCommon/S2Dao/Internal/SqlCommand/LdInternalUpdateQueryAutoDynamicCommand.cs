
using System;
using System.Reflection;

using Seasar.Extension.ADO;
using Seasar.Dao;

using DfExample.DBFlute.LibraryDb.AllCommon.S2Dao.Internal.SqlParser;
using DfExample.DBFlute.LibraryDb.AllCommon.S2Dao.Internal.SqlHandler;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean;
using DfExample.DBFlute.LibraryDb.AllCommon.Dbm;
using DfExample.DBFlute.LibraryDb.AllCommon.Dbm.Info;
using DfExample.DBFlute.LibraryDb.AllCommon.JavaLike;
using DfExample.DBFlute.LibraryDb.AllCommon.Util;

namespace DfExample.DBFlute.LibraryDb.AllCommon.S2Dao.Internal.SqlCommand {

public class LdInternalUpdateQueryAutoDynamicCommand : ISqlCommand {

    // ===================================================================================
    //                                                                           Attribute
    //                                                                           =========
    protected IDataSource dataSource;
    protected ICommandFactory commandFactory;

    // ===================================================================================
    //                                                                         Constructor
    //                                                                         ===========
    public LdInternalUpdateQueryAutoDynamicCommand(IDataSource dataSource, ICommandFactory commandFactory) {
        this.dataSource = dataSource;
        this.commandFactory = commandFactory;
    }

    // ===================================================================================
    //                                                                             Execute
    //                                                                             =======
    public Object Execute(Object[] args) {
        LdConditionBean cb = extractConditionBeanWithCheck(args);
        LdEntity entity = extractEntityWithCheck(args);
        String[] argNames = new String[]{"pmb", "entity"};
        Type[] argTypes = new Type[]{cb.GetType(), entity.GetType()};
        String twoWaySql = buildQueryUpdateTwoWaySql(cb, entity);
        if (twoWaySql == null) {
            return 0;// No execute!
        }
        ICommandContext context = createCommandContext(twoWaySql, argNames, argTypes, args);
        LdInternalCommandContextHandler handler = createCommandContextHandler(context);
        handler.LoggingMessageSqlArgs = context.BindVariables;
        return handler.Execute(args);
    }
    
    protected LdConditionBean extractConditionBeanWithCheck(Object[] args) {
        assertArgument(args);
        Object fisrtArg = args[0];
        if (!(fisrtArg is LdConditionBean)) {
            String msg = "The type of first argument should be " + typeof(LdConditionBean) + "! But:";
            msg = msg + " type=" + fisrtArg.GetType();
            throw new IllegalArgumentException(msg);
        }
        return (LdConditionBean) fisrtArg;
    }
    
    protected LdEntity extractEntityWithCheck(Object[] args) {
        assertArgument(args);
        Object secondArg = args[1];
        if (!(secondArg is LdEntity)) {
            String msg = "The type of second argument should be " + typeof(LdEntity) + "! But:";
            msg = msg + " type=" + secondArg.GetType();
            throw new IllegalArgumentException(msg);
        }
        return (LdEntity) secondArg;
    }
	
    protected void assertArgument(Object[] args) {
        if (args == null || args.Length <= 1) {
            String msg = "The arguments should have two argument! But:";
            msg = msg + " args=" + (args != null ? "" + args.Length : "null");
            throw new IllegalArgumentException(msg);
        }
    }
    
    protected LdInternalCommandContextHandler createCommandContextHandler(ICommandContext context) {
        return new LdInternalCommandContextHandler(dataSource, commandFactory, context);
    }

    /**
     * @param cb Condition-bean. (NotNull)
     * @param entity Entity. (NotNull)
     * @return The two-way SQL of query update. (NullAllowed: If the set of modified properties is empty, return null.)
     */
    protected String buildQueryUpdateTwoWaySql(LdConditionBean cb, LdEntity entity) {
        Map<String, String> columnParameterMap = new LinkedHashMap<String, String>();
        LdDBMeta dbmeta = LdDBMetaInstanceHandler.FindDBMeta(entity.TableDbName);
        System.Collections.Generic.IDictionary<String, Object> modifiedPropertyNames = entity.ModifiedPropertyNames;
        if (modifiedPropertyNames.Count == 0) {
            return null;
        }
        String currentPropertyName = null;
        foreach (String propertyName in modifiedPropertyNames.Keys) {
            currentPropertyName = propertyName;
            LdColumnInfo columnInfo = dbmeta.FindColumnInfo(propertyName);
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
            LdColumnInfo columnInfo = dbmeta.VersionNoColumnInfo;
            String columnName = columnInfo.ColumnDbName;
            columnParameterMap.put(columnName, columnName + " + 1");
        }
        if (dbmeta.HasUpdateDate) {
            LdColumnInfo columnInfo = dbmeta.UpdateDateColumnInfo;
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


using System;
using System.Data;
using System.Reflection;
using System.Collections.Generic;

using Seasar.Extension.ADO;
using Seasar.Extension.ADO.Impl;
using Seasar.Framework.Util;
using Seasar.Dao;
using Seasar.Dao.Impl;
using Seasar.Dao.Node;
using Seasar.Dao.Parser;

using DfExample.DBFlute.MemberDb.AllCommon;
using DfExample.DBFlute.MemberDb.AllCommon.CBean;
using DfExample.DBFlute.MemberDb.AllCommon.CBean.OutsideSql;
using DfExample.DBFlute.MemberDb.AllCommon.Exp;
using DfExample.DBFlute.MemberDb.AllCommon.JavaLike;
using DfExample.DBFlute.MemberDb.AllCommon.S2Dao.Internal.SqlHandler;
using DfExample.DBFlute.MemberDb.AllCommon.S2Dao.Internal.SqlParser;
using DfExample.DBFlute.MemberDb.AllCommon.Util;

namespace DfExample.DBFlute.MemberDb.AllCommon.S2Dao {

    /**
     * @author DBFlute(AutoGenerator)
     */
    public class MbS2DaoSelectDynamicCommand : SelectDynamicCommand {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /** Log instance. */
        private static readonly log4net.ILog _log = log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        private IDataReaderHandler dataReaderHandler;
        private IDataReaderFactory dataReaderFactory;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public MbS2DaoSelectDynamicCommand(IDataSource dataSource, ICommandFactory commandFactory
                , IDataReaderHandler dataReaderHandler, IDataReaderFactory dataReaderFactory)
            : base(dataSource, commandFactory, dataReaderHandler, dataReaderFactory) {
                this.dataReaderHandler = dataReaderHandler;
                this.dataReaderFactory = dataReaderFactory;
        }

        // ===============================================================================
        //                                                        Very Important Extension
        //                                                        ========================
        // -------------------------------------------------
        //                                          Override
        //                                          --------
        protected override ISqlParser CreateSqlParser(string sqlString) {
            return new MbInternalSqlParser(sqlString, true);
        }

        // -------------------------------------------------
        //                                         Extension
        //                                         ---------
        protected MbS2DaoSelectDynamicCommand CreateMySelectDynamicCommand() {
            return new MbS2DaoSelectDynamicCommand(DataSource, CommandFactory, dataReaderHandler, dataReaderFactory);
        }

        // -------------------------------------------------
        //                                        For Public
        //                                        ----------
        public ICommandContext DoApply(Object[] args) {
            return Apply(args);
        }

        // ===============================================================================
        //                                                                         Execute
        //                                                                         =======
        public override object Execute(object[] args) {
            // - - - - - - - - - - - -
            // This is top execution.
            // - - - - - - - - - - - -

            if (!MbConditionBeanContext.IsExistConditionBeanOnThread()) {
                // - - - - - - - - - -
                // Execute outsideSql.
                // - - - - - - - - - -
                if (MbOutsideSqlContext.IsExistOutsideSqlContextOnThread()) {
                    MbOutsideSqlContext outsideSqlContext = MbOutsideSqlContext.GetOutsideSqlContextOnThread();
                    if (outsideSqlContext.IsDynamicBinding) {
                        return ExecuteOutsideSqlAsDynamic(args, outsideSqlContext);
                    } else {
                        return ExecuteOutsideSqlAsStatic(args, outsideSqlContext);
                    }
                }

                // - - - - - - - - -
                // Execute default.
                // - - - - - - - - -
                return ExecuteDefault(args);
            }

            // - - - - - - - - - - - -
            // Execute conditionBean.
            // - - - - - - - - - - - -
            IList<Object> bindVariableList = new System.Collections.Generic.List<Object>();
            IList<Type> bindVariableTypeList = new System.Collections.Generic.List<Type>();
            IList<String> bindVariableNameList = new System.Collections.Generic.List<String>();

            MbConditionBean cb = MbConditionBeanContext.GetConditionBeanOnThread();
            String finalClause = SetupRealClause(args, bindVariableList, bindVariableTypeList, bindVariableNameList);
        
            MbInternalBasicSelectHandler selectHandler = CreateBasicSelectHandler(finalClause, this.dataReaderHandler);
            Object[] bindVariableArray = new Object[bindVariableList.Count];
            bindVariableList.CopyTo(bindVariableArray, 0);
            Type[] bindVariableTypeArray = new Type[bindVariableTypeList.Count];
            bindVariableTypeList.CopyTo(bindVariableTypeArray, 0);
            String[] bindVariableNameArray = new String[bindVariableNameList.Count];
            bindVariableNameList.CopyTo(bindVariableNameArray, 0);
            selectHandler.LoggingMessageSqlArgs = bindVariableArray;
            return selectHandler.Execute(bindVariableArray, bindVariableTypeArray, bindVariableNameArray);
        }

        // -------------------------------------------------
        //                                   Default Execute
        //                                   ---------------
        protected virtual object ExecuteDefault(object[] args) {
            // - - - - - - - - - - - - - - - - -
            // Find specified resultSetHandler.
            // - - - - - - - - - - - - - - - - -
            IDataReaderHandler specifiedDataReaderHandler = FindSpecifiedDataReaderHandler(args);

            // - - - - - - - - -
            // Filter arguments.
            // - - - - - - - - -
            Object[] filteredArgs = FilterArgumentsForDataReaderHandler(args);

            ICommandContext ctx = Apply(filteredArgs);
            MbInternalBasicSelectHandler selectHandler = CreateBasicSelectHandler(ctx.Sql, specifiedDataReaderHandler);
            Object[] bindVariableArray = ctx.BindVariables;
            selectHandler.LoggingMessageSqlArgs = bindVariableArray;
            return selectHandler.Execute(bindVariableArray, ctx.BindVariableTypes);
        }

        // -------------------------------------------------
        //                                OutsideSql Execute
        //                                ------------------
        protected Object ExecuteOutsideSqlAsStatic(Object[] args, MbOutsideSqlContext outsideSqlContext) {
            // - - - - - - - - - - - - - - - - -
            // Find specified resultSetHandler.
            // - - - - - - - - - - - - - - - - -
            IDataReaderHandler specifiedDataReaderHandler = FindSpecifiedDataReaderHandler(args);

            // - - - - - - - - -
            // Filter arguments.
            // - - - - - - - - -
            Object[] filteredArgs;
            if (outsideSqlContext.IsSpecifiedOutsideSql) {
                Object parameterBean = outsideSqlContext.ParameterBean;
                filteredArgs = new Object[] {parameterBean};
            } else {
                filteredArgs = FilterArgumentsForDataReaderHandler(args);
            }

            ICommandContext ctx = Apply(filteredArgs);
            MbInternalBasicSelectHandler selectHandler = CreateBasicSelectHandler(ctx.Sql, specifiedDataReaderHandler);
            Object[] bindVariableArray = ctx.BindVariables;
            selectHandler.LoggingMessageSqlArgs = bindVariableArray;
            return selectHandler.Execute(bindVariableArray, ctx.BindVariableTypes);
        }

        protected Object ExecuteOutsideSqlAsDynamic(Object[] args, MbOutsideSqlContext outsideSqlContext) {
            Object firstArg = args[0];
            PropertyInfo[] properties = firstArg.GetType().GetProperties();
            String filteredSql = this.Sql;

            // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
            // Resolve embedded comment for parsing bind variable comment in embedded comment.
            // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
            for (int i = 0; i < properties.Length; i++) {
                PropertyInfo propertyInfo = properties[i];
                Type propertyType = propertyInfo.PropertyType;
                if (!propertyType.Equals(typeof(String))) {
                    continue;
                }
                String outsideSqlPiece = (String)propertyInfo.GetValue(firstArg, null);
                if (outsideSqlPiece == null) {
                    continue;
                }
                String embeddedComment = "/*$pmb." + propertyInfo.Name + "*/";
                filteredSql = filteredSql.Replace(embeddedComment, outsideSqlPiece);
            }

            MbS2DaoSelectDynamicCommand outsideSqlCommand = CreateMySelectDynamicCommand();
            outsideSqlCommand.ArgNames = ArgNames;
            outsideSqlCommand.ArgTypes = ArgTypes;
            outsideSqlCommand.Sql = filteredSql;

            // - - - - - - - - - - - - - - - - -
            // Find specified resultSetHandler.
            // - - - - - - - - - - - - - - - - -
            IDataReaderHandler specifiedDataReaderHandler = FindSpecifiedDataReaderHandler(args);

            // - - - - - - - - -
            // Filter arguments.
            // - - - - - - - - -
            Object[] filteredArgs;
            if (outsideSqlContext.IsSpecifiedOutsideSql) {
                Object parameterBean = outsideSqlContext.ParameterBean;
                filteredArgs = new Object[] {parameterBean};
            } else {
                filteredArgs = FilterArgumentsForDataReaderHandler(args);
            }

            ICommandContext ctx = outsideSqlCommand.DoApply(filteredArgs);
            IList<Object> bindVariableList = new System.Collections.Generic.List<Object>();
            IList<Type> bindVariableTypeList = new System.Collections.Generic.List<Type>();
            IList<String> bindVariableNameList = new System.Collections.Generic.List<String>();
            AddBindVariableInfo(ctx, bindVariableList, bindVariableTypeList, bindVariableNameList);
            MbInternalBasicSelectHandler selectHandler = CreateBasicSelectHandler(ctx.Sql, specifiedDataReaderHandler);
            Object[] bindVariableArray = new Object[bindVariableList.Count];
            bindVariableList.CopyTo(bindVariableArray, 0);
            Type[] bindVariableTypeArray = new Type[bindVariableTypeList.Count];
            bindVariableTypeList.CopyTo(bindVariableTypeArray, 0);
            String[] bindVariableNameArray = new String[bindVariableNameList.Count];
            bindVariableNameList.CopyTo(bindVariableNameArray, 0);
            selectHandler.LoggingMessageSqlArgs = bindVariableArray;
            return selectHandler.Execute(bindVariableArray, bindVariableTypeArray, bindVariableNameArray);
        }

        protected virtual object[] FilterArgumentsForDataReaderHandler(object[] args) {
            if (args == null || args.Length == 0) {
                return args;
            }
            object[] filteredArgs;
            if (args[args.Length - 1] is DfExample.DBFlute.MemberDb.AllCommon.Ado.MbCursorHandler) {
                filteredArgs = new object[args.Length - 1];
                for (int i=0; i < args.Length - 1; i++) {
                    filteredArgs[i] = args[i];
                }
            } else {
                filteredArgs = args;
            }
            return filteredArgs;
        }

        protected IDataReaderHandler FindSpecifiedDataReaderHandler(object[] args) {
            if (args == null || args.Length == 0) {
                return this.dataReaderHandler;
            }
            if (args[args.Length-1] is DfExample.DBFlute.MemberDb.AllCommon.Ado.MbCursorHandler) {
                DfExample.DBFlute.MemberDb.AllCommon.Ado.MbCursorHandler cursorHandler = (DfExample.DBFlute.MemberDb.AllCommon.Ado.MbCursorHandler)args[args.Length-1];
                return new DataReaderCursol(cursorHandler);
            }
            if (ArgTypes.Length+1 == args.Length && args[args.Length-1] == null) {
                String lineSeparator = Environment.NewLine;
                String msg = "System Level Exception!" + lineSeparator;
                msg = msg + "/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *" + lineSeparator;
                msg = msg + "The size of arg types have not been same as the size of arg objects:";
                msg = msg + " argTypes=" + ArgTypes.Length + " args=" + args.Length + lineSeparator;
                msg = msg + "If the arguments contain DataReaderHandler, the argument value should not be null!" + lineSeparator;
                for (int i=0; i < args.Length - 1; i++) {
                    msg = msg + "  args[" + i + "] -- " + args[i] + lineSeparator;
                }
                msg = msg + "* * * * * * * * * */" + lineSeparator;
                throw new SystemException(msg);
            }
            return this.dataReaderHandler;
        }

        // -------------------------------------------------
        //                                      Setup Clause
        //                                      ------------
        protected String SetupRealClause(Object[] args, IList<Object> bindVariableList, IList<Type> bindVariableTypeList, IList<String> bindVariableNameList) {
            MbConditionBean cb = MbConditionBeanContext.GetConditionBeanOnThread();
            String realClause = null;
            {
                MbS2DaoSelectDynamicCommand dynamicCommand = CreateMySelectDynamicCommand();
                dynamicCommand.ArgNames = ArgNames;
                dynamicCommand.ArgTypes = ArgTypes;
                dynamicCommand.Sql = cb.SqlClause.getClause();
                ICommandContext ctx = dynamicCommand.Apply(args);
                realClause = ctx.Sql;
                AddBindVariableInfo(ctx, bindVariableList, bindVariableTypeList, bindVariableNameList);
            }
            return realClause;
        }
    
        protected MbInternalBasicSelectHandler CreateBasicSelectHandler(String realSql, IDataReaderHandler specifiedDataReaderHandler) {
            return new MbInternalBasicSelectHandler(DataSource, realSql, specifiedDataReaderHandler, CommandFactory, dataReaderFactory);
        }
        
        // ===============================================================================
        //                                                                   Assist Helper
        //                                                                   =============
        // -------------------------------------------------
        //                                      Setup Helper
        //                                      ------------
        protected void AddBindVariableInfo(ICommandContext ctx, IList<Object> bindVariableList, IList<Type> bindVariableTypeList, IList<String> bindVariableNameList) {
            Object[] bindVariables = ctx.BindVariables;
            AddBindVariableList(bindVariableList, bindVariables);
            Type[] bindVariableTypes = ctx.BindVariableTypes;
            AddBindVariableTypeList(bindVariableTypeList, bindVariableTypes);
            String[] bindVariableNames = ctx.BindVariableNames;
            AddBindVariableNameList(bindVariableNameList, bindVariableNames);
        }

        protected void AddBindVariableList(IList<Object> bindVariableList, Object[] bindVariables) {
            for (int i=0; i < bindVariables.Length; i++) {
                bindVariableList.Add(bindVariables[i]);
            }
        }

        protected void AddBindVariableTypeList(IList<Type> bindVariableTypeList, Type[] bindVariableTypes) {
            for (int i=0; i < bindVariableTypes.Length; i++) {
                bindVariableTypeList.Add(bindVariableTypes[i]);
            }
        }

        protected void AddBindVariableNameList(IList<String> bindVariableNameList, String[] bindVariableNames) {
            for (int i=0; i < bindVariableNames.Length; i++) {
                bindVariableNameList.Add(bindVariableNames[i]);
            }
        }

        // ===============================================================================
        //                                                                  General Helper
        //                                                                  ==============
        protected String ReplaceString(String text, String fromText, String toText) {
            return MbSimpleStringUtil.Replace(text, fromText, toText);
        }
        
        protected class DataReaderCursol : IDataReaderHandler {
            protected DfExample.DBFlute.MemberDb.AllCommon.Ado.MbCursorHandler _cursorHandler;
            public DataReaderCursol(DfExample.DBFlute.MemberDb.AllCommon.Ado.MbCursorHandler cursorHandler) {
                this._cursorHandler = cursorHandler;
            }
            public object Handle(System.Data.IDataReader dr) {
                return _cursorHandler.Handle(dr);
            }
        }
    }
}

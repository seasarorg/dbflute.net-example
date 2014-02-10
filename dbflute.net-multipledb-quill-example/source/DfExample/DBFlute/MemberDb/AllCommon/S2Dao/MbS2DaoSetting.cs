
using System;
using System.Data;

using Seasar.Dao;
using Seasar.Dao.Impl;
using Seasar.Extension.ADO;
using Seasar.Extension.ADO.Impl;
using Seasar.Quill.Dao.Impl;

using DfExample.DBFlute.MemberDb.AllCommon;
using DfExample.DBFlute.MemberDb.AllCommon.CBean;
using DfExample.DBFlute.MemberDb.AllCommon.CBean.OutsideSql;
using DfExample.DBFlute.MemberDb.AllCommon.Ado;

namespace DfExample.DBFlute.MemberDb.AllCommon.S2Dao {

    public class MbS2DaoSetting : AbstractDaoSetting {

        protected override void SetupDao(IDataSource dataSource) {
            ICommandFactory commandFactory = CreateCommandFactory();
            IDataReaderFactory dataReaderFactory = CreateDataReaderFactory(commandFactory);
            IAnnotationReaderFactory annotationReaderFactory = CreateAnnotationReaderFactory();
            _daoMetaDataFactory = new MbS2DaoMetaDataFactoryImpl(dataSource, commandFactory, annotationReaderFactory, dataReaderFactory);
            _daoInterceptor = new MbS2DaoInterceptor(_daoMetaDataFactory);
        }

        protected ICommandFactory CreateCommandFactory() {
            IDbParameterParser dbParamterParser = MbDBFluteConfig.GetInstance().DbParameterParser;
            BasicCommandFactory commandFactory;
            if (dbParamterParser != null) {
                commandFactory = new TnBasicCommandFactory(dbParamterParser);
            } else {
                commandFactory = new TnBasicCommandFactory();
            }
            return commandFactory;
        }

        protected IDataReaderFactory CreateDataReaderFactory(ICommandFactory commandFactory) {
            return new BasicDataReaderFactory(commandFactory);
        }

        protected IAnnotationReaderFactory CreateAnnotationReaderFactory() {
            return new FieldAnnotationReaderFactory();
        }

        public override String DataSourceName {
            get { return "MemberDb"; }
        }
    }

    public class TnBasicCommandFactory : BasicCommandFactory {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        private static readonly log4net.ILog _log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public TnBasicCommandFactory() : base() {}
        public TnBasicCommandFactory(IDbParameterParser dbParameterParser) : base(dbParameterParser) {}

        // ===============================================================================
        //                                                                Command Creation
        //                                                                ================
        public override IDbCommand CreateCommand(IDbConnection conn, string sql) {
            IDbCommand cmd = conn.CreateCommand();
            cmd.CommandText = ChangeSignSql(cmd, sql);
            MbStatementConfig defaultStatementConfig = MbDBFluteConfig.GetInstance().DefaultStatementConfig;
            bool internalDebug = MbDBFluteConfig.GetInstance().IsInternalDebug;
            MbStatementConfig config = FindStatementConfigOnThread();
            if (config != null && config.HasQueryTimeout()) {
                if (internalDebug) {
                    _log.Debug("...Setting statement config as request: " + config);
                }
                cmd.CommandTimeout = config.GetQueryTimeout().Value;// DBFlute original logic.
            } else if (defaultStatementConfig != null && defaultStatementConfig.HasQueryTimeout()) {
                if (internalDebug) {
                    _log.Debug("...Setting statement config as default: " + config);
                }
                cmd.CommandTimeout = defaultStatementConfig.GetQueryTimeout().Value;// DBFlute original logic.
            } else {
                if (CommandTimeout > -1) {
                    cmd.CommandTimeout = CommandTimeout;// S2Dao original logic.
                }
            }
            return cmd;
        }

        protected MbStatementConfig FindStatementConfigOnThread() {
            MbStatementConfig config = null;
            if (MbConditionBeanContext.IsExistConditionBeanOnThread()) {
                MbConditionBean cb = MbConditionBeanContext.GetConditionBeanOnThread();
                config = cb.StatementConfig;
            } else if (MbOutsideSqlContext.IsExistOutsideSqlContextOnThread()) {
                MbOutsideSqlContext context = MbOutsideSqlContext.GetOutsideSqlContextOnThread();
                config = context.StatementConfig;
            }
            return config;
        }
    }
}

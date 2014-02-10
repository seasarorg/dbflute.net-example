
using System;
using System.Collections;
using System.Data;
using System.Data.SqlTypes;
using System.Reflection;
using Seasar.Extension.ADO;
using Seasar.Extension.ADO.Impl;
using Seasar.Dao;

namespace DfExample.DBFlute.MemberDb.AllCommon.S2Dao.Internal.SqlHandler {

    public class MbInternalInsertAutoHandler : MbInternalAbstractAutoHandler {

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public MbInternalInsertAutoHandler(IDataSource dataSource, ICommandFactory commandFactory, IBeanMetaData beanMetaData, IPropertyType[] propertyTypes)
            : base(dataSource, commandFactory, beanMetaData, propertyTypes) {
        }
		
        // ===============================================================================
        //                                                                        Override
        //                                                                        ========
        protected override void SetupBindVariables(Object bean) {
            SetupInsertBindVariables(bean);
            LoggingMessageSqlArgs = _bindVariables;
        }

        protected override void PreUpdateBean(Object bean) {
            IIdentifierGenerator generator = BeanMetaData.IdentifierGenerator;
            if (generator.IsSelfGenerate) {
                generator.SetIdentifier(bean, DataSource);
            }
        }

        protected override void PostUpdateBean(Object bean, int ret) {
            IIdentifierGenerator generator = BeanMetaData.IdentifierGenerator;
            if (!generator.IsSelfGenerate) {
                generator.SetIdentifier(bean, DataSource);
            }
            UpdateVersionNoIfNeed(bean);
            UpdateTimestampIfNeed(bean);
        }
    }
}

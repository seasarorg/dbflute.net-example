
using System;
using System.Collections;
using System.Data;
using System.Data.SqlTypes;
using System.Reflection;
using Seasar.Extension.ADO;
using Seasar.Extension.ADO.Impl;
using Seasar.Dao;

namespace DfExample.DBFlute.MemberDb.AllCommon.S2Dao.Internal.SqlHandler {

    public class MbInternalDeleteAutoHandler : MbInternalAbstractAutoHandler {

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public MbInternalDeleteAutoHandler(IDataSource dataSource, ICommandFactory commandFactory, IBeanMetaData beanMetaData, IPropertyType[] propertyTypes)
            : base(dataSource, commandFactory, beanMetaData, propertyTypes) {
        }
		
        // ===============================================================================
        //                                                                        Override
        //                                                                        ========
        protected override void SetupBindVariables(object bean) {
            SetupDeleteBindVariables(bean);
            LoggingMessageSqlArgs = _bindVariables;
        }
    }
}

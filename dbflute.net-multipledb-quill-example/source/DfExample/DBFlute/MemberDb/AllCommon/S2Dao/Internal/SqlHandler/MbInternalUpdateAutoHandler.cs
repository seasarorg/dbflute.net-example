
using System;
using System.Collections;
using System.Data;
using System.Data.SqlTypes;
using System.Reflection;
using Seasar.Extension.ADO;
using Seasar.Extension.ADO.Impl;
using Seasar.Dao;

using DfExample.DBFlute.MemberDb.AllCommon.Exp;

namespace DfExample.DBFlute.MemberDb.AllCommon.S2Dao.Internal.SqlHandler {

    public class MbInternalUpdateAutoHandler : MbInternalAbstractAutoHandler {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected bool checkSingleRowUpdate = true;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public MbInternalUpdateAutoHandler(IDataSource dataSource, ICommandFactory commandFactory, IBeanMetaData beanMetaData, IPropertyType[] propertyTypes)
            : base(dataSource, commandFactory, beanMetaData, propertyTypes) {
        }
		
        // ===============================================================================
        //                                                                        Override
        //                                                                        ========
        protected override void SetupBindVariables(Object bean) {
            SetupUpdateBindVariables(bean);
            LoggingMessageSqlArgs = _bindVariables;
        }

        protected override void PostUpdateBean(Object bean, int ret) {
            if (IsCheckSingleRowUpdate && ret < 1) {
                throw CreateEntityAlreadyUpdatedException(bean, ret);
            }
            UpdateVersionNoIfNeed(bean);
            UpdateTimestampIfNeed(bean);
        }

        protected virtual MbEntityAlreadyUpdatedException CreateEntityAlreadyUpdatedException(Object bean, int rows) {
            return new MbEntityAlreadyUpdatedException(bean, rows);
        }
        
        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public bool IsCheckSingleRowUpdate {
            get { return checkSingleRowUpdate; }
            set { checkSingleRowUpdate = value; }
        }
    }
}

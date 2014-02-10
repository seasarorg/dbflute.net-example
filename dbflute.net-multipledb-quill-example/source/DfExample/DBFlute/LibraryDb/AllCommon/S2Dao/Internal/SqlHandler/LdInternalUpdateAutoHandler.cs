
using System;
using System.Collections;
using System.Data;
using System.Data.SqlTypes;
using System.Reflection;
using Seasar.Extension.ADO;
using Seasar.Extension.ADO.Impl;
using Seasar.Dao;

using DfExample.DBFlute.LibraryDb.AllCommon.Exp;

namespace DfExample.DBFlute.LibraryDb.AllCommon.S2Dao.Internal.SqlHandler {

    public class LdInternalUpdateAutoHandler : LdInternalAbstractAutoHandler {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected bool checkSingleRowUpdate = true;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public LdInternalUpdateAutoHandler(IDataSource dataSource, ICommandFactory commandFactory, IBeanMetaData beanMetaData, IPropertyType[] propertyTypes)
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

        protected virtual LdEntityAlreadyUpdatedException CreateEntityAlreadyUpdatedException(Object bean, int rows) {
            return new LdEntityAlreadyUpdatedException(bean, rows);
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

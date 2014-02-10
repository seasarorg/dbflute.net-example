
using System.Text;
using Seasar.Extension.ADO;
using Seasar.Dao;
using Seasar.Dao.Impl;

using DfExample.DBFlute.LibraryDb.AllCommon.S2Dao.Internal.SqlHandler;

namespace DfExample.DBFlute.LibraryDb.AllCommon.S2Dao.Internal.SqlCommand {

    public class LdInternalDeleteAutoStaticCommand : LdInternalAbstractAutoStaticCommand {

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public LdInternalDeleteAutoStaticCommand(IDataSource dataSource, ICommandFactory commandFactory,
            IBeanMetaData beanMetaData, string[] propertyNames)
            : base(dataSource, commandFactory, beanMetaData, propertyNames) {
        }

        // ===============================================================================
        //                                                                        Override
        //                                                                        ========
        protected override LdInternalAbstractAutoHandler CreateAutoHandler() {
            return new LdInternalDeleteAutoHandler(DataSource, CommandFactory, BeanMetaData, PropertyTypes);
        }
        protected override void SetupSql() {
            SetupDeleteSql();
        }
        protected override void SetupPropertyTypes(string[] propertyNames) {
            SetupDeletePropertyTypes(propertyNames);
        }
	}
}

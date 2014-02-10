
using System.Text;
using Seasar.Extension.ADO;
using Seasar.Dao;
using Seasar.Dao.Impl;

using DfExample.DBFlute.MemberDb.AllCommon.S2Dao.Internal.SqlHandler;

namespace DfExample.DBFlute.MemberDb.AllCommon.S2Dao.Internal.SqlCommand {

    public class MbInternalDeleteAutoStaticCommand : MbInternalAbstractAutoStaticCommand {

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public MbInternalDeleteAutoStaticCommand(IDataSource dataSource, ICommandFactory commandFactory,
            IBeanMetaData beanMetaData, string[] propertyNames)
            : base(dataSource, commandFactory, beanMetaData, propertyNames) {
        }

        // ===============================================================================
        //                                                                        Override
        //                                                                        ========
        protected override MbInternalAbstractAutoHandler CreateAutoHandler() {
            return new MbInternalDeleteAutoHandler(DataSource, CommandFactory, BeanMetaData, PropertyTypes);
        }
        protected override void SetupSql() {
            SetupDeleteSql();
        }
        protected override void SetupPropertyTypes(string[] propertyNames) {
            SetupDeletePropertyTypes(propertyNames);
        }
	}
}

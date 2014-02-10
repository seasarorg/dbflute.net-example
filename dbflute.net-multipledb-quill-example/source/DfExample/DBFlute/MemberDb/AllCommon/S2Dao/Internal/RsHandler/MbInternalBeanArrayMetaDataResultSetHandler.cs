
using System.Collections;
using System.Data;

using Seasar.Dao;

namespace DfExample.DBFlute.MemberDb.AllCommon.S2Dao.Internal.RsHandler {

    public class MbInternalBeanArrayMetaDataResultSetHandler : MbInternalBeanListMetaDataResultSetHandler {

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public MbInternalBeanArrayMetaDataResultSetHandler(IBeanMetaData beanMetaData, IRowCreator rowCreator, IRelationRowCreator relationRowCreator)
            : base(beanMetaData, rowCreator, relationRowCreator) {
        }

        // ===============================================================================
        //                                                                          Handle
        //                                                                          ======
        public override object Handle(IDataReader dataReader) {
            ArrayList list = (ArrayList) base.Handle(dataReader);
            return list.ToArray(BeanMetaData.BeanType);
        }
    }
}

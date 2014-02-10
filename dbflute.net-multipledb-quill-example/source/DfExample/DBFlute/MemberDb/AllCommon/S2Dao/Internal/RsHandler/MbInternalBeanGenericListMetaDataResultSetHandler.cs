
using System;
using System.Collections;
using System.Data;

using Seasar.Dao;

namespace DfExample.DBFlute.MemberDb.AllCommon.S2Dao.Internal.RsHandler {

    public class MbInternalBeanGenericListMetaDataResultSetHandler : MbInternalBeanListMetaDataResultSetHandler {

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public MbInternalBeanGenericListMetaDataResultSetHandler(
            IBeanMetaData beanMetaData, IRowCreator rowCreator, IRelationRowCreator relationRowCreator)
            : base(beanMetaData, rowCreator, relationRowCreator) {
        }

        // ===============================================================================
        //                                                                          Handle
        //                                                                          ======
        public override object Handle(IDataReader dataReader) {
            Type generic = typeof(System.Collections.Generic.List<>);
            Type constructed = generic.MakeGenericType(BeanMetaData.BeanType);
            object list = Activator.CreateInstance(constructed);
            Handle(dataReader, (IList) list);
            return list;
        }
    }
}


using System;
using System.Collections.Generic;

namespace DfExample.DBFlute.MemberDb.AllCommon.CBean {

    public class MbResultBeanBuilder<ENTITY> {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected String _tableDbName;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public MbResultBeanBuilder(String tableDbName) {
            _tableDbName = tableDbName;
        }

        // ===============================================================================
        //                                                                         Builder
        //                                                                         =======
        public MbListResultBean<ENTITY> BuildListResultBean(IList<ENTITY> selectedList) {
            MbListResultBean<ENTITY> rb = new MbListResultBean<ENTITY>();
            rb.TableDbName = _tableDbName;
            rb.AllRecordCount = selectedList.Count;
            rb.SelectedList = selectedList;
            return rb;
        }

        public MbListResultBean<ENTITY> BuildListResultBean(MbConditionBean ob, IList<ENTITY> selectedList) {
            MbListResultBean<ENTITY> rb = new MbListResultBean<ENTITY>();
            rb.TableDbName = _tableDbName;
            rb.AllRecordCount = selectedList.Count;
            rb.SelectedList = selectedList;
            rb.OrderByClause = ob.SqlComponentOfOrderByClause;
            return rb;
        }

        public MbPagingResultBean<ENTITY> BuildPagingResultBean(MbPagingBean pb, int allRecordCount, IList<ENTITY> selectedList) {
            MbPagingResultBean<ENTITY> rb = new MbPagingResultBean<ENTITY>();
            rb.TableDbName = _tableDbName;
            rb.AllRecordCount = allRecordCount;
            rb.SelectedList = selectedList;
            rb.OrderByClause = pb.SqlComponentOfOrderByClause;
            rb.CurrentPageNumber = pb.FetchPageNumber;
            rb.PageSize = pb.FetchSize;
            return rb;
        }
    }
}

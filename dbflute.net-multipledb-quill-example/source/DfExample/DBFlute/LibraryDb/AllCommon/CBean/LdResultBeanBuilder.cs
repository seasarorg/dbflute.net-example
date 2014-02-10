
using System;
using System.Collections.Generic;

namespace DfExample.DBFlute.LibraryDb.AllCommon.CBean {

    public class LdResultBeanBuilder<ENTITY> {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected String _tableDbName;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public LdResultBeanBuilder(String tableDbName) {
            _tableDbName = tableDbName;
        }

        // ===============================================================================
        //                                                                         Builder
        //                                                                         =======
        public LdListResultBean<ENTITY> BuildListResultBean(IList<ENTITY> selectedList) {
            LdListResultBean<ENTITY> rb = new LdListResultBean<ENTITY>();
            rb.TableDbName = _tableDbName;
            rb.AllRecordCount = selectedList.Count;
            rb.SelectedList = selectedList;
            return rb;
        }

        public LdListResultBean<ENTITY> BuildListResultBean(LdConditionBean ob, IList<ENTITY> selectedList) {
            LdListResultBean<ENTITY> rb = new LdListResultBean<ENTITY>();
            rb.TableDbName = _tableDbName;
            rb.AllRecordCount = selectedList.Count;
            rb.SelectedList = selectedList;
            rb.OrderByClause = ob.SqlComponentOfOrderByClause;
            return rb;
        }

        public LdPagingResultBean<ENTITY> BuildPagingResultBean(LdPagingBean pb, int allRecordCount, IList<ENTITY> selectedList) {
            LdPagingResultBean<ENTITY> rb = new LdPagingResultBean<ENTITY>();
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

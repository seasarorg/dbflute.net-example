using System;
using System.Collections.Generic;
using DfExample.DBFlute.AllCommon;
using DfExample.DBFlute.AllCommon.S2Dao.Internal.SqlLog;
using DfExample.DBFlute.CBean;
using DfExample.DBFlute.ExBhv;
using Seasar.Quill.Unit;
using Seasar.Extension.Unit;

namespace DfExample.DBFlute.AllCommon {

    [MbUnit.Framework.TestFixture]
    public class CallbackContextTest : ContainerTestCase {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected MemberBhv _memberBhv;

        // ===============================================================================
        //                                                                       Procedure
        //                                                                       =========
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void SqlLogRegistry_HowTo() {
            // ## Arrange ##
            IList<String> displaySqlList = new List<String>();
            CallbackContext callbackContext = new CallbackContext();
            callbackContext.SqlLogHandler = delegate(String executedSql, String displaySql, Object[] args, Type[] argTypes) {
                assertNotNull(executedSql);
                assertNotNull(displaySql);
                displaySqlList.Add(displaySql);
            };
            CallbackContext.SetCallbackContextOnThread(callbackContext);

            try {
                // ## Act ##
                MemberCB cb = new MemberCB();
                cb.Query().SetMemberName_PrefixSearch("AAA");
                _memberBhv.SelectCount(cb);
                cb.Query().SetMemberName_PrefixSearch("BBB");
                _memberBhv.SelectCount(cb);
                cb.Query().SetMemberName_PrefixSearch("CCC");
                _memberBhv.SelectCount(cb);
                cb.Query().SetMemberName_PrefixSearch("DDD");
                _memberBhv.SelectCount(cb);

                // ## Assert ##
                log("[Display SQL]");
                log("- - - - - - - - - - - - - - - - - - ");
                foreach (String displaySql in displaySqlList) {
                    log(displaySql);
                    log("- - - - - - - - - - - - - - - - - - ");
                }
                assertEquals(4, displaySqlList.Count);
                assertNull(InternalSqlLogRegistryLocator.Instance); // This doesn't use SqlLogRegistry 
            } finally {
                CallbackContext.ClearCallbackContextOnThread();
            }
        }
    }
}

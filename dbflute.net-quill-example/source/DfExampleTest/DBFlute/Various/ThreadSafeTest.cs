using System;
using System.Collections.Generic;
using System.Threading;
using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.Helper;
using DfExample.DBFlute.CBean;
using DfExample.DBFlute.ExBhv;
using DfExample.DBFlute.ExDao.PmBean;
using DfExample.DBFlute.ExEntity;
using DfExample.DBFlute.ExEntity.Customize;
using Seasar.Quill.Unit;
using Seasar.Extension.Unit;
using IllegalStateException=DfExample.DBFlute.AllCommon.JavaLike.IllegalStateException;

namespace DfExample.DBFlute.Various
{
    [MbUnit.Framework.TestFixture]
    public class ThreadSafeTest : ContainerTestCase {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected MemberBhv _memberBhv;

        // ===============================================================================
        //                                                                   ConditionBean
        //                                                                   =============
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void ConditionBean_threadSafe_sameExecution() {
            for (int i = 0; i < 5; i++) {
                fireSameExecution(delegate() {
                    return delegate() {
                        MemberCB cb = new MemberCB();
                        cb.SetupSelect_MemberStatus();
                        cb.Query().SetMemberName_PrefixSearch("S");
                        cb.Query().AddOrderBy_Birthdate_Desc().AddOrderBy_MemberId_Asc();
                        ListResultBean<Member> memberList = _memberBhv.SelectList(cb);
                        assertTrue(memberList.Count != 0);
                        foreach (Member member in memberList) {
                            assertTrue(member.MemberName.StartsWith("S"));
                        }
                    };
                });
            }
        }

        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void OutsideSql_threadSafe_sameExecution() {
            for (int i = 0; i < 5; i++) {
                fireSameExecution(delegate() {
                    return delegate() {
                        String path = MemberBhv.PATH_selectSimpleMember;

                        SimpleMemberPmb pmb = new SimpleMemberPmb();
                        pmb.SetMemberName_PrefixSearch("S");

                        // ## Act ##
                        IList<SimpleMember> memberList =
                        _memberBhv.OutsideSql().SelectList<SimpleMember>(path, pmb);

                        // ## Assert ##
                        assertNotSame(0, memberList.Count);
                        log("{SimpleMember}");
                        foreach (SimpleMember entity in memberList) {
                            int? memberId = entity.MemberId;
                            String memberName = entity.MemberName;
                            String memberStatusName = entity.MemberStatusName;
                            Log("    " + memberId + ", " + memberName + ", " + memberStatusName);
                            assertNotNull(memberId);
                            assertNotNull(memberName);
                            assertNotNull(memberStatusName);
                            assertTrue(memberName.StartsWith("S"));
                        }
                    };
                });
            }
        }

        // ===============================================================================
        //                                                                   Assist Helper
        //                                                                   =============
        private void fireSameExecution(ExecutionCreator creator) {
            // ## Arrange ##
            int threadCount = 10;
            ManualResetEvent ready = new ManualResetEvent(false);
            IList<Exception> threadExList = new List<Exception>();

            Thread[] t = new Thread[threadCount];
            Execution execution = creator.Invoke();
            assertNotNull(execution);
            for (int i = 0; i < threadCount; i++) {
                t[i] = new Thread(createCallable(execution, threadExList));
            }

            // ## Act & Assert ##
            // Start! (Expect no exception)
            for (int i = 0; i < threadCount; i++) {
                t[i].Start(ready);
            }
            Thread.Sleep(1000);
            log("Release wait-threads!");
            ready.Set();

            // Wait until all threads are finished!
            for (int i = 0; i < threadCount; i++) {
                t[i].Join();
            }
            log("All threads are finished!");

            foreach (Exception e in threadExList) {
                log(e.Message);
            }
            if (threadExList.Count > 0) {
                throw threadExList[0]; // throws first exception
            }
        }

        private delegate Execution ExecutionCreator();
        private delegate void Execution();
        private ParameterizedThreadStart createCallable(Execution execution, IList<Exception> threadExList) {
            return delegate(Object obj) {
                try {
                    if (obj == null) {
                        String msg = "The argument 'obj' should not be null!";
                        throw new IllegalStateException(msg);
                    }
                    WaitHandle waitHandle = obj as WaitHandle;
                    assertNotNull(waitHandle);
                    if (waitHandle == null) {
                        String msg = "The argument 'obj' should be waitHandle: obj=" + obj;
                        throw new IllegalStateException(msg);
                    }
                    log("Wait!");
                    while(waitHandle.WaitOne() == false) {
                        String msg = "Time out!";
                        log(msg);
                        throw new IllegalStateException(msg);
                    }
                    execution.Invoke();
                } catch (Exception e) {
                    threadExList.Add(e);
                    throw;
                }
            };
        }
    }
}

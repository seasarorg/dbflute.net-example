using System.Data.Common;
using DfExample.DBFlute.AllCommon.Exp;
using DfExample.DBFlute.ExBhv;
using DfExample.DBFlute.ExEntity;
using Seasar.Quill.Unit;
using Seasar.Extension.Unit;

namespace DfExample.DBFlute.Various {

    [MbUnit.Framework.TestFixture]
    public class UniqueConstraintTest : ContainerTestCase {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected MemberBhv _memberBhv;

        // ===============================================================================
        //                                                               Unique Constraint
        //                                                               =================
        // -------------------------------------------------
        //                                            Insert
        //                                            ------
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void Insert_unique_constraint_OriginalException() {
            // ## Arrange ##
            Member member = new Member();
            member.MemberName = "testName";
            member.MemberAccount = "testAccount";
            member.SetMemberStatusCode_Formalized(); // ê≥éÆâÔàı
            
            // ## Act & Assert ##
            _memberBhv.Insert(member);
            try {
                _memberBhv.Insert(member);
                fail();
            } catch (SQLFailureException e) { // EntityAlreadyExistsException Not Supported Yet! 
                log(e.Message);
                DbException dbException = e.CauseDbException;
                log("dbException=" + dbException);
                assertNotNull(dbException); // MySQL does not throw DbException!
            }
        }
    }
}

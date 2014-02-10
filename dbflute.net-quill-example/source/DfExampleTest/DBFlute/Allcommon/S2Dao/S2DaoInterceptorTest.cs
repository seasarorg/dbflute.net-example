using DfExample.DBFlute.ExBhv;
using Seasar.Extension.Unit;
using DfExample.DBFlute.CBean;
using Seasar.Quill.Unit;

namespace DfExample.DBFlute.AllCommon.S2Dao {

    [MbUnit.Framework.TestFixture]
    public class S2DaoInterceptorTest : ContainerTestCase {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected MemberBhv _memberBhv;

        // ===============================================================================
        //                                                                   LogInvocation
        //                                                                   =============
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void LogInvocation_Page_to_Service_and_Facade() {
            // ## Arrange ##
            AaaPage aaaPage = new AaaPage(_memberBhv);

            // ## Act & Assert ##
            // Confirm the log.
            aaaPage.service();
            aaaPage.facade();
        }

        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void LogInvocation_Action_to_Service_and_Facade() {
            // ## Arrange ##
            CccAction cccAction = new CccAction(_memberBhv);

            // ## Act & Assert ##
            // Confirm the log.
            cccAction.service();
            cccAction.facade();
        }
    }

    // ===============================================================================
    //                                                                    Helper Class
    //                                                                    ============
    public class AaaPage {
        protected MemberBhv _memberBhv;
        public AaaPage(MemberBhv memberBhv) {
            _memberBhv = memberBhv;
        }
        public void service() {
            new BbbService(_memberBhv).bbb();
        }
        public void facade() {
            new DddFacade(_memberBhv).ddd();
        }
    }

    public class BbbService {
        protected MemberBhv _memberBhv;
        public BbbService(MemberBhv memberBhv) {
            _memberBhv = memberBhv;
        }
        public void bbb() {
            _memberBhv.SelectList(new MemberCB());
        }
    }

    public class CccAction {
        protected MemberBhv _memberBhv;
        public CccAction(MemberBhv memberBhv) {
            _memberBhv = memberBhv;
        }
        public void service() {
            new BbbService(_memberBhv).bbb();
        }
        public void facade() {
            new DddFacade(_memberBhv).ddd();
        }
    }

    public class DddFacade {
        protected MemberBhv _memberBhv;
        public DddFacade(MemberBhv memberBhv) {
            _memberBhv = memberBhv;
        }
        public void ddd() {
            _memberBhv.SelectList(new MemberCB());
        }
    }
}

using Seasar.Extension.Unit;
using Seasar.Quill.Unit;

namespace DfExample.DBFlute.AllCommon {

    [MbUnit.Framework.TestFixture]
    public class CDefTest : ContainerTestCase {

        // ===============================================================================
        //                                                                           Basic
        //                                                                           =====
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void Values() {
            // ## Arrange & Act ##
            CDef.MemberStatus[] values = CDef.MemberStatus.Values;

            // ## Assert ##
            log("length=" + values.Length);
            assertTrue(values.Length > 0);
            bool existsSample = false;
            foreach (CDef.MemberStatus cls in values) {
                log(cls);
                if (cls.Equals(CDef.MemberStatus.Formalized)) {
                    if (existsSample) {
                        fail("Should be unique!");
                    }
                    existsSample = true;
                }
            }
            assertTrue(existsSample);
        }
    }
}

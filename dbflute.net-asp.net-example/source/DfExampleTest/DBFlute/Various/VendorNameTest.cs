using System;
using System.Collections.Generic;
using System.Text;
using DfExample.DBFlute.CBean;
using DfExample.DBFlute.ExBhv;
using DfExample.DBFlute.ExDao.PmBean;
using DfExample.DBFlute.ExEntity;
using DfExample.DBFlute.ExEntity.Customize;
using Seasar.Quill.Unit;
using Seasar.Extension.Unit;

namespace DfExample.DBFlute.Various
{
    [MbUnit.Framework.TestFixture]
    public class VendorNameTest : ContainerTestCase {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected VendorLargeName901234567890Bhv _vendorLargeName901234567890Bhv;
        protected VendorLargeName90123456RefBhv _vendorLargeName90123456RefBhv;

        // ===============================================================================
        //                                                                      Large Name
        //                                                                      ==========
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void test_LargeName_insert_select_Tx() {
            // ## Arrange ##
            VendorLargeName901234567890 large = new VendorLargeName901234567890();
            large.VendorLargeName901234567Id = 99999L;
            large.VendorLargeName9012345Name = "Pixy";
            _vendorLargeName901234567890Bhv.Insert(large);
            VendorLargeName901234567890CB cb = new VendorLargeName901234567890CB();
            cb.Query().SetVendorLargeName901234567Id_Equal(large.VendorLargeName901234567Id);

            // ## Act ##
            VendorLargeName901234567890 actual = _vendorLargeName901234567890Bhv.SelectEntityWithDeletedCheck(cb);

            // ## Assert ##
            assertNotNull(actual);
            assertEquals("Pixy", actual.VendorLargeName9012345Name);
        }

        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void test_LargeName_setupSelect_Tx() {
            // ## Arrange ##
            VendorLargeName901234567890 large = new VendorLargeName901234567890();
            large.VendorLargeName901234567Id = 99999L;
            large.VendorLargeName9012345Name = "Pixy";
            _vendorLargeName901234567890Bhv.Insert(large);
            VendorLargeName90123456Ref refName = new VendorLargeName90123456Ref();
            refName.VendorLargeName90123RefId = 88888L;
            refName.VendorLargeName901RefName = "Genius";
            refName.VendorLargeName901234567Id = large.VendorLargeName901234567Id;
            _vendorLargeName90123456RefBhv.Insert(refName);
            VendorLargeName90123456RefCB cb = new VendorLargeName90123456RefCB();
            cb.SetupSelect_VendorLargeName901234567890();
            cb.Query().SetVendorLargeName901234567Id_Equal(large.VendorLargeName901234567Id);

            // ## Act ##
            VendorLargeName90123456Ref actual = _vendorLargeName90123456RefBhv.SelectEntityWithDeletedCheck(cb);

            // ## Assert ##
            assertNotNull(actual);
            assertNotNull(actual.VendorLargeName901234567890);
            assertEquals("Pixy", actual.VendorLargeName901234567890.VendorLargeName9012345Name);
            assertEquals("Genius", actual.VendorLargeName901RefName);
        }

    }
}

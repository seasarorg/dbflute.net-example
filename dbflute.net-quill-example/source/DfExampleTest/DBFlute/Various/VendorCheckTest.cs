using System;
using System.Collections.Generic;
using System.Reflection;
using DfExample.DBFlute.AllCommon;
using DfExample.DBFlute.AllCommon.Exp;
using DfExample.DBFlute.CBean;
using DfExample.DBFlute.ExBhv;
using DfExample.DBFlute.ExDao.PmBean;
using DfExample.DBFlute.ExEntity;
using DfExample.DBFlute.ExEntity.Customize;
using Seasar.Framework.Util;
using Seasar.Quill.Unit;
using Seasar.Extension.Unit;

namespace DfExample.DBFlute.Various
{
    [MbUnit.Framework.TestFixture]
    public class VendorCheckTest : ContainerTestCase {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected VendorCheckBhv _vendorCheckBhv;

        protected MemberBhv _memberBhv;

        // ===============================================================================
        //                                                                 Optimistic Lock
        //                                                                 ===============
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void NotVersionNoIncremented_after_EntityAlraedyUpdated() {
            Member member = new Member();
            member.MemberId = 3;
            member.MemberName = "Test";
            member.VersionNo = 99999;

            try {
                _memberBhv.Update(member);
                fail();
            } catch (EntityAlreadyUpdatedException e) {
                // OK
                log(e.Message);
                log("member.VersionNo = " + member.VersionNo);
                assertEquals((long?)99999, member.VersionNo);
            }
        }

        // ===============================================================================
        //                                                                     Transaction
        //                                                                     ===========
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void Transaction_CB_and_OutsideSql() {
            // ## Arrange ##
            // /-------------------------------
            // Update member name to 'testName'
            // ----------/
            Member member = new Member();
            member.MemberId = 3; // çXêVÇµÇΩÇ¢âÔàıÇÃâÔàıID
            member.MemberName = "testName";
            _memberBhv.UpdateNonstrict(member);
            MemberCB memberCB = new MemberCB();
            memberCB.Query().SetMemberId_Equal(3);
            Member afterMember = _memberBhv.SelectEntityWithDeletedCheck(memberCB);
            log("onDatabase = " + afterMember.ToString());
            log("onMemory   = " + member.ToString());
            assertNull(member.VersionNo);
            assertNotNull(afterMember.VersionNo);

            // ## Act & Assert ##
            // /--------------
            // [ConditionBean]
            // ----------/
            MemberCB cb = new MemberCB();
            cb.Query().SetMemberId_Equal(3);
            Member cbResult = _memberBhv.SelectEntityWithDeletedCheck(cb);
            assertEquals("testName", cbResult.MemberName);

            // /-----------
            // [OutsideSql]
            // ----------/
            String path = MemberBhv.PATH_selectSimpleMember;
            SimpleMemberPmb pmb = new SimpleMemberPmb();
            pmb.MemberId = 3;
            IList<SimpleMember> memberList =
                _memberBhv.OutsideSql().SelectList<SimpleMember>(path, pmb);
            assertNotSame(0, memberList.Count);
            log("{SimpleMember}");
            foreach (SimpleMember entity in memberList) {
                int? memberId = entity.MemberId;
                String memberName = entity.MemberName;
                String memberStatusName = entity.MemberStatusName;
                Log("    " + memberId + ", " + memberName + ", " + memberStatusName);
                assertNotNull(memberId);
                assertNotNull(memberName);
                assertEquals("testName", cbResult.MemberName);
            }
        }
    }
}

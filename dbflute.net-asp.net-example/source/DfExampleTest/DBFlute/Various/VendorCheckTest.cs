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
    public class VendorCheckTest : ContainerTestCase {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected VendorCheckBhv _vendorCheckBhv;
        protected MemberBhv _memberBhv;
        protected MemberWithdrawalBhv _memberWithdrawalBhv;

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
                long? memberId = entity.MemberId;
                String memberName = entity.MemberName;
                String memberStatusName = entity.MemberStatusName;
                Log("    " + memberId + ", " + memberName + ", " + memberStatusName);
                assertNotNull(memberId);
                assertNotNull(memberName);
                assertEquals("testName", cbResult.MemberName);
            }
        }

        // ===============================================================================
        //                                                                    InScopeQuery
        //                                                                    ============
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void Query_InScope_SeveralRegistered_basic() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            IList<long?> memberIdList = new List<long?>();
            for (long i = 0; i < 3123; i++) {
                memberIdList.Add(i);
            }
            cb.Query().SetMemberStatusCode_Equal_Formalized();
            cb.Query().SetMemberId_InScope(memberIdList);

            // ## Act ##
            IList<Member> memberList = _memberBhv.SelectList(cb); // Except no exception
            
            // ## Assert ##
            assertNotNull(memberList);
            assertNotSame(0, memberList.Count);
            String displaySql = cb.ToDisplaySql();
            assertTrue(displaySql.Contains(" in ("));
            assertTrue(displaySql.Contains(" or "));
            assertTrue(displaySql.Contains(", 999)"));
            assertTrue(displaySql.Contains("(1000, "));
            assertTrue(displaySql.Contains(", 1999)"));
            assertTrue(displaySql.Contains("(2000, "));
            assertTrue(displaySql.Contains(", 2999)"));
            assertTrue(displaySql.Contains("(3000, "));
            assertTrue(displaySql.Contains(", 3122)"));
        }

        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void Query_InScope_SeveralRegistered_just() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            IList<long?> memberIdList = new List<long?>();
            for (long i = 0; i < 1000; i++) {
                memberIdList.Add(i);
            }
            cb.Query().SetMemberStatusCode_Equal_Formalized();
            cb.Query().SetMemberId_InScope(memberIdList);

            // ## Act ##
            IList<Member> memberList = _memberBhv.SelectList(cb); // Except no exception
            
            // ## Assert ##
            assertNotNull(memberList);
            assertNotSame(0, memberList.Count);
            String displaySql = cb.ToDisplaySql();
            assertTrue(displaySql.Contains(" in ("));
            assertFalse(displaySql.Contains(" or "));
            assertTrue(displaySql.Contains(", 999)"));
        }

        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void Query_InScope_SeveralRegistered_justPlus() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            IList<long?> memberIdList = new List<long?>();
            for (long i = 0; i < 1001; i++) {
                memberIdList.Add(i);
            }
            cb.Query().SetMemberStatusCode_Equal_Formalized();
            cb.Query().SetMemberId_InScope(memberIdList);

            // ## Act ##
            IList<Member> memberList = _memberBhv.SelectList(cb); // Except no exception
            
            // ## Assert ##
            assertNotNull(memberList);
            assertNotSame(0, memberList.Count);
            String displaySql = cb.ToDisplaySql();
            assertTrue(displaySql.Contains(" in ("));
            assertTrue(displaySql.Contains(" or "));
            assertTrue(displaySql.Contains(", 999)"));
            assertTrue(displaySql.Contains("(1000)"));
        }


        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void Query_InScope_SeveralRegistered_secondJust() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            IList<long?> memberIdList = new List<long?>();
            for (long i = 0; i < 2000; i++) {
                memberIdList.Add(i);
            }
            cb.Query().SetMemberStatusCode_Equal_Formalized();
            cb.Query().SetMemberId_InScope(memberIdList);

            // ## Act ##
            IList<Member> memberList = _memberBhv.SelectList(cb); // Except no exception
            
            // ## Assert ##
            assertNotNull(memberList);
            assertNotSame(0, memberList.Count);
            String displaySql = cb.ToDisplaySql();
            assertTrue(displaySql.Contains(" in ("));
            assertTrue(displaySql.Contains(" or "));
            assertTrue(displaySql.Contains(", 999)"));
            assertTrue(displaySql.Contains("(1000, "));
        }

        // ===============================================================================
        //                                                                 NotInScopeQuery
        //                                                                 ===============
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void Query_NotInScope_SeveralRegistered_basic() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            IList<long?> memberIdList = new List<long?>();
            for (long i = 0; i < 3123; i++) {
                memberIdList.Add(i);
            }
            cb.Query().SetMemberStatusCode_Equal_Formalized();
            cb.Query().SetMemberId_NotInScope(memberIdList);

            // ## Act ##
            IList<Member> memberList = _memberBhv.SelectList(cb); // Except no exception
            
            // ## Assert ##
            assertNotNull(memberList);
            assertEquals(0, memberList.Count);
            String displaySql = cb.ToDisplaySql();
            assertTrue(displaySql.Contains(" not in ("));
            assertTrue(displaySql.Contains(" and "));
            assertTrue(displaySql.Contains(", 999)"));
            assertTrue(displaySql.Contains("(1000, "));
            assertTrue(displaySql.Contains(", 1999)"));
            assertTrue(displaySql.Contains("(2000, "));
            assertTrue(displaySql.Contains(", 2999)"));
            assertTrue(displaySql.Contains("(3000, "));
            assertTrue(displaySql.Contains(", 3122)"));
        }

        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void Query_NotInScope_SeveralRegistered_just() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            IList<long?> memberIdList = new List<long?>();
            for (long i = 0; i < 1000; i++) {
                memberIdList.Add(i);
            }
            cb.Query().SetMemberStatusCode_Equal_Formalized();
            cb.Query().SetMemberId_NotInScope(memberIdList);

            // ## Act ##
            IList<Member> memberList = _memberBhv.SelectList(cb); // Except no exception
            
            // ## Assert ##
            assertNotNull(memberList);
            assertEquals(0, memberList.Count);
            String displaySql = cb.ToDisplaySql();
            assertTrue(displaySql.Contains(" not in ("));
            assertTrue(displaySql.Contains(", 999)"));
        }

        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void Query_NotInScope_SeveralRegistered_justPlus() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            IList<long?> memberIdList = new List<long?>();
            for (long i = 0; i < 1001; i++) {
                memberIdList.Add(i);
            }
            cb.Query().SetMemberStatusCode_Equal_Formalized();
            cb.Query().SetMemberId_NotInScope(memberIdList);

            // ## Act ##
            IList<Member> memberList = _memberBhv.SelectList(cb); // Except no exception
            
            // ## Assert ##
            assertNotNull(memberList);
            assertEquals(0, memberList.Count);
            String displaySql = cb.ToDisplaySql();
            assertTrue(displaySql.Contains(" not in ("));
            assertTrue(displaySql.Contains(" and "));
            assertTrue(displaySql.Contains(", 999)"));
            assertTrue(displaySql.Contains("(1000)"));
        }

        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void Query_NotInScope_SeveralRegistered_secondJust() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            IList<long?> memberIdList = new List<long?>();
            for (long i = 0; i < 2000; i++) {
                memberIdList.Add(i);
            }
            cb.Query().SetMemberStatusCode_Equal_Formalized();
            cb.Query().SetMemberId_NotInScope(memberIdList);

            // ## Act ##
            IList<Member> memberList = _memberBhv.SelectList(cb); // Except no exception
            
            // ## Assert ##
            assertNotNull(memberList);
            assertEquals(0, memberList.Count);
            String displaySql = cb.ToDisplaySql();
            assertTrue(displaySql.Contains(" not in ("));
            assertTrue(displaySql.Contains(" and "));
            assertTrue(displaySql.Contains(", 999)"));
            assertTrue(displaySql.Contains("(1000, "));
        }
    }
}

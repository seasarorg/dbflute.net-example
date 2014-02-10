using System;
using System.Collections.Generic;
using System.Reflection;
using DfExample.DBFlute.AllCommon;
using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.CBean.COption;
using DfExample.DBFlute.AllCommon.Exp;
using DfExample.DBFlute.CBean;
using DfExample.DBFlute.ExBhv;
using DfExample.DBFlute.ExEntity;
using Seasar.Framework.Util;
using Seasar.Quill.Unit;
using Seasar.Extension.Unit;

namespace DfExample.DBFlute.Various.WhiteBox {

    [MbUnit.Framework.TestFixture]
    public class TxConditionBeanTest : ContainerTestCase {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected MemberBhv _memberBhv;

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void Query_nullOrEmpty() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();

            // ## Act ##
            cb.Query().SetMemberId_Equal(null);
            cb.Query().SetMemberId_GreaterEqual(null);
            cb.Query().SetMemberId_GreaterThan(null);
            cb.Query().SetMemberId_LessThan(null);
            cb.Query().SetMemberId_LessEqual(null);
            cb.Query().SetMemberId_InScope(null);
            cb.Query().SetMemberId_InScope(new List<int?>());
            cb.Query().SetMemberId_InScope(new List<int?>());
            List<int?> intList = new List<int?>();
            intList.Add(null);
            cb.Query().SetMemberId_InScope(intList);
            cb.Query().SetMemberName_Equal(null);
            cb.Query().SetMemberName_Equal("");
            cb.Query().SetMemberName_NotEqual(null);
            cb.Query().SetMemberName_NotEqual("");
            cb.Query().SetMemberName_InScope(null);
            cb.Query().SetMemberName_InScope(new List<String>());
            List<String> strList = new List<String>();
            strList.Add(null);
            cb.Query().SetMemberName_InScope(strList);
            cb.Query().SetMemberName_LikeSearch(null, new LikeSearchOption());
            cb.Query().SetMemberName_LikeSearch("", new LikeSearchOption());
            cb.Query().SetBirthdate_Equal(null);
            cb.Query().SetBirthdate_GreaterEqual(null);
            cb.Query().SetBirthdate_GreaterThan(null);
            cb.Query().SetBirthdate_LessThan(null);
            cb.Query().SetBirthdate_LessEqual(null);
            cb.Query().SetBirthdate_FromTo(null, null, new FromToOption());

            // ## Assert ##
            log(cb.ToDisplaySql());
            assertFalse(cb.ToDisplaySql(), cb.HasWhereClause());
        }

        // ===============================================================================
        //                                                                   Entity Select
        //                                                                   =============
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void SelectEntity_EntityDuplicated() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            cb.Query().SetMemberName_LikeSearch("v", new LikeSearchOption().LikeContain());

            // ## Act ##
            try {
                _memberBhv.SelectEntity(cb);

                fail();
            } catch (EntityDuplicatedException e) {
                // OK
                log(e.Message);
                e.InnerException.GetType();
                assertEquals(typeof(DangerousResultSizeException), e.InnerException.GetType());
            }
        }

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void SelectList_CheckSafetyResult() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            cb.CheckSafetyResult(3);

            // ## Act ##
            try {
                _memberBhv.SelectList(cb);

                fail();
            } catch (DangerousResultSizeException e) {
                // OK
                log(e.Message);
                assertEquals(3, e.SafetyMaxResultSize);
            }
        }

        // ===============================================================================
        //                                                                   Load Referrer
        //                                                                   =============
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void test_basicStatusDetermination() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();

            // ## Act ##
            // ## Assert ##
            assertFalse(cb.HasWhereClause());
            assertFalse(cb.HasOrderByClause());
            assertFalse(cb.HasUnionQueryOrUnionAllQuery());
            cb.Query().SetMemberAccount_Equal(null);
            assertFalse(cb.HasWhereClause());
            cb.Query().SetMemberAccount_Equal("");
            assertFalse(cb.HasWhereClause());
            cb.Query().SetMemberAccount_Equal(" ");
            assertTrue(cb.HasWhereClause());
            assertFalse(cb.HasOrderByClause());
            cb.Query().AddOrderBy_Birthdate_Asc();
            assertTrue(cb.HasOrderByClause());
            assertFalse(cb.HasUnionQueryOrUnionAllQuery());
            cb.Union(delegate(MemberCB unionCB) {
            });
            assertTrue(cb.HasUnionQueryOrUnionAllQuery());
        }

        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void OrScopeQuery_basic() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            cb.OrScopeQuery(delegate(MemberCB orCB) {
                cb.Query().SetMemberName_PrefixSearch("S");
                orCB.Query().SetMemberName_PrefixSearch("J");
                orCB.Query().SetMemberId_Equal(3);
            });

            // ## Act ##
            ListResultBean<Member> memberList = _memberBhv.SelectList(cb);

            // ## Assert ##
            assertNotSame(0, memberList.Count);
            foreach (Member member in memberList) {
                log(member);
                int? memberId = member.MemberId;
                String memberName = member.MemberName;
                if (!memberId.Equals(3) && !memberName.StartsWith("S") && !memberName.StartsWith("J")) {
                    fail();
                }
            }
        }

        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void OrScopeQuery_andOr() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            cb.Query().SetMemberStatusCode_Equal_Formalized();
            cb.OrScopeQuery(delegate(MemberCB orCB) {
                cb.Query().SetMemberName_PrefixSearch("S");
                orCB.Query().SetMemberName_PrefixSearch("J");
                orCB.Query().SetMemberName_PrefixSearch("M");
            });

            // ## Act ##
            ListResultBean<Member> memberList = _memberBhv.SelectList(cb);

            // ## Assert ##
            assertNotSame(0, memberList.Count);
            foreach (Member member in memberList) {
                log(member);
                String memberName = member.MemberName;
                assertTrue(member.IsMemberStatusCodeFormalized);
                if (!memberName.StartsWith("S") && !memberName.StartsWith("J") && !memberName.StartsWith("M")) {
                    fail();
                }
            }
        }

        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void OrScopeQuery_nothing() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            int countAll = _memberBhv.SelectCount(cb);
            cb.OrScopeQuery(delegate(MemberCB orCB) {
                orCB.Query().SetMemberName_PrefixSearch(null);
            });

            // ## Act ##
            ListResultBean<Member> memberList = _memberBhv.SelectList(cb);

            // ## Assert ##
            foreach (Member member in memberList) {
                log(member);
            }
            assertEquals(countAll, memberList.Count);
        }
        
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void OrScopeQuery_onlyOne() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            int countAll = _memberBhv.SelectCount(cb);
            cb.OrScopeQuery(delegate(MemberCB orCB) {
                orCB.Query().SetMemberName_PrefixSearch(null);
                orCB.Query().SetMemberId_Equal(3);
            });

            // ## Act ##
            ListResultBean<Member> memberList = _memberBhv.SelectList(cb);

            // ## Assert ##
            assertNotSame(0, memberList.Count);
            foreach (Member member in memberList) {
                log(member);
                int? memberId = member.MemberId;
                if (!memberId.Equals(3)) {
                    fail();
                }
            }
        }

        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void OrScopeQuery_inline_andOr() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            cb.Query().Inline().SetMemberStatusCode_Equal_Formalized();
            cb.OrScopeQuery(delegate(MemberCB orCB) {
                orCB.Query().Inline().SetMemberName_PrefixSearch("S");
                orCB.Query().Inline().SetMemberName_PrefixSearch("J");
                orCB.Query().Inline().SetMemberName_PrefixSearch("M");
            });

            // ## Act ##
            ListResultBean<Member> memberList = _memberBhv.SelectList(cb);

            // ## Assert ##
            assertNotSame(0, memberList.Count);
            foreach (Member member in memberList) {
                log(member);
                String memberName = member.MemberName;
                assertTrue(member.IsMemberStatusCodeFormalized);
                if (!memberName.StartsWith("S") && !memberName.StartsWith("J") && !memberName.StartsWith("M")) {
                    fail();
                }
            }
        }
        
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void OrScopeQuery_onClause_andOr() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            cb.SetupSelect_MemberStatus();
            cb.OrScopeQuery(delegate(MemberCB orCB) {
                orCB.Query().QueryMemberStatus().On().SetMemberStatusCode_Equal_Formalized();
                orCB.Query().QueryMemberStatus().On().SetDisplayOrder_Equal(3);
            });

            // ## Act ##
            ListResultBean<Member> memberList = _memberBhv.SelectList(cb);

            // ## Assert ##
            assertNotSame(0, memberList.Count);
            bool existsFormalized = false;
            bool existsDisplayOrder = false;

            foreach (Member member in memberList) {
                log(member);
                if (member.IsMemberStatusCodeFormalized) {
                    assertNotNull(member.MemberStatus);
                    existsFormalized = true;
                } else {
                    MemberStatus memberStatus = member.MemberStatus;
                    if (memberStatus != null) {
                        assertTrue(memberStatus.DisplayOrder == 3);
                        existsDisplayOrder = true;
                    }
                }
            }
            assertTrue(existsFormalized);
            assertTrue(existsDisplayOrder);
        }

        // ===============================================================================
        //                                                                      Inner Join
        //                                                                      ==========
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void test_innerJoin_query_Tx() {
            // ## Arrange ##
            int countAll = _memberBhv.SelectCount(new MemberCB());

            MemberCB cb = new MemberCB();
            cb.Query().QueryMemberStatus().SetDisplayOrder_Equal(1);
            cb.Query().QueryMemberStatus().InnerJoin();

            // ## Act ##
            ListResultBean<Member> memberList = _memberBhv.SelectList(cb);

            // ## Assert ##
            assertTrue(cb.ToDisplaySql().Contains("inner join"));
            assertFalse(cb.ToDisplaySql().Contains("left outer join"));
            assertNotSame(0, memberList.Count);
            assertNotSame(countAll, memberList.Count);
            assertTrue(countAll > memberList.Count);
            foreach (Member member in memberList) {
                log(member.ToStringWithRelation());
            }
        }
    }
}

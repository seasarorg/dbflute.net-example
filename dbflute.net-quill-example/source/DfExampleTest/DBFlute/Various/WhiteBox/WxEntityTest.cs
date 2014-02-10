using System;
using System.Collections.Generic;
using System.Reflection;
using DfExample.DBFlute.AllCommon;
using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.JavaLike;
using DfExample.DBFlute.BsEntity.Dbm;
using DfExample.DBFlute.CBean;
using DfExample.DBFlute.ExBhv;
using DfExample.DBFlute.ExEntity;
using DfExample.DBFlute.ExEntity.Customize;
using Seasar.Framework.Util;
using Seasar.Quill.Unit;
using Seasar.Extension.Unit;

namespace DfExample.DBFlute.Various.WhiteBox {

    [MbUnit.Framework.TestFixture]
    public class TxEntityTest : ContainerTestCase {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected MemberBhv _memberBhv;

        
        // ===============================================================================
        //                                                                        Eqauls()
        //                                                                        ========
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void Equals_DomainEntity_hasPrimaryKey() {
            // ## Arrange ##
            Member member = new Member();
            Member other = new Member();

            // ## Act & Assert ##
            assertFalse(member.Equals(null));
            assertFalse(member.Equals(new Object()));
            assertTrue(member.Equals(other));
            member.Birthdate = DateTime.Now;
            assertTrue(member.Equals(other));
            member.MemberId = 3;
            assertFalse(member.Equals(other));
            other.MemberId = 4;
            assertFalse(member.Equals(other));
            other.MemberId = 3;
            assertTrue(member.Equals(other));
        }

        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void Equals_CustomizeEntity_nonPrimaryKey() {
            // ## Arrange ##
            SimpleVendorCheck vendorCheck = new SimpleVendorCheck();
            SimpleVendorCheck other = new SimpleVendorCheck();

            // ## Act & Assert ##
            assertFalse(vendorCheck.Equals(null));
            assertFalse(vendorCheck.Equals(new Object()));
            assertTrue(vendorCheck.Equals(other));
            vendorCheck.TypeOfText = "FOO";
            assertFalse(vendorCheck.Equals(other));
            vendorCheck.VendorCheckId = 3L;
            assertFalse(vendorCheck.Equals(other));
            other.VendorCheckId = 3L;
            assertFalse(vendorCheck.Equals(other));
            other.TypeOfText = "FOO";
            assertTrue(vendorCheck.Equals(other));
        }

        // ===============================================================================
        //                                                                   GetHashCode()
        //                                                                   =============
        public void GetHashCode_basic_Tx() {
            // ## Arrange ##
            Member member1 = new Member();
            Member member2 = new Member();

            // ## Act & Assert ##
            log(member1.GetHashCode());
            assertEquals(member1.GetHashCode(), member2.GetHashCode());
            assertEquals(member1.GetHashCode(), member1.GetHashCode());
            assertEquals(member2.GetHashCode(), member2.GetHashCode());
            member1.MemberId = 3;
            member2.MemberId = 3;
            log(member1.GetHashCode());
            assertEquals(member1.GetHashCode(), member2.GetHashCode());
            assertEquals(member1.GetHashCode(), member1.GetHashCode());
            assertEquals(member2.GetHashCode(), member2.GetHashCode());
            member1.MemberId = 333;
            member2.MemberId = 444;
            log(member1.GetHashCode());
            assertNotSame(member1.GetHashCode(), member2.GetHashCode());
            assertNotSame(member1.GetHashCode(), member1.GetHashCode());
            assertNotSame(member2.GetHashCode(), member2.GetHashCode());
        }

        // ===============================================================================
        //                                                          toStringWithRelation()
        //                                                          ======================
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void ToStringWithRelation_nonRelation() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            cb.Query().SetMemberId_Equal(18);

            // ## Act ##
            Member member = _memberBhv.SelectEntityWithDeletedCheck(cb);
            String detail = member.ToStringWithRelation();

            // ## Assert ##
            log(detail);
            MemberDbm dbm = MemberDbm.GetInstance();
            assertTrue(detail.Contains("Member"));
            assertFalse(detail.Contains(dbm.ForeignMemberStatus.ForeignPropertyName));
            assertFalse(detail.Contains("MemberStatus"));
        }

        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void ToStringWithRelation_withManyToOne() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            cb.SetupSelect_MemberStatus();

            // ## Act ##
            IList<Member> memberList = _memberBhv.SelectList(cb);

            // ## Assert ##
            StringBuilder sb = new StringBuilder();
            foreach (Member member in memberList) {
                String detail = member.ToStringWithRelation();
                MemberDbm dbm = MemberDbm.GetInstance();
                sb.append(getLineSeparator()).append(detail);
                assertTrue(detail.Contains("Member"));
                assertTrue(detail.Contains(dbm.ForeignMemberStatus.ForeignPropertyName));
                assertTrue(detail.Contains("MemberStatus"));
                assertFalse(detail.Contains(dbm.ReferrerPurchaseList.ReferrerPropertyName));
            }
            log(sb.toString());
        }
        
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void ToStringWithRelation_withOneToOne() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            cb.SetupSelect_MemberAddressAsValid(currentTimestamp());
            cb.SetupSelect_MemberSecurityAsOne();
            cb.SetupSelect_MemberWithdrawalAsOne();

            // ## Act ##
            IList<Member> memberList = _memberBhv.SelectList(cb);

            // ## Assert ##
            StringBuilder sb = new StringBuilder();
            foreach (Member member in memberList) {
                String detail = member.ToStringWithRelation();
                MemberDbm dbm = MemberDbm.GetInstance();
                sb.append(getLineSeparator()).append(detail);
                assertTrue(detail.Contains("Member"));
                assertFalse(detail.Contains(dbm.ForeignMemberStatus.ForeignPropertyName));
                assertFalse(detail.Contains("MemberStatus"));
                if (member.MemberAddressAsValid != null) {
                    assertTrue(detail.Contains(dbm.ForeignMemberAddressAsValid.ForeignPropertyName));
                }
                if (member.MemberSecurityAsOne != null) {
                    assertTrue(detail.Contains(dbm.ForeignMemberSecurityAsOne.ForeignPropertyName));
                }
                if (member.MemberWithdrawalAsOne != null) {
                    assertTrue(detail.Contains(dbm.ForeignMemberWithdrawalAsOne.ForeignPropertyName));
                }
                assertFalse(detail.Contains(dbm.ReferrerPurchaseList.ReferrerPropertyName));
            }
            log(sb.toString());
        }
                
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void ToStringWithRelation_withOneToMany() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();

            // ## Act ##
            IList<Member> memberList = _memberBhv.SelectList(cb);
            _memberBhv.LoadPurchaseList(memberList, delegate(PurchaseCB subCB) {
            });
            _memberBhv.LoadMemberAddressList(memberList, delegate(MemberAddressCB subCB) {
            });
            _memberBhv.LoadMemberLoginList(memberList, delegate(MemberLoginCB subCB) {
            });

            // ## Assert ##
            StringBuilder sb = new StringBuilder();
            foreach (Member member in memberList) {
                String detail = member.ToStringWithRelation();
                MemberDbm dbm = MemberDbm.GetInstance();
                sb.append(getLineSeparator()).append(detail);
                assertTrue(detail.Contains("Member"));
                assertFalse(detail.Contains(dbm.ForeignMemberStatus.ForeignPropertyName));
                assertFalse(detail.Contains("MemberStatus"));
                assertFalse(detail.Contains(dbm.ForeignMemberAddressAsValid.ForeignPropertyName));
                assertFalse(detail.Contains(dbm.ForeignMemberSecurityAsOne.ForeignPropertyName));
                assertFalse(detail.Contains(dbm.ForeignMemberWithdrawalAsOne.ForeignPropertyName));
                if (member.MemberAddressList.Count > 0) {
                    assertTrue(detail.Contains(dbm.ReferrerMemberAddressList.ReferrerPropertyName));
                }
                if (member.MemberLoginList.Count > 0) {
                    assertTrue(detail.Contains(dbm.ReferrerMemberLoginList.ReferrerPropertyName));
                }
                if (member.PurchaseList.Count > 0) {
                    assertTrue(detail.Contains(dbm.ReferrerPurchaseList.ReferrerPropertyName));
                }
            }
            log(sb.toString());
        }
                
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void ToStringWithRelation_withAll() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            cb.SetupSelect_MemberStatus();
            cb.SetupSelect_MemberAddressAsValid(currentTimestamp());
            cb.SetupSelect_MemberSecurityAsOne();
            cb.SetupSelect_MemberWithdrawalAsOne();

            // ## Act ##
            IList<Member> memberList = _memberBhv.SelectList(cb);
            _memberBhv.LoadPurchaseList(memberList, delegate(PurchaseCB subCB) {
            });
            _memberBhv.LoadMemberAddressList(memberList, delegate(MemberAddressCB subCB) {
            });
            _memberBhv.LoadMemberLoginList(memberList, delegate(MemberLoginCB subCB) {
            });

            // ## Assert ##
            StringBuilder sb = new StringBuilder();
            foreach (Member member in memberList) {
                String detail = member.ToStringWithRelation();
                MemberDbm dbm = MemberDbm.GetInstance();
                sb.append(getLineSeparator()).append(detail);
                assertTrue(detail.Contains("Member"));
                assertTrue(detail.Contains(dbm.ForeignMemberStatus.ForeignPropertyName));
                assertTrue(detail.Contains("MemberStatus"));
                if (member.MemberAddressAsValid != null) {
                    assertTrue(detail.Contains(dbm.ForeignMemberAddressAsValid.ForeignPropertyName));
                }
                if (member.MemberSecurityAsOne != null) {
                    assertTrue(detail.Contains(dbm.ForeignMemberSecurityAsOne.ForeignPropertyName));
                }
                if (member.MemberWithdrawalAsOne != null) {
                    assertTrue(detail.Contains(dbm.ForeignMemberWithdrawalAsOne.ForeignPropertyName));
                }
                if (member.MemberAddressList.Count > 0) {
                    assertTrue(detail.Contains(dbm.ReferrerMemberAddressList.ReferrerPropertyName));
                }
                if (member.MemberLoginList.Count > 0) {
                    assertTrue(detail.Contains(dbm.ReferrerMemberLoginList.ReferrerPropertyName));
                }
                if (member.PurchaseList.Count > 0) {
                    assertTrue(detail.Contains(dbm.ReferrerPurchaseList.ReferrerPropertyName));
                }
            }
            log(sb.toString());
        }
    }
}

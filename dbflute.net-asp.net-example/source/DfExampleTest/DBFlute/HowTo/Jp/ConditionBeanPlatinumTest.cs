using System;
using System.Collections.Generic;
using DfExample.DBFlute.AllCommon.Ado;
using DfExample.DBFlute.AllCommon.Bhv.Setup;
using DfExample.DBFlute.AllCommon.CBean.COption;
using DfExample.DBFlute.AllCommon.Exp;
using DfExample.DBFlute.AllCommon.Util;
using DfExample.DBFlute.ExBhv;
using DfExample.DBFlute.CBean;
using DfExample.DBFlute.ExEntity;
using DfExample.DBFlute.AllCommon.CBean;
using Seasar.Quill.Unit;
using Seasar.Extension.Unit;

namespace DfExample.DBFlute.HowTo.Jp {

    /// <summary>
    /// ConditionBean�̏㋉��Example�����B
    /// 
    /// �^�[�Q�b�g�͈ȉ��̒ʂ�F
    ///   o DBFlute���Ăǂ������@�\������̂���T���Ă����
    ///   o DBFlute�Ŏ������J�n������E�������Ă����
    ///   
    /// �R���e���c�͈ȉ��̒ʂ�F
    ///   x �󔒋�؂�̘A���B������(And����): option.likeContain().splitBySpace().
    ///   x �󔒋�؂�̘A���B������(Or����): option.likeContain().splitBySpace().asOrSplit().
    ///   o Exists��̒���Union: existsXxxList(), union().
    ///   o null���ŏ��ɕ��ׂ�: addOrderBy_Xxx_Asc().withNullsFirst().
    ///   o null���Ō�ɕ��ׂ�: addOrderBy_Xxx_Asc().withNullsLast().
    ///   o null���Ō�ɕ��ׂ�(Union�Ƌ���): addOrderBy_Xxx_Asc().withNullsLast(), union().
    ///   o Union�̃��[�v�ɂ��s�萔�ݒ�: for { cb.union() }.
    ///   o Union���g�����y�[�W���O����: union(), selectPage().
    ///   o OnClause(On��)�ɏ�����ǉ�: queryXxx().on().
    ///   o �擾�J�����̎w��(SpecifyColumn): Specify().ColumnXxx().
    ///   o �q�e�[�u�����o�J�����̎w��(SpecifyDerivedReferrer)-Max: specify().derivedXxxList().max().
    ///   o �q�e�[�u�����o�J�����ŕ��ёւ�(SpecifiedDerivedOrderBy)-Count: addSpecifiedDerivedOrderBy_Desc().
    ///   o Statement�̃R���t�B�O��ݒ�: cb.configure(statementConfig).
    ///   o �ǂ�Ȃ�SubQuery��Union�̘A�ł����Ă�SQL���Y��Ƀt�H�[�}�b�g: toDisplaySql().
    /// </summary>
    [MbUnit.Framework.TestFixture]
    public class ConditionBeanPlatinumTest : ContainerTestCase {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected MemberBhv _memberBhv;
        protected MemberWithdrawalBhv _memberWithdrawalBhv;

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        // -------------------------------------------------
        //                                        LikeSearch
        //                                        ----------

        // -------------------------------------------------
        //                                    ExistsSubQuery
        //                                    --------------
        /**
         * Exists��̒���Union: existsXxxList(), union().
         * ���i���̂�'s'��������'a'���܂܂�鏤�i���w���������Ƃ̂������������B
         */
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void Query_Exists_Union() {
            MemberCB cb = new MemberCB();
            LikeSearchOption option = new LikeSearchOption().LikeContain();
            cb.Query().ExistsPurchaseList(delegate(PurchaseCB purchaseCB) {
                purchaseCB.Query().SetPurchaseCount_GreaterThan(2);
                purchaseCB.Union(delegate(PurchaseCB purchaseUnionCB) {
                    purchaseUnionCB.Query().QueryProduct().SetProductName_LikeSearch("s", option);
                });
                purchaseCB.Union(delegate(PurchaseCB purchaseUnionCB) {
                    purchaseUnionCB.Query().QueryProduct().SetProductName_LikeSearch("a", option);
                });
            });

            // ## Act ##
            ListResultBean<Member> memberList = _memberBhv.SelectList(cb);

            // ## Assert ##
            ConditionBeanSetupper<PurchaseCB> setuppper = delegate(PurchaseCB subCB) {
                subCB.SetupSelect_Product();
            };
            _memberBhv.LoadPurchaseList(memberList, setuppper);
            foreach (Member member in memberList) {
                log("[member] " + member.MemberId + ", " + member.MemberName);
                IList<Purchase> purchaseList = member.PurchaseList;
                bool existsPurchase = false;
                foreach (Purchase purchase in purchaseList) {
                    Product product = purchase.Product;
                    long? purchaseCount = purchase.PurchaseCount;
                    String productName = product.ProductName;
                    log("  [purchase] " + purchase.PurchaseId + ", " + purchaseCount + ", " + productName);
                    if (purchaseCount > 2 || productName.Contains("s") || productName.Contains("a")) {
                        existsPurchase = true;
                    }
                }
                assertTrue(existsPurchase);
            }
        }

        // -------------------------------------------------
        //                                  Nulls First/Last
        //                                  ----------------
        /**
         * null���ŏ��ɕ��ׂ�: addOrderBy_Xxx_Asc().withNullsFirst().
         * ���N�����̏�����null�̂��͍̂ŏ��ɕ��ׂ�B
         */
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void Query_AddOrderBy_WithNullsFirst() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            cb.Query().AddOrderBy_Birthdate_Asc().WithNullsFirst();

            // ## Act ##
            ListResultBean<Member> memberList = _memberBhv.SelectList(cb);

            // ## Assert ##
            bool nulls = true;
            bool border = false;
            foreach (Member member in memberList) {
                DateTime? birthday = member.Birthdate;
                log(member.MemberId + ", " + member.MemberName + ", " + birthday);
                if (nulls) {
                    if (birthday != null && !border) {
                        nulls = false;
                        border = true;
                        continue;
                    }
                    assertNull(birthday);
                } else {
                    assertNotNull(birthday);
                }
            }
            assertTrue(border);
        }


        /**
         * null���Ō�ɕ��ׂ�: addOrderBy_Xxx_Asc().withNullsLast().
         * ���N�����̏�����null�̂��͍̂Ō�ɕ��ׂ�B
         */
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void Query_AddOrderBy_WithNullsLast() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            cb.Query().AddOrderBy_Birthdate_Asc().WithNullsLast();

            // ## Act ##
            ListResultBean<Member> memberList = _memberBhv.SelectList(cb);

            // ## Assert ##
            bool nulls = false;
            bool border = false;
            foreach (Member member in memberList) {
                DateTime? birthday = member.Birthdate;
                log(member.MemberId + ", " + member.MemberName + ", " + birthday);
                if (nulls) {
                    assertNull(birthday);
                } else {
                    if (birthday == null && !border) {
                        nulls = true;
                        border = true;
                        continue;
                    }
                    assertNotNull(birthday);
                }
            }
            assertTrue(border);
        }

        /**
         * null���Ō�ɕ��ׂ�(Union�Ƌ���): addOrderBy_Xxx_Asc().withNullsLast(), union().
         * ���N�����̂���Ȃ���Union�ł�������񂱂��āA���N�����̏�����null�̂��͍̂Ō�ɕ��ׂ�B
         */
        public void Query_AddOrderBy_WithNullsLast_and_Union() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            cb.Query().SetBirthdate_IsNull();
            cb.Union(delegate(MemberCB unionCB) {
                unionCB.Query().SetBirthdate_IsNotNull();
            });
            cb.Query().AddOrderBy_Birthdate_Asc().WithNullsLast();

            // ## Act ##
            ListResultBean<Member> memberList = _memberBhv.SelectList(cb);

            // ## Assert ##
            bool nulls = false;
            bool border = false;
            foreach (Member member in memberList) {
                DateTime? birthday = member.Birthdate;
                log(member.MemberId + ", " + member.MemberName + ", " + birthday);
                if (nulls) {
                    assertNull(birthday);
                } else {
                    if (birthday == null && !border) {
                        nulls = true;
                        border = true;
                        continue;
                    }
                    assertNotNull(birthday);
                }
            }
            assertTrue(border);
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
        /**
         * Union�̃��[�v�ɂ��s�萔�ݒ�: for { cb.union() }.
         */
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void SelectList_Union_LoopIndefiniteSetting() {
            // ## Arrange ##
            String keywordDelimiterString = "S M D";
            String[] keywordList = keywordDelimiterString.Split(' ');

            MemberCB cb = new MemberCB();
            cb.SetupSelect_MemberStatus();

            LikeSearchOption prefixOption = new LikeSearchOption().LikePrefix();
            bool first = true;
            foreach (String keyword in keywordList) {
                if (first) {
                    cb.Query().SetMemberAccount_LikeSearch(keyword, prefixOption);
                    first = false;
                    continue;
                }
                cb.Union(delegate(MemberCB unionCB) {
                    unionCB.Query().SetMemberAccount_LikeSearch(keyword, prefixOption);
                });
            }

            // ## Act ##
            ListResultBean<Member> memberList = _memberBhv.SelectList(cb);

            // ## Assert ##
            log("/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * ");
            assertTrue(memberList.Count > 0);
            foreach (Member member in memberList) {
                String memberName = member.MemberName;
                String memberAccount = member.MemberAccount;
                log(memberName + "(" + memberAccount + ")");
                assertTrue("Unexpected memberAccount = " + memberAccount, memberAccount.StartsWith("S")
                        || memberAccount.StartsWith("M") || memberAccount.StartsWith("D"));
            }
            log("* * * * * * * * * */");
        }

        /**
         * Union���g�����y�[�W���O����: union(), selectPage().
         * �i�荞�ݏ����́u�މ����ł��邱�Ɓv�������́u�P�T�O�O�~�ȏ�̍w�����������Ƃ�����v�B
         * �u�a�����̍~�������ID�̏����v�ŕ��ׂāA�P�y�[�W���R���Ƃ��ăy�[�W���O�����B
         * <pre>
         * selectPage()�����Ńy�[�W���O�̊�{���S�Ď��s�����F
         *   1. �y�[�W���O�Ȃ������擾
         *   2. �y�[�W���O���f�[�^����
         *   3. �y�[�W���O���ʌv�Z����
         * 
         * PagingResultBean����l�X�ȗv�f���擾�\�F
         *   o �y�[�W���O�Ȃ�������
         *   o ���݃y�[�W�ԍ�
         *   o ���y�[�W��
         *   o �O�y�[�W�̗L������
         *   o ���y�[�W�̗L������
         *   o �y�[�W���O�i�r�Q�[�V�����v�f�y�[�W���X�g
         *   o �ȂǂȂ�
         * </pre>
         */
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void SelectPage_Union_ExistsSubQuery() {
            // ## Arrange ##
            int fetchSize = 3;
            MemberCB cb = new MemberCB();
            cb.Query().SetMemberStatusCode_Equal_Withdrawal();
            cb.Union(delegate(MemberCB unionCB) {
                unionCB.Query().ExistsPurchaseList(delegate(PurchaseCB subCB) {
                    subCB.Query().SetPurchasePrice_GreaterEqual(1500);
                });
            });
            cb.Query().AddOrderBy_Birthdate_Desc().AddOrderBy_MemberId_Asc();

            // ## Act ##
            cb.Paging(fetchSize, 1);
            PagingResultBean<Member> page1 = _memberBhv.SelectPage(cb);
            cb.Paging(fetchSize, 2);
            PagingResultBean<Member> page2 = _memberBhv.SelectPage(cb);
            cb.Paging(fetchSize, 3);
            PagingResultBean<Member> page3 = _memberBhv.SelectPage(cb);
            cb.Paging(fetchSize, page1.AllPageCount);// Last Page
            PagingResultBean<Member> lastPage = _memberBhv.SelectPage(cb);

            // ## Assert ##
            assertEquals(fetchSize, page1.Count);
            assertEquals(fetchSize, page2.Count);
            assertEquals(fetchSize, page3.Count);
            assertNotSame(page1[0].MemberId, page2[0].MemberId);
            assertNotSame(page2[0].MemberId, page3[0].MemberId);
            assertNotSame(page3[0].MemberId, lastPage[0].MemberId);
            assertEquals(1, page1.CurrentPageNumber);
            assertEquals(2, page2.CurrentPageNumber);
            assertEquals(3, page3.CurrentPageNumber);
            assertEquals(page1.AllPageCount, lastPage.CurrentPageNumber);
            assertEquals(page1.AllRecordCount, page2.AllRecordCount);
            assertEquals(page2.AllRecordCount, page3.AllRecordCount);
            assertEquals(page3.AllRecordCount, lastPage.AllRecordCount);
            assertEquals(page1.AllPageCount, page2.AllPageCount);
            assertEquals(page2.AllPageCount, page3.AllPageCount);
            assertEquals(page3.AllPageCount, lastPage.AllPageCount);
            assertFalse(page1.IsExistPrePage());
            assertTrue(page1.IsExistNextPage());
            assertTrue(lastPage.IsExistPrePage());
            assertFalse(lastPage.IsExistNextPage());

            ConditionBeanSetupper<PurchaseCB> setupper = delegate(PurchaseCB subCB) {
                subCB.Query().SetPurchasePrice_GreaterEqual(1500);
            };
            _memberBhv.LoadPurchaseList(page1, setupper);
            _memberBhv.LoadPurchaseList(page2, setupper);
            _memberBhv.LoadPurchaseList(page3, setupper);
            _memberBhv.LoadPurchaseList(lastPage, setupper);
            SelectPageUnionExistsSbuQueryAssertBoolean bl = new SelectPageUnionExistsSbuQueryAssertBoolean();
            findTarget_of_selectPage_union_existsSubQuery(page1, bl);
            findTarget_of_selectPage_union_existsSubQuery(page2, bl);
            findTarget_of_selectPage_union_existsSubQuery(page3, bl);
            findTarget_of_selectPage_union_existsSubQuery(lastPage, bl);
            assertTrue(bl.isExistsWithdrawalOnly());
            assertTrue(bl.isExistsPurchasePriceOnly());

            // �Ō�ɖڂŊm�F���邽�߂�SQL�����O��
            log("/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * ");
            String displaySql = cb.ToDisplaySql();
            String newLine = getLineSeparator();
            log(newLine + SimpleStringUtil.Replace(displaySql, " union ", newLine + " union "));
            log("* * * * * * * * * */");
        }

        protected void findTarget_of_selectPage_union_existsSubQuery(PagingResultBean<Member> memberPage,
                SelectPageUnionExistsSbuQueryAssertBoolean bl) {
            foreach (Member member in memberPage) {
                IList<Purchase> purchaseList = member.PurchaseList;
                bool existsPurchaseTarget = false;
                foreach (Purchase purchase in purchaseList) {
                    if (purchase.PurchasePrice >= 1500) {
                        existsPurchaseTarget = true;
                    }
                }
                if (!existsPurchaseTarget && member.IsMemberStatusCodeWithdrawal) {
                    bl.setExistsWithdrawalOnly(true);
                } else if (existsPurchaseTarget && !member.IsMemberStatusCodeWithdrawal) {
                    bl.setExistsPurchasePriceOnly(true);
                }
            }
        }

        protected class SelectPageUnionExistsSbuQueryAssertBoolean {
            protected bool existsWithdrawalOnly = false;
            protected bool existsPurchasePriceOnly = false;

            public bool isExistsWithdrawalOnly() {
                return existsWithdrawalOnly;
            }

            public void setExistsWithdrawalOnly(bool existsWithdrawalOnly) {
                this.existsWithdrawalOnly = existsWithdrawalOnly;
            }

            public bool isExistsPurchasePriceOnly() {
                return existsPurchasePriceOnly;
            }

            public void setExistsPurchasePriceOnly(bool existsPurchasePriceOnly) {
                this.existsPurchasePriceOnly = existsPurchasePriceOnly;
            }
        }

        // ===============================================================================
        //                                                                  Specify Column
        //                                                                  ==============
        /// <summary>
        /// �擾�J�����̎w��(SpecifyColumn): Specify().ColumnXxx().
        /// ������̂Ɖ���X�e�[�^�X���̂����̈ꗗ����������B
        /// �p�t�H�[�}���X��̍l���łP�~���b�ł������������V�r�A�Ȍ��������̏ꍇ�̂��߂ɁA
        /// �擾�J�������w�肷�邱�Ƃ��ł���B�P�e�[�u���̃J���������₽�瑽���Ƃ��ɗL���B
        /// </summary>
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void SpecifyColumn() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            cb.SetupSelect_MemberStatus();
            cb.Specify().ColumnMemberName();
            cb.Specify().SpecifyMemberStatus().ColumnMemberStatusName();

            // ## Act ##
            IList<Member> memberList = _memberBhv.SelectList(cb);

            // ## Assert ##
            assertNotSame(0, memberList.Count);
            foreach (Member member in memberList) {
                assertNotNull(member.MemberId); // PK
                assertNotNull(member.MemberName); // Specified
                assertNull(member.MemberAccount);
                assertNull(member.Birthdate);
                assertNull(member.FormalizedDatetime);
                assertNull(member.RegisterDatetime);
                assertNull(member.RegisterProcess);
                assertNull(member.RegisterUser);
                assertNull(member.UpdateDatetime);
                assertNull(member.UpdateProcess);
                assertNull(member.UpdateUser);
                assertNull(member.VersionNo);
                assertNotNull(member.MemberStatusCode); // SetupSelect FK
                assertNotNull(member.MemberStatus.MemberStatusCode); // PK
                assertNotNull(member.MemberStatus.MemberStatusName); // Specified
                assertNull(member.MemberStatus.DisplayOrder);
            }

            // [Description]
            // A. ������e�[�u���Ɋւ��ẮAsetupSelect_Xxx()���Ăяo�����Ƃɕς��͂Ȃ��A
            //    setupSelect�����e�[�u���̒�����擾����J�������w�肷��B
            //    --> setupSelect���ĂȂ��e�[�u���̃J�������w�肷��Ɨ�O�ƂȂ�B
            // 
            // B. �J�������w�肳�ꂽ�e�[�u���̂݃J�������i�荞�܂�A�J�������w�肳��Ȃ��e�[�u����
            //    �ʏ�ʂ�S�ẴJ�������擾�����B
            //    --> �Ⴆ�΁A�����̌�����e�[�u�������J�����w��ɂ��邱�Ƃ��\
            // 
            // C. PK�́A�J�������w�肳��Ȃ��Ă��K���擾�����B(�Öق̎w��J����)
            // D. SetupSelect���ꂽFK�́A�J�������w�肳��Ȃ��Ă��K���擾�����B(�Öق̎w��J����)
        }

        // ===============================================================================
        //                                                                        OnClause
        //                                                                        ========
        /**
         * OnClause(On��)�ɏ�����ǉ�: queryXxx().on().
         * <code>{left outer join xxx on xxx = xxx and [column] = ?}</code>
         * <p>
         * �u����މ��񂪑��݂��Ă������ꗗ�v�ɑ΂��āA�u�މ�R�R�[�h��null�łȂ�����މ���v���������Ď擾�B
         * ����މ��񂪑��݂��Ă��Ă��މ�R�R�[�h��null�̉���́A����މ��񂪎擾����Ȃ��悤�ɂ���B
         * </p>
         * <p>
         * OnClause�ɏ�����ǉ�����Ɓu�����ɍ��v���Ȃ������惌�R�[�h�͌������Ȃ��v�Ƃ��������ɂȂ�B
         * �悭�g����̂́u�]�����Ȃ��֌W�̌�����e�[�u���Ř_���폜���ꂽ���̂͌������Ȃ��v�Ƃ����悤�ȏꍇ�B
         * </p>
         * <p>
         * OnClause���g��Ȃ���Where��ɏ���������ƁA�����ɍ��v���Ȃ������惌�R�[�h��
         * �Q�Ƃ��Ă����_���R�[�h�������ΏۊO�ɂȂ��Ă��܂��B<br />
         * <code>{left outer join xxx on xxx = xxx where [column] = ?}</code>
         * </p>
         * <pre>
         * �Ⴆ�΁A���{1,2,3,4,5}�ɑ΂��ĉ���މ���{A,B,C}������A���ꂼ��{1-A, 2-B, 3-C, 4-null, 5-null}
         * �Ƃ����悤�Ȋ֌W�ŁA�uB�v���މ�R�R�[�h�������Ă��Ȃ�����މ���ł������ꍇ�F
         * 
         * �f���Ɂu��� left outer join ����މ��� on ...�v����ƌ��ʂ͈ȉ��̂悤�ɂȂ�B
         * 
         * �@�@�������ʁF{1-A, 2-B, 3-C, 4-null, 5-null}
         * 
         * ������u��� left outer join ����މ��� on ... and ����މ���.�މ�R�R�[�h is not null�v
         * �Ƃ����悤��On��̒��Łu�މ�R�R�[�h�����݂��邱�Ɓv�Ƃ���������t�^����ƈȉ��̂悤�ɂȂ�B
         * 
         * �@�@�������ʁF{1-A, 2-null, 3-C, 4-null, 5-null}
         * 
         * �މ�R�R�[�h�������Ă��Ȃ��uB�v���e����Č�������Ȃ��̂ł���B
         * ������Ƃ����āu2�v�̉�����̂��������ʂ���O��邱�Ƃ͂Ȃ��B
         * 
         * ������u��� left outer join ����މ��� on ... where ����މ���.�މ�R�R�[�h is not null�v
         * �Ƃ����悤��Where��ɂāu�މ�R�R�[�h�����݂��邱�Ɓv�Ƃ���������t�^����ƈȉ��̂悤�ɂȂ�B
         * 
         * �@�@�������ʁF{1-A, 3-C}
         * 
         * ����͍����肽�������Ƃ͑S���Ⴄ���̂ł���B
         * </pre>
         * <p>
         * OnClause�łȂ�InlineView���g���Ă������������������邱�Ƃ͉\�ł���B
         * �������A�����ɂ���Ă�InlineView�̒��Ńt���X�L�����������Ă��܂��\��������̂ŁA
         * �p�t�H�[�}���X�̊ϓ_����OnClause�̕����ǂ����Ǝv����B(���s�v�悪�قȂ�)
         * �A���A����̓I�v�e�B�}�C�U����Ȃ̂ŁA�C�ɂȂ�����ǂ��炩�ɒ�������̂��ǂ��Ǝv����B<br />
         * <code>{left outer join (select * from xxx where [column] = ?) xxx on xxx = xxx}</code>
         * </p>
         */
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void SelectList_Query_QueryForeign_On() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            cb.SetupSelect_MemberWithdrawalAsOne();

            // �u�މ�R�R�[�h��null�łȂ�����މ���v�̃��R�[�h�͌�������ĂȂ��悤�ɂ���
            // left outer join xxx on xxx = xxx and WithdrawalReasonCode is not null
            cb.Query().QueryMemberWithdrawalAsOne().On().SetWithdrawalReasonCode_IsNotNull();

            // left outer join (select * from xxx where WithdrawalReasonCode is not null) xxx on xxx = xxx
            // cb.query().queryMemberWithdrawalAsOne().inline().setWithdrawalReasonCode_IsNotNull();

            // ����މ��񂪑��݂������������擾����悤�ɂ���
            cb.Query().InScopeMemberWithdrawalAsOne(delegate(MemberWithdrawalCB subCB) {
            });
            cb.Query().QueryMemberWithdrawalAsOne().AddOrderBy_WithdrawalDatetime_Desc();

            // ## Act ##
            ListResultBean<Member> memberList = _memberBhv.SelectList(cb);

            // ## Assert ##
            assertNotSame(0, memberList.Count);
            bool existsMemberWithdrawal = false;// ����މ��񂪂�����WithdrawalReasonCode�����݂����������邩�ۂ�
            bool notExistsMemberWithdrawal = false;// ����މ���͂��邯��WithdrawalReasonCode���Ȃ���������邩�ۂ�
            IList<long?> notExistsMemberIdList = new List<long?>();
            foreach (Member member in memberList) {
                MemberWithdrawal memberWithdrawal = member.MemberWithdrawalAsOne;
                if (memberWithdrawal != null) {
                    log(member.MemberName + " -- " + memberWithdrawal.WithdrawalReasonCode + ", "
                            + memberWithdrawal.WithdrawalDatetime);
                    String withdrawalReasonCode = memberWithdrawal.WithdrawalReasonCode;
                    assertNotNull(withdrawalReasonCode);
                    existsMemberWithdrawal = true;
                } else {
                    // ����މ���͑��݂��邯��WithdrawalReasonCode�����݂��Ȃ�������擾�ł��Ă��邱��
                    log(member.MemberName + " -- " + memberWithdrawal);
                    notExistsMemberWithdrawal = true;
                    notExistsMemberIdList.Add(member.MemberId);
                }
            }
            // �����̃p�^�[���̃f�[�^���Ȃ��ƃe�X�g�ɂȂ�Ȃ��̂Ŋm�F
            assertTrue(existsMemberWithdrawal);
            assertTrue(notExistsMemberWithdrawal);
            // MemberWithdrawal���擾�ł��Ȃ���������̉���މ��񂪂����Ƃ��邩�ǂ����m�F
            foreach (int? memberId in notExistsMemberIdList) {
                MemberWithdrawalCB pkCB = new MemberWithdrawalCB();
                pkCB.Query().SetMemberId_Equal(memberId);
                _memberWithdrawalBhv.SelectEntityWithDeletedCheck(pkCB);// Expected no exception
            }
        }

        // ===============================================================================
        //                                                         Specify DerivedReferrer
        //                                                         =======================
        /**
         * �q�e�[�u�����o�J�����̎w��(SpecifyDerivedReferrer)-Max: specify().derivedXxxList().max().
         * ����̍ŏI���O�C���������擾�B�A���A���o�C���[������̃��O�C���͏����B
         * <p>
         * �q�e�[�u���̓��o�J�������w�肷�邱�Ƃ��ł���B
         * �Ⴆ�΁A�q�e�[�u���̂Ƃ���J�����̍��v�l��ő�l�Ȃǂ��擾���邱�Ƃ��\�ł���B
         * ����SQL���̃C���[�W�͈ȉ��̒ʂ�F
         * </p>
         * <pre>
         * ex) �ŏI���O�C���������擾����SQL
         * select member.*
         *      , (select max(LOGIN_DATETIME)
         *           from MEMBER_LOGIN
         *          where MEMBER_ID = member.MEMBER_ID
         *            and LOGIN_MOBILE_FLG = 0
         *        ) as LATEST_LOGIN_DATETIME
         *   from MEMBER member
         * </pre>
         * @since 0.8.0
         */
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void SepcifyDerivedReferrer_Max() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            cb.Specify().DerivedMemberLoginList().Max(delegate(MemberLoginCB subCB) {
                subCB.Specify().ColumnLoginDatetime(); // *Point!
                subCB.Query().SetMobileLoginFlg_Equal_False(); // Except Mobile
            }, "LATEST_LOGIN_DATETIME");

            // ## Act ##
            ListResultBean<Member> memberList = _memberBhv.SelectList(cb);

            // ## Assert ##
            assertNotSame(0, memberList.Count);
            bool existsLoginDatetime = false;
            bool existsNullLoginDatetime = false;
            foreach (Member member in memberList) {
                String memberName = member.MemberName;
                DateTime? latestLoginDatetime = member.LatestLoginDatetime;
                if (latestLoginDatetime != null) {
                    existsLoginDatetime = true;
                } else {
                    // ���O�C������x�����Ă��Ȃ�����A�������́A���o�C���ł������O�C��
                    // �������Ƃ̂Ȃ�����̍ŏI���O�C��������null�ɂȂ�B
                    existsNullLoginDatetime = true;
                }
                log("memberName=" + memberName + ", latestLoginDatetime=" + latestLoginDatetime);
            }
            assertTrue(existsLoginDatetime);
            assertTrue(existsNullLoginDatetime);

            // [Description]
            // A. �����O�ɓ��o�J�������󂯎�邽�߂̃v���p�e�B��Entity�ɒ�`����K�v������B
            // 
            //    ex) Extended��Entity(ExEntity)�ɍŏI���O�C�������̃v���p�e�B���蓮�Ŏ���
            //    protected Date _latestLoginDatetime;
            //    public Date getLatestLoginDatetime() {
            //        return _latestLoginDatetime;
            //    }
            //    public void setLatestLoginDatetime(Date latestLoginDatetime) {
            //        _latestLoginDatetime = latestLoginDatetime;
            //    }
            // 
            // B. �֐��ɂ́A{max, min, sum, avg, count}�����p�\�ł���B
            //    --> sum��avg�͐��l�^�̂ݗ��p�\
            //    --> count�̏ꍇ�͎q�e�[�u����PK�𓱏o�J�����Ƃ��邱�Ƃ���{
            // 
            // C. �K��SubQuery�̒��œ��o�J�������u��v�w�肷�邱�ƁB
            //    --> �����w�肵�Ȃ��A�������́A��ȏ�̎w��ŗ�O����
            // 
            // D. ���o�J�����͎q�e�[�u���̃J�����̂݃T�|�[�g�����B
            //    --> �q�e�[�u���̕ʂ̐e�e�[�u��(��������one-to-one)�̃J�����𓱏o�J�����ɂ͂ł��Ȃ��B
            // 
            // E. ��_�e�[�u����������L�[�̏ꍇ�̓T�|�[�g����Ȃ��B
            // 
            // F. one-to-one�̎q�e�[�u���̏ꍇ�̓T�|�[�g����Ȃ��B(���������s�v�ł���)
            // 
            // G. SubQuery�̒���setupSelect��addOrderBy���w�肵�Ă����Ӗ��ł���B
            // 
            // H. SpecifyColumn��Union�Ƃ��g�ݍ��킹�ė��p���邱�Ƃ��\�ł���B
        }

        /**
         * �q�e�[�u�����o�J�����ŕ��ёւ�(SpecifiedDerivedOrderBy)-Count: addSpecifiedDerivedOrderBy_Desc().
         * ����̃��O�C���񐔂��擾����ۂɁA���O�C���񐔂̑����������ĉ��ID�̏����ŕ��ׂ�B�A���A���o�C���[������̃��O�C���͏����B
         * <p>
         * �q�e�[�u���̓��o�J�����ŕ��ёւ������邱�Ƃ��ł���B
         * SQL���̃C���[�W�͈ȉ��̒ʂ�F
         * </p>
         * <pre>
         * ex) ���O�C���񐔂��擾����SQL
         * select member.*
         *      , (select count(MEMBER_LOGIN_ID)
         *           from MEMBER_LOGIN
         *          where MEMBER_ID = member.MEMBER_ID
         *        ) as LOGIN_COUNT
         *   from MEMBER member
         *  order by LOGIN_COUNT desc, member.MEMBER_ID asc
         * </pre>
         * @since 0.8.0
         */
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void AddSepcifidDerivedOrderBy_Count() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            cb.Specify().DerivedMemberLoginList().Count(delegate(MemberLoginCB subCB) {
                subCB.Specify().ColumnMemberLoginId(); // *Point!
                subCB.Query().SetMobileLoginFlg_Equal_False(); // Except Mobile
            }, "LOGIN_COUNT");
            cb.Query().AddSpecifiedDerivedOrderBy_Desc("LOGIN_COUNT");
            cb.Query().AddOrderBy_MemberId_Asc();

            // ## Act ##
            ListResultBean<Member> memberList = _memberBhv.SelectList(cb);

            // ## Assert ##
            assertNotSame(0, memberList.Count);
            foreach (Member member in memberList) {
                String memberName = member.MemberName;
                int? loginCount = member.LoginCount;
                assertNotNull(loginCount); // count()�Ȃ̂�0���̏ꍇ��0�ɂȂ�(DB���悩��...)
                log("memberName=" + memberName + ", loginCount=" + loginCount);
            }
            // [Description]
            // A. SpecifyDerivedReferrer�Ŏw�肳��Ă��Ȃ�AliasName���w�肷��Ɨ�O�����B
            // 
            // B. withNullsFirst/Last()�Ƒg�ݍ��킹�邱�Ƃ��\
        }

        // ===============================================================================
        //                                                                Statement Config
        //                                                                ================
        /// <summary>
        /// Statement�̃R���t�B�O��ݒ�: cb.configure(statementConfig).
        /// </summary>
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void Configure_StatementConfig() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            cb.Configure(new StatementConfig().QueryTimeout(7));

            // ## Act & Assert ##
            _memberBhv.SelectList(cb);
        }

        // ===============================================================================
        //                                                                     Display SQL
        //                                                                     ===========
        /**
         * �ǂ�Ȃ�SubQuery��Union�̘A�ł����Ă�SQL���Y��Ƀt�H�[�}�b�g: toDisplaySql().
         * ���O��SQL���Y��Ƀt�H�[�}�b�g����Ă��邱�Ƃ��m�F���邾���B
         * <p>
         * �f�o�b�O�̂��Ղ��̓O��ƁAConditionBean����O����SQL�ւ̈ڍs���ɃX���[�Y�ɂł���悤��
         * ���O�̃t�H�[�}�b�g���d�����Ă���B���փT�u�N�G���Ȃǂ�ConditionBean�ŏ����Ă���o�͂��ꂽ
         * SQL���x�[�X�Ɏ������������O����SQL�ł��肪���ȃP�A���X�o�O�������Ȃ�B
         * </p>
         */
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void ToDisplaySql_Check_FormattedSQL() {
            // - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
            // �P�Ƀt�H�[�}�b�g����Ă��邱�Ƃ��݂��������Ȃ̂ŏ����͂��Ȃ薳���ꒃ
            // - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
            MemberStatusCB cb = new MemberStatusCB();
            cb.Query().SetDisplayOrder_Equal(3);
            cb.Query().ExistsMemberList(delegate(MemberCB memberCB) {
                memberCB.Query().SetBirthdate_LessEqual(DateTime.Now);
                memberCB.Query().ExistsPurchaseList(delegate(PurchaseCB purchaseCB) {
                    purchaseCB.Query().SetPurchaseCount_GreaterEqual(2);
                });
                memberCB.Query().ExistsMemberWithdrawalAsOne(delegate(MemberWithdrawalCB subCB) {
                    LikeSearchOption option = new LikeSearchOption().LikeContain().EscapeByPipeLine();
                    subCB.Query().QueryWithdrawalReason().SetWithdrawalReasonCode_LikeSearch("xxx", option);
                    subCB.Union(delegate(MemberWithdrawalCB unionCB) {
                        unionCB.Query().SetWithdrawalReasonInputText_IsNotNull();
                    });
                });
            });
            cb.Query().SetMemberStatusCode_Equal_Formalized();
            cb.Query().ExistsMemberLoginList(delegate(MemberLoginCB subCB) {
                subCB.Query().InScopeMember(delegate(MemberCB subSubCB) {
                    subSubCB.Query().SetBirthdate_GreaterEqual(DateTime.Now);
                });
            });
            cb.Query().AddOrderBy_DisplayOrder_Asc().AddOrderBy_MemberStatusCode_Desc();
            log(getLineSeparator() + cb.ToDisplaySql());
        }
    }
}

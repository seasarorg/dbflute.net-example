using System;
using System.Collections;
using System.Collections.Generic;
using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.CBean.COption;
using DfExample.DBFlute.AllCommon.Exp;
using DfExample.DBFlute.CBean;
using DfExample.DBFlute.ExBhv;
using DfExample.DBFlute.ExDao.PmBean;
using DfExample.DBFlute.ExEntity;
using DfExample.DBFlute.ExEntity.Customize;
using Seasar.Extension.Unit;
using Seasar.Quill.Unit;

namespace DfExample.DBFlute.HowTo.Jp {

    /// <summary>
    /// Behavior�̒�����Example�����B
    /// 
    /// �^�[�Q�b�g�͈ȉ��̒ʂ�F
    ///   o DBFlute���Ăǂ������@�\������̂���T���Ă����
    ///   o DBFlute�Ŏ������J�n������E�������Ă����
    ///   
    /// �R���e���c�͈ȉ��̒ʂ�F
    ///   o �y�[�W���O����: selectPage().
    ///   o one-to-many����(LoadReferrer): loadXxxList().
    ///   o �ꌏ�o�^�������͔r�����䂠��̈ꌏ�X�V: insertOrUpdate().
    ///   o �ꌏ�o�^�������͔r������Ȃ��ꌏ�X�V: insertOrUpdateNonstrict().
    ///   o Query���g�����X�V: queryUpdate().
    ///   o Query���g�����폜: queryDelete().
    ///   o �O����SQL�ŃJ����������̃��X�g����: outsideSql().selectList().
    ///   o �O����SQL�ŃG�X�P�[�v�t���B�������̃��X�g����: outsideSql().selectList().
    ///   o �O����SQL�̎����y�[�W���O����: OutsideSql().AutoPaging().SelectPage().
    ///   o �O����SQL�̎蓮�y�[�W���O����: outsideSql().manualPaging().selectPage().
    ///   o �O����SQL�ňꌏ����: outsideSql().entitnHandling().selectEntity().
    ///   o �O����SQL�Ń`�F�b�N�t���ꌏ����: outsideSql().entitnHandling().selectEntityWithDeletedCheck().
    ///   o �O����SQL�ŃJ����������̈ꌏ����: outsideSql().entitnHandling().selectEntity().
    /// </summary>
    [MbUnit.Framework.TestFixture]
    public class BehaviorMiddleTest : ContainerTestCase {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected MemberBhv _memberBhv;

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        /**
         * �y�[�W���O����: selectPage().
         * ������̂̏����̃��X�g���u�P�y�[�W�S���v�́u�R�y�[�W�ځv(�X���ڂ���P�Q����)�������B
         * <pre>
         * ConditionBean.paging(pageSize, pageNumber)�ɂăy�[�W���O�������w��F
         *   o pageSize : �y�[�W�T�C�Y(�P�y�[�W������̃��R�[�h��)
         *   o pageNumber : �y�[�W�ԍ�(��������Ώۂ̃y�[�W)
         * 
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
         *   o �y�[�W���O�i�r�Q�[�V�����v�f ���ڂ�����BehaviorPlatinumTest�ɂ�
         *   o �ȂǂȂ�
         * </pre>
         */
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void SelectPage() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            cb.Query().AddOrderBy_MemberName_Asc();
            cb.Paging(4, 3);// The page size is 4 records per 1 page, and The page number is 3.

            // ## Act ##
            PagingResultBean<Member> page3 = _memberBhv.SelectPage(cb);

            // ## Assert ##
            assertNotSame(0, page3.Count);
            foreach (Member member in page3) {
                log(member.ToString());
            }
            log("allRecordCount=" + page3.AllRecordCount);
            log("allPageCount=" + page3.AllPageCount);
            log("currentPageNumber=" + page3.CurrentPageNumber);
            log("currentStartRecordNumber=" + page3.CurrentStartRecordNumber);
            log("currentEndRecordNumber=" + page3.CurrentEndRecordNumber);
            log("isExistPrePage=" + page3.IsExistPrePage());
            log("isExistNextPage=" + page3.IsExistNextPage());

            // [Description]
            // A. paging()���\�b�h��DBFlute-0.7.3���T�|�[�g�B
            //    DBFlute-0.7.2�܂ł͈ȉ��̒ʂ�F
            //      fetchFirst(4);
            //      fetchPage(3);
            // 
            // B. paging()���\�b�h��������pageSize�́A�}�C�i�X�l��O���w�肳���Ɨ�O����
            //    --> ��{�I�ɃV�X�e���ŌŒ�Ŏw�肷��l�ł��邽��
            // 
            // C. paging()���\�b�h��������pageNumber�́A�}�C�i�X�l��O���w�肳���Ɓu�P�y�[�W�ځv�Ƃ��Ĉ�����B
            //    --> ��{�I�ɉ�ʃ��N�G�X�g�̒l�ŁA�\�����ʐ��l������\�������邽�߁B
            // 
            //    ���֘A���āA���y�[�W���𒴂���y�[�W�ԍ����w�肳�ꂽ�ꍇ�́u�Ō�̃y�[�W�v�Ƃ��Ĉ�����B
            //     (�A���A�����͌����ɂ�paging()�̋@�\�ł͂Ȃ�selectPage()�̋@�\�ł���)
        }

        // ===============================================================================
        //                                                                   Load Referrer
        //                                                                   =============
        /**
         * one-to-many����(LoadReferrer): loadXxxList().
         * ��������������X�g�ɑ΂��āA������̍w���J�E���g���Q���ȏ�̍w�����X�g���w���J�E���g�̍~���Ń��[�h�B
         * �q�e�[�u��(Referrer)���擾����u�ꔭ�v��SQL�𔭍s���ă}�b�s���O������(SubSelect�t�F�b�`)�B
         * DBFlute�ł͂���one-to-many�����[�h����@�\���uLoadReferrer�v�ƌĂԁB
         */
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void LoadReferrer() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();

            // At first, it selects the list of Member.
            ListResultBean<Member> memberList = _memberBhv.SelectList(cb);

            // ## Act ##
            // And it loads the list of Purchase with its conditions.
            _memberBhv.LoadPurchaseList(memberList, delegate(PurchaseCB subCB) {
                subCB.Query().SetPurchaseCount_GreaterEqual(2);
                subCB.Query().AddOrderBy_PurchaseCount_Desc();
            });

            // ## Assert ##
            assertNotSame(0, memberList.Count);
            foreach (Member member in memberList) {
                log("[MEMBER]: " + member.MemberName);
                IList<Purchase> purchaseList = member.PurchaseList;// *Point!
                foreach (Purchase purchase in purchaseList) {
                    log("    [PURCHASE]: " + purchase.ToString());
                }
            }

            // [SQL]
            // {1}: memberBhv.selectList(cb);
            // select ... 
            //   from MEMBER dflocal
            // 
            // {2}: memberBhv.loadPurchaseList(memberList, ...); 
            // select ... 
            //   from PURCHASE dflocal 
            //  where dflocal.MEMBER_ID in (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20)
            //    and dflocal.PURCHASE_COUNT >= 2 
            //  order by dflocal.MEMBER_ID asc, dflocal.PURCHASE_COUNT desc

            // [Description]
            // A. ��_�e�[�u��������PK�̏ꍇ�̓T�|�[�g����Ȃ��B
            //    --> ����Example�ł͉���e�[�u���B��������PK�Ȃ�loadPurchaseList()���\�b�h���̂���������Ȃ��B
            // B. SubSelect�t�F�b�`�Ȃ̂Łun+1���v�͔������Ȃ��B
            // C. �}������̎q�e�[�u�����擾���邱�Ƃ��\�B
            // D. �q�e�[�u���̐e�e�[�u�����擾���邱�Ƃ��\�B�ڂ�����BehaviorPlatinumTest�ɂ�
            // E. �q�e�[�u���̎q�e�[�u��(���e�[�u��)���擾���邱�Ƃ��\�B�ڂ�����BehaviorPlatinumTest�ɂ�
        }

        // ===================================================================================
        //                                                                       Entity Update
        //                                                                       =============
        // -----------------------------------------------------
        //                                        InsertOrUpdate
        //                                        --------------
        /// <summary>
        /// �ꌏ�o�^�������͔r�����䂠��̈ꌏ�X�V: insertOrUpdate().
        /// @since 0.8.0
        /// </summary>
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void InsertOrUpdate() {
            // ## Arrange ##
            Member member = new Member();
            member.MemberName = "testName";
            member.MemberAccount = "testAccount";
            member.SetMemberStatusCode_Formalized();

            // ## Act ##
            _memberBhv.InsertOrUpdate(member);
            member.MemberName = "testName2";
            _memberBhv.InsertOrUpdate(member);

            // ## Assert ##
            MemberCB cb = new MemberCB();
            cb.Query().SetMemberId_Equal(member.MemberId);
            Member actual = _memberBhv.SelectEntityWithDeletedCheck(cb);
            log(actual);
            assertEquals("testName2", actual.MemberName);

            // [Description]
            // A. �o�^������insert()�A�X�V������update()�ɈϏ�����B
            // B. PK�̒l�����݂��Ȃ��ꍇ�́A�����̔ԂƔ��f���ⓚ���p�œo�^�����ƂȂ�B
            // C. PK�l�����݂���ꍇ�́A��ɍX�V���������Ă��猋�ʂ𔻒f���ēo�^����������B
        }

        /// <summary>
        /// �ꌏ�o�^�������͔r������Ȃ��ꌏ�X�V: insertOrUpdateNonstrict().
        /// @since 0.8.0
        /// </summary>
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void InsertOrUpdateNonstrict() {
            // ## Arrange ##
            Member member = new Member();
            member.MemberName = "testName";
            member.MemberAccount = "testAccount";
            member.SetMemberStatusCode_Formalized();

            // ## Act ##
            _memberBhv.InsertOrUpdateNonstrict(member);
            member.MemberName = "testName2";
            member.VersionNo = null; // *Point
            _memberBhv.InsertOrUpdateNonstrict(member);

            // ## Assert ##
            MemberCB cb = new MemberCB();
            cb.Query().SetMemberId_Equal(member.MemberId);
            Member actual = _memberBhv.SelectEntityWithDeletedCheck(cb);
            log(actual);
            assertEquals("testName2", actual.MemberName);

            // [Description]
            // A. �o�^������insert()�A�X�V������updateNonstrict()�ɈϏ�����B
            // B. PK�̒l�����݂��Ȃ��ꍇ�́A�����̔ԂƔ��f���ⓚ���p�œo�^�����ƂȂ�B
            // C. PK�l�����݂���ꍇ�́A��ɍX�V���������Ă��猋�ʂ𔻒f���ēo�^����������B
        }

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        /// <summary>
        /// Query���g�����X�V: queryUpdate().
        /// ����X�e�[�^�X����������̉����S�ĉ�����ɂ���B
        /// ConditionBean�Őݒ肵�������ňꊇ�폜���\�ł���B(�r������͂Ȃ�)
        /// @since 0.7.9
        /// </summary>
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void QueryUpdate() {
            // ## Arrange ##
            deleteMemberReferrers();// for Test

            Member member = new Member();
            member.SetMemberStatusCode_Provisional();// ����X�e�[�^�X���u������v��
            member.FormalizedDatetime = null;// ��������������unull�v��

            MemberCB cb = new MemberCB();
            cb.Query().SetMemberStatusCode_Equal_Formalized();// �������

            // ## Act ##
            int updatedCount = _memberBhv.QueryUpdate(member, cb);

            // ## Assert ##
            assertNotSame(0, updatedCount);
            MemberCB actualCB = new MemberCB();
            actualCB.Query().SetMemberStatusCode_Equal_Provisional();
            actualCB.Query().SetFormalizedDatetime_IsNull();
            actualCB.Query().SetUpdateUser_Equal(_accessUser);// Common Column
            ListResultBean<Member> actualList = _memberBhv.SelectList(actualCB);
            assertEquals(actualList.Count, updatedCount);

            // [Description]
            // A. �����Ƃ��āA������̃J�����ɂ�������exists����g�����T�u�N�G���[�Ȃǂ����p�\�B
            // B. setupSelect_Xxx()��addOrderBy_Xxx()���Ăяo���Ă��Ӗ��͂Ȃ��B
            // C. �r������͂����ɖⓚ���p�ōX�V����B(�o�[�W����NO�͎����C���N�������g)
            // D. �X�V���ʂ�0���ł����ɗ�O�͔������Ȃ��B
            // E. ���ʃJ����(CommonColumn)�̎����ݒ�͗L���B
        }

        /// <summary>
        /// Query���g�����폜: queryDelete().
        /// ����X�e�[�^�X����������̉����S�č폜����B
        /// ConditionBean�Őݒ肵�������ňꊇ�폜���\�ł���B(�r������͂Ȃ�)
        /// @since 0.7.9
        /// </summary>
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void QueryDelete() {
            // ## Arrange ##
            deleteMemberReferrers();// for Test

            MemberCB cb = new MemberCB();
            cb.Query().SetMemberStatusCode_Equal_Formalized();// �������

            // ## Act ##
            int deletedCount = _memberBhv.QueryDelete(cb);

            // ## Assert ##
            assertNotSame(0, deletedCount);
            assertEquals(0, _memberBhv.SelectCount(cb));

            // [Description]
            // A. �����Ƃ��āA������̃J�����ɂ�������exists����g�����T�u�N�G���[�Ȃǂ����p�\�B
            // B. setupSelect_Xxx()��addOrderBy_Xxx()���Ăяo���Ă��Ӗ��͂Ȃ��B
            // C. �r������͂����ɖⓚ���p�ō폜����B
            // D. �폜���ʂ�0���ł����ɗ�O�͔������Ȃ��B
        }

        // ===============================================================================
        //                                                                      OutsideSql
        //                                                                      ==========
        // -------------------------------------------------
        //                                              List
        //                                              ----
        // /- - - - - - - - - - - - - - - - - - - - - - - - - - -
        // ��{�I��selectList()�Ɋւ��ẮABehaviorBasicTest�ɂ�
        // - - - - - - - - - -/
        /**
         * �O����SQL�ŃJ����������̃��X�g����: outsideSql().selectList().
         */
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void OutsideSql_SelectList_selectMemberName() {
            // ## Arrange ##
            // SQL�̃p�X
            String path = MemberBhv.PATH_selectMemberName;

            // ��������
            SimpleMemberPmb pmb = new SimpleMemberPmb();
            pmb.MemberName = "S";

            // ## Act ##
            // SQL���s�I
            IList<String> memberNameList = _memberBhv.OutsideSql().SelectList<String>(path, pmb);

            // ## Assert ##
            assertNotSame(0, memberNameList.Count);
            log("{MemberName}");
            foreach (String memberName in memberNameList) {
                log("    " + memberName);
                assertNotNull(memberName);
                assertTrue(memberName.StartsWith("S"));
            }
        }

        // -------------------------------------------------
        //                                            Option
        //                                            ------
        /**
         * �O����SQL�ŃG�X�P�[�v�t���B�������̃��X�g����: outsideSql().selectList().
         * <pre>
         * ParameterBean�̒�`�ɂāA�ȉ��̂悤�ɃI�v�V�����u:like�v��t�^����Ɨ��p�\�ɂȂ�B
         * -- !OptionMemberPmb!
         * -- !!Integer memberId!!
         * -- !!String memberName:like!!
         * </pre>
         * @since 0.8.0
         */
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void OutsideSql_SelectList_selectOptionMember_LikeSearchOption_Tx() {
            // ## Arrange ##
            // �e�X�g�̂��߂Ƀ��C���h�J�[�h�܂݂̃e�X�g������쐬
            Member testMember1 = new Member();
            testMember1.MemberId = 1;
            testMember1.MemberName = "�X�g�C�R100%�r�b�`_���̂P";
            _memberBhv.UpdateNonstrict(testMember1);
            Member testMember4 = new Member();
            testMember4.MemberId = 4;
            testMember4.MemberName = "�X�g�C�R100%�r�b�`_���̂S";
            _memberBhv.UpdateNonstrict(testMember4);

            // SQL�̃p�X
            String path = MemberBhv.PATH_selectOptionMember;

            // ��������
            OptionMemberPmb pmb = new OptionMemberPmb();
            pmb.SetMemberName("�X�g�C�R100%�r�b�`_����", new LikeSearchOption().LikePrefix().EscapeByPipeLine());

            // ## Act ##
            // SQL���s�I
            IList<OptionMember> memberList = _memberBhv.OutsideSql().SelectList<OptionMember>(path, pmb);

            // ## Assert ##
            assertNotSame(0, memberList.Count);
            log("{OptionMember}");
            foreach (OptionMember member in memberList) {
                long? memberId = member.MemberId;
                String memberName = member.MemberName;
                String memberStatusName = member.MemberStatusName;
                log("    " + memberId + ", " + memberName + ", " + memberStatusName + " - Formalized=");
                // TODO: @jflute -- Sql2Entity's IsMemberStatusCodeFormalized!?
                //         + member.IsMemberStatusCodeFormalized);// Sql2Entity�ł�Classification�@�\�����p�\
                assertNotNull(memberId);
                assertNotNull(memberName);
                assertNotNull(memberStatusName);
                assertTrue(memberName.StartsWith("�X�g�C�R100%�r�b�`_����"));
            }

            // [Description]
            // A. �O����SQL�ɂ����ẮALikeSearchOption��likeXxx()��escapeByXxx()�̂ݗ��p�\�B
            // B. CustomizeEntity(Sql2Entity�Ő�������Entity)�ł��敪�l�@�\�͗��p�\�B
        }

        // -------------------------------------------------
        //                                            Paging
        //                                            ------
        /// <summary>
        /// �O����SQL�̎����y�[�W���O����: OutsideSql().AutoPaging().SelectPage().
        /// ParameterBean.Paging(pageSize, pageNumber)�ɂăy�[�W���O�������w��F
        ///   o pageSize : �y�[�W�T�C�Y(�P�y�[�W������̃��R�[�h��)
        ///   o pageNumber : �y�[�W�ԍ�(��������Ώۂ̃y�[�W)
        /// 
        ///   ��SQL���ParameterBean�̒�`�ɂāA�ȉ��̂悤��SimplePagingBean���p�����邱�ƁB
        ///      -- !XxxPmb extends SPB!
        /// 
        /// SelectPage()�����Ńy�[�W���O�̊�{���S�Ď��s�����F
        ///   1. �y�[�W���O�Ȃ������擾
        ///   2. �y�[�W���O���f�[�^����
        ///   3. �y�[�W���O���ʌv�Z����
        ///   
        /// PagingResultBean����l�X�ȗv�f���擾�\�F
        ///   o �y�[�W���O�Ȃ�������
        ///   o ���݃y�[�W�ԍ�
        ///   o ���y�[�W��
        ///   o �O�y�[�W�̗L������
        ///   o ���y�[�W�̗L������
        ///   o �y�[�W���O�i�r�Q�[�V�����v�f�y�[�W���X�g
        ///   o �ȂǂȂ�
        /// </summary>
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void OutsideSql_AutoPaging_SelectPage() {
            // ## Arrange ##
            // SQL�̃p�X
            String path = MemberBhv.PATH_selectUnpaidSummaryMember;

            // ��������
            UnpaidSummaryMemberPmb pmb = new UnpaidSummaryMemberPmb();
            pmb.SetMemberStatusCode_Formalized();// �������

            // ## Act ##
            // SQL���s�I
            int pageSize = 3;
            pmb.Paging(pageSize, 1);// 1st page
            PagingResultBean<UnpaidSummaryMember> page1 = _memberBhv.OutsideSql().AutoPaging().SelectPage<UnpaidSummaryMember>(path, pmb);

            pmb.Paging(pageSize, 2);// 2st page
            PagingResultBean<UnpaidSummaryMember> page2 = _memberBhv.OutsideSql().AutoPaging().SelectPage<UnpaidSummaryMember>(path, pmb);

            pmb.Paging(pageSize, 3);// 3st page
            PagingResultBean<UnpaidSummaryMember> page3 = _memberBhv.OutsideSql().AutoPaging().SelectPage<UnpaidSummaryMember>(path, pmb);

            pmb.Paging(pageSize, page1.AllPageCount);// latest page
            PagingResultBean<UnpaidSummaryMember> lastPage = _memberBhv.OutsideSql().AutoPaging().SelectPage<UnpaidSummaryMember>(path, pmb);

            // ## Assert ##
            //showPage(page1, page2, page3, lastPage);
            assertEquals(3, page1.Count);
            assertEquals(3, page2.Count);
            assertEquals(3, page3.Count);
            assertNotSame(page1[0].MemberId, page2[0].MemberId);
            assertNotSame(page2[0].MemberId, page3[0].MemberId);
            assertEquals(1, page1.CurrentPageNumber);
            assertEquals(2, page2.CurrentPageNumber);
            assertEquals(3, page3.CurrentPageNumber);
            assertEquals(page1.AllRecordCount, page2.AllRecordCount);
            assertEquals(page2.AllRecordCount, page3.AllRecordCount);
            assertEquals(page1.AllPageCount, page2.AllPageCount);
            assertEquals(page2.AllPageCount, page3.AllPageCount);
            assertFalse(page1.IsExistPrePage());
            assertTrue(page1.IsExistNextPage());
            assertTrue(lastPage.IsExistPrePage());
            assertFalse(lastPage.IsExistNextPage());

            // [Description]
            // A. Paging()���\�b�h��DBFlute-0.7.3���T�|�[�g�B
            //    DBFlute-0.7.2�܂ł͈ȉ��̒ʂ�F
            //      pmb.FetchFirst(3);
            //      pmb.FetchPage(1);
            // 
            // B. �蓮�y�[�W���O���������ꍇ�͈ȉ��̒ʂ�B
            //   1. SQL��Ńy�[�W���O�i��������L�q
            //      /*IF pmb.IsPaging*/
            //      limit /*$pmb.PageStartIndex*/80, /*$pmb.FetchSize*/20
            //      /*END*/
            // 
            //   2. AutoPaging()��ManualPaging()�ɕύX
            //      memberBhv.OutsideSql().ManualPaging().SelectPage(...);
            // 
            // C. ParameterBean�ł��敪�l�@�\�͗��p�\ {�㋉��}
            //    : member.isMemberStatusCodeFormalized()
            // 
            //    ParameterBean�ɂ�
            //    -- !!String memberStatusCode:cls(MemberStatus)!!
            //    �Ǝw��
        }

        /**
         * �O����SQL�̎蓮�y�[�W���O����: outsideSql().manualPaging().selectPage().
         * �ő�w�����i�̉���ꗗ�������B
         * <pre>
         * ParameterBean.paging(pageSize, pageNumber)�ɂăy�[�W���O�������w��F
         *   o pageSize : �y�[�W�T�C�Y(�P�y�[�W������̃��R�[�h��)
         *   o pageNumber : �y�[�W�ԍ�(��������Ώۂ̃y�[�W)
         *   
         *   ��SQL���ParameterBean�̒�`�ɂāA�ȉ��̂悤��SimplePagingBean���p�����邱�ƁB
         *      -- !XxxPmb extends SPB!
         * 
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
        public void OutsideSql_ManualPaging_SelectPage() {
            // ## Arrange ##
            // SQL�̃p�X
            String path = MemberBhv.PATH_selectPurchaseMaxPriceMember;

            // ��������(�i�荞�ݏ����͓��ɂȂ�)
            PurchaseMaxPriceMemberPmb pmb = new PurchaseMaxPriceMemberPmb();

            // ## Act ##
            // SQL���s�I
            int pageSize = 3;
            pmb.Paging(pageSize, 1); // 1st page
            PagingResultBean<PurchaseMaxPriceMember> page1 =
                _memberBhv.OutsideSql().ManualPaging().SelectPage<PurchaseMaxPriceMember>(path, pmb);

            pmb.Paging(pageSize, 2); // 2st page
            PagingResultBean<PurchaseMaxPriceMember> page2 =
                _memberBhv.OutsideSql().ManualPaging().SelectPage<PurchaseMaxPriceMember>(path, pmb);

            pmb.Paging(pageSize, 3); // 3st page
            PagingResultBean<PurchaseMaxPriceMember> page3 =
                _memberBhv.OutsideSql().ManualPaging().SelectPage<PurchaseMaxPriceMember>(path, pmb);

            pmb.Paging(pageSize, page1.AllPageCount); // latest page
            PagingResultBean<PurchaseMaxPriceMember> lastPage =
                _memberBhv.OutsideSql().ManualPaging().SelectPage<PurchaseMaxPriceMember>(path, pmb);

            // ## Assert ##
            //showPage(page1, page2, page3, lastPage);
            assertEquals(3, page1.Count);
            assertEquals(3, page2.Count);
            assertEquals(3, page3.Count);
            assertNotSame(page1[0].MemberId, page2[0].MemberId);
            assertNotSame(page2[0].MemberId, page3[0].MemberId);
            assertEquals(1, page1.CurrentPageNumber);
            assertEquals(2, page2.CurrentPageNumber);
            assertEquals(3, page3.CurrentPageNumber);
            assertEquals(page1.AllRecordCount, page2.AllRecordCount);
            assertEquals(page2.AllRecordCount, page3.AllRecordCount);
            assertEquals(page1.AllPageCount, page2.AllPageCount);
            assertEquals(page2.AllPageCount, page3.AllPageCount);
            assertFalse(page1.IsExistPrePage());
            assertTrue(page1.IsExistNextPage());
            assertTrue(lastPage.IsExistPrePage());
            assertFalse(lastPage.IsExistNextPage());

            // [Description]
            // A. paging()���\�b�h��DBFlute-0.7.3���T�|�[�g�B
            //    DBFlute-0.7.2�܂ł͈ȉ��̒ʂ�F
            //      pmb.fetchFirst(3);
            //      pmb.fetchPage(1);
            // 
            // B. �����y�[�W���O���������ꍇ�͈ȉ��̒ʂ�B
            //   1. SQL��Ńy�[�W���O�i��������폜
            //   2. manualPaging()��autoPaging()�ɕύX
            // 
            // X. ConditionBean�ƊO����SQL�̋��ڃ|�C���g�I {�㋉��}
            //    o �y�[�W���O�i���SQL�ōs���̂�ConditionBean�ŉ\
            //      --> ConditionBean�̃y�[�W���O��SQL�ł̃y�[�W���O�i�������
            // 
            //    o Select��̑��փT�u�N�G���Ŏq�e�[�u����max()��ConditionBean�ŉ\
            //      --> SpecifyDerivedReferrer�𗘗p(�ڂ�����ConditionBeanPlatinumTest�ɂ�)
            // 
            //    o Select��̑��փT�u�N�G���œ��o�����l�ŕ��ёւ���̂�ConditionBean�ŉ\
            //      --> SpecifyDerivedReferrer�ŗ��p(�ڂ�����ConditionBeanPlatinumTest�ɂ�)
            // 
            //        �����͂��̗���SQL��ConditionBean�Ŏ����\
            //        /- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
            //        MemberCB cb = new MemberCB();
            //        cb.setupSelect_MemberStatus();
            //        cb.specify().derivedPurchaseList().max(new SubQuery<PurchaseCB>() {
            //            public void query(PurchaseCB subCB) {
            //                subCB.specify().columnPurchasePrice();
            //                subCB.query().setPaymentCompleteFlg_Equal_False();
            //            }
            //        }, "PURCHASE_MAX_PRICE");
            //        cb.query().setMemberId_Equal(3);
            //        cb.query().setMemberName_PrefixSearch("S");
            //        cb.query().addSpecifiedDerivedOrderBy_Desc("PURCHASE_MAX_PRICE");
            //        cb.query().addOrderBy_MemberId_Asc();
            //        cb.paging(3, 1);
            //        PagingResultBean<Member> page = memberBhv.selectPage(cb);
            //        - - - - - - - - - -/
        }

        // -------------------------------------------------
        //                                            Entity
        //                                            ------
        /**
         * �O����SQL�ňꌏ����: outsideSql().entitnHandling().selectEntity().
         */
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void OutsideSql_SelectEntity_selectUnpaidSummaryMember() {
            // ## Arrange ##
            // SQL�̃p�X
            String path = MemberBhv.PATH_selectUnpaidSummaryMember;

            // ��������
            UnpaidSummaryMemberPmb pmb = new UnpaidSummaryMemberPmb();
            pmb.MemberId = 3;

            // ## Act ##
            UnpaidSummaryMember member = _memberBhv.OutsideSql().EntityHandling().SelectEntity<UnpaidSummaryMember>(path, pmb);

            // ## Assert ##
            log("unpaidSummaryMember=" + member);
            assertNotNull(member);
            assertEquals(3L, member.MemberId);

            // [Description]
            // A. ���݂��Ȃ�ID���w�肵���ꍇ��null���߂�B
            // B. ���ʂ��������̏ꍇ�͗�O�����B{EntityDuplicatedException}
        }

        /**
         * �O����SQL�Ń`�F�b�N�t���ꌏ����: outsideSql().entitnHandling().selectEntityWithDeletedCheck().
         */
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void test_outsideSql_selectEntityWithDeletedCheck_selectUnpaidSummaryMember_Tx() {
            // ## Arrange ##
            // SQL�̃p�X
            String path = MemberBhv.PATH_selectUnpaidSummaryMember;

            // ��������
            UnpaidSummaryMemberPmb pmb = new UnpaidSummaryMemberPmb();
            pmb.MemberId = 99999;

            // ## Act & Assert ##
            try {
                _memberBhv.OutsideSql().EntityHandling().SelectEntityWithDeletedCheck<UnpaidSummaryMember>(path, pmb);
                fail();
            } catch (EntityAlreadyDeletedException e) {
                // OK
                log(e.Message);
            }

            // �yDescription�z
            // A. ���݂��Ȃ�ID���w�肵���ꍇ�͗�O�����B{EntityAlreadyDeletedException}
            // B. ���ʂ��������̏ꍇ�͗�O�����B{EntityDuplicatedException}
        }


        /**
         * �O����SQL�ŃJ����������̈ꌏ����: outsideSql().entitnHandling().selectEntity().
         */
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void test_outsideSql_SelectEntityWithDeletedCheck_selectLatestFormalizedDatetime_Tx() {
            // ## Arrange ##
            // SQL�̃p�X
            String path = MemberBhv.PATH_selectLatestFormalizedDatetime;

            // ��������
            Object pmb = null;

            // ## Act ##
            DateTime? maxValue = _memberBhv.OutsideSql().EntityHandling().SelectEntity<DateTime?>(path, pmb);

            // ## Assert ##
            log("maxValue=" + maxValue);
            assertNotNull(maxValue);
        }
    }
}

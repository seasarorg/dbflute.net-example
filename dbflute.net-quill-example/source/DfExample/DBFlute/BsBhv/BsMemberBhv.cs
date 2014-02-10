
using System;
using System.Collections.Generic;

using Seasar.Quill;
using Seasar.Quill.Attrs;

using DfExample.DBFlute.AllCommon;
using DfExample.DBFlute.AllCommon.Bhv;
using DfExample.DBFlute.AllCommon.Bhv.Load;
using DfExample.DBFlute.AllCommon.Bhv.Setup;
using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.Dbm;
using DfExample.DBFlute.AllCommon.Exp;
using DfExample.DBFlute.BsEntity.Dbm;
using DfExample.DBFlute.ExDao;
using DfExample.DBFlute.ExEntity;
using DfExample.DBFlute.CBean;


namespace DfExample.DBFlute.ExBhv {

    [Implementation]
    public partial class MemberBhv : DfExample.DBFlute.AllCommon.Bhv.AbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        public static readonly String PATH_selectLatestFormalizedDatetime = "selectLatestFormalizedDatetime";
        public static readonly String PATH_selectMemberName = "selectMemberName";
        public static readonly String PATH_selectOptionMember = "selectOptionMember";
        public static readonly String PATH_selectPurchaseMaxPriceMember = "selectPurchaseMaxPriceMember";
        public static readonly String PATH_selectPurchaseSummaryMember = "selectPurchaseSummaryMember";
        public static readonly String PATH_selectSimpleMember = "selectSimpleMember";
        /// <summary>Example for Auto Paging </summary>
        public static readonly String PATH_selectUnpaidSummaryMember = "selectUnpaidSummaryMember";
        public static readonly String PATH_selectUnpaidSummaryMemberUsingParameterMap = "selectUnpaidSummaryMemberUsingParameterMap";
        public static readonly String PATH_updateForcedWithdrawal = "updateForcedWithdrawal";
        public static readonly String PATH_SubDirectory_selectSubDirectoryCheck = "SubDirectory:selectSubDirectoryCheck";
        public static readonly String PATH_Various_NotEmbedded_selectNotEmbedded = "Various:NotEmbedded:selectNotEmbedded";
        public static readonly String PATH_Various_PmbCheck_selectResolvedPackageName = "Various:PmbCheck:selectResolvedPackageName";
        public static readonly String PATH_Various_WrongExample_selectBindVariableNotFoundProperty = "Various:WrongExample:selectBindVariableNotFoundProperty";
        public static readonly String PATH_Various_WrongExample_selectIfCommentNotBooleanResult = "Various:WrongExample:selectIfCommentNotBooleanResult";
        public static readonly String PATH_Various_WrongExample_selectIfCommentWrongExpression = "Various:WrongExample:selectIfCommentWrongExpression";
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected MemberDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public MemberBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "member"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override DBMeta DBMeta { get { return MemberDbm.GetInstance(); } }
        public MemberDbm MyDBMeta { get { return MemberDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override Entity NewEntity() { return NewMyEntity(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual Member NewMyEntity() { return new Member(); }
        public virtual MemberCB NewMyConditionBean() { return new MemberCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(MemberCB cb) {
            AssertConditionBeanNotNull(cb);
            return this.DelegateSelectCount(cb);
        }

        protected override int DoReadCount(ConditionBean cb) {
            return SelectCount(Downcast(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                   Entity Select
        //                                                                   =============
        #region Entity Select
        public virtual Member SelectEntity(MemberCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<Member> ls = null;
            try {
                ls = this.DelegateSelectList(cb);
            } catch (DangerousResultSizeException e) {
                ThrowEntityDuplicatedException("{over safetyMaxResultSize '1'}", cb, e);
                return null; // unreachable
            } finally {
                xrestoreSafetyResult(cb, preSafetyMaxResultSize);
            }
            if (ls.Count == 0) { return null; }
            AssertEntitySelectedAsOne(ls, cb);
            return (Member)ls[0];
        }

        protected override Entity DoReadEntity(ConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual Member SelectEntityWithDeletedCheck(MemberCB cb) {
            AssertConditionBeanNotNull(cb);
            Member entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override Entity DoReadEntityWithDeletedCheck(ConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual Member SelectByPKValue(int? memberId) {
            return SelectEntity(BuildPKCB(memberId));
        }

        public virtual Member SelectByPKValueWithDeletedCheck(int? memberId) {
            return SelectEntityWithDeletedCheck(BuildPKCB(memberId));
        }

        private MemberCB BuildPKCB(int? memberId) {
            AssertObjectNotNull("memberId", memberId);
            MemberCB cb = NewMyConditionBean();
            cb.Query().SetMemberId_Equal(memberId);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual ListResultBean<Member> SelectList(MemberCB cb) {
            AssertConditionBeanNotNull(cb);
            return new ResultBeanBuilder<Member>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual PagingResultBean<Member> SelectPage(MemberCB cb) {
            AssertConditionBeanNotNull(cb);
            PagingInvoker<Member> invoker = new PagingInvoker<Member>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : PagingHandler<Member> {
            protected MemberBhv _bhv; protected MemberCB _cb;
            public InternalSelectPagingHandler(MemberBhv bhv, MemberCB cb) { _bhv = bhv; _cb = cb; }
            public PagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<Member> Paging() { return _bhv.SelectList(_cb); }
        }
        #endregion

        // ===============================================================================
        //                                                                   Load Referrer
        //                                                                   =============
        #region Load Referrer
        public virtual void LoadMemberAddressList(Member member, ConditionBeanSetupper<MemberAddressCB> conditionBeanSetupper) {
            AssertObjectNotNull("member", member); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadMemberAddressList(xnewLRLs<Member>(member), conditionBeanSetupper);
        }
        public virtual void LoadMemberAddressList(IList<Member> memberList, ConditionBeanSetupper<MemberAddressCB> conditionBeanSetupper) {
            AssertObjectNotNull("memberList", memberList); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadMemberAddressList(memberList, new LoadReferrerOption<MemberAddressCB, MemberAddress>().xinit(conditionBeanSetupper));
        }
        public virtual void LoadMemberAddressList(Member member, LoadReferrerOption<MemberAddressCB, MemberAddress> loadReferrerOption) {
            AssertObjectNotNull("member", member); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            LoadMemberAddressList(xnewLRLs<Member>(member), loadReferrerOption);
        }
        public virtual void LoadMemberAddressList(IList<Member> memberList, LoadReferrerOption<MemberAddressCB, MemberAddress> loadReferrerOption) {
            AssertObjectNotNull("memberList", memberList); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            if (memberList.Count == 0) { return; }
            MemberAddressBhv referrerBhv = xgetBSFLR().Select<MemberAddressBhv>();
            HelpLoadReferrerInternally<Member, int?, MemberAddressCB, MemberAddress>
                    (memberList, loadReferrerOption, new MyInternalLoadMemberAddressListCallback(referrerBhv));
        }
        protected class MyInternalLoadMemberAddressListCallback : InternalLoadReferrerCallback<Member, int?, MemberAddressCB, MemberAddress> {
            protected MemberAddressBhv referrerBhv;
            public MyInternalLoadMemberAddressListCallback(MemberAddressBhv referrerBhv) { this.referrerBhv = referrerBhv; }
            public int? getPKVal(Member e) { return e.MemberId; }
            public void setRfLs(Member e, IList<MemberAddress> ls) { e.MemberAddressList = ls; }
            public MemberAddressCB newMyCB() { return referrerBhv.NewMyConditionBean(); }
            public void qyFKIn(MemberAddressCB cb, IList<int?> ls) { cb.Query().SetMemberId_InScope(ls); }
            public void qyOdFKAsc(MemberAddressCB cb) { cb.Query().AddOrderBy_MemberId_Asc(); }
            public void spFKCol(MemberAddressCB cb) { cb.Specify().ColumnMemberId(); }
            public IList<MemberAddress> selRfLs(MemberAddressCB cb) { return referrerBhv.SelectList(cb); }
            public int? getFKVal(MemberAddress e) { return e.MemberId; }
            public void setlcEt(MemberAddress re, Member be) { re.Member = be; }
        }
        public virtual void LoadMemberLoginList(Member member, ConditionBeanSetupper<MemberLoginCB> conditionBeanSetupper) {
            AssertObjectNotNull("member", member); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadMemberLoginList(xnewLRLs<Member>(member), conditionBeanSetupper);
        }
        public virtual void LoadMemberLoginList(IList<Member> memberList, ConditionBeanSetupper<MemberLoginCB> conditionBeanSetupper) {
            AssertObjectNotNull("memberList", memberList); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadMemberLoginList(memberList, new LoadReferrerOption<MemberLoginCB, MemberLogin>().xinit(conditionBeanSetupper));
        }
        public virtual void LoadMemberLoginList(Member member, LoadReferrerOption<MemberLoginCB, MemberLogin> loadReferrerOption) {
            AssertObjectNotNull("member", member); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            LoadMemberLoginList(xnewLRLs<Member>(member), loadReferrerOption);
        }
        public virtual void LoadMemberLoginList(IList<Member> memberList, LoadReferrerOption<MemberLoginCB, MemberLogin> loadReferrerOption) {
            AssertObjectNotNull("memberList", memberList); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            if (memberList.Count == 0) { return; }
            MemberLoginBhv referrerBhv = xgetBSFLR().Select<MemberLoginBhv>();
            HelpLoadReferrerInternally<Member, int?, MemberLoginCB, MemberLogin>
                    (memberList, loadReferrerOption, new MyInternalLoadMemberLoginListCallback(referrerBhv));
        }
        protected class MyInternalLoadMemberLoginListCallback : InternalLoadReferrerCallback<Member, int?, MemberLoginCB, MemberLogin> {
            protected MemberLoginBhv referrerBhv;
            public MyInternalLoadMemberLoginListCallback(MemberLoginBhv referrerBhv) { this.referrerBhv = referrerBhv; }
            public int? getPKVal(Member e) { return e.MemberId; }
            public void setRfLs(Member e, IList<MemberLogin> ls) { e.MemberLoginList = ls; }
            public MemberLoginCB newMyCB() { return referrerBhv.NewMyConditionBean(); }
            public void qyFKIn(MemberLoginCB cb, IList<int?> ls) { cb.Query().SetMemberId_InScope(ls); }
            public void qyOdFKAsc(MemberLoginCB cb) { cb.Query().AddOrderBy_MemberId_Asc(); }
            public void spFKCol(MemberLoginCB cb) { cb.Specify().ColumnMemberId(); }
            public IList<MemberLogin> selRfLs(MemberLoginCB cb) { return referrerBhv.SelectList(cb); }
            public int? getFKVal(MemberLogin e) { return e.MemberId; }
            public void setlcEt(MemberLogin re, Member be) { re.Member = be; }
        }
        public virtual void LoadPurchaseList(Member member, ConditionBeanSetupper<PurchaseCB> conditionBeanSetupper) {
            AssertObjectNotNull("member", member); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadPurchaseList(xnewLRLs<Member>(member), conditionBeanSetupper);
        }
        public virtual void LoadPurchaseList(IList<Member> memberList, ConditionBeanSetupper<PurchaseCB> conditionBeanSetupper) {
            AssertObjectNotNull("memberList", memberList); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadPurchaseList(memberList, new LoadReferrerOption<PurchaseCB, Purchase>().xinit(conditionBeanSetupper));
        }
        public virtual void LoadPurchaseList(Member member, LoadReferrerOption<PurchaseCB, Purchase> loadReferrerOption) {
            AssertObjectNotNull("member", member); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            LoadPurchaseList(xnewLRLs<Member>(member), loadReferrerOption);
        }
        public virtual void LoadPurchaseList(IList<Member> memberList, LoadReferrerOption<PurchaseCB, Purchase> loadReferrerOption) {
            AssertObjectNotNull("memberList", memberList); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            if (memberList.Count == 0) { return; }
            PurchaseBhv referrerBhv = xgetBSFLR().Select<PurchaseBhv>();
            HelpLoadReferrerInternally<Member, int?, PurchaseCB, Purchase>
                    (memberList, loadReferrerOption, new MyInternalLoadPurchaseListCallback(referrerBhv));
        }
        protected class MyInternalLoadPurchaseListCallback : InternalLoadReferrerCallback<Member, int?, PurchaseCB, Purchase> {
            protected PurchaseBhv referrerBhv;
            public MyInternalLoadPurchaseListCallback(PurchaseBhv referrerBhv) { this.referrerBhv = referrerBhv; }
            public int? getPKVal(Member e) { return e.MemberId; }
            public void setRfLs(Member e, IList<Purchase> ls) { e.PurchaseList = ls; }
            public PurchaseCB newMyCB() { return referrerBhv.NewMyConditionBean(); }
            public void qyFKIn(PurchaseCB cb, IList<int?> ls) { cb.Query().SetMemberId_InScope(ls); }
            public void qyOdFKAsc(PurchaseCB cb) { cb.Query().AddOrderBy_MemberId_Asc(); }
            public void spFKCol(PurchaseCB cb) { cb.Specify().ColumnMemberId(); }
            public IList<Purchase> selRfLs(PurchaseCB cb) { return referrerBhv.SelectList(cb); }
            public int? getFKVal(Purchase e) { return e.MemberId; }
            public void setlcEt(Purchase re, Member be) { re.Member = be; }
        }
        #endregion

        // ===============================================================================
        //                                                                Pull out Foreign
        //                                                                ================
        #region Pullout Foreign
        public IList<MemberStatus> PulloutMemberStatus(IList<Member> memberList) {
            return HelpPulloutInternally<Member, MemberStatus>(memberList, new MyInternalPulloutMemberStatusCallback());
        }
        protected class MyInternalPulloutMemberStatusCallback : InternalPulloutCallback<Member, MemberStatus> {
            public MemberStatus getFr(Member entity) { return entity.MemberStatus; }
        }
        public IList<MemberLogin> PulloutMemberLoginAsLatest(IList<Member> memberList) {
            return HelpPulloutInternally<Member, MemberLogin>(memberList, new MyInternalPulloutMemberLoginAsLatestCallback());
        }
        protected class MyInternalPulloutMemberLoginAsLatestCallback : InternalPulloutCallback<Member, MemberLogin> {
            public MemberLogin getFr(Member entity) { return entity.MemberLoginAsLatest; }
        }
        public IList<MemberAddress> PulloutMemberAddressAsValid(IList<Member> memberList) {
            return HelpPulloutInternally<Member, MemberAddress>(memberList, new MyInternalPulloutMemberAddressAsValidCallback());
        }
        protected class MyInternalPulloutMemberAddressAsValidCallback : InternalPulloutCallback<Member, MemberAddress> {
            public MemberAddress getFr(Member entity) { return entity.MemberAddressAsValid; }
        }
        public IList<MemberLogin> PulloutMemberLoginAsLocalForeignOverTest(IList<Member> memberList) {
            return HelpPulloutInternally<Member, MemberLogin>(memberList, new MyInternalPulloutMemberLoginAsLocalForeignOverTestCallback());
        }
        protected class MyInternalPulloutMemberLoginAsLocalForeignOverTestCallback : InternalPulloutCallback<Member, MemberLogin> {
            public MemberLogin getFr(Member entity) { return entity.MemberLoginAsLocalForeignOverTest; }
        }
        public IList<MemberLogin> PulloutMemberLoginAsForeignForeignOverTest(IList<Member> memberList) {
            return HelpPulloutInternally<Member, MemberLogin>(memberList, new MyInternalPulloutMemberLoginAsForeignForeignOverTestCallback());
        }
        protected class MyInternalPulloutMemberLoginAsForeignForeignOverTestCallback : InternalPulloutCallback<Member, MemberLogin> {
            public MemberLogin getFr(Member entity) { return entity.MemberLoginAsForeignForeignOverTest; }
        }
        public IList<MemberLogin> PulloutMemberLoginAsForeignForeignParameterOverTest(IList<Member> memberList) {
            return HelpPulloutInternally<Member, MemberLogin>(memberList, new MyInternalPulloutMemberLoginAsForeignForeignParameterOverTestCallback());
        }
        protected class MyInternalPulloutMemberLoginAsForeignForeignParameterOverTestCallback : InternalPulloutCallback<Member, MemberLogin> {
            public MemberLogin getFr(Member entity) { return entity.MemberLoginAsForeignForeignParameterOverTest; }
        }
        public IList<MemberLogin> PulloutMemberLoginAsForeignForeignVariousOverTest(IList<Member> memberList) {
            return HelpPulloutInternally<Member, MemberLogin>(memberList, new MyInternalPulloutMemberLoginAsForeignForeignVariousOverTestCallback());
        }
        protected class MyInternalPulloutMemberLoginAsForeignForeignVariousOverTestCallback : InternalPulloutCallback<Member, MemberLogin> {
            public MemberLogin getFr(Member entity) { return entity.MemberLoginAsForeignForeignVariousOverTest; }
        }
        public IList<MemberLogin> PulloutMemberLoginAsReferrerOverTest(IList<Member> memberList) {
            return HelpPulloutInternally<Member, MemberLogin>(memberList, new MyInternalPulloutMemberLoginAsReferrerOverTestCallback());
        }
        protected class MyInternalPulloutMemberLoginAsReferrerOverTestCallback : InternalPulloutCallback<Member, MemberLogin> {
            public MemberLogin getFr(Member entity) { return entity.MemberLoginAsReferrerOverTest; }
        }
        public IList<MemberLogin> PulloutMemberLoginAsReferrerForeignOverTest(IList<Member> memberList) {
            return HelpPulloutInternally<Member, MemberLogin>(memberList, new MyInternalPulloutMemberLoginAsReferrerForeignOverTestCallback());
        }
        protected class MyInternalPulloutMemberLoginAsReferrerForeignOverTestCallback : InternalPulloutCallback<Member, MemberLogin> {
            public MemberLogin getFr(Member entity) { return entity.MemberLoginAsReferrerForeignOverTest; }
        }
        public IList<MemberSecurity> PulloutMemberSecurityAsOne(IList<Member> memberList) {
            return HelpPulloutInternally<Member, MemberSecurity>(memberList, new MyInternalPulloutMemberSecurityListCallback());
        }
        protected class MyInternalPulloutMemberSecurityListCallback : InternalPulloutCallback<Member, MemberSecurity> {
            public MemberSecurity getFr(Member entity) { return entity.MemberSecurityAsOne; }
        }
        public IList<MemberWithdrawal> PulloutMemberWithdrawalAsOne(IList<Member> memberList) {
            return HelpPulloutInternally<Member, MemberWithdrawal>(memberList, new MyInternalPulloutMemberWithdrawalListCallback());
        }
        protected class MyInternalPulloutMemberWithdrawalListCallback : InternalPulloutCallback<Member, MemberWithdrawal> {
            public MemberWithdrawal getFr(Member entity) { return entity.MemberWithdrawalAsOne; }
        }
        #endregion


        // ===============================================================================
        //                                                                   Entity Update
        //                                                                   =============
        #region Basic Entity Update
        public virtual void Insert(Member entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(Entity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(Member entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(Entity entity) {
            Update(Downcast(entity));
        }

        public virtual void UpdateNonstrict(Member entity) {
            AssertEntityNotNull(entity);
            int updatedCount = this.DelegateUpdateNonstrict(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        public void InsertOrUpdate(Member entity) {
            HelpInsertOrUpdateInternally<Member, MemberCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<Member, MemberCB> {
            protected MemberBhv _bhv;
            public MyInternalInsertOrUpdateCallback(MemberBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(Member entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(Member entity) { _bhv.Update(entity); }
            public MemberCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(MemberCB cb, Member entity) {
                cb.Query().SetMemberId_Equal(entity.MemberId);
            }
            public int CallbackSelectCount(MemberCB cb) { return _bhv.SelectCount(cb); }
        }

        public void InsertOrUpdateNonstrict(Member entity) {
            HelpInsertOrUpdateInternally<Member>(entity, new MyInternalInsertOrUpdateNonstrictCallback(this));
        }
        protected class MyInternalInsertOrUpdateNonstrictCallback : InternalInsertOrUpdateNonstrictCallback<Member> {
            protected MemberBhv _bhv;
            public MyInternalInsertOrUpdateNonstrictCallback(MemberBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(Member entity) { _bhv.Insert(entity); }
            public void CallbackUpdateNonstrict(Member entity) { _bhv.UpdateNonstrict(entity); }
        }

        public virtual void Delete(Member entity) {
            HelpDeleteInternally<Member>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(Entity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<Member> {
            protected MemberBhv _bhv;
            public MyInternalDeleteCallback(MemberBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(Member entity) { return _bhv.DelegateDelete(entity); }
        }

        public virtual void DeleteNonstrict(Member entity) {
            HelpDeleteNonstrictInternally<Member>(entity, new MyInternalDeleteNonstrictCallback(this));
        }
        protected class MyInternalDeleteNonstrictCallback : InternalDeleteNonstrictCallback<Member> {
            protected MemberBhv _bhv;
            public MyInternalDeleteNonstrictCallback(MemberBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDeleteNonstrict(Member entity) { return _bhv.DelegateDeleteNonstrict(entity); }
        }

        public virtual void DeleteNonstrictIgnoreDeleted(Member entity) {
            HelpDeleteNonstrictIgnoreDeletedInternally<Member>(entity, new MyInternalDeleteNonstrictIgnoreDeletedCallback(this));
        }
        protected class MyInternalDeleteNonstrictIgnoreDeletedCallback : InternalDeleteNonstrictIgnoreDeletedCallback<Member> {
            protected MemberBhv _bhv;
            public MyInternalDeleteNonstrictIgnoreDeletedCallback(MemberBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDeleteNonstrict(Member entity) { return _bhv.DelegateDeleteNonstrict(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(Member member, MemberCB cb) {
            AssertObjectNotNull("member", member); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(member);
            FilterEntityOfUpdate(member); AssertEntityOfUpdate(member);
            return this.Dao.UpdateByQuery(cb, member);
        }

        public int QueryDelete(MemberCB cb) {
            AssertConditionBeanNotNull(cb);
            return this.Dao.DeleteByQuery(cb);
        }

        // ===============================================================================
        //                                                            Optimistic Lock Info
        //                                                            ====================
        protected override bool HasVersionNoValue(Entity entity) {
            return Downcast(entity).VersionNo != null;
        }

        protected override bool HasUpdateDateValue(Entity entity) {
            return false;
        }

        // ===============================================================================
        //                                                                 Delegate Method
        //                                                                 ===============
        #region Delegate Method
        protected int DelegateSelectCount(MemberCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<Member> DelegateSelectList(MemberCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(Member e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(Member e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateModifiedOnly(e); }
        protected int DelegateUpdateNonstrict(Member e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(Member e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.Delete(e); }
        protected int DelegateDeleteNonstrict(Member e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected Member Downcast(Entity entity) {
            return (Member)entity;
        }

        protected MemberCB Downcast(ConditionBean cb) {
            return (MemberCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual MemberDao Dao { get { return _dao; } set { _dao = value; } }
    }
}

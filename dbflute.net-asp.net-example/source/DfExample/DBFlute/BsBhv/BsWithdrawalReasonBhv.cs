
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
    public partial class WithdrawalReasonBhv : DfExample.DBFlute.AllCommon.Bhv.AbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected WithdrawalReasonDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public WithdrawalReasonBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "WITHDRAWAL_REASON"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override DBMeta DBMeta { get { return WithdrawalReasonDbm.GetInstance(); } }
        public WithdrawalReasonDbm MyDBMeta { get { return WithdrawalReasonDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override Entity NewEntity() { return NewMyEntity(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual WithdrawalReason NewMyEntity() { return new WithdrawalReason(); }
        public virtual WithdrawalReasonCB NewMyConditionBean() { return new WithdrawalReasonCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(WithdrawalReasonCB cb) {
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
        public virtual WithdrawalReason SelectEntity(WithdrawalReasonCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<WithdrawalReason> ls = null;
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
            return (WithdrawalReason)ls[0];
        }

        protected override Entity DoReadEntity(ConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual WithdrawalReason SelectEntityWithDeletedCheck(WithdrawalReasonCB cb) {
            AssertConditionBeanNotNull(cb);
            WithdrawalReason entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override Entity DoReadEntityWithDeletedCheck(ConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual WithdrawalReason SelectByPKValue(String withdrawalReasonCode) {
            return SelectEntity(BuildPKCB(withdrawalReasonCode));
        }

        public virtual WithdrawalReason SelectByPKValueWithDeletedCheck(String withdrawalReasonCode) {
            return SelectEntityWithDeletedCheck(BuildPKCB(withdrawalReasonCode));
        }

        private WithdrawalReasonCB BuildPKCB(String withdrawalReasonCode) {
            AssertObjectNotNull("withdrawalReasonCode", withdrawalReasonCode);
            WithdrawalReasonCB cb = NewMyConditionBean();
            cb.Query().SetWithdrawalReasonCode_Equal(withdrawalReasonCode);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual ListResultBean<WithdrawalReason> SelectList(WithdrawalReasonCB cb) {
            AssertConditionBeanNotNull(cb);
            return new ResultBeanBuilder<WithdrawalReason>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual PagingResultBean<WithdrawalReason> SelectPage(WithdrawalReasonCB cb) {
            AssertConditionBeanNotNull(cb);
            PagingInvoker<WithdrawalReason> invoker = new PagingInvoker<WithdrawalReason>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : PagingHandler<WithdrawalReason> {
            protected WithdrawalReasonBhv _bhv; protected WithdrawalReasonCB _cb;
            public InternalSelectPagingHandler(WithdrawalReasonBhv bhv, WithdrawalReasonCB cb) { _bhv = bhv; _cb = cb; }
            public PagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<WithdrawalReason> Paging() { return _bhv.SelectList(_cb); }
        }
        #endregion

        // ===============================================================================
        //                                                                   Load Referrer
        //                                                                   =============
        #region Load Referrer
        public virtual void LoadMemberWithdrawalList(WithdrawalReason withdrawalReason, ConditionBeanSetupper<MemberWithdrawalCB> conditionBeanSetupper) {
            AssertObjectNotNull("withdrawalReason", withdrawalReason); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadMemberWithdrawalList(xnewLRLs<WithdrawalReason>(withdrawalReason), conditionBeanSetupper);
        }
        public virtual void LoadMemberWithdrawalList(IList<WithdrawalReason> withdrawalReasonList, ConditionBeanSetupper<MemberWithdrawalCB> conditionBeanSetupper) {
            AssertObjectNotNull("withdrawalReasonList", withdrawalReasonList); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadMemberWithdrawalList(withdrawalReasonList, new LoadReferrerOption<MemberWithdrawalCB, MemberWithdrawal>().xinit(conditionBeanSetupper));
        }
        public virtual void LoadMemberWithdrawalList(WithdrawalReason withdrawalReason, LoadReferrerOption<MemberWithdrawalCB, MemberWithdrawal> loadReferrerOption) {
            AssertObjectNotNull("withdrawalReason", withdrawalReason); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            LoadMemberWithdrawalList(xnewLRLs<WithdrawalReason>(withdrawalReason), loadReferrerOption);
        }
        public virtual void LoadMemberWithdrawalList(IList<WithdrawalReason> withdrawalReasonList, LoadReferrerOption<MemberWithdrawalCB, MemberWithdrawal> loadReferrerOption) {
            AssertObjectNotNull("withdrawalReasonList", withdrawalReasonList); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            if (withdrawalReasonList.Count == 0) { return; }
            MemberWithdrawalBhv referrerBhv = xgetBSFLR().Select<MemberWithdrawalBhv>();
            HelpLoadReferrerInternally<WithdrawalReason, String, MemberWithdrawalCB, MemberWithdrawal>
                    (withdrawalReasonList, loadReferrerOption, new MyInternalLoadMemberWithdrawalListCallback(referrerBhv));
        }
        protected class MyInternalLoadMemberWithdrawalListCallback : InternalLoadReferrerCallback<WithdrawalReason, String, MemberWithdrawalCB, MemberWithdrawal> {
            protected MemberWithdrawalBhv referrerBhv;
            public MyInternalLoadMemberWithdrawalListCallback(MemberWithdrawalBhv referrerBhv) { this.referrerBhv = referrerBhv; }
            public String getPKVal(WithdrawalReason e) { return e.WithdrawalReasonCode; }
            public void setRfLs(WithdrawalReason e, IList<MemberWithdrawal> ls) { e.MemberWithdrawalList = ls; }
            public MemberWithdrawalCB newMyCB() { return referrerBhv.NewMyConditionBean(); }
            public void qyFKIn(MemberWithdrawalCB cb, IList<String> ls) { cb.Query().SetWithdrawalReasonCode_InScope(ls); }
            public void qyOdFKAsc(MemberWithdrawalCB cb) { cb.Query().AddOrderBy_WithdrawalReasonCode_Asc(); }
            public void spFKCol(MemberWithdrawalCB cb) { cb.Specify().ColumnWithdrawalReasonCode(); }
            public IList<MemberWithdrawal> selRfLs(MemberWithdrawalCB cb) { return referrerBhv.SelectList(cb); }
            public String getFKVal(MemberWithdrawal e) { return e.WithdrawalReasonCode; }
            public void setlcEt(MemberWithdrawal re, WithdrawalReason be) { re.WithdrawalReason = be; }
        }
        public virtual void LoadVdSynonymMemberWithdrawalList(WithdrawalReason withdrawalReason, ConditionBeanSetupper<VdSynonymMemberWithdrawalCB> conditionBeanSetupper) {
            AssertObjectNotNull("withdrawalReason", withdrawalReason); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadVdSynonymMemberWithdrawalList(xnewLRLs<WithdrawalReason>(withdrawalReason), conditionBeanSetupper);
        }
        public virtual void LoadVdSynonymMemberWithdrawalList(IList<WithdrawalReason> withdrawalReasonList, ConditionBeanSetupper<VdSynonymMemberWithdrawalCB> conditionBeanSetupper) {
            AssertObjectNotNull("withdrawalReasonList", withdrawalReasonList); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadVdSynonymMemberWithdrawalList(withdrawalReasonList, new LoadReferrerOption<VdSynonymMemberWithdrawalCB, VdSynonymMemberWithdrawal>().xinit(conditionBeanSetupper));
        }
        public virtual void LoadVdSynonymMemberWithdrawalList(WithdrawalReason withdrawalReason, LoadReferrerOption<VdSynonymMemberWithdrawalCB, VdSynonymMemberWithdrawal> loadReferrerOption) {
            AssertObjectNotNull("withdrawalReason", withdrawalReason); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            LoadVdSynonymMemberWithdrawalList(xnewLRLs<WithdrawalReason>(withdrawalReason), loadReferrerOption);
        }
        public virtual void LoadVdSynonymMemberWithdrawalList(IList<WithdrawalReason> withdrawalReasonList, LoadReferrerOption<VdSynonymMemberWithdrawalCB, VdSynonymMemberWithdrawal> loadReferrerOption) {
            AssertObjectNotNull("withdrawalReasonList", withdrawalReasonList); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            if (withdrawalReasonList.Count == 0) { return; }
            VdSynonymMemberWithdrawalBhv referrerBhv = xgetBSFLR().Select<VdSynonymMemberWithdrawalBhv>();
            HelpLoadReferrerInternally<WithdrawalReason, String, VdSynonymMemberWithdrawalCB, VdSynonymMemberWithdrawal>
                    (withdrawalReasonList, loadReferrerOption, new MyInternalLoadVdSynonymMemberWithdrawalListCallback(referrerBhv));
        }
        protected class MyInternalLoadVdSynonymMemberWithdrawalListCallback : InternalLoadReferrerCallback<WithdrawalReason, String, VdSynonymMemberWithdrawalCB, VdSynonymMemberWithdrawal> {
            protected VdSynonymMemberWithdrawalBhv referrerBhv;
            public MyInternalLoadVdSynonymMemberWithdrawalListCallback(VdSynonymMemberWithdrawalBhv referrerBhv) { this.referrerBhv = referrerBhv; }
            public String getPKVal(WithdrawalReason e) { return e.WithdrawalReasonCode; }
            public void setRfLs(WithdrawalReason e, IList<VdSynonymMemberWithdrawal> ls) { e.VdSynonymMemberWithdrawalList = ls; }
            public VdSynonymMemberWithdrawalCB newMyCB() { return referrerBhv.NewMyConditionBean(); }
            public void qyFKIn(VdSynonymMemberWithdrawalCB cb, IList<String> ls) { cb.Query().SetWithdrawalReasonCode_InScope(ls); }
            public void qyOdFKAsc(VdSynonymMemberWithdrawalCB cb) { cb.Query().AddOrderBy_WithdrawalReasonCode_Asc(); }
            public void spFKCol(VdSynonymMemberWithdrawalCB cb) { cb.Specify().ColumnWithdrawalReasonCode(); }
            public IList<VdSynonymMemberWithdrawal> selRfLs(VdSynonymMemberWithdrawalCB cb) { return referrerBhv.SelectList(cb); }
            public String getFKVal(VdSynonymMemberWithdrawal e) { return e.WithdrawalReasonCode; }
            public void setlcEt(VdSynonymMemberWithdrawal re, WithdrawalReason be) { re.WithdrawalReason = be; }
        }
        #endregion

        // ===============================================================================
        //                                                                Pull out Foreign
        //                                                                ================
        #region Pullout Foreign
        #endregion


        // ===============================================================================
        //                                                                   Entity Update
        //                                                                   =============
        #region Basic Entity Update
        public virtual void Insert(WithdrawalReason entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(Entity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(WithdrawalReason entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(Entity entity) {
            Update(Downcast(entity));
        }

        public void InsertOrUpdate(WithdrawalReason entity) {
            HelpInsertOrUpdateInternally<WithdrawalReason, WithdrawalReasonCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<WithdrawalReason, WithdrawalReasonCB> {
            protected WithdrawalReasonBhv _bhv;
            public MyInternalInsertOrUpdateCallback(WithdrawalReasonBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(WithdrawalReason entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(WithdrawalReason entity) { _bhv.Update(entity); }
            public WithdrawalReasonCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(WithdrawalReasonCB cb, WithdrawalReason entity) {
                cb.Query().SetWithdrawalReasonCode_Equal(entity.WithdrawalReasonCode);
            }
            public int CallbackSelectCount(WithdrawalReasonCB cb) { return _bhv.SelectCount(cb); }
        }

        public virtual void Delete(WithdrawalReason entity) {
            HelpDeleteInternally<WithdrawalReason>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(Entity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<WithdrawalReason> {
            protected WithdrawalReasonBhv _bhv;
            public MyInternalDeleteCallback(WithdrawalReasonBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(WithdrawalReason entity) { return _bhv.DelegateDelete(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(WithdrawalReason withdrawalReason, WithdrawalReasonCB cb) {
            AssertObjectNotNull("withdrawalReason", withdrawalReason); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(withdrawalReason);
            FilterEntityOfUpdate(withdrawalReason); AssertEntityOfUpdate(withdrawalReason);
            return this.Dao.UpdateByQuery(cb, withdrawalReason);
        }

        public int QueryDelete(WithdrawalReasonCB cb) {
            AssertConditionBeanNotNull(cb);
            return this.Dao.DeleteByQuery(cb);
        }

        // ===============================================================================
        //                                                            Optimistic Lock Info
        //                                                            ====================
        protected override bool HasVersionNoValue(Entity entity) {
            return false;
        }

        protected override bool HasUpdateDateValue(Entity entity) {
            return false;
        }

        // ===============================================================================
        //                                                                 Delegate Method
        //                                                                 ===============
        #region Delegate Method
        protected int DelegateSelectCount(WithdrawalReasonCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<WithdrawalReason> DelegateSelectList(WithdrawalReasonCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(WithdrawalReason e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(WithdrawalReason e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(WithdrawalReason e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected WithdrawalReason Downcast(Entity entity) {
            return (WithdrawalReason)entity;
        }

        protected WithdrawalReasonCB Downcast(ConditionBean cb) {
            return (WithdrawalReasonCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual WithdrawalReasonDao Dao { get { return _dao; } set { _dao = value; } }
    }
}

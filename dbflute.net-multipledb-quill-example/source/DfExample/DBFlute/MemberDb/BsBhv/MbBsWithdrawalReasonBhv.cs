
using System;
using System.Collections.Generic;

using Seasar.Quill;
using Seasar.Quill.Attrs;

using DfExample.DBFlute.MemberDb.AllCommon;
using DfExample.DBFlute.MemberDb.AllCommon.Bhv;
using DfExample.DBFlute.MemberDb.AllCommon.Bhv.Load;
using DfExample.DBFlute.MemberDb.AllCommon.Bhv.Setup;
using DfExample.DBFlute.MemberDb.AllCommon.CBean;
using DfExample.DBFlute.MemberDb.AllCommon.Dbm;
using DfExample.DBFlute.MemberDb.AllCommon.Exp;
using DfExample.DBFlute.MemberDb.BsEntity.Dbm;
using DfExample.DBFlute.MemberDb.ExDao;
using DfExample.DBFlute.MemberDb.ExEntity;
using DfExample.DBFlute.MemberDb.CBean;


namespace DfExample.DBFlute.MemberDb.ExBhv {

    [Implementation]
    public partial class MbWithdrawalReasonBhv : DfExample.DBFlute.MemberDb.AllCommon.Bhv.MbAbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected MbWithdrawalReasonDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public MbWithdrawalReasonBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "withdrawal_reason"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override MbDBMeta DBMeta { get { return MbWithdrawalReasonDbm.GetInstance(); } }
        public MbWithdrawalReasonDbm MyDBMeta { get { return MbWithdrawalReasonDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override MbEntity NewEntity() { return NewMyEntity(); }
        public override MbConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual MbWithdrawalReason NewMyEntity() { return new MbWithdrawalReason(); }
        public virtual MbWithdrawalReasonCB NewMyConditionBean() { return new MbWithdrawalReasonCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(MbWithdrawalReasonCB cb) {
            AssertConditionBeanNotNull(cb);
            return this.DelegateSelectCount(cb);
        }

        protected override int DoReadCount(MbConditionBean cb) {
            return SelectCount(Downcast(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                   Entity Select
        //                                                                   =============
        #region Entity Select
        public virtual MbWithdrawalReason SelectEntity(MbWithdrawalReasonCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<MbWithdrawalReason> ls = null;
            try {
                ls = this.DelegateSelectList(cb);
            } catch (MbDangerousResultSizeException e) {
                ThrowEntityDuplicatedException("{over safetyMaxResultSize '1'}", cb, e);
                return null; // unreachable
            } finally {
                xrestoreSafetyResult(cb, preSafetyMaxResultSize);
            }
            if (ls.Count == 0) { return null; }
            AssertEntitySelectedAsOne(ls, cb);
            return (MbWithdrawalReason)ls[0];
        }

        protected override MbEntity DoReadEntity(MbConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual MbWithdrawalReason SelectEntityWithDeletedCheck(MbWithdrawalReasonCB cb) {
            AssertConditionBeanNotNull(cb);
            MbWithdrawalReason entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override MbEntity DoReadEntityWithDeletedCheck(MbConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual MbWithdrawalReason SelectByPKValue(String withdrawalReasonCode) {
            return SelectEntity(BuildPKCB(withdrawalReasonCode));
        }

        public virtual MbWithdrawalReason SelectByPKValueWithDeletedCheck(String withdrawalReasonCode) {
            return SelectEntityWithDeletedCheck(BuildPKCB(withdrawalReasonCode));
        }

        private MbWithdrawalReasonCB BuildPKCB(String withdrawalReasonCode) {
            AssertObjectNotNull("withdrawalReasonCode", withdrawalReasonCode);
            MbWithdrawalReasonCB cb = NewMyConditionBean();
            cb.Query().SetWithdrawalReasonCode_Equal(withdrawalReasonCode);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual MbListResultBean<MbWithdrawalReason> SelectList(MbWithdrawalReasonCB cb) {
            AssertConditionBeanNotNull(cb);
            return new MbResultBeanBuilder<MbWithdrawalReason>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual MbPagingResultBean<MbWithdrawalReason> SelectPage(MbWithdrawalReasonCB cb) {
            AssertConditionBeanNotNull(cb);
            MbPagingInvoker<MbWithdrawalReason> invoker = new MbPagingInvoker<MbWithdrawalReason>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : MbPagingHandler<MbWithdrawalReason> {
            protected MbWithdrawalReasonBhv _bhv; protected MbWithdrawalReasonCB _cb;
            public InternalSelectPagingHandler(MbWithdrawalReasonBhv bhv, MbWithdrawalReasonCB cb) { _bhv = bhv; _cb = cb; }
            public MbPagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<MbWithdrawalReason> Paging() { return _bhv.SelectList(_cb); }
        }
        #endregion

        // ===============================================================================
        //                                                                   Load Referrer
        //                                                                   =============
        #region Load Referrer
        public virtual void LoadMemberWithdrawalList(MbWithdrawalReason withdrawalReason, MbConditionBeanSetupper<MbMemberWithdrawalCB> conditionBeanSetupper) {
            AssertObjectNotNull("withdrawalReason", withdrawalReason); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadMemberWithdrawalList(xnewLRLs<MbWithdrawalReason>(withdrawalReason), conditionBeanSetupper);
        }
        public virtual void LoadMemberWithdrawalList(IList<MbWithdrawalReason> withdrawalReasonList, MbConditionBeanSetupper<MbMemberWithdrawalCB> conditionBeanSetupper) {
            AssertObjectNotNull("withdrawalReasonList", withdrawalReasonList); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadMemberWithdrawalList(withdrawalReasonList, new MbLoadReferrerOption<MbMemberWithdrawalCB, MbMemberWithdrawal>().xinit(conditionBeanSetupper));
        }
        public virtual void LoadMemberWithdrawalList(MbWithdrawalReason withdrawalReason, MbLoadReferrerOption<MbMemberWithdrawalCB, MbMemberWithdrawal> loadReferrerOption) {
            AssertObjectNotNull("withdrawalReason", withdrawalReason); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            LoadMemberWithdrawalList(xnewLRLs<MbWithdrawalReason>(withdrawalReason), loadReferrerOption);
        }
        public virtual void LoadMemberWithdrawalList(IList<MbWithdrawalReason> withdrawalReasonList, MbLoadReferrerOption<MbMemberWithdrawalCB, MbMemberWithdrawal> loadReferrerOption) {
            AssertObjectNotNull("withdrawalReasonList", withdrawalReasonList); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            if (withdrawalReasonList.Count == 0) { return; }
            MbMemberWithdrawalBhv referrerBhv = xgetBSFLR().Select<MbMemberWithdrawalBhv>();
            HelpLoadReferrerInternally<MbWithdrawalReason, String, MbMemberWithdrawalCB, MbMemberWithdrawal>
                    (withdrawalReasonList, loadReferrerOption, new MyInternalLoadMemberWithdrawalListCallback(referrerBhv));
        }
        protected class MyInternalLoadMemberWithdrawalListCallback : InternalLoadReferrerCallback<MbWithdrawalReason, String, MbMemberWithdrawalCB, MbMemberWithdrawal> {
            protected MbMemberWithdrawalBhv referrerBhv;
            public MyInternalLoadMemberWithdrawalListCallback(MbMemberWithdrawalBhv referrerBhv) { this.referrerBhv = referrerBhv; }
            public String getPKVal(MbWithdrawalReason e) { return e.WithdrawalReasonCode; }
            public void setRfLs(MbWithdrawalReason e, IList<MbMemberWithdrawal> ls) { e.MemberWithdrawalList = ls; }
            public MbMemberWithdrawalCB newMyCB() { return referrerBhv.NewMyConditionBean(); }
            public void qyFKIn(MbMemberWithdrawalCB cb, IList<String> ls) { cb.Query().SetWithdrawalReasonCode_InScope(ls); }
            public void qyOdFKAsc(MbMemberWithdrawalCB cb) { cb.Query().AddOrderBy_WithdrawalReasonCode_Asc(); }
            public void spFKCol(MbMemberWithdrawalCB cb) { cb.Specify().ColumnWithdrawalReasonCode(); }
            public IList<MbMemberWithdrawal> selRfLs(MbMemberWithdrawalCB cb) { return referrerBhv.SelectList(cb); }
            public String getFKVal(MbMemberWithdrawal e) { return e.WithdrawalReasonCode; }
            public void setlcEt(MbMemberWithdrawal re, MbWithdrawalReason be) { re.WithdrawalReason = be; }
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
        public virtual void Insert(MbWithdrawalReason entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(MbEntity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(MbWithdrawalReason entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(MbEntity entity) {
            Update(Downcast(entity));
        }

        public void InsertOrUpdate(MbWithdrawalReason entity) {
            HelpInsertOrUpdateInternally<MbWithdrawalReason, MbWithdrawalReasonCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<MbWithdrawalReason, MbWithdrawalReasonCB> {
            protected MbWithdrawalReasonBhv _bhv;
            public MyInternalInsertOrUpdateCallback(MbWithdrawalReasonBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(MbWithdrawalReason entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(MbWithdrawalReason entity) { _bhv.Update(entity); }
            public MbWithdrawalReasonCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(MbWithdrawalReasonCB cb, MbWithdrawalReason entity) {
                cb.Query().SetWithdrawalReasonCode_Equal(entity.WithdrawalReasonCode);
            }
            public int CallbackSelectCount(MbWithdrawalReasonCB cb) { return _bhv.SelectCount(cb); }
        }

        public virtual void Delete(MbWithdrawalReason entity) {
            HelpDeleteInternally<MbWithdrawalReason>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(MbEntity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<MbWithdrawalReason> {
            protected MbWithdrawalReasonBhv _bhv;
            public MyInternalDeleteCallback(MbWithdrawalReasonBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(MbWithdrawalReason entity) { return _bhv.DelegateDelete(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(MbWithdrawalReason withdrawalReason, MbWithdrawalReasonCB cb) {
            AssertObjectNotNull("withdrawalReason", withdrawalReason); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(withdrawalReason);
            FilterEntityOfUpdate(withdrawalReason); AssertEntityOfUpdate(withdrawalReason);
            return this.Dao.UpdateByQuery(cb, withdrawalReason);
        }

        public int QueryDelete(MbWithdrawalReasonCB cb) {
            AssertConditionBeanNotNull(cb);
            return this.Dao.DeleteByQuery(cb);
        }

        // ===============================================================================
        //                                                            Optimistic Lock Info
        //                                                            ====================
        protected override bool HasVersionNoValue(MbEntity entity) {
            return false;
        }

        protected override bool HasUpdateDateValue(MbEntity entity) {
            return false;
        }

        // ===============================================================================
        //                                                                 Delegate Method
        //                                                                 ===============
        #region Delegate Method
        protected int DelegateSelectCount(MbWithdrawalReasonCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<MbWithdrawalReason> DelegateSelectList(MbWithdrawalReasonCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(MbWithdrawalReason e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(MbWithdrawalReason e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(MbWithdrawalReason e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected MbWithdrawalReason Downcast(MbEntity entity) {
            return (MbWithdrawalReason)entity;
        }

        protected MbWithdrawalReasonCB Downcast(MbConditionBean cb) {
            return (MbWithdrawalReasonCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual MbWithdrawalReasonDao Dao { get { return _dao; } set { _dao = value; } }
    }
}

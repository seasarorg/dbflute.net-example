
using System;
using System.Collections.Generic;

using Seasar.Quill;
using Seasar.Quill.Attrs;

using DfExample.DBFlute.LibraryDb.AllCommon;
using DfExample.DBFlute.LibraryDb.AllCommon.Bhv;
using DfExample.DBFlute.LibraryDb.AllCommon.Bhv.Load;
using DfExample.DBFlute.LibraryDb.AllCommon.Bhv.Setup;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean;
using DfExample.DBFlute.LibraryDb.AllCommon.Dbm;
using DfExample.DBFlute.LibraryDb.AllCommon.Exp;
using DfExample.DBFlute.LibraryDb.BsEntity.Dbm;
using DfExample.DBFlute.LibraryDb.ExDao;
using DfExample.DBFlute.LibraryDb.ExEntity;
using DfExample.DBFlute.LibraryDb.CBean;


namespace DfExample.DBFlute.LibraryDb.ExBhv {

    [Implementation]
    public partial class LdBlackListBhv : DfExample.DBFlute.LibraryDb.AllCommon.Bhv.LdAbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected LdBlackListDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public LdBlackListBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "black_list"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override LdDBMeta DBMeta { get { return LdBlackListDbm.GetInstance(); } }
        public LdBlackListDbm MyDBMeta { get { return LdBlackListDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override LdEntity NewEntity() { return NewMyEntity(); }
        public override LdConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual LdBlackList NewMyEntity() { return new LdBlackList(); }
        public virtual LdBlackListCB NewMyConditionBean() { return new LdBlackListCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(LdBlackListCB cb) {
            AssertConditionBeanNotNull(cb);
            return this.DelegateSelectCount(cb);
        }

        protected override int DoReadCount(LdConditionBean cb) {
            return SelectCount(Downcast(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                   Entity Select
        //                                                                   =============
        #region Entity Select
        public virtual LdBlackList SelectEntity(LdBlackListCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<LdBlackList> ls = null;
            try {
                ls = this.DelegateSelectList(cb);
            } catch (LdDangerousResultSizeException e) {
                ThrowEntityDuplicatedException("{over safetyMaxResultSize '1'}", cb, e);
                return null; // unreachable
            } finally {
                xrestoreSafetyResult(cb, preSafetyMaxResultSize);
            }
            if (ls.Count == 0) { return null; }
            AssertEntitySelectedAsOne(ls, cb);
            return (LdBlackList)ls[0];
        }

        protected override LdEntity DoReadEntity(LdConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual LdBlackList SelectEntityWithDeletedCheck(LdBlackListCB cb) {
            AssertConditionBeanNotNull(cb);
            LdBlackList entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override LdEntity DoReadEntityWithDeletedCheck(LdConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual LdBlackList SelectByPKValue(int? blackListId) {
            return SelectEntity(BuildPKCB(blackListId));
        }

        public virtual LdBlackList SelectByPKValueWithDeletedCheck(int? blackListId) {
            return SelectEntityWithDeletedCheck(BuildPKCB(blackListId));
        }

        private LdBlackListCB BuildPKCB(int? blackListId) {
            AssertObjectNotNull("blackListId", blackListId);
            LdBlackListCB cb = NewMyConditionBean();
            cb.Query().SetBlackListId_Equal(blackListId);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual LdListResultBean<LdBlackList> SelectList(LdBlackListCB cb) {
            AssertConditionBeanNotNull(cb);
            return new LdResultBeanBuilder<LdBlackList>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual LdPagingResultBean<LdBlackList> SelectPage(LdBlackListCB cb) {
            AssertConditionBeanNotNull(cb);
            LdPagingInvoker<LdBlackList> invoker = new LdPagingInvoker<LdBlackList>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : LdPagingHandler<LdBlackList> {
            protected LdBlackListBhv _bhv; protected LdBlackListCB _cb;
            public InternalSelectPagingHandler(LdBlackListBhv bhv, LdBlackListCB cb) { _bhv = bhv; _cb = cb; }
            public LdPagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<LdBlackList> Paging() { return _bhv.SelectList(_cb); }
        }
        #endregion

        // ===============================================================================
        //                                                                   Load Referrer
        //                                                                   =============
        #region Load Referrer
        public virtual void LoadBlackActionList(LdBlackList blackList, LdConditionBeanSetupper<LdBlackActionCB> conditionBeanSetupper) {
            AssertObjectNotNull("blackList", blackList); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadBlackActionList(xnewLRLs<LdBlackList>(blackList), conditionBeanSetupper);
        }
        public virtual void LoadBlackActionList(IList<LdBlackList> blackListList, LdConditionBeanSetupper<LdBlackActionCB> conditionBeanSetupper) {
            AssertObjectNotNull("blackListList", blackListList); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadBlackActionList(blackListList, new LdLoadReferrerOption<LdBlackActionCB, LdBlackAction>().xinit(conditionBeanSetupper));
        }
        public virtual void LoadBlackActionList(LdBlackList blackList, LdLoadReferrerOption<LdBlackActionCB, LdBlackAction> loadReferrerOption) {
            AssertObjectNotNull("blackList", blackList); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            LoadBlackActionList(xnewLRLs<LdBlackList>(blackList), loadReferrerOption);
        }
        public virtual void LoadBlackActionList(IList<LdBlackList> blackListList, LdLoadReferrerOption<LdBlackActionCB, LdBlackAction> loadReferrerOption) {
            AssertObjectNotNull("blackListList", blackListList); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            if (blackListList.Count == 0) { return; }
            LdBlackActionBhv referrerBhv = xgetBSFLR().Select<LdBlackActionBhv>();
            HelpLoadReferrerInternally<LdBlackList, int?, LdBlackActionCB, LdBlackAction>
                    (blackListList, loadReferrerOption, new MyInternalLoadBlackActionListCallback(referrerBhv));
        }
        protected class MyInternalLoadBlackActionListCallback : InternalLoadReferrerCallback<LdBlackList, int?, LdBlackActionCB, LdBlackAction> {
            protected LdBlackActionBhv referrerBhv;
            public MyInternalLoadBlackActionListCallback(LdBlackActionBhv referrerBhv) { this.referrerBhv = referrerBhv; }
            public int? getPKVal(LdBlackList e) { return e.BlackListId; }
            public void setRfLs(LdBlackList e, IList<LdBlackAction> ls) { e.BlackActionList = ls; }
            public LdBlackActionCB newMyCB() { return referrerBhv.NewMyConditionBean(); }
            public void qyFKIn(LdBlackActionCB cb, IList<int?> ls) { cb.Query().SetBlackListId_InScope(ls); }
            public void qyOdFKAsc(LdBlackActionCB cb) { cb.Query().AddOrderBy_BlackListId_Asc(); }
            public void spFKCol(LdBlackActionCB cb) { cb.Specify().ColumnBlackListId(); }
            public IList<LdBlackAction> selRfLs(LdBlackActionCB cb) { return referrerBhv.SelectList(cb); }
            public int? getFKVal(LdBlackAction e) { return e.BlackListId; }
            public void setlcEt(LdBlackAction re, LdBlackList be) { re.BlackList = be; }
        }
        #endregion

        // ===============================================================================
        //                                                                Pull out Foreign
        //                                                                ================
        #region Pullout Foreign
        public IList<LdLbUser> PulloutLbUser(IList<LdBlackList> blackListList) {
            return HelpPulloutInternally<LdBlackList, LdLbUser>(blackListList, new MyInternalPulloutLbUserCallback());
        }
        protected class MyInternalPulloutLbUserCallback : InternalPulloutCallback<LdBlackList, LdLbUser> {
            public LdLbUser getFr(LdBlackList entity) { return entity.LbUser; }
        }
        #endregion


        // ===============================================================================
        //                                                                   Entity Update
        //                                                                   =============
        #region Basic Entity Update
        public virtual void Insert(LdBlackList entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(LdEntity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(LdBlackList entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(LdEntity entity) {
            Update(Downcast(entity));
        }

        public virtual void UpdateNonstrict(LdBlackList entity) {
            AssertEntityNotNull(entity);
            int updatedCount = this.DelegateUpdateNonstrict(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        public void InsertOrUpdate(LdBlackList entity) {
            HelpInsertOrUpdateInternally<LdBlackList, LdBlackListCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<LdBlackList, LdBlackListCB> {
            protected LdBlackListBhv _bhv;
            public MyInternalInsertOrUpdateCallback(LdBlackListBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(LdBlackList entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(LdBlackList entity) { _bhv.Update(entity); }
            public LdBlackListCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(LdBlackListCB cb, LdBlackList entity) {
                cb.Query().SetBlackListId_Equal(entity.BlackListId);
            }
            public int CallbackSelectCount(LdBlackListCB cb) { return _bhv.SelectCount(cb); }
        }

        public void InsertOrUpdateNonstrict(LdBlackList entity) {
            HelpInsertOrUpdateInternally<LdBlackList>(entity, new MyInternalInsertOrUpdateNonstrictCallback(this));
        }
        protected class MyInternalInsertOrUpdateNonstrictCallback : InternalInsertOrUpdateNonstrictCallback<LdBlackList> {
            protected LdBlackListBhv _bhv;
            public MyInternalInsertOrUpdateNonstrictCallback(LdBlackListBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(LdBlackList entity) { _bhv.Insert(entity); }
            public void CallbackUpdateNonstrict(LdBlackList entity) { _bhv.UpdateNonstrict(entity); }
        }

        public virtual void Delete(LdBlackList entity) {
            HelpDeleteInternally<LdBlackList>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(LdEntity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<LdBlackList> {
            protected LdBlackListBhv _bhv;
            public MyInternalDeleteCallback(LdBlackListBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(LdBlackList entity) { return _bhv.DelegateDelete(entity); }
        }

        public virtual void DeleteNonstrict(LdBlackList entity) {
            HelpDeleteNonstrictInternally<LdBlackList>(entity, new MyInternalDeleteNonstrictCallback(this));
        }
        protected class MyInternalDeleteNonstrictCallback : InternalDeleteNonstrictCallback<LdBlackList> {
            protected LdBlackListBhv _bhv;
            public MyInternalDeleteNonstrictCallback(LdBlackListBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDeleteNonstrict(LdBlackList entity) { return _bhv.DelegateDeleteNonstrict(entity); }
        }

        public virtual void DeleteNonstrictIgnoreDeleted(LdBlackList entity) {
            HelpDeleteNonstrictIgnoreDeletedInternally<LdBlackList>(entity, new MyInternalDeleteNonstrictIgnoreDeletedCallback(this));
        }
        protected class MyInternalDeleteNonstrictIgnoreDeletedCallback : InternalDeleteNonstrictIgnoreDeletedCallback<LdBlackList> {
            protected LdBlackListBhv _bhv;
            public MyInternalDeleteNonstrictIgnoreDeletedCallback(LdBlackListBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDeleteNonstrict(LdBlackList entity) { return _bhv.DelegateDeleteNonstrict(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(LdBlackList blackList, LdBlackListCB cb) {
            AssertObjectNotNull("blackList", blackList); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(blackList);
            FilterEntityOfUpdate(blackList); AssertEntityOfUpdate(blackList);
            return this.Dao.UpdateByQuery(cb, blackList);
        }

        public int QueryDelete(LdBlackListCB cb) {
            AssertConditionBeanNotNull(cb);
            return this.Dao.DeleteByQuery(cb);
        }

        // ===============================================================================
        //                                                            Optimistic Lock Info
        //                                                            ====================
        protected override bool HasVersionNoValue(LdEntity entity) {
            return false;
        }

        protected override bool HasUpdateDateValue(LdEntity entity) {
            return Downcast(entity).UTimestamp != null;
        }

        // ===============================================================================
        //                                                                 Delegate Method
        //                                                                 ===============
        #region Delegate Method
        protected int DelegateSelectCount(LdBlackListCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<LdBlackList> DelegateSelectList(LdBlackListCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(LdBlackList e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(LdBlackList e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateModifiedOnly(e); }
        protected int DelegateUpdateNonstrict(LdBlackList e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(LdBlackList e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.Delete(e); }
        protected int DelegateDeleteNonstrict(LdBlackList e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected LdBlackList Downcast(LdEntity entity) {
            return (LdBlackList)entity;
        }

        protected LdBlackListCB Downcast(LdConditionBean cb) {
            return (LdBlackListCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual LdBlackListDao Dao { get { return _dao; } set { _dao = value; } }
    }
}

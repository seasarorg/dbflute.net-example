
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
    public partial class LdBlackActionBhv : DfExample.DBFlute.LibraryDb.AllCommon.Bhv.LdAbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected LdBlackActionDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public LdBlackActionBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "black_action"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override LdDBMeta DBMeta { get { return LdBlackActionDbm.GetInstance(); } }
        public LdBlackActionDbm MyDBMeta { get { return LdBlackActionDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override LdEntity NewEntity() { return NewMyEntity(); }
        public override LdConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual LdBlackAction NewMyEntity() { return new LdBlackAction(); }
        public virtual LdBlackActionCB NewMyConditionBean() { return new LdBlackActionCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(LdBlackActionCB cb) {
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
        public virtual LdBlackAction SelectEntity(LdBlackActionCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<LdBlackAction> ls = null;
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
            return (LdBlackAction)ls[0];
        }

        protected override LdEntity DoReadEntity(LdConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual LdBlackAction SelectEntityWithDeletedCheck(LdBlackActionCB cb) {
            AssertConditionBeanNotNull(cb);
            LdBlackAction entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override LdEntity DoReadEntityWithDeletedCheck(LdConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual LdBlackAction SelectByPKValue(int? blackActionId) {
            return SelectEntity(BuildPKCB(blackActionId));
        }

        public virtual LdBlackAction SelectByPKValueWithDeletedCheck(int? blackActionId) {
            return SelectEntityWithDeletedCheck(BuildPKCB(blackActionId));
        }

        private LdBlackActionCB BuildPKCB(int? blackActionId) {
            AssertObjectNotNull("blackActionId", blackActionId);
            LdBlackActionCB cb = NewMyConditionBean();
            cb.Query().SetBlackActionId_Equal(blackActionId);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual LdListResultBean<LdBlackAction> SelectList(LdBlackActionCB cb) {
            AssertConditionBeanNotNull(cb);
            return new LdResultBeanBuilder<LdBlackAction>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual LdPagingResultBean<LdBlackAction> SelectPage(LdBlackActionCB cb) {
            AssertConditionBeanNotNull(cb);
            LdPagingInvoker<LdBlackAction> invoker = new LdPagingInvoker<LdBlackAction>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : LdPagingHandler<LdBlackAction> {
            protected LdBlackActionBhv _bhv; protected LdBlackActionCB _cb;
            public InternalSelectPagingHandler(LdBlackActionBhv bhv, LdBlackActionCB cb) { _bhv = bhv; _cb = cb; }
            public LdPagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<LdBlackAction> Paging() { return _bhv.SelectList(_cb); }
        }
        #endregion

        // ===============================================================================
        //                                                                   Load Referrer
        //                                                                   =============
        #region Load Referrer
        #endregion

        // ===============================================================================
        //                                                                Pull out Foreign
        //                                                                ================
        #region Pullout Foreign
        public IList<LdBlackList> PulloutBlackList(IList<LdBlackAction> blackActionList) {
            return HelpPulloutInternally<LdBlackAction, LdBlackList>(blackActionList, new MyInternalPulloutBlackListCallback());
        }
        protected class MyInternalPulloutBlackListCallback : InternalPulloutCallback<LdBlackAction, LdBlackList> {
            public LdBlackList getFr(LdBlackAction entity) { return entity.BlackList; }
        }
        public IList<LdBlackActionLookup> PulloutBlackActionLookup(IList<LdBlackAction> blackActionList) {
            return HelpPulloutInternally<LdBlackAction, LdBlackActionLookup>(blackActionList, new MyInternalPulloutBlackActionLookupCallback());
        }
        protected class MyInternalPulloutBlackActionLookupCallback : InternalPulloutCallback<LdBlackAction, LdBlackActionLookup> {
            public LdBlackActionLookup getFr(LdBlackAction entity) { return entity.BlackActionLookup; }
        }
        #endregion


        // ===============================================================================
        //                                                                   Entity Update
        //                                                                   =============
        #region Basic Entity Update
        public virtual void Insert(LdBlackAction entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(LdEntity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(LdBlackAction entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(LdEntity entity) {
            Update(Downcast(entity));
        }

        public virtual void UpdateNonstrict(LdBlackAction entity) {
            AssertEntityNotNull(entity);
            int updatedCount = this.DelegateUpdateNonstrict(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        public void InsertOrUpdate(LdBlackAction entity) {
            HelpInsertOrUpdateInternally<LdBlackAction, LdBlackActionCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<LdBlackAction, LdBlackActionCB> {
            protected LdBlackActionBhv _bhv;
            public MyInternalInsertOrUpdateCallback(LdBlackActionBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(LdBlackAction entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(LdBlackAction entity) { _bhv.Update(entity); }
            public LdBlackActionCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(LdBlackActionCB cb, LdBlackAction entity) {
                cb.Query().SetBlackActionId_Equal(entity.BlackActionId);
            }
            public int CallbackSelectCount(LdBlackActionCB cb) { return _bhv.SelectCount(cb); }
        }

        public void InsertOrUpdateNonstrict(LdBlackAction entity) {
            HelpInsertOrUpdateInternally<LdBlackAction>(entity, new MyInternalInsertOrUpdateNonstrictCallback(this));
        }
        protected class MyInternalInsertOrUpdateNonstrictCallback : InternalInsertOrUpdateNonstrictCallback<LdBlackAction> {
            protected LdBlackActionBhv _bhv;
            public MyInternalInsertOrUpdateNonstrictCallback(LdBlackActionBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(LdBlackAction entity) { _bhv.Insert(entity); }
            public void CallbackUpdateNonstrict(LdBlackAction entity) { _bhv.UpdateNonstrict(entity); }
        }

        public virtual void Delete(LdBlackAction entity) {
            HelpDeleteInternally<LdBlackAction>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(LdEntity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<LdBlackAction> {
            protected LdBlackActionBhv _bhv;
            public MyInternalDeleteCallback(LdBlackActionBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(LdBlackAction entity) { return _bhv.DelegateDelete(entity); }
        }

        public virtual void DeleteNonstrict(LdBlackAction entity) {
            HelpDeleteNonstrictInternally<LdBlackAction>(entity, new MyInternalDeleteNonstrictCallback(this));
        }
        protected class MyInternalDeleteNonstrictCallback : InternalDeleteNonstrictCallback<LdBlackAction> {
            protected LdBlackActionBhv _bhv;
            public MyInternalDeleteNonstrictCallback(LdBlackActionBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDeleteNonstrict(LdBlackAction entity) { return _bhv.DelegateDeleteNonstrict(entity); }
        }

        public virtual void DeleteNonstrictIgnoreDeleted(LdBlackAction entity) {
            HelpDeleteNonstrictIgnoreDeletedInternally<LdBlackAction>(entity, new MyInternalDeleteNonstrictIgnoreDeletedCallback(this));
        }
        protected class MyInternalDeleteNonstrictIgnoreDeletedCallback : InternalDeleteNonstrictIgnoreDeletedCallback<LdBlackAction> {
            protected LdBlackActionBhv _bhv;
            public MyInternalDeleteNonstrictIgnoreDeletedCallback(LdBlackActionBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDeleteNonstrict(LdBlackAction entity) { return _bhv.DelegateDeleteNonstrict(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(LdBlackAction blackAction, LdBlackActionCB cb) {
            AssertObjectNotNull("blackAction", blackAction); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(blackAction);
            FilterEntityOfUpdate(blackAction); AssertEntityOfUpdate(blackAction);
            return this.Dao.UpdateByQuery(cb, blackAction);
        }

        public int QueryDelete(LdBlackActionCB cb) {
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
        protected int DelegateSelectCount(LdBlackActionCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<LdBlackAction> DelegateSelectList(LdBlackActionCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(LdBlackAction e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(LdBlackAction e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateModifiedOnly(e); }
        protected int DelegateUpdateNonstrict(LdBlackAction e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(LdBlackAction e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.Delete(e); }
        protected int DelegateDeleteNonstrict(LdBlackAction e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected LdBlackAction Downcast(LdEntity entity) {
            return (LdBlackAction)entity;
        }

        protected LdBlackActionCB Downcast(LdConditionBean cb) {
            return (LdBlackActionCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual LdBlackActionDao Dao { get { return _dao; } set { _dao = value; } }
    }
}

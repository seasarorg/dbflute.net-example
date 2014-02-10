
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
    public partial class LdLendingCollectionBhv : DfExample.DBFlute.LibraryDb.AllCommon.Bhv.LdAbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected LdLendingCollectionDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public LdLendingCollectionBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "lending_collection"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override LdDBMeta DBMeta { get { return LdLendingCollectionDbm.GetInstance(); } }
        public LdLendingCollectionDbm MyDBMeta { get { return LdLendingCollectionDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override LdEntity NewEntity() { return NewMyEntity(); }
        public override LdConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual LdLendingCollection NewMyEntity() { return new LdLendingCollection(); }
        public virtual LdLendingCollectionCB NewMyConditionBean() { return new LdLendingCollectionCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(LdLendingCollectionCB cb) {
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
        public virtual LdLendingCollection SelectEntity(LdLendingCollectionCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<LdLendingCollection> ls = null;
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
            return (LdLendingCollection)ls[0];
        }

        protected override LdEntity DoReadEntity(LdConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual LdLendingCollection SelectEntityWithDeletedCheck(LdLendingCollectionCB cb) {
            AssertConditionBeanNotNull(cb);
            LdLendingCollection entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override LdEntity DoReadEntityWithDeletedCheck(LdConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual LdLendingCollection SelectByPKValue(int? libraryId, int? lbUserId, DateTime? lendingDate, int? collectionId) {
            return SelectEntity(BuildPKCB(libraryId, lbUserId, lendingDate, collectionId));
        }

        public virtual LdLendingCollection SelectByPKValueWithDeletedCheck(int? libraryId, int? lbUserId, DateTime? lendingDate, int? collectionId) {
            return SelectEntityWithDeletedCheck(BuildPKCB(libraryId, lbUserId, lendingDate, collectionId));
        }

        private LdLendingCollectionCB BuildPKCB(int? libraryId, int? lbUserId, DateTime? lendingDate, int? collectionId) {
            AssertObjectNotNull("libraryId", libraryId);AssertObjectNotNull("lbUserId", lbUserId);AssertObjectNotNull("lendingDate", lendingDate);AssertObjectNotNull("collectionId", collectionId);
            LdLendingCollectionCB cb = NewMyConditionBean();
            cb.Query().SetLibraryId_Equal(libraryId);cb.Query().SetLbUserId_Equal(lbUserId);cb.Query().SetLendingDate_Equal(lendingDate);cb.Query().SetCollectionId_Equal(collectionId);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual LdListResultBean<LdLendingCollection> SelectList(LdLendingCollectionCB cb) {
            AssertConditionBeanNotNull(cb);
            return new LdResultBeanBuilder<LdLendingCollection>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual LdPagingResultBean<LdLendingCollection> SelectPage(LdLendingCollectionCB cb) {
            AssertConditionBeanNotNull(cb);
            LdPagingInvoker<LdLendingCollection> invoker = new LdPagingInvoker<LdLendingCollection>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : LdPagingHandler<LdLendingCollection> {
            protected LdLendingCollectionBhv _bhv; protected LdLendingCollectionCB _cb;
            public InternalSelectPagingHandler(LdLendingCollectionBhv bhv, LdLendingCollectionCB cb) { _bhv = bhv; _cb = cb; }
            public LdPagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<LdLendingCollection> Paging() { return _bhv.SelectList(_cb); }
        }
        #endregion


        // ===============================================================================
        //                                                                Pull out Foreign
        //                                                                ================
        #region Pullout Foreign
        public IList<LdCollection> PulloutCollection(IList<LdLendingCollection> lendingCollectionList) {
            return HelpPulloutInternally<LdLendingCollection, LdCollection>(lendingCollectionList, new MyInternalPulloutCollectionCallback());
        }
        protected class MyInternalPulloutCollectionCallback : InternalPulloutCallback<LdLendingCollection, LdCollection> {
            public LdCollection getFr(LdLendingCollection entity) { return entity.Collection; }
        }
        public IList<LdLending> PulloutLending(IList<LdLendingCollection> lendingCollectionList) {
            return HelpPulloutInternally<LdLendingCollection, LdLending>(lendingCollectionList, new MyInternalPulloutLendingCallback());
        }
        protected class MyInternalPulloutLendingCallback : InternalPulloutCallback<LdLendingCollection, LdLending> {
            public LdLending getFr(LdLendingCollection entity) { return entity.Lending; }
        }
        public IList<LdLibraryUser> PulloutLibraryUser(IList<LdLendingCollection> lendingCollectionList) {
            return HelpPulloutInternally<LdLendingCollection, LdLibraryUser>(lendingCollectionList, new MyInternalPulloutLibraryUserCallback());
        }
        protected class MyInternalPulloutLibraryUserCallback : InternalPulloutCallback<LdLendingCollection, LdLibraryUser> {
            public LdLibraryUser getFr(LdLendingCollection entity) { return entity.LibraryUser; }
        }
        #endregion


        // ===============================================================================
        //                                                                   Entity Update
        //                                                                   =============
        #region Basic Entity Update
        public virtual void Insert(LdLendingCollection entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(LdEntity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(LdLendingCollection entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(LdEntity entity) {
            Update(Downcast(entity));
        }

        public virtual void UpdateNonstrict(LdLendingCollection entity) {
            AssertEntityNotNull(entity);
            int updatedCount = this.DelegateUpdateNonstrict(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        public void InsertOrUpdate(LdLendingCollection entity) {
            HelpInsertOrUpdateInternally<LdLendingCollection, LdLendingCollectionCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<LdLendingCollection, LdLendingCollectionCB> {
            protected LdLendingCollectionBhv _bhv;
            public MyInternalInsertOrUpdateCallback(LdLendingCollectionBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(LdLendingCollection entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(LdLendingCollection entity) { _bhv.Update(entity); }
            public LdLendingCollectionCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(LdLendingCollectionCB cb, LdLendingCollection entity) {
                cb.Query().SetLibraryId_Equal(entity.LibraryId);
                cb.Query().SetLbUserId_Equal(entity.LbUserId);
                cb.Query().SetLendingDate_Equal(entity.LendingDate);
                cb.Query().SetCollectionId_Equal(entity.CollectionId);
            }
            public int CallbackSelectCount(LdLendingCollectionCB cb) { return _bhv.SelectCount(cb); }
        }

        public void InsertOrUpdateNonstrict(LdLendingCollection entity) {
            HelpInsertOrUpdateInternally<LdLendingCollection>(entity, new MyInternalInsertOrUpdateNonstrictCallback(this));
        }
        protected class MyInternalInsertOrUpdateNonstrictCallback : InternalInsertOrUpdateNonstrictCallback<LdLendingCollection> {
            protected LdLendingCollectionBhv _bhv;
            public MyInternalInsertOrUpdateNonstrictCallback(LdLendingCollectionBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(LdLendingCollection entity) { _bhv.Insert(entity); }
            public void CallbackUpdateNonstrict(LdLendingCollection entity) { _bhv.UpdateNonstrict(entity); }
        }

        public virtual void Delete(LdLendingCollection entity) {
            HelpDeleteInternally<LdLendingCollection>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(LdEntity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<LdLendingCollection> {
            protected LdLendingCollectionBhv _bhv;
            public MyInternalDeleteCallback(LdLendingCollectionBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(LdLendingCollection entity) { return _bhv.DelegateDelete(entity); }
        }

        public virtual void DeleteNonstrict(LdLendingCollection entity) {
            HelpDeleteNonstrictInternally<LdLendingCollection>(entity, new MyInternalDeleteNonstrictCallback(this));
        }
        protected class MyInternalDeleteNonstrictCallback : InternalDeleteNonstrictCallback<LdLendingCollection> {
            protected LdLendingCollectionBhv _bhv;
            public MyInternalDeleteNonstrictCallback(LdLendingCollectionBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDeleteNonstrict(LdLendingCollection entity) { return _bhv.DelegateDeleteNonstrict(entity); }
        }

        public virtual void DeleteNonstrictIgnoreDeleted(LdLendingCollection entity) {
            HelpDeleteNonstrictIgnoreDeletedInternally<LdLendingCollection>(entity, new MyInternalDeleteNonstrictIgnoreDeletedCallback(this));
        }
        protected class MyInternalDeleteNonstrictIgnoreDeletedCallback : InternalDeleteNonstrictIgnoreDeletedCallback<LdLendingCollection> {
            protected LdLendingCollectionBhv _bhv;
            public MyInternalDeleteNonstrictIgnoreDeletedCallback(LdLendingCollectionBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDeleteNonstrict(LdLendingCollection entity) { return _bhv.DelegateDeleteNonstrict(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============

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
        protected int DelegateSelectCount(LdLendingCollectionCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<LdLendingCollection> DelegateSelectList(LdLendingCollectionCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(LdLendingCollection e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(LdLendingCollection e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateModifiedOnly(e); }
        protected int DelegateUpdateNonstrict(LdLendingCollection e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(LdLendingCollection e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.Delete(e); }
        protected int DelegateDeleteNonstrict(LdLendingCollection e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected LdLendingCollection Downcast(LdEntity entity) {
            return (LdLendingCollection)entity;
        }

        protected LdLendingCollectionCB Downcast(LdConditionBean cb) {
            return (LdLendingCollectionCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual LdLendingCollectionDao Dao { get { return _dao; } set { _dao = value; } }
    }
}

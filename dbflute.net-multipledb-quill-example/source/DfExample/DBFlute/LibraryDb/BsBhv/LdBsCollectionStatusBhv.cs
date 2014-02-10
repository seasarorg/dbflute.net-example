
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
    public partial class LdCollectionStatusBhv : DfExample.DBFlute.LibraryDb.AllCommon.Bhv.LdAbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected LdCollectionStatusDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public LdCollectionStatusBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "collection_status"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override LdDBMeta DBMeta { get { return LdCollectionStatusDbm.GetInstance(); } }
        public LdCollectionStatusDbm MyDBMeta { get { return LdCollectionStatusDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override LdEntity NewEntity() { return NewMyEntity(); }
        public override LdConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual LdCollectionStatus NewMyEntity() { return new LdCollectionStatus(); }
        public virtual LdCollectionStatusCB NewMyConditionBean() { return new LdCollectionStatusCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(LdCollectionStatusCB cb) {
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
        public virtual LdCollectionStatus SelectEntity(LdCollectionStatusCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<LdCollectionStatus> ls = null;
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
            return (LdCollectionStatus)ls[0];
        }

        protected override LdEntity DoReadEntity(LdConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual LdCollectionStatus SelectEntityWithDeletedCheck(LdCollectionStatusCB cb) {
            AssertConditionBeanNotNull(cb);
            LdCollectionStatus entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override LdEntity DoReadEntityWithDeletedCheck(LdConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual LdCollectionStatus SelectByPKValue(int? collectionId) {
            return SelectEntity(BuildPKCB(collectionId));
        }

        public virtual LdCollectionStatus SelectByPKValueWithDeletedCheck(int? collectionId) {
            return SelectEntityWithDeletedCheck(BuildPKCB(collectionId));
        }

        private LdCollectionStatusCB BuildPKCB(int? collectionId) {
            AssertObjectNotNull("collectionId", collectionId);
            LdCollectionStatusCB cb = NewMyConditionBean();
            cb.Query().SetCollectionId_Equal(collectionId);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual LdListResultBean<LdCollectionStatus> SelectList(LdCollectionStatusCB cb) {
            AssertConditionBeanNotNull(cb);
            return new LdResultBeanBuilder<LdCollectionStatus>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual LdPagingResultBean<LdCollectionStatus> SelectPage(LdCollectionStatusCB cb) {
            AssertConditionBeanNotNull(cb);
            LdPagingInvoker<LdCollectionStatus> invoker = new LdPagingInvoker<LdCollectionStatus>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : LdPagingHandler<LdCollectionStatus> {
            protected LdCollectionStatusBhv _bhv; protected LdCollectionStatusCB _cb;
            public InternalSelectPagingHandler(LdCollectionStatusBhv bhv, LdCollectionStatusCB cb) { _bhv = bhv; _cb = cb; }
            public LdPagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<LdCollectionStatus> Paging() { return _bhv.SelectList(_cb); }
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
        public IList<LdCollection> PulloutCollection(IList<LdCollectionStatus> collectionStatusList) {
            return HelpPulloutInternally<LdCollectionStatus, LdCollection>(collectionStatusList, new MyInternalPulloutCollectionCallback());
        }
        protected class MyInternalPulloutCollectionCallback : InternalPulloutCallback<LdCollectionStatus, LdCollection> {
            public LdCollection getFr(LdCollectionStatus entity) { return entity.Collection; }
        }
        public IList<LdCollectionStatusLookup> PulloutCollectionStatusLookup(IList<LdCollectionStatus> collectionStatusList) {
            return HelpPulloutInternally<LdCollectionStatus, LdCollectionStatusLookup>(collectionStatusList, new MyInternalPulloutCollectionStatusLookupCallback());
        }
        protected class MyInternalPulloutCollectionStatusLookupCallback : InternalPulloutCallback<LdCollectionStatus, LdCollectionStatusLookup> {
            public LdCollectionStatusLookup getFr(LdCollectionStatus entity) { return entity.CollectionStatusLookup; }
        }
        #endregion


        // ===============================================================================
        //                                                                   Entity Update
        //                                                                   =============
        #region Basic Entity Update
        public virtual void Insert(LdCollectionStatus entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(LdEntity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(LdCollectionStatus entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(LdEntity entity) {
            Update(Downcast(entity));
        }

        public virtual void UpdateNonstrict(LdCollectionStatus entity) {
            AssertEntityNotNull(entity);
            int updatedCount = this.DelegateUpdateNonstrict(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        public void InsertOrUpdate(LdCollectionStatus entity) {
            HelpInsertOrUpdateInternally<LdCollectionStatus, LdCollectionStatusCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<LdCollectionStatus, LdCollectionStatusCB> {
            protected LdCollectionStatusBhv _bhv;
            public MyInternalInsertOrUpdateCallback(LdCollectionStatusBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(LdCollectionStatus entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(LdCollectionStatus entity) { _bhv.Update(entity); }
            public LdCollectionStatusCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(LdCollectionStatusCB cb, LdCollectionStatus entity) {
                cb.Query().SetCollectionId_Equal(entity.CollectionId);
            }
            public int CallbackSelectCount(LdCollectionStatusCB cb) { return _bhv.SelectCount(cb); }
        }

        public void InsertOrUpdateNonstrict(LdCollectionStatus entity) {
            HelpInsertOrUpdateInternally<LdCollectionStatus>(entity, new MyInternalInsertOrUpdateNonstrictCallback(this));
        }
        protected class MyInternalInsertOrUpdateNonstrictCallback : InternalInsertOrUpdateNonstrictCallback<LdCollectionStatus> {
            protected LdCollectionStatusBhv _bhv;
            public MyInternalInsertOrUpdateNonstrictCallback(LdCollectionStatusBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(LdCollectionStatus entity) { _bhv.Insert(entity); }
            public void CallbackUpdateNonstrict(LdCollectionStatus entity) { _bhv.UpdateNonstrict(entity); }
        }

        public virtual void Delete(LdCollectionStatus entity) {
            HelpDeleteInternally<LdCollectionStatus>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(LdEntity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<LdCollectionStatus> {
            protected LdCollectionStatusBhv _bhv;
            public MyInternalDeleteCallback(LdCollectionStatusBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(LdCollectionStatus entity) { return _bhv.DelegateDelete(entity); }
        }

        public virtual void DeleteNonstrict(LdCollectionStatus entity) {
            HelpDeleteNonstrictInternally<LdCollectionStatus>(entity, new MyInternalDeleteNonstrictCallback(this));
        }
        protected class MyInternalDeleteNonstrictCallback : InternalDeleteNonstrictCallback<LdCollectionStatus> {
            protected LdCollectionStatusBhv _bhv;
            public MyInternalDeleteNonstrictCallback(LdCollectionStatusBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDeleteNonstrict(LdCollectionStatus entity) { return _bhv.DelegateDeleteNonstrict(entity); }
        }

        public virtual void DeleteNonstrictIgnoreDeleted(LdCollectionStatus entity) {
            HelpDeleteNonstrictIgnoreDeletedInternally<LdCollectionStatus>(entity, new MyInternalDeleteNonstrictIgnoreDeletedCallback(this));
        }
        protected class MyInternalDeleteNonstrictIgnoreDeletedCallback : InternalDeleteNonstrictIgnoreDeletedCallback<LdCollectionStatus> {
            protected LdCollectionStatusBhv _bhv;
            public MyInternalDeleteNonstrictIgnoreDeletedCallback(LdCollectionStatusBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDeleteNonstrict(LdCollectionStatus entity) { return _bhv.DelegateDeleteNonstrict(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(LdCollectionStatus collectionStatus, LdCollectionStatusCB cb) {
            AssertObjectNotNull("collectionStatus", collectionStatus); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(collectionStatus);
            FilterEntityOfUpdate(collectionStatus); AssertEntityOfUpdate(collectionStatus);
            return this.Dao.UpdateByQuery(cb, collectionStatus);
        }

        public int QueryDelete(LdCollectionStatusCB cb) {
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
        protected int DelegateSelectCount(LdCollectionStatusCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<LdCollectionStatus> DelegateSelectList(LdCollectionStatusCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(LdCollectionStatus e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(LdCollectionStatus e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateModifiedOnly(e); }
        protected int DelegateUpdateNonstrict(LdCollectionStatus e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(LdCollectionStatus e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.Delete(e); }
        protected int DelegateDeleteNonstrict(LdCollectionStatus e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected LdCollectionStatus Downcast(LdEntity entity) {
            return (LdCollectionStatus)entity;
        }

        protected LdCollectionStatusCB Downcast(LdConditionBean cb) {
            return (LdCollectionStatusCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual LdCollectionStatusDao Dao { get { return _dao; } set { _dao = value; } }
    }
}

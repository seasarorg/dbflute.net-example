
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
    public partial class LdCollectionBhv : DfExample.DBFlute.LibraryDb.AllCommon.Bhv.LdAbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected LdCollectionDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public LdCollectionBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "collection"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override LdDBMeta DBMeta { get { return LdCollectionDbm.GetInstance(); } }
        public LdCollectionDbm MyDBMeta { get { return LdCollectionDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override LdEntity NewEntity() { return NewMyEntity(); }
        public override LdConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual LdCollection NewMyEntity() { return new LdCollection(); }
        public virtual LdCollectionCB NewMyConditionBean() { return new LdCollectionCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(LdCollectionCB cb) {
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
        public virtual LdCollection SelectEntity(LdCollectionCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<LdCollection> ls = null;
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
            return (LdCollection)ls[0];
        }

        protected override LdEntity DoReadEntity(LdConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual LdCollection SelectEntityWithDeletedCheck(LdCollectionCB cb) {
            AssertConditionBeanNotNull(cb);
            LdCollection entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override LdEntity DoReadEntityWithDeletedCheck(LdConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual LdCollection SelectByPKValue(int? collectionId) {
            return SelectEntity(BuildPKCB(collectionId));
        }

        public virtual LdCollection SelectByPKValueWithDeletedCheck(int? collectionId) {
            return SelectEntityWithDeletedCheck(BuildPKCB(collectionId));
        }

        private LdCollectionCB BuildPKCB(int? collectionId) {
            AssertObjectNotNull("collectionId", collectionId);
            LdCollectionCB cb = NewMyConditionBean();
            cb.Query().SetCollectionId_Equal(collectionId);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual LdListResultBean<LdCollection> SelectList(LdCollectionCB cb) {
            AssertConditionBeanNotNull(cb);
            return new LdResultBeanBuilder<LdCollection>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual LdPagingResultBean<LdCollection> SelectPage(LdCollectionCB cb) {
            AssertConditionBeanNotNull(cb);
            LdPagingInvoker<LdCollection> invoker = new LdPagingInvoker<LdCollection>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : LdPagingHandler<LdCollection> {
            protected LdCollectionBhv _bhv; protected LdCollectionCB _cb;
            public InternalSelectPagingHandler(LdCollectionBhv bhv, LdCollectionCB cb) { _bhv = bhv; _cb = cb; }
            public LdPagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<LdCollection> Paging() { return _bhv.SelectList(_cb); }
        }
        #endregion

        // ===============================================================================
        //                                                                   Load Referrer
        //                                                                   =============
        #region Load Referrer
        public virtual void LoadLendingCollectionList(LdCollection collection, LdConditionBeanSetupper<LdLendingCollectionCB> conditionBeanSetupper) {
            AssertObjectNotNull("collection", collection); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadLendingCollectionList(xnewLRLs<LdCollection>(collection), conditionBeanSetupper);
        }
        public virtual void LoadLendingCollectionList(IList<LdCollection> collectionList, LdConditionBeanSetupper<LdLendingCollectionCB> conditionBeanSetupper) {
            AssertObjectNotNull("collectionList", collectionList); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadLendingCollectionList(collectionList, new LdLoadReferrerOption<LdLendingCollectionCB, LdLendingCollection>().xinit(conditionBeanSetupper));
        }
        public virtual void LoadLendingCollectionList(LdCollection collection, LdLoadReferrerOption<LdLendingCollectionCB, LdLendingCollection> loadReferrerOption) {
            AssertObjectNotNull("collection", collection); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            LoadLendingCollectionList(xnewLRLs<LdCollection>(collection), loadReferrerOption);
        }
        public virtual void LoadLendingCollectionList(IList<LdCollection> collectionList, LdLoadReferrerOption<LdLendingCollectionCB, LdLendingCollection> loadReferrerOption) {
            AssertObjectNotNull("collectionList", collectionList); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            if (collectionList.Count == 0) { return; }
            LdLendingCollectionBhv referrerBhv = xgetBSFLR().Select<LdLendingCollectionBhv>();
            HelpLoadReferrerInternally<LdCollection, int?, LdLendingCollectionCB, LdLendingCollection>
                    (collectionList, loadReferrerOption, new MyInternalLoadLendingCollectionListCallback(referrerBhv));
        }
        protected class MyInternalLoadLendingCollectionListCallback : InternalLoadReferrerCallback<LdCollection, int?, LdLendingCollectionCB, LdLendingCollection> {
            protected LdLendingCollectionBhv referrerBhv;
            public MyInternalLoadLendingCollectionListCallback(LdLendingCollectionBhv referrerBhv) { this.referrerBhv = referrerBhv; }
            public int? getPKVal(LdCollection e) { return e.CollectionId; }
            public void setRfLs(LdCollection e, IList<LdLendingCollection> ls) { e.LendingCollectionList = ls; }
            public LdLendingCollectionCB newMyCB() { return referrerBhv.NewMyConditionBean(); }
            public void qyFKIn(LdLendingCollectionCB cb, IList<int?> ls) { cb.Query().SetCollectionId_InScope(ls); }
            public void qyOdFKAsc(LdLendingCollectionCB cb) { cb.Query().AddOrderBy_CollectionId_Asc(); }
            public void spFKCol(LdLendingCollectionCB cb) { cb.Specify().ColumnCollectionId(); }
            public IList<LdLendingCollection> selRfLs(LdLendingCollectionCB cb) { return referrerBhv.SelectList(cb); }
            public int? getFKVal(LdLendingCollection e) { return e.CollectionId; }
            public void setlcEt(LdLendingCollection re, LdCollection be) { re.Collection = be; }
        }
        #endregion

        // ===============================================================================
        //                                                                Pull out Foreign
        //                                                                ================
        #region Pullout Foreign
        public IList<LdBook> PulloutBook(IList<LdCollection> collectionList) {
            return HelpPulloutInternally<LdCollection, LdBook>(collectionList, new MyInternalPulloutBookCallback());
        }
        protected class MyInternalPulloutBookCallback : InternalPulloutCallback<LdCollection, LdBook> {
            public LdBook getFr(LdCollection entity) { return entity.Book; }
        }
        public IList<LdLibrary> PulloutLibrary(IList<LdCollection> collectionList) {
            return HelpPulloutInternally<LdCollection, LdLibrary>(collectionList, new MyInternalPulloutLibraryCallback());
        }
        protected class MyInternalPulloutLibraryCallback : InternalPulloutCallback<LdCollection, LdLibrary> {
            public LdLibrary getFr(LdCollection entity) { return entity.Library; }
        }
        public IList<LdCollectionStatus> PulloutCollectionStatusAsOne(IList<LdCollection> collectionList) {
            return HelpPulloutInternally<LdCollection, LdCollectionStatus>(collectionList, new MyInternalPulloutCollectionStatusListCallback());
        }
        protected class MyInternalPulloutCollectionStatusListCallback : InternalPulloutCallback<LdCollection, LdCollectionStatus> {
            public LdCollectionStatus getFr(LdCollection entity) { return entity.CollectionStatusAsOne; }
        }
        #endregion


        // ===============================================================================
        //                                                                   Entity Update
        //                                                                   =============
        #region Basic Entity Update
        public virtual void Insert(LdCollection entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(LdEntity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(LdCollection entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(LdEntity entity) {
            Update(Downcast(entity));
        }

        public virtual void UpdateNonstrict(LdCollection entity) {
            AssertEntityNotNull(entity);
            int updatedCount = this.DelegateUpdateNonstrict(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        public void InsertOrUpdate(LdCollection entity) {
            HelpInsertOrUpdateInternally<LdCollection, LdCollectionCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<LdCollection, LdCollectionCB> {
            protected LdCollectionBhv _bhv;
            public MyInternalInsertOrUpdateCallback(LdCollectionBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(LdCollection entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(LdCollection entity) { _bhv.Update(entity); }
            public LdCollectionCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(LdCollectionCB cb, LdCollection entity) {
                cb.Query().SetCollectionId_Equal(entity.CollectionId);
            }
            public int CallbackSelectCount(LdCollectionCB cb) { return _bhv.SelectCount(cb); }
        }

        public void InsertOrUpdateNonstrict(LdCollection entity) {
            HelpInsertOrUpdateInternally<LdCollection>(entity, new MyInternalInsertOrUpdateNonstrictCallback(this));
        }
        protected class MyInternalInsertOrUpdateNonstrictCallback : InternalInsertOrUpdateNonstrictCallback<LdCollection> {
            protected LdCollectionBhv _bhv;
            public MyInternalInsertOrUpdateNonstrictCallback(LdCollectionBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(LdCollection entity) { _bhv.Insert(entity); }
            public void CallbackUpdateNonstrict(LdCollection entity) { _bhv.UpdateNonstrict(entity); }
        }

        public virtual void Delete(LdCollection entity) {
            HelpDeleteInternally<LdCollection>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(LdEntity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<LdCollection> {
            protected LdCollectionBhv _bhv;
            public MyInternalDeleteCallback(LdCollectionBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(LdCollection entity) { return _bhv.DelegateDelete(entity); }
        }

        public virtual void DeleteNonstrict(LdCollection entity) {
            HelpDeleteNonstrictInternally<LdCollection>(entity, new MyInternalDeleteNonstrictCallback(this));
        }
        protected class MyInternalDeleteNonstrictCallback : InternalDeleteNonstrictCallback<LdCollection> {
            protected LdCollectionBhv _bhv;
            public MyInternalDeleteNonstrictCallback(LdCollectionBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDeleteNonstrict(LdCollection entity) { return _bhv.DelegateDeleteNonstrict(entity); }
        }

        public virtual void DeleteNonstrictIgnoreDeleted(LdCollection entity) {
            HelpDeleteNonstrictIgnoreDeletedInternally<LdCollection>(entity, new MyInternalDeleteNonstrictIgnoreDeletedCallback(this));
        }
        protected class MyInternalDeleteNonstrictIgnoreDeletedCallback : InternalDeleteNonstrictIgnoreDeletedCallback<LdCollection> {
            protected LdCollectionBhv _bhv;
            public MyInternalDeleteNonstrictIgnoreDeletedCallback(LdCollectionBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDeleteNonstrict(LdCollection entity) { return _bhv.DelegateDeleteNonstrict(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(LdCollection collection, LdCollectionCB cb) {
            AssertObjectNotNull("collection", collection); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(collection);
            FilterEntityOfUpdate(collection); AssertEntityOfUpdate(collection);
            return this.Dao.UpdateByQuery(cb, collection);
        }

        public int QueryDelete(LdCollectionCB cb) {
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
        protected int DelegateSelectCount(LdCollectionCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<LdCollection> DelegateSelectList(LdCollectionCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(LdCollection e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(LdCollection e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateModifiedOnly(e); }
        protected int DelegateUpdateNonstrict(LdCollection e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(LdCollection e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.Delete(e); }
        protected int DelegateDeleteNonstrict(LdCollection e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected LdCollection Downcast(LdEntity entity) {
            return (LdCollection)entity;
        }

        protected LdCollectionCB Downcast(LdConditionBean cb) {
            return (LdCollectionCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual LdCollectionDao Dao { get { return _dao; } set { _dao = value; } }
    }
}

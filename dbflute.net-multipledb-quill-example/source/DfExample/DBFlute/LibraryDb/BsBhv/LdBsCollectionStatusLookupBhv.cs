
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
    public partial class LdCollectionStatusLookupBhv : DfExample.DBFlute.LibraryDb.AllCommon.Bhv.LdAbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected LdCollectionStatusLookupDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public LdCollectionStatusLookupBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "collection_status_lookup"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override LdDBMeta DBMeta { get { return LdCollectionStatusLookupDbm.GetInstance(); } }
        public LdCollectionStatusLookupDbm MyDBMeta { get { return LdCollectionStatusLookupDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override LdEntity NewEntity() { return NewMyEntity(); }
        public override LdConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual LdCollectionStatusLookup NewMyEntity() { return new LdCollectionStatusLookup(); }
        public virtual LdCollectionStatusLookupCB NewMyConditionBean() { return new LdCollectionStatusLookupCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(LdCollectionStatusLookupCB cb) {
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
        public virtual LdCollectionStatusLookup SelectEntity(LdCollectionStatusLookupCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<LdCollectionStatusLookup> ls = null;
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
            return (LdCollectionStatusLookup)ls[0];
        }

        protected override LdEntity DoReadEntity(LdConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual LdCollectionStatusLookup SelectEntityWithDeletedCheck(LdCollectionStatusLookupCB cb) {
            AssertConditionBeanNotNull(cb);
            LdCollectionStatusLookup entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override LdEntity DoReadEntityWithDeletedCheck(LdConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual LdCollectionStatusLookup SelectByPKValue(String collectionStatusCode) {
            return SelectEntity(BuildPKCB(collectionStatusCode));
        }

        public virtual LdCollectionStatusLookup SelectByPKValueWithDeletedCheck(String collectionStatusCode) {
            return SelectEntityWithDeletedCheck(BuildPKCB(collectionStatusCode));
        }

        private LdCollectionStatusLookupCB BuildPKCB(String collectionStatusCode) {
            AssertObjectNotNull("collectionStatusCode", collectionStatusCode);
            LdCollectionStatusLookupCB cb = NewMyConditionBean();
            cb.Query().SetCollectionStatusCode_Equal(collectionStatusCode);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual LdListResultBean<LdCollectionStatusLookup> SelectList(LdCollectionStatusLookupCB cb) {
            AssertConditionBeanNotNull(cb);
            return new LdResultBeanBuilder<LdCollectionStatusLookup>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual LdPagingResultBean<LdCollectionStatusLookup> SelectPage(LdCollectionStatusLookupCB cb) {
            AssertConditionBeanNotNull(cb);
            LdPagingInvoker<LdCollectionStatusLookup> invoker = new LdPagingInvoker<LdCollectionStatusLookup>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : LdPagingHandler<LdCollectionStatusLookup> {
            protected LdCollectionStatusLookupBhv _bhv; protected LdCollectionStatusLookupCB _cb;
            public InternalSelectPagingHandler(LdCollectionStatusLookupBhv bhv, LdCollectionStatusLookupCB cb) { _bhv = bhv; _cb = cb; }
            public LdPagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<LdCollectionStatusLookup> Paging() { return _bhv.SelectList(_cb); }
        }
        #endregion

        // ===============================================================================
        //                                                                   Load Referrer
        //                                                                   =============
        #region Load Referrer
        public virtual void LoadCollectionStatusList(LdCollectionStatusLookup collectionStatusLookup, LdConditionBeanSetupper<LdCollectionStatusCB> conditionBeanSetupper) {
            AssertObjectNotNull("collectionStatusLookup", collectionStatusLookup); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadCollectionStatusList(xnewLRLs<LdCollectionStatusLookup>(collectionStatusLookup), conditionBeanSetupper);
        }
        public virtual void LoadCollectionStatusList(IList<LdCollectionStatusLookup> collectionStatusLookupList, LdConditionBeanSetupper<LdCollectionStatusCB> conditionBeanSetupper) {
            AssertObjectNotNull("collectionStatusLookupList", collectionStatusLookupList); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadCollectionStatusList(collectionStatusLookupList, new LdLoadReferrerOption<LdCollectionStatusCB, LdCollectionStatus>().xinit(conditionBeanSetupper));
        }
        public virtual void LoadCollectionStatusList(LdCollectionStatusLookup collectionStatusLookup, LdLoadReferrerOption<LdCollectionStatusCB, LdCollectionStatus> loadReferrerOption) {
            AssertObjectNotNull("collectionStatusLookup", collectionStatusLookup); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            LoadCollectionStatusList(xnewLRLs<LdCollectionStatusLookup>(collectionStatusLookup), loadReferrerOption);
        }
        public virtual void LoadCollectionStatusList(IList<LdCollectionStatusLookup> collectionStatusLookupList, LdLoadReferrerOption<LdCollectionStatusCB, LdCollectionStatus> loadReferrerOption) {
            AssertObjectNotNull("collectionStatusLookupList", collectionStatusLookupList); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            if (collectionStatusLookupList.Count == 0) { return; }
            LdCollectionStatusBhv referrerBhv = xgetBSFLR().Select<LdCollectionStatusBhv>();
            HelpLoadReferrerInternally<LdCollectionStatusLookup, String, LdCollectionStatusCB, LdCollectionStatus>
                    (collectionStatusLookupList, loadReferrerOption, new MyInternalLoadCollectionStatusListCallback(referrerBhv));
        }
        protected class MyInternalLoadCollectionStatusListCallback : InternalLoadReferrerCallback<LdCollectionStatusLookup, String, LdCollectionStatusCB, LdCollectionStatus> {
            protected LdCollectionStatusBhv referrerBhv;
            public MyInternalLoadCollectionStatusListCallback(LdCollectionStatusBhv referrerBhv) { this.referrerBhv = referrerBhv; }
            public String getPKVal(LdCollectionStatusLookup e) { return e.CollectionStatusCode; }
            public void setRfLs(LdCollectionStatusLookup e, IList<LdCollectionStatus> ls) { e.CollectionStatusList = ls; }
            public LdCollectionStatusCB newMyCB() { return referrerBhv.NewMyConditionBean(); }
            public void qyFKIn(LdCollectionStatusCB cb, IList<String> ls) { cb.Query().SetCollectionStatusCode_InScope(ls); }
            public void qyOdFKAsc(LdCollectionStatusCB cb) { cb.Query().AddOrderBy_CollectionStatusCode_Asc(); }
            public void spFKCol(LdCollectionStatusCB cb) { cb.Specify().ColumnCollectionStatusCode(); }
            public IList<LdCollectionStatus> selRfLs(LdCollectionStatusCB cb) { return referrerBhv.SelectList(cb); }
            public String getFKVal(LdCollectionStatus e) { return e.CollectionStatusCode; }
            public void setlcEt(LdCollectionStatus re, LdCollectionStatusLookup be) { re.CollectionStatusLookup = be; }
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
        public virtual void Insert(LdCollectionStatusLookup entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(LdEntity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(LdCollectionStatusLookup entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(LdEntity entity) {
            Update(Downcast(entity));
        }

        public virtual void UpdateNonstrict(LdCollectionStatusLookup entity) {
            AssertEntityNotNull(entity);
            int updatedCount = this.DelegateUpdateNonstrict(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        public void InsertOrUpdate(LdCollectionStatusLookup entity) {
            HelpInsertOrUpdateInternally<LdCollectionStatusLookup, LdCollectionStatusLookupCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<LdCollectionStatusLookup, LdCollectionStatusLookupCB> {
            protected LdCollectionStatusLookupBhv _bhv;
            public MyInternalInsertOrUpdateCallback(LdCollectionStatusLookupBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(LdCollectionStatusLookup entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(LdCollectionStatusLookup entity) { _bhv.Update(entity); }
            public LdCollectionStatusLookupCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(LdCollectionStatusLookupCB cb, LdCollectionStatusLookup entity) {
                cb.Query().SetCollectionStatusCode_Equal(entity.CollectionStatusCode);
            }
            public int CallbackSelectCount(LdCollectionStatusLookupCB cb) { return _bhv.SelectCount(cb); }
        }

        public void InsertOrUpdateNonstrict(LdCollectionStatusLookup entity) {
            HelpInsertOrUpdateInternally<LdCollectionStatusLookup>(entity, new MyInternalInsertOrUpdateNonstrictCallback(this));
        }
        protected class MyInternalInsertOrUpdateNonstrictCallback : InternalInsertOrUpdateNonstrictCallback<LdCollectionStatusLookup> {
            protected LdCollectionStatusLookupBhv _bhv;
            public MyInternalInsertOrUpdateNonstrictCallback(LdCollectionStatusLookupBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(LdCollectionStatusLookup entity) { _bhv.Insert(entity); }
            public void CallbackUpdateNonstrict(LdCollectionStatusLookup entity) { _bhv.UpdateNonstrict(entity); }
        }

        public virtual void Delete(LdCollectionStatusLookup entity) {
            HelpDeleteInternally<LdCollectionStatusLookup>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(LdEntity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<LdCollectionStatusLookup> {
            protected LdCollectionStatusLookupBhv _bhv;
            public MyInternalDeleteCallback(LdCollectionStatusLookupBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(LdCollectionStatusLookup entity) { return _bhv.DelegateDelete(entity); }
        }

        public virtual void DeleteNonstrict(LdCollectionStatusLookup entity) {
            HelpDeleteNonstrictInternally<LdCollectionStatusLookup>(entity, new MyInternalDeleteNonstrictCallback(this));
        }
        protected class MyInternalDeleteNonstrictCallback : InternalDeleteNonstrictCallback<LdCollectionStatusLookup> {
            protected LdCollectionStatusLookupBhv _bhv;
            public MyInternalDeleteNonstrictCallback(LdCollectionStatusLookupBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDeleteNonstrict(LdCollectionStatusLookup entity) { return _bhv.DelegateDeleteNonstrict(entity); }
        }

        public virtual void DeleteNonstrictIgnoreDeleted(LdCollectionStatusLookup entity) {
            HelpDeleteNonstrictIgnoreDeletedInternally<LdCollectionStatusLookup>(entity, new MyInternalDeleteNonstrictIgnoreDeletedCallback(this));
        }
        protected class MyInternalDeleteNonstrictIgnoreDeletedCallback : InternalDeleteNonstrictIgnoreDeletedCallback<LdCollectionStatusLookup> {
            protected LdCollectionStatusLookupBhv _bhv;
            public MyInternalDeleteNonstrictIgnoreDeletedCallback(LdCollectionStatusLookupBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDeleteNonstrict(LdCollectionStatusLookup entity) { return _bhv.DelegateDeleteNonstrict(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(LdCollectionStatusLookup collectionStatusLookup, LdCollectionStatusLookupCB cb) {
            AssertObjectNotNull("collectionStatusLookup", collectionStatusLookup); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(collectionStatusLookup);
            FilterEntityOfUpdate(collectionStatusLookup); AssertEntityOfUpdate(collectionStatusLookup);
            return this.Dao.UpdateByQuery(cb, collectionStatusLookup);
        }

        public int QueryDelete(LdCollectionStatusLookupCB cb) {
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
        protected int DelegateSelectCount(LdCollectionStatusLookupCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<LdCollectionStatusLookup> DelegateSelectList(LdCollectionStatusLookupCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(LdCollectionStatusLookup e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(LdCollectionStatusLookup e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateModifiedOnly(e); }
        protected int DelegateUpdateNonstrict(LdCollectionStatusLookup e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(LdCollectionStatusLookup e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.Delete(e); }
        protected int DelegateDeleteNonstrict(LdCollectionStatusLookup e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected LdCollectionStatusLookup Downcast(LdEntity entity) {
            return (LdCollectionStatusLookup)entity;
        }

        protected LdCollectionStatusLookupCB Downcast(LdConditionBean cb) {
            return (LdCollectionStatusLookupCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual LdCollectionStatusLookupDao Dao { get { return _dao; } set { _dao = value; } }
    }
}

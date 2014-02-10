
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
    public partial class LdLibraryBhv : DfExample.DBFlute.LibraryDb.AllCommon.Bhv.LdAbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected LdLibraryDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public LdLibraryBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "library"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override LdDBMeta DBMeta { get { return LdLibraryDbm.GetInstance(); } }
        public LdLibraryDbm MyDBMeta { get { return LdLibraryDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override LdEntity NewEntity() { return NewMyEntity(); }
        public override LdConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual LdLibrary NewMyEntity() { return new LdLibrary(); }
        public virtual LdLibraryCB NewMyConditionBean() { return new LdLibraryCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(LdLibraryCB cb) {
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
        public virtual LdLibrary SelectEntity(LdLibraryCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<LdLibrary> ls = null;
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
            return (LdLibrary)ls[0];
        }

        protected override LdEntity DoReadEntity(LdConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual LdLibrary SelectEntityWithDeletedCheck(LdLibraryCB cb) {
            AssertConditionBeanNotNull(cb);
            LdLibrary entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override LdEntity DoReadEntityWithDeletedCheck(LdConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual LdLibrary SelectByPKValue(int? libraryId) {
            return SelectEntity(BuildPKCB(libraryId));
        }

        public virtual LdLibrary SelectByPKValueWithDeletedCheck(int? libraryId) {
            return SelectEntityWithDeletedCheck(BuildPKCB(libraryId));
        }

        private LdLibraryCB BuildPKCB(int? libraryId) {
            AssertObjectNotNull("libraryId", libraryId);
            LdLibraryCB cb = NewMyConditionBean();
            cb.Query().SetLibraryId_Equal(libraryId);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual LdListResultBean<LdLibrary> SelectList(LdLibraryCB cb) {
            AssertConditionBeanNotNull(cb);
            return new LdResultBeanBuilder<LdLibrary>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual LdPagingResultBean<LdLibrary> SelectPage(LdLibraryCB cb) {
            AssertConditionBeanNotNull(cb);
            LdPagingInvoker<LdLibrary> invoker = new LdPagingInvoker<LdLibrary>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : LdPagingHandler<LdLibrary> {
            protected LdLibraryBhv _bhv; protected LdLibraryCB _cb;
            public InternalSelectPagingHandler(LdLibraryBhv bhv, LdLibraryCB cb) { _bhv = bhv; _cb = cb; }
            public LdPagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<LdLibrary> Paging() { return _bhv.SelectList(_cb); }
        }
        #endregion

        // ===============================================================================
        //                                                                   Load Referrer
        //                                                                   =============
        #region Load Referrer
        public virtual void LoadCollectionList(LdLibrary library, LdConditionBeanSetupper<LdCollectionCB> conditionBeanSetupper) {
            AssertObjectNotNull("library", library); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadCollectionList(xnewLRLs<LdLibrary>(library), conditionBeanSetupper);
        }
        public virtual void LoadCollectionList(IList<LdLibrary> libraryList, LdConditionBeanSetupper<LdCollectionCB> conditionBeanSetupper) {
            AssertObjectNotNull("libraryList", libraryList); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadCollectionList(libraryList, new LdLoadReferrerOption<LdCollectionCB, LdCollection>().xinit(conditionBeanSetupper));
        }
        public virtual void LoadCollectionList(LdLibrary library, LdLoadReferrerOption<LdCollectionCB, LdCollection> loadReferrerOption) {
            AssertObjectNotNull("library", library); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            LoadCollectionList(xnewLRLs<LdLibrary>(library), loadReferrerOption);
        }
        public virtual void LoadCollectionList(IList<LdLibrary> libraryList, LdLoadReferrerOption<LdCollectionCB, LdCollection> loadReferrerOption) {
            AssertObjectNotNull("libraryList", libraryList); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            if (libraryList.Count == 0) { return; }
            LdCollectionBhv referrerBhv = xgetBSFLR().Select<LdCollectionBhv>();
            HelpLoadReferrerInternally<LdLibrary, int?, LdCollectionCB, LdCollection>
                    (libraryList, loadReferrerOption, new MyInternalLoadCollectionListCallback(referrerBhv));
        }
        protected class MyInternalLoadCollectionListCallback : InternalLoadReferrerCallback<LdLibrary, int?, LdCollectionCB, LdCollection> {
            protected LdCollectionBhv referrerBhv;
            public MyInternalLoadCollectionListCallback(LdCollectionBhv referrerBhv) { this.referrerBhv = referrerBhv; }
            public int? getPKVal(LdLibrary e) { return e.LibraryId; }
            public void setRfLs(LdLibrary e, IList<LdCollection> ls) { e.CollectionList = ls; }
            public LdCollectionCB newMyCB() { return referrerBhv.NewMyConditionBean(); }
            public void qyFKIn(LdCollectionCB cb, IList<int?> ls) { cb.Query().SetLibraryId_InScope(ls); }
            public void qyOdFKAsc(LdCollectionCB cb) { cb.Query().AddOrderBy_LibraryId_Asc(); }
            public void spFKCol(LdCollectionCB cb) { cb.Specify().ColumnLibraryId(); }
            public IList<LdCollection> selRfLs(LdCollectionCB cb) { return referrerBhv.SelectList(cb); }
            public int? getFKVal(LdCollection e) { return e.LibraryId; }
            public void setlcEt(LdCollection re, LdLibrary be) { re.Library = be; }
        }
        public virtual void LoadLibraryUserList(LdLibrary library, LdConditionBeanSetupper<LdLibraryUserCB> conditionBeanSetupper) {
            AssertObjectNotNull("library", library); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadLibraryUserList(xnewLRLs<LdLibrary>(library), conditionBeanSetupper);
        }
        public virtual void LoadLibraryUserList(IList<LdLibrary> libraryList, LdConditionBeanSetupper<LdLibraryUserCB> conditionBeanSetupper) {
            AssertObjectNotNull("libraryList", libraryList); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadLibraryUserList(libraryList, new LdLoadReferrerOption<LdLibraryUserCB, LdLibraryUser>().xinit(conditionBeanSetupper));
        }
        public virtual void LoadLibraryUserList(LdLibrary library, LdLoadReferrerOption<LdLibraryUserCB, LdLibraryUser> loadReferrerOption) {
            AssertObjectNotNull("library", library); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            LoadLibraryUserList(xnewLRLs<LdLibrary>(library), loadReferrerOption);
        }
        public virtual void LoadLibraryUserList(IList<LdLibrary> libraryList, LdLoadReferrerOption<LdLibraryUserCB, LdLibraryUser> loadReferrerOption) {
            AssertObjectNotNull("libraryList", libraryList); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            if (libraryList.Count == 0) { return; }
            LdLibraryUserBhv referrerBhv = xgetBSFLR().Select<LdLibraryUserBhv>();
            HelpLoadReferrerInternally<LdLibrary, int?, LdLibraryUserCB, LdLibraryUser>
                    (libraryList, loadReferrerOption, new MyInternalLoadLibraryUserListCallback(referrerBhv));
        }
        protected class MyInternalLoadLibraryUserListCallback : InternalLoadReferrerCallback<LdLibrary, int?, LdLibraryUserCB, LdLibraryUser> {
            protected LdLibraryUserBhv referrerBhv;
            public MyInternalLoadLibraryUserListCallback(LdLibraryUserBhv referrerBhv) { this.referrerBhv = referrerBhv; }
            public int? getPKVal(LdLibrary e) { return e.LibraryId; }
            public void setRfLs(LdLibrary e, IList<LdLibraryUser> ls) { e.LibraryUserList = ls; }
            public LdLibraryUserCB newMyCB() { return referrerBhv.NewMyConditionBean(); }
            public void qyFKIn(LdLibraryUserCB cb, IList<int?> ls) { cb.Query().SetLibraryId_InScope(ls); }
            public void qyOdFKAsc(LdLibraryUserCB cb) { cb.Query().AddOrderBy_LibraryId_Asc(); }
            public void spFKCol(LdLibraryUserCB cb) { cb.Specify().ColumnLibraryId(); }
            public IList<LdLibraryUser> selRfLs(LdLibraryUserCB cb) { return referrerBhv.SelectList(cb); }
            public int? getFKVal(LdLibraryUser e) { return e.LibraryId; }
            public void setlcEt(LdLibraryUser re, LdLibrary be) { re.Library = be; }
        }
        public virtual void LoadNextLibraryByLibraryIdList(LdLibrary library, LdConditionBeanSetupper<LdNextLibraryCB> conditionBeanSetupper) {
            AssertObjectNotNull("library", library); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadNextLibraryByLibraryIdList(xnewLRLs<LdLibrary>(library), conditionBeanSetupper);
        }
        public virtual void LoadNextLibraryByLibraryIdList(IList<LdLibrary> libraryList, LdConditionBeanSetupper<LdNextLibraryCB> conditionBeanSetupper) {
            AssertObjectNotNull("libraryList", libraryList); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadNextLibraryByLibraryIdList(libraryList, new LdLoadReferrerOption<LdNextLibraryCB, LdNextLibrary>().xinit(conditionBeanSetupper));
        }
        public virtual void LoadNextLibraryByLibraryIdList(LdLibrary library, LdLoadReferrerOption<LdNextLibraryCB, LdNextLibrary> loadReferrerOption) {
            AssertObjectNotNull("library", library); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            LoadNextLibraryByLibraryIdList(xnewLRLs<LdLibrary>(library), loadReferrerOption);
        }
        public virtual void LoadNextLibraryByLibraryIdList(IList<LdLibrary> libraryList, LdLoadReferrerOption<LdNextLibraryCB, LdNextLibrary> loadReferrerOption) {
            AssertObjectNotNull("libraryList", libraryList); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            if (libraryList.Count == 0) { return; }
            LdNextLibraryBhv referrerBhv = xgetBSFLR().Select<LdNextLibraryBhv>();
            HelpLoadReferrerInternally<LdLibrary, int?, LdNextLibraryCB, LdNextLibrary>
                    (libraryList, loadReferrerOption, new MyInternalLoadNextLibraryByLibraryIdListCallback(referrerBhv));
        }
        protected class MyInternalLoadNextLibraryByLibraryIdListCallback : InternalLoadReferrerCallback<LdLibrary, int?, LdNextLibraryCB, LdNextLibrary> {
            protected LdNextLibraryBhv referrerBhv;
            public MyInternalLoadNextLibraryByLibraryIdListCallback(LdNextLibraryBhv referrerBhv) { this.referrerBhv = referrerBhv; }
            public int? getPKVal(LdLibrary e) { return e.LibraryId; }
            public void setRfLs(LdLibrary e, IList<LdNextLibrary> ls) { e.NextLibraryByLibraryIdList = ls; }
            public LdNextLibraryCB newMyCB() { return referrerBhv.NewMyConditionBean(); }
            public void qyFKIn(LdNextLibraryCB cb, IList<int?> ls) { cb.Query().SetLibraryId_InScope(ls); }
            public void qyOdFKAsc(LdNextLibraryCB cb) { cb.Query().AddOrderBy_LibraryId_Asc(); }
            public void spFKCol(LdNextLibraryCB cb) { cb.Specify().ColumnLibraryId(); }
            public IList<LdNextLibrary> selRfLs(LdNextLibraryCB cb) { return referrerBhv.SelectList(cb); }
            public int? getFKVal(LdNextLibrary e) { return e.LibraryId; }
            public void setlcEt(LdNextLibrary re, LdLibrary be) { re.LibraryByLibraryId = be; }
        }
        public virtual void LoadNextLibraryByNextLibraryIdList(LdLibrary library, LdConditionBeanSetupper<LdNextLibraryCB> conditionBeanSetupper) {
            AssertObjectNotNull("library", library); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadNextLibraryByNextLibraryIdList(xnewLRLs<LdLibrary>(library), conditionBeanSetupper);
        }
        public virtual void LoadNextLibraryByNextLibraryIdList(IList<LdLibrary> libraryList, LdConditionBeanSetupper<LdNextLibraryCB> conditionBeanSetupper) {
            AssertObjectNotNull("libraryList", libraryList); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadNextLibraryByNextLibraryIdList(libraryList, new LdLoadReferrerOption<LdNextLibraryCB, LdNextLibrary>().xinit(conditionBeanSetupper));
        }
        public virtual void LoadNextLibraryByNextLibraryIdList(LdLibrary library, LdLoadReferrerOption<LdNextLibraryCB, LdNextLibrary> loadReferrerOption) {
            AssertObjectNotNull("library", library); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            LoadNextLibraryByNextLibraryIdList(xnewLRLs<LdLibrary>(library), loadReferrerOption);
        }
        public virtual void LoadNextLibraryByNextLibraryIdList(IList<LdLibrary> libraryList, LdLoadReferrerOption<LdNextLibraryCB, LdNextLibrary> loadReferrerOption) {
            AssertObjectNotNull("libraryList", libraryList); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            if (libraryList.Count == 0) { return; }
            LdNextLibraryBhv referrerBhv = xgetBSFLR().Select<LdNextLibraryBhv>();
            HelpLoadReferrerInternally<LdLibrary, int?, LdNextLibraryCB, LdNextLibrary>
                    (libraryList, loadReferrerOption, new MyInternalLoadNextLibraryByNextLibraryIdListCallback(referrerBhv));
        }
        protected class MyInternalLoadNextLibraryByNextLibraryIdListCallback : InternalLoadReferrerCallback<LdLibrary, int?, LdNextLibraryCB, LdNextLibrary> {
            protected LdNextLibraryBhv referrerBhv;
            public MyInternalLoadNextLibraryByNextLibraryIdListCallback(LdNextLibraryBhv referrerBhv) { this.referrerBhv = referrerBhv; }
            public int? getPKVal(LdLibrary e) { return e.LibraryId; }
            public void setRfLs(LdLibrary e, IList<LdNextLibrary> ls) { e.NextLibraryByNextLibraryIdList = ls; }
            public LdNextLibraryCB newMyCB() { return referrerBhv.NewMyConditionBean(); }
            public void qyFKIn(LdNextLibraryCB cb, IList<int?> ls) { cb.Query().SetNextLibraryId_InScope(ls); }
            public void qyOdFKAsc(LdNextLibraryCB cb) { cb.Query().AddOrderBy_NextLibraryId_Asc(); }
            public void spFKCol(LdNextLibraryCB cb) { cb.Specify().ColumnNextLibraryId(); }
            public IList<LdNextLibrary> selRfLs(LdNextLibraryCB cb) { return referrerBhv.SelectList(cb); }
            public int? getFKVal(LdNextLibrary e) { return e.NextLibraryId; }
            public void setlcEt(LdNextLibrary re, LdLibrary be) { re.LibraryByNextLibraryId = be; }
        }
        #endregion

        // ===============================================================================
        //                                                                Pull out Foreign
        //                                                                ================
        #region Pullout Foreign
        public IList<LdLibraryTypeLookup> PulloutLibraryTypeLookup(IList<LdLibrary> libraryList) {
            return HelpPulloutInternally<LdLibrary, LdLibraryTypeLookup>(libraryList, new MyInternalPulloutLibraryTypeLookupCallback());
        }
        protected class MyInternalPulloutLibraryTypeLookupCallback : InternalPulloutCallback<LdLibrary, LdLibraryTypeLookup> {
            public LdLibraryTypeLookup getFr(LdLibrary entity) { return entity.LibraryTypeLookup; }
        }
        #endregion


        // ===============================================================================
        //                                                                   Entity Update
        //                                                                   =============
        #region Basic Entity Update
        public virtual void Insert(LdLibrary entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(LdEntity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(LdLibrary entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(LdEntity entity) {
            Update(Downcast(entity));
        }

        public virtual void UpdateNonstrict(LdLibrary entity) {
            AssertEntityNotNull(entity);
            int updatedCount = this.DelegateUpdateNonstrict(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        public void InsertOrUpdate(LdLibrary entity) {
            HelpInsertOrUpdateInternally<LdLibrary, LdLibraryCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<LdLibrary, LdLibraryCB> {
            protected LdLibraryBhv _bhv;
            public MyInternalInsertOrUpdateCallback(LdLibraryBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(LdLibrary entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(LdLibrary entity) { _bhv.Update(entity); }
            public LdLibraryCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(LdLibraryCB cb, LdLibrary entity) {
                cb.Query().SetLibraryId_Equal(entity.LibraryId);
            }
            public int CallbackSelectCount(LdLibraryCB cb) { return _bhv.SelectCount(cb); }
        }

        public void InsertOrUpdateNonstrict(LdLibrary entity) {
            HelpInsertOrUpdateInternally<LdLibrary>(entity, new MyInternalInsertOrUpdateNonstrictCallback(this));
        }
        protected class MyInternalInsertOrUpdateNonstrictCallback : InternalInsertOrUpdateNonstrictCallback<LdLibrary> {
            protected LdLibraryBhv _bhv;
            public MyInternalInsertOrUpdateNonstrictCallback(LdLibraryBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(LdLibrary entity) { _bhv.Insert(entity); }
            public void CallbackUpdateNonstrict(LdLibrary entity) { _bhv.UpdateNonstrict(entity); }
        }

        public virtual void Delete(LdLibrary entity) {
            HelpDeleteInternally<LdLibrary>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(LdEntity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<LdLibrary> {
            protected LdLibraryBhv _bhv;
            public MyInternalDeleteCallback(LdLibraryBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(LdLibrary entity) { return _bhv.DelegateDelete(entity); }
        }

        public virtual void DeleteNonstrict(LdLibrary entity) {
            HelpDeleteNonstrictInternally<LdLibrary>(entity, new MyInternalDeleteNonstrictCallback(this));
        }
        protected class MyInternalDeleteNonstrictCallback : InternalDeleteNonstrictCallback<LdLibrary> {
            protected LdLibraryBhv _bhv;
            public MyInternalDeleteNonstrictCallback(LdLibraryBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDeleteNonstrict(LdLibrary entity) { return _bhv.DelegateDeleteNonstrict(entity); }
        }

        public virtual void DeleteNonstrictIgnoreDeleted(LdLibrary entity) {
            HelpDeleteNonstrictIgnoreDeletedInternally<LdLibrary>(entity, new MyInternalDeleteNonstrictIgnoreDeletedCallback(this));
        }
        protected class MyInternalDeleteNonstrictIgnoreDeletedCallback : InternalDeleteNonstrictIgnoreDeletedCallback<LdLibrary> {
            protected LdLibraryBhv _bhv;
            public MyInternalDeleteNonstrictIgnoreDeletedCallback(LdLibraryBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDeleteNonstrict(LdLibrary entity) { return _bhv.DelegateDeleteNonstrict(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(LdLibrary library, LdLibraryCB cb) {
            AssertObjectNotNull("library", library); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(library);
            FilterEntityOfUpdate(library); AssertEntityOfUpdate(library);
            return this.Dao.UpdateByQuery(cb, library);
        }

        public int QueryDelete(LdLibraryCB cb) {
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
        protected int DelegateSelectCount(LdLibraryCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<LdLibrary> DelegateSelectList(LdLibraryCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(LdLibrary e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(LdLibrary e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateModifiedOnly(e); }
        protected int DelegateUpdateNonstrict(LdLibrary e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(LdLibrary e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.Delete(e); }
        protected int DelegateDeleteNonstrict(LdLibrary e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected LdLibrary Downcast(LdEntity entity) {
            return (LdLibrary)entity;
        }

        protected LdLibraryCB Downcast(LdConditionBean cb) {
            return (LdLibraryCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual LdLibraryDao Dao { get { return _dao; } set { _dao = value; } }
    }
}

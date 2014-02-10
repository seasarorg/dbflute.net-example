
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
    public partial class LdNextLibraryBhv : DfExample.DBFlute.LibraryDb.AllCommon.Bhv.LdAbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected LdNextLibraryDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public LdNextLibraryBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "next_library"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override LdDBMeta DBMeta { get { return LdNextLibraryDbm.GetInstance(); } }
        public LdNextLibraryDbm MyDBMeta { get { return LdNextLibraryDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override LdEntity NewEntity() { return NewMyEntity(); }
        public override LdConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual LdNextLibrary NewMyEntity() { return new LdNextLibrary(); }
        public virtual LdNextLibraryCB NewMyConditionBean() { return new LdNextLibraryCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(LdNextLibraryCB cb) {
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
        public virtual LdNextLibrary SelectEntity(LdNextLibraryCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<LdNextLibrary> ls = null;
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
            return (LdNextLibrary)ls[0];
        }

        protected override LdEntity DoReadEntity(LdConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual LdNextLibrary SelectEntityWithDeletedCheck(LdNextLibraryCB cb) {
            AssertConditionBeanNotNull(cb);
            LdNextLibrary entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override LdEntity DoReadEntityWithDeletedCheck(LdConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual LdNextLibrary SelectByPKValue(int? libraryId, int? nextLibraryId) {
            return SelectEntity(BuildPKCB(libraryId, nextLibraryId));
        }

        public virtual LdNextLibrary SelectByPKValueWithDeletedCheck(int? libraryId, int? nextLibraryId) {
            return SelectEntityWithDeletedCheck(BuildPKCB(libraryId, nextLibraryId));
        }

        private LdNextLibraryCB BuildPKCB(int? libraryId, int? nextLibraryId) {
            AssertObjectNotNull("libraryId", libraryId);AssertObjectNotNull("nextLibraryId", nextLibraryId);
            LdNextLibraryCB cb = NewMyConditionBean();
            cb.Query().SetLibraryId_Equal(libraryId);cb.Query().SetNextLibraryId_Equal(nextLibraryId);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual LdListResultBean<LdNextLibrary> SelectList(LdNextLibraryCB cb) {
            AssertConditionBeanNotNull(cb);
            return new LdResultBeanBuilder<LdNextLibrary>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual LdPagingResultBean<LdNextLibrary> SelectPage(LdNextLibraryCB cb) {
            AssertConditionBeanNotNull(cb);
            LdPagingInvoker<LdNextLibrary> invoker = new LdPagingInvoker<LdNextLibrary>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : LdPagingHandler<LdNextLibrary> {
            protected LdNextLibraryBhv _bhv; protected LdNextLibraryCB _cb;
            public InternalSelectPagingHandler(LdNextLibraryBhv bhv, LdNextLibraryCB cb) { _bhv = bhv; _cb = cb; }
            public LdPagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<LdNextLibrary> Paging() { return _bhv.SelectList(_cb); }
        }
        #endregion


        // ===============================================================================
        //                                                                Pull out Foreign
        //                                                                ================
        #region Pullout Foreign
        public IList<LdLibrary> PulloutLibraryByLibraryId(IList<LdNextLibrary> nextLibraryList) {
            return HelpPulloutInternally<LdNextLibrary, LdLibrary>(nextLibraryList, new MyInternalPulloutLibraryByLibraryIdCallback());
        }
        protected class MyInternalPulloutLibraryByLibraryIdCallback : InternalPulloutCallback<LdNextLibrary, LdLibrary> {
            public LdLibrary getFr(LdNextLibrary entity) { return entity.LibraryByLibraryId; }
        }
        public IList<LdLibrary> PulloutLibraryByNextLibraryId(IList<LdNextLibrary> nextLibraryList) {
            return HelpPulloutInternally<LdNextLibrary, LdLibrary>(nextLibraryList, new MyInternalPulloutLibraryByNextLibraryIdCallback());
        }
        protected class MyInternalPulloutLibraryByNextLibraryIdCallback : InternalPulloutCallback<LdNextLibrary, LdLibrary> {
            public LdLibrary getFr(LdNextLibrary entity) { return entity.LibraryByNextLibraryId; }
        }
        #endregion


        // ===============================================================================
        //                                                                   Entity Update
        //                                                                   =============
        #region Basic Entity Update
        public virtual void Insert(LdNextLibrary entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(LdEntity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(LdNextLibrary entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(LdEntity entity) {
            Update(Downcast(entity));
        }

        public virtual void UpdateNonstrict(LdNextLibrary entity) {
            AssertEntityNotNull(entity);
            int updatedCount = this.DelegateUpdateNonstrict(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        public void InsertOrUpdate(LdNextLibrary entity) {
            HelpInsertOrUpdateInternally<LdNextLibrary, LdNextLibraryCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<LdNextLibrary, LdNextLibraryCB> {
            protected LdNextLibraryBhv _bhv;
            public MyInternalInsertOrUpdateCallback(LdNextLibraryBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(LdNextLibrary entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(LdNextLibrary entity) { _bhv.Update(entity); }
            public LdNextLibraryCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(LdNextLibraryCB cb, LdNextLibrary entity) {
                cb.Query().SetLibraryId_Equal(entity.LibraryId);
                cb.Query().SetNextLibraryId_Equal(entity.NextLibraryId);
            }
            public int CallbackSelectCount(LdNextLibraryCB cb) { return _bhv.SelectCount(cb); }
        }

        public void InsertOrUpdateNonstrict(LdNextLibrary entity) {
            HelpInsertOrUpdateInternally<LdNextLibrary>(entity, new MyInternalInsertOrUpdateNonstrictCallback(this));
        }
        protected class MyInternalInsertOrUpdateNonstrictCallback : InternalInsertOrUpdateNonstrictCallback<LdNextLibrary> {
            protected LdNextLibraryBhv _bhv;
            public MyInternalInsertOrUpdateNonstrictCallback(LdNextLibraryBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(LdNextLibrary entity) { _bhv.Insert(entity); }
            public void CallbackUpdateNonstrict(LdNextLibrary entity) { _bhv.UpdateNonstrict(entity); }
        }

        public virtual void Delete(LdNextLibrary entity) {
            HelpDeleteInternally<LdNextLibrary>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(LdEntity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<LdNextLibrary> {
            protected LdNextLibraryBhv _bhv;
            public MyInternalDeleteCallback(LdNextLibraryBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(LdNextLibrary entity) { return _bhv.DelegateDelete(entity); }
        }

        public virtual void DeleteNonstrict(LdNextLibrary entity) {
            HelpDeleteNonstrictInternally<LdNextLibrary>(entity, new MyInternalDeleteNonstrictCallback(this));
        }
        protected class MyInternalDeleteNonstrictCallback : InternalDeleteNonstrictCallback<LdNextLibrary> {
            protected LdNextLibraryBhv _bhv;
            public MyInternalDeleteNonstrictCallback(LdNextLibraryBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDeleteNonstrict(LdNextLibrary entity) { return _bhv.DelegateDeleteNonstrict(entity); }
        }

        public virtual void DeleteNonstrictIgnoreDeleted(LdNextLibrary entity) {
            HelpDeleteNonstrictIgnoreDeletedInternally<LdNextLibrary>(entity, new MyInternalDeleteNonstrictIgnoreDeletedCallback(this));
        }
        protected class MyInternalDeleteNonstrictIgnoreDeletedCallback : InternalDeleteNonstrictIgnoreDeletedCallback<LdNextLibrary> {
            protected LdNextLibraryBhv _bhv;
            public MyInternalDeleteNonstrictIgnoreDeletedCallback(LdNextLibraryBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDeleteNonstrict(LdNextLibrary entity) { return _bhv.DelegateDeleteNonstrict(entity); }
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
        protected int DelegateSelectCount(LdNextLibraryCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<LdNextLibrary> DelegateSelectList(LdNextLibraryCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(LdNextLibrary e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(LdNextLibrary e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateModifiedOnly(e); }
        protected int DelegateUpdateNonstrict(LdNextLibrary e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(LdNextLibrary e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.Delete(e); }
        protected int DelegateDeleteNonstrict(LdNextLibrary e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected LdNextLibrary Downcast(LdEntity entity) {
            return (LdNextLibrary)entity;
        }

        protected LdNextLibraryCB Downcast(LdConditionBean cb) {
            return (LdNextLibraryCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual LdNextLibraryDao Dao { get { return _dao; } set { _dao = value; } }
    }
}

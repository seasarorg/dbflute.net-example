
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
    public partial class LdLendingBhv : DfExample.DBFlute.LibraryDb.AllCommon.Bhv.LdAbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected LdLendingDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public LdLendingBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "lending"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override LdDBMeta DBMeta { get { return LdLendingDbm.GetInstance(); } }
        public LdLendingDbm MyDBMeta { get { return LdLendingDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override LdEntity NewEntity() { return NewMyEntity(); }
        public override LdConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual LdLending NewMyEntity() { return new LdLending(); }
        public virtual LdLendingCB NewMyConditionBean() { return new LdLendingCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(LdLendingCB cb) {
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
        public virtual LdLending SelectEntity(LdLendingCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<LdLending> ls = null;
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
            return (LdLending)ls[0];
        }

        protected override LdEntity DoReadEntity(LdConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual LdLending SelectEntityWithDeletedCheck(LdLendingCB cb) {
            AssertConditionBeanNotNull(cb);
            LdLending entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override LdEntity DoReadEntityWithDeletedCheck(LdConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual LdLending SelectByPKValue(int? libraryId, int? lbUserId, DateTime? lendingDate) {
            return SelectEntity(BuildPKCB(libraryId, lbUserId, lendingDate));
        }

        public virtual LdLending SelectByPKValueWithDeletedCheck(int? libraryId, int? lbUserId, DateTime? lendingDate) {
            return SelectEntityWithDeletedCheck(BuildPKCB(libraryId, lbUserId, lendingDate));
        }

        private LdLendingCB BuildPKCB(int? libraryId, int? lbUserId, DateTime? lendingDate) {
            AssertObjectNotNull("libraryId", libraryId);AssertObjectNotNull("lbUserId", lbUserId);AssertObjectNotNull("lendingDate", lendingDate);
            LdLendingCB cb = NewMyConditionBean();
            cb.Query().SetLibraryId_Equal(libraryId);cb.Query().SetLbUserId_Equal(lbUserId);cb.Query().SetLendingDate_Equal(lendingDate);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual LdListResultBean<LdLending> SelectList(LdLendingCB cb) {
            AssertConditionBeanNotNull(cb);
            return new LdResultBeanBuilder<LdLending>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual LdPagingResultBean<LdLending> SelectPage(LdLendingCB cb) {
            AssertConditionBeanNotNull(cb);
            LdPagingInvoker<LdLending> invoker = new LdPagingInvoker<LdLending>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : LdPagingHandler<LdLending> {
            protected LdLendingBhv _bhv; protected LdLendingCB _cb;
            public InternalSelectPagingHandler(LdLendingBhv bhv, LdLendingCB cb) { _bhv = bhv; _cb = cb; }
            public LdPagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<LdLending> Paging() { return _bhv.SelectList(_cb); }
        }
        #endregion


        // ===============================================================================
        //                                                                Pull out Foreign
        //                                                                ================
        #region Pullout Foreign
        public IList<LdLibraryUser> PulloutLibraryUser(IList<LdLending> lendingList) {
            return HelpPulloutInternally<LdLending, LdLibraryUser>(lendingList, new MyInternalPulloutLibraryUserCallback());
        }
        protected class MyInternalPulloutLibraryUserCallback : InternalPulloutCallback<LdLending, LdLibraryUser> {
            public LdLibraryUser getFr(LdLending entity) { return entity.LibraryUser; }
        }
        #endregion


        // ===============================================================================
        //                                                                   Entity Update
        //                                                                   =============
        #region Basic Entity Update
        public virtual void Insert(LdLending entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(LdEntity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(LdLending entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(LdEntity entity) {
            Update(Downcast(entity));
        }

        public virtual void UpdateNonstrict(LdLending entity) {
            AssertEntityNotNull(entity);
            int updatedCount = this.DelegateUpdateNonstrict(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        public void InsertOrUpdate(LdLending entity) {
            HelpInsertOrUpdateInternally<LdLending, LdLendingCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<LdLending, LdLendingCB> {
            protected LdLendingBhv _bhv;
            public MyInternalInsertOrUpdateCallback(LdLendingBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(LdLending entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(LdLending entity) { _bhv.Update(entity); }
            public LdLendingCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(LdLendingCB cb, LdLending entity) {
                cb.Query().SetLibraryId_Equal(entity.LibraryId);
                cb.Query().SetLbUserId_Equal(entity.LbUserId);
                cb.Query().SetLendingDate_Equal(entity.LendingDate);
            }
            public int CallbackSelectCount(LdLendingCB cb) { return _bhv.SelectCount(cb); }
        }

        public void InsertOrUpdateNonstrict(LdLending entity) {
            HelpInsertOrUpdateInternally<LdLending>(entity, new MyInternalInsertOrUpdateNonstrictCallback(this));
        }
        protected class MyInternalInsertOrUpdateNonstrictCallback : InternalInsertOrUpdateNonstrictCallback<LdLending> {
            protected LdLendingBhv _bhv;
            public MyInternalInsertOrUpdateNonstrictCallback(LdLendingBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(LdLending entity) { _bhv.Insert(entity); }
            public void CallbackUpdateNonstrict(LdLending entity) { _bhv.UpdateNonstrict(entity); }
        }

        public virtual void Delete(LdLending entity) {
            HelpDeleteInternally<LdLending>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(LdEntity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<LdLending> {
            protected LdLendingBhv _bhv;
            public MyInternalDeleteCallback(LdLendingBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(LdLending entity) { return _bhv.DelegateDelete(entity); }
        }

        public virtual void DeleteNonstrict(LdLending entity) {
            HelpDeleteNonstrictInternally<LdLending>(entity, new MyInternalDeleteNonstrictCallback(this));
        }
        protected class MyInternalDeleteNonstrictCallback : InternalDeleteNonstrictCallback<LdLending> {
            protected LdLendingBhv _bhv;
            public MyInternalDeleteNonstrictCallback(LdLendingBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDeleteNonstrict(LdLending entity) { return _bhv.DelegateDeleteNonstrict(entity); }
        }

        public virtual void DeleteNonstrictIgnoreDeleted(LdLending entity) {
            HelpDeleteNonstrictIgnoreDeletedInternally<LdLending>(entity, new MyInternalDeleteNonstrictIgnoreDeletedCallback(this));
        }
        protected class MyInternalDeleteNonstrictIgnoreDeletedCallback : InternalDeleteNonstrictIgnoreDeletedCallback<LdLending> {
            protected LdLendingBhv _bhv;
            public MyInternalDeleteNonstrictIgnoreDeletedCallback(LdLendingBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDeleteNonstrict(LdLending entity) { return _bhv.DelegateDeleteNonstrict(entity); }
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
        protected int DelegateSelectCount(LdLendingCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<LdLending> DelegateSelectList(LdLendingCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(LdLending e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(LdLending e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateModifiedOnly(e); }
        protected int DelegateUpdateNonstrict(LdLending e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(LdLending e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.Delete(e); }
        protected int DelegateDeleteNonstrict(LdLending e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected LdLending Downcast(LdEntity entity) {
            return (LdLending)entity;
        }

        protected LdLendingCB Downcast(LdConditionBean cb) {
            return (LdLendingCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual LdLendingDao Dao { get { return _dao; } set { _dao = value; } }
    }
}

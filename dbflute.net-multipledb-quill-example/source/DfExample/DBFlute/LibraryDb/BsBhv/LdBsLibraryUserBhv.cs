
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
    public partial class LdLibraryUserBhv : DfExample.DBFlute.LibraryDb.AllCommon.Bhv.LdAbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected LdLibraryUserDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public LdLibraryUserBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "library_user"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override LdDBMeta DBMeta { get { return LdLibraryUserDbm.GetInstance(); } }
        public LdLibraryUserDbm MyDBMeta { get { return LdLibraryUserDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override LdEntity NewEntity() { return NewMyEntity(); }
        public override LdConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual LdLibraryUser NewMyEntity() { return new LdLibraryUser(); }
        public virtual LdLibraryUserCB NewMyConditionBean() { return new LdLibraryUserCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(LdLibraryUserCB cb) {
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
        public virtual LdLibraryUser SelectEntity(LdLibraryUserCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<LdLibraryUser> ls = null;
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
            return (LdLibraryUser)ls[0];
        }

        protected override LdEntity DoReadEntity(LdConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual LdLibraryUser SelectEntityWithDeletedCheck(LdLibraryUserCB cb) {
            AssertConditionBeanNotNull(cb);
            LdLibraryUser entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override LdEntity DoReadEntityWithDeletedCheck(LdConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual LdLibraryUser SelectByPKValue(int? libraryId, int? lbUserId) {
            return SelectEntity(BuildPKCB(libraryId, lbUserId));
        }

        public virtual LdLibraryUser SelectByPKValueWithDeletedCheck(int? libraryId, int? lbUserId) {
            return SelectEntityWithDeletedCheck(BuildPKCB(libraryId, lbUserId));
        }

        private LdLibraryUserCB BuildPKCB(int? libraryId, int? lbUserId) {
            AssertObjectNotNull("libraryId", libraryId);AssertObjectNotNull("lbUserId", lbUserId);
            LdLibraryUserCB cb = NewMyConditionBean();
            cb.Query().SetLibraryId_Equal(libraryId);cb.Query().SetLbUserId_Equal(lbUserId);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual LdListResultBean<LdLibraryUser> SelectList(LdLibraryUserCB cb) {
            AssertConditionBeanNotNull(cb);
            return new LdResultBeanBuilder<LdLibraryUser>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual LdPagingResultBean<LdLibraryUser> SelectPage(LdLibraryUserCB cb) {
            AssertConditionBeanNotNull(cb);
            LdPagingInvoker<LdLibraryUser> invoker = new LdPagingInvoker<LdLibraryUser>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : LdPagingHandler<LdLibraryUser> {
            protected LdLibraryUserBhv _bhv; protected LdLibraryUserCB _cb;
            public InternalSelectPagingHandler(LdLibraryUserBhv bhv, LdLibraryUserCB cb) { _bhv = bhv; _cb = cb; }
            public LdPagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<LdLibraryUser> Paging() { return _bhv.SelectList(_cb); }
        }
        #endregion


        // ===============================================================================
        //                                                                Pull out Foreign
        //                                                                ================
        #region Pullout Foreign
        public IList<LdLbUser> PulloutLbUser(IList<LdLibraryUser> libraryUserList) {
            return HelpPulloutInternally<LdLibraryUser, LdLbUser>(libraryUserList, new MyInternalPulloutLbUserCallback());
        }
        protected class MyInternalPulloutLbUserCallback : InternalPulloutCallback<LdLibraryUser, LdLbUser> {
            public LdLbUser getFr(LdLibraryUser entity) { return entity.LbUser; }
        }
        public IList<LdLibrary> PulloutLibrary(IList<LdLibraryUser> libraryUserList) {
            return HelpPulloutInternally<LdLibraryUser, LdLibrary>(libraryUserList, new MyInternalPulloutLibraryCallback());
        }
        protected class MyInternalPulloutLibraryCallback : InternalPulloutCallback<LdLibraryUser, LdLibrary> {
            public LdLibrary getFr(LdLibraryUser entity) { return entity.Library; }
        }
        #endregion


        // ===============================================================================
        //                                                                   Entity Update
        //                                                                   =============
        #region Basic Entity Update
        public virtual void Insert(LdLibraryUser entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(LdEntity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(LdLibraryUser entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(LdEntity entity) {
            Update(Downcast(entity));
        }

        public virtual void UpdateNonstrict(LdLibraryUser entity) {
            AssertEntityNotNull(entity);
            int updatedCount = this.DelegateUpdateNonstrict(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        public void InsertOrUpdate(LdLibraryUser entity) {
            HelpInsertOrUpdateInternally<LdLibraryUser, LdLibraryUserCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<LdLibraryUser, LdLibraryUserCB> {
            protected LdLibraryUserBhv _bhv;
            public MyInternalInsertOrUpdateCallback(LdLibraryUserBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(LdLibraryUser entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(LdLibraryUser entity) { _bhv.Update(entity); }
            public LdLibraryUserCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(LdLibraryUserCB cb, LdLibraryUser entity) {
                cb.Query().SetLibraryId_Equal(entity.LibraryId);
                cb.Query().SetLbUserId_Equal(entity.LbUserId);
            }
            public int CallbackSelectCount(LdLibraryUserCB cb) { return _bhv.SelectCount(cb); }
        }

        public void InsertOrUpdateNonstrict(LdLibraryUser entity) {
            HelpInsertOrUpdateInternally<LdLibraryUser>(entity, new MyInternalInsertOrUpdateNonstrictCallback(this));
        }
        protected class MyInternalInsertOrUpdateNonstrictCallback : InternalInsertOrUpdateNonstrictCallback<LdLibraryUser> {
            protected LdLibraryUserBhv _bhv;
            public MyInternalInsertOrUpdateNonstrictCallback(LdLibraryUserBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(LdLibraryUser entity) { _bhv.Insert(entity); }
            public void CallbackUpdateNonstrict(LdLibraryUser entity) { _bhv.UpdateNonstrict(entity); }
        }

        public virtual void Delete(LdLibraryUser entity) {
            HelpDeleteInternally<LdLibraryUser>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(LdEntity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<LdLibraryUser> {
            protected LdLibraryUserBhv _bhv;
            public MyInternalDeleteCallback(LdLibraryUserBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(LdLibraryUser entity) { return _bhv.DelegateDelete(entity); }
        }

        public virtual void DeleteNonstrict(LdLibraryUser entity) {
            HelpDeleteNonstrictInternally<LdLibraryUser>(entity, new MyInternalDeleteNonstrictCallback(this));
        }
        protected class MyInternalDeleteNonstrictCallback : InternalDeleteNonstrictCallback<LdLibraryUser> {
            protected LdLibraryUserBhv _bhv;
            public MyInternalDeleteNonstrictCallback(LdLibraryUserBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDeleteNonstrict(LdLibraryUser entity) { return _bhv.DelegateDeleteNonstrict(entity); }
        }

        public virtual void DeleteNonstrictIgnoreDeleted(LdLibraryUser entity) {
            HelpDeleteNonstrictIgnoreDeletedInternally<LdLibraryUser>(entity, new MyInternalDeleteNonstrictIgnoreDeletedCallback(this));
        }
        protected class MyInternalDeleteNonstrictIgnoreDeletedCallback : InternalDeleteNonstrictIgnoreDeletedCallback<LdLibraryUser> {
            protected LdLibraryUserBhv _bhv;
            public MyInternalDeleteNonstrictIgnoreDeletedCallback(LdLibraryUserBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDeleteNonstrict(LdLibraryUser entity) { return _bhv.DelegateDeleteNonstrict(entity); }
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
        protected int DelegateSelectCount(LdLibraryUserCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<LdLibraryUser> DelegateSelectList(LdLibraryUserCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(LdLibraryUser e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(LdLibraryUser e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateModifiedOnly(e); }
        protected int DelegateUpdateNonstrict(LdLibraryUser e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(LdLibraryUser e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.Delete(e); }
        protected int DelegateDeleteNonstrict(LdLibraryUser e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected LdLibraryUser Downcast(LdEntity entity) {
            return (LdLibraryUser)entity;
        }

        protected LdLibraryUserCB Downcast(LdConditionBean cb) {
            return (LdLibraryUserCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual LdLibraryUserDao Dao { get { return _dao; } set { _dao = value; } }
    }
}

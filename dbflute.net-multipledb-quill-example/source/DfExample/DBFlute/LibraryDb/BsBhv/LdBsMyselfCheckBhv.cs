
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
    public partial class LdMyselfCheckBhv : DfExample.DBFlute.LibraryDb.AllCommon.Bhv.LdAbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected LdMyselfCheckDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public LdMyselfCheckBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "myself_check"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override LdDBMeta DBMeta { get { return LdMyselfCheckDbm.GetInstance(); } }
        public LdMyselfCheckDbm MyDBMeta { get { return LdMyselfCheckDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override LdEntity NewEntity() { return NewMyEntity(); }
        public override LdConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual LdMyselfCheck NewMyEntity() { return new LdMyselfCheck(); }
        public virtual LdMyselfCheckCB NewMyConditionBean() { return new LdMyselfCheckCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(LdMyselfCheckCB cb) {
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
        public virtual LdMyselfCheck SelectEntity(LdMyselfCheckCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<LdMyselfCheck> ls = null;
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
            return (LdMyselfCheck)ls[0];
        }

        protected override LdEntity DoReadEntity(LdConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual LdMyselfCheck SelectEntityWithDeletedCheck(LdMyselfCheckCB cb) {
            AssertConditionBeanNotNull(cb);
            LdMyselfCheck entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override LdEntity DoReadEntityWithDeletedCheck(LdConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual LdMyselfCheck SelectByPKValue(int? myselfCheckId) {
            return SelectEntity(BuildPKCB(myselfCheckId));
        }

        public virtual LdMyselfCheck SelectByPKValueWithDeletedCheck(int? myselfCheckId) {
            return SelectEntityWithDeletedCheck(BuildPKCB(myselfCheckId));
        }

        private LdMyselfCheckCB BuildPKCB(int? myselfCheckId) {
            AssertObjectNotNull("myselfCheckId", myselfCheckId);
            LdMyselfCheckCB cb = NewMyConditionBean();
            cb.Query().SetMyselfCheckId_Equal(myselfCheckId);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual LdListResultBean<LdMyselfCheck> SelectList(LdMyselfCheckCB cb) {
            AssertConditionBeanNotNull(cb);
            return new LdResultBeanBuilder<LdMyselfCheck>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual LdPagingResultBean<LdMyselfCheck> SelectPage(LdMyselfCheckCB cb) {
            AssertConditionBeanNotNull(cb);
            LdPagingInvoker<LdMyselfCheck> invoker = new LdPagingInvoker<LdMyselfCheck>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : LdPagingHandler<LdMyselfCheck> {
            protected LdMyselfCheckBhv _bhv; protected LdMyselfCheckCB _cb;
            public InternalSelectPagingHandler(LdMyselfCheckBhv bhv, LdMyselfCheckCB cb) { _bhv = bhv; _cb = cb; }
            public LdPagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<LdMyselfCheck> Paging() { return _bhv.SelectList(_cb); }
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
        public IList<LdMyself> PulloutMyself(IList<LdMyselfCheck> myselfCheckList) {
            return HelpPulloutInternally<LdMyselfCheck, LdMyself>(myselfCheckList, new MyInternalPulloutMyselfCallback());
        }
        protected class MyInternalPulloutMyselfCallback : InternalPulloutCallback<LdMyselfCheck, LdMyself> {
            public LdMyself getFr(LdMyselfCheck entity) { return entity.Myself; }
        }
        #endregion


        // ===============================================================================
        //                                                                   Entity Update
        //                                                                   =============
        #region Basic Entity Update
        public virtual void Insert(LdMyselfCheck entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(LdEntity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(LdMyselfCheck entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(LdEntity entity) {
            Update(Downcast(entity));
        }

        public void InsertOrUpdate(LdMyselfCheck entity) {
            HelpInsertOrUpdateInternally<LdMyselfCheck, LdMyselfCheckCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<LdMyselfCheck, LdMyselfCheckCB> {
            protected LdMyselfCheckBhv _bhv;
            public MyInternalInsertOrUpdateCallback(LdMyselfCheckBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(LdMyselfCheck entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(LdMyselfCheck entity) { _bhv.Update(entity); }
            public LdMyselfCheckCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(LdMyselfCheckCB cb, LdMyselfCheck entity) {
                cb.Query().SetMyselfCheckId_Equal(entity.MyselfCheckId);
            }
            public int CallbackSelectCount(LdMyselfCheckCB cb) { return _bhv.SelectCount(cb); }
        }

        public virtual void Delete(LdMyselfCheck entity) {
            HelpDeleteInternally<LdMyselfCheck>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(LdEntity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<LdMyselfCheck> {
            protected LdMyselfCheckBhv _bhv;
            public MyInternalDeleteCallback(LdMyselfCheckBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(LdMyselfCheck entity) { return _bhv.DelegateDelete(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(LdMyselfCheck myselfCheck, LdMyselfCheckCB cb) {
            AssertObjectNotNull("myselfCheck", myselfCheck); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(myselfCheck);
            FilterEntityOfUpdate(myselfCheck); AssertEntityOfUpdate(myselfCheck);
            return this.Dao.UpdateByQuery(cb, myselfCheck);
        }

        public int QueryDelete(LdMyselfCheckCB cb) {
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
            return false;
        }

        // ===============================================================================
        //                                                                 Delegate Method
        //                                                                 ===============
        #region Delegate Method
        protected int DelegateSelectCount(LdMyselfCheckCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<LdMyselfCheck> DelegateSelectList(LdMyselfCheckCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(LdMyselfCheck e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(LdMyselfCheck e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(LdMyselfCheck e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected LdMyselfCheck Downcast(LdEntity entity) {
            return (LdMyselfCheck)entity;
        }

        protected LdMyselfCheckCB Downcast(LdConditionBean cb) {
            return (LdMyselfCheckCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual LdMyselfCheckDao Dao { get { return _dao; } set { _dao = value; } }
    }
}

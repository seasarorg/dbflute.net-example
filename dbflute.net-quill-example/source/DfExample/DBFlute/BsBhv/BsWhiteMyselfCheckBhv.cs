
using System;
using System.Collections.Generic;

using Seasar.Quill;
using Seasar.Quill.Attrs;

using DfExample.DBFlute.AllCommon;
using DfExample.DBFlute.AllCommon.Bhv;
using DfExample.DBFlute.AllCommon.Bhv.Load;
using DfExample.DBFlute.AllCommon.Bhv.Setup;
using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.Dbm;
using DfExample.DBFlute.AllCommon.Exp;
using DfExample.DBFlute.BsEntity.Dbm;
using DfExample.DBFlute.ExDao;
using DfExample.DBFlute.ExEntity;
using DfExample.DBFlute.CBean;


namespace DfExample.DBFlute.ExBhv {

    [Implementation]
    public partial class WhiteMyselfCheckBhv : DfExample.DBFlute.AllCommon.Bhv.AbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected WhiteMyselfCheckDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public WhiteMyselfCheckBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "white_myself_check"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override DBMeta DBMeta { get { return WhiteMyselfCheckDbm.GetInstance(); } }
        public WhiteMyselfCheckDbm MyDBMeta { get { return WhiteMyselfCheckDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override Entity NewEntity() { return NewMyEntity(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual WhiteMyselfCheck NewMyEntity() { return new WhiteMyselfCheck(); }
        public virtual WhiteMyselfCheckCB NewMyConditionBean() { return new WhiteMyselfCheckCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(WhiteMyselfCheckCB cb) {
            AssertConditionBeanNotNull(cb);
            return this.DelegateSelectCount(cb);
        }

        protected override int DoReadCount(ConditionBean cb) {
            return SelectCount(Downcast(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                   Entity Select
        //                                                                   =============
        #region Entity Select
        public virtual WhiteMyselfCheck SelectEntity(WhiteMyselfCheckCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<WhiteMyselfCheck> ls = null;
            try {
                ls = this.DelegateSelectList(cb);
            } catch (DangerousResultSizeException e) {
                ThrowEntityDuplicatedException("{over safetyMaxResultSize '1'}", cb, e);
                return null; // unreachable
            } finally {
                xrestoreSafetyResult(cb, preSafetyMaxResultSize);
            }
            if (ls.Count == 0) { return null; }
            AssertEntitySelectedAsOne(ls, cb);
            return (WhiteMyselfCheck)ls[0];
        }

        protected override Entity DoReadEntity(ConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual WhiteMyselfCheck SelectEntityWithDeletedCheck(WhiteMyselfCheckCB cb) {
            AssertConditionBeanNotNull(cb);
            WhiteMyselfCheck entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override Entity DoReadEntityWithDeletedCheck(ConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual WhiteMyselfCheck SelectByPKValue(int? myselfCheckId) {
            return SelectEntity(BuildPKCB(myselfCheckId));
        }

        public virtual WhiteMyselfCheck SelectByPKValueWithDeletedCheck(int? myselfCheckId) {
            return SelectEntityWithDeletedCheck(BuildPKCB(myselfCheckId));
        }

        private WhiteMyselfCheckCB BuildPKCB(int? myselfCheckId) {
            AssertObjectNotNull("myselfCheckId", myselfCheckId);
            WhiteMyselfCheckCB cb = NewMyConditionBean();
            cb.Query().SetMyselfCheckId_Equal(myselfCheckId);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual ListResultBean<WhiteMyselfCheck> SelectList(WhiteMyselfCheckCB cb) {
            AssertConditionBeanNotNull(cb);
            return new ResultBeanBuilder<WhiteMyselfCheck>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual PagingResultBean<WhiteMyselfCheck> SelectPage(WhiteMyselfCheckCB cb) {
            AssertConditionBeanNotNull(cb);
            PagingInvoker<WhiteMyselfCheck> invoker = new PagingInvoker<WhiteMyselfCheck>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : PagingHandler<WhiteMyselfCheck> {
            protected WhiteMyselfCheckBhv _bhv; protected WhiteMyselfCheckCB _cb;
            public InternalSelectPagingHandler(WhiteMyselfCheckBhv bhv, WhiteMyselfCheckCB cb) { _bhv = bhv; _cb = cb; }
            public PagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<WhiteMyselfCheck> Paging() { return _bhv.SelectList(_cb); }
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
        public IList<WhiteMyself> PulloutWhiteMyself(IList<WhiteMyselfCheck> whiteMyselfCheckList) {
            return HelpPulloutInternally<WhiteMyselfCheck, WhiteMyself>(whiteMyselfCheckList, new MyInternalPulloutWhiteMyselfCallback());
        }
        protected class MyInternalPulloutWhiteMyselfCallback : InternalPulloutCallback<WhiteMyselfCheck, WhiteMyself> {
            public WhiteMyself getFr(WhiteMyselfCheck entity) { return entity.WhiteMyself; }
        }
        #endregion


        // ===============================================================================
        //                                                                   Entity Update
        //                                                                   =============
        #region Basic Entity Update
        public virtual void Insert(WhiteMyselfCheck entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(Entity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(WhiteMyselfCheck entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(Entity entity) {
            Update(Downcast(entity));
        }

        public void InsertOrUpdate(WhiteMyselfCheck entity) {
            HelpInsertOrUpdateInternally<WhiteMyselfCheck, WhiteMyselfCheckCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<WhiteMyselfCheck, WhiteMyselfCheckCB> {
            protected WhiteMyselfCheckBhv _bhv;
            public MyInternalInsertOrUpdateCallback(WhiteMyselfCheckBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(WhiteMyselfCheck entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(WhiteMyselfCheck entity) { _bhv.Update(entity); }
            public WhiteMyselfCheckCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(WhiteMyselfCheckCB cb, WhiteMyselfCheck entity) {
                cb.Query().SetMyselfCheckId_Equal(entity.MyselfCheckId);
            }
            public int CallbackSelectCount(WhiteMyselfCheckCB cb) { return _bhv.SelectCount(cb); }
        }

        public virtual void Delete(WhiteMyselfCheck entity) {
            HelpDeleteInternally<WhiteMyselfCheck>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(Entity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<WhiteMyselfCheck> {
            protected WhiteMyselfCheckBhv _bhv;
            public MyInternalDeleteCallback(WhiteMyselfCheckBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(WhiteMyselfCheck entity) { return _bhv.DelegateDelete(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(WhiteMyselfCheck whiteMyselfCheck, WhiteMyselfCheckCB cb) {
            AssertObjectNotNull("whiteMyselfCheck", whiteMyselfCheck); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(whiteMyselfCheck);
            FilterEntityOfUpdate(whiteMyselfCheck); AssertEntityOfUpdate(whiteMyselfCheck);
            return this.Dao.UpdateByQuery(cb, whiteMyselfCheck);
        }

        public int QueryDelete(WhiteMyselfCheckCB cb) {
            AssertConditionBeanNotNull(cb);
            return this.Dao.DeleteByQuery(cb);
        }

        // ===============================================================================
        //                                                            Optimistic Lock Info
        //                                                            ====================
        protected override bool HasVersionNoValue(Entity entity) {
            return false;
        }

        protected override bool HasUpdateDateValue(Entity entity) {
            return false;
        }

        // ===============================================================================
        //                                                                 Delegate Method
        //                                                                 ===============
        #region Delegate Method
        protected int DelegateSelectCount(WhiteMyselfCheckCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<WhiteMyselfCheck> DelegateSelectList(WhiteMyselfCheckCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(WhiteMyselfCheck e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(WhiteMyselfCheck e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(WhiteMyselfCheck e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected WhiteMyselfCheck Downcast(Entity entity) {
            return (WhiteMyselfCheck)entity;
        }

        protected WhiteMyselfCheckCB Downcast(ConditionBean cb) {
            return (WhiteMyselfCheckCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual WhiteMyselfCheckDao Dao { get { return _dao; } set { _dao = value; } }
    }
}

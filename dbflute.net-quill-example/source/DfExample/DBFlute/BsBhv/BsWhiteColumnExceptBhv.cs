
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
    public partial class WhiteColumnExceptBhv : DfExample.DBFlute.AllCommon.Bhv.AbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected WhiteColumnExceptDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public WhiteColumnExceptBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "white_column_except"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override DBMeta DBMeta { get { return WhiteColumnExceptDbm.GetInstance(); } }
        public WhiteColumnExceptDbm MyDBMeta { get { return WhiteColumnExceptDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override Entity NewEntity() { return NewMyEntity(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual WhiteColumnExcept NewMyEntity() { return new WhiteColumnExcept(); }
        public virtual WhiteColumnExceptCB NewMyConditionBean() { return new WhiteColumnExceptCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(WhiteColumnExceptCB cb) {
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
        public virtual WhiteColumnExcept SelectEntity(WhiteColumnExceptCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<WhiteColumnExcept> ls = null;
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
            return (WhiteColumnExcept)ls[0];
        }

        protected override Entity DoReadEntity(ConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual WhiteColumnExcept SelectEntityWithDeletedCheck(WhiteColumnExceptCB cb) {
            AssertConditionBeanNotNull(cb);
            WhiteColumnExcept entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override Entity DoReadEntityWithDeletedCheck(ConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual WhiteColumnExcept SelectByPKValue(long? exceptColumnId) {
            return SelectEntity(BuildPKCB(exceptColumnId));
        }

        public virtual WhiteColumnExcept SelectByPKValueWithDeletedCheck(long? exceptColumnId) {
            return SelectEntityWithDeletedCheck(BuildPKCB(exceptColumnId));
        }

        private WhiteColumnExceptCB BuildPKCB(long? exceptColumnId) {
            AssertObjectNotNull("exceptColumnId", exceptColumnId);
            WhiteColumnExceptCB cb = NewMyConditionBean();
            cb.Query().SetExceptColumnId_Equal(exceptColumnId);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual ListResultBean<WhiteColumnExcept> SelectList(WhiteColumnExceptCB cb) {
            AssertConditionBeanNotNull(cb);
            return new ResultBeanBuilder<WhiteColumnExcept>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual PagingResultBean<WhiteColumnExcept> SelectPage(WhiteColumnExceptCB cb) {
            AssertConditionBeanNotNull(cb);
            PagingInvoker<WhiteColumnExcept> invoker = new PagingInvoker<WhiteColumnExcept>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : PagingHandler<WhiteColumnExcept> {
            protected WhiteColumnExceptBhv _bhv; protected WhiteColumnExceptCB _cb;
            public InternalSelectPagingHandler(WhiteColumnExceptBhv bhv, WhiteColumnExceptCB cb) { _bhv = bhv; _cb = cb; }
            public PagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<WhiteColumnExcept> Paging() { return _bhv.SelectList(_cb); }
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
        #endregion


        // ===============================================================================
        //                                                                   Entity Update
        //                                                                   =============
        #region Basic Entity Update
        public virtual void Insert(WhiteColumnExcept entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(Entity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(WhiteColumnExcept entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(Entity entity) {
            Update(Downcast(entity));
        }

        public void InsertOrUpdate(WhiteColumnExcept entity) {
            HelpInsertOrUpdateInternally<WhiteColumnExcept, WhiteColumnExceptCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<WhiteColumnExcept, WhiteColumnExceptCB> {
            protected WhiteColumnExceptBhv _bhv;
            public MyInternalInsertOrUpdateCallback(WhiteColumnExceptBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(WhiteColumnExcept entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(WhiteColumnExcept entity) { _bhv.Update(entity); }
            public WhiteColumnExceptCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(WhiteColumnExceptCB cb, WhiteColumnExcept entity) {
                cb.Query().SetExceptColumnId_Equal(entity.ExceptColumnId);
            }
            public int CallbackSelectCount(WhiteColumnExceptCB cb) { return _bhv.SelectCount(cb); }
        }

        public virtual void Delete(WhiteColumnExcept entity) {
            HelpDeleteInternally<WhiteColumnExcept>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(Entity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<WhiteColumnExcept> {
            protected WhiteColumnExceptBhv _bhv;
            public MyInternalDeleteCallback(WhiteColumnExceptBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(WhiteColumnExcept entity) { return _bhv.DelegateDelete(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(WhiteColumnExcept whiteColumnExcept, WhiteColumnExceptCB cb) {
            AssertObjectNotNull("whiteColumnExcept", whiteColumnExcept); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(whiteColumnExcept);
            FilterEntityOfUpdate(whiteColumnExcept); AssertEntityOfUpdate(whiteColumnExcept);
            return this.Dao.UpdateByQuery(cb, whiteColumnExcept);
        }

        public int QueryDelete(WhiteColumnExceptCB cb) {
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
        protected int DelegateSelectCount(WhiteColumnExceptCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<WhiteColumnExcept> DelegateSelectList(WhiteColumnExceptCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(WhiteColumnExcept e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(WhiteColumnExcept e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(WhiteColumnExcept e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected WhiteColumnExcept Downcast(Entity entity) {
            return (WhiteColumnExcept)entity;
        }

        protected WhiteColumnExceptCB Downcast(ConditionBean cb) {
            return (WhiteColumnExceptCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual WhiteColumnExceptDao Dao { get { return _dao; } set { _dao = value; } }
    }
}

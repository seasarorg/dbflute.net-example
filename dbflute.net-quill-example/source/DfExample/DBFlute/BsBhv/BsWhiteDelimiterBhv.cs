
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
    public partial class WhiteDelimiterBhv : DfExample.DBFlute.AllCommon.Bhv.AbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected WhiteDelimiterDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public WhiteDelimiterBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "white_delimiter"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override DBMeta DBMeta { get { return WhiteDelimiterDbm.GetInstance(); } }
        public WhiteDelimiterDbm MyDBMeta { get { return WhiteDelimiterDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override Entity NewEntity() { return NewMyEntity(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual WhiteDelimiter NewMyEntity() { return new WhiteDelimiter(); }
        public virtual WhiteDelimiterCB NewMyConditionBean() { return new WhiteDelimiterCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(WhiteDelimiterCB cb) {
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
        public virtual WhiteDelimiter SelectEntity(WhiteDelimiterCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<WhiteDelimiter> ls = null;
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
            return (WhiteDelimiter)ls[0];
        }

        protected override Entity DoReadEntity(ConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual WhiteDelimiter SelectEntityWithDeletedCheck(WhiteDelimiterCB cb) {
            AssertConditionBeanNotNull(cb);
            WhiteDelimiter entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override Entity DoReadEntityWithDeletedCheck(ConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual WhiteDelimiter SelectByPKValue(long? delimiterId) {
            return SelectEntity(BuildPKCB(delimiterId));
        }

        public virtual WhiteDelimiter SelectByPKValueWithDeletedCheck(long? delimiterId) {
            return SelectEntityWithDeletedCheck(BuildPKCB(delimiterId));
        }

        private WhiteDelimiterCB BuildPKCB(long? delimiterId) {
            AssertObjectNotNull("delimiterId", delimiterId);
            WhiteDelimiterCB cb = NewMyConditionBean();
            cb.Query().SetDelimiterId_Equal(delimiterId);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual ListResultBean<WhiteDelimiter> SelectList(WhiteDelimiterCB cb) {
            AssertConditionBeanNotNull(cb);
            return new ResultBeanBuilder<WhiteDelimiter>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual PagingResultBean<WhiteDelimiter> SelectPage(WhiteDelimiterCB cb) {
            AssertConditionBeanNotNull(cb);
            PagingInvoker<WhiteDelimiter> invoker = new PagingInvoker<WhiteDelimiter>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : PagingHandler<WhiteDelimiter> {
            protected WhiteDelimiterBhv _bhv; protected WhiteDelimiterCB _cb;
            public InternalSelectPagingHandler(WhiteDelimiterBhv bhv, WhiteDelimiterCB cb) { _bhv = bhv; _cb = cb; }
            public PagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<WhiteDelimiter> Paging() { return _bhv.SelectList(_cb); }
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
        public virtual void Insert(WhiteDelimiter entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(Entity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(WhiteDelimiter entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(Entity entity) {
            Update(Downcast(entity));
        }

        public void InsertOrUpdate(WhiteDelimiter entity) {
            HelpInsertOrUpdateInternally<WhiteDelimiter, WhiteDelimiterCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<WhiteDelimiter, WhiteDelimiterCB> {
            protected WhiteDelimiterBhv _bhv;
            public MyInternalInsertOrUpdateCallback(WhiteDelimiterBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(WhiteDelimiter entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(WhiteDelimiter entity) { _bhv.Update(entity); }
            public WhiteDelimiterCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(WhiteDelimiterCB cb, WhiteDelimiter entity) {
                cb.Query().SetDelimiterId_Equal(entity.DelimiterId);
            }
            public int CallbackSelectCount(WhiteDelimiterCB cb) { return _bhv.SelectCount(cb); }
        }

        public virtual void Delete(WhiteDelimiter entity) {
            HelpDeleteInternally<WhiteDelimiter>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(Entity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<WhiteDelimiter> {
            protected WhiteDelimiterBhv _bhv;
            public MyInternalDeleteCallback(WhiteDelimiterBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(WhiteDelimiter entity) { return _bhv.DelegateDelete(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(WhiteDelimiter whiteDelimiter, WhiteDelimiterCB cb) {
            AssertObjectNotNull("whiteDelimiter", whiteDelimiter); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(whiteDelimiter);
            FilterEntityOfUpdate(whiteDelimiter); AssertEntityOfUpdate(whiteDelimiter);
            return this.Dao.UpdateByQuery(cb, whiteDelimiter);
        }

        public int QueryDelete(WhiteDelimiterCB cb) {
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
        protected int DelegateSelectCount(WhiteDelimiterCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<WhiteDelimiter> DelegateSelectList(WhiteDelimiterCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(WhiteDelimiter e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(WhiteDelimiter e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(WhiteDelimiter e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected WhiteDelimiter Downcast(Entity entity) {
            return (WhiteDelimiter)entity;
        }

        protected WhiteDelimiterCB Downcast(ConditionBean cb) {
            return (WhiteDelimiterCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual WhiteDelimiterDao Dao { get { return _dao; } set { _dao = value; } }
    }
}

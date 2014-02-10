
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
    public partial class WhiteQuotedBhv : DfExample.DBFlute.AllCommon.Bhv.AbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected WhiteQuotedDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public WhiteQuotedBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "white_quoted"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override DBMeta DBMeta { get { return WhiteQuotedDbm.GetInstance(); } }
        public WhiteQuotedDbm MyDBMeta { get { return WhiteQuotedDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override Entity NewEntity() { return NewMyEntity(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual WhiteQuoted NewMyEntity() { return new WhiteQuoted(); }
        public virtual WhiteQuotedCB NewMyConditionBean() { return new WhiteQuotedCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(WhiteQuotedCB cb) {
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
        public virtual WhiteQuoted SelectEntity(WhiteQuotedCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<WhiteQuoted> ls = null;
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
            return (WhiteQuoted)ls[0];
        }

        protected override Entity DoReadEntity(ConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual WhiteQuoted SelectEntityWithDeletedCheck(WhiteQuotedCB cb) {
            AssertConditionBeanNotNull(cb);
            WhiteQuoted entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override Entity DoReadEntityWithDeletedCheck(ConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual WhiteQuoted SelectByPKValue(int? select) {
            return SelectEntity(BuildPKCB(select));
        }

        public virtual WhiteQuoted SelectByPKValueWithDeletedCheck(int? select) {
            return SelectEntityWithDeletedCheck(BuildPKCB(select));
        }

        private WhiteQuotedCB BuildPKCB(int? select) {
            AssertObjectNotNull("select", select);
            WhiteQuotedCB cb = NewMyConditionBean();
            cb.Query().SetSelect_Equal(select);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual ListResultBean<WhiteQuoted> SelectList(WhiteQuotedCB cb) {
            AssertConditionBeanNotNull(cb);
            return new ResultBeanBuilder<WhiteQuoted>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual PagingResultBean<WhiteQuoted> SelectPage(WhiteQuotedCB cb) {
            AssertConditionBeanNotNull(cb);
            PagingInvoker<WhiteQuoted> invoker = new PagingInvoker<WhiteQuoted>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : PagingHandler<WhiteQuoted> {
            protected WhiteQuotedBhv _bhv; protected WhiteQuotedCB _cb;
            public InternalSelectPagingHandler(WhiteQuotedBhv bhv, WhiteQuotedCB cb) { _bhv = bhv; _cb = cb; }
            public PagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<WhiteQuoted> Paging() { return _bhv.SelectList(_cb); }
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
        public virtual void Insert(WhiteQuoted entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(Entity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(WhiteQuoted entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(Entity entity) {
            Update(Downcast(entity));
        }

        public void InsertOrUpdate(WhiteQuoted entity) {
            HelpInsertOrUpdateInternally<WhiteQuoted, WhiteQuotedCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<WhiteQuoted, WhiteQuotedCB> {
            protected WhiteQuotedBhv _bhv;
            public MyInternalInsertOrUpdateCallback(WhiteQuotedBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(WhiteQuoted entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(WhiteQuoted entity) { _bhv.Update(entity); }
            public WhiteQuotedCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(WhiteQuotedCB cb, WhiteQuoted entity) {
                cb.Query().SetSelect_Equal(entity.Select);
            }
            public int CallbackSelectCount(WhiteQuotedCB cb) { return _bhv.SelectCount(cb); }
        }

        public virtual void Delete(WhiteQuoted entity) {
            HelpDeleteInternally<WhiteQuoted>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(Entity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<WhiteQuoted> {
            protected WhiteQuotedBhv _bhv;
            public MyInternalDeleteCallback(WhiteQuotedBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(WhiteQuoted entity) { return _bhv.DelegateDelete(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(WhiteQuoted whiteQuoted, WhiteQuotedCB cb) {
            AssertObjectNotNull("whiteQuoted", whiteQuoted); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(whiteQuoted);
            FilterEntityOfUpdate(whiteQuoted); AssertEntityOfUpdate(whiteQuoted);
            return this.Dao.UpdateByQuery(cb, whiteQuoted);
        }

        public int QueryDelete(WhiteQuotedCB cb) {
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
        protected int DelegateSelectCount(WhiteQuotedCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<WhiteQuoted> DelegateSelectList(WhiteQuotedCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(WhiteQuoted e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(WhiteQuoted e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(WhiteQuoted e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected WhiteQuoted Downcast(Entity entity) {
            return (WhiteQuoted)entity;
        }

        protected WhiteQuotedCB Downcast(ConditionBean cb) {
            return (WhiteQuotedCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual WhiteQuotedDao Dao { get { return _dao; } set { _dao = value; } }
    }
}

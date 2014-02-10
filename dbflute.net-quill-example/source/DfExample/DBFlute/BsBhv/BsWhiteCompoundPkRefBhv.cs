
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
    public partial class WhiteCompoundPkRefBhv : DfExample.DBFlute.AllCommon.Bhv.AbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected WhiteCompoundPkRefDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public WhiteCompoundPkRefBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "white_compound_pk_ref"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override DBMeta DBMeta { get { return WhiteCompoundPkRefDbm.GetInstance(); } }
        public WhiteCompoundPkRefDbm MyDBMeta { get { return WhiteCompoundPkRefDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override Entity NewEntity() { return NewMyEntity(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual WhiteCompoundPkRef NewMyEntity() { return new WhiteCompoundPkRef(); }
        public virtual WhiteCompoundPkRefCB NewMyConditionBean() { return new WhiteCompoundPkRefCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(WhiteCompoundPkRefCB cb) {
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
        public virtual WhiteCompoundPkRef SelectEntity(WhiteCompoundPkRefCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<WhiteCompoundPkRef> ls = null;
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
            return (WhiteCompoundPkRef)ls[0];
        }

        protected override Entity DoReadEntity(ConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual WhiteCompoundPkRef SelectEntityWithDeletedCheck(WhiteCompoundPkRefCB cb) {
            AssertConditionBeanNotNull(cb);
            WhiteCompoundPkRef entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override Entity DoReadEntityWithDeletedCheck(ConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual WhiteCompoundPkRef SelectByPKValue(int? multipleFirstId, int? multipleSecondId) {
            return SelectEntity(BuildPKCB(multipleFirstId, multipleSecondId));
        }

        public virtual WhiteCompoundPkRef SelectByPKValueWithDeletedCheck(int? multipleFirstId, int? multipleSecondId) {
            return SelectEntityWithDeletedCheck(BuildPKCB(multipleFirstId, multipleSecondId));
        }

        private WhiteCompoundPkRefCB BuildPKCB(int? multipleFirstId, int? multipleSecondId) {
            AssertObjectNotNull("multipleFirstId", multipleFirstId);AssertObjectNotNull("multipleSecondId", multipleSecondId);
            WhiteCompoundPkRefCB cb = NewMyConditionBean();
            cb.Query().SetMultipleFirstId_Equal(multipleFirstId);cb.Query().SetMultipleSecondId_Equal(multipleSecondId);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual ListResultBean<WhiteCompoundPkRef> SelectList(WhiteCompoundPkRefCB cb) {
            AssertConditionBeanNotNull(cb);
            return new ResultBeanBuilder<WhiteCompoundPkRef>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual PagingResultBean<WhiteCompoundPkRef> SelectPage(WhiteCompoundPkRefCB cb) {
            AssertConditionBeanNotNull(cb);
            PagingInvoker<WhiteCompoundPkRef> invoker = new PagingInvoker<WhiteCompoundPkRef>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : PagingHandler<WhiteCompoundPkRef> {
            protected WhiteCompoundPkRefBhv _bhv; protected WhiteCompoundPkRefCB _cb;
            public InternalSelectPagingHandler(WhiteCompoundPkRefBhv bhv, WhiteCompoundPkRefCB cb) { _bhv = bhv; _cb = cb; }
            public PagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<WhiteCompoundPkRef> Paging() { return _bhv.SelectList(_cb); }
        }
        #endregion


        // ===============================================================================
        //                                                                Pull out Foreign
        //                                                                ================
        #region Pullout Foreign
        public IList<WhiteCompoundPk> PulloutWhiteCompoundPk(IList<WhiteCompoundPkRef> whiteCompoundPkRefList) {
            return HelpPulloutInternally<WhiteCompoundPkRef, WhiteCompoundPk>(whiteCompoundPkRefList, new MyInternalPulloutWhiteCompoundPkCallback());
        }
        protected class MyInternalPulloutWhiteCompoundPkCallback : InternalPulloutCallback<WhiteCompoundPkRef, WhiteCompoundPk> {
            public WhiteCompoundPk getFr(WhiteCompoundPkRef entity) { return entity.WhiteCompoundPk; }
        }
        #endregion


        // ===============================================================================
        //                                                                   Entity Update
        //                                                                   =============
        #region Basic Entity Update
        public virtual void Insert(WhiteCompoundPkRef entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(Entity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(WhiteCompoundPkRef entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(Entity entity) {
            Update(Downcast(entity));
        }

        public void InsertOrUpdate(WhiteCompoundPkRef entity) {
            HelpInsertOrUpdateInternally<WhiteCompoundPkRef, WhiteCompoundPkRefCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<WhiteCompoundPkRef, WhiteCompoundPkRefCB> {
            protected WhiteCompoundPkRefBhv _bhv;
            public MyInternalInsertOrUpdateCallback(WhiteCompoundPkRefBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(WhiteCompoundPkRef entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(WhiteCompoundPkRef entity) { _bhv.Update(entity); }
            public WhiteCompoundPkRefCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(WhiteCompoundPkRefCB cb, WhiteCompoundPkRef entity) {
                cb.Query().SetMultipleFirstId_Equal(entity.MultipleFirstId);
                cb.Query().SetMultipleSecondId_Equal(entity.MultipleSecondId);
            }
            public int CallbackSelectCount(WhiteCompoundPkRefCB cb) { return _bhv.SelectCount(cb); }
        }

        public virtual void Delete(WhiteCompoundPkRef entity) {
            HelpDeleteInternally<WhiteCompoundPkRef>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(Entity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<WhiteCompoundPkRef> {
            protected WhiteCompoundPkRefBhv _bhv;
            public MyInternalDeleteCallback(WhiteCompoundPkRefBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(WhiteCompoundPkRef entity) { return _bhv.DelegateDelete(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============

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
        protected int DelegateSelectCount(WhiteCompoundPkRefCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<WhiteCompoundPkRef> DelegateSelectList(WhiteCompoundPkRefCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(WhiteCompoundPkRef e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(WhiteCompoundPkRef e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(WhiteCompoundPkRef e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected WhiteCompoundPkRef Downcast(Entity entity) {
            return (WhiteCompoundPkRef)entity;
        }

        protected WhiteCompoundPkRefCB Downcast(ConditionBean cb) {
            return (WhiteCompoundPkRefCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual WhiteCompoundPkRefDao Dao { get { return _dao; } set { _dao = value; } }
    }
}

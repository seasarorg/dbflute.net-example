
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
    public partial class WhitePgReservRefBhv : DfExample.DBFlute.AllCommon.Bhv.AbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected WhitePgReservRefDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public WhitePgReservRefBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "white_pg_reserv_ref"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override DBMeta DBMeta { get { return WhitePgReservRefDbm.GetInstance(); } }
        public WhitePgReservRefDbm MyDBMeta { get { return WhitePgReservRefDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override Entity NewEntity() { return NewMyEntity(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual WhitePgReservRef NewMyEntity() { return new WhitePgReservRef(); }
        public virtual WhitePgReservRefCB NewMyConditionBean() { return new WhitePgReservRefCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(WhitePgReservRefCB cb) {
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
        public virtual WhitePgReservRef SelectEntity(WhitePgReservRefCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<WhitePgReservRef> ls = null;
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
            return (WhitePgReservRef)ls[0];
        }

        protected override Entity DoReadEntity(ConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual WhitePgReservRef SelectEntityWithDeletedCheck(WhitePgReservRefCB cb) {
            AssertConditionBeanNotNull(cb);
            WhitePgReservRef entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override Entity DoReadEntityWithDeletedCheck(ConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual WhitePgReservRef SelectByPKValue(int? refId) {
            return SelectEntity(BuildPKCB(refId));
        }

        public virtual WhitePgReservRef SelectByPKValueWithDeletedCheck(int? refId) {
            return SelectEntityWithDeletedCheck(BuildPKCB(refId));
        }

        private WhitePgReservRefCB BuildPKCB(int? refId) {
            AssertObjectNotNull("refId", refId);
            WhitePgReservRefCB cb = NewMyConditionBean();
            cb.Query().SetRefId_Equal(refId);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual ListResultBean<WhitePgReservRef> SelectList(WhitePgReservRefCB cb) {
            AssertConditionBeanNotNull(cb);
            return new ResultBeanBuilder<WhitePgReservRef>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual PagingResultBean<WhitePgReservRef> SelectPage(WhitePgReservRefCB cb) {
            AssertConditionBeanNotNull(cb);
            PagingInvoker<WhitePgReservRef> invoker = new PagingInvoker<WhitePgReservRef>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : PagingHandler<WhitePgReservRef> {
            protected WhitePgReservRefBhv _bhv; protected WhitePgReservRefCB _cb;
            public InternalSelectPagingHandler(WhitePgReservRefBhv bhv, WhitePgReservRefCB cb) { _bhv = bhv; _cb = cb; }
            public PagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<WhitePgReservRef> Paging() { return _bhv.SelectList(_cb); }
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
        public IList<WhitePgReserv> PulloutWhitePgReserv(IList<WhitePgReservRef> whitePgReservRefList) {
            return HelpPulloutInternally<WhitePgReservRef, WhitePgReserv>(whitePgReservRefList, new MyInternalPulloutWhitePgReservCallback());
        }
        protected class MyInternalPulloutWhitePgReservCallback : InternalPulloutCallback<WhitePgReservRef, WhitePgReserv> {
            public WhitePgReserv getFr(WhitePgReservRef entity) { return entity.WhitePgReserv; }
        }
        #endregion


        // ===============================================================================
        //                                                                   Entity Update
        //                                                                   =============
        #region Basic Entity Update
        public virtual void Insert(WhitePgReservRef entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(Entity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(WhitePgReservRef entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(Entity entity) {
            Update(Downcast(entity));
        }

        public void InsertOrUpdate(WhitePgReservRef entity) {
            HelpInsertOrUpdateInternally<WhitePgReservRef, WhitePgReservRefCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<WhitePgReservRef, WhitePgReservRefCB> {
            protected WhitePgReservRefBhv _bhv;
            public MyInternalInsertOrUpdateCallback(WhitePgReservRefBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(WhitePgReservRef entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(WhitePgReservRef entity) { _bhv.Update(entity); }
            public WhitePgReservRefCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(WhitePgReservRefCB cb, WhitePgReservRef entity) {
                cb.Query().SetRefId_Equal(entity.RefId);
            }
            public int CallbackSelectCount(WhitePgReservRefCB cb) { return _bhv.SelectCount(cb); }
        }

        public virtual void Delete(WhitePgReservRef entity) {
            HelpDeleteInternally<WhitePgReservRef>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(Entity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<WhitePgReservRef> {
            protected WhitePgReservRefBhv _bhv;
            public MyInternalDeleteCallback(WhitePgReservRefBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(WhitePgReservRef entity) { return _bhv.DelegateDelete(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(WhitePgReservRef whitePgReservRef, WhitePgReservRefCB cb) {
            AssertObjectNotNull("whitePgReservRef", whitePgReservRef); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(whitePgReservRef);
            FilterEntityOfUpdate(whitePgReservRef); AssertEntityOfUpdate(whitePgReservRef);
            return this.Dao.UpdateByQuery(cb, whitePgReservRef);
        }

        public int QueryDelete(WhitePgReservRefCB cb) {
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
        protected int DelegateSelectCount(WhitePgReservRefCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<WhitePgReservRef> DelegateSelectList(WhitePgReservRefCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(WhitePgReservRef e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(WhitePgReservRef e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(WhitePgReservRef e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected WhitePgReservRef Downcast(Entity entity) {
            return (WhitePgReservRef)entity;
        }

        protected WhitePgReservRefCB Downcast(ConditionBean cb) {
            return (WhitePgReservRefCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual WhitePgReservRefDao Dao { get { return _dao; } set { _dao = value; } }
    }
}


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
    public partial class WhiteAllInOneClsRefBhv : DfExample.DBFlute.AllCommon.Bhv.AbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected WhiteAllInOneClsRefDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public WhiteAllInOneClsRefBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "white_all_in_one_cls_ref"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override DBMeta DBMeta { get { return WhiteAllInOneClsRefDbm.GetInstance(); } }
        public WhiteAllInOneClsRefDbm MyDBMeta { get { return WhiteAllInOneClsRefDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override Entity NewEntity() { return NewMyEntity(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual WhiteAllInOneClsRef NewMyEntity() { return new WhiteAllInOneClsRef(); }
        public virtual WhiteAllInOneClsRefCB NewMyConditionBean() { return new WhiteAllInOneClsRefCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(WhiteAllInOneClsRefCB cb) {
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
        public virtual WhiteAllInOneClsRef SelectEntity(WhiteAllInOneClsRefCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<WhiteAllInOneClsRef> ls = null;
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
            return (WhiteAllInOneClsRef)ls[0];
        }

        protected override Entity DoReadEntity(ConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual WhiteAllInOneClsRef SelectEntityWithDeletedCheck(WhiteAllInOneClsRefCB cb) {
            AssertConditionBeanNotNull(cb);
            WhiteAllInOneClsRef entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override Entity DoReadEntityWithDeletedCheck(ConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual WhiteAllInOneClsRef SelectByPKValue(int? clsRefId) {
            return SelectEntity(BuildPKCB(clsRefId));
        }

        public virtual WhiteAllInOneClsRef SelectByPKValueWithDeletedCheck(int? clsRefId) {
            return SelectEntityWithDeletedCheck(BuildPKCB(clsRefId));
        }

        private WhiteAllInOneClsRefCB BuildPKCB(int? clsRefId) {
            AssertObjectNotNull("clsRefId", clsRefId);
            WhiteAllInOneClsRefCB cb = NewMyConditionBean();
            cb.Query().SetClsRefId_Equal(clsRefId);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual ListResultBean<WhiteAllInOneClsRef> SelectList(WhiteAllInOneClsRefCB cb) {
            AssertConditionBeanNotNull(cb);
            return new ResultBeanBuilder<WhiteAllInOneClsRef>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual PagingResultBean<WhiteAllInOneClsRef> SelectPage(WhiteAllInOneClsRefCB cb) {
            AssertConditionBeanNotNull(cb);
            PagingInvoker<WhiteAllInOneClsRef> invoker = new PagingInvoker<WhiteAllInOneClsRef>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : PagingHandler<WhiteAllInOneClsRef> {
            protected WhiteAllInOneClsRefBhv _bhv; protected WhiteAllInOneClsRefCB _cb;
            public InternalSelectPagingHandler(WhiteAllInOneClsRefBhv bhv, WhiteAllInOneClsRefCB cb) { _bhv = bhv; _cb = cb; }
            public PagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<WhiteAllInOneClsRef> Paging() { return _bhv.SelectList(_cb); }
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
        public IList<WhiteAllInOneCls> PulloutWhiteAllInOneClsAsFoo(IList<WhiteAllInOneClsRef> whiteAllInOneClsRefList) {
            return HelpPulloutInternally<WhiteAllInOneClsRef, WhiteAllInOneCls>(whiteAllInOneClsRefList, new MyInternalPulloutWhiteAllInOneClsAsFooCallback());
        }
        protected class MyInternalPulloutWhiteAllInOneClsAsFooCallback : InternalPulloutCallback<WhiteAllInOneClsRef, WhiteAllInOneCls> {
            public WhiteAllInOneCls getFr(WhiteAllInOneClsRef entity) { return entity.WhiteAllInOneClsAsFoo; }
        }
        public IList<WhiteAllInOneCls> PulloutWhiteAllInOneClsAsBar(IList<WhiteAllInOneClsRef> whiteAllInOneClsRefList) {
            return HelpPulloutInternally<WhiteAllInOneClsRef, WhiteAllInOneCls>(whiteAllInOneClsRefList, new MyInternalPulloutWhiteAllInOneClsAsBarCallback());
        }
        protected class MyInternalPulloutWhiteAllInOneClsAsBarCallback : InternalPulloutCallback<WhiteAllInOneClsRef, WhiteAllInOneCls> {
            public WhiteAllInOneCls getFr(WhiteAllInOneClsRef entity) { return entity.WhiteAllInOneClsAsBar; }
        }
        #endregion


        // ===============================================================================
        //                                                                   Entity Update
        //                                                                   =============
        #region Basic Entity Update
        public virtual void Insert(WhiteAllInOneClsRef entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(Entity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(WhiteAllInOneClsRef entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(Entity entity) {
            Update(Downcast(entity));
        }

        public void InsertOrUpdate(WhiteAllInOneClsRef entity) {
            HelpInsertOrUpdateInternally<WhiteAllInOneClsRef, WhiteAllInOneClsRefCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<WhiteAllInOneClsRef, WhiteAllInOneClsRefCB> {
            protected WhiteAllInOneClsRefBhv _bhv;
            public MyInternalInsertOrUpdateCallback(WhiteAllInOneClsRefBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(WhiteAllInOneClsRef entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(WhiteAllInOneClsRef entity) { _bhv.Update(entity); }
            public WhiteAllInOneClsRefCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(WhiteAllInOneClsRefCB cb, WhiteAllInOneClsRef entity) {
                cb.Query().SetClsRefId_Equal(entity.ClsRefId);
            }
            public int CallbackSelectCount(WhiteAllInOneClsRefCB cb) { return _bhv.SelectCount(cb); }
        }

        public virtual void Delete(WhiteAllInOneClsRef entity) {
            HelpDeleteInternally<WhiteAllInOneClsRef>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(Entity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<WhiteAllInOneClsRef> {
            protected WhiteAllInOneClsRefBhv _bhv;
            public MyInternalDeleteCallback(WhiteAllInOneClsRefBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(WhiteAllInOneClsRef entity) { return _bhv.DelegateDelete(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(WhiteAllInOneClsRef whiteAllInOneClsRef, WhiteAllInOneClsRefCB cb) {
            AssertObjectNotNull("whiteAllInOneClsRef", whiteAllInOneClsRef); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(whiteAllInOneClsRef);
            FilterEntityOfUpdate(whiteAllInOneClsRef); AssertEntityOfUpdate(whiteAllInOneClsRef);
            return this.Dao.UpdateByQuery(cb, whiteAllInOneClsRef);
        }

        public int QueryDelete(WhiteAllInOneClsRefCB cb) {
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
        protected int DelegateSelectCount(WhiteAllInOneClsRefCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<WhiteAllInOneClsRef> DelegateSelectList(WhiteAllInOneClsRefCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(WhiteAllInOneClsRef e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(WhiteAllInOneClsRef e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(WhiteAllInOneClsRef e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected WhiteAllInOneClsRef Downcast(Entity entity) {
            return (WhiteAllInOneClsRef)entity;
        }

        protected WhiteAllInOneClsRefCB Downcast(ConditionBean cb) {
            return (WhiteAllInOneClsRefCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual WhiteAllInOneClsRefDao Dao { get { return _dao; } set { _dao = value; } }
    }
}

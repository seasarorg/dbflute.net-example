
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
    public partial class WhiteCompoundPkRefNestBhv : DfExample.DBFlute.AllCommon.Bhv.AbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected WhiteCompoundPkRefNestDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public WhiteCompoundPkRefNestBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "white_compound_pk_ref_nest"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override DBMeta DBMeta { get { return WhiteCompoundPkRefNestDbm.GetInstance(); } }
        public WhiteCompoundPkRefNestDbm MyDBMeta { get { return WhiteCompoundPkRefNestDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override Entity NewEntity() { return NewMyEntity(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual WhiteCompoundPkRefNest NewMyEntity() { return new WhiteCompoundPkRefNest(); }
        public virtual WhiteCompoundPkRefNestCB NewMyConditionBean() { return new WhiteCompoundPkRefNestCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(WhiteCompoundPkRefNestCB cb) {
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
        public virtual WhiteCompoundPkRefNest SelectEntity(WhiteCompoundPkRefNestCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<WhiteCompoundPkRefNest> ls = null;
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
            return (WhiteCompoundPkRefNest)ls[0];
        }

        protected override Entity DoReadEntity(ConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual WhiteCompoundPkRefNest SelectEntityWithDeletedCheck(WhiteCompoundPkRefNestCB cb) {
            AssertConditionBeanNotNull(cb);
            WhiteCompoundPkRefNest entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override Entity DoReadEntityWithDeletedCheck(ConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual WhiteCompoundPkRefNest SelectByPKValue(int? compoundPkRefNestId) {
            return SelectEntity(BuildPKCB(compoundPkRefNestId));
        }

        public virtual WhiteCompoundPkRefNest SelectByPKValueWithDeletedCheck(int? compoundPkRefNestId) {
            return SelectEntityWithDeletedCheck(BuildPKCB(compoundPkRefNestId));
        }

        private WhiteCompoundPkRefNestCB BuildPKCB(int? compoundPkRefNestId) {
            AssertObjectNotNull("compoundPkRefNestId", compoundPkRefNestId);
            WhiteCompoundPkRefNestCB cb = NewMyConditionBean();
            cb.Query().SetCompoundPkRefNestId_Equal(compoundPkRefNestId);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual ListResultBean<WhiteCompoundPkRefNest> SelectList(WhiteCompoundPkRefNestCB cb) {
            AssertConditionBeanNotNull(cb);
            return new ResultBeanBuilder<WhiteCompoundPkRefNest>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual PagingResultBean<WhiteCompoundPkRefNest> SelectPage(WhiteCompoundPkRefNestCB cb) {
            AssertConditionBeanNotNull(cb);
            PagingInvoker<WhiteCompoundPkRefNest> invoker = new PagingInvoker<WhiteCompoundPkRefNest>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : PagingHandler<WhiteCompoundPkRefNest> {
            protected WhiteCompoundPkRefNestBhv _bhv; protected WhiteCompoundPkRefNestCB _cb;
            public InternalSelectPagingHandler(WhiteCompoundPkRefNestBhv bhv, WhiteCompoundPkRefNestCB cb) { _bhv = bhv; _cb = cb; }
            public PagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<WhiteCompoundPkRefNest> Paging() { return _bhv.SelectList(_cb); }
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
        public IList<WhiteCompoundPkRef> PulloutWhiteCompoundPkRefByQuxMultipleId(IList<WhiteCompoundPkRefNest> whiteCompoundPkRefNestList) {
            return HelpPulloutInternally<WhiteCompoundPkRefNest, WhiteCompoundPkRef>(whiteCompoundPkRefNestList, new MyInternalPulloutWhiteCompoundPkRefByQuxMultipleIdCallback());
        }
        protected class MyInternalPulloutWhiteCompoundPkRefByQuxMultipleIdCallback : InternalPulloutCallback<WhiteCompoundPkRefNest, WhiteCompoundPkRef> {
            public WhiteCompoundPkRef getFr(WhiteCompoundPkRefNest entity) { return entity.WhiteCompoundPkRefByQuxMultipleId; }
        }
        public IList<WhiteCompoundPkRef> PulloutWhiteCompoundPkRefByFooMultipleId(IList<WhiteCompoundPkRefNest> whiteCompoundPkRefNestList) {
            return HelpPulloutInternally<WhiteCompoundPkRefNest, WhiteCompoundPkRef>(whiteCompoundPkRefNestList, new MyInternalPulloutWhiteCompoundPkRefByFooMultipleIdCallback());
        }
        protected class MyInternalPulloutWhiteCompoundPkRefByFooMultipleIdCallback : InternalPulloutCallback<WhiteCompoundPkRefNest, WhiteCompoundPkRef> {
            public WhiteCompoundPkRef getFr(WhiteCompoundPkRefNest entity) { return entity.WhiteCompoundPkRefByFooMultipleId; }
        }
        #endregion


        // ===============================================================================
        //                                                                   Entity Update
        //                                                                   =============
        #region Basic Entity Update
        public virtual void Insert(WhiteCompoundPkRefNest entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(Entity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(WhiteCompoundPkRefNest entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(Entity entity) {
            Update(Downcast(entity));
        }

        public void InsertOrUpdate(WhiteCompoundPkRefNest entity) {
            HelpInsertOrUpdateInternally<WhiteCompoundPkRefNest, WhiteCompoundPkRefNestCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<WhiteCompoundPkRefNest, WhiteCompoundPkRefNestCB> {
            protected WhiteCompoundPkRefNestBhv _bhv;
            public MyInternalInsertOrUpdateCallback(WhiteCompoundPkRefNestBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(WhiteCompoundPkRefNest entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(WhiteCompoundPkRefNest entity) { _bhv.Update(entity); }
            public WhiteCompoundPkRefNestCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(WhiteCompoundPkRefNestCB cb, WhiteCompoundPkRefNest entity) {
                cb.Query().SetCompoundPkRefNestId_Equal(entity.CompoundPkRefNestId);
            }
            public int CallbackSelectCount(WhiteCompoundPkRefNestCB cb) { return _bhv.SelectCount(cb); }
        }

        public virtual void Delete(WhiteCompoundPkRefNest entity) {
            HelpDeleteInternally<WhiteCompoundPkRefNest>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(Entity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<WhiteCompoundPkRefNest> {
            protected WhiteCompoundPkRefNestBhv _bhv;
            public MyInternalDeleteCallback(WhiteCompoundPkRefNestBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(WhiteCompoundPkRefNest entity) { return _bhv.DelegateDelete(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(WhiteCompoundPkRefNest whiteCompoundPkRefNest, WhiteCompoundPkRefNestCB cb) {
            AssertObjectNotNull("whiteCompoundPkRefNest", whiteCompoundPkRefNest); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(whiteCompoundPkRefNest);
            FilterEntityOfUpdate(whiteCompoundPkRefNest); AssertEntityOfUpdate(whiteCompoundPkRefNest);
            return this.Dao.UpdateByQuery(cb, whiteCompoundPkRefNest);
        }

        public int QueryDelete(WhiteCompoundPkRefNestCB cb) {
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
        protected int DelegateSelectCount(WhiteCompoundPkRefNestCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<WhiteCompoundPkRefNest> DelegateSelectList(WhiteCompoundPkRefNestCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(WhiteCompoundPkRefNest e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(WhiteCompoundPkRefNest e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(WhiteCompoundPkRefNest e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected WhiteCompoundPkRefNest Downcast(Entity entity) {
            return (WhiteCompoundPkRefNest)entity;
        }

        protected WhiteCompoundPkRefNestCB Downcast(ConditionBean cb) {
            return (WhiteCompoundPkRefNestCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual WhiteCompoundPkRefNestDao Dao { get { return _dao; } set { _dao = value; } }
    }
}

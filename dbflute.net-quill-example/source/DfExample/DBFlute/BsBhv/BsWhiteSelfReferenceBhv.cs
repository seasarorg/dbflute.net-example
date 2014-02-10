
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
    public partial class WhiteSelfReferenceBhv : DfExample.DBFlute.AllCommon.Bhv.AbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected WhiteSelfReferenceDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public WhiteSelfReferenceBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "white_self_reference"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override DBMeta DBMeta { get { return WhiteSelfReferenceDbm.GetInstance(); } }
        public WhiteSelfReferenceDbm MyDBMeta { get { return WhiteSelfReferenceDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override Entity NewEntity() { return NewMyEntity(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual WhiteSelfReference NewMyEntity() { return new WhiteSelfReference(); }
        public virtual WhiteSelfReferenceCB NewMyConditionBean() { return new WhiteSelfReferenceCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(WhiteSelfReferenceCB cb) {
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
        public virtual WhiteSelfReference SelectEntity(WhiteSelfReferenceCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<WhiteSelfReference> ls = null;
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
            return (WhiteSelfReference)ls[0];
        }

        protected override Entity DoReadEntity(ConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual WhiteSelfReference SelectEntityWithDeletedCheck(WhiteSelfReferenceCB cb) {
            AssertConditionBeanNotNull(cb);
            WhiteSelfReference entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override Entity DoReadEntityWithDeletedCheck(ConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual WhiteSelfReference SelectByPKValue(long? selfReferenceId) {
            return SelectEntity(BuildPKCB(selfReferenceId));
        }

        public virtual WhiteSelfReference SelectByPKValueWithDeletedCheck(long? selfReferenceId) {
            return SelectEntityWithDeletedCheck(BuildPKCB(selfReferenceId));
        }

        private WhiteSelfReferenceCB BuildPKCB(long? selfReferenceId) {
            AssertObjectNotNull("selfReferenceId", selfReferenceId);
            WhiteSelfReferenceCB cb = NewMyConditionBean();
            cb.Query().SetSelfReferenceId_Equal(selfReferenceId);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual ListResultBean<WhiteSelfReference> SelectList(WhiteSelfReferenceCB cb) {
            AssertConditionBeanNotNull(cb);
            return new ResultBeanBuilder<WhiteSelfReference>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual PagingResultBean<WhiteSelfReference> SelectPage(WhiteSelfReferenceCB cb) {
            AssertConditionBeanNotNull(cb);
            PagingInvoker<WhiteSelfReference> invoker = new PagingInvoker<WhiteSelfReference>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : PagingHandler<WhiteSelfReference> {
            protected WhiteSelfReferenceBhv _bhv; protected WhiteSelfReferenceCB _cb;
            public InternalSelectPagingHandler(WhiteSelfReferenceBhv bhv, WhiteSelfReferenceCB cb) { _bhv = bhv; _cb = cb; }
            public PagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<WhiteSelfReference> Paging() { return _bhv.SelectList(_cb); }
        }
        #endregion

        // ===============================================================================
        //                                                                   Load Referrer
        //                                                                   =============
        #region Load Referrer
        public virtual void LoadWhiteSelfReferenceSelfList(WhiteSelfReference whiteSelfReference, ConditionBeanSetupper<WhiteSelfReferenceCB> conditionBeanSetupper) {
            AssertObjectNotNull("whiteSelfReference", whiteSelfReference); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadWhiteSelfReferenceSelfList(xnewLRLs<WhiteSelfReference>(whiteSelfReference), conditionBeanSetupper);
        }
        public virtual void LoadWhiteSelfReferenceSelfList(IList<WhiteSelfReference> whiteSelfReferenceList, ConditionBeanSetupper<WhiteSelfReferenceCB> conditionBeanSetupper) {
            AssertObjectNotNull("whiteSelfReferenceList", whiteSelfReferenceList); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadWhiteSelfReferenceSelfList(whiteSelfReferenceList, new LoadReferrerOption<WhiteSelfReferenceCB, WhiteSelfReference>().xinit(conditionBeanSetupper));
        }
        public virtual void LoadWhiteSelfReferenceSelfList(WhiteSelfReference whiteSelfReference, LoadReferrerOption<WhiteSelfReferenceCB, WhiteSelfReference> loadReferrerOption) {
            AssertObjectNotNull("whiteSelfReference", whiteSelfReference); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            LoadWhiteSelfReferenceSelfList(xnewLRLs<WhiteSelfReference>(whiteSelfReference), loadReferrerOption);
        }
        public virtual void LoadWhiteSelfReferenceSelfList(IList<WhiteSelfReference> whiteSelfReferenceList, LoadReferrerOption<WhiteSelfReferenceCB, WhiteSelfReference> loadReferrerOption) {
            AssertObjectNotNull("whiteSelfReferenceList", whiteSelfReferenceList); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            if (whiteSelfReferenceList.Count == 0) { return; }
            WhiteSelfReferenceBhv referrerBhv = xgetBSFLR().Select<WhiteSelfReferenceBhv>();
            HelpLoadReferrerInternally<WhiteSelfReference, long?, WhiteSelfReferenceCB, WhiteSelfReference>
                    (whiteSelfReferenceList, loadReferrerOption, new MyInternalLoadWhiteSelfReferenceSelfListCallback(referrerBhv));
        }
        protected class MyInternalLoadWhiteSelfReferenceSelfListCallback : InternalLoadReferrerCallback<WhiteSelfReference, long?, WhiteSelfReferenceCB, WhiteSelfReference> {
            protected WhiteSelfReferenceBhv referrerBhv;
            public MyInternalLoadWhiteSelfReferenceSelfListCallback(WhiteSelfReferenceBhv referrerBhv) { this.referrerBhv = referrerBhv; }
            public long? getPKVal(WhiteSelfReference e) { return e.SelfReferenceId; }
            public void setRfLs(WhiteSelfReference e, IList<WhiteSelfReference> ls) { e.WhiteSelfReferenceSelfList = ls; }
            public WhiteSelfReferenceCB newMyCB() { return referrerBhv.NewMyConditionBean(); }
            public void qyFKIn(WhiteSelfReferenceCB cb, IList<long?> ls) { cb.Query().SetParentId_InScope(ls); }
            public void qyOdFKAsc(WhiteSelfReferenceCB cb) { cb.Query().AddOrderBy_ParentId_Asc(); }
            public void spFKCol(WhiteSelfReferenceCB cb) { cb.Specify().ColumnParentId(); }
            public IList<WhiteSelfReference> selRfLs(WhiteSelfReferenceCB cb) { return referrerBhv.SelectList(cb); }
            public long? getFKVal(WhiteSelfReference e) { return e.ParentId; }
            public void setlcEt(WhiteSelfReference re, WhiteSelfReference be) { re.WhiteSelfReferenceSelf = be; }
        }
        #endregion

        // ===============================================================================
        //                                                                Pull out Foreign
        //                                                                ================
        #region Pullout Foreign
        public IList<WhiteSelfReference> PulloutWhiteSelfReferenceSelf(IList<WhiteSelfReference> whiteSelfReferenceList) {
            return HelpPulloutInternally<WhiteSelfReference, WhiteSelfReference>(whiteSelfReferenceList, new MyInternalPulloutWhiteSelfReferenceSelfCallback());
        }
        protected class MyInternalPulloutWhiteSelfReferenceSelfCallback : InternalPulloutCallback<WhiteSelfReference, WhiteSelfReference> {
            public WhiteSelfReference getFr(WhiteSelfReference entity) { return entity.WhiteSelfReferenceSelf; }
        }
        #endregion


        // ===============================================================================
        //                                                                   Entity Update
        //                                                                   =============
        #region Basic Entity Update
        public virtual void Insert(WhiteSelfReference entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(Entity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(WhiteSelfReference entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(Entity entity) {
            Update(Downcast(entity));
        }

        public void InsertOrUpdate(WhiteSelfReference entity) {
            HelpInsertOrUpdateInternally<WhiteSelfReference, WhiteSelfReferenceCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<WhiteSelfReference, WhiteSelfReferenceCB> {
            protected WhiteSelfReferenceBhv _bhv;
            public MyInternalInsertOrUpdateCallback(WhiteSelfReferenceBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(WhiteSelfReference entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(WhiteSelfReference entity) { _bhv.Update(entity); }
            public WhiteSelfReferenceCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(WhiteSelfReferenceCB cb, WhiteSelfReference entity) {
                cb.Query().SetSelfReferenceId_Equal(entity.SelfReferenceId);
            }
            public int CallbackSelectCount(WhiteSelfReferenceCB cb) { return _bhv.SelectCount(cb); }
        }

        public virtual void Delete(WhiteSelfReference entity) {
            HelpDeleteInternally<WhiteSelfReference>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(Entity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<WhiteSelfReference> {
            protected WhiteSelfReferenceBhv _bhv;
            public MyInternalDeleteCallback(WhiteSelfReferenceBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(WhiteSelfReference entity) { return _bhv.DelegateDelete(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(WhiteSelfReference whiteSelfReference, WhiteSelfReferenceCB cb) {
            AssertObjectNotNull("whiteSelfReference", whiteSelfReference); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(whiteSelfReference);
            FilterEntityOfUpdate(whiteSelfReference); AssertEntityOfUpdate(whiteSelfReference);
            return this.Dao.UpdateByQuery(cb, whiteSelfReference);
        }

        public int QueryDelete(WhiteSelfReferenceCB cb) {
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
        protected int DelegateSelectCount(WhiteSelfReferenceCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<WhiteSelfReference> DelegateSelectList(WhiteSelfReferenceCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(WhiteSelfReference e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(WhiteSelfReference e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(WhiteSelfReference e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected WhiteSelfReference Downcast(Entity entity) {
            return (WhiteSelfReference)entity;
        }

        protected WhiteSelfReferenceCB Downcast(ConditionBean cb) {
            return (WhiteSelfReferenceCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual WhiteSelfReferenceDao Dao { get { return _dao; } set { _dao = value; } }
    }
}

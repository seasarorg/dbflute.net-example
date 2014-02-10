
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
    public partial class SummaryProductBhv : DfExample.DBFlute.AllCommon.Bhv.AbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected SummaryProductDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public SummaryProductBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "summary_product"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override DBMeta DBMeta { get { return SummaryProductDbm.GetInstance(); } }
        public SummaryProductDbm MyDBMeta { get { return SummaryProductDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override Entity NewEntity() { return NewMyEntity(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual SummaryProduct NewMyEntity() { return new SummaryProduct(); }
        public virtual SummaryProductCB NewMyConditionBean() { return new SummaryProductCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(SummaryProductCB cb) {
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
        public virtual SummaryProduct SelectEntity(SummaryProductCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<SummaryProduct> ls = null;
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
            return (SummaryProduct)ls[0];
        }

        protected override Entity DoReadEntity(ConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual SummaryProduct SelectEntityWithDeletedCheck(SummaryProductCB cb) {
            AssertConditionBeanNotNull(cb);
            SummaryProduct entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override Entity DoReadEntityWithDeletedCheck(ConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual SummaryProduct SelectByPKValue(int? productId) {
            return SelectEntity(BuildPKCB(productId));
        }

        public virtual SummaryProduct SelectByPKValueWithDeletedCheck(int? productId) {
            return SelectEntityWithDeletedCheck(BuildPKCB(productId));
        }

        private SummaryProductCB BuildPKCB(int? productId) {
            AssertObjectNotNull("productId", productId);
            SummaryProductCB cb = NewMyConditionBean();
            cb.Query().SetProductId_Equal(productId);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual ListResultBean<SummaryProduct> SelectList(SummaryProductCB cb) {
            AssertConditionBeanNotNull(cb);
            return new ResultBeanBuilder<SummaryProduct>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual PagingResultBean<SummaryProduct> SelectPage(SummaryProductCB cb) {
            AssertConditionBeanNotNull(cb);
            PagingInvoker<SummaryProduct> invoker = new PagingInvoker<SummaryProduct>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : PagingHandler<SummaryProduct> {
            protected SummaryProductBhv _bhv; protected SummaryProductCB _cb;
            public InternalSelectPagingHandler(SummaryProductBhv bhv, SummaryProductCB cb) { _bhv = bhv; _cb = cb; }
            public PagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<SummaryProduct> Paging() { return _bhv.SelectList(_cb); }
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
        public virtual void Insert(SummaryProduct entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(Entity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(SummaryProduct entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(Entity entity) {
            Update(Downcast(entity));
        }

        public void InsertOrUpdate(SummaryProduct entity) {
            HelpInsertOrUpdateInternally<SummaryProduct, SummaryProductCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<SummaryProduct, SummaryProductCB> {
            protected SummaryProductBhv _bhv;
            public MyInternalInsertOrUpdateCallback(SummaryProductBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(SummaryProduct entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(SummaryProduct entity) { _bhv.Update(entity); }
            public SummaryProductCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(SummaryProductCB cb, SummaryProduct entity) {
                cb.Query().SetProductId_Equal(entity.ProductId);
            }
            public int CallbackSelectCount(SummaryProductCB cb) { return _bhv.SelectCount(cb); }
        }

        public virtual void Delete(SummaryProduct entity) {
            HelpDeleteInternally<SummaryProduct>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(Entity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<SummaryProduct> {
            protected SummaryProductBhv _bhv;
            public MyInternalDeleteCallback(SummaryProductBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(SummaryProduct entity) { return _bhv.DelegateDelete(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(SummaryProduct summaryProduct, SummaryProductCB cb) {
            AssertObjectNotNull("summaryProduct", summaryProduct); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(summaryProduct);
            FilterEntityOfUpdate(summaryProduct); AssertEntityOfUpdate(summaryProduct);
            return this.Dao.UpdateByQuery(cb, summaryProduct);
        }

        public int QueryDelete(SummaryProductCB cb) {
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
        protected int DelegateSelectCount(SummaryProductCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<SummaryProduct> DelegateSelectList(SummaryProductCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(SummaryProduct e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(SummaryProduct e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(SummaryProduct e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected SummaryProduct Downcast(Entity entity) {
            return (SummaryProduct)entity;
        }

        protected SummaryProductCB Downcast(ConditionBean cb) {
            return (SummaryProductCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual SummaryProductDao Dao { get { return _dao; } set { _dao = value; } }
    }
}


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
    public partial class ProductStatusBhv : DfExample.DBFlute.AllCommon.Bhv.AbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected ProductStatusDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public ProductStatusBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "product_status"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override DBMeta DBMeta { get { return ProductStatusDbm.GetInstance(); } }
        public ProductStatusDbm MyDBMeta { get { return ProductStatusDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override Entity NewEntity() { return NewMyEntity(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual ProductStatus NewMyEntity() { return new ProductStatus(); }
        public virtual ProductStatusCB NewMyConditionBean() { return new ProductStatusCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(ProductStatusCB cb) {
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
        public virtual ProductStatus SelectEntity(ProductStatusCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<ProductStatus> ls = null;
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
            return (ProductStatus)ls[0];
        }

        protected override Entity DoReadEntity(ConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual ProductStatus SelectEntityWithDeletedCheck(ProductStatusCB cb) {
            AssertConditionBeanNotNull(cb);
            ProductStatus entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override Entity DoReadEntityWithDeletedCheck(ConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual ProductStatus SelectByPKValue(String productStatusCode) {
            return SelectEntity(BuildPKCB(productStatusCode));
        }

        public virtual ProductStatus SelectByPKValueWithDeletedCheck(String productStatusCode) {
            return SelectEntityWithDeletedCheck(BuildPKCB(productStatusCode));
        }

        private ProductStatusCB BuildPKCB(String productStatusCode) {
            AssertObjectNotNull("productStatusCode", productStatusCode);
            ProductStatusCB cb = NewMyConditionBean();
            cb.Query().SetProductStatusCode_Equal(productStatusCode);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual ListResultBean<ProductStatus> SelectList(ProductStatusCB cb) {
            AssertConditionBeanNotNull(cb);
            return new ResultBeanBuilder<ProductStatus>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual PagingResultBean<ProductStatus> SelectPage(ProductStatusCB cb) {
            AssertConditionBeanNotNull(cb);
            PagingInvoker<ProductStatus> invoker = new PagingInvoker<ProductStatus>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : PagingHandler<ProductStatus> {
            protected ProductStatusBhv _bhv; protected ProductStatusCB _cb;
            public InternalSelectPagingHandler(ProductStatusBhv bhv, ProductStatusCB cb) { _bhv = bhv; _cb = cb; }
            public PagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<ProductStatus> Paging() { return _bhv.SelectList(_cb); }
        }
        #endregion

        // ===============================================================================
        //                                                                   Load Referrer
        //                                                                   =============
        #region Load Referrer
        public virtual void LoadProductList(ProductStatus productStatus, ConditionBeanSetupper<ProductCB> conditionBeanSetupper) {
            AssertObjectNotNull("productStatus", productStatus); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadProductList(xnewLRLs<ProductStatus>(productStatus), conditionBeanSetupper);
        }
        public virtual void LoadProductList(IList<ProductStatus> productStatusList, ConditionBeanSetupper<ProductCB> conditionBeanSetupper) {
            AssertObjectNotNull("productStatusList", productStatusList); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadProductList(productStatusList, new LoadReferrerOption<ProductCB, Product>().xinit(conditionBeanSetupper));
        }
        public virtual void LoadProductList(ProductStatus productStatus, LoadReferrerOption<ProductCB, Product> loadReferrerOption) {
            AssertObjectNotNull("productStatus", productStatus); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            LoadProductList(xnewLRLs<ProductStatus>(productStatus), loadReferrerOption);
        }
        public virtual void LoadProductList(IList<ProductStatus> productStatusList, LoadReferrerOption<ProductCB, Product> loadReferrerOption) {
            AssertObjectNotNull("productStatusList", productStatusList); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            if (productStatusList.Count == 0) { return; }
            ProductBhv referrerBhv = xgetBSFLR().Select<ProductBhv>();
            HelpLoadReferrerInternally<ProductStatus, String, ProductCB, Product>
                    (productStatusList, loadReferrerOption, new MyInternalLoadProductListCallback(referrerBhv));
        }
        protected class MyInternalLoadProductListCallback : InternalLoadReferrerCallback<ProductStatus, String, ProductCB, Product> {
            protected ProductBhv referrerBhv;
            public MyInternalLoadProductListCallback(ProductBhv referrerBhv) { this.referrerBhv = referrerBhv; }
            public String getPKVal(ProductStatus e) { return e.ProductStatusCode; }
            public void setRfLs(ProductStatus e, IList<Product> ls) { e.ProductList = ls; }
            public ProductCB newMyCB() { return referrerBhv.NewMyConditionBean(); }
            public void qyFKIn(ProductCB cb, IList<String> ls) { cb.Query().SetProductStatusCode_InScope(ls); }
            public void qyOdFKAsc(ProductCB cb) { cb.Query().AddOrderBy_ProductStatusCode_Asc(); }
            public void spFKCol(ProductCB cb) { cb.Specify().ColumnProductStatusCode(); }
            public IList<Product> selRfLs(ProductCB cb) { return referrerBhv.SelectList(cb); }
            public String getFKVal(Product e) { return e.ProductStatusCode; }
            public void setlcEt(Product re, ProductStatus be) { re.ProductStatus = be; }
        }
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
        public virtual void Insert(ProductStatus entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(Entity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(ProductStatus entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(Entity entity) {
            Update(Downcast(entity));
        }

        public void InsertOrUpdate(ProductStatus entity) {
            HelpInsertOrUpdateInternally<ProductStatus, ProductStatusCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<ProductStatus, ProductStatusCB> {
            protected ProductStatusBhv _bhv;
            public MyInternalInsertOrUpdateCallback(ProductStatusBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(ProductStatus entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(ProductStatus entity) { _bhv.Update(entity); }
            public ProductStatusCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(ProductStatusCB cb, ProductStatus entity) {
                cb.Query().SetProductStatusCode_Equal(entity.ProductStatusCode);
            }
            public int CallbackSelectCount(ProductStatusCB cb) { return _bhv.SelectCount(cb); }
        }

        public virtual void Delete(ProductStatus entity) {
            HelpDeleteInternally<ProductStatus>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(Entity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<ProductStatus> {
            protected ProductStatusBhv _bhv;
            public MyInternalDeleteCallback(ProductStatusBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(ProductStatus entity) { return _bhv.DelegateDelete(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(ProductStatus productStatus, ProductStatusCB cb) {
            AssertObjectNotNull("productStatus", productStatus); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(productStatus);
            FilterEntityOfUpdate(productStatus); AssertEntityOfUpdate(productStatus);
            return this.Dao.UpdateByQuery(cb, productStatus);
        }

        public int QueryDelete(ProductStatusCB cb) {
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
        protected int DelegateSelectCount(ProductStatusCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<ProductStatus> DelegateSelectList(ProductStatusCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(ProductStatus e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(ProductStatus e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(ProductStatus e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected ProductStatus Downcast(Entity entity) {
            return (ProductStatus)entity;
        }

        protected ProductStatusCB Downcast(ConditionBean cb) {
            return (ProductStatusCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual ProductStatusDao Dao { get { return _dao; } set { _dao = value; } }
    }
}


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
    public partial class ProductBhv : DfExample.DBFlute.AllCommon.Bhv.AbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected ProductDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public ProductBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "PRODUCT"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override DBMeta DBMeta { get { return ProductDbm.GetInstance(); } }
        public ProductDbm MyDBMeta { get { return ProductDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override Entity NewEntity() { return NewMyEntity(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual Product NewMyEntity() { return new Product(); }
        public virtual ProductCB NewMyConditionBean() { return new ProductCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(ProductCB cb) {
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
        public virtual Product SelectEntity(ProductCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<Product> ls = null;
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
            return (Product)ls[0];
        }

        protected override Entity DoReadEntity(ConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual Product SelectEntityWithDeletedCheck(ProductCB cb) {
            AssertConditionBeanNotNull(cb);
            Product entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override Entity DoReadEntityWithDeletedCheck(ConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual Product SelectByPKValue(long? productId) {
            return SelectEntity(BuildPKCB(productId));
        }

        public virtual Product SelectByPKValueWithDeletedCheck(long? productId) {
            return SelectEntityWithDeletedCheck(BuildPKCB(productId));
        }

        private ProductCB BuildPKCB(long? productId) {
            AssertObjectNotNull("productId", productId);
            ProductCB cb = NewMyConditionBean();
            cb.Query().SetProductId_Equal(productId);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual ListResultBean<Product> SelectList(ProductCB cb) {
            AssertConditionBeanNotNull(cb);
            return new ResultBeanBuilder<Product>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual PagingResultBean<Product> SelectPage(ProductCB cb) {
            AssertConditionBeanNotNull(cb);
            PagingInvoker<Product> invoker = new PagingInvoker<Product>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : PagingHandler<Product> {
            protected ProductBhv _bhv; protected ProductCB _cb;
            public InternalSelectPagingHandler(ProductBhv bhv, ProductCB cb) { _bhv = bhv; _cb = cb; }
            public PagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<Product> Paging() { return _bhv.SelectList(_cb); }
        }
        #endregion

        // ===============================================================================
        //                                                                        Sequence
        //                                                                        ========
        public long? SelectNextVal() {
            return DelegateSelectNextVal();
        }
        protected override void SetupNextValueToPrimaryKey(Entity entity) {// Very Internal
            Product myEntity = (Product)entity;
            myEntity.ProductId = SelectNextVal();
        }

        // ===============================================================================
        //                                                                   Load Referrer
        //                                                                   =============
        #region Load Referrer
        public virtual void LoadPurchaseList(Product product, ConditionBeanSetupper<PurchaseCB> conditionBeanSetupper) {
            AssertObjectNotNull("product", product); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadPurchaseList(xnewLRLs<Product>(product), conditionBeanSetupper);
        }
        public virtual void LoadPurchaseList(IList<Product> productList, ConditionBeanSetupper<PurchaseCB> conditionBeanSetupper) {
            AssertObjectNotNull("productList", productList); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadPurchaseList(productList, new LoadReferrerOption<PurchaseCB, Purchase>().xinit(conditionBeanSetupper));
        }
        public virtual void LoadPurchaseList(Product product, LoadReferrerOption<PurchaseCB, Purchase> loadReferrerOption) {
            AssertObjectNotNull("product", product); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            LoadPurchaseList(xnewLRLs<Product>(product), loadReferrerOption);
        }
        public virtual void LoadPurchaseList(IList<Product> productList, LoadReferrerOption<PurchaseCB, Purchase> loadReferrerOption) {
            AssertObjectNotNull("productList", productList); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            if (productList.Count == 0) { return; }
            PurchaseBhv referrerBhv = xgetBSFLR().Select<PurchaseBhv>();
            HelpLoadReferrerInternally<Product, long?, PurchaseCB, Purchase>
                    (productList, loadReferrerOption, new MyInternalLoadPurchaseListCallback(referrerBhv));
        }
        protected class MyInternalLoadPurchaseListCallback : InternalLoadReferrerCallback<Product, long?, PurchaseCB, Purchase> {
            protected PurchaseBhv referrerBhv;
            public MyInternalLoadPurchaseListCallback(PurchaseBhv referrerBhv) { this.referrerBhv = referrerBhv; }
            public long? getPKVal(Product e) { return e.ProductId; }
            public void setRfLs(Product e, IList<Purchase> ls) { e.PurchaseList = ls; }
            public PurchaseCB newMyCB() { return referrerBhv.NewMyConditionBean(); }
            public void qyFKIn(PurchaseCB cb, IList<long?> ls) { cb.Query().SetProductId_InScope(ls); }
            public void qyOdFKAsc(PurchaseCB cb) { cb.Query().AddOrderBy_ProductId_Asc(); }
            public void spFKCol(PurchaseCB cb) { cb.Specify().ColumnProductId(); }
            public IList<Purchase> selRfLs(PurchaseCB cb) { return referrerBhv.SelectList(cb); }
            public long? getFKVal(Purchase e) { return e.ProductId; }
            public void setlcEt(Purchase re, Product be) { re.Product = be; }
        }
        #endregion

        // ===============================================================================
        //                                                                Pull out Foreign
        //                                                                ================
        #region Pullout Foreign
        public IList<ProductStatus> PulloutProductStatus(IList<Product> productList) {
            return HelpPulloutInternally<Product, ProductStatus>(productList, new MyInternalPulloutProductStatusCallback());
        }
        protected class MyInternalPulloutProductStatusCallback : InternalPulloutCallback<Product, ProductStatus> {
            public ProductStatus getFr(Product entity) { return entity.ProductStatus; }
        }
        #endregion


        // ===============================================================================
        //                                                                   Entity Update
        //                                                                   =============
        #region Basic Entity Update
        public virtual void Insert(Product entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(Entity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(Product entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(Entity entity) {
            Update(Downcast(entity));
        }

        public virtual void UpdateNonstrict(Product entity) {
            AssertEntityNotNull(entity);
            int updatedCount = this.DelegateUpdateNonstrict(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        public void InsertOrUpdate(Product entity) {
            HelpInsertOrUpdateInternally<Product, ProductCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<Product, ProductCB> {
            protected ProductBhv _bhv;
            public MyInternalInsertOrUpdateCallback(ProductBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(Product entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(Product entity) { _bhv.Update(entity); }
            public ProductCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(ProductCB cb, Product entity) {
                cb.Query().SetProductId_Equal(entity.ProductId);
            }
            public int CallbackSelectCount(ProductCB cb) { return _bhv.SelectCount(cb); }
        }

        public void InsertOrUpdateNonstrict(Product entity) {
            HelpInsertOrUpdateInternally<Product>(entity, new MyInternalInsertOrUpdateNonstrictCallback(this));
        }
        protected class MyInternalInsertOrUpdateNonstrictCallback : InternalInsertOrUpdateNonstrictCallback<Product> {
            protected ProductBhv _bhv;
            public MyInternalInsertOrUpdateNonstrictCallback(ProductBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(Product entity) { _bhv.Insert(entity); }
            public void CallbackUpdateNonstrict(Product entity) { _bhv.UpdateNonstrict(entity); }
        }

        public virtual void Delete(Product entity) {
            HelpDeleteInternally<Product>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(Entity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<Product> {
            protected ProductBhv _bhv;
            public MyInternalDeleteCallback(ProductBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(Product entity) { return _bhv.DelegateDelete(entity); }
        }

        public virtual void DeleteNonstrict(Product entity) {
            HelpDeleteNonstrictInternally<Product>(entity, new MyInternalDeleteNonstrictCallback(this));
        }
        protected class MyInternalDeleteNonstrictCallback : InternalDeleteNonstrictCallback<Product> {
            protected ProductBhv _bhv;
            public MyInternalDeleteNonstrictCallback(ProductBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDeleteNonstrict(Product entity) { return _bhv.DelegateDeleteNonstrict(entity); }
        }

        public virtual void DeleteNonstrictIgnoreDeleted(Product entity) {
            HelpDeleteNonstrictIgnoreDeletedInternally<Product>(entity, new MyInternalDeleteNonstrictIgnoreDeletedCallback(this));
        }
        protected class MyInternalDeleteNonstrictIgnoreDeletedCallback : InternalDeleteNonstrictIgnoreDeletedCallback<Product> {
            protected ProductBhv _bhv;
            public MyInternalDeleteNonstrictIgnoreDeletedCallback(ProductBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDeleteNonstrict(Product entity) { return _bhv.DelegateDeleteNonstrict(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(Product product, ProductCB cb) {
            AssertObjectNotNull("product", product); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(product);
            FilterEntityOfUpdate(product); AssertEntityOfUpdate(product);
            return this.Dao.UpdateByQuery(cb, product);
        }

        public int QueryDelete(ProductCB cb) {
            AssertConditionBeanNotNull(cb);
            return this.Dao.DeleteByQuery(cb);
        }

        // ===============================================================================
        //                                                            Optimistic Lock Info
        //                                                            ====================
        protected override bool HasVersionNoValue(Entity entity) {
            return Downcast(entity).VersionNo != null;
        }

        protected override bool HasUpdateDateValue(Entity entity) {
            return false;
        }

        // ===============================================================================
        //                                                                 Delegate Method
        //                                                                 ===============
        #region Delegate Method
        protected int DelegateSelectCount(ProductCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<Product> DelegateSelectList(ProductCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }
        protected long? DelegateSelectNextVal() { return this.Dao.SelectNextVal(); }

        protected int DelegateInsert(Product e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(Product e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateModifiedOnly(e); }
        protected int DelegateUpdateNonstrict(Product e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(Product e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.Delete(e); }
        protected int DelegateDeleteNonstrict(Product e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected Product Downcast(Entity entity) {
            return (Product)entity;
        }

        protected ProductCB Downcast(ConditionBean cb) {
            return (ProductCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual ProductDao Dao { get { return _dao; } set { _dao = value; } }
    }
}

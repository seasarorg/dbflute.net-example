
using System;
using System.Collections.Generic;

using Seasar.Quill;
using Seasar.Quill.Attrs;

using DfExample.DBFlute.MemberDb.AllCommon;
using DfExample.DBFlute.MemberDb.AllCommon.Bhv;
using DfExample.DBFlute.MemberDb.AllCommon.Bhv.Load;
using DfExample.DBFlute.MemberDb.AllCommon.Bhv.Setup;
using DfExample.DBFlute.MemberDb.AllCommon.CBean;
using DfExample.DBFlute.MemberDb.AllCommon.Dbm;
using DfExample.DBFlute.MemberDb.AllCommon.Exp;
using DfExample.DBFlute.MemberDb.BsEntity.Dbm;
using DfExample.DBFlute.MemberDb.ExDao;
using DfExample.DBFlute.MemberDb.ExEntity;
using DfExample.DBFlute.MemberDb.CBean;


namespace DfExample.DBFlute.MemberDb.ExBhv {

    [Implementation]
    public partial class MbProductBhv : DfExample.DBFlute.MemberDb.AllCommon.Bhv.MbAbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected MbProductDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public MbProductBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "product"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override MbDBMeta DBMeta { get { return MbProductDbm.GetInstance(); } }
        public MbProductDbm MyDBMeta { get { return MbProductDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override MbEntity NewEntity() { return NewMyEntity(); }
        public override MbConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual MbProduct NewMyEntity() { return new MbProduct(); }
        public virtual MbProductCB NewMyConditionBean() { return new MbProductCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(MbProductCB cb) {
            AssertConditionBeanNotNull(cb);
            return this.DelegateSelectCount(cb);
        }

        protected override int DoReadCount(MbConditionBean cb) {
            return SelectCount(Downcast(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                   Entity Select
        //                                                                   =============
        #region Entity Select
        public virtual MbProduct SelectEntity(MbProductCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<MbProduct> ls = null;
            try {
                ls = this.DelegateSelectList(cb);
            } catch (MbDangerousResultSizeException e) {
                ThrowEntityDuplicatedException("{over safetyMaxResultSize '1'}", cb, e);
                return null; // unreachable
            } finally {
                xrestoreSafetyResult(cb, preSafetyMaxResultSize);
            }
            if (ls.Count == 0) { return null; }
            AssertEntitySelectedAsOne(ls, cb);
            return (MbProduct)ls[0];
        }

        protected override MbEntity DoReadEntity(MbConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual MbProduct SelectEntityWithDeletedCheck(MbProductCB cb) {
            AssertConditionBeanNotNull(cb);
            MbProduct entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override MbEntity DoReadEntityWithDeletedCheck(MbConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual MbProduct SelectByPKValue(int? productId) {
            return SelectEntity(BuildPKCB(productId));
        }

        public virtual MbProduct SelectByPKValueWithDeletedCheck(int? productId) {
            return SelectEntityWithDeletedCheck(BuildPKCB(productId));
        }

        private MbProductCB BuildPKCB(int? productId) {
            AssertObjectNotNull("productId", productId);
            MbProductCB cb = NewMyConditionBean();
            cb.Query().SetProductId_Equal(productId);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual MbListResultBean<MbProduct> SelectList(MbProductCB cb) {
            AssertConditionBeanNotNull(cb);
            return new MbResultBeanBuilder<MbProduct>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual MbPagingResultBean<MbProduct> SelectPage(MbProductCB cb) {
            AssertConditionBeanNotNull(cb);
            MbPagingInvoker<MbProduct> invoker = new MbPagingInvoker<MbProduct>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : MbPagingHandler<MbProduct> {
            protected MbProductBhv _bhv; protected MbProductCB _cb;
            public InternalSelectPagingHandler(MbProductBhv bhv, MbProductCB cb) { _bhv = bhv; _cb = cb; }
            public MbPagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<MbProduct> Paging() { return _bhv.SelectList(_cb); }
        }
        #endregion

        // ===============================================================================
        //                                                                   Load Referrer
        //                                                                   =============
        #region Load Referrer
        public virtual void LoadPurchaseList(MbProduct product, MbConditionBeanSetupper<MbPurchaseCB> conditionBeanSetupper) {
            AssertObjectNotNull("product", product); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadPurchaseList(xnewLRLs<MbProduct>(product), conditionBeanSetupper);
        }
        public virtual void LoadPurchaseList(IList<MbProduct> productList, MbConditionBeanSetupper<MbPurchaseCB> conditionBeanSetupper) {
            AssertObjectNotNull("productList", productList); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadPurchaseList(productList, new MbLoadReferrerOption<MbPurchaseCB, MbPurchase>().xinit(conditionBeanSetupper));
        }
        public virtual void LoadPurchaseList(MbProduct product, MbLoadReferrerOption<MbPurchaseCB, MbPurchase> loadReferrerOption) {
            AssertObjectNotNull("product", product); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            LoadPurchaseList(xnewLRLs<MbProduct>(product), loadReferrerOption);
        }
        public virtual void LoadPurchaseList(IList<MbProduct> productList, MbLoadReferrerOption<MbPurchaseCB, MbPurchase> loadReferrerOption) {
            AssertObjectNotNull("productList", productList); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            if (productList.Count == 0) { return; }
            MbPurchaseBhv referrerBhv = xgetBSFLR().Select<MbPurchaseBhv>();
            HelpLoadReferrerInternally<MbProduct, int?, MbPurchaseCB, MbPurchase>
                    (productList, loadReferrerOption, new MyInternalLoadPurchaseListCallback(referrerBhv));
        }
        protected class MyInternalLoadPurchaseListCallback : InternalLoadReferrerCallback<MbProduct, int?, MbPurchaseCB, MbPurchase> {
            protected MbPurchaseBhv referrerBhv;
            public MyInternalLoadPurchaseListCallback(MbPurchaseBhv referrerBhv) { this.referrerBhv = referrerBhv; }
            public int? getPKVal(MbProduct e) { return e.ProductId; }
            public void setRfLs(MbProduct e, IList<MbPurchase> ls) { e.PurchaseList = ls; }
            public MbPurchaseCB newMyCB() { return referrerBhv.NewMyConditionBean(); }
            public void qyFKIn(MbPurchaseCB cb, IList<int?> ls) { cb.Query().SetProductId_InScope(ls); }
            public void qyOdFKAsc(MbPurchaseCB cb) { cb.Query().AddOrderBy_ProductId_Asc(); }
            public void spFKCol(MbPurchaseCB cb) { cb.Specify().ColumnProductId(); }
            public IList<MbPurchase> selRfLs(MbPurchaseCB cb) { return referrerBhv.SelectList(cb); }
            public int? getFKVal(MbPurchase e) { return e.ProductId; }
            public void setlcEt(MbPurchase re, MbProduct be) { re.Product = be; }
        }
        #endregion

        // ===============================================================================
        //                                                                Pull out Foreign
        //                                                                ================
        #region Pullout Foreign
        public IList<MbProductStatus> PulloutProductStatus(IList<MbProduct> productList) {
            return HelpPulloutInternally<MbProduct, MbProductStatus>(productList, new MyInternalPulloutProductStatusCallback());
        }
        protected class MyInternalPulloutProductStatusCallback : InternalPulloutCallback<MbProduct, MbProductStatus> {
            public MbProductStatus getFr(MbProduct entity) { return entity.ProductStatus; }
        }
        #endregion


        // ===============================================================================
        //                                                                   Entity Update
        //                                                                   =============
        #region Basic Entity Update
        public virtual void Insert(MbProduct entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(MbEntity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(MbProduct entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(MbEntity entity) {
            Update(Downcast(entity));
        }

        public virtual void UpdateNonstrict(MbProduct entity) {
            AssertEntityNotNull(entity);
            int updatedCount = this.DelegateUpdateNonstrict(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        public void InsertOrUpdate(MbProduct entity) {
            HelpInsertOrUpdateInternally<MbProduct, MbProductCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<MbProduct, MbProductCB> {
            protected MbProductBhv _bhv;
            public MyInternalInsertOrUpdateCallback(MbProductBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(MbProduct entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(MbProduct entity) { _bhv.Update(entity); }
            public MbProductCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(MbProductCB cb, MbProduct entity) {
                cb.Query().SetProductId_Equal(entity.ProductId);
            }
            public int CallbackSelectCount(MbProductCB cb) { return _bhv.SelectCount(cb); }
        }

        public void InsertOrUpdateNonstrict(MbProduct entity) {
            HelpInsertOrUpdateInternally<MbProduct>(entity, new MyInternalInsertOrUpdateNonstrictCallback(this));
        }
        protected class MyInternalInsertOrUpdateNonstrictCallback : InternalInsertOrUpdateNonstrictCallback<MbProduct> {
            protected MbProductBhv _bhv;
            public MyInternalInsertOrUpdateNonstrictCallback(MbProductBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(MbProduct entity) { _bhv.Insert(entity); }
            public void CallbackUpdateNonstrict(MbProduct entity) { _bhv.UpdateNonstrict(entity); }
        }

        public virtual void Delete(MbProduct entity) {
            HelpDeleteInternally<MbProduct>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(MbEntity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<MbProduct> {
            protected MbProductBhv _bhv;
            public MyInternalDeleteCallback(MbProductBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(MbProduct entity) { return _bhv.DelegateDelete(entity); }
        }

        public virtual void DeleteNonstrict(MbProduct entity) {
            HelpDeleteNonstrictInternally<MbProduct>(entity, new MyInternalDeleteNonstrictCallback(this));
        }
        protected class MyInternalDeleteNonstrictCallback : InternalDeleteNonstrictCallback<MbProduct> {
            protected MbProductBhv _bhv;
            public MyInternalDeleteNonstrictCallback(MbProductBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDeleteNonstrict(MbProduct entity) { return _bhv.DelegateDeleteNonstrict(entity); }
        }

        public virtual void DeleteNonstrictIgnoreDeleted(MbProduct entity) {
            HelpDeleteNonstrictIgnoreDeletedInternally<MbProduct>(entity, new MyInternalDeleteNonstrictIgnoreDeletedCallback(this));
        }
        protected class MyInternalDeleteNonstrictIgnoreDeletedCallback : InternalDeleteNonstrictIgnoreDeletedCallback<MbProduct> {
            protected MbProductBhv _bhv;
            public MyInternalDeleteNonstrictIgnoreDeletedCallback(MbProductBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDeleteNonstrict(MbProduct entity) { return _bhv.DelegateDeleteNonstrict(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(MbProduct product, MbProductCB cb) {
            AssertObjectNotNull("product", product); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(product);
            FilterEntityOfUpdate(product); AssertEntityOfUpdate(product);
            return this.Dao.UpdateByQuery(cb, product);
        }

        public int QueryDelete(MbProductCB cb) {
            AssertConditionBeanNotNull(cb);
            return this.Dao.DeleteByQuery(cb);
        }

        // ===============================================================================
        //                                                            Optimistic Lock Info
        //                                                            ====================
        protected override bool HasVersionNoValue(MbEntity entity) {
            return Downcast(entity).VersionNo != null;
        }

        protected override bool HasUpdateDateValue(MbEntity entity) {
            return false;
        }

        // ===============================================================================
        //                                                                 Delegate Method
        //                                                                 ===============
        #region Delegate Method
        protected int DelegateSelectCount(MbProductCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<MbProduct> DelegateSelectList(MbProductCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(MbProduct e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(MbProduct e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateModifiedOnly(e); }
        protected int DelegateUpdateNonstrict(MbProduct e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(MbProduct e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.Delete(e); }
        protected int DelegateDeleteNonstrict(MbProduct e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected MbProduct Downcast(MbEntity entity) {
            return (MbProduct)entity;
        }

        protected MbProductCB Downcast(MbConditionBean cb) {
            return (MbProductCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual MbProductDao Dao { get { return _dao; } set { _dao = value; } }
    }
}


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
    public partial class MbProductStatusBhv : DfExample.DBFlute.MemberDb.AllCommon.Bhv.MbAbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected MbProductStatusDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public MbProductStatusBhv() {
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
        public override MbDBMeta DBMeta { get { return MbProductStatusDbm.GetInstance(); } }
        public MbProductStatusDbm MyDBMeta { get { return MbProductStatusDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override MbEntity NewEntity() { return NewMyEntity(); }
        public override MbConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual MbProductStatus NewMyEntity() { return new MbProductStatus(); }
        public virtual MbProductStatusCB NewMyConditionBean() { return new MbProductStatusCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(MbProductStatusCB cb) {
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
        public virtual MbProductStatus SelectEntity(MbProductStatusCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<MbProductStatus> ls = null;
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
            return (MbProductStatus)ls[0];
        }

        protected override MbEntity DoReadEntity(MbConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual MbProductStatus SelectEntityWithDeletedCheck(MbProductStatusCB cb) {
            AssertConditionBeanNotNull(cb);
            MbProductStatus entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override MbEntity DoReadEntityWithDeletedCheck(MbConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual MbProductStatus SelectByPKValue(String productStatusCode) {
            return SelectEntity(BuildPKCB(productStatusCode));
        }

        public virtual MbProductStatus SelectByPKValueWithDeletedCheck(String productStatusCode) {
            return SelectEntityWithDeletedCheck(BuildPKCB(productStatusCode));
        }

        private MbProductStatusCB BuildPKCB(String productStatusCode) {
            AssertObjectNotNull("productStatusCode", productStatusCode);
            MbProductStatusCB cb = NewMyConditionBean();
            cb.Query().SetProductStatusCode_Equal(productStatusCode);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual MbListResultBean<MbProductStatus> SelectList(MbProductStatusCB cb) {
            AssertConditionBeanNotNull(cb);
            return new MbResultBeanBuilder<MbProductStatus>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual MbPagingResultBean<MbProductStatus> SelectPage(MbProductStatusCB cb) {
            AssertConditionBeanNotNull(cb);
            MbPagingInvoker<MbProductStatus> invoker = new MbPagingInvoker<MbProductStatus>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : MbPagingHandler<MbProductStatus> {
            protected MbProductStatusBhv _bhv; protected MbProductStatusCB _cb;
            public InternalSelectPagingHandler(MbProductStatusBhv bhv, MbProductStatusCB cb) { _bhv = bhv; _cb = cb; }
            public MbPagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<MbProductStatus> Paging() { return _bhv.SelectList(_cb); }
        }
        #endregion

        // ===============================================================================
        //                                                                   Load Referrer
        //                                                                   =============
        #region Load Referrer
        public virtual void LoadProductList(MbProductStatus productStatus, MbConditionBeanSetupper<MbProductCB> conditionBeanSetupper) {
            AssertObjectNotNull("productStatus", productStatus); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadProductList(xnewLRLs<MbProductStatus>(productStatus), conditionBeanSetupper);
        }
        public virtual void LoadProductList(IList<MbProductStatus> productStatusList, MbConditionBeanSetupper<MbProductCB> conditionBeanSetupper) {
            AssertObjectNotNull("productStatusList", productStatusList); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadProductList(productStatusList, new MbLoadReferrerOption<MbProductCB, MbProduct>().xinit(conditionBeanSetupper));
        }
        public virtual void LoadProductList(MbProductStatus productStatus, MbLoadReferrerOption<MbProductCB, MbProduct> loadReferrerOption) {
            AssertObjectNotNull("productStatus", productStatus); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            LoadProductList(xnewLRLs<MbProductStatus>(productStatus), loadReferrerOption);
        }
        public virtual void LoadProductList(IList<MbProductStatus> productStatusList, MbLoadReferrerOption<MbProductCB, MbProduct> loadReferrerOption) {
            AssertObjectNotNull("productStatusList", productStatusList); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            if (productStatusList.Count == 0) { return; }
            MbProductBhv referrerBhv = xgetBSFLR().Select<MbProductBhv>();
            HelpLoadReferrerInternally<MbProductStatus, String, MbProductCB, MbProduct>
                    (productStatusList, loadReferrerOption, new MyInternalLoadProductListCallback(referrerBhv));
        }
        protected class MyInternalLoadProductListCallback : InternalLoadReferrerCallback<MbProductStatus, String, MbProductCB, MbProduct> {
            protected MbProductBhv referrerBhv;
            public MyInternalLoadProductListCallback(MbProductBhv referrerBhv) { this.referrerBhv = referrerBhv; }
            public String getPKVal(MbProductStatus e) { return e.ProductStatusCode; }
            public void setRfLs(MbProductStatus e, IList<MbProduct> ls) { e.ProductList = ls; }
            public MbProductCB newMyCB() { return referrerBhv.NewMyConditionBean(); }
            public void qyFKIn(MbProductCB cb, IList<String> ls) { cb.Query().SetProductStatusCode_InScope(ls); }
            public void qyOdFKAsc(MbProductCB cb) { cb.Query().AddOrderBy_ProductStatusCode_Asc(); }
            public void spFKCol(MbProductCB cb) { cb.Specify().ColumnProductStatusCode(); }
            public IList<MbProduct> selRfLs(MbProductCB cb) { return referrerBhv.SelectList(cb); }
            public String getFKVal(MbProduct e) { return e.ProductStatusCode; }
            public void setlcEt(MbProduct re, MbProductStatus be) { re.ProductStatus = be; }
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
        public virtual void Insert(MbProductStatus entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(MbEntity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(MbProductStatus entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(MbEntity entity) {
            Update(Downcast(entity));
        }

        public void InsertOrUpdate(MbProductStatus entity) {
            HelpInsertOrUpdateInternally<MbProductStatus, MbProductStatusCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<MbProductStatus, MbProductStatusCB> {
            protected MbProductStatusBhv _bhv;
            public MyInternalInsertOrUpdateCallback(MbProductStatusBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(MbProductStatus entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(MbProductStatus entity) { _bhv.Update(entity); }
            public MbProductStatusCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(MbProductStatusCB cb, MbProductStatus entity) {
                cb.Query().SetProductStatusCode_Equal(entity.ProductStatusCode);
            }
            public int CallbackSelectCount(MbProductStatusCB cb) { return _bhv.SelectCount(cb); }
        }

        public virtual void Delete(MbProductStatus entity) {
            HelpDeleteInternally<MbProductStatus>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(MbEntity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<MbProductStatus> {
            protected MbProductStatusBhv _bhv;
            public MyInternalDeleteCallback(MbProductStatusBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(MbProductStatus entity) { return _bhv.DelegateDelete(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(MbProductStatus productStatus, MbProductStatusCB cb) {
            AssertObjectNotNull("productStatus", productStatus); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(productStatus);
            FilterEntityOfUpdate(productStatus); AssertEntityOfUpdate(productStatus);
            return this.Dao.UpdateByQuery(cb, productStatus);
        }

        public int QueryDelete(MbProductStatusCB cb) {
            AssertConditionBeanNotNull(cb);
            return this.Dao.DeleteByQuery(cb);
        }

        // ===============================================================================
        //                                                            Optimistic Lock Info
        //                                                            ====================
        protected override bool HasVersionNoValue(MbEntity entity) {
            return false;
        }

        protected override bool HasUpdateDateValue(MbEntity entity) {
            return false;
        }

        // ===============================================================================
        //                                                                 Delegate Method
        //                                                                 ===============
        #region Delegate Method
        protected int DelegateSelectCount(MbProductStatusCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<MbProductStatus> DelegateSelectList(MbProductStatusCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(MbProductStatus e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(MbProductStatus e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(MbProductStatus e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected MbProductStatus Downcast(MbEntity entity) {
            return (MbProductStatus)entity;
        }

        protected MbProductStatusCB Downcast(MbConditionBean cb) {
            return (MbProductStatusCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual MbProductStatusDao Dao { get { return _dao; } set { _dao = value; } }
    }
}

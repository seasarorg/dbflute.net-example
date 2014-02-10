
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
    public partial class VdSynonymProductStatusBhv : DfExample.DBFlute.AllCommon.Bhv.AbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected VdSynonymProductStatusDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public VdSynonymProductStatusBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "VD_SYNONYM_PRODUCT_STATUS"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override DBMeta DBMeta { get { return VdSynonymProductStatusDbm.GetInstance(); } }
        public VdSynonymProductStatusDbm MyDBMeta { get { return VdSynonymProductStatusDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override Entity NewEntity() { return NewMyEntity(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual VdSynonymProductStatus NewMyEntity() { return new VdSynonymProductStatus(); }
        public virtual VdSynonymProductStatusCB NewMyConditionBean() { return new VdSynonymProductStatusCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(VdSynonymProductStatusCB cb) {
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
        public virtual VdSynonymProductStatus SelectEntity(VdSynonymProductStatusCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<VdSynonymProductStatus> ls = null;
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
            return (VdSynonymProductStatus)ls[0];
        }

        protected override Entity DoReadEntity(ConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual VdSynonymProductStatus SelectEntityWithDeletedCheck(VdSynonymProductStatusCB cb) {
            AssertConditionBeanNotNull(cb);
            VdSynonymProductStatus entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override Entity DoReadEntityWithDeletedCheck(ConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual VdSynonymProductStatus SelectByPKValue(String productStatusCode) {
            return SelectEntity(BuildPKCB(productStatusCode));
        }

        public virtual VdSynonymProductStatus SelectByPKValueWithDeletedCheck(String productStatusCode) {
            return SelectEntityWithDeletedCheck(BuildPKCB(productStatusCode));
        }

        private VdSynonymProductStatusCB BuildPKCB(String productStatusCode) {
            AssertObjectNotNull("productStatusCode", productStatusCode);
            VdSynonymProductStatusCB cb = NewMyConditionBean();
            cb.Query().SetProductStatusCode_Equal(productStatusCode);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual ListResultBean<VdSynonymProductStatus> SelectList(VdSynonymProductStatusCB cb) {
            AssertConditionBeanNotNull(cb);
            return new ResultBeanBuilder<VdSynonymProductStatus>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual PagingResultBean<VdSynonymProductStatus> SelectPage(VdSynonymProductStatusCB cb) {
            AssertConditionBeanNotNull(cb);
            PagingInvoker<VdSynonymProductStatus> invoker = new PagingInvoker<VdSynonymProductStatus>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : PagingHandler<VdSynonymProductStatus> {
            protected VdSynonymProductStatusBhv _bhv; protected VdSynonymProductStatusCB _cb;
            public InternalSelectPagingHandler(VdSynonymProductStatusBhv bhv, VdSynonymProductStatusCB cb) { _bhv = bhv; _cb = cb; }
            public PagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<VdSynonymProductStatus> Paging() { return _bhv.SelectList(_cb); }
        }
        #endregion

        // ===============================================================================
        //                                                                   Load Referrer
        //                                                                   =============
        #region Load Referrer
        public virtual void LoadVdSynonymProductList(VdSynonymProductStatus vdSynonymProductStatus, ConditionBeanSetupper<VdSynonymProductCB> conditionBeanSetupper) {
            AssertObjectNotNull("vdSynonymProductStatus", vdSynonymProductStatus); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadVdSynonymProductList(xnewLRLs<VdSynonymProductStatus>(vdSynonymProductStatus), conditionBeanSetupper);
        }
        public virtual void LoadVdSynonymProductList(IList<VdSynonymProductStatus> vdSynonymProductStatusList, ConditionBeanSetupper<VdSynonymProductCB> conditionBeanSetupper) {
            AssertObjectNotNull("vdSynonymProductStatusList", vdSynonymProductStatusList); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadVdSynonymProductList(vdSynonymProductStatusList, new LoadReferrerOption<VdSynonymProductCB, VdSynonymProduct>().xinit(conditionBeanSetupper));
        }
        public virtual void LoadVdSynonymProductList(VdSynonymProductStatus vdSynonymProductStatus, LoadReferrerOption<VdSynonymProductCB, VdSynonymProduct> loadReferrerOption) {
            AssertObjectNotNull("vdSynonymProductStatus", vdSynonymProductStatus); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            LoadVdSynonymProductList(xnewLRLs<VdSynonymProductStatus>(vdSynonymProductStatus), loadReferrerOption);
        }
        public virtual void LoadVdSynonymProductList(IList<VdSynonymProductStatus> vdSynonymProductStatusList, LoadReferrerOption<VdSynonymProductCB, VdSynonymProduct> loadReferrerOption) {
            AssertObjectNotNull("vdSynonymProductStatusList", vdSynonymProductStatusList); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            if (vdSynonymProductStatusList.Count == 0) { return; }
            VdSynonymProductBhv referrerBhv = xgetBSFLR().Select<VdSynonymProductBhv>();
            HelpLoadReferrerInternally<VdSynonymProductStatus, String, VdSynonymProductCB, VdSynonymProduct>
                    (vdSynonymProductStatusList, loadReferrerOption, new MyInternalLoadVdSynonymProductListCallback(referrerBhv));
        }
        protected class MyInternalLoadVdSynonymProductListCallback : InternalLoadReferrerCallback<VdSynonymProductStatus, String, VdSynonymProductCB, VdSynonymProduct> {
            protected VdSynonymProductBhv referrerBhv;
            public MyInternalLoadVdSynonymProductListCallback(VdSynonymProductBhv referrerBhv) { this.referrerBhv = referrerBhv; }
            public String getPKVal(VdSynonymProductStatus e) { return e.ProductStatusCode; }
            public void setRfLs(VdSynonymProductStatus e, IList<VdSynonymProduct> ls) { e.VdSynonymProductList = ls; }
            public VdSynonymProductCB newMyCB() { return referrerBhv.NewMyConditionBean(); }
            public void qyFKIn(VdSynonymProductCB cb, IList<String> ls) { cb.Query().SetProductStatusCode_InScope(ls); }
            public void qyOdFKAsc(VdSynonymProductCB cb) { cb.Query().AddOrderBy_ProductStatusCode_Asc(); }
            public void spFKCol(VdSynonymProductCB cb) { cb.Specify().ColumnProductStatusCode(); }
            public IList<VdSynonymProduct> selRfLs(VdSynonymProductCB cb) { return referrerBhv.SelectList(cb); }
            public String getFKVal(VdSynonymProduct e) { return e.ProductStatusCode; }
            public void setlcEt(VdSynonymProduct re, VdSynonymProductStatus be) { re.VdSynonymProductStatus = be; }
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
        public virtual void Insert(VdSynonymProductStatus entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(Entity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(VdSynonymProductStatus entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(Entity entity) {
            Update(Downcast(entity));
        }

        public void InsertOrUpdate(VdSynonymProductStatus entity) {
            HelpInsertOrUpdateInternally<VdSynonymProductStatus, VdSynonymProductStatusCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<VdSynonymProductStatus, VdSynonymProductStatusCB> {
            protected VdSynonymProductStatusBhv _bhv;
            public MyInternalInsertOrUpdateCallback(VdSynonymProductStatusBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(VdSynonymProductStatus entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(VdSynonymProductStatus entity) { _bhv.Update(entity); }
            public VdSynonymProductStatusCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(VdSynonymProductStatusCB cb, VdSynonymProductStatus entity) {
                cb.Query().SetProductStatusCode_Equal(entity.ProductStatusCode);
            }
            public int CallbackSelectCount(VdSynonymProductStatusCB cb) { return _bhv.SelectCount(cb); }
        }

        public virtual void Delete(VdSynonymProductStatus entity) {
            HelpDeleteInternally<VdSynonymProductStatus>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(Entity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<VdSynonymProductStatus> {
            protected VdSynonymProductStatusBhv _bhv;
            public MyInternalDeleteCallback(VdSynonymProductStatusBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(VdSynonymProductStatus entity) { return _bhv.DelegateDelete(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(VdSynonymProductStatus vdSynonymProductStatus, VdSynonymProductStatusCB cb) {
            AssertObjectNotNull("vdSynonymProductStatus", vdSynonymProductStatus); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(vdSynonymProductStatus);
            FilterEntityOfUpdate(vdSynonymProductStatus); AssertEntityOfUpdate(vdSynonymProductStatus);
            return this.Dao.UpdateByQuery(cb, vdSynonymProductStatus);
        }

        public int QueryDelete(VdSynonymProductStatusCB cb) {
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
        protected int DelegateSelectCount(VdSynonymProductStatusCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<VdSynonymProductStatus> DelegateSelectList(VdSynonymProductStatusCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(VdSynonymProductStatus e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(VdSynonymProductStatus e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(VdSynonymProductStatus e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected VdSynonymProductStatus Downcast(Entity entity) {
            return (VdSynonymProductStatus)entity;
        }

        protected VdSynonymProductStatusCB Downcast(ConditionBean cb) {
            return (VdSynonymProductStatusCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual VdSynonymProductStatusDao Dao { get { return _dao; } set { _dao = value; } }
    }
}

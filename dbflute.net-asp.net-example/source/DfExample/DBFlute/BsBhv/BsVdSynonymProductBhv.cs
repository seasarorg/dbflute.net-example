
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
    public partial class VdSynonymProductBhv : DfExample.DBFlute.AllCommon.Bhv.AbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected VdSynonymProductDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public VdSynonymProductBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "VD_SYNONYM_PRODUCT"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override DBMeta DBMeta { get { return VdSynonymProductDbm.GetInstance(); } }
        public VdSynonymProductDbm MyDBMeta { get { return VdSynonymProductDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override Entity NewEntity() { return NewMyEntity(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual VdSynonymProduct NewMyEntity() { return new VdSynonymProduct(); }
        public virtual VdSynonymProductCB NewMyConditionBean() { return new VdSynonymProductCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(VdSynonymProductCB cb) {
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
        public virtual VdSynonymProduct SelectEntity(VdSynonymProductCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<VdSynonymProduct> ls = null;
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
            return (VdSynonymProduct)ls[0];
        }

        protected override Entity DoReadEntity(ConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual VdSynonymProduct SelectEntityWithDeletedCheck(VdSynonymProductCB cb) {
            AssertConditionBeanNotNull(cb);
            VdSynonymProduct entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override Entity DoReadEntityWithDeletedCheck(ConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual VdSynonymProduct SelectByPKValue(long? productId) {
            return SelectEntity(BuildPKCB(productId));
        }

        public virtual VdSynonymProduct SelectByPKValueWithDeletedCheck(long? productId) {
            return SelectEntityWithDeletedCheck(BuildPKCB(productId));
        }

        private VdSynonymProductCB BuildPKCB(long? productId) {
            AssertObjectNotNull("productId", productId);
            VdSynonymProductCB cb = NewMyConditionBean();
            cb.Query().SetProductId_Equal(productId);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual ListResultBean<VdSynonymProduct> SelectList(VdSynonymProductCB cb) {
            AssertConditionBeanNotNull(cb);
            return new ResultBeanBuilder<VdSynonymProduct>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual PagingResultBean<VdSynonymProduct> SelectPage(VdSynonymProductCB cb) {
            AssertConditionBeanNotNull(cb);
            PagingInvoker<VdSynonymProduct> invoker = new PagingInvoker<VdSynonymProduct>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : PagingHandler<VdSynonymProduct> {
            protected VdSynonymProductBhv _bhv; protected VdSynonymProductCB _cb;
            public InternalSelectPagingHandler(VdSynonymProductBhv bhv, VdSynonymProductCB cb) { _bhv = bhv; _cb = cb; }
            public PagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<VdSynonymProduct> Paging() { return _bhv.SelectList(_cb); }
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
        public IList<VdSynonymProductStatus> PulloutVdSynonymProductStatus(IList<VdSynonymProduct> vdSynonymProductList) {
            return HelpPulloutInternally<VdSynonymProduct, VdSynonymProductStatus>(vdSynonymProductList, new MyInternalPulloutVdSynonymProductStatusCallback());
        }
        protected class MyInternalPulloutVdSynonymProductStatusCallback : InternalPulloutCallback<VdSynonymProduct, VdSynonymProductStatus> {
            public VdSynonymProductStatus getFr(VdSynonymProduct entity) { return entity.VdSynonymProductStatus; }
        }
        #endregion


        // ===============================================================================
        //                                                                   Entity Update
        //                                                                   =============
        #region Basic Entity Update
        public virtual void Insert(VdSynonymProduct entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(Entity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(VdSynonymProduct entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(Entity entity) {
            Update(Downcast(entity));
        }

        public virtual void UpdateNonstrict(VdSynonymProduct entity) {
            AssertEntityNotNull(entity);
            int updatedCount = this.DelegateUpdateNonstrict(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        public void InsertOrUpdate(VdSynonymProduct entity) {
            HelpInsertOrUpdateInternally<VdSynonymProduct, VdSynonymProductCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<VdSynonymProduct, VdSynonymProductCB> {
            protected VdSynonymProductBhv _bhv;
            public MyInternalInsertOrUpdateCallback(VdSynonymProductBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(VdSynonymProduct entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(VdSynonymProduct entity) { _bhv.Update(entity); }
            public VdSynonymProductCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(VdSynonymProductCB cb, VdSynonymProduct entity) {
                cb.Query().SetProductId_Equal(entity.ProductId);
            }
            public int CallbackSelectCount(VdSynonymProductCB cb) { return _bhv.SelectCount(cb); }
        }

        public void InsertOrUpdateNonstrict(VdSynonymProduct entity) {
            HelpInsertOrUpdateInternally<VdSynonymProduct>(entity, new MyInternalInsertOrUpdateNonstrictCallback(this));
        }
        protected class MyInternalInsertOrUpdateNonstrictCallback : InternalInsertOrUpdateNonstrictCallback<VdSynonymProduct> {
            protected VdSynonymProductBhv _bhv;
            public MyInternalInsertOrUpdateNonstrictCallback(VdSynonymProductBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(VdSynonymProduct entity) { _bhv.Insert(entity); }
            public void CallbackUpdateNonstrict(VdSynonymProduct entity) { _bhv.UpdateNonstrict(entity); }
        }

        public virtual void Delete(VdSynonymProduct entity) {
            HelpDeleteInternally<VdSynonymProduct>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(Entity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<VdSynonymProduct> {
            protected VdSynonymProductBhv _bhv;
            public MyInternalDeleteCallback(VdSynonymProductBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(VdSynonymProduct entity) { return _bhv.DelegateDelete(entity); }
        }

        public virtual void DeleteNonstrict(VdSynonymProduct entity) {
            HelpDeleteNonstrictInternally<VdSynonymProduct>(entity, new MyInternalDeleteNonstrictCallback(this));
        }
        protected class MyInternalDeleteNonstrictCallback : InternalDeleteNonstrictCallback<VdSynonymProduct> {
            protected VdSynonymProductBhv _bhv;
            public MyInternalDeleteNonstrictCallback(VdSynonymProductBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDeleteNonstrict(VdSynonymProduct entity) { return _bhv.DelegateDeleteNonstrict(entity); }
        }

        public virtual void DeleteNonstrictIgnoreDeleted(VdSynonymProduct entity) {
            HelpDeleteNonstrictIgnoreDeletedInternally<VdSynonymProduct>(entity, new MyInternalDeleteNonstrictIgnoreDeletedCallback(this));
        }
        protected class MyInternalDeleteNonstrictIgnoreDeletedCallback : InternalDeleteNonstrictIgnoreDeletedCallback<VdSynonymProduct> {
            protected VdSynonymProductBhv _bhv;
            public MyInternalDeleteNonstrictIgnoreDeletedCallback(VdSynonymProductBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDeleteNonstrict(VdSynonymProduct entity) { return _bhv.DelegateDeleteNonstrict(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(VdSynonymProduct vdSynonymProduct, VdSynonymProductCB cb) {
            AssertObjectNotNull("vdSynonymProduct", vdSynonymProduct); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(vdSynonymProduct);
            FilterEntityOfUpdate(vdSynonymProduct); AssertEntityOfUpdate(vdSynonymProduct);
            return this.Dao.UpdateByQuery(cb, vdSynonymProduct);
        }

        public int QueryDelete(VdSynonymProductCB cb) {
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
        protected int DelegateSelectCount(VdSynonymProductCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<VdSynonymProduct> DelegateSelectList(VdSynonymProductCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(VdSynonymProduct e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(VdSynonymProduct e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateModifiedOnly(e); }
        protected int DelegateUpdateNonstrict(VdSynonymProduct e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(VdSynonymProduct e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.Delete(e); }
        protected int DelegateDeleteNonstrict(VdSynonymProduct e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected VdSynonymProduct Downcast(Entity entity) {
            return (VdSynonymProduct)entity;
        }

        protected VdSynonymProductCB Downcast(ConditionBean cb) {
            return (VdSynonymProductCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual VdSynonymProductDao Dao { get { return _dao; } set { _dao = value; } }
    }
}

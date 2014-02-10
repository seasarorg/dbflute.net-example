
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
    public partial class VendorRefTargetBhv : DfExample.DBFlute.AllCommon.Bhv.AbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected VendorRefTargetDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public VendorRefTargetBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "VENDOR_REF_TARGET"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override DBMeta DBMeta { get { return VendorRefTargetDbm.GetInstance(); } }
        public VendorRefTargetDbm MyDBMeta { get { return VendorRefTargetDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override Entity NewEntity() { return NewMyEntity(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual VendorRefTarget NewMyEntity() { return new VendorRefTarget(); }
        public virtual VendorRefTargetCB NewMyConditionBean() { return new VendorRefTargetCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(VendorRefTargetCB cb) {
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
        public virtual VendorRefTarget SelectEntity(VendorRefTargetCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<VendorRefTarget> ls = null;
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
            return (VendorRefTarget)ls[0];
        }

        protected override Entity DoReadEntity(ConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual VendorRefTarget SelectEntityWithDeletedCheck(VendorRefTargetCB cb) {
            AssertConditionBeanNotNull(cb);
            VendorRefTarget entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override Entity DoReadEntityWithDeletedCheck(ConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual VendorRefTarget SelectByPKValue(long? vendorRefTargetId) {
            return SelectEntity(BuildPKCB(vendorRefTargetId));
        }

        public virtual VendorRefTarget SelectByPKValueWithDeletedCheck(long? vendorRefTargetId) {
            return SelectEntityWithDeletedCheck(BuildPKCB(vendorRefTargetId));
        }

        private VendorRefTargetCB BuildPKCB(long? vendorRefTargetId) {
            AssertObjectNotNull("vendorRefTargetId", vendorRefTargetId);
            VendorRefTargetCB cb = NewMyConditionBean();
            cb.Query().SetVendorRefTargetId_Equal(vendorRefTargetId);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual ListResultBean<VendorRefTarget> SelectList(VendorRefTargetCB cb) {
            AssertConditionBeanNotNull(cb);
            return new ResultBeanBuilder<VendorRefTarget>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual PagingResultBean<VendorRefTarget> SelectPage(VendorRefTargetCB cb) {
            AssertConditionBeanNotNull(cb);
            PagingInvoker<VendorRefTarget> invoker = new PagingInvoker<VendorRefTarget>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : PagingHandler<VendorRefTarget> {
            protected VendorRefTargetBhv _bhv; protected VendorRefTargetCB _cb;
            public InternalSelectPagingHandler(VendorRefTargetBhv bhv, VendorRefTargetCB cb) { _bhv = bhv; _cb = cb; }
            public PagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<VendorRefTarget> Paging() { return _bhv.SelectList(_cb); }
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
        public IList<VendorTarget> PulloutVendorTarget(IList<VendorRefTarget> vendorRefTargetList) {
            return HelpPulloutInternally<VendorRefTarget, VendorTarget>(vendorRefTargetList, new MyInternalPulloutVendorTargetCallback());
        }
        protected class MyInternalPulloutVendorTargetCallback : InternalPulloutCallback<VendorRefTarget, VendorTarget> {
            public VendorTarget getFr(VendorRefTarget entity) { return entity.VendorTarget; }
        }
        #endregion


        // ===============================================================================
        //                                                                   Entity Update
        //                                                                   =============
        #region Basic Entity Update
        public virtual void Insert(VendorRefTarget entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(Entity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(VendorRefTarget entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(Entity entity) {
            Update(Downcast(entity));
        }

        public void InsertOrUpdate(VendorRefTarget entity) {
            HelpInsertOrUpdateInternally<VendorRefTarget, VendorRefTargetCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<VendorRefTarget, VendorRefTargetCB> {
            protected VendorRefTargetBhv _bhv;
            public MyInternalInsertOrUpdateCallback(VendorRefTargetBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(VendorRefTarget entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(VendorRefTarget entity) { _bhv.Update(entity); }
            public VendorRefTargetCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(VendorRefTargetCB cb, VendorRefTarget entity) {
                cb.Query().SetVendorRefTargetId_Equal(entity.VendorRefTargetId);
            }
            public int CallbackSelectCount(VendorRefTargetCB cb) { return _bhv.SelectCount(cb); }
        }

        public virtual void Delete(VendorRefTarget entity) {
            HelpDeleteInternally<VendorRefTarget>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(Entity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<VendorRefTarget> {
            protected VendorRefTargetBhv _bhv;
            public MyInternalDeleteCallback(VendorRefTargetBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(VendorRefTarget entity) { return _bhv.DelegateDelete(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(VendorRefTarget vendorRefTarget, VendorRefTargetCB cb) {
            AssertObjectNotNull("vendorRefTarget", vendorRefTarget); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(vendorRefTarget);
            FilterEntityOfUpdate(vendorRefTarget); AssertEntityOfUpdate(vendorRefTarget);
            return this.Dao.UpdateByQuery(cb, vendorRefTarget);
        }

        public int QueryDelete(VendorRefTargetCB cb) {
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
        protected int DelegateSelectCount(VendorRefTargetCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<VendorRefTarget> DelegateSelectList(VendorRefTargetCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(VendorRefTarget e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(VendorRefTarget e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(VendorRefTarget e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected VendorRefTarget Downcast(Entity entity) {
            return (VendorRefTarget)entity;
        }

        protected VendorRefTargetCB Downcast(ConditionBean cb) {
            return (VendorRefTargetCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual VendorRefTargetDao Dao { get { return _dao; } set { _dao = value; } }
    }
}

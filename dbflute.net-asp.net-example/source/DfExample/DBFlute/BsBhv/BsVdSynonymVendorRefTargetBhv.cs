
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
    public partial class VdSynonymVendorRefTargetBhv : DfExample.DBFlute.AllCommon.Bhv.AbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected VdSynonymVendorRefTargetDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public VdSynonymVendorRefTargetBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "VD_SYNONYM_VENDOR_REF_TARGET"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override DBMeta DBMeta { get { return VdSynonymVendorRefTargetDbm.GetInstance(); } }
        public VdSynonymVendorRefTargetDbm MyDBMeta { get { return VdSynonymVendorRefTargetDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override Entity NewEntity() { return NewMyEntity(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual VdSynonymVendorRefTarget NewMyEntity() { return new VdSynonymVendorRefTarget(); }
        public virtual VdSynonymVendorRefTargetCB NewMyConditionBean() { return new VdSynonymVendorRefTargetCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(VdSynonymVendorRefTargetCB cb) {
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
        public virtual VdSynonymVendorRefTarget SelectEntity(VdSynonymVendorRefTargetCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<VdSynonymVendorRefTarget> ls = null;
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
            return (VdSynonymVendorRefTarget)ls[0];
        }

        protected override Entity DoReadEntity(ConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual VdSynonymVendorRefTarget SelectEntityWithDeletedCheck(VdSynonymVendorRefTargetCB cb) {
            AssertConditionBeanNotNull(cb);
            VdSynonymVendorRefTarget entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override Entity DoReadEntityWithDeletedCheck(ConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual VdSynonymVendorRefTarget SelectByPKValue(long? vendorRefTargetId) {
            return SelectEntity(BuildPKCB(vendorRefTargetId));
        }

        public virtual VdSynonymVendorRefTarget SelectByPKValueWithDeletedCheck(long? vendorRefTargetId) {
            return SelectEntityWithDeletedCheck(BuildPKCB(vendorRefTargetId));
        }

        private VdSynonymVendorRefTargetCB BuildPKCB(long? vendorRefTargetId) {
            AssertObjectNotNull("vendorRefTargetId", vendorRefTargetId);
            VdSynonymVendorRefTargetCB cb = NewMyConditionBean();
            cb.Query().SetVendorRefTargetId_Equal(vendorRefTargetId);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual ListResultBean<VdSynonymVendorRefTarget> SelectList(VdSynonymVendorRefTargetCB cb) {
            AssertConditionBeanNotNull(cb);
            return new ResultBeanBuilder<VdSynonymVendorRefTarget>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual PagingResultBean<VdSynonymVendorRefTarget> SelectPage(VdSynonymVendorRefTargetCB cb) {
            AssertConditionBeanNotNull(cb);
            PagingInvoker<VdSynonymVendorRefTarget> invoker = new PagingInvoker<VdSynonymVendorRefTarget>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : PagingHandler<VdSynonymVendorRefTarget> {
            protected VdSynonymVendorRefTargetBhv _bhv; protected VdSynonymVendorRefTargetCB _cb;
            public InternalSelectPagingHandler(VdSynonymVendorRefTargetBhv bhv, VdSynonymVendorRefTargetCB cb) { _bhv = bhv; _cb = cb; }
            public PagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<VdSynonymVendorRefTarget> Paging() { return _bhv.SelectList(_cb); }
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
        public IList<VdSynonymVendorTarget> PulloutVdSynonymVendorTarget(IList<VdSynonymVendorRefTarget> vdSynonymVendorRefTargetList) {
            return HelpPulloutInternally<VdSynonymVendorRefTarget, VdSynonymVendorTarget>(vdSynonymVendorRefTargetList, new MyInternalPulloutVdSynonymVendorTargetCallback());
        }
        protected class MyInternalPulloutVdSynonymVendorTargetCallback : InternalPulloutCallback<VdSynonymVendorRefTarget, VdSynonymVendorTarget> {
            public VdSynonymVendorTarget getFr(VdSynonymVendorRefTarget entity) { return entity.VdSynonymVendorTarget; }
        }
        #endregion


        // ===============================================================================
        //                                                                   Entity Update
        //                                                                   =============
        #region Basic Entity Update
        public virtual void Insert(VdSynonymVendorRefTarget entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(Entity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(VdSynonymVendorRefTarget entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(Entity entity) {
            Update(Downcast(entity));
        }

        public void InsertOrUpdate(VdSynonymVendorRefTarget entity) {
            HelpInsertOrUpdateInternally<VdSynonymVendorRefTarget, VdSynonymVendorRefTargetCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<VdSynonymVendorRefTarget, VdSynonymVendorRefTargetCB> {
            protected VdSynonymVendorRefTargetBhv _bhv;
            public MyInternalInsertOrUpdateCallback(VdSynonymVendorRefTargetBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(VdSynonymVendorRefTarget entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(VdSynonymVendorRefTarget entity) { _bhv.Update(entity); }
            public VdSynonymVendorRefTargetCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(VdSynonymVendorRefTargetCB cb, VdSynonymVendorRefTarget entity) {
                cb.Query().SetVendorRefTargetId_Equal(entity.VendorRefTargetId);
            }
            public int CallbackSelectCount(VdSynonymVendorRefTargetCB cb) { return _bhv.SelectCount(cb); }
        }

        public virtual void Delete(VdSynonymVendorRefTarget entity) {
            HelpDeleteInternally<VdSynonymVendorRefTarget>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(Entity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<VdSynonymVendorRefTarget> {
            protected VdSynonymVendorRefTargetBhv _bhv;
            public MyInternalDeleteCallback(VdSynonymVendorRefTargetBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(VdSynonymVendorRefTarget entity) { return _bhv.DelegateDelete(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(VdSynonymVendorRefTarget vdSynonymVendorRefTarget, VdSynonymVendorRefTargetCB cb) {
            AssertObjectNotNull("vdSynonymVendorRefTarget", vdSynonymVendorRefTarget); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(vdSynonymVendorRefTarget);
            FilterEntityOfUpdate(vdSynonymVendorRefTarget); AssertEntityOfUpdate(vdSynonymVendorRefTarget);
            return this.Dao.UpdateByQuery(cb, vdSynonymVendorRefTarget);
        }

        public int QueryDelete(VdSynonymVendorRefTargetCB cb) {
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
        protected int DelegateSelectCount(VdSynonymVendorRefTargetCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<VdSynonymVendorRefTarget> DelegateSelectList(VdSynonymVendorRefTargetCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(VdSynonymVendorRefTarget e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(VdSynonymVendorRefTarget e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(VdSynonymVendorRefTarget e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected VdSynonymVendorRefTarget Downcast(Entity entity) {
            return (VdSynonymVendorRefTarget)entity;
        }

        protected VdSynonymVendorRefTargetCB Downcast(ConditionBean cb) {
            return (VdSynonymVendorRefTargetCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual VdSynonymVendorRefTargetDao Dao { get { return _dao; } set { _dao = value; } }
    }
}

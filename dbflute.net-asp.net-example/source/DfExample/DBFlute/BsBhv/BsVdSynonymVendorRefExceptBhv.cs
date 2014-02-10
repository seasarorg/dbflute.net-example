
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
    public partial class VdSynonymVendorRefExceptBhv : DfExample.DBFlute.AllCommon.Bhv.AbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected VdSynonymVendorRefExceptDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public VdSynonymVendorRefExceptBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "VD_SYNONYM_VENDOR_REF_EXCEPT"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override DBMeta DBMeta { get { return VdSynonymVendorRefExceptDbm.GetInstance(); } }
        public VdSynonymVendorRefExceptDbm MyDBMeta { get { return VdSynonymVendorRefExceptDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override Entity NewEntity() { return NewMyEntity(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual VdSynonymVendorRefExcept NewMyEntity() { return new VdSynonymVendorRefExcept(); }
        public virtual VdSynonymVendorRefExceptCB NewMyConditionBean() { return new VdSynonymVendorRefExceptCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(VdSynonymVendorRefExceptCB cb) {
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
        public virtual VdSynonymVendorRefExcept SelectEntity(VdSynonymVendorRefExceptCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<VdSynonymVendorRefExcept> ls = null;
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
            return (VdSynonymVendorRefExcept)ls[0];
        }

        protected override Entity DoReadEntity(ConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual VdSynonymVendorRefExcept SelectEntityWithDeletedCheck(VdSynonymVendorRefExceptCB cb) {
            AssertConditionBeanNotNull(cb);
            VdSynonymVendorRefExcept entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override Entity DoReadEntityWithDeletedCheck(ConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual VdSynonymVendorRefExcept SelectByPKValue(long? vendorRefExceptId) {
            return SelectEntity(BuildPKCB(vendorRefExceptId));
        }

        public virtual VdSynonymVendorRefExcept SelectByPKValueWithDeletedCheck(long? vendorRefExceptId) {
            return SelectEntityWithDeletedCheck(BuildPKCB(vendorRefExceptId));
        }

        private VdSynonymVendorRefExceptCB BuildPKCB(long? vendorRefExceptId) {
            AssertObjectNotNull("vendorRefExceptId", vendorRefExceptId);
            VdSynonymVendorRefExceptCB cb = NewMyConditionBean();
            cb.Query().SetVendorRefExceptId_Equal(vendorRefExceptId);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual ListResultBean<VdSynonymVendorRefExcept> SelectList(VdSynonymVendorRefExceptCB cb) {
            AssertConditionBeanNotNull(cb);
            return new ResultBeanBuilder<VdSynonymVendorRefExcept>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual PagingResultBean<VdSynonymVendorRefExcept> SelectPage(VdSynonymVendorRefExceptCB cb) {
            AssertConditionBeanNotNull(cb);
            PagingInvoker<VdSynonymVendorRefExcept> invoker = new PagingInvoker<VdSynonymVendorRefExcept>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : PagingHandler<VdSynonymVendorRefExcept> {
            protected VdSynonymVendorRefExceptBhv _bhv; protected VdSynonymVendorRefExceptCB _cb;
            public InternalSelectPagingHandler(VdSynonymVendorRefExceptBhv bhv, VdSynonymVendorRefExceptCB cb) { _bhv = bhv; _cb = cb; }
            public PagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<VdSynonymVendorRefExcept> Paging() { return _bhv.SelectList(_cb); }
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
        public IList<VdSynonymVendorExcept> PulloutVdSynonymVendorExcept(IList<VdSynonymVendorRefExcept> vdSynonymVendorRefExceptList) {
            return HelpPulloutInternally<VdSynonymVendorRefExcept, VdSynonymVendorExcept>(vdSynonymVendorRefExceptList, new MyInternalPulloutVdSynonymVendorExceptCallback());
        }
        protected class MyInternalPulloutVdSynonymVendorExceptCallback : InternalPulloutCallback<VdSynonymVendorRefExcept, VdSynonymVendorExcept> {
            public VdSynonymVendorExcept getFr(VdSynonymVendorRefExcept entity) { return entity.VdSynonymVendorExcept; }
        }
        #endregion


        // ===============================================================================
        //                                                                   Entity Update
        //                                                                   =============
        #region Basic Entity Update
        public virtual void Insert(VdSynonymVendorRefExcept entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(Entity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(VdSynonymVendorRefExcept entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(Entity entity) {
            Update(Downcast(entity));
        }

        public void InsertOrUpdate(VdSynonymVendorRefExcept entity) {
            HelpInsertOrUpdateInternally<VdSynonymVendorRefExcept, VdSynonymVendorRefExceptCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<VdSynonymVendorRefExcept, VdSynonymVendorRefExceptCB> {
            protected VdSynonymVendorRefExceptBhv _bhv;
            public MyInternalInsertOrUpdateCallback(VdSynonymVendorRefExceptBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(VdSynonymVendorRefExcept entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(VdSynonymVendorRefExcept entity) { _bhv.Update(entity); }
            public VdSynonymVendorRefExceptCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(VdSynonymVendorRefExceptCB cb, VdSynonymVendorRefExcept entity) {
                cb.Query().SetVendorRefExceptId_Equal(entity.VendorRefExceptId);
            }
            public int CallbackSelectCount(VdSynonymVendorRefExceptCB cb) { return _bhv.SelectCount(cb); }
        }

        public virtual void Delete(VdSynonymVendorRefExcept entity) {
            HelpDeleteInternally<VdSynonymVendorRefExcept>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(Entity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<VdSynonymVendorRefExcept> {
            protected VdSynonymVendorRefExceptBhv _bhv;
            public MyInternalDeleteCallback(VdSynonymVendorRefExceptBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(VdSynonymVendorRefExcept entity) { return _bhv.DelegateDelete(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(VdSynonymVendorRefExcept vdSynonymVendorRefExcept, VdSynonymVendorRefExceptCB cb) {
            AssertObjectNotNull("vdSynonymVendorRefExcept", vdSynonymVendorRefExcept); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(vdSynonymVendorRefExcept);
            FilterEntityOfUpdate(vdSynonymVendorRefExcept); AssertEntityOfUpdate(vdSynonymVendorRefExcept);
            return this.Dao.UpdateByQuery(cb, vdSynonymVendorRefExcept);
        }

        public int QueryDelete(VdSynonymVendorRefExceptCB cb) {
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
        protected int DelegateSelectCount(VdSynonymVendorRefExceptCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<VdSynonymVendorRefExcept> DelegateSelectList(VdSynonymVendorRefExceptCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(VdSynonymVendorRefExcept e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(VdSynonymVendorRefExcept e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(VdSynonymVendorRefExcept e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected VdSynonymVendorRefExcept Downcast(Entity entity) {
            return (VdSynonymVendorRefExcept)entity;
        }

        protected VdSynonymVendorRefExceptCB Downcast(ConditionBean cb) {
            return (VdSynonymVendorRefExceptCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual VdSynonymVendorRefExceptDao Dao { get { return _dao; } set { _dao = value; } }
    }
}

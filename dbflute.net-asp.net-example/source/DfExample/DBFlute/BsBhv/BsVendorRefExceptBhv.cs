
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
    public partial class VendorRefExceptBhv : DfExample.DBFlute.AllCommon.Bhv.AbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected VendorRefExceptDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public VendorRefExceptBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "VENDOR_REF_EXCEPT"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override DBMeta DBMeta { get { return VendorRefExceptDbm.GetInstance(); } }
        public VendorRefExceptDbm MyDBMeta { get { return VendorRefExceptDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override Entity NewEntity() { return NewMyEntity(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual VendorRefExcept NewMyEntity() { return new VendorRefExcept(); }
        public virtual VendorRefExceptCB NewMyConditionBean() { return new VendorRefExceptCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(VendorRefExceptCB cb) {
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
        public virtual VendorRefExcept SelectEntity(VendorRefExceptCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<VendorRefExcept> ls = null;
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
            return (VendorRefExcept)ls[0];
        }

        protected override Entity DoReadEntity(ConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual VendorRefExcept SelectEntityWithDeletedCheck(VendorRefExceptCB cb) {
            AssertConditionBeanNotNull(cb);
            VendorRefExcept entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override Entity DoReadEntityWithDeletedCheck(ConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual VendorRefExcept SelectByPKValue(long? vendorRefExceptId) {
            return SelectEntity(BuildPKCB(vendorRefExceptId));
        }

        public virtual VendorRefExcept SelectByPKValueWithDeletedCheck(long? vendorRefExceptId) {
            return SelectEntityWithDeletedCheck(BuildPKCB(vendorRefExceptId));
        }

        private VendorRefExceptCB BuildPKCB(long? vendorRefExceptId) {
            AssertObjectNotNull("vendorRefExceptId", vendorRefExceptId);
            VendorRefExceptCB cb = NewMyConditionBean();
            cb.Query().SetVendorRefExceptId_Equal(vendorRefExceptId);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual ListResultBean<VendorRefExcept> SelectList(VendorRefExceptCB cb) {
            AssertConditionBeanNotNull(cb);
            return new ResultBeanBuilder<VendorRefExcept>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual PagingResultBean<VendorRefExcept> SelectPage(VendorRefExceptCB cb) {
            AssertConditionBeanNotNull(cb);
            PagingInvoker<VendorRefExcept> invoker = new PagingInvoker<VendorRefExcept>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : PagingHandler<VendorRefExcept> {
            protected VendorRefExceptBhv _bhv; protected VendorRefExceptCB _cb;
            public InternalSelectPagingHandler(VendorRefExceptBhv bhv, VendorRefExceptCB cb) { _bhv = bhv; _cb = cb; }
            public PagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<VendorRefExcept> Paging() { return _bhv.SelectList(_cb); }
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
        public IList<VendorExcept> PulloutVendorExcept(IList<VendorRefExcept> vendorRefExceptList) {
            return HelpPulloutInternally<VendorRefExcept, VendorExcept>(vendorRefExceptList, new MyInternalPulloutVendorExceptCallback());
        }
        protected class MyInternalPulloutVendorExceptCallback : InternalPulloutCallback<VendorRefExcept, VendorExcept> {
            public VendorExcept getFr(VendorRefExcept entity) { return entity.VendorExcept; }
        }
        #endregion


        // ===============================================================================
        //                                                                   Entity Update
        //                                                                   =============
        #region Basic Entity Update
        public virtual void Insert(VendorRefExcept entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(Entity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(VendorRefExcept entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(Entity entity) {
            Update(Downcast(entity));
        }

        public void InsertOrUpdate(VendorRefExcept entity) {
            HelpInsertOrUpdateInternally<VendorRefExcept, VendorRefExceptCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<VendorRefExcept, VendorRefExceptCB> {
            protected VendorRefExceptBhv _bhv;
            public MyInternalInsertOrUpdateCallback(VendorRefExceptBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(VendorRefExcept entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(VendorRefExcept entity) { _bhv.Update(entity); }
            public VendorRefExceptCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(VendorRefExceptCB cb, VendorRefExcept entity) {
                cb.Query().SetVendorRefExceptId_Equal(entity.VendorRefExceptId);
            }
            public int CallbackSelectCount(VendorRefExceptCB cb) { return _bhv.SelectCount(cb); }
        }

        public virtual void Delete(VendorRefExcept entity) {
            HelpDeleteInternally<VendorRefExcept>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(Entity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<VendorRefExcept> {
            protected VendorRefExceptBhv _bhv;
            public MyInternalDeleteCallback(VendorRefExceptBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(VendorRefExcept entity) { return _bhv.DelegateDelete(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(VendorRefExcept vendorRefExcept, VendorRefExceptCB cb) {
            AssertObjectNotNull("vendorRefExcept", vendorRefExcept); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(vendorRefExcept);
            FilterEntityOfUpdate(vendorRefExcept); AssertEntityOfUpdate(vendorRefExcept);
            return this.Dao.UpdateByQuery(cb, vendorRefExcept);
        }

        public int QueryDelete(VendorRefExceptCB cb) {
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
        protected int DelegateSelectCount(VendorRefExceptCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<VendorRefExcept> DelegateSelectList(VendorRefExceptCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(VendorRefExcept e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(VendorRefExcept e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(VendorRefExcept e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected VendorRefExcept Downcast(Entity entity) {
            return (VendorRefExcept)entity;
        }

        protected VendorRefExceptCB Downcast(ConditionBean cb) {
            return (VendorRefExceptCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual VendorRefExceptDao Dao { get { return _dao; } set { _dao = value; } }
    }
}

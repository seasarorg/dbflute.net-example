
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
    public partial class VendorLargeName90123456RefBhv : DfExample.DBFlute.AllCommon.Bhv.AbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected VendorLargeName90123456RefDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public VendorLargeName90123456RefBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "VENDOR_LARGE_NAME_90123456_REF"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override DBMeta DBMeta { get { return VendorLargeName90123456RefDbm.GetInstance(); } }
        public VendorLargeName90123456RefDbm MyDBMeta { get { return VendorLargeName90123456RefDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override Entity NewEntity() { return NewMyEntity(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual VendorLargeName90123456Ref NewMyEntity() { return new VendorLargeName90123456Ref(); }
        public virtual VendorLargeName90123456RefCB NewMyConditionBean() { return new VendorLargeName90123456RefCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(VendorLargeName90123456RefCB cb) {
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
        public virtual VendorLargeName90123456Ref SelectEntity(VendorLargeName90123456RefCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<VendorLargeName90123456Ref> ls = null;
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
            return (VendorLargeName90123456Ref)ls[0];
        }

        protected override Entity DoReadEntity(ConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual VendorLargeName90123456Ref SelectEntityWithDeletedCheck(VendorLargeName90123456RefCB cb) {
            AssertConditionBeanNotNull(cb);
            VendorLargeName90123456Ref entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override Entity DoReadEntityWithDeletedCheck(ConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual VendorLargeName90123456Ref SelectByPKValue(long? vendorLargeName90123RefId) {
            return SelectEntity(BuildPKCB(vendorLargeName90123RefId));
        }

        public virtual VendorLargeName90123456Ref SelectByPKValueWithDeletedCheck(long? vendorLargeName90123RefId) {
            return SelectEntityWithDeletedCheck(BuildPKCB(vendorLargeName90123RefId));
        }

        private VendorLargeName90123456RefCB BuildPKCB(long? vendorLargeName90123RefId) {
            AssertObjectNotNull("vendorLargeName90123RefId", vendorLargeName90123RefId);
            VendorLargeName90123456RefCB cb = NewMyConditionBean();
            cb.Query().SetVendorLargeName90123RefId_Equal(vendorLargeName90123RefId);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual ListResultBean<VendorLargeName90123456Ref> SelectList(VendorLargeName90123456RefCB cb) {
            AssertConditionBeanNotNull(cb);
            return new ResultBeanBuilder<VendorLargeName90123456Ref>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual PagingResultBean<VendorLargeName90123456Ref> SelectPage(VendorLargeName90123456RefCB cb) {
            AssertConditionBeanNotNull(cb);
            PagingInvoker<VendorLargeName90123456Ref> invoker = new PagingInvoker<VendorLargeName90123456Ref>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : PagingHandler<VendorLargeName90123456Ref> {
            protected VendorLargeName90123456RefBhv _bhv; protected VendorLargeName90123456RefCB _cb;
            public InternalSelectPagingHandler(VendorLargeName90123456RefBhv bhv, VendorLargeName90123456RefCB cb) { _bhv = bhv; _cb = cb; }
            public PagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<VendorLargeName90123456Ref> Paging() { return _bhv.SelectList(_cb); }
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
        public IList<VendorLargeName901234567890> PulloutVendorLargeName901234567890(IList<VendorLargeName90123456Ref> vendorLargeName90123456RefList) {
            return HelpPulloutInternally<VendorLargeName90123456Ref, VendorLargeName901234567890>(vendorLargeName90123456RefList, new MyInternalPulloutVendorLargeName901234567890Callback());
        }
        protected class MyInternalPulloutVendorLargeName901234567890Callback : InternalPulloutCallback<VendorLargeName90123456Ref, VendorLargeName901234567890> {
            public VendorLargeName901234567890 getFr(VendorLargeName90123456Ref entity) { return entity.VendorLargeName901234567890; }
        }
        #endregion


        // ===============================================================================
        //                                                                   Entity Update
        //                                                                   =============
        #region Basic Entity Update
        public virtual void Insert(VendorLargeName90123456Ref entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(Entity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(VendorLargeName90123456Ref entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(Entity entity) {
            Update(Downcast(entity));
        }

        public void InsertOrUpdate(VendorLargeName90123456Ref entity) {
            HelpInsertOrUpdateInternally<VendorLargeName90123456Ref, VendorLargeName90123456RefCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<VendorLargeName90123456Ref, VendorLargeName90123456RefCB> {
            protected VendorLargeName90123456RefBhv _bhv;
            public MyInternalInsertOrUpdateCallback(VendorLargeName90123456RefBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(VendorLargeName90123456Ref entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(VendorLargeName90123456Ref entity) { _bhv.Update(entity); }
            public VendorLargeName90123456RefCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(VendorLargeName90123456RefCB cb, VendorLargeName90123456Ref entity) {
                cb.Query().SetVendorLargeName90123RefId_Equal(entity.VendorLargeName90123RefId);
            }
            public int CallbackSelectCount(VendorLargeName90123456RefCB cb) { return _bhv.SelectCount(cb); }
        }

        public virtual void Delete(VendorLargeName90123456Ref entity) {
            HelpDeleteInternally<VendorLargeName90123456Ref>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(Entity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<VendorLargeName90123456Ref> {
            protected VendorLargeName90123456RefBhv _bhv;
            public MyInternalDeleteCallback(VendorLargeName90123456RefBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(VendorLargeName90123456Ref entity) { return _bhv.DelegateDelete(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(VendorLargeName90123456Ref vendorLargeName90123456Ref, VendorLargeName90123456RefCB cb) {
            AssertObjectNotNull("vendorLargeName90123456Ref", vendorLargeName90123456Ref); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(vendorLargeName90123456Ref);
            FilterEntityOfUpdate(vendorLargeName90123456Ref); AssertEntityOfUpdate(vendorLargeName90123456Ref);
            return this.Dao.UpdateByQuery(cb, vendorLargeName90123456Ref);
        }

        public int QueryDelete(VendorLargeName90123456RefCB cb) {
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
        protected int DelegateSelectCount(VendorLargeName90123456RefCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<VendorLargeName90123456Ref> DelegateSelectList(VendorLargeName90123456RefCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(VendorLargeName90123456Ref e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(VendorLargeName90123456Ref e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(VendorLargeName90123456Ref e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected VendorLargeName90123456Ref Downcast(Entity entity) {
            return (VendorLargeName90123456Ref)entity;
        }

        protected VendorLargeName90123456RefCB Downcast(ConditionBean cb) {
            return (VendorLargeName90123456RefCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual VendorLargeName90123456RefDao Dao { get { return _dao; } set { _dao = value; } }
    }
}

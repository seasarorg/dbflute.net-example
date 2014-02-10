
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
    public partial class VendorExceptBhv : DfExample.DBFlute.AllCommon.Bhv.AbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected VendorExceptDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public VendorExceptBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "VENDOR_EXCEPT"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override DBMeta DBMeta { get { return VendorExceptDbm.GetInstance(); } }
        public VendorExceptDbm MyDBMeta { get { return VendorExceptDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override Entity NewEntity() { return NewMyEntity(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual VendorExcept NewMyEntity() { return new VendorExcept(); }
        public virtual VendorExceptCB NewMyConditionBean() { return new VendorExceptCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(VendorExceptCB cb) {
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
        public virtual VendorExcept SelectEntity(VendorExceptCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<VendorExcept> ls = null;
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
            return (VendorExcept)ls[0];
        }

        protected override Entity DoReadEntity(ConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual VendorExcept SelectEntityWithDeletedCheck(VendorExceptCB cb) {
            AssertConditionBeanNotNull(cb);
            VendorExcept entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override Entity DoReadEntityWithDeletedCheck(ConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual VendorExcept SelectByPKValue(long? vendorExceptId) {
            return SelectEntity(BuildPKCB(vendorExceptId));
        }

        public virtual VendorExcept SelectByPKValueWithDeletedCheck(long? vendorExceptId) {
            return SelectEntityWithDeletedCheck(BuildPKCB(vendorExceptId));
        }

        private VendorExceptCB BuildPKCB(long? vendorExceptId) {
            AssertObjectNotNull("vendorExceptId", vendorExceptId);
            VendorExceptCB cb = NewMyConditionBean();
            cb.Query().SetVendorExceptId_Equal(vendorExceptId);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual ListResultBean<VendorExcept> SelectList(VendorExceptCB cb) {
            AssertConditionBeanNotNull(cb);
            return new ResultBeanBuilder<VendorExcept>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual PagingResultBean<VendorExcept> SelectPage(VendorExceptCB cb) {
            AssertConditionBeanNotNull(cb);
            PagingInvoker<VendorExcept> invoker = new PagingInvoker<VendorExcept>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : PagingHandler<VendorExcept> {
            protected VendorExceptBhv _bhv; protected VendorExceptCB _cb;
            public InternalSelectPagingHandler(VendorExceptBhv bhv, VendorExceptCB cb) { _bhv = bhv; _cb = cb; }
            public PagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<VendorExcept> Paging() { return _bhv.SelectList(_cb); }
        }
        #endregion

        // ===============================================================================
        //                                                                   Load Referrer
        //                                                                   =============
        #region Load Referrer
        public virtual void LoadVendorRefExceptList(VendorExcept vendorExcept, ConditionBeanSetupper<VendorRefExceptCB> conditionBeanSetupper) {
            AssertObjectNotNull("vendorExcept", vendorExcept); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadVendorRefExceptList(xnewLRLs<VendorExcept>(vendorExcept), conditionBeanSetupper);
        }
        public virtual void LoadVendorRefExceptList(IList<VendorExcept> vendorExceptList, ConditionBeanSetupper<VendorRefExceptCB> conditionBeanSetupper) {
            AssertObjectNotNull("vendorExceptList", vendorExceptList); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadVendorRefExceptList(vendorExceptList, new LoadReferrerOption<VendorRefExceptCB, VendorRefExcept>().xinit(conditionBeanSetupper));
        }
        public virtual void LoadVendorRefExceptList(VendorExcept vendorExcept, LoadReferrerOption<VendorRefExceptCB, VendorRefExcept> loadReferrerOption) {
            AssertObjectNotNull("vendorExcept", vendorExcept); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            LoadVendorRefExceptList(xnewLRLs<VendorExcept>(vendorExcept), loadReferrerOption);
        }
        public virtual void LoadVendorRefExceptList(IList<VendorExcept> vendorExceptList, LoadReferrerOption<VendorRefExceptCB, VendorRefExcept> loadReferrerOption) {
            AssertObjectNotNull("vendorExceptList", vendorExceptList); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            if (vendorExceptList.Count == 0) { return; }
            VendorRefExceptBhv referrerBhv = xgetBSFLR().Select<VendorRefExceptBhv>();
            HelpLoadReferrerInternally<VendorExcept, long?, VendorRefExceptCB, VendorRefExcept>
                    (vendorExceptList, loadReferrerOption, new MyInternalLoadVendorRefExceptListCallback(referrerBhv));
        }
        protected class MyInternalLoadVendorRefExceptListCallback : InternalLoadReferrerCallback<VendorExcept, long?, VendorRefExceptCB, VendorRefExcept> {
            protected VendorRefExceptBhv referrerBhv;
            public MyInternalLoadVendorRefExceptListCallback(VendorRefExceptBhv referrerBhv) { this.referrerBhv = referrerBhv; }
            public long? getPKVal(VendorExcept e) { return e.VendorExceptId; }
            public void setRfLs(VendorExcept e, IList<VendorRefExcept> ls) { e.VendorRefExceptList = ls; }
            public VendorRefExceptCB newMyCB() { return referrerBhv.NewMyConditionBean(); }
            public void qyFKIn(VendorRefExceptCB cb, IList<long?> ls) { cb.Query().SetVendorExceptId_InScope(ls); }
            public void qyOdFKAsc(VendorRefExceptCB cb) { cb.Query().AddOrderBy_VendorExceptId_Asc(); }
            public void spFKCol(VendorRefExceptCB cb) { cb.Specify().ColumnVendorExceptId(); }
            public IList<VendorRefExcept> selRfLs(VendorRefExceptCB cb) { return referrerBhv.SelectList(cb); }
            public long? getFKVal(VendorRefExcept e) { return e.VendorExceptId; }
            public void setlcEt(VendorRefExcept re, VendorExcept be) { re.VendorExcept = be; }
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
        public virtual void Insert(VendorExcept entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(Entity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(VendorExcept entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(Entity entity) {
            Update(Downcast(entity));
        }

        public void InsertOrUpdate(VendorExcept entity) {
            HelpInsertOrUpdateInternally<VendorExcept, VendorExceptCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<VendorExcept, VendorExceptCB> {
            protected VendorExceptBhv _bhv;
            public MyInternalInsertOrUpdateCallback(VendorExceptBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(VendorExcept entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(VendorExcept entity) { _bhv.Update(entity); }
            public VendorExceptCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(VendorExceptCB cb, VendorExcept entity) {
                cb.Query().SetVendorExceptId_Equal(entity.VendorExceptId);
            }
            public int CallbackSelectCount(VendorExceptCB cb) { return _bhv.SelectCount(cb); }
        }

        public virtual void Delete(VendorExcept entity) {
            HelpDeleteInternally<VendorExcept>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(Entity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<VendorExcept> {
            protected VendorExceptBhv _bhv;
            public MyInternalDeleteCallback(VendorExceptBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(VendorExcept entity) { return _bhv.DelegateDelete(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(VendorExcept vendorExcept, VendorExceptCB cb) {
            AssertObjectNotNull("vendorExcept", vendorExcept); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(vendorExcept);
            FilterEntityOfUpdate(vendorExcept); AssertEntityOfUpdate(vendorExcept);
            return this.Dao.UpdateByQuery(cb, vendorExcept);
        }

        public int QueryDelete(VendorExceptCB cb) {
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
        protected int DelegateSelectCount(VendorExceptCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<VendorExcept> DelegateSelectList(VendorExceptCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(VendorExcept e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(VendorExcept e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(VendorExcept e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected VendorExcept Downcast(Entity entity) {
            return (VendorExcept)entity;
        }

        protected VendorExceptCB Downcast(ConditionBean cb) {
            return (VendorExceptCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual VendorExceptDao Dao { get { return _dao; } set { _dao = value; } }
    }
}

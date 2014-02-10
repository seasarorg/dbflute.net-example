
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
    public partial class VendorTargetBhv : DfExample.DBFlute.AllCommon.Bhv.AbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected VendorTargetDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public VendorTargetBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "VENDOR_TARGET"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override DBMeta DBMeta { get { return VendorTargetDbm.GetInstance(); } }
        public VendorTargetDbm MyDBMeta { get { return VendorTargetDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override Entity NewEntity() { return NewMyEntity(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual VendorTarget NewMyEntity() { return new VendorTarget(); }
        public virtual VendorTargetCB NewMyConditionBean() { return new VendorTargetCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(VendorTargetCB cb) {
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
        public virtual VendorTarget SelectEntity(VendorTargetCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<VendorTarget> ls = null;
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
            return (VendorTarget)ls[0];
        }

        protected override Entity DoReadEntity(ConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual VendorTarget SelectEntityWithDeletedCheck(VendorTargetCB cb) {
            AssertConditionBeanNotNull(cb);
            VendorTarget entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override Entity DoReadEntityWithDeletedCheck(ConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual VendorTarget SelectByPKValue(long? vendorTargetId) {
            return SelectEntity(BuildPKCB(vendorTargetId));
        }

        public virtual VendorTarget SelectByPKValueWithDeletedCheck(long? vendorTargetId) {
            return SelectEntityWithDeletedCheck(BuildPKCB(vendorTargetId));
        }

        private VendorTargetCB BuildPKCB(long? vendorTargetId) {
            AssertObjectNotNull("vendorTargetId", vendorTargetId);
            VendorTargetCB cb = NewMyConditionBean();
            cb.Query().SetVendorTargetId_Equal(vendorTargetId);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual ListResultBean<VendorTarget> SelectList(VendorTargetCB cb) {
            AssertConditionBeanNotNull(cb);
            return new ResultBeanBuilder<VendorTarget>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual PagingResultBean<VendorTarget> SelectPage(VendorTargetCB cb) {
            AssertConditionBeanNotNull(cb);
            PagingInvoker<VendorTarget> invoker = new PagingInvoker<VendorTarget>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : PagingHandler<VendorTarget> {
            protected VendorTargetBhv _bhv; protected VendorTargetCB _cb;
            public InternalSelectPagingHandler(VendorTargetBhv bhv, VendorTargetCB cb) { _bhv = bhv; _cb = cb; }
            public PagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<VendorTarget> Paging() { return _bhv.SelectList(_cb); }
        }
        #endregion

        // ===============================================================================
        //                                                                   Load Referrer
        //                                                                   =============
        #region Load Referrer
        public virtual void LoadVendorRefTargetList(VendorTarget vendorTarget, ConditionBeanSetupper<VendorRefTargetCB> conditionBeanSetupper) {
            AssertObjectNotNull("vendorTarget", vendorTarget); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadVendorRefTargetList(xnewLRLs<VendorTarget>(vendorTarget), conditionBeanSetupper);
        }
        public virtual void LoadVendorRefTargetList(IList<VendorTarget> vendorTargetList, ConditionBeanSetupper<VendorRefTargetCB> conditionBeanSetupper) {
            AssertObjectNotNull("vendorTargetList", vendorTargetList); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadVendorRefTargetList(vendorTargetList, new LoadReferrerOption<VendorRefTargetCB, VendorRefTarget>().xinit(conditionBeanSetupper));
        }
        public virtual void LoadVendorRefTargetList(VendorTarget vendorTarget, LoadReferrerOption<VendorRefTargetCB, VendorRefTarget> loadReferrerOption) {
            AssertObjectNotNull("vendorTarget", vendorTarget); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            LoadVendorRefTargetList(xnewLRLs<VendorTarget>(vendorTarget), loadReferrerOption);
        }
        public virtual void LoadVendorRefTargetList(IList<VendorTarget> vendorTargetList, LoadReferrerOption<VendorRefTargetCB, VendorRefTarget> loadReferrerOption) {
            AssertObjectNotNull("vendorTargetList", vendorTargetList); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            if (vendorTargetList.Count == 0) { return; }
            VendorRefTargetBhv referrerBhv = xgetBSFLR().Select<VendorRefTargetBhv>();
            HelpLoadReferrerInternally<VendorTarget, long?, VendorRefTargetCB, VendorRefTarget>
                    (vendorTargetList, loadReferrerOption, new MyInternalLoadVendorRefTargetListCallback(referrerBhv));
        }
        protected class MyInternalLoadVendorRefTargetListCallback : InternalLoadReferrerCallback<VendorTarget, long?, VendorRefTargetCB, VendorRefTarget> {
            protected VendorRefTargetBhv referrerBhv;
            public MyInternalLoadVendorRefTargetListCallback(VendorRefTargetBhv referrerBhv) { this.referrerBhv = referrerBhv; }
            public long? getPKVal(VendorTarget e) { return e.VendorTargetId; }
            public void setRfLs(VendorTarget e, IList<VendorRefTarget> ls) { e.VendorRefTargetList = ls; }
            public VendorRefTargetCB newMyCB() { return referrerBhv.NewMyConditionBean(); }
            public void qyFKIn(VendorRefTargetCB cb, IList<long?> ls) { cb.Query().SetVendorTargetId_InScope(ls); }
            public void qyOdFKAsc(VendorRefTargetCB cb) { cb.Query().AddOrderBy_VendorTargetId_Asc(); }
            public void spFKCol(VendorRefTargetCB cb) { cb.Specify().ColumnVendorTargetId(); }
            public IList<VendorRefTarget> selRfLs(VendorRefTargetCB cb) { return referrerBhv.SelectList(cb); }
            public long? getFKVal(VendorRefTarget e) { return e.VendorTargetId; }
            public void setlcEt(VendorRefTarget re, VendorTarget be) { re.VendorTarget = be; }
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
        public virtual void Insert(VendorTarget entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(Entity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(VendorTarget entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(Entity entity) {
            Update(Downcast(entity));
        }

        public void InsertOrUpdate(VendorTarget entity) {
            HelpInsertOrUpdateInternally<VendorTarget, VendorTargetCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<VendorTarget, VendorTargetCB> {
            protected VendorTargetBhv _bhv;
            public MyInternalInsertOrUpdateCallback(VendorTargetBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(VendorTarget entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(VendorTarget entity) { _bhv.Update(entity); }
            public VendorTargetCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(VendorTargetCB cb, VendorTarget entity) {
                cb.Query().SetVendorTargetId_Equal(entity.VendorTargetId);
            }
            public int CallbackSelectCount(VendorTargetCB cb) { return _bhv.SelectCount(cb); }
        }

        public virtual void Delete(VendorTarget entity) {
            HelpDeleteInternally<VendorTarget>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(Entity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<VendorTarget> {
            protected VendorTargetBhv _bhv;
            public MyInternalDeleteCallback(VendorTargetBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(VendorTarget entity) { return _bhv.DelegateDelete(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(VendorTarget vendorTarget, VendorTargetCB cb) {
            AssertObjectNotNull("vendorTarget", vendorTarget); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(vendorTarget);
            FilterEntityOfUpdate(vendorTarget); AssertEntityOfUpdate(vendorTarget);
            return this.Dao.UpdateByQuery(cb, vendorTarget);
        }

        public int QueryDelete(VendorTargetCB cb) {
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
        protected int DelegateSelectCount(VendorTargetCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<VendorTarget> DelegateSelectList(VendorTargetCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(VendorTarget e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(VendorTarget e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(VendorTarget e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected VendorTarget Downcast(Entity entity) {
            return (VendorTarget)entity;
        }

        protected VendorTargetCB Downcast(ConditionBean cb) {
            return (VendorTargetCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual VendorTargetDao Dao { get { return _dao; } set { _dao = value; } }
    }
}

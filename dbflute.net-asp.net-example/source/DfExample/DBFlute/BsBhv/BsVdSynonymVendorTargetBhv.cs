
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
    public partial class VdSynonymVendorTargetBhv : DfExample.DBFlute.AllCommon.Bhv.AbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected VdSynonymVendorTargetDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public VdSynonymVendorTargetBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "VD_SYNONYM_VENDOR_TARGET"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override DBMeta DBMeta { get { return VdSynonymVendorTargetDbm.GetInstance(); } }
        public VdSynonymVendorTargetDbm MyDBMeta { get { return VdSynonymVendorTargetDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override Entity NewEntity() { return NewMyEntity(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual VdSynonymVendorTarget NewMyEntity() { return new VdSynonymVendorTarget(); }
        public virtual VdSynonymVendorTargetCB NewMyConditionBean() { return new VdSynonymVendorTargetCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(VdSynonymVendorTargetCB cb) {
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
        public virtual VdSynonymVendorTarget SelectEntity(VdSynonymVendorTargetCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<VdSynonymVendorTarget> ls = null;
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
            return (VdSynonymVendorTarget)ls[0];
        }

        protected override Entity DoReadEntity(ConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual VdSynonymVendorTarget SelectEntityWithDeletedCheck(VdSynonymVendorTargetCB cb) {
            AssertConditionBeanNotNull(cb);
            VdSynonymVendorTarget entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override Entity DoReadEntityWithDeletedCheck(ConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual VdSynonymVendorTarget SelectByPKValue(long? vendorTargetId) {
            return SelectEntity(BuildPKCB(vendorTargetId));
        }

        public virtual VdSynonymVendorTarget SelectByPKValueWithDeletedCheck(long? vendorTargetId) {
            return SelectEntityWithDeletedCheck(BuildPKCB(vendorTargetId));
        }

        private VdSynonymVendorTargetCB BuildPKCB(long? vendorTargetId) {
            AssertObjectNotNull("vendorTargetId", vendorTargetId);
            VdSynonymVendorTargetCB cb = NewMyConditionBean();
            cb.Query().SetVendorTargetId_Equal(vendorTargetId);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual ListResultBean<VdSynonymVendorTarget> SelectList(VdSynonymVendorTargetCB cb) {
            AssertConditionBeanNotNull(cb);
            return new ResultBeanBuilder<VdSynonymVendorTarget>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual PagingResultBean<VdSynonymVendorTarget> SelectPage(VdSynonymVendorTargetCB cb) {
            AssertConditionBeanNotNull(cb);
            PagingInvoker<VdSynonymVendorTarget> invoker = new PagingInvoker<VdSynonymVendorTarget>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : PagingHandler<VdSynonymVendorTarget> {
            protected VdSynonymVendorTargetBhv _bhv; protected VdSynonymVendorTargetCB _cb;
            public InternalSelectPagingHandler(VdSynonymVendorTargetBhv bhv, VdSynonymVendorTargetCB cb) { _bhv = bhv; _cb = cb; }
            public PagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<VdSynonymVendorTarget> Paging() { return _bhv.SelectList(_cb); }
        }
        #endregion

        // ===============================================================================
        //                                                                   Load Referrer
        //                                                                   =============
        #region Load Referrer
        public virtual void LoadVdSynonymVendorRefTargetList(VdSynonymVendorTarget vdSynonymVendorTarget, ConditionBeanSetupper<VdSynonymVendorRefTargetCB> conditionBeanSetupper) {
            AssertObjectNotNull("vdSynonymVendorTarget", vdSynonymVendorTarget); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadVdSynonymVendorRefTargetList(xnewLRLs<VdSynonymVendorTarget>(vdSynonymVendorTarget), conditionBeanSetupper);
        }
        public virtual void LoadVdSynonymVendorRefTargetList(IList<VdSynonymVendorTarget> vdSynonymVendorTargetList, ConditionBeanSetupper<VdSynonymVendorRefTargetCB> conditionBeanSetupper) {
            AssertObjectNotNull("vdSynonymVendorTargetList", vdSynonymVendorTargetList); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadVdSynonymVendorRefTargetList(vdSynonymVendorTargetList, new LoadReferrerOption<VdSynonymVendorRefTargetCB, VdSynonymVendorRefTarget>().xinit(conditionBeanSetupper));
        }
        public virtual void LoadVdSynonymVendorRefTargetList(VdSynonymVendorTarget vdSynonymVendorTarget, LoadReferrerOption<VdSynonymVendorRefTargetCB, VdSynonymVendorRefTarget> loadReferrerOption) {
            AssertObjectNotNull("vdSynonymVendorTarget", vdSynonymVendorTarget); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            LoadVdSynonymVendorRefTargetList(xnewLRLs<VdSynonymVendorTarget>(vdSynonymVendorTarget), loadReferrerOption);
        }
        public virtual void LoadVdSynonymVendorRefTargetList(IList<VdSynonymVendorTarget> vdSynonymVendorTargetList, LoadReferrerOption<VdSynonymVendorRefTargetCB, VdSynonymVendorRefTarget> loadReferrerOption) {
            AssertObjectNotNull("vdSynonymVendorTargetList", vdSynonymVendorTargetList); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            if (vdSynonymVendorTargetList.Count == 0) { return; }
            VdSynonymVendorRefTargetBhv referrerBhv = xgetBSFLR().Select<VdSynonymVendorRefTargetBhv>();
            HelpLoadReferrerInternally<VdSynonymVendorTarget, long?, VdSynonymVendorRefTargetCB, VdSynonymVendorRefTarget>
                    (vdSynonymVendorTargetList, loadReferrerOption, new MyInternalLoadVdSynonymVendorRefTargetListCallback(referrerBhv));
        }
        protected class MyInternalLoadVdSynonymVendorRefTargetListCallback : InternalLoadReferrerCallback<VdSynonymVendorTarget, long?, VdSynonymVendorRefTargetCB, VdSynonymVendorRefTarget> {
            protected VdSynonymVendorRefTargetBhv referrerBhv;
            public MyInternalLoadVdSynonymVendorRefTargetListCallback(VdSynonymVendorRefTargetBhv referrerBhv) { this.referrerBhv = referrerBhv; }
            public long? getPKVal(VdSynonymVendorTarget e) { return e.VendorTargetId; }
            public void setRfLs(VdSynonymVendorTarget e, IList<VdSynonymVendorRefTarget> ls) { e.VdSynonymVendorRefTargetList = ls; }
            public VdSynonymVendorRefTargetCB newMyCB() { return referrerBhv.NewMyConditionBean(); }
            public void qyFKIn(VdSynonymVendorRefTargetCB cb, IList<long?> ls) { cb.Query().SetVendorTargetId_InScope(ls); }
            public void qyOdFKAsc(VdSynonymVendorRefTargetCB cb) { cb.Query().AddOrderBy_VendorTargetId_Asc(); }
            public void spFKCol(VdSynonymVendorRefTargetCB cb) { cb.Specify().ColumnVendorTargetId(); }
            public IList<VdSynonymVendorRefTarget> selRfLs(VdSynonymVendorRefTargetCB cb) { return referrerBhv.SelectList(cb); }
            public long? getFKVal(VdSynonymVendorRefTarget e) { return e.VendorTargetId; }
            public void setlcEt(VdSynonymVendorRefTarget re, VdSynonymVendorTarget be) { re.VdSynonymVendorTarget = be; }
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
        public virtual void Insert(VdSynonymVendorTarget entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(Entity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(VdSynonymVendorTarget entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(Entity entity) {
            Update(Downcast(entity));
        }

        public void InsertOrUpdate(VdSynonymVendorTarget entity) {
            HelpInsertOrUpdateInternally<VdSynonymVendorTarget, VdSynonymVendorTargetCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<VdSynonymVendorTarget, VdSynonymVendorTargetCB> {
            protected VdSynonymVendorTargetBhv _bhv;
            public MyInternalInsertOrUpdateCallback(VdSynonymVendorTargetBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(VdSynonymVendorTarget entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(VdSynonymVendorTarget entity) { _bhv.Update(entity); }
            public VdSynonymVendorTargetCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(VdSynonymVendorTargetCB cb, VdSynonymVendorTarget entity) {
                cb.Query().SetVendorTargetId_Equal(entity.VendorTargetId);
            }
            public int CallbackSelectCount(VdSynonymVendorTargetCB cb) { return _bhv.SelectCount(cb); }
        }

        public virtual void Delete(VdSynonymVendorTarget entity) {
            HelpDeleteInternally<VdSynonymVendorTarget>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(Entity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<VdSynonymVendorTarget> {
            protected VdSynonymVendorTargetBhv _bhv;
            public MyInternalDeleteCallback(VdSynonymVendorTargetBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(VdSynonymVendorTarget entity) { return _bhv.DelegateDelete(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(VdSynonymVendorTarget vdSynonymVendorTarget, VdSynonymVendorTargetCB cb) {
            AssertObjectNotNull("vdSynonymVendorTarget", vdSynonymVendorTarget); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(vdSynonymVendorTarget);
            FilterEntityOfUpdate(vdSynonymVendorTarget); AssertEntityOfUpdate(vdSynonymVendorTarget);
            return this.Dao.UpdateByQuery(cb, vdSynonymVendorTarget);
        }

        public int QueryDelete(VdSynonymVendorTargetCB cb) {
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
        protected int DelegateSelectCount(VdSynonymVendorTargetCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<VdSynonymVendorTarget> DelegateSelectList(VdSynonymVendorTargetCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(VdSynonymVendorTarget e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(VdSynonymVendorTarget e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(VdSynonymVendorTarget e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected VdSynonymVendorTarget Downcast(Entity entity) {
            return (VdSynonymVendorTarget)entity;
        }

        protected VdSynonymVendorTargetCB Downcast(ConditionBean cb) {
            return (VdSynonymVendorTargetCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual VdSynonymVendorTargetDao Dao { get { return _dao; } set { _dao = value; } }
    }
}

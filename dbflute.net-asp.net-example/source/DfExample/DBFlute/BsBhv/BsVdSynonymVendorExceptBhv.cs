
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
    public partial class VdSynonymVendorExceptBhv : DfExample.DBFlute.AllCommon.Bhv.AbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected VdSynonymVendorExceptDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public VdSynonymVendorExceptBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "VD_SYNONYM_VENDOR_EXCEPT"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override DBMeta DBMeta { get { return VdSynonymVendorExceptDbm.GetInstance(); } }
        public VdSynonymVendorExceptDbm MyDBMeta { get { return VdSynonymVendorExceptDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override Entity NewEntity() { return NewMyEntity(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual VdSynonymVendorExcept NewMyEntity() { return new VdSynonymVendorExcept(); }
        public virtual VdSynonymVendorExceptCB NewMyConditionBean() { return new VdSynonymVendorExceptCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(VdSynonymVendorExceptCB cb) {
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
        public virtual VdSynonymVendorExcept SelectEntity(VdSynonymVendorExceptCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<VdSynonymVendorExcept> ls = null;
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
            return (VdSynonymVendorExcept)ls[0];
        }

        protected override Entity DoReadEntity(ConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual VdSynonymVendorExcept SelectEntityWithDeletedCheck(VdSynonymVendorExceptCB cb) {
            AssertConditionBeanNotNull(cb);
            VdSynonymVendorExcept entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override Entity DoReadEntityWithDeletedCheck(ConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual VdSynonymVendorExcept SelectByPKValue(long? vendorExceptId) {
            return SelectEntity(BuildPKCB(vendorExceptId));
        }

        public virtual VdSynonymVendorExcept SelectByPKValueWithDeletedCheck(long? vendorExceptId) {
            return SelectEntityWithDeletedCheck(BuildPKCB(vendorExceptId));
        }

        private VdSynonymVendorExceptCB BuildPKCB(long? vendorExceptId) {
            AssertObjectNotNull("vendorExceptId", vendorExceptId);
            VdSynonymVendorExceptCB cb = NewMyConditionBean();
            cb.Query().SetVendorExceptId_Equal(vendorExceptId);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual ListResultBean<VdSynonymVendorExcept> SelectList(VdSynonymVendorExceptCB cb) {
            AssertConditionBeanNotNull(cb);
            return new ResultBeanBuilder<VdSynonymVendorExcept>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual PagingResultBean<VdSynonymVendorExcept> SelectPage(VdSynonymVendorExceptCB cb) {
            AssertConditionBeanNotNull(cb);
            PagingInvoker<VdSynonymVendorExcept> invoker = new PagingInvoker<VdSynonymVendorExcept>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : PagingHandler<VdSynonymVendorExcept> {
            protected VdSynonymVendorExceptBhv _bhv; protected VdSynonymVendorExceptCB _cb;
            public InternalSelectPagingHandler(VdSynonymVendorExceptBhv bhv, VdSynonymVendorExceptCB cb) { _bhv = bhv; _cb = cb; }
            public PagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<VdSynonymVendorExcept> Paging() { return _bhv.SelectList(_cb); }
        }
        #endregion

        // ===============================================================================
        //                                                                   Load Referrer
        //                                                                   =============
        #region Load Referrer
        public virtual void LoadVdSynonymVendorRefExceptList(VdSynonymVendorExcept vdSynonymVendorExcept, ConditionBeanSetupper<VdSynonymVendorRefExceptCB> conditionBeanSetupper) {
            AssertObjectNotNull("vdSynonymVendorExcept", vdSynonymVendorExcept); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadVdSynonymVendorRefExceptList(xnewLRLs<VdSynonymVendorExcept>(vdSynonymVendorExcept), conditionBeanSetupper);
        }
        public virtual void LoadVdSynonymVendorRefExceptList(IList<VdSynonymVendorExcept> vdSynonymVendorExceptList, ConditionBeanSetupper<VdSynonymVendorRefExceptCB> conditionBeanSetupper) {
            AssertObjectNotNull("vdSynonymVendorExceptList", vdSynonymVendorExceptList); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadVdSynonymVendorRefExceptList(vdSynonymVendorExceptList, new LoadReferrerOption<VdSynonymVendorRefExceptCB, VdSynonymVendorRefExcept>().xinit(conditionBeanSetupper));
        }
        public virtual void LoadVdSynonymVendorRefExceptList(VdSynonymVendorExcept vdSynonymVendorExcept, LoadReferrerOption<VdSynonymVendorRefExceptCB, VdSynonymVendorRefExcept> loadReferrerOption) {
            AssertObjectNotNull("vdSynonymVendorExcept", vdSynonymVendorExcept); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            LoadVdSynonymVendorRefExceptList(xnewLRLs<VdSynonymVendorExcept>(vdSynonymVendorExcept), loadReferrerOption);
        }
        public virtual void LoadVdSynonymVendorRefExceptList(IList<VdSynonymVendorExcept> vdSynonymVendorExceptList, LoadReferrerOption<VdSynonymVendorRefExceptCB, VdSynonymVendorRefExcept> loadReferrerOption) {
            AssertObjectNotNull("vdSynonymVendorExceptList", vdSynonymVendorExceptList); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            if (vdSynonymVendorExceptList.Count == 0) { return; }
            VdSynonymVendorRefExceptBhv referrerBhv = xgetBSFLR().Select<VdSynonymVendorRefExceptBhv>();
            HelpLoadReferrerInternally<VdSynonymVendorExcept, long?, VdSynonymVendorRefExceptCB, VdSynonymVendorRefExcept>
                    (vdSynonymVendorExceptList, loadReferrerOption, new MyInternalLoadVdSynonymVendorRefExceptListCallback(referrerBhv));
        }
        protected class MyInternalLoadVdSynonymVendorRefExceptListCallback : InternalLoadReferrerCallback<VdSynonymVendorExcept, long?, VdSynonymVendorRefExceptCB, VdSynonymVendorRefExcept> {
            protected VdSynonymVendorRefExceptBhv referrerBhv;
            public MyInternalLoadVdSynonymVendorRefExceptListCallback(VdSynonymVendorRefExceptBhv referrerBhv) { this.referrerBhv = referrerBhv; }
            public long? getPKVal(VdSynonymVendorExcept e) { return e.VendorExceptId; }
            public void setRfLs(VdSynonymVendorExcept e, IList<VdSynonymVendorRefExcept> ls) { e.VdSynonymVendorRefExceptList = ls; }
            public VdSynonymVendorRefExceptCB newMyCB() { return referrerBhv.NewMyConditionBean(); }
            public void qyFKIn(VdSynonymVendorRefExceptCB cb, IList<long?> ls) { cb.Query().SetVendorExceptId_InScope(ls); }
            public void qyOdFKAsc(VdSynonymVendorRefExceptCB cb) { cb.Query().AddOrderBy_VendorExceptId_Asc(); }
            public void spFKCol(VdSynonymVendorRefExceptCB cb) { cb.Specify().ColumnVendorExceptId(); }
            public IList<VdSynonymVendorRefExcept> selRfLs(VdSynonymVendorRefExceptCB cb) { return referrerBhv.SelectList(cb); }
            public long? getFKVal(VdSynonymVendorRefExcept e) { return e.VendorExceptId; }
            public void setlcEt(VdSynonymVendorRefExcept re, VdSynonymVendorExcept be) { re.VdSynonymVendorExcept = be; }
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
        public virtual void Insert(VdSynonymVendorExcept entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(Entity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(VdSynonymVendorExcept entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(Entity entity) {
            Update(Downcast(entity));
        }

        public void InsertOrUpdate(VdSynonymVendorExcept entity) {
            HelpInsertOrUpdateInternally<VdSynonymVendorExcept, VdSynonymVendorExceptCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<VdSynonymVendorExcept, VdSynonymVendorExceptCB> {
            protected VdSynonymVendorExceptBhv _bhv;
            public MyInternalInsertOrUpdateCallback(VdSynonymVendorExceptBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(VdSynonymVendorExcept entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(VdSynonymVendorExcept entity) { _bhv.Update(entity); }
            public VdSynonymVendorExceptCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(VdSynonymVendorExceptCB cb, VdSynonymVendorExcept entity) {
                cb.Query().SetVendorExceptId_Equal(entity.VendorExceptId);
            }
            public int CallbackSelectCount(VdSynonymVendorExceptCB cb) { return _bhv.SelectCount(cb); }
        }

        public virtual void Delete(VdSynonymVendorExcept entity) {
            HelpDeleteInternally<VdSynonymVendorExcept>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(Entity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<VdSynonymVendorExcept> {
            protected VdSynonymVendorExceptBhv _bhv;
            public MyInternalDeleteCallback(VdSynonymVendorExceptBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(VdSynonymVendorExcept entity) { return _bhv.DelegateDelete(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(VdSynonymVendorExcept vdSynonymVendorExcept, VdSynonymVendorExceptCB cb) {
            AssertObjectNotNull("vdSynonymVendorExcept", vdSynonymVendorExcept); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(vdSynonymVendorExcept);
            FilterEntityOfUpdate(vdSynonymVendorExcept); AssertEntityOfUpdate(vdSynonymVendorExcept);
            return this.Dao.UpdateByQuery(cb, vdSynonymVendorExcept);
        }

        public int QueryDelete(VdSynonymVendorExceptCB cb) {
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
        protected int DelegateSelectCount(VdSynonymVendorExceptCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<VdSynonymVendorExcept> DelegateSelectList(VdSynonymVendorExceptCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(VdSynonymVendorExcept e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(VdSynonymVendorExcept e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(VdSynonymVendorExcept e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected VdSynonymVendorExcept Downcast(Entity entity) {
            return (VdSynonymVendorExcept)entity;
        }

        protected VdSynonymVendorExceptCB Downcast(ConditionBean cb) {
            return (VdSynonymVendorExceptCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual VdSynonymVendorExceptDao Dao { get { return _dao; } set { _dao = value; } }
    }
}

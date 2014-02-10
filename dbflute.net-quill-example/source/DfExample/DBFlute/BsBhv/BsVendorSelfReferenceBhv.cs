
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
    public partial class VendorSelfReferenceBhv : DfExample.DBFlute.AllCommon.Bhv.AbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected VendorSelfReferenceDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public VendorSelfReferenceBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "vendor_self_reference"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override DBMeta DBMeta { get { return VendorSelfReferenceDbm.GetInstance(); } }
        public VendorSelfReferenceDbm MyDBMeta { get { return VendorSelfReferenceDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override Entity NewEntity() { return NewMyEntity(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual VendorSelfReference NewMyEntity() { return new VendorSelfReference(); }
        public virtual VendorSelfReferenceCB NewMyConditionBean() { return new VendorSelfReferenceCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(VendorSelfReferenceCB cb) {
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
        public virtual VendorSelfReference SelectEntity(VendorSelfReferenceCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<VendorSelfReference> ls = null;
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
            return (VendorSelfReference)ls[0];
        }

        protected override Entity DoReadEntity(ConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual VendorSelfReference SelectEntityWithDeletedCheck(VendorSelfReferenceCB cb) {
            AssertConditionBeanNotNull(cb);
            VendorSelfReference entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override Entity DoReadEntityWithDeletedCheck(ConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual VendorSelfReference SelectByPKValue(long? selfReferenceId) {
            return SelectEntity(BuildPKCB(selfReferenceId));
        }

        public virtual VendorSelfReference SelectByPKValueWithDeletedCheck(long? selfReferenceId) {
            return SelectEntityWithDeletedCheck(BuildPKCB(selfReferenceId));
        }

        private VendorSelfReferenceCB BuildPKCB(long? selfReferenceId) {
            AssertObjectNotNull("selfReferenceId", selfReferenceId);
            VendorSelfReferenceCB cb = NewMyConditionBean();
            cb.Query().SetSelfReferenceId_Equal(selfReferenceId);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual ListResultBean<VendorSelfReference> SelectList(VendorSelfReferenceCB cb) {
            AssertConditionBeanNotNull(cb);
            return new ResultBeanBuilder<VendorSelfReference>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual PagingResultBean<VendorSelfReference> SelectPage(VendorSelfReferenceCB cb) {
            AssertConditionBeanNotNull(cb);
            PagingInvoker<VendorSelfReference> invoker = new PagingInvoker<VendorSelfReference>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : PagingHandler<VendorSelfReference> {
            protected VendorSelfReferenceBhv _bhv; protected VendorSelfReferenceCB _cb;
            public InternalSelectPagingHandler(VendorSelfReferenceBhv bhv, VendorSelfReferenceCB cb) { _bhv = bhv; _cb = cb; }
            public PagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<VendorSelfReference> Paging() { return _bhv.SelectList(_cb); }
        }
        #endregion

        // ===============================================================================
        //                                                                   Load Referrer
        //                                                                   =============
        #region Load Referrer
        public virtual void LoadVendorSelfReferenceSelfList(VendorSelfReference vendorSelfReference, ConditionBeanSetupper<VendorSelfReferenceCB> conditionBeanSetupper) {
            AssertObjectNotNull("vendorSelfReference", vendorSelfReference); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadVendorSelfReferenceSelfList(xnewLRLs<VendorSelfReference>(vendorSelfReference), conditionBeanSetupper);
        }
        public virtual void LoadVendorSelfReferenceSelfList(IList<VendorSelfReference> vendorSelfReferenceList, ConditionBeanSetupper<VendorSelfReferenceCB> conditionBeanSetupper) {
            AssertObjectNotNull("vendorSelfReferenceList", vendorSelfReferenceList); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadVendorSelfReferenceSelfList(vendorSelfReferenceList, new LoadReferrerOption<VendorSelfReferenceCB, VendorSelfReference>().xinit(conditionBeanSetupper));
        }
        public virtual void LoadVendorSelfReferenceSelfList(VendorSelfReference vendorSelfReference, LoadReferrerOption<VendorSelfReferenceCB, VendorSelfReference> loadReferrerOption) {
            AssertObjectNotNull("vendorSelfReference", vendorSelfReference); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            LoadVendorSelfReferenceSelfList(xnewLRLs<VendorSelfReference>(vendorSelfReference), loadReferrerOption);
        }
        public virtual void LoadVendorSelfReferenceSelfList(IList<VendorSelfReference> vendorSelfReferenceList, LoadReferrerOption<VendorSelfReferenceCB, VendorSelfReference> loadReferrerOption) {
            AssertObjectNotNull("vendorSelfReferenceList", vendorSelfReferenceList); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            if (vendorSelfReferenceList.Count == 0) { return; }
            VendorSelfReferenceBhv referrerBhv = xgetBSFLR().Select<VendorSelfReferenceBhv>();
            HelpLoadReferrerInternally<VendorSelfReference, long?, VendorSelfReferenceCB, VendorSelfReference>
                    (vendorSelfReferenceList, loadReferrerOption, new MyInternalLoadVendorSelfReferenceSelfListCallback(referrerBhv));
        }
        protected class MyInternalLoadVendorSelfReferenceSelfListCallback : InternalLoadReferrerCallback<VendorSelfReference, long?, VendorSelfReferenceCB, VendorSelfReference> {
            protected VendorSelfReferenceBhv referrerBhv;
            public MyInternalLoadVendorSelfReferenceSelfListCallback(VendorSelfReferenceBhv referrerBhv) { this.referrerBhv = referrerBhv; }
            public long? getPKVal(VendorSelfReference e) { return e.SelfReferenceId; }
            public void setRfLs(VendorSelfReference e, IList<VendorSelfReference> ls) { e.VendorSelfReferenceSelfList = ls; }
            public VendorSelfReferenceCB newMyCB() { return referrerBhv.NewMyConditionBean(); }
            public void qyFKIn(VendorSelfReferenceCB cb, IList<long?> ls) { cb.Query().SetParentId_InScope(ls); }
            public void qyOdFKAsc(VendorSelfReferenceCB cb) { cb.Query().AddOrderBy_ParentId_Asc(); }
            public void spFKCol(VendorSelfReferenceCB cb) { cb.Specify().ColumnParentId(); }
            public IList<VendorSelfReference> selRfLs(VendorSelfReferenceCB cb) { return referrerBhv.SelectList(cb); }
            public long? getFKVal(VendorSelfReference e) { return e.ParentId; }
            public void setlcEt(VendorSelfReference re, VendorSelfReference be) { re.VendorSelfReferenceSelf = be; }
        }
        #endregion

        // ===============================================================================
        //                                                                Pull out Foreign
        //                                                                ================
        #region Pullout Foreign
        public IList<VendorSelfReference> PulloutVendorSelfReferenceSelf(IList<VendorSelfReference> vendorSelfReferenceList) {
            return HelpPulloutInternally<VendorSelfReference, VendorSelfReference>(vendorSelfReferenceList, new MyInternalPulloutVendorSelfReferenceSelfCallback());
        }
        protected class MyInternalPulloutVendorSelfReferenceSelfCallback : InternalPulloutCallback<VendorSelfReference, VendorSelfReference> {
            public VendorSelfReference getFr(VendorSelfReference entity) { return entity.VendorSelfReferenceSelf; }
        }
        #endregion


        // ===============================================================================
        //                                                                   Entity Update
        //                                                                   =============
        #region Basic Entity Update
        public virtual void Insert(VendorSelfReference entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(Entity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(VendorSelfReference entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(Entity entity) {
            Update(Downcast(entity));
        }

        public void InsertOrUpdate(VendorSelfReference entity) {
            HelpInsertOrUpdateInternally<VendorSelfReference, VendorSelfReferenceCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<VendorSelfReference, VendorSelfReferenceCB> {
            protected VendorSelfReferenceBhv _bhv;
            public MyInternalInsertOrUpdateCallback(VendorSelfReferenceBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(VendorSelfReference entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(VendorSelfReference entity) { _bhv.Update(entity); }
            public VendorSelfReferenceCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(VendorSelfReferenceCB cb, VendorSelfReference entity) {
                cb.Query().SetSelfReferenceId_Equal(entity.SelfReferenceId);
            }
            public int CallbackSelectCount(VendorSelfReferenceCB cb) { return _bhv.SelectCount(cb); }
        }

        public virtual void Delete(VendorSelfReference entity) {
            HelpDeleteInternally<VendorSelfReference>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(Entity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<VendorSelfReference> {
            protected VendorSelfReferenceBhv _bhv;
            public MyInternalDeleteCallback(VendorSelfReferenceBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(VendorSelfReference entity) { return _bhv.DelegateDelete(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(VendorSelfReference vendorSelfReference, VendorSelfReferenceCB cb) {
            AssertObjectNotNull("vendorSelfReference", vendorSelfReference); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(vendorSelfReference);
            FilterEntityOfUpdate(vendorSelfReference); AssertEntityOfUpdate(vendorSelfReference);
            return this.Dao.UpdateByQuery(cb, vendorSelfReference);
        }

        public int QueryDelete(VendorSelfReferenceCB cb) {
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
        protected int DelegateSelectCount(VendorSelfReferenceCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<VendorSelfReference> DelegateSelectList(VendorSelfReferenceCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(VendorSelfReference e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(VendorSelfReference e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(VendorSelfReference e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected VendorSelfReference Downcast(Entity entity) {
            return (VendorSelfReference)entity;
        }

        protected VendorSelfReferenceCB Downcast(ConditionBean cb) {
            return (VendorSelfReferenceCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual VendorSelfReferenceDao Dao { get { return _dao; } set { _dao = value; } }
    }
}

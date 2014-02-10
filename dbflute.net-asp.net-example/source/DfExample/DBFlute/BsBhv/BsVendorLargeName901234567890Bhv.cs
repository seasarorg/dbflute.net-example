
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
    public partial class VendorLargeName901234567890Bhv : DfExample.DBFlute.AllCommon.Bhv.AbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected VendorLargeName901234567890Dao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public VendorLargeName901234567890Bhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "VENDOR_LARGE_NAME_901234567890"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override DBMeta DBMeta { get { return VendorLargeName901234567890Dbm.GetInstance(); } }
        public VendorLargeName901234567890Dbm MyDBMeta { get { return VendorLargeName901234567890Dbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override Entity NewEntity() { return NewMyEntity(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual VendorLargeName901234567890 NewMyEntity() { return new VendorLargeName901234567890(); }
        public virtual VendorLargeName901234567890CB NewMyConditionBean() { return new VendorLargeName901234567890CB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(VendorLargeName901234567890CB cb) {
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
        public virtual VendorLargeName901234567890 SelectEntity(VendorLargeName901234567890CB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<VendorLargeName901234567890> ls = null;
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
            return (VendorLargeName901234567890)ls[0];
        }

        protected override Entity DoReadEntity(ConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual VendorLargeName901234567890 SelectEntityWithDeletedCheck(VendorLargeName901234567890CB cb) {
            AssertConditionBeanNotNull(cb);
            VendorLargeName901234567890 entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override Entity DoReadEntityWithDeletedCheck(ConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual VendorLargeName901234567890 SelectByPKValue(long? vendorLargeName901234567Id) {
            return SelectEntity(BuildPKCB(vendorLargeName901234567Id));
        }

        public virtual VendorLargeName901234567890 SelectByPKValueWithDeletedCheck(long? vendorLargeName901234567Id) {
            return SelectEntityWithDeletedCheck(BuildPKCB(vendorLargeName901234567Id));
        }

        private VendorLargeName901234567890CB BuildPKCB(long? vendorLargeName901234567Id) {
            AssertObjectNotNull("vendorLargeName901234567Id", vendorLargeName901234567Id);
            VendorLargeName901234567890CB cb = NewMyConditionBean();
            cb.Query().SetVendorLargeName901234567Id_Equal(vendorLargeName901234567Id);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual ListResultBean<VendorLargeName901234567890> SelectList(VendorLargeName901234567890CB cb) {
            AssertConditionBeanNotNull(cb);
            return new ResultBeanBuilder<VendorLargeName901234567890>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual PagingResultBean<VendorLargeName901234567890> SelectPage(VendorLargeName901234567890CB cb) {
            AssertConditionBeanNotNull(cb);
            PagingInvoker<VendorLargeName901234567890> invoker = new PagingInvoker<VendorLargeName901234567890>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : PagingHandler<VendorLargeName901234567890> {
            protected VendorLargeName901234567890Bhv _bhv; protected VendorLargeName901234567890CB _cb;
            public InternalSelectPagingHandler(VendorLargeName901234567890Bhv bhv, VendorLargeName901234567890CB cb) { _bhv = bhv; _cb = cb; }
            public PagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<VendorLargeName901234567890> Paging() { return _bhv.SelectList(_cb); }
        }
        #endregion

        // ===============================================================================
        //                                                                   Load Referrer
        //                                                                   =============
        #region Load Referrer
        public virtual void LoadVendorLargeName90123456RefList(VendorLargeName901234567890 vendorLargeName901234567890, ConditionBeanSetupper<VendorLargeName90123456RefCB> conditionBeanSetupper) {
            AssertObjectNotNull("vendorLargeName901234567890", vendorLargeName901234567890); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadVendorLargeName90123456RefList(xnewLRLs<VendorLargeName901234567890>(vendorLargeName901234567890), conditionBeanSetupper);
        }
        public virtual void LoadVendorLargeName90123456RefList(IList<VendorLargeName901234567890> vendorLargeName901234567890List, ConditionBeanSetupper<VendorLargeName90123456RefCB> conditionBeanSetupper) {
            AssertObjectNotNull("vendorLargeName901234567890List", vendorLargeName901234567890List); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadVendorLargeName90123456RefList(vendorLargeName901234567890List, new LoadReferrerOption<VendorLargeName90123456RefCB, VendorLargeName90123456Ref>().xinit(conditionBeanSetupper));
        }
        public virtual void LoadVendorLargeName90123456RefList(VendorLargeName901234567890 vendorLargeName901234567890, LoadReferrerOption<VendorLargeName90123456RefCB, VendorLargeName90123456Ref> loadReferrerOption) {
            AssertObjectNotNull("vendorLargeName901234567890", vendorLargeName901234567890); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            LoadVendorLargeName90123456RefList(xnewLRLs<VendorLargeName901234567890>(vendorLargeName901234567890), loadReferrerOption);
        }
        public virtual void LoadVendorLargeName90123456RefList(IList<VendorLargeName901234567890> vendorLargeName901234567890List, LoadReferrerOption<VendorLargeName90123456RefCB, VendorLargeName90123456Ref> loadReferrerOption) {
            AssertObjectNotNull("vendorLargeName901234567890List", vendorLargeName901234567890List); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            if (vendorLargeName901234567890List.Count == 0) { return; }
            VendorLargeName90123456RefBhv referrerBhv = xgetBSFLR().Select<VendorLargeName90123456RefBhv>();
            HelpLoadReferrerInternally<VendorLargeName901234567890, long?, VendorLargeName90123456RefCB, VendorLargeName90123456Ref>
                    (vendorLargeName901234567890List, loadReferrerOption, new MyInternalLoadVendorLargeName90123456RefListCallback(referrerBhv));
        }
        protected class MyInternalLoadVendorLargeName90123456RefListCallback : InternalLoadReferrerCallback<VendorLargeName901234567890, long?, VendorLargeName90123456RefCB, VendorLargeName90123456Ref> {
            protected VendorLargeName90123456RefBhv referrerBhv;
            public MyInternalLoadVendorLargeName90123456RefListCallback(VendorLargeName90123456RefBhv referrerBhv) { this.referrerBhv = referrerBhv; }
            public long? getPKVal(VendorLargeName901234567890 e) { return e.VendorLargeName901234567Id; }
            public void setRfLs(VendorLargeName901234567890 e, IList<VendorLargeName90123456Ref> ls) { e.VendorLargeName90123456RefList = ls; }
            public VendorLargeName90123456RefCB newMyCB() { return referrerBhv.NewMyConditionBean(); }
            public void qyFKIn(VendorLargeName90123456RefCB cb, IList<long?> ls) { cb.Query().SetVendorLargeName901234567Id_InScope(ls); }
            public void qyOdFKAsc(VendorLargeName90123456RefCB cb) { cb.Query().AddOrderBy_VendorLargeName901234567Id_Asc(); }
            public void spFKCol(VendorLargeName90123456RefCB cb) { cb.Specify().ColumnVendorLargeName901234567Id(); }
            public IList<VendorLargeName90123456Ref> selRfLs(VendorLargeName90123456RefCB cb) { return referrerBhv.SelectList(cb); }
            public long? getFKVal(VendorLargeName90123456Ref e) { return e.VendorLargeName901234567Id; }
            public void setlcEt(VendorLargeName90123456Ref re, VendorLargeName901234567890 be) { re.VendorLargeName901234567890 = be; }
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
        public virtual void Insert(VendorLargeName901234567890 entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(Entity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(VendorLargeName901234567890 entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(Entity entity) {
            Update(Downcast(entity));
        }

        public void InsertOrUpdate(VendorLargeName901234567890 entity) {
            HelpInsertOrUpdateInternally<VendorLargeName901234567890, VendorLargeName901234567890CB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<VendorLargeName901234567890, VendorLargeName901234567890CB> {
            protected VendorLargeName901234567890Bhv _bhv;
            public MyInternalInsertOrUpdateCallback(VendorLargeName901234567890Bhv bhv) { _bhv = bhv; }
            public void CallbackInsert(VendorLargeName901234567890 entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(VendorLargeName901234567890 entity) { _bhv.Update(entity); }
            public VendorLargeName901234567890CB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(VendorLargeName901234567890CB cb, VendorLargeName901234567890 entity) {
                cb.Query().SetVendorLargeName901234567Id_Equal(entity.VendorLargeName901234567Id);
            }
            public int CallbackSelectCount(VendorLargeName901234567890CB cb) { return _bhv.SelectCount(cb); }
        }

        public virtual void Delete(VendorLargeName901234567890 entity) {
            HelpDeleteInternally<VendorLargeName901234567890>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(Entity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<VendorLargeName901234567890> {
            protected VendorLargeName901234567890Bhv _bhv;
            public MyInternalDeleteCallback(VendorLargeName901234567890Bhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(VendorLargeName901234567890 entity) { return _bhv.DelegateDelete(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(VendorLargeName901234567890 vendorLargeName901234567890, VendorLargeName901234567890CB cb) {
            AssertObjectNotNull("vendorLargeName901234567890", vendorLargeName901234567890); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(vendorLargeName901234567890);
            FilterEntityOfUpdate(vendorLargeName901234567890); AssertEntityOfUpdate(vendorLargeName901234567890);
            return this.Dao.UpdateByQuery(cb, vendorLargeName901234567890);
        }

        public int QueryDelete(VendorLargeName901234567890CB cb) {
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
        protected int DelegateSelectCount(VendorLargeName901234567890CB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<VendorLargeName901234567890> DelegateSelectList(VendorLargeName901234567890CB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(VendorLargeName901234567890 e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(VendorLargeName901234567890 e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(VendorLargeName901234567890 e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected VendorLargeName901234567890 Downcast(Entity entity) {
            return (VendorLargeName901234567890)entity;
        }

        protected VendorLargeName901234567890CB Downcast(ConditionBean cb) {
            return (VendorLargeName901234567890CB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual VendorLargeName901234567890Dao Dao { get { return _dao; } set { _dao = value; } }
    }
}

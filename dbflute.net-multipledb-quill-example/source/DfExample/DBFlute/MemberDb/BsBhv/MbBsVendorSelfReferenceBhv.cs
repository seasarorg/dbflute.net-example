
using System;
using System.Collections.Generic;

using Seasar.Quill;
using Seasar.Quill.Attrs;

using DfExample.DBFlute.MemberDb.AllCommon;
using DfExample.DBFlute.MemberDb.AllCommon.Bhv;
using DfExample.DBFlute.MemberDb.AllCommon.Bhv.Load;
using DfExample.DBFlute.MemberDb.AllCommon.Bhv.Setup;
using DfExample.DBFlute.MemberDb.AllCommon.CBean;
using DfExample.DBFlute.MemberDb.AllCommon.Dbm;
using DfExample.DBFlute.MemberDb.AllCommon.Exp;
using DfExample.DBFlute.MemberDb.BsEntity.Dbm;
using DfExample.DBFlute.MemberDb.ExDao;
using DfExample.DBFlute.MemberDb.ExEntity;
using DfExample.DBFlute.MemberDb.CBean;


namespace DfExample.DBFlute.MemberDb.ExBhv {

    [Implementation]
    public partial class MbVendorSelfReferenceBhv : DfExample.DBFlute.MemberDb.AllCommon.Bhv.MbAbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected MbVendorSelfReferenceDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public MbVendorSelfReferenceBhv() {
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
        public override MbDBMeta DBMeta { get { return MbVendorSelfReferenceDbm.GetInstance(); } }
        public MbVendorSelfReferenceDbm MyDBMeta { get { return MbVendorSelfReferenceDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override MbEntity NewEntity() { return NewMyEntity(); }
        public override MbConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual MbVendorSelfReference NewMyEntity() { return new MbVendorSelfReference(); }
        public virtual MbVendorSelfReferenceCB NewMyConditionBean() { return new MbVendorSelfReferenceCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(MbVendorSelfReferenceCB cb) {
            AssertConditionBeanNotNull(cb);
            return this.DelegateSelectCount(cb);
        }

        protected override int DoReadCount(MbConditionBean cb) {
            return SelectCount(Downcast(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                   Entity Select
        //                                                                   =============
        #region Entity Select
        public virtual MbVendorSelfReference SelectEntity(MbVendorSelfReferenceCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<MbVendorSelfReference> ls = null;
            try {
                ls = this.DelegateSelectList(cb);
            } catch (MbDangerousResultSizeException e) {
                ThrowEntityDuplicatedException("{over safetyMaxResultSize '1'}", cb, e);
                return null; // unreachable
            } finally {
                xrestoreSafetyResult(cb, preSafetyMaxResultSize);
            }
            if (ls.Count == 0) { return null; }
            AssertEntitySelectedAsOne(ls, cb);
            return (MbVendorSelfReference)ls[0];
        }

        protected override MbEntity DoReadEntity(MbConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual MbVendorSelfReference SelectEntityWithDeletedCheck(MbVendorSelfReferenceCB cb) {
            AssertConditionBeanNotNull(cb);
            MbVendorSelfReference entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override MbEntity DoReadEntityWithDeletedCheck(MbConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual MbVendorSelfReference SelectByPKValue(long? selfReferenceId) {
            return SelectEntity(BuildPKCB(selfReferenceId));
        }

        public virtual MbVendorSelfReference SelectByPKValueWithDeletedCheck(long? selfReferenceId) {
            return SelectEntityWithDeletedCheck(BuildPKCB(selfReferenceId));
        }

        private MbVendorSelfReferenceCB BuildPKCB(long? selfReferenceId) {
            AssertObjectNotNull("selfReferenceId", selfReferenceId);
            MbVendorSelfReferenceCB cb = NewMyConditionBean();
            cb.Query().SetSelfReferenceId_Equal(selfReferenceId);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual MbListResultBean<MbVendorSelfReference> SelectList(MbVendorSelfReferenceCB cb) {
            AssertConditionBeanNotNull(cb);
            return new MbResultBeanBuilder<MbVendorSelfReference>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual MbPagingResultBean<MbVendorSelfReference> SelectPage(MbVendorSelfReferenceCB cb) {
            AssertConditionBeanNotNull(cb);
            MbPagingInvoker<MbVendorSelfReference> invoker = new MbPagingInvoker<MbVendorSelfReference>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : MbPagingHandler<MbVendorSelfReference> {
            protected MbVendorSelfReferenceBhv _bhv; protected MbVendorSelfReferenceCB _cb;
            public InternalSelectPagingHandler(MbVendorSelfReferenceBhv bhv, MbVendorSelfReferenceCB cb) { _bhv = bhv; _cb = cb; }
            public MbPagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<MbVendorSelfReference> Paging() { return _bhv.SelectList(_cb); }
        }
        #endregion

        // ===============================================================================
        //                                                                   Load Referrer
        //                                                                   =============
        #region Load Referrer
        public virtual void LoadVendorSelfReferenceSelfList(MbVendorSelfReference vendorSelfReference, MbConditionBeanSetupper<MbVendorSelfReferenceCB> conditionBeanSetupper) {
            AssertObjectNotNull("vendorSelfReference", vendorSelfReference); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadVendorSelfReferenceSelfList(xnewLRLs<MbVendorSelfReference>(vendorSelfReference), conditionBeanSetupper);
        }
        public virtual void LoadVendorSelfReferenceSelfList(IList<MbVendorSelfReference> vendorSelfReferenceList, MbConditionBeanSetupper<MbVendorSelfReferenceCB> conditionBeanSetupper) {
            AssertObjectNotNull("vendorSelfReferenceList", vendorSelfReferenceList); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadVendorSelfReferenceSelfList(vendorSelfReferenceList, new MbLoadReferrerOption<MbVendorSelfReferenceCB, MbVendorSelfReference>().xinit(conditionBeanSetupper));
        }
        public virtual void LoadVendorSelfReferenceSelfList(MbVendorSelfReference vendorSelfReference, MbLoadReferrerOption<MbVendorSelfReferenceCB, MbVendorSelfReference> loadReferrerOption) {
            AssertObjectNotNull("vendorSelfReference", vendorSelfReference); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            LoadVendorSelfReferenceSelfList(xnewLRLs<MbVendorSelfReference>(vendorSelfReference), loadReferrerOption);
        }
        public virtual void LoadVendorSelfReferenceSelfList(IList<MbVendorSelfReference> vendorSelfReferenceList, MbLoadReferrerOption<MbVendorSelfReferenceCB, MbVendorSelfReference> loadReferrerOption) {
            AssertObjectNotNull("vendorSelfReferenceList", vendorSelfReferenceList); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            if (vendorSelfReferenceList.Count == 0) { return; }
            MbVendorSelfReferenceBhv referrerBhv = xgetBSFLR().Select<MbVendorSelfReferenceBhv>();
            HelpLoadReferrerInternally<MbVendorSelfReference, long?, MbVendorSelfReferenceCB, MbVendorSelfReference>
                    (vendorSelfReferenceList, loadReferrerOption, new MyInternalLoadVendorSelfReferenceSelfListCallback(referrerBhv));
        }
        protected class MyInternalLoadVendorSelfReferenceSelfListCallback : InternalLoadReferrerCallback<MbVendorSelfReference, long?, MbVendorSelfReferenceCB, MbVendorSelfReference> {
            protected MbVendorSelfReferenceBhv referrerBhv;
            public MyInternalLoadVendorSelfReferenceSelfListCallback(MbVendorSelfReferenceBhv referrerBhv) { this.referrerBhv = referrerBhv; }
            public long? getPKVal(MbVendorSelfReference e) { return e.SelfReferenceId; }
            public void setRfLs(MbVendorSelfReference e, IList<MbVendorSelfReference> ls) { e.VendorSelfReferenceSelfList = ls; }
            public MbVendorSelfReferenceCB newMyCB() { return referrerBhv.NewMyConditionBean(); }
            public void qyFKIn(MbVendorSelfReferenceCB cb, IList<long?> ls) { cb.Query().SetParentId_InScope(ls); }
            public void qyOdFKAsc(MbVendorSelfReferenceCB cb) { cb.Query().AddOrderBy_ParentId_Asc(); }
            public void spFKCol(MbVendorSelfReferenceCB cb) { cb.Specify().ColumnParentId(); }
            public IList<MbVendorSelfReference> selRfLs(MbVendorSelfReferenceCB cb) { return referrerBhv.SelectList(cb); }
            public long? getFKVal(MbVendorSelfReference e) { return e.ParentId; }
            public void setlcEt(MbVendorSelfReference re, MbVendorSelfReference be) { re.VendorSelfReferenceSelf = be; }
        }
        #endregion

        // ===============================================================================
        //                                                                Pull out Foreign
        //                                                                ================
        #region Pullout Foreign
        public IList<MbVendorSelfReference> PulloutVendorSelfReferenceSelf(IList<MbVendorSelfReference> vendorSelfReferenceList) {
            return HelpPulloutInternally<MbVendorSelfReference, MbVendorSelfReference>(vendorSelfReferenceList, new MyInternalPulloutVendorSelfReferenceSelfCallback());
        }
        protected class MyInternalPulloutVendorSelfReferenceSelfCallback : InternalPulloutCallback<MbVendorSelfReference, MbVendorSelfReference> {
            public MbVendorSelfReference getFr(MbVendorSelfReference entity) { return entity.VendorSelfReferenceSelf; }
        }
        #endregion


        // ===============================================================================
        //                                                                   Entity Update
        //                                                                   =============
        #region Basic Entity Update
        public virtual void Insert(MbVendorSelfReference entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(MbEntity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(MbVendorSelfReference entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(MbEntity entity) {
            Update(Downcast(entity));
        }

        public void InsertOrUpdate(MbVendorSelfReference entity) {
            HelpInsertOrUpdateInternally<MbVendorSelfReference, MbVendorSelfReferenceCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<MbVendorSelfReference, MbVendorSelfReferenceCB> {
            protected MbVendorSelfReferenceBhv _bhv;
            public MyInternalInsertOrUpdateCallback(MbVendorSelfReferenceBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(MbVendorSelfReference entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(MbVendorSelfReference entity) { _bhv.Update(entity); }
            public MbVendorSelfReferenceCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(MbVendorSelfReferenceCB cb, MbVendorSelfReference entity) {
                cb.Query().SetSelfReferenceId_Equal(entity.SelfReferenceId);
            }
            public int CallbackSelectCount(MbVendorSelfReferenceCB cb) { return _bhv.SelectCount(cb); }
        }

        public virtual void Delete(MbVendorSelfReference entity) {
            HelpDeleteInternally<MbVendorSelfReference>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(MbEntity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<MbVendorSelfReference> {
            protected MbVendorSelfReferenceBhv _bhv;
            public MyInternalDeleteCallback(MbVendorSelfReferenceBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(MbVendorSelfReference entity) { return _bhv.DelegateDelete(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(MbVendorSelfReference vendorSelfReference, MbVendorSelfReferenceCB cb) {
            AssertObjectNotNull("vendorSelfReference", vendorSelfReference); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(vendorSelfReference);
            FilterEntityOfUpdate(vendorSelfReference); AssertEntityOfUpdate(vendorSelfReference);
            return this.Dao.UpdateByQuery(cb, vendorSelfReference);
        }

        public int QueryDelete(MbVendorSelfReferenceCB cb) {
            AssertConditionBeanNotNull(cb);
            return this.Dao.DeleteByQuery(cb);
        }

        // ===============================================================================
        //                                                            Optimistic Lock Info
        //                                                            ====================
        protected override bool HasVersionNoValue(MbEntity entity) {
            return false;
        }

        protected override bool HasUpdateDateValue(MbEntity entity) {
            return false;
        }

        // ===============================================================================
        //                                                                 Delegate Method
        //                                                                 ===============
        #region Delegate Method
        protected int DelegateSelectCount(MbVendorSelfReferenceCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<MbVendorSelfReference> DelegateSelectList(MbVendorSelfReferenceCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(MbVendorSelfReference e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(MbVendorSelfReference e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(MbVendorSelfReference e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected MbVendorSelfReference Downcast(MbEntity entity) {
            return (MbVendorSelfReference)entity;
        }

        protected MbVendorSelfReferenceCB Downcast(MbConditionBean cb) {
            return (MbVendorSelfReferenceCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual MbVendorSelfReferenceDao Dao { get { return _dao; } set { _dao = value; } }
    }
}

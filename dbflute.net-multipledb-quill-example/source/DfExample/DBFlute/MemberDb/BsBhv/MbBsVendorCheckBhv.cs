
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
    public partial class MbVendorCheckBhv : DfExample.DBFlute.MemberDb.AllCommon.Bhv.MbAbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected MbVendorCheckDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public MbVendorCheckBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "vendor_check"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override MbDBMeta DBMeta { get { return MbVendorCheckDbm.GetInstance(); } }
        public MbVendorCheckDbm MyDBMeta { get { return MbVendorCheckDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override MbEntity NewEntity() { return NewMyEntity(); }
        public override MbConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual MbVendorCheck NewMyEntity() { return new MbVendorCheck(); }
        public virtual MbVendorCheckCB NewMyConditionBean() { return new MbVendorCheckCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(MbVendorCheckCB cb) {
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
        public virtual MbVendorCheck SelectEntity(MbVendorCheckCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<MbVendorCheck> ls = null;
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
            return (MbVendorCheck)ls[0];
        }

        protected override MbEntity DoReadEntity(MbConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual MbVendorCheck SelectEntityWithDeletedCheck(MbVendorCheckCB cb) {
            AssertConditionBeanNotNull(cb);
            MbVendorCheck entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override MbEntity DoReadEntityWithDeletedCheck(MbConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual MbVendorCheck SelectByPKValue(long? vendorCheckId) {
            return SelectEntity(BuildPKCB(vendorCheckId));
        }

        public virtual MbVendorCheck SelectByPKValueWithDeletedCheck(long? vendorCheckId) {
            return SelectEntityWithDeletedCheck(BuildPKCB(vendorCheckId));
        }

        private MbVendorCheckCB BuildPKCB(long? vendorCheckId) {
            AssertObjectNotNull("vendorCheckId", vendorCheckId);
            MbVendorCheckCB cb = NewMyConditionBean();
            cb.Query().SetVendorCheckId_Equal(vendorCheckId);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual MbListResultBean<MbVendorCheck> SelectList(MbVendorCheckCB cb) {
            AssertConditionBeanNotNull(cb);
            return new MbResultBeanBuilder<MbVendorCheck>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual MbPagingResultBean<MbVendorCheck> SelectPage(MbVendorCheckCB cb) {
            AssertConditionBeanNotNull(cb);
            MbPagingInvoker<MbVendorCheck> invoker = new MbPagingInvoker<MbVendorCheck>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : MbPagingHandler<MbVendorCheck> {
            protected MbVendorCheckBhv _bhv; protected MbVendorCheckCB _cb;
            public InternalSelectPagingHandler(MbVendorCheckBhv bhv, MbVendorCheckCB cb) { _bhv = bhv; _cb = cb; }
            public MbPagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<MbVendorCheck> Paging() { return _bhv.SelectList(_cb); }
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
        #endregion


        // ===============================================================================
        //                                                                   Entity Update
        //                                                                   =============
        #region Basic Entity Update
        public virtual void Insert(MbVendorCheck entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(MbEntity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(MbVendorCheck entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(MbEntity entity) {
            Update(Downcast(entity));
        }

        public void InsertOrUpdate(MbVendorCheck entity) {
            HelpInsertOrUpdateInternally<MbVendorCheck, MbVendorCheckCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<MbVendorCheck, MbVendorCheckCB> {
            protected MbVendorCheckBhv _bhv;
            public MyInternalInsertOrUpdateCallback(MbVendorCheckBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(MbVendorCheck entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(MbVendorCheck entity) { _bhv.Update(entity); }
            public MbVendorCheckCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(MbVendorCheckCB cb, MbVendorCheck entity) {
                cb.Query().SetVendorCheckId_Equal(entity.VendorCheckId);
            }
            public int CallbackSelectCount(MbVendorCheckCB cb) { return _bhv.SelectCount(cb); }
        }

        public virtual void Delete(MbVendorCheck entity) {
            HelpDeleteInternally<MbVendorCheck>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(MbEntity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<MbVendorCheck> {
            protected MbVendorCheckBhv _bhv;
            public MyInternalDeleteCallback(MbVendorCheckBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(MbVendorCheck entity) { return _bhv.DelegateDelete(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(MbVendorCheck vendorCheck, MbVendorCheckCB cb) {
            AssertObjectNotNull("vendorCheck", vendorCheck); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(vendorCheck);
            FilterEntityOfUpdate(vendorCheck); AssertEntityOfUpdate(vendorCheck);
            return this.Dao.UpdateByQuery(cb, vendorCheck);
        }

        public int QueryDelete(MbVendorCheckCB cb) {
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
        protected int DelegateSelectCount(MbVendorCheckCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<MbVendorCheck> DelegateSelectList(MbVendorCheckCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(MbVendorCheck e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(MbVendorCheck e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(MbVendorCheck e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected MbVendorCheck Downcast(MbEntity entity) {
            return (MbVendorCheck)entity;
        }

        protected MbVendorCheckCB Downcast(MbConditionBean cb) {
            return (MbVendorCheckCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual MbVendorCheckDao Dao { get { return _dao; } set { _dao = value; } }
    }
}

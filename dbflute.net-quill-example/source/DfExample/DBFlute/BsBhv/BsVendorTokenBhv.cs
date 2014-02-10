
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
    public partial class VendorTokenBhv : DfExample.DBFlute.AllCommon.Bhv.AbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected VendorTokenDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public VendorTokenBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "vendor_token"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override DBMeta DBMeta { get { return VendorTokenDbm.GetInstance(); } }
        public VendorTokenDbm MyDBMeta { get { return VendorTokenDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override Entity NewEntity() { return NewMyEntity(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual VendorToken NewMyEntity() { return new VendorToken(); }
        public virtual VendorTokenCB NewMyConditionBean() { return new VendorTokenCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(VendorTokenCB cb) {
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
        public virtual VendorToken SelectEntity(VendorTokenCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<VendorToken> ls = null;
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
            return (VendorToken)ls[0];
        }

        protected override Entity DoReadEntity(ConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual VendorToken SelectEntityWithDeletedCheck(VendorTokenCB cb) {
            AssertConditionBeanNotNull(cb);
            VendorToken entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override Entity DoReadEntityWithDeletedCheck(ConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual VendorToken SelectByPKValue(long? vendorTokenId) {
            return SelectEntity(BuildPKCB(vendorTokenId));
        }

        public virtual VendorToken SelectByPKValueWithDeletedCheck(long? vendorTokenId) {
            return SelectEntityWithDeletedCheck(BuildPKCB(vendorTokenId));
        }

        private VendorTokenCB BuildPKCB(long? vendorTokenId) {
            AssertObjectNotNull("vendorTokenId", vendorTokenId);
            VendorTokenCB cb = NewMyConditionBean();
            cb.Query().SetVendorTokenId_Equal(vendorTokenId);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual ListResultBean<VendorToken> SelectList(VendorTokenCB cb) {
            AssertConditionBeanNotNull(cb);
            return new ResultBeanBuilder<VendorToken>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual PagingResultBean<VendorToken> SelectPage(VendorTokenCB cb) {
            AssertConditionBeanNotNull(cb);
            PagingInvoker<VendorToken> invoker = new PagingInvoker<VendorToken>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : PagingHandler<VendorToken> {
            protected VendorTokenBhv _bhv; protected VendorTokenCB _cb;
            public InternalSelectPagingHandler(VendorTokenBhv bhv, VendorTokenCB cb) { _bhv = bhv; _cb = cb; }
            public PagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<VendorToken> Paging() { return _bhv.SelectList(_cb); }
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
        public virtual void Insert(VendorToken entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(Entity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(VendorToken entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(Entity entity) {
            Update(Downcast(entity));
        }

        public void InsertOrUpdate(VendorToken entity) {
            HelpInsertOrUpdateInternally<VendorToken, VendorTokenCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<VendorToken, VendorTokenCB> {
            protected VendorTokenBhv _bhv;
            public MyInternalInsertOrUpdateCallback(VendorTokenBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(VendorToken entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(VendorToken entity) { _bhv.Update(entity); }
            public VendorTokenCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(VendorTokenCB cb, VendorToken entity) {
                cb.Query().SetVendorTokenId_Equal(entity.VendorTokenId);
            }
            public int CallbackSelectCount(VendorTokenCB cb) { return _bhv.SelectCount(cb); }
        }

        public virtual void Delete(VendorToken entity) {
            HelpDeleteInternally<VendorToken>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(Entity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<VendorToken> {
            protected VendorTokenBhv _bhv;
            public MyInternalDeleteCallback(VendorTokenBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(VendorToken entity) { return _bhv.DelegateDelete(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(VendorToken vendorToken, VendorTokenCB cb) {
            AssertObjectNotNull("vendorToken", vendorToken); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(vendorToken);
            FilterEntityOfUpdate(vendorToken); AssertEntityOfUpdate(vendorToken);
            return this.Dao.UpdateByQuery(cb, vendorToken);
        }

        public int QueryDelete(VendorTokenCB cb) {
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
        protected int DelegateSelectCount(VendorTokenCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<VendorToken> DelegateSelectList(VendorTokenCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(VendorToken e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(VendorToken e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(VendorToken e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected VendorToken Downcast(Entity entity) {
            return (VendorToken)entity;
        }

        protected VendorTokenCB Downcast(ConditionBean cb) {
            return (VendorTokenCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual VendorTokenDao Dao { get { return _dao; } set { _dao = value; } }
    }
}


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
    public partial class PurchaseBhv : DfExample.DBFlute.AllCommon.Bhv.AbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected PurchaseDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public PurchaseBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "purchase"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override DBMeta DBMeta { get { return PurchaseDbm.GetInstance(); } }
        public PurchaseDbm MyDBMeta { get { return PurchaseDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override Entity NewEntity() { return NewMyEntity(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual Purchase NewMyEntity() { return new Purchase(); }
        public virtual PurchaseCB NewMyConditionBean() { return new PurchaseCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(PurchaseCB cb) {
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
        public virtual Purchase SelectEntity(PurchaseCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<Purchase> ls = null;
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
            return (Purchase)ls[0];
        }

        protected override Entity DoReadEntity(ConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual Purchase SelectEntityWithDeletedCheck(PurchaseCB cb) {
            AssertConditionBeanNotNull(cb);
            Purchase entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override Entity DoReadEntityWithDeletedCheck(ConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual Purchase SelectByPKValue(long? purchaseId) {
            return SelectEntity(BuildPKCB(purchaseId));
        }

        public virtual Purchase SelectByPKValueWithDeletedCheck(long? purchaseId) {
            return SelectEntityWithDeletedCheck(BuildPKCB(purchaseId));
        }

        private PurchaseCB BuildPKCB(long? purchaseId) {
            AssertObjectNotNull("purchaseId", purchaseId);
            PurchaseCB cb = NewMyConditionBean();
            cb.Query().SetPurchaseId_Equal(purchaseId);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual ListResultBean<Purchase> SelectList(PurchaseCB cb) {
            AssertConditionBeanNotNull(cb);
            return new ResultBeanBuilder<Purchase>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual PagingResultBean<Purchase> SelectPage(PurchaseCB cb) {
            AssertConditionBeanNotNull(cb);
            PagingInvoker<Purchase> invoker = new PagingInvoker<Purchase>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : PagingHandler<Purchase> {
            protected PurchaseBhv _bhv; protected PurchaseCB _cb;
            public InternalSelectPagingHandler(PurchaseBhv bhv, PurchaseCB cb) { _bhv = bhv; _cb = cb; }
            public PagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<Purchase> Paging() { return _bhv.SelectList(_cb); }
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
        public IList<Member> PulloutMember(IList<Purchase> purchaseList) {
            return HelpPulloutInternally<Purchase, Member>(purchaseList, new MyInternalPulloutMemberCallback());
        }
        protected class MyInternalPulloutMemberCallback : InternalPulloutCallback<Purchase, Member> {
            public Member getFr(Purchase entity) { return entity.Member; }
        }
        public IList<Product> PulloutProduct(IList<Purchase> purchaseList) {
            return HelpPulloutInternally<Purchase, Product>(purchaseList, new MyInternalPulloutProductCallback());
        }
        protected class MyInternalPulloutProductCallback : InternalPulloutCallback<Purchase, Product> {
            public Product getFr(Purchase entity) { return entity.Product; }
        }
        #endregion


        // ===============================================================================
        //                                                                   Entity Update
        //                                                                   =============
        #region Basic Entity Update
        public virtual void Insert(Purchase entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(Entity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(Purchase entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(Entity entity) {
            Update(Downcast(entity));
        }

        public virtual void UpdateNonstrict(Purchase entity) {
            AssertEntityNotNull(entity);
            int updatedCount = this.DelegateUpdateNonstrict(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        public void InsertOrUpdate(Purchase entity) {
            HelpInsertOrUpdateInternally<Purchase, PurchaseCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<Purchase, PurchaseCB> {
            protected PurchaseBhv _bhv;
            public MyInternalInsertOrUpdateCallback(PurchaseBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(Purchase entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(Purchase entity) { _bhv.Update(entity); }
            public PurchaseCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(PurchaseCB cb, Purchase entity) {
                cb.Query().SetPurchaseId_Equal(entity.PurchaseId);
            }
            public int CallbackSelectCount(PurchaseCB cb) { return _bhv.SelectCount(cb); }
        }

        public void InsertOrUpdateNonstrict(Purchase entity) {
            HelpInsertOrUpdateInternally<Purchase>(entity, new MyInternalInsertOrUpdateNonstrictCallback(this));
        }
        protected class MyInternalInsertOrUpdateNonstrictCallback : InternalInsertOrUpdateNonstrictCallback<Purchase> {
            protected PurchaseBhv _bhv;
            public MyInternalInsertOrUpdateNonstrictCallback(PurchaseBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(Purchase entity) { _bhv.Insert(entity); }
            public void CallbackUpdateNonstrict(Purchase entity) { _bhv.UpdateNonstrict(entity); }
        }

        public virtual void Delete(Purchase entity) {
            HelpDeleteInternally<Purchase>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(Entity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<Purchase> {
            protected PurchaseBhv _bhv;
            public MyInternalDeleteCallback(PurchaseBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(Purchase entity) { return _bhv.DelegateDelete(entity); }
        }

        public virtual void DeleteNonstrict(Purchase entity) {
            HelpDeleteNonstrictInternally<Purchase>(entity, new MyInternalDeleteNonstrictCallback(this));
        }
        protected class MyInternalDeleteNonstrictCallback : InternalDeleteNonstrictCallback<Purchase> {
            protected PurchaseBhv _bhv;
            public MyInternalDeleteNonstrictCallback(PurchaseBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDeleteNonstrict(Purchase entity) { return _bhv.DelegateDeleteNonstrict(entity); }
        }

        public virtual void DeleteNonstrictIgnoreDeleted(Purchase entity) {
            HelpDeleteNonstrictIgnoreDeletedInternally<Purchase>(entity, new MyInternalDeleteNonstrictIgnoreDeletedCallback(this));
        }
        protected class MyInternalDeleteNonstrictIgnoreDeletedCallback : InternalDeleteNonstrictIgnoreDeletedCallback<Purchase> {
            protected PurchaseBhv _bhv;
            public MyInternalDeleteNonstrictIgnoreDeletedCallback(PurchaseBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDeleteNonstrict(Purchase entity) { return _bhv.DelegateDeleteNonstrict(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(Purchase purchase, PurchaseCB cb) {
            AssertObjectNotNull("purchase", purchase); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(purchase);
            FilterEntityOfUpdate(purchase); AssertEntityOfUpdate(purchase);
            return this.Dao.UpdateByQuery(cb, purchase);
        }

        public int QueryDelete(PurchaseCB cb) {
            AssertConditionBeanNotNull(cb);
            return this.Dao.DeleteByQuery(cb);
        }

        // ===============================================================================
        //                                                            Optimistic Lock Info
        //                                                            ====================
        protected override bool HasVersionNoValue(Entity entity) {
            return Downcast(entity).VersionNo != null;
        }

        protected override bool HasUpdateDateValue(Entity entity) {
            return false;
        }

        // ===============================================================================
        //                                                                 Delegate Method
        //                                                                 ===============
        #region Delegate Method
        protected int DelegateSelectCount(PurchaseCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<Purchase> DelegateSelectList(PurchaseCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(Purchase e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(Purchase e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateModifiedOnly(e); }
        protected int DelegateUpdateNonstrict(Purchase e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(Purchase e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.Delete(e); }
        protected int DelegateDeleteNonstrict(Purchase e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected Purchase Downcast(Entity entity) {
            return (Purchase)entity;
        }

        protected PurchaseCB Downcast(ConditionBean cb) {
            return (PurchaseCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual PurchaseDao Dao { get { return _dao; } set { _dao = value; } }
    }
}

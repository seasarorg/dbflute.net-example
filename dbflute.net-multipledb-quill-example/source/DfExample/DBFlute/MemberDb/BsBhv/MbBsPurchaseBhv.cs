
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
    public partial class MbPurchaseBhv : DfExample.DBFlute.MemberDb.AllCommon.Bhv.MbAbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected MbPurchaseDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public MbPurchaseBhv() {
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
        public override MbDBMeta DBMeta { get { return MbPurchaseDbm.GetInstance(); } }
        public MbPurchaseDbm MyDBMeta { get { return MbPurchaseDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override MbEntity NewEntity() { return NewMyEntity(); }
        public override MbConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual MbPurchase NewMyEntity() { return new MbPurchase(); }
        public virtual MbPurchaseCB NewMyConditionBean() { return new MbPurchaseCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(MbPurchaseCB cb) {
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
        public virtual MbPurchase SelectEntity(MbPurchaseCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<MbPurchase> ls = null;
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
            return (MbPurchase)ls[0];
        }

        protected override MbEntity DoReadEntity(MbConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual MbPurchase SelectEntityWithDeletedCheck(MbPurchaseCB cb) {
            AssertConditionBeanNotNull(cb);
            MbPurchase entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override MbEntity DoReadEntityWithDeletedCheck(MbConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual MbPurchase SelectByPKValue(long? purchaseId) {
            return SelectEntity(BuildPKCB(purchaseId));
        }

        public virtual MbPurchase SelectByPKValueWithDeletedCheck(long? purchaseId) {
            return SelectEntityWithDeletedCheck(BuildPKCB(purchaseId));
        }

        private MbPurchaseCB BuildPKCB(long? purchaseId) {
            AssertObjectNotNull("purchaseId", purchaseId);
            MbPurchaseCB cb = NewMyConditionBean();
            cb.Query().SetPurchaseId_Equal(purchaseId);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual MbListResultBean<MbPurchase> SelectList(MbPurchaseCB cb) {
            AssertConditionBeanNotNull(cb);
            return new MbResultBeanBuilder<MbPurchase>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual MbPagingResultBean<MbPurchase> SelectPage(MbPurchaseCB cb) {
            AssertConditionBeanNotNull(cb);
            MbPagingInvoker<MbPurchase> invoker = new MbPagingInvoker<MbPurchase>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : MbPagingHandler<MbPurchase> {
            protected MbPurchaseBhv _bhv; protected MbPurchaseCB _cb;
            public InternalSelectPagingHandler(MbPurchaseBhv bhv, MbPurchaseCB cb) { _bhv = bhv; _cb = cb; }
            public MbPagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<MbPurchase> Paging() { return _bhv.SelectList(_cb); }
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
        public IList<MbMember> PulloutMember(IList<MbPurchase> purchaseList) {
            return HelpPulloutInternally<MbPurchase, MbMember>(purchaseList, new MyInternalPulloutMemberCallback());
        }
        protected class MyInternalPulloutMemberCallback : InternalPulloutCallback<MbPurchase, MbMember> {
            public MbMember getFr(MbPurchase entity) { return entity.Member; }
        }
        public IList<MbProduct> PulloutProduct(IList<MbPurchase> purchaseList) {
            return HelpPulloutInternally<MbPurchase, MbProduct>(purchaseList, new MyInternalPulloutProductCallback());
        }
        protected class MyInternalPulloutProductCallback : InternalPulloutCallback<MbPurchase, MbProduct> {
            public MbProduct getFr(MbPurchase entity) { return entity.Product; }
        }
        #endregion


        // ===============================================================================
        //                                                                   Entity Update
        //                                                                   =============
        #region Basic Entity Update
        public virtual void Insert(MbPurchase entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(MbEntity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(MbPurchase entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(MbEntity entity) {
            Update(Downcast(entity));
        }

        public virtual void UpdateNonstrict(MbPurchase entity) {
            AssertEntityNotNull(entity);
            int updatedCount = this.DelegateUpdateNonstrict(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        public void InsertOrUpdate(MbPurchase entity) {
            HelpInsertOrUpdateInternally<MbPurchase, MbPurchaseCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<MbPurchase, MbPurchaseCB> {
            protected MbPurchaseBhv _bhv;
            public MyInternalInsertOrUpdateCallback(MbPurchaseBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(MbPurchase entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(MbPurchase entity) { _bhv.Update(entity); }
            public MbPurchaseCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(MbPurchaseCB cb, MbPurchase entity) {
                cb.Query().SetPurchaseId_Equal(entity.PurchaseId);
            }
            public int CallbackSelectCount(MbPurchaseCB cb) { return _bhv.SelectCount(cb); }
        }

        public void InsertOrUpdateNonstrict(MbPurchase entity) {
            HelpInsertOrUpdateInternally<MbPurchase>(entity, new MyInternalInsertOrUpdateNonstrictCallback(this));
        }
        protected class MyInternalInsertOrUpdateNonstrictCallback : InternalInsertOrUpdateNonstrictCallback<MbPurchase> {
            protected MbPurchaseBhv _bhv;
            public MyInternalInsertOrUpdateNonstrictCallback(MbPurchaseBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(MbPurchase entity) { _bhv.Insert(entity); }
            public void CallbackUpdateNonstrict(MbPurchase entity) { _bhv.UpdateNonstrict(entity); }
        }

        public virtual void Delete(MbPurchase entity) {
            HelpDeleteInternally<MbPurchase>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(MbEntity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<MbPurchase> {
            protected MbPurchaseBhv _bhv;
            public MyInternalDeleteCallback(MbPurchaseBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(MbPurchase entity) { return _bhv.DelegateDelete(entity); }
        }

        public virtual void DeleteNonstrict(MbPurchase entity) {
            HelpDeleteNonstrictInternally<MbPurchase>(entity, new MyInternalDeleteNonstrictCallback(this));
        }
        protected class MyInternalDeleteNonstrictCallback : InternalDeleteNonstrictCallback<MbPurchase> {
            protected MbPurchaseBhv _bhv;
            public MyInternalDeleteNonstrictCallback(MbPurchaseBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDeleteNonstrict(MbPurchase entity) { return _bhv.DelegateDeleteNonstrict(entity); }
        }

        public virtual void DeleteNonstrictIgnoreDeleted(MbPurchase entity) {
            HelpDeleteNonstrictIgnoreDeletedInternally<MbPurchase>(entity, new MyInternalDeleteNonstrictIgnoreDeletedCallback(this));
        }
        protected class MyInternalDeleteNonstrictIgnoreDeletedCallback : InternalDeleteNonstrictIgnoreDeletedCallback<MbPurchase> {
            protected MbPurchaseBhv _bhv;
            public MyInternalDeleteNonstrictIgnoreDeletedCallback(MbPurchaseBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDeleteNonstrict(MbPurchase entity) { return _bhv.DelegateDeleteNonstrict(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(MbPurchase purchase, MbPurchaseCB cb) {
            AssertObjectNotNull("purchase", purchase); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(purchase);
            FilterEntityOfUpdate(purchase); AssertEntityOfUpdate(purchase);
            return this.Dao.UpdateByQuery(cb, purchase);
        }

        public int QueryDelete(MbPurchaseCB cb) {
            AssertConditionBeanNotNull(cb);
            return this.Dao.DeleteByQuery(cb);
        }

        // ===============================================================================
        //                                                            Optimistic Lock Info
        //                                                            ====================
        protected override bool HasVersionNoValue(MbEntity entity) {
            return Downcast(entity).VersionNo != null;
        }

        protected override bool HasUpdateDateValue(MbEntity entity) {
            return false;
        }

        // ===============================================================================
        //                                                                 Delegate Method
        //                                                                 ===============
        #region Delegate Method
        protected int DelegateSelectCount(MbPurchaseCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<MbPurchase> DelegateSelectList(MbPurchaseCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(MbPurchase e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(MbPurchase e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateModifiedOnly(e); }
        protected int DelegateUpdateNonstrict(MbPurchase e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(MbPurchase e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.Delete(e); }
        protected int DelegateDeleteNonstrict(MbPurchase e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected MbPurchase Downcast(MbEntity entity) {
            return (MbPurchase)entity;
        }

        protected MbPurchaseCB Downcast(MbConditionBean cb) {
            return (MbPurchaseCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual MbPurchaseDao Dao { get { return _dao; } set { _dao = value; } }
    }
}

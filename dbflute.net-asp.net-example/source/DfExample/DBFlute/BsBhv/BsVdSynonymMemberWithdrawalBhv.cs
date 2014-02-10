
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
    public partial class VdSynonymMemberWithdrawalBhv : DfExample.DBFlute.AllCommon.Bhv.AbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected VdSynonymMemberWithdrawalDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public VdSynonymMemberWithdrawalBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "VD_SYNONYM_MEMBER_WITHDRAWAL"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override DBMeta DBMeta { get { return VdSynonymMemberWithdrawalDbm.GetInstance(); } }
        public VdSynonymMemberWithdrawalDbm MyDBMeta { get { return VdSynonymMemberWithdrawalDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override Entity NewEntity() { return NewMyEntity(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual VdSynonymMemberWithdrawal NewMyEntity() { return new VdSynonymMemberWithdrawal(); }
        public virtual VdSynonymMemberWithdrawalCB NewMyConditionBean() { return new VdSynonymMemberWithdrawalCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(VdSynonymMemberWithdrawalCB cb) {
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
        public virtual VdSynonymMemberWithdrawal SelectEntity(VdSynonymMemberWithdrawalCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<VdSynonymMemberWithdrawal> ls = null;
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
            return (VdSynonymMemberWithdrawal)ls[0];
        }

        protected override Entity DoReadEntity(ConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual VdSynonymMemberWithdrawal SelectEntityWithDeletedCheck(VdSynonymMemberWithdrawalCB cb) {
            AssertConditionBeanNotNull(cb);
            VdSynonymMemberWithdrawal entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override Entity DoReadEntityWithDeletedCheck(ConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual VdSynonymMemberWithdrawal SelectByPKValue(long? memberId) {
            return SelectEntity(BuildPKCB(memberId));
        }

        public virtual VdSynonymMemberWithdrawal SelectByPKValueWithDeletedCheck(long? memberId) {
            return SelectEntityWithDeletedCheck(BuildPKCB(memberId));
        }

        private VdSynonymMemberWithdrawalCB BuildPKCB(long? memberId) {
            AssertObjectNotNull("memberId", memberId);
            VdSynonymMemberWithdrawalCB cb = NewMyConditionBean();
            cb.Query().SetMemberId_Equal(memberId);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual ListResultBean<VdSynonymMemberWithdrawal> SelectList(VdSynonymMemberWithdrawalCB cb) {
            AssertConditionBeanNotNull(cb);
            return new ResultBeanBuilder<VdSynonymMemberWithdrawal>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual PagingResultBean<VdSynonymMemberWithdrawal> SelectPage(VdSynonymMemberWithdrawalCB cb) {
            AssertConditionBeanNotNull(cb);
            PagingInvoker<VdSynonymMemberWithdrawal> invoker = new PagingInvoker<VdSynonymMemberWithdrawal>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : PagingHandler<VdSynonymMemberWithdrawal> {
            protected VdSynonymMemberWithdrawalBhv _bhv; protected VdSynonymMemberWithdrawalCB _cb;
            public InternalSelectPagingHandler(VdSynonymMemberWithdrawalBhv bhv, VdSynonymMemberWithdrawalCB cb) { _bhv = bhv; _cb = cb; }
            public PagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<VdSynonymMemberWithdrawal> Paging() { return _bhv.SelectList(_cb); }
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
        public IList<MemberVendorSynonym> PulloutMemberVendorSynonym(IList<VdSynonymMemberWithdrawal> vdSynonymMemberWithdrawalList) {
            return HelpPulloutInternally<VdSynonymMemberWithdrawal, MemberVendorSynonym>(vdSynonymMemberWithdrawalList, new MyInternalPulloutMemberVendorSynonymCallback());
        }
        protected class MyInternalPulloutMemberVendorSynonymCallback : InternalPulloutCallback<VdSynonymMemberWithdrawal, MemberVendorSynonym> {
            public MemberVendorSynonym getFr(VdSynonymMemberWithdrawal entity) { return entity.MemberVendorSynonym; }
        }
        public IList<WithdrawalReason> PulloutWithdrawalReason(IList<VdSynonymMemberWithdrawal> vdSynonymMemberWithdrawalList) {
            return HelpPulloutInternally<VdSynonymMemberWithdrawal, WithdrawalReason>(vdSynonymMemberWithdrawalList, new MyInternalPulloutWithdrawalReasonCallback());
        }
        protected class MyInternalPulloutWithdrawalReasonCallback : InternalPulloutCallback<VdSynonymMemberWithdrawal, WithdrawalReason> {
            public WithdrawalReason getFr(VdSynonymMemberWithdrawal entity) { return entity.WithdrawalReason; }
        }
        public IList<VdSynonymMember> PulloutVdSynonymMember(IList<VdSynonymMemberWithdrawal> vdSynonymMemberWithdrawalList) {
            return HelpPulloutInternally<VdSynonymMemberWithdrawal, VdSynonymMember>(vdSynonymMemberWithdrawalList, new MyInternalPulloutVdSynonymMemberCallback());
        }
        protected class MyInternalPulloutVdSynonymMemberCallback : InternalPulloutCallback<VdSynonymMemberWithdrawal, VdSynonymMember> {
            public VdSynonymMember getFr(VdSynonymMemberWithdrawal entity) { return entity.VdSynonymMember; }
        }
        public IList<VendorSynonymMember> PulloutVendorSynonymMember(IList<VdSynonymMemberWithdrawal> vdSynonymMemberWithdrawalList) {
            return HelpPulloutInternally<VdSynonymMemberWithdrawal, VendorSynonymMember>(vdSynonymMemberWithdrawalList, new MyInternalPulloutVendorSynonymMemberCallback());
        }
        protected class MyInternalPulloutVendorSynonymMemberCallback : InternalPulloutCallback<VdSynonymMemberWithdrawal, VendorSynonymMember> {
            public VendorSynonymMember getFr(VdSynonymMemberWithdrawal entity) { return entity.VendorSynonymMember; }
        }
        #endregion


        // ===============================================================================
        //                                                                   Entity Update
        //                                                                   =============
        #region Basic Entity Update
        public virtual void Insert(VdSynonymMemberWithdrawal entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(Entity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(VdSynonymMemberWithdrawal entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(Entity entity) {
            Update(Downcast(entity));
        }

        public virtual void UpdateNonstrict(VdSynonymMemberWithdrawal entity) {
            AssertEntityNotNull(entity);
            int updatedCount = this.DelegateUpdateNonstrict(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        public void InsertOrUpdate(VdSynonymMemberWithdrawal entity) {
            HelpInsertOrUpdateInternally<VdSynonymMemberWithdrawal, VdSynonymMemberWithdrawalCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<VdSynonymMemberWithdrawal, VdSynonymMemberWithdrawalCB> {
            protected VdSynonymMemberWithdrawalBhv _bhv;
            public MyInternalInsertOrUpdateCallback(VdSynonymMemberWithdrawalBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(VdSynonymMemberWithdrawal entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(VdSynonymMemberWithdrawal entity) { _bhv.Update(entity); }
            public VdSynonymMemberWithdrawalCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(VdSynonymMemberWithdrawalCB cb, VdSynonymMemberWithdrawal entity) {
                cb.Query().SetMemberId_Equal(entity.MemberId);
            }
            public int CallbackSelectCount(VdSynonymMemberWithdrawalCB cb) { return _bhv.SelectCount(cb); }
        }

        public void InsertOrUpdateNonstrict(VdSynonymMemberWithdrawal entity) {
            HelpInsertOrUpdateInternally<VdSynonymMemberWithdrawal>(entity, new MyInternalInsertOrUpdateNonstrictCallback(this));
        }
        protected class MyInternalInsertOrUpdateNonstrictCallback : InternalInsertOrUpdateNonstrictCallback<VdSynonymMemberWithdrawal> {
            protected VdSynonymMemberWithdrawalBhv _bhv;
            public MyInternalInsertOrUpdateNonstrictCallback(VdSynonymMemberWithdrawalBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(VdSynonymMemberWithdrawal entity) { _bhv.Insert(entity); }
            public void CallbackUpdateNonstrict(VdSynonymMemberWithdrawal entity) { _bhv.UpdateNonstrict(entity); }
        }

        public virtual void Delete(VdSynonymMemberWithdrawal entity) {
            HelpDeleteInternally<VdSynonymMemberWithdrawal>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(Entity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<VdSynonymMemberWithdrawal> {
            protected VdSynonymMemberWithdrawalBhv _bhv;
            public MyInternalDeleteCallback(VdSynonymMemberWithdrawalBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(VdSynonymMemberWithdrawal entity) { return _bhv.DelegateDelete(entity); }
        }

        public virtual void DeleteNonstrict(VdSynonymMemberWithdrawal entity) {
            HelpDeleteNonstrictInternally<VdSynonymMemberWithdrawal>(entity, new MyInternalDeleteNonstrictCallback(this));
        }
        protected class MyInternalDeleteNonstrictCallback : InternalDeleteNonstrictCallback<VdSynonymMemberWithdrawal> {
            protected VdSynonymMemberWithdrawalBhv _bhv;
            public MyInternalDeleteNonstrictCallback(VdSynonymMemberWithdrawalBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDeleteNonstrict(VdSynonymMemberWithdrawal entity) { return _bhv.DelegateDeleteNonstrict(entity); }
        }

        public virtual void DeleteNonstrictIgnoreDeleted(VdSynonymMemberWithdrawal entity) {
            HelpDeleteNonstrictIgnoreDeletedInternally<VdSynonymMemberWithdrawal>(entity, new MyInternalDeleteNonstrictIgnoreDeletedCallback(this));
        }
        protected class MyInternalDeleteNonstrictIgnoreDeletedCallback : InternalDeleteNonstrictIgnoreDeletedCallback<VdSynonymMemberWithdrawal> {
            protected VdSynonymMemberWithdrawalBhv _bhv;
            public MyInternalDeleteNonstrictIgnoreDeletedCallback(VdSynonymMemberWithdrawalBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDeleteNonstrict(VdSynonymMemberWithdrawal entity) { return _bhv.DelegateDeleteNonstrict(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(VdSynonymMemberWithdrawal vdSynonymMemberWithdrawal, VdSynonymMemberWithdrawalCB cb) {
            AssertObjectNotNull("vdSynonymMemberWithdrawal", vdSynonymMemberWithdrawal); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(vdSynonymMemberWithdrawal);
            FilterEntityOfUpdate(vdSynonymMemberWithdrawal); AssertEntityOfUpdate(vdSynonymMemberWithdrawal);
            return this.Dao.UpdateByQuery(cb, vdSynonymMemberWithdrawal);
        }

        public int QueryDelete(VdSynonymMemberWithdrawalCB cb) {
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
        protected int DelegateSelectCount(VdSynonymMemberWithdrawalCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<VdSynonymMemberWithdrawal> DelegateSelectList(VdSynonymMemberWithdrawalCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(VdSynonymMemberWithdrawal e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(VdSynonymMemberWithdrawal e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateModifiedOnly(e); }
        protected int DelegateUpdateNonstrict(VdSynonymMemberWithdrawal e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(VdSynonymMemberWithdrawal e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.Delete(e); }
        protected int DelegateDeleteNonstrict(VdSynonymMemberWithdrawal e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        protected override void FilterEntityOfInsert(Entity targetEntity) {
            base.FilterEntityOfInsert(targetEntity);
            VdSynonymMemberWithdrawal entity = (VdSynonymMemberWithdrawal)targetEntity;
            entity.WithdrawalDatetime = DfExample.DBFlute.AllCommon.AccessContext.GetAccessTimestampOnThread();
        }

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected VdSynonymMemberWithdrawal Downcast(Entity entity) {
            return (VdSynonymMemberWithdrawal)entity;
        }

        protected VdSynonymMemberWithdrawalCB Downcast(ConditionBean cb) {
            return (VdSynonymMemberWithdrawalCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual VdSynonymMemberWithdrawalDao Dao { get { return _dao; } set { _dao = value; } }
    }
}

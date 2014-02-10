
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
    public partial class MemberWithdrawalBhv : DfExample.DBFlute.AllCommon.Bhv.AbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected MemberWithdrawalDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public MemberWithdrawalBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "member_withdrawal"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override DBMeta DBMeta { get { return MemberWithdrawalDbm.GetInstance(); } }
        public MemberWithdrawalDbm MyDBMeta { get { return MemberWithdrawalDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override Entity NewEntity() { return NewMyEntity(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual MemberWithdrawal NewMyEntity() { return new MemberWithdrawal(); }
        public virtual MemberWithdrawalCB NewMyConditionBean() { return new MemberWithdrawalCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(MemberWithdrawalCB cb) {
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
        public virtual MemberWithdrawal SelectEntity(MemberWithdrawalCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<MemberWithdrawal> ls = null;
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
            return (MemberWithdrawal)ls[0];
        }

        protected override Entity DoReadEntity(ConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual MemberWithdrawal SelectEntityWithDeletedCheck(MemberWithdrawalCB cb) {
            AssertConditionBeanNotNull(cb);
            MemberWithdrawal entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override Entity DoReadEntityWithDeletedCheck(ConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual MemberWithdrawal SelectByPKValue(int? memberId) {
            return SelectEntity(BuildPKCB(memberId));
        }

        public virtual MemberWithdrawal SelectByPKValueWithDeletedCheck(int? memberId) {
            return SelectEntityWithDeletedCheck(BuildPKCB(memberId));
        }

        private MemberWithdrawalCB BuildPKCB(int? memberId) {
            AssertObjectNotNull("memberId", memberId);
            MemberWithdrawalCB cb = NewMyConditionBean();
            cb.Query().SetMemberId_Equal(memberId);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual ListResultBean<MemberWithdrawal> SelectList(MemberWithdrawalCB cb) {
            AssertConditionBeanNotNull(cb);
            return new ResultBeanBuilder<MemberWithdrawal>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual PagingResultBean<MemberWithdrawal> SelectPage(MemberWithdrawalCB cb) {
            AssertConditionBeanNotNull(cb);
            PagingInvoker<MemberWithdrawal> invoker = new PagingInvoker<MemberWithdrawal>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : PagingHandler<MemberWithdrawal> {
            protected MemberWithdrawalBhv _bhv; protected MemberWithdrawalCB _cb;
            public InternalSelectPagingHandler(MemberWithdrawalBhv bhv, MemberWithdrawalCB cb) { _bhv = bhv; _cb = cb; }
            public PagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<MemberWithdrawal> Paging() { return _bhv.SelectList(_cb); }
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
        public IList<Member> PulloutMember(IList<MemberWithdrawal> memberWithdrawalList) {
            return HelpPulloutInternally<MemberWithdrawal, Member>(memberWithdrawalList, new MyInternalPulloutMemberCallback());
        }
        protected class MyInternalPulloutMemberCallback : InternalPulloutCallback<MemberWithdrawal, Member> {
            public Member getFr(MemberWithdrawal entity) { return entity.Member; }
        }
        public IList<WithdrawalReason> PulloutWithdrawalReason(IList<MemberWithdrawal> memberWithdrawalList) {
            return HelpPulloutInternally<MemberWithdrawal, WithdrawalReason>(memberWithdrawalList, new MyInternalPulloutWithdrawalReasonCallback());
        }
        protected class MyInternalPulloutWithdrawalReasonCallback : InternalPulloutCallback<MemberWithdrawal, WithdrawalReason> {
            public WithdrawalReason getFr(MemberWithdrawal entity) { return entity.WithdrawalReason; }
        }
        #endregion


        // ===============================================================================
        //                                                                   Entity Update
        //                                                                   =============
        #region Basic Entity Update
        public virtual void Insert(MemberWithdrawal entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(Entity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(MemberWithdrawal entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(Entity entity) {
            Update(Downcast(entity));
        }

        public virtual void UpdateNonstrict(MemberWithdrawal entity) {
            AssertEntityNotNull(entity);
            int updatedCount = this.DelegateUpdateNonstrict(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        public void InsertOrUpdate(MemberWithdrawal entity) {
            HelpInsertOrUpdateInternally<MemberWithdrawal, MemberWithdrawalCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<MemberWithdrawal, MemberWithdrawalCB> {
            protected MemberWithdrawalBhv _bhv;
            public MyInternalInsertOrUpdateCallback(MemberWithdrawalBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(MemberWithdrawal entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(MemberWithdrawal entity) { _bhv.Update(entity); }
            public MemberWithdrawalCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(MemberWithdrawalCB cb, MemberWithdrawal entity) {
                cb.Query().SetMemberId_Equal(entity.MemberId);
            }
            public int CallbackSelectCount(MemberWithdrawalCB cb) { return _bhv.SelectCount(cb); }
        }

        public void InsertOrUpdateNonstrict(MemberWithdrawal entity) {
            HelpInsertOrUpdateInternally<MemberWithdrawal>(entity, new MyInternalInsertOrUpdateNonstrictCallback(this));
        }
        protected class MyInternalInsertOrUpdateNonstrictCallback : InternalInsertOrUpdateNonstrictCallback<MemberWithdrawal> {
            protected MemberWithdrawalBhv _bhv;
            public MyInternalInsertOrUpdateNonstrictCallback(MemberWithdrawalBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(MemberWithdrawal entity) { _bhv.Insert(entity); }
            public void CallbackUpdateNonstrict(MemberWithdrawal entity) { _bhv.UpdateNonstrict(entity); }
        }

        public virtual void Delete(MemberWithdrawal entity) {
            HelpDeleteInternally<MemberWithdrawal>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(Entity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<MemberWithdrawal> {
            protected MemberWithdrawalBhv _bhv;
            public MyInternalDeleteCallback(MemberWithdrawalBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(MemberWithdrawal entity) { return _bhv.DelegateDelete(entity); }
        }

        public virtual void DeleteNonstrict(MemberWithdrawal entity) {
            HelpDeleteNonstrictInternally<MemberWithdrawal>(entity, new MyInternalDeleteNonstrictCallback(this));
        }
        protected class MyInternalDeleteNonstrictCallback : InternalDeleteNonstrictCallback<MemberWithdrawal> {
            protected MemberWithdrawalBhv _bhv;
            public MyInternalDeleteNonstrictCallback(MemberWithdrawalBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDeleteNonstrict(MemberWithdrawal entity) { return _bhv.DelegateDeleteNonstrict(entity); }
        }

        public virtual void DeleteNonstrictIgnoreDeleted(MemberWithdrawal entity) {
            HelpDeleteNonstrictIgnoreDeletedInternally<MemberWithdrawal>(entity, new MyInternalDeleteNonstrictIgnoreDeletedCallback(this));
        }
        protected class MyInternalDeleteNonstrictIgnoreDeletedCallback : InternalDeleteNonstrictIgnoreDeletedCallback<MemberWithdrawal> {
            protected MemberWithdrawalBhv _bhv;
            public MyInternalDeleteNonstrictIgnoreDeletedCallback(MemberWithdrawalBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDeleteNonstrict(MemberWithdrawal entity) { return _bhv.DelegateDeleteNonstrict(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(MemberWithdrawal memberWithdrawal, MemberWithdrawalCB cb) {
            AssertObjectNotNull("memberWithdrawal", memberWithdrawal); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(memberWithdrawal);
            FilterEntityOfUpdate(memberWithdrawal); AssertEntityOfUpdate(memberWithdrawal);
            return this.Dao.UpdateByQuery(cb, memberWithdrawal);
        }

        public int QueryDelete(MemberWithdrawalCB cb) {
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
        protected int DelegateSelectCount(MemberWithdrawalCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<MemberWithdrawal> DelegateSelectList(MemberWithdrawalCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(MemberWithdrawal e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(MemberWithdrawal e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateModifiedOnly(e); }
        protected int DelegateUpdateNonstrict(MemberWithdrawal e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(MemberWithdrawal e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.Delete(e); }
        protected int DelegateDeleteNonstrict(MemberWithdrawal e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        protected override void FilterEntityOfInsert(Entity targetEntity) {
            base.FilterEntityOfInsert(targetEntity);
            MemberWithdrawal entity = (MemberWithdrawal)targetEntity;
            entity.WithdrawalDatetime = DfExample.DBFlute.AllCommon.AccessContext.GetAccessTimestampOnThread();
        }

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected MemberWithdrawal Downcast(Entity entity) {
            return (MemberWithdrawal)entity;
        }

        protected MemberWithdrawalCB Downcast(ConditionBean cb) {
            return (MemberWithdrawalCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual MemberWithdrawalDao Dao { get { return _dao; } set { _dao = value; } }
    }
}

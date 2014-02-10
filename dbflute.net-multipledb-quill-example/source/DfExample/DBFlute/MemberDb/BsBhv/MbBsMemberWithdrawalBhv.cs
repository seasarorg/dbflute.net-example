
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
    public partial class MbMemberWithdrawalBhv : DfExample.DBFlute.MemberDb.AllCommon.Bhv.MbAbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected MbMemberWithdrawalDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public MbMemberWithdrawalBhv() {
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
        public override MbDBMeta DBMeta { get { return MbMemberWithdrawalDbm.GetInstance(); } }
        public MbMemberWithdrawalDbm MyDBMeta { get { return MbMemberWithdrawalDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override MbEntity NewEntity() { return NewMyEntity(); }
        public override MbConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual MbMemberWithdrawal NewMyEntity() { return new MbMemberWithdrawal(); }
        public virtual MbMemberWithdrawalCB NewMyConditionBean() { return new MbMemberWithdrawalCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(MbMemberWithdrawalCB cb) {
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
        public virtual MbMemberWithdrawal SelectEntity(MbMemberWithdrawalCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<MbMemberWithdrawal> ls = null;
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
            return (MbMemberWithdrawal)ls[0];
        }

        protected override MbEntity DoReadEntity(MbConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual MbMemberWithdrawal SelectEntityWithDeletedCheck(MbMemberWithdrawalCB cb) {
            AssertConditionBeanNotNull(cb);
            MbMemberWithdrawal entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override MbEntity DoReadEntityWithDeletedCheck(MbConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual MbMemberWithdrawal SelectByPKValue(int? memberId) {
            return SelectEntity(BuildPKCB(memberId));
        }

        public virtual MbMemberWithdrawal SelectByPKValueWithDeletedCheck(int? memberId) {
            return SelectEntityWithDeletedCheck(BuildPKCB(memberId));
        }

        private MbMemberWithdrawalCB BuildPKCB(int? memberId) {
            AssertObjectNotNull("memberId", memberId);
            MbMemberWithdrawalCB cb = NewMyConditionBean();
            cb.Query().SetMemberId_Equal(memberId);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual MbListResultBean<MbMemberWithdrawal> SelectList(MbMemberWithdrawalCB cb) {
            AssertConditionBeanNotNull(cb);
            return new MbResultBeanBuilder<MbMemberWithdrawal>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual MbPagingResultBean<MbMemberWithdrawal> SelectPage(MbMemberWithdrawalCB cb) {
            AssertConditionBeanNotNull(cb);
            MbPagingInvoker<MbMemberWithdrawal> invoker = new MbPagingInvoker<MbMemberWithdrawal>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : MbPagingHandler<MbMemberWithdrawal> {
            protected MbMemberWithdrawalBhv _bhv; protected MbMemberWithdrawalCB _cb;
            public InternalSelectPagingHandler(MbMemberWithdrawalBhv bhv, MbMemberWithdrawalCB cb) { _bhv = bhv; _cb = cb; }
            public MbPagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<MbMemberWithdrawal> Paging() { return _bhv.SelectList(_cb); }
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
        public IList<MbMember> PulloutMember(IList<MbMemberWithdrawal> memberWithdrawalList) {
            return HelpPulloutInternally<MbMemberWithdrawal, MbMember>(memberWithdrawalList, new MyInternalPulloutMemberCallback());
        }
        protected class MyInternalPulloutMemberCallback : InternalPulloutCallback<MbMemberWithdrawal, MbMember> {
            public MbMember getFr(MbMemberWithdrawal entity) { return entity.Member; }
        }
        public IList<MbWithdrawalReason> PulloutWithdrawalReason(IList<MbMemberWithdrawal> memberWithdrawalList) {
            return HelpPulloutInternally<MbMemberWithdrawal, MbWithdrawalReason>(memberWithdrawalList, new MyInternalPulloutWithdrawalReasonCallback());
        }
        protected class MyInternalPulloutWithdrawalReasonCallback : InternalPulloutCallback<MbMemberWithdrawal, MbWithdrawalReason> {
            public MbWithdrawalReason getFr(MbMemberWithdrawal entity) { return entity.WithdrawalReason; }
        }
        #endregion


        // ===============================================================================
        //                                                                   Entity Update
        //                                                                   =============
        #region Basic Entity Update
        public virtual void Insert(MbMemberWithdrawal entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(MbEntity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(MbMemberWithdrawal entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(MbEntity entity) {
            Update(Downcast(entity));
        }

        public virtual void UpdateNonstrict(MbMemberWithdrawal entity) {
            AssertEntityNotNull(entity);
            int updatedCount = this.DelegateUpdateNonstrict(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        public void InsertOrUpdate(MbMemberWithdrawal entity) {
            HelpInsertOrUpdateInternally<MbMemberWithdrawal, MbMemberWithdrawalCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<MbMemberWithdrawal, MbMemberWithdrawalCB> {
            protected MbMemberWithdrawalBhv _bhv;
            public MyInternalInsertOrUpdateCallback(MbMemberWithdrawalBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(MbMemberWithdrawal entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(MbMemberWithdrawal entity) { _bhv.Update(entity); }
            public MbMemberWithdrawalCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(MbMemberWithdrawalCB cb, MbMemberWithdrawal entity) {
                cb.Query().SetMemberId_Equal(entity.MemberId);
            }
            public int CallbackSelectCount(MbMemberWithdrawalCB cb) { return _bhv.SelectCount(cb); }
        }

        public void InsertOrUpdateNonstrict(MbMemberWithdrawal entity) {
            HelpInsertOrUpdateInternally<MbMemberWithdrawal>(entity, new MyInternalInsertOrUpdateNonstrictCallback(this));
        }
        protected class MyInternalInsertOrUpdateNonstrictCallback : InternalInsertOrUpdateNonstrictCallback<MbMemberWithdrawal> {
            protected MbMemberWithdrawalBhv _bhv;
            public MyInternalInsertOrUpdateNonstrictCallback(MbMemberWithdrawalBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(MbMemberWithdrawal entity) { _bhv.Insert(entity); }
            public void CallbackUpdateNonstrict(MbMemberWithdrawal entity) { _bhv.UpdateNonstrict(entity); }
        }

        public virtual void Delete(MbMemberWithdrawal entity) {
            HelpDeleteInternally<MbMemberWithdrawal>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(MbEntity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<MbMemberWithdrawal> {
            protected MbMemberWithdrawalBhv _bhv;
            public MyInternalDeleteCallback(MbMemberWithdrawalBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(MbMemberWithdrawal entity) { return _bhv.DelegateDelete(entity); }
        }

        public virtual void DeleteNonstrict(MbMemberWithdrawal entity) {
            HelpDeleteNonstrictInternally<MbMemberWithdrawal>(entity, new MyInternalDeleteNonstrictCallback(this));
        }
        protected class MyInternalDeleteNonstrictCallback : InternalDeleteNonstrictCallback<MbMemberWithdrawal> {
            protected MbMemberWithdrawalBhv _bhv;
            public MyInternalDeleteNonstrictCallback(MbMemberWithdrawalBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDeleteNonstrict(MbMemberWithdrawal entity) { return _bhv.DelegateDeleteNonstrict(entity); }
        }

        public virtual void DeleteNonstrictIgnoreDeleted(MbMemberWithdrawal entity) {
            HelpDeleteNonstrictIgnoreDeletedInternally<MbMemberWithdrawal>(entity, new MyInternalDeleteNonstrictIgnoreDeletedCallback(this));
        }
        protected class MyInternalDeleteNonstrictIgnoreDeletedCallback : InternalDeleteNonstrictIgnoreDeletedCallback<MbMemberWithdrawal> {
            protected MbMemberWithdrawalBhv _bhv;
            public MyInternalDeleteNonstrictIgnoreDeletedCallback(MbMemberWithdrawalBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDeleteNonstrict(MbMemberWithdrawal entity) { return _bhv.DelegateDeleteNonstrict(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(MbMemberWithdrawal memberWithdrawal, MbMemberWithdrawalCB cb) {
            AssertObjectNotNull("memberWithdrawal", memberWithdrawal); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(memberWithdrawal);
            FilterEntityOfUpdate(memberWithdrawal); AssertEntityOfUpdate(memberWithdrawal);
            return this.Dao.UpdateByQuery(cb, memberWithdrawal);
        }

        public int QueryDelete(MbMemberWithdrawalCB cb) {
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
        protected int DelegateSelectCount(MbMemberWithdrawalCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<MbMemberWithdrawal> DelegateSelectList(MbMemberWithdrawalCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(MbMemberWithdrawal e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(MbMemberWithdrawal e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateModifiedOnly(e); }
        protected int DelegateUpdateNonstrict(MbMemberWithdrawal e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(MbMemberWithdrawal e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.Delete(e); }
        protected int DelegateDeleteNonstrict(MbMemberWithdrawal e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        protected override void FilterEntityOfInsert(MbEntity targetEntity) {
            base.FilterEntityOfInsert(targetEntity);
            MbMemberWithdrawal entity = (MbMemberWithdrawal)targetEntity;
            entity.WithdrawalDatetime = DfExample.DBFlute.MemberDb.AllCommon.MbAccessContext.GetAccessTimestampOnThread();
        }

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected MbMemberWithdrawal Downcast(MbEntity entity) {
            return (MbMemberWithdrawal)entity;
        }

        protected MbMemberWithdrawalCB Downcast(MbConditionBean cb) {
            return (MbMemberWithdrawalCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual MbMemberWithdrawalDao Dao { get { return _dao; } set { _dao = value; } }
    }
}

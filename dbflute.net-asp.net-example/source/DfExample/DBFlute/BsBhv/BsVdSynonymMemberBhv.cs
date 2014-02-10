
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
    public partial class VdSynonymMemberBhv : DfExample.DBFlute.AllCommon.Bhv.AbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected VdSynonymMemberDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public VdSynonymMemberBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "VD_SYNONYM_MEMBER"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override DBMeta DBMeta { get { return VdSynonymMemberDbm.GetInstance(); } }
        public VdSynonymMemberDbm MyDBMeta { get { return VdSynonymMemberDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override Entity NewEntity() { return NewMyEntity(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual VdSynonymMember NewMyEntity() { return new VdSynonymMember(); }
        public virtual VdSynonymMemberCB NewMyConditionBean() { return new VdSynonymMemberCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(VdSynonymMemberCB cb) {
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
        public virtual VdSynonymMember SelectEntity(VdSynonymMemberCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<VdSynonymMember> ls = null;
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
            return (VdSynonymMember)ls[0];
        }

        protected override Entity DoReadEntity(ConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual VdSynonymMember SelectEntityWithDeletedCheck(VdSynonymMemberCB cb) {
            AssertConditionBeanNotNull(cb);
            VdSynonymMember entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override Entity DoReadEntityWithDeletedCheck(ConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual VdSynonymMember SelectByPKValue(long? memberId) {
            return SelectEntity(BuildPKCB(memberId));
        }

        public virtual VdSynonymMember SelectByPKValueWithDeletedCheck(long? memberId) {
            return SelectEntityWithDeletedCheck(BuildPKCB(memberId));
        }

        private VdSynonymMemberCB BuildPKCB(long? memberId) {
            AssertObjectNotNull("memberId", memberId);
            VdSynonymMemberCB cb = NewMyConditionBean();
            cb.Query().SetMemberId_Equal(memberId);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual ListResultBean<VdSynonymMember> SelectList(VdSynonymMemberCB cb) {
            AssertConditionBeanNotNull(cb);
            return new ResultBeanBuilder<VdSynonymMember>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual PagingResultBean<VdSynonymMember> SelectPage(VdSynonymMemberCB cb) {
            AssertConditionBeanNotNull(cb);
            PagingInvoker<VdSynonymMember> invoker = new PagingInvoker<VdSynonymMember>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : PagingHandler<VdSynonymMember> {
            protected VdSynonymMemberBhv _bhv; protected VdSynonymMemberCB _cb;
            public InternalSelectPagingHandler(VdSynonymMemberBhv bhv, VdSynonymMemberCB cb) { _bhv = bhv; _cb = cb; }
            public PagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<VdSynonymMember> Paging() { return _bhv.SelectList(_cb); }
        }
        #endregion

        // ===============================================================================
        //                                                                   Load Referrer
        //                                                                   =============
        #region Load Referrer
        public virtual void LoadVdSynonymMemberLoginList(VdSynonymMember vdSynonymMember, ConditionBeanSetupper<VdSynonymMemberLoginCB> conditionBeanSetupper) {
            AssertObjectNotNull("vdSynonymMember", vdSynonymMember); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadVdSynonymMemberLoginList(xnewLRLs<VdSynonymMember>(vdSynonymMember), conditionBeanSetupper);
        }
        public virtual void LoadVdSynonymMemberLoginList(IList<VdSynonymMember> vdSynonymMemberList, ConditionBeanSetupper<VdSynonymMemberLoginCB> conditionBeanSetupper) {
            AssertObjectNotNull("vdSynonymMemberList", vdSynonymMemberList); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadVdSynonymMemberLoginList(vdSynonymMemberList, new LoadReferrerOption<VdSynonymMemberLoginCB, VdSynonymMemberLogin>().xinit(conditionBeanSetupper));
        }
        public virtual void LoadVdSynonymMemberLoginList(VdSynonymMember vdSynonymMember, LoadReferrerOption<VdSynonymMemberLoginCB, VdSynonymMemberLogin> loadReferrerOption) {
            AssertObjectNotNull("vdSynonymMember", vdSynonymMember); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            LoadVdSynonymMemberLoginList(xnewLRLs<VdSynonymMember>(vdSynonymMember), loadReferrerOption);
        }
        public virtual void LoadVdSynonymMemberLoginList(IList<VdSynonymMember> vdSynonymMemberList, LoadReferrerOption<VdSynonymMemberLoginCB, VdSynonymMemberLogin> loadReferrerOption) {
            AssertObjectNotNull("vdSynonymMemberList", vdSynonymMemberList); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            if (vdSynonymMemberList.Count == 0) { return; }
            VdSynonymMemberLoginBhv referrerBhv = xgetBSFLR().Select<VdSynonymMemberLoginBhv>();
            HelpLoadReferrerInternally<VdSynonymMember, long?, VdSynonymMemberLoginCB, VdSynonymMemberLogin>
                    (vdSynonymMemberList, loadReferrerOption, new MyInternalLoadVdSynonymMemberLoginListCallback(referrerBhv));
        }
        protected class MyInternalLoadVdSynonymMemberLoginListCallback : InternalLoadReferrerCallback<VdSynonymMember, long?, VdSynonymMemberLoginCB, VdSynonymMemberLogin> {
            protected VdSynonymMemberLoginBhv referrerBhv;
            public MyInternalLoadVdSynonymMemberLoginListCallback(VdSynonymMemberLoginBhv referrerBhv) { this.referrerBhv = referrerBhv; }
            public long? getPKVal(VdSynonymMember e) { return e.MemberId; }
            public void setRfLs(VdSynonymMember e, IList<VdSynonymMemberLogin> ls) { e.VdSynonymMemberLoginList = ls; }
            public VdSynonymMemberLoginCB newMyCB() { return referrerBhv.NewMyConditionBean(); }
            public void qyFKIn(VdSynonymMemberLoginCB cb, IList<long?> ls) { cb.Query().SetMemberId_InScope(ls); }
            public void qyOdFKAsc(VdSynonymMemberLoginCB cb) { cb.Query().AddOrderBy_MemberId_Asc(); }
            public void spFKCol(VdSynonymMemberLoginCB cb) { cb.Specify().ColumnMemberId(); }
            public IList<VdSynonymMemberLogin> selRfLs(VdSynonymMemberLoginCB cb) { return referrerBhv.SelectList(cb); }
            public long? getFKVal(VdSynonymMemberLogin e) { return e.MemberId; }
            public void setlcEt(VdSynonymMemberLogin re, VdSynonymMember be) { re.VdSynonymMember = be; }
        }
        #endregion

        // ===============================================================================
        //                                                                Pull out Foreign
        //                                                                ================
        #region Pullout Foreign
        public IList<MemberStatus> PulloutMemberStatus(IList<VdSynonymMember> vdSynonymMemberList) {
            return HelpPulloutInternally<VdSynonymMember, MemberStatus>(vdSynonymMemberList, new MyInternalPulloutMemberStatusCallback());
        }
        protected class MyInternalPulloutMemberStatusCallback : InternalPulloutCallback<VdSynonymMember, MemberStatus> {
            public MemberStatus getFr(VdSynonymMember entity) { return entity.MemberStatus; }
        }
        public IList<VdSynonymMemberWithdrawal> PulloutVdSynonymMemberWithdrawalAsOne(IList<VdSynonymMember> vdSynonymMemberList) {
            return HelpPulloutInternally<VdSynonymMember, VdSynonymMemberWithdrawal>(vdSynonymMemberList, new MyInternalPulloutVdSynonymMemberWithdrawalListCallback());
        }
        protected class MyInternalPulloutVdSynonymMemberWithdrawalListCallback : InternalPulloutCallback<VdSynonymMember, VdSynonymMemberWithdrawal> {
            public VdSynonymMemberWithdrawal getFr(VdSynonymMember entity) { return entity.VdSynonymMemberWithdrawalAsOne; }
        }
        #endregion


        // ===============================================================================
        //                                                                   Entity Update
        //                                                                   =============
        #region Basic Entity Update
        public virtual void Insert(VdSynonymMember entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(Entity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(VdSynonymMember entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(Entity entity) {
            Update(Downcast(entity));
        }

        public virtual void UpdateNonstrict(VdSynonymMember entity) {
            AssertEntityNotNull(entity);
            int updatedCount = this.DelegateUpdateNonstrict(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        public void InsertOrUpdate(VdSynonymMember entity) {
            HelpInsertOrUpdateInternally<VdSynonymMember, VdSynonymMemberCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<VdSynonymMember, VdSynonymMemberCB> {
            protected VdSynonymMemberBhv _bhv;
            public MyInternalInsertOrUpdateCallback(VdSynonymMemberBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(VdSynonymMember entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(VdSynonymMember entity) { _bhv.Update(entity); }
            public VdSynonymMemberCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(VdSynonymMemberCB cb, VdSynonymMember entity) {
                cb.Query().SetMemberId_Equal(entity.MemberId);
            }
            public int CallbackSelectCount(VdSynonymMemberCB cb) { return _bhv.SelectCount(cb); }
        }

        public void InsertOrUpdateNonstrict(VdSynonymMember entity) {
            HelpInsertOrUpdateInternally<VdSynonymMember>(entity, new MyInternalInsertOrUpdateNonstrictCallback(this));
        }
        protected class MyInternalInsertOrUpdateNonstrictCallback : InternalInsertOrUpdateNonstrictCallback<VdSynonymMember> {
            protected VdSynonymMemberBhv _bhv;
            public MyInternalInsertOrUpdateNonstrictCallback(VdSynonymMemberBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(VdSynonymMember entity) { _bhv.Insert(entity); }
            public void CallbackUpdateNonstrict(VdSynonymMember entity) { _bhv.UpdateNonstrict(entity); }
        }

        public virtual void Delete(VdSynonymMember entity) {
            HelpDeleteInternally<VdSynonymMember>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(Entity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<VdSynonymMember> {
            protected VdSynonymMemberBhv _bhv;
            public MyInternalDeleteCallback(VdSynonymMemberBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(VdSynonymMember entity) { return _bhv.DelegateDelete(entity); }
        }

        public virtual void DeleteNonstrict(VdSynonymMember entity) {
            HelpDeleteNonstrictInternally<VdSynonymMember>(entity, new MyInternalDeleteNonstrictCallback(this));
        }
        protected class MyInternalDeleteNonstrictCallback : InternalDeleteNonstrictCallback<VdSynonymMember> {
            protected VdSynonymMemberBhv _bhv;
            public MyInternalDeleteNonstrictCallback(VdSynonymMemberBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDeleteNonstrict(VdSynonymMember entity) { return _bhv.DelegateDeleteNonstrict(entity); }
        }

        public virtual void DeleteNonstrictIgnoreDeleted(VdSynonymMember entity) {
            HelpDeleteNonstrictIgnoreDeletedInternally<VdSynonymMember>(entity, new MyInternalDeleteNonstrictIgnoreDeletedCallback(this));
        }
        protected class MyInternalDeleteNonstrictIgnoreDeletedCallback : InternalDeleteNonstrictIgnoreDeletedCallback<VdSynonymMember> {
            protected VdSynonymMemberBhv _bhv;
            public MyInternalDeleteNonstrictIgnoreDeletedCallback(VdSynonymMemberBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDeleteNonstrict(VdSynonymMember entity) { return _bhv.DelegateDeleteNonstrict(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(VdSynonymMember vdSynonymMember, VdSynonymMemberCB cb) {
            AssertObjectNotNull("vdSynonymMember", vdSynonymMember); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(vdSynonymMember);
            FilterEntityOfUpdate(vdSynonymMember); AssertEntityOfUpdate(vdSynonymMember);
            return this.Dao.UpdateByQuery(cb, vdSynonymMember);
        }

        public int QueryDelete(VdSynonymMemberCB cb) {
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
        protected int DelegateSelectCount(VdSynonymMemberCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<VdSynonymMember> DelegateSelectList(VdSynonymMemberCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(VdSynonymMember e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(VdSynonymMember e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateModifiedOnly(e); }
        protected int DelegateUpdateNonstrict(VdSynonymMember e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(VdSynonymMember e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.Delete(e); }
        protected int DelegateDeleteNonstrict(VdSynonymMember e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected VdSynonymMember Downcast(Entity entity) {
            return (VdSynonymMember)entity;
        }

        protected VdSynonymMemberCB Downcast(ConditionBean cb) {
            return (VdSynonymMemberCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual VdSynonymMemberDao Dao { get { return _dao; } set { _dao = value; } }
    }
}

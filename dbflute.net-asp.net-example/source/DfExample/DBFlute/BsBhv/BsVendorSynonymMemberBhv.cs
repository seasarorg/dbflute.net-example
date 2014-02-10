
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
    public partial class VendorSynonymMemberBhv : DfExample.DBFlute.AllCommon.Bhv.AbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected VendorSynonymMemberDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public VendorSynonymMemberBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "VENDOR_SYNONYM_MEMBER"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override DBMeta DBMeta { get { return VendorSynonymMemberDbm.GetInstance(); } }
        public VendorSynonymMemberDbm MyDBMeta { get { return VendorSynonymMemberDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override Entity NewEntity() { return NewMyEntity(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual VendorSynonymMember NewMyEntity() { return new VendorSynonymMember(); }
        public virtual VendorSynonymMemberCB NewMyConditionBean() { return new VendorSynonymMemberCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(VendorSynonymMemberCB cb) {
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
        public virtual VendorSynonymMember SelectEntity(VendorSynonymMemberCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<VendorSynonymMember> ls = null;
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
            return (VendorSynonymMember)ls[0];
        }

        protected override Entity DoReadEntity(ConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual VendorSynonymMember SelectEntityWithDeletedCheck(VendorSynonymMemberCB cb) {
            AssertConditionBeanNotNull(cb);
            VendorSynonymMember entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override Entity DoReadEntityWithDeletedCheck(ConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual VendorSynonymMember SelectByPKValue(long? memberId) {
            return SelectEntity(BuildPKCB(memberId));
        }

        public virtual VendorSynonymMember SelectByPKValueWithDeletedCheck(long? memberId) {
            return SelectEntityWithDeletedCheck(BuildPKCB(memberId));
        }

        private VendorSynonymMemberCB BuildPKCB(long? memberId) {
            AssertObjectNotNull("memberId", memberId);
            VendorSynonymMemberCB cb = NewMyConditionBean();
            cb.Query().SetMemberId_Equal(memberId);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual ListResultBean<VendorSynonymMember> SelectList(VendorSynonymMemberCB cb) {
            AssertConditionBeanNotNull(cb);
            return new ResultBeanBuilder<VendorSynonymMember>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual PagingResultBean<VendorSynonymMember> SelectPage(VendorSynonymMemberCB cb) {
            AssertConditionBeanNotNull(cb);
            PagingInvoker<VendorSynonymMember> invoker = new PagingInvoker<VendorSynonymMember>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : PagingHandler<VendorSynonymMember> {
            protected VendorSynonymMemberBhv _bhv; protected VendorSynonymMemberCB _cb;
            public InternalSelectPagingHandler(VendorSynonymMemberBhv bhv, VendorSynonymMemberCB cb) { _bhv = bhv; _cb = cb; }
            public PagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<VendorSynonymMember> Paging() { return _bhv.SelectList(_cb); }
        }
        #endregion

        // ===============================================================================
        //                                                                   Load Referrer
        //                                                                   =============
        #region Load Referrer
        public virtual void LoadVdSynonymMemberLoginList(VendorSynonymMember vendorSynonymMember, ConditionBeanSetupper<VdSynonymMemberLoginCB> conditionBeanSetupper) {
            AssertObjectNotNull("vendorSynonymMember", vendorSynonymMember); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadVdSynonymMemberLoginList(xnewLRLs<VendorSynonymMember>(vendorSynonymMember), conditionBeanSetupper);
        }
        public virtual void LoadVdSynonymMemberLoginList(IList<VendorSynonymMember> vendorSynonymMemberList, ConditionBeanSetupper<VdSynonymMemberLoginCB> conditionBeanSetupper) {
            AssertObjectNotNull("vendorSynonymMemberList", vendorSynonymMemberList); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadVdSynonymMemberLoginList(vendorSynonymMemberList, new LoadReferrerOption<VdSynonymMemberLoginCB, VdSynonymMemberLogin>().xinit(conditionBeanSetupper));
        }
        public virtual void LoadVdSynonymMemberLoginList(VendorSynonymMember vendorSynonymMember, LoadReferrerOption<VdSynonymMemberLoginCB, VdSynonymMemberLogin> loadReferrerOption) {
            AssertObjectNotNull("vendorSynonymMember", vendorSynonymMember); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            LoadVdSynonymMemberLoginList(xnewLRLs<VendorSynonymMember>(vendorSynonymMember), loadReferrerOption);
        }
        public virtual void LoadVdSynonymMemberLoginList(IList<VendorSynonymMember> vendorSynonymMemberList, LoadReferrerOption<VdSynonymMemberLoginCB, VdSynonymMemberLogin> loadReferrerOption) {
            AssertObjectNotNull("vendorSynonymMemberList", vendorSynonymMemberList); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            if (vendorSynonymMemberList.Count == 0) { return; }
            VdSynonymMemberLoginBhv referrerBhv = xgetBSFLR().Select<VdSynonymMemberLoginBhv>();
            HelpLoadReferrerInternally<VendorSynonymMember, long?, VdSynonymMemberLoginCB, VdSynonymMemberLogin>
                    (vendorSynonymMemberList, loadReferrerOption, new MyInternalLoadVdSynonymMemberLoginListCallback(referrerBhv));
        }
        protected class MyInternalLoadVdSynonymMemberLoginListCallback : InternalLoadReferrerCallback<VendorSynonymMember, long?, VdSynonymMemberLoginCB, VdSynonymMemberLogin> {
            protected VdSynonymMemberLoginBhv referrerBhv;
            public MyInternalLoadVdSynonymMemberLoginListCallback(VdSynonymMemberLoginBhv referrerBhv) { this.referrerBhv = referrerBhv; }
            public long? getPKVal(VendorSynonymMember e) { return e.MemberId; }
            public void setRfLs(VendorSynonymMember e, IList<VdSynonymMemberLogin> ls) { e.VdSynonymMemberLoginList = ls; }
            public VdSynonymMemberLoginCB newMyCB() { return referrerBhv.NewMyConditionBean(); }
            public void qyFKIn(VdSynonymMemberLoginCB cb, IList<long?> ls) { cb.Query().SetMemberId_InScope(ls); }
            public void qyOdFKAsc(VdSynonymMemberLoginCB cb) { cb.Query().AddOrderBy_MemberId_Asc(); }
            public void spFKCol(VdSynonymMemberLoginCB cb) { cb.Specify().ColumnMemberId(); }
            public IList<VdSynonymMemberLogin> selRfLs(VdSynonymMemberLoginCB cb) { return referrerBhv.SelectList(cb); }
            public long? getFKVal(VdSynonymMemberLogin e) { return e.MemberId; }
            public void setlcEt(VdSynonymMemberLogin re, VendorSynonymMember be) { re.VendorSynonymMember = be; }
        }
        #endregion

        // ===============================================================================
        //                                                                Pull out Foreign
        //                                                                ================
        #region Pullout Foreign
        public IList<MemberStatus> PulloutMemberStatus(IList<VendorSynonymMember> vendorSynonymMemberList) {
            return HelpPulloutInternally<VendorSynonymMember, MemberStatus>(vendorSynonymMemberList, new MyInternalPulloutMemberStatusCallback());
        }
        protected class MyInternalPulloutMemberStatusCallback : InternalPulloutCallback<VendorSynonymMember, MemberStatus> {
            public MemberStatus getFr(VendorSynonymMember entity) { return entity.MemberStatus; }
        }
        public IList<VdSynonymMemberWithdrawal> PulloutVdSynonymMemberWithdrawalAsOne(IList<VendorSynonymMember> vendorSynonymMemberList) {
            return HelpPulloutInternally<VendorSynonymMember, VdSynonymMemberWithdrawal>(vendorSynonymMemberList, new MyInternalPulloutVdSynonymMemberWithdrawalListCallback());
        }
        protected class MyInternalPulloutVdSynonymMemberWithdrawalListCallback : InternalPulloutCallback<VendorSynonymMember, VdSynonymMemberWithdrawal> {
            public VdSynonymMemberWithdrawal getFr(VendorSynonymMember entity) { return entity.VdSynonymMemberWithdrawalAsOne; }
        }
        #endregion


        // ===============================================================================
        //                                                                   Entity Update
        //                                                                   =============
        #region Basic Entity Update
        public virtual void Insert(VendorSynonymMember entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(Entity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(VendorSynonymMember entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(Entity entity) {
            Update(Downcast(entity));
        }

        public virtual void UpdateNonstrict(VendorSynonymMember entity) {
            AssertEntityNotNull(entity);
            int updatedCount = this.DelegateUpdateNonstrict(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        public void InsertOrUpdate(VendorSynonymMember entity) {
            HelpInsertOrUpdateInternally<VendorSynonymMember, VendorSynonymMemberCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<VendorSynonymMember, VendorSynonymMemberCB> {
            protected VendorSynonymMemberBhv _bhv;
            public MyInternalInsertOrUpdateCallback(VendorSynonymMemberBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(VendorSynonymMember entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(VendorSynonymMember entity) { _bhv.Update(entity); }
            public VendorSynonymMemberCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(VendorSynonymMemberCB cb, VendorSynonymMember entity) {
                cb.Query().SetMemberId_Equal(entity.MemberId);
            }
            public int CallbackSelectCount(VendorSynonymMemberCB cb) { return _bhv.SelectCount(cb); }
        }

        public void InsertOrUpdateNonstrict(VendorSynonymMember entity) {
            HelpInsertOrUpdateInternally<VendorSynonymMember>(entity, new MyInternalInsertOrUpdateNonstrictCallback(this));
        }
        protected class MyInternalInsertOrUpdateNonstrictCallback : InternalInsertOrUpdateNonstrictCallback<VendorSynonymMember> {
            protected VendorSynonymMemberBhv _bhv;
            public MyInternalInsertOrUpdateNonstrictCallback(VendorSynonymMemberBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(VendorSynonymMember entity) { _bhv.Insert(entity); }
            public void CallbackUpdateNonstrict(VendorSynonymMember entity) { _bhv.UpdateNonstrict(entity); }
        }

        public virtual void Delete(VendorSynonymMember entity) {
            HelpDeleteInternally<VendorSynonymMember>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(Entity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<VendorSynonymMember> {
            protected VendorSynonymMemberBhv _bhv;
            public MyInternalDeleteCallback(VendorSynonymMemberBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(VendorSynonymMember entity) { return _bhv.DelegateDelete(entity); }
        }

        public virtual void DeleteNonstrict(VendorSynonymMember entity) {
            HelpDeleteNonstrictInternally<VendorSynonymMember>(entity, new MyInternalDeleteNonstrictCallback(this));
        }
        protected class MyInternalDeleteNonstrictCallback : InternalDeleteNonstrictCallback<VendorSynonymMember> {
            protected VendorSynonymMemberBhv _bhv;
            public MyInternalDeleteNonstrictCallback(VendorSynonymMemberBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDeleteNonstrict(VendorSynonymMember entity) { return _bhv.DelegateDeleteNonstrict(entity); }
        }

        public virtual void DeleteNonstrictIgnoreDeleted(VendorSynonymMember entity) {
            HelpDeleteNonstrictIgnoreDeletedInternally<VendorSynonymMember>(entity, new MyInternalDeleteNonstrictIgnoreDeletedCallback(this));
        }
        protected class MyInternalDeleteNonstrictIgnoreDeletedCallback : InternalDeleteNonstrictIgnoreDeletedCallback<VendorSynonymMember> {
            protected VendorSynonymMemberBhv _bhv;
            public MyInternalDeleteNonstrictIgnoreDeletedCallback(VendorSynonymMemberBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDeleteNonstrict(VendorSynonymMember entity) { return _bhv.DelegateDeleteNonstrict(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(VendorSynonymMember vendorSynonymMember, VendorSynonymMemberCB cb) {
            AssertObjectNotNull("vendorSynonymMember", vendorSynonymMember); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(vendorSynonymMember);
            FilterEntityOfUpdate(vendorSynonymMember); AssertEntityOfUpdate(vendorSynonymMember);
            return this.Dao.UpdateByQuery(cb, vendorSynonymMember);
        }

        public int QueryDelete(VendorSynonymMemberCB cb) {
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
        protected int DelegateSelectCount(VendorSynonymMemberCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<VendorSynonymMember> DelegateSelectList(VendorSynonymMemberCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(VendorSynonymMember e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(VendorSynonymMember e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateModifiedOnly(e); }
        protected int DelegateUpdateNonstrict(VendorSynonymMember e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(VendorSynonymMember e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.Delete(e); }
        protected int DelegateDeleteNonstrict(VendorSynonymMember e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected VendorSynonymMember Downcast(Entity entity) {
            return (VendorSynonymMember)entity;
        }

        protected VendorSynonymMemberCB Downcast(ConditionBean cb) {
            return (VendorSynonymMemberCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual VendorSynonymMemberDao Dao { get { return _dao; } set { _dao = value; } }
    }
}


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
    public partial class MemberVendorSynonymBhv : DfExample.DBFlute.AllCommon.Bhv.AbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected MemberVendorSynonymDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public MemberVendorSynonymBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "MEMBER_VENDOR_SYNONYM"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override DBMeta DBMeta { get { return MemberVendorSynonymDbm.GetInstance(); } }
        public MemberVendorSynonymDbm MyDBMeta { get { return MemberVendorSynonymDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override Entity NewEntity() { return NewMyEntity(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual MemberVendorSynonym NewMyEntity() { return new MemberVendorSynonym(); }
        public virtual MemberVendorSynonymCB NewMyConditionBean() { return new MemberVendorSynonymCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(MemberVendorSynonymCB cb) {
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
        public virtual MemberVendorSynonym SelectEntity(MemberVendorSynonymCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<MemberVendorSynonym> ls = null;
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
            return (MemberVendorSynonym)ls[0];
        }

        protected override Entity DoReadEntity(ConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual MemberVendorSynonym SelectEntityWithDeletedCheck(MemberVendorSynonymCB cb) {
            AssertConditionBeanNotNull(cb);
            MemberVendorSynonym entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override Entity DoReadEntityWithDeletedCheck(ConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual MemberVendorSynonym SelectByPKValue(long? memberId) {
            return SelectEntity(BuildPKCB(memberId));
        }

        public virtual MemberVendorSynonym SelectByPKValueWithDeletedCheck(long? memberId) {
            return SelectEntityWithDeletedCheck(BuildPKCB(memberId));
        }

        private MemberVendorSynonymCB BuildPKCB(long? memberId) {
            AssertObjectNotNull("memberId", memberId);
            MemberVendorSynonymCB cb = NewMyConditionBean();
            cb.Query().SetMemberId_Equal(memberId);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual ListResultBean<MemberVendorSynonym> SelectList(MemberVendorSynonymCB cb) {
            AssertConditionBeanNotNull(cb);
            return new ResultBeanBuilder<MemberVendorSynonym>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual PagingResultBean<MemberVendorSynonym> SelectPage(MemberVendorSynonymCB cb) {
            AssertConditionBeanNotNull(cb);
            PagingInvoker<MemberVendorSynonym> invoker = new PagingInvoker<MemberVendorSynonym>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : PagingHandler<MemberVendorSynonym> {
            protected MemberVendorSynonymBhv _bhv; protected MemberVendorSynonymCB _cb;
            public InternalSelectPagingHandler(MemberVendorSynonymBhv bhv, MemberVendorSynonymCB cb) { _bhv = bhv; _cb = cb; }
            public PagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<MemberVendorSynonym> Paging() { return _bhv.SelectList(_cb); }
        }
        #endregion

        // ===============================================================================
        //                                                                   Load Referrer
        //                                                                   =============
        #region Load Referrer
        public virtual void LoadVdSynonymMemberLoginList(MemberVendorSynonym memberVendorSynonym, ConditionBeanSetupper<VdSynonymMemberLoginCB> conditionBeanSetupper) {
            AssertObjectNotNull("memberVendorSynonym", memberVendorSynonym); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadVdSynonymMemberLoginList(xnewLRLs<MemberVendorSynonym>(memberVendorSynonym), conditionBeanSetupper);
        }
        public virtual void LoadVdSynonymMemberLoginList(IList<MemberVendorSynonym> memberVendorSynonymList, ConditionBeanSetupper<VdSynonymMemberLoginCB> conditionBeanSetupper) {
            AssertObjectNotNull("memberVendorSynonymList", memberVendorSynonymList); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadVdSynonymMemberLoginList(memberVendorSynonymList, new LoadReferrerOption<VdSynonymMemberLoginCB, VdSynonymMemberLogin>().xinit(conditionBeanSetupper));
        }
        public virtual void LoadVdSynonymMemberLoginList(MemberVendorSynonym memberVendorSynonym, LoadReferrerOption<VdSynonymMemberLoginCB, VdSynonymMemberLogin> loadReferrerOption) {
            AssertObjectNotNull("memberVendorSynonym", memberVendorSynonym); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            LoadVdSynonymMemberLoginList(xnewLRLs<MemberVendorSynonym>(memberVendorSynonym), loadReferrerOption);
        }
        public virtual void LoadVdSynonymMemberLoginList(IList<MemberVendorSynonym> memberVendorSynonymList, LoadReferrerOption<VdSynonymMemberLoginCB, VdSynonymMemberLogin> loadReferrerOption) {
            AssertObjectNotNull("memberVendorSynonymList", memberVendorSynonymList); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            if (memberVendorSynonymList.Count == 0) { return; }
            VdSynonymMemberLoginBhv referrerBhv = xgetBSFLR().Select<VdSynonymMemberLoginBhv>();
            HelpLoadReferrerInternally<MemberVendorSynonym, long?, VdSynonymMemberLoginCB, VdSynonymMemberLogin>
                    (memberVendorSynonymList, loadReferrerOption, new MyInternalLoadVdSynonymMemberLoginListCallback(referrerBhv));
        }
        protected class MyInternalLoadVdSynonymMemberLoginListCallback : InternalLoadReferrerCallback<MemberVendorSynonym, long?, VdSynonymMemberLoginCB, VdSynonymMemberLogin> {
            protected VdSynonymMemberLoginBhv referrerBhv;
            public MyInternalLoadVdSynonymMemberLoginListCallback(VdSynonymMemberLoginBhv referrerBhv) { this.referrerBhv = referrerBhv; }
            public long? getPKVal(MemberVendorSynonym e) { return e.MemberId; }
            public void setRfLs(MemberVendorSynonym e, IList<VdSynonymMemberLogin> ls) { e.VdSynonymMemberLoginList = ls; }
            public VdSynonymMemberLoginCB newMyCB() { return referrerBhv.NewMyConditionBean(); }
            public void qyFKIn(VdSynonymMemberLoginCB cb, IList<long?> ls) { cb.Query().SetMemberId_InScope(ls); }
            public void qyOdFKAsc(VdSynonymMemberLoginCB cb) { cb.Query().AddOrderBy_MemberId_Asc(); }
            public void spFKCol(VdSynonymMemberLoginCB cb) { cb.Specify().ColumnMemberId(); }
            public IList<VdSynonymMemberLogin> selRfLs(VdSynonymMemberLoginCB cb) { return referrerBhv.SelectList(cb); }
            public long? getFKVal(VdSynonymMemberLogin e) { return e.MemberId; }
            public void setlcEt(VdSynonymMemberLogin re, MemberVendorSynonym be) { re.MemberVendorSynonym = be; }
        }
        #endregion

        // ===============================================================================
        //                                                                Pull out Foreign
        //                                                                ================
        #region Pullout Foreign
        public IList<MemberStatus> PulloutMemberStatus(IList<MemberVendorSynonym> memberVendorSynonymList) {
            return HelpPulloutInternally<MemberVendorSynonym, MemberStatus>(memberVendorSynonymList, new MyInternalPulloutMemberStatusCallback());
        }
        protected class MyInternalPulloutMemberStatusCallback : InternalPulloutCallback<MemberVendorSynonym, MemberStatus> {
            public MemberStatus getFr(MemberVendorSynonym entity) { return entity.MemberStatus; }
        }
        public IList<VdSynonymMemberWithdrawal> PulloutVdSynonymMemberWithdrawalAsOne(IList<MemberVendorSynonym> memberVendorSynonymList) {
            return HelpPulloutInternally<MemberVendorSynonym, VdSynonymMemberWithdrawal>(memberVendorSynonymList, new MyInternalPulloutVdSynonymMemberWithdrawalListCallback());
        }
        protected class MyInternalPulloutVdSynonymMemberWithdrawalListCallback : InternalPulloutCallback<MemberVendorSynonym, VdSynonymMemberWithdrawal> {
            public VdSynonymMemberWithdrawal getFr(MemberVendorSynonym entity) { return entity.VdSynonymMemberWithdrawalAsOne; }
        }
        #endregion


        // ===============================================================================
        //                                                                   Entity Update
        //                                                                   =============
        #region Basic Entity Update
        public virtual void Insert(MemberVendorSynonym entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(Entity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(MemberVendorSynonym entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(Entity entity) {
            Update(Downcast(entity));
        }

        public virtual void UpdateNonstrict(MemberVendorSynonym entity) {
            AssertEntityNotNull(entity);
            int updatedCount = this.DelegateUpdateNonstrict(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        public void InsertOrUpdate(MemberVendorSynonym entity) {
            HelpInsertOrUpdateInternally<MemberVendorSynonym, MemberVendorSynonymCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<MemberVendorSynonym, MemberVendorSynonymCB> {
            protected MemberVendorSynonymBhv _bhv;
            public MyInternalInsertOrUpdateCallback(MemberVendorSynonymBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(MemberVendorSynonym entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(MemberVendorSynonym entity) { _bhv.Update(entity); }
            public MemberVendorSynonymCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(MemberVendorSynonymCB cb, MemberVendorSynonym entity) {
                cb.Query().SetMemberId_Equal(entity.MemberId);
            }
            public int CallbackSelectCount(MemberVendorSynonymCB cb) { return _bhv.SelectCount(cb); }
        }

        public void InsertOrUpdateNonstrict(MemberVendorSynonym entity) {
            HelpInsertOrUpdateInternally<MemberVendorSynonym>(entity, new MyInternalInsertOrUpdateNonstrictCallback(this));
        }
        protected class MyInternalInsertOrUpdateNonstrictCallback : InternalInsertOrUpdateNonstrictCallback<MemberVendorSynonym> {
            protected MemberVendorSynonymBhv _bhv;
            public MyInternalInsertOrUpdateNonstrictCallback(MemberVendorSynonymBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(MemberVendorSynonym entity) { _bhv.Insert(entity); }
            public void CallbackUpdateNonstrict(MemberVendorSynonym entity) { _bhv.UpdateNonstrict(entity); }
        }

        public virtual void Delete(MemberVendorSynonym entity) {
            HelpDeleteInternally<MemberVendorSynonym>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(Entity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<MemberVendorSynonym> {
            protected MemberVendorSynonymBhv _bhv;
            public MyInternalDeleteCallback(MemberVendorSynonymBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(MemberVendorSynonym entity) { return _bhv.DelegateDelete(entity); }
        }

        public virtual void DeleteNonstrict(MemberVendorSynonym entity) {
            HelpDeleteNonstrictInternally<MemberVendorSynonym>(entity, new MyInternalDeleteNonstrictCallback(this));
        }
        protected class MyInternalDeleteNonstrictCallback : InternalDeleteNonstrictCallback<MemberVendorSynonym> {
            protected MemberVendorSynonymBhv _bhv;
            public MyInternalDeleteNonstrictCallback(MemberVendorSynonymBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDeleteNonstrict(MemberVendorSynonym entity) { return _bhv.DelegateDeleteNonstrict(entity); }
        }

        public virtual void DeleteNonstrictIgnoreDeleted(MemberVendorSynonym entity) {
            HelpDeleteNonstrictIgnoreDeletedInternally<MemberVendorSynonym>(entity, new MyInternalDeleteNonstrictIgnoreDeletedCallback(this));
        }
        protected class MyInternalDeleteNonstrictIgnoreDeletedCallback : InternalDeleteNonstrictIgnoreDeletedCallback<MemberVendorSynonym> {
            protected MemberVendorSynonymBhv _bhv;
            public MyInternalDeleteNonstrictIgnoreDeletedCallback(MemberVendorSynonymBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDeleteNonstrict(MemberVendorSynonym entity) { return _bhv.DelegateDeleteNonstrict(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(MemberVendorSynonym memberVendorSynonym, MemberVendorSynonymCB cb) {
            AssertObjectNotNull("memberVendorSynonym", memberVendorSynonym); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(memberVendorSynonym);
            FilterEntityOfUpdate(memberVendorSynonym); AssertEntityOfUpdate(memberVendorSynonym);
            return this.Dao.UpdateByQuery(cb, memberVendorSynonym);
        }

        public int QueryDelete(MemberVendorSynonymCB cb) {
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
        protected int DelegateSelectCount(MemberVendorSynonymCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<MemberVendorSynonym> DelegateSelectList(MemberVendorSynonymCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(MemberVendorSynonym e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(MemberVendorSynonym e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateModifiedOnly(e); }
        protected int DelegateUpdateNonstrict(MemberVendorSynonym e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(MemberVendorSynonym e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.Delete(e); }
        protected int DelegateDeleteNonstrict(MemberVendorSynonym e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected MemberVendorSynonym Downcast(Entity entity) {
            return (MemberVendorSynonym)entity;
        }

        protected MemberVendorSynonymCB Downcast(ConditionBean cb) {
            return (MemberVendorSynonymCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual MemberVendorSynonymDao Dao { get { return _dao; } set { _dao = value; } }
    }
}

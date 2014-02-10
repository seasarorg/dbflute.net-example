
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
    public partial class MbMemberBhv : DfExample.DBFlute.MemberDb.AllCommon.Bhv.MbAbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected MbMemberDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public MbMemberBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "member"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override MbDBMeta DBMeta { get { return MbMemberDbm.GetInstance(); } }
        public MbMemberDbm MyDBMeta { get { return MbMemberDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override MbEntity NewEntity() { return NewMyEntity(); }
        public override MbConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual MbMember NewMyEntity() { return new MbMember(); }
        public virtual MbMemberCB NewMyConditionBean() { return new MbMemberCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(MbMemberCB cb) {
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
        public virtual MbMember SelectEntity(MbMemberCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<MbMember> ls = null;
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
            return (MbMember)ls[0];
        }

        protected override MbEntity DoReadEntity(MbConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual MbMember SelectEntityWithDeletedCheck(MbMemberCB cb) {
            AssertConditionBeanNotNull(cb);
            MbMember entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override MbEntity DoReadEntityWithDeletedCheck(MbConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual MbMember SelectByPKValue(int? memberId) {
            return SelectEntity(BuildPKCB(memberId));
        }

        public virtual MbMember SelectByPKValueWithDeletedCheck(int? memberId) {
            return SelectEntityWithDeletedCheck(BuildPKCB(memberId));
        }

        private MbMemberCB BuildPKCB(int? memberId) {
            AssertObjectNotNull("memberId", memberId);
            MbMemberCB cb = NewMyConditionBean();
            cb.Query().SetMemberId_Equal(memberId);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual MbListResultBean<MbMember> SelectList(MbMemberCB cb) {
            AssertConditionBeanNotNull(cb);
            return new MbResultBeanBuilder<MbMember>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual MbPagingResultBean<MbMember> SelectPage(MbMemberCB cb) {
            AssertConditionBeanNotNull(cb);
            MbPagingInvoker<MbMember> invoker = new MbPagingInvoker<MbMember>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : MbPagingHandler<MbMember> {
            protected MbMemberBhv _bhv; protected MbMemberCB _cb;
            public InternalSelectPagingHandler(MbMemberBhv bhv, MbMemberCB cb) { _bhv = bhv; _cb = cb; }
            public MbPagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<MbMember> Paging() { return _bhv.SelectList(_cb); }
        }
        #endregion

        // ===============================================================================
        //                                                                   Load Referrer
        //                                                                   =============
        #region Load Referrer
        public virtual void LoadMemberAddressList(MbMember member, MbConditionBeanSetupper<MbMemberAddressCB> conditionBeanSetupper) {
            AssertObjectNotNull("member", member); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadMemberAddressList(xnewLRLs<MbMember>(member), conditionBeanSetupper);
        }
        public virtual void LoadMemberAddressList(IList<MbMember> memberList, MbConditionBeanSetupper<MbMemberAddressCB> conditionBeanSetupper) {
            AssertObjectNotNull("memberList", memberList); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadMemberAddressList(memberList, new MbLoadReferrerOption<MbMemberAddressCB, MbMemberAddress>().xinit(conditionBeanSetupper));
        }
        public virtual void LoadMemberAddressList(MbMember member, MbLoadReferrerOption<MbMemberAddressCB, MbMemberAddress> loadReferrerOption) {
            AssertObjectNotNull("member", member); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            LoadMemberAddressList(xnewLRLs<MbMember>(member), loadReferrerOption);
        }
        public virtual void LoadMemberAddressList(IList<MbMember> memberList, MbLoadReferrerOption<MbMemberAddressCB, MbMemberAddress> loadReferrerOption) {
            AssertObjectNotNull("memberList", memberList); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            if (memberList.Count == 0) { return; }
            MbMemberAddressBhv referrerBhv = xgetBSFLR().Select<MbMemberAddressBhv>();
            HelpLoadReferrerInternally<MbMember, int?, MbMemberAddressCB, MbMemberAddress>
                    (memberList, loadReferrerOption, new MyInternalLoadMemberAddressListCallback(referrerBhv));
        }
        protected class MyInternalLoadMemberAddressListCallback : InternalLoadReferrerCallback<MbMember, int?, MbMemberAddressCB, MbMemberAddress> {
            protected MbMemberAddressBhv referrerBhv;
            public MyInternalLoadMemberAddressListCallback(MbMemberAddressBhv referrerBhv) { this.referrerBhv = referrerBhv; }
            public int? getPKVal(MbMember e) { return e.MemberId; }
            public void setRfLs(MbMember e, IList<MbMemberAddress> ls) { e.MemberAddressList = ls; }
            public MbMemberAddressCB newMyCB() { return referrerBhv.NewMyConditionBean(); }
            public void qyFKIn(MbMemberAddressCB cb, IList<int?> ls) { cb.Query().SetMemberId_InScope(ls); }
            public void qyOdFKAsc(MbMemberAddressCB cb) { cb.Query().AddOrderBy_MemberId_Asc(); }
            public void spFKCol(MbMemberAddressCB cb) { cb.Specify().ColumnMemberId(); }
            public IList<MbMemberAddress> selRfLs(MbMemberAddressCB cb) { return referrerBhv.SelectList(cb); }
            public int? getFKVal(MbMemberAddress e) { return e.MemberId; }
            public void setlcEt(MbMemberAddress re, MbMember be) { re.Member = be; }
        }
        public virtual void LoadMemberLoginList(MbMember member, MbConditionBeanSetupper<MbMemberLoginCB> conditionBeanSetupper) {
            AssertObjectNotNull("member", member); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadMemberLoginList(xnewLRLs<MbMember>(member), conditionBeanSetupper);
        }
        public virtual void LoadMemberLoginList(IList<MbMember> memberList, MbConditionBeanSetupper<MbMemberLoginCB> conditionBeanSetupper) {
            AssertObjectNotNull("memberList", memberList); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadMemberLoginList(memberList, new MbLoadReferrerOption<MbMemberLoginCB, MbMemberLogin>().xinit(conditionBeanSetupper));
        }
        public virtual void LoadMemberLoginList(MbMember member, MbLoadReferrerOption<MbMemberLoginCB, MbMemberLogin> loadReferrerOption) {
            AssertObjectNotNull("member", member); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            LoadMemberLoginList(xnewLRLs<MbMember>(member), loadReferrerOption);
        }
        public virtual void LoadMemberLoginList(IList<MbMember> memberList, MbLoadReferrerOption<MbMemberLoginCB, MbMemberLogin> loadReferrerOption) {
            AssertObjectNotNull("memberList", memberList); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            if (memberList.Count == 0) { return; }
            MbMemberLoginBhv referrerBhv = xgetBSFLR().Select<MbMemberLoginBhv>();
            HelpLoadReferrerInternally<MbMember, int?, MbMemberLoginCB, MbMemberLogin>
                    (memberList, loadReferrerOption, new MyInternalLoadMemberLoginListCallback(referrerBhv));
        }
        protected class MyInternalLoadMemberLoginListCallback : InternalLoadReferrerCallback<MbMember, int?, MbMemberLoginCB, MbMemberLogin> {
            protected MbMemberLoginBhv referrerBhv;
            public MyInternalLoadMemberLoginListCallback(MbMemberLoginBhv referrerBhv) { this.referrerBhv = referrerBhv; }
            public int? getPKVal(MbMember e) { return e.MemberId; }
            public void setRfLs(MbMember e, IList<MbMemberLogin> ls) { e.MemberLoginList = ls; }
            public MbMemberLoginCB newMyCB() { return referrerBhv.NewMyConditionBean(); }
            public void qyFKIn(MbMemberLoginCB cb, IList<int?> ls) { cb.Query().SetMemberId_InScope(ls); }
            public void qyOdFKAsc(MbMemberLoginCB cb) { cb.Query().AddOrderBy_MemberId_Asc(); }
            public void spFKCol(MbMemberLoginCB cb) { cb.Specify().ColumnMemberId(); }
            public IList<MbMemberLogin> selRfLs(MbMemberLoginCB cb) { return referrerBhv.SelectList(cb); }
            public int? getFKVal(MbMemberLogin e) { return e.MemberId; }
            public void setlcEt(MbMemberLogin re, MbMember be) { re.Member = be; }
        }
        public virtual void LoadPurchaseList(MbMember member, MbConditionBeanSetupper<MbPurchaseCB> conditionBeanSetupper) {
            AssertObjectNotNull("member", member); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadPurchaseList(xnewLRLs<MbMember>(member), conditionBeanSetupper);
        }
        public virtual void LoadPurchaseList(IList<MbMember> memberList, MbConditionBeanSetupper<MbPurchaseCB> conditionBeanSetupper) {
            AssertObjectNotNull("memberList", memberList); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadPurchaseList(memberList, new MbLoadReferrerOption<MbPurchaseCB, MbPurchase>().xinit(conditionBeanSetupper));
        }
        public virtual void LoadPurchaseList(MbMember member, MbLoadReferrerOption<MbPurchaseCB, MbPurchase> loadReferrerOption) {
            AssertObjectNotNull("member", member); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            LoadPurchaseList(xnewLRLs<MbMember>(member), loadReferrerOption);
        }
        public virtual void LoadPurchaseList(IList<MbMember> memberList, MbLoadReferrerOption<MbPurchaseCB, MbPurchase> loadReferrerOption) {
            AssertObjectNotNull("memberList", memberList); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            if (memberList.Count == 0) { return; }
            MbPurchaseBhv referrerBhv = xgetBSFLR().Select<MbPurchaseBhv>();
            HelpLoadReferrerInternally<MbMember, int?, MbPurchaseCB, MbPurchase>
                    (memberList, loadReferrerOption, new MyInternalLoadPurchaseListCallback(referrerBhv));
        }
        protected class MyInternalLoadPurchaseListCallback : InternalLoadReferrerCallback<MbMember, int?, MbPurchaseCB, MbPurchase> {
            protected MbPurchaseBhv referrerBhv;
            public MyInternalLoadPurchaseListCallback(MbPurchaseBhv referrerBhv) { this.referrerBhv = referrerBhv; }
            public int? getPKVal(MbMember e) { return e.MemberId; }
            public void setRfLs(MbMember e, IList<MbPurchase> ls) { e.PurchaseList = ls; }
            public MbPurchaseCB newMyCB() { return referrerBhv.NewMyConditionBean(); }
            public void qyFKIn(MbPurchaseCB cb, IList<int?> ls) { cb.Query().SetMemberId_InScope(ls); }
            public void qyOdFKAsc(MbPurchaseCB cb) { cb.Query().AddOrderBy_MemberId_Asc(); }
            public void spFKCol(MbPurchaseCB cb) { cb.Specify().ColumnMemberId(); }
            public IList<MbPurchase> selRfLs(MbPurchaseCB cb) { return referrerBhv.SelectList(cb); }
            public int? getFKVal(MbPurchase e) { return e.MemberId; }
            public void setlcEt(MbPurchase re, MbMember be) { re.Member = be; }
        }
        #endregion

        // ===============================================================================
        //                                                                Pull out Foreign
        //                                                                ================
        #region Pullout Foreign
        public IList<MbMemberStatus> PulloutMemberStatus(IList<MbMember> memberList) {
            return HelpPulloutInternally<MbMember, MbMemberStatus>(memberList, new MyInternalPulloutMemberStatusCallback());
        }
        protected class MyInternalPulloutMemberStatusCallback : InternalPulloutCallback<MbMember, MbMemberStatus> {
            public MbMemberStatus getFr(MbMember entity) { return entity.MemberStatus; }
        }
        public IList<MbMemberLogin> PulloutMemberLoginAsLatest(IList<MbMember> memberList) {
            return HelpPulloutInternally<MbMember, MbMemberLogin>(memberList, new MyInternalPulloutMemberLoginAsLatestCallback());
        }
        protected class MyInternalPulloutMemberLoginAsLatestCallback : InternalPulloutCallback<MbMember, MbMemberLogin> {
            public MbMemberLogin getFr(MbMember entity) { return entity.MemberLoginAsLatest; }
        }
        public IList<MbMemberAddress> PulloutMemberAddressAsValid(IList<MbMember> memberList) {
            return HelpPulloutInternally<MbMember, MbMemberAddress>(memberList, new MyInternalPulloutMemberAddressAsValidCallback());
        }
        protected class MyInternalPulloutMemberAddressAsValidCallback : InternalPulloutCallback<MbMember, MbMemberAddress> {
            public MbMemberAddress getFr(MbMember entity) { return entity.MemberAddressAsValid; }
        }
        public IList<MbMemberSecurity> PulloutMemberSecurityAsOne(IList<MbMember> memberList) {
            return HelpPulloutInternally<MbMember, MbMemberSecurity>(memberList, new MyInternalPulloutMemberSecurityListCallback());
        }
        protected class MyInternalPulloutMemberSecurityListCallback : InternalPulloutCallback<MbMember, MbMemberSecurity> {
            public MbMemberSecurity getFr(MbMember entity) { return entity.MemberSecurityAsOne; }
        }
        public IList<MbMemberWithdrawal> PulloutMemberWithdrawalAsOne(IList<MbMember> memberList) {
            return HelpPulloutInternally<MbMember, MbMemberWithdrawal>(memberList, new MyInternalPulloutMemberWithdrawalListCallback());
        }
        protected class MyInternalPulloutMemberWithdrawalListCallback : InternalPulloutCallback<MbMember, MbMemberWithdrawal> {
            public MbMemberWithdrawal getFr(MbMember entity) { return entity.MemberWithdrawalAsOne; }
        }
        #endregion


        // ===============================================================================
        //                                                                   Entity Update
        //                                                                   =============
        #region Basic Entity Update
        public virtual void Insert(MbMember entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(MbEntity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(MbMember entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(MbEntity entity) {
            Update(Downcast(entity));
        }

        public virtual void UpdateNonstrict(MbMember entity) {
            AssertEntityNotNull(entity);
            int updatedCount = this.DelegateUpdateNonstrict(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        public void InsertOrUpdate(MbMember entity) {
            HelpInsertOrUpdateInternally<MbMember, MbMemberCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<MbMember, MbMemberCB> {
            protected MbMemberBhv _bhv;
            public MyInternalInsertOrUpdateCallback(MbMemberBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(MbMember entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(MbMember entity) { _bhv.Update(entity); }
            public MbMemberCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(MbMemberCB cb, MbMember entity) {
                cb.Query().SetMemberId_Equal(entity.MemberId);
            }
            public int CallbackSelectCount(MbMemberCB cb) { return _bhv.SelectCount(cb); }
        }

        public void InsertOrUpdateNonstrict(MbMember entity) {
            HelpInsertOrUpdateInternally<MbMember>(entity, new MyInternalInsertOrUpdateNonstrictCallback(this));
        }
        protected class MyInternalInsertOrUpdateNonstrictCallback : InternalInsertOrUpdateNonstrictCallback<MbMember> {
            protected MbMemberBhv _bhv;
            public MyInternalInsertOrUpdateNonstrictCallback(MbMemberBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(MbMember entity) { _bhv.Insert(entity); }
            public void CallbackUpdateNonstrict(MbMember entity) { _bhv.UpdateNonstrict(entity); }
        }

        public virtual void Delete(MbMember entity) {
            HelpDeleteInternally<MbMember>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(MbEntity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<MbMember> {
            protected MbMemberBhv _bhv;
            public MyInternalDeleteCallback(MbMemberBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(MbMember entity) { return _bhv.DelegateDelete(entity); }
        }

        public virtual void DeleteNonstrict(MbMember entity) {
            HelpDeleteNonstrictInternally<MbMember>(entity, new MyInternalDeleteNonstrictCallback(this));
        }
        protected class MyInternalDeleteNonstrictCallback : InternalDeleteNonstrictCallback<MbMember> {
            protected MbMemberBhv _bhv;
            public MyInternalDeleteNonstrictCallback(MbMemberBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDeleteNonstrict(MbMember entity) { return _bhv.DelegateDeleteNonstrict(entity); }
        }

        public virtual void DeleteNonstrictIgnoreDeleted(MbMember entity) {
            HelpDeleteNonstrictIgnoreDeletedInternally<MbMember>(entity, new MyInternalDeleteNonstrictIgnoreDeletedCallback(this));
        }
        protected class MyInternalDeleteNonstrictIgnoreDeletedCallback : InternalDeleteNonstrictIgnoreDeletedCallback<MbMember> {
            protected MbMemberBhv _bhv;
            public MyInternalDeleteNonstrictIgnoreDeletedCallback(MbMemberBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDeleteNonstrict(MbMember entity) { return _bhv.DelegateDeleteNonstrict(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(MbMember member, MbMemberCB cb) {
            AssertObjectNotNull("member", member); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(member);
            FilterEntityOfUpdate(member); AssertEntityOfUpdate(member);
            return this.Dao.UpdateByQuery(cb, member);
        }

        public int QueryDelete(MbMemberCB cb) {
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
        protected int DelegateSelectCount(MbMemberCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<MbMember> DelegateSelectList(MbMemberCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(MbMember e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(MbMember e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateModifiedOnly(e); }
        protected int DelegateUpdateNonstrict(MbMember e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(MbMember e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.Delete(e); }
        protected int DelegateDeleteNonstrict(MbMember e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected MbMember Downcast(MbEntity entity) {
            return (MbMember)entity;
        }

        protected MbMemberCB Downcast(MbConditionBean cb) {
            return (MbMemberCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual MbMemberDao Dao { get { return _dao; } set { _dao = value; } }
    }
}

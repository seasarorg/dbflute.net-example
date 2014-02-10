
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
    public partial class MemberStatusBhv : DfExample.DBFlute.AllCommon.Bhv.AbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected MemberStatusDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public MemberStatusBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "member_status"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override DBMeta DBMeta { get { return MemberStatusDbm.GetInstance(); } }
        public MemberStatusDbm MyDBMeta { get { return MemberStatusDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override Entity NewEntity() { return NewMyEntity(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual MemberStatus NewMyEntity() { return new MemberStatus(); }
        public virtual MemberStatusCB NewMyConditionBean() { return new MemberStatusCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(MemberStatusCB cb) {
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
        public virtual MemberStatus SelectEntity(MemberStatusCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<MemberStatus> ls = null;
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
            return (MemberStatus)ls[0];
        }

        protected override Entity DoReadEntity(ConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual MemberStatus SelectEntityWithDeletedCheck(MemberStatusCB cb) {
            AssertConditionBeanNotNull(cb);
            MemberStatus entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override Entity DoReadEntityWithDeletedCheck(ConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual MemberStatus SelectByPKValue(String memberStatusCode) {
            return SelectEntity(BuildPKCB(memberStatusCode));
        }

        public virtual MemberStatus SelectByPKValueWithDeletedCheck(String memberStatusCode) {
            return SelectEntityWithDeletedCheck(BuildPKCB(memberStatusCode));
        }

        private MemberStatusCB BuildPKCB(String memberStatusCode) {
            AssertObjectNotNull("memberStatusCode", memberStatusCode);
            MemberStatusCB cb = NewMyConditionBean();
            cb.Query().SetMemberStatusCode_Equal(memberStatusCode);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual ListResultBean<MemberStatus> SelectList(MemberStatusCB cb) {
            AssertConditionBeanNotNull(cb);
            return new ResultBeanBuilder<MemberStatus>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual PagingResultBean<MemberStatus> SelectPage(MemberStatusCB cb) {
            AssertConditionBeanNotNull(cb);
            PagingInvoker<MemberStatus> invoker = new PagingInvoker<MemberStatus>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : PagingHandler<MemberStatus> {
            protected MemberStatusBhv _bhv; protected MemberStatusCB _cb;
            public InternalSelectPagingHandler(MemberStatusBhv bhv, MemberStatusCB cb) { _bhv = bhv; _cb = cb; }
            public PagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<MemberStatus> Paging() { return _bhv.SelectList(_cb); }
        }
        #endregion

        // ===============================================================================
        //                                                                   Load Referrer
        //                                                                   =============
        #region Load Referrer
        public virtual void LoadMemberList(MemberStatus memberStatus, ConditionBeanSetupper<MemberCB> conditionBeanSetupper) {
            AssertObjectNotNull("memberStatus", memberStatus); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadMemberList(xnewLRLs<MemberStatus>(memberStatus), conditionBeanSetupper);
        }
        public virtual void LoadMemberList(IList<MemberStatus> memberStatusList, ConditionBeanSetupper<MemberCB> conditionBeanSetupper) {
            AssertObjectNotNull("memberStatusList", memberStatusList); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadMemberList(memberStatusList, new LoadReferrerOption<MemberCB, Member>().xinit(conditionBeanSetupper));
        }
        public virtual void LoadMemberList(MemberStatus memberStatus, LoadReferrerOption<MemberCB, Member> loadReferrerOption) {
            AssertObjectNotNull("memberStatus", memberStatus); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            LoadMemberList(xnewLRLs<MemberStatus>(memberStatus), loadReferrerOption);
        }
        public virtual void LoadMemberList(IList<MemberStatus> memberStatusList, LoadReferrerOption<MemberCB, Member> loadReferrerOption) {
            AssertObjectNotNull("memberStatusList", memberStatusList); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            if (memberStatusList.Count == 0) { return; }
            MemberBhv referrerBhv = xgetBSFLR().Select<MemberBhv>();
            HelpLoadReferrerInternally<MemberStatus, String, MemberCB, Member>
                    (memberStatusList, loadReferrerOption, new MyInternalLoadMemberListCallback(referrerBhv));
        }
        protected class MyInternalLoadMemberListCallback : InternalLoadReferrerCallback<MemberStatus, String, MemberCB, Member> {
            protected MemberBhv referrerBhv;
            public MyInternalLoadMemberListCallback(MemberBhv referrerBhv) { this.referrerBhv = referrerBhv; }
            public String getPKVal(MemberStatus e) { return e.MemberStatusCode; }
            public void setRfLs(MemberStatus e, IList<Member> ls) { e.MemberList = ls; }
            public MemberCB newMyCB() { return referrerBhv.NewMyConditionBean(); }
            public void qyFKIn(MemberCB cb, IList<String> ls) { cb.Query().SetMemberStatusCode_InScope(ls); }
            public void qyOdFKAsc(MemberCB cb) { cb.Query().AddOrderBy_MemberStatusCode_Asc(); }
            public void spFKCol(MemberCB cb) { cb.Specify().ColumnMemberStatusCode(); }
            public IList<Member> selRfLs(MemberCB cb) { return referrerBhv.SelectList(cb); }
            public String getFKVal(Member e) { return e.MemberStatusCode; }
            public void setlcEt(Member re, MemberStatus be) { re.MemberStatus = be; }
        }
        public virtual void LoadMemberLoginList(MemberStatus memberStatus, ConditionBeanSetupper<MemberLoginCB> conditionBeanSetupper) {
            AssertObjectNotNull("memberStatus", memberStatus); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadMemberLoginList(xnewLRLs<MemberStatus>(memberStatus), conditionBeanSetupper);
        }
        public virtual void LoadMemberLoginList(IList<MemberStatus> memberStatusList, ConditionBeanSetupper<MemberLoginCB> conditionBeanSetupper) {
            AssertObjectNotNull("memberStatusList", memberStatusList); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadMemberLoginList(memberStatusList, new LoadReferrerOption<MemberLoginCB, MemberLogin>().xinit(conditionBeanSetupper));
        }
        public virtual void LoadMemberLoginList(MemberStatus memberStatus, LoadReferrerOption<MemberLoginCB, MemberLogin> loadReferrerOption) {
            AssertObjectNotNull("memberStatus", memberStatus); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            LoadMemberLoginList(xnewLRLs<MemberStatus>(memberStatus), loadReferrerOption);
        }
        public virtual void LoadMemberLoginList(IList<MemberStatus> memberStatusList, LoadReferrerOption<MemberLoginCB, MemberLogin> loadReferrerOption) {
            AssertObjectNotNull("memberStatusList", memberStatusList); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            if (memberStatusList.Count == 0) { return; }
            MemberLoginBhv referrerBhv = xgetBSFLR().Select<MemberLoginBhv>();
            HelpLoadReferrerInternally<MemberStatus, String, MemberLoginCB, MemberLogin>
                    (memberStatusList, loadReferrerOption, new MyInternalLoadMemberLoginListCallback(referrerBhv));
        }
        protected class MyInternalLoadMemberLoginListCallback : InternalLoadReferrerCallback<MemberStatus, String, MemberLoginCB, MemberLogin> {
            protected MemberLoginBhv referrerBhv;
            public MyInternalLoadMemberLoginListCallback(MemberLoginBhv referrerBhv) { this.referrerBhv = referrerBhv; }
            public String getPKVal(MemberStatus e) { return e.MemberStatusCode; }
            public void setRfLs(MemberStatus e, IList<MemberLogin> ls) { e.MemberLoginList = ls; }
            public MemberLoginCB newMyCB() { return referrerBhv.NewMyConditionBean(); }
            public void qyFKIn(MemberLoginCB cb, IList<String> ls) { cb.Query().SetLoginMemberStatusCode_InScope(ls); }
            public void qyOdFKAsc(MemberLoginCB cb) { cb.Query().AddOrderBy_LoginMemberStatusCode_Asc(); }
            public void spFKCol(MemberLoginCB cb) { cb.Specify().ColumnLoginMemberStatusCode(); }
            public IList<MemberLogin> selRfLs(MemberLoginCB cb) { return referrerBhv.SelectList(cb); }
            public String getFKVal(MemberLogin e) { return e.LoginMemberStatusCode; }
            public void setlcEt(MemberLogin re, MemberStatus be) { re.MemberStatus = be; }
        }
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
        public virtual void Insert(MemberStatus entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(Entity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(MemberStatus entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(Entity entity) {
            Update(Downcast(entity));
        }

        public void InsertOrUpdate(MemberStatus entity) {
            HelpInsertOrUpdateInternally<MemberStatus, MemberStatusCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<MemberStatus, MemberStatusCB> {
            protected MemberStatusBhv _bhv;
            public MyInternalInsertOrUpdateCallback(MemberStatusBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(MemberStatus entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(MemberStatus entity) { _bhv.Update(entity); }
            public MemberStatusCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(MemberStatusCB cb, MemberStatus entity) {
                cb.Query().SetMemberStatusCode_Equal(entity.MemberStatusCode);
            }
            public int CallbackSelectCount(MemberStatusCB cb) { return _bhv.SelectCount(cb); }
        }

        public virtual void Delete(MemberStatus entity) {
            HelpDeleteInternally<MemberStatus>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(Entity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<MemberStatus> {
            protected MemberStatusBhv _bhv;
            public MyInternalDeleteCallback(MemberStatusBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(MemberStatus entity) { return _bhv.DelegateDelete(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(MemberStatus memberStatus, MemberStatusCB cb) {
            AssertObjectNotNull("memberStatus", memberStatus); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(memberStatus);
            FilterEntityOfUpdate(memberStatus); AssertEntityOfUpdate(memberStatus);
            return this.Dao.UpdateByQuery(cb, memberStatus);
        }

        public int QueryDelete(MemberStatusCB cb) {
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
        protected int DelegateSelectCount(MemberStatusCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<MemberStatus> DelegateSelectList(MemberStatusCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(MemberStatus e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(MemberStatus e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(MemberStatus e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected MemberStatus Downcast(Entity entity) {
            return (MemberStatus)entity;
        }

        protected MemberStatusCB Downcast(ConditionBean cb) {
            return (MemberStatusCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual MemberStatusDao Dao { get { return _dao; } set { _dao = value; } }
    }
}

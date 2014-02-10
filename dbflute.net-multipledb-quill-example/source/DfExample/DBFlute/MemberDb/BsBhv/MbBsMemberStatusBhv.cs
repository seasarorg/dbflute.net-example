
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
    public partial class MbMemberStatusBhv : DfExample.DBFlute.MemberDb.AllCommon.Bhv.MbAbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected MbMemberStatusDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public MbMemberStatusBhv() {
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
        public override MbDBMeta DBMeta { get { return MbMemberStatusDbm.GetInstance(); } }
        public MbMemberStatusDbm MyDBMeta { get { return MbMemberStatusDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override MbEntity NewEntity() { return NewMyEntity(); }
        public override MbConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual MbMemberStatus NewMyEntity() { return new MbMemberStatus(); }
        public virtual MbMemberStatusCB NewMyConditionBean() { return new MbMemberStatusCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(MbMemberStatusCB cb) {
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
        public virtual MbMemberStatus SelectEntity(MbMemberStatusCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<MbMemberStatus> ls = null;
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
            return (MbMemberStatus)ls[0];
        }

        protected override MbEntity DoReadEntity(MbConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual MbMemberStatus SelectEntityWithDeletedCheck(MbMemberStatusCB cb) {
            AssertConditionBeanNotNull(cb);
            MbMemberStatus entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override MbEntity DoReadEntityWithDeletedCheck(MbConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual MbMemberStatus SelectByPKValue(String memberStatusCode) {
            return SelectEntity(BuildPKCB(memberStatusCode));
        }

        public virtual MbMemberStatus SelectByPKValueWithDeletedCheck(String memberStatusCode) {
            return SelectEntityWithDeletedCheck(BuildPKCB(memberStatusCode));
        }

        private MbMemberStatusCB BuildPKCB(String memberStatusCode) {
            AssertObjectNotNull("memberStatusCode", memberStatusCode);
            MbMemberStatusCB cb = NewMyConditionBean();
            cb.Query().SetMemberStatusCode_Equal(memberStatusCode);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual MbListResultBean<MbMemberStatus> SelectList(MbMemberStatusCB cb) {
            AssertConditionBeanNotNull(cb);
            return new MbResultBeanBuilder<MbMemberStatus>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual MbPagingResultBean<MbMemberStatus> SelectPage(MbMemberStatusCB cb) {
            AssertConditionBeanNotNull(cb);
            MbPagingInvoker<MbMemberStatus> invoker = new MbPagingInvoker<MbMemberStatus>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : MbPagingHandler<MbMemberStatus> {
            protected MbMemberStatusBhv _bhv; protected MbMemberStatusCB _cb;
            public InternalSelectPagingHandler(MbMemberStatusBhv bhv, MbMemberStatusCB cb) { _bhv = bhv; _cb = cb; }
            public MbPagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<MbMemberStatus> Paging() { return _bhv.SelectList(_cb); }
        }
        #endregion

        // ===============================================================================
        //                                                                   Load Referrer
        //                                                                   =============
        #region Load Referrer
        public virtual void LoadMemberList(MbMemberStatus memberStatus, MbConditionBeanSetupper<MbMemberCB> conditionBeanSetupper) {
            AssertObjectNotNull("memberStatus", memberStatus); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadMemberList(xnewLRLs<MbMemberStatus>(memberStatus), conditionBeanSetupper);
        }
        public virtual void LoadMemberList(IList<MbMemberStatus> memberStatusList, MbConditionBeanSetupper<MbMemberCB> conditionBeanSetupper) {
            AssertObjectNotNull("memberStatusList", memberStatusList); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadMemberList(memberStatusList, new MbLoadReferrerOption<MbMemberCB, MbMember>().xinit(conditionBeanSetupper));
        }
        public virtual void LoadMemberList(MbMemberStatus memberStatus, MbLoadReferrerOption<MbMemberCB, MbMember> loadReferrerOption) {
            AssertObjectNotNull("memberStatus", memberStatus); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            LoadMemberList(xnewLRLs<MbMemberStatus>(memberStatus), loadReferrerOption);
        }
        public virtual void LoadMemberList(IList<MbMemberStatus> memberStatusList, MbLoadReferrerOption<MbMemberCB, MbMember> loadReferrerOption) {
            AssertObjectNotNull("memberStatusList", memberStatusList); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            if (memberStatusList.Count == 0) { return; }
            MbMemberBhv referrerBhv = xgetBSFLR().Select<MbMemberBhv>();
            HelpLoadReferrerInternally<MbMemberStatus, String, MbMemberCB, MbMember>
                    (memberStatusList, loadReferrerOption, new MyInternalLoadMemberListCallback(referrerBhv));
        }
        protected class MyInternalLoadMemberListCallback : InternalLoadReferrerCallback<MbMemberStatus, String, MbMemberCB, MbMember> {
            protected MbMemberBhv referrerBhv;
            public MyInternalLoadMemberListCallback(MbMemberBhv referrerBhv) { this.referrerBhv = referrerBhv; }
            public String getPKVal(MbMemberStatus e) { return e.MemberStatusCode; }
            public void setRfLs(MbMemberStatus e, IList<MbMember> ls) { e.MemberList = ls; }
            public MbMemberCB newMyCB() { return referrerBhv.NewMyConditionBean(); }
            public void qyFKIn(MbMemberCB cb, IList<String> ls) { cb.Query().SetMemberStatusCode_InScope(ls); }
            public void qyOdFKAsc(MbMemberCB cb) { cb.Query().AddOrderBy_MemberStatusCode_Asc(); }
            public void spFKCol(MbMemberCB cb) { cb.Specify().ColumnMemberStatusCode(); }
            public IList<MbMember> selRfLs(MbMemberCB cb) { return referrerBhv.SelectList(cb); }
            public String getFKVal(MbMember e) { return e.MemberStatusCode; }
            public void setlcEt(MbMember re, MbMemberStatus be) { re.MemberStatus = be; }
        }
        public virtual void LoadMemberLoginList(MbMemberStatus memberStatus, MbConditionBeanSetupper<MbMemberLoginCB> conditionBeanSetupper) {
            AssertObjectNotNull("memberStatus", memberStatus); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadMemberLoginList(xnewLRLs<MbMemberStatus>(memberStatus), conditionBeanSetupper);
        }
        public virtual void LoadMemberLoginList(IList<MbMemberStatus> memberStatusList, MbConditionBeanSetupper<MbMemberLoginCB> conditionBeanSetupper) {
            AssertObjectNotNull("memberStatusList", memberStatusList); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadMemberLoginList(memberStatusList, new MbLoadReferrerOption<MbMemberLoginCB, MbMemberLogin>().xinit(conditionBeanSetupper));
        }
        public virtual void LoadMemberLoginList(MbMemberStatus memberStatus, MbLoadReferrerOption<MbMemberLoginCB, MbMemberLogin> loadReferrerOption) {
            AssertObjectNotNull("memberStatus", memberStatus); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            LoadMemberLoginList(xnewLRLs<MbMemberStatus>(memberStatus), loadReferrerOption);
        }
        public virtual void LoadMemberLoginList(IList<MbMemberStatus> memberStatusList, MbLoadReferrerOption<MbMemberLoginCB, MbMemberLogin> loadReferrerOption) {
            AssertObjectNotNull("memberStatusList", memberStatusList); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            if (memberStatusList.Count == 0) { return; }
            MbMemberLoginBhv referrerBhv = xgetBSFLR().Select<MbMemberLoginBhv>();
            HelpLoadReferrerInternally<MbMemberStatus, String, MbMemberLoginCB, MbMemberLogin>
                    (memberStatusList, loadReferrerOption, new MyInternalLoadMemberLoginListCallback(referrerBhv));
        }
        protected class MyInternalLoadMemberLoginListCallback : InternalLoadReferrerCallback<MbMemberStatus, String, MbMemberLoginCB, MbMemberLogin> {
            protected MbMemberLoginBhv referrerBhv;
            public MyInternalLoadMemberLoginListCallback(MbMemberLoginBhv referrerBhv) { this.referrerBhv = referrerBhv; }
            public String getPKVal(MbMemberStatus e) { return e.MemberStatusCode; }
            public void setRfLs(MbMemberStatus e, IList<MbMemberLogin> ls) { e.MemberLoginList = ls; }
            public MbMemberLoginCB newMyCB() { return referrerBhv.NewMyConditionBean(); }
            public void qyFKIn(MbMemberLoginCB cb, IList<String> ls) { cb.Query().SetLoginMemberStatusCode_InScope(ls); }
            public void qyOdFKAsc(MbMemberLoginCB cb) { cb.Query().AddOrderBy_LoginMemberStatusCode_Asc(); }
            public void spFKCol(MbMemberLoginCB cb) { cb.Specify().ColumnLoginMemberStatusCode(); }
            public IList<MbMemberLogin> selRfLs(MbMemberLoginCB cb) { return referrerBhv.SelectList(cb); }
            public String getFKVal(MbMemberLogin e) { return e.LoginMemberStatusCode; }
            public void setlcEt(MbMemberLogin re, MbMemberStatus be) { re.MemberStatus = be; }
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
        public virtual void Insert(MbMemberStatus entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(MbEntity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(MbMemberStatus entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(MbEntity entity) {
            Update(Downcast(entity));
        }

        public void InsertOrUpdate(MbMemberStatus entity) {
            HelpInsertOrUpdateInternally<MbMemberStatus, MbMemberStatusCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<MbMemberStatus, MbMemberStatusCB> {
            protected MbMemberStatusBhv _bhv;
            public MyInternalInsertOrUpdateCallback(MbMemberStatusBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(MbMemberStatus entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(MbMemberStatus entity) { _bhv.Update(entity); }
            public MbMemberStatusCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(MbMemberStatusCB cb, MbMemberStatus entity) {
                cb.Query().SetMemberStatusCode_Equal(entity.MemberStatusCode);
            }
            public int CallbackSelectCount(MbMemberStatusCB cb) { return _bhv.SelectCount(cb); }
        }

        public virtual void Delete(MbMemberStatus entity) {
            HelpDeleteInternally<MbMemberStatus>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(MbEntity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<MbMemberStatus> {
            protected MbMemberStatusBhv _bhv;
            public MyInternalDeleteCallback(MbMemberStatusBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(MbMemberStatus entity) { return _bhv.DelegateDelete(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(MbMemberStatus memberStatus, MbMemberStatusCB cb) {
            AssertObjectNotNull("memberStatus", memberStatus); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(memberStatus);
            FilterEntityOfUpdate(memberStatus); AssertEntityOfUpdate(memberStatus);
            return this.Dao.UpdateByQuery(cb, memberStatus);
        }

        public int QueryDelete(MbMemberStatusCB cb) {
            AssertConditionBeanNotNull(cb);
            return this.Dao.DeleteByQuery(cb);
        }

        // ===============================================================================
        //                                                            Optimistic Lock Info
        //                                                            ====================
        protected override bool HasVersionNoValue(MbEntity entity) {
            return false;
        }

        protected override bool HasUpdateDateValue(MbEntity entity) {
            return false;
        }

        // ===============================================================================
        //                                                                 Delegate Method
        //                                                                 ===============
        #region Delegate Method
        protected int DelegateSelectCount(MbMemberStatusCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<MbMemberStatus> DelegateSelectList(MbMemberStatusCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(MbMemberStatus e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(MbMemberStatus e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(MbMemberStatus e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected MbMemberStatus Downcast(MbEntity entity) {
            return (MbMemberStatus)entity;
        }

        protected MbMemberStatusCB Downcast(MbConditionBean cb) {
            return (MbMemberStatusCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual MbMemberStatusDao Dao { get { return _dao; } set { _dao = value; } }
    }
}

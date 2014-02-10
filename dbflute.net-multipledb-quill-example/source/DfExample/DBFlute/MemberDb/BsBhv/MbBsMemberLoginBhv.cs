
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
    public partial class MbMemberLoginBhv : DfExample.DBFlute.MemberDb.AllCommon.Bhv.MbAbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected MbMemberLoginDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public MbMemberLoginBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "member_login"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override MbDBMeta DBMeta { get { return MbMemberLoginDbm.GetInstance(); } }
        public MbMemberLoginDbm MyDBMeta { get { return MbMemberLoginDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override MbEntity NewEntity() { return NewMyEntity(); }
        public override MbConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual MbMemberLogin NewMyEntity() { return new MbMemberLogin(); }
        public virtual MbMemberLoginCB NewMyConditionBean() { return new MbMemberLoginCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(MbMemberLoginCB cb) {
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
        public virtual MbMemberLogin SelectEntity(MbMemberLoginCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<MbMemberLogin> ls = null;
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
            return (MbMemberLogin)ls[0];
        }

        protected override MbEntity DoReadEntity(MbConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual MbMemberLogin SelectEntityWithDeletedCheck(MbMemberLoginCB cb) {
            AssertConditionBeanNotNull(cb);
            MbMemberLogin entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override MbEntity DoReadEntityWithDeletedCheck(MbConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual MbMemberLogin SelectByPKValue(long? memberLoginId) {
            return SelectEntity(BuildPKCB(memberLoginId));
        }

        public virtual MbMemberLogin SelectByPKValueWithDeletedCheck(long? memberLoginId) {
            return SelectEntityWithDeletedCheck(BuildPKCB(memberLoginId));
        }

        private MbMemberLoginCB BuildPKCB(long? memberLoginId) {
            AssertObjectNotNull("memberLoginId", memberLoginId);
            MbMemberLoginCB cb = NewMyConditionBean();
            cb.Query().SetMemberLoginId_Equal(memberLoginId);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual MbListResultBean<MbMemberLogin> SelectList(MbMemberLoginCB cb) {
            AssertConditionBeanNotNull(cb);
            return new MbResultBeanBuilder<MbMemberLogin>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual MbPagingResultBean<MbMemberLogin> SelectPage(MbMemberLoginCB cb) {
            AssertConditionBeanNotNull(cb);
            MbPagingInvoker<MbMemberLogin> invoker = new MbPagingInvoker<MbMemberLogin>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : MbPagingHandler<MbMemberLogin> {
            protected MbMemberLoginBhv _bhv; protected MbMemberLoginCB _cb;
            public InternalSelectPagingHandler(MbMemberLoginBhv bhv, MbMemberLoginCB cb) { _bhv = bhv; _cb = cb; }
            public MbPagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<MbMemberLogin> Paging() { return _bhv.SelectList(_cb); }
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
        public IList<MbMember> PulloutMember(IList<MbMemberLogin> memberLoginList) {
            return HelpPulloutInternally<MbMemberLogin, MbMember>(memberLoginList, new MyInternalPulloutMemberCallback());
        }
        protected class MyInternalPulloutMemberCallback : InternalPulloutCallback<MbMemberLogin, MbMember> {
            public MbMember getFr(MbMemberLogin entity) { return entity.Member; }
        }
        public IList<MbMemberStatus> PulloutMemberStatus(IList<MbMemberLogin> memberLoginList) {
            return HelpPulloutInternally<MbMemberLogin, MbMemberStatus>(memberLoginList, new MyInternalPulloutMemberStatusCallback());
        }
        protected class MyInternalPulloutMemberStatusCallback : InternalPulloutCallback<MbMemberLogin, MbMemberStatus> {
            public MbMemberStatus getFr(MbMemberLogin entity) { return entity.MemberStatus; }
        }
        #endregion


        // ===============================================================================
        //                                                                   Entity Update
        //                                                                   =============
        #region Basic Entity Update
        public virtual void Insert(MbMemberLogin entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(MbEntity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(MbMemberLogin entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(MbEntity entity) {
            Update(Downcast(entity));
        }

        public void InsertOrUpdate(MbMemberLogin entity) {
            HelpInsertOrUpdateInternally<MbMemberLogin, MbMemberLoginCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<MbMemberLogin, MbMemberLoginCB> {
            protected MbMemberLoginBhv _bhv;
            public MyInternalInsertOrUpdateCallback(MbMemberLoginBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(MbMemberLogin entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(MbMemberLogin entity) { _bhv.Update(entity); }
            public MbMemberLoginCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(MbMemberLoginCB cb, MbMemberLogin entity) {
                cb.Query().SetMemberLoginId_Equal(entity.MemberLoginId);
            }
            public int CallbackSelectCount(MbMemberLoginCB cb) { return _bhv.SelectCount(cb); }
        }

        public virtual void Delete(MbMemberLogin entity) {
            HelpDeleteInternally<MbMemberLogin>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(MbEntity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<MbMemberLogin> {
            protected MbMemberLoginBhv _bhv;
            public MyInternalDeleteCallback(MbMemberLoginBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(MbMemberLogin entity) { return _bhv.DelegateDelete(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(MbMemberLogin memberLogin, MbMemberLoginCB cb) {
            AssertObjectNotNull("memberLogin", memberLogin); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(memberLogin);
            FilterEntityOfUpdate(memberLogin); AssertEntityOfUpdate(memberLogin);
            return this.Dao.UpdateByQuery(cb, memberLogin);
        }

        public int QueryDelete(MbMemberLoginCB cb) {
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
        protected int DelegateSelectCount(MbMemberLoginCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<MbMemberLogin> DelegateSelectList(MbMemberLoginCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(MbMemberLogin e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(MbMemberLogin e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(MbMemberLogin e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected MbMemberLogin Downcast(MbEntity entity) {
            return (MbMemberLogin)entity;
        }

        protected MbMemberLoginCB Downcast(MbConditionBean cb) {
            return (MbMemberLoginCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual MbMemberLoginDao Dao { get { return _dao; } set { _dao = value; } }
    }
}

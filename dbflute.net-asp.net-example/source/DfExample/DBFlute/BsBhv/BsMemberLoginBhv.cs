
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
    public partial class MemberLoginBhv : DfExample.DBFlute.AllCommon.Bhv.AbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected MemberLoginDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public MemberLoginBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "MEMBER_LOGIN"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override DBMeta DBMeta { get { return MemberLoginDbm.GetInstance(); } }
        public MemberLoginDbm MyDBMeta { get { return MemberLoginDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override Entity NewEntity() { return NewMyEntity(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual MemberLogin NewMyEntity() { return new MemberLogin(); }
        public virtual MemberLoginCB NewMyConditionBean() { return new MemberLoginCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(MemberLoginCB cb) {
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
        public virtual MemberLogin SelectEntity(MemberLoginCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<MemberLogin> ls = null;
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
            return (MemberLogin)ls[0];
        }

        protected override Entity DoReadEntity(ConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual MemberLogin SelectEntityWithDeletedCheck(MemberLoginCB cb) {
            AssertConditionBeanNotNull(cb);
            MemberLogin entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override Entity DoReadEntityWithDeletedCheck(ConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual MemberLogin SelectByPKValue(long? memberLoginId) {
            return SelectEntity(BuildPKCB(memberLoginId));
        }

        public virtual MemberLogin SelectByPKValueWithDeletedCheck(long? memberLoginId) {
            return SelectEntityWithDeletedCheck(BuildPKCB(memberLoginId));
        }

        private MemberLoginCB BuildPKCB(long? memberLoginId) {
            AssertObjectNotNull("memberLoginId", memberLoginId);
            MemberLoginCB cb = NewMyConditionBean();
            cb.Query().SetMemberLoginId_Equal(memberLoginId);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual ListResultBean<MemberLogin> SelectList(MemberLoginCB cb) {
            AssertConditionBeanNotNull(cb);
            return new ResultBeanBuilder<MemberLogin>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual PagingResultBean<MemberLogin> SelectPage(MemberLoginCB cb) {
            AssertConditionBeanNotNull(cb);
            PagingInvoker<MemberLogin> invoker = new PagingInvoker<MemberLogin>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : PagingHandler<MemberLogin> {
            protected MemberLoginBhv _bhv; protected MemberLoginCB _cb;
            public InternalSelectPagingHandler(MemberLoginBhv bhv, MemberLoginCB cb) { _bhv = bhv; _cb = cb; }
            public PagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<MemberLogin> Paging() { return _bhv.SelectList(_cb); }
        }
        #endregion

        // ===============================================================================
        //                                                                        Sequence
        //                                                                        ========
        public long? SelectNextVal() {
            return DelegateSelectNextVal();
        }
        protected override void SetupNextValueToPrimaryKey(Entity entity) {// Very Internal
            MemberLogin myEntity = (MemberLogin)entity;
            myEntity.MemberLoginId = SelectNextVal();
        }

        // ===============================================================================
        //                                                                   Load Referrer
        //                                                                   =============
        #region Load Referrer
        #endregion

        // ===============================================================================
        //                                                                Pull out Foreign
        //                                                                ================
        #region Pullout Foreign
        public IList<Member> PulloutMember(IList<MemberLogin> memberLoginList) {
            return HelpPulloutInternally<MemberLogin, Member>(memberLoginList, new MyInternalPulloutMemberCallback());
        }
        protected class MyInternalPulloutMemberCallback : InternalPulloutCallback<MemberLogin, Member> {
            public Member getFr(MemberLogin entity) { return entity.Member; }
        }
        public IList<MemberStatus> PulloutMemberStatus(IList<MemberLogin> memberLoginList) {
            return HelpPulloutInternally<MemberLogin, MemberStatus>(memberLoginList, new MyInternalPulloutMemberStatusCallback());
        }
        protected class MyInternalPulloutMemberStatusCallback : InternalPulloutCallback<MemberLogin, MemberStatus> {
            public MemberStatus getFr(MemberLogin entity) { return entity.MemberStatus; }
        }
        #endregion


        // ===============================================================================
        //                                                                   Entity Update
        //                                                                   =============
        #region Basic Entity Update
        public virtual void Insert(MemberLogin entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(Entity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(MemberLogin entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(Entity entity) {
            Update(Downcast(entity));
        }

        public void InsertOrUpdate(MemberLogin entity) {
            HelpInsertOrUpdateInternally<MemberLogin, MemberLoginCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<MemberLogin, MemberLoginCB> {
            protected MemberLoginBhv _bhv;
            public MyInternalInsertOrUpdateCallback(MemberLoginBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(MemberLogin entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(MemberLogin entity) { _bhv.Update(entity); }
            public MemberLoginCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(MemberLoginCB cb, MemberLogin entity) {
                cb.Query().SetMemberLoginId_Equal(entity.MemberLoginId);
            }
            public int CallbackSelectCount(MemberLoginCB cb) { return _bhv.SelectCount(cb); }
        }

        public virtual void Delete(MemberLogin entity) {
            HelpDeleteInternally<MemberLogin>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(Entity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<MemberLogin> {
            protected MemberLoginBhv _bhv;
            public MyInternalDeleteCallback(MemberLoginBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(MemberLogin entity) { return _bhv.DelegateDelete(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(MemberLogin memberLogin, MemberLoginCB cb) {
            AssertObjectNotNull("memberLogin", memberLogin); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(memberLogin);
            FilterEntityOfUpdate(memberLogin); AssertEntityOfUpdate(memberLogin);
            return this.Dao.UpdateByQuery(cb, memberLogin);
        }

        public int QueryDelete(MemberLoginCB cb) {
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
        protected int DelegateSelectCount(MemberLoginCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<MemberLogin> DelegateSelectList(MemberLoginCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }
        protected long? DelegateSelectNextVal() { return this.Dao.SelectNextVal(); }

        protected int DelegateInsert(MemberLogin e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(MemberLogin e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(MemberLogin e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected MemberLogin Downcast(Entity entity) {
            return (MemberLogin)entity;
        }

        protected MemberLoginCB Downcast(ConditionBean cb) {
            return (MemberLoginCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual MemberLoginDao Dao { get { return _dao; } set { _dao = value; } }
    }
}

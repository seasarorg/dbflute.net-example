
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
    public partial class MemberSecurityBhv : DfExample.DBFlute.AllCommon.Bhv.AbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected MemberSecurityDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public MemberSecurityBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "member_security"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override DBMeta DBMeta { get { return MemberSecurityDbm.GetInstance(); } }
        public MemberSecurityDbm MyDBMeta { get { return MemberSecurityDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override Entity NewEntity() { return NewMyEntity(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual MemberSecurity NewMyEntity() { return new MemberSecurity(); }
        public virtual MemberSecurityCB NewMyConditionBean() { return new MemberSecurityCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(MemberSecurityCB cb) {
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
        public virtual MemberSecurity SelectEntity(MemberSecurityCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<MemberSecurity> ls = null;
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
            return (MemberSecurity)ls[0];
        }

        protected override Entity DoReadEntity(ConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual MemberSecurity SelectEntityWithDeletedCheck(MemberSecurityCB cb) {
            AssertConditionBeanNotNull(cb);
            MemberSecurity entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override Entity DoReadEntityWithDeletedCheck(ConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual MemberSecurity SelectByPKValue(int? memberId) {
            return SelectEntity(BuildPKCB(memberId));
        }

        public virtual MemberSecurity SelectByPKValueWithDeletedCheck(int? memberId) {
            return SelectEntityWithDeletedCheck(BuildPKCB(memberId));
        }

        private MemberSecurityCB BuildPKCB(int? memberId) {
            AssertObjectNotNull("memberId", memberId);
            MemberSecurityCB cb = NewMyConditionBean();
            cb.Query().SetMemberId_Equal(memberId);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual ListResultBean<MemberSecurity> SelectList(MemberSecurityCB cb) {
            AssertConditionBeanNotNull(cb);
            return new ResultBeanBuilder<MemberSecurity>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual PagingResultBean<MemberSecurity> SelectPage(MemberSecurityCB cb) {
            AssertConditionBeanNotNull(cb);
            PagingInvoker<MemberSecurity> invoker = new PagingInvoker<MemberSecurity>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : PagingHandler<MemberSecurity> {
            protected MemberSecurityBhv _bhv; protected MemberSecurityCB _cb;
            public InternalSelectPagingHandler(MemberSecurityBhv bhv, MemberSecurityCB cb) { _bhv = bhv; _cb = cb; }
            public PagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<MemberSecurity> Paging() { return _bhv.SelectList(_cb); }
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
        public IList<Member> PulloutMember(IList<MemberSecurity> memberSecurityList) {
            return HelpPulloutInternally<MemberSecurity, Member>(memberSecurityList, new MyInternalPulloutMemberCallback());
        }
        protected class MyInternalPulloutMemberCallback : InternalPulloutCallback<MemberSecurity, Member> {
            public Member getFr(MemberSecurity entity) { return entity.Member; }
        }
        #endregion


        // ===============================================================================
        //                                                                   Entity Update
        //                                                                   =============
        #region Basic Entity Update
        public virtual void Insert(MemberSecurity entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(Entity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(MemberSecurity entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(Entity entity) {
            Update(Downcast(entity));
        }

        public virtual void UpdateNonstrict(MemberSecurity entity) {
            AssertEntityNotNull(entity);
            int updatedCount = this.DelegateUpdateNonstrict(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        public void InsertOrUpdate(MemberSecurity entity) {
            HelpInsertOrUpdateInternally<MemberSecurity, MemberSecurityCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<MemberSecurity, MemberSecurityCB> {
            protected MemberSecurityBhv _bhv;
            public MyInternalInsertOrUpdateCallback(MemberSecurityBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(MemberSecurity entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(MemberSecurity entity) { _bhv.Update(entity); }
            public MemberSecurityCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(MemberSecurityCB cb, MemberSecurity entity) {
                cb.Query().SetMemberId_Equal(entity.MemberId);
            }
            public int CallbackSelectCount(MemberSecurityCB cb) { return _bhv.SelectCount(cb); }
        }

        public void InsertOrUpdateNonstrict(MemberSecurity entity) {
            HelpInsertOrUpdateInternally<MemberSecurity>(entity, new MyInternalInsertOrUpdateNonstrictCallback(this));
        }
        protected class MyInternalInsertOrUpdateNonstrictCallback : InternalInsertOrUpdateNonstrictCallback<MemberSecurity> {
            protected MemberSecurityBhv _bhv;
            public MyInternalInsertOrUpdateNonstrictCallback(MemberSecurityBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(MemberSecurity entity) { _bhv.Insert(entity); }
            public void CallbackUpdateNonstrict(MemberSecurity entity) { _bhv.UpdateNonstrict(entity); }
        }

        public virtual void Delete(MemberSecurity entity) {
            HelpDeleteInternally<MemberSecurity>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(Entity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<MemberSecurity> {
            protected MemberSecurityBhv _bhv;
            public MyInternalDeleteCallback(MemberSecurityBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(MemberSecurity entity) { return _bhv.DelegateDelete(entity); }
        }

        public virtual void DeleteNonstrict(MemberSecurity entity) {
            HelpDeleteNonstrictInternally<MemberSecurity>(entity, new MyInternalDeleteNonstrictCallback(this));
        }
        protected class MyInternalDeleteNonstrictCallback : InternalDeleteNonstrictCallback<MemberSecurity> {
            protected MemberSecurityBhv _bhv;
            public MyInternalDeleteNonstrictCallback(MemberSecurityBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDeleteNonstrict(MemberSecurity entity) { return _bhv.DelegateDeleteNonstrict(entity); }
        }

        public virtual void DeleteNonstrictIgnoreDeleted(MemberSecurity entity) {
            HelpDeleteNonstrictIgnoreDeletedInternally<MemberSecurity>(entity, new MyInternalDeleteNonstrictIgnoreDeletedCallback(this));
        }
        protected class MyInternalDeleteNonstrictIgnoreDeletedCallback : InternalDeleteNonstrictIgnoreDeletedCallback<MemberSecurity> {
            protected MemberSecurityBhv _bhv;
            public MyInternalDeleteNonstrictIgnoreDeletedCallback(MemberSecurityBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDeleteNonstrict(MemberSecurity entity) { return _bhv.DelegateDeleteNonstrict(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(MemberSecurity memberSecurity, MemberSecurityCB cb) {
            AssertObjectNotNull("memberSecurity", memberSecurity); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(memberSecurity);
            FilterEntityOfUpdate(memberSecurity); AssertEntityOfUpdate(memberSecurity);
            return this.Dao.UpdateByQuery(cb, memberSecurity);
        }

        public int QueryDelete(MemberSecurityCB cb) {
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
        protected int DelegateSelectCount(MemberSecurityCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<MemberSecurity> DelegateSelectList(MemberSecurityCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(MemberSecurity e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(MemberSecurity e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateModifiedOnly(e); }
        protected int DelegateUpdateNonstrict(MemberSecurity e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(MemberSecurity e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.Delete(e); }
        protected int DelegateDeleteNonstrict(MemberSecurity e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected MemberSecurity Downcast(Entity entity) {
            return (MemberSecurity)entity;
        }

        protected MemberSecurityCB Downcast(ConditionBean cb) {
            return (MemberSecurityCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual MemberSecurityDao Dao { get { return _dao; } set { _dao = value; } }
    }
}

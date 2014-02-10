
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
    public partial class MbMemberSecurityBhv : DfExample.DBFlute.MemberDb.AllCommon.Bhv.MbAbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected MbMemberSecurityDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public MbMemberSecurityBhv() {
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
        public override MbDBMeta DBMeta { get { return MbMemberSecurityDbm.GetInstance(); } }
        public MbMemberSecurityDbm MyDBMeta { get { return MbMemberSecurityDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override MbEntity NewEntity() { return NewMyEntity(); }
        public override MbConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual MbMemberSecurity NewMyEntity() { return new MbMemberSecurity(); }
        public virtual MbMemberSecurityCB NewMyConditionBean() { return new MbMemberSecurityCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(MbMemberSecurityCB cb) {
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
        public virtual MbMemberSecurity SelectEntity(MbMemberSecurityCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<MbMemberSecurity> ls = null;
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
            return (MbMemberSecurity)ls[0];
        }

        protected override MbEntity DoReadEntity(MbConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual MbMemberSecurity SelectEntityWithDeletedCheck(MbMemberSecurityCB cb) {
            AssertConditionBeanNotNull(cb);
            MbMemberSecurity entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override MbEntity DoReadEntityWithDeletedCheck(MbConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual MbMemberSecurity SelectByPKValue(int? memberId) {
            return SelectEntity(BuildPKCB(memberId));
        }

        public virtual MbMemberSecurity SelectByPKValueWithDeletedCheck(int? memberId) {
            return SelectEntityWithDeletedCheck(BuildPKCB(memberId));
        }

        private MbMemberSecurityCB BuildPKCB(int? memberId) {
            AssertObjectNotNull("memberId", memberId);
            MbMemberSecurityCB cb = NewMyConditionBean();
            cb.Query().SetMemberId_Equal(memberId);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual MbListResultBean<MbMemberSecurity> SelectList(MbMemberSecurityCB cb) {
            AssertConditionBeanNotNull(cb);
            return new MbResultBeanBuilder<MbMemberSecurity>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual MbPagingResultBean<MbMemberSecurity> SelectPage(MbMemberSecurityCB cb) {
            AssertConditionBeanNotNull(cb);
            MbPagingInvoker<MbMemberSecurity> invoker = new MbPagingInvoker<MbMemberSecurity>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : MbPagingHandler<MbMemberSecurity> {
            protected MbMemberSecurityBhv _bhv; protected MbMemberSecurityCB _cb;
            public InternalSelectPagingHandler(MbMemberSecurityBhv bhv, MbMemberSecurityCB cb) { _bhv = bhv; _cb = cb; }
            public MbPagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<MbMemberSecurity> Paging() { return _bhv.SelectList(_cb); }
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
        public IList<MbMember> PulloutMember(IList<MbMemberSecurity> memberSecurityList) {
            return HelpPulloutInternally<MbMemberSecurity, MbMember>(memberSecurityList, new MyInternalPulloutMemberCallback());
        }
        protected class MyInternalPulloutMemberCallback : InternalPulloutCallback<MbMemberSecurity, MbMember> {
            public MbMember getFr(MbMemberSecurity entity) { return entity.Member; }
        }
        #endregion


        // ===============================================================================
        //                                                                   Entity Update
        //                                                                   =============
        #region Basic Entity Update
        public virtual void Insert(MbMemberSecurity entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(MbEntity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(MbMemberSecurity entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(MbEntity entity) {
            Update(Downcast(entity));
        }

        public virtual void UpdateNonstrict(MbMemberSecurity entity) {
            AssertEntityNotNull(entity);
            int updatedCount = this.DelegateUpdateNonstrict(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        public void InsertOrUpdate(MbMemberSecurity entity) {
            HelpInsertOrUpdateInternally<MbMemberSecurity, MbMemberSecurityCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<MbMemberSecurity, MbMemberSecurityCB> {
            protected MbMemberSecurityBhv _bhv;
            public MyInternalInsertOrUpdateCallback(MbMemberSecurityBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(MbMemberSecurity entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(MbMemberSecurity entity) { _bhv.Update(entity); }
            public MbMemberSecurityCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(MbMemberSecurityCB cb, MbMemberSecurity entity) {
                cb.Query().SetMemberId_Equal(entity.MemberId);
            }
            public int CallbackSelectCount(MbMemberSecurityCB cb) { return _bhv.SelectCount(cb); }
        }

        public void InsertOrUpdateNonstrict(MbMemberSecurity entity) {
            HelpInsertOrUpdateInternally<MbMemberSecurity>(entity, new MyInternalInsertOrUpdateNonstrictCallback(this));
        }
        protected class MyInternalInsertOrUpdateNonstrictCallback : InternalInsertOrUpdateNonstrictCallback<MbMemberSecurity> {
            protected MbMemberSecurityBhv _bhv;
            public MyInternalInsertOrUpdateNonstrictCallback(MbMemberSecurityBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(MbMemberSecurity entity) { _bhv.Insert(entity); }
            public void CallbackUpdateNonstrict(MbMemberSecurity entity) { _bhv.UpdateNonstrict(entity); }
        }

        public virtual void Delete(MbMemberSecurity entity) {
            HelpDeleteInternally<MbMemberSecurity>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(MbEntity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<MbMemberSecurity> {
            protected MbMemberSecurityBhv _bhv;
            public MyInternalDeleteCallback(MbMemberSecurityBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(MbMemberSecurity entity) { return _bhv.DelegateDelete(entity); }
        }

        public virtual void DeleteNonstrict(MbMemberSecurity entity) {
            HelpDeleteNonstrictInternally<MbMemberSecurity>(entity, new MyInternalDeleteNonstrictCallback(this));
        }
        protected class MyInternalDeleteNonstrictCallback : InternalDeleteNonstrictCallback<MbMemberSecurity> {
            protected MbMemberSecurityBhv _bhv;
            public MyInternalDeleteNonstrictCallback(MbMemberSecurityBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDeleteNonstrict(MbMemberSecurity entity) { return _bhv.DelegateDeleteNonstrict(entity); }
        }

        public virtual void DeleteNonstrictIgnoreDeleted(MbMemberSecurity entity) {
            HelpDeleteNonstrictIgnoreDeletedInternally<MbMemberSecurity>(entity, new MyInternalDeleteNonstrictIgnoreDeletedCallback(this));
        }
        protected class MyInternalDeleteNonstrictIgnoreDeletedCallback : InternalDeleteNonstrictIgnoreDeletedCallback<MbMemberSecurity> {
            protected MbMemberSecurityBhv _bhv;
            public MyInternalDeleteNonstrictIgnoreDeletedCallback(MbMemberSecurityBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDeleteNonstrict(MbMemberSecurity entity) { return _bhv.DelegateDeleteNonstrict(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(MbMemberSecurity memberSecurity, MbMemberSecurityCB cb) {
            AssertObjectNotNull("memberSecurity", memberSecurity); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(memberSecurity);
            FilterEntityOfUpdate(memberSecurity); AssertEntityOfUpdate(memberSecurity);
            return this.Dao.UpdateByQuery(cb, memberSecurity);
        }

        public int QueryDelete(MbMemberSecurityCB cb) {
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
        protected int DelegateSelectCount(MbMemberSecurityCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<MbMemberSecurity> DelegateSelectList(MbMemberSecurityCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(MbMemberSecurity e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(MbMemberSecurity e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateModifiedOnly(e); }
        protected int DelegateUpdateNonstrict(MbMemberSecurity e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(MbMemberSecurity e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.Delete(e); }
        protected int DelegateDeleteNonstrict(MbMemberSecurity e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected MbMemberSecurity Downcast(MbEntity entity) {
            return (MbMemberSecurity)entity;
        }

        protected MbMemberSecurityCB Downcast(MbConditionBean cb) {
            return (MbMemberSecurityCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual MbMemberSecurityDao Dao { get { return _dao; } set { _dao = value; } }
    }
}


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
    public partial class VdSynonymMemberLoginBhv : DfExample.DBFlute.AllCommon.Bhv.AbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected VdSynonymMemberLoginDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public VdSynonymMemberLoginBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "VD_SYNONYM_MEMBER_LOGIN"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override DBMeta DBMeta { get { return VdSynonymMemberLoginDbm.GetInstance(); } }
        public VdSynonymMemberLoginDbm MyDBMeta { get { return VdSynonymMemberLoginDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override Entity NewEntity() { return NewMyEntity(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual VdSynonymMemberLogin NewMyEntity() { return new VdSynonymMemberLogin(); }
        public virtual VdSynonymMemberLoginCB NewMyConditionBean() { return new VdSynonymMemberLoginCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(VdSynonymMemberLoginCB cb) {
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
        public virtual VdSynonymMemberLogin SelectEntity(VdSynonymMemberLoginCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<VdSynonymMemberLogin> ls = null;
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
            return (VdSynonymMemberLogin)ls[0];
        }

        protected override Entity DoReadEntity(ConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual VdSynonymMemberLogin SelectEntityWithDeletedCheck(VdSynonymMemberLoginCB cb) {
            AssertConditionBeanNotNull(cb);
            VdSynonymMemberLogin entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override Entity DoReadEntityWithDeletedCheck(ConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual VdSynonymMemberLogin SelectByPKValue(long? memberLoginId) {
            return SelectEntity(BuildPKCB(memberLoginId));
        }

        public virtual VdSynonymMemberLogin SelectByPKValueWithDeletedCheck(long? memberLoginId) {
            return SelectEntityWithDeletedCheck(BuildPKCB(memberLoginId));
        }

        private VdSynonymMemberLoginCB BuildPKCB(long? memberLoginId) {
            AssertObjectNotNull("memberLoginId", memberLoginId);
            VdSynonymMemberLoginCB cb = NewMyConditionBean();
            cb.Query().SetMemberLoginId_Equal(memberLoginId);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual ListResultBean<VdSynonymMemberLogin> SelectList(VdSynonymMemberLoginCB cb) {
            AssertConditionBeanNotNull(cb);
            return new ResultBeanBuilder<VdSynonymMemberLogin>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual PagingResultBean<VdSynonymMemberLogin> SelectPage(VdSynonymMemberLoginCB cb) {
            AssertConditionBeanNotNull(cb);
            PagingInvoker<VdSynonymMemberLogin> invoker = new PagingInvoker<VdSynonymMemberLogin>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : PagingHandler<VdSynonymMemberLogin> {
            protected VdSynonymMemberLoginBhv _bhv; protected VdSynonymMemberLoginCB _cb;
            public InternalSelectPagingHandler(VdSynonymMemberLoginBhv bhv, VdSynonymMemberLoginCB cb) { _bhv = bhv; _cb = cb; }
            public PagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<VdSynonymMemberLogin> Paging() { return _bhv.SelectList(_cb); }
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
        public IList<MemberStatus> PulloutMemberStatus(IList<VdSynonymMemberLogin> vdSynonymMemberLoginList) {
            return HelpPulloutInternally<VdSynonymMemberLogin, MemberStatus>(vdSynonymMemberLoginList, new MyInternalPulloutMemberStatusCallback());
        }
        protected class MyInternalPulloutMemberStatusCallback : InternalPulloutCallback<VdSynonymMemberLogin, MemberStatus> {
            public MemberStatus getFr(VdSynonymMemberLogin entity) { return entity.MemberStatus; }
        }
        public IList<MemberVendorSynonym> PulloutMemberVendorSynonym(IList<VdSynonymMemberLogin> vdSynonymMemberLoginList) {
            return HelpPulloutInternally<VdSynonymMemberLogin, MemberVendorSynonym>(vdSynonymMemberLoginList, new MyInternalPulloutMemberVendorSynonymCallback());
        }
        protected class MyInternalPulloutMemberVendorSynonymCallback : InternalPulloutCallback<VdSynonymMemberLogin, MemberVendorSynonym> {
            public MemberVendorSynonym getFr(VdSynonymMemberLogin entity) { return entity.MemberVendorSynonym; }
        }
        public IList<VdSynonymMember> PulloutVdSynonymMember(IList<VdSynonymMemberLogin> vdSynonymMemberLoginList) {
            return HelpPulloutInternally<VdSynonymMemberLogin, VdSynonymMember>(vdSynonymMemberLoginList, new MyInternalPulloutVdSynonymMemberCallback());
        }
        protected class MyInternalPulloutVdSynonymMemberCallback : InternalPulloutCallback<VdSynonymMemberLogin, VdSynonymMember> {
            public VdSynonymMember getFr(VdSynonymMemberLogin entity) { return entity.VdSynonymMember; }
        }
        public IList<VendorSynonymMember> PulloutVendorSynonymMember(IList<VdSynonymMemberLogin> vdSynonymMemberLoginList) {
            return HelpPulloutInternally<VdSynonymMemberLogin, VendorSynonymMember>(vdSynonymMemberLoginList, new MyInternalPulloutVendorSynonymMemberCallback());
        }
        protected class MyInternalPulloutVendorSynonymMemberCallback : InternalPulloutCallback<VdSynonymMemberLogin, VendorSynonymMember> {
            public VendorSynonymMember getFr(VdSynonymMemberLogin entity) { return entity.VendorSynonymMember; }
        }
        #endregion


        // ===============================================================================
        //                                                                   Entity Update
        //                                                                   =============
        #region Basic Entity Update
        public virtual void Insert(VdSynonymMemberLogin entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(Entity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(VdSynonymMemberLogin entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(Entity entity) {
            Update(Downcast(entity));
        }

        public void InsertOrUpdate(VdSynonymMemberLogin entity) {
            HelpInsertOrUpdateInternally<VdSynonymMemberLogin, VdSynonymMemberLoginCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<VdSynonymMemberLogin, VdSynonymMemberLoginCB> {
            protected VdSynonymMemberLoginBhv _bhv;
            public MyInternalInsertOrUpdateCallback(VdSynonymMemberLoginBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(VdSynonymMemberLogin entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(VdSynonymMemberLogin entity) { _bhv.Update(entity); }
            public VdSynonymMemberLoginCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(VdSynonymMemberLoginCB cb, VdSynonymMemberLogin entity) {
                cb.Query().SetMemberLoginId_Equal(entity.MemberLoginId);
            }
            public int CallbackSelectCount(VdSynonymMemberLoginCB cb) { return _bhv.SelectCount(cb); }
        }

        public virtual void Delete(VdSynonymMemberLogin entity) {
            HelpDeleteInternally<VdSynonymMemberLogin>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(Entity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<VdSynonymMemberLogin> {
            protected VdSynonymMemberLoginBhv _bhv;
            public MyInternalDeleteCallback(VdSynonymMemberLoginBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(VdSynonymMemberLogin entity) { return _bhv.DelegateDelete(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(VdSynonymMemberLogin vdSynonymMemberLogin, VdSynonymMemberLoginCB cb) {
            AssertObjectNotNull("vdSynonymMemberLogin", vdSynonymMemberLogin); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(vdSynonymMemberLogin);
            FilterEntityOfUpdate(vdSynonymMemberLogin); AssertEntityOfUpdate(vdSynonymMemberLogin);
            return this.Dao.UpdateByQuery(cb, vdSynonymMemberLogin);
        }

        public int QueryDelete(VdSynonymMemberLoginCB cb) {
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
        protected int DelegateSelectCount(VdSynonymMemberLoginCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<VdSynonymMemberLogin> DelegateSelectList(VdSynonymMemberLoginCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(VdSynonymMemberLogin e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(VdSynonymMemberLogin e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(VdSynonymMemberLogin e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected VdSynonymMemberLogin Downcast(Entity entity) {
            return (VdSynonymMemberLogin)entity;
        }

        protected VdSynonymMemberLoginCB Downcast(ConditionBean cb) {
            return (VdSynonymMemberLoginCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual VdSynonymMemberLoginDao Dao { get { return _dao; } set { _dao = value; } }
    }
}


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
    public partial class MemberAddressBhv : DfExample.DBFlute.AllCommon.Bhv.AbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected MemberAddressDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public MemberAddressBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "member_address"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override DBMeta DBMeta { get { return MemberAddressDbm.GetInstance(); } }
        public MemberAddressDbm MyDBMeta { get { return MemberAddressDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override Entity NewEntity() { return NewMyEntity(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual MemberAddress NewMyEntity() { return new MemberAddress(); }
        public virtual MemberAddressCB NewMyConditionBean() { return new MemberAddressCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(MemberAddressCB cb) {
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
        public virtual MemberAddress SelectEntity(MemberAddressCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<MemberAddress> ls = null;
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
            return (MemberAddress)ls[0];
        }

        protected override Entity DoReadEntity(ConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual MemberAddress SelectEntityWithDeletedCheck(MemberAddressCB cb) {
            AssertConditionBeanNotNull(cb);
            MemberAddress entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override Entity DoReadEntityWithDeletedCheck(ConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual MemberAddress SelectByPKValue(int? memberAddressId) {
            return SelectEntity(BuildPKCB(memberAddressId));
        }

        public virtual MemberAddress SelectByPKValueWithDeletedCheck(int? memberAddressId) {
            return SelectEntityWithDeletedCheck(BuildPKCB(memberAddressId));
        }

        private MemberAddressCB BuildPKCB(int? memberAddressId) {
            AssertObjectNotNull("memberAddressId", memberAddressId);
            MemberAddressCB cb = NewMyConditionBean();
            cb.Query().SetMemberAddressId_Equal(memberAddressId);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual ListResultBean<MemberAddress> SelectList(MemberAddressCB cb) {
            AssertConditionBeanNotNull(cb);
            return new ResultBeanBuilder<MemberAddress>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual PagingResultBean<MemberAddress> SelectPage(MemberAddressCB cb) {
            AssertConditionBeanNotNull(cb);
            PagingInvoker<MemberAddress> invoker = new PagingInvoker<MemberAddress>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : PagingHandler<MemberAddress> {
            protected MemberAddressBhv _bhv; protected MemberAddressCB _cb;
            public InternalSelectPagingHandler(MemberAddressBhv bhv, MemberAddressCB cb) { _bhv = bhv; _cb = cb; }
            public PagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<MemberAddress> Paging() { return _bhv.SelectList(_cb); }
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
        public IList<Member> PulloutMember(IList<MemberAddress> memberAddressList) {
            return HelpPulloutInternally<MemberAddress, Member>(memberAddressList, new MyInternalPulloutMemberCallback());
        }
        protected class MyInternalPulloutMemberCallback : InternalPulloutCallback<MemberAddress, Member> {
            public Member getFr(MemberAddress entity) { return entity.Member; }
        }
        #endregion


        // ===============================================================================
        //                                                                   Entity Update
        //                                                                   =============
        #region Basic Entity Update
        public virtual void Insert(MemberAddress entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(Entity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(MemberAddress entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(Entity entity) {
            Update(Downcast(entity));
        }

        public virtual void UpdateNonstrict(MemberAddress entity) {
            AssertEntityNotNull(entity);
            int updatedCount = this.DelegateUpdateNonstrict(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        public void InsertOrUpdate(MemberAddress entity) {
            HelpInsertOrUpdateInternally<MemberAddress, MemberAddressCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<MemberAddress, MemberAddressCB> {
            protected MemberAddressBhv _bhv;
            public MyInternalInsertOrUpdateCallback(MemberAddressBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(MemberAddress entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(MemberAddress entity) { _bhv.Update(entity); }
            public MemberAddressCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(MemberAddressCB cb, MemberAddress entity) {
                cb.Query().SetMemberAddressId_Equal(entity.MemberAddressId);
            }
            public int CallbackSelectCount(MemberAddressCB cb) { return _bhv.SelectCount(cb); }
        }

        public void InsertOrUpdateNonstrict(MemberAddress entity) {
            HelpInsertOrUpdateInternally<MemberAddress>(entity, new MyInternalInsertOrUpdateNonstrictCallback(this));
        }
        protected class MyInternalInsertOrUpdateNonstrictCallback : InternalInsertOrUpdateNonstrictCallback<MemberAddress> {
            protected MemberAddressBhv _bhv;
            public MyInternalInsertOrUpdateNonstrictCallback(MemberAddressBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(MemberAddress entity) { _bhv.Insert(entity); }
            public void CallbackUpdateNonstrict(MemberAddress entity) { _bhv.UpdateNonstrict(entity); }
        }

        public virtual void Delete(MemberAddress entity) {
            HelpDeleteInternally<MemberAddress>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(Entity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<MemberAddress> {
            protected MemberAddressBhv _bhv;
            public MyInternalDeleteCallback(MemberAddressBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(MemberAddress entity) { return _bhv.DelegateDelete(entity); }
        }

        public virtual void DeleteNonstrict(MemberAddress entity) {
            HelpDeleteNonstrictInternally<MemberAddress>(entity, new MyInternalDeleteNonstrictCallback(this));
        }
        protected class MyInternalDeleteNonstrictCallback : InternalDeleteNonstrictCallback<MemberAddress> {
            protected MemberAddressBhv _bhv;
            public MyInternalDeleteNonstrictCallback(MemberAddressBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDeleteNonstrict(MemberAddress entity) { return _bhv.DelegateDeleteNonstrict(entity); }
        }

        public virtual void DeleteNonstrictIgnoreDeleted(MemberAddress entity) {
            HelpDeleteNonstrictIgnoreDeletedInternally<MemberAddress>(entity, new MyInternalDeleteNonstrictIgnoreDeletedCallback(this));
        }
        protected class MyInternalDeleteNonstrictIgnoreDeletedCallback : InternalDeleteNonstrictIgnoreDeletedCallback<MemberAddress> {
            protected MemberAddressBhv _bhv;
            public MyInternalDeleteNonstrictIgnoreDeletedCallback(MemberAddressBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDeleteNonstrict(MemberAddress entity) { return _bhv.DelegateDeleteNonstrict(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(MemberAddress memberAddress, MemberAddressCB cb) {
            AssertObjectNotNull("memberAddress", memberAddress); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(memberAddress);
            FilterEntityOfUpdate(memberAddress); AssertEntityOfUpdate(memberAddress);
            return this.Dao.UpdateByQuery(cb, memberAddress);
        }

        public int QueryDelete(MemberAddressCB cb) {
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
        protected int DelegateSelectCount(MemberAddressCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<MemberAddress> DelegateSelectList(MemberAddressCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(MemberAddress e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(MemberAddress e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateModifiedOnly(e); }
        protected int DelegateUpdateNonstrict(MemberAddress e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(MemberAddress e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.Delete(e); }
        protected int DelegateDeleteNonstrict(MemberAddress e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected MemberAddress Downcast(Entity entity) {
            return (MemberAddress)entity;
        }

        protected MemberAddressCB Downcast(ConditionBean cb) {
            return (MemberAddressCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual MemberAddressDao Dao { get { return _dao; } set { _dao = value; } }
    }
}

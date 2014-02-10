
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
    public partial class MbMemberAddressBhv : DfExample.DBFlute.MemberDb.AllCommon.Bhv.MbAbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected MbMemberAddressDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public MbMemberAddressBhv() {
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
        public override MbDBMeta DBMeta { get { return MbMemberAddressDbm.GetInstance(); } }
        public MbMemberAddressDbm MyDBMeta { get { return MbMemberAddressDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override MbEntity NewEntity() { return NewMyEntity(); }
        public override MbConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual MbMemberAddress NewMyEntity() { return new MbMemberAddress(); }
        public virtual MbMemberAddressCB NewMyConditionBean() { return new MbMemberAddressCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(MbMemberAddressCB cb) {
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
        public virtual MbMemberAddress SelectEntity(MbMemberAddressCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<MbMemberAddress> ls = null;
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
            return (MbMemberAddress)ls[0];
        }

        protected override MbEntity DoReadEntity(MbConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual MbMemberAddress SelectEntityWithDeletedCheck(MbMemberAddressCB cb) {
            AssertConditionBeanNotNull(cb);
            MbMemberAddress entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override MbEntity DoReadEntityWithDeletedCheck(MbConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual MbMemberAddress SelectByPKValue(int? memberAddressId) {
            return SelectEntity(BuildPKCB(memberAddressId));
        }

        public virtual MbMemberAddress SelectByPKValueWithDeletedCheck(int? memberAddressId) {
            return SelectEntityWithDeletedCheck(BuildPKCB(memberAddressId));
        }

        private MbMemberAddressCB BuildPKCB(int? memberAddressId) {
            AssertObjectNotNull("memberAddressId", memberAddressId);
            MbMemberAddressCB cb = NewMyConditionBean();
            cb.Query().SetMemberAddressId_Equal(memberAddressId);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual MbListResultBean<MbMemberAddress> SelectList(MbMemberAddressCB cb) {
            AssertConditionBeanNotNull(cb);
            return new MbResultBeanBuilder<MbMemberAddress>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual MbPagingResultBean<MbMemberAddress> SelectPage(MbMemberAddressCB cb) {
            AssertConditionBeanNotNull(cb);
            MbPagingInvoker<MbMemberAddress> invoker = new MbPagingInvoker<MbMemberAddress>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : MbPagingHandler<MbMemberAddress> {
            protected MbMemberAddressBhv _bhv; protected MbMemberAddressCB _cb;
            public InternalSelectPagingHandler(MbMemberAddressBhv bhv, MbMemberAddressCB cb) { _bhv = bhv; _cb = cb; }
            public MbPagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<MbMemberAddress> Paging() { return _bhv.SelectList(_cb); }
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
        public IList<MbMember> PulloutMember(IList<MbMemberAddress> memberAddressList) {
            return HelpPulloutInternally<MbMemberAddress, MbMember>(memberAddressList, new MyInternalPulloutMemberCallback());
        }
        protected class MyInternalPulloutMemberCallback : InternalPulloutCallback<MbMemberAddress, MbMember> {
            public MbMember getFr(MbMemberAddress entity) { return entity.Member; }
        }
        #endregion


        // ===============================================================================
        //                                                                   Entity Update
        //                                                                   =============
        #region Basic Entity Update
        public virtual void Insert(MbMemberAddress entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(MbEntity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(MbMemberAddress entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(MbEntity entity) {
            Update(Downcast(entity));
        }

        public virtual void UpdateNonstrict(MbMemberAddress entity) {
            AssertEntityNotNull(entity);
            int updatedCount = this.DelegateUpdateNonstrict(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        public void InsertOrUpdate(MbMemberAddress entity) {
            HelpInsertOrUpdateInternally<MbMemberAddress, MbMemberAddressCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<MbMemberAddress, MbMemberAddressCB> {
            protected MbMemberAddressBhv _bhv;
            public MyInternalInsertOrUpdateCallback(MbMemberAddressBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(MbMemberAddress entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(MbMemberAddress entity) { _bhv.Update(entity); }
            public MbMemberAddressCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(MbMemberAddressCB cb, MbMemberAddress entity) {
                cb.Query().SetMemberAddressId_Equal(entity.MemberAddressId);
            }
            public int CallbackSelectCount(MbMemberAddressCB cb) { return _bhv.SelectCount(cb); }
        }

        public void InsertOrUpdateNonstrict(MbMemberAddress entity) {
            HelpInsertOrUpdateInternally<MbMemberAddress>(entity, new MyInternalInsertOrUpdateNonstrictCallback(this));
        }
        protected class MyInternalInsertOrUpdateNonstrictCallback : InternalInsertOrUpdateNonstrictCallback<MbMemberAddress> {
            protected MbMemberAddressBhv _bhv;
            public MyInternalInsertOrUpdateNonstrictCallback(MbMemberAddressBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(MbMemberAddress entity) { _bhv.Insert(entity); }
            public void CallbackUpdateNonstrict(MbMemberAddress entity) { _bhv.UpdateNonstrict(entity); }
        }

        public virtual void Delete(MbMemberAddress entity) {
            HelpDeleteInternally<MbMemberAddress>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(MbEntity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<MbMemberAddress> {
            protected MbMemberAddressBhv _bhv;
            public MyInternalDeleteCallback(MbMemberAddressBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(MbMemberAddress entity) { return _bhv.DelegateDelete(entity); }
        }

        public virtual void DeleteNonstrict(MbMemberAddress entity) {
            HelpDeleteNonstrictInternally<MbMemberAddress>(entity, new MyInternalDeleteNonstrictCallback(this));
        }
        protected class MyInternalDeleteNonstrictCallback : InternalDeleteNonstrictCallback<MbMemberAddress> {
            protected MbMemberAddressBhv _bhv;
            public MyInternalDeleteNonstrictCallback(MbMemberAddressBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDeleteNonstrict(MbMemberAddress entity) { return _bhv.DelegateDeleteNonstrict(entity); }
        }

        public virtual void DeleteNonstrictIgnoreDeleted(MbMemberAddress entity) {
            HelpDeleteNonstrictIgnoreDeletedInternally<MbMemberAddress>(entity, new MyInternalDeleteNonstrictIgnoreDeletedCallback(this));
        }
        protected class MyInternalDeleteNonstrictIgnoreDeletedCallback : InternalDeleteNonstrictIgnoreDeletedCallback<MbMemberAddress> {
            protected MbMemberAddressBhv _bhv;
            public MyInternalDeleteNonstrictIgnoreDeletedCallback(MbMemberAddressBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDeleteNonstrict(MbMemberAddress entity) { return _bhv.DelegateDeleteNonstrict(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(MbMemberAddress memberAddress, MbMemberAddressCB cb) {
            AssertObjectNotNull("memberAddress", memberAddress); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(memberAddress);
            FilterEntityOfUpdate(memberAddress); AssertEntityOfUpdate(memberAddress);
            return this.Dao.UpdateByQuery(cb, memberAddress);
        }

        public int QueryDelete(MbMemberAddressCB cb) {
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
        protected int DelegateSelectCount(MbMemberAddressCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<MbMemberAddress> DelegateSelectList(MbMemberAddressCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(MbMemberAddress e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(MbMemberAddress e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateModifiedOnly(e); }
        protected int DelegateUpdateNonstrict(MbMemberAddress e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(MbMemberAddress e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.Delete(e); }
        protected int DelegateDeleteNonstrict(MbMemberAddress e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected MbMemberAddress Downcast(MbEntity entity) {
            return (MbMemberAddress)entity;
        }

        protected MbMemberAddressCB Downcast(MbConditionBean cb) {
            return (MbMemberAddressCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual MbMemberAddressDao Dao { get { return _dao; } set { _dao = value; } }
    }
}


using System;
using System.Collections.Generic;

using Seasar.Quill;
using Seasar.Quill.Attrs;

using DfExample.DBFlute.LibraryDb.AllCommon;
using DfExample.DBFlute.LibraryDb.AllCommon.Bhv;
using DfExample.DBFlute.LibraryDb.AllCommon.Bhv.Load;
using DfExample.DBFlute.LibraryDb.AllCommon.Bhv.Setup;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean;
using DfExample.DBFlute.LibraryDb.AllCommon.Dbm;
using DfExample.DBFlute.LibraryDb.AllCommon.Exp;
using DfExample.DBFlute.LibraryDb.BsEntity.Dbm;
using DfExample.DBFlute.LibraryDb.ExDao;
using DfExample.DBFlute.LibraryDb.ExEntity;
using DfExample.DBFlute.LibraryDb.CBean;


namespace DfExample.DBFlute.LibraryDb.ExBhv {

    [Implementation]
    public partial class LdLbUserBhv : DfExample.DBFlute.LibraryDb.AllCommon.Bhv.LdAbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected LdLbUserDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public LdLbUserBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "lb_user"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override LdDBMeta DBMeta { get { return LdLbUserDbm.GetInstance(); } }
        public LdLbUserDbm MyDBMeta { get { return LdLbUserDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override LdEntity NewEntity() { return NewMyEntity(); }
        public override LdConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual LdLbUser NewMyEntity() { return new LdLbUser(); }
        public virtual LdLbUserCB NewMyConditionBean() { return new LdLbUserCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(LdLbUserCB cb) {
            AssertConditionBeanNotNull(cb);
            return this.DelegateSelectCount(cb);
        }

        protected override int DoReadCount(LdConditionBean cb) {
            return SelectCount(Downcast(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                   Entity Select
        //                                                                   =============
        #region Entity Select
        public virtual LdLbUser SelectEntity(LdLbUserCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<LdLbUser> ls = null;
            try {
                ls = this.DelegateSelectList(cb);
            } catch (LdDangerousResultSizeException e) {
                ThrowEntityDuplicatedException("{over safetyMaxResultSize '1'}", cb, e);
                return null; // unreachable
            } finally {
                xrestoreSafetyResult(cb, preSafetyMaxResultSize);
            }
            if (ls.Count == 0) { return null; }
            AssertEntitySelectedAsOne(ls, cb);
            return (LdLbUser)ls[0];
        }

        protected override LdEntity DoReadEntity(LdConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual LdLbUser SelectEntityWithDeletedCheck(LdLbUserCB cb) {
            AssertConditionBeanNotNull(cb);
            LdLbUser entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override LdEntity DoReadEntityWithDeletedCheck(LdConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual LdLbUser SelectByPKValue(int? lbUserId) {
            return SelectEntity(BuildPKCB(lbUserId));
        }

        public virtual LdLbUser SelectByPKValueWithDeletedCheck(int? lbUserId) {
            return SelectEntityWithDeletedCheck(BuildPKCB(lbUserId));
        }

        private LdLbUserCB BuildPKCB(int? lbUserId) {
            AssertObjectNotNull("lbUserId", lbUserId);
            LdLbUserCB cb = NewMyConditionBean();
            cb.Query().SetLbUserId_Equal(lbUserId);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual LdListResultBean<LdLbUser> SelectList(LdLbUserCB cb) {
            AssertConditionBeanNotNull(cb);
            return new LdResultBeanBuilder<LdLbUser>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual LdPagingResultBean<LdLbUser> SelectPage(LdLbUserCB cb) {
            AssertConditionBeanNotNull(cb);
            LdPagingInvoker<LdLbUser> invoker = new LdPagingInvoker<LdLbUser>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : LdPagingHandler<LdLbUser> {
            protected LdLbUserBhv _bhv; protected LdLbUserCB _cb;
            public InternalSelectPagingHandler(LdLbUserBhv bhv, LdLbUserCB cb) { _bhv = bhv; _cb = cb; }
            public LdPagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<LdLbUser> Paging() { return _bhv.SelectList(_cb); }
        }
        #endregion

        // ===============================================================================
        //                                                                   Load Referrer
        //                                                                   =============
        #region Load Referrer
        public virtual void LoadLibraryUserList(LdLbUser lbUser, LdConditionBeanSetupper<LdLibraryUserCB> conditionBeanSetupper) {
            AssertObjectNotNull("lbUser", lbUser); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadLibraryUserList(xnewLRLs<LdLbUser>(lbUser), conditionBeanSetupper);
        }
        public virtual void LoadLibraryUserList(IList<LdLbUser> lbUserList, LdConditionBeanSetupper<LdLibraryUserCB> conditionBeanSetupper) {
            AssertObjectNotNull("lbUserList", lbUserList); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadLibraryUserList(lbUserList, new LdLoadReferrerOption<LdLibraryUserCB, LdLibraryUser>().xinit(conditionBeanSetupper));
        }
        public virtual void LoadLibraryUserList(LdLbUser lbUser, LdLoadReferrerOption<LdLibraryUserCB, LdLibraryUser> loadReferrerOption) {
            AssertObjectNotNull("lbUser", lbUser); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            LoadLibraryUserList(xnewLRLs<LdLbUser>(lbUser), loadReferrerOption);
        }
        public virtual void LoadLibraryUserList(IList<LdLbUser> lbUserList, LdLoadReferrerOption<LdLibraryUserCB, LdLibraryUser> loadReferrerOption) {
            AssertObjectNotNull("lbUserList", lbUserList); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            if (lbUserList.Count == 0) { return; }
            LdLibraryUserBhv referrerBhv = xgetBSFLR().Select<LdLibraryUserBhv>();
            HelpLoadReferrerInternally<LdLbUser, int?, LdLibraryUserCB, LdLibraryUser>
                    (lbUserList, loadReferrerOption, new MyInternalLoadLibraryUserListCallback(referrerBhv));
        }
        protected class MyInternalLoadLibraryUserListCallback : InternalLoadReferrerCallback<LdLbUser, int?, LdLibraryUserCB, LdLibraryUser> {
            protected LdLibraryUserBhv referrerBhv;
            public MyInternalLoadLibraryUserListCallback(LdLibraryUserBhv referrerBhv) { this.referrerBhv = referrerBhv; }
            public int? getPKVal(LdLbUser e) { return e.LbUserId; }
            public void setRfLs(LdLbUser e, IList<LdLibraryUser> ls) { e.LibraryUserList = ls; }
            public LdLibraryUserCB newMyCB() { return referrerBhv.NewMyConditionBean(); }
            public void qyFKIn(LdLibraryUserCB cb, IList<int?> ls) { cb.Query().SetLbUserId_InScope(ls); }
            public void qyOdFKAsc(LdLibraryUserCB cb) { cb.Query().AddOrderBy_LbUserId_Asc(); }
            public void spFKCol(LdLibraryUserCB cb) { cb.Specify().ColumnLbUserId(); }
            public IList<LdLibraryUser> selRfLs(LdLibraryUserCB cb) { return referrerBhv.SelectList(cb); }
            public int? getFKVal(LdLibraryUser e) { return e.LbUserId; }
            public void setlcEt(LdLibraryUser re, LdLbUser be) { re.LbUser = be; }
        }
        #endregion

        // ===============================================================================
        //                                                                Pull out Foreign
        //                                                                ================
        #region Pullout Foreign
        public IList<LdBlackList> PulloutBlackListAsOne(IList<LdLbUser> lbUserList) {
            return HelpPulloutInternally<LdLbUser, LdBlackList>(lbUserList, new MyInternalPulloutBlackListListCallback());
        }
        protected class MyInternalPulloutBlackListListCallback : InternalPulloutCallback<LdLbUser, LdBlackList> {
            public LdBlackList getFr(LdLbUser entity) { return entity.BlackListAsOne; }
        }
        #endregion


        // ===============================================================================
        //                                                                   Entity Update
        //                                                                   =============
        #region Basic Entity Update
        public virtual void Insert(LdLbUser entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(LdEntity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(LdLbUser entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(LdEntity entity) {
            Update(Downcast(entity));
        }

        public virtual void UpdateNonstrict(LdLbUser entity) {
            AssertEntityNotNull(entity);
            int updatedCount = this.DelegateUpdateNonstrict(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        public void InsertOrUpdate(LdLbUser entity) {
            HelpInsertOrUpdateInternally<LdLbUser, LdLbUserCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<LdLbUser, LdLbUserCB> {
            protected LdLbUserBhv _bhv;
            public MyInternalInsertOrUpdateCallback(LdLbUserBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(LdLbUser entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(LdLbUser entity) { _bhv.Update(entity); }
            public LdLbUserCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(LdLbUserCB cb, LdLbUser entity) {
                cb.Query().SetLbUserId_Equal(entity.LbUserId);
            }
            public int CallbackSelectCount(LdLbUserCB cb) { return _bhv.SelectCount(cb); }
        }

        public void InsertOrUpdateNonstrict(LdLbUser entity) {
            HelpInsertOrUpdateInternally<LdLbUser>(entity, new MyInternalInsertOrUpdateNonstrictCallback(this));
        }
        protected class MyInternalInsertOrUpdateNonstrictCallback : InternalInsertOrUpdateNonstrictCallback<LdLbUser> {
            protected LdLbUserBhv _bhv;
            public MyInternalInsertOrUpdateNonstrictCallback(LdLbUserBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(LdLbUser entity) { _bhv.Insert(entity); }
            public void CallbackUpdateNonstrict(LdLbUser entity) { _bhv.UpdateNonstrict(entity); }
        }

        public virtual void Delete(LdLbUser entity) {
            HelpDeleteInternally<LdLbUser>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(LdEntity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<LdLbUser> {
            protected LdLbUserBhv _bhv;
            public MyInternalDeleteCallback(LdLbUserBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(LdLbUser entity) { return _bhv.DelegateDelete(entity); }
        }

        public virtual void DeleteNonstrict(LdLbUser entity) {
            HelpDeleteNonstrictInternally<LdLbUser>(entity, new MyInternalDeleteNonstrictCallback(this));
        }
        protected class MyInternalDeleteNonstrictCallback : InternalDeleteNonstrictCallback<LdLbUser> {
            protected LdLbUserBhv _bhv;
            public MyInternalDeleteNonstrictCallback(LdLbUserBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDeleteNonstrict(LdLbUser entity) { return _bhv.DelegateDeleteNonstrict(entity); }
        }

        public virtual void DeleteNonstrictIgnoreDeleted(LdLbUser entity) {
            HelpDeleteNonstrictIgnoreDeletedInternally<LdLbUser>(entity, new MyInternalDeleteNonstrictIgnoreDeletedCallback(this));
        }
        protected class MyInternalDeleteNonstrictIgnoreDeletedCallback : InternalDeleteNonstrictIgnoreDeletedCallback<LdLbUser> {
            protected LdLbUserBhv _bhv;
            public MyInternalDeleteNonstrictIgnoreDeletedCallback(LdLbUserBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDeleteNonstrict(LdLbUser entity) { return _bhv.DelegateDeleteNonstrict(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(LdLbUser lbUser, LdLbUserCB cb) {
            AssertObjectNotNull("lbUser", lbUser); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(lbUser);
            FilterEntityOfUpdate(lbUser); AssertEntityOfUpdate(lbUser);
            return this.Dao.UpdateByQuery(cb, lbUser);
        }

        public int QueryDelete(LdLbUserCB cb) {
            AssertConditionBeanNotNull(cb);
            return this.Dao.DeleteByQuery(cb);
        }

        // ===============================================================================
        //                                                            Optimistic Lock Info
        //                                                            ====================
        protected override bool HasVersionNoValue(LdEntity entity) {
            return false;
        }

        protected override bool HasUpdateDateValue(LdEntity entity) {
            return Downcast(entity).UTimestamp != null;
        }

        // ===============================================================================
        //                                                                 Delegate Method
        //                                                                 ===============
        #region Delegate Method
        protected int DelegateSelectCount(LdLbUserCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<LdLbUser> DelegateSelectList(LdLbUserCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(LdLbUser e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(LdLbUser e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateModifiedOnly(e); }
        protected int DelegateUpdateNonstrict(LdLbUser e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(LdLbUser e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.Delete(e); }
        protected int DelegateDeleteNonstrict(LdLbUser e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected LdLbUser Downcast(LdEntity entity) {
            return (LdLbUser)entity;
        }

        protected LdLbUserCB Downcast(LdConditionBean cb) {
            return (LdLbUserCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual LdLbUserDao Dao { get { return _dao; } set { _dao = value; } }
    }
}


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
    public partial class LdBlackActionLookupBhv : DfExample.DBFlute.LibraryDb.AllCommon.Bhv.LdAbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected LdBlackActionLookupDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public LdBlackActionLookupBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "black_action_lookup"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override LdDBMeta DBMeta { get { return LdBlackActionLookupDbm.GetInstance(); } }
        public LdBlackActionLookupDbm MyDBMeta { get { return LdBlackActionLookupDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override LdEntity NewEntity() { return NewMyEntity(); }
        public override LdConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual LdBlackActionLookup NewMyEntity() { return new LdBlackActionLookup(); }
        public virtual LdBlackActionLookupCB NewMyConditionBean() { return new LdBlackActionLookupCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(LdBlackActionLookupCB cb) {
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
        public virtual LdBlackActionLookup SelectEntity(LdBlackActionLookupCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<LdBlackActionLookup> ls = null;
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
            return (LdBlackActionLookup)ls[0];
        }

        protected override LdEntity DoReadEntity(LdConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual LdBlackActionLookup SelectEntityWithDeletedCheck(LdBlackActionLookupCB cb) {
            AssertConditionBeanNotNull(cb);
            LdBlackActionLookup entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override LdEntity DoReadEntityWithDeletedCheck(LdConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual LdBlackActionLookup SelectByPKValue(String blackActionCode) {
            return SelectEntity(BuildPKCB(blackActionCode));
        }

        public virtual LdBlackActionLookup SelectByPKValueWithDeletedCheck(String blackActionCode) {
            return SelectEntityWithDeletedCheck(BuildPKCB(blackActionCode));
        }

        private LdBlackActionLookupCB BuildPKCB(String blackActionCode) {
            AssertObjectNotNull("blackActionCode", blackActionCode);
            LdBlackActionLookupCB cb = NewMyConditionBean();
            cb.Query().SetBlackActionCode_Equal(blackActionCode);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual LdListResultBean<LdBlackActionLookup> SelectList(LdBlackActionLookupCB cb) {
            AssertConditionBeanNotNull(cb);
            return new LdResultBeanBuilder<LdBlackActionLookup>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual LdPagingResultBean<LdBlackActionLookup> SelectPage(LdBlackActionLookupCB cb) {
            AssertConditionBeanNotNull(cb);
            LdPagingInvoker<LdBlackActionLookup> invoker = new LdPagingInvoker<LdBlackActionLookup>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : LdPagingHandler<LdBlackActionLookup> {
            protected LdBlackActionLookupBhv _bhv; protected LdBlackActionLookupCB _cb;
            public InternalSelectPagingHandler(LdBlackActionLookupBhv bhv, LdBlackActionLookupCB cb) { _bhv = bhv; _cb = cb; }
            public LdPagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<LdBlackActionLookup> Paging() { return _bhv.SelectList(_cb); }
        }
        #endregion

        // ===============================================================================
        //                                                                   Load Referrer
        //                                                                   =============
        #region Load Referrer
        public virtual void LoadBlackActionList(LdBlackActionLookup blackActionLookup, LdConditionBeanSetupper<LdBlackActionCB> conditionBeanSetupper) {
            AssertObjectNotNull("blackActionLookup", blackActionLookup); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadBlackActionList(xnewLRLs<LdBlackActionLookup>(blackActionLookup), conditionBeanSetupper);
        }
        public virtual void LoadBlackActionList(IList<LdBlackActionLookup> blackActionLookupList, LdConditionBeanSetupper<LdBlackActionCB> conditionBeanSetupper) {
            AssertObjectNotNull("blackActionLookupList", blackActionLookupList); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadBlackActionList(blackActionLookupList, new LdLoadReferrerOption<LdBlackActionCB, LdBlackAction>().xinit(conditionBeanSetupper));
        }
        public virtual void LoadBlackActionList(LdBlackActionLookup blackActionLookup, LdLoadReferrerOption<LdBlackActionCB, LdBlackAction> loadReferrerOption) {
            AssertObjectNotNull("blackActionLookup", blackActionLookup); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            LoadBlackActionList(xnewLRLs<LdBlackActionLookup>(blackActionLookup), loadReferrerOption);
        }
        public virtual void LoadBlackActionList(IList<LdBlackActionLookup> blackActionLookupList, LdLoadReferrerOption<LdBlackActionCB, LdBlackAction> loadReferrerOption) {
            AssertObjectNotNull("blackActionLookupList", blackActionLookupList); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            if (blackActionLookupList.Count == 0) { return; }
            LdBlackActionBhv referrerBhv = xgetBSFLR().Select<LdBlackActionBhv>();
            HelpLoadReferrerInternally<LdBlackActionLookup, String, LdBlackActionCB, LdBlackAction>
                    (blackActionLookupList, loadReferrerOption, new MyInternalLoadBlackActionListCallback(referrerBhv));
        }
        protected class MyInternalLoadBlackActionListCallback : InternalLoadReferrerCallback<LdBlackActionLookup, String, LdBlackActionCB, LdBlackAction> {
            protected LdBlackActionBhv referrerBhv;
            public MyInternalLoadBlackActionListCallback(LdBlackActionBhv referrerBhv) { this.referrerBhv = referrerBhv; }
            public String getPKVal(LdBlackActionLookup e) { return e.BlackActionCode; }
            public void setRfLs(LdBlackActionLookup e, IList<LdBlackAction> ls) { e.BlackActionList = ls; }
            public LdBlackActionCB newMyCB() { return referrerBhv.NewMyConditionBean(); }
            public void qyFKIn(LdBlackActionCB cb, IList<String> ls) { cb.Query().SetBlackActionCode_InScope(ls); }
            public void qyOdFKAsc(LdBlackActionCB cb) { cb.Query().AddOrderBy_BlackActionCode_Asc(); }
            public void spFKCol(LdBlackActionCB cb) { cb.Specify().ColumnBlackActionCode(); }
            public IList<LdBlackAction> selRfLs(LdBlackActionCB cb) { return referrerBhv.SelectList(cb); }
            public String getFKVal(LdBlackAction e) { return e.BlackActionCode; }
            public void setlcEt(LdBlackAction re, LdBlackActionLookup be) { re.BlackActionLookup = be; }
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
        public virtual void Insert(LdBlackActionLookup entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(LdEntity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(LdBlackActionLookup entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(LdEntity entity) {
            Update(Downcast(entity));
        }

        public virtual void UpdateNonstrict(LdBlackActionLookup entity) {
            AssertEntityNotNull(entity);
            int updatedCount = this.DelegateUpdateNonstrict(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        public void InsertOrUpdate(LdBlackActionLookup entity) {
            HelpInsertOrUpdateInternally<LdBlackActionLookup, LdBlackActionLookupCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<LdBlackActionLookup, LdBlackActionLookupCB> {
            protected LdBlackActionLookupBhv _bhv;
            public MyInternalInsertOrUpdateCallback(LdBlackActionLookupBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(LdBlackActionLookup entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(LdBlackActionLookup entity) { _bhv.Update(entity); }
            public LdBlackActionLookupCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(LdBlackActionLookupCB cb, LdBlackActionLookup entity) {
                cb.Query().SetBlackActionCode_Equal(entity.BlackActionCode);
            }
            public int CallbackSelectCount(LdBlackActionLookupCB cb) { return _bhv.SelectCount(cb); }
        }

        public void InsertOrUpdateNonstrict(LdBlackActionLookup entity) {
            HelpInsertOrUpdateInternally<LdBlackActionLookup>(entity, new MyInternalInsertOrUpdateNonstrictCallback(this));
        }
        protected class MyInternalInsertOrUpdateNonstrictCallback : InternalInsertOrUpdateNonstrictCallback<LdBlackActionLookup> {
            protected LdBlackActionLookupBhv _bhv;
            public MyInternalInsertOrUpdateNonstrictCallback(LdBlackActionLookupBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(LdBlackActionLookup entity) { _bhv.Insert(entity); }
            public void CallbackUpdateNonstrict(LdBlackActionLookup entity) { _bhv.UpdateNonstrict(entity); }
        }

        public virtual void Delete(LdBlackActionLookup entity) {
            HelpDeleteInternally<LdBlackActionLookup>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(LdEntity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<LdBlackActionLookup> {
            protected LdBlackActionLookupBhv _bhv;
            public MyInternalDeleteCallback(LdBlackActionLookupBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(LdBlackActionLookup entity) { return _bhv.DelegateDelete(entity); }
        }

        public virtual void DeleteNonstrict(LdBlackActionLookup entity) {
            HelpDeleteNonstrictInternally<LdBlackActionLookup>(entity, new MyInternalDeleteNonstrictCallback(this));
        }
        protected class MyInternalDeleteNonstrictCallback : InternalDeleteNonstrictCallback<LdBlackActionLookup> {
            protected LdBlackActionLookupBhv _bhv;
            public MyInternalDeleteNonstrictCallback(LdBlackActionLookupBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDeleteNonstrict(LdBlackActionLookup entity) { return _bhv.DelegateDeleteNonstrict(entity); }
        }

        public virtual void DeleteNonstrictIgnoreDeleted(LdBlackActionLookup entity) {
            HelpDeleteNonstrictIgnoreDeletedInternally<LdBlackActionLookup>(entity, new MyInternalDeleteNonstrictIgnoreDeletedCallback(this));
        }
        protected class MyInternalDeleteNonstrictIgnoreDeletedCallback : InternalDeleteNonstrictIgnoreDeletedCallback<LdBlackActionLookup> {
            protected LdBlackActionLookupBhv _bhv;
            public MyInternalDeleteNonstrictIgnoreDeletedCallback(LdBlackActionLookupBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDeleteNonstrict(LdBlackActionLookup entity) { return _bhv.DelegateDeleteNonstrict(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(LdBlackActionLookup blackActionLookup, LdBlackActionLookupCB cb) {
            AssertObjectNotNull("blackActionLookup", blackActionLookup); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(blackActionLookup);
            FilterEntityOfUpdate(blackActionLookup); AssertEntityOfUpdate(blackActionLookup);
            return this.Dao.UpdateByQuery(cb, blackActionLookup);
        }

        public int QueryDelete(LdBlackActionLookupCB cb) {
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
        protected int DelegateSelectCount(LdBlackActionLookupCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<LdBlackActionLookup> DelegateSelectList(LdBlackActionLookupCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(LdBlackActionLookup e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(LdBlackActionLookup e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateModifiedOnly(e); }
        protected int DelegateUpdateNonstrict(LdBlackActionLookup e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(LdBlackActionLookup e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.Delete(e); }
        protected int DelegateDeleteNonstrict(LdBlackActionLookup e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected LdBlackActionLookup Downcast(LdEntity entity) {
            return (LdBlackActionLookup)entity;
        }

        protected LdBlackActionLookupCB Downcast(LdConditionBean cb) {
            return (LdBlackActionLookupCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual LdBlackActionLookupDao Dao { get { return _dao; } set { _dao = value; } }
    }
}

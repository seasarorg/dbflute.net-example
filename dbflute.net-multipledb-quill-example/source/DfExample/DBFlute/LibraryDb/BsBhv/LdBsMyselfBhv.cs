
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
    public partial class LdMyselfBhv : DfExample.DBFlute.LibraryDb.AllCommon.Bhv.LdAbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected LdMyselfDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public LdMyselfBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "myself"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override LdDBMeta DBMeta { get { return LdMyselfDbm.GetInstance(); } }
        public LdMyselfDbm MyDBMeta { get { return LdMyselfDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override LdEntity NewEntity() { return NewMyEntity(); }
        public override LdConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual LdMyself NewMyEntity() { return new LdMyself(); }
        public virtual LdMyselfCB NewMyConditionBean() { return new LdMyselfCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(LdMyselfCB cb) {
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
        public virtual LdMyself SelectEntity(LdMyselfCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<LdMyself> ls = null;
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
            return (LdMyself)ls[0];
        }

        protected override LdEntity DoReadEntity(LdConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual LdMyself SelectEntityWithDeletedCheck(LdMyselfCB cb) {
            AssertConditionBeanNotNull(cb);
            LdMyself entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override LdEntity DoReadEntityWithDeletedCheck(LdConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual LdMyself SelectByPKValue(int? myselfId) {
            return SelectEntity(BuildPKCB(myselfId));
        }

        public virtual LdMyself SelectByPKValueWithDeletedCheck(int? myselfId) {
            return SelectEntityWithDeletedCheck(BuildPKCB(myselfId));
        }

        private LdMyselfCB BuildPKCB(int? myselfId) {
            AssertObjectNotNull("myselfId", myselfId);
            LdMyselfCB cb = NewMyConditionBean();
            cb.Query().SetMyselfId_Equal(myselfId);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual LdListResultBean<LdMyself> SelectList(LdMyselfCB cb) {
            AssertConditionBeanNotNull(cb);
            return new LdResultBeanBuilder<LdMyself>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual LdPagingResultBean<LdMyself> SelectPage(LdMyselfCB cb) {
            AssertConditionBeanNotNull(cb);
            LdPagingInvoker<LdMyself> invoker = new LdPagingInvoker<LdMyself>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : LdPagingHandler<LdMyself> {
            protected LdMyselfBhv _bhv; protected LdMyselfCB _cb;
            public InternalSelectPagingHandler(LdMyselfBhv bhv, LdMyselfCB cb) { _bhv = bhv; _cb = cb; }
            public LdPagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<LdMyself> Paging() { return _bhv.SelectList(_cb); }
        }
        #endregion

        // ===============================================================================
        //                                                                   Load Referrer
        //                                                                   =============
        #region Load Referrer
        public virtual void LoadMyselfCheckList(LdMyself myself, LdConditionBeanSetupper<LdMyselfCheckCB> conditionBeanSetupper) {
            AssertObjectNotNull("myself", myself); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadMyselfCheckList(xnewLRLs<LdMyself>(myself), conditionBeanSetupper);
        }
        public virtual void LoadMyselfCheckList(IList<LdMyself> myselfList, LdConditionBeanSetupper<LdMyselfCheckCB> conditionBeanSetupper) {
            AssertObjectNotNull("myselfList", myselfList); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadMyselfCheckList(myselfList, new LdLoadReferrerOption<LdMyselfCheckCB, LdMyselfCheck>().xinit(conditionBeanSetupper));
        }
        public virtual void LoadMyselfCheckList(LdMyself myself, LdLoadReferrerOption<LdMyselfCheckCB, LdMyselfCheck> loadReferrerOption) {
            AssertObjectNotNull("myself", myself); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            LoadMyselfCheckList(xnewLRLs<LdMyself>(myself), loadReferrerOption);
        }
        public virtual void LoadMyselfCheckList(IList<LdMyself> myselfList, LdLoadReferrerOption<LdMyselfCheckCB, LdMyselfCheck> loadReferrerOption) {
            AssertObjectNotNull("myselfList", myselfList); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            if (myselfList.Count == 0) { return; }
            LdMyselfCheckBhv referrerBhv = xgetBSFLR().Select<LdMyselfCheckBhv>();
            HelpLoadReferrerInternally<LdMyself, int?, LdMyselfCheckCB, LdMyselfCheck>
                    (myselfList, loadReferrerOption, new MyInternalLoadMyselfCheckListCallback(referrerBhv));
        }
        protected class MyInternalLoadMyselfCheckListCallback : InternalLoadReferrerCallback<LdMyself, int?, LdMyselfCheckCB, LdMyselfCheck> {
            protected LdMyselfCheckBhv referrerBhv;
            public MyInternalLoadMyselfCheckListCallback(LdMyselfCheckBhv referrerBhv) { this.referrerBhv = referrerBhv; }
            public int? getPKVal(LdMyself e) { return e.MyselfId; }
            public void setRfLs(LdMyself e, IList<LdMyselfCheck> ls) { e.MyselfCheckList = ls; }
            public LdMyselfCheckCB newMyCB() { return referrerBhv.NewMyConditionBean(); }
            public void qyFKIn(LdMyselfCheckCB cb, IList<int?> ls) { cb.Query().SetMyselfId_InScope(ls); }
            public void qyOdFKAsc(LdMyselfCheckCB cb) { cb.Query().AddOrderBy_MyselfId_Asc(); }
            public void spFKCol(LdMyselfCheckCB cb) { cb.Specify().ColumnMyselfId(); }
            public IList<LdMyselfCheck> selRfLs(LdMyselfCheckCB cb) { return referrerBhv.SelectList(cb); }
            public int? getFKVal(LdMyselfCheck e) { return e.MyselfId; }
            public void setlcEt(LdMyselfCheck re, LdMyself be) { re.Myself = be; }
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
        public virtual void Insert(LdMyself entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(LdEntity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(LdMyself entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(LdEntity entity) {
            Update(Downcast(entity));
        }

        public void InsertOrUpdate(LdMyself entity) {
            HelpInsertOrUpdateInternally<LdMyself, LdMyselfCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<LdMyself, LdMyselfCB> {
            protected LdMyselfBhv _bhv;
            public MyInternalInsertOrUpdateCallback(LdMyselfBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(LdMyself entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(LdMyself entity) { _bhv.Update(entity); }
            public LdMyselfCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(LdMyselfCB cb, LdMyself entity) {
                cb.Query().SetMyselfId_Equal(entity.MyselfId);
            }
            public int CallbackSelectCount(LdMyselfCB cb) { return _bhv.SelectCount(cb); }
        }

        public virtual void Delete(LdMyself entity) {
            HelpDeleteInternally<LdMyself>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(LdEntity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<LdMyself> {
            protected LdMyselfBhv _bhv;
            public MyInternalDeleteCallback(LdMyselfBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(LdMyself entity) { return _bhv.DelegateDelete(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(LdMyself myself, LdMyselfCB cb) {
            AssertObjectNotNull("myself", myself); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(myself);
            FilterEntityOfUpdate(myself); AssertEntityOfUpdate(myself);
            return this.Dao.UpdateByQuery(cb, myself);
        }

        public int QueryDelete(LdMyselfCB cb) {
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
            return false;
        }

        // ===============================================================================
        //                                                                 Delegate Method
        //                                                                 ===============
        #region Delegate Method
        protected int DelegateSelectCount(LdMyselfCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<LdMyself> DelegateSelectList(LdMyselfCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(LdMyself e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(LdMyself e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(LdMyself e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected LdMyself Downcast(LdEntity entity) {
            return (LdMyself)entity;
        }

        protected LdMyselfCB Downcast(LdConditionBean cb) {
            return (LdMyselfCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual LdMyselfDao Dao { get { return _dao; } set { _dao = value; } }
    }
}


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
    public partial class WhiteMyselfBhv : DfExample.DBFlute.AllCommon.Bhv.AbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected WhiteMyselfDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public WhiteMyselfBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "white_myself"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override DBMeta DBMeta { get { return WhiteMyselfDbm.GetInstance(); } }
        public WhiteMyselfDbm MyDBMeta { get { return WhiteMyselfDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override Entity NewEntity() { return NewMyEntity(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual WhiteMyself NewMyEntity() { return new WhiteMyself(); }
        public virtual WhiteMyselfCB NewMyConditionBean() { return new WhiteMyselfCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(WhiteMyselfCB cb) {
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
        public virtual WhiteMyself SelectEntity(WhiteMyselfCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<WhiteMyself> ls = null;
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
            return (WhiteMyself)ls[0];
        }

        protected override Entity DoReadEntity(ConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual WhiteMyself SelectEntityWithDeletedCheck(WhiteMyselfCB cb) {
            AssertConditionBeanNotNull(cb);
            WhiteMyself entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override Entity DoReadEntityWithDeletedCheck(ConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual WhiteMyself SelectByPKValue(int? myselfId) {
            return SelectEntity(BuildPKCB(myselfId));
        }

        public virtual WhiteMyself SelectByPKValueWithDeletedCheck(int? myselfId) {
            return SelectEntityWithDeletedCheck(BuildPKCB(myselfId));
        }

        private WhiteMyselfCB BuildPKCB(int? myselfId) {
            AssertObjectNotNull("myselfId", myselfId);
            WhiteMyselfCB cb = NewMyConditionBean();
            cb.Query().SetMyselfId_Equal(myselfId);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual ListResultBean<WhiteMyself> SelectList(WhiteMyselfCB cb) {
            AssertConditionBeanNotNull(cb);
            return new ResultBeanBuilder<WhiteMyself>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual PagingResultBean<WhiteMyself> SelectPage(WhiteMyselfCB cb) {
            AssertConditionBeanNotNull(cb);
            PagingInvoker<WhiteMyself> invoker = new PagingInvoker<WhiteMyself>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : PagingHandler<WhiteMyself> {
            protected WhiteMyselfBhv _bhv; protected WhiteMyselfCB _cb;
            public InternalSelectPagingHandler(WhiteMyselfBhv bhv, WhiteMyselfCB cb) { _bhv = bhv; _cb = cb; }
            public PagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<WhiteMyself> Paging() { return _bhv.SelectList(_cb); }
        }
        #endregion

        // ===============================================================================
        //                                                                   Load Referrer
        //                                                                   =============
        #region Load Referrer
        public virtual void LoadWhiteMyselfCheckList(WhiteMyself whiteMyself, ConditionBeanSetupper<WhiteMyselfCheckCB> conditionBeanSetupper) {
            AssertObjectNotNull("whiteMyself", whiteMyself); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadWhiteMyselfCheckList(xnewLRLs<WhiteMyself>(whiteMyself), conditionBeanSetupper);
        }
        public virtual void LoadWhiteMyselfCheckList(IList<WhiteMyself> whiteMyselfList, ConditionBeanSetupper<WhiteMyselfCheckCB> conditionBeanSetupper) {
            AssertObjectNotNull("whiteMyselfList", whiteMyselfList); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadWhiteMyselfCheckList(whiteMyselfList, new LoadReferrerOption<WhiteMyselfCheckCB, WhiteMyselfCheck>().xinit(conditionBeanSetupper));
        }
        public virtual void LoadWhiteMyselfCheckList(WhiteMyself whiteMyself, LoadReferrerOption<WhiteMyselfCheckCB, WhiteMyselfCheck> loadReferrerOption) {
            AssertObjectNotNull("whiteMyself", whiteMyself); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            LoadWhiteMyselfCheckList(xnewLRLs<WhiteMyself>(whiteMyself), loadReferrerOption);
        }
        public virtual void LoadWhiteMyselfCheckList(IList<WhiteMyself> whiteMyselfList, LoadReferrerOption<WhiteMyselfCheckCB, WhiteMyselfCheck> loadReferrerOption) {
            AssertObjectNotNull("whiteMyselfList", whiteMyselfList); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            if (whiteMyselfList.Count == 0) { return; }
            WhiteMyselfCheckBhv referrerBhv = xgetBSFLR().Select<WhiteMyselfCheckBhv>();
            HelpLoadReferrerInternally<WhiteMyself, int?, WhiteMyselfCheckCB, WhiteMyselfCheck>
                    (whiteMyselfList, loadReferrerOption, new MyInternalLoadWhiteMyselfCheckListCallback(referrerBhv));
        }
        protected class MyInternalLoadWhiteMyselfCheckListCallback : InternalLoadReferrerCallback<WhiteMyself, int?, WhiteMyselfCheckCB, WhiteMyselfCheck> {
            protected WhiteMyselfCheckBhv referrerBhv;
            public MyInternalLoadWhiteMyselfCheckListCallback(WhiteMyselfCheckBhv referrerBhv) { this.referrerBhv = referrerBhv; }
            public int? getPKVal(WhiteMyself e) { return e.MyselfId; }
            public void setRfLs(WhiteMyself e, IList<WhiteMyselfCheck> ls) { e.WhiteMyselfCheckList = ls; }
            public WhiteMyselfCheckCB newMyCB() { return referrerBhv.NewMyConditionBean(); }
            public void qyFKIn(WhiteMyselfCheckCB cb, IList<int?> ls) { cb.Query().SetMyselfId_InScope(ls); }
            public void qyOdFKAsc(WhiteMyselfCheckCB cb) { cb.Query().AddOrderBy_MyselfId_Asc(); }
            public void spFKCol(WhiteMyselfCheckCB cb) { cb.Specify().ColumnMyselfId(); }
            public IList<WhiteMyselfCheck> selRfLs(WhiteMyselfCheckCB cb) { return referrerBhv.SelectList(cb); }
            public int? getFKVal(WhiteMyselfCheck e) { return e.MyselfId; }
            public void setlcEt(WhiteMyselfCheck re, WhiteMyself be) { re.WhiteMyself = be; }
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
        public virtual void Insert(WhiteMyself entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(Entity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(WhiteMyself entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(Entity entity) {
            Update(Downcast(entity));
        }

        public void InsertOrUpdate(WhiteMyself entity) {
            HelpInsertOrUpdateInternally<WhiteMyself, WhiteMyselfCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<WhiteMyself, WhiteMyselfCB> {
            protected WhiteMyselfBhv _bhv;
            public MyInternalInsertOrUpdateCallback(WhiteMyselfBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(WhiteMyself entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(WhiteMyself entity) { _bhv.Update(entity); }
            public WhiteMyselfCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(WhiteMyselfCB cb, WhiteMyself entity) {
                cb.Query().SetMyselfId_Equal(entity.MyselfId);
            }
            public int CallbackSelectCount(WhiteMyselfCB cb) { return _bhv.SelectCount(cb); }
        }

        public virtual void Delete(WhiteMyself entity) {
            HelpDeleteInternally<WhiteMyself>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(Entity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<WhiteMyself> {
            protected WhiteMyselfBhv _bhv;
            public MyInternalDeleteCallback(WhiteMyselfBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(WhiteMyself entity) { return _bhv.DelegateDelete(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(WhiteMyself whiteMyself, WhiteMyselfCB cb) {
            AssertObjectNotNull("whiteMyself", whiteMyself); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(whiteMyself);
            FilterEntityOfUpdate(whiteMyself); AssertEntityOfUpdate(whiteMyself);
            return this.Dao.UpdateByQuery(cb, whiteMyself);
        }

        public int QueryDelete(WhiteMyselfCB cb) {
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
        protected int DelegateSelectCount(WhiteMyselfCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<WhiteMyself> DelegateSelectList(WhiteMyselfCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(WhiteMyself e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(WhiteMyself e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(WhiteMyself e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected WhiteMyself Downcast(Entity entity) {
            return (WhiteMyself)entity;
        }

        protected WhiteMyselfCB Downcast(ConditionBean cb) {
            return (WhiteMyselfCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual WhiteMyselfDao Dao { get { return _dao; } set { _dao = value; } }
    }
}

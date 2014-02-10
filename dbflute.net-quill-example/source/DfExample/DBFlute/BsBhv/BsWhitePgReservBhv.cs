
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
    public partial class WhitePgReservBhv : DfExample.DBFlute.AllCommon.Bhv.AbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected WhitePgReservDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public WhitePgReservBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "white_pg_reserv"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override DBMeta DBMeta { get { return WhitePgReservDbm.GetInstance(); } }
        public WhitePgReservDbm MyDBMeta { get { return WhitePgReservDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override Entity NewEntity() { return NewMyEntity(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual WhitePgReserv NewMyEntity() { return new WhitePgReserv(); }
        public virtual WhitePgReservCB NewMyConditionBean() { return new WhitePgReservCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(WhitePgReservCB cb) {
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
        public virtual WhitePgReserv SelectEntity(WhitePgReservCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<WhitePgReserv> ls = null;
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
            return (WhitePgReserv)ls[0];
        }

        protected override Entity DoReadEntity(ConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual WhitePgReserv SelectEntityWithDeletedCheck(WhitePgReservCB cb) {
            AssertConditionBeanNotNull(cb);
            WhitePgReserv entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override Entity DoReadEntityWithDeletedCheck(ConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual WhitePgReserv SelectByPKValue(int? classSynonym) {
            return SelectEntity(BuildPKCB(classSynonym));
        }

        public virtual WhitePgReserv SelectByPKValueWithDeletedCheck(int? classSynonym) {
            return SelectEntityWithDeletedCheck(BuildPKCB(classSynonym));
        }

        private WhitePgReservCB BuildPKCB(int? classSynonym) {
            AssertObjectNotNull("classSynonym", classSynonym);
            WhitePgReservCB cb = NewMyConditionBean();
            cb.Query().SetClassSynonym_Equal(classSynonym);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual ListResultBean<WhitePgReserv> SelectList(WhitePgReservCB cb) {
            AssertConditionBeanNotNull(cb);
            return new ResultBeanBuilder<WhitePgReserv>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual PagingResultBean<WhitePgReserv> SelectPage(WhitePgReservCB cb) {
            AssertConditionBeanNotNull(cb);
            PagingInvoker<WhitePgReserv> invoker = new PagingInvoker<WhitePgReserv>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : PagingHandler<WhitePgReserv> {
            protected WhitePgReservBhv _bhv; protected WhitePgReservCB _cb;
            public InternalSelectPagingHandler(WhitePgReservBhv bhv, WhitePgReservCB cb) { _bhv = bhv; _cb = cb; }
            public PagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<WhitePgReserv> Paging() { return _bhv.SelectList(_cb); }
        }
        #endregion

        // ===============================================================================
        //                                                                   Load Referrer
        //                                                                   =============
        #region Load Referrer
        public virtual void LoadWhitePgReservRefList(WhitePgReserv whitePgReserv, ConditionBeanSetupper<WhitePgReservRefCB> conditionBeanSetupper) {
            AssertObjectNotNull("whitePgReserv", whitePgReserv); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadWhitePgReservRefList(xnewLRLs<WhitePgReserv>(whitePgReserv), conditionBeanSetupper);
        }
        public virtual void LoadWhitePgReservRefList(IList<WhitePgReserv> whitePgReservList, ConditionBeanSetupper<WhitePgReservRefCB> conditionBeanSetupper) {
            AssertObjectNotNull("whitePgReservList", whitePgReservList); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadWhitePgReservRefList(whitePgReservList, new LoadReferrerOption<WhitePgReservRefCB, WhitePgReservRef>().xinit(conditionBeanSetupper));
        }
        public virtual void LoadWhitePgReservRefList(WhitePgReserv whitePgReserv, LoadReferrerOption<WhitePgReservRefCB, WhitePgReservRef> loadReferrerOption) {
            AssertObjectNotNull("whitePgReserv", whitePgReserv); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            LoadWhitePgReservRefList(xnewLRLs<WhitePgReserv>(whitePgReserv), loadReferrerOption);
        }
        public virtual void LoadWhitePgReservRefList(IList<WhitePgReserv> whitePgReservList, LoadReferrerOption<WhitePgReservRefCB, WhitePgReservRef> loadReferrerOption) {
            AssertObjectNotNull("whitePgReservList", whitePgReservList); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            if (whitePgReservList.Count == 0) { return; }
            WhitePgReservRefBhv referrerBhv = xgetBSFLR().Select<WhitePgReservRefBhv>();
            HelpLoadReferrerInternally<WhitePgReserv, int?, WhitePgReservRefCB, WhitePgReservRef>
                    (whitePgReservList, loadReferrerOption, new MyInternalLoadWhitePgReservRefListCallback(referrerBhv));
        }
        protected class MyInternalLoadWhitePgReservRefListCallback : InternalLoadReferrerCallback<WhitePgReserv, int?, WhitePgReservRefCB, WhitePgReservRef> {
            protected WhitePgReservRefBhv referrerBhv;
            public MyInternalLoadWhitePgReservRefListCallback(WhitePgReservRefBhv referrerBhv) { this.referrerBhv = referrerBhv; }
            public int? getPKVal(WhitePgReserv e) { return e.ClassSynonym; }
            public void setRfLs(WhitePgReserv e, IList<WhitePgReservRef> ls) { e.WhitePgReservRefList = ls; }
            public WhitePgReservRefCB newMyCB() { return referrerBhv.NewMyConditionBean(); }
            public void qyFKIn(WhitePgReservRefCB cb, IList<int?> ls) { cb.Query().SetClassSynonym_InScope(ls); }
            public void qyOdFKAsc(WhitePgReservRefCB cb) { cb.Query().AddOrderBy_ClassSynonym_Asc(); }
            public void spFKCol(WhitePgReservRefCB cb) { cb.Specify().ColumnClassSynonym(); }
            public IList<WhitePgReservRef> selRfLs(WhitePgReservRefCB cb) { return referrerBhv.SelectList(cb); }
            public int? getFKVal(WhitePgReservRef e) { return e.ClassSynonym; }
            public void setlcEt(WhitePgReservRef re, WhitePgReserv be) { re.WhitePgReserv = be; }
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
        public virtual void Insert(WhitePgReserv entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(Entity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(WhitePgReserv entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(Entity entity) {
            Update(Downcast(entity));
        }

        public void InsertOrUpdate(WhitePgReserv entity) {
            HelpInsertOrUpdateInternally<WhitePgReserv, WhitePgReservCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<WhitePgReserv, WhitePgReservCB> {
            protected WhitePgReservBhv _bhv;
            public MyInternalInsertOrUpdateCallback(WhitePgReservBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(WhitePgReserv entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(WhitePgReserv entity) { _bhv.Update(entity); }
            public WhitePgReservCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(WhitePgReservCB cb, WhitePgReserv entity) {
                cb.Query().SetClassSynonym_Equal(entity.ClassSynonym);
            }
            public int CallbackSelectCount(WhitePgReservCB cb) { return _bhv.SelectCount(cb); }
        }

        public virtual void Delete(WhitePgReserv entity) {
            HelpDeleteInternally<WhitePgReserv>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(Entity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<WhitePgReserv> {
            protected WhitePgReservBhv _bhv;
            public MyInternalDeleteCallback(WhitePgReservBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(WhitePgReserv entity) { return _bhv.DelegateDelete(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(WhitePgReserv whitePgReserv, WhitePgReservCB cb) {
            AssertObjectNotNull("whitePgReserv", whitePgReserv); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(whitePgReserv);
            FilterEntityOfUpdate(whitePgReserv); AssertEntityOfUpdate(whitePgReserv);
            return this.Dao.UpdateByQuery(cb, whitePgReserv);
        }

        public int QueryDelete(WhitePgReservCB cb) {
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
        protected int DelegateSelectCount(WhitePgReservCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<WhitePgReserv> DelegateSelectList(WhitePgReservCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(WhitePgReserv e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(WhitePgReserv e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(WhitePgReserv e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected WhitePgReserv Downcast(Entity entity) {
            return (WhitePgReserv)entity;
        }

        protected WhitePgReservCB Downcast(ConditionBean cb) {
            return (WhitePgReservCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual WhitePgReservDao Dao { get { return _dao; } set { _dao = value; } }
    }
}

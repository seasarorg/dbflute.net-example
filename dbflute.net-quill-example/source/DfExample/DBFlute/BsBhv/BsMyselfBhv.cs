
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
    public partial class MyselfBhv : DfExample.DBFlute.AllCommon.Bhv.AbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected MyselfDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public MyselfBhv() {
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
        public override DBMeta DBMeta { get { return MyselfDbm.GetInstance(); } }
        public MyselfDbm MyDBMeta { get { return MyselfDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override Entity NewEntity() { return NewMyEntity(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual Myself NewMyEntity() { return new Myself(); }
        public virtual MyselfCB NewMyConditionBean() { return new MyselfCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(MyselfCB cb) {
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
        public virtual Myself SelectEntity(MyselfCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<Myself> ls = null;
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
            return (Myself)ls[0];
        }

        protected override Entity DoReadEntity(ConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual Myself SelectEntityWithDeletedCheck(MyselfCB cb) {
            AssertConditionBeanNotNull(cb);
            Myself entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override Entity DoReadEntityWithDeletedCheck(ConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual Myself SelectByPKValue(int? myselfId) {
            return SelectEntity(BuildPKCB(myselfId));
        }

        public virtual Myself SelectByPKValueWithDeletedCheck(int? myselfId) {
            return SelectEntityWithDeletedCheck(BuildPKCB(myselfId));
        }

        private MyselfCB BuildPKCB(int? myselfId) {
            AssertObjectNotNull("myselfId", myselfId);
            MyselfCB cb = NewMyConditionBean();
            cb.Query().SetMyselfId_Equal(myselfId);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual ListResultBean<Myself> SelectList(MyselfCB cb) {
            AssertConditionBeanNotNull(cb);
            return new ResultBeanBuilder<Myself>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual PagingResultBean<Myself> SelectPage(MyselfCB cb) {
            AssertConditionBeanNotNull(cb);
            PagingInvoker<Myself> invoker = new PagingInvoker<Myself>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : PagingHandler<Myself> {
            protected MyselfBhv _bhv; protected MyselfCB _cb;
            public InternalSelectPagingHandler(MyselfBhv bhv, MyselfCB cb) { _bhv = bhv; _cb = cb; }
            public PagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<Myself> Paging() { return _bhv.SelectList(_cb); }
        }
        #endregion

        // ===============================================================================
        //                                                                   Load Referrer
        //                                                                   =============
        #region Load Referrer
        public virtual void LoadMyselfCheckList(Myself myself, ConditionBeanSetupper<MyselfCheckCB> conditionBeanSetupper) {
            AssertObjectNotNull("myself", myself); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadMyselfCheckList(xnewLRLs<Myself>(myself), conditionBeanSetupper);
        }
        public virtual void LoadMyselfCheckList(IList<Myself> myselfList, ConditionBeanSetupper<MyselfCheckCB> conditionBeanSetupper) {
            AssertObjectNotNull("myselfList", myselfList); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadMyselfCheckList(myselfList, new LoadReferrerOption<MyselfCheckCB, MyselfCheck>().xinit(conditionBeanSetupper));
        }
        public virtual void LoadMyselfCheckList(Myself myself, LoadReferrerOption<MyselfCheckCB, MyselfCheck> loadReferrerOption) {
            AssertObjectNotNull("myself", myself); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            LoadMyselfCheckList(xnewLRLs<Myself>(myself), loadReferrerOption);
        }
        public virtual void LoadMyselfCheckList(IList<Myself> myselfList, LoadReferrerOption<MyselfCheckCB, MyselfCheck> loadReferrerOption) {
            AssertObjectNotNull("myselfList", myselfList); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            if (myselfList.Count == 0) { return; }
            MyselfCheckBhv referrerBhv = xgetBSFLR().Select<MyselfCheckBhv>();
            HelpLoadReferrerInternally<Myself, int?, MyselfCheckCB, MyselfCheck>
                    (myselfList, loadReferrerOption, new MyInternalLoadMyselfCheckListCallback(referrerBhv));
        }
        protected class MyInternalLoadMyselfCheckListCallback : InternalLoadReferrerCallback<Myself, int?, MyselfCheckCB, MyselfCheck> {
            protected MyselfCheckBhv referrerBhv;
            public MyInternalLoadMyselfCheckListCallback(MyselfCheckBhv referrerBhv) { this.referrerBhv = referrerBhv; }
            public int? getPKVal(Myself e) { return e.MyselfId; }
            public void setRfLs(Myself e, IList<MyselfCheck> ls) { e.MyselfCheckList = ls; }
            public MyselfCheckCB newMyCB() { return referrerBhv.NewMyConditionBean(); }
            public void qyFKIn(MyselfCheckCB cb, IList<int?> ls) { cb.Query().SetMyselfId_InScope(ls); }
            public void qyOdFKAsc(MyselfCheckCB cb) { cb.Query().AddOrderBy_MyselfId_Asc(); }
            public void spFKCol(MyselfCheckCB cb) { cb.Specify().ColumnMyselfId(); }
            public IList<MyselfCheck> selRfLs(MyselfCheckCB cb) { return referrerBhv.SelectList(cb); }
            public int? getFKVal(MyselfCheck e) { return e.MyselfId; }
            public void setlcEt(MyselfCheck re, Myself be) { re.Myself = be; }
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
        public virtual void Insert(Myself entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(Entity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(Myself entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(Entity entity) {
            Update(Downcast(entity));
        }

        public void InsertOrUpdate(Myself entity) {
            HelpInsertOrUpdateInternally<Myself, MyselfCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<Myself, MyselfCB> {
            protected MyselfBhv _bhv;
            public MyInternalInsertOrUpdateCallback(MyselfBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(Myself entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(Myself entity) { _bhv.Update(entity); }
            public MyselfCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(MyselfCB cb, Myself entity) {
                cb.Query().SetMyselfId_Equal(entity.MyselfId);
            }
            public int CallbackSelectCount(MyselfCB cb) { return _bhv.SelectCount(cb); }
        }

        public virtual void Delete(Myself entity) {
            HelpDeleteInternally<Myself>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(Entity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<Myself> {
            protected MyselfBhv _bhv;
            public MyInternalDeleteCallback(MyselfBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(Myself entity) { return _bhv.DelegateDelete(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(Myself myself, MyselfCB cb) {
            AssertObjectNotNull("myself", myself); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(myself);
            FilterEntityOfUpdate(myself); AssertEntityOfUpdate(myself);
            return this.Dao.UpdateByQuery(cb, myself);
        }

        public int QueryDelete(MyselfCB cb) {
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
        protected int DelegateSelectCount(MyselfCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<Myself> DelegateSelectList(MyselfCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(Myself e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(Myself e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(Myself e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected Myself Downcast(Entity entity) {
            return (Myself)entity;
        }

        protected MyselfCB Downcast(ConditionBean cb) {
            return (MyselfCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual MyselfDao Dao { get { return _dao; } set { _dao = value; } }
    }
}

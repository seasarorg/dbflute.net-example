
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
    public partial class MyselfCheckBhv : DfExample.DBFlute.AllCommon.Bhv.AbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected MyselfCheckDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public MyselfCheckBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "myself_check"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override DBMeta DBMeta { get { return MyselfCheckDbm.GetInstance(); } }
        public MyselfCheckDbm MyDBMeta { get { return MyselfCheckDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override Entity NewEntity() { return NewMyEntity(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual MyselfCheck NewMyEntity() { return new MyselfCheck(); }
        public virtual MyselfCheckCB NewMyConditionBean() { return new MyselfCheckCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(MyselfCheckCB cb) {
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
        public virtual MyselfCheck SelectEntity(MyselfCheckCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<MyselfCheck> ls = null;
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
            return (MyselfCheck)ls[0];
        }

        protected override Entity DoReadEntity(ConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual MyselfCheck SelectEntityWithDeletedCheck(MyselfCheckCB cb) {
            AssertConditionBeanNotNull(cb);
            MyselfCheck entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override Entity DoReadEntityWithDeletedCheck(ConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual MyselfCheck SelectByPKValue(int? myselfCheckId) {
            return SelectEntity(BuildPKCB(myselfCheckId));
        }

        public virtual MyselfCheck SelectByPKValueWithDeletedCheck(int? myselfCheckId) {
            return SelectEntityWithDeletedCheck(BuildPKCB(myselfCheckId));
        }

        private MyselfCheckCB BuildPKCB(int? myselfCheckId) {
            AssertObjectNotNull("myselfCheckId", myselfCheckId);
            MyselfCheckCB cb = NewMyConditionBean();
            cb.Query().SetMyselfCheckId_Equal(myselfCheckId);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual ListResultBean<MyselfCheck> SelectList(MyselfCheckCB cb) {
            AssertConditionBeanNotNull(cb);
            return new ResultBeanBuilder<MyselfCheck>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual PagingResultBean<MyselfCheck> SelectPage(MyselfCheckCB cb) {
            AssertConditionBeanNotNull(cb);
            PagingInvoker<MyselfCheck> invoker = new PagingInvoker<MyselfCheck>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : PagingHandler<MyselfCheck> {
            protected MyselfCheckBhv _bhv; protected MyselfCheckCB _cb;
            public InternalSelectPagingHandler(MyselfCheckBhv bhv, MyselfCheckCB cb) { _bhv = bhv; _cb = cb; }
            public PagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<MyselfCheck> Paging() { return _bhv.SelectList(_cb); }
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
        public IList<Myself> PulloutMyself(IList<MyselfCheck> myselfCheckList) {
            return HelpPulloutInternally<MyselfCheck, Myself>(myselfCheckList, new MyInternalPulloutMyselfCallback());
        }
        protected class MyInternalPulloutMyselfCallback : InternalPulloutCallback<MyselfCheck, Myself> {
            public Myself getFr(MyselfCheck entity) { return entity.Myself; }
        }
        #endregion


        // ===============================================================================
        //                                                                   Entity Update
        //                                                                   =============
        #region Basic Entity Update
        public virtual void Insert(MyselfCheck entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(Entity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(MyselfCheck entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(Entity entity) {
            Update(Downcast(entity));
        }

        public void InsertOrUpdate(MyselfCheck entity) {
            HelpInsertOrUpdateInternally<MyselfCheck, MyselfCheckCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<MyselfCheck, MyselfCheckCB> {
            protected MyselfCheckBhv _bhv;
            public MyInternalInsertOrUpdateCallback(MyselfCheckBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(MyselfCheck entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(MyselfCheck entity) { _bhv.Update(entity); }
            public MyselfCheckCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(MyselfCheckCB cb, MyselfCheck entity) {
                cb.Query().SetMyselfCheckId_Equal(entity.MyselfCheckId);
            }
            public int CallbackSelectCount(MyselfCheckCB cb) { return _bhv.SelectCount(cb); }
        }

        public virtual void Delete(MyselfCheck entity) {
            HelpDeleteInternally<MyselfCheck>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(Entity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<MyselfCheck> {
            protected MyselfCheckBhv _bhv;
            public MyInternalDeleteCallback(MyselfCheckBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(MyselfCheck entity) { return _bhv.DelegateDelete(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(MyselfCheck myselfCheck, MyselfCheckCB cb) {
            AssertObjectNotNull("myselfCheck", myselfCheck); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(myselfCheck);
            FilterEntityOfUpdate(myselfCheck); AssertEntityOfUpdate(myselfCheck);
            return this.Dao.UpdateByQuery(cb, myselfCheck);
        }

        public int QueryDelete(MyselfCheckCB cb) {
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
        protected int DelegateSelectCount(MyselfCheckCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<MyselfCheck> DelegateSelectList(MyselfCheckCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(MyselfCheck e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(MyselfCheck e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(MyselfCheck e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected MyselfCheck Downcast(Entity entity) {
            return (MyselfCheck)entity;
        }

        protected MyselfCheckCB Downcast(ConditionBean cb) {
            return (MyselfCheckCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual MyselfCheckDao Dao { get { return _dao; } set { _dao = value; } }
    }
}


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
    public partial class WhiteCompoundPkBhv : DfExample.DBFlute.AllCommon.Bhv.AbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected WhiteCompoundPkDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public WhiteCompoundPkBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "white_compound_pk"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override DBMeta DBMeta { get { return WhiteCompoundPkDbm.GetInstance(); } }
        public WhiteCompoundPkDbm MyDBMeta { get { return WhiteCompoundPkDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override Entity NewEntity() { return NewMyEntity(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual WhiteCompoundPk NewMyEntity() { return new WhiteCompoundPk(); }
        public virtual WhiteCompoundPkCB NewMyConditionBean() { return new WhiteCompoundPkCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(WhiteCompoundPkCB cb) {
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
        public virtual WhiteCompoundPk SelectEntity(WhiteCompoundPkCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<WhiteCompoundPk> ls = null;
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
            return (WhiteCompoundPk)ls[0];
        }

        protected override Entity DoReadEntity(ConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual WhiteCompoundPk SelectEntityWithDeletedCheck(WhiteCompoundPkCB cb) {
            AssertConditionBeanNotNull(cb);
            WhiteCompoundPk entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override Entity DoReadEntityWithDeletedCheck(ConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual WhiteCompoundPk SelectByPKValue(int? pkFirstId, int? pkSecondId) {
            return SelectEntity(BuildPKCB(pkFirstId, pkSecondId));
        }

        public virtual WhiteCompoundPk SelectByPKValueWithDeletedCheck(int? pkFirstId, int? pkSecondId) {
            return SelectEntityWithDeletedCheck(BuildPKCB(pkFirstId, pkSecondId));
        }

        private WhiteCompoundPkCB BuildPKCB(int? pkFirstId, int? pkSecondId) {
            AssertObjectNotNull("pkFirstId", pkFirstId);AssertObjectNotNull("pkSecondId", pkSecondId);
            WhiteCompoundPkCB cb = NewMyConditionBean();
            cb.Query().SetPkFirstId_Equal(pkFirstId);cb.Query().SetPkSecondId_Equal(pkSecondId);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual ListResultBean<WhiteCompoundPk> SelectList(WhiteCompoundPkCB cb) {
            AssertConditionBeanNotNull(cb);
            return new ResultBeanBuilder<WhiteCompoundPk>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual PagingResultBean<WhiteCompoundPk> SelectPage(WhiteCompoundPkCB cb) {
            AssertConditionBeanNotNull(cb);
            PagingInvoker<WhiteCompoundPk> invoker = new PagingInvoker<WhiteCompoundPk>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : PagingHandler<WhiteCompoundPk> {
            protected WhiteCompoundPkBhv _bhv; protected WhiteCompoundPkCB _cb;
            public InternalSelectPagingHandler(WhiteCompoundPkBhv bhv, WhiteCompoundPkCB cb) { _bhv = bhv; _cb = cb; }
            public PagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<WhiteCompoundPk> Paging() { return _bhv.SelectList(_cb); }
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
        public virtual void Insert(WhiteCompoundPk entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(Entity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(WhiteCompoundPk entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(Entity entity) {
            Update(Downcast(entity));
        }

        public void InsertOrUpdate(WhiteCompoundPk entity) {
            HelpInsertOrUpdateInternally<WhiteCompoundPk, WhiteCompoundPkCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<WhiteCompoundPk, WhiteCompoundPkCB> {
            protected WhiteCompoundPkBhv _bhv;
            public MyInternalInsertOrUpdateCallback(WhiteCompoundPkBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(WhiteCompoundPk entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(WhiteCompoundPk entity) { _bhv.Update(entity); }
            public WhiteCompoundPkCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(WhiteCompoundPkCB cb, WhiteCompoundPk entity) {
                cb.Query().SetPkFirstId_Equal(entity.PkFirstId);
                cb.Query().SetPkSecondId_Equal(entity.PkSecondId);
            }
            public int CallbackSelectCount(WhiteCompoundPkCB cb) { return _bhv.SelectCount(cb); }
        }

        public virtual void Delete(WhiteCompoundPk entity) {
            HelpDeleteInternally<WhiteCompoundPk>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(Entity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<WhiteCompoundPk> {
            protected WhiteCompoundPkBhv _bhv;
            public MyInternalDeleteCallback(WhiteCompoundPkBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(WhiteCompoundPk entity) { return _bhv.DelegateDelete(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============

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
        protected int DelegateSelectCount(WhiteCompoundPkCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<WhiteCompoundPk> DelegateSelectList(WhiteCompoundPkCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(WhiteCompoundPk e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(WhiteCompoundPk e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(WhiteCompoundPk e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected WhiteCompoundPk Downcast(Entity entity) {
            return (WhiteCompoundPk)entity;
        }

        protected WhiteCompoundPkCB Downcast(ConditionBean cb) {
            return (WhiteCompoundPkCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual WhiteCompoundPkDao Dao { get { return _dao; } set { _dao = value; } }
    }
}

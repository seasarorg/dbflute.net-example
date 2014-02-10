
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
    public partial class WhiteAllInOneClsBhv : DfExample.DBFlute.AllCommon.Bhv.AbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected WhiteAllInOneClsDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public WhiteAllInOneClsBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "white_all_in_one_cls"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override DBMeta DBMeta { get { return WhiteAllInOneClsDbm.GetInstance(); } }
        public WhiteAllInOneClsDbm MyDBMeta { get { return WhiteAllInOneClsDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override Entity NewEntity() { return NewMyEntity(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual WhiteAllInOneCls NewMyEntity() { return new WhiteAllInOneCls(); }
        public virtual WhiteAllInOneClsCB NewMyConditionBean() { return new WhiteAllInOneClsCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(WhiteAllInOneClsCB cb) {
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
        public virtual WhiteAllInOneCls SelectEntity(WhiteAllInOneClsCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<WhiteAllInOneCls> ls = null;
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
            return (WhiteAllInOneCls)ls[0];
        }

        protected override Entity DoReadEntity(ConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual WhiteAllInOneCls SelectEntityWithDeletedCheck(WhiteAllInOneClsCB cb) {
            AssertConditionBeanNotNull(cb);
            WhiteAllInOneCls entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override Entity DoReadEntityWithDeletedCheck(ConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual WhiteAllInOneCls SelectByPKValue(String clsCategoryCode, String clsElementCode) {
            return SelectEntity(BuildPKCB(clsCategoryCode, clsElementCode));
        }

        public virtual WhiteAllInOneCls SelectByPKValueWithDeletedCheck(String clsCategoryCode, String clsElementCode) {
            return SelectEntityWithDeletedCheck(BuildPKCB(clsCategoryCode, clsElementCode));
        }

        private WhiteAllInOneClsCB BuildPKCB(String clsCategoryCode, String clsElementCode) {
            AssertObjectNotNull("clsCategoryCode", clsCategoryCode);AssertObjectNotNull("clsElementCode", clsElementCode);
            WhiteAllInOneClsCB cb = NewMyConditionBean();
            cb.Query().SetClsCategoryCode_Equal(clsCategoryCode);cb.Query().SetClsElementCode_Equal(clsElementCode);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual ListResultBean<WhiteAllInOneCls> SelectList(WhiteAllInOneClsCB cb) {
            AssertConditionBeanNotNull(cb);
            return new ResultBeanBuilder<WhiteAllInOneCls>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual PagingResultBean<WhiteAllInOneCls> SelectPage(WhiteAllInOneClsCB cb) {
            AssertConditionBeanNotNull(cb);
            PagingInvoker<WhiteAllInOneCls> invoker = new PagingInvoker<WhiteAllInOneCls>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : PagingHandler<WhiteAllInOneCls> {
            protected WhiteAllInOneClsBhv _bhv; protected WhiteAllInOneClsCB _cb;
            public InternalSelectPagingHandler(WhiteAllInOneClsBhv bhv, WhiteAllInOneClsCB cb) { _bhv = bhv; _cb = cb; }
            public PagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<WhiteAllInOneCls> Paging() { return _bhv.SelectList(_cb); }
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
        public virtual void Insert(WhiteAllInOneCls entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(Entity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(WhiteAllInOneCls entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(Entity entity) {
            Update(Downcast(entity));
        }

        public void InsertOrUpdate(WhiteAllInOneCls entity) {
            HelpInsertOrUpdateInternally<WhiteAllInOneCls, WhiteAllInOneClsCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<WhiteAllInOneCls, WhiteAllInOneClsCB> {
            protected WhiteAllInOneClsBhv _bhv;
            public MyInternalInsertOrUpdateCallback(WhiteAllInOneClsBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(WhiteAllInOneCls entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(WhiteAllInOneCls entity) { _bhv.Update(entity); }
            public WhiteAllInOneClsCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(WhiteAllInOneClsCB cb, WhiteAllInOneCls entity) {
                cb.Query().SetClsCategoryCode_Equal(entity.ClsCategoryCode);
                cb.Query().SetClsElementCode_Equal(entity.ClsElementCode);
            }
            public int CallbackSelectCount(WhiteAllInOneClsCB cb) { return _bhv.SelectCount(cb); }
        }

        public virtual void Delete(WhiteAllInOneCls entity) {
            HelpDeleteInternally<WhiteAllInOneCls>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(Entity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<WhiteAllInOneCls> {
            protected WhiteAllInOneClsBhv _bhv;
            public MyInternalDeleteCallback(WhiteAllInOneClsBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(WhiteAllInOneCls entity) { return _bhv.DelegateDelete(entity); }
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
        protected int DelegateSelectCount(WhiteAllInOneClsCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<WhiteAllInOneCls> DelegateSelectList(WhiteAllInOneClsCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(WhiteAllInOneCls e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(WhiteAllInOneCls e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(WhiteAllInOneCls e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected WhiteAllInOneCls Downcast(Entity entity) {
            return (WhiteAllInOneCls)entity;
        }

        protected WhiteAllInOneClsCB Downcast(ConditionBean cb) {
            return (WhiteAllInOneClsCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual WhiteAllInOneClsDao Dao { get { return _dao; } set { _dao = value; } }
    }
}

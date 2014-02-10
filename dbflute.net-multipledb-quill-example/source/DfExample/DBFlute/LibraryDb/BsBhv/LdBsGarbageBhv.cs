
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
    public partial class LdGarbageBhv : DfExample.DBFlute.LibraryDb.AllCommon.Bhv.LdAbstractBehaviorReadable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected LdGarbageDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public LdGarbageBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "garbage"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override LdDBMeta DBMeta { get { return LdGarbageDbm.GetInstance(); } }
        public LdGarbageDbm MyDBMeta { get { return LdGarbageDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override LdEntity NewEntity() { return NewMyEntity(); }
        public override LdConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual LdGarbage NewMyEntity() { return new LdGarbage(); }
        public virtual LdGarbageCB NewMyConditionBean() { return new LdGarbageCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(LdGarbageCB cb) {
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
        public virtual LdGarbage SelectEntity(LdGarbageCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<LdGarbage> ls = null;
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
            return (LdGarbage)ls[0];
        }

        protected override LdEntity DoReadEntity(LdConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual LdGarbage SelectEntityWithDeletedCheck(LdGarbageCB cb) {
            AssertConditionBeanNotNull(cb);
            LdGarbage entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override LdEntity DoReadEntityWithDeletedCheck(LdConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual LdListResultBean<LdGarbage> SelectList(LdGarbageCB cb) {
            AssertConditionBeanNotNull(cb);
            return new LdResultBeanBuilder<LdGarbage>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual LdPagingResultBean<LdGarbage> SelectPage(LdGarbageCB cb) {
            AssertConditionBeanNotNull(cb);
            LdPagingInvoker<LdGarbage> invoker = new LdPagingInvoker<LdGarbage>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : LdPagingHandler<LdGarbage> {
            protected LdGarbageBhv _bhv; protected LdGarbageCB _cb;
            public InternalSelectPagingHandler(LdGarbageBhv bhv, LdGarbageCB cb) { _bhv = bhv; _cb = cb; }
            public LdPagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<LdGarbage> Paging() { return _bhv.SelectList(_cb); }
        }
        #endregion


        // ===============================================================================
        //                                                                Pull out Foreign
        //                                                                ================
        #region Pullout Foreign
        #endregion


        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============

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
        protected int DelegateSelectCount(LdGarbageCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<LdGarbage> DelegateSelectList(LdGarbageCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        #endregion

        protected override void FilterEntityOfInsert(LdEntity targetEntity) {
            base.FilterEntityOfInsert(targetEntity);
            LdGarbage entity = (LdGarbage)targetEntity;
            entity.GarbageTime = DfExample.DBFlute.LibraryDb.AllCommon.LdAccessContext.GetAccessTimestampOnThread();
            entity.RUser = DfExample.DBFlute.LibraryDb.AllCommon.LdAccessContext.GetAccessUserOnThread();
            entity.RTimestamp = DfExample.DBFlute.LibraryDb.AllCommon.LdAccessContext.GetAccessTimestampOnThread();
        }

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected LdGarbage Downcast(LdEntity entity) {
            return (LdGarbage)entity;
        }

        protected LdGarbageCB Downcast(LdConditionBean cb) {
            return (LdGarbageCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual LdGarbageDao Dao { get { return _dao; } set { _dao = value; } }
    }
}

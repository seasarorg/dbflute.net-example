
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
    public partial class LdGarbagePlusBhv : DfExample.DBFlute.LibraryDb.AllCommon.Bhv.LdAbstractBehaviorReadable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected LdGarbagePlusDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public LdGarbagePlusBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "garbage_plus"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override LdDBMeta DBMeta { get { return LdGarbagePlusDbm.GetInstance(); } }
        public LdGarbagePlusDbm MyDBMeta { get { return LdGarbagePlusDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override LdEntity NewEntity() { return NewMyEntity(); }
        public override LdConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual LdGarbagePlus NewMyEntity() { return new LdGarbagePlus(); }
        public virtual LdGarbagePlusCB NewMyConditionBean() { return new LdGarbagePlusCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(LdGarbagePlusCB cb) {
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
        public virtual LdGarbagePlus SelectEntity(LdGarbagePlusCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<LdGarbagePlus> ls = null;
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
            return (LdGarbagePlus)ls[0];
        }

        protected override LdEntity DoReadEntity(LdConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual LdGarbagePlus SelectEntityWithDeletedCheck(LdGarbagePlusCB cb) {
            AssertConditionBeanNotNull(cb);
            LdGarbagePlus entity = SelectEntity(cb);
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
        public virtual LdListResultBean<LdGarbagePlus> SelectList(LdGarbagePlusCB cb) {
            AssertConditionBeanNotNull(cb);
            return new LdResultBeanBuilder<LdGarbagePlus>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual LdPagingResultBean<LdGarbagePlus> SelectPage(LdGarbagePlusCB cb) {
            AssertConditionBeanNotNull(cb);
            LdPagingInvoker<LdGarbagePlus> invoker = new LdPagingInvoker<LdGarbagePlus>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : LdPagingHandler<LdGarbagePlus> {
            protected LdGarbagePlusBhv _bhv; protected LdGarbagePlusCB _cb;
            public InternalSelectPagingHandler(LdGarbagePlusBhv bhv, LdGarbagePlusCB cb) { _bhv = bhv; _cb = cb; }
            public LdPagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<LdGarbagePlus> Paging() { return _bhv.SelectList(_cb); }
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
        protected int DelegateSelectCount(LdGarbagePlusCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<LdGarbagePlus> DelegateSelectList(LdGarbagePlusCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        #endregion

        protected override void FilterEntityOfInsert(LdEntity targetEntity) {
            base.FilterEntityOfInsert(targetEntity);
            LdGarbagePlus entity = (LdGarbagePlus)targetEntity;
            entity.GarbageTime = DfExample.DBFlute.LibraryDb.AllCommon.LdAccessContext.GetAccessTimestampOnThread();
            entity.RUser = DfExample.DBFlute.LibraryDb.AllCommon.LdAccessContext.GetAccessUserOnThread();
            entity.RTimestamp = DfExample.DBFlute.LibraryDb.AllCommon.LdAccessContext.GetAccessTimestampOnThread();
        }

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected LdGarbagePlus Downcast(LdEntity entity) {
            return (LdGarbagePlus)entity;
        }

        protected LdGarbagePlusCB Downcast(LdConditionBean cb) {
            return (LdGarbagePlusCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual LdGarbagePlusDao Dao { get { return _dao; } set { _dao = value; } }
    }
}

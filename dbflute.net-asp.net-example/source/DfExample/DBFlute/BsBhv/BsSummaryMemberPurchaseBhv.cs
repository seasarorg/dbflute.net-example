
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
    public partial class SummaryMemberPurchaseBhv : DfExample.DBFlute.AllCommon.Bhv.AbstractBehaviorReadable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected SummaryMemberPurchaseDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public SummaryMemberPurchaseBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "SUMMARY_MEMBER_PURCHASE"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override DBMeta DBMeta { get { return SummaryMemberPurchaseDbm.GetInstance(); } }
        public SummaryMemberPurchaseDbm MyDBMeta { get { return SummaryMemberPurchaseDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override Entity NewEntity() { return NewMyEntity(); }
        public override ConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual SummaryMemberPurchase NewMyEntity() { return new SummaryMemberPurchase(); }
        public virtual SummaryMemberPurchaseCB NewMyConditionBean() { return new SummaryMemberPurchaseCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(SummaryMemberPurchaseCB cb) {
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
        public virtual SummaryMemberPurchase SelectEntity(SummaryMemberPurchaseCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<SummaryMemberPurchase> ls = null;
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
            return (SummaryMemberPurchase)ls[0];
        }

        protected override Entity DoReadEntity(ConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual SummaryMemberPurchase SelectEntityWithDeletedCheck(SummaryMemberPurchaseCB cb) {
            AssertConditionBeanNotNull(cb);
            SummaryMemberPurchase entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override Entity DoReadEntityWithDeletedCheck(ConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual ListResultBean<SummaryMemberPurchase> SelectList(SummaryMemberPurchaseCB cb) {
            AssertConditionBeanNotNull(cb);
            return new ResultBeanBuilder<SummaryMemberPurchase>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual PagingResultBean<SummaryMemberPurchase> SelectPage(SummaryMemberPurchaseCB cb) {
            AssertConditionBeanNotNull(cb);
            PagingInvoker<SummaryMemberPurchase> invoker = new PagingInvoker<SummaryMemberPurchase>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : PagingHandler<SummaryMemberPurchase> {
            protected SummaryMemberPurchaseBhv _bhv; protected SummaryMemberPurchaseCB _cb;
            public InternalSelectPagingHandler(SummaryMemberPurchaseBhv bhv, SummaryMemberPurchaseCB cb) { _bhv = bhv; _cb = cb; }
            public PagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<SummaryMemberPurchase> Paging() { return _bhv.SelectList(_cb); }
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
        protected int DelegateSelectCount(SummaryMemberPurchaseCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<SummaryMemberPurchase> DelegateSelectList(SummaryMemberPurchaseCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected SummaryMemberPurchase Downcast(Entity entity) {
            return (SummaryMemberPurchase)entity;
        }

        protected SummaryMemberPurchaseCB Downcast(ConditionBean cb) {
            return (SummaryMemberPurchaseCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual SummaryMemberPurchaseDao Dao { get { return _dao; } set { _dao = value; } }
    }
}

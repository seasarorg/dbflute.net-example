
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
    public partial class LdPublisherBhv : DfExample.DBFlute.LibraryDb.AllCommon.Bhv.LdAbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected LdPublisherDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public LdPublisherBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "publisher"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override LdDBMeta DBMeta { get { return LdPublisherDbm.GetInstance(); } }
        public LdPublisherDbm MyDBMeta { get { return LdPublisherDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override LdEntity NewEntity() { return NewMyEntity(); }
        public override LdConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual LdPublisher NewMyEntity() { return new LdPublisher(); }
        public virtual LdPublisherCB NewMyConditionBean() { return new LdPublisherCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(LdPublisherCB cb) {
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
        public virtual LdPublisher SelectEntity(LdPublisherCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<LdPublisher> ls = null;
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
            return (LdPublisher)ls[0];
        }

        protected override LdEntity DoReadEntity(LdConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual LdPublisher SelectEntityWithDeletedCheck(LdPublisherCB cb) {
            AssertConditionBeanNotNull(cb);
            LdPublisher entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override LdEntity DoReadEntityWithDeletedCheck(LdConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual LdPublisher SelectByPKValue(int? publisherId) {
            return SelectEntity(BuildPKCB(publisherId));
        }

        public virtual LdPublisher SelectByPKValueWithDeletedCheck(int? publisherId) {
            return SelectEntityWithDeletedCheck(BuildPKCB(publisherId));
        }

        private LdPublisherCB BuildPKCB(int? publisherId) {
            AssertObjectNotNull("publisherId", publisherId);
            LdPublisherCB cb = NewMyConditionBean();
            cb.Query().SetPublisherId_Equal(publisherId);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual LdListResultBean<LdPublisher> SelectList(LdPublisherCB cb) {
            AssertConditionBeanNotNull(cb);
            return new LdResultBeanBuilder<LdPublisher>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual LdPagingResultBean<LdPublisher> SelectPage(LdPublisherCB cb) {
            AssertConditionBeanNotNull(cb);
            LdPagingInvoker<LdPublisher> invoker = new LdPagingInvoker<LdPublisher>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : LdPagingHandler<LdPublisher> {
            protected LdPublisherBhv _bhv; protected LdPublisherCB _cb;
            public InternalSelectPagingHandler(LdPublisherBhv bhv, LdPublisherCB cb) { _bhv = bhv; _cb = cb; }
            public LdPagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<LdPublisher> Paging() { return _bhv.SelectList(_cb); }
        }
        #endregion

        // ===============================================================================
        //                                                                   Load Referrer
        //                                                                   =============
        #region Load Referrer
        public virtual void LoadBookList(LdPublisher publisher, LdConditionBeanSetupper<LdBookCB> conditionBeanSetupper) {
            AssertObjectNotNull("publisher", publisher); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadBookList(xnewLRLs<LdPublisher>(publisher), conditionBeanSetupper);
        }
        public virtual void LoadBookList(IList<LdPublisher> publisherList, LdConditionBeanSetupper<LdBookCB> conditionBeanSetupper) {
            AssertObjectNotNull("publisherList", publisherList); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadBookList(publisherList, new LdLoadReferrerOption<LdBookCB, LdBook>().xinit(conditionBeanSetupper));
        }
        public virtual void LoadBookList(LdPublisher publisher, LdLoadReferrerOption<LdBookCB, LdBook> loadReferrerOption) {
            AssertObjectNotNull("publisher", publisher); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            LoadBookList(xnewLRLs<LdPublisher>(publisher), loadReferrerOption);
        }
        public virtual void LoadBookList(IList<LdPublisher> publisherList, LdLoadReferrerOption<LdBookCB, LdBook> loadReferrerOption) {
            AssertObjectNotNull("publisherList", publisherList); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            if (publisherList.Count == 0) { return; }
            LdBookBhv referrerBhv = xgetBSFLR().Select<LdBookBhv>();
            HelpLoadReferrerInternally<LdPublisher, int?, LdBookCB, LdBook>
                    (publisherList, loadReferrerOption, new MyInternalLoadBookListCallback(referrerBhv));
        }
        protected class MyInternalLoadBookListCallback : InternalLoadReferrerCallback<LdPublisher, int?, LdBookCB, LdBook> {
            protected LdBookBhv referrerBhv;
            public MyInternalLoadBookListCallback(LdBookBhv referrerBhv) { this.referrerBhv = referrerBhv; }
            public int? getPKVal(LdPublisher e) { return e.PublisherId; }
            public void setRfLs(LdPublisher e, IList<LdBook> ls) { e.BookList = ls; }
            public LdBookCB newMyCB() { return referrerBhv.NewMyConditionBean(); }
            public void qyFKIn(LdBookCB cb, IList<int?> ls) { cb.Query().SetPublisherId_InScope(ls); }
            public void qyOdFKAsc(LdBookCB cb) { cb.Query().AddOrderBy_PublisherId_Asc(); }
            public void spFKCol(LdBookCB cb) { cb.Specify().ColumnPublisherId(); }
            public IList<LdBook> selRfLs(LdBookCB cb) { return referrerBhv.SelectList(cb); }
            public int? getFKVal(LdBook e) { return e.PublisherId; }
            public void setlcEt(LdBook re, LdPublisher be) { re.Publisher = be; }
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
        public virtual void Insert(LdPublisher entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(LdEntity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(LdPublisher entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(LdEntity entity) {
            Update(Downcast(entity));
        }

        public virtual void UpdateNonstrict(LdPublisher entity) {
            AssertEntityNotNull(entity);
            int updatedCount = this.DelegateUpdateNonstrict(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        public void InsertOrUpdate(LdPublisher entity) {
            HelpInsertOrUpdateInternally<LdPublisher, LdPublisherCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<LdPublisher, LdPublisherCB> {
            protected LdPublisherBhv _bhv;
            public MyInternalInsertOrUpdateCallback(LdPublisherBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(LdPublisher entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(LdPublisher entity) { _bhv.Update(entity); }
            public LdPublisherCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(LdPublisherCB cb, LdPublisher entity) {
                cb.Query().SetPublisherId_Equal(entity.PublisherId);
            }
            public int CallbackSelectCount(LdPublisherCB cb) { return _bhv.SelectCount(cb); }
        }

        public void InsertOrUpdateNonstrict(LdPublisher entity) {
            HelpInsertOrUpdateInternally<LdPublisher>(entity, new MyInternalInsertOrUpdateNonstrictCallback(this));
        }
        protected class MyInternalInsertOrUpdateNonstrictCallback : InternalInsertOrUpdateNonstrictCallback<LdPublisher> {
            protected LdPublisherBhv _bhv;
            public MyInternalInsertOrUpdateNonstrictCallback(LdPublisherBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(LdPublisher entity) { _bhv.Insert(entity); }
            public void CallbackUpdateNonstrict(LdPublisher entity) { _bhv.UpdateNonstrict(entity); }
        }

        public virtual void Delete(LdPublisher entity) {
            HelpDeleteInternally<LdPublisher>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(LdEntity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<LdPublisher> {
            protected LdPublisherBhv _bhv;
            public MyInternalDeleteCallback(LdPublisherBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(LdPublisher entity) { return _bhv.DelegateDelete(entity); }
        }

        public virtual void DeleteNonstrict(LdPublisher entity) {
            HelpDeleteNonstrictInternally<LdPublisher>(entity, new MyInternalDeleteNonstrictCallback(this));
        }
        protected class MyInternalDeleteNonstrictCallback : InternalDeleteNonstrictCallback<LdPublisher> {
            protected LdPublisherBhv _bhv;
            public MyInternalDeleteNonstrictCallback(LdPublisherBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDeleteNonstrict(LdPublisher entity) { return _bhv.DelegateDeleteNonstrict(entity); }
        }

        public virtual void DeleteNonstrictIgnoreDeleted(LdPublisher entity) {
            HelpDeleteNonstrictIgnoreDeletedInternally<LdPublisher>(entity, new MyInternalDeleteNonstrictIgnoreDeletedCallback(this));
        }
        protected class MyInternalDeleteNonstrictIgnoreDeletedCallback : InternalDeleteNonstrictIgnoreDeletedCallback<LdPublisher> {
            protected LdPublisherBhv _bhv;
            public MyInternalDeleteNonstrictIgnoreDeletedCallback(LdPublisherBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDeleteNonstrict(LdPublisher entity) { return _bhv.DelegateDeleteNonstrict(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(LdPublisher publisher, LdPublisherCB cb) {
            AssertObjectNotNull("publisher", publisher); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(publisher);
            FilterEntityOfUpdate(publisher); AssertEntityOfUpdate(publisher);
            return this.Dao.UpdateByQuery(cb, publisher);
        }

        public int QueryDelete(LdPublisherCB cb) {
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
            return Downcast(entity).UTimestamp != null;
        }

        // ===============================================================================
        //                                                                 Delegate Method
        //                                                                 ===============
        #region Delegate Method
        protected int DelegateSelectCount(LdPublisherCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<LdPublisher> DelegateSelectList(LdPublisherCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(LdPublisher e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(LdPublisher e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateModifiedOnly(e); }
        protected int DelegateUpdateNonstrict(LdPublisher e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(LdPublisher e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.Delete(e); }
        protected int DelegateDeleteNonstrict(LdPublisher e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected LdPublisher Downcast(LdEntity entity) {
            return (LdPublisher)entity;
        }

        protected LdPublisherCB Downcast(LdConditionBean cb) {
            return (LdPublisherCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual LdPublisherDao Dao { get { return _dao; } set { _dao = value; } }
    }
}

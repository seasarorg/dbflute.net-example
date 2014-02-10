
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
    public partial class LdBookBhv : DfExample.DBFlute.LibraryDb.AllCommon.Bhv.LdAbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected LdBookDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public LdBookBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "book"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override LdDBMeta DBMeta { get { return LdBookDbm.GetInstance(); } }
        public LdBookDbm MyDBMeta { get { return LdBookDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override LdEntity NewEntity() { return NewMyEntity(); }
        public override LdConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual LdBook NewMyEntity() { return new LdBook(); }
        public virtual LdBookCB NewMyConditionBean() { return new LdBookCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(LdBookCB cb) {
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
        public virtual LdBook SelectEntity(LdBookCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<LdBook> ls = null;
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
            return (LdBook)ls[0];
        }

        protected override LdEntity DoReadEntity(LdConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual LdBook SelectEntityWithDeletedCheck(LdBookCB cb) {
            AssertConditionBeanNotNull(cb);
            LdBook entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override LdEntity DoReadEntityWithDeletedCheck(LdConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual LdBook SelectByPKValue(int? bookId) {
            return SelectEntity(BuildPKCB(bookId));
        }

        public virtual LdBook SelectByPKValueWithDeletedCheck(int? bookId) {
            return SelectEntityWithDeletedCheck(BuildPKCB(bookId));
        }

        private LdBookCB BuildPKCB(int? bookId) {
            AssertObjectNotNull("bookId", bookId);
            LdBookCB cb = NewMyConditionBean();
            cb.Query().SetBookId_Equal(bookId);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual LdListResultBean<LdBook> SelectList(LdBookCB cb) {
            AssertConditionBeanNotNull(cb);
            return new LdResultBeanBuilder<LdBook>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual LdPagingResultBean<LdBook> SelectPage(LdBookCB cb) {
            AssertConditionBeanNotNull(cb);
            LdPagingInvoker<LdBook> invoker = new LdPagingInvoker<LdBook>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : LdPagingHandler<LdBook> {
            protected LdBookBhv _bhv; protected LdBookCB _cb;
            public InternalSelectPagingHandler(LdBookBhv bhv, LdBookCB cb) { _bhv = bhv; _cb = cb; }
            public LdPagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<LdBook> Paging() { return _bhv.SelectList(_cb); }
        }
        #endregion

        // ===============================================================================
        //                                                                   Load Referrer
        //                                                                   =============
        #region Load Referrer
        public virtual void LoadCollectionList(LdBook book, LdConditionBeanSetupper<LdCollectionCB> conditionBeanSetupper) {
            AssertObjectNotNull("book", book); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadCollectionList(xnewLRLs<LdBook>(book), conditionBeanSetupper);
        }
        public virtual void LoadCollectionList(IList<LdBook> bookList, LdConditionBeanSetupper<LdCollectionCB> conditionBeanSetupper) {
            AssertObjectNotNull("bookList", bookList); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadCollectionList(bookList, new LdLoadReferrerOption<LdCollectionCB, LdCollection>().xinit(conditionBeanSetupper));
        }
        public virtual void LoadCollectionList(LdBook book, LdLoadReferrerOption<LdCollectionCB, LdCollection> loadReferrerOption) {
            AssertObjectNotNull("book", book); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            LoadCollectionList(xnewLRLs<LdBook>(book), loadReferrerOption);
        }
        public virtual void LoadCollectionList(IList<LdBook> bookList, LdLoadReferrerOption<LdCollectionCB, LdCollection> loadReferrerOption) {
            AssertObjectNotNull("bookList", bookList); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            if (bookList.Count == 0) { return; }
            LdCollectionBhv referrerBhv = xgetBSFLR().Select<LdCollectionBhv>();
            HelpLoadReferrerInternally<LdBook, int?, LdCollectionCB, LdCollection>
                    (bookList, loadReferrerOption, new MyInternalLoadCollectionListCallback(referrerBhv));
        }
        protected class MyInternalLoadCollectionListCallback : InternalLoadReferrerCallback<LdBook, int?, LdCollectionCB, LdCollection> {
            protected LdCollectionBhv referrerBhv;
            public MyInternalLoadCollectionListCallback(LdCollectionBhv referrerBhv) { this.referrerBhv = referrerBhv; }
            public int? getPKVal(LdBook e) { return e.BookId; }
            public void setRfLs(LdBook e, IList<LdCollection> ls) { e.CollectionList = ls; }
            public LdCollectionCB newMyCB() { return referrerBhv.NewMyConditionBean(); }
            public void qyFKIn(LdCollectionCB cb, IList<int?> ls) { cb.Query().SetBookId_InScope(ls); }
            public void qyOdFKAsc(LdCollectionCB cb) { cb.Query().AddOrderBy_BookId_Asc(); }
            public void spFKCol(LdCollectionCB cb) { cb.Specify().ColumnBookId(); }
            public IList<LdCollection> selRfLs(LdCollectionCB cb) { return referrerBhv.SelectList(cb); }
            public int? getFKVal(LdCollection e) { return e.BookId; }
            public void setlcEt(LdCollection re, LdBook be) { re.Book = be; }
        }
        #endregion

        // ===============================================================================
        //                                                                Pull out Foreign
        //                                                                ================
        #region Pullout Foreign
        public IList<LdAuthor> PulloutAuthor(IList<LdBook> bookList) {
            return HelpPulloutInternally<LdBook, LdAuthor>(bookList, new MyInternalPulloutAuthorCallback());
        }
        protected class MyInternalPulloutAuthorCallback : InternalPulloutCallback<LdBook, LdAuthor> {
            public LdAuthor getFr(LdBook entity) { return entity.Author; }
        }
        public IList<LdGenre> PulloutGenre(IList<LdBook> bookList) {
            return HelpPulloutInternally<LdBook, LdGenre>(bookList, new MyInternalPulloutGenreCallback());
        }
        protected class MyInternalPulloutGenreCallback : InternalPulloutCallback<LdBook, LdGenre> {
            public LdGenre getFr(LdBook entity) { return entity.Genre; }
        }
        public IList<LdPublisher> PulloutPublisher(IList<LdBook> bookList) {
            return HelpPulloutInternally<LdBook, LdPublisher>(bookList, new MyInternalPulloutPublisherCallback());
        }
        protected class MyInternalPulloutPublisherCallback : InternalPulloutCallback<LdBook, LdPublisher> {
            public LdPublisher getFr(LdBook entity) { return entity.Publisher; }
        }
        public IList<LdCollectionStatusLookup> PulloutCollectionStatusLookupAsNonExist(IList<LdBook> bookList) {
            return HelpPulloutInternally<LdBook, LdCollectionStatusLookup>(bookList, new MyInternalPulloutCollectionStatusLookupAsNonExistCallback());
        }
        protected class MyInternalPulloutCollectionStatusLookupAsNonExistCallback : InternalPulloutCallback<LdBook, LdCollectionStatusLookup> {
            public LdCollectionStatusLookup getFr(LdBook entity) { return entity.CollectionStatusLookupAsNonExist; }
        }
        #endregion


        // ===============================================================================
        //                                                                   Entity Update
        //                                                                   =============
        #region Basic Entity Update
        public virtual void Insert(LdBook entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(LdEntity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(LdBook entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(LdEntity entity) {
            Update(Downcast(entity));
        }

        public virtual void UpdateNonstrict(LdBook entity) {
            AssertEntityNotNull(entity);
            int updatedCount = this.DelegateUpdateNonstrict(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        public void InsertOrUpdate(LdBook entity) {
            HelpInsertOrUpdateInternally<LdBook, LdBookCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<LdBook, LdBookCB> {
            protected LdBookBhv _bhv;
            public MyInternalInsertOrUpdateCallback(LdBookBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(LdBook entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(LdBook entity) { _bhv.Update(entity); }
            public LdBookCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(LdBookCB cb, LdBook entity) {
                cb.Query().SetBookId_Equal(entity.BookId);
            }
            public int CallbackSelectCount(LdBookCB cb) { return _bhv.SelectCount(cb); }
        }

        public void InsertOrUpdateNonstrict(LdBook entity) {
            HelpInsertOrUpdateInternally<LdBook>(entity, new MyInternalInsertOrUpdateNonstrictCallback(this));
        }
        protected class MyInternalInsertOrUpdateNonstrictCallback : InternalInsertOrUpdateNonstrictCallback<LdBook> {
            protected LdBookBhv _bhv;
            public MyInternalInsertOrUpdateNonstrictCallback(LdBookBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(LdBook entity) { _bhv.Insert(entity); }
            public void CallbackUpdateNonstrict(LdBook entity) { _bhv.UpdateNonstrict(entity); }
        }

        public virtual void Delete(LdBook entity) {
            HelpDeleteInternally<LdBook>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(LdEntity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<LdBook> {
            protected LdBookBhv _bhv;
            public MyInternalDeleteCallback(LdBookBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(LdBook entity) { return _bhv.DelegateDelete(entity); }
        }

        public virtual void DeleteNonstrict(LdBook entity) {
            HelpDeleteNonstrictInternally<LdBook>(entity, new MyInternalDeleteNonstrictCallback(this));
        }
        protected class MyInternalDeleteNonstrictCallback : InternalDeleteNonstrictCallback<LdBook> {
            protected LdBookBhv _bhv;
            public MyInternalDeleteNonstrictCallback(LdBookBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDeleteNonstrict(LdBook entity) { return _bhv.DelegateDeleteNonstrict(entity); }
        }

        public virtual void DeleteNonstrictIgnoreDeleted(LdBook entity) {
            HelpDeleteNonstrictIgnoreDeletedInternally<LdBook>(entity, new MyInternalDeleteNonstrictIgnoreDeletedCallback(this));
        }
        protected class MyInternalDeleteNonstrictIgnoreDeletedCallback : InternalDeleteNonstrictIgnoreDeletedCallback<LdBook> {
            protected LdBookBhv _bhv;
            public MyInternalDeleteNonstrictIgnoreDeletedCallback(LdBookBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDeleteNonstrict(LdBook entity) { return _bhv.DelegateDeleteNonstrict(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(LdBook book, LdBookCB cb) {
            AssertObjectNotNull("book", book); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(book);
            FilterEntityOfUpdate(book); AssertEntityOfUpdate(book);
            return this.Dao.UpdateByQuery(cb, book);
        }

        public int QueryDelete(LdBookCB cb) {
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
        protected int DelegateSelectCount(LdBookCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<LdBook> DelegateSelectList(LdBookCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(LdBook e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(LdBook e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateModifiedOnly(e); }
        protected int DelegateUpdateNonstrict(LdBook e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(LdBook e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.Delete(e); }
        protected int DelegateDeleteNonstrict(LdBook e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected LdBook Downcast(LdEntity entity) {
            return (LdBook)entity;
        }

        protected LdBookCB Downcast(LdConditionBean cb) {
            return (LdBookCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual LdBookDao Dao { get { return _dao; } set { _dao = value; } }
    }
}

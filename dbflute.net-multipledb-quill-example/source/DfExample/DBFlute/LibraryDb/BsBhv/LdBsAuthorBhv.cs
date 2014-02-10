
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
    public partial class LdAuthorBhv : DfExample.DBFlute.LibraryDb.AllCommon.Bhv.LdAbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected LdAuthorDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public LdAuthorBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "author"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override LdDBMeta DBMeta { get { return LdAuthorDbm.GetInstance(); } }
        public LdAuthorDbm MyDBMeta { get { return LdAuthorDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override LdEntity NewEntity() { return NewMyEntity(); }
        public override LdConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual LdAuthor NewMyEntity() { return new LdAuthor(); }
        public virtual LdAuthorCB NewMyConditionBean() { return new LdAuthorCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(LdAuthorCB cb) {
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
        public virtual LdAuthor SelectEntity(LdAuthorCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<LdAuthor> ls = null;
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
            return (LdAuthor)ls[0];
        }

        protected override LdEntity DoReadEntity(LdConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual LdAuthor SelectEntityWithDeletedCheck(LdAuthorCB cb) {
            AssertConditionBeanNotNull(cb);
            LdAuthor entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override LdEntity DoReadEntityWithDeletedCheck(LdConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual LdAuthor SelectByPKValue(int? authorId) {
            return SelectEntity(BuildPKCB(authorId));
        }

        public virtual LdAuthor SelectByPKValueWithDeletedCheck(int? authorId) {
            return SelectEntityWithDeletedCheck(BuildPKCB(authorId));
        }

        private LdAuthorCB BuildPKCB(int? authorId) {
            AssertObjectNotNull("authorId", authorId);
            LdAuthorCB cb = NewMyConditionBean();
            cb.Query().SetAuthorId_Equal(authorId);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual LdListResultBean<LdAuthor> SelectList(LdAuthorCB cb) {
            AssertConditionBeanNotNull(cb);
            return new LdResultBeanBuilder<LdAuthor>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual LdPagingResultBean<LdAuthor> SelectPage(LdAuthorCB cb) {
            AssertConditionBeanNotNull(cb);
            LdPagingInvoker<LdAuthor> invoker = new LdPagingInvoker<LdAuthor>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : LdPagingHandler<LdAuthor> {
            protected LdAuthorBhv _bhv; protected LdAuthorCB _cb;
            public InternalSelectPagingHandler(LdAuthorBhv bhv, LdAuthorCB cb) { _bhv = bhv; _cb = cb; }
            public LdPagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<LdAuthor> Paging() { return _bhv.SelectList(_cb); }
        }
        #endregion

        // ===============================================================================
        //                                                                   Load Referrer
        //                                                                   =============
        #region Load Referrer
        public virtual void LoadBookList(LdAuthor author, LdConditionBeanSetupper<LdBookCB> conditionBeanSetupper) {
            AssertObjectNotNull("author", author); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadBookList(xnewLRLs<LdAuthor>(author), conditionBeanSetupper);
        }
        public virtual void LoadBookList(IList<LdAuthor> authorList, LdConditionBeanSetupper<LdBookCB> conditionBeanSetupper) {
            AssertObjectNotNull("authorList", authorList); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadBookList(authorList, new LdLoadReferrerOption<LdBookCB, LdBook>().xinit(conditionBeanSetupper));
        }
        public virtual void LoadBookList(LdAuthor author, LdLoadReferrerOption<LdBookCB, LdBook> loadReferrerOption) {
            AssertObjectNotNull("author", author); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            LoadBookList(xnewLRLs<LdAuthor>(author), loadReferrerOption);
        }
        public virtual void LoadBookList(IList<LdAuthor> authorList, LdLoadReferrerOption<LdBookCB, LdBook> loadReferrerOption) {
            AssertObjectNotNull("authorList", authorList); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            if (authorList.Count == 0) { return; }
            LdBookBhv referrerBhv = xgetBSFLR().Select<LdBookBhv>();
            HelpLoadReferrerInternally<LdAuthor, int?, LdBookCB, LdBook>
                    (authorList, loadReferrerOption, new MyInternalLoadBookListCallback(referrerBhv));
        }
        protected class MyInternalLoadBookListCallback : InternalLoadReferrerCallback<LdAuthor, int?, LdBookCB, LdBook> {
            protected LdBookBhv referrerBhv;
            public MyInternalLoadBookListCallback(LdBookBhv referrerBhv) { this.referrerBhv = referrerBhv; }
            public int? getPKVal(LdAuthor e) { return e.AuthorId; }
            public void setRfLs(LdAuthor e, IList<LdBook> ls) { e.BookList = ls; }
            public LdBookCB newMyCB() { return referrerBhv.NewMyConditionBean(); }
            public void qyFKIn(LdBookCB cb, IList<int?> ls) { cb.Query().SetAuthorId_InScope(ls); }
            public void qyOdFKAsc(LdBookCB cb) { cb.Query().AddOrderBy_AuthorId_Asc(); }
            public void spFKCol(LdBookCB cb) { cb.Specify().ColumnAuthorId(); }
            public IList<LdBook> selRfLs(LdBookCB cb) { return referrerBhv.SelectList(cb); }
            public int? getFKVal(LdBook e) { return e.AuthorId; }
            public void setlcEt(LdBook re, LdAuthor be) { re.Author = be; }
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
        public virtual void Insert(LdAuthor entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(LdEntity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(LdAuthor entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(LdEntity entity) {
            Update(Downcast(entity));
        }

        public virtual void UpdateNonstrict(LdAuthor entity) {
            AssertEntityNotNull(entity);
            int updatedCount = this.DelegateUpdateNonstrict(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        public void InsertOrUpdate(LdAuthor entity) {
            HelpInsertOrUpdateInternally<LdAuthor, LdAuthorCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<LdAuthor, LdAuthorCB> {
            protected LdAuthorBhv _bhv;
            public MyInternalInsertOrUpdateCallback(LdAuthorBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(LdAuthor entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(LdAuthor entity) { _bhv.Update(entity); }
            public LdAuthorCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(LdAuthorCB cb, LdAuthor entity) {
                cb.Query().SetAuthorId_Equal(entity.AuthorId);
            }
            public int CallbackSelectCount(LdAuthorCB cb) { return _bhv.SelectCount(cb); }
        }

        public void InsertOrUpdateNonstrict(LdAuthor entity) {
            HelpInsertOrUpdateInternally<LdAuthor>(entity, new MyInternalInsertOrUpdateNonstrictCallback(this));
        }
        protected class MyInternalInsertOrUpdateNonstrictCallback : InternalInsertOrUpdateNonstrictCallback<LdAuthor> {
            protected LdAuthorBhv _bhv;
            public MyInternalInsertOrUpdateNonstrictCallback(LdAuthorBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(LdAuthor entity) { _bhv.Insert(entity); }
            public void CallbackUpdateNonstrict(LdAuthor entity) { _bhv.UpdateNonstrict(entity); }
        }

        public virtual void Delete(LdAuthor entity) {
            HelpDeleteInternally<LdAuthor>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(LdEntity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<LdAuthor> {
            protected LdAuthorBhv _bhv;
            public MyInternalDeleteCallback(LdAuthorBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(LdAuthor entity) { return _bhv.DelegateDelete(entity); }
        }

        public virtual void DeleteNonstrict(LdAuthor entity) {
            HelpDeleteNonstrictInternally<LdAuthor>(entity, new MyInternalDeleteNonstrictCallback(this));
        }
        protected class MyInternalDeleteNonstrictCallback : InternalDeleteNonstrictCallback<LdAuthor> {
            protected LdAuthorBhv _bhv;
            public MyInternalDeleteNonstrictCallback(LdAuthorBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDeleteNonstrict(LdAuthor entity) { return _bhv.DelegateDeleteNonstrict(entity); }
        }

        public virtual void DeleteNonstrictIgnoreDeleted(LdAuthor entity) {
            HelpDeleteNonstrictIgnoreDeletedInternally<LdAuthor>(entity, new MyInternalDeleteNonstrictIgnoreDeletedCallback(this));
        }
        protected class MyInternalDeleteNonstrictIgnoreDeletedCallback : InternalDeleteNonstrictIgnoreDeletedCallback<LdAuthor> {
            protected LdAuthorBhv _bhv;
            public MyInternalDeleteNonstrictIgnoreDeletedCallback(LdAuthorBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDeleteNonstrict(LdAuthor entity) { return _bhv.DelegateDeleteNonstrict(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(LdAuthor author, LdAuthorCB cb) {
            AssertObjectNotNull("author", author); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(author);
            FilterEntityOfUpdate(author); AssertEntityOfUpdate(author);
            return this.Dao.UpdateByQuery(cb, author);
        }

        public int QueryDelete(LdAuthorCB cb) {
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
        protected int DelegateSelectCount(LdAuthorCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<LdAuthor> DelegateSelectList(LdAuthorCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(LdAuthor e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(LdAuthor e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateModifiedOnly(e); }
        protected int DelegateUpdateNonstrict(LdAuthor e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(LdAuthor e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.Delete(e); }
        protected int DelegateDeleteNonstrict(LdAuthor e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected LdAuthor Downcast(LdEntity entity) {
            return (LdAuthor)entity;
        }

        protected LdAuthorCB Downcast(LdConditionBean cb) {
            return (LdAuthorCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual LdAuthorDao Dao { get { return _dao; } set { _dao = value; } }
    }
}


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
    public partial class LdGenreBhv : DfExample.DBFlute.LibraryDb.AllCommon.Bhv.LdAbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected LdGenreDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public LdGenreBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "genre"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override LdDBMeta DBMeta { get { return LdGenreDbm.GetInstance(); } }
        public LdGenreDbm MyDBMeta { get { return LdGenreDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override LdEntity NewEntity() { return NewMyEntity(); }
        public override LdConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual LdGenre NewMyEntity() { return new LdGenre(); }
        public virtual LdGenreCB NewMyConditionBean() { return new LdGenreCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(LdGenreCB cb) {
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
        public virtual LdGenre SelectEntity(LdGenreCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<LdGenre> ls = null;
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
            return (LdGenre)ls[0];
        }

        protected override LdEntity DoReadEntity(LdConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual LdGenre SelectEntityWithDeletedCheck(LdGenreCB cb) {
            AssertConditionBeanNotNull(cb);
            LdGenre entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override LdEntity DoReadEntityWithDeletedCheck(LdConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual LdGenre SelectByPKValue(String genreCode) {
            return SelectEntity(BuildPKCB(genreCode));
        }

        public virtual LdGenre SelectByPKValueWithDeletedCheck(String genreCode) {
            return SelectEntityWithDeletedCheck(BuildPKCB(genreCode));
        }

        private LdGenreCB BuildPKCB(String genreCode) {
            AssertObjectNotNull("genreCode", genreCode);
            LdGenreCB cb = NewMyConditionBean();
            cb.Query().SetGenreCode_Equal(genreCode);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual LdListResultBean<LdGenre> SelectList(LdGenreCB cb) {
            AssertConditionBeanNotNull(cb);
            return new LdResultBeanBuilder<LdGenre>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual LdPagingResultBean<LdGenre> SelectPage(LdGenreCB cb) {
            AssertConditionBeanNotNull(cb);
            LdPagingInvoker<LdGenre> invoker = new LdPagingInvoker<LdGenre>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : LdPagingHandler<LdGenre> {
            protected LdGenreBhv _bhv; protected LdGenreCB _cb;
            public InternalSelectPagingHandler(LdGenreBhv bhv, LdGenreCB cb) { _bhv = bhv; _cb = cb; }
            public LdPagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<LdGenre> Paging() { return _bhv.SelectList(_cb); }
        }
        #endregion

        // ===============================================================================
        //                                                                   Load Referrer
        //                                                                   =============
        #region Load Referrer
        public virtual void LoadBookList(LdGenre genre, LdConditionBeanSetupper<LdBookCB> conditionBeanSetupper) {
            AssertObjectNotNull("genre", genre); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadBookList(xnewLRLs<LdGenre>(genre), conditionBeanSetupper);
        }
        public virtual void LoadBookList(IList<LdGenre> genreList, LdConditionBeanSetupper<LdBookCB> conditionBeanSetupper) {
            AssertObjectNotNull("genreList", genreList); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadBookList(genreList, new LdLoadReferrerOption<LdBookCB, LdBook>().xinit(conditionBeanSetupper));
        }
        public virtual void LoadBookList(LdGenre genre, LdLoadReferrerOption<LdBookCB, LdBook> loadReferrerOption) {
            AssertObjectNotNull("genre", genre); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            LoadBookList(xnewLRLs<LdGenre>(genre), loadReferrerOption);
        }
        public virtual void LoadBookList(IList<LdGenre> genreList, LdLoadReferrerOption<LdBookCB, LdBook> loadReferrerOption) {
            AssertObjectNotNull("genreList", genreList); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            if (genreList.Count == 0) { return; }
            LdBookBhv referrerBhv = xgetBSFLR().Select<LdBookBhv>();
            HelpLoadReferrerInternally<LdGenre, String, LdBookCB, LdBook>
                    (genreList, loadReferrerOption, new MyInternalLoadBookListCallback(referrerBhv));
        }
        protected class MyInternalLoadBookListCallback : InternalLoadReferrerCallback<LdGenre, String, LdBookCB, LdBook> {
            protected LdBookBhv referrerBhv;
            public MyInternalLoadBookListCallback(LdBookBhv referrerBhv) { this.referrerBhv = referrerBhv; }
            public String getPKVal(LdGenre e) { return e.GenreCode; }
            public void setRfLs(LdGenre e, IList<LdBook> ls) { e.BookList = ls; }
            public LdBookCB newMyCB() { return referrerBhv.NewMyConditionBean(); }
            public void qyFKIn(LdBookCB cb, IList<String> ls) { cb.Query().SetGenreCode_InScope(ls); }
            public void qyOdFKAsc(LdBookCB cb) { cb.Query().AddOrderBy_GenreCode_Asc(); }
            public void spFKCol(LdBookCB cb) { cb.Specify().ColumnGenreCode(); }
            public IList<LdBook> selRfLs(LdBookCB cb) { return referrerBhv.SelectList(cb); }
            public String getFKVal(LdBook e) { return e.GenreCode; }
            public void setlcEt(LdBook re, LdGenre be) { re.Genre = be; }
        }
        public virtual void LoadGenreSelfList(LdGenre genre, LdConditionBeanSetupper<LdGenreCB> conditionBeanSetupper) {
            AssertObjectNotNull("genre", genre); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadGenreSelfList(xnewLRLs<LdGenre>(genre), conditionBeanSetupper);
        }
        public virtual void LoadGenreSelfList(IList<LdGenre> genreList, LdConditionBeanSetupper<LdGenreCB> conditionBeanSetupper) {
            AssertObjectNotNull("genreList", genreList); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadGenreSelfList(genreList, new LdLoadReferrerOption<LdGenreCB, LdGenre>().xinit(conditionBeanSetupper));
        }
        public virtual void LoadGenreSelfList(LdGenre genre, LdLoadReferrerOption<LdGenreCB, LdGenre> loadReferrerOption) {
            AssertObjectNotNull("genre", genre); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            LoadGenreSelfList(xnewLRLs<LdGenre>(genre), loadReferrerOption);
        }
        public virtual void LoadGenreSelfList(IList<LdGenre> genreList, LdLoadReferrerOption<LdGenreCB, LdGenre> loadReferrerOption) {
            AssertObjectNotNull("genreList", genreList); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            if (genreList.Count == 0) { return; }
            LdGenreBhv referrerBhv = xgetBSFLR().Select<LdGenreBhv>();
            HelpLoadReferrerInternally<LdGenre, String, LdGenreCB, LdGenre>
                    (genreList, loadReferrerOption, new MyInternalLoadGenreSelfListCallback(referrerBhv));
        }
        protected class MyInternalLoadGenreSelfListCallback : InternalLoadReferrerCallback<LdGenre, String, LdGenreCB, LdGenre> {
            protected LdGenreBhv referrerBhv;
            public MyInternalLoadGenreSelfListCallback(LdGenreBhv referrerBhv) { this.referrerBhv = referrerBhv; }
            public String getPKVal(LdGenre e) { return e.GenreCode; }
            public void setRfLs(LdGenre e, IList<LdGenre> ls) { e.GenreSelfList = ls; }
            public LdGenreCB newMyCB() { return referrerBhv.NewMyConditionBean(); }
            public void qyFKIn(LdGenreCB cb, IList<String> ls) { cb.Query().SetParentGenreCode_InScope(ls); }
            public void qyOdFKAsc(LdGenreCB cb) { cb.Query().AddOrderBy_ParentGenreCode_Asc(); }
            public void spFKCol(LdGenreCB cb) { cb.Specify().ColumnParentGenreCode(); }
            public IList<LdGenre> selRfLs(LdGenreCB cb) { return referrerBhv.SelectList(cb); }
            public String getFKVal(LdGenre e) { return e.ParentGenreCode; }
            public void setlcEt(LdGenre re, LdGenre be) { re.GenreSelf = be; }
        }
        #endregion

        // ===============================================================================
        //                                                                Pull out Foreign
        //                                                                ================
        #region Pullout Foreign
        public IList<LdGenre> PulloutGenreSelf(IList<LdGenre> genreList) {
            return HelpPulloutInternally<LdGenre, LdGenre>(genreList, new MyInternalPulloutGenreSelfCallback());
        }
        protected class MyInternalPulloutGenreSelfCallback : InternalPulloutCallback<LdGenre, LdGenre> {
            public LdGenre getFr(LdGenre entity) { return entity.GenreSelf; }
        }
        #endregion


        // ===============================================================================
        //                                                                   Entity Update
        //                                                                   =============
        #region Basic Entity Update
        public virtual void Insert(LdGenre entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(LdEntity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(LdGenre entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(LdEntity entity) {
            Update(Downcast(entity));
        }

        public virtual void UpdateNonstrict(LdGenre entity) {
            AssertEntityNotNull(entity);
            int updatedCount = this.DelegateUpdateNonstrict(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        public void InsertOrUpdate(LdGenre entity) {
            HelpInsertOrUpdateInternally<LdGenre, LdGenreCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<LdGenre, LdGenreCB> {
            protected LdGenreBhv _bhv;
            public MyInternalInsertOrUpdateCallback(LdGenreBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(LdGenre entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(LdGenre entity) { _bhv.Update(entity); }
            public LdGenreCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(LdGenreCB cb, LdGenre entity) {
                cb.Query().SetGenreCode_Equal(entity.GenreCode);
            }
            public int CallbackSelectCount(LdGenreCB cb) { return _bhv.SelectCount(cb); }
        }

        public void InsertOrUpdateNonstrict(LdGenre entity) {
            HelpInsertOrUpdateInternally<LdGenre>(entity, new MyInternalInsertOrUpdateNonstrictCallback(this));
        }
        protected class MyInternalInsertOrUpdateNonstrictCallback : InternalInsertOrUpdateNonstrictCallback<LdGenre> {
            protected LdGenreBhv _bhv;
            public MyInternalInsertOrUpdateNonstrictCallback(LdGenreBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(LdGenre entity) { _bhv.Insert(entity); }
            public void CallbackUpdateNonstrict(LdGenre entity) { _bhv.UpdateNonstrict(entity); }
        }

        public virtual void Delete(LdGenre entity) {
            HelpDeleteInternally<LdGenre>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(LdEntity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<LdGenre> {
            protected LdGenreBhv _bhv;
            public MyInternalDeleteCallback(LdGenreBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(LdGenre entity) { return _bhv.DelegateDelete(entity); }
        }

        public virtual void DeleteNonstrict(LdGenre entity) {
            HelpDeleteNonstrictInternally<LdGenre>(entity, new MyInternalDeleteNonstrictCallback(this));
        }
        protected class MyInternalDeleteNonstrictCallback : InternalDeleteNonstrictCallback<LdGenre> {
            protected LdGenreBhv _bhv;
            public MyInternalDeleteNonstrictCallback(LdGenreBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDeleteNonstrict(LdGenre entity) { return _bhv.DelegateDeleteNonstrict(entity); }
        }

        public virtual void DeleteNonstrictIgnoreDeleted(LdGenre entity) {
            HelpDeleteNonstrictIgnoreDeletedInternally<LdGenre>(entity, new MyInternalDeleteNonstrictIgnoreDeletedCallback(this));
        }
        protected class MyInternalDeleteNonstrictIgnoreDeletedCallback : InternalDeleteNonstrictIgnoreDeletedCallback<LdGenre> {
            protected LdGenreBhv _bhv;
            public MyInternalDeleteNonstrictIgnoreDeletedCallback(LdGenreBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDeleteNonstrict(LdGenre entity) { return _bhv.DelegateDeleteNonstrict(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(LdGenre genre, LdGenreCB cb) {
            AssertObjectNotNull("genre", genre); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(genre);
            FilterEntityOfUpdate(genre); AssertEntityOfUpdate(genre);
            return this.Dao.UpdateByQuery(cb, genre);
        }

        public int QueryDelete(LdGenreCB cb) {
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
        protected int DelegateSelectCount(LdGenreCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<LdGenre> DelegateSelectList(LdGenreCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(LdGenre e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(LdGenre e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateModifiedOnly(e); }
        protected int DelegateUpdateNonstrict(LdGenre e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(LdGenre e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.Delete(e); }
        protected int DelegateDeleteNonstrict(LdGenre e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected LdGenre Downcast(LdEntity entity) {
            return (LdGenre)entity;
        }

        protected LdGenreCB Downcast(LdConditionBean cb) {
            return (LdGenreCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual LdGenreDao Dao { get { return _dao; } set { _dao = value; } }
    }
}

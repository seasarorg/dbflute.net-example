
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
    public partial class LdLibraryTypeLookupBhv : DfExample.DBFlute.LibraryDb.AllCommon.Bhv.LdAbstractBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /*df:beginQueryPath*/
        /*df:endQueryPath*/

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected LdLibraryTypeLookupDao _dao;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public LdLibraryTypeLookupBhv() {
        }
        
        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public override bool IsInitialized { get { return _dao != null; } }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "library_type_lookup"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public override LdDBMeta DBMeta { get { return LdLibraryTypeLookupDbm.GetInstance(); } }
        public LdLibraryTypeLookupDbm MyDBMeta { get { return LdLibraryTypeLookupDbm.GetInstance(); } }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        #region New Instance
        public override LdEntity NewEntity() { return NewMyEntity(); }
        public override LdConditionBean NewConditionBean() { return NewMyConditionBean(); }
        public virtual LdLibraryTypeLookup NewMyEntity() { return new LdLibraryTypeLookup(); }
        public virtual LdLibraryTypeLookupCB NewMyConditionBean() { return new LdLibraryTypeLookupCB(); }
        #endregion

        // ===============================================================================
        //                                                                    Count Select
        //                                                                    ============
        #region Count Select
        public virtual int SelectCount(LdLibraryTypeLookupCB cb) {
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
        public virtual LdLibraryTypeLookup SelectEntity(LdLibraryTypeLookupCB cb) {
            AssertConditionBeanNotNull(cb);
            if (!cb.HasWhereClause() && cb.FetchSize != 1) { // if no condition for one
                throwSelectEntityConditionNotFoundException(cb);
            }
            int preSafetyMaxResultSize = xcheckSafetyResultAsOne(cb);
            IList<LdLibraryTypeLookup> ls = null;
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
            return (LdLibraryTypeLookup)ls[0];
        }

        protected override LdEntity DoReadEntity(LdConditionBean cb) {
            return SelectEntity(Downcast(cb));
        }

        public virtual LdLibraryTypeLookup SelectEntityWithDeletedCheck(LdLibraryTypeLookupCB cb) {
            AssertConditionBeanNotNull(cb);
            LdLibraryTypeLookup entity = SelectEntity(cb);
            AssertEntityNotDeleted(entity, cb);
            return entity;
        }

        protected override LdEntity DoReadEntityWithDeletedCheck(LdConditionBean cb) {
            return SelectEntityWithDeletedCheck(Downcast(cb));
        }

        public virtual LdLibraryTypeLookup SelectByPKValue(String libraryTypeCode) {
            return SelectEntity(BuildPKCB(libraryTypeCode));
        }

        public virtual LdLibraryTypeLookup SelectByPKValueWithDeletedCheck(String libraryTypeCode) {
            return SelectEntityWithDeletedCheck(BuildPKCB(libraryTypeCode));
        }

        private LdLibraryTypeLookupCB BuildPKCB(String libraryTypeCode) {
            AssertObjectNotNull("libraryTypeCode", libraryTypeCode);
            LdLibraryTypeLookupCB cb = NewMyConditionBean();
            cb.Query().SetLibraryTypeCode_Equal(libraryTypeCode);
            return cb;            
        }
        #endregion

        // ===============================================================================
        //                                                                     List Select
        //                                                                     ===========
        #region List Select
        public virtual LdListResultBean<LdLibraryTypeLookup> SelectList(LdLibraryTypeLookupCB cb) {
            AssertConditionBeanNotNull(cb);
            return new LdResultBeanBuilder<LdLibraryTypeLookup>(TableDbName).BuildListResultBean(cb, this.DelegateSelectList(cb));
        }
        #endregion

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        #region Page Select
        public virtual LdPagingResultBean<LdLibraryTypeLookup> SelectPage(LdLibraryTypeLookupCB cb) {
            AssertConditionBeanNotNull(cb);
            LdPagingInvoker<LdLibraryTypeLookup> invoker = new LdPagingInvoker<LdLibraryTypeLookup>(TableDbName);
            return invoker.InvokePaging(new InternalSelectPagingHandler(this, cb));
        }

        private class InternalSelectPagingHandler : LdPagingHandler<LdLibraryTypeLookup> {
            protected LdLibraryTypeLookupBhv _bhv; protected LdLibraryTypeLookupCB _cb;
            public InternalSelectPagingHandler(LdLibraryTypeLookupBhv bhv, LdLibraryTypeLookupCB cb) { _bhv = bhv; _cb = cb; }
            public LdPagingBean PagingBean { get { return _cb; } }
            public int Count() { return _bhv.SelectCount(_cb); }
            public IList<LdLibraryTypeLookup> Paging() { return _bhv.SelectList(_cb); }
        }
        #endregion

        // ===============================================================================
        //                                                                   Load Referrer
        //                                                                   =============
        #region Load Referrer
        public virtual void LoadLibraryList(LdLibraryTypeLookup libraryTypeLookup, LdConditionBeanSetupper<LdLibraryCB> conditionBeanSetupper) {
            AssertObjectNotNull("libraryTypeLookup", libraryTypeLookup); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadLibraryList(xnewLRLs<LdLibraryTypeLookup>(libraryTypeLookup), conditionBeanSetupper);
        }
        public virtual void LoadLibraryList(IList<LdLibraryTypeLookup> libraryTypeLookupList, LdConditionBeanSetupper<LdLibraryCB> conditionBeanSetupper) {
            AssertObjectNotNull("libraryTypeLookupList", libraryTypeLookupList); AssertObjectNotNull("conditionBeanSetupper", conditionBeanSetupper);
            LoadLibraryList(libraryTypeLookupList, new LdLoadReferrerOption<LdLibraryCB, LdLibrary>().xinit(conditionBeanSetupper));
        }
        public virtual void LoadLibraryList(LdLibraryTypeLookup libraryTypeLookup, LdLoadReferrerOption<LdLibraryCB, LdLibrary> loadReferrerOption) {
            AssertObjectNotNull("libraryTypeLookup", libraryTypeLookup); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            LoadLibraryList(xnewLRLs<LdLibraryTypeLookup>(libraryTypeLookup), loadReferrerOption);
        }
        public virtual void LoadLibraryList(IList<LdLibraryTypeLookup> libraryTypeLookupList, LdLoadReferrerOption<LdLibraryCB, LdLibrary> loadReferrerOption) {
            AssertObjectNotNull("libraryTypeLookupList", libraryTypeLookupList); AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            if (libraryTypeLookupList.Count == 0) { return; }
            LdLibraryBhv referrerBhv = xgetBSFLR().Select<LdLibraryBhv>();
            HelpLoadReferrerInternally<LdLibraryTypeLookup, String, LdLibraryCB, LdLibrary>
                    (libraryTypeLookupList, loadReferrerOption, new MyInternalLoadLibraryListCallback(referrerBhv));
        }
        protected class MyInternalLoadLibraryListCallback : InternalLoadReferrerCallback<LdLibraryTypeLookup, String, LdLibraryCB, LdLibrary> {
            protected LdLibraryBhv referrerBhv;
            public MyInternalLoadLibraryListCallback(LdLibraryBhv referrerBhv) { this.referrerBhv = referrerBhv; }
            public String getPKVal(LdLibraryTypeLookup e) { return e.LibraryTypeCode; }
            public void setRfLs(LdLibraryTypeLookup e, IList<LdLibrary> ls) { e.LibraryList = ls; }
            public LdLibraryCB newMyCB() { return referrerBhv.NewMyConditionBean(); }
            public void qyFKIn(LdLibraryCB cb, IList<String> ls) { cb.Query().SetLibraryTypeCode_InScope(ls); }
            public void qyOdFKAsc(LdLibraryCB cb) { cb.Query().AddOrderBy_LibraryTypeCode_Asc(); }
            public void spFKCol(LdLibraryCB cb) { cb.Specify().ColumnLibraryTypeCode(); }
            public IList<LdLibrary> selRfLs(LdLibraryCB cb) { return referrerBhv.SelectList(cb); }
            public String getFKVal(LdLibrary e) { return e.LibraryTypeCode; }
            public void setlcEt(LdLibrary re, LdLibraryTypeLookup be) { re.LibraryTypeLookup = be; }
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
        public virtual void Insert(LdLibraryTypeLookup entity) {
            AssertEntityNotNull(entity);
            this.DelegateInsert(entity);
        }

        protected override void DoCreate(LdEntity entity) {
            Insert(Downcast(entity));
        }

        public virtual void Update(LdLibraryTypeLookup entity) {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int updatedCount = this.DelegateUpdate(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        protected override void DoModify(LdEntity entity) {
            Update(Downcast(entity));
        }

        public virtual void UpdateNonstrict(LdLibraryTypeLookup entity) {
            AssertEntityNotNull(entity);
            int updatedCount = this.DelegateUpdateNonstrict(entity);
            AssertUpdatedEntity(entity, updatedCount);
        }

        public void InsertOrUpdate(LdLibraryTypeLookup entity) {
            HelpInsertOrUpdateInternally<LdLibraryTypeLookup, LdLibraryTypeLookupCB>(entity, new MyInternalInsertOrUpdateCallback(this));
        }
        protected class MyInternalInsertOrUpdateCallback : InternalInsertOrUpdateCallback<LdLibraryTypeLookup, LdLibraryTypeLookupCB> {
            protected LdLibraryTypeLookupBhv _bhv;
            public MyInternalInsertOrUpdateCallback(LdLibraryTypeLookupBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(LdLibraryTypeLookup entity) { _bhv.Insert(entity); }
            public void CallbackUpdate(LdLibraryTypeLookup entity) { _bhv.Update(entity); }
            public LdLibraryTypeLookupCB CallbackNewMyConditionBean() { return _bhv.NewMyConditionBean(); }
            public void CallbackSetupPrimaryKeyCondition(LdLibraryTypeLookupCB cb, LdLibraryTypeLookup entity) {
                cb.Query().SetLibraryTypeCode_Equal(entity.LibraryTypeCode);
            }
            public int CallbackSelectCount(LdLibraryTypeLookupCB cb) { return _bhv.SelectCount(cb); }
        }

        public void InsertOrUpdateNonstrict(LdLibraryTypeLookup entity) {
            HelpInsertOrUpdateInternally<LdLibraryTypeLookup>(entity, new MyInternalInsertOrUpdateNonstrictCallback(this));
        }
        protected class MyInternalInsertOrUpdateNonstrictCallback : InternalInsertOrUpdateNonstrictCallback<LdLibraryTypeLookup> {
            protected LdLibraryTypeLookupBhv _bhv;
            public MyInternalInsertOrUpdateNonstrictCallback(LdLibraryTypeLookupBhv bhv) { _bhv = bhv; }
            public void CallbackInsert(LdLibraryTypeLookup entity) { _bhv.Insert(entity); }
            public void CallbackUpdateNonstrict(LdLibraryTypeLookup entity) { _bhv.UpdateNonstrict(entity); }
        }

        public virtual void Delete(LdLibraryTypeLookup entity) {
            HelpDeleteInternally<LdLibraryTypeLookup>(entity, new MyInternalDeleteCallback(this));
        }

        protected override void DoRemove(LdEntity entity) {
            Remove(Downcast(entity));
        }

        protected class MyInternalDeleteCallback : InternalDeleteCallback<LdLibraryTypeLookup> {
            protected LdLibraryTypeLookupBhv _bhv;
            public MyInternalDeleteCallback(LdLibraryTypeLookupBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDelete(LdLibraryTypeLookup entity) { return _bhv.DelegateDelete(entity); }
        }

        public virtual void DeleteNonstrict(LdLibraryTypeLookup entity) {
            HelpDeleteNonstrictInternally<LdLibraryTypeLookup>(entity, new MyInternalDeleteNonstrictCallback(this));
        }
        protected class MyInternalDeleteNonstrictCallback : InternalDeleteNonstrictCallback<LdLibraryTypeLookup> {
            protected LdLibraryTypeLookupBhv _bhv;
            public MyInternalDeleteNonstrictCallback(LdLibraryTypeLookupBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDeleteNonstrict(LdLibraryTypeLookup entity) { return _bhv.DelegateDeleteNonstrict(entity); }
        }

        public virtual void DeleteNonstrictIgnoreDeleted(LdLibraryTypeLookup entity) {
            HelpDeleteNonstrictIgnoreDeletedInternally<LdLibraryTypeLookup>(entity, new MyInternalDeleteNonstrictIgnoreDeletedCallback(this));
        }
        protected class MyInternalDeleteNonstrictIgnoreDeletedCallback : InternalDeleteNonstrictIgnoreDeletedCallback<LdLibraryTypeLookup> {
            protected LdLibraryTypeLookupBhv _bhv;
            public MyInternalDeleteNonstrictIgnoreDeletedCallback(LdLibraryTypeLookupBhv bhv) { _bhv = bhv; }
            public int CallbackDelegateDeleteNonstrict(LdLibraryTypeLookup entity) { return _bhv.DelegateDeleteNonstrict(entity); }
        }
        #endregion

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        public int QueryUpdate(LdLibraryTypeLookup libraryTypeLookup, LdLibraryTypeLookupCB cb) {
            AssertObjectNotNull("libraryTypeLookup", libraryTypeLookup); AssertConditionBeanNotNull(cb);
            SetupCommonColumnOfUpdateIfNeeds(libraryTypeLookup);
            FilterEntityOfUpdate(libraryTypeLookup); AssertEntityOfUpdate(libraryTypeLookup);
            return this.Dao.UpdateByQuery(cb, libraryTypeLookup);
        }

        public int QueryDelete(LdLibraryTypeLookupCB cb) {
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
        protected int DelegateSelectCount(LdLibraryTypeLookupCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectCount(cb); }
        protected IList<LdLibraryTypeLookup> DelegateSelectList(LdLibraryTypeLookupCB cb) { AssertConditionBeanNotNull(cb); return this.Dao.SelectList(cb); }

        protected int DelegateInsert(LdLibraryTypeLookup e) { if (!ProcessBeforeInsert(e)) { return 1; } return this.Dao.Insert(e); }
        protected int DelegateUpdate(LdLibraryTypeLookup e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateModifiedOnly(e); }
        protected int DelegateUpdateNonstrict(LdLibraryTypeLookup e)
        { if (!ProcessBeforeUpdate(e)) { return 1; } return this.Dao.UpdateNonstrictModifiedOnly(e); }
        protected int DelegateDelete(LdLibraryTypeLookup e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.Delete(e); }
        protected int DelegateDeleteNonstrict(LdLibraryTypeLookup e)
        { if (!ProcessBeforeDelete(e)) { return 1; } return this.Dao.DeleteNonstrict(e); }
        #endregion

        // ===============================================================================
        //                                                                 Downcast Helper
        //                                                                 ===============
        protected LdLibraryTypeLookup Downcast(LdEntity entity) {
            return (LdLibraryTypeLookup)entity;
        }

        protected LdLibraryTypeLookupCB Downcast(LdConditionBean cb) {
            return (LdLibraryTypeLookupCB)cb;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public virtual LdLibraryTypeLookupDao Dao { get { return _dao; } set { _dao = value; } }
    }
}

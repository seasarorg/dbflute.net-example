
using System;
using System.Collections.Generic;

using DfExample.DBFlute.LibraryDb.AllCommon;
using DfExample.DBFlute.LibraryDb.AllCommon.Bhv.Load;
using DfExample.DBFlute.LibraryDb.AllCommon.Bhv.Setup;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean.OutsideSql;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean.OutsideSql.Executor;
using DfExample.DBFlute.LibraryDb.AllCommon.Dbm;
using DfExample.DBFlute.LibraryDb.AllCommon.Util;

namespace DfExample.DBFlute.LibraryDb.AllCommon.Bhv {

    public abstract class LdAbstractBehaviorReadable : LdBehaviorReadable {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected LdDaoSelector _daoSelector;
        protected LdBehaviorSelector _behaviorSelector;

        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        public abstract bool IsInitialized { get; }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public abstract String TableDbName { get; }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public abstract LdDBMeta DBMeta { get; }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        public abstract LdEntity NewEntity();
        public abstract LdConditionBean NewConditionBean();

        // ===============================================================================
        //                                                                      Count Read
        //                                                                      ==========
        public virtual int ReadCount(LdConditionBean cb) {
            AssertConditionBeanNotNull(cb);
            return DoReadCount(cb);
        }

        protected abstract int DoReadCount(LdConditionBean cb);

        // ===============================================================================
        //                                                                     Entity Read
        //                                                                     ===========
        public virtual LdEntity ReadEntity(LdConditionBean cb) {
            AssertConditionBeanNotNull(cb);
            return DoReadEntity(cb);
        }

        protected abstract LdEntity DoReadEntity(LdConditionBean cb);

        public virtual LdEntity ReadEntityWithDeletedCheck(LdConditionBean cb) {
            AssertConditionBeanNotNull(cb);
            return DoReadEntityWithDeletedCheck(cb);
        }

        protected abstract LdEntity DoReadEntityWithDeletedCheck(LdConditionBean cb);

        // -----------------------------------------------------
        //                                       Internal Helper
        //                                       ---------------
        protected int xcheckSafetyResultAsOne(LdConditionBean cb) {
            int safetyMaxResultSize = cb.SafetyMaxResultSize;
            cb.CheckSafetyResult(1);
            return safetyMaxResultSize;
        }

        protected void xrestoreSafetyResult(LdConditionBean cb, int preSafetyMaxResultSize) {
            cb.CheckSafetyResult(preSafetyMaxResultSize);
        }

        // ===============================================================================
        //                                                          Entity Result Handling
        //                                                          ======================
        protected void AssertEntityNotDeleted(LdEntity entity, Object searchKey4Log) {
            if (entity == null) {
                ThrowEntityAlreadyDeletedException(searchKey4Log);
            }
        }

        protected void AssertEntityNotDeleted<ENTITY_TYPE>(IList<ENTITY_TYPE> ls, Object searchKey4Log) where ENTITY_TYPE : LdEntity {
            if (ls == null || ls.Count == 0) {
                ThrowEntityAlreadyDeletedException(searchKey4Log);
            }
        }

        protected void AssertEntitySelectedAsOne<ENTITY_TYPE>(IList<ENTITY_TYPE> ls, Object searchKey4Log) where ENTITY_TYPE : LdEntity {
            if (ls == null || ls.Count == 0) {
				ThrowEntityAlreadyDeletedException(searchKey4Log);
            }
            if (ls.Count != 1) {
			    ThrowEntityDuplicatedException("" + ls.Count, searchKey4Log, null);
            }
        }

        protected void ThrowEntityAlreadyDeletedException(Object searchKey4Log) {
            LdConditionBeanContext.ThrowEntityAlreadyDeletedException(searchKey4Log);
        }

        protected void ThrowEntityDuplicatedException(String resultCountString, Object searchKey4Log, Exception cause) {
            LdConditionBeanContext.ThrowEntityDuplicatedException(resultCountString, searchKey4Log, cause);
        }

        protected void throwSelectEntityConditionNotFoundException(LdConditionBean cb) {
            LdConditionBeanContext.throwSelectEntityConditionNotFoundException(cb);
        }

        // ===============================================================================
        //                                                                  Various Select
        //                                                                  ==============
        public virtual LdOutsideSqlBasicExecutor OutsideSql() {
            AssertDaoSelectorNotNull("OutsideSql");
            LdOutsideSqlDao outsideSqlDao = _daoSelector.Select<LdOutsideSqlDao>();
            return new LdOutsideSqlBasicExecutor(outsideSqlDao, this.TableDbName);
        }

        private void AssertDaoSelectorNotNull(String methodName) {
            if (_daoSelector == null) {
                String msg = "Look! Read the message below." + GetLineSeparator();
                msg = msg + "/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *" + GetLineSeparator();
                msg = msg + "Not found the selector of dao as behavior's attributed!" + GetLineSeparator();
                msg = msg + GetLineSeparator();
                msg = msg + "[Advice]" + GetLineSeparator();
                msg = msg + "Please confirm the definition of the selector at your 'dbflute.dicon'." + GetLineSeparator();
                msg = msg + "It is precondition that '" + methodName + "()' needs the selector instance." + GetLineSeparator();
                msg = msg + GetLineSeparator();
                msg = msg + "[Your Behavior's Attributes]" + GetLineSeparator();
                msg = msg + "  _behaviorSelector  : " + _behaviorSelector + GetLineSeparator();
                msg = msg + "  _daoSelector       : " + _daoSelector + GetLineSeparator();
                msg = msg + "* * * * * * * * * */" + GetLineSeparator();
                throw new SystemException(msg);
            }
        }

        // ===============================================================================
        //                                                   Load Referrer Internal Helper
        //                                                   =============================
        /**
         * Help load referrer internally.
         * About internal policy, the value of primary key(and others too) is treated as CaseInsensitive.
         * @param <LOCAL_ENTITY> The type of base entity.
         * @param <PK> The type of primary key.
         * @param <REFERRER_CB> The type of referrer condition-bean.
         * @param <REFERRER_ENTITY> The type of referrer entity.
         * @param localEntityList The list of local entity. (NotNull)
         * @param loadReferrerOption The option of loadReferrer. (NotNull)
         * @param callback The internal call-back of loadReferrer. (NotNull) 
         */
        protected virtual void HelpLoadReferrerInternally<LOCAL_ENTITY, PK, REFERRER_CB, REFERRER_ENTITY>(
                                               IList<LOCAL_ENTITY> localEntityList
                                             , LdLoadReferrerOption<REFERRER_CB, REFERRER_ENTITY> loadReferrerOption
                                             , InternalLoadReferrerCallback<LOCAL_ENTITY, PK, REFERRER_CB, REFERRER_ENTITY> callback) 
                     where LOCAL_ENTITY : LdEntity
                     where REFERRER_CB : LdConditionBean
                     where REFERRER_ENTITY : LdEntity {
            DoHelpLoadReferrerInternally(localEntityList, loadReferrerOption, callback);
        }

        /**
         * Help load referrer internally.
         * About internal policy, the value of primary key(and others too) is treated as CaseInsensitive.
         * @param <LOCAL_ENTITY> The type of base entity.
         * @param <PK> The type of primary key.
         * @param <REFERRER_CB> The type of referrer condition-bean.
         * @param <REFERRER_ENTITY> The type of referrer entity.
         * @param localEntityList The list of local entity. (NotNull)
         * @param loadReferrerOption The option of loadReferrer. (NotNull)
         * @param callback The internal call-back of loadReferrer. (NotNull) 
         */
        protected virtual void DoHelpLoadReferrerInternally<LOCAL_ENTITY, PK, REFERRER_CB, REFERRER_ENTITY>(
                                               IList<LOCAL_ENTITY> localEntityList
                                             , LdLoadReferrerOption<REFERRER_CB, REFERRER_ENTITY> loadReferrerOption
                                             , InternalLoadReferrerCallback<LOCAL_ENTITY, PK, REFERRER_CB, REFERRER_ENTITY> callback) 
                     where LOCAL_ENTITY : LdEntity
                     where REFERRER_CB : LdConditionBean
                     where REFERRER_ENTITY : LdEntity {

            // - - - - - - - - - - -
            // Assert pre-condition
            // - - - - - - - - - - -
            AssertBehaviorSelectorNotNull("loadReferrer");
            AssertObjectNotNull("localEntityList", localEntityList);
            AssertObjectNotNull("loadReferrerOption", loadReferrerOption);
            if (localEntityList.Count == 0) {
                return;
            }

            // - - - - - - - - - - - - - -
            // Prepare temporary container
            // - - - - - - - - - - - - - -
            IDictionary<PK, LOCAL_ENTITY> pkLocalEntityMap = new Dictionary<PK, LOCAL_ENTITY>();
            IList<PK> pkList = new List<PK>();
            foreach (LOCAL_ENTITY localEntity in localEntityList) {
                PK primaryKeyValue = callback.getPKVal(localEntity);
                if (primaryKeyValue == null) {
                    String msg = "PK value of local entity should not be null: " + localEntity;
                    throw new SystemException(msg);
                }
                pkList.Add(primaryKeyValue);
                if (!pkLocalEntityMap.ContainsKey(primaryKeyValue)) {
                    pkLocalEntityMap.Add(ToLoadReferrerMappingKey(primaryKeyValue), localEntity);
                }
            }

            // - - - - - - - - - - - - - - - -
            // Prepare referrer condition bean
            // - - - - - - - - - - - - - - - -
            REFERRER_CB cb;
            if (loadReferrerOption.ReferrerConditionBean != null) {
                cb = loadReferrerOption.ReferrerConditionBean;
            } else {
                cb = callback.newMyCB();
            }

            // - - - - - - - - - - - - - -
            // Select the list of referrer
            // - - - - - - - - - - - - - -
            callback.qyFKIn(cb, pkList);
            cb.xregisterUnionQuerySynchronizer(delegate(LdConditionBean unionCB) {
                REFERRER_CB referrerUnionCB = (REFERRER_CB) unionCB;
                // for when application uses union query in condition-bean set-upper.
                callback.qyFKIn(referrerUnionCB, pkList);
            });
            if (pkList.Count > 1) {
                callback.qyOdFKAsc(cb);
                cb.SqlComponentOfOrderByClause.exchangeFirstOrderByElementForLastOne();
            }
            loadReferrerOption.delegateConditionBeanSettingUp(cb);
            if (cb.SqlClause.hasSpecifiedSelectColumn(cb.SqlClause.getBasePointAliasName())) {
                callback.spFKCol(cb); // specify required columns
            }
            IList<REFERRER_ENTITY> referrerList = callback.selRfLs(cb);
            loadReferrerOption.delegateEntitySettingUp(referrerList);

            // - - - - - - - - - - - - - - - - - - - - - - - -
            // Create the map of {primary key / referrer list}
            // - - - - - - - - - - - - - - - - - - - - - - - -
            IDictionary<PK, List<REFERRER_ENTITY>> pkReferrerListMap = new Dictionary<PK, List<REFERRER_ENTITY>>();
            foreach (REFERRER_ENTITY referrerEntity in referrerList) {
                PK referrerListKey;
                {
                    PK foreignKeyValue = callback.getFKVal(referrerEntity);
                    referrerListKey = ToLoadReferrerMappingKey(foreignKeyValue);
                }
                if (!pkReferrerListMap.ContainsKey(referrerListKey)) {
                    pkReferrerListMap.Add(referrerListKey, new List<REFERRER_ENTITY>());
                }
                pkReferrerListMap[referrerListKey].Add(referrerEntity);

                // for Reverse Reference.
                LOCAL_ENTITY localEntity = pkLocalEntityMap[referrerListKey];
                callback.setlcEt(referrerEntity, localEntity);
            }

            // - - - - - - - - - - - - - - - - - -
            // Relate referrer list to base entity
            // - - - - - - - - - - - - - - - - - -
            foreach (LOCAL_ENTITY localEntity in localEntityList) {
                PK referrerListKey;
                {
                    PK primaryKey = callback.getPKVal(localEntity);
                    referrerListKey = ToLoadReferrerMappingKey(primaryKey);
                }
                if (pkReferrerListMap.ContainsKey(referrerListKey)) {
                    callback.setRfLs(localEntity, pkReferrerListMap[referrerListKey]);
                } else {
                    callback.setRfLs(localEntity, new List<REFERRER_ENTITY>());
                }
            }
        }

        protected PK ToLoadReferrerMappingKey<PK>(PK value) {
            return (PK)ToLowerCaseIfString(value);
        }

        /**
         * @param <LOCAL_ENTITY> The type of base entity.
         * @param <PK> The type of primary key.
         * @param <REFERRER_CB> The type of referrer condition-bean.
         * @param <REFERRER_ENTITY> The type of referrer entity.
         */
        protected interface InternalLoadReferrerCallback<LOCAL_ENTITY, PK, REFERRER_CB, REFERRER_ENTITY>
                     where LOCAL_ENTITY : LdEntity
                     where REFERRER_CB : LdConditionBean
                     where REFERRER_ENTITY : LdEntity {
            // for Base
            PK getPKVal(LOCAL_ENTITY entity); // getPrimaryKeyValue()
            void setRfLs(LOCAL_ENTITY entity, IList<REFERRER_ENTITY> referrerList); // setReferrerList()

            // for Referrer
            REFERRER_CB newMyCB(); // newMyConditionBean()
            void qyFKIn(REFERRER_CB cb, IList<PK> pkList); // queryForeignKeyInScope()
            void qyOdFKAsc(REFERRER_CB cb); // queryAddOrderByForeignKeyAsc()
            void spFKCol(REFERRER_CB cb); // specifyForeignKeyColumn()
            IList<REFERRER_ENTITY> selRfLs(REFERRER_CB cb); // selectReferrerList()
            PK getFKVal(REFERRER_ENTITY entity); // getForeignKeyValue()
            void setlcEt(REFERRER_ENTITY referrerEntity, LOCAL_ENTITY localEntity); // setLocalEntity()
        }
    
        protected LdBehaviorSelector xgetBSFLR() { // GetBehaviorSelectorForLoadReferrer() as Internal
            AssertBehaviorSelectorNotNull("loadReferrer");
            return this.BehaviorSelector;
        }

        private void AssertBehaviorSelectorNotNull(String methodName) {
            if (_behaviorSelector == null) {
                String msg = "Look! Read the message below." + GetLineSeparator();
                msg = msg + "/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *" + GetLineSeparator();
                msg = msg + "Not found the selector of behavior as behavior's attributed!" + GetLineSeparator();
                msg = msg + GetLineSeparator();
                msg = msg + "[Advice]" + GetLineSeparator();
                msg = msg + "Please confirm the definition of the selector at your 'dbflute.dicon'." + GetLineSeparator();
                msg = msg + "It is precondition that '" + methodName + "()' needs the selector instance." + GetLineSeparator();
                msg = msg + GetLineSeparator();
                msg = msg + "[Your Behavior's Attributes]" + GetLineSeparator();
                msg = msg + "  _behaviorSelector  : " + _behaviorSelector + GetLineSeparator();
                msg = msg + "  _daoSelector       : " + _daoSelector + GetLineSeparator();
                msg = msg + "* * * * * * * * * */" + GetLineSeparator();
                throw new SystemException(msg);
            }
        }
    
        protected IList<ELEMENT> xnewLRLs<ELEMENT>(ELEMENT element) { // newLoadReferrerList() as Internal
            System.Collections.Generic.IList<ELEMENT> ls = new System.Collections.Generic.List<ELEMENT>(1);
            ls.Add(element);
            return ls;
        }

        // ===============================================================================
        //                                                         Pullout Internal Helper
        //                                                         =======================
        protected IList<FOREIGN_ENTITY> HelpPulloutInternally<LOCAL_ENTITY, FOREIGN_ENTITY>(IList<LOCAL_ENTITY> localEntityList, InternalPulloutCallback<LOCAL_ENTITY, FOREIGN_ENTITY> callback)
                where LOCAL_ENTITY : LdEntity where FOREIGN_ENTITY : LdEntity {
            AssertObjectNotNull("localEntityList", localEntityList);
            IList<FOREIGN_ENTITY> foreignList = new List<FOREIGN_ENTITY>();
            foreach (LOCAL_ENTITY entity in localEntityList) {
                FOREIGN_ENTITY foreignEntity = callback.getFr(entity);
                if (foreignEntity == null || foreignList.Contains(foreignEntity)) {
                    continue;
                }
                foreignList.Add(foreignEntity);
            }
            return foreignList;
        }

        protected interface InternalPulloutCallback<LOCAL_ENTITY, FOREIGN_ENTITY> where LOCAL_ENTITY : LdEntity where FOREIGN_ENTITY : LdEntity {
            FOREIGN_ENTITY getFr(LOCAL_ENTITY entity); // getForeignEntity()
        }

        // ===============================================================================
        //                                                            Optimistic Lock Info
        //                                                            ====================
        protected abstract bool HasVersionNoValue(LdEntity entity);
        protected abstract bool HasUpdateDateValue(LdEntity entity);

        // ===============================================================================
        //                                                                  Process Method
        //                                                                  ==============
        protected virtual void FilterEntityOfInsert(LdEntity targetEntity) { // for isAvailableNonPrimaryKeyWritable
        }

        // ===============================================================================
        //                                                                  General Helper
        //                                                                  ==============
        #region General Helper
        protected virtual Object ToLowerCaseIfString(Object obj) {
            if (obj != null && obj is String) {
                return ((String)obj).ToLower();
            }
            return obj;
        }

        protected virtual String GetLineSeparator() {
            return Environment.NewLine;
        }

        // -------------------------------------------------
        //                                     Assert Object
        //                                     -------------
        protected virtual void AssertObjectNotNull(String variableName, Object arg) {
            if (variableName == null) {
                String msg = "Argument[variableName] should not be null.";
                throw new SystemException(msg);
            }
            if (arg == null) {
                String msg = "Argument[" + variableName + "] should not be null.";
                throw new SystemException(msg);
            }
        }

        protected virtual void AssertEntityNotNull(LdEntity entity) {
            AssertObjectNotNull("entity", entity);
        }

        protected virtual void AssertConditionBeanNotNull(DfExample.DBFlute.LibraryDb.AllCommon.CBean.LdConditionBean cb) {
            AssertObjectNotNull("cb", cb);
        }

        protected virtual void AssertEntityNotNullAndHasPrimaryKeyValue(LdEntity entity) {
            AssertEntityNotNull(entity);
            if (!entity.HasPrimaryKeyValue) {
                String msg = "The entity should have primary-key: entity=" + entity;
                throw new SystemException(msg + entity);
            }
        }

        // -------------------------------------------------
        //                                     Assert String
        //                                     -------------
        protected virtual void AssertStringNotNullAndNotTrimmedEmpty(String variableName, String value) {
            if (variableName == null) {
                String msg = "Variable[variableName] should not be null.";
                throw new SystemException(msg);
            }
            if (value == null) {
                String msg = "Variable[" + variableName + "] should not be null.";
                throw new SystemException(msg);
            }
            if (value.Trim().Length == 0) {
                String msg = "Variable[" + variableName + "] should not be empty: [" + value + "]";
                throw new SystemException(msg);
            }
        }

        // -------------------------------------------------
        //                                       Assert List
        //                                       -----------
        protected virtual void AssertListNotNullAndEmpty<ELEMENT_TYPE>(String variableName, IList<ELEMENT_TYPE> ls) {
            AssertObjectNotNull(variableName, ls);
            if (!(ls.Count == 0)) {
                String msg = "The list[" + variableName + "] should be empty: ls=" + ls.ToString();
                throw new SystemException(msg);
            }
        }

        protected virtual void AssertListNotNullAndNotEmpty<ELEMENT_TYPE>(String variableName, IList<ELEMENT_TYPE> ls) {
            AssertObjectNotNull(variableName, ls);
            if (ls.Count == 0) {
                String msg = "The list[" + variableName + "] should not be empty: ls=" + ls.ToString();
                throw new SystemException(msg);
            }
        }

        protected virtual void AssertListNotNullAndHasOnlyOne<ELEMENT_TYPE>(String variableName, IList<ELEMENT_TYPE> ls) {
            AssertObjectNotNull(variableName, ls);
            if (ls.Count != 1) {
                String msg = "The list[" + variableName + "] should contain only one object: ls=" + ls.ToString();
                throw new SystemException(msg);
            }
        }
        #endregion

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        #region Accessor
        /// <summary>
        ///  The property of dao selector.
        /// </summary>
        public LdDaoSelector DaoSelector {
            get { return _daoSelector; }
            set { _daoSelector = value; }
        }

        /// <summary>
        ///  The property of behavior selector.
        /// </summary>
        public LdBehaviorSelector BehaviorSelector {
            get { return _behaviorSelector; }
            set { _behaviorSelector = value; }
        }
        #endregion
    }
}

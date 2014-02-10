
using System;
using System.Collections;

using DfExample.DBFlute.MemberDb.AllCommon;
using DfExample.DBFlute.MemberDb.AllCommon.CBean;
using DfExample.DBFlute.MemberDb.AllCommon.Dbm;
using DfExample.DBFlute.MemberDb.AllCommon.Exp;

namespace DfExample.DBFlute.MemberDb.AllCommon.Bhv {

    public abstract class MbAbstractBehaviorWritable : MbAbstractBehaviorReadable, MbBehaviorWritable {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        private static readonly log4net.ILog _log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        // ===============================================================================
        //                                                                   Entity Update
        //                                                                   =============
        public virtual void Create(MbEntity entity) {
            AssertEntityNotNull(entity);
            DoCreate(entity);
        }

        protected abstract void DoCreate(MbEntity entity);

        public virtual void Modify(MbEntity entity) {
            AssertEntityNotNull(entity);
            DoModify(entity);
        }

        protected abstract void DoModify(MbEntity entity);

        protected static void AssertUpdatedEntity(MbEntity entity, int updatedCount) {
            if (updatedCount == 0) {
                String msg = "The entity was not found! it has already been deleted: entity=" + entity;
                throw new MbEntityAlreadyDeletedException(msg);
            }
            if (updatedCount > 1) {
                String msg = "The entity was too many! it has been duplicated.";
                msg = msg + " It should be the only one!";
                msg = msg + " But the updatedCount=" + updatedCount;
                msg = msg + ": entity=" + entity;
                throw new MbEntityDuplicatedException(msg);
            }
        }

        public virtual void Remove(MbEntity entity) {
            AssertEntityNotNull(entity);
            DoRemove(entity);
        }

        protected abstract void DoRemove(MbEntity entity);

        protected static void AssertDeletedEntity(MbEntity entity, int deletedCount) {
            if (deletedCount == 0) {
                String msg = "The entity was Not Found! it has already been deleted: entity=" + entity;
                throw new MbEntityAlreadyDeletedException(msg);
            }
            if (deletedCount > 1) {
                String msg = "The entity was Too Many! it has been duplicated. It should be the only one! But the deletedCount=" + deletedCount;
                msg = msg + ": entity=" + entity;
                throw new MbEntityDuplicatedException(msg);
            }
        }

        // -------------------------------------------------
        //                                    InsertOrUpdate
        //                                    --------------
        protected void HelpInsertOrUpdateInternally<ENTITY_TYPE, CB_TYPE>(ENTITY_TYPE entity, InternalInsertOrUpdateCallback<ENTITY_TYPE, CB_TYPE> callback)
                    where ENTITY_TYPE : MbEntity where CB_TYPE : MbConditionBean {
            AssertEntityNotNull(entity);
            if (!entity.HasPrimaryKeyValue) {
                callback.CallbackInsert(entity);
            } else {
                Exception exception = null;
                try {
                   callback.CallbackUpdate(entity);
                } catch (MbEntityAlreadyUpdatedException e) {
                    if (e.Rows == 0) {
                        exception = e;
                    }
                } catch (MbEntityAlreadyDeletedException e) {
                    exception = e;
                } catch (OptimisticLockColumnValueNullException e) {
                    exception = e;
                }
                if (exception != null) {
                    CB_TYPE cb = callback.CallbackNewMyConditionBean();
                    callback.CallbackSetupPrimaryKeyCondition(cb, entity);
                    if (callback.CallbackSelectCount(cb) == 0) {
                        callback.CallbackInsert(entity);
                    } else {
                        throw exception;
                    }
                }
            }
        }

        protected interface InternalInsertOrUpdateCallback<ENTITY_TYPE, CB_TYPE> where ENTITY_TYPE : MbEntity where CB_TYPE : MbConditionBean {
            void CallbackInsert(ENTITY_TYPE entity);
            void CallbackUpdate(ENTITY_TYPE entity);
            CB_TYPE CallbackNewMyConditionBean();
            void CallbackSetupPrimaryKeyCondition(CB_TYPE cb, ENTITY_TYPE entity);
            int CallbackSelectCount(CB_TYPE cb);
        }

        protected void HelpInsertOrUpdateInternally<ENTITY_TYPE>(ENTITY_TYPE entity, InternalInsertOrUpdateNonstrictCallback<ENTITY_TYPE> callback)
                where ENTITY_TYPE : MbEntity {
            AssertEntityNotNull(entity);
            if (!entity.HasPrimaryKeyValue) {
                callback.CallbackInsert(entity);
            } else {
                try {
                    callback.CallbackUpdateNonstrict(entity);
                } catch (MbEntityAlreadyUpdatedException) {
                    callback.CallbackInsert(entity);
                } catch (MbEntityAlreadyDeletedException) {
                    callback.CallbackInsert(entity);
                }
            }
        }

        protected interface InternalInsertOrUpdateNonstrictCallback<ENTITY_TYPE> where ENTITY_TYPE : MbEntity {
            void CallbackInsert(ENTITY_TYPE entity);
            void CallbackUpdateNonstrict(ENTITY_TYPE entity);
        }

        // -------------------------------------------------
        //                                            Delete
        //                                            ------
        protected void HelpDeleteInternally<ENTITY_TYPE>(ENTITY_TYPE entity, InternalDeleteCallback<ENTITY_TYPE> callback) where ENTITY_TYPE : MbEntity {
            AssertEntityNotNull(entity);
            AssertEntityHasVersionNoValue(entity);
            AssertEntityHasUpdateDateValue(entity);
            int deletedCount = callback.CallbackDelegateDelete(entity);
            AssertUpdatedEntity(entity, deletedCount);
        }

        protected interface InternalDeleteCallback<ENTITY_TYPE> where ENTITY_TYPE : MbEntity {
            int CallbackDelegateDelete(ENTITY_TYPE entity);
        }

        protected void HelpDeleteNonstrictInternally<ENTITY_TYPE>(ENTITY_TYPE entity, InternalDeleteNonstrictCallback<ENTITY_TYPE> callback) where ENTITY_TYPE : MbEntity {
            AssertEntityNotNull(entity);
            int deletedCount = callback.CallbackDelegateDeleteNonstrict(entity);
            if (deletedCount == 0) {
                String msg = "The entity was Not Found! The entity has already been deleted: entity=" + entity;
                throw new MbEntityAlreadyDeletedException(msg);
            } else if (deletedCount > 1) {
                String msg = "The deleted entity was duplicated. It should be the only one! But the deletedCount=" + deletedCount;
                msg = msg + ": entity=" + entity;
                throw new MbEntityDuplicatedException(msg);
            }
        }

        protected interface InternalDeleteNonstrictCallback<ENTITY_TYPE> where ENTITY_TYPE : MbEntity {
            int CallbackDelegateDeleteNonstrict(ENTITY_TYPE entity);
        }

        protected void HelpDeleteNonstrictIgnoreDeletedInternally<ENTITY_TYPE>(ENTITY_TYPE entity, InternalDeleteNonstrictIgnoreDeletedCallback<ENTITY_TYPE> callback) where ENTITY_TYPE : MbEntity {
            AssertEntityNotNull(entity);
            int deletedCount = callback.CallbackDelegateDeleteNonstrict(entity);
            if (deletedCount == 0) {
                return;
            } else if (deletedCount > 1) {
                String msg = "The deleted entity was duplicated. It should be the only one! But the deletedCount=" + deletedCount;
                msg = msg + ": entity=" + entity;
                throw new MbEntityDuplicatedException(msg);
            }
       }

        protected interface InternalDeleteNonstrictIgnoreDeletedCallback<ENTITY_TYPE> where ENTITY_TYPE : MbEntity {
            int CallbackDelegateDeleteNonstrict(ENTITY_TYPE entity);
        }

        // ===============================================================================
        //                                                                 Delegate Method
        //                                                                 ===============
        // -------------------------------------------------
        //                                            Create
        //                                            ------
        protected virtual bool ProcessBeforeInsert(MbEntity entity) {
            AssertEntityNotNull(entity);// If this table use identity, the entity does not have primary-key.
            FrameworkFilterEntityOfInsert(entity);
            FilterEntityOfInsert(entity);
            AssertEntityOfInsert(entity);
            return true;
        }

        protected virtual void FrameworkFilterEntityOfInsert(MbEntity targetEntity) {
            InjectSequenceToPrimaryKeyIfNeeds(targetEntity);
            SetupCommonColumnOfInsertIfNeeds(targetEntity);
        }
		
        protected void InjectSequenceToPrimaryKeyIfNeeds(MbEntity entity) {
            MbDBMeta dbmeta = entity.DBMeta;
            if (!dbmeta.HasSequence || dbmeta.HasCompoundPrimaryKey || entity.HasPrimaryKeyValue) {
                return;
            }
            SetupNextValueToPrimaryKey(entity);
        }
        protected virtual void SetupNextValueToPrimaryKey(MbEntity entity) {// Expect Override of Sub Class!
        }

        protected virtual void SetupCommonColumnOfInsertIfNeeds(MbEntity targetEntity) {
            if (!IsEntityDefinedCommonColumn(targetEntity)) {
                return;
            }
            MbEntityDefinedCommonColumn entity = (MbEntityDefinedCommonColumn)targetEntity;
            if (!entity.CanCommonColumnAutoSetup()) {
                return;
            }
            if (_log.IsDebugEnabled) {
                _log.Debug("...Setting up column columns of " + this.TableDbName + " before INSERT");
            }
      
            DateTime? registerDatetime = DfExample.DBFlute.MemberDb.AllCommon.MbAccessContext.GetAccessTimestampOnThread();
            entity.RegisterDatetime = registerDatetime;
            
            String registerUser = DfExample.DBFlute.MemberDb.AllCommon.MbAccessContext.GetAccessUserOnThread();
            entity.RegisterUser = registerUser;
            
            String registerProcess = DfExample.DBFlute.MemberDb.AllCommon.MbAccessContext.GetAccessProcessOnThread();
            entity.RegisterProcess = registerProcess;
            
            DateTime? updateDatetime = entity.RegisterDatetime;
            entity.UpdateDatetime = updateDatetime;
            
            String updateUser = entity.RegisterUser;
            entity.UpdateUser = updateUser;
            
            String updateProcess = entity.RegisterProcess;
            entity.UpdateProcess = updateProcess;
      
        }

        protected override void FilterEntityOfInsert(MbEntity targetEntity) {
        }

        protected virtual void AssertEntityOfInsert(MbEntity entity) {
        }

        // -------------------------------------------------
        //                                            Modify
        //                                            ------
        protected virtual bool ProcessBeforeUpdate(MbEntity entity) {
            AssertEntityNotNullAndHasPrimaryKeyValue(entity);
            FrameworkFilterEntityOfUpdate(entity);
            FilterEntityOfUpdate(entity);
            AssertEntityOfUpdate(entity);
            return true;
        }

        protected virtual void FrameworkFilterEntityOfUpdate(MbEntity targetEntity) {
            SetupCommonColumnOfUpdateIfNeeds(targetEntity);
        }

        protected virtual void SetupCommonColumnOfUpdateIfNeeds(MbEntity targetEntity) {
            if (!IsEntityDefinedCommonColumn(targetEntity)) {
                return;
            }
            MbEntityDefinedCommonColumn entity = (MbEntityDefinedCommonColumn)targetEntity;
            if (!entity.CanCommonColumnAutoSetup()) {
                return;
            }
            if (_log.IsDebugEnabled) {
                _log.Debug("...Setting up column columns of " + this.TableDbName + " before UPDATE");
            }
            
            DateTime? updateDatetime = DfExample.DBFlute.MemberDb.AllCommon.MbAccessContext.GetAccessTimestampOnThread();
            entity.UpdateDatetime = updateDatetime;
            
            String updateUser = DfExample.DBFlute.MemberDb.AllCommon.MbAccessContext.GetAccessUserOnThread();
            entity.UpdateUser = updateUser;
            
            String updateProcess = DfExample.DBFlute.MemberDb.AllCommon.MbAccessContext.GetAccessProcessOnThread();
            entity.UpdateProcess = updateProcess;
              }

        protected virtual void FilterEntityOfUpdate(DfExample.DBFlute.MemberDb.AllCommon.MbEntity targetEntity) {
        }

        protected virtual void AssertEntityOfUpdate(DfExample.DBFlute.MemberDb.AllCommon.MbEntity entity) {
        }

        // -------------------------------------------------
        //                                            Remove
        //                                            ------
        protected virtual bool ProcessBeforeDelete(MbEntity entity) {
            AssertEntityNotNullAndHasPrimaryKeyValue(entity);
            FrameworkFilterEntityOfDelete(entity);
            FilterEntityOfDelete(entity);
            AssertEntityOfDelete(entity);
            return true;
        }

        protected virtual void FrameworkFilterEntityOfDelete(MbEntity targetEntity) {
        }

        protected virtual void FilterEntityOfDelete(MbEntity targetEntity) {
        }

        protected virtual void AssertEntityOfDelete(MbEntity entity) {
        }

        // -------------------------------------------------
        //                                            Helper
        //                                            ------
        protected virtual bool IsEntityDefinedCommonColumn(Object obj) {
            if (obj == null) {
                return false;
            }
            if (obj is MbEntityDefinedCommonColumn) {
                return true;
            } else {
                return false;
            }
        }

        protected void AssertEntityHasVersionNoValue(MbEntity entity) {
            if (!DBMeta.HasVersionNo) {
                return;
            }
            if (HasVersionNoValue(entity)) {
                return;
            }
            String msg = "Look! Read the message below." + GetLineSeparator();
            msg = msg + "/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *" + GetLineSeparator();
            msg = msg + "The value of 'version no' on the entity was not found!" + GetLineSeparator() + GetLineSeparator();
            msg = msg + "[Advice]" + GetLineSeparator();
            msg = msg + "Please confirm the existence of the value of 'version no' on the entity." + GetLineSeparator();
            msg = msg + "You called the method in which the check for optimistic lock is indispensable. " + GetLineSeparator();
            msg = msg + "So 'version no' is required on the entity. " + GetLineSeparator();
            msg = msg + "In addition, please confirm the necessity of optimistic lock. It might possibly be unnecessary." + GetLineSeparator() + GetLineSeparator();
            msg = msg + "[Entity]" + GetLineSeparator();
            msg = msg + "entity to string = " + entity + GetLineSeparator();
            msg = msg + "* * * * * * * * * */" + GetLineSeparator();
            throw new OptimisticLockColumnValueNullException(msg);
        }

        protected void AssertEntityHasUpdateDateValue(MbEntity entity) {
            if (!DBMeta.HasUpdateDate) {
                return;
            }
            if (HasUpdateDateValue(entity)) {
                return;
            }
            String msg = "Look! Read the message below." + GetLineSeparator();
            msg = msg + "/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *" + GetLineSeparator();
            msg = msg + "The value of 'update date' on the entity was not found!" + GetLineSeparator() + GetLineSeparator();
            msg = msg + "[Advice]" + GetLineSeparator();
            msg = msg + "Please confirm the existence of the value of 'update date' on the entity." + GetLineSeparator();
            msg = msg + "You called the method in which the check for optimistic lock is indispensable. " + GetLineSeparator();
            msg = msg + "So 'update date' is required on the entity. " + GetLineSeparator();
            msg = msg + "In addition, please confirm the necessity of optimistic lock. It might possibly be unnecessary." + GetLineSeparator() + GetLineSeparator();
            msg = msg + "[Entity]" + GetLineSeparator();
            msg = msg + "entity to string = " + entity + GetLineSeparator();
            msg = msg + "* * * * * * * * * */" + GetLineSeparator();
            throw new OptimisticLockColumnValueNullException(msg);
        }

        public class OptimisticLockColumnValueNullException : SystemException {
            public OptimisticLockColumnValueNullException(String msg) : base(msg) {
            }
        }
    }
}

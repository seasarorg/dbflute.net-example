
using System;
using System.Collections.Generic;
using System.Threading;

using DfExample.DBFlute.LibraryDb.AllCommon;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean.OutsideSql;

namespace DfExample.DBFlute.LibraryDb.AllCommon.S2Dao {

    public class LdContextStack {

        private static LocalDataStoreSlot _slot = Thread.AllocateDataSlot();

        public static Stack<LdContextStack> GetContextStackOnThread() {
            return (Stack<LdContextStack>)Thread.GetData(_slot);
        }

        public static void ClearContextStackOnThread() {
            Thread.SetData(_slot, null);
        }

        public static bool IsExistContextStackOnThread() {
            return (Thread.GetData(_slot) != null);
        }

        public static void SaveAllContextOnThread() {
            if (!IsExistContextStackOnThread()) {
                Thread.SetData(_slot, new Stack<LdContextStack>());
            }
            LdContextStack contextStack = new LdContextStack();
            if (LdConditionBeanContext.IsExistConditionBeanOnThread()) {
                contextStack.ConditionBean = LdConditionBeanContext.GetConditionBeanOnThread();
            }
            if (LdOutsideSqlContext.IsExistOutsideSqlContextOnThread()) {
                contextStack.OutsideSqlContext = LdOutsideSqlContext.GetOutsideSqlContextOnThread();
            }
            if (LdFetchNarrowingBeanContext.IsExistFetchNarrowingBeanOnThread()) {
                contextStack.FetchNarrowingBean = LdFetchNarrowingBeanContext.GetFetchNarrowingBeanOnThread();
            }
            if (LdInternalMapContext.IsExistInternalMapOnThread()) {
                contextStack.InternalMap = LdInternalMapContext.GetInternalMap();
            }
            GetContextStackOnThread().Push(contextStack);
        }

        public static void RestoreAllContextOnThreadIfExists() {
            if (!IsExistContextStackOnThread()) {
                return;
            }
            Stack<LdContextStack> stackOnThread = GetContextStackOnThread();
            if (stackOnThread.Count == 0) {
                ClearContextStackOnThread();
                return;
            }
            LdContextStack contextStack = stackOnThread.Pop();
            LdConditionBean cb = contextStack.ConditionBean;
            if (cb != null) {
                LdConditionBeanContext.SetConditionBeanOnThread(cb);
            }
            LdOutsideSqlContext outsideSqlContext = contextStack.OutsideSqlContext;
            if (outsideSqlContext != null) {
                LdOutsideSqlContext.SetOutsideSqlContextOnThread(outsideSqlContext);
            }
            LdFetchNarrowingBean fetchNarrowingBean = contextStack.FetchNarrowingBean;
            if (fetchNarrowingBean != null) {
                LdFetchNarrowingBeanContext.SetFetchNarrowingBeanOnThread(fetchNarrowingBean);
            }
            IDictionary<String, Object> internalMap = contextStack.InternalMap;
            if (internalMap != null) {
                LdInternalMapContext.ClearInternalMapOnThread();
                foreach (String key in internalMap.Keys) {
                    Object value = internalMap[key];
                    LdInternalMapContext.SetObject(key, value);
                }
            }
        }

        public static void ClearAllCurrentContext() {
            if (LdConditionBeanContext.IsExistConditionBeanOnThread()) {
                LdConditionBeanContext.ClearConditionBeanOnThread();
            }
            if (LdOutsideSqlContext.IsExistOutsideSqlContextOnThread()) {
                LdOutsideSqlContext.ClearOutsideSqlContextOnThread();
            }
            if (LdFetchNarrowingBeanContext.IsExistFetchNarrowingBeanOnThread()) {
                LdFetchNarrowingBeanContext.ClearFetchNarrowingBeanOnThread();
            }
            if (LdInternalMapContext.IsExistInternalMapOnThread()) {
                LdInternalMapContext.ClearInternalMapOnThread();
            }
        }

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected LdConditionBean _conditionBean;
        protected LdOutsideSqlContext _outsideSqlContext;
        protected LdFetchNarrowingBean _fetchNarrowingBean;
        protected IDictionary<String, Object> _internalMap;

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public LdConditionBean ConditionBean {
            get { return _conditionBean; }
            set { this._conditionBean = value; }
        }

        public LdOutsideSqlContext OutsideSqlContext {
            get { return _outsideSqlContext; }
            set { this._outsideSqlContext = value; }
        }

        public LdFetchNarrowingBean FetchNarrowingBean {
            get { return _fetchNarrowingBean; }
            set { this._fetchNarrowingBean = value; }
        }

        public IDictionary<String, Object> InternalMap {
            get { return _internalMap; }
            set { this._internalMap = value; }
        }
    }
}

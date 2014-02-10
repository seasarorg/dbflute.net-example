
using System;
using System.Collections.Generic;
using System.Threading;

using DfExample.DBFlute.MemberDb.AllCommon;
using DfExample.DBFlute.MemberDb.AllCommon.CBean;
using DfExample.DBFlute.MemberDb.AllCommon.CBean.OutsideSql;

namespace DfExample.DBFlute.MemberDb.AllCommon.S2Dao {

    public class MbContextStack {

        private static LocalDataStoreSlot _slot = Thread.AllocateDataSlot();

        public static Stack<MbContextStack> GetContextStackOnThread() {
            return (Stack<MbContextStack>)Thread.GetData(_slot);
        }

        public static void ClearContextStackOnThread() {
            Thread.SetData(_slot, null);
        }

        public static bool IsExistContextStackOnThread() {
            return (Thread.GetData(_slot) != null);
        }

        public static void SaveAllContextOnThread() {
            if (!IsExistContextStackOnThread()) {
                Thread.SetData(_slot, new Stack<MbContextStack>());
            }
            MbContextStack contextStack = new MbContextStack();
            if (MbConditionBeanContext.IsExistConditionBeanOnThread()) {
                contextStack.ConditionBean = MbConditionBeanContext.GetConditionBeanOnThread();
            }
            if (MbOutsideSqlContext.IsExistOutsideSqlContextOnThread()) {
                contextStack.OutsideSqlContext = MbOutsideSqlContext.GetOutsideSqlContextOnThread();
            }
            if (MbFetchNarrowingBeanContext.IsExistFetchNarrowingBeanOnThread()) {
                contextStack.FetchNarrowingBean = MbFetchNarrowingBeanContext.GetFetchNarrowingBeanOnThread();
            }
            if (MbInternalMapContext.IsExistInternalMapOnThread()) {
                contextStack.InternalMap = MbInternalMapContext.GetInternalMap();
            }
            GetContextStackOnThread().Push(contextStack);
        }

        public static void RestoreAllContextOnThreadIfExists() {
            if (!IsExistContextStackOnThread()) {
                return;
            }
            Stack<MbContextStack> stackOnThread = GetContextStackOnThread();
            if (stackOnThread.Count == 0) {
                ClearContextStackOnThread();
                return;
            }
            MbContextStack contextStack = stackOnThread.Pop();
            MbConditionBean cb = contextStack.ConditionBean;
            if (cb != null) {
                MbConditionBeanContext.SetConditionBeanOnThread(cb);
            }
            MbOutsideSqlContext outsideSqlContext = contextStack.OutsideSqlContext;
            if (outsideSqlContext != null) {
                MbOutsideSqlContext.SetOutsideSqlContextOnThread(outsideSqlContext);
            }
            MbFetchNarrowingBean fetchNarrowingBean = contextStack.FetchNarrowingBean;
            if (fetchNarrowingBean != null) {
                MbFetchNarrowingBeanContext.SetFetchNarrowingBeanOnThread(fetchNarrowingBean);
            }
            IDictionary<String, Object> internalMap = contextStack.InternalMap;
            if (internalMap != null) {
                MbInternalMapContext.ClearInternalMapOnThread();
                foreach (String key in internalMap.Keys) {
                    Object value = internalMap[key];
                    MbInternalMapContext.SetObject(key, value);
                }
            }
        }

        public static void ClearAllCurrentContext() {
            if (MbConditionBeanContext.IsExistConditionBeanOnThread()) {
                MbConditionBeanContext.ClearConditionBeanOnThread();
            }
            if (MbOutsideSqlContext.IsExistOutsideSqlContextOnThread()) {
                MbOutsideSqlContext.ClearOutsideSqlContextOnThread();
            }
            if (MbFetchNarrowingBeanContext.IsExistFetchNarrowingBeanOnThread()) {
                MbFetchNarrowingBeanContext.ClearFetchNarrowingBeanOnThread();
            }
            if (MbInternalMapContext.IsExistInternalMapOnThread()) {
                MbInternalMapContext.ClearInternalMapOnThread();
            }
        }

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected MbConditionBean _conditionBean;
        protected MbOutsideSqlContext _outsideSqlContext;
        protected MbFetchNarrowingBean _fetchNarrowingBean;
        protected IDictionary<String, Object> _internalMap;

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public MbConditionBean ConditionBean {
            get { return _conditionBean; }
            set { this._conditionBean = value; }
        }

        public MbOutsideSqlContext OutsideSqlContext {
            get { return _outsideSqlContext; }
            set { this._outsideSqlContext = value; }
        }

        public MbFetchNarrowingBean FetchNarrowingBean {
            get { return _fetchNarrowingBean; }
            set { this._fetchNarrowingBean = value; }
        }

        public IDictionary<String, Object> InternalMap {
            get { return _internalMap; }
            set { this._internalMap = value; }
        }
    }
}


using System;
using System.Collections;
using System.Reflection;
using System.Text;
using System.Threading;

namespace DfExample.DBFlute.MemberDb.AllCommon.CBean {

/**
 * FetchNarrowing-Bean context. (referring to s2pager)
 * 
 * @author DBFlute(AutoGenerator)
 */
    public static class MbFetchNarrowingBeanContext {

        /** The thread-local for this. */
        private static LocalDataStoreSlot _fetchNarrowingBeanSlot = Thread.AllocateDataSlot();

        /**
         * Get fetch-narrowing-bean context on thread.
         * 
         * @return FetchNarrowing-bean. (NullAllowed)
         */
        public static MbFetchNarrowingBean GetFetchNarrowingBeanOnThread() {
            return (MbFetchNarrowingBean)Thread.GetData(_fetchNarrowingBeanSlot);
        }

        /**
         * Set fetch-narrowing-bean context on thread.
         * 
         * @param cb FetchNarrowing-bean. (NotNull)
         */
        public static void SetFetchNarrowingBeanOnThread(MbFetchNarrowingBean cb) {
            if (cb == null) {
                String msg = "The argument[cb] must not be null.";
                throw new ArgumentNullException(msg);
            }
            Thread.SetData(_fetchNarrowingBeanSlot, cb);
        }

        /**
         * Clear fetch-narrowing-bean context on thread.
         */
        public static void ClearFetchNarrowingBeanOnThread() {
            Thread.SetData(_fetchNarrowingBeanSlot, null);
        }

        /**
         * Is existing fetch-narrowing-bean context on thread?
         * 
         * @return The determination, true or false.
         */
        public static bool IsExistFetchNarrowingBeanOnThread() {
            return (Thread.GetData(_fetchNarrowingBeanSlot) != null);
        }

        /**
         * Is the argument fetch-narrowing-bean?
         * 
         * @param dtoInstance Dto instance.
         * @return The determination, true or false.
         */
        public static bool IsTheArgumentFetchNarrowingBean(Object dtoInstance) {
            if (dtoInstance is MbFetchNarrowingBean) {
                return true;
            } else {
                return false;
            }
        }

        /**
         * Is the type fetch-narrowing-bean?
         * 
         * @param dtoClass DtoClass.
         * @return The determination, true or false.
         */
        public static bool IsTheTypeFetchNarrowingBean(Type dtoType) {
            if (typeof(MbFetchNarrowingBean).IsAssignableFrom(dtoType)) {
                return true;
            } else {
                return false;
            }
        }
    }
}

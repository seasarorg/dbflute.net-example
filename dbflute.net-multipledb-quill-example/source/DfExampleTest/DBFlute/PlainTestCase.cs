using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using DfExample.DBFlute.MemberDb.AllCommon.Util;
using DfExample.DBFlute.MemberDb.ExBhv;
using MbUnit.Framework;
using Seasar.Framework.Container.Factory;
using Seasar.Framework.Container;
using System.Data;

namespace DfExample.DBFlute
{
    public class PlainTestCase {

        /// <summary>Log instance.</summary>
        protected static readonly log4net.ILog _log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        // ===============================================================================
        //                                                        Java Like General Helper
        //                                                        ========================
        protected void Log(Object msg) {
            _log.Debug(msg);
        }

        protected void log(Object msg) {
            _log.Debug(msg);
        }

        // ===============================================================================
        //                                                         Java Like Assert Helper
        //                                                         =======================
        protected void assertEquals(Object expected, Object actual) {
            Assert.AreEqual(expected, actual);
        }

        // append @nishikata
        protected void assertEquals(String msg, Object expected, Object actual) {
            Assert.AreEqual(expected, actual, msg);
        }
        //

        protected void assertNotSame(Object expected, Object actual) {
            // intå^ÇÃÇ∆Ç´Ç…ê≥èÌÇ…ìÆçÏÇµÇ»Ç©Ç¡ÇΩÇÃÇ≈ïîï™ìIÇ…é©ëOÇ≈é¿ëï
            if (expected != null && actual != null && expected is int && actual is int) {
                if (expected.ToString() == actual.ToString()) {
                    fail("Expected 'Not Same' but expected=[" + expected + "], actual=[" + actual + "]");
                }
            }
            Assert.AreNotSame(expected, actual);
        }

        protected void assertTrue(bool obj) {
            Assert.IsTrue(obj);
        }

        // append @nishikata
        protected void assertTrue(String msg, bool obj) {
            Assert.IsTrue(obj, msg);
        }
        //

        protected void assertFalse(bool obj) {
            Assert.IsFalse(obj);
        }

        protected void assertNull(Object obj) {
            Assert.IsNull(obj);
        }

        protected void assertNotNull(Object obj) {
            Assert.IsNotNull(obj);
        }

        protected void fail() {
            Assert.Fail();
        }

        protected void fail(String msg) {
            Assert.Fail(msg);
        }

        // ===============================================================================
        //                                                                  General Helper
        //                                                                  ==============

        public void SetupLog4Net()
        {
            log4net.Config.XmlConfigurator.Configure();
        }

        public DateTime currentTimestamp() {
            return DateTime.Now;
        }

        public String getLineSeparator() {
            return MbSimpleSystemUtil.GetLineSeparator();
        }

        public String toString(Object obj) {
            if (obj is System.Collections.IList) {
                StringBuilder sb = new StringBuilder();
                System.Collections.IList ls = (IList)obj;
                foreach (Object element in ls) {
                    if (sb.Length == 0) {
                        sb.Append(element != null ? element.ToString() : "null");
                    } else {
                        sb.Append(", ").Append(element != null ? element.ToString() : "null");
                    }
                }
                return sb.ToString();
            }
            return obj != null ? obj.ToString() : null;
        }
    }
}

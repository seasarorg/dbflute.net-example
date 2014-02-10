using System;
using System.Collections.Generic;
using System.Reflection;
using DfExample.DBFlute.AllCommon;
using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.Util;
using DfExample.DBFlute.CBean;
using DfExample.DBFlute.ExBhv;
using DfExample.DBFlute.ExEntity;
using Seasar.Framework.Util;
using Seasar.Quill.Unit;
using Seasar.Extension.Unit;

namespace DfExample.DBFlute.Various.WhiteBox.Runtime.Util {

    [MbUnit.Framework.TestFixture]
    public class TxTraceViewUtilTest : ContainerTestCase {

        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void TraceViewUtil_ConvertToPerformanceView_basic() {
            DateTime before = DateTime.Now;
            {
                DateTime after = before.AddMilliseconds(1);
                assertEquals("00m00s001ms", TraceViewUtil.ConvertToPerformanceView(before, after));
            }
            {
                DateTime after = before.AddMilliseconds(-1);
                assertEquals("-1", TraceViewUtil.ConvertToPerformanceView(before, after));
            }
            {
                DateTime after = before;
                assertEquals("00m00s000ms", TraceViewUtil.ConvertToPerformanceView(before, after));
            }
            {
                DateTime after = before.AddSeconds(1);
                assertEquals("00m01s000ms", TraceViewUtil.ConvertToPerformanceView(before, after));
            }
            {
                DateTime after = before.AddMinutes(1);
                assertEquals("01m00s000ms", TraceViewUtil.ConvertToPerformanceView(before, after));
            }
            {
                DateTime after = before.AddHours(1);
                assertEquals("60m00s000ms", TraceViewUtil.ConvertToPerformanceView(before, after));
            }
            {
                DateTime after = before.AddHours(23);
                assertEquals("1380m00s000ms", TraceViewUtil.ConvertToPerformanceView(before, after));
            }
            {
                DateTime after = before.AddDays(1);
                assertEquals("1440m00s000ms", TraceViewUtil.ConvertToPerformanceView(before, after));
            }
            {
                DateTime after = before.AddDays(1).AddHours(1).AddMinutes(20).AddSeconds(12).AddMilliseconds(789);
                assertEquals("1520m12s789ms", TraceViewUtil.ConvertToPerformanceView(before, after));
            }
        }
    }
}

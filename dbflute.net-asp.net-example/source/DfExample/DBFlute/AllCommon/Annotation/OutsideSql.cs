
using System;

namespace DfExample.DBFlute.AllCommon.Annotation {

    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public class OutsideSql : Attribute {
        public OutsideSql() {
        }
    }
}

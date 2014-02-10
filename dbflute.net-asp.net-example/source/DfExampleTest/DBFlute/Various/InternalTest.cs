using System;
using System.Reflection;
using DfExample.DBFlute.AllCommon;
using Seasar.Framework.Util;
using Seasar.Quill.Unit;
using Seasar.Extension.Unit;

namespace DfExample.DBFlute.Various
{
    [MbUnit.Framework.TestFixture]
    public class InternalTest : ContainerTestCase {
        
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void DotDotDirectory() {
            Assembly asm = typeof(Entity).Assembly;
            {
                String path = "DfExample.DBFlute.TestDir.NonDot.testfile.sql";
                assertTrue(IsExistResource(path, asm));
            }
            {
                String path = "DfExample.DBFlute.TestDir.Dot.Dot.testfile.sql";
                assertTrue(IsExistResource(path, asm));
            }
        }

        protected virtual bool IsExistResource(String path, Assembly asm) {
            return ResourceUtil.IsExist(path, asm);
        }
    }
}

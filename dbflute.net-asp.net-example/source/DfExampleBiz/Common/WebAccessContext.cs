using System;
using DfExample.DBFlute.AllCommon;

namespace DfExampleBiz.Common
{
    /// <summary>
    /// アクセスコンテキスト部分を適当に設定する
    /// </summary>
    public class WebAccessContext
    {
        /// <summary>
        /// アクセスコンテキストを設定
        /// </summary>
        public static void SetAccessContext()
        {
            //サンプルなのでこれで。。。
            AccessContext context = new AccessContext();
            context.AccessTimestamp = DateTime.Now;
            context.AccessUser = "test";
            context.AccessProcess = "user";
            AccessContext.SetAccessContextOnThread(context);
        }

        public static void ClearAccessContext()
        {
            AccessContext.ClearAccessContextOnThread();
        }
    }
}

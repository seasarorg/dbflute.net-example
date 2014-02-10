using System;
using System.Collections;
using System.Text;
using DfExample.DBFlute.AllCommon;
using DfExample.DBFlute.AllCommon.Util;
using Seasar.Quill.Unit;
using MbUnit.Framework;
using DfExample.DBFlute.ExBhv;

namespace DfExample.DBFlute {

    public class ContainerTestCase : QuillTestCase {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        /// <summary>Log instance.</summary>
        protected static readonly log4net.ILog _log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected DateTime? _accessTimestamp = DateTime.Now;
        protected String _accessUser = "testUser";
        protected String _accessProcess = "testProcess";

        // ===============================================================================
        //                                                                           Setup
        //                                                                           =====
        [MbUnit.Framework.SetUp]
        public void Before() {
            // テストケース実行前の準備処理
            // 
            // /- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
            // 実際のアプリケーションにおいては、以下のタイミングで実行する必要がある。
            // 
            // {1}は、アプリケーションの初期化時に実行。
            // {2}は、リクエスト処理の共通ポイントで実行。
            // {3}は、Quillコンポーネントを利用するクラスで実行。
            // - - - - - - - - - -/
            // 1. Log4Netの初期化
            log4net.Config.XmlConfigurator.Configure();

            // 2. リクエストコンポーネントの初期化処理
            InitializeRequestComponent();

            // 3. TestクラスにQuillコンポーネントをインジェクション
            // 
            //  --> QuillTestCaseがやってくれるので不要となった(2008/03/06)
            // 
            // Seasar.Quill.QuillInjector.GetInstance().Inject(this);
        }

        protected void InitializeRequestComponent() {
            // CommonColumnの自動設定のためのAccessContextの設定。
            // 
            // /- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
            // 実際のアプリケーションでは、リクエストが発行されたタイミングで以下の処理を行う。
            // また、正常終了・例外終了双方で必ずAccessContextが破棄されるようにすること。
            // (PageクラスなどにAspectをかけて処理するのが定番)
            // - - - - - - - - - -/
            AccessContext context = new AccessContext();
            context.AccessTimestamp = _accessTimestamp;
            context.AccessUser = _accessUser;
            context.AccessProcess = _accessProcess;
            AccessContext.SetAccessContextOnThread(context);
        }

        // ===============================================================================
        //                                                                        TearDown
        //                                                                        ========
        [MbUnit.Framework.TearDown]
        public void After() {
            AccessContext.ClearAccessContextOnThread();
        }

        // ===============================================================================
        //                                                                   Assist Helper
        //                                                                   =============
        protected BehaviorSelector _internalSelector;
        protected void deleteMemberReferrers() {
            {
                PurchaseBhv bhv = _internalSelector.Select<PurchaseBhv>();
                bhv.QueryDelete(bhv.NewMyConditionBean());
            }
            {
                MemberAddressBhv bhv = _internalSelector.Select<MemberAddressBhv>();
                bhv.QueryDelete(bhv.NewMyConditionBean());
            }
            {
                MemberLoginBhv bhv = _internalSelector.Select<MemberLoginBhv>();
                bhv.QueryDelete(bhv.NewMyConditionBean());
            }
            {
                MemberWithdrawalBhv bhv = _internalSelector.Select<MemberWithdrawalBhv>();
                bhv.QueryDelete(bhv.NewMyConditionBean());
            }
            {
                MemberSecurityBhv bhv = _internalSelector.Select<MemberSecurityBhv>();
                bhv.QueryDelete(bhv.NewMyConditionBean());
            }
        }

        protected virtual String SqlDirBase { get { return "DfExample/Resources/Sql"; } }

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
            // int型のときに正常に動作しなかったので部分的に自前で実装
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
        public DateTime currentTimestamp()
        {
            return DateTime.Now;
        }

        public String getLineSeparator() {
            return SimpleSystemUtil.GetLineSeparator();
        }

        public String toString(Object obj) {
            if (obj is IList) {
                StringBuilder sb = new StringBuilder();
                IList ls = (IList) obj;
                foreach(Object element in ls) {
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

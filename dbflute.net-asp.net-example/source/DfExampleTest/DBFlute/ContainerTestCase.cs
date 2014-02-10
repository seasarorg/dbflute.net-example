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
            // �e�X�g�P�[�X���s�O�̏�������
            // 
            // /- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
            // ���ۂ̃A�v���P�[�V�����ɂ����ẮA�ȉ��̃^�C�~���O�Ŏ��s����K�v������B
            // 
            // {1}�́A�A�v���P�[�V�����̏��������Ɏ��s�B
            // {2}�́A���N�G�X�g�����̋��ʃ|�C���g�Ŏ��s�B
            // {3}�́AQuill�R���|�[�l���g�𗘗p����N���X�Ŏ��s�B
            // - - - - - - - - - -/
            // 1. Log4Net�̏�����
            log4net.Config.XmlConfigurator.Configure();

            // 2. ���N�G�X�g�R���|�[�l���g�̏���������
            InitializeRequestComponent();

            // 3. Test�N���X��Quill�R���|�[�l���g���C���W�F�N�V����
            // 
            //  --> QuillTestCase������Ă����̂ŕs�v�ƂȂ���(2008/03/06)
            // 
            // Seasar.Quill.QuillInjector.GetInstance().Inject(this);
        }

        protected void InitializeRequestComponent() {
            // CommonColumn�̎����ݒ�̂��߂�AccessContext�̐ݒ�B
            // 
            // /- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
            // ���ۂ̃A�v���P�[�V�����ł́A���N�G�X�g�����s���ꂽ�^�C�~���O�ňȉ��̏������s���B
            // �܂��A����I���E��O�I���o���ŕK��AccessContext���j�������悤�ɂ��邱�ƁB
            // (Page�N���X�Ȃǂ�Aspect�������ď�������̂����)
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
            // int�^�̂Ƃ��ɐ���ɓ��삵�Ȃ������̂ŕ����I�Ɏ��O�Ŏ���
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

using System;
using System.Collections.Generic;
using DfExample.DBFlute;
using DfExample.DBFlute.LibraryDb.AllCommon.S2Dao;
using DfExample.DBFlute.LibraryDb.CBean;
using DfExample.DBFlute.LibraryDb.ExDao;
using DfExample.DBFlute.LibraryDb.ExEntity;
using DfExample.DBFlute.MemberDb.AllCommon.S2Dao;
using DfExample.DBFlute.MemberDb.CBean;
using DfExample.DBFlute.MemberDb.ExDao;
using DfExample.DBFlute.MemberDb.ExEntity;
using MbUnit.Framework;
using Seasar.Quill.Attrs;

namespace DfExampleTest.DBFlute.MultipleDb
{
    /// <summary>
    /// 二つのデータソースに対して検索、更新をかけてみるテスト
    /// </summary>
    [TestFixture]
    public class BasicSelectAndUpdateTest : PlainTestCase
    {
        #region Setup and TearDown
#if NET_4_0
        [FixtureSetUp]
#else
        [TestFixtureSetUp]
#endif
        public void SetupFixture()
        {
            SetupLog4Net();
            QuillTestHelper.Inject(this);
        }

        #endregion

        [Test]
        public void TestSelectList()
        {
            TwoDataSourceTxMb actual = QuillTestHelper.GetInjectedComponent<TwoDataSourceTxMb>();
            actual.ExecuteSelectOnly();
        }

        [Test]
        public void TestMultiSelectAndUpdate()
        {
            BeginTransaction();

            TwoDataSourceTxMb actual = QuillTestHelper.GetInjectedComponent<TwoDataSourceTxMb>();
            actual.Execute();

            Rollback();
        }

        /// <summary>
        /// 検索、更新→例外発生時に両データソース共ロールバックされるか
        /// </summary>
        [Test]
        public void TestMultiSelectAndUpdateWithException()
        {
            TwoDataSourceTxMb actual = QuillTestHelper.GetInjectedComponent<TwoDataSourceTxMb>();

            try
            {
                actual.ExecuteAndRaiseException();
            }
            catch (ApplicationException ex)
            {
                _log.Debug(ex.Message);
            }
            //  ロールバックされているか確認するために再度検索
            actual.ExecuteSelectOnly();
        }

        #region Helper

        private void BeginTransaction()
        {
            _log.Debug("MemberDb_Tx:START");
            QuillTestHelper.BeginTransaction(typeof(MbTxSetting));
            _log.Debug("LibraryDb_Tx:START");
            QuillTestHelper.BeginTransaction(typeof(LdTxSetting));
        }

        private void Rollback()
        {
            _log.Debug("MemberDb_Tx:END");
            QuillTestHelper.RollbackTransaction(typeof(MbTxSetting));
            _log.Debug("LibraryDb_Tx:END");
            QuillTestHelper.RollbackTransaction(typeof(LdTxSetting));
        }

        #endregion
    }

    [Implementation]
    public class TwoDataSourceTxMb
    {
        protected TwoDataSourceTxLd _ld;
        protected MbMemberDao _mbDao;
        protected LdBookDao _ldDao;

        [Transaction(typeof(MbTxSetting))]
        public virtual void ExecuteSelectOnly()
        {
            _ld.ExecuteSelectOnly();
        }

        /// <summary>
        /// 要Rollback
        /// </summary>
        [Transaction(typeof(MbTxSetting))]
        public virtual void Execute()
        {
            _ld.Execute();
        }

        [Transaction(typeof(MbTxSetting))]
        public virtual void ExecuteAndRaiseException()
        {
            _ld.ExecuteAndRaiseException();
        }
    }

    [Implementation]
    public class TwoDataSourceTxLd
    {
        protected MbMemberDao _mbDao;
        protected LdBookDao _ldDao;

        /// <summary>
        /// ひとまず二つのデータソースに対しての検索は行えるか確認
        /// </summary>
        [Transaction(typeof(LdTxSetting))]
        public virtual void ExecuteSelectOnly()
        {
            MbMemberCB mbMemberCB = new MbMemberCB();
            mbMemberCB.Query().SetMemberId_Equal(1);

            LdBookCB ldBookCB = new LdBookCB();
            ldBookCB.Query().SetBookId_Equal(1);

            IList<MbMember> mbMembers = _mbDao.SelectList(mbMemberCB);
            Assert.AreEqual(1, mbMembers.Count);

            IList<LdBook> ldBooks = _ldDao.SelectList(ldBookCB);
            Assert.AreEqual(1, ldBooks.Count);

            Console.WriteLine("<<< Assert memberDb >>>");
            MbMember member = mbMembers[0];
            Assert.AreEqual("Stojkovic", member.MemberName);

            Console.WriteLine("<<< Assert libraryDb >>>");
            LdBook ldBook = ldBooks[0];
            Assert.AreEqual("X0000000001", ldBook.Isbn);
        }

        /// <summary>
        /// 二つのDataSourceに対して検索→更新→検索→更新されているか確認
        /// </summary>
        [Transaction(typeof(LdTxSetting))]
        public virtual void Execute()
        {
            MbMemberCB mbMemberCB = new MbMemberCB();
            mbMemberCB.Query().SetMemberId_Equal(1);

            LdBookCB ldBookCB = new LdBookCB();
            ldBookCB.Query().SetBookId_Equal(1);

            //  検索 ----------------------------------------------
            IList<MbMember> mbMembers = _mbDao.SelectList(mbMemberCB);
            Assert.AreEqual(1, mbMembers.Count);

            IList<LdBook> ldBooks = _ldDao.SelectList(ldBookCB);
            Assert.AreEqual(1, ldBooks.Count);

            //  更新 ----------------------------------------------
            Console.WriteLine("<<< Update memberDb >>>");
            MbMember member = mbMembers[0];
            Assert.AreEqual("Stojkovic", member.MemberName);
            member.MemberName = "Change!";
            _mbDao.UpdateModifiedOnly(member);

            Console.WriteLine("<<< Update libraryDb >>>");
            LdBook ldBook = ldBooks[0];
            Assert.AreEqual("X0000000001", ldBook.Isbn);
            ldBook.Isbn = "Y0000000001";
            _ldDao.UpdateModifiedOnly(ldBook);

            //  再検索 ---------------------------------------------
            IList<MbMember> mbMembersAfter = _mbDao.SelectList(mbMemberCB);
            Assert.AreEqual(1, mbMembersAfter.Count);

            IList<LdBook> ldBooksAfter = _ldDao.SelectList(ldBookCB);
            Assert.AreEqual(1, ldBooksAfter.Count);

            Console.WriteLine("<<< Assert memberDb >>>");
            MbMember memberAfter = mbMembersAfter[0];
            Assert.AreEqual("Change!", memberAfter.MemberName);

            Console.WriteLine("<<< Assert libraryDb >>>");
            LdBook ldBookAfter = ldBooksAfter[0];
            Assert.AreEqual("Y0000000001", ldBookAfter.Isbn);
        }

        /// <summary>
        /// 例外発生時にロールバックされるか確認
        /// </summary>
        [Transaction(typeof(LdTxSetting))]
        public virtual void ExecuteAndRaiseException()
        {
            MbMemberCB mbMemberCB = new MbMemberCB();
            mbMemberCB.Query().SetMemberId_Equal(1);

            LdBookCB ldBookCB = new LdBookCB();
            ldBookCB.Query().SetBookId_Equal(1);

            //  検索 ----------------------------------------------
            IList<MbMember> mbMembers = _mbDao.SelectList(mbMemberCB);
            Assert.AreEqual(1, mbMembers.Count);

            IList<LdBook> ldBooks = _ldDao.SelectList(ldBookCB);
            Assert.AreEqual(1, ldBooks.Count);

            //  更新 ----------------------------------------------
            Console.WriteLine("<<< Update memberDb >>>");
            MbMember member = mbMembers[0];
            Assert.AreEqual("Stojkovic", member.MemberName);
            member.MemberName = "Change!";
            _mbDao.UpdateModifiedOnly(member);

            Console.WriteLine("<<< Update libraryDb >>>");
            LdBook ldBook = ldBooks[0];
            Assert.AreEqual("X0000000001", ldBook.Isbn);
            ldBook.Isbn = "Y0000000001";
            _ldDao.UpdateModifiedOnly(ldBook);

            Console.WriteLine("Raise exception !!");
            throw new ApplicationException("Rollbackを確認するためのException");
        }
    }
}

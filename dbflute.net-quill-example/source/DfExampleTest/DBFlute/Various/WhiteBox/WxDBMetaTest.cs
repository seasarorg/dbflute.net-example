using System;
using DfExample.DBFlute.AllCommon.Dbm.Info;
using DfExample.DBFlute.AllCommon.JavaLike;
using DfExample.DBFlute.BsEntity.Dbm;
using Seasar.Quill.Unit;
using Seasar.Extension.Unit;

namespace DfExample.DBFlute.Various.WhiteBox {

    [MbUnit.Framework.TestFixture]
    public class TxDBMetaTest : PlainTestCase {

        // ===============================================================================
        //                                                                      ColumnInfo
        //                                                                      ==========
        [MbUnit.Framework.Test]
        public void ColumnInfo_ForeignInfoList() {
            // ## Arrange ##
            MemberDbm dbm = MemberDbm.GetInstance();

            // ## Act##
            List<ForeignInfo> foreignInfoList = dbm.ColumnMemberId.ForeignInfoList;

            // ## Assert ##
            assertNotSame(0, foreignInfoList.size());
            foreach (ForeignInfo foreignInfo in foreignInfoList) {
                log(foreignInfo);
            }
        }

        [MbUnit.Framework.Test]
        public void ColumnInfo_ReferrerInfoList() {
            // ## Arrange ##
            MemberDbm dbm = MemberDbm.GetInstance();

            // ## Act##
            List<ReferrerInfo> referrerInfoList = dbm.ColumnMemberId.ReferrerInfoList;

            // ## Assert ##
            assertNotSame(0, referrerInfoList.size());
            foreach (ReferrerInfo referrerInfo in referrerInfoList) {
                log(referrerInfo);
            }
        }

        [MbUnit.Framework.Test]
        public void ColumnInfo_ForeignInfoList_empty() {
            // ## Arrange ##
            MemberDbm dbm = MemberDbm.GetInstance();

            // ## Act##
            List<ForeignInfo> foreignInfoList = dbm.ColumnMemberName.ForeignInfoList;

            // ## Assert ##
            assertEquals(0, foreignInfoList.size());
        }

        [MbUnit.Framework.Test]
        public void ColumnInfo_ReferrerInfoList_empty() {
            // ## Arrange ##
            MemberDbm dbm = MemberDbm.GetInstance();

            // ## Act##
            List<ReferrerInfo> referrerInfoList = dbm.ColumnMemberName.ReferrerInfoList;

            // ## Assert ##
            assertEquals(0, referrerInfoList.size());
        }
    }
}
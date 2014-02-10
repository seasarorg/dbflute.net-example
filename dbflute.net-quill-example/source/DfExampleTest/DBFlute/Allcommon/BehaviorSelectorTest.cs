using System;
using System.Collections;
using System.Reflection;
using DfExample.DBFlute.AllCommon.Bhv;
using DfExample.DBFlute.AllCommon.Dbm;
using DfExample.DBFlute.AllCommon.S2Dao;
using DfExample.DBFlute.ExBhv;
using Seasar.Extension.Unit;
using DfExample.DBFlute.CBean;
using Seasar.Quill.Unit;

namespace DfExample.DBFlute.AllCommon {

    [MbUnit.Framework.TestFixture]
    public class BehaviorSelectorTest : ContainerTestCase {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected BehaviorSelector _behaviorSelector;
        protected MemberBhv _memberBhv;

        // ===============================================================================
        //                                                                           Basic
        //                                                                           =====
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void InitializeConditionBeanMetaData() {
            // ## Arrange ##
            assertNotNull(_behaviorSelector);

            // ## Act ##
            _behaviorSelector.InitializeConditionBeanMetaData();

            // ## Assert ##
            // assertFalse(getDaoMetaDataCache().isEmpty());
            _memberBhv.SelectList(new MemberCB()); // Expect no exception!
            _memberBhv.SelectList(new MemberCB()); // Expect no exception!
        }

        // ===============================================================================
        //                                                                          byName
        //                                                                          ======
        /**
         * テーブル名からBehaviorを取得して、テーブルのプロパティ名を取得する。
         */
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void ByName_and_TablePropertyName() {
            // ## Arrange ##
            String tableDbName = "MEMBER";

            // ## Act ##
            BehaviorReadable bhv = _behaviorSelector.ByName(tableDbName);
            DBMeta dbmeta = bhv.DBMeta;
            String tablePropertyName = dbmeta.TablePropertyName;

            // ## Assert ##
            assertNotNull(tablePropertyName);
            log("/********************************");
            log("tablePropertyName=" + tablePropertyName);
            log("**********/");
            assertNotNull(tablePropertyName);
        }
    }
}

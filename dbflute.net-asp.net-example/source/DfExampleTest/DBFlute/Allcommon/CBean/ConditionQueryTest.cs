using System;
using DfExample.DBFlute.AllCommon.CBean.CValue;
using DfExample.DBFlute.BsEntity.Dbm;
using DfExample.DBFlute.CBean;

namespace DfExample.DBFlute.AllCommon.CBean {

    [MbUnit.Framework.TestFixture]
    public class ConditionQueryTest : PlainTestCase {

        // ===============================================================================
        //                                                                           Basic
        //                                                                           =====
        [MbUnit.Framework.Test]
        public void test_invokeQuery_by_propertyName() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            String propertyName = MemberDbm.GetInstance().ColumnMemberName.PropertyName;

            // ## Act ##
            cb.Query().invokeQuery(propertyName, "Equal", "testValue");

            // ## Assert ##
            ConditionValue value = cb.Query().MemberName;
            log("conditionValue=" + value);
            assertEquals("testValue", value.Equal);
        }
        [MbUnit.Framework.Test]
        public void test_invokeQuery_by_columnName() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            String propertyName = MemberDbm.GetInstance().ColumnMemberName.ColumnDbName;

            // ## Act ##
            cb.Query().invokeQuery(propertyName, "Equal", "testValue");

            // ## Assert ##
            ConditionValue value = cb.Query().MemberName;
            log("conditionValue=" + value);
            assertEquals("testValue", value.Equal);
        }
        [MbUnit.Framework.Test]
        public void test_invokeQuery_resolveRelation() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            String foreingPropertyName = MemberDbm.GetInstance().ForeignMemberStatus.ForeignPropertyName;
            String propertyName = MemberStatusDbm.GetInstance().ColumnMemberStatusName.PropertyName;

            // ## Act ##
            cb.Query().invokeQuery(foreingPropertyName + "." + propertyName, "Equal", "testValue");

            // ## Assert ##
            ConditionValue value = cb.Query().QueryMemberStatus().MemberStatusName;
            log("conditionValue=" + value);
            assertEquals("testValue", value.Equal);
        }
        [MbUnit.Framework.Test]
        public void test_invokeQuery_resolveNestedRelation() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            String foreingPropertyName1 = MemberDbm.GetInstance().ForeignMemberWithdrawalAsOne.ForeignPropertyName;
            String foreingPropertyName2 = MemberWithdrawalDbm.GetInstance().ForeignWithdrawalReason.ForeignPropertyName;
            String propertyName = WithdrawalReasonDbm.GetInstance().ColumnWithdrawalReasonText.PropertyName;
            String targetName = foreingPropertyName1 + "." + foreingPropertyName2 + "." + propertyName;

            // ## Act ##
            cb.Query().invokeQuery(targetName, "Equal", "testValue");

            // ## Assert ##
            ConditionValue value = cb.Query().QueryMemberWithdrawalAsOne().QueryWithdrawalReason().WithdrawalReasonText;
            log("conditionValue=" + value);
            assertEquals("testValue", value.Equal);
        }
        [MbUnit.Framework.Test]
        public void test_invokeOrderBy_by_propertyName() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            String propertyName = MemberDbm.GetInstance().ColumnMemberName.PropertyName;
            String columnName = MemberDbm.GetInstance().ColumnMemberName.ColumnDbName;

            // ## Act ##
            cb.Query().invokeOrderBy(propertyName, true);

            // ## Assert ##
            String orderByClause = cb.Query().xgetSqlClause().getOrderByClause();
            log("orderByClause=" + orderByClause);
            assertTrue(orderByClause.Contains(columnName));
            assertTrue(orderByClause.Contains("asc"));
        }
        [MbUnit.Framework.Test]
        public void test_invokeOrderBy_by_columnName() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            String columnName = MemberDbm.GetInstance().ColumnMemberName.ColumnDbName;

            // ## Act ##
            cb.Query().invokeOrderBy(columnName, true);

            // ## Assert ##
            String orderByClause = cb.Query().xgetSqlClause().getOrderByClause();
            log("orderByClause=" + orderByClause);
            assertTrue(orderByClause.Contains(columnName));
            assertTrue(orderByClause.Contains("asc"));
        }
        [MbUnit.Framework.Test]
        public void test_invokeOrderBy_resolveRelation() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            String foreingPropertyName = MemberDbm.GetInstance().ForeignMemberStatus.ForeignPropertyName;
            String propertyName = MemberStatusDbm.GetInstance().ColumnMemberStatusName.PropertyName;
            String columnName = MemberStatusDbm.GetInstance().ColumnMemberStatusName.ColumnDbName;

            // ## Act ##
            cb.Query().invokeOrderBy(foreingPropertyName + "." + propertyName, false);

            // ## Assert ##
            String orderByClause = cb.Query().xgetSqlClause().getOrderByClause();
            log("orderByClause=" + orderByClause);
            assertTrue(orderByClause.Contains(columnName));
            assertTrue(orderByClause.Contains("desc"));
        }
        [MbUnit.Framework.Test]
        public void test_invokeOrderBy_resolveNestedRelation() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            String foreingPropertyName1 = MemberDbm.GetInstance().ForeignMemberWithdrawalAsOne.ForeignPropertyName;
            String foreingPropertyName2 = MemberWithdrawalDbm.GetInstance().ForeignWithdrawalReason.ForeignPropertyName;
            String propertyName = WithdrawalReasonDbm.GetInstance().ColumnWithdrawalReasonText.PropertyName;
            String targetName = foreingPropertyName1 + "." + foreingPropertyName2 + "." + propertyName;
            String columnName = WithdrawalReasonDbm.GetInstance().ColumnWithdrawalReasonText.ColumnDbName;

            // ## Act ##
            cb.Query().invokeOrderBy(targetName, false);

            // ## Assert ##
            String orderByClause = cb.Query().xgetSqlClause().getOrderByClause();
            log("orderByClause=" + orderByClause);
            assertTrue(orderByClause.Contains(columnName));
            assertTrue(orderByClause.Contains("desc"));
        }
    }
}

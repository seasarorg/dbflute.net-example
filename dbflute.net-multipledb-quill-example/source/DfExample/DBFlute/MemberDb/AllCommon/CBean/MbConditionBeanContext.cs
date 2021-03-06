
using System;
using System.Collections;
using System.Reflection;
using System.Text;
using System.Threading;

using DfExample.DBFlute.MemberDb.AllCommon.CBean;
using DfExample.DBFlute.MemberDb.AllCommon.CBean.CKey;
using DfExample.DBFlute.MemberDb.AllCommon.Exp;
using DfExample.DBFlute.MemberDb.AllCommon.JavaLike;
using DfExample.DBFlute.MemberDb.AllCommon.S2Dao.Internal.SqlParser;
using DfExample.DBFlute.MemberDb.AllCommon.Util;

namespace DfExample.DBFlute.MemberDb.AllCommon.CBean {

    public static class MbConditionBeanContext {

        private static LocalDataStoreSlot _slot = Thread.AllocateDataSlot();

        public static MbConditionBean GetConditionBeanOnThread() {
            return (MbConditionBean)Thread.GetData(_slot);
        }

        public static void SetConditionBeanOnThread(MbConditionBean cb) {
            if (cb == null) {
                String msg = "The argument[cb] must not be null.";
                throw new ArgumentNullException(msg);
            }
            Thread.SetData(_slot, cb);
        }

        public static void ClearConditionBeanOnThread() {
            Thread.SetData(_slot, null);
        }

        public static bool IsExistConditionBeanOnThread() {
            return (Thread.GetData(_slot) != null);
        }

        public static bool IsTheArgumentConditionBean(Object dtoInstance) {
            if (dtoInstance is MbConditionBean) {
                return true;
            } else {
                return false;
            }
        }

        public static bool IsTheTypeConditionBean(Type dtoType) {
            if (typeof(MbConditionBean).IsAssignableFrom(dtoType)) {
                return true;
            } else {
                return false;
            }
        }

        // ===================================================================================
        //                                                                  Exception Handling
        //                                                                  ==================
        public static void ThrowEntityAlreadyDeletedException(Object searchKey4Log) {
            String msg = "Look! Read the message below." + ln();
            msg = msg + "/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *" + ln();
            msg = msg + "The entity was Not Found! it has already been deleted!" + ln();
            msg = msg + ln();
            msg = msg + "[Advice]" + ln();
            msg = msg + "Please confirm the existence of your target record on your database." + ln();
            msg = msg + "Does the target record really created before this operation?" + ln();
            msg = msg + "Has the target record been deleted by other thread?" + ln();
            msg = msg + "It is precondition that the record exists on your database." + ln();
            msg = msg + ln();
            if (searchKey4Log != null && searchKey4Log is MbConditionBean) {
                MbConditionBean cb = (MbConditionBean)searchKey4Log;
                String dispalySql = cb.ToDisplaySql();
                msg = msg + "[Display SQL]" + ln() + dispalySql + ln();
            } else {
                msg = msg + "[Search Condition]" + ln() + searchKey4Log + ln();
            }
            msg = msg + "* * * * * * * * * */";
            throw new MbEntityAlreadyDeletedException(msg);
        }

        public static void ThrowEntityDuplicatedException(String resultCountString, Object searchKey4Log, Exception cause) {
            String msg = "Look! Read the message below." + ln();
            msg = msg + "/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *" + ln();
            msg = msg + "The entity was Too Many! it has been duplicated. It should be the only one! But the resultCount=" + resultCountString + ln();
            msg = msg + ln();
            msg = msg + "[Advice]" + ln();
            msg = msg + "Please confirm your search condition. Does it really select the only one?" + ln();
            msg = msg + "Please confirm your database. Does it really exist the only one?" + ln();
            msg = msg + ln();
            if (searchKey4Log != null && searchKey4Log is MbConditionBean) {
                MbConditionBean cb = (MbConditionBean)searchKey4Log;
                String dispalySql = cb.ToDisplaySql();
                msg = msg + "[Display SQL]" + ln() + dispalySql + ln();
            } else {
                msg = msg + "[Search Condition]" + ln() + searchKey4Log + ln();
            }
            msg = msg + "* * * * * * * * * */";
            if (cause != null) {
                throw new MbEntityDuplicatedException(msg, cause);
            } else {
                throw new MbEntityDuplicatedException(msg);
            }
        }

        public static void throwSelectEntityConditionNotFoundException(MbConditionBean cb) {
            String msg = "Look! Read the message below." + ln();
            msg = msg + "/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *" + ln();
            msg = msg + "The condition for selecting an entity was not found!" + ln();
            msg = msg + ln();
            msg = msg + "[Advice]" + ln();
            msg = msg + "Confirm your search condition. Does it really select the only one?" + ln();
            msg = msg + "You have to set a valid query or fetch-first as 1." + ln();
            msg = msg + "For example:" + ln();
            msg = msg + "  (x):" + ln();
            msg = msg + "    MemberCB cb = MemberCB();" + ln();
            msg = msg + "    ... = memberBhv.SelectEntity(cb); // exception" + ln();
            msg = msg + "  (x):" + ln();
            msg = msg + "    MemberCB cb = MemberCB();" + ln();
            msg = msg + "    cb.Query().SetMemberId_Equal(null);" + ln();
            msg = msg + "    ... = memberBhv.SelectEntity(cb); // exception" + ln();
            msg = msg + "  (o):" + ln();
            msg = msg + "    MemberCB cb = MemberCB();" + ln();
            msg = msg + "    cb.Query().SetMemberId_Equal(3);" + ln();
            msg = msg + "    ... = memberBhv.SelectEntity(cb);" + ln();
            msg = msg + "  (o):" + ln();
            msg = msg + "    MemberCB cb = MemberCB();" + ln();
            msg = msg + "    cb.FetchFirst(1);" + ln();
            msg = msg + "    ... = memberBhv.SelectEntity(cb);" + ln();
            msg = msg + ln();
            msg = msg + "[Invalid Query]" + ln();
            Map<String, MbConditionKey> invalidQueryColumnMap = cb.SqlClause.getInvalidQueryColumnMap();
            if (invalidQueryColumnMap != null && !invalidQueryColumnMap.isEmpty()) {
                Set<String> keySet = invalidQueryColumnMap.keySet();
                foreach (String columnFullName in keySet) {
                    MbConditionKey key = invalidQueryColumnMap.get(columnFullName);
                    msg = msg + columnFullName + " : " + key.getConditionKey() + ln();
                }
            } else {
                msg = msg + "*no invalid" + ln();
            }
            msg = msg + ln();
            msg = msg + "[Fetch Size]" + ln();
            msg = msg + cb.FetchSize + ln();
            msg = msg + ln();
            msg = msg + "[Display SQL]" + ln();
            msg = msg + cb.ToDisplaySql() + ln();
            msg = msg + "* * * * * * * * * */";
            throw new MbSelectEntityConditionNotFoundException(msg);
        }

        // -----------------------------------------------------
        //                                Query Derived Referrer
        //                                ----------------------
        public static void ThrowQueryDerivedReferrerInvalidColumnSpecificationException(String function) {
            String msg = "Look! Read the message below." + ln();
            msg = msg + "/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *" + ln();
            msg = msg + "The specified the column for derived-referrer was Invalid!" + ln();
            msg = msg + ln();
            msg = msg + "[Advice]" + ln();
            msg = msg + " You should call specify().column[TargetColumn]() only once." + ln();
            msg = msg + " (If your function is count(), the target column should be primary key.)" + ln();
            msg = msg + "  For example:" + ln();
            msg = msg + "    (x):" + ln();
            msg = msg + "    /- - - - - - - - - - - - - - - - - - - - " + ln();
            msg = msg + "    MemberCB cb = new MemberCB();" + ln();
            msg = msg + "    cb.query().scalarPurchaseList().max(new SubQuery<PurchaseCB>() {" + ln();
            msg = msg + "        public void query(PurchaseCB subCB) {" + ln();
            msg = msg + "            // *No! It's empty!" + ln();
            msg = msg + "        }" + ln();
            msg = msg + "    }).greaterEqual(123);" + ln();
            msg = msg + "    - - - - - - - - - -/" + ln();
            msg = msg + ln();
            msg = msg + "    (x):" + ln();
            msg = msg + "    /- - - - - - - - - - - - - - - - - - - - " + ln();
            msg = msg + "    MemberCB cb = new MemberCB();" + ln();
            msg = msg + "    cb.query().scalarPurchaseList().max(new SubQuery<PurchaseCB>() {" + ln();
            msg = msg + "        public void query(PurchaseCB subCB) {" + ln();
            msg = msg + "            subCB.specify().columnPurchaseDatetime();" + ln();
            msg = msg + "            subCB.specify().columnPurchaseCount(); // *No! It's duplicated!" + ln();
            msg = msg + "        }" + ln();
            msg = msg + "    }).greaterEqual(123);" + ln();
            msg = msg + "    - - - - - - - - - -/" + ln();
            msg = msg + ln();
            msg = msg + "    (o):" + ln();
            msg = msg + "    /- - - - - - - - - - - - - - - - - - - - " + ln();
            msg = msg + "    MemberCB cb = new MemberCB();" + ln();
            msg = msg + "    cb.query().scalarPurchaseList().max(new SubQuery<PurchaseCB>() {" + ln();
            msg = msg + "        public void query(PurchaseCB subCB) {" + ln();
            msg = msg + "            subCB.specify().columnPurchaseDatetime(); // *Point!" + ln();
            msg = msg + "        }" + ln();
            msg = msg + "    }).greaterEqual(123);" + ln();
            msg = msg + "    - - - - - - - - - -/" + ln();
            msg = msg + ln();
            msg = msg + "[Function Method]" + ln() + xconvertFunctionToMethod(function) + ln();
            msg = msg + "* * * * * * * * * */";
            throw new IllegalStateException(msg);
        }

        public static void ThrowQueryDerivedReferrerUnmatchedColumnTypeException(String function, String deriveColumnName,
                Type deriveColumnType, Object value) {
            String msg = "Look! Read the message below." + ln();
            msg = msg + "/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *" + ln();
            msg = msg + "The type of the specified the column unmatched with the function or the parameter!" + ln();
            msg = msg + ln();
            msg = msg + "[Advice]" + ln();
            msg = msg + "You should confirm the list as follow:" + ln();
            msg = msg + "    count() : String, Number, Date *with distinct same" + ln();
            msg = msg + "    max()   : String, Number, Date" + ln();
            msg = msg + "    min()   : String, Number, Date" + ln();
            msg = msg + "    sum()   : Number" + ln();
            msg = msg + "    avg()   : Number" + ln();
            msg = msg + ln();
            msg = msg + "[Function Method]" + ln() + xconvertFunctionToMethod(function) + ln();
            msg = msg + ln();
            msg = msg + "[Derive Column]" + ln() + deriveColumnName + "(" + deriveColumnType.Name + ")" + ln();
            msg = msg + ln();
            msg = msg + "[Parameter Type]" + ln() + (value != null ? value.GetType() : null) + ln();
            msg = msg + "* * * * * * * * * */";
            throw new IllegalStateException(msg);
        }

	    // -----------------------------------------------------
	    //                                       Scalar SubQuery
	    //                                       ---------------
	    public static void ThrowScalarSubQueryInvalidForeignSpecificationException(String foreignPropertyName) {
	        String msg = "Look! Read the message below." + ln();
	        msg = msg + "/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *" + ln();
	        msg = msg + "You specified a foreign table column in spite of derived-query!" + ln();
	        msg = msg + ln();
	        msg = msg + "[Advice]" + ln();
	        msg = msg + "You should specified a local table column at condition-bean for derived-query." + ln();
	        msg = msg + "  For example:" + ln();
	        msg = msg + "    (x):" + ln();
	        msg = msg + "    /- - - - - - - - - - - - - - - - - - - - " + ln();
	        msg = msg + "    MemberCB cb = new MemberCB();" + ln();
	        msg = msg + "    cb.query().scalar_Equal().max(new SubQuery<MemberCB>() {" + ln();
	        msg = msg + "        public void query(MemberCB subCB) {" + ln();
	        msg = msg + "            subCB.specify().specifyMemberStatusName().columnDisplayOrder(); // *No!" + ln();
	        msg = msg + "        }" + ln();
	        msg = msg + "    });" + ln();
	        msg = msg + "    - - - - - - - - - -/" + ln();
	        msg = msg + ln();
	        msg = msg + "    (o):" + ln();
	        msg = msg + "    /- - - - - - - - - - - - - - - - - - - - " + ln();
	        msg = msg + "    MemberCB cb = new MemberCB();" + ln();
	        msg = msg + "    cb.query().scalar_Equal().max(new SubQuery<MemberCB>() {" + ln();
	        msg = msg + "        public void query(MemberCB subCB) {" + ln();
	        msg = msg + "            subCB.specify().columnMemberBirthday();// *Point!" + ln();
	        msg = msg + "        }" + ln();
	        msg = msg + "    });" + ln();
	        msg = msg + "    - - - - - - - - - -/" + ln();
	        msg = msg + ln();
	        msg = msg + "[Specified Foreign Property]" + ln() + foreignPropertyName + ln();
	        msg = msg + "* * * * * * * * * */";
	        throw new IllegalStateException(msg);
	    }
	
	    public static void ThrowScalarSubQueryInvalidColumnSpecificationException(String function) {
	        String msg = "Look! Read the message below." + ln();
	        msg = msg + "/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *" + ln();
	        msg = msg + "The specified the column for derived-referrer was Invalid!" + ln();
	        msg = msg + ln();
	        msg = msg + "[Advice]" + ln();
	        msg = msg + " You should call specify().column[TargetColumn]() only once." + ln();
	        msg = msg + " (If your function is count(), the target column should be primary key.)" + ln();
	        msg = msg + "  For example:" + ln();
	        msg = msg + "    (x):" + ln();
	        msg = msg + "    /- - - - - - - - - - - - - - - - - - - - " + ln();
	        msg = msg + "    MemberCB cb = new MemberCB();" + ln();
	        msg = msg + "    cb.query().scalar_Equal().max(new SubQuery<MemberCB>() {" + ln();
	        msg = msg + "        public void query(MemberCB subCB) {" + ln();
	        msg = msg + "            // *No! It's empty!" + ln();
	        msg = msg + "        }" + ln();
	        msg = msg + "    });" + ln();
	        msg = msg + "    - - - - - - - - - -/" + ln();
	        msg = msg + ln();
	        msg = msg + "    (x):" + ln();
	        msg = msg + "    /- - - - - - - - - - - - - - - - - - - - " + ln();
	        msg = msg + "    MemberCB cb = new MemberCB();" + ln();
	        msg = msg + "    cb.query().scalar_Equal().max(new SubQuery<MemberCB>() {" + ln();
	        msg = msg + "        public void query(MemberCB subCB) {" + ln();
	        msg = msg + "            subCB.specify().columnMemberBirthday();" + ln();
	        msg = msg + "            subCB.specify().columnMemberName(); // *No! It's duplicated!" + ln();
	        msg = msg + "        }" + ln();
	        msg = msg + "    });" + ln();
	        msg = msg + "    - - - - - - - - - -/" + ln();
	        msg = msg + ln();
	        msg = msg + "    (o):" + ln();
	        msg = msg + "    /- - - - - - - - - - - - - - - - - - - - " + ln();
	        msg = msg + "    MemberCB cb = new MemberCB();" + ln();
	        msg = msg + "    cb.query().scalar_Equal().max(new SubQuery<MemberCB>() {" + ln();
	        msg = msg + "        public void query(MemberCB subCB) {" + ln();
	        msg = msg + "            subCB.specify().columnPurchaseDatetime(); // *Point!" + ln();
	        msg = msg + "        }" + ln();
	        msg = msg + "    });" + ln();
	        msg = msg + "    - - - - - - - - - -/" + ln();
	        msg = msg + ln();
	        msg = msg + "[Function Method]" + ln() + xconvertFunctionToMethod(function) + ln();
	        msg = msg + "* * * * * * * * * */";
	        throw new IllegalStateException(msg);
	    }
	
	    public static void ThrowScalarSubQueryUnmatchedColumnTypeException(String function, String deriveColumnName,
	            Type deriveColumnType) {
	        String msg = "Look! Read the message below." + ln();
	        msg = msg + "/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *" + ln();
	        msg = msg + "The type of the specified the column unmatched with the function!" + ln();
	        msg = msg + ln();
	        msg = msg + "[Advice]" + ln();
	        msg = msg + "You should confirm the list as follow:" + ln();
	        msg = msg + "    max()   : String, Number, Date" + ln();
	        msg = msg + "    min()   : String, Number, Date" + ln();
	        msg = msg + "    sum()   : Number" + ln();
	        msg = msg + "    avg()   : Number" + ln();
	        msg = msg + ln();
	        msg = msg + "[Function Method]" + ln() + xconvertFunctionToMethod(function) + ln();
	        msg = msg + ln();
	        msg = msg + "[Derive Column]" + ln() + deriveColumnName + "(" + deriveColumnType.Name + ")" + ln();
	        msg = msg + "* * * * * * * * * */";
	        throw new IllegalStateException(msg);
	    }

        // -----------------------------------------------------
        //                                       Function Helper
        //                                       ---------------
        private static String xconvertFunctionToMethod(String function) {
            if (function != null && function.Contains("(")) { // For example 'count(distinct'
                int index = function.IndexOf("(");
                String front = function.Substring(0, index);
                if (function.Length > front.Length + "(".Length) {
                    String rear = function.Substring(index + "(".Length);
                    function = front + initCap(rear);
                } else {
                    function = front;
                }
            }
            return function + "()";
        }

        // ===============================================================================
        //                                                                     Display SQL
        //                                                                     ===========
        public static String ConvertConditionBean2DisplaySql(MbConditionBean cb) {
            String twoWaySql = cb.SqlClause.getClause();
            return MbInternalSqlParser.ConvertTwoWaySql2DisplaySql(twoWaySql, cb);
        }
    
        // ===============================================================================
        //                                                                  General Helper
        //                                                                  ==============
        private static String ln() {
            return MbSimpleSystemUtil.GetLineSeparator();
        }
        
        private static String initCap(String str) {
            return MbSimpleStringUtil.InitCap(str);
        }
    }
}

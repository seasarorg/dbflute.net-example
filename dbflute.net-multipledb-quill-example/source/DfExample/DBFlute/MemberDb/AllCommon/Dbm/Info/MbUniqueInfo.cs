
using System;

using DfExample.DBFlute.MemberDb.AllCommon.Dbm;
using DfExample.DBFlute.MemberDb.AllCommon.JavaLike;

namespace DfExample.DBFlute.MemberDb.AllCommon.Dbm.Info {

    public class MbUniqueInfo {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected MbDBMeta dbmeta;
        protected List<MbColumnInfo> uniqueColumnList;
        protected bool primary;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public MbUniqueInfo(MbDBMeta dbmeta, List<MbColumnInfo> uniqueColumnList, bool primary) {
            AssertObjectNotNull("dbmeta", dbmeta);
            AssertObjectNotNull("uniqueColumnList", uniqueColumnList);
            this.dbmeta = dbmeta;
            this.uniqueColumnList = uniqueColumnList;
            this.primary = primary;
        }

        // ===============================================================================
        //                                                                     Easy-to-Use
        //                                                                     ===========
        public bool ContainsColumn(MbColumnInfo columnInfo) {
            return ContainsColumn(columnInfo.ColumnDbName);
        }

        protected bool ContainsColumn(String columnName) {
            foreach (MbColumnInfo columnInfo in uniqueColumnList) {
                if (columnInfo.ColumnDbName.Equals(columnName)) {
                    return true;
                }
            }
            return false;
        }

        // ===============================================================================
        //                                                                  General Helper
        //                                                                  ==============
        protected void AssertObjectNotNull(String variableName, Object value) {
            if (variableName == null) {
                String msg = "The value should not be null: variableName=" + variableName + " value=" + value;
                throw new ArgumentException(msg);
            }
            if (value == null) {
                String msg = "The value should not be null: variableName=" + variableName;
                throw new ArgumentException(msg);
            }
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
       public MbDBMeta DBMeta {
           get { return dbmeta; }
       }

        public List<MbColumnInfo> UniqueColumnList {
            get { return uniqueColumnList; }
        }

        public MbColumnInfo FirstColumn {
            get { return (MbColumnInfo)this.uniqueColumnList.get(0); }
        }

        public bool IsTwoOrMore {
            get { return this.uniqueColumnList.size() > 1; }
        }

        public bool IsPrimary {
            get { return this.primary; }
        }
    }
}

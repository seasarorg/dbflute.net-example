
using System;

using DfExample.DBFlute.LibraryDb.AllCommon.Dbm;
using DfExample.DBFlute.LibraryDb.AllCommon.JavaLike;

namespace DfExample.DBFlute.LibraryDb.AllCommon.Dbm.Info {

    public class LdUniqueInfo {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected LdDBMeta dbmeta;
        protected List<LdColumnInfo> uniqueColumnList;
        protected bool primary;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public LdUniqueInfo(LdDBMeta dbmeta, List<LdColumnInfo> uniqueColumnList, bool primary) {
            AssertObjectNotNull("dbmeta", dbmeta);
            AssertObjectNotNull("uniqueColumnList", uniqueColumnList);
            this.dbmeta = dbmeta;
            this.uniqueColumnList = uniqueColumnList;
            this.primary = primary;
        }

        // ===============================================================================
        //                                                                     Easy-to-Use
        //                                                                     ===========
        public bool ContainsColumn(LdColumnInfo columnInfo) {
            return ContainsColumn(columnInfo.ColumnDbName);
        }

        protected bool ContainsColumn(String columnName) {
            foreach (LdColumnInfo columnInfo in uniqueColumnList) {
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
       public LdDBMeta DBMeta {
           get { return dbmeta; }
       }

        public List<LdColumnInfo> UniqueColumnList {
            get { return uniqueColumnList; }
        }

        public LdColumnInfo FirstColumn {
            get { return (LdColumnInfo)this.uniqueColumnList.get(0); }
        }

        public bool IsTwoOrMore {
            get { return this.uniqueColumnList.size() > 1; }
        }

        public bool IsPrimary {
            get { return this.primary; }
        }
    }
}

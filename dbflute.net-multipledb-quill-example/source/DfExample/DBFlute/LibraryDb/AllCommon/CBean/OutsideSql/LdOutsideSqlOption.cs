
using System;
using System.Collections.Generic;

using DfExample.DBFlute.LibraryDb.AllCommon.Ado;

namespace DfExample.DBFlute.LibraryDb.AllCommon.CBean.OutsideSql {

    public class LdOutsideSqlOption {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected String _pagingRequestType = "non";

        protected bool _dynamicBinding;

        protected LdStatementConfig _statementConfig;

        protected String _sourcePagingRequestType = "non";

        protected String _tableDbName;// The DB name of table. It is not related with the options of outside-SQL.

        // ===============================================================================
        //                                                                     Easy-to-Use
        //                                                                     ===========
        public void AutoPaging() {
            _pagingRequestType = "auto";
        }

        public void ManualPaging() {
            _pagingRequestType = "manual";
        }

        public void DynamicBinding() {
            _dynamicBinding = true;
        }

        // ===============================================================================
        //                                                                      Unique Key
        //                                                                      ==========
        public String GenerateUniqueKey() {
            return "{" + _pagingRequestType + "/" + _dynamicBinding + "}";
        }

        // ===============================================================================
        //                                                                            Copy
        //                                                                            ====
        public LdOutsideSqlOption CopyOptionWithoutPaging() {
            LdOutsideSqlOption copyOption = new LdOutsideSqlOption();
            copyOption.setPagingSourceRequestType(_pagingRequestType);
            if (IsDynamicBinding) {
                copyOption.DynamicBinding();
            }
            copyOption.TableDbName = _tableDbName;
            return copyOption;
        }


        // ===============================================================================
        //                                                                  Basic Override
        //                                                                  ==============
        public override String ToString() {
            return "{paging=" + _pagingRequestType + ", dynamic=" + _dynamicBinding + "}";
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public bool IsAutoPaging {
            get { return "auto".Equals(_pagingRequestType); }
        }

        public bool IsManualPaging {
            get { return "manual".Equals(_pagingRequestType); }
        }

        public bool IsDynamicBinding {
            get { return _dynamicBinding; }
        }

        public String TableDbName {
            get { return _tableDbName; }
            set { _tableDbName = value; }
        }

        public LdStatementConfig StatementConfig {
            get { return _statementConfig; }
            set { _statementConfig = value; }
        }

        protected void setPagingSourceRequestType(String sourcePagingRequestType) { // Very Internal
            _sourcePagingRequestType = sourcePagingRequestType;
        }

        public bool IsSourcePagingRequestTypeAuto { get { // Very Internal
            return "auto".Equals(_sourcePagingRequestType);
        }}
    }
}

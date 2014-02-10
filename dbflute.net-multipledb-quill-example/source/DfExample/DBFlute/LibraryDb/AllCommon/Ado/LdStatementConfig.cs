
using System;
using System.Data;

namespace DfExample.DBFlute.LibraryDb.AllCommon.Ado {

    public class LdStatementConfig {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
	    // -------------------------------------------------
        //                                  Statement Option
        //                                  ----------------
        protected int? _queryTimeout;

	    // ===============================================================================
        //                                                               Setting Interface
        //                                                               =================
    	// -------------------------------------------------
        //                                  Statement Option
        //                                  ----------------
        public LdStatementConfig QueryTimeout(int? queryTimeout) { _queryTimeout = queryTimeout; return this; }

	    // ===============================================================================
        //                                                                   Determination
        //                                                                   =============
    	// -------------------------------------------------
        //                                  Statement Option
        //                                  ----------------
        public bool HasQueryTimeout() {
            return _queryTimeout != null;
        }

        // ===============================================================================
        //                                                                  Basic Override
        //                                                                  ==============
	    public override String ToString() {
	        return "{" + _queryTimeout + "}";
	    }
	
	    // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
    	// -------------------------------------------------
        //                                  Statement Option
        //                                  ----------------
        public int? GetQueryTimeout() {
            return _queryTimeout;
        }
    }
}

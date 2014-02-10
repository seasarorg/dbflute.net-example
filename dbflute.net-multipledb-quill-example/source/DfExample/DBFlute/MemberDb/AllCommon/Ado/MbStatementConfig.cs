
using System;
using System.Data;

namespace DfExample.DBFlute.MemberDb.AllCommon.Ado {

    public class MbStatementConfig {

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
        public MbStatementConfig QueryTimeout(int? queryTimeout) { _queryTimeout = queryTimeout; return this; }

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

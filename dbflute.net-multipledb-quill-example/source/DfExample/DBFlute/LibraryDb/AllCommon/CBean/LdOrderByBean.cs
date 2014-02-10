
using System;
using System.Collections;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean.SClause;

namespace DfExample.DBFlute.LibraryDb.AllCommon.CBean {

    /// <summary>
    /// The condition-bean as interface.
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    public interface LdOrderByBean {

        /// <summary>
        /// The property of sql component of order-by clause.
        /// </summary>
        LdOrderByClause SqlComponentOfOrderByClause { get; }

        /**
         * Clear order-by.
         * 
         * @return this. (NotNull)
         */
        LdOrderByBean ClearOrderBy();

	    /**
	     * Ignore order-by.
	     * 
	     * @return this. (NotNull)
	     */
        LdOrderByBean IgnoreOrderBy();

	    /**
	     * Make order-by effective.
	     * 
	     * @return this. (NotNull)
	     */
        LdOrderByBean MakeOrderByEffective();

	    /**
	     * Get order-by clause.
	     * 
	     * @return Order-by clause. (NotNull)
	     */
	    String OrderByClause { get; }
    }
}

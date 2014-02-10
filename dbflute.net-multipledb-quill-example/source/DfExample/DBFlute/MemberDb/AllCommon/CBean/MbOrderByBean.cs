
using System;
using System.Collections;
using DfExample.DBFlute.MemberDb.AllCommon.CBean.SClause;

namespace DfExample.DBFlute.MemberDb.AllCommon.CBean {

    /// <summary>
    /// The condition-bean as interface.
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    public interface MbOrderByBean {

        /// <summary>
        /// The property of sql component of order-by clause.
        /// </summary>
        MbOrderByClause SqlComponentOfOrderByClause { get; }

        /**
         * Clear order-by.
         * 
         * @return this. (NotNull)
         */
        MbOrderByBean ClearOrderBy();

	    /**
	     * Ignore order-by.
	     * 
	     * @return this. (NotNull)
	     */
        MbOrderByBean IgnoreOrderBy();

	    /**
	     * Make order-by effective.
	     * 
	     * @return this. (NotNull)
	     */
        MbOrderByBean MakeOrderByEffective();

	    /**
	     * Get order-by clause.
	     * 
	     * @return Order-by clause. (NotNull)
	     */
	    String OrderByClause { get; }
    }
}

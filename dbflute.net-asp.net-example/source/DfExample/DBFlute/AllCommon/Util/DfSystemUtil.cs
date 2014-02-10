
using System;
using DfExample.DBFlute.AllCommon.JavaLike;

namespace DfExample.DBFlute.AllCommon.Util {

public class DfSystemUtil {

    // ===================================================================================
    //                                                                              System
    //                                                                              ======
    public static String getLineSeparator() {
        // /- - - - - - - - - - - - - - - - - - - - - -
        // Because 'CR + LF' caused many trouble!
		// And Now 'LF' have little trouble. 
		// 
        // return Environment.NewLine;
        // - - - - - - - - - -/
		return "\n";
    }
}

}


using System;
using DfExample.DBFlute.MemberDb.AllCommon.JavaLike;

namespace DfExample.DBFlute.MemberDb.AllCommon.Util {

public class MbDfSystemUtil {

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


using System;
using System.Text;

namespace DfExample.DBFlute.AllCommon.Util {

    public class SimpleSystemUtil {
    
        // ===================================================================================
        //                                                                              System
        //                                                                              ======
        public static String GetLineSeparator() {
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

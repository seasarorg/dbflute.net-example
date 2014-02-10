
using System;
using System.Collections;

namespace DfExample.DBFlute.LibraryDb.AllCommon {

    public interface LdEntityDefinedCommonColumn : LdEntity {

        String RUser { get; set; }

        String RModule { get; set; }

        DateTime? RTimestamp { get; set; }

        String UUser { get; set; }

        String UModule { get; set; }

        DateTime? UTimestamp { get; set; }

        void EnableCommonColumnAutoSetup(); // for after disable because the default is enabled
        void DisableCommonColumnAutoSetup();
        bool CanCommonColumnAutoSetup();
    }
}

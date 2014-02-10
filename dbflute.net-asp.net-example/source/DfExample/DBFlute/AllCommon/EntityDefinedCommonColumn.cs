
using System;
using System.Collections;

namespace DfExample.DBFlute.AllCommon {

    public interface EntityDefinedCommonColumn : Entity {

        DateTime? RegisterDatetime { get; set; }

        String RegisterUser { get; set; }

        String RegisterProcess { get; set; }

        DateTime? UpdateDatetime { get; set; }

        String UpdateUser { get; set; }

        String UpdateProcess { get; set; }

        void EnableCommonColumnAutoSetup(); // for after disable because the default is enabled
        void DisableCommonColumnAutoSetup();
        bool CanCommonColumnAutoSetup();
    }
}

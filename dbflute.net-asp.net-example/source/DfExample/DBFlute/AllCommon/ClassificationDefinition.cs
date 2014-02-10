
using System;
using System.Collections.Generic;

namespace DfExample.DBFlute.AllCommon {

    /// <summary>
    /// The definition class that has classification.
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    [Obsolete]
    public static class ClassificationDefinition {

        // ===============================================================================
        //                                                  Classification Code Definition
        //                                                  ==============================
        /// <summary>
        /// The classification code of True.
        /// 有効を示す
        /// </summary>
        public const String CODE_Flg_True = "1";

        /// <summary>
        /// The classification code of False.
        /// 無効を示す
        /// </summary>
        public const String CODE_Flg_False = "0";

        /// <summary>
        /// The classification code of Provisional.
        /// 仮会員を示す
        /// </summary>
        public const String CODE_MemberStatus_Provisional = "PRV";

        /// <summary>
        /// The classification code of Formalized.
        /// 正式会員を示す
        /// </summary>
        public const String CODE_MemberStatus_Formalized = "FML";

        /// <summary>
        /// The classification code of Withdrawal.
        /// 退会会員を示す
        /// </summary>
        public const String CODE_MemberStatus_Withdrawal = "WDL";

        // ===============================================================================
        //                                           Classification CodeNameMap Definition
        //                                           =====================================
        /** The classification code-name map of Flg. */
        public static readonly IDictionary<String, String> CODE_NAME_MAP_Flg;
        public static String FindFlgName(String code) { return FindByCode(code, CODE_NAME_MAP_Flg); }

        /** The classification code-name map of MemberStatus. */
        public static readonly IDictionary<String, String> CODE_NAME_MAP_MemberStatus;
        public static String FindMemberStatusName(String code) { return FindByCode(code, CODE_NAME_MAP_MemberStatus); }

        // ===============================================================================
        //                                                              Static Initializer
        //                                                              ==================
        static ClassificationDefinition() {
            {
                IDictionary<String, String> map = new Dictionary<String, String>();
                map.Add(CODE_Flg_True, "True");
                map.Add(CODE_Flg_False, "False");
                CODE_NAME_MAP_Flg = map; //java.util.Collections.unmodifiableMap(map);
            }
            {
                IDictionary<String, String> map = new Dictionary<String, String>();
                map.Add(CODE_MemberStatus_Provisional, "Provisional");
                map.Add(CODE_MemberStatus_Formalized, "Formalized");
                map.Add(CODE_MemberStatus_Withdrawal, "Withdrawal");
                CODE_NAME_MAP_MemberStatus = map; //java.util.Collections.unmodifiableMap(map);
            }
        }

        private static String FindByCode(String code, IDictionary<String, String> map) {
            foreach (String key in map.Keys) {
                if (code.ToLower().Equals(key.ToLower())) {
                    return map[key];
                }
            }
            return null;
        }
    }
}

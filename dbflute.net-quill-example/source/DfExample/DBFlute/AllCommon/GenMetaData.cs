
using System;
using System.Collections;

namespace DfExample.DBFlute.AllCommon {

    /// <summary>
    /// The singleton class that has generate meta data.
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    public class GenMetaData {

        // ===============================================================================
        //                                                                       Singleton
        //                                                                       =========
        /// <summary>Singleton instance.</summary>
        private static readonly GenMetaData _instance = new GenMetaData();

        /// <summary>
        /// Constructor.
        /// </summary>
        private GenMetaData() {
        }

        /// <summary>
        /// Get instance.
        /// </summary>
        /// <returns>Singleton instance.</returns>
        public static GenMetaData GetInstance() {
            return _instance;
        }

        // ===============================================================================
        //                                                                           Basic
        //                                                                           =====
        /// <sumarry>
        /// Get the property-value of targetLanguage.
        /// </sumarry>
        /// <returns>The property-value.</returns>
        public String GetTargetLanguage() {
            return "csharp";
        }

        /// <sumarry>
        /// Get the property-value of templateFileExtension.
        /// </sumarry>
        /// <returns>The property-value.</returns>
        public String GetTemplateFileExtension() {
            return "vmnet";
        }

        /// <sumarry>
        /// Get the property-value of classFileExtension.
        /// </sumarry>
        /// <returns>The property-value.</returns>
        public String GetClassFileExtension() {
            return "cs";
        }

        /// <sumarry>
        /// Get the property-value of templateFileEncoding.
        /// </sumarry>
        /// <returns>The property-value.</returns>
        public String GetTemplateEncoding() {
            return "UTF-8";
        }

        /// </sumarry>
        /// Get the property-value of classAuthor.
        /// </sumarry>
        /// <returns>The property-value.</returns>
        public String GetClassAuthor() {
            return "DBFlute(AutoGenerator)";
        }

        // ===============================================================================
        //                                                                          Prefix
        //                                                                          ======
        /// <sumarry>
        /// Get the property-value of projectPrefix.
        /// </sumarry>
        /// <returns>The property-value.</returns>
        public String GetProjectPrefix() {
            return "";
        }

        /// <sumarry>
        /// Get the property-value of basePrefix.
        /// </sumarry>
        /// <returns>The property-value.</returns>
        public String GetBasePrefix() {
            return "Bs";
        }
    }
}

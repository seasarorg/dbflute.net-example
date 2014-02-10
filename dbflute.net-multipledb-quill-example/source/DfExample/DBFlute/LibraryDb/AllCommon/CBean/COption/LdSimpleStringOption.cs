
using System;

// using DfExample.DBFlute.LibraryDb.AllCommon.CBean.COption.Parts;
// using DfExample.DBFlute.LibraryDb.AllCommon.CBean.COption.Parts.Local;
using DfExample.DBFlute.LibraryDb.AllCommon.Util;

namespace DfExample.DBFlute.LibraryDb.AllCommon.CBean.COption {

public class LdSimpleStringOption : LdConditionOption {

    // protected LdSplitOptionParts _splitOptionParts;
    // protected LdToUpperLowerCaseOptionParts _toUpperLowerCaseOptionParts;
    // protected LdToSingleByteOptionParts _toSingleByteCaseOptionParts;
    // protected LdJapaneseOptionPartsAgent _japaneseOptionPartsAgent;

    // =====================================================================================
    //                                                                           Rear Option
    //                                                                           ===========
    public virtual String getRearOption() {
        return "";
    }

    // =====================================================================================
    //                                                                                 Split
    //                                                                                 =====
    public bool isSplit() {
        return false;
    }

    // =====================================================================================
    //                                                                   To Upper/Lower Case
    //                                                                   ===================

    // =====================================================================================
    //                                                                        To Single Byte
    //                                                                        ==============

    // =====================================================================================
    //                                                                        To Double Byte
    //                                                                        ==============

    // =====================================================================================
    //                                                                              Japanese
    //                                                                              ========

    // =====================================================================================
    //                                                                            Real Value
    //                                                                            ==========
    public virtual String generateRealValue(String value) {
        // value = getToUpperLowerCaseOptionParts().generateRealValue(value);
        // value = getToSingleByteOptionParts().generateRealValue(value);
        // value = getJapaneseOptionPartsAgent().generateRealValue(value);
        return value;
    }
	
    // =====================================================================================
    //                                                                        General Helper
    //                                                                        ==============
    protected String replaceString(String text, String fromText, String toText) {
	    return LdSimpleStringUtil.Replace(text, fromText, toText);
    }
}

}

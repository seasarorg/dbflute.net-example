
using System;

// using DfExample.DBFlute.MemberDb.AllCommon.CBean.COption.Parts;
// using DfExample.DBFlute.MemberDb.AllCommon.CBean.COption.Parts.Local;
using DfExample.DBFlute.MemberDb.AllCommon.Util;

namespace DfExample.DBFlute.MemberDb.AllCommon.CBean.COption {

public class MbSimpleStringOption : MbConditionOption {

    // protected MbSplitOptionParts _splitOptionParts;
    // protected MbToUpperLowerCaseOptionParts _toUpperLowerCaseOptionParts;
    // protected MbToSingleByteOptionParts _toSingleByteCaseOptionParts;
    // protected MbJapaneseOptionPartsAgent _japaneseOptionPartsAgent;

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
	    return MbSimpleStringUtil.Replace(text, fromText, toText);
    }
}

}


using System;

using DfExample.DBFlute.LibraryDb.AllCommon.JavaLike;
// using DfExample.DBFlute.LibraryDb.AllCommon.CBean.COption.Parts.Local;

namespace DfExample.DBFlute.LibraryDb.AllCommon.CBean.COption {

public class LdLikeSearchOption : LdSimpleStringOption {

    public static readonly String LIKE_PREFIX = "prefix";
    public static readonly String LIKE_SUFFIX = "suffix";
    public static readonly String LIKE_CONTAIN = "contain";

    protected String _like;
    protected String _escape;

    // ===================================================================================
    //                                                                         Rear Option
    //                                                                         ===========
    public override String getRearOption() {
        if (_escape == null || _escape.Trim().Length == 0) {
            return "";
        }
        return " escape '" + _escape + "'";
    }

    // ===================================================================================
    //                                                                                Like
    //                                                                                ====
    public LdLikeSearchOption LikePrefix() {
        _like = LIKE_PREFIX;
        DoLikeAutoEscape();
        return this;
    }

    public LdLikeSearchOption LikeSuffix() {
        _like = LIKE_SUFFIX;
        DoLikeAutoEscape();
        return this;
    }

    public LdLikeSearchOption LikeContain() {
        _like = LIKE_CONTAIN;
        DoLikeAutoEscape();
        return this;
    }
    
    protected virtual void DoLikeAutoEscape() {
        Escape();
    }

    // ===================================================================================
    //                                                                              Escape
    //                                                                              ======
    public LdLikeSearchOption Escape() {
        return EscapeByPipeLine();
    }

    public LdLikeSearchOption EscapeByPipeLine() {
        _escape = "|";
        return this;
    }

    public LdLikeSearchOption EscapeByAtMark() {
        _escape = "@";
        return this;
    }

    public LdLikeSearchOption EscapeBySlash() {
        _escape = "/";
        return this;
    }

    public LdLikeSearchOption EscapeByBackSlash() {
        _escape = "\\";
        return this;
    }

    public LdLikeSearchOption NotEscape() {
        _escape = null;
        return this;
    }

    // ===================================================================================
    //                                                                               Split
    //                                                                               =====

    // ===================================================================================
    //                                                                 To Upper/Lower Case
    //                                                                 ===================

    // ===================================================================================
    //                                                                      To Single Byte
    //                                                                      ==============

    // ===================================================================================
    //                                                                      To Double Byte
    //                                                                      ==============

    // ===================================================================================
    //                                                                            Japanese
    //                                                                            ========

    // ===================================================================================
    //                                                                          Real Value
    //                                                                          ==========
    public override String generateRealValue(String value) {
        value = base.generateRealValue(value);

        // Escape
        if (_escape != null && _escape.Trim().Length != 0) {
            String tmp = replaceString(value, _escape, _escape + _escape);
            tmp = filterEscape(tmp, "%");
            tmp = filterEscape(tmp, "_");
            value = tmp;
        }
        String wildCard = "%";
        if (_like == null || _like.Trim().Length == 0) {
            return value;
        } else if (_like.Equals(LIKE_PREFIX)) {
            return value + wildCard;
        } else if (_like.Equals(LIKE_SUFFIX)) {
            return wildCard + value;
        } else if (_like.Equals(LIKE_CONTAIN)) {
            return wildCard + value + wildCard;
        } else {
            String msg = "The like was wrong string: " + _like;
            throw new IllegalStateException(msg);
        }
    }

    protected String filterEscape(String target, String wildcard) {
        return replaceString(target, wildcard, _escape + wildcard);
    }

    // ===================================================================================
    //                                                                            DeepCopy
    //                                                                            ========

}

}

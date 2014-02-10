
using System;

using DfExample.DBFlute.MemberDb.AllCommon.CBean.CKey;
using DfExample.DBFlute.MemberDb.AllCommon.JavaLike;

namespace DfExample.DBFlute.MemberDb.AllCommon.CBean.COption {

public class MbFromToOption : MbSimpleStringOption {

    // ===================================================================================
    //                                                                           Attribute
    //                                                                           =========
    protected bool _fromDateGreaterThan;
    protected bool _toDateLessThan;
    protected bool _compareAsDate;
    protected bool _toDateMaxValue; // CSharp Only

    // ===================================================================================
    //                                                                         Rear Option
    //                                                                         ===========
    public override String getRearOption() {
        String msg = "Thie option does not use getRearOption()!";
        throw new UnsupportedOperationException(msg);
    }

    // ===================================================================================
    //                                                                                Main
    //                                                                                ====
    public MbFromToOption GreaterThan() {
        _fromDateGreaterThan = true; return this;
    }

    public MbFromToOption LessThan() {
        _toDateLessThan = true; return this;
    }

    public MbFromToOption CompareAsDate() {
        _compareAsDate = true; return this;
    }

    // ===================================================================================
    //                                                                       Internal Main
    //                                                                       =============
    public DateTime? filterFromDate(DateTime? fromDate) {
        if (fromDate == null) {
            return null;
        }
        if (_compareAsDate) {
            DateTime cloneDate = new DateTime(fromDate.Value.Year, fromDate.Value.Month, fromDate.Value.Day);
            return cloneDate;
        }
        return fromDate;
    }

    public DateTime? filterToDate(DateTime? toDate) {
        if (toDate == null) {
            return null;
        }
        if (_compareAsDate) {
            DateTime cloneDate = new DateTime(toDate.Value.Year, toDate.Value.Month, toDate.Value.Day);
            if (cloneDate.Date.Equals(DateTime.MaxValue.Date)) { // CSharp Only
                _toDateMaxValue = true;
                return DateTime.MaxValue;
            }
            return cloneDate.AddDays(1);
        }
        return toDate;
    }

    public MbConditionKey getFromDateConditionKey() {
        if (_compareAsDate) {
            return MbConditionKey.CK_GREATER_EQUAL;
        }
        if (_fromDateGreaterThan) {
            return MbConditionKey.CK_GREATER_THAN;// Default!
        } else {
            return MbConditionKey.CK_GREATER_EQUAL;// Default!
        }
    }

    public MbConditionKey getToDateConditionKey() {
        if (_compareAsDate) {
            return _toDateMaxValue ? MbConditionKey.CK_LESS_EQUAL : MbConditionKey.CK_LESS_THAN;
        }
        if (_toDateLessThan) {
            return MbConditionKey.CK_LESS_THAN;// Default!
        } else {
            return MbConditionKey.CK_LESS_EQUAL;// Default!
        }
    }
}

}

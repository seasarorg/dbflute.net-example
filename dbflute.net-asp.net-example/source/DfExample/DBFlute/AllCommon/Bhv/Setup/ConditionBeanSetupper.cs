
using System;
using System.Collections.Generic;
using DfExample.DBFlute.AllCommon.CBean;

namespace DfExample.DBFlute.AllCommon.Bhv.Setup {

    public delegate void ConditionBeanSetupper<CONDITION_BEAN>(CONDITION_BEAN cb) where CONDITION_BEAN : ConditionBean;

//    public interface ConditionBeanSetupper<CONDITION_BEAN> where CONDITION_BEAN : ConditionBean {
//        void Setup(CONDITION_BEAN cb);
//    }
}


using System;
using System.Collections.Generic;
using DfExample.DBFlute.MemberDb.AllCommon.CBean;

namespace DfExample.DBFlute.MemberDb.AllCommon.Bhv.Setup {

    public delegate void MbConditionBeanSetupper<CONDITION_BEAN>(CONDITION_BEAN cb) where CONDITION_BEAN : MbConditionBean;

//    public interface MbConditionBeanSetupper<CONDITION_BEAN> where CONDITION_BEAN : MbConditionBean {
//        void Setup(CONDITION_BEAN cb);
//    }
}

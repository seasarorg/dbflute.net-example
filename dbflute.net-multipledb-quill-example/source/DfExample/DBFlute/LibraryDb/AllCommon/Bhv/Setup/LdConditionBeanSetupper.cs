
using System;
using System.Collections.Generic;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean;

namespace DfExample.DBFlute.LibraryDb.AllCommon.Bhv.Setup {

    public delegate void LdConditionBeanSetupper<CONDITION_BEAN>(CONDITION_BEAN cb) where CONDITION_BEAN : LdConditionBean;

//    public interface LdConditionBeanSetupper<CONDITION_BEAN> where CONDITION_BEAN : LdConditionBean {
//        void Setup(CONDITION_BEAN cb);
//    }
}

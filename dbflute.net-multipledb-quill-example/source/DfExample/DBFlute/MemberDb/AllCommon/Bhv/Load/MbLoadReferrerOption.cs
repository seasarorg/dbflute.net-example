
using System;
using System.Collections.Generic;

using DfExample.DBFlute.MemberDb.AllCommon;
using DfExample.DBFlute.MemberDb.AllCommon.CBean;
using DfExample.DBFlute.MemberDb.AllCommon.Bhv.Setup;

namespace DfExample.DBFlute.MemberDb.AllCommon.Bhv.Load {

    public class MbLoadReferrerOption<REFERRER_CB, REFERRER_ENTITY> where REFERRER_CB : MbConditionBean where REFERRER_ENTITY : MbEntity {

        // ===================================================================================
        //                                                                           Attribute
        //                                                                           =========
        protected MbConditionBeanSetupper<REFERRER_CB> _conditionBeanSetupper;
        protected MbEntityListSetupper<REFERRER_ENTITY> _entityListSetupper;
        protected REFERRER_CB _referrerConditionBean;

        // ===================================================================================
        //                                                                         Constructor
        //                                                                         ===========
        public MbLoadReferrerOption() {
        }

        public MbLoadReferrerOption<REFERRER_CB, REFERRER_ENTITY> xinit(
                MbConditionBeanSetupper<REFERRER_CB> conditionBeanSetupper) { // internal
            this.ConditionBeanSetupper = conditionBeanSetupper;
            return this;
        }

        // ===================================================================================
        //                                                                         Easy-to-Use
        //                                                                         ===========
        public void delegateConditionBeanSettingUp(REFERRER_CB cb) { // internal
            if (_conditionBeanSetupper != null) {
                _conditionBeanSetupper.Invoke(cb);
            }
        }

        public void delegateEntitySettingUp(IList<REFERRER_ENTITY> entityList) { // internal
            if (_entityListSetupper != null) {
                _entityListSetupper.Invoke(entityList);
            }
        }

        // ===================================================================================
        //                                                                            Accessor
        //                                                                            ========
        public MbConditionBeanSetupper<REFERRER_CB> ConditionBeanSetupper { get {
            return _conditionBeanSetupper;
        } set {
            this._conditionBeanSetupper = value;
        }}

        public MbEntityListSetupper<REFERRER_ENTITY> EntityListSetupper { get {
            return _entityListSetupper;
        } set {
            this._entityListSetupper = value;
        }}

        public REFERRER_CB ReferrerConditionBean { get {
            return _referrerConditionBean;
        } set {
            this._referrerConditionBean = value;
        }}
    }
}

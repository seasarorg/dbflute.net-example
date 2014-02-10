
using System;
using System.Collections.Generic;

using DfExample.DBFlute.LibraryDb.AllCommon;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean;
using DfExample.DBFlute.LibraryDb.AllCommon.Bhv.Setup;

namespace DfExample.DBFlute.LibraryDb.AllCommon.Bhv.Load {

    public class LdLoadReferrerOption<REFERRER_CB, REFERRER_ENTITY> where REFERRER_CB : LdConditionBean where REFERRER_ENTITY : LdEntity {

        // ===================================================================================
        //                                                                           Attribute
        //                                                                           =========
        protected LdConditionBeanSetupper<REFERRER_CB> _conditionBeanSetupper;
        protected LdEntityListSetupper<REFERRER_ENTITY> _entityListSetupper;
        protected REFERRER_CB _referrerConditionBean;

        // ===================================================================================
        //                                                                         Constructor
        //                                                                         ===========
        public LdLoadReferrerOption() {
        }

        public LdLoadReferrerOption<REFERRER_CB, REFERRER_ENTITY> xinit(
                LdConditionBeanSetupper<REFERRER_CB> conditionBeanSetupper) { // internal
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
        public LdConditionBeanSetupper<REFERRER_CB> ConditionBeanSetupper { get {
            return _conditionBeanSetupper;
        } set {
            this._conditionBeanSetupper = value;
        }}

        public LdEntityListSetupper<REFERRER_ENTITY> EntityListSetupper { get {
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


using System;

using Seasar.Framework.Util;

using DfExample.DBFlute.MemberDb.AllCommon.JavaLike;
using DfExample.DBFlute.MemberDb.AllCommon.CBean.PageNavi.Group;
using DfExample.DBFlute.MemberDb.AllCommon.CBean.PageNavi.Range;

namespace DfExample.DBFlute.MemberDb.AllCommon.CBean {

    /// <summary>
    /// The paging-result-bean of MbPagingResultBean.
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    [System.Serializable]
    public class MbPagingResultBean<ENTITY> : MbListResultBean<ENTITY> {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        #region Attribute
        protected int _pageSize;
        protected int _currentPageNumber;
        protected MbPageGroupBean _pageGroupBean;
        protected MbPageGroupOption _pageGroupOption;
        protected MbPageRangeBean _pageRangeBean;
        protected MbPageRangeOption _pageRangeOption;
        #endregion

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        #region Constructor
        public MbPagingResultBean() {
        }
        #endregion

        // ===============================================================================
        //                                                                  Page Existence
        //                                                                  ==============
        #region Page Existence
        public bool IsExistPrePage() {
            return (_allRecordCount > 0 && _currentPageNumber > 1);
        }

        public bool IsExistNextPage() {
            return (_allRecordCount > 0 && _currentPageNumber < this.AllPageCount);
        }
        #endregion

        // ===============================================================================
        //                                                                Page Group/Range
        //                                                                ================
        protected void InitializeCachedBeans() {
            InitializePageGroup();
            InitializePageRange();
        }

        // -------------------------------------------------
        //                                        Page Group
        //                                        ----------
        protected void InitializePageGroup() {
            _pageGroupBean = null;
        }

        public MbPageGroupOption PageGroupOption {
            set {
                InitializePageGroup();
                _pageGroupOption = value;
            }
        }

        public MbPageGroupBean PageGroup() {
            AssertPageGroupValid();
            if (_pageGroupBean == null) {
                _pageGroupBean = new MbPageGroupBean();
                _pageGroupBean.PageGroupOption = _pageGroupOption;
                _pageGroupBean.CurrentPageNumber = CurrentPageNumber;
                _pageGroupBean.AllPageCount = AllPageCount;
            }
            return _pageGroupBean;
        }
    
        protected void AssertPageGroupValid() {
            if (_pageGroupOption == null) {
                String msg = "The pageGroupOption should not be null. Please call setPageGroupOption().";
                throw new IllegalStateException(msg);
            }
            if (_pageGroupOption.PageGroupSize == 0) {
                String msg = "The pageGroupSize should be greater than 1. But the value is zero.";
                msg = msg + " pageGroupSize=" + _pageGroupOption.PageGroupSize;
                throw new IllegalStateException(msg);
            }
            if (_pageGroupOption.PageGroupSize == 1) {
                String msg = "The pageGroupSize should be greater than 1. But the value is one.";
                msg = msg + " pageGroupSize=" + _pageGroupOption.PageGroupSize;
                throw new IllegalStateException(msg);
            }
        }

        // -------------------------------------------------
        //                                        Page Range
        //                                        ----------
        protected void InitializePageRange() {
            _pageRangeBean = null;
        }

        public MbPageRangeOption PageRangeOption {
            set {
                InitializePageRange();
                _pageRangeOption = value;
            }
        }

        public MbPageRangeBean PageRange() {
            AssertPageRangeValid();
            if (_pageRangeBean == null) {
                _pageRangeBean = new MbPageRangeBean();
                _pageRangeBean.PageRangeOption = _pageRangeOption;
                _pageRangeBean.CurrentPageNumber = CurrentPageNumber;
                _pageRangeBean.AllPageCount = AllPageCount;
            }
            return _pageRangeBean;
        }
    
        protected void AssertPageRangeValid() {
            if (_pageRangeOption == null) {
                String msg = "The pageRangeOption should not be null. Please call setPageRangeOption().";
                throw new IllegalStateException(msg);
            }
            int pageRangeSize = _pageRangeOption.PageRangeSize;
            if (pageRangeSize == 0) {
                String msg = "The pageRangeSize should be greater than 1. But the value is zero.";
                throw new IllegalStateException(msg);
            }
        }

        // ===============================================================================
        //                                                             Calculate(Internal)
        //                                                             ===================
        protected int CalculateAllPageCount(int allRecordCount, int pageSize) {
            if (allRecordCount == 0) {
                return 1;
            }
            int pageCountBase = (allRecordCount / pageSize);
            if (allRecordCount % pageSize > 0) {
                pageCountBase++;
            }
            return pageCountBase;
        }

        protected int CalculateCurrentStartRecordNumber(int currentPageNumber, int pageSize) {
            return ((currentPageNumber - 1) * pageSize) + 1;
        }

        protected int CalculateCurrentEndRecordNumber(int currentPageNumber, int pageSize) {
            return CalculateCurrentStartRecordNumber(currentPageNumber, pageSize) + _selectedList.Count - 1;
        }

        // ===============================================================================
        //                                                                  Basic Override
        //                                                                  ==============
        public override String ToString() {
            StringBuilder sb = new StringBuilder();
            sb.append("{").append(this.CurrentPageNumber).append("/").append(this.AllPageCount);
            sb.append(" of ").append(this.AllRecordCount);
            sb.append(" ").append(IsExistPrePage() ? "true" : "false").append("/").append(IsExistNextPage() ? "true" : "false");
            if (_pageGroupOption != null) {
                sb.append(" group:{").append(_pageGroupOption.PageGroupSize).append(",").append(ToStringUtil.ToString(PageGroup().CreatePageNumberList())).append("}");
            }
            if (_pageRangeOption != null) {
                sb.append(" range:{").append(_pageRangeOption.PageRangeSize).append(",").append(_pageRangeOption.IsFillLimit);
                sb.append(",").append(ToStringUtil.ToString(PageRange().CreatePageNumberList())).append("}");
            }
            sb.append(" list=").append((this.SelectedList != null ? ""+this.SelectedList.Count : null));
            sb.append(" page=").append(this.PageSize);
            sb.append("}");
            sb.append(":selectedList=").append(this.SelectedList != null ? ToStringUtil.ToString(this.SelectedList) : null);
            return sb.toString();
        }

        // ===============================================================================
        //                                                                        Property
        //                                                                        ========
        #region Property
        public override int AllRecordCount {
            get { return _allRecordCount; }
            set { InitializeCachedBeans(); _allRecordCount = value; }
        }

        public virtual int PageSize {
            get { return _pageSize; }
            set { InitializeCachedBeans(); _pageSize = value; }
        }

        public virtual int CurrentPageNumber {
            get { return _currentPageNumber; }
            set { InitializeCachedBeans(); _currentPageNumber = value; }
        }

        // -------------------------------------------------
        //                               Calculated Property
        //                               -------------------
        public virtual int AllPageCount {
            get { return CalculateAllPageCount(_allRecordCount, _pageSize); }
        }

        public virtual int PrePageNumber { get {
            if (!IsExistPrePage()) {
                String msg = "The previous page should exist when you use prePageNumber:";
                msg = msg + " currentPageNumber=" + _currentPageNumber;
                throw new IllegalStateException(msg);
            }
            return _currentPageNumber - 1;
        }}

        public virtual int NextPageNumber { get {
            if (!IsExistNextPage()) {
                String msg = "The next page should exist when you use prePageNumber:";
                msg = msg + " currentPageNumber=" + _currentPageNumber;
                throw new IllegalStateException(msg);
            }
            return _currentPageNumber + 1;
        }}

        public virtual int CurrentStartRecordNumber {
            get { return CalculateCurrentStartRecordNumber(_currentPageNumber, _pageSize); }
        }

        public virtual int CurrentEndRecordNumber {
            get { return CalculateCurrentEndRecordNumber(_currentPageNumber, _pageSize); }
        }
        #endregion
    }
}

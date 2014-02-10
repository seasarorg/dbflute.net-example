using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using DfExampleBiz.Common;
using DfExampleBiz.Facade.Member;
using DfExampleBiz.Facade.Member.Condition;
using Seasar.Quill;

namespace DfExampleWeb.View.Member
{
    public partial class MemberList : System.Web.UI.Page
    {
        /// <summary>
        /// メンバーFacade
        /// </summary>
        protected MemberFacade facade;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MemberList()
        {
            //インジェクト
            QuillInjector.GetInstance().Inject(this);
        }

        /// <summary>
        /// ページロード
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //検索部分のドロップダウン部分設定
                IList<KeyValuePair<string, string>> list = facade.GetMemberStatusList();
                ddlMemberStatus.Items.Add(new ListItem(""));
                foreach (var pair in list)
                {
                    ddlMemberStatus.Items.Add(new ListItem(pair.Value, pair.Key));
                }
                ddlMemberStatus.DataBind();

                #region パラメーターから検索値やページ番号設定
                var s = Request.QueryString;
                string pageNumber = s.Get("pn");
                string memberName = s.Get("mn");
                string purchaseItem = s.Get("pi");
                string memberStatusCd = s.Get("msc");
                string hasUnPaid = s.Get("hup");
                string from = s.Get("from");
                string to = s.Get("to");
                if (string.IsNullOrEmpty(pageNumber))
                {
                    //指定無しの場合1ページ目を検索
                    pageNumber = "1";
                }
                if (!string.IsNullOrEmpty(memberName))
                {
                    txtMemberName.Text = memberName;
                }
                if (!string.IsNullOrEmpty(purchaseItem))
                {
                    txtPurchaseItem.Text = purchaseItem;
                }
                if (!string.IsNullOrEmpty(memberStatusCd))
                {
                    ddlMemberStatus.SelectedValue = memberStatusCd;
                }
                if (!string.IsNullOrEmpty(hasUnPaid))
                {
                    //URLは変更される可能性があるため本当はTryParse
                    chkUnPaid.Checked = bool.Parse(hasUnPaid);
                }
                if (!string.IsNullOrEmpty(from))
                {
                    txtFormalizedDatetimeFrom.Text = from;
                }
                if (!string.IsNullOrEmpty(to))
                {
                    txtFormalizedDatetimeTo.Text = to;
                }
                #endregion

                DoSearch(int.Parse(pageNumber));
            }
        }

        /// <summary>
        /// 検索実行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            DoSearch(1);
        }

        /// <summary>
        /// ページ番号を指定して検索実行
        /// </summary>
        /// <param name="pageNumber">ページ番号</param>
        private void DoSearch(int pageNumber)
        {
            MemberCondition cb = new MemberCondition();
            cb.PageNumber = pageNumber;
            cb.MemberName = txtMemberName.Text;
            cb.PurchaseItemName = txtPurchaseItem.Text;
            cb.MemberStatusCd = ddlMemberStatus.SelectedValue;
            if (!string.IsNullOrEmpty(txtFormalizedDatetimeFrom.Text))
            {
                cb.FormalizedDatetimeFrom = DateTime.Parse(txtFormalizedDatetimeFrom.Text);
            }
            if (!string.IsNullOrEmpty(txtFormalizedDatetimeTo.Text))
            {
                cb.FormalizedDatetimeTo = DateTime.Parse(txtFormalizedDatetimeTo.Text);
            }
            cb.HasUnPaid = chkUnPaid.Checked;
            var list = facade.GetMemberList(cb);
            SetPagingArea(list.AllRecordCount, txtMemberName.Text, txtPurchaseItem.Text, ddlMemberStatus.SelectedValue,
                          chkUnPaid.Checked, txtFormalizedDatetimeFrom.Text, txtFormalizedDatetimeTo.Text);

            //TODO 編集画面や購入履歴画面へのURLを作成し設定する
            rptMember.DataSource = list.MemberList;
            rptMember.DataBind();
        }

        /// <summary>
        /// ページングのリンク生成(検索条件を持ちまわる)
        /// とりあえず。。。
        /// </summary>
        /// <param name="AllPageCount"></param>
        private void SetPagingArea(int AllPageCount, string memberName, string purchaseItem, string memberStatus,
                                   bool hasUnPaid, string from, string to)
        {
            IList<PagingDto> list = new List<PagingDto>();
            for (int i = 0; i < AllPageCount; i++)
            {
                string num = (i + 1).ToString();
                PagingDto dto = new PagingDto();
                dto.PageNum = num;

                string url = string.Format("MemberList.aspx?pn={0}&mn={1}&pi={2}&msc={3}&hup={4}&from={5}&to={6}", num,
                                           memberName, purchaseItem, memberStatus, hasUnPaid, from, to);
                dto.PageUrl = url;
                list.Add(dto);
            }
            rptPaging.DataSource = list;
            rptPaging.DataBind();
        }

        //TODO Validate
    }
}
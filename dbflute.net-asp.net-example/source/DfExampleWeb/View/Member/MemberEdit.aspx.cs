using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using DfExampleBiz.Facade.Member;
using DfExampleBiz.Facade.Member.Dto;
using Seasar.Quill;

namespace DfExampleWeb.View.Member
{
    public partial class MemberEdit : System.Web.UI.Page
    {
        /// <summary>
        /// メンバーFacade
        /// </summary>
        protected MemberFacade facade;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MemberEdit()
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
            if(!IsPostBack)
            {
                //初期遷移時は登録とキャンセルはできない
                btnRegist.Enabled = false;
                btnCancel.Enabled = false;
                //検索部分のドロップダウン部分設定
                IList<KeyValuePair<string, string>> list = facade.GetMemberStatusList();
                foreach (var pair in list)
                {
                    ddlMemberStatus.Items.Add(new ListItem(pair.Value, pair.Key));
                }
                ddlMemberStatus.DataBind();

                var s = Request.QueryString;
                string memberId = s.Get("mi");
                string versionNo = s.Get("vn");
                hdnMemberId.Value = memberId;
                hdnVersionNo.Value = versionNo;
                if(!string.IsNullOrEmpty(memberId))
                {
                    //URLは変更される可能性があるため本当はTryParse
                    MemberDto member = facade.GetMember(long.Parse(memberId));
                    lblMemberIdVal.Text = member.MemberId;
                    txtMemberName.Text = member.MemberName;
                    txtMemberAccount.Text = member.MemberAccount;
                    ddlMemberStatus.SelectedValue = member.MemberStatusCode;
                    txtBirthdate.Text = member.Birthdate;
                    lblFormalizedDatetimeVal.Text = member.FormalizedDatetime;
                    lblUpdateDatetimeVal.Text = member.UpdateDatetime;
                    lblLastLoginDatetimeVal.Text = member.LatestLoginDatetime;
                }
            }
        }

        /// <summary>
        /// 一覧画面へ戻る
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnBack_Click(object sender, EventArgs e)
        {
            //TODO 本当は一覧画面から遷移時の検索条件を戻ったときにも表示するようにしたほうがよい
            Response.Redirect("MemberList.aspx");
        }

        /// <summary>
        /// 登録情報確認。ボタンと入力フィールドの変更をコントロールするだけ。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            //登録とキャンセルを可能にし、確認を不可にする
            btnRegist.Enabled = true;
            btnCancel.Enabled = true;
            btnConfirm.Enabled = false;
            txtBirthdate.Enabled = false;
            txtMemberAccount.Enabled = false;
            txtMemberName.Enabled = false;
            ddlMemberStatus.Enabled = false;
        }

        /// <summary>
        /// 登録キャンセル。ボタンと入力フィールドの変更をコントロールするだけ。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            btnRegist.Enabled = false;
            btnCancel.Enabled = false;
            btnConfirm.Enabled = true;
            txtBirthdate.Enabled = true;
            txtMemberAccount.Enabled = true;
            txtMemberName.Enabled = true;
            ddlMemberStatus.Enabled = true;
        }

        /// <summary>
        /// 会員情報更新処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnRegist_Click(object sender, EventArgs e)
        {
            MemberDto dto = new MemberDto();
            dto.MemberName = txtMemberName.Text;
            dto.MemberAccount = txtMemberAccount.Text;
            dto.Birthdate = string.Format(txtBirthdate.Text,"yyyyMMdd");
            dto.VersionNo = long.Parse(hdnVersionNo.Value);
            dto.MemberId = hdnMemberId.Value;
            facade.Update(dto);
            //TODO 本当は一覧画面から遷移時の検索条件を戻ったときにも表示するようにしたほうがよい
            Response.Redirect("MemberList.aspx");
        }

        //TODO Validate
    }
}


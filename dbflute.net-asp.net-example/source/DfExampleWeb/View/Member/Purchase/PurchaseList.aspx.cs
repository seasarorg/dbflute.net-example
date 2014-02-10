using System;
using System.Web.UI.WebControls;
using DfExampleBiz.Facade.Member.Purchase;
using DfExampleBiz.Facade.Member.Purchase.Dto;
using Seasar.Quill;

namespace DfExampleWeb.View.Member.Purchase
{
    public partial class PurchaseList : System.Web.UI.Page
    {
        public PurchaseList()
        {
            QuillInjector.GetInstance().Inject(this);
        }

        protected PurchaseFacade facade;

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                var s = Request.QueryString;
                string memberId = s.Get("mi");
                long id;
                long.TryParse(memberId, out id);
                PurchaseDtoList list = facade.GetPurchaseList(id);
                lblMemberIdVal.Text = list.MemberId;
                lblMemberNameVal.Text = list.MemberName;
                rptPurchase.DataSource = list.PurchaseList;
                rptPurchase.DataBind();

            }

       }

        protected void btnDelete_Click(object sender, CommandEventArgs e)
        {
            string purchaseId = e.CommandArgument.ToString();
        }
    }
}

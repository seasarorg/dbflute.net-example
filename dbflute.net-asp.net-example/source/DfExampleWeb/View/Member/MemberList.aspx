<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MemberList.aspx.cs" Inherits="DfExampleWeb.View.Member.MemberList" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>会員一覧</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    <table border="1">
        <tr>
            <td>
                <asp:Label ID="lblMemberName" runat="server" Text="会員名(前方一致)"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtMemberName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblPurchaseItem" runat="server" Text="購入商品名"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtPurchaseItem" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblMemberStatus" runat="server" Text="会員ステータス"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlMemberStatus" runat="server"></asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="未払い商品有無"></asp:Label>
            </td>
            <td>
                <label>有</label><asp:CheckBox ID="chkUnPaid" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="正式会員日(yyyy/MM/dd)"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtFormalizedDatetimeFrom" runat="server"></asp:TextBox>～<asp:TextBox ID="txtFormalizedDatetimeTo" runat="server"></asp:TextBox>
            </td>
        </tr>
    </table>
    <asp:Button ID="btnSearch" runat="server" onclick="btnSearch_Click" Text="検索" />
    <hr />
    <asp:Repeater ID="rptPaging" runat="server">
    <HeaderTemplate>
    </HeaderTemplate>
    <ItemTemplate>
        <asp:HyperLink ID="hlPage" runat="server" Text='<%# Eval("PageNum") %>' NavigateUrl='<%# Eval("PageUrl") %>'></asp:HyperLink>
    </ItemTemplate>
    <FooterTemplate>
    </table>
    </FooterTemplate>
    </asp:Repeater>
    <asp:Repeater ID="rptMember" runat="server">
    <HeaderTemplate>
    <table border="1">
    <tr>
        <th><asp:Label ID="lblMemberIdHeader" runat="server" Text="会員ID"></asp:Label></th>
        <th><asp:Label ID="lblMemberNameHeader" runat="server" Text="会員名"></asp:Label></th>
        <th><asp:Label ID="lblMemberStatusHeader" runat="server" Text="会員ステータス"></asp:Label></th>
        <th><asp:Label ID="lblRegisterDateTimeHeader" runat="server" Text="正式会員日時"></asp:Label></th>
        <th><asp:Label ID="lblUpdateDateTimeHeader" runat="server" Text="会員更新日時"></asp:Label></th>
        <th><asp:Label ID="lblEditHeader" runat="server" Text="編集"></asp:Label></th>
        <th><asp:Label ID="lblPurchaseHistHeader" runat="server" Text="購入履歴"></asp:Label></th>
    </tr>
    </HeaderTemplate>
    <ItemTemplate>
    <tr>
        <td>
            <asp:Label Text='<%# Eval("MemberId") %>' ID="lblMemberId" runat="server"></asp:Label>
        </td>
        <td>
            <asp:Label Text='<%# Eval("MemberName") %>' ID="lblMemberName" runat="server"></asp:Label>
        </td>
        <td>
            <asp:Label Text='<%# Eval("MemberStatus") %>' ID="lblMemberStatus" runat="server"></asp:Label>
        </td>
        <td>
            <asp:Label Text='<%# Eval("FormalizedDatetime") %>' ID="lblRegDate" runat="server"></asp:Label>
        </td>
        <td>
            <asp:Label Text='<%# Eval("UpdateDateTime") %>' ID="lblUpdDate" runat="server"></asp:Label>
        </td>
        <td>
            <asp:HyperLink ID="hlEdit" runat="server" Text='編集' NavigateUrl='<%# Eval("NavigateEdit") %>'></asp:HyperLink>
        </td>
        <td>
            <asp:HyperLink ID="hlPurchaseHist" runat="server" Text='購入履歴' NavigateUrl='<%# Eval("NavigatePurchase") %>'></asp:HyperLink>
        </td>
    </tr>
    </ItemTemplate>
    <FooterTemplate>
    </table>
    </FooterTemplate>
    </asp:Repeater>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PurchaseList.aspx.cs" Inherits="DfExampleWeb.View.Member.Purchase.PurchaseList" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    <table border="1">
    <tr>
        <td>
            <asp:Label ID="lblMemberId" runat="server" Text="会員ID"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lblMemberIdVal" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblMemberName" runat="server" Text="会員名"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lblMemberNameVal" runat="server"></asp:Label>
        </td>
    </tr>
    </table>
    <hr />
    <asp:Repeater ID="rptPurchase" runat="server" >
    <HeaderTemplate>
    <table border="1">
    <tr>
        <th><asp:Label ID="lblPurchaseDatetime" runat="server" Text="購入日時"></asp:Label></th>
        <th><asp:Label ID="lblProductName" runat="server" Text="商品名"></asp:Label></th>
        <th><asp:Label ID="lblProductPrice" runat="server" Text="商品価格"></asp:Label></th>
        <th><asp:Label ID="lblPurchaseCount" runat="server" Text="商品数量"></asp:Label></th>
        <th><asp:Label ID="lblPaymemtComplete" runat="server" Text="支払い状態"></asp:Label></th>
        <th><asp:Label ID="lblDelete"  runat="server" ></asp:Label></th>
    </tr>
    </HeaderTemplate>
    <ItemTemplate>
    <tr>
        <td>
            <asp:Label Text='<%# Eval("PurchaseDatetime") %>' ID="lblPurchaseDatetime" runat="server"></asp:Label>
        </td>
        <td>
            <asp:Label Text='<%# Eval("ProductName") %>' ID="lblProductName" runat="server"></asp:Label>
        </td>
        <td>
            <asp:Label Text='<%# Eval("ProductPrice") %>' ID="lblProductPrice" runat="server"></asp:Label>
        </td>
        <td>
            <asp:Label Text='<%# Eval("PurchaseCount") %>' ID="lblPurchaseCount" runat="server"></asp:Label>
        </td>
        <td>
           <asp:Label Text='<%# Eval("PaymentComplete") %>' ID="lblPaymemntComplete" runat="server"></asp:Label>
        </td>
        <td>
            <asp:Button ID="btnDelete" CommandArgument='<%# Eval("PurchaseId") %>' runat="server" Text='削除'></asp:Button>
        </td>
    </tr>
    </ItemTemplate>
    <FooterTemplate>
    </table>
    </FooterTemplate>
    </asp:Repeater>
    </div>
    </form>
</body>
</html>

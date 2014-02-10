<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MemberEdit.aspx.cs" Inherits="DfExampleWeb.View.Member.MemberEdit" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>会員編集</title>
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
            <asp:Label ID="lblMemberIdVal" runat="server" Text=""></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblMemberName" runat="server" Text="会員名称(※)"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtMemberName" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblMemberAccount" runat="server" Text="会員アカウント(※)"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtMemberAccount" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblMemberStatus" runat="server" Text="会員ステータス(※)"></asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlMemberStatus" runat="server"></asp:DropDownList>
        </td>
    </tr>    
    <tr>
        <td>
            <asp:Label ID="lblBirthdate" runat="server" Text="生年月日"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtBirthdate" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblFormalizedDatetime" runat="server" Text="正式会員日"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lblFormalizedDatetimeVal" runat="server" Text=""></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblLastLoginDatetime" runat="server" Text="最終ログイン日時"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lblLastLoginDatetimeVal" runat="server" Text=""></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblUpdateDatetime" runat="server" Text="更新日時"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lblUpdateDatetimeVal" runat="server" Text=""></asp:Label>
        </td>
    </tr>
    </table>
    </div>
    <asp:Button ID="btnBack" runat="server" Text="戻る" onclick="btnBack_Click" />
    <asp:Button ID="btnConfirm" runat="server" Text="確認" 
        onclick="btnConfirm_Click"/>
    <asp:Button ID="btnCancel" runat="server" Text="キャンセル" 
        onclick="btnCancel_Click"/>
    <asp:Button ID="btnRegist" runat="server" Text="登録" onclick="btnRegist_Click"/>
    <asp:HiddenField ID="hdnMemberId" runat="server" />
    <asp:HiddenField ID="hdnVersionNo" runat="server" />
    </form>
</body>
</html>

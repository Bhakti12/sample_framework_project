<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style1
    {
        width: 135px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:100%;">
    <tr>
        <td class="style1">
            <asp:Label ID="Label1" runat="server" Text="Enter Username"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style1">
            <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style1">
            <asp:Button ID="Button1" runat="server" Text="LogIn" Width="134px" 
                onclick="Button1_Click" />
        </td>
        <td>
            <asp:Label ID="lblmsg2" runat="server" Text="Label"></asp:Label>
        </td>
        <td>
            &nbsp;</td>
    </tr>
</table>
</asp:Content>


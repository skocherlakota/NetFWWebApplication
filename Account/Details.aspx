<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="NetFWWebApplication.Account.Details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lblUserName2" runat="server" Text="Label"></asp:Label>

    <table class="table table-striped">
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Title"></asp:Label></td>
            <td>
                <asp:TextBox ID="txtTitle" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="Button1" runat="server" Text="Save" />
            </td>
        </tr>
    </table>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="AddNewBook.aspx.cs" Inherits="NetFWWebApplication.Account.AddNewBook" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <table class="table table-bordered">
        <tr>
            <td>
                <asp:Label ID="Label5" runat="server" Text="BookID"></asp:Label></td>
            <td>
                <asp:TextBox ID="txtBookID" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Tile"></asp:Label></td>
            <td>
                <asp:TextBox ID="txtTitle" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Author"></asp:Label></td>
            <td>
                <asp:TextBox ID="txtAuthor" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Pub Date"></asp:Label></td>
            <td>
                <asp:TextBox ID="txtPubDate" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Price"></asp:Label></td>
            <td>
                <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
                <asp:Button ID="btnDelete" runat="server" Text="Delete" Visible="false" OnClick="btnDelete_Click" />
                <asp:Button ID="btnCancel" runat="server" Text="Reset" OnClick="btnCancel_Click" /></td>
        </tr>
    </table>
    <asp:Label ID="lblMessage" runat="server" Text="Label"></asp:Label>
    <br />
    <hr />
    <asp:GridView ID="gvBooks" runat="server" AutoGenerateColumns="true" CssClass="table table-condensed" OnRowCommand="gvBooks_RowCommand">
       <Columns>
        <asp:TemplateField HeaderText="Title">
            <itemtemplate>
                <asp:LinkButton ID="lnktitle" runat="server" CommandArgument='<%#Eval("bookid")%>' Text='<%#Eval("title") %>' CommandName="selecttitle"></asp:LinkButton>
            </itemtemplate>
        </asp:TemplateField>
       </Columns>
    </asp:GridView>

</asp:Content>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Account.aspx.cs" Inherits="NetFWWebApplication.Account.Account" MasterPageFile="~/User.Master" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br /><br />
        <div>
            <h1>Welcome <asp:Label ID="lblUserName" runat="server" Text="Label"></asp:Label></h1>
        </div>
   
    
    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    
    <input id="Button2" type="button" value="button" />



</asp:Content>
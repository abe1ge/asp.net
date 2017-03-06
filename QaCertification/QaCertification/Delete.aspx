<%@ Page Title="" Language="C#" MasterPageFile="~/page.Master" AutoEventWireup="true" CodeBehind="Delete.aspx.cs" Inherits="QaCertification.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form id="form1" runat="server">
        Name : <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
        <br />
        Address :  <asp:TextBox ID="TextBoxAddress" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="ButtonDelete" runat="server" Text="Delete" />
    </form>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/page.Master" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="QaCertification.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form id="form1" runat="server">
        Name : <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
        <br />
        Address :  <asp:TextBox ID="TextBoxAddress" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="ButtonUpdate" runat="server" Text="Update" />
    </form>
</asp:Content>

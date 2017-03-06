<%@ Page Title="" Language="C#" MasterPageFile="~/page.Master" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="QaCertification.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form id="form1" runat="server">
        <br />
    Username :
        <asp:TextBox ID="TextBoxUsername" runat="server"></asp:TextBox>
    <br />
    Password :

        <asp:TextBox ID="TextBoxPassword" runat="server"></asp:TextBox>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="ButtonLogIn" runat="server" OnClick="ButtonLogIn_Click" Text="LogIn" Width="90px" />
        <asp:Label ID="LabelLogInError" runat="server"></asp:Label>
    </form>

</asp:Content>  

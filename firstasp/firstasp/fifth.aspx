<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="fifth.aspx.cs" Inherits="firstasp.fifth" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Panel ID="Panel1" runat="server" Height="377px">
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox> <br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
            <asp:Button ID="Button1" runat="server" Text="calculate" OnClick="Button1_Click" /><br />
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </asp:Panel>
    </form>
</body>
</html>

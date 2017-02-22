<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="firstwebf.aspx.cs" Inherits="firstasp.firstwebf" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
         abel ruls
        <br />
        My first asp program
        <br />
        <%
            Response.Write("hello my friend ");
            Response.Write(Request["Name"]);

           
            %>
        <br />
        <img src="https://i.ytimg.com/vi/tYBk4kLHPkk/maxresdefault.jpg" alt="pic" />
    </div>
    </form>
</body>
</html>

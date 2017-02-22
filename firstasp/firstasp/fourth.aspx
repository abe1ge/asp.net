<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="fourth.aspx.cs" Inherits="firstasp.fourth" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" action="fourth.aspx">
        <div>
            <center>
            <b>Table :</b>&nbsp;
            <input type="number" name="T" style="margin-bottom: 0px" /><br />
            <b>Range :</b>
            <input type="number" name="R" />
            <br />
            <input type="submit" />
            <br /></center>
        </div>
        <div>
            <%
                int table = 0;
                int range = 0;
                try
                {
                    table = Int32.Parse(Request["T"]);
                    range = Int32.Parse(Request["R"]);
                }
                catch (Exception)
                {
                    Response.Write("Please provide a number");
                }

                Response.Write("<h1><center>Times table of " + table + "</center></h1>");

                for (int i = 0; i <= range; i++)
                {
                    Response.Write("<center>" + table + " x " + i + " = " + (table * i) + "</center>");
                    Response.Write("<br />");
                }
            %>
        </div>
    </form>
</body>
</html>

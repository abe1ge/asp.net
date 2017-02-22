<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="second.aspx.cs" Inherits="firstasp.second" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <%
                int table = 0;
                try
                {
                    table = Int32.Parse(Request["T"]);
                }
                catch (Exception)
                {
                    Response.Write("Please provide a number");
                }

                Response.Write("<h1><center>please select the range</center></h1>");

                for (int i = 0; i <= 100; i += 10)
                {
                    Response.Write("<center><a href='third.aspx?T=" + table + "&R=" + i + "'>" + i + "</a></center>");
                    Response.Write("<br /> ");
                    
                }
            %>
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="first.aspx.cs" Inherits="firstasp.first" %>

<!DOCTYPE html>


<body>

    <form id="form1" runat="server">
        <div class="container">
            <div class="panel panel-default">
                <center><h1>pick a number <br /></h1></center>
                <%
                    for (int i = 0; i <= 1000; i++)
                    {
                        Response.Write("<center><a href='second.aspx?T=" + i + "'>" + i + "</a></center>");
                        Response.Write("<br />");
                    }
                %>
            </div>

        </div>
    </form>

    <script src="/Scripts/jquery-1.9.1.min.js"></script>
    <script src="/Scripts/bootstrap.min.js"></script>
</body>
</html>

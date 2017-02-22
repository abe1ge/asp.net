<%@ Page Title="" Language="C#" MasterPageFile="~/ultimet.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="firstasp.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
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
</asp:Content>

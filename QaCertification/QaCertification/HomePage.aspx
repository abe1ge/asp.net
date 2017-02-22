<%@ Page Title="" Language="C#" MasterPageFile="~/page.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="QaCertification.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <form id="form1" runat="server" style="height: 447px">
        <div class="container">
            <%--<div class="panel panel-default">--%>
                Home Page
                <br />
            <br />
            <table>
                <tr>
                    <th>Name</th>
                    <th>Address</th>
                    <th>Edit</th>
                    <th>Delete</th>
                </tr>
                <tr>
                    <td>Alfreds Futterkiste</td>
                    <td>Maria Anders</td>
                    <td>Germany</td>
                </tr>

            </table>
            <%--</div>--%>
        </div>
    </form>
</asp:Content>

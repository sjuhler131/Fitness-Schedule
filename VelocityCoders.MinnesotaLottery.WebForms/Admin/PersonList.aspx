<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PersonList.aspx.cs" Inherits="VelocityCoders.FitnessSchedule.WebForms.Admin.PersonList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Person List</h1>
        <br />
        <a href="Index.aspx">Index</a>
    <table>
        <asp:Repeater runat="server" ID="rptPersonList">
            <HeaderTemplate>
                <tr>
                    <td>PersonId</td>
                    <td>FirstName</td>
                    <td>LastName</td>
                    <td>DisplayFirstName</td>
                    <td>Gender</td>
                    <td>&nbsp;</td>
                </tr>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td><%# Eval("PersonId") %></td>
                    <td><%# Eval("FirstName") %></td>
                    <td><%# Eval("LastName") %></td>
                    <td><%# Eval("DisplayFirstName") %></td>
                    <td><%# Eval("Gender") %></td>
                    <td><a href='PersonDetails.aspx?PersonId=<%# Eval("PersonId") %>'>Details</a></td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
    </div>
    </form>
</body>
</html>

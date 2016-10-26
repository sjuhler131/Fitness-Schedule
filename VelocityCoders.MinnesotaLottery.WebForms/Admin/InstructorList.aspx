<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InstructorList.aspx.cs" Inherits="VelocityCoders.FitnessSchedule.WebForms.Admin.InstructorList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Instructor List</h1>
        <br />
        <a href="Index.aspx">Index</a>
    <table>
        <asp:Repeater runat="server" ID="rptInstructorList">
            <HeaderTemplate>
                <tr>
                    <td>InstructorId</td>
                    <td>PersonId</td>
                    <td>HireDate</td>
                    <td>TermDate</td>
                    <td>Description</td>
                    <td>&nbsp;</td>
                </tr>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td><%# Eval("InstructorId") %></td>
                    <td><%# Eval("PersonId") %></td>
                    <td><%# Eval("HireDate") %></td>
                    <td><%# Eval("TermDate") %></td>
                    <td><%# Eval("Description") %></td>
                    <td><a href='InstructorDetails.aspx?InstructorId=<%# Eval("InstructorId") %>'>Details</a></td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
    </div>
    </form>
</body>
</html>

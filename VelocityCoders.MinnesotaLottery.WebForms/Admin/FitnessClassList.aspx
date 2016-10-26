<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FitnessClassList.aspx.cs" Inherits="VelocityCoders.FitnessSchedule.WebForms.Admin.FitnessClassList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Fitness Class List</h1>
        <br />
        <a href="Index.aspx">Index</a>
    <table>
        <asp:Repeater runat="server" ID="rptFitnessClassList">
            <HeaderTemplate>
                <tr>
                    <td>FitnessClassId</td>
                    <td>FitnessClassName</td>
                    <td>Description</td>
                    <td>&nbsp;</td>
                </tr>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td><%# Eval("FitnessClassId") %></td>
                    <td><%# Eval("FitnessClassName") %></td>
                    <td><%# Eval("Description") %></td>
                    <td><a href='FitnessClassDetails.aspx?FitnessClassId=<%# Eval("FitnessClassId") %>'>Details</a></td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
    </div>
    </form>
</body>
</html>

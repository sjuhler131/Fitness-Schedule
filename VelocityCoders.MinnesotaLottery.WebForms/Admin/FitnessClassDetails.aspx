<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FitnessClassDetails.aspx.cs" Inherits="VelocityCoders.FitnessSchedule.WebForms.Admin.FitnessClassDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Fitness Class Details</h1>
        <a href="Index.aspx">Index</a>&nbsp;&nbsp; <a href="FitnessClassList.aspx">Fitness Class List</a>
        <br />
        <br />
        <asp:Label runat="server" ID ="lblMessage" />
        <br />
        <b>Fintess Class ID:</b> &nbsp; <asp:Label runat="server" ID ="lblFitnessClassId" />
        <br />
        <b>Fitness Class Name:</b> &nbsp; <asp:Label runat="server" ID ="lblFitnessClassName" />
        <br />
        <b>Description:</b> &nbsp; <asp:Label runat="server" ID ="lblDescription" />
    </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InstructorDetails.aspx.cs" Inherits="VelocityCoders.FitnessSchedule.WebForms.Admin.InstructorDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Instructor Details</h1>
        <a href="Index.aspx">Index</a>&nbsp;&nbsp; <a href="InstructorList.aspx">Instructor List</a>
        <br />
        <br />
        <asp:Label runat="server" ID ="lblMessage" />
        <br />
        <b>Instructor ID:</b> &nbsp; <asp:Label runat="server" ID ="lblInstructorId" />
        <br />        
        <b>Person ID:</b> &nbsp; <asp:Label runat="server" ID ="lblPersonId" />
        <br />
        <b>Hire Date:</b> &nbsp; <asp:Label runat="server" ID ="lblHireDate" />
        <br />
        <b>Term Date:</b> &nbsp; <asp:Label runat="server" ID ="lblTermDate" />
        <br />
        <b>Description:</b> &nbsp; <asp:Label runat="server" ID ="lblDescription" />
    </div>
    </form>
</body>
</html>

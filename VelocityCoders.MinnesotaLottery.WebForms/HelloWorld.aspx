<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HelloWorld.aspx.cs" Inherits="VelocityCoders.FitnessSchedule.WebForms.HelloWorld" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hello World</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Label runat="server" ID="lblStaticContent" />
        <br />
        <asp:Label runat="server" ID="lblDynamicContent" />
        <br />
        <asp:Label runat="server" ID="lblDisplayMessage" />
        <br />
    </div>
    </form>
</body>
</html>

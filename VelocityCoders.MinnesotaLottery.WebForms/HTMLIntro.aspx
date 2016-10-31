<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HTMLIntro.aspx.cs" Inherits="VelocityCoders.FitnessSchedule.WebForms.HTMLIntro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Steve is Learning HTML</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <center>
        <a href="HelloWorld.aspx">
        <img src="Images/background-banner.jpg" alt="Background Image" height="100"/>
        </a>
            <br />
            <a href="mailto:dan@velocitycoders.com">Email Me</a>
        </center>
    <h2>Page Navigation</h2>
        <h1>Hello World!</h1>
        <p>The <b>Hello Web</b> page is a <i><u>basic</u></i> page to learn HTML</p>
        <h3>More Page Content</h3>
        <ol type='A' start='5'>
            <li>First</li>
            <li>Second</li>
            <li>Third</li>
        </ol>
        <ul type="circle">
            <li>First</li>
            <li>Second</li>
            <li>Third</li>
            <li>Fourth</li>
        </ul>      
    </div>
        <div>
            <table border="1">
                <tr>
                    <th>Column1</th>
                    <th>Column2</th>
                    <th>Column3</th>
                    <th>Column4</th>
                </tr>
                <tr>
                    <td>Data 1</td>
                    <td>Data 2</td>
                    <td colspan='2'>Data 3</td>
                </tr>
            </table>
        </div>
        <div>
            <h2>iFrame Example</h2>
            <iframe src="HelloWorld.aspx">Hello World Web Page</iframe>
        </div>
    </form>
</body>
</html>

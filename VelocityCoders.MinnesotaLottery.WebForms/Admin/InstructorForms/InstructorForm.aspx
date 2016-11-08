<%@ Page Language="C#" 
    AutoEventWireup="true"
    CodeBehind="InstructorForm.aspx.cs" 
    Inherits="VelocityCoders.FitnessSchedule.WebForms.Admin.InstructorForms.InstructorForm" 
    EnableViewState="true"
    Theme="Main"
    %>

<%@ Register TagPrefix="CustomVelocityCoders"
             TagName="InstructorNavigation"
             Src="~/User Controls/InstructorNavigationControl.ascx" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">        
            <div id="Header">
                <img src="/Images/header-logo.png" />              
            </div>
            <div id="Subheader">
                <div class="Banner">
                    <h1 class="Banner-Text">Fitness Schedule Administration</h1>
                    <p>Tool to manage your fitness schedule application.</p>
                </div>
            </div> 
        <div id="Container">
            <div id="NavigationContainer">
                <div id="NavigationContainerContent">Left Navigation Placeholder</div>
            </div>
            <div id="BodyContainer">
                <div id="BodyContainerContent">
                    <CustomVelocityCoders:InstructorNavigation runat="server" ID="instructorNavigation" />
                    <div id="InstructorContainer" class="BorderRadiusBottom">
                        <asp:Label runat="server" ID="lblPageMessage" />
                                <table>
                        <tr>
                               <td><label>First Name:</label></td>
                            <td><asp:TextBox runat="server" ID="txtFirstName" MaxLength="50" /></td>
                        </tr>
                        <tr>
                               <td><label>Preferred First Name:</label></td>
                            <td><asp:TextBox runat="server" ID="txtPreferredFirstName" MaxLength="50" /></td>
                        </tr>
                        <tr>
                               <td><label>Last Name:</label></td>
                            <td><asp:TextBox runat="server" ID="txtLastName" MaxLength="50" /></td>
                        </tr>
                        <tr>
                               <td><label>Date of Birth:</label></td>
                            <td><asp:TextBox runat="server" ID="txtBirthDate" MaxLength="10" /></td>
                        </tr>
                        <tr>
                            <td colspan="2"><hr /></td>
                        </tr>
                        <tr>
                               <td><label>Hire Date:</label></td>
                            <td><asp:TextBox runat="server" ID="txtHireDate" MaxLength="10" /></td>
                        </tr>
                        <tr>
                               <td><label>Termination Date:</label></td>
                            <td><asp:TextBox runat="server" ID="txtTermDate" MaxLength="10" /></td>
                        </tr>
                        <tr>
                            <td><label>Employee Type</label></td>
                            <td>
                                <asp:DropDownList runat="server" ID="drpEmployeeType">
                                    <asp:ListItem Text="(Select Employee Type)" />
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td><label>Gender:</label></td>
                            <td>
                                <asp:DropDownList runat="server" ID="drpGender">
                                    <asp:ListItem Text="(Select Gender)" Value="0" />
                                    <asp:ListItem Text="Male" Value="Male" />
                                    <asp:ListItem Text="Female" Value="Female" />
                                </asp:DropDownList>
                            </td>
                        </tr>
            <tr>
                <td><label>Notes:</label></td>
                <td><asp:TextBox runat="server" ID="txtNotes" TextMode="MultiLine" /></td>
            </tr>
        </table>
        <br />
        <asp:Button runat="server" Text="Save" OnClick="Save_Click"/>
                    </div>
                </div>
            </div>
        </div>
               
    <div>
        <div id="Footer">
        <div>Copyright 2016 - Velocity Coders</div>
        </div> 
      </div>   
    </form>
</body>
</html>

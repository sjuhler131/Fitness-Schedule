﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InstructorForm.aspx.cs" Inherits="VelocityCoders.FitnessSchedule.WebForms.Admin.InstructorForms.InstructorForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <img src="/Images/header-logo.png" />
        <br />
        <br />
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
                               <td><label>Date of Hire:</label></td>
                            <td><asp:TextBox runat="server" ID="txtDateofHire" MaxLength="10" /></td>
                        </tr>
                        <tr>
                               <td><label>Date of Termination:</label></td>
                            <td><asp:TextBox runat="server" ID="txtDateofTermination" MaxLength="10" /></td>
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
        <asp:Button runat="server" Text="Save"  />
    </div>
    </form>
</body>
</html>
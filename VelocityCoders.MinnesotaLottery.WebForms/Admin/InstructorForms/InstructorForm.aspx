<%@ Page 
    Language="C#" 
    AutoEventWireup="true"
    MasterPageFile="~/MasterPages/Site2Column.Master"
    CodeBehind="InstructorForm.aspx.cs" 
    Inherits="VelocityCoders.FitnessSchedule.WebForms.Admin.InstructorForms.InstructorForm" 
    EnableViewState="true"
    Theme="Main"
    %>

<%@ Register TagPrefix="CustomVelocityCoders"
             TagName="InstructorNavigation"
             Src="~/User Controls/InstructorNavigationControl.ascx" %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:HiddenField runat="server" ID="hidInstructorId" Value="0" />
    <asp:HiddenField runat="server" ID="hidPersonId" Value="0" />
    
    
    
    
    
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
                                <asp:DropDownList   runat="server" 
                                                    ID="drpEmployeeType"
                                                    DataTextField="EntityTypeName"
                                                    DataValueField="EntityTypeId"/>                                   
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
         <div class="ContainerBar">
        <asp:Button runat="server" Text="AddInstructor" ID="btnSave" OnClick="Save_Click"/>
        &nbsp;&nbsp;
        <asp:Button runat="server" Text="Cancel" ID="btnCancel" OnClick="Cancel_Click" />
             <span class="FloatRight">
                 <asp:Button runat="server" text="Delete" ID="btnDelete" OnClick="Delete_Click" Visible ="false" />
             </span>
        </div>
   </div>                   
</asp:Content>
                    
               
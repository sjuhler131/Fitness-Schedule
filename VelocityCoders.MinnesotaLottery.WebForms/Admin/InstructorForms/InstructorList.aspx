<%@ Page Title="InstructorList" 
    Language="C#" 
    MasterPageFile="~/MasterPages/Site2Column.Master" 
    AutoEventWireup="true" 
    Theme="Main"
    CodeBehind="InstructorList.aspx.cs" 
    Inherits="VelocityCoders.FitnessSchedule.WebForms.Admin.InstructorForms.InstructorList" %>

<%@ Register Src="~/User Controls/InstructorNavigationControl.ascx" 
    TagPrefix="CustomVelocityCoders" 
    TagName="InstructorNavigation" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>




<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <CustomVelocityCoders:InstructorNavigation runat="server" ID="instructorNavigator" />
    <div id="InstructorContainer" class="BorderRadiusBottom" >
        <table>
            <asp:Repeater runat="server" ID="rptInstructorList">
                <HeaderTemplate>
                    <tr>
                        <td>First Name</td>
                        <td>Last Name</td>
                        <td>Display Name</td>
                        <td>Gender</td>                        
                        <td>HireDate</td>
                        <td>TermDate</td>
                        <td>Employee Type</td>
                        <td>&nbsp;</td>
                    </tr>
                </HeaderTemplate>
                <ItemTemplate>
                <tr>
                    <td><%# Eval("FirstName") %></td>
                    <td><%# Eval("LastName") %></td>
                    <td><%# Eval("DisplayFirstName") %></td>
                    <td class="TextCenter"><%# Eval("Gender") %></td>
                    <td class="TextCenter"><%# Eval("HireDate") %></td>
                    <td class="TextCenter"><%# Eval("TermDate") %></td>
                    <td class="TextCenter"><%# Eval("EntityTypeId") %></td>
                    <td class="TextCenter"><a href='InstructorForm.aspx?InstructorId=<%# Eval("InstructorId") %>'>Edit</a></td>
                </tr>
                </ItemTemplate>
             </asp:Repeater>
          </table>
    </div>
</asp:Content>

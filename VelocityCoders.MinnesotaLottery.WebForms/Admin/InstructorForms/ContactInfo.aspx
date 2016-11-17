<%@ Page Title="Contact Info" 
    Theme ="Main"
    Language="C#"
    MasterPageFile="~/MasterPages/Site2Column.Master" 
    AutoEventWireup="true" 
    CodeBehind="ContactInfo.aspx.cs" 
    Inherits="VelocityCoders.FitnessSchedule.WebForms.Admin.InstructorForms.ContactInfo" %>

<%@ Register TagPrefix="CustomVelocityCoders"
             TagName="InstructorNavigation"
             Src="~/User Controls/InstructorNavigationControl.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<CustomVelocityCoders:InstructorNavigation runat="server" ID="instructorNavigation" />
                    <div id="InstructorContainer" class="BorderRadiusBottom">
                        Content from the Contact Info Body...
                    </div>
</asp:Content>

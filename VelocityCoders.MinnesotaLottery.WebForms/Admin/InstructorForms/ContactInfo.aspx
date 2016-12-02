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
    <asp:HiddenField runat="server" ID="hidEmailId" Value ="0" />
<CustomVelocityCoders:InstructorNavigation runat="server" ID="instructorNavigation" />
                    <div id="InstructorContainer" class="BorderRadiusBottom">
                        
                    <div class="PageMessage"><asp:Label runat="server" ID="lblPageMessage" /></div>
                        <table>
                            <tr>
                                <td><label>Email Address:</label></td>
                                <td><asp:TextBox runat="server" ID="txtEmailAddress" MaxLength="50" /></td>
                            </tr>
                            <tr>
                                <td>Email Type:</td>
                                <td>
                                    <asp:DropDownList
                                        runat="server"
                                        ID="drpEmailType"
                                        DataTextField="EntityTypeName"
                                        DataValueField="EntityTypeId">                                         
                                    </asp:DropDownList>
                                </td>
                            </tr>
                        </table>
                        <div class="ContainerBar">
                            <asp:Button runat="server"
                                Text="Add Email"
                                ID="btnSaveEmail"
                                OnClick="Save_Click" />
                        </div>
        <br />
        <asp:Repeater runat="server" ID="rptEmailList" OnItemDataBound="EmailList_OnItemDataBound">
            <HeaderTemplate>
                <table class="ListStyle BorderRadiusAll">
                    <tr>
                        <th>&nbsp;</th>
                        <th>Email Address</th>
                        <th>Email Type</th>
                    </tr>               
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td class="CenterText">
                        <asp:LinkButton
                            runat="server"
                            ID="EditButton"
                            Text="Edit"
                            CssClass="Button ButtonRoundedLeft"
                            OnCommand="EmailButton_Command"
                            CommandName="Edit" />
                        <asp:LinkButton
                            runat="server"
                            ID="DeleteButton"
                            Text="Delete"
                            CssClass="Button ButtonRoundedRight"
                            OnCommand="EmailButton_Command"
                            CommandName="Delete" />
                    </td>
                    <td class="CenterText"><%# Eval("EmailValue") %></td>
                    <td class="CenterText"><%# Eval("EmailType.EntityTypeName") %></td>
                </tr>
            </ItemTemplate>
            <AlternatingItemTemplate>
               <tr>
                    <td class="CenterText">
                        <asp:LinkButton
                            runat="server"
                            ID="EditButton"
                            Text="Edit"
                            CssClass="Button ButtonRoundedLeft"
                            OnCommand="EmailButton_Command"
                            CommandName="Edit" />
                        <asp:LinkButton
                            runat="server"
                            ID="DeleteButton"
                            Text="Delete"
                            CssClass="Button ButtonRoundedRight"
                            OnCommand="EmailButton_Command"
                            CommandName="Delete" />
                    </td>
                    <td class="CenterText"><%# Eval("EmailValue") %></td>
                    <td class="CenterText"><%# Eval("EmailType.EntityTypeName") %></td>
                </tr>
            </AlternatingItemTemplate>
            <FooterTemplate>
                </table>
            </FooterTemplate>
        </asp:Repeater>

    </div>
</asp:Content>

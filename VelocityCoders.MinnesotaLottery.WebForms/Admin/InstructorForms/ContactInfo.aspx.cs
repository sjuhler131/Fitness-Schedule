using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VelocityCoders.FitnessSchedule.WebForms.Custom;
using Uhler.Common;
using Uhler.Common.Extensions;
using VelocityCoders.FitnessSchedule.BLL;
using VelocityCoders.FitnessSchedule.Models;
using VelocityCoders.FitnessSchedule.Models.Enums;
using VelocityCoders.FitnessSchedule.Models.Collections;


namespace VelocityCoders.FitnessSchedule.WebForms.Admin.InstructorForms
{
    public partial class ContactInfo : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.BindInstructorNavigation(); 
            if(!IsPostBack)
            {
                this.BindEmailType();
                this.BindEmailList();
            }
        }

        #region CRUD

        private void DeleteEmail (int emailId)
        {
            if (EmailAddressManager.Delete(emailId))
            {
                //notes: redirects back to page refresh list.
                Response.Redirect("ContactInfo.aspx?InstructorId=" + base.InstructorId.ToString());
            }
            else
            {
                //notes: display message to user
                base.DisplayPageMessage(lblPageMessage, "Delete of email failed. Contact administrator.");
            }
        }

        private void ProcessEmail()
        {
            EmailAddress emailToSave = new EmailAddress(drpEmailType.SelectedValue.ToInt(), txtEmailAddress.Text);

            //notes: set EmailId property for updates
            emailToSave.EmailId = hidEmailId.Value.ToInt();

            //notes: call middle tier to save
            InstructorManager.SaveEmail(base.InstructorId, emailToSave);

            Response.Redirect("ContactInfo.aspx?InstructorId=" + base.InstructorId.ToString());
        }
        #endregion

        #region EVENT HANDLERS

        protected void EmailList_OnItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                EmailAddress emailAddress = (EmailAddress)e.Item.DataItem;

                LinkButton editButton = (LinkButton)e.Item.FindControl("EditButton");
                LinkButton deleteButton = (LinkButton)e.Item.FindControl("DeleteButton");

                editButton.CommandArgument = emailAddress.EmailId.ToString();
                deleteButton.CommandArgument = emailAddress.EmailId.ToString();
            }
        }

        protected void EmailButton_Command(object sender, CommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "Edit":
                    this.BindUpdateInfo(e.CommandArgument.ToString().ToInt());
                    break;

                case "Delete":
                    this.DeleteEmail(e.CommandArgument.ToString().ToInt());
                    break;
            }
        }

        protected void Save_Click (object sender, EventArgs e)
        {
            this.ProcessEmail();
        }

        


        #endregion

        #region BIND CONTROLS

        private void BindInstructorNavigation()
        {
            instructorNavigation.CurrentNavigationLink = InstructorNavigation.ContactInfo;

            instructorNavigation.InstructorId = base.InstructorId;
        }

        private void BindEmailType()
        {

            EntityTypeCollection items = EntityTypeManager.GetCollection(EntityEnum.Email);

            //ListItemCollection drpItems = new ListItemCollection();

            //ListItem option01 = new ListItem { Text = "List Item 01", Value = "1" };
            //ListItem option02 = new ListItem { Text = "List Item 02", Value = "2" };
            //ListItem option03 = new ListItem { Text = "List Item 03", Value = "3" };

            //drpItems.Add(option01);
            //drpItems.Add(option02);
            //drpItems.Add(option03);

            drpEmailType.DataSource = items;
            drpEmailType.DataBind();

            drpEmailType.Items.Insert(0, new ListItem { Text = "(Select Email Type)", Value = "0" });
        }

        private void BindUpdateInfo(int emailId)
        {
            EmailAddress emailAddress = EmailAddressManager.GetItem(emailId);
            if (emailAddress != null)
            {
                //notes: set hidden fields so page knows to update
                hidEmailId.Value = emailAddress.EmailId.ToString();

                //notes: set textbox for email address
                if (emailAddress.EmailValue != null)
                    txtEmailAddress.Text = emailAddress.EmailValue;

                //notes: select item from drop-down
                if (emailAddress.EmailType != null)
                    drpEmailType.SelectedValue = emailAddress.EmailType.EntityTypeId.ToString();

                //notes: set the display text of the button to indicate if it is an UPDATE
                btnSaveEmail.Text = "Save Email";
            }
            else
                base.DisplayPageMessage(lblPageMessage, "Email Address could not be retrieved. Contact and administrator.");
        }

        private void BindEmailList()
        {
            EmailAddressCollection emailList = EmailAddressManager.GetCollection(base.InstructorId);

            rptEmailList.DataSource = emailList;
            rptEmailList.DataBind();
        }

        #endregion
    }

}

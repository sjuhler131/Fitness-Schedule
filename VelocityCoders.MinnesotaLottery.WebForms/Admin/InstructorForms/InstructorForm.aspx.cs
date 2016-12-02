using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using VelocityCoders.FitnessSchedule.BLL;
using VelocityCoders.FitnessSchedule.Models;
using VelocityCoders.FitnessSchedule.Models.Collections;
using Uhler.Common;
using VelocityCoders.FitnessSchedule.Models.Enums;
using VelocityCoders.FitnessSchedule.DAL;
using Uhler.Common.Extensions;
using VelocityCoders.FitnessSchedule.WebForms.Custom;


namespace VelocityCoders.FitnessSchedule.WebForms.Admin.InstructorForms
{
    public partial class InstructorForm : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            this.BindInstructorNavigation();
            if (!IsPostBack)
            {
                this.BindEmployeeType();
                this.CheckUpdate();
            }
        }


        private void CheckUpdate()
        {
            if (base.InstructorId > 0)
            {
                Instructor instructorToUpdate = InstructorManager.GetItem(base.InstructorId);

                if (instructorToUpdate != null)
                {
                    this.BindUpdateInfo(instructorToUpdate);
                    this.SetButtons(true);
                }
                else
                {
                    this.SetButtons(false);
                }
            }
            else
                this.SetButtons(false);

                       
        }

        #region BIND CONTROLS

        private void BindInstructorNavigation()
        {
            instructorNavigation.CurrentNavigationLink = InstructorNavigation.InstructorForm;

            instructorNavigation.InstructorId = base.InstructorId;
        }
        private void BindEmployeeType()
        {
            EntityTypeCollection employeeTypeList = EntityTypeManager.GetCollection(EntityEnum.EmployeeType);

            drpEmployeeType.DataSource = employeeTypeList;
            drpEmployeeType.DataBind();

            drpEmployeeType.Items.Insert(0, new ListItem { Text = "(Select Emplyee Type)" });
        }
        private void BindUpdateInfo(Instructor instructorToUpdate)
        {
            if (instructorToUpdate.FirstName != null)
                txtFirstName.Text = instructorToUpdate.FirstName;

            if (instructorToUpdate.LastName != null)
                txtLastName.Text = instructorToUpdate.LastName;

            if (instructorToUpdate.DisplayFirstName != null)
                txtPreferredFirstName.Text = instructorToUpdate.DisplayFirstName;

            if (instructorToUpdate.Description != null)
                txtNotes.Text = instructorToUpdate.Description;

            if (instructorToUpdate.BirthDate != DateTime.MinValue)
                txtBirthDate.Text = instructorToUpdate.BirthDate.ToShortDateString();

            if (instructorToUpdate.HireDate != DateTime.MinValue)
                txtHireDate.Text = instructorToUpdate.HireDate.ToShortDateString();

            if (instructorToUpdate.TermDate != DateTime.MinValue)
                txtTermDate.Text = instructorToUpdate.TermDate.ToShortDateString();

            if (instructorToUpdate.Gender != null)
                drpGender.SelectedValue = instructorToUpdate.Gender;

            if (instructorToUpdate.EntityTypeId > 0)
                drpEmployeeType.SelectedValue = instructorToUpdate.EntityTypeId.ToString();

            hidInstructorId.Value = base.InstructorId.ToString();
            hidPersonId.Value = instructorToUpdate.PersonId.ToString();
        }
        private void SetButtons(bool isUpdate)
        {
            if (isUpdate)
            { 
                btnSave.Text = "Update Instructor";
                btnCancel.Visible = true;
                btnDelete.Visible = true;
            }
            else
            {
                btnSave.Text = "Add Instructor";
                btnCancel.Visible = false;
                btnDelete.Visible = false;
            }
        }
            
        #endregion


        #region EVENT HANDLERS
        protected void Save_Click(object sender, EventArgs e)
        {
            this.ProcessForm();
        }

        protected void Cancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("InstructorForm.aspx");
        }

        protected void Delete_Click(object sender, EventArgs e)
        {
            this.DeleteInstructor();
        }

        #endregion
        private void ProcessForm()
        {           
            string firstName = txtFirstName.Text;
            string preferredFistName = txtPreferredFirstName.Text;
            string lastName = txtLastName.Text;
            string birthDate = txtBirthDate.Text;
            string hireDate = txtHireDate.Text;
            string termDate = txtTermDate.Text;
            string employeeType = drpEmployeeType.SelectedItem.Value;
            string gender = drpGender.SelectedItem.Text;
            string notes = txtNotes.Text;
            

            Instructor instructorToSave = new Instructor();

            //notes: specify person properties

            instructorToSave.FirstName = firstName;
            instructorToSave.DisplayFirstName = preferredFistName;
            instructorToSave.LastName = lastName;
            instructorToSave.BirthDate = birthDate.ToDate();
            instructorToSave.Gender = gender;

            //notes: specify instructor properties

            instructorToSave.HireDate = hireDate.ToDate();
            instructorToSave.TermDate = termDate.ToDate();
            instructorToSave.EntityTypeId = employeeType.ToInt();
            instructorToSave.Description = notes;

            //notes: set Id's from hidden fields to determine insert/update
            instructorToSave.InstructorId = hidInstructorId.Value.ToInt();
            instructorToSave.PersonId = hidPersonId.Value.ToInt();
            

            // notes: call instructor manager
            //InstructorManager.Save(instructorToSave);

            int someValue = InstructorManager.Save(instructorToSave);

            Response.Redirect("InstructorForm.aspx?InstructorId=" + someValue);

            //lblPageMessage.Text = "Save successfully";           
        }
        private void DeleteInstructor()
        {
            int instructorId = hidInstructorId.Value.ToInt();
             

            if (instructorId > 0)
            {
                if (InstructorManager.Delete(instructorId))
                {
                    Response.Redirect("InstructorList.aspx");
                }
                else
                    base.DisplayPageMessage(lblPageMessage, "Error. Delete Failed.");
            }
            else
                base.DisplayPageMessage(lblPageMessage, "Invalid ID. Delete Failed.");
        }
    }
}
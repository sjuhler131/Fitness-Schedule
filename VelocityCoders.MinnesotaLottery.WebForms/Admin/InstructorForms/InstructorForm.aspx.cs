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
            this.BindEmployeeType();

            this.CheckUpdate();
        }


        private void CheckUpdate()
        {
            if (base.InstructorId > 0)
            {
                Instructor instructorToUpdate = InstructorManager.GetItem(base.InstructorId);
                
                if (instructorToUpdate != null )
                {
                    this.BindUpdateInfo(instructorToUpdate);
                }
            }
            
        }

        #region BIND CONTROLS

        private void BindInstructorNavigation()
        {
            instructorNavigation.CurrentNavigationLink = InstructorNavigation.InstructorForm;

            instructorNavigation.InstructorId = 1;
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
            
        #endregion


        #region EVENT HANDLERS
        protected void Save_Click(object sender, EventArgs e)
        {
            this.ProcessForm();
        }
        #endregion
        private void ProcessForm()
        {
            //StringBuilder formValues = new StringBuilder();

            string firstName = txtFirstName.Text;
            string preferredFistName = txtPreferredFirstName.Text;
            string lastName = txtLastName.Text;
            string birthDate = txtBirthDate.Text;
            string hireDate = txtHireDate.Text;
            string termDate = txtTermDate.Text;
            string employeeType = drpEmployeeType.SelectedItem.Text;
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



            // notes: call instructor manager

            InstructorManager.Save(instructorToSave);

            lblPageMessage.Text = "Save successfully";

            //formValues.Append("First Name: " + firstName);
            //formValues.Append("<br />");
            //formValues.Append("Preferred First Name: " + preferredFistName);
            //formValues.Append("<br />");
            //formValues.Append("Last Name: " + lastName);
            //formValues.Append("<br />");
            //formValues.Append("Birth Date: " + birthDate);
            //formValues.Append("<br />");
            //formValues.Append("Hire Date" + hireDate);
            //formValues.Append("<br />");
            //formValues.Append("Term Date" + termDate);
            //formValues.Append("<br />");
            //formValues.Append("Employee Type" + employeeType);
            //formValues.Append("<br />");
            //formValues.Append("Gender" + gender);
            //formValues.Append("<br />");
            //formValues.Append("Notes: " + notes);

            //lblPageMessage.Text = formValues.ToString();
        }
    }
}
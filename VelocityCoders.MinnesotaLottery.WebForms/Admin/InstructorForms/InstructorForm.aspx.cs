using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace VelocityCoders.FitnessSchedule.WebForms.Admin.InstructorForms
{
    public partial class InstructorForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //lblPageMessage.Text = DateTime.Now.ToShortTimeString();

            //if (IsPostBack)
            //{
            //    lblPageMessage.Text = lblPageMessage.Text + " - " + txtFirstName.Text;
            //}
            
        }

        protected void Save_Click(object sender, EventArgs e)
        {
            lblPageMessage.Text = "Event Handler: " + lblPageMessage.Text + " - " + txtFirstName.Text;
        } 

        private void ProcessForm()
        {
            StringBuilder formValues = new StringBuilder();
            string firstName = txtFirstName.Text;
            string preferredFistName = txtPreferredFirstName.Text;
            string lastName = txtLastName.Text;
            string birthDate = txtBirthDate.Text;
            string dateofHire = txtDateofHire.Text;
            string dateofTermination = txtDateofTermination.Text;
            string employeeType = drpEmployeeType.SelectedItem.Text;
            string gender = drpGender.SelectedItem.Text;
            string notes = txtNotes.Text;

            formValues.Append("First Name: " + firstName);
            formValues.Append("br />");
            formValues.Append("Preferred First Name: " + preferredFistName);
            formValues.Append("br />");
            formValues.Append("Last Name: " + lastName);
            formValues.Append("br />");
            formValues.Append("Birth Date: " + birthDate);
            formValues.Append("br />");
            formValues.Append("Hire Date" + dateofHire);
            formValues.Append("br />");

        }
    }
}
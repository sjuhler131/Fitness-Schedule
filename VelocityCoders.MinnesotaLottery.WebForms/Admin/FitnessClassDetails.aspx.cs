using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Uhler.Common.Extensions;
using VelocityCoders.FitnessSchedule.Models;
using VelocityCoders.FitnessSchedule.DAL;

namespace VelocityCoders.FitnessSchedule.WebForms.Admin
{
    public partial class FitnessClassDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.BindFitnessClass();
        }

        private void BindFitnessClass()
        {
            int fitnessClassId = Request.QueryString["FitnessClassId"].ToInt();

            if (fitnessClassId > 0)
            {
                FitnessClass personLookup = FitnessClassDAL.GetItem(fitnessClassId);

                if (personLookup != null)
                {
                    lblFitnessClassId.Text = personLookup.FitnessClassId.ToString();
                    lblFitnessClassName.Text = personLookup.FitnessClassName;
                    lblDescription.Text = personLookup.Description;
                }

                else
                    lblMessage.Text = "Fitness Class could not be found.";
            }
            else
                lblMessage.Text = "Invalid ID. Fitness Class record could not be found.";
        }
    }
}
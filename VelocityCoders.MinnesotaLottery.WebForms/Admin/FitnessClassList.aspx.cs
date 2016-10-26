using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VelocityCoders.FitnessSchedule.Models;
using VelocityCoders.FitnessSchedule.Models.Collections;
using VelocityCoders.FitnessSchedule.DAL;
using Uhler.Common;

namespace VelocityCoders.FitnessSchedule.WebForms.Admin
{
    public partial class FitnessClassList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.BindFitnessClassList();
        }

        private void BindFitnessClassList()
        {
            FitnessClassCollection fitnessClassList = new FitnessClassCollection();

            fitnessClassList = FitnessClassDAL.GetCollection();

            rptFitnessClassList.DataSource = fitnessClassList;
            rptFitnessClassList.DataBind();
        }
    }
}

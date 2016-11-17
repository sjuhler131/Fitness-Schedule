using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VelocityCoders.FitnessSchedule.Models;
using VelocityCoders.FitnessSchedule.Models.Collections;
using VelocityCoders.FitnessSchedule.Models.Enums;
using VelocityCoders.FitnessSchedule.DAL;
using Uhler.Common;
using VelocityCoders.FitnessSchedule.BLL;

namespace VelocityCoders.FitnessSchedule.WebForms.Admin
{
    public partial class EntityTypeList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.BindEntityTypeList();
        }

        private void BindEntityTypeList()
        {
            EntityTypeCollection entityTypeList = new EntityTypeCollection();

            entityTypeList = EntityTypeManager.GetCollection(EntityEnum.EmployeeType);

            rptEntityTypeList.DataSource = entityTypeList;
            rptEntityTypeList.DataBind();
        }
    }
}
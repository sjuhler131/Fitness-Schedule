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
    public partial class EntityTypeDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.BindEntityType();
        }

        private void BindEntityType()
        {
            int entityTypeId = Request.QueryString["EntityTypeId"].ToInt();

            if (entityTypeId > 0)
            {
                EntityType entityTypeLookup = EntityTypeDAL.GetItem(entityTypeId);

                if (entityTypeLookup != null)
                {
                    lblEntityTypeId.Text = entityTypeLookup.EntityTypeId.ToString();
                    lblEntityId.Text = entityTypeLookup.EntityId.ToString();
                    lblEntityTypeName.Text = entityTypeLookup.EntityTypeName;                 
                    lblDisplayName.Text = entityTypeLookup.DisplayName;
                    lblDescription.Text = entityTypeLookup.Description;
                }

                else
                    lblMessage.Text = "EntityType could not be found.";
            }
            else
                lblMessage.Text = "Invalid ID. EntityType record could not be found.";
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VelocityCoders.FitnessSchedule.WebForms;

namespace VelocityCoders.FitnessSchedule.WebForms.User_Controls
{
    public partial class InstructorNavigationControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.BindInstructorNavigation();
        }

        #region PROPERTIES
        //Set the current instructor page. Link will be disabled for the current subheader link of current page.
        public InstructorNavigation CurrentNavigationLink { get; set; }

        //If ID is greater than 0 will activate the subheader links othewise all subheader links will be inactive.
        public int InstructorId { get; set; }

        #endregion

        private void BindInstructorNavigation()
        {
            ListItemCollection navigationList = new ListItemCollection();

            Array navigationValues = Enum.GetValues(typeof(InstructorNavigation));

            string instructorIdQueryString = "InstructorId=" + this.InstructorId.ToString();

            if (this.InstructorId > 0)
            {
                foreach (InstructorNavigation item in navigationValues)
                {
                    if (item != InstructorNavigation.None)
                    {
                        string displayValue = item.ToString();

                        if (item == this.CurrentNavigationLink)
                            navigationList.Add(new ListItem { Text = displayValue, Value = "", Enabled = false });
                        else
                            navigationList.Add(new ListItem
                            {
                                Text = displayValue,
                                Value = "/Admin/Instructor/" + item.ToString() + ".aspx?" + instructorIdQueryString,
                                Enabled = true
                            });
                    }
                }
            }
            else
            {
                foreach (InstructorNavigation item in navigationValues)
                {
                    if (item != InstructorNavigation.None)
                    {
                        navigationList.Add(new ListItem
                        {
                            Text = item.ToString(),
                            Value = "/Admin/Instructor/" + item.ToString() + ".aspx?" + instructorIdQueryString,
                            Enabled = false
                        });
                    }

                }
            }
            InstructorNavigationList.DataSource = navigationList;
            InstructorNavigationList.DataBind();
        }
    }
}

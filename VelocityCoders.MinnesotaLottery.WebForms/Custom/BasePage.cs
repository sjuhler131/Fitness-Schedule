using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Uhler.Common.Extensions;
using System.Web.UI.WebControls;


namespace VelocityCoders.FitnessSchedule.WebForms.Custom
{
    public class BasePage : System.Web.UI.Page
    {
        public int GetQueryStringNumber(string queryStringName)
        {            
            if (Request.QueryString[queryStringName] == null)
            {
                return 0;
            }
            else
            {
                return Request.QueryString[queryStringName].ToInt();
            }
        }

        public int InstructorId
        {
            get
            {
                return this.GetQueryStringNumber("InstructorId");
            }
        }

        public void DisplayPageMessage(Label labelControl, string messageToDisplay)
        {
            this.DisplayPageMessage(labelControl, messageToDisplay, false);
        }
        public void DisplayPageMessage(Label labelControl, string messageToDisplay, bool isAppend)
        {
            if (isAppend)
                labelControl.Text += messageToDisplay;
            else
                labelControl.Text = messageToDisplay;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Uhler.Common;
using VelocityCoders.FitnessSchedule.Models;
using VelocityCoders.FitnessSchedule.Models.Collections;

namespace VelocityCoders.FitnessSchedule.WebForms
{
    public partial class PolymorphismLab : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //lblDisplayMessage.Text = this.GetVikings("Teddy");
            this.VikingExample();

        }

        public string GetVikings(string vikingNames)
        {
            string returnValue = string.Empty;

            switch (vikingNames)
            {
                case "Teddy":
                    returnValue = "Bridgewater";
                    break;
                case "Adrian":
                    returnValue = "Peterson";
                    break;
                case "Sam":
                    returnValue = "Bradford";
                    break;
            }
            return returnValue;
        }
        public string GetVikings(int vikingNumbers)
        {
            string returnValue = string.Empty;

            switch (vikingNumbers)
            {
                case 8:
                    returnValue = "Sam Bradford";
                    break;
                case 5:
                    returnValue = "Teddy Bridgewater";
                    break;
                case 28:
                    returnValue = "Adrian Peterson";
                    break;
            }
            return returnValue;
        }

        public void VikingExample()
        {
            Person person01 = new Person();
            lblDisplayMessage.Text = person01.GetNameExample();
        }
    }
}
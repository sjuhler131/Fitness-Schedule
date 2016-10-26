using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;

namespace VelocityCoders.FitnessSchedule.WebForms
{
    public partial class ExceptionsLab : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //this.Exception01();
            //this.Exception02();  
        }
        #region Exception01
        public void Exception01()
        {
            int a = 20;
            int b = 10;
            int c = 10;

            try
            {
                lblDisplayMessage.Text = (a / (b - c)).ToString();
            }
            catch (DivideByZeroException ex)
            {
                lblDisplayMessage.Text = "Dividing by zero error..." + ex.Message;
            }
            catch (Exception ex)
            {
                lblDisplayMessage.Text = "Error" + ex.Message;
            }
            finally
            {
                lblDisplayMessage.Text = "Error: This issue is being looked into.";
            }
        }
        #endregion
        #region Exception02
        private void Exception02()
        {
            string[] arrayException = new string[] { "Jim", "Anne", "Phil", "Joe" };

            try
            {
                lblDisplayMessage.Text = arrayException[4].ToString();
            }
            catch (IndexOutOfRangeException ex)
            {
                lblDisplayMessage.Text = "Index Out of Range error: " + ex.Message;
            }
            catch (Exception ex)
            {
                lblDisplayMessage.Text = "Generic Error" + ex.Message;
            }
            finally
            {
                lblDisplayMessage.Text = "This errror is being worked on.";
            }
        }
        #endregion
    
    }
}
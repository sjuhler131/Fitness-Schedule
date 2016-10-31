using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VelocityCoders.FitnessSchedule.Models;
using Uhler.Common;
using VelocityCoders.FitnessSchedule.Models.Collections;
using Uhler.Common.Helpers;
using Uhler.Common.Extensions;
using VelocityCoders.FitnessSchedule.Models.Enums;


namespace VelocityCoders.FitnessSchedule.WebForms
{
    public partial class HelloWorld : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            #region String Example
            //this.StringExample();
            #endregion
            #region ArrayExample
            //this.ArrayExample();
            #endregion
            #region Conditional Statements
            //this.ConditionalStatements();
            #endregion
            #region Loops
            //this.Loops();
            #endregion
            #region Person Example
            //this.PersonExample();
            #endregion
            #region Test
            //this.Test();
            #endregion
            #region Collection Example
            //this.CollectionExample();
            #endregion
            #region Exaeptions Example
            //this.ExceptionsExample();
            #endregion
            #region Polymorphism Example
            //this.PolymorphismExample();
            #endregion
            #region Interface Example
            //this.InterfaceExample();
            //Instructor Inst = new Instructor()
            //{
            //    FirstName = "John",
            //    LastName = "Smith",
            //    HireDate = new DateTime(2011, 11, 15)
            //};
            //this.InterfaceExample(Inst);
            #endregion
            #region Instance Example
            //this.StaticExample();
            #endregion
            #region Extension Example
            //this.ExtensionExample1();           
            #endregion
            #region Enumeration Example
           // this.EnumerationExample(); 
            #endregion
        }
        #region StringExample
        private void StringExample()
        {
            string firstName = "Jim";
            string middleName;

            middleName = "Eugene";

            firstName = "James";

            string firstLetter = firstName.Substring(0, 1);

            int myAge = 30;
            DateTime myBirthDate = new DateTime(1990, 4, 1);

            string stringDate = Convert.ToString(myBirthDate);

            StringBuilder sb = new StringBuilder();

            sb.Append("My Name");
            sb.Append(" -- James");

            lblDisplayMessage.Text = sb.ToString();



        }
        #endregion
        #region Array Example
        private void ArrayExample()
        {
            string[] nameList = new string[5];

            nameList[0] = "Andy";
            nameList[1] = "Bob";
            nameList[2] = "Cathy";
            nameList[3] = "Doug";
            nameList[4] = "Ellen";

            int[] ageList = new int[] {50, 21, 15, 40, 10, 40, 50 };

            Array.Sort(ageList);

            lblDisplayMessage.Text = "All Elements = " + string.Join(", ", ageList);
        }
        #endregion
        #region Conditional Statements
        private void ConditionalStatements()
        {
            Boolean isDeleted = true;
            string firstName = "Jane";
            int x = 10;
            string outputMessage;

            outputMessage = (x > 15) ? "Greater than 15" : "Less than 15";  
            
            lblDisplayMessage.Text = outputMessage;
        }
        #endregion
        #region Loops
        private void Loops()
        {
            StringBuilder sb = new StringBuilder();
            #region For Loop
            for (int x = 1; x <= 10; x++)
            {
                sb.Append("Loop Iteration: " + x.ToString() + "<br> ");
            }

            #endregion
            #region For Each Loop

            sb = new StringBuilder();

            string[] namesList = new string[] { "Amy", "Bill", "Michael", "Darin", "Bobby" };
            Array.Sort(namesList);
            foreach (string item in namesList)
            {
                sb.Append("Iteration: " + item + "<br>");
            }
            #endregion
            #region While Loop
            int[] intArray = new int[] { 2, 4, 6, 0, 8, 10, 12 };
            bool keepGoing = true;
            int count = 0;

            sb = new StringBuilder();

            while (keepGoing)
            {
                sb.Append(intArray[count].ToString() + "<br>");
                keepGoing = (intArray[count] == 0) ? false : true;
                count++;
            }

            #endregion
            #region Do Loop

            int y = 0;
            sb = new StringBuilder();

            do
            {
                sb.Append(y.ToString() + "<br>");
                y++;
            } while (y < 5);

            #endregion
            lblDisplayMessage.Text = sb.ToString();
            
        }
        #endregion
        #region PersonExample
        private void PersonExample()
        {
            Person myFriend = new Person("Johnny", "Five", "Male");




            lblDisplayMessage.Text = myFriend.GetName();
        }
        #endregion
        #region Test
        private void Test()
        {
            Email testEmail = new Email();

            testEmail.EmailAddress = "Test123.com";
            testEmail.EmailId = 1;
            testEmail.EntityTypeId = 3;

            lblDisplayMessage.Text = "Email Id: " + testEmail.EmailId + "<br>" + "EntityTypeId: " + testEmail.EntityTypeId + "<br>" + "Email Address: " + testEmail.EmailAddress;
        }
            #endregion
            #region Collection Example
        private void CollectionExample()
        {
            PersonCollection myList = new PersonCollection()
            {
                new Person() { FirstName = "Abby" },
                new Person() { FirstName = "Ben" },
                new Person() { FirstName = "Charlie" },
                new Person() { FirstName = "Debbie" }
            };

            StringBuilder sb = new StringBuilder();

            foreach (Person item in myList)
            {
                sb.Append(item.FirstName + "<br>");
            }
            lblDisplayMessage.Text = sb.ToString();
        }
        #endregion
        #region Exceptions Example
        private void ExceptionsExample()
        {
            string[] myList = new string[] { "Amy", "Bob", "Charlie" };

            lblDisplayMessage.Text = myList[5];

            //try
            //{
            //    lblDisplayMessage.Text = myList[5];
            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    lblDisplayMessage.Text = "Index out of range: " + ex.Message;
            //}
            //catch (Exception ex)
            //{
            //    lblDisplayMessage.Text = "Some generic error: " + ex.Message;
            //}
            //finally
            //{

            //}

        }
        #endregion
        #region Polymorphism Example
        private void PolymorphismExample()
        {
            Person person01 = new Person() { FirstName = "Julie" };
            lblDisplayMessage.Text = person01.GetNameExample();
        }

        private string GetStateName(int stateId)
        {
            string returnValue = string.Empty;

            switch(stateId)
            {
                case 1:
                    returnValue = "Alabama";
                    break;
                case 2:
                    returnValue = "Alaska";
                    break;
            }
            return returnValue;
        }
        private string GetStateName(string stateAbbreviation)
        {
            string returnValue = string.Empty;

            switch (stateAbbreviation.ToUpper())
            {
                case "AZ":
                    returnValue = "Arizona";
                    break;
                case "AL":
                    returnValue = "Alaska";
                    break;
            }
            return returnValue;
        }
        #endregion
        #region Interface Example
        private void InterfaceExample(IPerson person)
        {
            
            lblDisplayMessage.Text = person.GetFullInfo();
        }
        #endregion
        #region Instance Example
        private void StaticExample()
        {
            lblDisplayMessage.Text = VikingsHelper.GetVikingName(72);
        }
        #endregion
        #region Extension Example
        private void ExtensionExample1()
        {
            string myBirthday = "2/1/1990";
            DateTime convertedDate = myBirthday.ToDate();

            string myAge = "20";
            int convertedAge = myAge.ToInt();

            string isTrue = "True";
            Boolean convertedBool = isTrue.ToBool();

            string s = "one two three four five six seven eight nine ten eleven twelve";


            //lblDisplayMessage.Text = s.WordCount().ToString();
            lblDisplayMessage.Text = s.Alphabetize().ToString();

            //lblDisplayMessage.Text = "My Birthdate: " + convertedDate.ToString() + "<br>" + "My Age: " + convertedAge.ToString() + "<br>" + "True: " + convertedBool.ToString();       
        }
        #endregion
        #region Enumeration Example
        private void EnumerationExample()
        {
            //lblDisplayMessage.Text = ((int)DaysEnum.Monday).ToString();
            //lblDisplayMessage.Text = ((int)GetEnum.GET_ITEM).ToString();
            lblDisplayMessage.Text = ExecuteEnum.INSERT_ITEM.ToString();
        }
        #endregion

        
          
        
    }
}
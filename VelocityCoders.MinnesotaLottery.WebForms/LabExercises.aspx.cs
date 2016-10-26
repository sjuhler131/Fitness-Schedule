using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VelocityCoders.FitnessSchedule.WebForms
{
    public partial class LabExercises : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        
        {


            //Call Method Here
            #region DisplayStateLab
            //string States = this.GetStates("State List: ");
            //string Minnesota = this.GetMinnesota("Minnesota", "MN");
            //string Wisconsin = this.GetWisconsin("Wisconsin", "WI");
            //string NewYork = this.GetNewYork("New York", "NY");
            //string Iowa = this.GetIowa("Iowa", "IA");
            //string Alaska = this.GetAlaska("Alaska", "AK");
            //this.DisplayState(DisplayStateId, States + Minnesota + ", " + Wisconsin + ", " + NewYork + ", " + Iowa + " and " + Alaska);
            #endregion
            #region GetStringsLab
            //this.GetStringsLab();
            #endregion
            #region ArrayLab
            //this.ArrayLab();
            #endregion
            #region ConditionalLab
            //this.ConditionalLab();
            #endregion
            #region LoopLab
            this.LoopLab();
            #endregion
            this.ConditionalLab();
        }
        //Put Methods Below Here
        #region DisplayStateLab
        private void DisplayStateLab(Label labelControl, string displayStuff)
        {
            labelControl.Text = displayStuff;
        }


        private string GetMinnesota(string stateName, string stateAbbreviation)
        {
            string getMinnesota = stateName + " " + stateAbbreviation;

            return getMinnesota;
        }

        private string GetWisconsin(string stateName, string stateAbbreviation)
        {
            string getWisconsin = stateName + " " + stateAbbreviation;

            return getWisconsin;
        }

        private string GetNewYork(string stateName, string stateAbbreviation)
        {
            string getNewYork = stateName + " " + stateAbbreviation;

            return getNewYork;
        }

        private string GetIowa(string stateName, string stateAbbreviation)
        {
            string getIowa = stateName + " " + stateAbbreviation;

            return getIowa;
        }
           private string GetAlaska(String stateName, string stateAbbreviation)
        {
            string GetAlaska = stateName + " " + stateAbbreviation;

            return GetAlaska;
        }
        private string GetStates(string words)
        {
            string GetStates = words;

            return GetStates;
        }
        #endregion
        #region GetStringsLab
        private void GetStringsLab()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("My Name Is ");
            sb.Append("Jim ");
            int VikingsWins = 5;
            int VikingsLosses = 0;
            DateTime NextGame = new DateTime(2016, 10, 10);
            DateTime LastGame = new DateTime(2016, 10, 23);
            String Coach = "Mike Zimmer";
            String Quarterback = "Sam Bradford";
            sb.Append(" My Age Is 45");
            //lblDisplayMessage.Text = "This is the Next Game: " + NextGame.ToShortDateString() + "<br>" + " This is the Last Game " + LastGame.ToString();
            //lblDisplayMessage.Text = "These are the wins: " + VikingsWins + "<br>" + "These are the losses: " + VikingsLosses;
            //lblDisplayMessage.Text = "Coach name yelled: " + Coach.ToUpper() + "<br>" + "Coach wispered: " + Coach.ToLower() + "<br> " + "Length of Quarterback's name including space: " + Quarterback.Length;
            //lblDisplayMessage.Text = sb.ToString();       
        }
        #endregion
        #region ArrayLab
        private void ArrayLab()
        {
            string[] footballTeams = new string[5];

            footballTeams[0] = "Vikings";
            footballTeams[1] = "Packers";
            footballTeams[2] = "Giants";
            footballTeams[3] = "Dolphins";
            footballTeams[4] = "Browns";
            #region Array Lab 1.
            //lblDisplayMessage.Text = "Football Team List: " + string.Concat(footballTeams);

            string terribleTeam = footballTeams[4];
            string goodTeam = footballTeams[0];
            #endregion
            #region Array Lab 3.   
            //lblDisplayMessage.Text = "This team is awful... seriously: " + terribleTeam;
            //lblDisplayMessage.Text = "This team is doing OK, but will probably let us down as usual: " + goodTeam;
            #endregion
            #region Array Lab 2.
            int[] rushingYards = new int[5] { 5, 12, 6, 3, -1 };
            //lblDisplayMessage.Text = "Rushing Yards: " + string.Join(", ", rushingYards);
            #endregion
            #region Array Lab 3. (cont)
            int thirdDownRushing = rushingYards[2];
            // lblDisplayMessage.Text = "Third down rushing yards: " + thirdDownRushing;
            #endregion
            #region Array Lab 4.
            Array.Sort(rushingYards);
            //lblDisplayMessage.Text = "Rushing Yards Sorted: " + string.Join(", ", rushingYards);
            Array.Sort(footballTeams);
            //lblDisplayMessage.Text = "Football Teams Sorted: " + string.Join(", ", footballTeams);
            #endregion
        }

        #endregion
        #region ConditionalLab

        private void ConditionalLab()
        {
            #region Lab 1.
            //int totalVotes = 122;
            //int totalVoters = 120;
            //string outputMessage = string.Empty;

            //if (totalVotes == totalVoters)
            //{
            //    outputMessage = "Everyone voted!";
            //}
            //else if (totalVotes > totalVoters)
            //{
            //    outputMessage = "Something's fishy here...";
            //}
            //else if (totalVotes < totalVoters)
            //{
            //    outputMessage = "Not everyone voted";
            //}

            //lblDisplayMessage.Text = outputMessage;
            #endregion
            #region Lab 2.
            //string firstName = "Kermit";
            //string lastName = "The Frog";
            //string outputmessage = string.Empty;

            //if (firstName == "Kermit" && lastName == "The Frog")
            //{
            //    outputMessage = "You might be a frog...";
            //}
            //else if (firstName == "Yogi" && lastName == "Bear")
            //{
            //    outputMessage = "You might be a bear...";
            //}
            //else
            //{
            //    outputMessage = "You might not be a cartoon character";
            //}
            //    lblDisplayMessage.Text = outputMessage;
            #endregion
            #region Lab 3/4.
            //DateTime birthDate = new DateTime(1985, 12, 10);
            //DateTime deathDate = new DateTime(1995, 1, 11);
            //DateTime thisDay = DateTime.Today;
            //string outputMessage = string.Empty;

            //if (birthDate <= thisDay && deathDate > thisDay)
            //{
            //    outputMessage = "Congrats! You're alive!";
            //}
            //else if (birthDate > thisDay || deathDate <= thisDay)
            //{
            //    outputMessage = "You're not currently living";
            //}
            //lblDisplayMessage.Text = outputMessage;

            #endregion
            #region Lab 5.

            //int tireAmount = 2;
            //string outputMessage;

            //outputMessage = (tireAmount > 2) ? "It is a car or truck" : "It is a Motorcycle or Bike";

            //lblDisplayMessage.Text = outputMessage;

            #endregion
            #region Lab 6.
            //string emailAddress = null;
            //string outputMessage;

            //outputMessage = emailAddress ?? "They don't have an Email Address.";

            //lblDisplayMessage.Text = outputMessage;
            #endregion
            #region Lab 7.
            int beardLength = 1;
            string outputMessage = string.Empty;

            switch (beardLength) //<--in centimeters
            {
                case 0:
                    outputMessage = "Babyfaced";
                    break;
                case 1:
                case 2:
                case 3:
                    outputMessage = "Bestubbled";
                    break;
                case 4:
                case 5:
                case 6:
                    outputMessage = "Grizzled";
                    break;
                case 7:
                case 8:
                case 9:
                    outputMessage = "Viking";
                    break;
                case 10:
                case 11:
                case 12:
                    outputMessage = "Wizard";
                    break;
                default:
                    outputMessage = "ZZ Top";
                    break;
            }

            lblDisplayMessage.Text = outputMessage;
            #endregion
            #region Lab 8.
            //string userInput = txtTargetFish.Text;
            //string outputMessage = string.Empty;

            //switch (userInput.ToUpper())
            //{
            //    case "SUNFISH":
            //        outputMessage = "Waxworms and a small jig";
            //        break;
            //    case "CRAPPIE":
            //        outputMessage = "Jig and a minnow";
            //        break;
            //    case "BASS":
            //        outputMessage = "Crankbaits or frogs";
            //        break;
            //    case "NORTHERN PIKE":
            //    case "WALLEYE":
            //        outputMessage = "Spinners, lindy-rigs, leeches and nightcrawlers";
            //        break;
            //    case "TROUT":
            //        outputMessage = "Try flyfishing";
            //        break;
            //    case "CARP":
            //        outputMessage = "Wad of bread and a big hook";
            //        break;
            //    default:
            //        outputMessage = "Try your own method because I don't know.";
            //        break;
            //}
            //lblDisplayMessage.Text = "To catch your fish: " + userInput + " - " + outputMessage;
            #endregion
        }
        #endregion
        #region LoopLab
        private void LoopLab()
        {
            #region Lab 1.
            //StringBuilder sb = new StringBuilder();

            //for (int x = 100; x > 90; x--)
            //{
            //    sb.Append(x.ToString() + "<br>");
            //}
            #endregion
            #region Lab 2.
            //string[] stateName = new string[] { "Alabama,", "Alaska,", "Arkansas,", "and", "Arizona" };
            //sb = new StringBuilder();
            //foreach(string item in stateName)
            //{
            //    sb.Append(item + "<br>");
            //}
            #endregion
            #region Lab 3.

            //int[] daysInOctober = new int[] { 111, 15, 30, 12, 44, 99, 14, 5, 6, 9, 2, 31, 32, 68 };
            //bool keepGoing= true;
            //int count = 0;
            //StringBuilder sb = new StringBuilder();
            //Array.Sort(daysInOctober);
            //while (keepGoing)
            //{
            //    sb.Append(daysInOctober[count].ToString() + "<br>");
            //    keepGoing = (daysInOctober[count] == 31) ? false : true;
            //    count++;
            //}
            #endregion
            #region Lab 5.
            StringBuilder sb = new StringBuilder();
            int x = 100;

            do
            {
                sb.Append(x.ToString() + "<br>");
                x--;
            } while (x >= 90);

            #endregion
            lblDisplayMessage.Text = sb.ToString();
        }
        
        #endregion
    }
}


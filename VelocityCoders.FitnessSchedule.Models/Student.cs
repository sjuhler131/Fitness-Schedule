using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VelocityCoders.FitnessSchedule.Models
{
    public class Student : Person, IPerson
    {
        public DateTime JoinDate { get; set; }


        public string GetFullInfo()
        {
            return "Student " + this.Name + " : " + this.JoinDate.ToShortDateString();
        }

        public Student()
        {
        }
        public override string Name
        {
            get
            {
                return base.FirstName + " " + base.LastName;
            }
        }
    }
}

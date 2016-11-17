using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uhler.Common;
using VelocityCoders.FitnessSchedule.Models;

namespace VelocityCoders.FitnessSchedule.Models
{
    public class Person : BaseEntity<int>
    {
      

        public Person(string firstName, string lastName, string gender, DateTime birthDate)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Gender = gender;
            this.BirthDate = birthDate;
        }
        public Person()
        {
        }

        public override string GetNameExample()
        {
            return "Return value from the Person Class";
        }

        public override string Name
        {
            get
            {
                return "Name From Subclass";
            }
        }
        public override string GetName()
        {
            return "Name From Subclass: " + this.FirstName + " " + this.LastName;
        }

        public int      PersonId { get; set; }
        public string   FirstName { get; set; }
        public string   LastName { get; set; }
        public string   DisplayFirstName { get; set; }
        public string   Gender { get; set; }
        public DateTime BirthDate { get; set; }


    }
}


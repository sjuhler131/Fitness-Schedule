using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VelocityCoders.FitnessSchedule.Models;
using Uhler.Common;
using VelocityCoders.FitnessSchedule.Models.Collections;


namespace VelocityCoders.FitnessSchedule.Models
{
    public class Instructor : Person, IPerson
    {
        public Instructor(DateTime hireDate, DateTime termDate, DateTime createDate, string description)
        {
            this.HireDate = hireDate;
            this.TermDate = termDate;
            this.CreateDate = createDate;
            this.Description = description;
        }

        public int InstructorId { get; set; }
        public int EntityTypeId { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime TermDate { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; } 

        //public Instructor()
        //{
        //    //notes: default constructor
        //}

        public EmailAddressCollection Emails { get; set; }
        

        public Instructor()
        {
            this.Emails = new EmailAddressCollection();            
        }
        
        
        public override string Name
        {
            get
            {
                return base.FirstName + " " + base.LastName;
            }
        }
        public string GetFullInfo()
        {
            return "Instructor " + this.Name + " : " + this.HireDate.ToShortDateString();
        }
    }
}

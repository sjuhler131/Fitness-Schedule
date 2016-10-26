using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VelocityCoders.FitnessSchedule.Models;
using Uhler.Common;
namespace VelocityCoders.FitnessSchedule.Models
{
    public class Email /*: BaseEntity<int>*/
    {
        public Email(string emailAddress)
        {
            this.EmailAddress = emailAddress;
        }
        public int EmailId { get; set; }
        public string EmailAddress { get; set; }
        public int InstructorId { get; set; }
        public int EntityTypeId { get; set; }

        public Email()
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VelocityCoders.FitnessSchedule.Models;
using Uhler.Common;
namespace VelocityCoders.FitnessSchedule.Models
{
    public class EmailAddress /*: BaseEntity<int>*/
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public EmailAddress()
        {
            this.EmailType = new EntityType();            
        }

        /// <summary>
        /// Constructor for Email object.
        /// </summary>
        /// <param name="personID"></param>
        /// <param name="entityTypeId"></param>
        /// <param name="emailAddress"></param>
        public EmailAddress(int entityTypeId, string emailAddress) : this()
        {
            EmailType = new EntityType { EntityTypeId = entityTypeId };
            EmailValue =  emailAddress;      
        }


        //public EmailAddress(string emailAddress)
        //{
        //    this.EmailValue = emailAddress;
        //}

        public int EmailId { get; set; }
        public string EmailValue { get; set; }
        public EntityType EmailType { get; set; }
        public int InstructorId { get; set; }
        public int EntityTypeId { get; set; }

        public EmailAddress(int instructorId)
        {

        }
       
    }
}

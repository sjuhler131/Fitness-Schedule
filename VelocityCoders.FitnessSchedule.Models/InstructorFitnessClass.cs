using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uhler.Common;

namespace VelocityCoders.FitnessSchedule.Models
{
    public class InstructorFitnessClass /*: BaseEntity<int>*/
    {
        public InstructorFitnessClass(string description)
        {
            this.Description = description;
        }
        public int InstructorFitnessClassId { get; set; }
        public int FitnessClassId { get; set; }
        public int InstructorId { get; set; }
        public string Description { get; set; }

        public InstructorFitnessClass()
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uhler.Common;

namespace VelocityCoders.FitnessSchedule.Models
{
   public class FitnessClass /*: BaseEntity<int>*/
    {
        public FitnessClass(string description)
        {
            this.Description = description;
        }
        public int FitnessClassId { get; set; }
        public string FitnessClassName { get; set; }
        public string Description { get; set; }

        public FitnessClass()
        {
        }
    }
}

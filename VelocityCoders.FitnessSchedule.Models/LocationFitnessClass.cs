using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uhler.Common;

namespace VelocityCoders.FitnessSchedule.Models
{
    class LocationFitnessClass /*: BaseEntity<int>*/
    {
        public LocationFitnessClass(string description)
        {
            this.Description = description;
        }
        public int FitnessClassId { get; set; }
        public int LocationId { get; set; }
        public int LocationFitnessClassId { get; set; }
        public string Description { get; set; }

        public LocationFitnessClass()
        {
        }
    }
}

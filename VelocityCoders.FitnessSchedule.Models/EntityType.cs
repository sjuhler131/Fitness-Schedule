using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VelocityCoders.FitnessSchedule.Models;
using Uhler.Common;

namespace VelocityCoders.FitnessSchedule.Models
{
    public class EntityType /*: BaseEntity<int>*/
    {
        public EntityType(string entityTypeName, string displayName, string description)
        {
            this.EntityTypeName = entityTypeName;
            this.DisplayName = displayName;
            this.Description = description;
        }
        public int EntityTypeId { get; set; }
        public string EntityTypeName { get; set; }
        public int EntityId { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }

        public EntityType()
        {
        }
    }
}

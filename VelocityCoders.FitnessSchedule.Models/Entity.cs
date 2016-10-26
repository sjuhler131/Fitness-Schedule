using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uhler.Common;
namespace VelocityCoders.FitnessSchedule.Models
{
    public class Entity /*: BaseEntity<int>*/
    {
        public Entity(string entityName, string description, string displayName)
        {
            this.EntityName = entityName;
            this.Description = description;
            this.DisplayName = displayName;
        }
        public int EntityId { get; set; }
        public string EntityName { get; set; }
        public string Description { get; set; }
        public string DisplayName { get; set; }

        public Entity()
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VelocityCoders.FitnessSchedule.Models.Enums
{
    public enum ExecuteEnum
    {
        None        = 0,
        INSERT_ITEM = 10,
        UPDATE_ITEM = 20,
        DELETE_ITEM = 30,
        DELETE_COLLECTION_BY_INSTRUCTOR = 31
    }
}

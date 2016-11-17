using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VelocityCoders.FitnessSchedule.Models;
using VelocityCoders.FitnessSchedule.DAL;


namespace VelocityCoders.FitnessSchedule.BLL
{
    public static class PersonManager
    {
        public static int Save(Person personToSave)
        {
            int returnValue;
            returnValue = PersonDAL.Save(personToSave);

                return returnValue;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VelocityCoders.FitnessSchedule.Models.Collections;
using VelocityCoders.FitnessSchedule.Models;
using VelocityCoders.FitnessSchedule.DAL;

namespace VelocityCoders.FitnessSchedule.BLL
{
    public static class InstructorManager
    {

        #region INSERT and UPDATE

        public static int Save(Instructor instructorToSave)
        {
            int personId = SavePerson(instructorToSave);
            instructorToSave.PersonId = personId;

            //notes: call DAL to save
            return InstructorDAL.Save(instructorToSave);
        }

        #endregion

        private static int SavePerson(Instructor instructorToSave)
        {
            Person tempPerson = new Person();
            tempPerson.PersonId = instructorToSave.PersonId;

            tempPerson.FirstName = instructorToSave.FirstName;
            tempPerson.LastName = instructorToSave.LastName;
            tempPerson.DisplayFirstName = instructorToSave.DisplayFirstName;
            tempPerson.BirthDate = instructorToSave.BirthDate;
            tempPerson.Gender = instructorToSave.Gender;

            return PersonManager.Save(tempPerson);
        }

        public static InstructorCollection GetCollection()
        {
            return InstructorDAL.GetCollection();
        }

        public static Instructor GetItem(int instructorId)
        {
            return InstructorDAL.GetItem(instructorId);
        }
    }
}

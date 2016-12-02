using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VelocityCoders.FitnessSchedule.Models;
using VelocityCoders.FitnessSchedule.Models.Collections;
using VelocityCoders.FitnessSchedule.DAL;

namespace VelocityCoders.FitnessSchedule.BLL
{
    public static class EmailAddressManager
    {
        #region SELECT
        /// <summary>
        /// Gets single email address.
        /// </summary>
        /// <param name="emailId"></param>

        public static EmailAddress GetItem(int emailId)
        {
            return EmailAddressDAL.GetItem(emailId);
        }

        /// <summary>
        /// Gets a collection of emails filtered by instructor.
        /// </summary>
        /// <param name="instructorId"></param>
        /// <returns></returns>
        public static EmailAddressCollection GetCollection(int instructorId)
        {
            return EmailAddressDAL.GetCollection(instructorId);
        }
        #endregion

        #region INSERT, UPDATE
     
        public static int Save(int instructorId, EmailAddress emailToSave)
        {
            return EmailAddressDAL.Save(instructorId, emailToSave);
        }       
        #endregion


        #region DELETE

        public static bool Delete(int emailId)
        {
            return EmailAddressDAL.Delete(emailId);
        }

        #endregion
    }
}

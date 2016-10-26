using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using VelocityCoders.FitnessSchedule.Models;
using VelocityCoders.FitnessSchedule.Models.Collections;
using VelocityCoders.FitnessSchedule.Models.Enums;
using Uhler.Common;



namespace VelocityCoders.FitnessSchedule.DAL
{
    public class EmailDAL
    {
        public static EmailCollection GetCollection()
        {
            EmailCollection tempList = null;

            using (SqlConnection myConnection = new SqlConnection(AppConfiguration.ConnectionString))
            {
                using (SqlCommand myCommand = new SqlCommand("usp_GetEmail", myConnection))
                {
                    myCommand.CommandType = CommandType.StoredProcedure;

                    myCommand.Parameters.AddWithValue("@QueryId", SelectTypeEnum.GetCollection);

                    myConnection.Open();
                    using (SqlDataReader myReader = myCommand.ExecuteReader())
                    {
                        if (myReader.HasRows)
                        {
                            tempList = new EmailCollection();
                            while (myReader.Read())
                            {
                                tempList.Add(FillDataRecord(myReader));
                            }
                        }
                        myReader.Close();
                    }
                }
            }
            return tempList;
        }

        private static Email FillDataRecord(IDataRecord myDataRecord)
        {
            Email myObject = new Email();

            myObject.EmailId = myDataRecord.GetInt32(myDataRecord.GetOrdinal("EmailId"));

            if (!myDataRecord.IsDBNull(myDataRecord.GetOrdinal("EmailAddress")))
                myObject.EmailAddress = myDataRecord.GetString(myDataRecord.GetOrdinal("EmailAddress"));

            if (!myDataRecord.IsDBNull(myDataRecord.GetOrdinal("EntityTypeId")))
                myObject.EntityTypeId = myDataRecord.GetInt32(myDataRecord.GetOrdinal("EntityTypeId"));

            if (!myDataRecord.IsDBNull(myDataRecord.GetOrdinal("InstructorId")))
                myObject.InstructorId = myDataRecord.GetInt32(myDataRecord.GetOrdinal("InstructorId"));

            return myObject;
        }
    }
}
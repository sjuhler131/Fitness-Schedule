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
    public class InstructorFitnessClassDAL
    {
        public static InstructorFitnessClassCollection GetCollection()
        {
            InstructorFitnessClassCollection tempList = null;

            using (SqlConnection myConnection = new SqlConnection(AppConfiguration.ConnectionString))
            {
                using (SqlCommand myCommand = new SqlCommand("usp_GetInstructorFitnessClass", myConnection))
                {
                    myCommand.CommandType = CommandType.StoredProcedure;

                    myCommand.Parameters.AddWithValue("@QueryId", SelectTypeEnum.GetCollection);

                    myConnection.Open();
                    using (SqlDataReader myReader = myCommand.ExecuteReader())
                    {
                        if (myReader.HasRows)
                        {
                            tempList = new InstructorFitnessClassCollection();
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

        private static InstructorFitnessClass FillDataRecord(IDataRecord myDataRecord)
        {
            InstructorFitnessClass myObject = new InstructorFitnessClass();

            myObject.InstructorFitnessClassId = myDataRecord.GetInt32(myDataRecord.GetOrdinal("InstructorFitnessClassId"));

            if (!myDataRecord.IsDBNull(myDataRecord.GetOrdinal("FitnessClassId")))
                myObject.FitnessClassId = myDataRecord.GetInt32(myDataRecord.GetOrdinal("FitnessClassId"));

            if (!myDataRecord.IsDBNull(myDataRecord.GetOrdinal("InstructorId")))
                myObject.InstructorId = myDataRecord.GetInt32(myDataRecord.GetOrdinal("InstructorId"));

            if (!myDataRecord.IsDBNull(myDataRecord.GetOrdinal("Description")))
                myObject.Description = myDataRecord.GetString(myDataRecord.GetOrdinal("Description"));

            return myObject;
        }
    }
}
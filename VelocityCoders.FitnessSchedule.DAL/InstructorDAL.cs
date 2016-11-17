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
    public static class InstructorDAL
    {
        public static InstructorCollection GetCollection()
        {
            InstructorCollection tempList = null;

            using (SqlConnection myConnection = new SqlConnection(AppConfiguration.ConnectionString))
            {
                using (SqlCommand myCommand = new SqlCommand("usp_GetInstructor", myConnection))
                {
                    myCommand.CommandType = CommandType.StoredProcedure;

                    myCommand.Parameters.AddWithValue("@QueryId", SelectTypeEnum.GetCollection);

                    myConnection.Open();
                    using (SqlDataReader myReader = myCommand.ExecuteReader())
                    {
                        if (myReader.HasRows)
                        {
                            tempList = new InstructorCollection();
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

        public static Instructor GetItem(int instructorId)
        {
            Instructor tempItem = null;

            using (SqlConnection myConnection = new SqlConnection(AppConfiguration.ConnectionString))
            {
                using (SqlCommand myCommand = new SqlCommand("usp_GetInstructor", myConnection))
                {
                    myCommand.CommandType = CommandType.StoredProcedure;

                    myCommand.Parameters.AddWithValue("@QueryId", SelectTypeEnum.GetItem);
                    myCommand.Parameters.AddWithValue("@InstructorId", instructorId);

                    myConnection.Open();
                    using (SqlDataReader myReader = myCommand.ExecuteReader())
                    {
                        if (myReader.Read())
                        {
                            tempItem = FillDataRecord(myReader);
                        }
                        myReader.Close();
                    }
                }
            }
            return tempItem;
        }

        private static Instructor FillDataRecord(IDataRecord myDataRecord)
        {
            Instructor myObject = new Instructor();

            myObject.InstructorId = myDataRecord.GetInt32(myDataRecord.GetOrdinal("InstructorId"));
            myObject.PersonId = myDataRecord.GetInt32(myDataRecord.GetOrdinal("PersonId"));

            if (!myDataRecord.IsDBNull(myDataRecord.GetOrdinal("FirstName")))
                myObject.FirstName = myDataRecord.GetString(myDataRecord.GetOrdinal("FirstName"));

            if (!myDataRecord.IsDBNull(myDataRecord.GetOrdinal("LastName")))
                myObject.LastName = myDataRecord.GetString(myDataRecord.GetOrdinal("LastName"));

            if (!myDataRecord.IsDBNull(myDataRecord.GetOrdinal("DisplayFirstName")))
                myObject.DisplayFirstName = myDataRecord.GetString(myDataRecord.GetOrdinal("DisplayFirstName"));

            if (!myDataRecord.IsDBNull(myDataRecord.GetOrdinal("Gender")))
                myObject.Gender = myDataRecord.GetString(myDataRecord.GetOrdinal("Gender"));

            //notes: instructor specific properties

            if (!myDataRecord.IsDBNull(myDataRecord.GetOrdinal("EmployeeTypeId")))
                myObject.EntityTypeId = myDataRecord.GetInt32(myDataRecord.GetOrdinal("EmployeeTypeId"));

            //if (!myDataRecord.IsDBNull(myDataRecord.GetOrdinal("HireDate")))
            //    myObject.HireDate = myDataRecord.GetDateTime(myDataRecord.GetOrdinal("HireDate"));

            if (!myDataRecord.IsDBNull(myDataRecord.GetOrdinal("TermDate")))
                myObject.TermDate = myDataRecord.GetDateTime(myDataRecord.GetOrdinal("TermDate"));

            if (!myDataRecord.IsDBNull(myDataRecord.GetOrdinal("Description")))
                myObject.Description = myDataRecord.GetString(myDataRecord.GetOrdinal("Description"));

            return myObject;
        }

        public static int Save(Instructor instructorToSave)
        {
            int result = 0;
            ExecuteEnum queryId = ExecuteEnum.INSERT_ITEM;

            //notes: check for valid PersonId - if exists, UPDATE, else INSERT
            // 10 = INSERT_ITEM
            // 20 = UPDATE_ITEM

            if (instructorToSave.InstructorId > 0)
                queryId = ExecuteEnum.UPDATE_ITEM;

            using (SqlConnection myConnection = new SqlConnection(AppConfiguration.ConnectionString))
            {
                using (SqlCommand myCommand = new SqlCommand("usp_ExecuteInstructor", myConnection))
                {
                    myCommand.CommandType = CommandType.StoredProcedure;

                    myCommand.Parameters.AddWithValue("@QueryId", queryId);
                    myCommand.Parameters.AddWithValue("@InstructorId", instructorToSave.InstructorId);
                    myCommand.Parameters.AddWithValue("@PersonId", instructorToSave.PersonId);

                    if (instructorToSave.HireDate != DateTime.MinValue)
                        myCommand.Parameters.AddWithValue("@HireDate", instructorToSave.HireDate.ToShortDateString());

                    if (instructorToSave.TermDate != DateTime.MinValue)
                        myCommand.Parameters.AddWithValue("@TermDate", instructorToSave.TermDate.ToShortDateString());

                    if (instructorToSave.Description != null)
                        myCommand.Parameters.AddWithValue("@Description", instructorToSave.Description);

                    //notes: add return output parameter to command object

                    myCommand.Parameters.Add(HelperDAL.GetReturnParameterInt("ReturnValue"));

                    myConnection.Open();
                    myCommand.ExecuteNonQuery();
                   
                    result = (int)myCommand.Parameters["@ReturnValue"].Value;
                }

                myConnection.Close();
            }
            return result;
        }
    }
}
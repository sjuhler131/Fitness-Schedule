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
    public class PersonDAL
    {
        public static PersonCollection GetCollection()
        {
            PersonCollection tempList = null;

            using (SqlConnection myConnection = new SqlConnection(AppConfiguration.ConnectionString))
            {
                using (SqlCommand myCommand = new SqlCommand("usp_GetPerson", myConnection))
                {
                    myCommand.CommandType = CommandType.StoredProcedure;

                    myCommand.Parameters.AddWithValue("@QueryId", SelectTypeEnum.GetCollection);

                    myConnection.Open();
                    using (SqlDataReader myReader = myCommand.ExecuteReader())
                    {
                        if (myReader.HasRows)
                        {
                            tempList = new PersonCollection();
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

        public static Person GetItem(int personId)
        {
            Person tempItem = null;

            using (SqlConnection myConnection = new SqlConnection(AppConfiguration.ConnectionString))
            {
                using (SqlCommand myCommand = new SqlCommand("usp_GetPerson", myConnection))
                {
                    myCommand.CommandType = CommandType.StoredProcedure;

                    myCommand.Parameters.AddWithValue("@QueryId", SelectTypeEnum.GetItem);
                    myCommand.Parameters.AddWithValue("@PersonId", personId);

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

        public static bool Delete(int personId)
        {
            int result = 0;
            using (SqlConnection myConnection = new SqlConnection(AppConfiguration.ConnectionString))
            {
                using (SqlCommand myCommand = new SqlCommand("usp_ExecutePerson", myConnection))
                {
                    myCommand.CommandType = CommandType.StoredProcedure;
                    myCommand.Parameters.AddWithValue("@QueryId", ExecuteEnum.DELETE_ITEM);
                    myCommand.Parameters.AddWithValue("@PersonId", personId);

                    myConnection.Open();
                    result = myCommand.ExecuteNonQuery();
                }
                myConnection.Close();
            }
            return result > 0;
        }

        private static Person FillDataRecord(IDataRecord myDataRecord)
        {
            Person myObject = new Person();

            myObject.PersonId = myDataRecord.GetInt32(myDataRecord.GetOrdinal("PersonId"));

            if (!myDataRecord.IsDBNull(myDataRecord.GetOrdinal("FirstName")))
                myObject.FirstName = myDataRecord.GetString(myDataRecord.GetOrdinal("FirstName"));

            if (!myDataRecord.IsDBNull(myDataRecord.GetOrdinal("LastName")))
                myObject.LastName = myDataRecord.GetString(myDataRecord.GetOrdinal("LastName"));

            if (!myDataRecord.IsDBNull(myDataRecord.GetOrdinal("DisplayFirstName")))
                myObject.DisplayFirstName = myDataRecord.GetString(myDataRecord.GetOrdinal("DisplayFirstName"));

            if (!myDataRecord.IsDBNull(myDataRecord.GetOrdinal("Gender")))
                myObject.Gender = myDataRecord.GetString(myDataRecord.GetOrdinal("Gender"));

            return myObject;
        }

        public static int Save(Person personToSave)
        {
            int result = 0;
            ExecuteEnum queryId = ExecuteEnum.INSERT_ITEM;

            //Notes: Check for valid PersonId - if exists then UPDATE, else INSERT
            //          10 = INSERT_ITEM
            //          20 = UPDATE_ITEM
            if (personToSave.PersonId > 0)
                queryId = ExecuteEnum.UPDATE_ITEM;

            using (SqlConnection myConnection = new SqlConnection(AppConfiguration.ConnectionString))
            {
                using (SqlCommand myCommand = new SqlCommand("usp_ExecutePerson", myConnection))
                {
                    myCommand.CommandType = CommandType.StoredProcedure;

                    myCommand.Parameters.AddWithValue("@QueryId", queryId);

                    if (personToSave.PersonId > 0)
                        myCommand.Parameters.AddWithValue("@PersonId", personToSave.PersonId);

                    if (personToSave.FirstName != null)
                        myCommand.Parameters.AddWithValue("@FirstName", personToSave.FirstName);

                    if (personToSave.LastName != null)
                        myCommand.Parameters.AddWithValue("@LastName", personToSave.LastName);

                    if (personToSave.DisplayFirstName != null)
                        myCommand.Parameters.AddWithValue("@DisplayFirstName", personToSave.DisplayFirstName);

                    if (personToSave.Gender != null)
                        myCommand.Parameters.AddWithValue("@Gender", personToSave.Gender);

                    if (personToSave.BirthDate != DateTime.MinValue)
                        myCommand.Parameters.AddWithValue("@BirthDate", personToSave.BirthDate.ToShortDateString());

                    //notes: add return output parameter to command object
                    myCommand.Parameters.Add(HelperDAL.GetReturnParameterInt("ReturnValue"));

                    myConnection.Open();
                    myCommand.ExecuteNonQuery();

                    //notes: get return value from stored procedure andreturn Id
                    result = (int)myCommand.Parameters["@ReturnValue"].Value;
                }
                myConnection.Close();
            }
            return result;
        }
    }
}
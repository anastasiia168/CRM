using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Api.data
{
    public class DataSource
    {
        SqlCommand cmnd;
        string cmndt;
        string[] fieldHuman = { "Name", "SName", "Age", "Sity", "Wages" };
        public List<Person> GetSQL(string command, int id, Person _person, string[] changeField)
        {
            switch (command)
            {
                case "GET":
                    cmnd = new SqlCommand("SELECT * From Human", connection);
                    return ListOfAll(cmnd);
                case "GET/id":
                    cmnd = new SqlCommand("SELECT * FROM Human Where id =" + id, connection);
                    return ListOfAll(cmnd);
                case "SORT":
                    cmndt = "SELECT * FROM Human ORDER BY ";
                    for (int i = 0; i < changeField.Length; i++)
                    {
                        cmndt += changeField[i] + " ";
                        if (i < changeField.Length - 1)
                        {
                            if (i % 2 != 0)
                            {
                                cmndt += ", ";
                            }
                        }
                    }
                    cmnd = new SqlCommand(cmndt, connection);
                    return ListOfAll(cmnd);
                case "FILTR":
                    cmndt = "SELECT * FROM Human WHERE ";
                    for (int i = 0; i < changeField.Length; i ++)
                    {
                        if (i % 2 == 0)
                        {
                            cmndt += changeField[i];
                        }
                        else
                        {
                            cmndt += "'" + changeField[i] + "'";
                            if (i <changeField.Length - 1)
                            {
                                cmndt += " AND ";
                            }
                        }
      
                    }
                    //cmndt = "SELECT * FROM Human WHERE Name='Mariia'";
                    cmnd = new SqlCommand(cmndt, connection);
                    return ListOfAll(cmnd);
                case "DELETE":
                    cmnd = new SqlCommand("DELETE FROM Human WHERE id =" + id, connection);
                    return DeleteElement(cmnd);
                case "INSERT":
                    cmnd = new SqlCommand("INSERT INTO Human " +
                        "(Name, SName, Age, Sity, Wages) " +
                        "VALUES ('" +
                        _person.Name + "', '"
                        + _person.SName + "', '"
                        + _person.Age + "', '"
                        + _person.Sity + "', '"
                        + _person.Wages + "')",
                        connection);
                    return InsertElement(cmnd);
                case "UPDATE":
                    cmndt = "UPDATE Human SET ";
                    for (int i = 0; i < fieldHuman.Length; i++)
                    {
                        if (changeField[i] != "")
                        {
                            cmndt += fieldHuman[i] + "= '" + changeField[i] + "'";
                            if (i < fieldHuman.Length - 1)
                            {
                                cmndt += ", ";
                            }
                        }
                    }
                    
                    cmnd = new SqlCommand(cmndt + " Where id = " + id, connection);
                    return UpdateElement(cmnd);
            }
            return null;
        }


       

        private List<Person> UpdateElement(SqlCommand cmnd)
        {
            connection.Open();
            cmnd.ExecuteNonQuery();
            connection.Close();
            cmnd = new SqlCommand("SELECT * From Human", connection);
            return ListOfAll(cmnd);
        }

        private List<Person> InsertElement(SqlCommand cmnd)
        {
            connection.Open();
            cmnd.ExecuteNonQuery();
            connection.Close();
            cmnd = new SqlCommand("SELECT * From Human", connection);
            return ListOfAll(cmnd);
        }

        private List<Person> DeleteElement(SqlCommand cmnd)
        {
            connection.Open();
            cmnd.ExecuteNonQuery();
            connection.Close();
            cmnd = new SqlCommand("SELECT * From Human", connection);
            return ListOfAll(cmnd);
        }

        List<Person> ListOfAll(SqlCommand cmnd)
        {
            List<Person> persons = new List<Person>();
            connection.Open();
            SqlDataReader reader = cmnd.ExecuteReader();
            while (reader.Read())
            {
                Person _person = new Person(
                        Convert.ToInt32(reader["id"]),
                        Convert.ToString(reader["Name"]),
                        Convert.ToString(reader["SName"]),
                        Convert.ToInt32(reader["Age"]),
                        Convert.ToString(reader["Sity"]),
                        Convert.ToInt32(reader["Wages"])
                    );
                persons.Add(_person);
            }
            connection.Close();
            return persons;
        }



    }
}

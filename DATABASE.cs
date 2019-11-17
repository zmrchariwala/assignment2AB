using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace Assignment2ab
{
    public class DATABASE
    {
        private static string User { get { return "humber_student"; } }
        private static string Password { get { return "humberisgreat123"; } }
        private static string Database { get { return "humber_school"; } }
        private static string Server { get { return "107.180.41.170"; } }
        private static string Port { get { return "3306"; } }

        private static string ConnectionString
        {
            get
            {
                return "server = " + Server
                    + "; user = " + User
                    + "; database = " + Database
                    + "; port = " + Port
                    + "; password = " + Password;
            }
        }

        public List<Dictionary<string,string>> showdata(string query)
        {
            //This is the connection string used for connect with the database on cloud with IP address 107.180.41.170
            MySqlConnection connect = new MySqlConnection(ConnectionString);
            
            //This is the resultset list where all out come data will be stored on.

            List<Dictionary<String, String>> Resultset = new List<Dictionary<String, String>>();

            try
            {
                //This command connect the database with page
                connect.Open();

                //This command is to load the query in commander
                MySqlCommand cmd = new MySqlCommand(query,connect);
                //resultset is where we can store the data in variable
                MySqlDataReader resultset = cmd.ExecuteReader();

                while(resultset.Read())
                {
                    Dictionary<string, string> record = new Dictionary<string, string>();
                    for(int i=0; i<resultset.FieldCount;i++)
                    {
                        record.Add(resultset.GetName(i),resultset.GetString(i));
                    }

                    Resultset.Add(record);
                }
               
                
            }
            catch(Exception ex)
            {
                ex.ToString();
            }

            return Resultset;
        }
    }
}
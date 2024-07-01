using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace cams
{
    public class connector
    {
        String server;
        String database;
        String userName;
        String password;
        public MySqlConnection connection;
        public connector() 
        {
            server = "localhost";
            database = "cbc";
            userName = "root";
            password = "";
            String connectionString = "SERVER=" + server + ";DATABASE=" + 
                database + ";UID=" + userName + ";PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);

        }
        public bool openconnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException e) 
            {
                Console.Write("Invalid Connection");
                return false;
            }
        }
        public bool closeConnection() 
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException e)
            {
                return false;
            }
        }
    }
}


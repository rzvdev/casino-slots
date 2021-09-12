using MySql.Data.MySqlClient;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace SizzlingHot
{
    class DbConnection : ConnectionInfo, IConnectable
    {
        private static DbConnection instance;

        internal bool CanConnect { get; set; }
        internal bool IsSqlConnection { get; set; }

        private static MySqlConnection mySqlConnection;
        private static MySqlDataReader dataReader;

        /// <summary>
        /// Represent the sql connection 
        /// </summary>
        private static SqlConnection sqlConnection;
        private static SqlDataReader sqlDataReader;

        public static DbConnection GetInstance()
        {
            if (instance == null)
            {
                instance = new DbConnection();
            }
            return instance;
        }

        protected DbConnection() { }

        public void CloseConnection()
        {
            if (!IsSqlConnection)
            {
                if (mySqlConnection.State == 0)
                {
                    mySqlConnection.Close();
                }
            }
            else
            {
                if (sqlConnection.State == 0)
                {
                    sqlConnection.Close();
                }
            }
        }
        public bool TryConnection()
        {
            string connectionString = ConnectionInfo.GetConnectionString();

            if (!IsSqlConnection)
            {
                mySqlConnection = new MySqlConnection(connectionString);

                try
                {
                    mySqlConnection.Open();
                    CanConnect = true;
                    Console.WriteLine("Connected to MYSQL database!");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Cannot connect to database!");
                    Console.WriteLine(e.Message);
                    CanConnect = false;
                }
            }
            else
            {
                sqlConnection = new SqlConnection(connectionString);

                try
                {
                    sqlConnection.Open();
                    CanConnect = true;
                    Console.WriteLine("Connected to SQL database!");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Cannot connect to database!");
                    Console.WriteLine(e.Message);
                    CanConnect = false;
                }
            }
            return CanConnect;
        }

        public bool ConnectDB(string user, string password)
        {
            bool logged = false;

            if (CanConnect)
            {
                string sqlToLogin = $"SELECT user_id,password FROM account WHERE user_id = '{user}' AND password = '{password}'";

                if (!IsSqlConnection)
                {
                    MySqlCommand tryLogin = new MySqlCommand(sqlToLogin, mySqlConnection);

                    if (mySqlConnection.State == 0)
                    {
                        mySqlConnection.Open();
                    }

                    dataReader = tryLogin.ExecuteReader();

                    if (dataReader.HasRows)
                    {
                        Account.Login(new Account(user, password));
                        Console.WriteLine("LOGGED IN!");
                        logged = true;
                    }
                    else
                    {
                        Console.WriteLine("This account dosen't exist!");
                        mySqlConnection.Close();
                    }
                }
                else
                {
                    SqlCommand tryLogin = new SqlCommand(sqlToLogin,sqlConnection);

                    if(sqlConnection.State == 0)
                    {
                        sqlConnection.Open();
                    }

                    sqlDataReader = tryLogin.ExecuteReader();

                    if (sqlDataReader.HasRows)
                    {
                        Account.Login(new Account(user, password));
                        Console.WriteLine("Logged IN!");
                        logged = true;
                    }
                    else
                    {
                        Console.WriteLine("This account dosen't exist!");
                        sqlConnection.Close();
                    }
                }
            }
            return logged;
        }
    }
}

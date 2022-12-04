using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;


namespace Assignment3_try2_RaminFallahi.Models
{
    public class SchoolDbContext
    {
        private static string User { get { return "root"; } }//read only because of get prperty accessor.
        private static string Password { get { return "root"; } }//read only because of get prperty accessor.
        private static string Database { get { return "SchoolDb"; } }//changed into the schooldb = the name of the database.
        private static string Server { get { return "localhost"; } }//read only because of get prperty accessor.
        private static string Port { get { return "3306"; } }//read only because of get prperty accessor.

        protected static string ConnectionString
        {
            get
            {

                return "server = " + Server
                    + "; user = " + User
                    + "; database = " + Database
                    + "; port = " + Port
                    + "; password = " + Password
                    + "; convert zero datetime = True";
            }
        }
        /// <summary>
        /// Returns a connection to the schoolDbContext database.
        /// </summary>
        /// <example>
        /// private schoolDbDbContext schoolDb = new schoolDbContext();
        /// MySqlConnection Conn = schoolDb.AccessDatabase();
        /// </example>
        /// <returns>A MySqlConnection Object</returns>
        public MySqlConnection AccessDatabase()//this method is public = can be accessed by any controller that exist in our server.
        {//mthod name === AccessDatabase
            return new MySqlConnection(ConnectionString);
        }
    }
}
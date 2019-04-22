using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BookStore
{
   public class Database
    {
        private static string path = "Data Source=" + Application.StartupPath + "\\BookStore.db;Version=3";
        private SQLiteConnection connection;
        private SQLiteCommand sql_command;
        private static Database database;

        private Database()
        {
            connection = new SQLiteConnection(path);
            sql_command = new SQLiteCommand();
        }

        public static Database get_instance()
        {

            if ( database == null)
            {
                database = new Database();
               
            }
            return database;
        }

        public void open_database()
        {
           
            connection.Open();
           
        }

        public void process_command(string sql_statement)
        {
            sql_command.CommandText = sql_statement;
            sql_command.Connection = connection;
        }

        public void add_value(string par,object value)
        {
            sql_command.Parameters.AddWithValue(par,value);
        }

        public bool execute_command()
        {

            try
            {
                sql_command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            
        }
     
        public void read_value(string value)
        {
            connection.Open();
            sql_command.Connection = connection;
            sql_command.CommandText = "Select * from "+value;
            using (SQLiteDataReader sdr = sql_command.ExecuteReader())
            {
                
               /* while (sdr.Read())
                {
                    Console.Write("{0} ", sdr["Id"]);
                    Console.Write("{0} ", sdr["Name"]);
                    Console.Write("{0} \n", sdr["Price"]);
                  //  Console.Write("{0} \n", sdr["Image"]
                 //  Console.Write("{0} \n", sdr["Type"]);

                }*/
                sdr.Close();
                connection.Close();
               

            }


        }
        public void close_database()
        {
            sql_command.Dispose();
            connection.Dispose();

        }

    }
}

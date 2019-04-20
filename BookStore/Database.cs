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
    class Database
    {
        private static string path = "Data source = BookStore.db";
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
     
        public void read_value()
        {
            string sql = "Select * from BookTable";


            process_command(sql);



            SQLiteDataReader rdr = sql_command.ExecuteReader();

            do
            {
                rdr.Read();
                Console.WriteLine(rdr);

            } while (rdr.NextResult());





        }
        public void close_database()
        {
            sql_command.Dispose();
            connection.Dispose();

        }

    }
}

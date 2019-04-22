using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
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
        public List<Book> BookList = new List<Book>();
        public static Database get_instance()
        {
            

            if (database == null)
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

        public void add_value(string par, object value)
        {
            sql_command.Parameters.AddWithValue(par, value);
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
            using (connection = new SQLiteConnection(path))
            {
                connection.Open();

                string stm = "SELECT * FROM " + value;

                using (sql_command = new SQLiteCommand(stm, connection))
                {

                    using (SQLiteDataReader sdr = sql_command.ExecuteReader())
                    {

                        while (sdr.Read())
                        {

                            Book mybook = new Book(sdr.GetString(1), sdr.GetDouble(2), sdr.GetInt32(4), sdr.GetString(5), sdr.GetString(6), sdr.GetInt32(7), null);
                            BookList.Add(mybook);


                        }
                        sdr.Close();
                        connection.Close();

                    }
                }

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

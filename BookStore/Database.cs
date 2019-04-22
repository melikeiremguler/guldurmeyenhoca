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
        public List<Customer> CustomerList = new List<Customer>();
        public List<MusicCD> MusicCDList = new List<MusicCD>();
        public List<Magazine> MagazineList = new List<Magazine>();

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

        private void process_command(string sql_statement)
        {
            sql_command.CommandText = sql_statement;
            sql_command.Connection = connection;
        }

        public void add_value(string param, object value, string sql_statement)  //string sql_statement = INSERT INTO table'ın adı
        {
            process_command(sql_statement);
            sql_command.Parameters.AddWithValue(param, value);
        }
        public void add_customer(string sql_statement, Customer customer)
        {
            process_command(sql_statement);
      
            sql_command.Parameters.Add(customer.customerID);
            sql_command.Parameters.Add(customer.name);
            sql_command.Parameters.Add(customer.email);
            sql_command.Parameters.Add(customer.userName);
            sql_command.Parameters.Add(customer.possword);
          //  sql_command.Parameters.Add(customer.TotalCustomer);
           

        }
        public void add_book(string sql_statement, Book book)
        {
            process_command(sql_statement);

            sql_command.Parameters.Add(book.getId());
            sql_command.Parameters.Add(book.getName());
            sql_command.Parameters.Add(book.getPrice());
            sql_command.Parameters.Add(book.image);
            sql_command.Parameters.Add(book.ISBN);
            sql_command.Parameters.Add(book.author);
            sql_command.Parameters.Add(book.publisher);
            sql_command.Parameters.Add(book.page);
          //  sql_command.Parameters.Add(book.getTotalBook());

        }
        public void add_magazine(string sql_statement, Magazine magazine)
        {
            process_command(sql_statement);

            sql_command.Parameters.Add(magazine.getId());
            sql_command.Parameters.Add(magazine.getName());
            sql_command.Parameters.Add(magazine.getPrice());
            sql_command.Parameters.Add(magazine.image);
            sql_command.Parameters.Add(magazine.issue);
            sql_command.Parameters.Add(magazine.type);
          //  sql_command.Parameters.Add(magazine.getTotalMagazine());

        }
        public void add_musiccd(string sql_statement, MusicCD musicCD)
        {
            process_command(sql_statement);

            sql_command.Parameters.Add(musicCD.getId());
            sql_command.Parameters.Add(musicCD.getName());
            sql_command.Parameters.Add(musicCD.getPrice());
            sql_command.Parameters.Add(musicCD.image);
            sql_command.Parameters.Add(musicCD.singer);
            sql_command.Parameters.Add(musicCD.type);
          //  sql_command.Parameters.Add(musicCD.getTotalCd());

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

        public List<Book> read_book(string value)
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
                            Book mybook = new Book(sdr.GetInt32(0),sdr.GetString(1), sdr.GetDouble(2), sdr.GetInt32(4), sdr.GetString(5), sdr.GetString(6), sdr.GetInt32(7), null);
                            BookList.Add(mybook);
                        }
                        sdr.Close();
                        connection.Close();
                    }
                }
                connection.Close();
            }
            return BookList;

        }
        public List<Customer> read_customer(string value)
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
                            Customer mycustomer = new Customer(sdr.GetInt32(0), sdr.GetString(1), sdr.GetString(2), sdr.GetString(4), sdr.GetString(5));
                            CustomerList.Add(mycustomer);
                        }
                        sdr.Close();
                        connection.Close();
                    }
                }
                connection.Close();
            }
            return CustomerList;
        }
        public List<MusicCD> read_musiccd(string value)
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
                            MusicCD mymusicCD = new MusicCD(sdr.GetInt32(0), sdr.GetString(1), sdr.GetDouble(2), null , sdr.GetString(4), sdr.GetChar(5));
                            MusicCDList.Add(mymusicCD);
                        }
                        sdr.Close();
                        connection.Close();
                    }
                }
                connection.Close();
            }
            return MusicCDList;
        }
        public List<Magazine> read_magazine(string value)
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
                            Magazine mymagazine = new Magazine(sdr.GetInt32(0), sdr.GetString(1), sdr.GetDouble(2), null, sdr.GetString(4), sdr.GetChar(5));
                            MagazineList.Add(mymagazine);
                        }
                        sdr.Close();
                        connection.Close();
                    }
                }
                connection.Close();
            }
            return MagazineList;
        }
        public void close_database()
        {
            sql_command.Dispose();
            connection.Dispose();

        }

    }
}

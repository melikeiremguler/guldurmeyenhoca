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
       
        public void update_value(string param1, object value, string sql_statement)  //string sql_statement = INSERT INTO table'ın adı
        {
            process_command(sql_statement);
            sql_command.Parameters.AddWithValue(param1, value);
            try
            {
                sql_command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public void add_customer(string sql_statement, Customer customer)
        {
            //process_command(sql_statement);
            SQLiteCommand sql_command = new SQLiteCommand(sql_statement, connection);

            sql_command.Parameters.Add(customer.customerID);
            sql_command.Parameters.Add(customer.name);
            sql_command.Parameters.Add(customer.email);
            sql_command.Parameters.Add(customer.userName);
            sql_command.Parameters.Add(customer.password);
            sql_command.Parameters.Add(customer.Address);
            //  sql_command.Parameters.Add(customer.TotalCustomer);
            try
            {
                sql_command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }
        public void add_book(string sql_statement,Book book)
        {

            using (SQLiteConnection connection = new SQLiteConnection(path))
            {             

                SQLiteCommand sql_command = new SQLiteCommand();
                sql_command.CommandText = sql_statement;
          
                sql_command.Connection = connection;  //bağlantı kuruluyor.
                sql_command.Parameters.AddWithValue("@Id", book.getId());
                sql_command.Parameters.AddWithValue("@Name", book.getName());
                sql_command.Parameters.AddWithValue("@Price", book.getPrice());
                sql_command.Parameters.AddWithValue("@Image", "Book");
                sql_command.Parameters.AddWithValue("@ISBN", book.ISBN);
                sql_command.Parameters.AddWithValue("@Author", book.author);
                sql_command.Parameters.AddWithValue("@Publisher", book.publisher);
                sql_command.Parameters.AddWithValue("@Page", book.page);
                sql_command.Parameters.AddWithValue("@Stock", book.Stok);
                connection.Open();

                try
                {
                    sql_command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }


                connection.Close();
            }
               

        }
        public void add_magazine(string sql_statement, Magazine magazine)
        {
             using(SQLiteConnection connection = new SQLiteConnection(path))
            {
                SQLiteCommand sql_command = new SQLiteCommand();
                sql_command.CommandText = sql_statement;

                sql_command.Connection = connection;  //bağlantı kuruluyor.
                sql_command.Parameters.AddWithValue("@Id",magazine.getId());
                sql_command.Parameters.AddWithValue("@Name", magazine.getName());
                sql_command.Parameters.AddWithValue("@Price", magazine.getPrice());
                sql_command.Parameters.AddWithValue("@Image", magazine.image);
                sql_command.Parameters.AddWithValue("@Type", magazine.type);
                sql_command.Parameters.AddWithValue("@Issue", magazine.issue);
                sql_command.Parameters.AddWithValue("@Stock", magazine.Stok);

                connection.Open(); //connnection açılır.
                try
                {
                    sql_command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                connection.Close();
            }
        }
        public void add_musiccd(string sql_statement, MusicCD musicCD)
        {

            using (SQLiteConnection connection = new SQLiteConnection(path))
            {
                SQLiteCommand sql_command = new SQLiteCommand();
                sql_command.CommandText = sql_statement;

                sql_command.Connection = connection;    //bağlantı kuruluyor.
                sql_command.Parameters.AddWithValue("@Id",musicCD.getId());
                sql_command.Parameters.AddWithValue("@Name",musicCD.getName());
                sql_command.Parameters.AddWithValue("@Price",musicCD.getPrice());
                sql_command.Parameters.AddWithValue("@Image",musicCD.image);
                sql_command.Parameters.AddWithValue("@Singer",musicCD.singer);
                sql_command.Parameters.AddWithValue("@Type",musicCD.type);
                sql_command.Parameters.AddWithValue("@Stock", musicCD.Stok);
                connection.Open(); //connnection açılır.

                try
                {
                    sql_command.ExecuteNonQuery();
                    MessageBox.Show("Production has been added");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Production could not be added");
                    throw new Exception(ex.Message);
                    
                }
                connection.Close();
            }
        }
        public void add_shoppingcart(string sql_statement, int customerId,string productName)
        {
            process_command(sql_statement);
            sql_command.Parameters.Add(customerId);
            sql_command.Parameters.Add(productName+',');
            try
            {
                sql_command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
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
            BookList.Clear();
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
                            Book mybook = new Book(sdr.GetInt32(0),sdr.GetString(1), sdr.GetDouble(2), sdr.GetInt32(4), sdr.GetString(5), sdr.GetString(6), sdr.GetInt32(7), null,sdr.GetInt32(8));
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
            CustomerList.Clear();
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
                            Customer mycustomer = new Customer(sdr.GetInt32(0), sdr.GetString(1), sdr.GetString(2), sdr.GetString(3), sdr.GetString(4), sdr.GetString(5));
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
            MusicCDList.Clear();
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

                           MusicCD mymusicCD = new MusicCD(sdr.GetInt32(0), sdr.GetString(1), sdr.GetDouble(2), null , sdr.GetString(4), (MusicCD.Type)sdr.GetInt32(5),sdr.GetInt32(6));
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
            MagazineList.Clear();
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

                          Magazine mymagazine = new Magazine(sdr.GetInt32(0), sdr.GetString(1), sdr.GetDouble(2), null, (Magazine.Type)sdr.GetInt32(4), sdr.GetString(5),sdr.GetInt32(6));

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

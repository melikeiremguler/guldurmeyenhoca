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
    /*! \class Database
    *  \brief It is Database class.
    */

    public class Database
    {
        private static string path = "Data Source=" + Application.StartupPath + "\\BookStore.db;Version=3";
        private SQLiteConnection connection;
        private SQLiteCommand sql_command;

        public List<Book> BookList = new List<Book>();
        public List<Customer> CustomerList = new List<Customer>();
        public List<MusicCD> MusicCDList = new List<MusicCD>();
        public List<Magazine> MagazineList = new List<Magazine>();

        private static Database database;

        private Database()
        {

            connection = new SQLiteConnection(path);
            sql_command = new SQLiteCommand();
        }

        /*! \fn static Database get_instance()
         *  \brief A static Database function 
         *  \details It is used to return only one Database object by using Singleton Pattern.
         *  \return Database
        */
        public static Database get_instance()
        {
            
            if (database == null)
            {
                database = new Database();

            }
            return database;
        }

        /*! \fn void open_database()
        *  \brief A open database function.
        *  \details It is used to connect database.
        *  \return void
       */
        public void open_database()
        {

            connection.Open();

        }

        /*! \fn void process_command(string sql_statement)
        *  \brief A process command function.
        *  \details It is used to process sql statement.
        *  \param sql_statement (string) it holds sql statement.
        *  \return void
       */
        private void process_command(string sql_statement)
        {
            sql_command.CommandText = sql_statement;
            sql_command.Connection = connection;
        }

        /*!  \fn void add_value(string param, object value, string sql_statement)
           * \brief A add value function.
           * \details It is used to add value to database.
           * \param param (string) it holds key.
           * \param value (object) it hold value.
           * \param sql_statement (string) it holds sql statement.
           * \return void
        */
        public void add_value(string param, object value, string sql_statement)  //string sql_statement = INSERT INTO table'ın adı
        {
            process_command(sql_statement);
            sql_command.Parameters.AddWithValue(param, value);
        }

        /*!  \fn void update_value(string param1, object value, string sql_statement)
           * \brief A update value function.
           * \details It is used to update value to database.
           * \param param1 (string) it holds key.
           * \param value (object) it hold value.
           * \param sql_statement (string) it holds sql statement.
           * \return void
        */
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


            connection.Close();
            
        }

        /*!  \fn  void add_customer(string sql_statement, Customer customer)
           * \brief A adding customer function.
           * \details It is used to add customer value to database.
           * \param sql_statement (string) it holds sql statement.
           * \param customer (Customer) it holds Customer object.
           * \return void
        */
        public void add_customer(string sql_statement, Customer customer)
        {
            using (SQLiteConnection connection = new SQLiteConnection(path))
            {

                SQLiteCommand sql_command = new SQLiteCommand();
                sql_command.CommandText = sql_statement;

                sql_command.Connection = connection;  //bağlantı kuruluyor.            
                sql_command.Parameters.AddWithValue("@Name", customer.name);
                sql_command.Parameters.AddWithValue("@Email", customer.email);
                sql_command.Parameters.AddWithValue("@Username", customer.userName);
                sql_command.Parameters.AddWithValue("@Password", customer.password);
                sql_command.Parameters.AddWithValue("@Address", customer.Address);

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

        /*!  \fn void add_book(string sql_statement,Book book)
           * \brief A adding book function.
           * \details It is used to add book value to database.
           * \param sql_statement (string) it holds sql statement.
           * \param book (Book) it holds Book object.
           * \return void
        */
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
                sql_command.Parameters.AddWithValue("@Description", book.Description);
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

        /*!  \fn void add_magazine(string sql_statement,Magazine magazine)
          * \brief A adding magazine function.
          * \details It is used to add magazine value to database.
          * \param sql_statement (string) it holds sql statement.
          * \param magazine (Magazine) it holds Magazine object.
          * \return void
       */
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
                sql_command.Parameters.AddWithValue("@Image", magazine.image_path);
                sql_command.Parameters.AddWithValue("@Type", magazine.type);
                sql_command.Parameters.AddWithValue("@Issue", magazine.issue);
                sql_command.Parameters.AddWithValue("@Description", magazine.Description);
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

        /*!  \fn void add_music(string sql_statement,MusicCD musicCD)
         * \brief A adding musiccd function.
         * \details It is used to add musiccd value to database.
         * \param sql_statement (string) it holds sql statement.
         * \param musicCD (MusicCD) it holds MusicCD object.
         * \return void
         */
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
                sql_command.Parameters.AddWithValue("@Image",musicCD.image_path);
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

        /*!  \fn void add_shoppingcart(string sql_statement, int customerId,string productName,int amount)
        * \brief A adding product to shopping cart function.
        * \details It is used to add product that customer wants to buy to database.
        * \param sql_statement (string) it holds sql statement.
        * \param customerId (int) it holds customer id.
        * \param productName (string) it holds product name.
        * \param amount (int) it holds quantity of product.
        * \return void
        */
        public void add_shoppingcart(string sql_statement, int customerId,string productName,int amount)
        {
            sql_command = connection.CreateCommand();
            sql_command.CommandText = sql_statement;
            
            sql_command.Parameters.Add(customerId);
            sql_command.Parameters.Add(productName);
            sql_command.Parameters.Add(amount);
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

        /*! \fn bool execute_command()
        *   \brief A executing command function.
        *   \details It is used to execute sql statement.
        *   \return bool
        */
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

        /*! \fn List<Book> read_book(string value)
       *   \brief A reading data function.
       *   \details It is used to read data from book table in database.
       *   \param value (string) table name.
       *   \return List<Book>
       */
        public List<Book> read_book(string value)
        {

            Book b = new Book(0, null, 0, 0, null, null, 0, null,null, 0);
            b.setTotalBook(1);
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
                            Book mybook = new Book(sdr.GetInt32(0),sdr.GetString(1), sdr.GetDouble(2), sdr.GetInt32(4), sdr.GetString(5), sdr.GetString(6), sdr.GetInt32(7), null, sdr.GetString(8), sdr.GetInt32(9));
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

        /*! \fn List<Customer> read_customer(string value)
         *   \brief A reading data function.
         *   \details It is used to read data from customer table in database.
         *   \param value (string) table name.
         *   \return List<Customer>
         */
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

        /*! \fn List<MusicCD> read_musiccd(string value)
         *   \brief A reading data function.
         *   \details It is used to read data from musicCD table in database.
         *   \param value (string) table name.
         *   \return List<Customer>
         */
        public List<MusicCD> read_musiccd(string value)
        {

            MusicCD m = new MusicCD(0, null, 0, null, null, MusicCD.Type.Country, 0);
            m.setTotalCd(1);

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

        /*! \fn List<Magazine> read_magazine(string value)
        *   \brief A reading data function.
        *   \details It is used to read data from magazine table in database.
        *   \param value (string) table name.
        *   \return List<Magazine>
        */
        public List<Magazine> read_magazine(string value)
        {

           Magazine m=new Magazine(0,"a",1,null,Magazine.Type.Actual,"fun",null,0);
           m.setTotalMagazine(1);

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

                          Magazine mymagazine = new Magazine(sdr.GetInt32(0), sdr.GetString(1), sdr.GetDouble(2), null, (Magazine.Type)sdr.GetInt32(4), sdr.GetString(5), sdr.GetString(6), sdr.GetInt32(7));

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

        /*! \fn void close_database()
        *   \brief A close database.
        *   \details It is used to close database.
        *   \return void
        */
        public void close_database()
        {
            sql_command.Dispose();
            connection.Dispose();

        }

    }
}

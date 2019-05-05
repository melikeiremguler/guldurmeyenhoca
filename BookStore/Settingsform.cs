using System;
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
    /**A Setting Form */
    public partial class Settingsform : Form
    {
        public Settingsform()
        {
            InitializeComponent();
        }

        private void customerUpdateBtn_Click(object sender, EventArgs e)
        {
            Database database = Database.get_instance();/*!Singleton pattern ile database oluştur.*/
            database.CustomerList.Clear();//Listede Customer class objesi varsa temizle(üzerine yazmamak için).
            database.read_customer("UserTable");//Customerları databaseden oku.

            /*! Database ile bağlantı kur.*/
            using (SQLiteConnection con = new SQLiteConnection("Data Source=" + Application.StartupPath + "\\BookStore.db;Version=3"))
            {
                /*!Try Catch ile Hata ihtimaline karşı önlem al. */
                try
                {
                    /* Database ileteceğin komutu oluştur. */
                    SQLiteCommand cmd = new SQLiteCommand();
                   
                   /*! Database komutu */
                        cmd.CommandText = @"Update UserTable Set Name=@Name, Email=@Email, Password=@Password, Address=@Address Where Id= " + LoginForm.current_customer_id;
                    
                    /*! Komut ve bağlantıyı ilişkilendir. */
                    cmd.Connection = con;
                    /*! Değiştirilen parametreleri Sqlite'ın kütüphanesindekini fonksiyona gönder .*/ 
                    cmd.Parameters.Add(new SQLiteParameter("@Name", txtName.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@Email", txtEmail.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@Password", txtPassword.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@Address", txtEmail.Text));

                    /*! Birden fazla bağlantı oluşmaması için bağlantıyı kapat. */
                    con.Open();

                    /*! İşlem başarılı mı kontrol et . */
                    int i = cmd.ExecuteNonQuery();

                    /*! İşlem başarılı mesajı ver. */
                    if (i == 1)
                    {

                        MessageBox.Show("User update");
                        this.Close();
                    }
                    /*! İşlem başarısız mesajı ver. */
                    else
                    {
                        MessageBox.Show("User not update");
                    }
                }
                /*! Programın işlenmesi sırasında bir hata alınırsa kullanıcıya hatanın mesajını ver. */
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Settingsform_Load(object sender, EventArgs e)
        {

        }
    }
}

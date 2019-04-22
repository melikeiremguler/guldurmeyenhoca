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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CustomerForm mycustomerform = new CustomerForm();

            mycustomerform.Show();
          

          
          

            //Database database = Database.get_instance();
            //database.open_database();
            //string sql = "insert into tblbook(id,name) values(@id,@name)";
            //database.process_command(sql);
            //database.add_value("@id", 2);
            //database.add_value("@name", "veys");
            //database.execute_command();
            //database.close_database();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Toplam ürün sayısını gösteriyo magazin + book + cd deneme yapıldı
            /* string tt = ";";
             Magazine p = new Magazine(tt, 1,tt,Type.Actual);
             MusicCD m = new MusicCD(tt, 1, tt, type.Country);
             Magazine pt = new Magazine(tt, 1, tt, Type.Actual);
             MusicCD mt = new MusicCD(tt, 1, tt, type.Country);
             int a= m.getTotal();
             Console.WriteLine(a);*/
        }
    }
}

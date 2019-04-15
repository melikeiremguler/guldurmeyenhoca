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


namespace oopProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string path = "Data source =sqlite.db";
            SQLiteConnection baglantı = new SQLiteConnection(path);
            baglantı.Open();
            string sql = "insert into tblbook(id,name) values(@id,@name)";
            SQLiteCommand komutislet = new SQLiteCommand(sql, baglantı);
            komutislet.Parameters.AddWithValue("@id",1);
            komutislet.Parameters.AddWithValue("@name", "tuce");

            komutislet.ExecuteNonQuery();
            baglantı.Dispose();
            komutislet.Dispose();
           
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

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    class ShoppingCart
    {
        public int customerID { get; set; }
        public ArrayList itemsToPurchase_list { get; set; }
        public int paymentAmount { get; set; }
        public enum paymentType { cash, creditcard }
        
        public ShoppingCart()
        {

        }

        public ShoppingCart(int id, ref ArrayList items, int amount) //constructor
        {
            customerID = id;
            paymentAmount = amount;
            itemsToPurchase_list = items;

        }

        public void addProduct(ItemToPurchase item)
        {
            bool check = true;
            Database database = Database.get_instance();

            //to check whether the product exists in the database or not
            for (int i = 0; i < itemsToPurchase_list.Count; i++)
            {
                ItemToPurchase item_obj = (ItemToPurchase)itemsToPurchase_list[i];

                if (item_obj.product.getId() == customerID && item_obj.product.getName().Equals(item.product.getName()))
                {

                    item_obj.quantity++;
                    itemsToPurchase_list.RemoveAt(i);
                    itemsToPurchase_list.Insert(i, item_obj);
                    using (SQLiteConnection connection = new SQLiteConnection("Data Source=" + Application.StartupPath + "\\BookStore.db;Version=3"))
                    {

                        connection.Open();
                        using (SQLiteCommand command = new SQLiteCommand(connection))
                        {
                            command.CommandText =
                                "update ShoppingCartTable set Amount = :amount,TotalPrice = :totalprice where Id = :id AND Product= :product";
                            command.Parameters.Add("amount", DbType.Int32).Value = item_obj.quantity;
                            command.Parameters.Add("totalprice", DbType.Double).Value = item_obj.quantity * item_obj.product.getPrice();
                            command.Parameters.Add("id", DbType.Int32).Value = customerID;
                            command.Parameters.Add("product", DbType.String).Value = item.product.getName();

                            command.ExecuteNonQuery();
                        }

                        connection.Close();
                    }
                    check = false;
                    break;

                }
            }

            if (check)
            {
                //if the product does not exist in the database,it is added to the database.
                itemsToPurchase_list.Add(item);
                using (SQLiteConnection sql_con = new SQLiteConnection("Data Source=" + Application.StartupPath + "\\BookStore.db;Version=3"))
                {
                    SQLiteCommand sql_command = new SQLiteCommand();
                    sql_command.CommandText = "Insert Into ShoppingCartTable(Id,Product,Amount,UnitPrice,TotalPrice,Image) Values(@Id,@Product,@Amount,@UnitPrice,@TotalPrice,@Image)";
                    sql_command.Connection = sql_con;

                    sql_command.Parameters.AddWithValue("@Id", customerID);
                    sql_command.Parameters.AddWithValue("@Product", item.product.getName());
                    sql_command.Parameters.AddWithValue("@Amount", item.quantity);
                    sql_command.Parameters.AddWithValue("@UnitPrice", item.product.getPrice());
                    sql_command.Parameters.AddWithValue("@TotalPrice", item.product.getPrice()*item.quantity);
                    sql_command.Parameters.AddWithValue("@Image", item.product.ToString().Split('.')[1] + "," + item.product.getId().ToString());
                    sql_con.Open();
                    sql_command.ExecuteNonQuery();
                    sql_con.Close();
                }
            }

        }

        public void removeProduct(ItemToPurchase item)
        {
            Database database = Database.get_instance();
            using (SQLiteConnection sql_con = new SQLiteConnection("Data Source=" + Application.StartupPath + "\\BookStore.db;Version=3"))
            {

                SQLiteCommand sql_command = new SQLiteCommand();
                sql_command.CommandText = "Delete From ShoppingCartTable where Id = '" + customerID + "' AND Product = '" + item.product.getName()+"'";
                sql_command.Connection = sql_con;
                sql_con.Open();
                sql_command.ExecuteNonQuery();
                sql_con.Close();
            }

            if (itemsToPurchase_list.Contains(item))
            {
                itemsToPurchase_list.Remove(item);
            }
        }

        public int getTotalProduct()
        {
            int totalproduct = 0;
            for(int i = 0; i < itemsToPurchase_list.Count; i++)
            {
                ItemToPurchase item = (ItemToPurchase)itemsToPurchase_list[i];
                if (customerID == item.product.getId())
                {
                    totalproduct += item.quantity;
                }
            }

            return totalproduct;
        }
        public void placeOrder() { }//fatura gönderme
        public void cancelOrder() { }//sms gönderme
        public void endInvoidcebyEmail() { }
    }
}

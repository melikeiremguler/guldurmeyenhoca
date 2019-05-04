using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    class Email
    {
        private Customer currentCustomer { get; set; }//o anki aktif olan kullanıcıya güncellenen stok bilgisi mail olarak gider.
        private MailMessage mail { get; set; }
        private SmtpClient client { get; set; }

        public Email()
        {
            
            
            Database database = Database.get_instance();
            database.CustomerList = database.read_customer("UserTable");
            foreach(var i in database.CustomerList)
            {
                if (i.customerID == LoginForm.current_customer_id)
                {
                    currentCustomer = i;

                    string htmlBody = "<html><body><h1>Picture</h1><br><img src=\"cid:filename\"></body></html>";
                    AlternateView avHtml = AlternateView.CreateAlternateViewFromString
                       (htmlBody, null, MediaTypeNames.Text.Html);

                    LinkedResource inline = new LinkedResource(Application.StartupPath + "screenshot.jpeg", MediaTypeNames.Image.Jpeg);
                    inline.ContentId = Guid.NewGuid().ToString();
                    avHtml.LinkedResources.Add(inline);

                    mail = new MailMessage("onlinebookstorebestof@gmail.com", currentCustomer.email); ;
                    mail.AlternateViews.Add(avHtml);

                    Attachment att = new Attachment(Application.StartupPath + "screenshot.jpeg");
                    att.ContentDisposition.Inline = true;

                   
                    client = new SmtpClient();
                    client.Port = 587;
                    client.EnableSsl = true;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.UseDefaultCredentials = false;
                    client.Credentials = new NetworkCredential("onlinebookstorebestof@gmail.com", "tivtivtiv");
                    client.Host = "smtp.gmail.com";
                    mail.Subject = "succes";
                    mail.Body = String.Format(
                       "<h3>Client: " + currentCustomer.customerID + " Has Sent You A Screenshot</h3>" +
                       @"<img src=""cid:{0}"" />", inline.ContentId);
                    mail.IsBodyHtml = true;

                    mail.Attachments.Add(att);
                    client.Send(mail);

                }
                

            }


        }
       
       

    }
  
}

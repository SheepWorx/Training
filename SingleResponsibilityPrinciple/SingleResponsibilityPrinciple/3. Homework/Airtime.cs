using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple._3._Homework
{
    /// <summary>
    /// refactor this class to adhere to the SRP
    /// </summary>
    public class Airtime
    {
        public string ProductName { get; set; }
        public string Type { get; set; }
        public decimal Amount { get; set; }
        public string CellNumber { get; set; }

        public void SendDefaultEmailReceipt(string toEmailAddress)
        {
            try
            {
                MailMessage mail = new MailMessage("you@yourcompany.co.za", toEmailAddress);
                SmtpClient client = new SmtpClient();
                client.Port = 25;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Host = "smtp.gmail.com";
                mail.Subject = "Airtime purchased";
                mail.Body = string.Format("Hi<br><br>You have purchased R{0} of {1}.<br><br>bye bye", Amount, ProductName);
                client.Send(mail);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Could not purchase Airtime");
            }
        }

        public IList<string> ReceiptForReceiptPrinter()
        {
            IList<string> items = new List<string>();

            items.Add(string.Format("Item purchased: {0}", ProductName));
            items.Add(string.Format("Amount: {0}", Amount));
            items.Add(string.Format("Cellphone No: {0}", CellNumber));

            return items;
            
        }
    }
}

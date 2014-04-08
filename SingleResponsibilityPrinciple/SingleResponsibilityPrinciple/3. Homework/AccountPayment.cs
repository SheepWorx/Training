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
    public class AccountPayment
    {
        public string ProductName { get; set; }
        public string Type { get; set; }
        public decimal Amount { get; set; }
        public string AccountNumber { get; set; }

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
                mail.Subject = "Account Payment made";
                mail.Body = string.Format("Hi<br><br>You have paid R{0} of your {1} account.<br><br>bye bye", Amount, AccountNumber);
                client.Send(mail);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Could not make AccountPayment");
            }
        }

        public IList<string> ReceiptForReceiptPrinter()
        {
            IList<string> items = new List<string>();

            items.Add(string.Format("Item purchased: {0}", ProductName));
            items.Add(string.Format("Amount: {0}", Amount));
            items.Add(string.Format("Account No: {0}", AccountNumber));

            return items;

        }
    }
}

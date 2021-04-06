using HW4EX2B4.TightCoupling.Interfaces;
using HW4EX2B4.TightCoupling.Services;
using System.Net.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HW4EX2B4.TightCoupling.Model
{
    class Factory
    {
        public static IInventorySystem CreateInventorySystem()
        {
            return new InventorySystem();
        }

        public static IPaymentGateway CreatePaymentGateway()
        {
            return new PaymentGateway();
        }

        public static MailMessage CreateMail(string to, string from)    // This is the only way I could figure out how to remove the newing up of a predefined method
        {
            return new MailMessage();
        }

        public static SmtpClient CreateClient(string host)
        {
            return new SmtpClient();
        }









    }
}

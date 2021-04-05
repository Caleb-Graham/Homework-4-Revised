using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4EX2B4.TightCoupling.Interfaces
{
    public interface IPaymentGateway: IDisposable
    {
        string CardNumber { get; set; }
        string Credentials { get; set; }
        string ExpiresMonth { get; set; }
        string ExpiresYear { get; set; }
        string NameOnCard { get; set; }
        decimal AmountToCharge { get; set; }

        void Charge();

        
    }
}

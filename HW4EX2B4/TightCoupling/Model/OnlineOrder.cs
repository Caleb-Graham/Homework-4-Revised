using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4EX2B4.TightCoupling.Model
{
    class OnlineOrder : Order
    {

        private readonly PaymentDetails _paymentDetails;
        private readonly INotifyCustomer _notifyCustomer;
        private readonly IReserveInventory _reserveInventory;
        private readonly IPaymentProcessor _paymentProcessor;






        public void Checkout(bool notifyCustomer)
        {
            if (_paymentDetails.PaymentMethod == PaymentMethod.CreditCard)
            {
                _paymentProcessor.ChargeCard(_paymentDetails, _cart.TotalAmount);
            }

            _reserveInventory.ReserveInventory(_cart);

            if (notifyCustomer)
            {
                _notifyCustomer.NotifyCustomer(_cart);
            }
        }
    }
}

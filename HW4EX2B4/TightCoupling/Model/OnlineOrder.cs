using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4EX2B4.TightCoupling.Model
{
    public class OnlineOrder : Order
    {
        private readonly PaymentDetails _paymentDetails;
        private readonly INotifyCustomer _notifyCustomer;
        private readonly IReserveInventory _reserveInventory;
        private readonly IPaymentProcessor _paymentProcessor;



        public OnlineOrder(PaymentDetails paymentDetails, INotifyCustomer notifyCustomer, IReserveInventory reserveInventory, IPaymentProcessor paymentProcessor)
        {
            _paymentDetails = paymentDetails;
            _notifyCustomer = notifyCustomer;
            _reserveInventory = reserveInventory;
            _paymentProcessor = paymentProcessor;
        }


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

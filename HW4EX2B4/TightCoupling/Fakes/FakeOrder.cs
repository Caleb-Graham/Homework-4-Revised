using HW4EX2B4.TightCoupling.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4EX2B4.TightCoupling.Fakes
{
    public class FakeOrder
    {
        private readonly Cart _cart;
        private readonly PaymentDetails _paymentDetails;
        private readonly INotifyCustomer _notifyCustomer;
        private readonly IReserveInventory _reserveInventory;
        private readonly IPaymentProcessor _paymentProcessor;

        public FakeOrder(Cart cart, PaymentDetails paymentDetails, INotifyCustomer notifyCustomer, IReserveInventory reserveInventory, IPaymentProcessor paymentProcessor)
        {
            _cart = cart;
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

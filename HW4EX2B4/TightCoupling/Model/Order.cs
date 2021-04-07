 namespace HW4EX2B4.TightCoupling.Model
{
    public abstract class Order
    {
        protected readonly Cart _cart;


        /*
            Dependency Inversion Principle
         *  High-level modules should not depend on low-level modules. Both should depend on abstractions. 
            Abstractions should not depend on details. Details should depend on abstractions
         */
        public Order()
        {

        }

        protected Order(Cart cart)
        {
            _cart = cart;
        }


        public virtual void Checkout()
        {
            // log the order in the database
        }
    }
}
















//namespace HW4EX2B4.TightCoupling.Model
//{
//    public abstract class Order
//    {
//        private readonly Cart _cart;
//        private readonly PaymentDetails _paymentDetails;
//        private readonly INotifyCustomer _notifyCustomer;
//        private readonly IReserveInventory _reserveInventory;
//        private readonly IPaymentProcessor _paymentProcessor;


//        /*
//            Dependency Inversion Principle
//         *  High-level modules should not depend on low-level modules. Both should depend on abstractions. 
//            Abstractions should not depend on details. Details should depend on abstractions
//         */

//        protected Order(Cart cart, PaymentDetails paymentDetails, INotifyCustomer notifyCustomer, IReserveInventory reserveInventory, IPaymentProcessor paymentProcessor)
//        {
//            _cart = cart;
//            _paymentDetails = paymentDetails;
//            _notifyCustomer = notifyCustomer;
//            _reserveInventory = reserveInventory;
//            _paymentProcessor = paymentProcessor;
//        }


//        public void Checkout(bool notifyCustomer)
//        {
//            if (_paymentDetails.PaymentMethod == PaymentMethod.CreditCard)
//            {
//                _paymentProcessor.ChargeCard(_paymentDetails, _cart.TotalAmount);
//            }

//            _reserveInventory.ReserveInventory(_cart);

//            if (notifyCustomer)
//            {
//                _notifyCustomer.NotifyCustomer(_cart);
//            }
//        }
//    }
//}


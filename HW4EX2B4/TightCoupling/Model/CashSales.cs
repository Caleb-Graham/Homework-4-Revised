using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4EX2B4.TightCoupling.Model
{
    public class CashSales : Order
    {

        private readonly PaymentDetails _paymentDetails;
        private readonly IPaymentProcessor _paymentProcessor;






        public override void Checkout()
        {
            if (_paymentDetails.PaymentMethod == PaymentMethod.Cash)
            {
                _paymentProcessor.ChargeCash(_paymentDetails, _cart.TotalAmount);
            }
        }



            ///*
            //    Dependency Inversion Principle
            // *  High-level modules should not depend on low-level modules. Both should depend on abstractions. 
            //    Abstractions should not depend on details. Details should depend on abstractions
            // */



        
    }
}

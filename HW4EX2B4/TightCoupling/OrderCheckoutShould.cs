using HW4EX2B4.TightCoupling.Fakes;
using HW4EX2B4.TightCoupling.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HW4EX2B4.TightCoupling
{
    [TestClass]
    public class OrderCheckoutShould

    {

        [TestMethod]
        public void NotFailWithNoItemsNoNotificationCreditCard()
        {

            var reservationService = new FakeReserveInventory();
            var paymentService = new FakePaymentProcessor();
            var notificationService = new FakeNotifyCustomer();
            var paymentDetails = new PaymentDetails() { PaymentMethod = PaymentMethod.CreditCard };

            var cart = new Cart();
            var order = new FakeOrder(cart, paymentDetails, notificationService, reservationService, paymentService);   //Made fake order due to abstract class

            bool shouldnotifycustomer = false;

            order.Checkout(shouldnotifycustomer);

            Assert.IsTrue(paymentService.wasCalled);

            // if I got here, I guess it worked...
        }

        [TestMethod]
        public void NotFailWithNoItemsNotificationNoCreditCard()
        {
            var reservationService = new FakeReserveInventory();
            var paymentService = new FakePaymentProcessor();
            var notificationService = new FakeNotifyCustomer();
            var paymentDetails = new PaymentDetails() { PaymentMethod = PaymentMethod.Cash };

            var cart = new Cart();
            var order = new FakeOrder(cart, paymentDetails, notificationService, reservationService, paymentService);   //Made fake order due to abstract class

            bool shouldnotifycustomer = true;

            order.Checkout(shouldnotifycustomer);

            Assert.IsTrue(notificationService.wasCalled);
        }


        [TestMethod]
        public void ChargeCardNotFail() // Checks that ChargeCard method is being called
        {
            var paymentService = new FakePaymentProcessor();
            var paymentDetails = new PaymentDetails() { PaymentMethod = PaymentMethod.Cash };

            var cart = new Cart();
            //var order = new FakeOrder(cart, paymentDetails, notificationService, reservationService, paymentService);   //Made fake order due to abstract class

            decimal amount = 0;

            paymentService.ChargeCard(paymentDetails, amount);

            Assert.IsTrue(paymentService.wasCalled);
        }


            [TestMethod]
            public void ChargeCashNotFail() // Checks that ChargeCash method is being called
        {
                var paymentService = new FakePaymentProcessor();
                var paymentDetails = new PaymentDetails() { PaymentMethod = PaymentMethod.Cash };

                var cart = new Cart();
                //var order = new FakeOrder(cart, paymentDetails, notificationService, reservationService, paymentService);   //Made fake order due to abstract class

                decimal amount = 0;

                paymentService.ChargeCash(paymentDetails, amount);

                Assert.IsTrue(paymentService.wasCalled);
            }


        [TestMethod]
        public void ReserveInventoryNotFail()
        {
            var reservationService = new FakeReserveInventory();

            var cart = new Cart();
            //var order = new FakeOrder(cart, paymentDetails, notificationService, reservationService, paymentService);   //Made fake order due to abstract class


            reservationService.ReserveInventory(cart);

            Assert.IsTrue(reservationService.wasCalled);
        }

    }
}
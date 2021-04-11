using System;

namespace HW4EX1
{


    public class BurgerOrderService
    {
        private IOrderBurger _orderBurger;
        private IOrderFries _orderFries;
        private IOrderCombo _orderCombo;



        public BurgerOrderService()
        {
        }

        public BurgerOrderService(IOrderBurger orderBurger, IOrderFries orderFries, IOrderCombo orderCombo)
        {
            _orderBurger = orderBurger;
            _orderFries = orderFries;
            _orderCombo = orderCombo;
        }

        public void OrderBurger(IOrderBurger orderBurger, IOrderFries orderFries, IOrderCombo orderCombo)
        {
            _orderBurger = orderBurger;
            _orderFries = orderFries;
            _orderCombo = orderCombo;


        }
        //public void OrderFries(IOrderFries orderFries)
        //{
        //    _orderFries = orderFries;
        //}
        //public void OrderCombo(IOrderCombo orderCombo)
        //{
        //    _orderCombo = orderCombo;
        //}

        public void OrderBurger(int data)
        {
            var result = _orderBurger.orderBurger(data);

            Console.WriteLine(result);
        }

        public void OrderFries(int data)
        {
            var result = _orderFries.orderFries(data);

            Console.WriteLine(result);
        }

        public void OrderCombo(int data)
        {
            var result = _orderCombo.orderCombo(data);

            Console.WriteLine(result);
        }


    }
}
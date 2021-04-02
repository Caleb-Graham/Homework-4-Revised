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

        public void OrderBurger(IOrderBurger orderBurger)
        {
            _orderBurger = orderBurger;
        }
        public void OrderFries(IOrderFries orderFries)
        {
            _orderFries = orderFries;
        }
        public void OrderCombo(IOrderCombo orderCombo)
        {
            _orderCombo = orderCombo;
        }


        //public void orderBurger(int quantity)
        //{
        //    Console.WriteLine($"Received order for {quantity} burgers");
        //}

        //public void orderFries(int fries)
        //{
        //    throw new NotImplementedException("No fries in burger only order");
        //}

        //public void orderCombo(int quantity, int fries)
        //{
        //    throw new NotImplementedException("No combo in burger only order");
        //}
    }


    public interface IOrderBurger
    {
        void OrderNormalBurger(int quantity);
    }

    class OrderBurger : IOrderBurger
    {
        public void OrderNormalBurger(int quantity)
        {
            Console.WriteLine($"Received order for {quantity} burgers");
        }
    }


    public interface IOrderFries
    {
        void orderFries(int fries);
    }

    class OrderFries : IOrderFries
    {
        public void orderFries(int fries)
        {
            throw new NotImplementedException("No fries in burger only order");
        }
    }


    public interface IOrderCombo
    {
        void orderCombo(int quantity, int fries);
    }

    class OrderCombo : IOrderCombo
    {
        public void orderCombo(int quantity, int fries)
        {
            throw new NotImplementedException("No combo in burger only order");
        }
    }

}

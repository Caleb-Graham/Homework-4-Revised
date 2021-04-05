using System;

namespace HW4EX1
{
    class Program
    {
        static void Main(string[] args)
        {
            BurgerOrder order = new BurgerOrder();
            FriesOrder orderF = new FriesOrder();
            order.orderBurger(2);       // only want a burger only order
            orderF.orderFries(0);            // throws an exception

            //order.OrderBurger(new BurgerOrder());
            
            //order.OrderFries(new FriesOrder());
        }

    }

    
    public interface IOrderBurger
    {
        void orderBurger(int quantity);
    }

    public interface IOrderFries
    {
        void orderFries(int fries);
    }

    public interface IOrderCombo
    {
        void orderCombo(int quantity, int fries);
    }


    public class BurgerOrder : IOrderBurger
    {
        public void orderBurger(int quantity)
        {
            Console.WriteLine($"Received order for {quantity} burgers");
        }
    }

    public class FriesOrder : IOrderFries
    {
        public void orderFries(int fries)
        {
            throw new NotImplementedException("No fries in burger only order");
        }
    }

    public class ComboOrder : IOrderCombo
    {
        public void orderCombo(int quantity, int fries)
        {
            throw new NotImplementedException("No combo in burger only order");
        }
    }


}

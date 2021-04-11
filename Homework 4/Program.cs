using System;

namespace HW4EX1
{
    class Program
    {
        static void Main(string[] args)
        {
            var order = new BurgerOrderService();
            //order.orderBurger(2);       // only want a burger only order
            //order.orderFries(0);            // throws an exception

            order.OrderBurger(2);
            order.OrderFries(0);


        }

    }

    
    public interface IOrderBurger
    {
        //void orderBurger(int quantity);
        object orderBurger(int quantity);
    }

    public interface IOrderFries
    {
        //void orderFries(int fries);
        object orderFries(int quantity);
    }

    public interface IOrderCombo
    {
        //void orderCombo(int quantity, int fries);
        object orderCombo(int quantity);

    }


    public class BurgerOrder : IOrderBurger
    {
        object IOrderBurger.orderBurger(int quantity)
        {
            Console.WriteLine($"Received order for {quantity} burgers");
            return quantity;
        }
    }

    public class FriesOrder : IOrderFries
    {
        public object orderFries(int quantity)
        {
            Console.WriteLine($"Received order for {quantity} burgers");
            return quantity;
        }
    }

    public class ComboOrder : IOrderCombo
    {
        public object orderCombo(int quantity)
        {
            Console.WriteLine($"Received order for {quantity} burgers");
            return quantity;
        }
    }


}

namespace HW4EX1
{
    class Program
    {
        static void Main(string[] args)
        {
            BurgerOrderService order = new BurgerOrderService();
            //order.orderBurger(2);       // only want a burger only order
            //order.orderFries(0);            // throws an exception

            order.OrderBurger(new OrderBurger()); 
            order.OrderFries(new OrderFries());
        }
    }


    //public interface IOrderBurger
    //{
    //    void orderBurger(int quantity);
    //}

    //public interface IOrderFries
    //{
    //    void orderFries(int fries);
    //}

    //public interface IOrderCombo
    //{
    //    void orderCombo(int quantity, int fries);
    //}
}

using System;

namespace InterfacesTestability
{
    class Program
    {
        static void Main(string[] args)
        {
            var orderProcessor = new OrderProcessor(new ShippingCalculator2());
            var order = new Order();
            order.DatePlaced = DateTime.Now;
            order.TotalPrice = 100f;
            orderProcessor.Process(order);
        }
    }
}

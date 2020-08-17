namespace InterfacesTestability
{
    public class ShippingCalculator2 : IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            if (order.Price > 30f) return 0;
            return order.Price * 0.1f;
        }
    }
}
using System;

namespace InterfacesTestability
{
    public class Order
    {
        public float TotalPrice { get; set; }
        public DateTime DatePlaced { get; set; }
        public float Price { get; set; }
        public bool IsShipped { get; set; }
        public Shipment shipment { get; set; }
        public Order()
        {
        }
    }
}
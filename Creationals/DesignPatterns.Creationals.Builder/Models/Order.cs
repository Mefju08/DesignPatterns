using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creationals.Builder.Models
{
    internal sealed class Order
    {
        public List<Product> Products { get; set; } = new();
        public PaymentMethods PaymentMethod { get; set; }
        public string ShippingAddress { get; set; }

        public void ShowOrder()
        {
            Console.WriteLine("Products: " + string.Join(", ", Products));
            Console.WriteLine("Payment method: " + PaymentMethod);
            Console.WriteLine("Shipping address: " + ShippingAddress);
        }
    }
}

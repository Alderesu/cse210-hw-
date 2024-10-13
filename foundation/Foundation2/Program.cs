using System;  

namespace OrderSystem  
{  
    class Program  
    {  
        static void Main(string[] args)  
        {  
            // Create address for customer 1  
            Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");  
            Customer customer1 = new Customer("Rick Grimes", address1);  
            Order order1 = new Order(customer1);  
            order1.AddProduct(new Product("Colt 45", "CT45", 999.99m, 1));  
            order1.AddProduct(new Product("Legendary Hatchet", "LH22", 29.99m, 2));  

            // Create address for customer 2  
            Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");  
            Customer customer2 = new Customer("Negan Smith", address2);  
            Order order2 = new Order(customer2);  
            order2.AddProduct(new Product("Lucille", "BT666", 199.99m, 1));  
            order2.AddProduct(new Product("Hot Iron", "HT204", 15.00m, 3));  

            // Display order details for customer 1  
            Console.WriteLine(order1.GetPackingLabel());  
            Console.WriteLine(order1.GetShippingLabel());  
            Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost():0.00}\n");  

            // Display order details for customer 2  
            Console.WriteLine(order2.GetPackingLabel());  
            Console.WriteLine(order2.GetShippingLabel());  
            Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost():0.00}\n");  
        }  
    }  
}
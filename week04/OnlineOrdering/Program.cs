using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("A Summary of Orders.");

        Customer customer1 = new Customer("Sayonara Bloom", new Address("777 Main St", "New York", "NY", "USA"));
        Customer customer2 = new Customer("Oluwafeyikunmi Akinola ", new Address("999 Maple Ave", "Toronto", "ON", "Canada"));

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "P1000", 1200, 1));
        order1.AddProduct(new Product("Iphone", "G2002", 25, 2));
        
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Tablet", "P1001", 500, 3));
        order2.AddProduct(new Product("PS5", "G2001", 50, 2));
        
        List<Order> orders = new List<Order> { order1, order2 };
        
        foreach (var order in orders)
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order.CalculateTotalCost():F2}\n");
        }
    }
    
}
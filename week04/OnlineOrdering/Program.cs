using System;

class Program
{
    static void Main(string[] args)
    {
        // Customer 1 (USA)
        Address address1 = new Address(
            "123 Main Street",
            "New York",
            "NY",
            "USA");

        Customer customer1 = new Customer("John Smith", address1);

        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Laptop", "P101", 850.00, 1));
        order1.AddProduct(new Product("Wireless Mouse", "P102", 25.50, 2));
        order1.AddProduct(new Product("Keyboard", "P103", 45.00, 1));

        // Customer 2 (International)
        Address address2 = new Address(
            "456 Queen Street",
            "Toronto",
            "Ontario",
            "Canada");

        Customer customer2 = new Customer("Emily Johnson", address2);

        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Desk Chair", "P201", 150.00, 1));
        order2.AddProduct(new Product("Monitor", "P202", 275.00, 2));

        // Display Order 1
        Console.WriteLine("===== ORDER 1 =====");
        Console.WriteLine("\nPacking Label:");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine($"\nTotal Price: ${order1.CalculateTotalCost():F2}");

        // Display Order 2
        Console.WriteLine("\n=============================\n");

        Console.WriteLine("===== ORDER 2 =====");
        Console.WriteLine("\nPacking Label:");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine($"\nTotal Price: ${order2.CalculateTotalCost():F2}");
    }
}

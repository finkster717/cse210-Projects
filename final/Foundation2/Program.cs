using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating and populating list of products for first order
        List<Product> order1Products = new List<Product>();
        order1Products.Add(new Product("Baby Monitor", "H48735", 19.99, 1));
        order1Products.Add(new Product("Diapers 76 pack", "Q79822", 39.95, 2));
        // Setting customer data for first order
        Address customer1Address = new Address("1111 SOMEWHERE DRIVE", "FLATWOODS", "KENTUCKY", "USA");
        Customer order1Customer = new Customer("Billy Ray", customer1Address);
        Order order1 = new Order(order1Products, order1Customer);

        // Creating and populating a list of products for second order
        List<Product> order2Products = new List<Product>();
        order2Products.Add(new Product("White Socks 6 pack", "C23935", 16.10, 3));
        order2Products.Add(new Product("Green Shirt", "C79822", 15.95, 2));
        order2Products.Add(new Product("Jeans", "C44589", 29.99, 1));
        // Setting customer data for second order
        Address customer2Address = new Address("1590 NOTAREALPLACE STREET", "WINNIPEG", "MANITOBA", "CANADA");
        Customer order2Customer = new Customer("Randy Bachman", customer2Address);
        Order order2 = new Order(order2Products, order2Customer);

        // Creating and populating a list of orders
        List<Order> orders = new List<Order>();
        orders.Add(order1);
        orders.Add(order2);

        // Displaying packing and shipping labels for both orders along with total price for each order
        foreach (Order order in orders)
        {
            Console.WriteLine($"PACKING LABEL:\n{order.GetPackingLabel()}");
            Console.WriteLine($"SHIPPING LABEL:\n{order.GetShippingLabel()}\n");

            Console.WriteLine($"Order Total: {order.GetOrderTotal()}");
            Console.WriteLine("---------------------------------------------------");
        }
    }
}
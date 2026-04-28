using System;
using System.Collections.Generic;

//As a backend developer, I want to manage customer orders efficiently so that I can process,
//track, and optimize order workflows in an online store.

/*Requirements
Use List<Order> to store all orders placed
Use Dictionary<int, Customer> to map customer ID to customer details
Use HashSet<string> to store unique product categories
Use Queue<Order> for order processing (FIFO)
Use Stack<string> to track order status history (LIFO)
*/

/*Expected Outcome
Add, update, and remove orders
Process orders in sequence
Track order status changes
Ensure unique product categories
*/

class Order
{
    public int OrderId;
    public string ProductName;
    public double Price;
    public string Category;
}

class Customer
{
    public int CustomeerId;
    public string Name;
}

class Program
{
    static void Main()
    {
        List<Order> orders = new List<Order>();
        Dictionary<int, Customer> customers = new Dictionary<int, Customer>();
        HashSet<string> categories = new HashSet<string>();
        Queue<Order> orderQueue = new Queue<Order>();
        Stack<string> orderHistory = new Stack<string>();

        // Adding customers
        customers.Add(1, new Customer { CustomeerId = 1, Name = "Abhishek" });

        // Adding orders
        Order order1 = new Order { OrderId = 101, ProductName = "Laptop", Price = 999.99, Category = "Electronics" };
        orders.Add(order1);
        orderQueue.Enqueue(order1);
        categories.Add(order1.Category);

        // Processing orders
        Order processed = orderQueue.Dequeue();
        Console.WriteLine($"Product: {processed.ProductName} processed for customer {customers[1].Name}");

        // Tracking order status
        orderHistory.Push("Order Placed");
        orderHistory.Push("Shipped");
        orderHistory.Push("Delivered");

        Console.WriteLine("Order Status History:");
        foreach (var s in orderHistory)
        {
            Console.WriteLine(s);
        }
    }
}
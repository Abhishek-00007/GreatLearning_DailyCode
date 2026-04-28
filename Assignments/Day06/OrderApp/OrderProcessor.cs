using System;

public class OrderProcessor
{
    // Delegate
    public delegate void OrderPlacedHandler(Order order);

    // Event
    public event OrderPlacedHandler OnOrderPlaced;

    public void PlaceOrder(Order order)
    {
        Console.WriteLine($"Order Placed: {order.OrderId}");

        // Trigger event safely
        OnOrderPlaced?.Invoke(order);
    }
}
using System;

class Program
{
    static void Main()
    {
        OrderProcessor processor = new OrderProcessor();

        EmailService emailService = new EmailService();
        SMSService smsService = new SMSService();
        LoggerService loggerService = new LoggerService();

        // Subscribe
        processor.OnOrderPlaced += emailService.SendEmail;
        processor.OnOrderPlaced += smsService.SendSMS;
        processor.OnOrderPlaced += loggerService.LogOrder;

        // Create order
        Order order = new Order
        {
            OrderId = 101,
            CustomerName = "Abhishek",
            Amount = 5000
        };

        // Process order
        processor.PlaceOrder(order);
    }
}
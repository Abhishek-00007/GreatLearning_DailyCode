using System;

// PropertyDemo class
public class PropertyDemo
{
    private int number = 5;

    public int Number
    {
        get { return number; }
    }

    private string message = "Private Value";

    public string GetMessage()
    {
        return message;
    }
}

// StaticDemo class
public class StaticDemo
{
    public static int value;

    static StaticDemo()
    {
        value = 10;
        Console.WriteLine("Static Constructor");
    }

    public static void ShowValue()
    {
        Console.WriteLine(value);
    }

    public static void ShowText()
    {
        Console.WriteLine("Static Method");
    }
}

// MathHelper static class
public static class MathHelper
{
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static int Subtract(int a, int b)
    {
        return a - b;
    }
}
public class Program
{
    public static void Main()
    {
        // PropertyDemo usage
        PropertyDemo obj = new PropertyDemo();
        Console.WriteLine(obj.Number);          // 5
        Console.WriteLine(obj.GetMessage());    // Private Value

        // StaticDemo usage
        StaticDemo.ShowValue();                 // triggers static constructor + prints 10
        StaticDemo.ShowText();                  // Static Method

        // MathHelper usage
        Console.WriteLine(MathHelper.Add(10, 5));      // 15
        Console.WriteLine(MathHelper.Subtract(10, 5)); // 5
    }
}
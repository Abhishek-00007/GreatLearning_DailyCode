using System;

// Define PropertyDemo class
public class PropertyDemo
{
    // Define properties
    // Complete Step 1:............
    private int value;
    public int Value{
        get {return value;}
        set {this.value=value;}
    }
    public string GetPrivateValue(){
        return "Private Value";
    }
}

// Define StaticDemo class
public class StaticDemo
{
    // Define static members
    // Complete Step 2:............
    public static int number;
    static StaticDemo() {
        Console.WriteLine("Static Constructor");
        number=10;
    }
    public static void Show() {
        Console.WriteLine("Static Method");
    }
}

// Define MathHelper static class
public static class MathHelper
{
    // Define static methods
    // Complete Step 3:............
    public static int Add(int a, int b){
        return a+b;
    }
}

public class Program
{
    public static void Main()
    {
        // Demonstrate usage
        // Complete Step 4:............
        PropertyDemo obj=new PropertyDemo();
        obj.Value=5;

        Console.WriteLine(obj.Value);
        Console.WriteLine(obj.GetPrivateValue());

        Console.WriteLine(StaticDemo.number);
        StaticDemo.Show();
        Console.WriteLine(MathHelper.Add(10, 5));
        Console.WriteLine(obj.Value);
    }
}
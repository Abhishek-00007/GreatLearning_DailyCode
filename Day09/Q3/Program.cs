using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Implement exception handling
        // Complete the code below to demonstrate various aspects of exception handling
        try
        {
            string input;
            if (args.Length > 0)
                input = args[0];          
            else
                input = Console.ReadLine(); 
            switch (input)
            {
                case "IndexOutOfRangeException":
                    int[] arr = new int[2];
                    Console.WriteLine(arr[5]);
                    // Trigger IndexOutOfRangeException
                    break;
                case "DivideByZeroException":
                    int x=10, y=0;
                    Console.WriteLine(x/y);
                    // Trigger DivideByZeroException
                    break;
                case "FileNotFoundException":
                    throw new System.IO.FileNotFoundException();
                    // Trigger FileNotFoundException
            }
        }
        catch (IndexOutOfRangeException ex) {
            Console.WriteLine("Index out of range error: "+ex.Message);
        }
        catch (DivideByZeroException ex) {
            Console.WriteLine("Divide by zero error: "+ex.Message);
        }
        catch(System.IO.FileNotFoundException ex) {
            Console.WriteLine("File not found error: "+ex.Message);
        }
    }
}
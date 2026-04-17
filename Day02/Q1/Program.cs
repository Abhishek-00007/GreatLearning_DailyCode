using System;

class Student
{
    public string Name;
    public int Age;
    public string Grade;


    public Student(string name, int age, string grade) {
        Name=name;
        Age=age;
        Grade=grade;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter student's name:");
        string name=Console.ReadLine();

        Console.WriteLine("Enter student's age:");
        int age=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter student's grade:");
        string grade=Console.ReadLine();

        Student student=new Student(name,age,grade);


        Console.WriteLine("Student Name: "+student.Name);
        Console.WriteLine("Student Age: "+student.Age);
        Console.WriteLine("Student Grade: "+student.Grade);
    }
}
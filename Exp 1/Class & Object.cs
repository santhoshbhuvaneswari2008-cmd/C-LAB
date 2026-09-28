using System;
class Student
{
    string name;
    int mark1, mark2, mark3;
    int total;
    double average;
    char grade;
    public void GetData()
    {
        Console.Write("Enter Student Name: ");
        name = Console.ReadLine();

        Console.Write("Enter Mark 1: ");
        mark1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Mark 2: ");
        mark2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Mark 3: ");
        mark3 = Convert.ToInt32(Console.ReadLine());
    }
    public void Calculate()
    {
        total = mark1 + mark2 + mark3;
        average = total / 3.0;

        if (average >= 90)
            grade = 'A';
        else if (average >= 75)
            grade = 'B';
        else if (average >= 60)
            grade = 'C';
        else
            grade = 'D';
    }
    public void Display()
    {
        Console.WriteLine("\nStudent Name : " + name);
        Console.WriteLine("Total Marks  : " + total);
        Console.WriteLine("Average      : " + average);
        Console.WriteLine("Grade        : " + grade);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student();

        s1.GetData();
        s1.Calculate();
        s1.Display();

        Console.ReadLine();
    }
}


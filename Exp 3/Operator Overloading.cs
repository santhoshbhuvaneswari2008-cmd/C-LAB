using System;

class Complex
{
    int real, imag;

    public Complex(int r, int i)
    {
        real = r;
        imag = i;
    }

    public static Complex operator +(Complex c1, Complex c2)
    {
        return new Complex(c1.real + c2.real, c1.imag + c2.imag);
    }

    public void Display()
    {
        Console.WriteLine(real + " + " + imag + "i");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Complex c1 = new Complex(5, 3);
        Complex c2 = new Complex(2, 4);

        Complex c3 = c1 + c2;

        Console.WriteLine("First Complex Number:");
        c1.Display();

        Console.WriteLine("Second Complex Number:");
        c2.Display();

        Console.WriteLine("After Addition:");
        c3.Display();

        Console.ReadLine();
    }
}

using System;

class Product
{
    public int productId;
    public string productName;
    public double price;

    public void GetProductDetails()
    {
        Console.Write("Enter Product ID: ");
        productId = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Product Name: ");
        productName = Console.ReadLine();

        Console.Write("Enter Price: ");
        price = Convert.ToDouble(Console.ReadLine());
    }
}

class Bill : Product
{
    int quantity;
    double total;

    public void CalculateBill()
    {
        Console.Write("Enter Quantity: ");
        quantity = Convert.ToInt32(Console.ReadLine());

        total = price * quantity;
    }

    public void DisplayBill()
    {
        Console.WriteLine("\n----- Product Bill -----");
        Console.WriteLine("Product ID   : " + productId);
        Console.WriteLine("Product Name : " + productName);
        Console.WriteLine("Price        : " + price);
        Console.WriteLine("Quantity     : " + quantity);
        Console.WriteLine("Total Amount : " + total);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Bill b = new Bill();

        b.GetProductDetails();
        b.CalculateBill();
        b.DisplayBill();

        Console.ReadLine();
    }
}

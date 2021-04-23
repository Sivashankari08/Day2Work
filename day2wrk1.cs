using System.IO;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Some value");
        var x=Console.ReadLine();
        Console.WriteLine(x);
        Console.WriteLine(x.GetType());
        Console.ReadLine();
    }
}
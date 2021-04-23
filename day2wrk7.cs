using System.IO;
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("enter a variable  ");
        var a= Console.ReadLine();
        int result;
        int.TryParse(a, out result);
        if(result == 0)
        {
           Console.WriteLine("Not a number");
        }
        else
        {
          Console.WriteLine("It is a number");
        }
       Console.ReadLine();
    }
}
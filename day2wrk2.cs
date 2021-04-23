using System.IO;
using System;
					
class Class2
{
    void CheckOddEven(int a)
    {
       if (a % 2==0)
       {
           Console.WriteLine(a + " is Even");
       }
       else
       {
           Console.WriteLine(a + " is Odd");
       }
    }
    static void Main(string[] args)
    {
        Class2 class1= new Class2();
        class1.CheckOddEven(6);
        Console.ReadLine();
    }
}
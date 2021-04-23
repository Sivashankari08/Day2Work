using System.IO;
using System;
class Class2
{
   void Swap(int a, int b)
   {
      int temp = a;
      a = b;
      b = temp;
      Console.WriteLine("Inside Swap function");
      Console.WriteLine("a= "+a);
      Console.WriteLine("b= "+b);
   }
   static void Main ()
   {
      Class2 class1= new Class2();
      int a = 1, b =2;
      class1.Swap(a,b);
      Console.WriteLine("Inside Main function");
      Console.WriteLine("a= "+a);
      Console.WriteLine("b= "+b);
      Console.ReadLine();
   }
}

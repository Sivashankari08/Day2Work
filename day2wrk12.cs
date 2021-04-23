using System.IO;
using System;

class count
    {  
         static void Main(string[] args)  
        {  
            Console.Write("Enter the String: ");   
            string inputString =Console.ReadLine(); 
            int count=0;
            for( int i=0;i<inputString.Length;i++)
            {
                if(inputString[i]=='a' || inputString[i]=='e' || inputString[i]=='i'|| inputString[i]=='o'|| inputString[i]=='u')      
                    count=count+1;
            }       
            Console.WriteLine("No of vowels are:"+count);      
    	}  
 	}
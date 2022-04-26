using System;

namespace week2lab
{
    class Program
    {
        static void Main(string[] args)
        {   
             string myname = "Fuhad";
         int myage = 16;
         float eurostodollars = 12;
         long  abc = 12;
         char charVar = 'A';
         bool boolvar = true;
         double eurostodollar = 12;
         dynamic phone = 45000;
         Nullable<int> xyz = null;
            //<<<<<Implicit conversion>>>>>>>>
            float a = myage;
            long b = myage;
            //<<<<<Explicit conversion>>>>>>>>
            double schoolfees = 12000;
            int schoolfeesint = (int)schoolfees;
            


           
            
            Console.WriteLine(myname);
            Console.WriteLine(myage);
            Console.WriteLine(eurostodollars);
            Console.WriteLine(abc);
            Console.WriteLine(charVar);
            Console.WriteLine(boolvar);
            Console.WriteLine(eurostodollar);
            Console.WriteLine(a);
            Console.WriteLine(schoolfees);
            Console.WriteLine(phone);
            Console.WriteLine(xyz);
            Console.WriteLine("Hello World!");
        }
    }
}

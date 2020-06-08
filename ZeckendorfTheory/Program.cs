using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace ZeckendorfTheory
{
    class Program
    {
        static void Main(string[] args)
        {
            int zeckendorfNumber = 0;
            int sum = 0;
            Zeckendorf zeckendorf = new Zeckendorf();
            Console.WriteLine("Type number:");
            while (true)
            {
                if (Int32.TryParse(Console.ReadLine(), out int number))
                {
                    zeckendorfNumber = number;
                    zeckendorf.SetFibonaciiList(number);
                    break;
                }
            }
            zeckendorf.AddNumbers(zeckendorfNumber);
            
            foreach (int item in zeckendorf.zeckendorfList)
            {
                Console.Write(item);
                sum += item;
                if (item != zeckendorf.zeckendorfList.Min())
                    Console.Write(" + ");
               
            }
            Console.Write(" = " + sum); ;

        }

       

      
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace ZeckendorfTheory
{
    class Program
    {
        static int zeckendorfNumber;
        static Stack<int> fibo = new Stack<int>();
        static List<int> fibo2 = new List<int>();
        static void Main(string[] args)
        {
            Console.WriteLine("Type number:");
            while (true)
            {
                if (Int32.TryParse(Console.ReadLine(), out int number))
                {
                    zeckendorfNumber = number;
                    int i = 0;
                    while (true)
                    {
                        fibo.Push(Fibo(i));
                        Console.WriteLine(Fibo(i));
                        if (fibo.Peek() > number)
                        {
                            fibo.Pop();
                            Console.WriteLine(fibo.Peek());
                            fibo2.Add(fibo.Peek());
                            break;
                        }
                        i++;
                    }
                    break;
                }
            }
            AddNumbers(zeckendorfNumber);
            int sum = 0;
            foreach (int item in fibo2)
            {
                Console.Write(item + " + ");
                sum += item;
            }
            Console.Write(" = " + sum); ;

        }

        public static void AddNumbers(int number)
        {
            if (number == 0)
                return;
            int howMuchLeft;
            if (number >= fibo.Peek())
                howMuchLeft = number - fibo.Pop();
            else
                howMuchLeft = number;
            if (howMuchLeft == 0)
                return;

            while (howMuchLeft < fibo.Peek())
                fibo.Pop();

            fibo2.Add(fibo.Pop());
                AddNumbers(howMuchLeft - fibo2.Min());
        }

        public static int Fibo(int n)
        {
            if (n == 0) return 0;
            if (n < 3) return 1;
            else return Fibo(n - 2) + Fibo(n - 1);
        }
    }
}

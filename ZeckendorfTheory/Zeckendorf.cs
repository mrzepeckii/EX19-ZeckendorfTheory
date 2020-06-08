using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZeckendorfTheory
{
    class Zeckendorf
    {
        private Stack<int> fiboList = new Stack<int>();
        public List<int> zeckendorfList = new List<int>();
        public int Fibo(int n)
        {
            if (n == 0) return 0;
            if (n < 3) return 1;
            else return Fibo(n - 2) + Fibo(n - 1);
        }

        public void SetFibonaciiList(int number)
        {
            int i = 0;
            while (true)
            {
                fiboList.Push(Fibo(i));
                if (fiboList.Peek() > number)
                {
                    fiboList.Pop();
                    zeckendorfList.Add(fiboList.Peek());
                    break;
                }
                i++;
            }
        }

        public  void AddNumbers(int number)
        {
            if (number == 0)
                return;
            int howMuchLeft;
            if (number >= fiboList.Peek())
                howMuchLeft = number - fiboList.Pop();
            else
                howMuchLeft = number;
            if (howMuchLeft == 0)
                return;

            while (howMuchLeft < fiboList.Peek())
                fiboList.Pop();

            zeckendorfList.Add(fiboList.Pop());
            AddNumbers(howMuchLeft - zeckendorfList.Min());
        }
    }
}

using System;
using System.Collections.Generic;

namespace dontnet
{
    class SecondLab
    {
        public double number;
        public char character;

        static double Something(double n)
        {
            return n;
        }

        static char Something(char c)
        {
            return c;
        }

        static double Something(double n, char c)
        {
            Console.WriteLine(c);
            return n;
        }

        static double Something(double n1, double n2)
        {
            if (n1 == 0)
                return n2;
            return Something(n2 % n1, n2);
        }

        static HashSet<int> Something(int[] array)
        {
            HashSet<int> NoPrime = new HashSet<int>();

            int n = 2000000;

            for (int x = 2; x < n; x++)
            {
                for (int y = x * 2; y < n; y += x)
                {

                    if (!NoPrime.Contains(y))
                        NoPrime.Add(y);
                }
            }

            return NoPrime;
        }
    }
}

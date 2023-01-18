using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "Unnniiiiwwerrrsyyyttttteeeeet Gddddaansssskkii​";
            string result = RLE(s);
            Console.WriteLine("RLE result is " + result);
            Console.ReadKey();
        }

        private static string RLE(string s)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(s[0]);
            int counter = 1;
            for (int i = 1; i<s.Length; i++)
            {
                if (s[i] == s[i - 1])
                {
                    counter++;
                } else
                {
                    if (counter > 1)
                    {
                        sb.Append(counter.ToString());
                    }
                    sb.Append(s[i]);
                    counter = 1;
                }
            }
            return sb.ToString();
        }
    }

    internal abstract class First
    {
        public abstract int f(int x, int y);
        public virtual int r(int x, int y)
        {
            return x - y;
        }
    }

    internal class Second : First
    {
        public override int f(int x, int y)
        {
            return x + y;
        }

        public override int r(int x, int y)
        {
            return x * y;
        }
    }
}

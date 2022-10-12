using System;
using System.Collections.Generic;
using System.Linq;

namespace dontnet
{
    internal class Program
    {
        static void FirstExercise()
        {
            Console.WriteLine("Uzycie petli for:");
            for (int i1 = 100; i1 > 0; i1--)
            {
                if (i1 % 3 == 0 && i1 % 2 != 0)
                {
                    Console.WriteLine(i1);
                }
            }

            Console.WriteLine("Uzycie petli while:");
            int i2 = 100;
            while (i2 > 0)
            {
                if (i2 % 3 == 0 && i2 % 2 != 0)
                {
                    Console.WriteLine(i2);
                }
                i2--;
            }

            Console.WriteLine("Uzycie petli do...while:");
            int i3 = 100;
            do
            {
                if (i3 % 3 == 0 && i3 % 2 != 0)
                {
                    Console.WriteLine(i3);
                }
                i3--;
            } while (i3 > 0);
        }

        static void SecondExercise()
        {
            // you can specify how many rows there will be
            int rows = 4;

            // populate "triangular" version of 2D array
            int[][] array = new int[rows][];
            for (int x = 0; x < rows; x++)
            {
                array[x] = new int[x + 1];
            }
            
            // print numbers out
            int counter = 1;
            for (int i = 0; i < array.Length; i++) {
                for (int j = 0; j < array[i].Length; j++) {
                    Console.Write(counter++ + " ");
                }
                Console.WriteLine();
            }
        }

        static int[] CreateFib(int len)
        {
            int[] fib = new int[len];
            int x = 1;
            int y = 1;
            int temp;
            for (int i = 0; i < len; i++)
            {
                fib[i] = x;
                temp = x;
                x = y;
                y = temp + y;
            }
            return fib;
        }
        static void ThirdExercise()
        {
            int range = 10;
            int[] outer = CreateFib(range);
            int counter = 0;
            foreach (int i in outer)
            {
                IEnumerable<int> inner = Enumerable.Range(1, i).Reverse();
                Console.WriteLine("Fib[" + counter + "]: " + string.Join(", ", inner));
                counter++;
            }
        }


        static void Main(string[] args)
        {
            // FirstExercise();
            // SecondExercise();
            ThirdExercise();

            Console.ReadLine(); // or use CTRL+F5
        }
    }
}

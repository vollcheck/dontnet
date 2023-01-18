using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOandClientServer
{
    internal class Second
    {
        public static void Compute()
        {
            Console.WriteLine("Give me A, B and C and I'll compute the quadratic equation");
            int a, b, c;
            double delta, x1, x2;
            Console.WriteLine("Give me A:");
            a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Give me B:");
            b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Give me C:");
            c = Int32.Parse(Console.ReadLine());

	        delta = b * b - 4 * a * c;
	        if (delta > 0) {
  	            x1 = ((-b + Math.Sqrt(b * b - 4 * a * c)) / 2 * a);
		        x2 = ((-b - Math.Sqrt(b * b - 4 * a * c)) / 2 * a);
		        Console.WriteLine("Delta is positive, there are two solutions");
		        Console.WriteLine("The resuls are: " + x1 + " " + x2);
	        } else if (delta == 0) {
	            x1 = ((-b + Math.Sqrt(b * b - 4 * a * c)) / 2 * a);
	            Console.WriteLine("Delta is 0, there is only one solution");
	            Console.WriteLine("The result is: " + x1);
	        } else {
	            Console.WriteLine("Your quadratic equation has no solutions");
	        }
	    
            Console.ReadKey();
        }
    }
}

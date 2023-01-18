using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Streams
{
    internal class Program
    {
        static int INTERVAL = 10000;

        static void Main(string[] args)
        {
            // Instantiate random number generator using
            // system-supplied value as seed
            var rand = new Random();
            double rand_x, rand_y, origin_dist, pi = 0;
            int circle_points = 0, square_points = 0;

            // Total Random numbers generated = possible x
            // values * possible y values
            for (int i = 0; i < (INTERVAL * INTERVAL); i++)
            {

                // Randomly generated x and y values in the
                // range [-1,1]
                rand_x = (double)(rand.Next() % (INTERVAL + 1))
                  / INTERVAL;
                rand_y = (double)(rand.Next() % (INTERVAL + 1))
                  / INTERVAL;

                // Distance between (x, y) from the origin
                origin_dist = rand_x * rand_x + rand_y * rand_y;

                // Checking if (x, y) lies inside the define
                // circle with R=1
                if (origin_dist <= 1)
                    circle_points++;

                // Total number of points generated
                square_points++;

                // estimated pi after this iteration
                pi = ((4.0 * circle_points) / square_points);

                // For visual understanding (Optional)
                // System.out.println(rand_x+" "+rand_y+"
                // "+circle_points+" "+square_points+" - "+pi);
            }

            // Final Estimated Value
            Console.WriteLine("Final Estimation of Pi = " + pi);

            string filename = "result.txt";
            using (FileStream file = File.Create(filename))
            {
                using (BinaryWriter writer = new BinaryWriter(file))
                {

                    writer.Write(pi.ToString());
                }
            }

            Console.WriteLine("Result has been saved to the file {0}", filename);

            Console.ReadKey();
        }
    }
}

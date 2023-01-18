﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOandClientServer
{
    internal class Third
    {
		public static void Compute()
		{
			Console.WriteLine("Give me line of numbers separated by comma (,)");
			Console.WriteLine("I'll return all primary numbers");
			string line = Console.ReadLine();
			List<int> numbers = new List<int>();
			foreach (string s in line.Split(','))
				numbers.Add(int.Parse(s));

			int maxNum = numbers.Max();

			// List<int> primes = new List<int>();

			numbers.Sort();

			bool[] primes = new bool[numbers.Count + 1];
			for (int i = 0; i < primes.Length + 1; i++)
            {
				primes[i] = true;
            }

			for (int i=2; i<Math.Sqrt(maxNum) + 1; i++) {
				if (primes[i-1]) {
					for (int j=(int) Math.Pow(i,2); j<=maxNum; j+=i) {
						primes[j - 1] = false;
					}
			    }
			}

			for (int i = 2; i < primes.Length; i++) {
				if (primes[i - 1]) {
					Console.WriteLine(i);
				}
			}

			Console.ReadKey();
        }
    }
}


// using System;

// /// Implementation of the sieve of Eratosthenes for finding all the primes up to
// /// a given number (MAX in this case).
// /// From the command line:
// ///   Step 1 (Compile): csc PrimesSieve.cs
// ///   Step 2 (Run):     .\PrimesSieve
// public class PrimesSieve {
//   static void Main() {
//     const int MAX = 1000000;
//     // Create an array of boolean values indicating whether a number is prime.
//     // Start by assuming all numbers are prime by setting them to true.
//     bool[] primes = new bool[MAX + 1];
//     for (int i=0; i<primes.Length; i++) {
//       primes[i] = true;
//     }
		
//     // Loop through a portion of the array (up to the square root of MAX). If
//     // it's a prime, ensure all multiples of it are set to false, as they
//     // clearly cannot be prime.
//     for (int i=2; i<Math.Sqrt(MAX)+1; i++) {
//       if (primes[i-1]) {
//         for (int j=(int) Math.Pow(i,2); j<=MAX; j+=i) {
//           primes[j - 1] = false;
//         }
//       }
//     }

//     // Output the results
//     int count = 0;
//     for (int i = 2; i < primes.Length; i++) {
//       if (primes[i - 1]) {
//         Console.WriteLine(i);
//         count++;
//       }
//     }
//     Console.WriteLine($"There are {count} primes up to {MAX}");
//   }
// }

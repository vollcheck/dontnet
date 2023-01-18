using System;

namespace IOandClientServer
{
    internal class First
    {
        public static void Encode() {
            Console.WriteLine("Input a char and I'll encode it using Caesar cypher");
            Console.WriteLine("[Esc] will terminate a program");
            
            Console.WriteLine("But let's actually start with defining a shift for the cypher: ");
            int k = Int32.Parse(Console.ReadLine());

            Console.WriteLine("now you can type the characters!");
            
            ConsoleKeyInfo keyInfo;
            char c, offset;

            do
            {
                keyInfo = Console.ReadKey(true);
                c = keyInfo.KeyChar;
                if (!char.IsLetter(c))
                {
                    Console.WriteLine("What you typed isn't really a character...");
                }
                offset = char.IsUpper(c) ? 'A' : 'a';
                char result = (char)(((c + k - offset) % 26) + offset);
                Console.WriteLine("you typed " + c + " but we changed it to " + result) ;

            }
            while (keyInfo.Key != ConsoleKey.Escape);
        }
    }
}
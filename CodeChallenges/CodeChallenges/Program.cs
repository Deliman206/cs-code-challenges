using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Sean's C# Coding Challenges.");
            menu();
            Console.Read();
        }
        static string menu()
        {
            Console.WriteLine("Choose from the following titles to run its code.");
            Console.WriteLine("-Challenge01\n");
            string challenge = Console.ReadLine();
            return challenges(challenge);
        }
        static string challenges(string challenge)
        {
            switch (challenge)
            {
                case "Challenge01":
                    return challenge01();
                default:
                    return menu();
            }
        }
        static string challenge01()
        {
            Console.WriteLine("Hello World!");
            string x = "one";
            return x;
        }
    }
}

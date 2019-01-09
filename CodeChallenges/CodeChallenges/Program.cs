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
        static int[] menu()
        {
            Console.WriteLine("Choose from the following titles to run its code.");
            Console.WriteLine("-insertShiftArray\n");
            string challenge = Console.ReadLine();
            return challenges(challenge);
        }
        static int[] challenges(string challenge)
        {
            switch (challenge)
            {
                case "insertShiftArray":
                    return insertShiftArray();
                default:
                    return menu();
            }
        }
        static int[] insertShiftArray()
        {
            bool done = false;
            List<int> nums = new List<int>();
            Console.WriteLine("Okay, lets use an insert and shift array.\nGive me some numbers to put into the array\nHit ENTER when done");

            // Add Inputs to List
            while(done == false)
            {
                Console.WriteLine("\nEnter a number or hit ENTER:");
                string x = Console.ReadLine();

                if (x == "")
                {
                    done = true;
                    break;
                }
                Int32.TryParse(x, out int num);
                nums.Add(num);
            }

            // Convert List to array and clear the list
            int[] arguementArray = nums.ToArray();
            nums.Clear();

            // Now ask for the number they want to insert
            Console.WriteLine("\nNow enter the number which you wish to put in the middle:");
            string y = Console.ReadLine();
            Int32.TryParse(y, out int arguementValue);

            //Now we will call the method with our created arguements
            return _insertShiftArray(arguementArray,arguementValue);
        }
        static int[] _insertShiftArray(int[] array, int value)
        {

            int[] solutionArray = new int[array.Length + 1];
            bool flag = false;
            
            for (int counter = 0; counter < solutionArray.Length; counter++)
            {
                if (flag == true)
                {
                    solutionArray[counter] = array[counter - 1];
                    continue;
                }
                if(counter == array.Length/2)
                {
                    solutionArray[counter] = value;
                    flag = true;
                    continue;
                }
                solutionArray[counter] = array[counter];
            }
            foreach(int num in solutionArray)
            {
                Console.WriteLine(num);
            }
            return solutionArray;
        }
    }
}

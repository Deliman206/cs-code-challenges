using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Sean's C# Coding Challenges.");
            menu();
            Console.Read();
        }
        static void menu()
        {
            Console.WriteLine("Choose from the following titles to run its code.");
            Console.WriteLine("-insertShiftArray\n-BinarySearch\n");
            string challenge = Console.ReadLine();
            challenges(challenge);
        }
        static void challenges(string challenge)
        {
            if (challenge == "insertShiftArray")
            {
                insertShiftArray();
            }
            if (challenge == "BinarySearch")
            {
                BinarySearch();
            }
        }
        static void insertShiftArray()
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
            _insertShiftArray(arguementArray,arguementValue);
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

        static void BinarySearch()
        {
            bool done = false;
            List<int> nums = new List<int>();
            Console.WriteLine("Okay, lets use a binary search.\nGive me some numbers to put into the array\nHit ENTER when done");

            // Add Inputs to List
            while (done == false)
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
            int[] numArray = nums.ToArray();
            nums.Clear();

            // Sort the array
            Array.Sort(numArray);

            // Now ask for the number they want to insert
            Console.WriteLine("\nNow enter the number which you wish to search for:");
            string y = Console.ReadLine();
            Int32.TryParse(y, out int value);

            //Now we will call the method with our created arguements
            _BinarySearch(numArray, value);
        }
        public static int _BinarySearch(int[] sortedArray, int value)
        {
            int min = 0;
            int max = sortedArray.Length - 1;
            int mid = (min + max) / 2;

            while (min <= max)
            {
                mid = (max + min) / 2;

                if (sortedArray[mid] == value)
                {
                    return mid;
                }
                else if (sortedArray[mid] < value)
                {
                    min = mid + 1;
                }
                else
                {
                    max = mid - 1;
                }
            }
            return -1;
        }

    }
}

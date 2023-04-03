using System;
using System.IO;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Environment.CurrentDirectory + "/input.txt";
            int sum = 0;
            string[] nums = File.ReadAllLines(path);
            if (nums.Length != 0)
            {
                int[] numbers = new int[nums.Length];
                for (int i = 0; i < nums.Length; i++)
                {
                    numbers[i] = Convert.ToInt32(nums[i]);
                    sum += numbers[i];
                }
                int avg = sum / numbers.Length;
                int count = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    count += Math.Abs(numbers[i] - avg);
                }
                Console.WriteLine("Answer: " + count);
                Console.WriteLine("Press any key to close...");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("File is empty! Fill in the input.txt file.");
                Console.WriteLine("Press any key to close...");
                Console.ReadLine();
            }
        }
    }
}

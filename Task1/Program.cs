using System;
using System.IO;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path = Environment.CurrentDirectory + "\\input.txt";
                StreamReader input = new StreamReader(path);
                int n = Convert.ToInt32(input.ReadLine());
                int m = Convert.ToInt32(input.ReadLine());
                if (n == 0 || m == 0)
                {
                    Console.WriteLine("Enter the correct values in the file!");
                    input.Close();
                    Console.WriteLine("Press any key to close...");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Answer: " + algorithm(n, m));
                    input.Close();
                    Console.WriteLine("Press any key to close...");
                    Console.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static string algorithm(int n, int m)
        {
            string result = "";
            int tempPos = 1;
            while ((tempPos + (m - 1)) % n != 1)
            {
                result += tempPos;
                tempPos += (m - 1);
                tempPos %= n;
                if (tempPos % n == 0)
                {
                    tempPos = n;
                }
            }
            result += tempPos;
            return result;
        }
    }
}

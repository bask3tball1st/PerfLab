using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string result = "";
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
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
            Console.WriteLine(result);
            //string path = "D:/Skillbox/Task1/Task1/input.txt";
            //StreamReader input = new StreamReader(path);
            //string line = input.ReadLine();
            //foreach (var i in line.Split())
            //{
            //    Console.WriteLine(i);
            //}
            Console.ReadLine();
        }
    }
}

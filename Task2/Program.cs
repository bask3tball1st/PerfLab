using System;
using System.IO;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path1 = "test1.txt";
                string path2 = "test2.txt";
                StreamReader input = new StreamReader(path1);
                string line = input.ReadLine();
                string[] buffer = line.Split(' ');
                double circleX = double.Parse(buffer[0]);
                double circleY = double.Parse(buffer[1]);
                double radius = double.Parse(input.ReadLine());
                input.Close();
                string[] points = File.ReadAllLines(path2);
                for (int i = 0; i < points.Length; i++)
                {
                    double pointX = double.Parse(points[i].Split(' ')[0]);
                    double pointY = double.Parse(points[i].Split(' ')[1]);
                    double dist = distance(pointX, pointY, circleX, circleY);
                    result(radius, dist);
                }
                Console.Write("\nPress any key to close...");
                Console.ReadLine();
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static double distance(double px, double py, double cx, double cy)
        {
            return Math.Sqrt(Math.Pow(px - cx, 2) + Math.Pow(py - cy, 2));
        }

        static void result(double radius, double distance)
        {
            if (distance < radius)
            {
                Console.Write(1 + " ");
            }
            else if (distance == radius)
            {
                Console.Write(0 + " ");
            }
            else
            {
                Console.Write(2 + " ");
            }
        }
    }
}

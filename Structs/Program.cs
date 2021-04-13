using System;
using System.Windows.Forms;

namespace Structs
{
    internal class Program
    {
        enum Color
        {
            Red = 237, 
            Green = 74, 
            Blue = 118
        }
        public static void Main(string[] args)
        {
            foreach (var key in Enum.GetValues(typeof(Keys)))
            {
                Console.WriteLine($"Code: {(int)key, 7} -> Key: {key}");
            }
            
            
            /*Point a = new Point(12, 23);
            Point b = new Point(12, 23);
            
            Console.WriteLine(a);
            Console.WriteLine(b);*/

            /*Random rand = new Random();
            Point[] arr = new Point[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i].X = rand.Next(10);
                arr[i].Y = rand.Next(100);
            }

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");
            foreach (var point in arr)
            {
                Console.WriteLine(point);
            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");
            Array.Sort(arr, 0, arr.Length);
            foreach (var point in arr)
            {
                Console.WriteLine(point);
            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");*/

            /*Color a = Color.Blue;
            Console.WriteLine(a);
            Console.WriteLine((int)a);

            Color b = (Color)118;
            Console.WriteLine(b);*/

            /*foreach (var color in Enum.GetNames(typeof(Color)))
            {
                Console.WriteLine(color);
            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");
            foreach (var color in Enum.GetValues(typeof(Color)))
            {
                Console.WriteLine($"Color: {color} -> Code: {(int)color}");
            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");
            
            foreach (var color in Enum.GetValues(typeof(ConsoleColor)))
            {
                Console.ForegroundColor = (ConsoleColor) color;
                Console.BackgroundColor = (ConsoleColor) (15-(int)color);
                //Console.BackgroundColor = (ConsoleColor)color;
                Console.WriteLine($"Color: {color, 11} -> Code: {(int)color}");
            }
            Console.Clear();*/
        }
    }
}
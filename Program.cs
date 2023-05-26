using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Moi ban nhap so dong cua mang: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write(" Moi ban nhap so cot cua mang: ");
            int y = int.Parse(Console.ReadLine());

            int[,] arr = new int[x, y];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(" Moi ban nhap phan tu IntArray[{0}, {1}] = ", i, j);
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int max = arr[0, 0];

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                    }

                }
            }

            //Print Array Elements
            Console.Write("Array Elements\n");
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(arr[i, j] + ", ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //Print max and min number
            Console.WriteLine("Maximum element:" + max);

            Console.ReadKey();
        }
    }
}








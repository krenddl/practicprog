using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] randtemparray = new int[7];
            for (int i = 0; i < randtemparray.Length; i++)
            {
                randtemparray[i] = random.Next(-100, 100);
            }
            int[] temparray = { 15, 16, 17, 18, 19, 20, 21 };
            int Average = (temparray.Sum() / (temparray.Length));
            int operation = int.Parse(Console.ReadLine());

            int[,] HighMap = new int[5,5];
            for (int i =0; i <  HighMap.GetLength(0); i++)
            {
                for(int j=0;  j < HighMap.GetLength(1); j++)
                {
                    HighMap[i, j] = random.Next(0, 1000);
                }
            }


            switch(operation)
            {
                case 1:
                    for (int i = 0; i< randtemparray.Length; i++)
                    {
                        Console.Write(randtemparray[i] + " ");
                    }
                    return;

                case 2:
                    Console.WriteLine(Average);
                    return;
                case 3:

       



            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrixarray = new int[3, 4]
            {
                    {12, 14, 15, 16},
                    {17, 18, 19, 20},
                    {21, 22, 23, 24}
            };
            int Rows = matrixarray.GetLength(0);
            int Columns = matrixarray.GetLength(1);

            foreach (var i in Enumerable.Range(0, Rows))
            {
                foreach (var j in Enumerable.Range(0, Columns))
                {
                    Console.Write(matrixarray[i,j]+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    Console.Write(matrixarray[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Enter Value 1 example Row");
            int UserRow = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Value 2 example Coloumn");
            int UserColoumn = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Multiply Value example Row+Coloumn*YourValue");
            int UserNum = int.Parse(Console.ReadLine());

            int[,] MultidimensionalArray = new int [UserRow, UserColoumn];

























            int ArrayRow = MultidimensionalArray.GetLength(0);
            int ArrayCol = MultidimensionalArray.GetLength(1);
            for (int i = 0; i < ArrayRow; i++)
            {
                for (int j = 0; j < ArrayCol; j++)
                {
                    Console.Write(MultidimensionalArray[i , j] = i * UserNum + j * UserNum);
                    Console.Write(" ");
                }
                Console.ReadLine();
            }
            Console.ReadLine();
        }

    }
}

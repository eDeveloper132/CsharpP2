using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Project2
{
    internal class Program
    {
        public static int Add(int a , int b ,int c , int d)
        {
            return a + b + c + d;
        }
        public static int Percentage(int a,int b,int c)
        {
            return (a * c) / b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("********************AS SALAM U ALAIKUM*****************************");
            Console.WriteLine("***************WELCOME TO EXAMINATION PORTAL*****************************");
            Console.WriteLine("*******************************************************************************************");
            Console.WriteLine("Enter Subject 1");
            string sub1 = Console.ReadLine();
            Console.WriteLine("Enter Subject 2");
            string sub2 = Console.ReadLine();
            Console.WriteLine("Enter Subject 3");
            string sub3 = Console.ReadLine();
            Console.WriteLine("Enter Subject 4");
            string sub4 = Console.ReadLine();
            string[] subjects = { sub1, sub2, sub3, sub4 };
            int[] TotalMarks = { 75, 100, 75, 100 };
            Console.WriteLine("*******************************************************************************************");
            Console.WriteLine($"Total marks of {subjects[0]} is {TotalMarks[0]}");
            Console.WriteLine($"Total marks of {subjects[1]} is {TotalMarks[1]}");
            Console.WriteLine($"Total marks of {subjects[2]} is {TotalMarks[2]}");
            Console.WriteLine($"Total marks of {subjects[3]} is {TotalMarks[3]}");
            Console.WriteLine("*******************************************************************************************");
            Console.WriteLine($"Enter {subjects[0]} obtained marks");
            var obt1 = int.Parse(Console.ReadLine());
            if (obt1 < 0 || obt1 > TotalMarks[0])
            {
                Console.WriteLine($"Total marks of  {subjects[0]}  is  {TotalMarks[0]}");
                Console.Write("Please Enter correct number");
                Console.WriteLine();
                obt1 = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Enter {subjects[1]} obtained marks");
            var obt2 = int.Parse(Console.ReadLine());
            if (obt2 < 0 || obt2 > TotalMarks[1])
            {
                Console.WriteLine($"Total marks of  {subjects[1]}  is  {TotalMarks[1]}");
                Console.WriteLine("Please Enter correct number");
                Console.WriteLine();
                obt2 = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Enter {subjects[2]} obtained marks");
            var obt3 = int.Parse(Console.ReadLine());
            if (obt3 < 0 || obt3 > TotalMarks[2])
            {
                Console.WriteLine($"Total marks of  {subjects[2]}  is  {TotalMarks[2]}");
                Console.WriteLine("Please Enter correct number");
                Console.WriteLine() ;
                obt3 = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Enter {subjects[3]} obtained marks");
            var obt4 = int.Parse(Console.ReadLine());
            if (obt4 < 0 || obt4 > TotalMarks[3])
            {
                Console.WriteLine($"Total marks of  {subjects[3]}  is  {TotalMarks[3]}");
                Console.WriteLine("Please Enter correct number");
                Console.WriteLine();
                obt4 = int.Parse(Console.ReadLine());
            }
            int[] obtained = { obt1, obt2, obt3, obt4 };
            //Console.WriteLine($"{obtained[0]}, {obtained[1]}, {obtained[2]}, {obtained[3]}");
            Console.WriteLine("*******************************************************************************************");
            //Console.WriteLine($"{subjects[0]}   {subjects[1]}   {subjects[2]}   {subjects[3]}");
            Console.WriteLine($"The Subject {subjects[0]} You Obtained From {TotalMarks[0]} is : {obtained[0]}");
            Console.WriteLine($"The Subject {subjects[1]} You Obtained From {TotalMarks[1]} is : {obtained[1]}");
            Console.WriteLine($"The Subject {subjects[2]} You Obtained From {TotalMarks[2]} is : {obtained[2]}");
            Console.WriteLine($"The Subject {subjects[3]} You Obtained From {TotalMarks[3]} is : {obtained[3]}");
            Console.WriteLine("*******************************************************************************************");
            int SuppliCount = 0;
            var TotalObtained = obtained[0] + obtained[1] + obtained[2] + obtained[3];
            var TotalNumber = TotalMarks[0] + TotalMarks[1] + TotalMarks[2] + TotalMarks[3];
            var Percentage = (TotalObtained * 100) / TotalNumber;
            Console.WriteLine($"Total Obtained Marks is : " + Program.Add(obtained[0], obtained[1], obtained[2], obtained[3])+" From Total Marks : " + Program.Add(TotalMarks[0], TotalMarks[1], TotalMarks[2], TotalMarks[3])+" And Your Whole Percentage is : "+ Program.Percentage(TotalObtained, TotalNumber, 100));
            if(Percentage <= 100 && Percentage >= 80)
            {
                Console.WriteLine("****************************Your Grade is : \u001b[1m A \u001b[0m*******************************");
            }
            else if(Percentage <= 79 && Percentage >= 60)
            {
                Console.WriteLine("****************************Your Grade is : \u001b[1m B \u001b[0m*******************************");
            }
            else if(Percentage <= 59 && Percentage >= 40)
            {
                Console.WriteLine("****************************Your Grade is : \u001b[1m C \u001b[0m*******************************");
            }
            else
            {
                Console.WriteLine("****************************Your Grade is : \u001b[1m Fail \u001b[0m Do Some Hardwork*******************************");
            }
            if (SuppliCount == 0)
                for(int i = 0; i <= 3 ; i++)
                {
                    if (obtained[i] < 33)
                    {
                        ++SuppliCount;
                    }
                }
            else
            {
                Console.WriteLine("Value Not Found");
            }
            Console.WriteLine($"****************************Your Suppli Count is : \u001b[1m {SuppliCount} \u001b[0m *******************************");
            Console.ReadLine();
            //if (obtained[0] <= 25 && obtained[0] >= 0)
            //{
            //        ++SuppliCount;
            //        Console.WriteLine($"****************************Your Suppli Count is : \u001b[1m {SuppliCount} \u001b[0m *******************************");
            //}
            //else if (obtained[1] <= 33 && obtained[1] >= 0)
            //{
            //        ++SuppliCount;
            //        Console.WriteLine($"****************************Your Suppli Count is : \u001b[1m {SuppliCount} \u001b[0m *******************************");
            //}
            //else if (obtained[2] <= 25 && obtained[2] >= 0)
            //{
            //        ++SuppliCount;
            //        Console.WriteLine($"****************************Your Suppli Count is : \u001b[1m {SuppliCount} \u001b[0m *******************************");
            //}
            //else if (obtained[3] <= 33 && obtained[3] >= 0)
            //{   
            //        ++SuppliCount;
            //        Console.WriteLine($"****************************Your Suppli Count is : \u001b[1m {SuppliCount} \u001b[0m *******************************");
            //}
            //else
            //{
            //    Console.WriteLine("Value Not Found");
            //}
            //int[,] matrixarray = new int[3, 4]
            //{
            //        {12, 14, 15, 16},
            //        {17, 18, 19, 20},
            //        {21, 22, 23, 24}
            //};
            //int Rows = matrixarray.GetLength(0);
            //int Columns = matrixarray.GetLength(1);

            //foreach (var i in Enumerable.Range(0, Rows))
            //{
            //    foreach (var j in Enumerable.Range(0, Columns))
            //    {
            //        Console.Write(matrixarray[i,j]+" ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine();
            //for (int i = 0; i < Rows; i++)
            //{
            //    for (int j = 0; j < Columns; j++)
            //    {
            //        Console.Write(matrixarray[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("Enter Value 1 example Row");
            //int UserRow = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Value 2 example Coloumn");
            //int UserColoumn = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Multiply Value example Row+Coloumn*YourValue");
            //int UserNum = int.Parse(Console.ReadLine());

            //int[,] MultidimensionalArray = new int [UserRow, UserColoumn];

            //int ArrayRow = MultidimensionalArray.GetLength(0);
            //int ArrayCol = MultidimensionalArray.GetLength(1);
            //for (int i = 0; i < ArrayRow; i++)
            //{
            //    for (int j = 0; j < ArrayCol; j++)
            //    {
            //        Console.Write(MultidimensionalArray[i , j] = i * UserNum + j * UserNum);
            //        Console.Write(" ");
            //    }
            //    Console.ReadLine();
            //}
        }

    }
}

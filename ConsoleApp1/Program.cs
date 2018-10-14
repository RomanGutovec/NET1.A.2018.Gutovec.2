using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ////int[] actualArray = { 3, 5, 1, 0, 2, 3,2,3 };

            ////Console.WriteLine(Algorithms.Algorithms.FindIndexWhereSumLeftAndRightPartEqual(actualArray));
            ////Console.ReadLine();

            ////string str1 ="Ffffffffirsttttttt";
            ////string str2 = "Tesrtttttttttta";

            ////Console.WriteLine(Algorithms.Algorithms.ConcatTwoStringTask4(str1, str2));
            ////Console.ReadLine();
            ////int[] arr = new int[10];
            ////arr=Algorithms.Algorithms.DevideOnSimple(7856);
            ////for (int i = 0; i < arr.Length; i++)
            ////{
            ////    Console.WriteLine(arr[i]);
            ////}
            ////Console.ReadLine();
            ////Algorithms.Algorithms.FindNumbersMore(3456432);
            ////Console.ReadLine();
            //int[] sortedArray = { 1, 2, 3, 4, 5, 6 };
            //int[] temp = new int[5];
            ////int res[]=new int[5]
            //int index = 2;
            //temp = sortedArray.Skip(index).Reverse().ToArray();
            //for (int j = 0; j < temp.Length - index; j++)
            //{
            //    //res[j] = temp[j];
            //    Console.WriteLine("elem {0}", temp[j]);
            //}
            //Console.ReadLine();
            //int i = 3;


            //byte x = 15;

            //// получаем биты числа
            //for (int i = 0; i < 8; ++i)
            //    Console.WriteLine((x >> i) & 1);
            //Console.ReadLine();


            Console.WriteLine( Algorithms.Algorithm.InsertNumber(11, 8, 2, 8) );
            Console.ReadLine();
        }
    }
}


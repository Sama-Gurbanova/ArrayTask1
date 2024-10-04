using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TASK 4 -Verilmiş array-ın elementlərinin sayının tapılması.

            //int[] array = { 15, 48, 23, 90, 67, 88, 32};
            //int count = array.Length;
            //Console.WriteLine("Number of elements in array:" +count);




            //TASK 5-Verilmiş elementin array-in daxilində yer alıb-almaması məlumatının əldə edilməsi.

            //int[] array = { 15, 48, 23, 90, 67, 88, 32 };
            //int elemenet = 88;
            //bool result = false;

            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] == elemenet)
            //    {
            //        result = true;
            //        break;
            //    }

            //}
            //if (result)
            //{
            //    Console.WriteLine("The element is in an array");
            //}
            //else
            //{
            //    Console.WriteLine("The element is not in the array");
            //}






            // TASK 6- Verilmiş element array daxilində yer alırsa neçə dəfə təkrarlandığı məlumatının əldə edilməsi.

            int[] array = { 1, 2, 3, 4, 2, 5, 6, 2 };
            int element = 2;
            int count = 0;

            for ( int i = 0; i < array.Length; i++ )
            {
                if (array[i] == element)
                {
                    count++;
                }
            }
            Console.WriteLine(count);












        }
    }
}

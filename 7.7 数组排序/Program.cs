using System;

namespace _7._7_数组排序
{
    class Program
    {
        static void Main(string[] args)
        {
            //数组排序主要通过Array类下的Sort与Reverse进行排序
            int[] myintArray = { 1, 52, 3, 34, 52, 6, 37, 23, 45, 67 };

            //将给定的数组进行排序
            Array.Sort(myintArray);
            Console.WriteLine("sort排序，正序");
            foreach (var item in myintArray)
            {
                Console.Write(item+" ");
            }

            //利用Reverse可以实现数组元素的降序排列，更改原数组的存储位置
            Console.WriteLine("\nreverse排序，倒序：");
            Array.Reverse(myintArray);
            foreach (var item in myintArray)
            {
                Console.Write(item + " ");
            }

            Console.ReadKey();
        }
    }
}

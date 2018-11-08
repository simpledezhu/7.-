using System;

namespace _7._8_数组的合并与拆分
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num1 = { 1, 2, 3, 4, 5 };
            int[] num2 = { 6, 7, 8, 9, 10 };
            Console.WriteLine("原num1数组为：");
            foreach (var item in num1)
            {
                Console.Write(item+" ");
            }

            Console.WriteLine("\n原num2数组为：");
            foreach (var item in num2)
            {
                Console.Write(item+" ");
            }

            int[] resultNum = new int[20];
            //表示将num1中数组元素从索引值0开始，去5个长度放入到resultNum中
            //在resultNum中从索引值0开始存放

            Array.Copy(num1, resultNum, 5);
            Console.WriteLine("\n使用第一种copy");
            foreach (var item in resultNum)
            {
                Console.Write(item + " ");
            }

            //将num2复制到以上的resultNum中
            //从num2索引值从0开始取10个长度，放入到resultNum中并从索引值0开始进行存放。
            Console.WriteLine("\n使用第三种copy");
            Array.Copy(num2,0,resultNum,5,5);
            foreach (var item in resultNum)
            {
                Console.Write(item + " ");
            }

            Console.ReadKey();
        }
    }
}

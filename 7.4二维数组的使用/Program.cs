using System;

namespace _7._4二维数组的使用
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] friendName = { { "张三", "男" }, { "李四", "女" }, { "王五", "男" } };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(friendName[i,j]+"\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("==========");

            foreach (var outstr in friendName)
            {
                Console.WriteLine(outstr+"   ");
            }


            Console.ReadKey();
        }
    }
}

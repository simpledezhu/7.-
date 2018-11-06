using System;

namespace _7._1一维数组的使用
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = { "张三", "李四", "王五", "赵六" };
            //使用数组中的元素是通过索引值来实现的
            Console.WriteLine(name[1]);
            //数组元素的重新赋值
            name[3] = "刘能";
            Console.WriteLine(name[3]);
            Console.WriteLine("===========");
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }

            foreach (var item in name)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();


        }
    }
}

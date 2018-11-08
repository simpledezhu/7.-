using System;
using System.Linq;

namespace _7._6查找数组元素
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myintArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            string[] mystrArray = { "aac", "scs", "adss", "sdwqfq", "dvdd" };
            //IndexOf可以查找元素首次出现的位置
            //LastIndexOf可以查找元素最后一次出现的位置，位置都是从0开始的索引值
            //IndexOf与LastIndexOf都返回一个索引值，为整形int

            //IndexOf（参数1，参数2）：参数1是我们要查找的数据，参数2是要查找的元素
            int result = Array.IndexOf(myintArray,11);
            int result1 = Array.IndexOf(mystrArray, "sdwqfq");

            Console.WriteLine(result);
            Console.WriteLine(result1);

            //contains方法，返回的是一个布尔值
            bool mybool = myintArray.Contains(8);
            if (mybool)
            {
                Console.WriteLine("存在该元素！");
            }
            else {
                Console.WriteLine("不存在！");
            }

            Console.ReadKey();
        }
    }
}

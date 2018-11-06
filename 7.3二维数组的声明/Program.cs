using System;

namespace _7._3二维数组的声明
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] friendName = { "张三", "李四", "王五", "赵六", "刘七" };
            //二维数组的声明
            string[,] friend;
            //初始化第一种方法：指定字面量，适用于已知元素的内容
            string[,] friend2 = { { "张三", "男" }, { "李四", "女" }, { "王五", "男" } };

            //初始化第三种方法：new关键字，适用于元素内容未知
            string[,] friend3 = new string[5,2];


        }
    }
}

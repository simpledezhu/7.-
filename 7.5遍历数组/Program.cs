using System;

namespace _7._5遍历数组
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] friendName = { { "张三", "男" }, { "李四", "女" }, { "王五", "男" } };
            //正序输出
            //以下是正序输出
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(friendName[i,j]+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("以下是倒叙输出============");

            for (int i = 2; i >=0; i--)
            {
                for (int j = 1; j >=0; j--)
                {
                    Console.Write(friendName[i,j]+" ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("数组包含的总元素个数：" + friendName.Length);
            Console.WriteLine("得到数组指定维度的索引个数:"+friendName.GetLowerBound(0));
            //一维数组的索引号为2，即3行
            Console.WriteLine("得到数组指定维度的索引个数:" + friendName.GetUpperBound(0));
            //二维的最大索引号为1，即2列
            Console.WriteLine("得到数组指定维度的最大索引号:" + friendName.GetUpperBound(1));

            //查看3行2列的元素
            //1.
            Console.WriteLine(friendName[2, 1]);
            //2.
            Console.WriteLine(friendName.GetValue(2,1));


            Console.ReadKey();

        }
    }
}

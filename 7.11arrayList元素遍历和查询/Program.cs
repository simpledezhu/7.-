using System;
using System.Collections;

namespace _7._11arrayList元素遍历和查询
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("haha");
            arrayList.Add(1313);
            arrayList.Add('a');

            string[] mystrArray = { "张三", "李四", "王五" };
            arrayList.AddRange(mystrArray);

            //按索引查找数据
            Console.WriteLine(arrayList.IndexOf("张三"));

            //LastIndexOf（）返回最后一次出现的索引整形值
            Console.WriteLine(arrayList.LastIndexOf("张三"));

            Console.ReadKey();
        }
    }
}

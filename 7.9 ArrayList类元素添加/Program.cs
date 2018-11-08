using System;
using System.Collections;

namespace _7._9_ArrayList类元素添加
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList(5);
            //ArrayList的好处是，长度不固定，类型随意
            //数组的长度是固定的，不能更改的，类型单一，只能为其中的一种
            Console.WriteLine("arrayList初始化之后有{0}个元素",arrayList.Count);

            //add方法，用于向arrayList中添加单个元素，每次只能添加一个
            arrayList.Add(123);
            arrayList.Add("哈哈");
            arrayList.Add("mystr");
            arrayList.Add('w');
            arrayList.Add(123.423);

            Console.WriteLine("使用add方法添加五个元素之后，有{0}个元素", arrayList.Count);

            //addRange方法用于一次性向arrayList中添加多个元素，可以是一个数组。
            string[] mystrArray = { "张三", "李四", "王五", "赵六" };
            arrayList.AddRange(mystrArray);
            Console.WriteLine("使用AddRange方法后，有{0}个元素",arrayList.Count);

            //遍历集合元素
            foreach (var item in arrayList)
            {
                Console.Write(item+" ");
            }

            Console.ReadKey();
        }
    }
}

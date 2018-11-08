using System;
using System.Collections;

namespace _7._10_ArrayList类中元素的删除
{
    class Program
    {
        static void Main(string[] args)
        {
            //元素删除的四种方法

            //Remove（值）
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("haha");
            arrayList.Add(1313);
            arrayList.Add('a');

            string[] mystrArray = {  "张三","李四","王五" };
            arrayList.AddRange(mystrArray);
            Console.WriteLine("删除之前的内容");

            foreach (Object item in arrayList)
            {
                Console.Write(item+" ");
            }

            //remove()
            Console.WriteLine("按内容删除之后的内容为：");
            arrayList.Remove("张三");
            foreach (Object item in arrayList)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("按索引删除之后的内容为：");
            arrayList.RemoveAt(3);
            foreach (Object item in arrayList)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("按索引多个删除之后的内容为：");
            arrayList.RemoveRange(3,2);
            foreach (Object item in arrayList)
            {
                Console.Write(item + " ");
            }


            Console.ReadKey();
        }
    }
}

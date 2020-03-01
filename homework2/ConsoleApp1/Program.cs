using System;
using System.Collections;

namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array;
            int sum=0;
            Console.WriteLine("请输入一个数组：");
            string[] stringArray = Console.ReadLine().Split(',');
            array = Array.ConvertAll<string, int>(stringArray, int.Parse);
            for(int i=0; i<=array.Length; i++)
            {
                sum += array[i];
            }
            int average = sum / array.Length;
            ArrayList list = new ArrayList(array);
            list.Sort();
            int min = Convert.ToInt32(list[0]);
            int max = Convert.ToInt32(list[list.Count - 1]);
            Console.WriteLine("最大" + max + " 最小:" + min+" 元素和:"+sum+" 平均值:"+average);

        }
    }
}

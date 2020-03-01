using System;
namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个整数：");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("该数字的素数因子有：");
            for (int i = 2; i <= a;)
            {
                if (a % i == 0)
                {
                    a = a / i;
                    Console.WriteLine(i);
                    i = 2;
                }
                else
                {
                    i++;
                }
            }
        }
    }
}
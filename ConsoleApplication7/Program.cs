using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            Q1();
           
        }

       // 1.Given two integers, write a program to display the sum,difference,and their product.

        public static void Q1()
        {
            Console.WriteLine("Enter the value1 ");
            int value1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value2");
            int value2 = int.Parse(Console.ReadLine());
            int add = value1 + value2;
            Console.WriteLine("Addtion:"+add);
            int sub = value1 - value2;
            Console.WriteLine("Substract:"+sub);
            int pro = value1 * value2;
            Console.WriteLine("Multiplication:"+pro);
 

        }
    }
}

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
            //Q1();
            //Q2();
            //Q3();
            //Q4();
            //Q5();
            //Q6();
            //Q7();
            //Q8();
            //Q9();
            Q10();

        }

        // 1.Given two integers, write a program to display the sum,difference,and their product.

        public static void Q1()
        {
            Console.WriteLine("Enter the value1 ");
            int value1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value2");
            int value2 = int.Parse(Console.ReadLine());
            int add = value1 + value2;
            Console.WriteLine("Addtion:" + add);
            int sub = value1 - value2;
            Console.WriteLine("Substract:" + sub);
            int pro = value1 * value2;
            Console.WriteLine("Multiplication:" + pro);
        }
        public static void Q2()
        {
            Console.WriteLine("Enter the value");
            int value = int.Parse(Console.ReadLine());
            double power = Math.Pow(value, 2);
            Console.WriteLine("The power value is:" + power);
        }
        public static void Q3()
        {
            Console.WriteLine("Enter the length value");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the width value");
            int width = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the height value");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("The volume of Rectangular is:"+length*width*height);
 
        }
        public static void Q4()
        {
            Console.WriteLine("Enter the value");
            double radius= double.Parse(Console.ReadLine());
            double perimeter = 2 * Math.PI * radius;
            Console.WriteLine("Perimeter of circle is:"+perimeter);
        }
        public static void Q5()
        {
            Console.WriteLine("Enter the number1");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number2");
            double num2 = double.Parse(Console.ReadLine());

            double remainder = num1 % num2;
            double quotient = num1 / num2;

            Console.WriteLine("Quotient:"+quotient);
            Console.WriteLine("Remaider:"+remainder);
        }
        public static void Q6()
        {
            Console.WriteLine("Enter the value ");
            double num=double.Parse(Console.ReadLine());
            double sqr = Math.Pow(num, 2);
            Console.WriteLine("The square is:"+sqr);
            
        }
        public static void Q7()
        {
            Console.WriteLine("Enter the value");
            double num = double.Parse(Console.ReadLine());
            double sqt = Math.Sqrt(num);
            Console.WriteLine("The square root is:"+sqt);
        }
        public static void Q8()
        {
            Console.WriteLine("Enter  the value 1:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value 2:");
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine("Area of a Triangle is:"+1/2*(b*h));
        }
        public static void Q9()
        {
            Console.WriteLine("Enter the Kilometer:");
            double km = Convert.ToDouble(Console.ReadLine());
            double miles = km / 1.6;
            Console.WriteLine("Miles:"+miles);
        }
        public static void Q10()
        {
            Console.WriteLine("Enter the celcius:");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("Convert Celcius to Fahrenheit:"+(c*9.0/5)+32);
        }
        public static void Q11()
        {
            int num1 = 18;
            int num2 = 19;
            int temp = num1;
            num1 = num2;
            num2 = temp;

          
        }
    }
}
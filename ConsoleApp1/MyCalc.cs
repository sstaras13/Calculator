using System;

namespace ConsoleApp1
{
     class MyCalc
    {
        double a;
        double b;
        public string oper;
        public double res;

        public void GetData()
        {
            Console.Write("Please enter the first number:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Now enter the second number:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter an operation +, -, * or /:");
            oper = Console.ReadLine();
        }

        public double Add() => res = a + b;

        public double Subtruct() => res = a - b;

        public double Devide() => res = a / b;

        public double Multiply() => res = a * b;
    }
}

using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyCalc myCalc = new MyCalc();
            myCalc.GetData();
            switch (myCalc.oper)
            {
                case "+":
                    myCalc.Add();
                    break;
                case "-":
                    myCalc.Subtruct();
                    break;
                case "/":
                    myCalc.Devide();
                    break;
                case "*":
                    myCalc.Multiply();
                    break;
                default:
                    Console.WriteLine("Wrong operation!");
                    break;
            }
            Console.WriteLine($"The result is: {myCalc.res}");
            //Console.ReadKey();
        }
    }
}

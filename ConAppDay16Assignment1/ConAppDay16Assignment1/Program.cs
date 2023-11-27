using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppDay16Assignment1
{
    internal class Program
    {
        public delegate int ArithemeticOperation(int a, int b);
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first Number");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int number2 = int.Parse(Console.ReadLine());
            Class calc = new Class();
            ArithemeticOperation del = new ArithemeticOperation(calc.Add);
            ArithemeticOperation del1 = new ArithemeticOperation(calc.Subtarct);
            ArithemeticOperation del2 = new ArithemeticOperation(calc.Multi);
            ArithemeticOperation del3 = new ArithemeticOperation(calc.Divide);

            Console.WriteLine("Choose: \n 1.Addition \n 2.Subtraction \n 3.Multiplication \n 4.Divided");
            Console.WriteLine("Enter your choice");

            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    {

                        int result = del(number1, number2);
                        Console.WriteLine($"Addition of number {number1} and {number2} is: " + result);
                        break;
                    }
                case 2:
                    {
                        int result = del1(number1, number2);
                        Console.WriteLine($"Subtraction of number {number1} and {number2} is: " + result);
                        break;
                    }
                case 3:
                    {
                        int result = del2(number1, number2);
                        Console.WriteLine($"Multiplication of number {number1} and {number2} is: " + result);
                        break;
                    }
                case 4:
                    {
                        int result = del3(number1, number2);
                        Console.WriteLine($"Division of number {number1} and {number2} is: " + result);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid Operation");
                        break;
                    }
            }
            Console.ReadKey();

        }
    }
}
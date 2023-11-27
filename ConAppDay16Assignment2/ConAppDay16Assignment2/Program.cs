using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppDay16Assignment2
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The second nuber");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Choose \n 1.Addition \n 2.Subtraction \n 3.Multi \n 4.Divide");
            Console.WriteLine("Enter your choice");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    {
                        Func<int, int, int> Add = (number1, number2) => number1 + number2;
                        int result = Add(num1, num2);
                        Console.WriteLine($"Addition of two number {num1} and {num2}: " + result);
                        break;
                    }
                case 2:
                    {
                        Func<int, int, int> Sub = (number1, number2) => number1 - number2;
                        int result = Sub(num1, num2);
                        Console.WriteLine($"Subtraction of two number {num1} and {num2}: " + result);
                        break;
                    }
                case 3:
                    {
                        Func<int, int, int> Multi = (number1, number2) => number1 * number2;
                        int result = Multi(num1, num2);
                        Console.WriteLine($"Multiplication of two number {num1} and {num2}: " + result);
                        break;
                    }
                case 4:
                    {
                        Func<int, int, int> Divide = (number1, number2) => number1 / number2;
                        int result = Divide(num1, num2);
                        Console.WriteLine($"Division of two number {num1} and {num2}: " + result);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid operation");
                        break;
                    }
            }
            Console.ReadKey();

        }
    }
}

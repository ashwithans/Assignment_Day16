using System;

namespace ConAppDay16Assignment2
{
    internal class Program
    {
        delegate T Operation<T>(T a, T b);

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("Enter your choice:");

            int choice = int.Parse(Console.ReadLine());
            Operation<int> operation = null;

            switch (choice)
            {
                case 1:
                    operation = Add;
                    break;
                case 2:
                    operation = Subtract;
                    break;
                case 3:
                    operation = Multiply;
                    break;
                case 4:
                    operation = Divide;
                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    break;
            }

            if (operation != null)
            {
                int result = operation(num1, num2);
                Console.WriteLine($"Result: {result}");
            }

            Console.ReadKey();
        }

        static int Add(int a, int b) => a + b;
        static int Subtract(int a, int b) => a - b;
        static int Multiply(int a, int b) => a * b;
        static int Divide(int a, int b) => b != 0 ? a / b : 0; 
    }
}

using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        public static int PerformOperation(int number)
        {
            return number; // You can perform any operations on the integer here
        }

        // Function for math operator input
        public static int initVerem(int inputSzam = 0, char muveletiJel = ' ')
        {
            var stack = new Stack<int>();
            if (muveletiJel == ' ')
            {
                stack.Push(inputSzam);
                return 1;
            }
            else
            {
                int operand2 = stack.Pop();
                int operand1 = stack.Pop();
                int result;

                switch (muveletiJel)
                {
                    case '+':
                        result = operand1 + operand2;
                        break;
                    case '-':
                        result = operand1 - operand2;
                        break;
                    case '*':
                        result = operand1 * operand2;
                        break;
                    case '/':
                        if (operand2 != 0)
                            result = operand1 / operand2;
                        else
                            throw new DivideByZeroException("Nem lehet osztani 0-val");
                        break;
                    default:
                        throw new ArgumentException("Nincs ilyen műveleti jel");
                }

                stack.Push(result);
                Console.WriteLine(result);
                return result;

            }
        }
        static void Main(string[] args)
        {

            Console.WriteLine(initVerem(1));
            Console.WriteLine(initVerem(2));
            Console.WriteLine(initVerem('/'));

        }
    }
}
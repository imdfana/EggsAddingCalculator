using Core;
using System;

namespace App
{
    public sealed class EggsAddingCalculator
    {
        public static void Main(string[] args)
        {
            Console.Out.WriteLine("========== Eggs Adding Calculator v1.0 ==========");
            Console.Out.WriteLine();

            Console.Out.Write("Enter the first operand: ");
            int addendA = int.Parse(Console.In.ReadLine());

            Console.Out.Write("Enter the second operand: ");
            int addendB = int.Parse(Console.In.ReadLine());

            Console.Out.Write("Enter Operation [-, x, +, /]:");
            String op = Console.In.ReadLine();

            var calculator = new Calculator();
            var result = 0;
            switch (op)
            {
                case "-":
                    result = calculator.Subtract(addendA, addendB);
                    break;
                case "/":
                    result = calculator.Divide(addendA, addendB);
                    break;
                case "x":
                    result = calculator.Multiplication(addendA, addendB);
                    break;
                case "+":
                    result = calculator.Add(addendA, addendB);
                    break;
                default:
                    Console.Out.Write("Operacion no definida dentro del sistema");
                    break;
            }
            Console.Out.WriteLine();
            Console.Out.WriteLine($"Result: {result}");

            Console.Out.Write("Press Enter to exit ...");
            Console.In.ReadLine();

            Console.Out.WriteLine("Goodbye!");
        }
    }
}

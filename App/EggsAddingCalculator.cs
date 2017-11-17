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

            var calculator = new Calculator();
            Console.Out.WriteLine();
            Console.Out.WriteLine($"Result: {calculator.Add(addendA, addendB)}");

            Console.Out.Write("Press Enter to exit ...");
            Console.In.ReadLine();

            Console.Out.WriteLine("Goodbye!");
        }
    }
}

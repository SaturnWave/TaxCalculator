using System;

using System;
using System.Runtime.CompilerServices;

namespace TaxCalculator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            bool runAgain = true;
            while(runAgain)
            { runAgain = runTaxCalculator(); }
            
            }
        Console.WriteLine("Press any key to exit...");
        }   
private static bool runTaxCalculator()
    {
    Console.WriteLine("Enter your income (or 'q' to quit): ");
    string input = Console.ReadLine();
    if (input == "q")
        {
        return false;
    }
    else
        {
        double income = Convert.ToDouble(input);
        double cpp = calculateCPP(income);
        double ei = calculateEI(income);
        double tax = calculateTax(income);
        double netIncome = income - cpp - ei - tax;
        Console.WriteLine("Your net income is: " + netIncome);
        return true;
    }
    }
}

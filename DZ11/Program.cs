using LAB;
using System;

namespace DZ11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 14.1");
            new Bankaccount("Сергей", 1000, BankType.Сберегательный).DumpToScreen();
        }
    }
}

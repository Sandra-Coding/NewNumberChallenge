using System;

namespace NewNumberChallenge
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter any whole number");

            //var inputNum = Console.ReadLine();
            //var newNum = LogicAlgorithim.AlterInputNumber_ConvertingStringToNumber(inputNum);

            //Console.WriteLine();
            //Console.WriteLine(newNum);

            Int32.TryParse(Console.ReadLine(), out int x);

            Console.WriteLine();
            LogicAlgorithim.AlterInputNumber_UsingWhileLoop_AndModulo(x);
            //LogicAlgorithim.AlterInputNumber_UsingWhileLoop(x);
        }
    }
}

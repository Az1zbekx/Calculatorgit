using System;
namespace Pro{
    class Program{
        static void Main(){
            Console.Write("Enter the numbers to calculate: ");
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');
            decimal a = decimal.Parse(numbers[0]);
            decimal b = decimal.Parse(numbers[1]);
            Console.WriteLine("Sum: "+(a+b));
        }
    }
}

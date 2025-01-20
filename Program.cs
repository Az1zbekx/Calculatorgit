using System;
namespace Pro{
    class Program{
        static void Main(){
            Console.WriteLine("Enter the numbers to calculate");
            Console.Write("Enter the first number: ");
            decimal num1 = decimal.Parse(Console.ReadLine());
            string op = Console.ReadLine();
            Console.Write("Enter the second number: ");
            decimal num2 = decimal.Parse(Console.ReadLine());
            switch(op){
                case "+":
                    Console.WriteLine($"{num1} + {num2} = {num1+num2}");
                    break;
                case "-":
                    Console.WriteLine($"{num1} - {num2} = {num1-num2}");
                    break;
                case "*":
                    Console.WriteLine($"{num1} * {num2} = {num1*num2}");
                    break;
                case "/":
                    Console.WriteLine($"{num1} / {num2} = {num1/num2}");
                    break;
                case "%":
                    Console.WriteLine($"{num1} % {num2} = {num1%num2}");
                    break;
                default:
                    Console.WriteLine("Impossible");
                    break; 
            }
        }
    }
}

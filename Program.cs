using System;
using System.Threading;

namespace ConsoleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, result = 0;
            string answer;
            bool isValidOperator;

            Console.WriteLine("                         *****Selamat datang di Kalkulator Konsol C#!*****                         \n");
            Thread.Sleep(2000);

            do {
                Console.WriteLine("Pilihlah operator yang ingin dipakai\n + (Penjumlahan)\n - (Pengurangan)\n * (Perkalian)\n / (Pembagian)\n % (Modulo)\n");
                answer = Console.ReadLine();
                isValidOperator = answer == "+" || answer == "-" || answer == "*" || answer == "/" || answer == "%";

                if (!isValidOperator) {
                    Console.WriteLine("Operator tidak valid\n");
                    Thread.Sleep(1000);
                }
            } while (!isValidOperator);

            Console.Write("\nMasukkan angka pertama ");
            num1 = Convert.ToInt16(Console.ReadLine());

            Console.Write("\nMasukkan angka kedua ");
            num2 = Convert.ToInt16(Console.ReadLine());

            switch (answer) {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
                case "%":
                    result = num1 % num2;
                    break;
            }

            Console.Write($"\nHasil dari {num1} {answer} {num2} adalah {result}\n");
        }
    }
}

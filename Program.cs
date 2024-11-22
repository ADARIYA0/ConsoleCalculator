namespace ConsoleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, result = 0;
            string answer;
            bool isValidOperator, isNum1Valid, isNum2Valid;

            Thread.Sleep(1500);
            Console.WriteLine("                         *****Selamat datang di Kalkulator Konsol C#!*****                         \n");
            Console.WriteLine("            *****JANGAN MENEKAN TOMBOL ENTER JIKA PROGRAM BELUM MENYURUH SESUATU*****                         \n");

            Thread.Sleep(3000);
            do {
                Console.WriteLine("Pilihlah operator yang ingin dipakai\n + (Penjumlahan)\n - (Pengurangan)\n * (Perkalian)\n / (Pembagian)\n % (Modulo)");
                answer = Console.ReadLine();
                isValidOperator = answer == "+" || answer == "-" || answer == "*" || answer == "/" || answer == "%";

                if (!isValidOperator) {
                    Console.WriteLine("\nOperator tidak valid\n");
                    Thread.Sleep(1000);
                }
            } while (!isValidOperator);

            do {
                Console.Write("\nMasukkan angka pertama: ");
                isNum1Valid = int.TryParse(Console.ReadLine(), out num1);
                if (!isNum1Valid) {
                    Console.WriteLine("\nInput tidak valid. Silakan masukkan angka yang benar.");
                }
            } while (!isNum1Valid);

            do {
                Console.Write("\nMasukkan angka kedua: ");
                isNum2Valid = int.TryParse(Console.ReadLine(), out num2);
                if (!isNum2Valid) {
                    Console.WriteLine("\nInput tidak valid. Silakan masukkan angka yang benar.");
                } else if ((answer == "/" || answer == "%") && num2 == 0) {
                    Console.WriteLine("\nAngka kedua tidak boleh nol untuk operasi pembagian atau modulo. Silakan coba lagi.");
                    isNum2Valid = false;
                }
            } while (!isNum2Valid);

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
                    if (num2 == 0) {
                        Console.WriteLine("Pembagian nol tidak diperbolehkan.");
                        return;
                    }
                    result = num1 / num2;
                    break;
                case "%":
                    if (num2 == 0) {
                        Console.WriteLine("Modulo dengan nol tidak diperbolehkan.");
                        return;
                    }
                    result = num1 % num2;
                    break;
            }

            Console.Write($"\nHasil dari {num1} {answer} {num2} adalah {result}\n");
        }
    }
}

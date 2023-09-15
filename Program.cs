using System;

namespace Fibonacchi {
    class Make {

        /*
         * In this program the Fibonacci sequence starts from the numbers "1" and "2";
        */

        static int Input()
        {
            int index = -1;
            try
            {
                Console.WriteLine("\nPlease input index of the number in the Fibonacci sequence: ");
                index = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Помилка: " + ex.ToString());
                Input();
            }

            return index;
        }

        static int CountFibonacci(int index, out int number, out int sum)
        {
            number = 0;
            sum = 3;

            int n1 = 1; // The first number in the sequence;
            int n2 = 2; // The second number in the sequence;

            for (int i = 2; i < index; i++)
            {
                number = n1 + n2;
                sum += number;
                n1 = n2;
                n2 = number;
            }
            return index;
        }

        static void Main() {
            Console.WriteLine("Progran started...");

            int number;
            int sum;

            Console.WriteLine("Iндекс числа: {0}\nЧисло: {1}\nСума: {2}\n", CountFibonacci(Input(), out number, out sum), number, sum);
        }

    }

}


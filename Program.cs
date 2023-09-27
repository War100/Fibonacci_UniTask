
/*
 * В цій програмі послідовність Фібоначі починажться "1" та "2"
 * Індексування чисел в послідовності починається з 1
 * (Як прийнято в математиці, а не в програмуванні)
*/

namespace Fibonacchi {
    class Make {

        //Функція для інтерактивного введення необхідних даних:
        static int Input()
        {
            int index = -1;     // Індекс числа послідовності Фібоначі (Індесування починається з "1")

            try
            {
                Console.WriteLine("\nPlease input index of the number in the Fibonacci sequence: ");
                index = Convert.ToInt32(Console.ReadLine());

                if (index <= 0)
                {
                    Console.WriteLine("Помилка: Введено не коректне значення. Будь ласка повторно введіть необхдне значення.");
                    return Input();
                }

            }

            catch (Exception ex)
            {
                Console.WriteLine("Помилка: " + ex.ToString());
                return Input();
            }

                return index;
        }

        // Функція, що здійснює обчислення необхідного числа послідовності та суми чисел послідовності:
        static int CountFibonacci(int index, out long number, out long sum)
        {
            number = 0;     // Шукане число послідовності
            sum = 3;        // Сума чисел послідовності включно з шуканим

            long n1 = 1; // Перше число в послідовності
            long n2 = 2; // Друге число в послідовності

            for (int i = 2; i < index; i++)
            {
                number = n1 + n2;
                sum += number;
                n1 = n2;
                n2 = number;
            }

            if (index == 2)
            {
                number = n2;
                sum = n1 + n2;
            }
            else if (index == 1)
            {
                number = n1;
                sum = n1;
            }

            return index;
        }


        // Точка входу програми:
        static void Main() {
            Console.WriteLine("Початок виконання програми...");

            long number; // Шукане число послідовності
            long sum;    // Сума чисел послідовності включно з шуканим

            Console.WriteLine("\nIндекс числа: {0}\nЧисло: {1}\nСума: {2}\n", CountFibonacci(Input(), out number, out sum), number, sum);
        }

    }

}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*4.	Даны целые положительные числа A и B (A < B). Вывести все целые числа от A до B включительно;
             * каждое число должно выводиться на новой строке;
             * при этом каждое число должно выводиться количество раз, равное его значению. */

            Console.WriteLine("Необходимо ввести A и B, причем A<B ");
            try
            {
                Console.WriteLine("Введите A");
                int A = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите B");
                int B = Convert.ToInt32(Console.ReadLine());
                if(A>=B || A<=0 || B <= 0)
                {
                    Console.WriteLine("Не соблюдено условие A<B либо числа A и B не положительные ");
                    return;
                }
                Console.Clear();

                for (int i = A; i < B; i++)
                {
                    for(int j = 1; j <= i; j++)
                    {
                        Console.Write(i);
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Завершение программы ");
                Environment.Exit(0);
            }

            Console.ReadLine();
        }
    }
}

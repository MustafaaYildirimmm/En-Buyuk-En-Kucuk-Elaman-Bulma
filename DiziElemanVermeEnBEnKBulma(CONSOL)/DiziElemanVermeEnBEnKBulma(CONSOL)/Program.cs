using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiziElemanVermeEnBEnKBulma_CONSOL_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers;
            int max, min;
            char c;
            do
            {
                Console.Clear();
                Console.WriteLine("Dizinin Uzunluğunu Giriniz");
                int length = Convert.ToInt32(Console.ReadLine());
                numbers = new int[length];


                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.WriteLine("A[{0}]=", i);
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                }
                max = numbers[0]; min = numbers[0];
                foreach (int item in numbers)
                {
                    if (max < item) max = item;
                    if (min > item) min = item;
                }

                Console.WriteLine("dizinin en büyük degeri {0} ' dir.", max);
                Console.WriteLine("dizinin en kücük degeri {0} ' dir.", min);

                Console.WriteLine("devam etmek istermisiniz e/h");
                c = Convert.ToChar(Console.ReadLine().ToLower());

                if (c=='h')
                {
                    Environment.Exit(1);
                }
            } while (c=='e');       


        }
    }
}

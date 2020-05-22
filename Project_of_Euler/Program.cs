using System;

namespace Project_of_Euler
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();

            program.Task_2();
        }
        public void Task_1()
        {
            /*
           Если выписать все натуральные числа меньше 10, кратные 3 или 5, то получим 3, 5, 6 и 9. Сумма этих чисел равна 23.
           Найдите сумму всех чисел меньше 1000, кратных 3 или 5.
           */

            int max = 1000;
            int sum = 0;
            for(int i = 0; i < max; i++)
            {
                if(i % 3 ==0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine("Сумма всех чисел до {0} и кратных 3 или 5 = {1}", max, sum);
        }
        public void Task_2()
        {
            /*
            Каждый следующий элемент ряда Фибоначчи получается при сложении двух предыдущих. Начиная с 1 и 2, первые 10 элементов будут:
            1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
            Найдите сумму всех четных элементов ряда Фибоначчи, которые не превышают четыре миллиона.
             */

            int max = 4000000;
            long sum = 0;
            int a, b, c;
            a = 1;
            b = 2;
            c = 0;
            sum += a;
            sum += b;

            for (int i = 0; i < max; i++)
            {
                c = a + b;
                a = b;
                b = c;
                sum += c;
            }

            Console.WriteLine("Сумма все числе Фибоначи до {0} = {1}", max, sum);


        }

    }
}

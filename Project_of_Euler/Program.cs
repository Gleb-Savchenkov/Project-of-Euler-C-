using System;

namespace Project_of_Euler
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();

            program.Task_1();
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
        
    }
}

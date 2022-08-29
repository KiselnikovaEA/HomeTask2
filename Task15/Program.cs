using System;       // Программа покажет, является ли введённый день выходным (или рабочим) днём

namespace HomeTasks_KisEA
{
    class Program
    {
        static void Main (string[] args)
        {
            void Weekend(int weekday)
            {

                if (weekday >=1 && weekday <=5)
                    Console.WriteLine("Рабочий");
                else if(weekday == 6 || weekday == 7) Console.WriteLine("Выходной");
                else Console.WriteLine("Вы ввели неправильное число, попробуйте снова.");
            }

            Console.Write("Введите число, соответствующее дню недели: ");
            int num = Convert.ToInt32(Console.ReadLine());       

            Weekend(num);

        }
    }
}
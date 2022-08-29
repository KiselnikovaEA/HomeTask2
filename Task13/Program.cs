using System;       //Программа покажет третью цифру введённого числа

namespace HomeTasks_KisEA
{
    class Program
    {
        static void Main (string[] args)
        {
            void PrintThirdDigit()
            {
                Console.Write("Введите число: ");
                int num = Convert.ToInt32(Console.ReadLine());
                
                num = Math.Abs(num);

                if ((int)Math.Log10(num) < 2) Console.Write("Третьего числа нет");
                else
                {
                    string s = Convert.ToString(num);                           
                    Console.WriteLine($"Третья цифра заданного числа {s[2]}");
                }
            }
            
            PrintThirdDigit();

        }
    }
}
using System;

namespace HomeTasks_KisEA
{
    class Program
    {
        static void Main (string[] args)
        {
         
            void PrintSecondDigit()         // если хотим только посмотреть на вторую цифру числа
            {

                Console.Write("Введите трёхзначное число: ");
                int num = Convert.ToInt32(Console.ReadLine());
                
                num = Math.Abs(num);

                if ((int)Math.Log10(num) == 2)
                {
                    string s = Convert.ToString(num);                           
                    Console.WriteLine($"Вторая цифра заданного числа {s[1]}");
                }  
                else Console.WriteLine("Число не является трёхзначным");

            }

            int getSecondDigit()        //если хотим как-то использовать её
            {

                Console.Write("Введите трёхзначное число: ");
                int num = Convert.ToInt32(Console.ReadLine());
                
                num = Math.Abs(num);

                if ((int)Math.Log10(num) == 2)
                {
                    int a = num / 100;
                    num = num - a * 100;
                    a = num % 10;
                    num = (num - a)/10;
                    return num;
               }  
                else
                {   
                    Console.WriteLine("Число не является трёхзначным");
                    return -1;
                } 

            }

            PrintSecondDigit();
            Console.WriteLine(getSecondDigit());

        }
    }
}
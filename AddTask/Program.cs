using System;       // Программа покажет, является ли введённый день выходным (или рабочим) днём

namespace HomeTasks_KisEA
{
    class Program
    {
        static void Main (string[] args)
        {
            void Announsment(int count)
            {

                string s = Convert.ToString(count);
                Console.Write(count + " программист");
                int sLen = s.Length;

                if (sLen > 1)
                {
                    if (s[sLen - 2] != '1' && s[sLen - 1] >= '2' && s[sLen - 1] <= '4') Console.Write("а");
                    else if (s[sLen - 2] != '1' && s[sLen - 1] == '1') Console.Write("");
                    else Console.Write("ов");
                }
                else if(sLen == 1)
                {
                    if(s[0] == '1') Console.Write("");
                    else if (s[0] >= '2' && s[0] <= '4') Console.Write("а");
                    else Console.Write("ов");
                }
                else Console.Write("Ошибка");
            }

            Console.Write("Введите число: ");
            int num = Convert.ToInt32(Console.ReadLine());       

            Announsment(num);

        }
    }
}
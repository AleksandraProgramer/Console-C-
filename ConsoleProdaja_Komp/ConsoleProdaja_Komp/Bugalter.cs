using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProdaja_Komp
{
    class Bugalter
    {
        string[] Bugalt = { " -Получает документы на оформление ", " -Оформляет ", " -Возвращает оформленные документы " };


        public void Bug()
        {
            
            
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("---------------------------");
                Console.WriteLine(" БУХГАЛТЕР : ");

                for (int bg = 0; bg < Bugalt.Length; bg++)
                {
                    Console.ResetColor();
                    Console.WriteLine(Bugalt[bg] + " ");
                }
               
            
        }
    }
}

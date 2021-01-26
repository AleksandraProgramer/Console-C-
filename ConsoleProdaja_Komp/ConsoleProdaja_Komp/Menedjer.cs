using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProdaja_Komp
{
    class Menedjer
    {
        string[] Menedjers = { " -Ноутбуки ", " -Клавиатура и мышки ", " -Планшеты ", " -Мониторы " };

        public void Menedj()
        {
            
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("---------------------------");
            Console.WriteLine(" МЕНЕДЖЕР : ");
            
            
            for (int i = 0; i < Menedjers.Length; i++)
            {
                Console.ResetColor();
                Console.WriteLine(Menedjers[i] + " ");
                // Console.Clear();
                
            }
          
        }
    }
}

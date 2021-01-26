using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProdaja_Komp
{
    class Menu
    {
        public void Menus(int w)
        {
            while (true)
            {

                int j;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" МЕНЮ : ");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("1 Заказ товара \n2 - Оформление \n3 - Расчёт ");

                try
                { 
                    if (w > 0)
                    {
                        j = w;
                    }
                    else
                    {
                        j = int.Parse(Console.ReadLine());
                    }

                    switch (j)
                    {
                        case 1:
                            Zkaz();
                            return;
                        case 2:
                            w = Nazad();
                            break;
                        case 3:
                            Console.WriteLine(" - Расчёт ");
                            break;

                        default:
                            Console.WriteLine("Ошибка");
                            break;
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine(" Не жмите много кнопок одновременно ");
                }


            }

        }   
    
    public int  Nazad()
        {
            Console.WriteLine(" - Оформление");
            return 0;
        }

        public void Zkaz()
        {
            Console.WriteLine(" - Заказ товара");
            Korzina_pokupok korzina_Pokupok = new Korzina_pokupok();
            korzina_Pokupok.Korzi_na();

        }

    }
}

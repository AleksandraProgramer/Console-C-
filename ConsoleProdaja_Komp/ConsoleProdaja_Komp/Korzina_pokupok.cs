using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;



namespace ConsoleProdaja_Komp
{
    class Korzina_pokupok
    {

        
       public void Korzi_na()
        {
            Console.WriteLine(" ПОТРЕБИТЕЛЬСКАЯ КОРЗИНА ");
            Console.WriteLine("------------------------------");
            

            while (true)
            {
              
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(" ВЫБОР ТОВАРА  : ");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("1 - НОУТБУКИ \n2 - КЛАВИАТУРА И МЫШИ  \n3 - ПЛАНШЕТЫ  \n4  - МОНИТОРЫ ");
                int i = int.Parse(Console.ReadLine());
                switch (i)
                {
                    case 1:                       
                        Nout();
                        break;
                    case 2:
                        Klava();                        
                        break;
                    case 3:
                        Plan();                        
                        break;
                    case 4:
                        Monit();                       
                        break;

                    default:
                        Console.WriteLine("Ошибка");
                        break;
                }
            }
        }

         public void Nout()
        {
            Console.WriteLine(" - НОУБУКИ ");

            Menu menu = new Menu();
            menu.Menus(2);

        }
        public void Klava()
        {
            Console.WriteLine(" - КЛАВИАТУРА И МЫШИ ");

            Menu menu = new Menu();
            menu.Menus(2);


        }
        public void Plan()
        {
            Console.WriteLine(" - ПЛАНШЕТЫ  ");

            Menu menu = new Menu();
            menu.Menus(2);


        }
        public void Monit()
        {
            Console.WriteLine(" - МОНИТОРЫ ");

            Menu menu = new Menu();
            menu.Menus(2);


        }
        


    }
}


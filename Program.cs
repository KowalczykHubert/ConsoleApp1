using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int los = rnd.Next(1, 11);
            int number;
            int row = 1;
            Console.WriteLine("Podaj Liczbę z zakresu 1 do 10:");

            do
            {
                Console.Write("Podaj Liczbę: ");
                number = int.Parse(Console.ReadLine());

                if (number > 10 || number < 1)
                {
                    Console.WriteLine("Podałeś liczbę z poza zakresu!");
                }
                else
                {
                    if (number > los)
                    {
                        Console.WriteLine("Podałeś zbyt dużą liczbę!");
                    }
                    else if (number < los)
                    {
                        Console.WriteLine("Podałeś zbyt małą liczbę!");
                    }
                    else
                    {
                        Console.Write("Zgadłeś! BRAWO!" + " Udało Ci się za {0} razem!", row);
                    }
                    row++;
                }
            } while (los != number);

                       
            Console.ReadKey();
        }
    }
}

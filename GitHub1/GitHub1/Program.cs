using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHub1
{
    class Program
    {
        static void Main(string[] args)
        {
           bool Semafor = true;
           Console.WriteLine("Vítejte ve hře Lodě. Hra je určená pro dva hráče.");
            while (Semafor){
                Console.WriteLine("1)Nová hra");
                Console.WriteLine("2)Ukončit hru");
                string vyber = Console.ReadLine();
                if(vyber == "1"){
                   Console.WriteLine("Hráč 1 nasazuje jednotlivé lodě.");
                    for(int i = 0;)
                    {

                    }
                }
                else if(vyber == "2"){
}                  Semafor = false;
            }

        }
    }
}

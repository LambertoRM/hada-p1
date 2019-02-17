using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hada_p1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "";

            do
            {
                Console.WriteLine("¿De qué unidad partes, de segundos (s) o de minutos (m)? (pulse otra tecla para salir)");
                s = Console.ReadLine();

                if (s == "s")
                {
                    Console.WriteLine("Introduce la cantidad: ");
                    string num = Console.ReadLine();
                    double minutes = HadaP1.Seconds2Minutes(double.Parse(num));
                    Console.WriteLine(minutes + " minutes.");

                }
                else if (s == "m")
                {
                    Console.WriteLine("Introduce el número: ");
                    string num = Console.ReadLine();
                    double seconds = HadaP1.Minutes2Seconds(double.Parse(num));
                    Console.WriteLine(seconds + " seconds.");
                }
            } while ((s == "s") || (s == "m"));


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo1.cs
{
    class Program
    {
        static void Main(string[] args)
        {

            int numeroDigitado;

            Console.Write("Digite um número: ");

            numeroDigitado = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(numeroDigitado.ToString());

            if (numeroDigitado % 2 == 0)
            {
                Console.Write("Par");

            }else{

                Console.Write("Impar");
            }
                          
            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumar sumar = new Sumar(4,4);

            sumar.Calcular();


            sumar.MostrarNumeros();


            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Interfaces
{
   public class Sumar:ICalcul
    {
        public int a;
        public int b;

        public int total;

        public Sumar(int primer,int segundo)
        {
            this.a = primer;
            this.b = segundo;
        }

        public void MostrarNumeros() 
        {


            Console.WriteLine($"El primer numero a sumar es {a}");
            Console.WriteLine($"El segundo numero a sumar es {b}");

            Console.WriteLine($"El total de la suma es {total}");


        }


       public int Calcular() 
        {
            return total = a + b;
        }




    }
}

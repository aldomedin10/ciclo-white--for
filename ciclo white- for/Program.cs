using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ciclo_white__for
{
    class Program
    {
        static void Main(string[] args)
        {

            //while
            //for
            //parte 1 valor de la interaccion
            //parte 2 condicion
            //parte 3 aumento o decrementooo

            int tabla;
            int i = 1; //parte1
            Console.WriteLine("ingrese el numero de la tabla que quiere calcular");
            tabla = int.Parse(Console.ReadLine());

            //parte2
            while(i <= 10){
                Console.WriteLine("" + tabla * i);
                i++; //parte 3
                }
            Console.ReadKey();


        }
    }
}

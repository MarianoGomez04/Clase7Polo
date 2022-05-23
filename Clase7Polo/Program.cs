using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase7Polo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese 10 numeros por favor:");
            int[] numeros = new int[10];


            for (int posicion = 0; posicion < numeros.Length; posicion++)
            {
                numeros[posicion] = int.Parse(Console.ReadLine());
                Console.WriteLine($"La posicion del numero es: {posicion + 1} y el numero elegido por el usuario es {numeros[posicion]}");
            }

            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
            var sumatotal = 0;
            for (int posicion = 0; posicion < numeros.Length; posicion++)
            {
                sumatotal = sumatotal + numeros[posicion];

            }
            Console.WriteLine($"La suma de todos los numero es : {sumatotal}");

            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");

            Console.WriteLine("Ahora necesitamos saber cual es el numero mayor");
            var numMayor = numeros[0];
            var numMenor = numeros[0];


            for (int posicion = 0; posicion < numeros.Length; posicion++)

            {

                if (numMayor < numeros[posicion])
                {
                    numMayor = numeros[posicion];
                }
                

                if (numMenor > numeros[posicion])
                { 
                    numMenor = numeros[posicion];    
                }
                
            }
            Console.WriteLine($"El numero mayor es {numMayor}");
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine($"El numero menor es {numMenor}");    
        }


            //Console.WriteLine("---------------------------------------------------------------------------------------------------");
            //for (int posicion = 0; posicion < numeros.Length; posicion++)
            //{
            //    numMenor =  numeros[posicion];
            //}

            //if (numMayor < numMenor)
            //{
            //    Console.WriteLine($"El numero mayor es: {numMenor} ");
            //}
            //if (numMenor < numMayor)
            //{

            //}
            //{
            //    Console.WriteLine($"El numero menor es {numMayor}");
            //}


        }
    }


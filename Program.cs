using System;

namespace CSharp_01_SumaDeNumerosConsecutivos
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 1;
            int suma = 0;


            while(contador <= 10){
                Console.WriteLine("Contador + Suma: " + contador + " + " + suma + " = " + (contador+suma));
                suma = contador + suma;
                contador++;
            }

            Console.WriteLine("El Total de la Suma es: " + suma);
        }
    }
}

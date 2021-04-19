/*Una planta que fabrica perfiles de hierro posee un lote de n piezas.
Confeccionar un programa que pida ingresar por teclado la cantidad de piezas a procesar y luego ingrese la longitud de cada perfil; sabiendo que la pieza cuya longitud esté comprendida en el rango de 1,20 y 1,30 son aptas. Imprimir por pantalla la cantidad de piezas aptas que hay en el lote.
 */


using System;

namespace FabricaHierro
{
    class Program
    {
        static void Main(string[] args)
        {
            int nPiezas, num = 1, piezasValidas = 0;
            float longitud;
            string linea;

            Console.Write("Ingrese la cantidad de piezas que desee procesar: ");
            linea = Console.ReadLine();
            nPiezas = int.Parse(linea);


            //En este caso decidi forzar el punto como separador decimal
            //En caso no querer forzarlo, se debe utilizar la coma como separador decimal.
            while(num <= nPiezas)
            {
                Console.Write("Ingrese la longitud de la pieza: ");
                linea = Console.ReadLine();
                longitud = float.Parse(linea,System.Globalization.CultureInfo.InvariantCulture);

                if(longitud >= 1.20 && longitud <= 1.30)
                {
                    piezasValidas++;
                }

                num++;
            }

            Console.Write("El numero de piezas es: ");
            Console.Write(piezasValidas);

            Console.ReadKey();
        }
    }
}

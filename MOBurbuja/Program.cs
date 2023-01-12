using System;
namespace burbuja
{
    class program
    {
        static int[] numeros = new int[] { 10, 3, 5, 6, 7, 23 };
        static void Main(string[] args)
        {
            Console.WriteLine("Inicio");
            mostrar();
           
            for (int i = 0; i < numeros.Length; i++) 
            {
                
                for (int j = 0; j < numeros.Length -i - 1; j++)//optimizacion de 42 iteraciones a 21
                {
                    if (numeros[j] > numeros[j+1])
                    {
                        
                        int aux = numeros[j];
                        numeros[j] = numeros[j+1];
                        numeros[j+1] = aux;

                    }
                }
            }
            Console.WriteLine("ordenado");
            mostrar();
        }

        public static void mostrar()
        {
            foreach(var numero in numeros)
            {
                Console.WriteLine(numero + " ");
            }

        }
    }
}
using System;
namespace Collections
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hola");
            List<int> numeros = new List<int>(); //declaracion de lista de numeros
            /*numeros.Add(1);//agregamos un 1 a la lista 
            //numeros.Add(29);
            //numeros.Add(36);
            int[] listaNumeros = new int[] { 3, 5, 6, 7, 8 }; 
            for (int i=0; i<5; i++)
            {
                numeros.Add(listaNumeros[i]);
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(numeros[i]);
            }

            Console.WriteLine("cuantos elementos quieres introducir?");
            int numeros2 = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < numeros2; i++)
            {
                numeros.Add(Int32.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < numeros2; i++)
            {
                Console.WriteLine(numeros[i]);
            }
            /*/
            Console.WriteLine("agregar elementos: (0 para salir)");
            int elem = 1;
            while (elem!=0)
            {
                elem= Int32.Parse(Console.ReadLine());  
                numeros.Add(elem);
            }
            numeros.RemoveAt(numeros.Count-1);
            Console.WriteLine("elementos");
            foreach (int e in numeros)
            {
                Console.WriteLine(e);
            }
        }
    }
}
using System;
namespace QuickSort
{
    class Program
    {
        static void Main()
        {
            int n;
            Console.WriteLine("longitud del vector");
            n = Int32.Parse(Console.ReadLine());

            agregar b = new agregar(n);
        }
        class agregar
        {
            int h;
            int[] vector;
            public agregar(int n)
            {
                h = n;
                vector = new int[h];
                for(int i = 0; i < h; i++)
                {
                    Console.Write("ingrese valor {0} : ",i);
                    vector[i] = Int32.Parse(Console.ReadLine());
                }

                quicksort(vector, 0, h - 1);
                mostrar();
            }
            private void quicksort(int[] vector,int primero, int ultimo)
            {
                int i, j, central;
                double pivote;
                central = (primero + ultimo)/2;
                pivote = vector[central];
                i = primero;
                j = ultimo;
                do
                {
                    while (vector[i] < pivote) i++;
                    while (vector[j] > pivote) j--;
                    if (i <= j)
                    {
                        int temp;
                        temp = vector[i];   
                        vector[i] = vector[j];
                        vector[j] = temp;
                        i++;
                        j--;
                    }
                }while (i <= j);
                if(primero < j)
                {
                    quicksort(vector, primero, j);
                }
                if (i<=ultimo)
                {
                    quicksort(vector, i, ultimo);
                }
            }
            private void mostrar()
            {
                Console.WriteLine("vector ordenado asc");
                for(int i=0; i<h; i++)
                {
                    Console.WriteLine("{0}", vector[i]);

                }
                Console.ReadLine();
            }

        }
    }
}
using System;

class program
{
    static void Main(string[] args)
    {
        LinkedList<int> numeros = new LinkedList<int>();//constructor
        //por cada numero agregar en primera posicion
        foreach(int numero in new int[] {1,3,4,6,7})
        {
            numeros.AddFirst(numero);
        }

        /* foreach(int numero in numeros)
         {
             Console.WriteLine(numero);
         }*/
        numeros.Remove(4);
        LinkedListNode<int> nodo2 = new LinkedListNode<int>(4453);
        numeros.AddFirst(nodo2);
       for(LinkedListNode<int> nodo = numeros.First; nodo!=null; nodo=nodo.Next)
        {
            int numero = nodo.Value;    
            Console.WriteLine(numero);
        }
    }
}
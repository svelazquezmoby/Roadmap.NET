using System;
using System.Collections;
namespace Types
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(10);
            int j = list[0];

            ArrayList array = new ArrayList();
            array.Add(10);
            int i = (int)array[0];

            Console.WriteLine();
            Console.ReadLine();   
        }
    }
}
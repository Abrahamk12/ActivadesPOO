namespace Repaso;
using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        ArrayList list = new ArrayList();
        list.Add("Manzana");
        list.Add("Pera");
        list.Add("Banana");
        list.Add(2.5);
        list.Add(3);
        list.Add(true);
        Console.WriteLine("Elementos en la lista: {0}", list.Count);
        Console.WriteLine("Elemento en la posición 1: {0}", list[1]);
        foreach (var fruta in list)
        {
            Console.WriteLine(fruta);
        }
        Console.WriteLine("---------------------------------------");
        list.RemoveAt(1);
        foreach (var fruta in list)
        {
            Console.WriteLine(fruta);
        }
        Console.WriteLine("Confomrme al nombre"+list.Contains("Banana"));

    }
}
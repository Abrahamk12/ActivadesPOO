using System;
using System.Collections.Generic;

class Program
{
    static void metodoLinkedList(){
        LinkedList<string> list = new LinkedList<string>();

        // Agregar elementos
        list.AddLast("A");
        list.AddLast("B");
        list.AddFirst("C");

        // Iterar sobre la lista
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        // Métodos comunes
        var node = list.Find("B");  // Encuentra un nodo con valor "B"
        list.AddAfter(node, "D");  // Agrega "D" después de "B"
        list.AddBefore(node, "E"); // Agrega "E" antes de "B"
        list.Remove("A");          // Elimina el nodo con valor "A"
        list.Clear();              // Vacía toda la lista
    }
    static void metodoHashSet(){
        HashSet<int> set = new HashSet<int>();

        // Agregar elementos
        set.Add(1);
        set.Add(2);
        set.Add(3);
        set.Add(2);  // No se agrega porque ya existe

        // Iterar sobre el conjunto
        foreach (var item in set)
        {
            Console.WriteLine(item);
        }

        // Métodos comunes
        set.Remove(1);           // Elimina el elemento "1"
        Console.WriteLine(set.Contains(2)); // Verifica si el conjunto contiene "2"
        set.Clear();             // Vacía todo el conjunto

        // Operaciones de conjuntos
        HashSet<int> otherSet = new HashSet<int>() { 2, 3, 4 };
        set.UnionWith(otherSet);  // Unión
        set.IntersectWith(otherSet); // Intersección
        set.ExceptWith(otherSet);    // Diferencia
    }
    static void Main()
    {
        
    }
    
}

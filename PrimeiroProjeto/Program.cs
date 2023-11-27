using System;

class Program
{
    static void Main()
    {
        ArvoreBinaria tree = new ArvoreBinaria();

        tree.inserir(12);
        tree.inserir(90);
        tree.inserir(4);
        tree.inserir(20);
        tree.inserir(87);
        tree.inserir(7);
        tree.inserir(8);

        Console.WriteLine("Árvore Binária em ordem:");
        tree.InOrderTraversal();

        Console.WriteLine("\n\nRemovendo 12:");
        tree.Remove(12);
        tree.InOrderTraversal();

        Console.WriteLine("\n\nRemovendo 20:");
        tree.Remove(20);
        tree.InOrderTraversal();

        Console.WriteLine("\n\nRemovendo 4:");
        tree.Remove(4);
        tree.InOrderTraversal();
    }
}
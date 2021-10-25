using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Node n1 = new Node("persona1", 19);
            Node n2 = new Node("persona2", 10);
            Node n3 = new Node("persona3", 80);
            Node n4 = new Node("persona4", 32);
            Node n5 = new Node("persona5", 26);
            Node n6 = new Node("persona6", 21);
            Node n7 = new Node("persona7", 6);

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);

            // visitar el árbol aquí
        }
    }
}

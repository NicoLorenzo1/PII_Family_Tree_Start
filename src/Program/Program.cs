using System;
using Library;
using System.Collections.Generic;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            //creo los nodos con sus correspondientes personas 
            Node n1 = new Node(1, new Person("Nicolas", "Lorenzo", 19));
            Node n2 = new Node(2, new Person("Martin", "Perez", 10));
            Node n3 = new Node(3, new Person("Facundo", "Alvarez", 11));
            Node n4 = new Node(4, new Person("Valeria", "Nuñez", 19));
            Node n5 = new Node(5, new Person("Anthony", "Rivera", 17));
            Node n6 = new Node(6, new Person("Olivia", "Suarez", 29));
            Node n7 = new Node(7, new Person("Santiago", "De Oliveira", 69));
            Node n8 = new Node(8, new Person("Lucas", "Cabrera", 29));


            //el nodo1 agrega como hijo al nodo2 y nodo3
            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);
            n3.AddChildren(n8);


            // visitar el árbol aquí
            Visitor v = new Visitor();
            v.Visit(n1);

            Console.WriteLine("Suma total de las edades: " + v._contador);
        }

    }
}

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node
    {
        private int number;

        private List<Node> children = new List<Node>();

        private Person _person;
        public Person person
        {
            get
            {
                return _person;
            }
            set
            {
                if (value is not null)
                {
                    _person = value;
                }
            }
        }
        public int Number
        {
            get
            {
                return this.number;
            }
        }

        public ReadOnlyCollection<Node> Children
        {
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(int number, Person person)
        {
            this.number = number;
            this.person = person;
        }

        public void AddChildren(Node n)
        {
            this.children.Add(n);
        }


        public void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

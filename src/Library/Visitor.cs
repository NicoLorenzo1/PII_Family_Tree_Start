namespace Library
{
    public class Visitor
    {
        public int _contador = 0;

        public void Visit(Node nodo)
        {
            this._contador += nodo.person.age;


            foreach (Node node in nodo.Children)
            {
                node.Accept(this);
            }
        }
    }
}
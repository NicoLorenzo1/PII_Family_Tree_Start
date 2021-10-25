namespace Library
{
    public void visitador(Visitor visitor)
    {
        visitor.Visit(this);
    }
}
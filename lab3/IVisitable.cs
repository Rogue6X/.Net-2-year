namespace lab3
{
    public interface IVisitable
    {
        public string Accept(IVisitor visitor);
    }
}
namespace lab3.Races
{
    public class Pegasus:IVisitable
    {
        public string walk()
        {
            return "Pegasus are galloping";
        }

        public string Accept(IVisitor visitor)
        {
            return visitor.VisitPegasus(this);
        }
    }
}
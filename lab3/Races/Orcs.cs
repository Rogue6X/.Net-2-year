namespace lab3.Races
{
    public class Orcs:IVisitable
    {
        public string walk()
        {
            return "Orcs are marching";
        }

        public string Accept(IVisitor visitor)
        {
            return visitor.VisitOrcs(this);
        }
    }
}
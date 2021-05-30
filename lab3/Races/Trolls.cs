namespace lab3.Races
{
    public class Trolls:IVisitable
    {
        public string walk()
        {
            return "Trolls are walking";
        }

        public string Accept(IVisitor visitor)
        {
            return visitor.VisitTrolls(this);
        }
    }
}
namespace lab3.Races
{
    public class Vampires:IVisitable
    {
        public string walk()
        {
            return "Vampires proceed, hiding in the shadows";
        }

        public string Accept(IVisitor visitor)
        {
            return visitor.VisitVampires(this);
        }
    }
}
namespace lab3.Races
{
    public class Harpys:IVisitable
    {
        public string walk()
        {
            return "Harpys can't walk";
        }

        public string Accept(IVisitor visitor)
        {
            return visitor.VisitHarpys(this);
        }
    }
}
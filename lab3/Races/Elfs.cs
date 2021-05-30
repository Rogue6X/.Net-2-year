namespace lab3.Races
{
    public class Elfs:IVisitable
    {
        public string walk()
        {
            return "Elfs are running";
        }

        public string Accept(IVisitor visitor)
        {
            return visitor.VisitElfs(this);
        }
    }
}
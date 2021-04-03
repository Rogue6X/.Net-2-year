namespace lab1.cards
{
    public class Tube:Card
    {
        public double discount { get; set; }
        public double paysum{ get; set; }

        public Tube(double paysum)
            : base(paysum,0.05)
        {

        }
    }
}
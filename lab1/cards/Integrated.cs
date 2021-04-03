namespace lab1.cards
{
    public class Integrated:Card
    {
        public double discount { get; set; }
        public double paysum{ get; set; }

        public Integrated(double paysum)
            : base(paysum,0.15)
        {
        }

    }
}
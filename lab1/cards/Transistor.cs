namespace lab1.cards
{
    public class Transistor : Card
    {
        public double discount { get; set; }
        public double paysum { get; set; }

        public Transistor(double paysum)
            : base(paysum,0.1)
        {

        }
    }
}